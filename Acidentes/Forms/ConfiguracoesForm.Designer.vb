<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConfiguracoesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConfiguracoesForm))
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.Label1 = New System.Windows.Forms.Label
        Me.SalvaConfiguracoesButton = New System.Windows.Forms.Button
        Me.IntersecoesGroup = New System.Windows.Forms.GroupBox
        Me.ProcuraIntersecoesWarningCheck = New System.Windows.Forms.CheckBox
        Me.ProcuraIntersecoesCheck = New System.Windows.Forms.CheckBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.SairSemSalvarButton = New System.Windows.Forms.Button
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.AutoCompleteITCheck = New System.Windows.Forms.CheckBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.TextBox3 = New System.Windows.Forms.TextBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.Label3 = New System.Windows.Forms.Label
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.Panel2.SuspendLayout()
        Me.IntersecoesGroup.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.DimGray
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(283, 45)
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
        Me.Label1.Size = New System.Drawing.Size(259, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     Configurações do Sistema"
        '
        'SalvaConfiguracoesButton
        '
        Me.SalvaConfiguracoesButton.CausesValidation = False
        Me.SalvaConfiguracoesButton.Image = CType(resources.GetObject("SalvaConfiguracoesButton.Image"), System.Drawing.Image)
        Me.SalvaConfiguracoesButton.Location = New System.Drawing.Point(165, 325)
        Me.SalvaConfiguracoesButton.Name = "SalvaConfiguracoesButton"
        Me.SalvaConfiguracoesButton.Size = New System.Drawing.Size(50, 45)
        Me.SalvaConfiguracoesButton.TabIndex = 2
        Me.SalvaConfiguracoesButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SalvaConfiguracoesButton.UseVisualStyleBackColor = True
        '
        'IntersecoesGroup
        '
        Me.IntersecoesGroup.Controls.Add(Me.ProcuraIntersecoesWarningCheck)
        Me.IntersecoesGroup.Controls.Add(Me.ProcuraIntersecoesCheck)
        Me.IntersecoesGroup.Location = New System.Drawing.Point(12, 51)
        Me.IntersecoesGroup.Name = "IntersecoesGroup"
        Me.IntersecoesGroup.Size = New System.Drawing.Size(259, 70)
        Me.IntersecoesGroup.TabIndex = 0
        Me.IntersecoesGroup.TabStop = False
        Me.IntersecoesGroup.Text = "*Tratamento de Interseções:"
        '
        'ProcuraIntersecoesWarningCheck
        '
        Me.ProcuraIntersecoesWarningCheck.AutoSize = True
        Me.ProcuraIntersecoesWarningCheck.Location = New System.Drawing.Point(6, 42)
        Me.ProcuraIntersecoesWarningCheck.Name = "ProcuraIntersecoesWarningCheck"
        Me.ProcuraIntersecoesWarningCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProcuraIntersecoesWarningCheck.Size = New System.Drawing.Size(116, 17)
        Me.ProcuraIntersecoesWarningCheck.TabIndex = 1
        Me.ProcuraIntersecoesWarningCheck.Text = "Avisar o resultado?"
        Me.ProcuraIntersecoesWarningCheck.UseVisualStyleBackColor = True
        '
        'ProcuraIntersecoesCheck
        '
        Me.ProcuraIntersecoesCheck.AutoSize = True
        Me.ProcuraIntersecoesCheck.Location = New System.Drawing.Point(6, 19)
        Me.ProcuraIntersecoesCheck.Name = "ProcuraIntersecoesCheck"
        Me.ProcuraIntersecoesCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ProcuraIntersecoesCheck.Size = New System.Drawing.Size(228, 17)
        Me.ProcuraIntersecoesCheck.TabIndex = 0
        Me.ProcuraIntersecoesCheck.Text = "Procurar por interseções automaticamente:"
        Me.ProcuraIntersecoesCheck.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 296)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(213, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "*Você deve reiniciar o software para que as" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "configurações tenham efeito."
        '
        'SairSemSalvarButton
        '
        Me.SairSemSalvarButton.CausesValidation = False
        Me.SairSemSalvarButton.Image = CType(resources.GetObject("SairSemSalvarButton.Image"), System.Drawing.Image)
        Me.SairSemSalvarButton.Location = New System.Drawing.Point(221, 325)
        Me.SairSemSalvarButton.Name = "SairSemSalvarButton"
        Me.SairSemSalvarButton.Size = New System.Drawing.Size(50, 45)
        Me.SairSemSalvarButton.TabIndex = 3
        Me.SairSemSalvarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.SairSemSalvarButton.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.AutoCompleteITCheck)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 127)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(259, 60)
        Me.GroupBox2.TabIndex = 6
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "*Terminal Interativo"
        '
        'AutoCompleteITCheck
        '
        Me.AutoCompleteITCheck.AutoSize = True
        Me.AutoCompleteITCheck.Location = New System.Drawing.Point(5, 19)
        Me.AutoCompleteITCheck.Name = "AutoCompleteITCheck"
        Me.AutoCompleteITCheck.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.AutoCompleteITCheck.Size = New System.Drawing.Size(160, 30)
        Me.AutoCompleteITCheck.TabIndex = 1
        Me.AutoCompleteITCheck.Text = "Completar automaticamente " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "o critério de busca?"
        Me.AutoCompleteITCheck.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.AutoCompleteITCheck.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.TextBox2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 193)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(259, 100)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Configurações de Conexão"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(61, 71)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(192, 20)
        Me.TextBox3.TabIndex = 20
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(41, 13)
        Me.Label4.TabIndex = 19
        Me.Label4.Text = "Banco:"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(61, 45)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(192, 20)
        Me.TextBox2.TabIndex = 18
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 48)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "Porta:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(61, 19)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(192, 20)
        Me.TextBox1.TabIndex = 16
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 22)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(49, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Servidor:"
        '
        'ConfiguracoesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(283, 379)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.SairSemSalvarButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.IntersecoesGroup)
        Me.Controls.Add(Me.SalvaConfiguracoesButton)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "ConfiguracoesForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.IntersecoesGroup.ResumeLayout(False)
        Me.IntersecoesGroup.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents SalvaConfiguracoesButton As System.Windows.Forms.Button
    Friend WithEvents IntersecoesGroup As System.Windows.Forms.GroupBox
    Friend WithEvents ProcuraIntersecoesWarningCheck As System.Windows.Forms.CheckBox
    Friend WithEvents ProcuraIntersecoesCheck As System.Windows.Forms.CheckBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents SairSemSalvarButton As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AutoCompleteITCheck As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
End Class
