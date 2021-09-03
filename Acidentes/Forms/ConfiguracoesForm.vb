Public Class ConfiguracoesForm
    Private Sub SalvarConfiguracoes()
        If Me.ProcuraIntersecoesCheck.Checked = True Then
            My.Settings.CheckIntersections = True
        Else
            My.Settings.CheckIntersections = False
        End If

        If Me.ProcuraIntersecoesWarningCheck.Checked = True Then
            My.Settings.CheckIntersectionsWarning = True
        Else
            My.Settings.CheckIntersectionsWarning = False
        End If

        If Me.AutoCompleteITCheck.Checked = True Then
            My.Settings.AutoCompleteIT = True
        Else
            My.Settings.AutoCompleteIT = False
        End If

        My.Settings.Save()
        MessageBox.Show("As configura��es foram salvas com sucesso.", "Opera��o Completada")
    End Sub
    Private Sub ConfiguracoesForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If My.Settings.CheckIntersections = True Then
            Me.ProcuraIntersecoesCheck.Checked = True
        Else
            Me.ProcuraIntersecoesCheck.Checked = False
        End If
        If My.Settings.CheckIntersectionsWarning = True Then
            Me.ProcuraIntersecoesWarningCheck.Checked = True
        Else
            Me.ProcuraIntersecoesWarningCheck.Checked = False
        End If
        If My.Settings.AutoCompleteIT = True Then
            Me.AutoCompleteITCheck.Checked = True
        Else
            Me.AutoCompleteITCheck.Checked = False
        End If
    End Sub

    Private Sub SalvaConfiguracoesButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SalvaConfiguracoesButton.Click
        SalvarConfiguracoes()
        Me.Close()
    End Sub

    Private Sub SairSemSalvarButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairSemSalvarButton.Click
        If MessageBox.Show("As configura��es n�o foram salvas. Deseja salvar as configura��es e sair?", "Salvar configura��es", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            SalvarConfiguracoes()
            Me.Close()
        Else
            Me.Close()
        End If
    End Sub
End Class