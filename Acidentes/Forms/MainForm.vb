Public Class MainForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CadastroAcidenteForm.ShowDialog()
    End Sub

    Private Sub Usu�rioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usu�rioToolStripMenuItem.Click
        Dim CadastroForm As New CadastroUsuariosForm
        CadastroForm.ShowDialog()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm.ShowDialog()
        Dim i As Integer
        If CarregaInfo.Autenticado = False Then
            Me.Close()
        Else
            StatusUsuario.Text = "Usu�rio: " + CarregaInfo.usuario.ToString
            StatusConectado.Text = "Conectado desde: " + Now().ToString
            GrupoUserLabel.Text = "N�vel de Usu�rio: " + Utilidades.GetUserGroup
        End If
        QueryUtilities.RefreshDataGrid(Me.EstatisticasDataGrid, "select * from view_estatisticas_gerais", "estatisticas")
        QueryUtilities.RefreshDataGrid(Me.SeveridadeDataGrid, "select * from view_estatisticas_severidade", "severidade")
        i = 0
        Do While i <= EstatisticasDataGrid.Columns.Count - 1
            EstatisticasDataGrid.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            i = i + 1
        Loop
        i = 0
        Do While i <= SeveridadeDataGrid.Columns.Count - 1
            SeveridadeDataGrid.Columns(i).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            i = i + 1
        Loop
    End Sub
    Private Sub AbrirSobreForm(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SobreSigmaTTToolStripMenuItem.Click
        SobreForm.ShowDialog()
    End Sub

#Region "abertura de formul�rios - variaveis de sistema:condutores"

    Private Sub Condi��oF�sicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Condi��oF�sicaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_condicao order by cod_condicao", "aux_cond_condicao", "Condi��o do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ComportamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComportamentoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_comportamento order by cod_comportamento", "aux_cond_comportamento", "Comportamento do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub Profiss�oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Profiss�oToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_profissao order by cod_profissao", "aux_cond_profissao", "Profiss�o do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub EscolaridadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscolaridadeToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_escolaridade order by cod_escolaridade", "aux_cond_escolaridade", "Escolaridade do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

#End Region

#Region "abertura de formul�rios - variaveis de sistema: acidente"
    Private Sub BairroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BairroToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_bairros order by cod_bairro", "aux_bairros", "Bairro")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub Caracter�sticaDeAcidenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caracter�sticaDeAcidenteToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_caracteristica order by cod_caracteristica", "aux_acid_caracteristica", "Caracter�stica do Acidente")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub CausaDeAcidenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CausaDeAcidenteToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_causa order by cod_causa", "aux_acid_causa", "Causa do Acidente")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub TipoDeAcidenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeAcidenteToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_tipo order by cod_tipo", "aux_acid_tipo", "Tipo do Acidente")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SairToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub Caracter�sticaDeViaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Caracter�sticaDeViaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_caracteristicavia order by cod_caracteristica", "aux_acid_caracteristicavia", "Caracter�stica da Via")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub Condi��oDeViaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Condi��oDeViaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_condicaovia order by cod_condicao", "aux_acid_condicaovia", "Condi��o da Via")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub TipoDePavimenta��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDePavimenta��oToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_pavimentacao order by cod_pavimentacao", "aux_acid_pavimentacao", "Tipo de Pavimenta��o")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub TipoDeSocorroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeSocorroToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_socorro order by cod_socorro", "aux_acid_socorro", "Tipo de Socorro")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub �rg�oRespons�velToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles �rg�oRespons�velToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_orgaoresp order by cod_orgao", "aux_acid_orgaoresp", "�rg�o Respons�vel")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ControleDeTr�fegoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControleDeTr�fegoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_controletrafego order by cod_controle", "aux_acid_controletrafego", "Controle de Tr�fego")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ClimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClimaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_clima order by cod_clima", "aux_acid_clima", "Clima")
        CadastroVariavelForm.ShowDialog()
    End Sub

#End Region

#Region "abertura de formularios-variaveis de sistema:veiculos"
    Private Sub TipoDeVe�culoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeVe�culoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_veic_tipo order by cod_tipo", "aux_veic_tipo", "Tipo de Ve�culo")
        CadastroVariavelForm.ShowDialog()
    End Sub
#End Region

    Private Sub Configura��esToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Configura��esToolStripMenuItem.Click
        Dim ConfigForm As New ConfiguracoesForm
        ConfigForm.ShowDialog()
    End Sub

    Private Sub TerminalInterativoVers�o01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminalInterativoVers�o01ToolStripMenuItem.Click
        Dim TerminalInterativoForm As New TerminalInterativoForm
        TerminalInterativoForm.ShowDialog()
    End Sub

    Private Sub PorLocaliza��oToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorLocaliza��oToolStripMenuItem.Click

    End Sub

    Private Sub PorCaracter�sticaDoAcidenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorCaracter�sticaDoAcidenteToolStripMenuItem.Click
        Dim MapForm As New MapaForm("http://localhost/teste.html")
        MapForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GeradorAleatorioAcidentes.ShowDialog()
    End Sub
End Class
