Public Class GeradorAleatorioAcidentes

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim high As Integer
        Dim low As Integer
        Dim result As Integer
        high = TextBox1.Text
        low = TextBox2.Text
        result = GeradorModule.my_random(low, high)
        MessageBox.Show(result.ToString)
    End Sub
End Class