Public Class MainForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CadastroAcidenteForm.ShowDialog()
    End Sub

    Private Sub UsuárioToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsuárioToolStripMenuItem.Click
        Dim CadastroForm As New CadastroUsuariosForm
        CadastroForm.ShowDialog()
    End Sub

    Private Sub MainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoginForm.ShowDialog()
        Dim i As Integer
        If CarregaInfo.Autenticado = False Then
            Me.Close()
        Else
            StatusUsuario.Text = "Usuário: " + CarregaInfo.usuario.ToString
            StatusConectado.Text = "Conectado desde: " + Now().ToString
            GrupoUserLabel.Text = "Nível de Usuário: " + Utilidades.GetUserGroup
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

#Region "abertura de formulários - variaveis de sistema:condutores"

    Private Sub CondiçãoFísicaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CondiçãoFísicaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_condicao order by cod_condicao", "aux_cond_condicao", "Condição do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ComportamentoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComportamentoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_comportamento order by cod_comportamento", "aux_cond_comportamento", "Comportamento do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ProfissãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProfissãoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_profissao order by cod_profissao", "aux_cond_profissao", "Profissão do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub EscolaridadeToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EscolaridadeToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_cond_escolaridade order by cod_escolaridade", "aux_cond_escolaridade", "Escolaridade do Condutor")
        CadastroVariavelForm.ShowDialog()
    End Sub

#End Region

#Region "abertura de formulários - variaveis de sistema: acidente"
    Private Sub BairroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BairroToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_bairros order by cod_bairro", "aux_bairros", "Bairro")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub CaracterísticaDeAcidenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaracterísticaDeAcidenteToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_caracteristica order by cod_caracteristica", "aux_acid_caracteristica", "Característica do Acidente")
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

    Private Sub CaracterísticaDeViaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CaracterísticaDeViaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_caracteristicavia order by cod_caracteristica", "aux_acid_caracteristicavia", "Característica da Via")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub CondiçãoDeViaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CondiçãoDeViaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_condicaovia order by cod_condicao", "aux_acid_condicaovia", "Condição da Via")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub TipoDePavimentaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDePavimentaçãoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_pavimentacao order by cod_pavimentacao", "aux_acid_pavimentacao", "Tipo de Pavimentação")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub TipoDeSocorroToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeSocorroToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_socorro order by cod_socorro", "aux_acid_socorro", "Tipo de Socorro")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ÓrgãoResponsávelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÓrgãoResponsávelToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_orgaoresp order by cod_orgao", "aux_acid_orgaoresp", "Órgão Responsável")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ControleDeTráfegoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ControleDeTráfegoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_controletrafego order by cod_controle", "aux_acid_controletrafego", "Controle de Tráfego")
        CadastroVariavelForm.ShowDialog()
    End Sub

    Private Sub ClimaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClimaToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_acid_clima order by cod_clima", "aux_acid_clima", "Clima")
        CadastroVariavelForm.ShowDialog()
    End Sub

#End Region

#Region "abertura de formularios-variaveis de sistema:veiculos"
    Private Sub TipoDeVeículoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoDeVeículoToolStripMenuItem.Click
        Dim CadastroVariavelForm As New CadastroVariaveisSistemaForm("select * from aux_veic_tipo order by cod_tipo", "aux_veic_tipo", "Tipo de Veículo")
        CadastroVariavelForm.ShowDialog()
    End Sub
#End Region

    Private Sub ConfiguraçõesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ConfiguraçõesToolStripMenuItem.Click
        Dim ConfigForm As New ConfiguracoesForm
        ConfigForm.ShowDialog()
    End Sub

    Private Sub TerminalInterativoVersão01ToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TerminalInterativoVersão01ToolStripMenuItem.Click
        Dim TerminalInterativoForm As New TerminalInterativoForm
        TerminalInterativoForm.ShowDialog()
    End Sub

    Private Sub PorLocalizaçãoToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorLocalizaçãoToolStripMenuItem.Click

    End Sub

    Private Sub PorCaracterísticaDoAcidenteToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PorCaracterísticaDoAcidenteToolStripMenuItem.Click
        Dim MapForm As New MapaForm("http://localhost/teste.html")
        MapForm.ShowDialog()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        GeradorAleatorioAcidentes.ShowDialog()
    End Sub
End Class
