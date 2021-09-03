Module MotorCondutores
    Private CondutoresInfoLoaded As Boolean
#Region "funcoes privadas"
    Private Sub CarregaCombo(ByVal SQL As String, ByVal Alvo As ComboBox, ByVal Coluna As Integer)
        'funcao especifica para preencher um combo box com a coluna 1 de determinada tabela
        'index 0-based
        'ideal para carregar informacoes textuais de tabelas auxiliares
        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Dim Dr As Npgsql.NpgsqlDataReader
        Try
            Dr = PgDb.returnDatareader(SQL)
            Do While Dr.Read
                Alvo.Items.Add(Dr(Coluna))
            Loop
        Catch ex As Exception
            MessageBox.Show("Erro ao carregar as informações solicitadas. " + vbNewLine + ex.Message, "Erro")
        End Try
    End Sub
    'reescrever

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
    Public Sub CarregaCondutorID(ByVal Alvo As TextBoxBase)
        Alvo.Clear()
        Alvo.Text = GeradorCondutor.CodCondutor
    End Sub
    Public Sub CarregaCondutores()
        If CondutoresInfoLoaded = True Then
            Exit Sub
        Else
            CarregaCondutorID(CadastroAcidenteForm.Condutor_CodCondutorText)
            CarregaCombo("select sigla_estado from aux_estados", CadastroAcidenteForm.Condutor_EstadoCombo, 0)
            CarregaCombo("select desc_escolaridade from aux_cond_escolaridade", CadastroAcidenteForm.Condutor_EscolaridadeCombo, 0)
            CarregaCombo("select * from aux_cond_profissao", CadastroAcidenteForm.Condutor_ProfissaoCombo, 1)
            CarregaCombo("select * from aux_cond_comportamento", CadastroAcidenteForm.Condutor_ComportamentoCombo, 1)
            CarregaCombo("select * from aux_cond_condicao", CadastroAcidenteForm.Condutor_CondicaoCombo, 1)
            CarregaCombo("select * from aux_cond_sexo", CadastroAcidenteForm.Condutor_SexoCombo, 1)
            CarregaCombo("select * from aux_cond_habilitacao", CadastroAcidenteForm.Condutor_HabilitacaoCombo, 1)
            CondutoresInfoLoaded = True
        End If
    End Sub
    Public Sub CarregaCidade()
        CarregaCombo("select desc_cidade from aux_cidades where sigla_estado = " + "'" + CadastroAcidenteForm.Condutor_EstadoCombo.SelectedItem.ToString + "'", CadastroAcidenteForm.Condutor_CidadeCombo, 0)
    End Sub
    Public Sub LimpaCondutorForm()
        ClearCombo(CadastroAcidenteForm.Condutor_CidadeCombo)
        ClearCombo(CadastroAcidenteForm.Condutor_ComportamentoCombo)
        ClearCombo(CadastroAcidenteForm.Condutor_CondicaoCombo)
        ClearCombo(CadastroAcidenteForm.Condutor_EscolaridadeCombo)
        ClearCombo(CadastroAcidenteForm.Condutor_EstadoCombo)
        ClearCombo(CadastroAcidenteForm.Condutor_HabilitacaoCombo)
        ClearCombo(CadastroAcidenteForm.Condutor_ProfissaoCombo)
        ClearCombo(CadastroAcidenteForm.Condutor_SexoCombo)
        ClearTextBox(CadastroAcidenteForm.Condutor_DataHabilitacaoText)
        ClearTextBox(CadastroAcidenteForm.Condutor_DataNascimentoText)
        ClearTextBox(CadastroAcidenteForm.Condutor_ProntuarioText)
        ClearTextBox(CadastroAcidenteForm.Condutor_CodAcidenteText)
        ClearTextBox(CadastroAcidenteForm.Condutor_CodCondutorText)
        ClearTextBox(CadastroAcidenteForm.Condutor_CodVeiculoText)
    End Sub


End Module
