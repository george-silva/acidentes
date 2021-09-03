Module GeradorModule
    'acidente
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
    'veiculo
    Public CodVeiculo As Integer
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
    'condutor
    Public CodCondutor As Integer
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
    Public NumInicialAcidente As Integer

#Region "métodos"
    Public Function my_random(ByVal low As Integer, ByVal high As Integer)
        Dim range As Integer
        Dim result As Integer
        range = (high - low) + 1
        'achar o randok
        result = (Rnd() * range) + low
        Return result
    End Function
    Public Sub GeraAcidente(ByVal NoInicial)
        NumInicialAcidente = NoInicial
        CodAcidente = NoInicial
        'tipolog
        'nomelog
        Numero = my_random(1, 2500)
        AcidCaracteristica = my_random(1, 5)
        AcidCausa = my_random(1, 19)
        AcidTipo = my_random(1, 12)
    End Sub
#End Region

End Module
