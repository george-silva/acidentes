Public Class LoginForm

    ' TODO: Insert code to perform custom authentication using the provided username and password 
    ' (See http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' The custom principal can then be attached to the current thread's principal as follows: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' where CustomPrincipal is the IPrincipal implementation used to perform authentication. 
    ' Subsequently, My.User will return identity information encapsulated in the CustomPrincipal object
    ' such as the username, display name, etc.
    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        CarregaInfo.StringConexao = "server=localhost;port=5432;userid=" + UsernameTextBox.Text.ToString + ";password=" + PasswordTextBox.Text.ToString + ";database=dummy;"
        Dim pgdb As New AcessoPG(StringConexao)
        If pgdb.testaconexao = False Then
            PasswordTextBox.Clear()
            PasswordTextBox.Focus()
            CarregaInfo.Autenticado = False
        Else
            CarregaInfo.Autenticado = True
            CarregaInfo.usuario = UsernameTextBox.Text.ToString
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub LoginForm_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        If CarregaInfo.Autenticado = False Then
            MainForm.Close()
        End If
    End Sub

    Private Sub LoginForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Autenticado = False
    End Sub

    Private Sub LogInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogInButton.Click
        CarregaInfo.StringConexao = "server=localhost;port=5432;userid=" + UsernameTextBox.Text.ToString + ";password=" + PasswordTextBox.Text.ToString + ";database=dummy;"
        Dim pgdb As New AcessoPG(StringConexao)
        If pgdb.testaconexao = False Then
            PasswordTextBox.Clear()
            PasswordTextBox.Focus()
            CarregaInfo.Autenticado = False
        Else
            CarregaInfo.Autenticado = True
            CarregaInfo.usuario = UsernameTextBox.Text.ToString
            MainForm.Show()
            Me.Close()
        End If
    End Sub

    Private Sub CloseFormButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CloseFormButton.Click
        Me.Close()
    End Sub
End Class

