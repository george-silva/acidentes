Module GeradorCondutor
#Region "Variaveis"
    Public CodCondutor As Integer
    Public CodAcidente As Integer
    Public CodVeiculo As Integer
    Public Prontuario As Integer
    Public Escolaridade As Integer
    Public Profissao As Integer
    Public Comportamento As Integer
    Public Condicao As Integer
    Public Habilitacao As Integer
    Public Data_Hab As String
    Public Data_Nasc As String
    Public Condutor_SemDanos As Integer
    Public Condutor_FeridoLeve As Integer
    Public Condutor_FeridoGrave As Integer
    Public Condutor_Fatalidade As Integer
    Public Estado As Integer
    Public Cidade As Integer
    Public CondutorSexo As Integer
#End Region
#Region "Métodos"

    Public Sub PegaCodCondutor()
        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        sql = "select nextval('condutor_cod_condutor_seq') as seq"
        dr = PgDb.returnDatascalar(sql)

        CodCondutor = dr
    End Sub
    Public Sub PegaCodAcidente()
        CodAcidente = GeradorAcidente.CodAcidente
    End Sub
    Public Sub PegaCodVeiculo()
        CodVeiculo = GeradorVeiculo.CodVeiculo
    End Sub
    Public Sub PegaProntuario(ByVal ProntuarioText As TextBoxBase)
        If ProntuarioText.Text.Length <= 0 Then
            Prontuario = vbNull
        Else
            Prontuario = ProntuarioText.Text
        End If
    End Sub
    Public Sub PegaEscolaridade(ByVal EscolaridadeCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If EscolaridadeCombo.Text.ToString.Length = 0 Then
            Escolaridade = vbNull
        Else
            sql = "select cod_escolaridade from aux_cond_escolaridade where desc_escolaridade = " + "'" + EscolaridadeCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Escolaridade = dr
        End If
    End Sub
    Public Sub PegaProfissao(ByVal ProfissaoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If ProfissaoCombo.Text.ToString.Length = 0 Then
            Profissao = vbNull
        Else
            sql = "select cod_profissao from aux_cond_profissao where desc_profissao = " + "'" + ProfissaoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Profissao = dr
        End If
    End Sub
    Public Sub PegaComportamento(ByVal ComportamentoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If ComportamentoCombo.Text.ToString.Length = 0 Then
            Comportamento = vbNull
        Else
            sql = "select cod_Comportamento from aux_cond_comportamento where desc_comportamento = " + "'" + ComportamentoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Comportamento = dr
        End If
    End Sub
    Public Sub PegaCondicao(ByVal CondicaoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If CondicaoCombo.Text.ToString.Length = 0 Then
            Condicao = vbNull
        Else
            sql = "select cod_condicao from aux_cond_condicao where desc_condicao = " + "'" + CondicaoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Condicao = dr
        End If
    End Sub
    Public Sub PegaHabilitacao(ByVal HabilitacaoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If HabilitacaoCombo.Text.ToString.Length = 0 Then
            Habilitacao = vbNull
        Else
            sql = "select cod_habilitacao from aux_cond_habilitacao where desc_habilitacao = " + "'" + HabilitacaoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Habilitacao = dr
        End If
    End Sub
    Public Sub PegaDataHabilitacao(ByVal DataHab As TextBoxBase)
        Data_Hab = DataHab.Text.ToString
    End Sub
    Public Sub PegaDataNascimento(ByVal DataNasc As TextBoxBase)
        Data_Nasc = DataNasc.Text.ToString
    End Sub
    Public Sub PegaCondutorSemDanos(ByVal SemDanosRadio As RadioButton)
        If SemDanosRadio.Checked = True Then
            Condutor_SemDanos = 1
        Else
            Condutor_SemDanos = 0
        End If
    End Sub
    Public Sub PegaCondutorFeridoLeve(ByVal FeridoLeveRadio As RadioButton)
        If FeridoLeveRadio.Checked = True Then
            Condutor_FeridoLeve = 1
        Else
            Condutor_FeridoLeve = 0
        End If
    End Sub
    Public Sub PegaCondutorFeridoGrave(ByVal FeridoGraveRadio As RadioButton)
        If FeridoGraveRadio.Checked = True Then
            Condutor_FeridoGrave = 1
        Else
            Condutor_FeridoGrave = 0
        End If
    End Sub
    Public Sub PegaCondutorFatalidade(ByVal FatalidadeRadio As RadioButton)
        If FatalidadeRadio.Checked = True Then
            Condutor_Fatalidade = 1
        Else
            Condutor_Fatalidade = 0
        End If
    End Sub
    Public Sub PegaCondutorEstado(ByVal EstadoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If EstadoCombo.Text.ToString.Length = 0 Then
            Estado = vbNull
        Else
            sql = "select cod_estado from aux_estados where sigla_estado = " + "'" + EstadoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Estado = dr
        End If
    End Sub
    Public Sub PegaCondutorCidade(ByVal CidadeCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If CidadeCombo.Text.ToString.Length = 0 Then
            Cidade = vbNull
        Else
            sql = "select cod_cidade from aux_cidades where desc_cidade = " + "'" + CidadeCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Cidade = dr
        End If
    End Sub
    Public Sub PegaCondutorSexo(ByVal SexoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If SexoCombo.Text.ToString.Length = 0 Then
            CondutorSexo = vbNull
        Else
            sql = "select cod_sexo from aux_cond_sexo where desc_sexo = " + "'" + SexoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            CondutorSexo = dr
        End If
    End Sub
    Public Sub PegaTudo()
        'PegaCodCondutor()
        PegaCodVeiculo()
        PegaCodAcidente()
        PegaProntuario(CadastroAcidenteForm.Condutor_ProntuarioText)
        PegaEscolaridade(CadastroAcidenteForm.Condutor_EscolaridadeCombo)
        PegaProfissao(CadastroAcidenteForm.Condutor_ProfissaoCombo)
        PegaComportamento(CadastroAcidenteForm.Condutor_ComportamentoCombo)
        PegaCondicao(CadastroAcidenteForm.Condutor_CondicaoCombo)
        PegaHabilitacao(CadastroAcidenteForm.Condutor_HabilitacaoCombo)
        PegaDataHabilitacao(CadastroAcidenteForm.Condutor_DataHabilitacaoText)
        PegaDataNascimento(CadastroAcidenteForm.Condutor_DataNascimentoText)
        PegaCondutorSemDanos(CadastroAcidenteForm.Condutor_SemDanosRadio)
        PegaCondutorFeridoLeve(CadastroAcidenteForm.Condutor_FeridoLeveRadio)
        PegaCondutorFeridoGrave(CadastroAcidenteForm.Condutor_FeridoGraveRadio)
        PegaCondutorFatalidade(CadastroAcidenteForm.Condutor_FatalidadeRadio)
        PegaCondutorEstado(CadastroAcidenteForm.Condutor_EstadoCombo)
        PegaCondutorCidade(CadastroAcidenteForm.Condutor_CidadeCombo)
        PegaCondutorSexo(CadastroAcidenteForm.Condutor_SexoCombo)
    End Sub
    Public Sub InserirGrid(ByVal DataGrid As DataGridView)
        DataGrid.Rows.Add( _
        CodCondutor, _
        CodVeiculo, _
        CodAcidente, _
        Estado, _
        Cidade, _
        Escolaridade, _
        Profissao, _
        Habilitacao, _
        Comportamento, _
        Condicao, _
        CondutorSexo, _
        Data_Nasc, _
        Data_Hab, _
        Condutor_SemDanos, _
        Condutor_FeridoLeve, _
        Condutor_FeridoGrave, _
        Condutor_Fatalidade, _
        Prontuario)
    End Sub
#End Region

End Module
