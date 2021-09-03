Public Class CadastroVariaveisSistemaForm
    Private RefreshSQL As String
    Private Tabela As String
    Private ApelidoTabela As String

    Public Sub New(ByVal SQL As String, ByVal Tabela As String, ByVal apelido As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.RefreshSQL = SQL
        'sql usado para carrega o datagrid
        Me.Tabela = Tabela
        'nome da tabela sendo consultada
        Me.ApelidoTabela = apelido
        'apelido usado no preenchimento do label

    End Sub

    Private Sub CadastroVariaveisSistemaForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '(re)carregue as informacoes no datagrid
        'de acordo com os valores passados no momento de criacao
        'new(refreshsql,tabela,apelido)
        QueryUtilities.RefreshDataGrid(DataGridView1, RefreshSQL, Tabela)
        'recarregue
        Me.VariavelNomeLabel.Text = ApelidoTabela
        'defina o label
        DataGridView1.Columns(0).AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader
        'defina a largura da coluna 0-codigo
        DataGridView1.Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCellsExceptHeader
        'defina a largura da coluna 1-descricao

        'teste para ver se o usuario tem permissao para criar novas variaveis
        Dim pgdb As New SigmaTT.AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Boolean

        dr = pgdb.returnDatascalar("select rolcreaterole from pg_roles where rolname = " + "'" + LoginForm.UsernameTextBox.Text.ToString + "'" + " limit 1")
        If dr = False Then
            Me.CodigoText.Enabled = False
            Me.DescText.Enabled = False
            Me.InserirVariavelButton.Enabled = False
            MessageBox.Show("Você não tem permissão para inserir outras variáveis.", "Erro", MessageBoxButtons.OK)
        Else
        End If
        'fim teste permissao
    End Sub

    Private Sub CodigoText_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CodigoText.KeyPress
        'apenas numeros no campo codigotext
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub InserirVariavelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserirVariavelButton.Click
        'testa se os valores nao tem tamanho 0
        If Me.CodigoText.Text.Length <= 0 Or Me.DescText.Text.Length <= 0 Then
            'caso um dos dois nao tenha sido preenchido
            'gere um erro e saia da funcao
            MessageBox.Show("Você precisa preencher os campos código e descrição para adicionar uma nova variável.", "Erro")
            Exit Sub
        Else
            'caso tenham sido preenchidos
            Dim sql As String
            Dim colunaA As String
            Dim colunaB As String
            'pegue o nome das colunas
            colunaA = QueryUtilities.ReturnColumns(DataGridView1, 0)
            colunaB = QueryUtilities.ReturnColumns(DataGridView1, 1)
            'gere o sql
            sql = "insert into " + Tabela + "(" + colunaA + "," + colunaB + ") values(" + Me.CodigoText.Text + "," + "'" + Me.DescText.Text + "')"
            'insira no banco de dados
            QueryUtilities.InsertDB(sql)
            'recarregue as informacoes do datagrid
            QueryUtilities.RefreshDataGrid(DataGridView1, RefreshSQL, Tabela)
        End If
    End Sub

    Private Sub FinalizaEdicaoButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FinalizaEdicaoButton.Click
        Me.Close()
    End Sub
#Region "validacao com error provider"
    Private Sub CodigoText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CodigoText.Validating
        If CodigoText.Text.Length <= 0 Then
            ProvedorErros.SetError(CodigoText, "Você deve preencher o valor do código para cada atributo")
            e.Cancel = True
        Else
            ProvedorErros.SetError(CodigoText, "")
        End If
    End Sub

    Private Sub DescText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles DescText.Validating
        If DescText.Text.Length <= 0 Then
            ProvedorErros.SetError(DescText, "Você deve preencher o valor da descrição para cada atributo")
            e.Cancel = True
        Else
            ProvedorErros.SetError(DescText, "")
        End If
    End Sub
#End Region

End Class