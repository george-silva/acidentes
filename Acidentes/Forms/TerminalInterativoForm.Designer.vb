<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TerminalInterativoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TerminalInterativoForm))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.DisplayResultsGrid = New System.Windows.Forms.DataGridView
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.ExecutaQueryButton = New System.Windows.Forms.Button
        Me.SQLTextBox = New System.Windows.Forms.TextBox
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.ClearQueryButton = New System.Windows.Forms.ToolStripButton
        Me.UndoButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator
        Me.OrLabel = New System.Windows.Forms.ToolStripLabel
        Me.AndLabel = New System.Windows.Forms.ToolStripLabel
        Me.BetweenLabel = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.MenorQueLabel = New System.Windows.Forms.ToolStripLabel
        Me.MenorIgualLabel = New System.Windows.Forms.ToolStripLabel
        Me.IgualLabel = New System.Windows.Forms.ToolStripLabel
        Me.MaiorIgualLabel = New System.Windows.Forms.ToolStripLabel
        Me.MaiorQueLabel = New System.Windows.Forms.ToolStripLabel
        Me.DiferenteLabel = New System.Windows.Forms.ToolStripLabel
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.TabelasLabel = New System.Windows.Forms.ToolStripLabel
        Me.TabelasCombo = New System.Windows.Forms.ToolStripComboBox
        Me.ColunasLabel = New System.Windows.Forms.ToolStripLabel
        Me.ColunasCombo = New System.Windows.Forms.ToolStripComboBox
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator
        Me.ExportExcelButton = New System.Windows.Forms.ToolStripButton
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DisplayResultsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(794, 45)
        Me.Panel2.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     Terminal Interativo SQL"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.DisplayResultsGrid)
        Me.Panel1.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel1.Controls.Add(Me.ToolStrip1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 45)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(794, 631)
        Me.Panel1.TabIndex = 6
        '
        'DisplayResultsGrid
        '
        Me.DisplayResultsGrid.AllowUserToAddRows = False
        Me.DisplayResultsGrid.AllowUserToDeleteRows = False
        Me.DisplayResultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DisplayResultsGrid.Dock = System.Windows.Forms.DockStyle.Left
        Me.DisplayResultsGrid.Location = New System.Drawing.Point(0, 74)
        Me.DisplayResultsGrid.Name = "DisplayResultsGrid"
        Me.DisplayResultsGrid.ReadOnly = True
        Me.DisplayResultsGrid.Size = New System.Drawing.Size(791, 557)
        Me.DisplayResultsGrid.TabIndex = 2
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.ExecutaQueryButton, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SQLTextBox, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 25)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 49.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(794, 49)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'ExecutaQueryButton
        '
        Me.ExecutaQueryButton.CausesValidation = False
        Me.ExecutaQueryButton.Image = CType(resources.GetObject("ExecutaQueryButton.Image"), System.Drawing.Image)
        Me.ExecutaQueryButton.Location = New System.Drawing.Point(746, 3)
        Me.ExecutaQueryButton.Name = "ExecutaQueryButton"
        Me.ExecutaQueryButton.Size = New System.Drawing.Size(45, 43)
        Me.ExecutaQueryButton.TabIndex = 16
        Me.ExecutaQueryButton.UseVisualStyleBackColor = True
        '
        'SQLTextBox
        '
        Me.SQLTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.SQLTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SQLTextBox.Location = New System.Drawing.Point(3, 3)
        Me.SQLTextBox.Multiline = True
        Me.SQLTextBox.Name = "SQLTextBox"
        Me.SQLTextBox.Size = New System.Drawing.Size(737, 43)
        Me.SQLTextBox.TabIndex = 17
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClearQueryButton, Me.UndoButton, Me.ToolStripSeparator4, Me.OrLabel, Me.AndLabel, Me.BetweenLabel, Me.ToolStripSeparator1, Me.MenorQueLabel, Me.MenorIgualLabel, Me.IgualLabel, Me.MaiorIgualLabel, Me.MaiorQueLabel, Me.DiferenteLabel, Me.ToolStripSeparator2, Me.TabelasLabel, Me.TabelasCombo, Me.ColunasLabel, Me.ColunasCombo, Me.ToolStripSeparator3, Me.ExportExcelButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(794, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ClearQueryButton
        '
        Me.ClearQueryButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ClearQueryButton.Image = CType(resources.GetObject("ClearQueryButton.Image"), System.Drawing.Image)
        Me.ClearQueryButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ClearQueryButton.Name = "ClearQueryButton"
        Me.ClearQueryButton.Size = New System.Drawing.Size(23, 22)
        Me.ClearQueryButton.Text = "Resetar Query"
        '
        'UndoButton
        '
        Me.UndoButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.UndoButton.Image = CType(resources.GetObject("UndoButton.Image"), System.Drawing.Image)
        Me.UndoButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.UndoButton.Name = "UndoButton"
        Me.UndoButton.Size = New System.Drawing.Size(23, 22)
        Me.UndoButton.Text = "Desfazer"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 25)
        '
        'OrLabel
        '
        Me.OrLabel.Name = "OrLabel"
        Me.OrLabel.Size = New System.Drawing.Size(22, 22)
        Me.OrLabel.Text = "OR"
        '
        'AndLabel
        '
        Me.AndLabel.Name = "AndLabel"
        Me.AndLabel.Size = New System.Drawing.Size(28, 22)
        Me.AndLabel.Text = "AND"
        '
        'BetweenLabel
        '
        Me.BetweenLabel.Name = "BetweenLabel"
        Me.BetweenLabel.Size = New System.Drawing.Size(54, 22)
        Me.BetweenLabel.Text = "BETWEEN"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'MenorQueLabel
        '
        Me.MenorQueLabel.Name = "MenorQueLabel"
        Me.MenorQueLabel.Size = New System.Drawing.Size(15, 22)
        Me.MenorQueLabel.Text = "<"
        '
        'MenorIgualLabel
        '
        Me.MenorIgualLabel.Name = "MenorIgualLabel"
        Me.MenorIgualLabel.Size = New System.Drawing.Size(23, 22)
        Me.MenorIgualLabel.Text = "<="
        '
        'IgualLabel
        '
        Me.IgualLabel.Name = "IgualLabel"
        Me.IgualLabel.Size = New System.Drawing.Size(15, 22)
        Me.IgualLabel.Text = "="
        '
        'MaiorIgualLabel
        '
        Me.MaiorIgualLabel.Name = "MaiorIgualLabel"
        Me.MaiorIgualLabel.Size = New System.Drawing.Size(23, 22)
        Me.MaiorIgualLabel.Text = "=>"
        '
        'MaiorQueLabel
        '
        Me.MaiorQueLabel.Name = "MaiorQueLabel"
        Me.MaiorQueLabel.Size = New System.Drawing.Size(15, 22)
        Me.MaiorQueLabel.Text = ">"
        '
        'DiferenteLabel
        '
        Me.DiferenteLabel.Name = "DiferenteLabel"
        Me.DiferenteLabel.Size = New System.Drawing.Size(23, 22)
        Me.DiferenteLabel.Text = "<>"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TabelasLabel
        '
        Me.TabelasLabel.Name = "TabelasLabel"
        Me.TabelasLabel.Size = New System.Drawing.Size(44, 22)
        Me.TabelasLabel.Text = "Tabelas"
        '
        'TabelasCombo
        '
        Me.TabelasCombo.Name = "TabelasCombo"
        Me.TabelasCombo.Size = New System.Drawing.Size(121, 25)
        '
        'ColunasLabel
        '
        Me.ColunasLabel.Name = "ColunasLabel"
        Me.ColunasLabel.Size = New System.Drawing.Size(45, 22)
        Me.ColunasLabel.Text = "Colunas"
        '
        'ColunasCombo
        '
        Me.ColunasCombo.Name = "ColunasCombo"
        Me.ColunasCombo.Size = New System.Drawing.Size(121, 25)
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 25)
        '
        'ExportExcelButton
        '
        Me.ExportExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExportExcelButton.Image = CType(resources.GetObject("ExportExcelButton.Image"), System.Drawing.Image)
        Me.ExportExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExportExcelButton.Name = "ExportExcelButton"
        Me.ExportExcelButton.Size = New System.Drawing.Size(23, 22)
        Me.ExportExcelButton.Text = "Exportar para Excel"
        '
        'TerminalInterativoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(794, 676)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "TerminalInterativoForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DisplayResultsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ExecutaQueryButton As System.Windows.Forms.Button
    Friend WithEvents SQLTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents MenorQueLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MenorIgualLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IgualLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MaiorIgualLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents MaiorQueLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents DisplayResultsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents DiferenteLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents TabelasCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents TabelasLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ColunasLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents OrLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents AndLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BetweenLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ColunasCombo As System.Windows.Forms.ToolStripComboBox
    Friend WithEvents ToolStripSeparator3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents UndoButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ClearQueryButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator4 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExportExcelButton As System.Windows.Forms.ToolStripButton
End Class
