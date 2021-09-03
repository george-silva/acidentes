Imports SigmaTT.AcessoPG

Public Class CadastroUsuariosForm

    Private Sub RecarregaUsuariosDatagrid()
        QueryUtilities.RefreshDataGrid(Me.UsuariosDatagrid, "select rolname,groname from pg_group join pg_roles on (oid = any (grolist))", "pg_group")
        'definindo o nome das colunas
        Me.UsuariosDatagrid.Columns(0).HeaderText = "Nome de usuário"
        Me.UsuariosDatagrid.Columns(1).HeaderText = "Nome do grupo de usuários"
        'definindo tamanho das colunas
        Me.UsuariosDatagrid.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        Me.UsuariosDatagrid.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
        'fim do reload
    End Sub

    Private Sub CadastroUsuariosForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim pgdb As New SigmaTT.AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Boolean

        dr = pgdb.returnDatascalar("select rolcreaterole from pg_roles where rolname = " + "'" + LoginForm.UsernameTextBox.Text.ToString + "'" + " limit 1")
        If dr = False Then
            AddUserPanel.Enabled = False
            CreateUserButton.Enabled = False
            DeleteUserButton.Enabled = False
            MessageBox.Show("Você não tem permissão para criar outros usuários.", "Permissão Negada", MessageBoxButtons.OK)
        Else
        End If

        'carrega as informacoes na datagrid
        RecarregaUsuariosDatagrid()

    End Sub

    Private Sub CreateUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateUserButton.Click
        Dim pgdb As New SigmaTT.AcessoPG(CarregaInfo.StringConexao)
        Dim sql As String

        If SuperuserCheckBox.Checked = True Then
            sql = "create user " + UsernameTextBox.Text.ToString + " with password " + "'" + PasswordTextBox.Text.ToString + "'" + "createrole nocreatedb;grant intermediario to " + UsernameTextBox.Text.ToString + ";"
        Else
            sql = "create user " + UsernameTextBox.Text.ToString + " with password " + "'" + PasswordTextBox.Text.ToString + "'" + "nocreaterole nocreatedb;grant usuarios to " + UsernameTextBox.Text.ToString + ";"
        End If
        Try
            pgdb.returnNonQuery(sql)
            MessageBox.Show("Registro de usuário inserido com sucesso.", "Operação Completada")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            PasswordTextBox2.Clear()
            SuperuserCheckBox.Checked = False
        Catch ex As Exception
            MessageBox.Show("Não foi possível realizar a operação de inclusão do usuário. Erro n: " + ex.Message, "Erro")
            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            PasswordTextBox2.Clear()
            SuperuserCheckBox.Checked = False
        End Try

        'recarregando o datagrid
        RecarregaUsuariosDatagrid()
        'fim do reload

    End Sub

    Private Sub FecharCadastroUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FecharCadastroUserButton.Click
        Me.Close()
    End Sub

    Private Sub PasswordTextBox2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PasswordTextBox2.TextChanged
        'define como vermelho o campo de cadastro de senha, caso nao seja igual ao campo 1
        If PasswordTextBox2.Text.Equals(PasswordTextBox.Text) = True Then
            PasswordTextBox2.BackColor = Color.White
        Else
            PasswordTextBox2.BackColor = Color.Red
        End If
    End Sub

    Private Sub DeleteUserButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteUserButton.Click
        If UsuariosDatagrid.SelectedRows.Count <= 0 Then
            MessageBox.Show("Você deve selecionar um usuário para deletar.", "Erro")
            Exit Sub
        Else
            If UsuariosDatagrid.SelectedRows.Count > 1 Then
                MessageBox.Show("Você deve deletar apenas um usuários por vez", "Erro")
                Exit Sub
            Else
                Dim SQL As String
                Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
                Dim dr As Integer

                SQL = "drop role if exists " + UsuariosDatagrid.SelectedRows(0).Cells(0).Value.ToString

                dr = PgDb.returnNonQuery(SQL)
                MessageBox.Show("Usuário deletado com sucesso.", "Operação Completada")

                'reload
                RecarregaUsuariosDatagrid()
                'fim do reload
            End If
        End If
    End Sub

#Region "validacao por error provider"

    Private Sub UsernameTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles UsernameTextBox.Validating
        If UsernameTextBox.Text.Trim().Length = 0 Then
            ErrorProvider1.SetError(UsernameTextBox, "Informe o nome do usuário")
        Else
            ErrorProvider1.SetError(UsernameTextBox, "")
        End If

    End Sub

    Private Sub PasswordTextBox_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If PasswordTextBox.Text.Trim().Length = 0 Then
            ErrorProvider1.SetError(PasswordTextBox, "Informe a senha")
        Else
            ErrorProvider1.SetError(PasswordTextBox, "")
        End If
    End Sub

    Private Sub PasswordTextBox2_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs)
        If PasswordTextBox2.Text.Trim().Length = 0 Then
            ErrorProvider1.SetError(PasswordTextBox2, "Confirme a senha")
        Else
            ErrorProvider1.SetError(PasswordTextBox2, "")
        End If
        If PasswordTextBox2.Text.Trim.Equals(PasswordTextBox2.Text) Then
            ErrorProvider1.SetError(PasswordTextBox2, "")
        Else
            ErrorProvider1.SetError(PasswordTextBox2, " Você deve confirmar a senha. Redigite os valores")
        End If
    End Sub

#End Region
End Class