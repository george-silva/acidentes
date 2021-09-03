<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroUsuariosForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroUsuariosForm))
        Me.ErrorProvider1 = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label4 = New System.Windows.Forms.Label
        Me.CreateUserButton = New System.Windows.Forms.Button
        Me.DeleteUserButton = New System.Windows.Forms.Button
        Me.FecharCadastroUserButton = New System.Windows.Forms.Button
        Me.CadastroUserGroup = New System.Windows.Forms.GroupBox
        Me.AddUserPanel = New System.Windows.Forms.Panel
        Me.SuperuserCheckBox = New System.Windows.Forms.CheckBox
        Me.PasswordTextBox2 = New System.Windows.Forms.TextBox
        Me.UsernameTextBox = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.PasswordTextBox = New System.Windows.Forms.TextBox
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.UsuariosDatagrid = New System.Windows.Forms.DataGridView
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.CadastroUserGroup.SuspendLayout()
        Me.AddUserPanel.SuspendLayout()
        CType(Me.UsuariosDatagrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(556, 41)
        Me.Panel1.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Image = CType(resources.GetObject("Label4.Image"), System.Drawing.Image)
        Me.Label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label4.Location = New System.Drawing.Point(12, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(223, 26)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "      Cadastro de Usuários"
        '
        'CreateUserButton
        '
        Me.CreateUserButton.CausesValidation = False
        Me.CreateUserButton.Image = CType(resources.GetObject("CreateUserButton.Image"), System.Drawing.Image)
        Me.CreateUserButton.Location = New System.Drawing.Point(444, 172)
        Me.CreateUserButton.Name = "CreateUserButton"
        Me.CreateUserButton.Size = New System.Drawing.Size(50, 45)
        Me.CreateUserButton.TabIndex = 2
        Me.CreateUserButton.UseVisualStyleBackColor = True
        '
        'DeleteUserButton
        '
        Me.DeleteUserButton.CausesValidation = False
        Me.DeleteUserButton.Image = CType(resources.GetObject("DeleteUserButton.Image"), System.Drawing.Image)
        Me.DeleteUserButton.Location = New System.Drawing.Point(500, 172)
        Me.DeleteUserButton.Name = "DeleteUserButton"
        Me.DeleteUserButton.Size = New System.Drawing.Size(50, 45)
        Me.DeleteUserButton.TabIndex = 3
        Me.DeleteUserButton.UseVisualStyleBackColor = True
        '
        'FecharCadastroUserButton
        '
        Me.FecharCadastroUserButton.CausesValidation = False
        Me.FecharCadastroUserButton.Image = CType(resources.GetObject("FecharCadastroUserButton.Image"), System.Drawing.Image)
        Me.FecharCadastroUserButton.Location = New System.Drawing.Point(500, 223)
        Me.FecharCadastroUserButton.Name = "FecharCadastroUserButton"
        Me.FecharCadastroUserButton.Size = New System.Drawing.Size(50, 45)
        Me.FecharCadastroUserButton.TabIndex = 4
        Me.FecharCadastroUserButton.UseVisualStyleBackColor = True
        '
        'CadastroUserGroup
        '
        Me.CadastroUserGroup.Controls.Add(Me.AddUserPanel)
        Me.CadastroUserGroup.Location = New System.Drawing.Point(284, 47)
        Me.CadastroUserGroup.Name = "CadastroUserGroup"
        Me.CadastroUserGroup.Size = New System.Drawing.Size(266, 119)
        Me.CadastroUserGroup.TabIndex = 1
        Me.CadastroUserGroup.TabStop = False
        Me.CadastroUserGroup.Text = "Cadastrar Usuário:"
        '
        'AddUserPanel
        '
        Me.AddUserPanel.Controls.Add(Me.SuperuserCheckBox)
        Me.AddUserPanel.Controls.Add(Me.PasswordTextBox2)
        Me.AddUserPanel.Controls.Add(Me.UsernameTextBox)
        Me.AddUserPanel.Controls.Add(Me.Label5)
        Me.AddUserPanel.Controls.Add(Me.PasswordTextBox)
        Me.AddUserPanel.Controls.Add(Me.Label6)
        Me.AddUserPanel.Controls.Add(Me.Label7)
        Me.AddUserPanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AddUserPanel.Location = New System.Drawing.Point(3, 16)
        Me.AddUserPanel.Name = "AddUserPanel"
        Me.AddUserPanel.Size = New System.Drawing.Size(260, 100)
        Me.AddUserPanel.TabIndex = 12
        '
        'SuperuserCheckBox
        '
        Me.SuperuserCheckBox.AutoSize = True
        Me.SuperuserCheckBox.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.SuperuserCheckBox.Location = New System.Drawing.Point(167, 81)
        Me.SuperuserCheckBox.Name = "SuperuserCheckBox"
        Me.SuperuserCheckBox.Size = New System.Drawing.Size(89, 17)
        Me.SuperuserCheckBox.TabIndex = 3
        Me.SuperuserCheckBox.Text = "Administrador"
        Me.SuperuserCheckBox.UseVisualStyleBackColor = True
        '
        'PasswordTextBox2
        '
        Me.PasswordTextBox2.Location = New System.Drawing.Point(110, 55)
        Me.PasswordTextBox2.Name = "PasswordTextBox2"
        Me.PasswordTextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox2.Size = New System.Drawing.Size(146, 20)
        Me.PasswordTextBox2.TabIndex = 2
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Location = New System.Drawing.Point(110, 3)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.Size = New System.Drawing.Size(146, 20)
        Me.UsernameTextBox.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 6)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Nome de Usuário:"
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Location = New System.Drawing.Point(110, 29)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.Size = New System.Drawing.Size(146, 20)
        Me.PasswordTextBox.TabIndex = 1
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Confirme a Senha:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(63, 32)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Senha:"
        '
        'UsuariosDatagrid
        '
        Me.UsuariosDatagrid.AllowUserToAddRows = False
        Me.UsuariosDatagrid.AllowUserToDeleteRows = False
        Me.UsuariosDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UsuariosDatagrid.Location = New System.Drawing.Point(12, 47)
        Me.UsuariosDatagrid.Name = "UsuariosDatagrid"
        Me.UsuariosDatagrid.ReadOnly = True
        Me.UsuariosDatagrid.Size = New System.Drawing.Size(266, 221)
        Me.UsuariosDatagrid.TabIndex = 0
        '
        'CadastroUsuariosForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(556, 274)
        Me.Controls.Add(Me.UsuariosDatagrid)
        Me.Controls.Add(Me.CadastroUserGroup)
        Me.Controls.Add(Me.FecharCadastroUserButton)
        Me.Controls.Add(Me.DeleteUserButton)
        Me.Controls.Add(Me.CreateUserButton)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "CadastroUsuariosForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.CadastroUserGroup.ResumeLayout(False)
        Me.AddUserPanel.ResumeLayout(False)
        Me.AddUserPanel.PerformLayout()
        CType(Me.UsuariosDatagrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ErrorProvider1 As System.Windows.Forms.ErrorProvider
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents CreateUserButton As System.Windows.Forms.Button
    Friend WithEvents DeleteUserButton As System.Windows.Forms.Button
    Friend WithEvents FecharCadastroUserButton As System.Windows.Forms.Button
    Friend WithEvents CadastroUserGroup As System.Windows.Forms.GroupBox
    Friend WithEvents AddUserPanel As System.Windows.Forms.Panel
    Friend WithEvents SuperuserCheckBox As System.Windows.Forms.CheckBox
    Friend WithEvents PasswordTextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents UsernameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PasswordTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents UsuariosDatagrid As System.Windows.Forms.DataGridView
End Class
