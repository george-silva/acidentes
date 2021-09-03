Module GeradorAcidente
#Region "Variaveis"
    'variaveis acidente
    Public CodAcidente As Integer
    Public CodTipoLog As Integer
    Public CodNomeLogradouro As Integer
    Public CodIntersecao1 As Integer
    Public CodIntersecao2 As Integer
    Public Numero As Integer
    Public CodBairro As Integer
    Public AcidData As String
    Public AcidHora As String
    Public AcidNoBoletim As Integer
    Public AcidCaracteristica As Integer
    Public AcidCausa As Integer
    Public AcidTipoSocorro As Integer
    Public AcidNoVeiculosEnvolvidos As Integer
    Public AcidOrgaoResponsavel As Integer
    Public AcidTipo As Integer
    Public AcidControleTrafego As Integer
    Public AcidCaracteristicaVia As Integer
    Public AcidClima As Integer
    Public AcidCondicaoVia As Integer
    Public AcidTipoPavimentacao As Integer
    Public AcidObs As String
#End Region
#Region "Métodos"
    Public Sub PegaCodAcidente()
        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        sql = "select nextval('acidentes_cod_acidente_seq') as seq"
        dr = PgDb.returnDatascalar(sql)

        CodAcidente = dr
    End Sub
    Public Sub PegaTipoLog(ByVal TipoLogCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        sql = "select cod_tipolog from aux_tipo_logradouro where desc_tipolog = " + "'" + TipoLogCombo.SelectedItem.ToString + "'"
        dr = pgdb.returnDatascalar(sql)

        CodTipoLog = dr
    End Sub
    Public Sub PegaCodNomeLog(ByVal TipoLogCombo As ComboBox, ByVal NomeLogCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        sql = "select cod_logradouro from aux_enderecos where tipo_logradouro = " + "'" + TipoLogCombo.SelectedItem.ToString + "'" + " AND desc_logradouro = " + "'" + NomeLogCombo.SelectedItem.ToString + "'"
        dr = pgdb.returnDatascalar(sql)

        CodNomeLogradouro = dr
    End Sub
    Public Sub PegaCodIntersecao1(ByVal Intersecao1Combo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If Intersecao1Combo.Text.ToString.Length = 0 Then
            CodIntersecao1 = vbNullString
        Else
            sql = "select cod_logradouro from aux_enderecos where desc_logradouro = " + "'" + Intersecao1Combo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            CodIntersecao1 = dr
        End If
    End Sub
    Public Sub PegaCodIntersecao2(ByVal Intersecao2Combo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If Intersecao2Combo.Text.ToString.Length = 0 Then
            CodIntersecao2 = vbNullString
        Else
            sql = "select cod_logradouro from aux_enderecos where desc_logradouro = " + "'" + Intersecao2Combo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            CodIntersecao2 = dr
        End If
    End Sub
    Public Sub PegaNumeroViario(ByVal NumViario As TextBox)
        If NumViario.Text.Length = 0 Then
            Numero = vbNull
        Else
            Numero = NumViario.Text
        End If
    End Sub
    Public Sub PegaCodBairro(ByVal BairroCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If BairroCombo.Text.ToString.Length = 0 Then
            CodBairro = vbNullString
        Else
            sql = "select cod_bairro from aux_bairros where desc_bairro = " + "'" + BairroCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            CodBairro = dr
        End If
    End Sub
    Public Sub PegaAcidData(ByVal DataAcidenteText As MaskedTextBox)
        AcidData = DataAcidenteText.Text.ToString
    End Sub
    Public Sub PegaAcidHora(ByVal HoraAcidenteText As MaskedTextBox)
        AcidHora = HoraAcidenteText.Text.ToString + ":00"
    End Sub
    Public Sub PegaNoBoletim(ByVal NoBoletimText As TextBox)
        AcidNoBoletim = NoBoletimText.Text
    End Sub
    Public Sub PegaAcidCaracteristica(ByVal CaracteristicaAcidenteCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If CaracteristicaAcidenteCombo.Text.ToString.Length = 0 Then
            AcidCaracteristica = vbNullString
        Else
            sql = "select cod_caracteristica from aux_acid_caracteristica where desc_caracteristica = " + "'" + CaracteristicaAcidenteCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidCaracteristica = dr
        End If
    End Sub
    Public Sub PegaAcidCausa(ByVal CausaAcidenteCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If CausaAcidenteCombo.Text.ToString.Length = 0 Then
            AcidCausa = vbNullString
        Else
            sql = "select cod_causa from aux_acid_causa where desc_causa = " + "'" + CausaAcidenteCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidCausa = dr
        End If
    End Sub
    Public Sub PegaAcidSocorro(ByVal TipoSocorroCombo As ComboBox)
        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If TipoSocorroCombo.Text.ToString.Length = 0 Then
        Else
            sql = "select cod_socorro from aux_acid_socorro where desc_socorro = " + "'" + TipoSocorroCombo.Text.ToString + "'"
            dr = PgDb.returnDatascalar(sql)
            AcidTipoSocorro = dr
        End If
    End Sub
    Public Sub PegaAcidNoVeiculos(ByVal NumVeiculos As NumericUpDown)
        If NumVeiculos.Value < 1 Then
            AcidNoVeiculosEnvolvidos = 1
        Else
            AcidNoVeiculosEnvolvidos = Int16.Parse(NumVeiculos.Value)
        End If
    End Sub
    Public Sub PegaAcidOrgao(ByVal OrgaoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If OrgaoCombo.Text.ToString.Length = 0 Then
            AcidOrgaoResponsavel = 1
        Else
            sql = "select cod_orgao from aux_acid_orgaoresp where desc_orgao = " + "'" + OrgaoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidOrgaoResponsavel = dr
        End If
    End Sub
    Public Sub PegaAcidTipo(ByVal tipoacidentecombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If tipoacidentecombo.Text.ToString.Length = 0 Then
            AcidTipo = vbNullString
        Else
            sql = "select cod_tipo from aux_acid_tipo where desc_tipo = " + "'" + tipoacidentecombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidTipo = dr
        End If
    End Sub
    Public Sub PegaAcidControle(ByVal AcidControle As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If AcidControle.Text.ToString.Length = 0 Then
            AcidControleTrafego = 6
        Else
            sql = "select cod_controle from aux_acid_controletrafego where desc_controle = " + "'" + AcidControle.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidControleTrafego = dr
        End If
    End Sub
    Public Sub PegaAcidCaracteristicaVia(ByVal CaracViaCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If CaracViaCombo.Text.ToString.Length = 0 Then
            AcidCaracteristicaVia = 9
        Else
            sql = "select cod_caracteristica from aux_acid_caracteristicavia where desc_caracteristica = " + "'" + CaracViaCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidCaracteristicaVia = dr
        End If
    End Sub
    Public Sub PegaAcidClima(ByVal ClimaCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If ClimaCombo.Text.ToString.Length = 0 Then
            AcidClima = 5
        Else
            sql = "select cod_clima from aux_acid_clima where desc_clima = " + "'" + ClimaCombo.SelectedItem.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidClima = dr
        End If
    End Sub
    Public Sub PegaAcidCondicaoVia(ByVal CondicaoViaCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If CondicaoViaCombo.Text.ToString.Length = 0 Then
            AcidCondicaoVia = 11
        Else
            sql = "select cod_condicao from aux_acid_condicaovia where desc_condicao = " + "'" + CondicaoViaCombo.SelectedItem.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidCondicaoVia = dr
        End If
    End Sub
    Public Sub PegaAcidPavimentacao(ByVal PavimentacaoViaCombo)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If PavimentacaoViaCombo.Text.ToString.Length = 0 Then
            AcidTipoPavimentacao = 6
        Else
            sql = "select cod_pavimentacao from aux_acid_pavimentacao where desc_pavimentacao = " + "'" + PavimentacaoViaCombo.SelectedItem.ToString + "'"
            dr = pgdb.returnDatascalar(sql)
            AcidTipoPavimentacao = dr
        End If
    End Sub
    Public Sub PegaAcidObs(ByVal ObsText As TextBox)
        If ObsText.Text.Length <= 0 Then
            AcidObs = vbNull
        Else
            AcidObs = ObsText.Text
        End If
    End Sub
    Public Sub PegaTudo()
        PegaTipoLog(CadastroAcidenteForm.TipoLogradouroCombo)
        PegaCodNomeLog(CadastroAcidenteForm.TipoLogradouroCombo, CadastroAcidenteForm.NomeLogradouroCombo)
        PegaNumeroViario(CadastroAcidenteForm.NumeroText)
        PegaCodIntersecao1(CadastroAcidenteForm.Intersecao1Combo)
        PegaCodIntersecao2(CadastroAcidenteForm.Intersecao2Combo)
        PegaCodBairro(CadastroAcidenteForm.BairroCombo)
        PegaAcidData(CadastroAcidenteForm.Acidente_DataText)
        PegaAcidHora(CadastroAcidenteForm.Acidente_HoraText)
        PegaNoBoletim(CadastroAcidenteForm.Acidente_NoBoText)
        PegaAcidCaracteristica(CadastroAcidenteForm.CaracteristicaAcidenteCombo)
        PegaAcidCausa(CadastroAcidenteForm.CausaAcidenteCombo)
        PegaAcidSocorro(CadastroAcidenteForm.TipoSocorroCombo)
        PegaAcidNoVeiculos(CadastroAcidenteForm.Acidente_NoEnvolvidoNumeric)
        PegaAcidOrgao(CadastroAcidenteForm.OrgaoResponsavelCombo)
        PegaAcidTipo(CadastroAcidenteForm.TipoAcidenteCombo)
        PegaAcidControle(CadastroAcidenteForm.ControleTrafegoCombo)
        PegaAcidCaracteristicaVia(CadastroAcidenteForm.CaracteristicaViaCombo)
        PegaAcidClima(CadastroAcidenteForm.ClimaCombo)
        PegaAcidCondicaoVia(CadastroAcidenteForm.CondicaoViaCombo)
        PegaAcidPavimentacao(CadastroAcidenteForm.TipoPavimentacaoCombo)
        PegaAcidObs(CadastroAcidenteForm.ObsText)
    End Sub
    Public Sub PegaIntersecoes(ByVal numero As Integer, ByVal nome_logradouro As String, ByVal intersecao1 As ComboBox, ByVal intersecao2 As ComboBox)
        'somente utilizavel em winforms.
        'utilizar outro metodo apra pegar o codigo de cada intersecao

        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Npgsql.NpgsqlDataReader
        Dim SQL As String
        SQL = "select prefixo_direcao, sufixo_direcao from logradouros where " + numero.ToString + " between geocode_minadd and geocode_maxadd and nome_logradouro = " + "'" + nome_logradouro + "'"

        dr = PgDb.returnDatareader(SQL)
        dr.Read()
        'caso nao esteja entre algum intervalo
        If dr.HasRows = False Then
            If My.Settings.CheckIntersectionsWarning = True Then
                'MessageBox.Show("Não foram encontradas interseções para este número. Por favor preencha as interseções anterior e posterior manualmente.")
                Exit Sub
            Else
                Exit Sub
            End If

        Else
            intersecao1.SelectedItem = dr(0)
            intersecao2.SelectedItem = dr(1)
        End If
    End Sub
    Public Sub InserirGrid(ByVal datagrid As DataGridView)
        If datagrid.Rows.Count < 1 Then
            datagrid.Rows.Add( _
            CodAcidente, _
            AcidNoBoletim, _
            AcidData, _
            AcidHora, _
            AcidNoVeiculosEnvolvidos, _
            CodBairro, _
            CodTipoLog, _
            CodNomeLogradouro, _
            Numero, _
            CodIntersecao1, _
            CodIntersecao2, _
            AcidCaracteristica, _
            AcidCausa, _
            AcidTipo, _
            AcidCaracteristicaVia, _
            AcidCondicaoVia, _
            AcidTipoPavimentacao, _
            AcidTipoSocorro, _
            AcidControleTrafego, _
            AcidOrgaoResponsavel, _
            AcidClima, _
            AcidObs)
        Else
            MessageBox.Show("Você só pode adicionar um acidente por vez.")
        End If
    End Sub
#End Region
End Module
