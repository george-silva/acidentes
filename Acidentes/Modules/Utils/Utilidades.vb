Imports Microsoft.Office.Core
Imports Microsoft.Office.Interop
Module Utilidades

    Public Sub ClearForm()
        MotorAcidentes.LimpaAcidenteForm()
        MotorVeiculos.LimpaVeiculoForm()
        MotorCondutores.LimpaCondutorForm()
    End Sub
    Public Function GetUserGroup() As String
        Dim pgdb As New AcessoPG(CarregaInfo.StringConexao)
        Dim dr As String
        dr = pgdb.returnDatascalar("select groname,rolname from pg_group join pg_roles on (oid = any (grolist)) where rolname = " + "'" + CarregaInfo.usuario + "'")
        Return dr
    End Function
    Public Sub ExportToExcel(ByVal dt As DataTable)
        Try
            Dim oApp As New Excel.Application
            Dim oBook As Excel.Workbook = oApp.Workbooks.Add
            Dim oSheet As Excel.Worksheet = CType(oBook.Worksheets(1), Excel.Worksheet)

            oApp.Visible = False

            With oSheet
                Dim c As Long = Asc("A")
                For Each dc As DataColumn In dt.Columns
                    .Range(Chr(c) & "1").Value = dc.ColumnName.ToString
                    .Range(Chr(c) & "1").Font.Bold = True
                    c += 1
                Next

                Dim i As Long = 2
                For Each dr As DataRow In dt.Rows
                    c = Asc("A")
                    For Each dc As DataColumn In dt.Columns
                        .Range(Chr(c) & i.ToString).Value = dr.Item(dc.ColumnName)
                        c += 1
                    Next
                    i += 1
                Next

                oApp.Visible = True
            End With
        Catch ex As Exception
            MessageBox.Show("Source [" & ex.Source & "] Description  [" & ex.Message & "]")
        End Try
    End Sub

End Module
