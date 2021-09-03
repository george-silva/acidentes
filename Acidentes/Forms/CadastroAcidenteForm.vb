Imports System.Math
Imports System.Text.RegularExpressions
Imports ESRI.ArcGIS.Controls
Imports SigmaTT.QueryUtilities

Public Class CadastroAcidenteForm

    Private Sub InicializaFormulario(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        AxMap.LoadMxFile("C:\Documents and Settings\Administrador\Desktop\Untitled.mxd")
        ScaleDenominatorLabel.Text = Round(AxMap.MapScale, 0)

        GeradorAcidente.PegaCodAcidente()
        MotorAcidentes.CarregaAcidentes()

    End Sub

    Private Sub CadastrarAcidenteBD(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadastrarAcidenteButton.Click
        If VeiculosDataGrid.Rows.Count < AcidentesDataGrid.Rows(0).Cells("no_veiculos").Value Or CondutoresDataGrid.Rows.Count < AcidentesDataGrid.Rows(0).Cells("no_veiculos").Value Then
            MessageBox.Show("Você deve inserir um número de veículos/condutores correspondente ao indicado na aba acidente.", "Aviso")
            Exit Sub
        Else
            Dim SqlGeral As String
            Dim i As Integer

            i = 0
            'constroi primeiro SQL de acidentes
            SqlGeral = QueryUtilities.BuildQuery(AcidentesDataGrid, "acidentes", 0)

            'constroi SQLs de veiculos
            Do While i <= VeiculosDataGrid.Rows.Count - 1
                SqlGeral = SqlGeral + vbNewLine + QueryUtilities.BuildQuery(VeiculosDataGrid, "veiculos", i) + vbNewLine
                i = i + 1
            Loop

            i = 0

            Do While i <= CondutoresDataGrid.Rows.Count - 1
                SqlGeral = SqlGeral + vbNewLine + QueryUtilities.BuildQuery(CondutoresDataGrid, "condutor", i) + vbNewLine
                i = i + 1
            Loop

            'inseri o mega sql no BD
            QueryUtilities.InsertDB(SqlGeral)

            'deleta as colunas inseridas
            AcidentesDataGrid.Rows.Clear()
            VeiculosDataGrid.Rows.Clear()
            CondutoresDataGrid.Rows.Clear()

            'reinicializa as chaves
            GeradorAcidente.PegaCodAcidente()
            MotorAcidentes.CarregaAcidenteIds(Me.Acidente_CodAcidenteText, Me.Veiculo_CodAcidenteText, Me.Condutor_CodAcidenteText)

            'volta para a pagina de acidentes
            TabControlMaster.SelectedIndex = 0

        End If
    End Sub

    Private Sub BuscaIntersecoes(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NumeroText.Validated
        If My.Settings.CheckIntersections = True Then
            If NumeroText.Text.Length <= 0 Then
                Exit Sub
            Else
                GeradorAcidente.PegaIntersecoes(NumeroText.Text, Me.NomeLogradouroCombo.SelectedItem.ToString, Intersecao1Combo, Intersecao2Combo)
            End If
        Else
            Exit Sub
        End If
    End Sub

#Region "Inserir GRIDS"

    Private Sub InserirAcidenteGRID(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserirAcidenteButton.Click
        Dim i As Integer
        i = AcidentesDataGrid.Rows.Count
        If i < 1 Then
            'inserir na grid
            GeradorAcidente.PegaTudo()
            GeradorAcidente.InserirGrid(AcidentesDataGrid)
            MotorAcidentes.LimpaAcidenteForm()
            'fim inserir na grid

            'carrega veiculos
            GeradorVeiculo.PegaCodVeiculo()
            MotorVeiculos.CarregaVeiculoID(Me.Veiculo_CodVeiculoText)
            MotorVeiculos.CarregaVeiculoID(Me.Condutor_CodVeiculoText)
            MotorVeiculos.CarregaVeiculos()
            'fim carrega veiculos

            'mudar a tabpage para veículos
            TabControlMaster.SelectedIndex = 1

        Else
            'nao inserir
            MessageBox.Show("Só é possível cadastrar um acidente por vez.", "Aviso")
        End If
    End Sub

    Private Sub InserirVeiculoGRID(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserirVeiculoButton.Click
        If Me.AcidentesDataGrid.Rows.Count = 0 Then
            MessageBox.Show("Você precisa inserir as informações relativas ao acidente primeiro.", "Aviso")
            Exit Sub
        Else
            Dim i As Integer
            i = Me.AcidentesDataGrid.Rows(0).Cells("no_veiculos").Value
            If VeiculosDataGrid.Rows.Count < i Then
                'inserir na grid
                GeradorVeiculo.PegaTudo()
                GeradorVeiculo.InserirGrid(VeiculosDataGrid)
                MotorVeiculos.LimpaVeiculoForm()
                'fim inserir na grid

                'carregar condutores
                GeradorCondutor.PegaCodCondutor()
                MotorCondutores.CarregaCondutorID(Me.Condutor_CodCondutorText)
                MotorCondutores.CarregaCondutores()
                'fim carregar condutores

                'mudar a tabpage para condutor
                TabControlMaster.SelectedIndex = 2

            Else
                'nao inserir
                MessageBox.Show("Não é possível inserir mais veículos do que declarado no campo Número de Veículos Envolvidos.", "Aviso")
            End If
        End If
    End Sub

    Private Sub InserirCondutorGRID(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles InserirCondutorButton.Click
        If Me.AcidentesDataGrid.Rows.Count = 0 Then
            MessageBox.Show("Você precisa inserir as informações relativas ao acidente e ao veículo primeiro.", "Aviso")
            Exit Sub
        Else
            Dim i As Integer
            i = Me.AcidentesDataGrid.Rows(0).Cells("no_veiculos").Value
            If CondutoresDataGrid.Rows.Count < i Then
                'inserir na grid
                GeradorCondutor.PegaTudo()
                GeradorCondutor.InserirGrid(CondutoresDataGrid)
                MotorCondutores.LimpaCondutorForm()
                'fim inserir grid

                'carregar veiculo novamente
                GeradorVeiculo.PegaCodVeiculo()
                'preenche novamente a chave estrangeira de acidentes
                MotorAcidentes.CarregaAcidenteID(Me.Veiculo_CodAcidenteText)
                MotorAcidentes.CarregaAcidenteID(Me.Condutor_CodAcidenteText)
                'preenche novamente a chave estrangeira de veiculos
                MotorVeiculos.CarregaVeiculoID(Me.Veiculo_CodVeiculoText)
                MotorVeiculos.CarregaVeiculoID(Me.Condutor_CodVeiculoText)

                'mudar tabpage
                If CondutoresDataGrid.Rows.Count = i Then
                    TabControlMaster.SelectedIndex = 0 'terminou de inserir tudo
                    MessageBox.Show("Todas as informações sobre o acidente " + _
                    Me.AcidentesDataGrid.Rows(0).Cells("cod_acidente").Value.ToString + " foram inseridas." + _
                    vbNewLine + _
                    "Insira os registros no banco de dados clicando no botão de adicionar no canto superior direito.", "Aviso")
                    'volta p pagina acidentes
                Else
                    TabControlMaster.SelectedIndex = 1
                    'ainda nao, volta para veiculos
                End If
            Else
                MessageBox.Show("Não é possível inserir mais condutores do que declarado no campo Número de Veículos Envolvidos.", "Aviso")
            End If
            End If
    End Sub

#End Region

#Region "ArcGIS Functions"
    Private Sub PanLeftButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanLeftButton.Click
        ArcGisModule.FixedPan(AxMap, -250, 0)
    End Sub

    Private Sub PanRightButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanRightButton.Click
        ArcGisModule.FixedPan(AxMap, 250, 0)
    End Sub

    Private Sub PanUpButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanUpButton.Click
        ArcGisModule.FixedPan(AxMap, 0, 250)
    End Sub

    Private Sub PanDownButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PanDownButton.Click
        ArcGisModule.FixedPan(AxMap, 0, -250)
    End Sub

    Private Sub ZoomInButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomInButton.Click
        ArcGisModule.FixedZoom(AxMap, 0.5)
    End Sub

    Private Sub ZoomOutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ZoomOutButton.Click
        ArcGisModule.FixedZoom(AxMap, 1.5)
    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        ArcGisModule.FindFeatures(0, "NOME_LOGRA", Me.LogSearchText.Text)
    End Sub

    Private Sub DisplayResults_NodeMouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles DisplayResults.NodeMouseDoubleClick
        ArcGisModule.ZoomFeature(Int64.Parse(DisplayResults.SelectedNode.Name), 0, 2500)
    End Sub
    Private Sub AxMap_OnViewRefreshed(ByVal sender As System.Object, ByVal e As ESRI.ArcGIS.Controls.IMapControlEvents2_OnViewRefreshedEvent) Handles AxMap.OnViewRefreshed
        ScaleDenominatorLabel.Text = Round(AxMap.MapScale, 0)
    End Sub
#End Region


#Region "Validação Acidente"

    Private Sub NoBoText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Acidente_NoBoText.Validating
        If Acidente_NoBoText.Text.Trim.Length = 0 Then
            ProvedorErros.SetError(Acidente_NoBoText, "Informe o número do boletim de ocorrência.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Acidente_NoBoText, "")
        End If
    End Sub

    Private Sub DataText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Acidente_DataText.Validating
        If Acidente_DataText.MaskCompleted = False Then
            ProvedorErros.SetError(Acidente_DataText, "Infome a data do acidente.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Acidente_DataText, "")
        End If
    End Sub

    Private Sub HoraText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Acidente_HoraText.Validating
        If Acidente_HoraText.MaskCompleted = False Then
            ProvedorErros.SetError(Acidente_HoraText, "Informe a hora do acidente.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Acidente_HoraText, "")
        End If
    End Sub

    Private Sub BairroCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles BairroCombo.Validating
        If BairroCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(BairroCombo, "Informe o bairro.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(BairroCombo, "")
        End If
    End Sub

    Private Sub TipoLogradouroCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TipoLogradouroCombo.Validating
        If TipoLogradouroCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(TipoLogradouroCombo, "Informe o tipo do logradouro.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(TipoLogradouroCombo, "")
            'adicionar a liberacao do query do nome de logradouros
        End If
    End Sub

    Private Sub NomeLogradouroCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NomeLogradouroCombo.Validating
        If NomeLogradouroCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(NomeLogradouroCombo, "Informe o nome do logradouro.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(NomeLogradouroCombo, "")
        End If
    End Sub

    Private Sub CaracteristicaAcidenteCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CaracteristicaAcidenteCombo.Validating
        If CaracteristicaAcidenteCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(CaracteristicaAcidenteCombo, "Informe a característica do acidente.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(CaracteristicaAcidenteCombo, "")
        End If
    End Sub

    Private Sub CausaAcidenteCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CausaAcidenteCombo.Validating
        If CausaAcidenteCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(CausaAcidenteCombo, "Informe a causa do acidente.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(CausaAcidenteCombo, "")
        End If
    End Sub

    Private Sub TipoAcidenteCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TipoAcidenteCombo.Validating
        If TipoAcidenteCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(TipoAcidenteCombo, "Informe o tipo do acidente.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(TipoAcidenteCombo, "")
        End If
    End Sub

    Private Sub CaracteristicaViaCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CaracteristicaViaCombo.Validating
        If CaracteristicaViaCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(CaracteristicaViaCombo, "Informe a característica da via.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(CaracteristicaViaCombo, "")
        End If
    End Sub

    Private Sub CondicaoViaCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles CondicaoViaCombo.Validating
        If CondicaoViaCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(CondicaoViaCombo, "Informe a condição da via.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(CondicaoViaCombo, "")
        End If
    End Sub

    Private Sub TipoPavimentacaoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TipoPavimentacaoCombo.Validating
        If TipoPavimentacaoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(TipoPavimentacaoCombo, "Informe o tipo de pavimentação.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(TipoPavimentacaoCombo, "")
        End If
    End Sub

    Private Sub OrgaoResponsavelCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles OrgaoResponsavelCombo.Validating
        If OrgaoResponsavelCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(OrgaoResponsavelCombo, "Informe o órgão responsável.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(OrgaoResponsavelCombo, "")
        End If
    End Sub

    Private Sub TipoSocorroCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TipoSocorroCombo.Validating
        If TipoSocorroCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(TipoSocorroCombo, "Informe o tipo de socorro prestado.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(TipoSocorroCombo, "")
        End If
    End Sub

    Private Sub ControleTrafegoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ControleTrafegoCombo.Validating
        If ControleTrafegoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(ControleTrafegoCombo, "Informe o tipo de controle de tráfego.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(ControleTrafegoCombo, "")
        End If
    End Sub

    Private Sub ClimaCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ClimaCombo.Validating
        If ClimaCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(ClimaCombo, "Informe o tipo de clima.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(ClimaCombo, "")
        End If
    End Sub

    Private Sub Intersecao1Combo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Intersecao1Combo.Validating
        If Intersecao1Combo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Intersecao1Combo, "Informe o nome da interseção anterior, caso esta informação esteja disponível.")
        Else
            ProvedorErros.SetError(Intersecao1Combo, "")
        End If
    End Sub

    Private Sub NomeLogradouroCombo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomeLogradouroCombo.Validated
        If NomeLogradouroCombo.SelectedIndex < 0 Then
        Else
            MotorAcidentes.carregaInter1()
        End If
    End Sub

    Private Sub Intersecao1Combo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Intersecao1Combo.Validated
        If Intersecao1Combo.SelectedIndex < 0 Then
        Else
            MotorAcidentes.LimpaIntersecao2()
            MotorAcidentes.carregaInter2()
            Me.Intersecao2Combo.Enabled = True
        End If
    End Sub

    Private Sub TipoLogradouroCombo_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TipoLogradouroCombo.Validated
        If TipoLogradouroCombo.SelectedIndex < 0 Then
        Else
            MotorAcidentes.CarregaNomeLog()
        End If
    End Sub

    Private Sub NumeroText_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NumeroText.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = vbBack Then
            e.Handled = True
        End If
    End Sub

    Private Sub NumeroText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles NumeroText.Validating
        If NumeroText.Text.Length = 0 Then
            ProvedorErros.SetError(NumeroText, "Informe o número viário correspondente, caso exista.")
        Else
            ProvedorErros.SetError(NumeroText, "")
        End If
    End Sub
#End Region

#Region "Validacao Veículos"

    Private Sub Veiculo_TipoVeiculoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Veiculo_TipoVeiculoCombo.Validating
        If Veiculo_TipoVeiculoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Veiculo_TipoVeiculoCombo, "Infome o tipo do veículo.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Veiculo_TipoVeiculoCombo, "")
            'anula o erro
            'testa se o tipo de veiculo é pedestre ou bicicleta
            'e automaticamente preenche equipseguranca e placa
            If Veiculo_TipoVeiculoCombo.SelectedItem.ToString = "PEDESTRE" Or Veiculo_TipoVeiculoCombo.SelectedItem.ToString = "BICICLETA" Then
                Veiculo_EquipSegurancaCombo.SelectedItem = "NÃO NECESSITA"
                Veiculo_PlacaVeiculoText.Text = "AAA-0000"
            Else
                Exit Sub
            End If
        End If
    End Sub

    Private Sub Veiculo_EquipSegurancaCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Veiculo_EquipSegurancaCombo.Validating
        If Veiculo_EquipSegurancaCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Veiculo_EquipSegurancaCombo, "Informe o equipamento de segurança.")
        Else
            ProvedorErros.SetError(Veiculo_EquipSegurancaCombo, "")
        End If
    End Sub

    Private Sub Veiculo_PlacaVeiculoText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Veiculo_PlacaVeiculoText.Validating
        If Veiculo_PlacaVeiculoText.MaskCompleted = False Then
            ProvedorErros.SetError(Veiculo_PlacaVeiculoText, "Informe a placa do veículo. Caso o veículo não tenha placa utilize o valor AAA-0000.")
        Else
            ProvedorErros.SetError(Veiculo_PlacaVeiculoText, "")
        End If
    End Sub

    Private Sub Veiculo_ApreendidoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Veiculo_ApreendidoCombo.Validating
        If Veiculo_ApreendidoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Veiculo_ApreendidoCombo, "Informe a situação do veículo.")
        Else
            ProvedorErros.SetError(Veiculo_ApreendidoCombo, "")
        End If
    End Sub

    Private Sub Veiculo_SentidoVeiculoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Veiculo_SentidoVeiculoCombo.Validating
        If Veiculo_SentidoVeiculoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Veiculo_SentidoVeiculoCombo, "Informe o sentido do veículo.")
        Else
            ProvedorErros.SetError(Veiculo_SentidoVeiculoCombo, "")
        End If
    End Sub
#End Region

#Region "Validacao Condutores"
    Private Sub Condutor_EstadoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_EstadoCombo.Validating
        If Condutor_EstadoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Condutor_EstadoCombo, "Informe o estado da federação.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_EstadoCombo, "")
        End If
    End Sub

    Private Sub Condutor_CidadeCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_CidadeCombo.Validating
        If Condutor_CidadeCombo.SelectedText < 0 Then
            ProvedorErros.SetError(Condutor_CidadeCombo, "Informe a cidade.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_CidadeCombo, "")
        End If
    End Sub

    Private Sub Condutor_HabilitacaoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_HabilitacaoCombo.Validating
        If Condutor_HabilitacaoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Condutor_HabilitacaoCombo, "Informe a situação da habilitação.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_HabilitacaoCombo, "")
        End If
    End Sub

    Private Sub Condutor_DataHabilitacaoText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_DataHabilitacaoText.Validating
        If Condutor_DataHabilitacaoText.MaskCompleted = False Then
            ProvedorErros.SetError(Condutor_DataHabilitacaoText, "Informe a data da habilitação")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_DataHabilitacaoText, "")
        End If
    End Sub

    Private Sub Condutor_EscolaridadeCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_EscolaridadeCombo.Validating
        If Condutor_EscolaridadeCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Condutor_EscolaridadeCombo, "Informe a escolaridade do condutor.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_EscolaridadeCombo, "")
        End If
    End Sub

    Private Sub Condutor_ProfissaoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_ProfissaoCombo.Validating
        If Condutor_ProfissaoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Condutor_ProfissaoCombo, "Informe a profissão do condutor.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_ProfissaoCombo, "")
        End If
    End Sub

    Private Sub Condutor_ComportamentoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_ComportamentoCombo.Validating
        If Condutor_ComportamentoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Condutor_ComportamentoCombo, "Informe o comportamento do condutor.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_ComportamentoCombo, "")
        End If
    End Sub

    Private Sub Condutor_CondicaoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_CondicaoCombo.Validating
        If Condutor_CondicaoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Condutor_CondicaoCombo, "Informe a condição física do condutor.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_CondicaoCombo, "")
        End If
    End Sub

    Private Sub Condutor_DataNascimentoText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_DataNascimentoText.Validating
        If Condutor_DataNascimentoText.MaskCompleted = False Then
            ProvedorErros.SetError(Condutor_DataNascimentoText, "Informe a data de nascimento do condutor.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_DataNascimentoText, "")
        End If
    End Sub

    Private Sub Condutor_SexoCombo_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_SexoCombo.Validating
        If Condutor_SexoCombo.SelectedIndex < 0 Then
            ProvedorErros.SetError(Condutor_SexoCombo, "Informe o sexo do conduutor.")
            e.Cancel = True
        Else
            ProvedorErros.SetError(Condutor_SexoCombo, "")
        End If
    End Sub

    Private Sub Condutor_ProntuarioText_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles Condutor_ProntuarioText.Validating
        If Condutor_ProntuarioText.Text.Length <= 0 Then
            ProvedorErros.SetError(Condutor_ProntuarioText, "Informe o prontuário relativo ao condutor, caso exista.")
        Else
            ProvedorErros.SetError(Condutor_ProntuarioText, "")
        End If
    End Sub
#End Region


    Private Sub ResetAcidente_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetAcidente.Click
        If MessageBox.Show("Tem certeza que deseja deletar este acidente sem inseri-lo?", "Aviso", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then

            Utilidades.ClearForm()
            AcidentesDataGrid.Rows.Clear()
            VeiculosDataGrid.Rows.Clear()
            CondutoresDataGrid.Rows.Clear()
        Else
            Exit Sub
        End If
    End Sub

    Private Sub NomeLogradouroCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NomeLogradouroCombo.SelectedIndexChanged
        MotorAcidentes.LimpaIntersecoes()
    End Sub
End Class
