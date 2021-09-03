<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadastroAcidenteForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadastroAcidenteForm))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Logradouros encontrados:")
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Panel2 = New System.Windows.Forms.Panel
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip
        Me.CadastrarAcidenteButton = New System.Windows.Forms.ToolStripButton
        Me.ResetAcidente = New System.Windows.Forms.ToolStripButton
        Me.TabControlMaster = New System.Windows.Forms.TabControl
        Me.AcidenteTabPage = New System.Windows.Forms.TabPage
        Me.InserirAcidenteButton = New System.Windows.Forms.Button
        Me.AcidentesDataGrid = New System.Windows.Forms.DataGridView
        Me.cod_acidente = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.no_boletim = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.data = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.hora = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.no_veiculos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.bairro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipolog = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.nomelog = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.numero = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.intersecao1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.intersecao2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_caracteristica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_causa = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_tipo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_caracteristicavia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_condicaovia = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_pavimentacao = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_tiposocorro = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_controletrafego = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_orgaoresponsavel = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.acid_clima = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CaracteristicaAcidenteGroup = New System.Windows.Forms.GroupBox
        Me.CaracteristicaAcidenteTable = New System.Windows.Forms.TableLayoutPanel
        Me.ObsLabel = New System.Windows.Forms.Label
        Me.ControleTrafegoCombo = New System.Windows.Forms.ComboBox
        Me.TipoPavimentacaoCombo = New System.Windows.Forms.ComboBox
        Me.TipoAcidenteCombo = New System.Windows.Forms.ComboBox
        Me.ControleTrafegoLabel = New System.Windows.Forms.Label
        Me.TipoPavimentacaoLabel = New System.Windows.Forms.Label
        Me.TipoAcidenteLabel = New System.Windows.Forms.Label
        Me.TipoSocorroCombo = New System.Windows.Forms.ComboBox
        Me.CondicaoViaCombo = New System.Windows.Forms.ComboBox
        Me.CausaAcidenteCombo = New System.Windows.Forms.ComboBox
        Me.TipoSocorroLabel = New System.Windows.Forms.Label
        Me.CondicaoViaLabel = New System.Windows.Forms.Label
        Me.CausaAcidenteLabel = New System.Windows.Forms.Label
        Me.ClimaCombo = New System.Windows.Forms.ComboBox
        Me.OrgaoResponsavelCombo = New System.Windows.Forms.ComboBox
        Me.CaracteristicaViaCombo = New System.Windows.Forms.ComboBox
        Me.ClimaLabel = New System.Windows.Forms.Label
        Me.OrgaoResponsavelLabel = New System.Windows.Forms.Label
        Me.CaracteristicaViaLabel = New System.Windows.Forms.Label
        Me.CaracteristicaAcidenteLabel = New System.Windows.Forms.Label
        Me.CaracteristicaAcidenteCombo = New System.Windows.Forms.ComboBox
        Me.ObsText = New System.Windows.Forms.TextBox
        Me.GeografiaGroup = New System.Windows.Forms.GroupBox
        Me.LocalizacaoTable = New System.Windows.Forms.TableLayoutPanel
        Me.NumeroText = New System.Windows.Forms.TextBox
        Me.NumeroLabel = New System.Windows.Forms.Label
        Me.NomeLogradouroLabel = New System.Windows.Forms.Label
        Me.TipoLogradouroLabel = New System.Windows.Forms.Label
        Me.BairroCombo = New System.Windows.Forms.ComboBox
        Me.TipoLogradouroCombo = New System.Windows.Forms.ComboBox
        Me.NomeLogradouroCombo = New System.Windows.Forms.ComboBox
        Me.BairroLabel = New System.Windows.Forms.Label
        Me.Intersecao1Label = New System.Windows.Forms.Label
        Me.Intersecao2Label = New System.Windows.Forms.Label
        Me.Intersecao1Combo = New System.Windows.Forms.ComboBox
        Me.Intersecao2Combo = New System.Windows.Forms.ComboBox
        Me.GeralGroup = New System.Windows.Forms.GroupBox
        Me.Acidente_HoraText = New System.Windows.Forms.MaskedTextBox
        Me.Acidente_DataText = New System.Windows.Forms.MaskedTextBox
        Me.Acidente_NoEnvolvidoNumeric = New System.Windows.Forms.NumericUpDown
        Me.NoEnvolvidoLabel = New System.Windows.Forms.Label
        Me.Acidente_NoBoText = New System.Windows.Forms.TextBox
        Me.HoraLabel = New System.Windows.Forms.Label
        Me.DataLabel = New System.Windows.Forms.Label
        Me.NoBoLabel = New System.Windows.Forms.Label
        Me.Acidente_CodAcidenteText = New System.Windows.Forms.TextBox
        Me.CodAcidenteLabel = New System.Windows.Forms.Label
        Me.VeiculoTabPage = New System.Windows.Forms.TabPage
        Me.InserirVeiculoButton = New System.Windows.Forms.Button
        Me.VeiculosDataGrid = New System.Windows.Forms.DataGridView
        Me.cod_veiculo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cod_acidente_veiculo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.tipo_veiculo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.placa_veiculo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.apreendido = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.no_ocupantes = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sentido_veiculo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.veic_equipseg = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sev_sem_danos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sev_danos_materiais = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sev_feridos_leves = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sev_feridos_graves = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sev_fatalidades = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.sev_nao_apurado = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SeveridadeGroup = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel
        Me.Veiculo_SeveridadeNA = New System.Windows.Forms.NumericUpDown
        Me.Veiculo_SeveridadeFatalidade = New System.Windows.Forms.NumericUpDown
        Me.Veiculo_SeveridadeFeridoGrave = New System.Windows.Forms.NumericUpDown
        Me.Veiculo_SeveridadeFeridoLeve = New System.Windows.Forms.NumericUpDown
        Me.Veiculo_SeveridadeDanoMaterial = New System.Windows.Forms.NumericUpDown
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Veiculo_SeveridadeSemDano = New System.Windows.Forms.NumericUpDown
        Me.VeiculoGroup = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label31 = New System.Windows.Forms.Label
        Me.Veiculo_NoOcupantesNumeric = New System.Windows.Forms.NumericUpDown
        Me.Veiculo_TipoVeiculoCombo = New System.Windows.Forms.ComboBox
        Me.Veiculo_ApreendidoCombo = New System.Windows.Forms.ComboBox
        Me.Veiculo_EquipSegurancaCombo = New System.Windows.Forms.ComboBox
        Me.Veiculo_SentidoVeiculoCombo = New System.Windows.Forms.ComboBox
        Me.Veiculo_PlacaVeiculoText = New System.Windows.Forms.MaskedTextBox
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.Veiculo_CodAcidenteText = New System.Windows.Forms.TextBox
        Me.Label34 = New System.Windows.Forms.Label
        Me.Veiculo_CodVeiculoText = New System.Windows.Forms.TextBox
        Me.Label35 = New System.Windows.Forms.Label
        Me.CondutorTabPage = New System.Windows.Forms.TabPage
        Me.InserirCondutorButton = New System.Windows.Forms.Button
        Me.CondutoresDataGrid = New System.Windows.Forms.DataGridView
        Me.cod_condutor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cod_veiculo_condutor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cod_acidente_condutor = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.estado_origem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cidade_origem = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.escolaridade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.profissao = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.habilitacao = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.comportamento = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.condicao_fisica = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.cond_sexo = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.data_nasc = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.data_hab = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.c_semdanos = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.c_feridoleve = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.c_feridograve = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.c_fatalidade = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.prontuario = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.Condutor_SeveridadeGroup = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel
        Me.Condutor_FatalidadeRadio = New System.Windows.Forms.RadioButton
        Me.Condutor_FeridoGraveRadio = New System.Windows.Forms.RadioButton
        Me.Condutor_FeridoLeveRadio = New System.Windows.Forms.RadioButton
        Me.Condutor_SemDanosRadio = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.Condutor_CidadeCombo = New System.Windows.Forms.ComboBox
        Me.Condutor_CidadeLabel = New System.Windows.Forms.Label
        Me.Condutor_HabilitacaoCombo = New System.Windows.Forms.ComboBox
        Me.Condutor_EstadoCombo = New System.Windows.Forms.ComboBox
        Me.Condutor_EstadoLabel = New System.Windows.Forms.Label
        Me.Label24 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.Condutor_DataHabilitacaoText = New System.Windows.Forms.MaskedTextBox
        Me.Condutor_InformacoesPessoaisGroup = New System.Windows.Forms.GroupBox
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel
        Me.Condutor_CondicaoCombo = New System.Windows.Forms.ComboBox
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Condutor_EscolaridadeCombo = New System.Windows.Forms.ComboBox
        Me.Condutor_ProfissaoCombo = New System.Windows.Forms.ComboBox
        Me.Condutor_ComportamentoCombo = New System.Windows.Forms.ComboBox
        Me.Condutor_DataNascimentoText = New System.Windows.Forms.MaskedTextBox
        Me.Label23 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.Label25 = New System.Windows.Forms.Label
        Me.Condutor_ProntuarioText = New System.Windows.Forms.TextBox
        Me.Label26 = New System.Windows.Forms.Label
        Me.Condutor_SexoCombo = New System.Windows.Forms.ComboBox
        Me.Condutor_InformacoesGeraisGroup = New System.Windows.Forms.GroupBox
        Me.Condutor_CodAcidenteText = New System.Windows.Forms.TextBox
        Me.Condutor_CodVeiculoLabel = New System.Windows.Forms.Label
        Me.Condutor_CodAcidenteLabel = New System.Windows.Forms.Label
        Me.Condutor_CodVeiculoText = New System.Windows.Forms.TextBox
        Me.Condutor_CodCondutorText = New System.Windows.Forms.TextBox
        Me.Condutor_CodCondutorLabel = New System.Windows.Forms.Label
        Me.Panel3 = New System.Windows.Forms.Panel
        Me.MapControlToolbar = New System.Windows.Forms.ToolStrip
        Me.ZoomInButton = New System.Windows.Forms.ToolStripButton
        Me.ZoomOutButton = New System.Windows.Forms.ToolStripButton
        Me.ZoomButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.PanLeftButton = New System.Windows.Forms.ToolStripButton
        Me.PanRightButton = New System.Windows.Forms.ToolStripButton
        Me.PanUpButton = New System.Windows.Forms.ToolStripButton
        Me.PanDownButton = New System.Windows.Forms.ToolStripButton
        Me.PanButton = New System.Windows.Forms.ToolStripButton
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.MapStatusStrip = New System.Windows.Forms.StatusStrip
        Me.ScaleLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.ScaleDenominatorLabel = New System.Windows.Forms.ToolStripStatusLabel
        Me.AxMap = New ESRI.ArcGIS.Controls.AxMapControl
        Me.Panel4 = New System.Windows.Forms.Panel
        Me.Label3 = New System.Windows.Forms.Label
        Me.Panel5 = New System.Windows.Forms.Panel
        Me.DisplayResults = New System.Windows.Forms.TreeView
        Me.LogSearchToolbar = New System.Windows.Forms.ToolStrip
        Me.LogSearchText = New System.Windows.Forms.ToolStripTextBox
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton
        Me.ProvedorErros = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControlMaster.SuspendLayout()
        Me.AcidenteTabPage.SuspendLayout()
        CType(Me.AcidentesDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CaracteristicaAcidenteGroup.SuspendLayout()
        Me.CaracteristicaAcidenteTable.SuspendLayout()
        Me.GeografiaGroup.SuspendLayout()
        Me.LocalizacaoTable.SuspendLayout()
        Me.GeralGroup.SuspendLayout()
        CType(Me.Acidente_NoEnvolvidoNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VeiculoTabPage.SuspendLayout()
        CType(Me.VeiculosDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SeveridadeGroup.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.Veiculo_SeveridadeNA, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Veiculo_SeveridadeFatalidade, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Veiculo_SeveridadeFeridoGrave, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Veiculo_SeveridadeFeridoLeve, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Veiculo_SeveridadeDanoMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Veiculo_SeveridadeSemDano, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VeiculoGroup.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.Veiculo_NoOcupantesNumeric, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.CondutorTabPage.SuspendLayout()
        CType(Me.CondutoresDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Condutor_SeveridadeGroup.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.Condutor_InformacoesPessoaisGroup.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        Me.Condutor_InformacoesGeraisGroup.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.MapControlToolbar.SuspendLayout()
        Me.MapStatusStrip.SuspendLayout()
        CType(Me.AxMap, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.LogSearchToolbar.SuspendLayout()
        CType(Me.ProvedorErros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1018, 41)
        Me.Panel1.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(941, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Versão 0.1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(6, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(230, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     Cadastro de Acidentes"
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel2.Controls.Add(Me.ToolStrip1)
        Me.Panel2.Controls.Add(Me.TabControlMaster)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 41)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(722, 703)
        Me.Panel2.TabIndex = 2
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrarAcidenteButton, Me.ResetAcidente})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ToolStrip1.Size = New System.Drawing.Size(718, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CadastrarAcidenteButton
        '
        Me.CadastrarAcidenteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CadastrarAcidenteButton.Image = CType(resources.GetObject("CadastrarAcidenteButton.Image"), System.Drawing.Image)
        Me.CadastrarAcidenteButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CadastrarAcidenteButton.Name = "CadastrarAcidenteButton"
        Me.CadastrarAcidenteButton.Size = New System.Drawing.Size(23, 22)
        Me.CadastrarAcidenteButton.Text = "Cadastrar Acidente"
        '
        'ResetAcidente
        '
        Me.ResetAcidente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ResetAcidente.Image = CType(resources.GetObject("ResetAcidente.Image"), System.Drawing.Image)
        Me.ResetAcidente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ResetAcidente.Name = "ResetAcidente"
        Me.ResetAcidente.Size = New System.Drawing.Size(23, 22)
        Me.ResetAcidente.Text = "Limpar todas informações"
        Me.ResetAcidente.ToolTipText = "Limpar todas informações"
        '
        'TabControlMaster
        '
        Me.TabControlMaster.Controls.Add(Me.AcidenteTabPage)
        Me.TabControlMaster.Controls.Add(Me.VeiculoTabPage)
        Me.TabControlMaster.Controls.Add(Me.CondutorTabPage)
        Me.TabControlMaster.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.TabControlMaster.Location = New System.Drawing.Point(0, 28)
        Me.TabControlMaster.Name = "TabControlMaster"
        Me.TabControlMaster.SelectedIndex = 0
        Me.TabControlMaster.Size = New System.Drawing.Size(718, 671)
        Me.TabControlMaster.TabIndex = 3
        '
        'AcidenteTabPage
        '
        Me.AcidenteTabPage.Controls.Add(Me.InserirAcidenteButton)
        Me.AcidenteTabPage.Controls.Add(Me.AcidentesDataGrid)
        Me.AcidenteTabPage.Controls.Add(Me.CaracteristicaAcidenteGroup)
        Me.AcidenteTabPage.Controls.Add(Me.GeografiaGroup)
        Me.AcidenteTabPage.Controls.Add(Me.GeralGroup)
        Me.AcidenteTabPage.Location = New System.Drawing.Point(4, 22)
        Me.AcidenteTabPage.Name = "AcidenteTabPage"
        Me.AcidenteTabPage.Size = New System.Drawing.Size(710, 645)
        Me.AcidenteTabPage.TabIndex = 0
        Me.AcidenteTabPage.Text = "Acidente"
        Me.AcidenteTabPage.UseVisualStyleBackColor = True
        '
        'InserirAcidenteButton
        '
        Me.InserirAcidenteButton.CausesValidation = False
        Me.InserirAcidenteButton.Image = CType(resources.GetObject("InserirAcidenteButton.Image"), System.Drawing.Image)
        Me.InserirAcidenteButton.Location = New System.Drawing.Point(653, 374)
        Me.InserirAcidenteButton.Name = "InserirAcidenteButton"
        Me.InserirAcidenteButton.Size = New System.Drawing.Size(50, 45)
        Me.InserirAcidenteButton.TabIndex = 14
        Me.InserirAcidenteButton.UseVisualStyleBackColor = True
        '
        'AcidentesDataGrid
        '
        Me.AcidentesDataGrid.AllowUserToAddRows = False
        Me.AcidentesDataGrid.AllowUserToResizeColumns = False
        Me.AcidentesDataGrid.AllowUserToResizeRows = False
        Me.AcidentesDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AcidentesDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_acidente, Me.no_boletim, Me.data, Me.hora, Me.no_veiculos, Me.bairro, Me.tipolog, Me.nomelog, Me.numero, Me.intersecao1, Me.intersecao2, Me.acid_caracteristica, Me.acid_causa, Me.acid_tipo, Me.acid_caracteristicavia, Me.acid_condicaovia, Me.acid_pavimentacao, Me.acid_tiposocorro, Me.acid_controletrafego, Me.acid_orgaoresponsavel, Me.acid_clima})
        Me.AcidentesDataGrid.Location = New System.Drawing.Point(3, 425)
        Me.AcidentesDataGrid.Name = "AcidentesDataGrid"
        Me.AcidentesDataGrid.ReadOnly = True
        Me.AcidentesDataGrid.Size = New System.Drawing.Size(700, 214)
        Me.AcidentesDataGrid.TabIndex = 13
        '
        'cod_acidente
        '
        Me.cod_acidente.Frozen = True
        Me.cod_acidente.HeaderText = "Código Acidente"
        Me.cod_acidente.Name = "cod_acidente"
        Me.cod_acidente.ReadOnly = True
        Me.cod_acidente.Width = 60
        '
        'no_boletim
        '
        Me.no_boletim.HeaderText = "Número Boletim"
        Me.no_boletim.Name = "no_boletim"
        Me.no_boletim.ReadOnly = True
        Me.no_boletim.Width = 60
        '
        'data
        '
        Me.data.HeaderText = "Data do Acidente"
        Me.data.Name = "data"
        Me.data.ReadOnly = True
        Me.data.Width = 60
        '
        'hora
        '
        Me.hora.HeaderText = "Hora do Acidente"
        Me.hora.Name = "hora"
        Me.hora.ReadOnly = True
        Me.hora.Width = 60
        '
        'no_veiculos
        '
        Me.no_veiculos.HeaderText = "Número de Veículos Envolvidos"
        Me.no_veiculos.Name = "no_veiculos"
        Me.no_veiculos.ReadOnly = True
        Me.no_veiculos.Width = 60
        '
        'bairro
        '
        Me.bairro.HeaderText = "Bairro"
        Me.bairro.Name = "bairro"
        Me.bairro.ReadOnly = True
        Me.bairro.Width = 60
        '
        'tipolog
        '
        Me.tipolog.HeaderText = "Tipo do Logradouro"
        Me.tipolog.Name = "tipolog"
        Me.tipolog.ReadOnly = True
        Me.tipolog.Width = 75
        '
        'nomelog
        '
        Me.nomelog.HeaderText = "Nome do Logradouro"
        Me.nomelog.Name = "nomelog"
        Me.nomelog.ReadOnly = True
        Me.nomelog.Width = 75
        '
        'numero
        '
        Me.numero.HeaderText = "Número"
        Me.numero.Name = "numero"
        Me.numero.ReadOnly = True
        Me.numero.Width = 60
        '
        'intersecao1
        '
        Me.intersecao1.HeaderText = "Interseção Anterior"
        Me.intersecao1.Name = "intersecao1"
        Me.intersecao1.ReadOnly = True
        Me.intersecao1.Width = 75
        '
        'intersecao2
        '
        Me.intersecao2.HeaderText = "Interseção Posterior"
        Me.intersecao2.Name = "intersecao2"
        Me.intersecao2.ReadOnly = True
        Me.intersecao2.Width = 75
        '
        'acid_caracteristica
        '
        Me.acid_caracteristica.HeaderText = "Característica do Acidente"
        Me.acid_caracteristica.Name = "acid_caracteristica"
        Me.acid_caracteristica.ReadOnly = True
        '
        'acid_causa
        '
        Me.acid_causa.HeaderText = "Causa do Acidente"
        Me.acid_causa.Name = "acid_causa"
        Me.acid_causa.ReadOnly = True
        '
        'acid_tipo
        '
        Me.acid_tipo.HeaderText = "Tipo do Acidente"
        Me.acid_tipo.Name = "acid_tipo"
        Me.acid_tipo.ReadOnly = True
        '
        'acid_caracteristicavia
        '
        Me.acid_caracteristicavia.HeaderText = "Característica da Via"
        Me.acid_caracteristicavia.Name = "acid_caracteristicavia"
        Me.acid_caracteristicavia.ReadOnly = True
        '
        'acid_condicaovia
        '
        Me.acid_condicaovia.HeaderText = "Condição da Via"
        Me.acid_condicaovia.Name = "acid_condicaovia"
        Me.acid_condicaovia.ReadOnly = True
        '
        'acid_pavimentacao
        '
        Me.acid_pavimentacao.HeaderText = "Tipo de Pavimentação"
        Me.acid_pavimentacao.Name = "acid_pavimentacao"
        Me.acid_pavimentacao.ReadOnly = True
        '
        'acid_tiposocorro
        '
        Me.acid_tiposocorro.HeaderText = "Tipo de Socorro"
        Me.acid_tiposocorro.Name = "acid_tiposocorro"
        Me.acid_tiposocorro.ReadOnly = True
        '
        'acid_controletrafego
        '
        Me.acid_controletrafego.HeaderText = "Controle de Tráfego"
        Me.acid_controletrafego.Name = "acid_controletrafego"
        Me.acid_controletrafego.ReadOnly = True
        '
        'acid_orgaoresponsavel
        '
        Me.acid_orgaoresponsavel.HeaderText = "Órgão Responsável"
        Me.acid_orgaoresponsavel.Name = "acid_orgaoresponsavel"
        Me.acid_orgaoresponsavel.ReadOnly = True
        '
        'acid_clima
        '
        Me.acid_clima.HeaderText = "Clima"
        Me.acid_clima.Name = "acid_clima"
        Me.acid_clima.ReadOnly = True
        '
        'CaracteristicaAcidenteGroup
        '
        Me.CaracteristicaAcidenteGroup.Controls.Add(Me.CaracteristicaAcidenteTable)
        Me.CaracteristicaAcidenteGroup.Location = New System.Drawing.Point(3, 213)
        Me.CaracteristicaAcidenteGroup.Name = "CaracteristicaAcidenteGroup"
        Me.CaracteristicaAcidenteGroup.Padding = New System.Windows.Forms.Padding(5)
        Me.CaracteristicaAcidenteGroup.Size = New System.Drawing.Size(700, 155)
        Me.CaracteristicaAcidenteGroup.TabIndex = 12
        Me.CaracteristicaAcidenteGroup.TabStop = False
        Me.CaracteristicaAcidenteGroup.Text = "Característica do Acidente"
        '
        'CaracteristicaAcidenteTable
        '
        Me.CaracteristicaAcidenteTable.ColumnCount = 4
        Me.CaracteristicaAcidenteTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CaracteristicaAcidenteTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CaracteristicaAcidenteTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CaracteristicaAcidenteTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.ObsLabel, 3, 2)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.ControleTrafegoCombo, 2, 5)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.TipoPavimentacaoCombo, 1, 5)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.TipoAcidenteCombo, 0, 5)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.ControleTrafegoLabel, 2, 4)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.TipoPavimentacaoLabel, 1, 4)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.TipoAcidenteLabel, 0, 4)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.TipoSocorroCombo, 2, 3)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CondicaoViaCombo, 1, 3)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CausaAcidenteCombo, 0, 3)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.TipoSocorroLabel, 2, 2)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CondicaoViaLabel, 1, 2)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CausaAcidenteLabel, 0, 2)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.ClimaCombo, 3, 1)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.OrgaoResponsavelCombo, 2, 1)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CaracteristicaViaCombo, 1, 1)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.ClimaLabel, 3, 0)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.OrgaoResponsavelLabel, 2, 0)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CaracteristicaViaLabel, 1, 0)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CaracteristicaAcidenteLabel, 0, 0)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.CaracteristicaAcidenteCombo, 0, 1)
        Me.CaracteristicaAcidenteTable.Controls.Add(Me.ObsText, 3, 3)
        Me.CaracteristicaAcidenteTable.Location = New System.Drawing.Point(12, 16)
        Me.CaracteristicaAcidenteTable.Name = "CaracteristicaAcidenteTable"
        Me.CaracteristicaAcidenteTable.RowCount = 6
        Me.CaracteristicaAcidenteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.CaracteristicaAcidenteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.CaracteristicaAcidenteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.CaracteristicaAcidenteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.CaracteristicaAcidenteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.CaracteristicaAcidenteTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.CaracteristicaAcidenteTable.Size = New System.Drawing.Size(671, 131)
        Me.CaracteristicaAcidenteTable.TabIndex = 1
        '
        'ObsLabel
        '
        Me.ObsLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ObsLabel.AutoSize = True
        Me.ObsLabel.Location = New System.Drawing.Point(504, 45)
        Me.ObsLabel.Name = "ObsLabel"
        Me.ObsLabel.Size = New System.Drawing.Size(73, 13)
        Me.ObsLabel.TabIndex = 15
        Me.ObsLabel.Text = "Observações:"
        '
        'ControleTrafegoCombo
        '
        Me.ControleTrafegoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ControleTrafegoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ControleTrafegoCombo.FormattingEnabled = True
        Me.ControleTrafegoCombo.Location = New System.Drawing.Point(337, 102)
        Me.ControleTrafegoCombo.Name = "ControleTrafegoCombo"
        Me.ControleTrafegoCombo.Size = New System.Drawing.Size(161, 21)
        Me.ControleTrafegoCombo.TabIndex = 18
        '
        'TipoPavimentacaoCombo
        '
        Me.TipoPavimentacaoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoPavimentacaoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoPavimentacaoCombo.FormattingEnabled = True
        Me.TipoPavimentacaoCombo.Location = New System.Drawing.Point(170, 102)
        Me.TipoPavimentacaoCombo.Name = "TipoPavimentacaoCombo"
        Me.TipoPavimentacaoCombo.Size = New System.Drawing.Size(161, 21)
        Me.TipoPavimentacaoCombo.TabIndex = 15
        '
        'TipoAcidenteCombo
        '
        Me.TipoAcidenteCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoAcidenteCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoAcidenteCombo.FormattingEnabled = True
        Me.TipoAcidenteCombo.Location = New System.Drawing.Point(3, 102)
        Me.TipoAcidenteCombo.Name = "TipoAcidenteCombo"
        Me.TipoAcidenteCombo.Size = New System.Drawing.Size(161, 21)
        Me.TipoAcidenteCombo.TabIndex = 12
        '
        'ControleTrafegoLabel
        '
        Me.ControleTrafegoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ControleTrafegoLabel.AutoSize = True
        Me.ControleTrafegoLabel.Location = New System.Drawing.Point(337, 86)
        Me.ControleTrafegoLabel.Name = "ControleTrafegoLabel"
        Me.ControleTrafegoLabel.Size = New System.Drawing.Size(104, 13)
        Me.ControleTrafegoLabel.TabIndex = 30
        Me.ControleTrafegoLabel.Text = "Controle de Tráfego:"
        '
        'TipoPavimentacaoLabel
        '
        Me.TipoPavimentacaoLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipoPavimentacaoLabel.AutoSize = True
        Me.TipoPavimentacaoLabel.Location = New System.Drawing.Point(170, 86)
        Me.TipoPavimentacaoLabel.Name = "TipoPavimentacaoLabel"
        Me.TipoPavimentacaoLabel.Size = New System.Drawing.Size(117, 13)
        Me.TipoPavimentacaoLabel.TabIndex = 29
        Me.TipoPavimentacaoLabel.Text = "Tipo de Pavimentação:"
        '
        'TipoAcidenteLabel
        '
        Me.TipoAcidenteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipoAcidenteLabel.AutoSize = True
        Me.TipoAcidenteLabel.Location = New System.Drawing.Point(3, 86)
        Me.TipoAcidenteLabel.Name = "TipoAcidenteLabel"
        Me.TipoAcidenteLabel.Size = New System.Drawing.Size(91, 13)
        Me.TipoAcidenteLabel.TabIndex = 28
        Me.TipoAcidenteLabel.Text = "Tipo do Acidente:"
        '
        'TipoSocorroCombo
        '
        Me.TipoSocorroCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoSocorroCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoSocorroCombo.FormattingEnabled = True
        Me.TipoSocorroCombo.Location = New System.Drawing.Point(337, 61)
        Me.TipoSocorroCombo.Name = "TipoSocorroCombo"
        Me.TipoSocorroCombo.Size = New System.Drawing.Size(161, 21)
        Me.TipoSocorroCombo.TabIndex = 17
        '
        'CondicaoViaCombo
        '
        Me.CondicaoViaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CondicaoViaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CondicaoViaCombo.FormattingEnabled = True
        Me.CondicaoViaCombo.Location = New System.Drawing.Point(170, 61)
        Me.CondicaoViaCombo.Name = "CondicaoViaCombo"
        Me.CondicaoViaCombo.Size = New System.Drawing.Size(161, 21)
        Me.CondicaoViaCombo.TabIndex = 14
        '
        'CausaAcidenteCombo
        '
        Me.CausaAcidenteCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CausaAcidenteCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CausaAcidenteCombo.FormattingEnabled = True
        Me.CausaAcidenteCombo.Location = New System.Drawing.Point(3, 61)
        Me.CausaAcidenteCombo.Name = "CausaAcidenteCombo"
        Me.CausaAcidenteCombo.Size = New System.Drawing.Size(161, 21)
        Me.CausaAcidenteCombo.TabIndex = 11
        '
        'TipoSocorroLabel
        '
        Me.TipoSocorroLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipoSocorroLabel.AutoSize = True
        Me.TipoSocorroLabel.Location = New System.Drawing.Point(337, 45)
        Me.TipoSocorroLabel.Name = "TipoSocorroLabel"
        Me.TipoSocorroLabel.Size = New System.Drawing.Size(131, 13)
        Me.TipoSocorroLabel.TabIndex = 22
        Me.TipoSocorroLabel.Text = "Tipo de Socorro Prestado:"
        '
        'CondicaoViaLabel
        '
        Me.CondicaoViaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CondicaoViaLabel.AutoSize = True
        Me.CondicaoViaLabel.Location = New System.Drawing.Point(170, 45)
        Me.CondicaoViaLabel.Name = "CondicaoViaLabel"
        Me.CondicaoViaLabel.Size = New System.Drawing.Size(88, 13)
        Me.CondicaoViaLabel.TabIndex = 21
        Me.CondicaoViaLabel.Text = "Condição da Via:"
        '
        'CausaAcidenteLabel
        '
        Me.CausaAcidenteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CausaAcidenteLabel.AutoSize = True
        Me.CausaAcidenteLabel.Location = New System.Drawing.Point(3, 45)
        Me.CausaAcidenteLabel.Name = "CausaAcidenteLabel"
        Me.CausaAcidenteLabel.Size = New System.Drawing.Size(100, 13)
        Me.CausaAcidenteLabel.TabIndex = 20
        Me.CausaAcidenteLabel.Text = "Causa do Acidente:"
        '
        'ClimaCombo
        '
        Me.ClimaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.ClimaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ClimaCombo.FormattingEnabled = True
        Me.ClimaCombo.Location = New System.Drawing.Point(504, 20)
        Me.ClimaCombo.Name = "ClimaCombo"
        Me.ClimaCombo.Size = New System.Drawing.Size(164, 21)
        Me.ClimaCombo.TabIndex = 19
        '
        'OrgaoResponsavelCombo
        '
        Me.OrgaoResponsavelCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.OrgaoResponsavelCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.OrgaoResponsavelCombo.FormattingEnabled = True
        Me.OrgaoResponsavelCombo.Location = New System.Drawing.Point(337, 20)
        Me.OrgaoResponsavelCombo.Name = "OrgaoResponsavelCombo"
        Me.OrgaoResponsavelCombo.Size = New System.Drawing.Size(161, 21)
        Me.OrgaoResponsavelCombo.TabIndex = 16
        '
        'CaracteristicaViaCombo
        '
        Me.CaracteristicaViaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CaracteristicaViaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CaracteristicaViaCombo.FormattingEnabled = True
        Me.CaracteristicaViaCombo.Location = New System.Drawing.Point(170, 20)
        Me.CaracteristicaViaCombo.Name = "CaracteristicaViaCombo"
        Me.CaracteristicaViaCombo.Size = New System.Drawing.Size(161, 21)
        Me.CaracteristicaViaCombo.TabIndex = 13
        '
        'ClimaLabel
        '
        Me.ClimaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ClimaLabel.AutoSize = True
        Me.ClimaLabel.Location = New System.Drawing.Point(504, 4)
        Me.ClimaLabel.Name = "ClimaLabel"
        Me.ClimaLabel.Size = New System.Drawing.Size(35, 13)
        Me.ClimaLabel.TabIndex = 16
        Me.ClimaLabel.Text = "Clima:"
        '
        'OrgaoResponsavelLabel
        '
        Me.OrgaoResponsavelLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.OrgaoResponsavelLabel.AutoSize = True
        Me.OrgaoResponsavelLabel.Location = New System.Drawing.Point(337, 4)
        Me.OrgaoResponsavelLabel.Name = "OrgaoResponsavelLabel"
        Me.OrgaoResponsavelLabel.Size = New System.Drawing.Size(104, 13)
        Me.OrgaoResponsavelLabel.TabIndex = 15
        Me.OrgaoResponsavelLabel.Text = "Órgão Responsável:"
        '
        'CaracteristicaViaLabel
        '
        Me.CaracteristicaViaLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CaracteristicaViaLabel.AutoSize = True
        Me.CaracteristicaViaLabel.Location = New System.Drawing.Point(170, 4)
        Me.CaracteristicaViaLabel.Name = "CaracteristicaViaLabel"
        Me.CaracteristicaViaLabel.Size = New System.Drawing.Size(109, 13)
        Me.CaracteristicaViaLabel.TabIndex = 14
        Me.CaracteristicaViaLabel.Text = "Característica da Via:"
        '
        'CaracteristicaAcidenteLabel
        '
        Me.CaracteristicaAcidenteLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.CaracteristicaAcidenteLabel.AutoSize = True
        Me.CaracteristicaAcidenteLabel.Location = New System.Drawing.Point(3, 4)
        Me.CaracteristicaAcidenteLabel.Name = "CaracteristicaAcidenteLabel"
        Me.CaracteristicaAcidenteLabel.Size = New System.Drawing.Size(136, 13)
        Me.CaracteristicaAcidenteLabel.TabIndex = 13
        Me.CaracteristicaAcidenteLabel.Text = "Característica do Acidente:"
        '
        'CaracteristicaAcidenteCombo
        '
        Me.CaracteristicaAcidenteCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.CaracteristicaAcidenteCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CaracteristicaAcidenteCombo.FormattingEnabled = True
        Me.CaracteristicaAcidenteCombo.Location = New System.Drawing.Point(3, 20)
        Me.CaracteristicaAcidenteCombo.Name = "CaracteristicaAcidenteCombo"
        Me.CaracteristicaAcidenteCombo.Size = New System.Drawing.Size(161, 21)
        Me.CaracteristicaAcidenteCombo.TabIndex = 10
        '
        'ObsText
        '
        Me.ObsText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.ObsText.Location = New System.Drawing.Point(504, 61)
        Me.ObsText.MaxLength = 1200
        Me.ObsText.Name = "ObsText"
        Me.ObsText.Size = New System.Drawing.Size(164, 20)
        Me.ObsText.TabIndex = 31
        '
        'GeografiaGroup
        '
        Me.GeografiaGroup.Controls.Add(Me.LocalizacaoTable)
        Me.GeografiaGroup.Location = New System.Drawing.Point(3, 52)
        Me.GeografiaGroup.Name = "GeografiaGroup"
        Me.GeografiaGroup.Padding = New System.Windows.Forms.Padding(5)
        Me.GeografiaGroup.Size = New System.Drawing.Size(700, 155)
        Me.GeografiaGroup.TabIndex = 11
        Me.GeografiaGroup.TabStop = False
        Me.GeografiaGroup.Text = "Localização:"
        '
        'LocalizacaoTable
        '
        Me.LocalizacaoTable.ColumnCount = 4
        Me.LocalizacaoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LocalizacaoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LocalizacaoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LocalizacaoTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.LocalizacaoTable.Controls.Add(Me.NumeroText, 3, 1)
        Me.LocalizacaoTable.Controls.Add(Me.NumeroLabel, 3, 0)
        Me.LocalizacaoTable.Controls.Add(Me.NomeLogradouroLabel, 2, 0)
        Me.LocalizacaoTable.Controls.Add(Me.TipoLogradouroLabel, 1, 0)
        Me.LocalizacaoTable.Controls.Add(Me.BairroCombo, 0, 1)
        Me.LocalizacaoTable.Controls.Add(Me.TipoLogradouroCombo, 1, 1)
        Me.LocalizacaoTable.Controls.Add(Me.NomeLogradouroCombo, 2, 1)
        Me.LocalizacaoTable.Controls.Add(Me.BairroLabel, 0, 0)
        Me.LocalizacaoTable.Controls.Add(Me.Intersecao1Label, 2, 2)
        Me.LocalizacaoTable.Controls.Add(Me.Intersecao2Label, 2, 4)
        Me.LocalizacaoTable.Controls.Add(Me.Intersecao1Combo, 2, 3)
        Me.LocalizacaoTable.Controls.Add(Me.Intersecao2Combo, 2, 5)
        Me.LocalizacaoTable.Location = New System.Drawing.Point(11, 21)
        Me.LocalizacaoTable.Name = "LocalizacaoTable"
        Me.LocalizacaoTable.RowCount = 6
        Me.LocalizacaoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.LocalizacaoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.LocalizacaoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.LocalizacaoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.LocalizacaoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.LocalizacaoTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.LocalizacaoTable.Size = New System.Drawing.Size(672, 126)
        Me.LocalizacaoTable.TabIndex = 0
        '
        'NumeroText
        '
        Me.NumeroText.Location = New System.Drawing.Point(507, 20)
        Me.NumeroText.MaxLength = 8
        Me.NumeroText.Name = "NumeroText"
        Me.NumeroText.Size = New System.Drawing.Size(50, 20)
        Me.NumeroText.TabIndex = 7
        '
        'NumeroLabel
        '
        Me.NumeroLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NumeroLabel.AutoSize = True
        Me.NumeroLabel.Location = New System.Drawing.Point(507, 4)
        Me.NumeroLabel.Name = "NumeroLabel"
        Me.NumeroLabel.Size = New System.Drawing.Size(47, 13)
        Me.NumeroLabel.TabIndex = 7
        Me.NumeroLabel.Text = "Número:"
        '
        'NomeLogradouroLabel
        '
        Me.NomeLogradouroLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.NomeLogradouroLabel.AutoSize = True
        Me.NomeLogradouroLabel.Location = New System.Drawing.Point(339, 4)
        Me.NomeLogradouroLabel.Name = "NomeLogradouroLabel"
        Me.NomeLogradouroLabel.Size = New System.Drawing.Size(110, 13)
        Me.NomeLogradouroLabel.TabIndex = 6
        Me.NomeLogradouroLabel.Text = "Nome do Logradouro:"
        '
        'TipoLogradouroLabel
        '
        Me.TipoLogradouroLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.TipoLogradouroLabel.AutoSize = True
        Me.TipoLogradouroLabel.Location = New System.Drawing.Point(171, 4)
        Me.TipoLogradouroLabel.Name = "TipoLogradouroLabel"
        Me.TipoLogradouroLabel.Size = New System.Drawing.Size(103, 13)
        Me.TipoLogradouroLabel.TabIndex = 5
        Me.TipoLogradouroLabel.Text = "Tipo do Logradouro:"
        '
        'BairroCombo
        '
        Me.BairroCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.BairroCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.BairroCombo.FormattingEnabled = True
        Me.BairroCombo.Location = New System.Drawing.Point(3, 20)
        Me.BairroCombo.Name = "BairroCombo"
        Me.BairroCombo.Size = New System.Drawing.Size(162, 21)
        Me.BairroCombo.TabIndex = 4
        '
        'TipoLogradouroCombo
        '
        Me.TipoLogradouroCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.TipoLogradouroCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.TipoLogradouroCombo.FormattingEnabled = True
        Me.TipoLogradouroCombo.Location = New System.Drawing.Point(171, 20)
        Me.TipoLogradouroCombo.Name = "TipoLogradouroCombo"
        Me.TipoLogradouroCombo.Size = New System.Drawing.Size(162, 21)
        Me.TipoLogradouroCombo.TabIndex = 5
        '
        'NomeLogradouroCombo
        '
        Me.NomeLogradouroCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.NomeLogradouroCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.NomeLogradouroCombo.FormattingEnabled = True
        Me.NomeLogradouroCombo.Location = New System.Drawing.Point(339, 20)
        Me.NomeLogradouroCombo.Name = "NomeLogradouroCombo"
        Me.NomeLogradouroCombo.Size = New System.Drawing.Size(162, 21)
        Me.NomeLogradouroCombo.TabIndex = 6
        '
        'BairroLabel
        '
        Me.BairroLabel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.BairroLabel.AutoSize = True
        Me.BairroLabel.Location = New System.Drawing.Point(3, 4)
        Me.BairroLabel.Name = "BairroLabel"
        Me.BairroLabel.Size = New System.Drawing.Size(37, 13)
        Me.BairroLabel.TabIndex = 4
        Me.BairroLabel.Text = "Bairro:"
        '
        'Intersecao1Label
        '
        Me.Intersecao1Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Intersecao1Label.AutoSize = True
        Me.Intersecao1Label.Location = New System.Drawing.Point(339, 45)
        Me.Intersecao1Label.Name = "Intersecao1Label"
        Me.Intersecao1Label.Size = New System.Drawing.Size(99, 13)
        Me.Intersecao1Label.TabIndex = 9
        Me.Intersecao1Label.Text = "Interseção Anterior:"
        '
        'Intersecao2Label
        '
        Me.Intersecao2Label.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Intersecao2Label.AutoSize = True
        Me.Intersecao2Label.Location = New System.Drawing.Point(339, 86)
        Me.Intersecao2Label.Name = "Intersecao2Label"
        Me.Intersecao2Label.Size = New System.Drawing.Size(104, 13)
        Me.Intersecao2Label.TabIndex = 10
        Me.Intersecao2Label.Text = "Interseção Posterior:"
        '
        'Intersecao1Combo
        '
        Me.Intersecao1Combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Intersecao1Combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Intersecao1Combo.FormattingEnabled = True
        Me.Intersecao1Combo.Location = New System.Drawing.Point(339, 61)
        Me.Intersecao1Combo.Name = "Intersecao1Combo"
        Me.Intersecao1Combo.Size = New System.Drawing.Size(162, 21)
        Me.Intersecao1Combo.TabIndex = 8
        '
        'Intersecao2Combo
        '
        Me.Intersecao2Combo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Intersecao2Combo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Intersecao2Combo.FormattingEnabled = True
        Me.Intersecao2Combo.Location = New System.Drawing.Point(339, 102)
        Me.Intersecao2Combo.Name = "Intersecao2Combo"
        Me.Intersecao2Combo.Size = New System.Drawing.Size(162, 21)
        Me.Intersecao2Combo.TabIndex = 9
        '
        'GeralGroup
        '
        Me.GeralGroup.Controls.Add(Me.Acidente_HoraText)
        Me.GeralGroup.Controls.Add(Me.Acidente_DataText)
        Me.GeralGroup.Controls.Add(Me.Acidente_NoEnvolvidoNumeric)
        Me.GeralGroup.Controls.Add(Me.NoEnvolvidoLabel)
        Me.GeralGroup.Controls.Add(Me.Acidente_NoBoText)
        Me.GeralGroup.Controls.Add(Me.HoraLabel)
        Me.GeralGroup.Controls.Add(Me.DataLabel)
        Me.GeralGroup.Controls.Add(Me.NoBoLabel)
        Me.GeralGroup.Controls.Add(Me.Acidente_CodAcidenteText)
        Me.GeralGroup.Controls.Add(Me.CodAcidenteLabel)
        Me.GeralGroup.Location = New System.Drawing.Point(5, 6)
        Me.GeralGroup.MinimumSize = New System.Drawing.Size(14, 27)
        Me.GeralGroup.Name = "GeralGroup"
        Me.GeralGroup.Padding = New System.Windows.Forms.Padding(5)
        Me.GeralGroup.Size = New System.Drawing.Size(700, 40)
        Me.GeralGroup.TabIndex = 10
        Me.GeralGroup.TabStop = False
        Me.GeralGroup.Text = "Informações Gerais"
        '
        'Acidente_HoraText
        '
        Me.Acidente_HoraText.Location = New System.Drawing.Point(514, 15)
        Me.Acidente_HoraText.Mask = "00:00"
        Me.Acidente_HoraText.Name = "Acidente_HoraText"
        Me.Acidente_HoraText.Size = New System.Drawing.Size(38, 20)
        Me.Acidente_HoraText.TabIndex = 2
        Me.Acidente_HoraText.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.Acidente_HoraText.ValidatingType = GetType(Date)
        '
        'Acidente_DataText
        '
        Me.Acidente_DataText.Location = New System.Drawing.Point(401, 15)
        Me.Acidente_DataText.Mask = "00/00/0000"
        Me.Acidente_DataText.Name = "Acidente_DataText"
        Me.Acidente_DataText.Size = New System.Drawing.Size(68, 20)
        Me.Acidente_DataText.TabIndex = 1
        Me.Acidente_DataText.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.Acidente_DataText.ValidatingType = GetType(Date)
        '
        'Acidente_NoEnvolvidoNumeric
        '
        Me.Acidente_NoEnvolvidoNumeric.Location = New System.Drawing.Point(633, 14)
        Me.Acidente_NoEnvolvidoNumeric.Maximum = New Decimal(New Integer() {8, 0, 0, 0})
        Me.Acidente_NoEnvolvidoNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Acidente_NoEnvolvidoNumeric.Name = "Acidente_NoEnvolvidoNumeric"
        Me.Acidente_NoEnvolvidoNumeric.Size = New System.Drawing.Size(50, 20)
        Me.Acidente_NoEnvolvidoNumeric.TabIndex = 3
        Me.Acidente_NoEnvolvidoNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'NoEnvolvidoLabel
        '
        Me.NoEnvolvidoLabel.AutoSize = True
        Me.NoEnvolvidoLabel.Location = New System.Drawing.Point(558, 18)
        Me.NoEnvolvidoLabel.Name = "NoEnvolvidoLabel"
        Me.NoEnvolvidoLabel.Size = New System.Drawing.Size(69, 13)
        Me.NoEnvolvidoLabel.TabIndex = 8
        Me.NoEnvolvidoLabel.Text = "No Veículos:"
        '
        'Acidente_NoBoText
        '
        Me.Acidente_NoBoText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Acidente_NoBoText.Location = New System.Drawing.Point(256, 14)
        Me.Acidente_NoBoText.MaxLength = 15
        Me.Acidente_NoBoText.Name = "Acidente_NoBoText"
        Me.Acidente_NoBoText.Size = New System.Drawing.Size(100, 20)
        Me.Acidente_NoBoText.TabIndex = 0
        '
        'HoraLabel
        '
        Me.HoraLabel.AutoSize = True
        Me.HoraLabel.Location = New System.Drawing.Point(475, 18)
        Me.HoraLabel.Name = "HoraLabel"
        Me.HoraLabel.Size = New System.Drawing.Size(33, 13)
        Me.HoraLabel.TabIndex = 6
        Me.HoraLabel.Text = "Hora:"
        '
        'DataLabel
        '
        Me.DataLabel.AutoSize = True
        Me.DataLabel.Location = New System.Drawing.Point(362, 18)
        Me.DataLabel.Name = "DataLabel"
        Me.DataLabel.Size = New System.Drawing.Size(33, 13)
        Me.DataLabel.TabIndex = 4
        Me.DataLabel.Text = "Data:"
        '
        'NoBoLabel
        '
        Me.NoBoLabel.AutoSize = True
        Me.NoBoLabel.Location = New System.Drawing.Point(208, 18)
        Me.NoBoLabel.Name = "NoBoLabel"
        Me.NoBoLabel.Size = New System.Drawing.Size(42, 13)
        Me.NoBoLabel.TabIndex = 2
        Me.NoBoLabel.Text = "No BO:"
        '
        'Acidente_CodAcidenteText
        '
        Me.Acidente_CodAcidenteText.Enabled = False
        Me.Acidente_CodAcidenteText.Location = New System.Drawing.Point(102, 14)
        Me.Acidente_CodAcidenteText.MaxLength = 15
        Me.Acidente_CodAcidenteText.Name = "Acidente_CodAcidenteText"
        Me.Acidente_CodAcidenteText.Size = New System.Drawing.Size(100, 20)
        Me.Acidente_CodAcidenteText.TabIndex = 3
        '
        'CodAcidenteLabel
        '
        Me.CodAcidenteLabel.AutoSize = True
        Me.CodAcidenteLabel.Location = New System.Drawing.Point(8, 18)
        Me.CodAcidenteLabel.Name = "CodAcidenteLabel"
        Me.CodAcidenteLabel.Size = New System.Drawing.Size(88, 13)
        Me.CodAcidenteLabel.TabIndex = 0
        Me.CodAcidenteLabel.Text = "Código Acidente:"
        '
        'VeiculoTabPage
        '
        Me.VeiculoTabPage.Controls.Add(Me.InserirVeiculoButton)
        Me.VeiculoTabPage.Controls.Add(Me.VeiculosDataGrid)
        Me.VeiculoTabPage.Controls.Add(Me.SeveridadeGroup)
        Me.VeiculoTabPage.Controls.Add(Me.VeiculoGroup)
        Me.VeiculoTabPage.Controls.Add(Me.GroupBox1)
        Me.VeiculoTabPage.Location = New System.Drawing.Point(4, 22)
        Me.VeiculoTabPage.Name = "VeiculoTabPage"
        Me.VeiculoTabPage.Padding = New System.Windows.Forms.Padding(3)
        Me.VeiculoTabPage.Size = New System.Drawing.Size(710, 645)
        Me.VeiculoTabPage.TabIndex = 1
        Me.VeiculoTabPage.Text = "Veículo"
        Me.VeiculoTabPage.UseVisualStyleBackColor = True
        '
        'InserirVeiculoButton
        '
        Me.InserirVeiculoButton.Image = CType(resources.GetObject("InserirVeiculoButton.Image"), System.Drawing.Image)
        Me.InserirVeiculoButton.Location = New System.Drawing.Point(654, 250)
        Me.InserirVeiculoButton.Name = "InserirVeiculoButton"
        Me.InserirVeiculoButton.Size = New System.Drawing.Size(50, 45)
        Me.InserirVeiculoButton.TabIndex = 13
        Me.InserirVeiculoButton.UseVisualStyleBackColor = True
        '
        'VeiculosDataGrid
        '
        Me.VeiculosDataGrid.AllowUserToAddRows = False
        Me.VeiculosDataGrid.AllowUserToResizeColumns = False
        Me.VeiculosDataGrid.AllowUserToResizeRows = False
        Me.VeiculosDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VeiculosDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_veiculo, Me.cod_acidente_veiculo, Me.tipo_veiculo, Me.placa_veiculo, Me.apreendido, Me.no_ocupantes, Me.sentido_veiculo, Me.veic_equipseg, Me.sev_sem_danos, Me.sev_danos_materiais, Me.sev_feridos_leves, Me.sev_feridos_graves, Me.sev_fatalidades, Me.sev_nao_apurado})
        Me.VeiculosDataGrid.Location = New System.Drawing.Point(6, 301)
        Me.VeiculosDataGrid.Name = "VeiculosDataGrid"
        Me.VeiculosDataGrid.ReadOnly = True
        Me.VeiculosDataGrid.Size = New System.Drawing.Size(698, 338)
        Me.VeiculosDataGrid.TabIndex = 6
        '
        'cod_veiculo
        '
        Me.cod_veiculo.Frozen = True
        Me.cod_veiculo.HeaderText = "Código Veículo"
        Me.cod_veiculo.Name = "cod_veiculo"
        Me.cod_veiculo.ReadOnly = True
        Me.cod_veiculo.Width = 60
        '
        'cod_acidente_veiculo
        '
        Me.cod_acidente_veiculo.Frozen = True
        Me.cod_acidente_veiculo.HeaderText = "Código Acidente"
        Me.cod_acidente_veiculo.Name = "cod_acidente_veiculo"
        Me.cod_acidente_veiculo.ReadOnly = True
        Me.cod_acidente_veiculo.Width = 60
        '
        'tipo_veiculo
        '
        Me.tipo_veiculo.Frozen = True
        Me.tipo_veiculo.HeaderText = "Tipo de Veículo"
        Me.tipo_veiculo.Name = "tipo_veiculo"
        Me.tipo_veiculo.ReadOnly = True
        Me.tipo_veiculo.Width = 60
        '
        'placa_veiculo
        '
        Me.placa_veiculo.HeaderText = "Placa"
        Me.placa_veiculo.Name = "placa_veiculo"
        Me.placa_veiculo.ReadOnly = True
        Me.placa_veiculo.Width = 60
        '
        'apreendido
        '
        Me.apreendido.HeaderText = "Apreendido?"
        Me.apreendido.Name = "apreendido"
        Me.apreendido.ReadOnly = True
        Me.apreendido.Width = 75
        '
        'no_ocupantes
        '
        Me.no_ocupantes.HeaderText = "No Ocupantes"
        Me.no_ocupantes.Name = "no_ocupantes"
        Me.no_ocupantes.ReadOnly = True
        Me.no_ocupantes.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.no_ocupantes.Width = 75
        '
        'sentido_veiculo
        '
        Me.sentido_veiculo.HeaderText = "Sentido Veículo"
        Me.sentido_veiculo.Name = "sentido_veiculo"
        Me.sentido_veiculo.ReadOnly = True
        Me.sentido_veiculo.Width = 60
        '
        'veic_equipseg
        '
        Me.veic_equipseg.HeaderText = "Eq. Segurança"
        Me.veic_equipseg.Name = "veic_equipseg"
        Me.veic_equipseg.ReadOnly = True
        Me.veic_equipseg.Width = 60
        '
        'sev_sem_danos
        '
        Me.sev_sem_danos.HeaderText = "Sem danos"
        Me.sev_sem_danos.Name = "sev_sem_danos"
        Me.sev_sem_danos.ReadOnly = True
        Me.sev_sem_danos.Width = 50
        '
        'sev_danos_materiais
        '
        Me.sev_danos_materiais.HeaderText = "Danos Materiais"
        Me.sev_danos_materiais.Name = "sev_danos_materiais"
        Me.sev_danos_materiais.ReadOnly = True
        Me.sev_danos_materiais.Width = 50
        '
        'sev_feridos_leves
        '
        Me.sev_feridos_leves.HeaderText = "Feridos leves"
        Me.sev_feridos_leves.Name = "sev_feridos_leves"
        Me.sev_feridos_leves.ReadOnly = True
        Me.sev_feridos_leves.Width = 50
        '
        'sev_feridos_graves
        '
        Me.sev_feridos_graves.HeaderText = "Feridos graves"
        Me.sev_feridos_graves.Name = "sev_feridos_graves"
        Me.sev_feridos_graves.ReadOnly = True
        Me.sev_feridos_graves.Width = 50
        '
        'sev_fatalidades
        '
        Me.sev_fatalidades.HeaderText = "Fatalidades"
        Me.sev_fatalidades.Name = "sev_fatalidades"
        Me.sev_fatalidades.ReadOnly = True
        Me.sev_fatalidades.Width = 50
        '
        'sev_nao_apurado
        '
        Me.sev_nao_apurado.HeaderText = "Não apurado"
        Me.sev_nao_apurado.Name = "sev_nao_apurado"
        Me.sev_nao_apurado.ReadOnly = True
        Me.sev_nao_apurado.Width = 50
        '
        'SeveridadeGroup
        '
        Me.SeveridadeGroup.Controls.Add(Me.TableLayoutPanel2)
        Me.SeveridadeGroup.Location = New System.Drawing.Point(6, 174)
        Me.SeveridadeGroup.Name = "SeveridadeGroup"
        Me.SeveridadeGroup.Size = New System.Drawing.Size(698, 70)
        Me.SeveridadeGroup.TabIndex = 7
        Me.SeveridadeGroup.TabStop = False
        Me.SeveridadeGroup.Text = "Severidade:"
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 6
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667!))
        Me.TableLayoutPanel2.Controls.Add(Me.Veiculo_SeveridadeNA, 5, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Veiculo_SeveridadeFatalidade, 4, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Veiculo_SeveridadeFeridoGrave, 3, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Veiculo_SeveridadeFeridoLeve, 2, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Veiculo_SeveridadeDanoMaterial, 1, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.Label10, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label9, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label11, 2, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label12, 3, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label13, 4, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Label14, 5, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Veiculo_SeveridadeSemDano, 0, 1)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(11, 19)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(681, 43)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Veiculo_SeveridadeNA
        '
        Me.Veiculo_SeveridadeNA.Location = New System.Drawing.Point(568, 20)
        Me.Veiculo_SeveridadeNA.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Veiculo_SeveridadeNA.Name = "Veiculo_SeveridadeNA"
        Me.Veiculo_SeveridadeNA.Size = New System.Drawing.Size(69, 20)
        Me.Veiculo_SeveridadeNA.TabIndex = 13
        '
        'Veiculo_SeveridadeFatalidade
        '
        Me.Veiculo_SeveridadeFatalidade.Location = New System.Drawing.Point(455, 20)
        Me.Veiculo_SeveridadeFatalidade.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Veiculo_SeveridadeFatalidade.Name = "Veiculo_SeveridadeFatalidade"
        Me.Veiculo_SeveridadeFatalidade.Size = New System.Drawing.Size(69, 20)
        Me.Veiculo_SeveridadeFatalidade.TabIndex = 12
        '
        'Veiculo_SeveridadeFeridoGrave
        '
        Me.Veiculo_SeveridadeFeridoGrave.Location = New System.Drawing.Point(342, 20)
        Me.Veiculo_SeveridadeFeridoGrave.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Veiculo_SeveridadeFeridoGrave.Name = "Veiculo_SeveridadeFeridoGrave"
        Me.Veiculo_SeveridadeFeridoGrave.Size = New System.Drawing.Size(69, 20)
        Me.Veiculo_SeveridadeFeridoGrave.TabIndex = 11
        '
        'Veiculo_SeveridadeFeridoLeve
        '
        Me.Veiculo_SeveridadeFeridoLeve.Location = New System.Drawing.Point(229, 20)
        Me.Veiculo_SeveridadeFeridoLeve.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Veiculo_SeveridadeFeridoLeve.Name = "Veiculo_SeveridadeFeridoLeve"
        Me.Veiculo_SeveridadeFeridoLeve.Size = New System.Drawing.Size(69, 20)
        Me.Veiculo_SeveridadeFeridoLeve.TabIndex = 10
        '
        'Veiculo_SeveridadeDanoMaterial
        '
        Me.Veiculo_SeveridadeDanoMaterial.Location = New System.Drawing.Point(116, 20)
        Me.Veiculo_SeveridadeDanoMaterial.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Veiculo_SeveridadeDanoMaterial.Name = "Veiculo_SeveridadeDanoMaterial"
        Me.Veiculo_SeveridadeDanoMaterial.Size = New System.Drawing.Size(69, 20)
        Me.Veiculo_SeveridadeDanoMaterial.TabIndex = 9
        '
        'Label10
        '
        Me.Label10.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(116, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 13)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "D. Materiais:"
        '
        'Label9
        '
        Me.Label9.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(3, 4)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Sem Danos:"
        '
        'Label11
        '
        Me.Label11.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(229, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "F. Leves:"
        '
        'Label12
        '
        Me.Label12.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(342, 4)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(53, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "F. Graves"
        '
        'Label13
        '
        Me.Label13.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(455, 4)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(64, 13)
        Me.Label13.TabIndex = 5
        Me.Label13.Text = "Fatalidades:"
        '
        'Label14
        '
        Me.Label14.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(568, 4)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(30, 13)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "N/A:"
        '
        'Veiculo_SeveridadeSemDano
        '
        Me.Veiculo_SeveridadeSemDano.Location = New System.Drawing.Point(3, 20)
        Me.Veiculo_SeveridadeSemDano.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.Veiculo_SeveridadeSemDano.Name = "Veiculo_SeveridadeSemDano"
        Me.Veiculo_SeveridadeSemDano.Size = New System.Drawing.Size(69, 20)
        Me.Veiculo_SeveridadeSemDano.TabIndex = 8
        '
        'VeiculoGroup
        '
        Me.VeiculoGroup.Controls.Add(Me.TableLayoutPanel1)
        Me.VeiculoGroup.Location = New System.Drawing.Point(5, 58)
        Me.VeiculoGroup.Name = "VeiculoGroup"
        Me.VeiculoGroup.Size = New System.Drawing.Size(699, 110)
        Me.VeiculoGroup.TabIndex = 6
        Me.VeiculoGroup.TabStop = False
        Me.VeiculoGroup.Text = "Veículo:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel1.Controls.Add(Me.Label5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label4, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Label7, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label8, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Label31, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Veiculo_NoOcupantesNumeric, 2, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Veiculo_TipoVeiculoCombo, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Veiculo_ApreendidoCombo, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Veiculo_EquipSegurancaCombo, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Veiculo_SentidoVeiculoCombo, 1, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Veiculo_PlacaVeiculoText, 1, 1)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(11, 19)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(682, 83)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(457, 4)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Apreendido:"
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(230, 4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Placa:"
        '
        'Label6
        '
        Me.Label6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(3, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Tipo de Veículo:"
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 45)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Equipamento Segurança:"
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(230, 45)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 13)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "Sentido Veículo:"
        '
        'Label31
        '
        Me.Label31.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(457, 45)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(79, 13)
        Me.Label31.TabIndex = 5
        Me.Label31.Text = "No Ocupantes:"
        '
        'Veiculo_NoOcupantesNumeric
        '
        Me.Veiculo_NoOcupantesNumeric.Location = New System.Drawing.Point(457, 61)
        Me.Veiculo_NoOcupantesNumeric.Maximum = New Decimal(New Integer() {6, 0, 0, 0})
        Me.Veiculo_NoOcupantesNumeric.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.Veiculo_NoOcupantesNumeric.Name = "Veiculo_NoOcupantesNumeric"
        Me.Veiculo_NoOcupantesNumeric.Size = New System.Drawing.Size(146, 20)
        Me.Veiculo_NoOcupantesNumeric.TabIndex = 7
        Me.Veiculo_NoOcupantesNumeric.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.Veiculo_NoOcupantesNumeric.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Veiculo_TipoVeiculoCombo
        '
        Me.Veiculo_TipoVeiculoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Veiculo_TipoVeiculoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Veiculo_TipoVeiculoCombo.FormattingEnabled = True
        Me.Veiculo_TipoVeiculoCombo.Location = New System.Drawing.Point(3, 20)
        Me.Veiculo_TipoVeiculoCombo.Name = "Veiculo_TipoVeiculoCombo"
        Me.Veiculo_TipoVeiculoCombo.Size = New System.Drawing.Size(144, 21)
        Me.Veiculo_TipoVeiculoCombo.TabIndex = 2
        '
        'Veiculo_ApreendidoCombo
        '
        Me.Veiculo_ApreendidoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Veiculo_ApreendidoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Veiculo_ApreendidoCombo.FormattingEnabled = True
        Me.Veiculo_ApreendidoCombo.Location = New System.Drawing.Point(457, 20)
        Me.Veiculo_ApreendidoCombo.Name = "Veiculo_ApreendidoCombo"
        Me.Veiculo_ApreendidoCombo.Size = New System.Drawing.Size(144, 21)
        Me.Veiculo_ApreendidoCombo.TabIndex = 4
        '
        'Veiculo_EquipSegurancaCombo
        '
        Me.Veiculo_EquipSegurancaCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Veiculo_EquipSegurancaCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Veiculo_EquipSegurancaCombo.FormattingEnabled = True
        Me.Veiculo_EquipSegurancaCombo.Location = New System.Drawing.Point(3, 61)
        Me.Veiculo_EquipSegurancaCombo.Name = "Veiculo_EquipSegurancaCombo"
        Me.Veiculo_EquipSegurancaCombo.Size = New System.Drawing.Size(144, 21)
        Me.Veiculo_EquipSegurancaCombo.TabIndex = 5
        '
        'Veiculo_SentidoVeiculoCombo
        '
        Me.Veiculo_SentidoVeiculoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Veiculo_SentidoVeiculoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Veiculo_SentidoVeiculoCombo.FormattingEnabled = True
        Me.Veiculo_SentidoVeiculoCombo.Location = New System.Drawing.Point(230, 61)
        Me.Veiculo_SentidoVeiculoCombo.Name = "Veiculo_SentidoVeiculoCombo"
        Me.Veiculo_SentidoVeiculoCombo.Size = New System.Drawing.Size(144, 21)
        Me.Veiculo_SentidoVeiculoCombo.TabIndex = 6
        '
        'Veiculo_PlacaVeiculoText
        '
        Me.Veiculo_PlacaVeiculoText.BeepOnError = True
        Me.Veiculo_PlacaVeiculoText.Location = New System.Drawing.Point(230, 20)
        Me.Veiculo_PlacaVeiculoText.Mask = ">LLL-0000"
        Me.Veiculo_PlacaVeiculoText.Name = "Veiculo_PlacaVeiculoText"
        Me.Veiculo_PlacaVeiculoText.Size = New System.Drawing.Size(144, 20)
        Me.Veiculo_PlacaVeiculoText.TabIndex = 3
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Veiculo_CodAcidenteText)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.Veiculo_CodVeiculoText)
        Me.GroupBox1.Controls.Add(Me.Label35)
        Me.GroupBox1.Location = New System.Drawing.Point(5, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox1.Size = New System.Drawing.Size(699, 46)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Informações Gerais"
        '
        'Veiculo_CodAcidenteText
        '
        Me.Veiculo_CodAcidenteText.Enabled = False
        Me.Veiculo_CodAcidenteText.Location = New System.Drawing.Point(316, 15)
        Me.Veiculo_CodAcidenteText.Name = "Veiculo_CodAcidenteText"
        Me.Veiculo_CodAcidenteText.Size = New System.Drawing.Size(100, 20)
        Me.Veiculo_CodAcidenteText.TabIndex = 1
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(207, 18)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(103, 13)
        Me.Label34.TabIndex = 5
        Me.Label34.Text = "Código do Acidente:"
        '
        'Veiculo_CodVeiculoText
        '
        Me.Veiculo_CodVeiculoText.Enabled = False
        Me.Veiculo_CodVeiculoText.Location = New System.Drawing.Point(97, 15)
        Me.Veiculo_CodVeiculoText.Name = "Veiculo_CodVeiculoText"
        Me.Veiculo_CodVeiculoText.Size = New System.Drawing.Size(100, 20)
        Me.Veiculo_CodVeiculoText.TabIndex = 0
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(8, 18)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(83, 13)
        Me.Label35.TabIndex = 3
        Me.Label35.Text = "Código Veículo:"
        '
        'CondutorTabPage
        '
        Me.CondutorTabPage.Controls.Add(Me.InserirCondutorButton)
        Me.CondutorTabPage.Controls.Add(Me.CondutoresDataGrid)
        Me.CondutorTabPage.Controls.Add(Me.Condutor_SeveridadeGroup)
        Me.CondutorTabPage.Controls.Add(Me.GroupBox2)
        Me.CondutorTabPage.Controls.Add(Me.Condutor_InformacoesPessoaisGroup)
        Me.CondutorTabPage.Controls.Add(Me.Condutor_InformacoesGeraisGroup)
        Me.CondutorTabPage.Location = New System.Drawing.Point(4, 22)
        Me.CondutorTabPage.Name = "CondutorTabPage"
        Me.CondutorTabPage.Size = New System.Drawing.Size(710, 645)
        Me.CondutorTabPage.TabIndex = 2
        Me.CondutorTabPage.Text = "Condutor"
        Me.CondutorTabPage.UseVisualStyleBackColor = True
        '
        'InserirCondutorButton
        '
        Me.InserirCondutorButton.Image = CType(resources.GetObject("InserirCondutorButton.Image"), System.Drawing.Image)
        Me.InserirCondutorButton.Location = New System.Drawing.Point(653, 321)
        Me.InserirCondutorButton.Name = "InserirCondutorButton"
        Me.InserirCondutorButton.Size = New System.Drawing.Size(50, 45)
        Me.InserirCondutorButton.TabIndex = 0
        Me.InserirCondutorButton.UseVisualStyleBackColor = True
        '
        'CondutoresDataGrid
        '
        Me.CondutoresDataGrid.AllowUserToAddRows = False
        Me.CondutoresDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CondutoresDataGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cod_condutor, Me.cod_veiculo_condutor, Me.cod_acidente_condutor, Me.estado_origem, Me.cidade_origem, Me.escolaridade, Me.profissao, Me.habilitacao, Me.comportamento, Me.condicao_fisica, Me.cond_sexo, Me.data_nasc, Me.data_hab, Me.c_semdanos, Me.c_feridoleve, Me.c_feridograve, Me.c_fatalidade, Me.prontuario})
        Me.CondutoresDataGrid.Location = New System.Drawing.Point(6, 372)
        Me.CondutoresDataGrid.Name = "CondutoresDataGrid"
        Me.CondutoresDataGrid.ReadOnly = True
        Me.CondutoresDataGrid.Size = New System.Drawing.Size(697, 267)
        Me.CondutoresDataGrid.TabIndex = 14
        '
        'cod_condutor
        '
        Me.cod_condutor.HeaderText = "Código Condutor"
        Me.cod_condutor.Name = "cod_condutor"
        Me.cod_condutor.ReadOnly = True
        '
        'cod_veiculo_condutor
        '
        Me.cod_veiculo_condutor.HeaderText = "Código Veículo"
        Me.cod_veiculo_condutor.Name = "cod_veiculo_condutor"
        Me.cod_veiculo_condutor.ReadOnly = True
        '
        'cod_acidente_condutor
        '
        Me.cod_acidente_condutor.HeaderText = "Código Acidente"
        Me.cod_acidente_condutor.Name = "cod_acidente_condutor"
        Me.cod_acidente_condutor.ReadOnly = True
        '
        'estado_origem
        '
        Me.estado_origem.HeaderText = "Estado de Origem"
        Me.estado_origem.Name = "estado_origem"
        Me.estado_origem.ReadOnly = True
        '
        'cidade_origem
        '
        Me.cidade_origem.HeaderText = "Cidade de Origem"
        Me.cidade_origem.Name = "cidade_origem"
        Me.cidade_origem.ReadOnly = True
        '
        'escolaridade
        '
        Me.escolaridade.HeaderText = "Escolaridade"
        Me.escolaridade.Name = "escolaridade"
        Me.escolaridade.ReadOnly = True
        '
        'profissao
        '
        Me.profissao.HeaderText = "Profissão"
        Me.profissao.Name = "profissao"
        Me.profissao.ReadOnly = True
        '
        'habilitacao
        '
        Me.habilitacao.HeaderText = "Situação Habilitação"
        Me.habilitacao.Name = "habilitacao"
        Me.habilitacao.ReadOnly = True
        '
        'comportamento
        '
        Me.comportamento.HeaderText = "Comportamento"
        Me.comportamento.Name = "comportamento"
        Me.comportamento.ReadOnly = True
        '
        'condicao_fisica
        '
        Me.condicao_fisica.HeaderText = "Condição Física"
        Me.condicao_fisica.Name = "condicao_fisica"
        Me.condicao_fisica.ReadOnly = True
        '
        'cond_sexo
        '
        Me.cond_sexo.HeaderText = "Sexo"
        Me.cond_sexo.Name = "cond_sexo"
        Me.cond_sexo.ReadOnly = True
        '
        'data_nasc
        '
        Me.data_nasc.HeaderText = "Data Nascimento"
        Me.data_nasc.Name = "data_nasc"
        Me.data_nasc.ReadOnly = True
        '
        'data_hab
        '
        Me.data_hab.HeaderText = "Data Habilitação"
        Me.data_hab.Name = "data_hab"
        Me.data_hab.ReadOnly = True
        '
        'c_semdanos
        '
        Me.c_semdanos.HeaderText = "Sem Danos"
        Me.c_semdanos.Name = "c_semdanos"
        Me.c_semdanos.ReadOnly = True
        Me.c_semdanos.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'c_feridoleve
        '
        Me.c_feridoleve.HeaderText = "Ferido Leve"
        Me.c_feridoleve.Name = "c_feridoleve"
        Me.c_feridoleve.ReadOnly = True
        Me.c_feridoleve.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'c_feridograve
        '
        Me.c_feridograve.HeaderText = "Ferido Grave"
        Me.c_feridograve.Name = "c_feridograve"
        Me.c_feridograve.ReadOnly = True
        Me.c_feridograve.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'c_fatalidade
        '
        Me.c_fatalidade.HeaderText = "Fatalidade"
        Me.c_fatalidade.Name = "c_fatalidade"
        Me.c_fatalidade.ReadOnly = True
        Me.c_fatalidade.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'prontuario
        '
        Me.prontuario.HeaderText = "Prontuário"
        Me.prontuario.Name = "prontuario"
        Me.prontuario.ReadOnly = True
        '
        'Condutor_SeveridadeGroup
        '
        Me.Condutor_SeveridadeGroup.Controls.Add(Me.TableLayoutPanel4)
        Me.Condutor_SeveridadeGroup.Location = New System.Drawing.Point(5, 259)
        Me.Condutor_SeveridadeGroup.Name = "Condutor_SeveridadeGroup"
        Me.Condutor_SeveridadeGroup.Size = New System.Drawing.Size(698, 56)
        Me.Condutor_SeveridadeGroup.TabIndex = 13
        Me.Condutor_SeveridadeGroup.TabStop = False
        Me.Condutor_SeveridadeGroup.Text = "Severidade:"
        '
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 4
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25.0!))
        Me.TableLayoutPanel4.Controls.Add(Me.Condutor_FatalidadeRadio, 3, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Condutor_FeridoGraveRadio, 2, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Condutor_FeridoLeveRadio, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.Condutor_SemDanosRadio, 0, 0)
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(11, 19)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 24.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(681, 24)
        Me.TableLayoutPanel4.TabIndex = 0
        '
        'Condutor_FatalidadeRadio
        '
        Me.Condutor_FatalidadeRadio.AutoSize = True
        Me.Condutor_FatalidadeRadio.Location = New System.Drawing.Point(513, 3)
        Me.Condutor_FatalidadeRadio.Name = "Condutor_FatalidadeRadio"
        Me.Condutor_FatalidadeRadio.Size = New System.Drawing.Size(74, 17)
        Me.Condutor_FatalidadeRadio.TabIndex = 3
        Me.Condutor_FatalidadeRadio.TabStop = True
        Me.Condutor_FatalidadeRadio.Text = "Fatalidade"
        Me.Condutor_FatalidadeRadio.UseVisualStyleBackColor = True
        '
        'Condutor_FeridoGraveRadio
        '
        Me.Condutor_FeridoGraveRadio.AutoSize = True
        Me.Condutor_FeridoGraveRadio.Location = New System.Drawing.Point(343, 3)
        Me.Condutor_FeridoGraveRadio.Name = "Condutor_FeridoGraveRadio"
        Me.Condutor_FeridoGraveRadio.Size = New System.Drawing.Size(86, 17)
        Me.Condutor_FeridoGraveRadio.TabIndex = 2
        Me.Condutor_FeridoGraveRadio.TabStop = True
        Me.Condutor_FeridoGraveRadio.Text = "Ferido Grave"
        Me.Condutor_FeridoGraveRadio.UseVisualStyleBackColor = True
        '
        'Condutor_FeridoLeveRadio
        '
        Me.Condutor_FeridoLeveRadio.AutoSize = True
        Me.Condutor_FeridoLeveRadio.Location = New System.Drawing.Point(173, 3)
        Me.Condutor_FeridoLeveRadio.Name = "Condutor_FeridoLeveRadio"
        Me.Condutor_FeridoLeveRadio.Size = New System.Drawing.Size(81, 17)
        Me.Condutor_FeridoLeveRadio.TabIndex = 1
        Me.Condutor_FeridoLeveRadio.TabStop = True
        Me.Condutor_FeridoLeveRadio.Text = "Ferido Leve"
        Me.Condutor_FeridoLeveRadio.UseVisualStyleBackColor = True
        '
        'Condutor_SemDanosRadio
        '
        Me.Condutor_SemDanosRadio.AutoSize = True
        Me.Condutor_SemDanosRadio.Location = New System.Drawing.Point(3, 3)
        Me.Condutor_SemDanosRadio.Name = "Condutor_SemDanosRadio"
        Me.Condutor_SemDanosRadio.Size = New System.Drawing.Size(80, 17)
        Me.Condutor_SemDanosRadio.TabIndex = 0
        Me.Condutor_SemDanosRadio.TabStop = True
        Me.Condutor_SemDanosRadio.Text = "Sem Danos"
        Me.Condutor_SemDanosRadio.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Condutor_CidadeCombo)
        Me.GroupBox2.Controls.Add(Me.Condutor_CidadeLabel)
        Me.GroupBox2.Controls.Add(Me.Condutor_HabilitacaoCombo)
        Me.GroupBox2.Controls.Add(Me.Condutor_EstadoCombo)
        Me.GroupBox2.Controls.Add(Me.Condutor_EstadoLabel)
        Me.GroupBox2.Controls.Add(Me.Label24)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.Condutor_DataHabilitacaoText)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 51)
        Me.GroupBox2.MinimumSize = New System.Drawing.Size(14, 27)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(698, 40)
        Me.GroupBox2.TabIndex = 12
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Origem"
        '
        'Condutor_CidadeCombo
        '
        Me.Condutor_CidadeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_CidadeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_CidadeCombo.FormattingEnabled = True
        Me.Condutor_CidadeCombo.Location = New System.Drawing.Point(175, 14)
        Me.Condutor_CidadeCombo.Name = "Condutor_CidadeCombo"
        Me.Condutor_CidadeCombo.Size = New System.Drawing.Size(125, 21)
        Me.Condutor_CidadeCombo.TabIndex = 1
        '
        'Condutor_CidadeLabel
        '
        Me.Condutor_CidadeLabel.AutoSize = True
        Me.Condutor_CidadeLabel.Location = New System.Drawing.Point(126, 18)
        Me.Condutor_CidadeLabel.Name = "Condutor_CidadeLabel"
        Me.Condutor_CidadeLabel.Size = New System.Drawing.Size(43, 13)
        Me.Condutor_CidadeLabel.TabIndex = 7
        Me.Condutor_CidadeLabel.Text = "Cidade:"
        '
        'Condutor_HabilitacaoCombo
        '
        Me.Condutor_HabilitacaoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_HabilitacaoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_HabilitacaoCombo.FormattingEnabled = True
        Me.Condutor_HabilitacaoCombo.Location = New System.Drawing.Point(375, 14)
        Me.Condutor_HabilitacaoCombo.Name = "Condutor_HabilitacaoCombo"
        Me.Condutor_HabilitacaoCombo.Size = New System.Drawing.Size(123, 21)
        Me.Condutor_HabilitacaoCombo.TabIndex = 2
        '
        'Condutor_EstadoCombo
        '
        Me.Condutor_EstadoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_EstadoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_EstadoCombo.FormattingEnabled = True
        Me.Condutor_EstadoCombo.Location = New System.Drawing.Point(57, 14)
        Me.Condutor_EstadoCombo.Name = "Condutor_EstadoCombo"
        Me.Condutor_EstadoCombo.Size = New System.Drawing.Size(63, 21)
        Me.Condutor_EstadoCombo.TabIndex = 0
        '
        'Condutor_EstadoLabel
        '
        Me.Condutor_EstadoLabel.AutoSize = True
        Me.Condutor_EstadoLabel.Location = New System.Drawing.Point(8, 18)
        Me.Condutor_EstadoLabel.Name = "Condutor_EstadoLabel"
        Me.Condutor_EstadoLabel.Size = New System.Drawing.Size(43, 13)
        Me.Condutor_EstadoLabel.TabIndex = 0
        Me.Condutor_EstadoLabel.Text = "Estado:"
        '
        'Label24
        '
        Me.Label24.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(306, 18)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(63, 13)
        Me.Label24.TabIndex = 10
        Me.Label24.Text = "Habilitação:"
        '
        'Label22
        '
        Me.Label22.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(511, 18)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(104, 13)
        Me.Label22.TabIndex = 4
        Me.Label22.Text = "Data da Habilitação:"
        '
        'Condutor_DataHabilitacaoText
        '
        Me.Condutor_DataHabilitacaoText.Location = New System.Drawing.Point(621, 14)
        Me.Condutor_DataHabilitacaoText.Mask = "00/00/0000"
        Me.Condutor_DataHabilitacaoText.Name = "Condutor_DataHabilitacaoText"
        Me.Condutor_DataHabilitacaoText.Size = New System.Drawing.Size(68, 20)
        Me.Condutor_DataHabilitacaoText.TabIndex = 3
        Me.Condutor_DataHabilitacaoText.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.Condutor_DataHabilitacaoText.ValidatingType = GetType(Date)
        '
        'Condutor_InformacoesPessoaisGroup
        '
        Me.Condutor_InformacoesPessoaisGroup.Controls.Add(Me.TableLayoutPanel3)
        Me.Condutor_InformacoesPessoaisGroup.Location = New System.Drawing.Point(5, 97)
        Me.Condutor_InformacoesPessoaisGroup.Name = "Condutor_InformacoesPessoaisGroup"
        Me.Condutor_InformacoesPessoaisGroup.Size = New System.Drawing.Size(698, 156)
        Me.Condutor_InformacoesPessoaisGroup.TabIndex = 12
        Me.Condutor_InformacoesPessoaisGroup.TabStop = False
        Me.Condutor_InformacoesPessoaisGroup.Text = "Condutor"
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 3
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33332!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334!))
        Me.TableLayoutPanel3.Controls.Add(Me.Condutor_CondicaoCombo, 1, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Label20, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label21, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Condutor_EscolaridadeCombo, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Condutor_ProfissaoCombo, 0, 3)
        Me.TableLayoutPanel3.Controls.Add(Me.Condutor_ComportamentoCombo, 1, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Condutor_DataNascimentoText, 2, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Label23, 1, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Label15, 1, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label16, 2, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.Label25, 2, 4)
        Me.TableLayoutPanel3.Controls.Add(Me.Condutor_ProntuarioText, 2, 5)
        Me.TableLayoutPanel3.Controls.Add(Me.Label26, 2, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Condutor_SexoCombo, 2, 3)
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(7, 19)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 6
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 17.0!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(682, 127)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'Condutor_CondicaoCombo
        '
        Me.Condutor_CondicaoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_CondicaoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_CondicaoCombo.FormattingEnabled = True
        Me.Condutor_CondicaoCombo.Location = New System.Drawing.Point(230, 62)
        Me.Condutor_CondicaoCombo.Name = "Condutor_CondicaoCombo"
        Me.Condutor_CondicaoCombo.Size = New System.Drawing.Size(144, 21)
        Me.Condutor_CondicaoCombo.TabIndex = 3
        '
        'Label20
        '
        Me.Label20.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 4)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(71, 13)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Escolaridade:"
        '
        'Label21
        '
        Me.Label21.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(3, 46)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(53, 13)
        Me.Label21.TabIndex = 3
        Me.Label21.Text = "Profissão:"
        '
        'Condutor_EscolaridadeCombo
        '
        Me.Condutor_EscolaridadeCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_EscolaridadeCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_EscolaridadeCombo.FormattingEnabled = True
        Me.Condutor_EscolaridadeCombo.Location = New System.Drawing.Point(3, 20)
        Me.Condutor_EscolaridadeCombo.Name = "Condutor_EscolaridadeCombo"
        Me.Condutor_EscolaridadeCombo.Size = New System.Drawing.Size(144, 21)
        Me.Condutor_EscolaridadeCombo.TabIndex = 0
        '
        'Condutor_ProfissaoCombo
        '
        Me.Condutor_ProfissaoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_ProfissaoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_ProfissaoCombo.FormattingEnabled = True
        Me.Condutor_ProfissaoCombo.Location = New System.Drawing.Point(3, 62)
        Me.Condutor_ProfissaoCombo.Name = "Condutor_ProfissaoCombo"
        Me.Condutor_ProfissaoCombo.Size = New System.Drawing.Size(144, 21)
        Me.Condutor_ProfissaoCombo.TabIndex = 1
        '
        'Condutor_ComportamentoCombo
        '
        Me.Condutor_ComportamentoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_ComportamentoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_ComportamentoCombo.FormattingEnabled = True
        Me.Condutor_ComportamentoCombo.Location = New System.Drawing.Point(230, 20)
        Me.Condutor_ComportamentoCombo.Name = "Condutor_ComportamentoCombo"
        Me.Condutor_ComportamentoCombo.Size = New System.Drawing.Size(144, 21)
        Me.Condutor_ComportamentoCombo.TabIndex = 2
        '
        'Condutor_DataNascimentoText
        '
        Me.Condutor_DataNascimentoText.Location = New System.Drawing.Point(457, 20)
        Me.Condutor_DataNascimentoText.Mask = "00/00/0000"
        Me.Condutor_DataNascimentoText.Name = "Condutor_DataNascimentoText"
        Me.Condutor_DataNascimentoText.Size = New System.Drawing.Size(68, 20)
        Me.Condutor_DataNascimentoText.TabIndex = 4
        Me.Condutor_DataNascimentoText.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePromptAndLiterals
        Me.Condutor_DataNascimentoText.ValidatingType = GetType(Date)
        '
        'Label23
        '
        Me.Label23.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(230, 46)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(87, 13)
        Me.Label23.TabIndex = 5
        Me.Label23.Text = "Condição Física:"
        '
        'Label15
        '
        Me.Label15.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(230, 4)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 13)
        Me.Label15.TabIndex = 2
        Me.Label15.Text = "Comportamento:"
        '
        'Label16
        '
        Me.Label16.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(457, 4)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(107, 13)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Data de Nascimento:"
        '
        'Label25
        '
        Me.Label25.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(457, 88)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(113, 13)
        Me.Label25.TabIndex = 12
        Me.Label25.Text = "Número do Prontuário:"
        '
        'Condutor_ProntuarioText
        '
        Me.Condutor_ProntuarioText.Location = New System.Drawing.Point(457, 104)
        Me.Condutor_ProntuarioText.Name = "Condutor_ProntuarioText"
        Me.Condutor_ProntuarioText.Size = New System.Drawing.Size(68, 20)
        Me.Condutor_ProntuarioText.TabIndex = 6
        '
        'Label26
        '
        Me.Label26.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(457, 46)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(34, 13)
        Me.Label26.TabIndex = 14
        Me.Label26.Text = "Sexo:"
        '
        'Condutor_SexoCombo
        '
        Me.Condutor_SexoCombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.Condutor_SexoCombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.Condutor_SexoCombo.FormattingEnabled = True
        Me.Condutor_SexoCombo.Location = New System.Drawing.Point(457, 62)
        Me.Condutor_SexoCombo.Name = "Condutor_SexoCombo"
        Me.Condutor_SexoCombo.Size = New System.Drawing.Size(68, 21)
        Me.Condutor_SexoCombo.TabIndex = 5
        '
        'Condutor_InformacoesGeraisGroup
        '
        Me.Condutor_InformacoesGeraisGroup.Controls.Add(Me.Condutor_CodAcidenteText)
        Me.Condutor_InformacoesGeraisGroup.Controls.Add(Me.Condutor_CodVeiculoLabel)
        Me.Condutor_InformacoesGeraisGroup.Controls.Add(Me.Condutor_CodAcidenteLabel)
        Me.Condutor_InformacoesGeraisGroup.Controls.Add(Me.Condutor_CodVeiculoText)
        Me.Condutor_InformacoesGeraisGroup.Controls.Add(Me.Condutor_CodCondutorText)
        Me.Condutor_InformacoesGeraisGroup.Controls.Add(Me.Condutor_CodCondutorLabel)
        Me.Condutor_InformacoesGeraisGroup.Location = New System.Drawing.Point(5, 5)
        Me.Condutor_InformacoesGeraisGroup.MinimumSize = New System.Drawing.Size(14, 27)
        Me.Condutor_InformacoesGeraisGroup.Name = "Condutor_InformacoesGeraisGroup"
        Me.Condutor_InformacoesGeraisGroup.Padding = New System.Windows.Forms.Padding(5)
        Me.Condutor_InformacoesGeraisGroup.Size = New System.Drawing.Size(698, 40)
        Me.Condutor_InformacoesGeraisGroup.TabIndex = 11
        Me.Condutor_InformacoesGeraisGroup.TabStop = False
        Me.Condutor_InformacoesGeraisGroup.Text = "Informações Gerais"
        '
        'Condutor_CodAcidenteText
        '
        Me.Condutor_CodAcidenteText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Condutor_CodAcidenteText.Enabled = False
        Me.Condutor_CodAcidenteText.Location = New System.Drawing.Point(490, 14)
        Me.Condutor_CodAcidenteText.MaxLength = 15
        Me.Condutor_CodAcidenteText.Name = "Condutor_CodAcidenteText"
        Me.Condutor_CodAcidenteText.Size = New System.Drawing.Size(100, 20)
        Me.Condutor_CodAcidenteText.TabIndex = 2
        '
        'Condutor_CodVeiculoLabel
        '
        Me.Condutor_CodVeiculoLabel.AutoSize = True
        Me.Condutor_CodVeiculoLabel.Location = New System.Drawing.Point(207, 18)
        Me.Condutor_CodVeiculoLabel.Name = "Condutor_CodVeiculoLabel"
        Me.Condutor_CodVeiculoLabel.Size = New System.Drawing.Size(80, 13)
        Me.Condutor_CodVeiculoLabel.TabIndex = 3
        Me.Condutor_CodVeiculoLabel.Text = "Código Veículo"
        '
        'Condutor_CodAcidenteLabel
        '
        Me.Condutor_CodAcidenteLabel.AutoSize = True
        Me.Condutor_CodAcidenteLabel.Location = New System.Drawing.Point(397, 18)
        Me.Condutor_CodAcidenteLabel.Name = "Condutor_CodAcidenteLabel"
        Me.Condutor_CodAcidenteLabel.Size = New System.Drawing.Size(88, 13)
        Me.Condutor_CodAcidenteLabel.TabIndex = 2
        Me.Condutor_CodAcidenteLabel.Text = "Código Acidente:"
        '
        'Condutor_CodVeiculoText
        '
        Me.Condutor_CodVeiculoText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.Condutor_CodVeiculoText.Enabled = False
        Me.Condutor_CodVeiculoText.Location = New System.Drawing.Point(292, 14)
        Me.Condutor_CodVeiculoText.MaxLength = 15
        Me.Condutor_CodVeiculoText.Name = "Condutor_CodVeiculoText"
        Me.Condutor_CodVeiculoText.Size = New System.Drawing.Size(100, 20)
        Me.Condutor_CodVeiculoText.TabIndex = 1
        '
        'Condutor_CodCondutorText
        '
        Me.Condutor_CodCondutorText.Enabled = False
        Me.Condutor_CodCondutorText.Location = New System.Drawing.Point(102, 14)
        Me.Condutor_CodCondutorText.MaxLength = 15
        Me.Condutor_CodCondutorText.Name = "Condutor_CodCondutorText"
        Me.Condutor_CodCondutorText.Size = New System.Drawing.Size(100, 20)
        Me.Condutor_CodCondutorText.TabIndex = 0
        '
        'Condutor_CodCondutorLabel
        '
        Me.Condutor_CodCondutorLabel.AutoSize = True
        Me.Condutor_CodCondutorLabel.Location = New System.Drawing.Point(8, 18)
        Me.Condutor_CodCondutorLabel.Name = "Condutor_CodCondutorLabel"
        Me.Condutor_CodCondutorLabel.Size = New System.Drawing.Size(89, 13)
        Me.Condutor_CodCondutorLabel.TabIndex = 5
        Me.Condutor_CodCondutorLabel.Text = "Código Condutor:"
        '
        'Panel3
        '
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel3.Controls.Add(Me.MapControlToolbar)
        Me.Panel3.Controls.Add(Me.MapStatusStrip)
        Me.Panel3.Controls.Add(Me.AxMap)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(722, 41)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(296, 460)
        Me.Panel3.TabIndex = 3
        '
        'MapControlToolbar
        '
        Me.MapControlToolbar.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.MapControlToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ZoomInButton, Me.ZoomOutButton, Me.ZoomButton, Me.ToolStripSeparator1, Me.PanLeftButton, Me.PanRightButton, Me.PanUpButton, Me.PanDownButton, Me.PanButton, Me.ToolStripSeparator2})
        Me.MapControlToolbar.Location = New System.Drawing.Point(0, 0)
        Me.MapControlToolbar.Name = "MapControlToolbar"
        Me.MapControlToolbar.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MapControlToolbar.Size = New System.Drawing.Size(292, 25)
        Me.MapControlToolbar.TabIndex = 2
        Me.MapControlToolbar.Text = "ToolStrip1"
        '
        'ZoomInButton
        '
        Me.ZoomInButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomInButton.Image = CType(resources.GetObject("ZoomInButton.Image"), System.Drawing.Image)
        Me.ZoomInButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomInButton.Name = "ZoomInButton"
        Me.ZoomInButton.Size = New System.Drawing.Size(23, 22)
        Me.ZoomInButton.Text = "ToolStripButton1"
        Me.ZoomInButton.ToolTipText = "Zoom +"
        '
        'ZoomOutButton
        '
        Me.ZoomOutButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomOutButton.Image = CType(resources.GetObject("ZoomOutButton.Image"), System.Drawing.Image)
        Me.ZoomOutButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomOutButton.Name = "ZoomOutButton"
        Me.ZoomOutButton.Size = New System.Drawing.Size(23, 22)
        Me.ZoomOutButton.Text = "ToolStripButton1"
        Me.ZoomOutButton.ToolTipText = "Zoom -"
        '
        'ZoomButton
        '
        Me.ZoomButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ZoomButton.Image = CType(resources.GetObject("ZoomButton.Image"), System.Drawing.Image)
        Me.ZoomButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ZoomButton.Name = "ZoomButton"
        Me.ZoomButton.Size = New System.Drawing.Size(23, 22)
        Me.ZoomButton.Text = "ToolStripButton1"
        Me.ZoomButton.ToolTipText = "Zoom"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'PanLeftButton
        '
        Me.PanLeftButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PanLeftButton.Image = CType(resources.GetObject("PanLeftButton.Image"), System.Drawing.Image)
        Me.PanLeftButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PanLeftButton.Name = "PanLeftButton"
        Me.PanLeftButton.Size = New System.Drawing.Size(23, 22)
        Me.PanLeftButton.Text = "ToolStripButton1"
        Me.PanLeftButton.ToolTipText = "Pan Left"
        '
        'PanRightButton
        '
        Me.PanRightButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PanRightButton.Image = CType(resources.GetObject("PanRightButton.Image"), System.Drawing.Image)
        Me.PanRightButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PanRightButton.Name = "PanRightButton"
        Me.PanRightButton.Size = New System.Drawing.Size(23, 22)
        Me.PanRightButton.Text = "ToolStripButton1"
        Me.PanRightButton.ToolTipText = "Pan Right"
        '
        'PanUpButton
        '
        Me.PanUpButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PanUpButton.Image = CType(resources.GetObject("PanUpButton.Image"), System.Drawing.Image)
        Me.PanUpButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PanUpButton.Name = "PanUpButton"
        Me.PanUpButton.Size = New System.Drawing.Size(23, 22)
        Me.PanUpButton.Text = "ToolStripButton1"
        Me.PanUpButton.ToolTipText = "Pan Up"
        '
        'PanDownButton
        '
        Me.PanDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PanDownButton.Image = CType(resources.GetObject("PanDownButton.Image"), System.Drawing.Image)
        Me.PanDownButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PanDownButton.Name = "PanDownButton"
        Me.PanDownButton.Size = New System.Drawing.Size(23, 22)
        Me.PanDownButton.Text = "ToolStripButton1"
        Me.PanDownButton.ToolTipText = "Pan Down"
        '
        'PanButton
        '
        Me.PanButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PanButton.Image = CType(resources.GetObject("PanButton.Image"), System.Drawing.Image)
        Me.PanButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.PanButton.Name = "PanButton"
        Me.PanButton.Size = New System.Drawing.Size(23, 22)
        Me.PanButton.Text = "ToolStripButton1"
        Me.PanButton.ToolTipText = "Pan"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MapStatusStrip
        '
        Me.MapStatusStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ScaleLabel, Me.ScaleDenominatorLabel})
        Me.MapStatusStrip.Location = New System.Drawing.Point(0, 434)
        Me.MapStatusStrip.Name = "MapStatusStrip"
        Me.MapStatusStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MapStatusStrip.Size = New System.Drawing.Size(292, 22)
        Me.MapStatusStrip.SizingGrip = False
        Me.MapStatusStrip.TabIndex = 1
        Me.MapStatusStrip.Text = "StatusStrip1"
        '
        'ScaleLabel
        '
        Me.ScaleLabel.Name = "ScaleLabel"
        Me.ScaleLabel.Size = New System.Drawing.Size(50, 17)
        Me.ScaleLabel.Text = "Escala 1:"
        '
        'ScaleDenominatorLabel
        '
        Me.ScaleDenominatorLabel.Name = "ScaleDenominatorLabel"
        Me.ScaleDenominatorLabel.Size = New System.Drawing.Size(111, 17)
        Me.ScaleDenominatorLabel.Text = "ToolStripStatusLabel1"
        '
        'AxMap
        '
        Me.AxMap.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxMap.Location = New System.Drawing.Point(3, 28)
        Me.AxMap.Name = "AxMap"
        Me.AxMap.OcxState = CType(resources.GetObject("AxMap.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxMap.Size = New System.Drawing.Size(286, 403)
        Me.AxMap.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.DimGray
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(722, 501)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(296, 41)
        Me.Panel4.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(6, 8)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 26)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "     Busca de Logradouros"
        '
        'Panel5
        '
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel5.Controls.Add(Me.DisplayResults)
        Me.Panel5.Controls.Add(Me.LogSearchToolbar)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(722, 542)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(296, 202)
        Me.Panel5.TabIndex = 5
        '
        'DisplayResults
        '
        Me.DisplayResults.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DisplayResults.Indent = 15
        Me.DisplayResults.ItemHeight = 18
        Me.DisplayResults.Location = New System.Drawing.Point(0, 25)
        Me.DisplayResults.Name = "DisplayResults"
        TreeNode1.Name = "Node0"
        TreeNode1.Text = "Logradouros encontrados:"
        Me.DisplayResults.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode1})
        Me.DisplayResults.Size = New System.Drawing.Size(292, 173)
        Me.DisplayResults.TabIndex = 3
        '
        'LogSearchToolbar
        '
        Me.LogSearchToolbar.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LogSearchText, Me.ToolStripButton1})
        Me.LogSearchToolbar.Location = New System.Drawing.Point(0, 0)
        Me.LogSearchToolbar.Name = "LogSearchToolbar"
        Me.LogSearchToolbar.Size = New System.Drawing.Size(292, 25)
        Me.LogSearchToolbar.TabIndex = 2
        Me.LogSearchToolbar.Text = "ToolStrip2"
        '
        'LogSearchText
        '
        Me.LogSearchText.Name = "LogSearchText"
        Me.LogSearchText.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Procurar Logradouro"
        '
        'ProvedorErros
        '
        Me.ProvedorErros.ContainerControl = Me
        '
        'CadastroAcidenteForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1018, 744)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CadastroAcidenteForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControlMaster.ResumeLayout(False)
        Me.AcidenteTabPage.ResumeLayout(False)
        CType(Me.AcidentesDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CaracteristicaAcidenteGroup.ResumeLayout(False)
        Me.CaracteristicaAcidenteTable.ResumeLayout(False)
        Me.CaracteristicaAcidenteTable.PerformLayout()
        Me.GeografiaGroup.ResumeLayout(False)
        Me.LocalizacaoTable.ResumeLayout(False)
        Me.LocalizacaoTable.PerformLayout()
        Me.GeralGroup.ResumeLayout(False)
        Me.GeralGroup.PerformLayout()
        CType(Me.Acidente_NoEnvolvidoNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VeiculoTabPage.ResumeLayout(False)
        CType(Me.VeiculosDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SeveridadeGroup.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel2.PerformLayout()
        CType(Me.Veiculo_SeveridadeNA, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Veiculo_SeveridadeFatalidade, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Veiculo_SeveridadeFeridoGrave, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Veiculo_SeveridadeFeridoLeve, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Veiculo_SeveridadeDanoMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Veiculo_SeveridadeSemDano, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VeiculoGroup.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.Veiculo_NoOcupantesNumeric, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.CondutorTabPage.ResumeLayout(False)
        CType(Me.CondutoresDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Condutor_SeveridadeGroup.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.TableLayoutPanel4.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.Condutor_InformacoesPessoaisGroup.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        Me.Condutor_InformacoesGeraisGroup.ResumeLayout(False)
        Me.Condutor_InformacoesGeraisGroup.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.MapControlToolbar.ResumeLayout(False)
        Me.MapControlToolbar.PerformLayout()
        Me.MapStatusStrip.ResumeLayout(False)
        Me.MapStatusStrip.PerformLayout()
        CType(Me.AxMap, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.LogSearchToolbar.ResumeLayout(False)
        Me.LogSearchToolbar.PerformLayout()
        CType(Me.ProvedorErros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents MapStatusStrip As System.Windows.Forms.StatusStrip
    Friend WithEvents AxMap As ESRI.ArcGIS.Controls.AxMapControl
    Friend WithEvents Panel4 As System.Windows.Forms.Panel
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Panel5 As System.Windows.Forms.Panel
    Friend WithEvents MapControlToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ScaleLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents ScaleDenominatorLabel As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents DisplayResults As System.Windows.Forms.TreeView
    Friend WithEvents LogSearchToolbar As System.Windows.Forms.ToolStrip
    Friend WithEvents ZoomInButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ZoomOutButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents PanLeftButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanRightButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanUpButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanDownButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents PanButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ZoomButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents LogSearchText As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStrip1 As System.Windows.Forms.ToolStrip
    Friend WithEvents ProvedorErros As System.Windows.Forms.ErrorProvider
    Friend WithEvents CadastrarAcidenteButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ResetAcidente As System.Windows.Forms.ToolStripButton
    Friend WithEvents TabControlMaster As System.Windows.Forms.TabControl
    Friend WithEvents AcidenteTabPage As System.Windows.Forms.TabPage
    Friend WithEvents CaracteristicaAcidenteGroup As System.Windows.Forms.GroupBox
    Friend WithEvents CaracteristicaAcidenteTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents ControleTrafegoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipoPavimentacaoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipoAcidenteCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ControleTrafegoLabel As System.Windows.Forms.Label
    Friend WithEvents TipoPavimentacaoLabel As System.Windows.Forms.Label
    Friend WithEvents TipoAcidenteLabel As System.Windows.Forms.Label
    Friend WithEvents TipoSocorroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CondicaoViaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CausaAcidenteCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipoSocorroLabel As System.Windows.Forms.Label
    Friend WithEvents CondicaoViaLabel As System.Windows.Forms.Label
    Friend WithEvents CausaAcidenteLabel As System.Windows.Forms.Label
    Friend WithEvents ClimaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents OrgaoResponsavelCombo As System.Windows.Forms.ComboBox
    Friend WithEvents CaracteristicaViaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ClimaLabel As System.Windows.Forms.Label
    Friend WithEvents OrgaoResponsavelLabel As System.Windows.Forms.Label
    Friend WithEvents CaracteristicaViaLabel As System.Windows.Forms.Label
    Friend WithEvents CaracteristicaAcidenteLabel As System.Windows.Forms.Label
    Friend WithEvents CaracteristicaAcidenteCombo As System.Windows.Forms.ComboBox
    Friend WithEvents GeografiaGroup As System.Windows.Forms.GroupBox
    Friend WithEvents LocalizacaoTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents NumeroText As System.Windows.Forms.TextBox
    Friend WithEvents NumeroLabel As System.Windows.Forms.Label
    Friend WithEvents NomeLogradouroLabel As System.Windows.Forms.Label
    Friend WithEvents TipoLogradouroLabel As System.Windows.Forms.Label
    Friend WithEvents BairroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents TipoLogradouroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents NomeLogradouroCombo As System.Windows.Forms.ComboBox
    Friend WithEvents BairroLabel As System.Windows.Forms.Label
    Friend WithEvents Intersecao1Label As System.Windows.Forms.Label
    Friend WithEvents Intersecao2Label As System.Windows.Forms.Label
    Friend WithEvents Intersecao1Combo As System.Windows.Forms.ComboBox
    Friend WithEvents Intersecao2Combo As System.Windows.Forms.ComboBox
    Friend WithEvents GeralGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Acidente_HoraText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Acidente_DataText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Acidente_NoEnvolvidoNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents NoEnvolvidoLabel As System.Windows.Forms.Label
    Friend WithEvents Acidente_NoBoText As System.Windows.Forms.TextBox
    Friend WithEvents HoraLabel As System.Windows.Forms.Label
    Friend WithEvents DataLabel As System.Windows.Forms.Label
    Friend WithEvents NoBoLabel As System.Windows.Forms.Label
    Friend WithEvents Acidente_CodAcidenteText As System.Windows.Forms.TextBox
    Friend WithEvents CodAcidenteLabel As System.Windows.Forms.Label
    Friend WithEvents VeiculoTabPage As System.Windows.Forms.TabPage
    Friend WithEvents VeiculosDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents SeveridadeGroup As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Veiculo_SeveridadeNA As System.Windows.Forms.NumericUpDown
    Friend WithEvents Veiculo_SeveridadeFatalidade As System.Windows.Forms.NumericUpDown
    Friend WithEvents Veiculo_SeveridadeFeridoGrave As System.Windows.Forms.NumericUpDown
    Friend WithEvents Veiculo_SeveridadeFeridoLeve As System.Windows.Forms.NumericUpDown
    Friend WithEvents Veiculo_SeveridadeDanoMaterial As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Veiculo_SeveridadeSemDano As System.Windows.Forms.NumericUpDown
    Friend WithEvents VeiculoGroup As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Veiculo_NoOcupantesNumeric As System.Windows.Forms.NumericUpDown
    Friend WithEvents Veiculo_TipoVeiculoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Veiculo_ApreendidoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Veiculo_EquipSegurancaCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Veiculo_SentidoVeiculoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Veiculo_PlacaVeiculoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Veiculo_CodAcidenteText As System.Windows.Forms.TextBox
    Friend WithEvents Label34 As System.Windows.Forms.Label
    Friend WithEvents Veiculo_CodVeiculoText As System.Windows.Forms.TextBox
    Friend WithEvents Label35 As System.Windows.Forms.Label
    Friend WithEvents CondutorTabPage As System.Windows.Forms.TabPage
    Friend WithEvents AcidentesDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents InserirAcidenteButton As System.Windows.Forms.Button
    Friend WithEvents InserirVeiculoButton As System.Windows.Forms.Button
    Friend WithEvents ObsLabel As System.Windows.Forms.Label
    Friend WithEvents ObsText As System.Windows.Forms.TextBox
    Friend WithEvents cod_acidente As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_boletim As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents hora As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_veiculos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents bairro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipolog As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents nomelog As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents numero As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents intersecao1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents intersecao2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_caracteristica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_causa As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_tipo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_caracteristicavia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_condicaovia As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_pavimentacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_tiposocorro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_controletrafego As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_orgaoresponsavel As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents acid_clima As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Condutor_InformacoesGeraisGroup As System.Windows.Forms.GroupBox
    Friend WithEvents Condutor_CodVeiculoText As System.Windows.Forms.TextBox
    Friend WithEvents Condutor_CodVeiculoLabel As System.Windows.Forms.Label
    Friend WithEvents Condutor_CodAcidenteLabel As System.Windows.Forms.Label
    Friend WithEvents Condutor_CodCondutorText As System.Windows.Forms.TextBox
    Friend WithEvents Condutor_CodCondutorLabel As System.Windows.Forms.Label
    Friend WithEvents Condutor_CodAcidenteText As System.Windows.Forms.TextBox
    Friend WithEvents Condutor_InformacoesPessoaisGroup As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Condutor_CondicaoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Condutor_EscolaridadeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Condutor_ProfissaoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Condutor_ComportamentoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Condutor_DataNascimentoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Condutor_DataHabilitacaoText As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Condutor_SexoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Condutor_HabilitacaoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Condutor_ProntuarioText As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Condutor_EstadoLabel As System.Windows.Forms.Label
    Friend WithEvents Condutor_CidadeCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Condutor_CidadeLabel As System.Windows.Forms.Label
    Friend WithEvents Condutor_EstadoCombo As System.Windows.Forms.ComboBox
    Friend WithEvents Condutor_SeveridadeGroup As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents InserirCondutorButton As System.Windows.Forms.Button
    Friend WithEvents CondutoresDataGrid As System.Windows.Forms.DataGridView
    Friend WithEvents cod_veiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_acidente_veiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tipo_veiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents placa_veiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents apreendido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents no_ocupantes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sentido_veiculo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents veic_equipseg As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sev_sem_danos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sev_danos_materiais As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sev_feridos_leves As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sev_feridos_graves As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sev_fatalidades As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents sev_nao_apurado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Condutor_FatalidadeRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Condutor_FeridoGraveRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Condutor_FeridoLeveRadio As System.Windows.Forms.RadioButton
    Friend WithEvents Condutor_SemDanosRadio As System.Windows.Forms.RadioButton
    Friend WithEvents cod_condutor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_veiculo_condutor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cod_acidente_condutor As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents estado_origem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cidade_origem As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents escolaridade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents profissao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents habilitacao As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents comportamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents condicao_fisica As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents cond_sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_nasc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents data_hab As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_semdanos As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_feridoleve As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_feridograve As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents c_fatalidade As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents prontuario As System.Windows.Forms.DataGridViewTextBoxColumn

End Class
