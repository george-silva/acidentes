Module MotorAcidentes
    Private AcidentesInfoLoaded As Boolean
#Region "funcoes privadas"
    Private Sub CarregaCombo(ByVal SQL As String, ByVal Alvo As ComboBox, ByVal Coluna As Integer)
        'funcao especifica para preencher um combo box com a coluna 1 de determinada tabela
        'index 0-based
        'ideal para carregar informacoes textuais de tabelas auxiliares
        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Dim Dr As Npgsql.NpgsqlDataReader
        Try
            Dr = PgDb.returnDatareader(Sql)
            Do While Dr.Read
                Alvo.Items.Add(Dr(Coluna))
            Loop
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar as informações solicitadas. " + vbNewLine + ex.Message, "Erro")
        End Try
    End Sub

    Private Sub ClearCombo(ByVal Alvo As ComboBox)
        Alvo.SelectedIndex = -1
        Alvo.Text = ""
    End Sub
    Private Sub ClearTextBox(ByVal Alvo As TextBoxBase)
        Alvo.Clear()
    End Sub
    Private Sub ClearNumeric(ByVal Alvo As NumericUpDown, ByVal valor As Integer)
        Alvo.Value = valor
    End Sub
#End Region
    Public Sub CarregaAcidenteID(ByVal Alvo As TextBoxBase)
        Alvo.Clear()
        Alvo.Text = GeradorAcidente.CodAcidente
    End Sub
    Public Sub CarregaBairros()
        CarregaCombo("select desc_bairro from aux_bairros", CadastroAcidenteForm.BairroCombo, 0)
    End Sub
    Public Sub CarregaTipolog()
        CarregaCombo("select desc_tipolog from aux_tipo_logradouro", CadastroAcidenteForm.TipoLogradouroCombo, 0)
    End Sub
    Public Sub CarregaNomeLog()
        CarregaCombo("select desc_logradouro from aux_enderecos where tipo_logradouro=" + "'" + CadastroAcidenteForm.TipoLogradouroCombo.SelectedItem.ToString + "'", CadastroAcidenteForm.NomeLogradouroCombo, 0)
    End Sub
    Public Sub carregaInter1()
        CarregaCombo("select prefixo_direcao from logradouros where tipo_logradouro=" + "'" + CadastroAcidenteForm.TipoLogradouroCombo.SelectedItem.ToString + "' and " + "nome_logradouro = " + " '" + CadastroAcidenteForm.NomeLogradouroCombo.Text.ToString + "'", CadastroAcidenteForm.Intersecao1Combo, 0)
    End Sub
    Public Sub carregaInter2()
        ClearCombo(CadastroAcidenteForm.Intersecao2Combo)
        CarregaCombo("select sufixo_direcao from logradouros where tipo_logradouro = " + "'" + CadastroAcidenteForm.TipoLogradouroCombo.SelectedItem.ToString + "' AND nome_logradouro = " + " '" + CadastroAcidenteForm.NomeLogradouroCombo.Text.ToString + "'", CadastroAcidenteForm.Intersecao2Combo, 0)
    End Sub
    Public Sub CarregaAcidentes()
        If AcidentesInfoLoaded = True Then
            Exit Sub
        Else

            CarregaAcidenteID(CadastroAcidenteForm.Acidente_CodAcidenteText)
            CarregaAcidenteID(CadastroAcidenteForm.Veiculo_CodAcidenteText)
            CarregaAcidenteID(CadastroAcidenteForm.Condutor_CodAcidenteText)
            CarregaCombo("select desc_bairro from aux_bairros", CadastroAcidenteForm.BairroCombo, 0)
            CarregaCombo("select desc_tipolog from aux_tipo_logradouro", CadastroAcidenteForm.TipoLogradouroCombo, 0)
            CarregaCombo("select desc_caracteristica from aux_acid_caracteristica", CadastroAcidenteForm.CaracteristicaAcidenteCombo, 0)
            CarregaCombo("select desc_caracteristica from aux_acid_caracteristicavia", CadastroAcidenteForm.CaracteristicaViaCombo, 0)
            CarregaCombo("select desc_causa from aux_acid_causa", CadastroAcidenteForm.CausaAcidenteCombo, 0)
            CarregaCombo("select desc_clima from aux_acid_clima", CadastroAcidenteForm.ClimaCombo, 0)
            CarregaCombo("select desc_condicao from aux_acid_condicaovia", CadastroAcidenteForm.CondicaoViaCombo, 0)
            CarregaCombo("select desc_controle from aux_acid_controletrafego", CadastroAcidenteForm.ControleTrafegoCombo, 0)
            CarregaCombo("select desc_orgao from aux_acid_orgaoresp", CadastroAcidenteForm.OrgaoResponsavelCombo, 0)
            CarregaCombo("select desc_socorro from aux_acid_socorro", CadastroAcidenteForm.TipoSocorroCombo, 0)
            CarregaCombo("select desc_pavimentacao from aux_acid_pavimentacao", CadastroAcidenteForm.TipoPavimentacaoCombo, 0)
            CarregaCombo("select desc_tipo from aux_acid_tipo", CadastroAcidenteForm.TipoAcidenteCombo, 0)
            AcidentesInfoLoaded = True
        End If
    End Sub
    Public Sub LimpaAcidenteForm()
        ClearCombo(CadastroAcidenteForm.BairroCombo)
        ClearCombo(CadastroAcidenteForm.TipoLogradouroCombo)
        ClearCombo(CadastroAcidenteForm.CaracteristicaAcidenteCombo)
        ClearCombo(CadastroAcidenteForm.CausaAcidenteCombo)
        ClearCombo(CadastroAcidenteForm.ClimaCombo)
        ClearCombo(CadastroAcidenteForm.CondicaoViaCombo)
        ClearCombo(CadastroAcidenteForm.ControleTrafegoCombo)
        ClearCombo(CadastroAcidenteForm.OrgaoResponsavelCombo)
        ClearCombo(CadastroAcidenteForm.TipoSocorroCombo)
        ClearCombo(CadastroAcidenteForm.TipoPavimentacaoCombo)
        ClearCombo(CadastroAcidenteForm.TipoAcidenteCombo)
        ClearCombo(CadastroAcidenteForm.NomeLogradouroCombo)
        ClearCombo(CadastroAcidenteForm.Intersecao1Combo)
        ClearCombo(CadastroAcidenteForm.Intersecao2Combo)
        ClearCombo(CadastroAcidenteForm.CaracteristicaViaCombo)
        ClearTextBox(CadastroAcidenteForm.NumeroText)
        ClearTextBox(CadastroAcidenteForm.Acidente_CodAcidenteText)
        ClearTextBox(CadastroAcidenteForm.Acidente_NoBoText)
        ClearTextBox(CadastroAcidenteForm.Acidente_DataText)
        ClearTextBox(CadastroAcidenteForm.Acidente_HoraText)
        ClearNumeric(CadastroAcidenteForm.Acidente_NoEnvolvidoNumeric, 1)
        ClearTextBox(CadastroAcidenteForm.ObsText)
    End Sub
    Public Sub CarregaAcidenteIds(ByVal textbox1 As TextBox, ByVal textbox2 As TextBox, ByVal textbox3 As TextBox)
        CarregaAcidenteID(textbox1)
        CarregaAcidenteID(textbox2)
        CarregaAcidenteID(textbox3)
    End Sub
    Public Sub LimpaIntersecoes()
        ClearCombo(CadastroAcidenteForm.Intersecao2Combo)
        ClearCombo(CadastroAcidenteForm.Intersecao1Combo)
    End Sub
    Public Sub LimpaIntersecao1()
        ClearCombo(CadastroAcidenteForm.Intersecao1Combo)
    End Sub
    Public Sub LimpaIntersecao2()
        ClearCombo(CadastroAcidenteForm.Intersecao2Combo)
    End Sub
End Module
