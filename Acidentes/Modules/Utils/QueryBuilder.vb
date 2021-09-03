Module QueryBuilder
    Private Sub CarregaCombo(ByVal SQL As String, ByVal Alvo As ToolStripComboBox, ByVal Coluna As Integer)
        'funcao especifica para preencher um combo box com a coluna 1 de determinada tabela
        'index 0-based
        'ideal para carregar informacoes textuais de tabelas auxiliares
        'neste caso estamos carregando tudo em uma toolstripcombobox.
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
    Public Sub CarregaTabelas(ByVal ToolStripCombo As ToolStripComboBox)
        CarregaCombo("select tablename from pg_tables where schemaname = 'public' and tablename <> 'geometry_columns' and tablename <> 'spatial_ref_sys' order by tablename", ToolStripCombo, 0)
    End Sub
    Public Sub CarregaColunas(ByVal tabela As String, ByVal ToolstripCombo As ToolStripComboBox)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As New DataSet
        dr = pgdb.returnDataset("select * from " + tabela, "tabelatemp")

        Dim i As Integer
        i = 0

        Do While i <= dr.Tables(0).Columns.Count - 1
            ToolstripCombo.Items.Add(dr.Tables(0).Columns(i).ColumnName.ToString)
            i = i + 1
        Loop
    End Sub
    Public Sub CarregarTexto(ByVal Texto As String, ByVal Alvo As TextBoxBase)
        alvo.Text = alvo.Text + " " + Texto
    End Sub
End Module
