<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroVariaveisSistemaForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroVariaveisSistemaForm))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.VariavelNomeLabel = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.FinalizaEdicaoButton = New System.Windows.Forms.Button
        Me.Label2 = New System.Windows.Forms.Label
        Me.CodigoText = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.DescText = New System.Windows.Forms.TextBox
        Me.InserirVariavelButton = New System.Windows.Forms.Button
        Me.ProvedorErros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProvedorErros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.VariavelNomeLabel)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(344, 63)
        Me.Panel1.TabIndex = 2
        '
        'VariavelNomeLabel
        '
        Me.VariavelNomeLabel.AutoSize = True
        Me.VariavelNomeLabel.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VariavelNomeLabel.ForeColor = System.Drawing.Color.White
        Me.VariavelNomeLabel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.VariavelNomeLabel.Location = New System.Drawing.Point(13, 39)
        Me.VariavelNomeLabel.Name = "VariavelNomeLabel"
        Me.VariavelNomeLabel.Size = New System.Drawing.Size(130, 19)
        Me.VariavelNomeLabel.TabIndex = 3
        Me.VariavelNomeLabel.Text = "Nome da Variável"
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
        Me.Label1.Size = New System.Drawing.Size(322, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     Cadastro de Variáveis de Sistema"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 132)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(321, 371)
        Me.DataGridView1.TabIndex = 3
        '
        'FinalizaEdicaoButton
        '
        Me.FinalizaEdicaoButton.CausesValidation = False
        Me.FinalizaEdicaoButton.Image = CType(resources.GetObject("FinalizaEdicaoButton.Image"), System.Drawing.Image)
        Me.FinalizaEdicaoButton.Location = New System.Drawing.Point(284, 509)
        Me.FinalizaEdicaoButton.Name = "FinalizaEdicaoButton"
        Me.FinalizaEdicaoButton.Size = New System.Drawing.Size(50, 45)
        Me.FinalizaEdicaoButton.TabIndex = 15
        Me.FinalizaEdicaoButton.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(14, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Código:"
        '
        'CodigoText
        '
        Me.CodigoText.Location = New System.Drawing.Point(78, 78)
        Me.CodigoText.Name = "CodigoText"
        Me.CodigoText.Size = New System.Drawing.Size(198, 20)
        Me.CodigoText.TabIndex = 17
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(14, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 13)
        Me.Label3.TabIndex = 18
        Me.Label3.Text = "Descrição:"
        '
        'DescText
        '
        Me.DescText.Location = New System.Drawing.Point(78, 104)
        Me.DescText.Name = "DescText"
        Me.DescText.Size = New System.Drawing.Size(198, 20)
        Me.DescText.TabIndex = 19
        '
        'InserirVariavelButton
        '
        Me.InserirVariavelButton.CausesValidation = False
        Me.InserirVariavelButton.Image = CType(resources.GetObject("InserirVariavelButton.Image"), System.Drawing.Image)
        Me.InserirVariavelButton.Location = New System.Drawing.Point(282, 78)
        Me.InserirVariavelButton.Name = "InserirVariavelButton"
        Me.InserirVariavelButton.Size = New System.Drawing.Size(50, 48)
        Me.InserirVariavelButton.TabIndex = 20
        Me.InserirVariavelButton.UseVisualStyleBackColor = True
        '
        'ProvedorErros
        '
        Me.ProvedorErros.ContainerControl = Me
        '
        'CadastroVariaveisSistemaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 566)
        Me.Controls.Add(Me.InserirVariavelButton)
        Me.Controls.Add(Me.DescText)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.CodigoText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.FinalizaEdicaoButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CadastroVariaveisSistemaForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProvedorErros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents VariavelNomeLabel As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FinalizaEdicaoButton As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents CodigoText As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents DescText As System.Windows.Forms.TextBox
    Friend WithEvents InserirVariavelButton As System.Windows.Forms.Button
    Public WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents ProvedorErros As System.Windows.Forms.ErrorProvider
End Class
