Public Class TerminalInterativoForm

    Private Sub ExecutaQueryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExecutaQueryButton.Click
        If SQLTextBox.Text.Contains("INSERT") Or SQLTextBox.Text.Contains("DROP") Or SQLTextBox.Text.Contains("DELETE") Or SQLTextBox.Text.Contains("CREATE") Or SQLTextBox.Text.Contains("TRUNCATE") Or SQLTextBox.Text.Length <= 0 Then
            MessageBox.Show("Você não pode realizar esta operação SQL.", "Erro")
        Else
            QueryUtilities.RefreshDataGrid(DisplayResultsGrid, SQLTextBox.Text, "")
        End If
    End Sub

    Private Sub TerminalInterativoForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        QueryBuilder.CarregaTabelas(Me.TabelasCombo)
    End Sub

    Private Sub TabelasCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabelasCombo.SelectedIndexChanged
        ColunasCombo.Items.Clear()
        QueryBuilder.CarregaColunas(TabelasCombo.SelectedItem.ToString, ColunasCombo)

        If My.Settings.AutoCompleteIT = True Then
            Dim InsertTableName As String
            Dim i As Integer
            InsertTableName = TabelasCombo.SelectedItem.ToString
            i = InsertTableName.Length

            Me.SQLTextBox.Text = SQLTextBox.Text + " " + InsertTableName
            Me.SQLTextBox.Select()
            Me.SQLTextBox.Select(SQLTextBox.Text.Length - i, i)
        Else
            Exit Sub
        End If

    End Sub

    Private Sub ClearQueryButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearQueryButton.Click
        SQLTextBox.Text = ""
    End Sub

    Private Sub ColunasCombo_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ColunasCombo.SelectedIndexChanged
        If My.Settings.AutoCompleteIT = True Then
            Dim InsertColumnName As String
            Dim i As Integer
            InsertColumnName = ColunasCombo.SelectedItem.ToString
            i = InsertColumnName.Length

            Me.SQLTextBox.Text = SQLTextBox.Text + " " + InsertColumnName
            Me.SQLTextBox.Select()
            Me.SQLTextBox.Select(SQLTextBox.Text.Length - i, i)
        Else
            Exit Sub
        End If
    End Sub

    Private Sub ExportExcelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExportExcelButton.Click
        Utilidades.ExportToExcel(Me.DisplayResultsGrid.DataSource)
    End Sub

#Region "manipulacao da SQL"

    Private Sub OrLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OrLabel.Click
        QueryBuilder.CarregarTexto("OR", Me.SQLTextBox)
    End Sub

    Private Sub AndLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AndLabel.Click
        QueryBuilder.CarregarTexto("AND", Me.SQLTextBox)
    End Sub

    Private Sub BetweenLabel_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles BetweenLabel.Click
        QueryBuilder.CarregarTexto("BETWEEN", Me.SQLTextBox)
    End Sub

    Private Sub MenorQueLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenorQueLabel.Click
        QueryBuilder.CarregarTexto("<", Me.SQLTextBox)
    End Sub

    Private Sub MenorIgualLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MenorIgualLabel.Click
        QueryBuilder.CarregarTexto("<=", Me.SQLTextBox)
    End Sub

    Private Sub IgualLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IgualLabel.Click
        QueryBuilder.CarregarTexto("=", Me.SQLTextBox)
    End Sub

    Private Sub MaiorIgualLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaiorIgualLabel.Click
        QueryBuilder.CarregarTexto("=>", Me.SQLTextBox)
    End Sub

    Private Sub MaiorQueLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MaiorQueLabel.Click
        QueryBuilder.CarregarTexto(">", Me.SQLTextBox)
    End Sub

    Private Sub DiferenteLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DiferenteLabel.Click
        QueryBuilder.CarregarTexto("<>", Me.SQLTextBox)
    End Sub

#End Region
End Class