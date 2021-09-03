Public Class MapaForm
    Public Sub New(ByVal URL As String)

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Dim Html As New System.Uri(URL)
        WebMap.Url = Html
    End Sub
End Class