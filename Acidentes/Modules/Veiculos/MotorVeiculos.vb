Module MotorVeiculos
    Private VeiculosInfoLoaded As Boolean
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
    Private Sub ClearCombo(ByVal alvo As ComboBox)
        alvo.SelectedIndex = -1
        alvo.Text = ""
    End Sub
    Private Sub ClearTextBox(ByVal alvo As TextBoxBase)
        alvo.Clear()
    End Sub
    Private Sub ClearNumeric(ByVal Alvo As NumericUpDown, ByVal valor As Integer)
        Alvo.Value = valor
    End Sub

#End Region
    Public Sub CarregaVeiculoID(ByVal Alvo As TextBoxBase)
        Alvo.Clear()
        Alvo.Text = GeradorVeiculo.CodVeiculo
    End Sub
    Public Sub LimpaVeiculoForm()
        ClearCombo(CadastroAcidenteForm.Veiculo_TipoVeiculoCombo)
        ClearCombo(CadastroAcidenteForm.Veiculo_ApreendidoCombo)
        ClearCombo(CadastroAcidenteForm.Veiculo_EquipSegurancaCombo)
        ClearCombo(CadastroAcidenteForm.Veiculo_SentidoVeiculoCombo)
        ClearTextBox(CadastroAcidenteForm.Veiculo_CodVeiculoText)
        ClearTextBox(CadastroAcidenteForm.Veiculo_CodAcidenteText)
        ClearTextBox(CadastroAcidenteForm.Veiculo_PlacaVeiculoText)
        ClearNumeric(CadastroAcidenteForm.Veiculo_SeveridadeSemDano, 0)
        ClearNumeric(CadastroAcidenteForm.Veiculo_SeveridadeDanoMaterial, 0)
        ClearNumeric(CadastroAcidenteForm.Veiculo_SeveridadeFeridoLeve, 0)
        ClearNumeric(CadastroAcidenteForm.Veiculo_SeveridadeFeridoGrave, 0)
        ClearNumeric(CadastroAcidenteForm.Veiculo_SeveridadeFatalidade, 0)
        ClearNumeric(CadastroAcidenteForm.Veiculo_SeveridadeNA, 0)
        ClearNumeric(CadastroAcidenteForm.Veiculo_NoOcupantesNumeric, 1)
    End Sub
    Public Sub CarregaVeiculos()
        If VeiculosInfoLoaded = True Then
            Exit Sub
        Else
            CarregaVeiculoID(CadastroAcidenteForm.Veiculo_CodVeiculoText)
            CarregaVeiculoID(CadastroAcidenteForm.Condutor_CodVeiculoText)
            CarregaCombo("select * from aux_veic_tipo", CadastroAcidenteForm.Veiculo_TipoVeiculoCombo, 1)
            CarregaCombo("select * from aux_veic_apreendido", CadastroAcidenteForm.Veiculo_ApreendidoCombo, 1)
            CarregaCombo("select * from aux_veic_equipamentoseg", CadastroAcidenteForm.Veiculo_EquipSegurancaCombo, 1)
            CarregaCombo("select * from aux_veic_sentido", CadastroAcidenteForm.Veiculo_SentidoVeiculoCombo, 1)
            VeiculosInfoLoaded = True
        End If
    End Sub
    Public Sub CarregaVeiculoIDs(ByVal textbox1 As TextBox, ByVal textbox2 As TextBox)
        CarregaVeiculoID(textbox1)
        CarregaVeiculoID(textbox2)
    End Sub
End Module
