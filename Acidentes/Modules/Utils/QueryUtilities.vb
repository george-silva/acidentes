Module QueryUtilities
    Public Function BuildQuery(ByVal datagridview As DataGridView, ByVal tabela As String, ByVal rownumber As Integer)
        Dim query As String
        Dim i As Integer
        Dim j As Integer
        i = 1
        j = 1
        query = "insert into " + tabela + " (" + datagridview.Columns(0).Name.ToString + ","
        Do While i <= datagridview.Columns.Count - 1
            If i = datagridview.Columns.Count - 1 Then
                query = query + datagridview.Columns(i).Name.ToString + ") values ("
            Else
                query = query + datagridview.Columns(i).Name.ToString + ","
            End If
            i = i + 1
        Loop
        query = query + "'" + datagridview.Rows(rownumber).Cells(0).Value.ToString + "'" + ","
        Do While j <= datagridview.Rows(rownumber).Cells.Count - 1
            If j = datagridview.Rows(rownumber).Cells.Count - 1 Then
                query = query + "'" + datagridview.Rows(rownumber).Cells(j).Value.ToString + "'" + ");"
            Else
                query = query + "'" + datagridview.Rows(rownumber).Cells(j).Value.ToString + "'" + ","
            End If
            j = j + 1
        Loop
        Return query
    End Function
    Public Sub InsertDB(ByVal Query As String)
        Dim PgDb As New AcessoPG(CarregaInfo.StringConexao)
        Try
            PgDb.returnNonQuery(Query)
            MessageBox.Show("Registro incluído com sucesso.", "Operação Completada")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Public Function ReturnColumns(ByVal datagrid As DataGridView, ByVal index As Integer)
        Return datagrid.Columns(index).Name.ToString
    End Function
    Public Sub RefreshDataGrid(ByVal Datagrid As DataGridView, ByVal SQLConsulta As String, ByVal tabela As String)
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim ds As New DataSet

        ds = pgdb.returnDataset(SQLConsulta, tabela)
        If ds.Tables(0).Rows.Count <= 0 Then
            MessageBox.Show("Não existem registros para este critério de busca.", "Aviso")
        Else
            Datagrid.DataSource = ds.Tables(0)
        End If
    End Sub
End Module
