Module GeradorVeiculo
#Region "Variáveis"
    Public CodVeiculo As Integer
    Public CodAcidente As Integer
    Public CodTipoVeiculo As Integer
    Public PlacaVeiculo As String
    Public Apreendido As Integer
    Public NoOcupantes As Integer
    Public SentidoVeicular As Integer
    Public EquipSeguranca As Integer
    Public SevSemDanos As Integer
    Public SevDanosMateriais As Integer
    Public SevFeridosLeves As Integer
    Public SevFeridosGraves As Integer
    Public SevFatalidades As Integer
    Public SevNaoApurado As Integer
#End Region

#Region "Métodos"
    Public Sub PegaCodVeiculo()
        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        sql = "select nextval('veiculos_cod_veiculo_seq') as seq"
        dr = PgDb.returnDatascalar(sql)

        CodVeiculo = dr
    End Sub
    Public Sub PegaCodAcidente()
        CodAcidente = GeradorAcidente.CodAcidente
    End Sub
    Public Sub PegaCodTipoVeiculo(ByVal TipoVeiculoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If TipoVeiculoCombo.Text.ToString.Length = 0 Then
            CodTipoVeiculo = vbNullString
        Else
            sql = "select cod_tipo from aux_veic_tipo where desc_tipo = " + "'" + TipoVeiculoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            CodTipoVeiculo = dr
        End If
    End Sub
    Public Sub PegaPlaca(ByVal Placa As TextBoxBase)
        If Placa.Text.Length < 0 Then
            PlacaVeiculo = vbNull
        Else
            PlacaVeiculo = Placa.Text.ToString
        End If
    End Sub
    Public Sub PegaApreendido(ByVal ApreendidoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String

        If ApreendidoCombo.Text.ToString.Length = 0 Then
            Apreendido = vbNull
        Else
            sql = "select cod_apreendido from aux_veic_apreendido where desc_apreendido = " + "'" + ApreendidoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            Apreendido = dr
        End If
    End Sub
    Public Sub PegaNoOcupantes(ByVal NumOcupantes As NumericUpDown)
        If NumOcupantes.Value < 1 Then
            NoOcupantes = 1
        Else
            NoOcupantes = NumOcupantes.Value
        End If
    End Sub
    Public Sub PegaSentidoVeicular(ByVal SentidoCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If SentidoCombo.Text.Length = 0 Then
            SentidoVeicular = vbNullString
        Else
            sql = "select cod_sentido from aux_veic_sentido where desc_sentido = " + "'" + SentidoCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            SentidoVeicular = dr
        End If
    End Sub
    Public Sub PegaEquipSeguranca(ByVal EquipSegurancaCombo As ComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As Integer
        Dim sql As String
        If EquipSegurancaCombo.Text.Length = 0 Then
            EquipSeguranca = vbNull
        Else
            sql = "select cod_equip from aux_veic_equipamentoseg where desc_equip = " + "'" + EquipSegurancaCombo.Text.ToString + "'"
            dr = pgdb.returnDatascalar(sql)

            EquipSeguranca = dr
        End If

    End Sub
    Public Sub PegaSevSemDanos(ByVal Numeric As NumericUpDown)
        SevSemDanos = Numeric.Value
    End Sub
    Public Sub PegaSevDanosMateriais(ByVal Numeric As NumericUpDown)
        SevDanosMateriais = Numeric.Value
    End Sub
    Public Sub PegaSevFeridosLeves(ByVal Numeric As NumericUpDown)
        SevFeridosLeves = Numeric.Value
    End Sub
    Public Sub PegaSevFeridosGraves(ByVal numeric As NumericUpDown)
        SevFeridosGraves = numeric.Value
    End Sub
    Public Sub PegaSevFatalidades(ByVal numeric As NumericUpDown)
        SevFatalidades = numeric.Value
    End Sub
    Public Sub PegaSevNaoApurado(ByVal Numeric As NumericUpDown)
        SevNaoApurado = Numeric.Value
    End Sub
    Public Sub PegaTudo()
        PegaCodAcidente()
        PegaCodTipoVeiculo(CadastroAcidenteForm.Veiculo_TipoVeiculoCombo)
        PegaPlaca(CadastroAcidenteForm.Veiculo_PlacaVeiculoText)
        PegaApreendido(CadastroAcidenteForm.Veiculo_ApreendidoCombo)
        PegaNoOcupantes(CadastroAcidenteForm.Veiculo_NoOcupantesNumeric)
        PegaSentidoVeicular(CadastroAcidenteForm.Veiculo_SentidoVeiculoCombo)
        PegaEquipSeguranca(CadastroAcidenteForm.Veiculo_EquipSegurancaCombo)
        PegaSevSemDanos(CadastroAcidenteForm.Veiculo_SeveridadeSemDano)
        PegaSevDanosMateriais(CadastroAcidenteForm.Veiculo_SeveridadeDanoMaterial)
        PegaSevFeridosLeves(CadastroAcidenteForm.Veiculo_SeveridadeFeridoLeve)
        PegaSevFeridosGraves(CadastroAcidenteForm.Veiculo_SeveridadeFeridoGrave)
        PegaSevFatalidades(CadastroAcidenteForm.Veiculo_SeveridadeFatalidade)
        PegaSevNaoApurado(CadastroAcidenteForm.Veiculo_SeveridadeNA)
    End Sub
    Public Sub InserirGrid(ByVal DataGrid As DataGridView)
        DataGrid.Rows.Add( _
        CodVeiculo, _
        CodAcidente, _
        CodTipoVeiculo, _
        PlacaVeiculo, _
        Apreendido, _
        NoOcupantes, _
        SentidoVeicular, _
        EquipSeguranca, _
        SevSemDanos, _
        SevDanosMateriais, _
        SevFeridosLeves, _
        SevFeridosGraves, _
        SevFatalidades, _
        SevNaoApurado)
    End Sub
#End Region

End Module
