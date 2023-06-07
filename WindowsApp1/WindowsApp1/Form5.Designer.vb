<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAluguel
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CODIGOLabel As System.Windows.Forms.Label
        Dim CPF_FUNCLabel As System.Windows.Forms.Label
        Dim CPF_CLILabel As System.Windows.Forms.Label
        Dim PLACA_CARLabel As System.Windows.Forms.Label
        Dim DTALUGUELLabel As System.Windows.Forms.Label
        Dim DTPREVISAOLabel As System.Windows.Forms.Label
        Dim ENTREGALabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim DTENTREGALabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim CPFLabel1 As System.Windows.Forms.Label
        Dim MODELOLabel As System.Windows.Forms.Label
        Dim ANOLabel As System.Windows.Forms.Label
        Dim CORLabel As System.Windows.Forms.Label
        Dim DISPONIBILIDADELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmAluguel))
        Me.DataSet1 = New WindowsApp1.DataSet1()
        Me.ALUGUELBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ALUGUELTableAdapter = New WindowsApp1.DataSet1TableAdapters.ALUGUELTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.DataSet1TableAdapters.TableAdapterManager()
        Me.CARROSTableAdapter = New WindowsApp1.DataSet1TableAdapters.CARROSTableAdapter()
        Me.CLIENTESTableAdapter = New WindowsApp1.DataSet1TableAdapters.CLIENTESTableAdapter()
        Me.FUNCIONARIOSTableAdapter = New WindowsApp1.DataSet1TableAdapters.FUNCIONARIOSTableAdapter()
        Me.ALUGUELBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ALUGUELBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CODIGOTextBox = New System.Windows.Forms.TextBox()
        Me.CPF_FUNCComboBox = New System.Windows.Forms.ComboBox()
        Me.FUNCIONARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CPF_CLIComboBox = New System.Windows.Forms.ComboBox()
        Me.CLIENTESBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PLACA_CARComboBox = New System.Windows.Forms.ComboBox()
        Me.CARROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DTALUGUELMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.DTPREVISAOMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ENTREGAComboBox = New System.Windows.Forms.ComboBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.DTENTREGAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.CPFMaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.MODELOTextBox = New System.Windows.Forms.TextBox()
        Me.ANOTextBox = New System.Windows.Forms.TextBox()
        Me.CORTextBox = New System.Windows.Forms.TextBox()
        Me.DISPONIBILIDADETextBox = New System.Windows.Forms.TextBox()
        CODIGOLabel = New System.Windows.Forms.Label()
        CPF_FUNCLabel = New System.Windows.Forms.Label()
        CPF_CLILabel = New System.Windows.Forms.Label()
        PLACA_CARLabel = New System.Windows.Forms.Label()
        DTALUGUELLabel = New System.Windows.Forms.Label()
        DTPREVISAOLabel = New System.Windows.Forms.Label()
        ENTREGALabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        DTENTREGALabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        CPFLabel1 = New System.Windows.Forms.Label()
        MODELOLabel = New System.Windows.Forms.Label()
        ANOLabel = New System.Windows.Forms.Label()
        CORLabel = New System.Windows.Forms.Label()
        DISPONIBILIDADELabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUGUELBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ALUGUELBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ALUGUELBindingNavigator.SuspendLayout()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CODIGOLabel
        '
        CODIGOLabel.AutoSize = True
        CODIGOLabel.Location = New System.Drawing.Point(4, 31)
        CODIGOLabel.Name = "CODIGOLabel"
        CODIGOLabel.Size = New System.Drawing.Size(52, 13)
        CODIGOLabel.TabIndex = 1
        CODIGOLabel.Text = "CODIGO:"
        '
        'CPF_FUNCLabel
        '
        CPF_FUNCLabel.AutoSize = True
        CPF_FUNCLabel.Location = New System.Drawing.Point(4, 57)
        CPF_FUNCLabel.Name = "CPF_FUNCLabel"
        CPF_FUNCLabel.Size = New System.Drawing.Size(84, 13)
        CPF_FUNCLabel.TabIndex = 3
        CPF_FUNCLabel.Text = "FUNCIONÁRIO:"
        AddHandler CPF_FUNCLabel.Click, AddressOf Me.CPF_FUNCLabel_Click
        '
        'CPF_CLILabel
        '
        CPF_CLILabel.AutoSize = True
        CPF_CLILabel.Location = New System.Drawing.Point(4, 84)
        CPF_CLILabel.Name = "CPF_CLILabel"
        CPF_CLILabel.Size = New System.Drawing.Size(55, 13)
        CPF_CLILabel.TabIndex = 5
        CPF_CLILabel.Text = "CLIENTE:"
        '
        'PLACA_CARLabel
        '
        PLACA_CARLabel.AutoSize = True
        PLACA_CARLabel.Location = New System.Drawing.Point(4, 111)
        PLACA_CARLabel.Name = "PLACA_CARLabel"
        PLACA_CARLabel.Size = New System.Drawing.Size(48, 13)
        PLACA_CARLabel.TabIndex = 7
        PLACA_CARLabel.Text = "CARRO:"
        AddHandler PLACA_CARLabel.Click, AddressOf Me.PLACA_CARLabel_Click
        '
        'DTALUGUELLabel
        '
        DTALUGUELLabel.AutoSize = True
        DTALUGUELLabel.Location = New System.Drawing.Point(4, 163)
        DTALUGUELLabel.Name = "DTALUGUELLabel"
        DTALUGUELLabel.Size = New System.Drawing.Size(75, 13)
        DTALUGUELLabel.TabIndex = 9
        DTALUGUELLabel.Text = "DTALUGUEL:"
        '
        'DTPREVISAOLabel
        '
        DTPREVISAOLabel.AutoSize = True
        DTPREVISAOLabel.Location = New System.Drawing.Point(4, 189)
        DTPREVISAOLabel.Name = "DTPREVISAOLabel"
        DTPREVISAOLabel.Size = New System.Drawing.Size(79, 13)
        DTPREVISAOLabel.TabIndex = 11
        DTPREVISAOLabel.Text = "DTPREVISAO:"
        '
        'ENTREGALabel
        '
        ENTREGALabel.AutoSize = True
        ENTREGALabel.Location = New System.Drawing.Point(4, 216)
        ENTREGALabel.Name = "ENTREGALabel"
        ENTREGALabel.Size = New System.Drawing.Size(62, 13)
        ENTREGALabel.TabIndex = 15
        ENTREGALabel.Text = "ENTREGA:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(4, 243)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 17
        OBSLabel.Text = "OBS:"
        '
        'DTENTREGALabel
        '
        DTENTREGALabel.AutoSize = True
        DTENTREGALabel.Location = New System.Drawing.Point(2, 136)
        DTENTREGALabel.Name = "DTENTREGALabel"
        DTENTREGALabel.Size = New System.Drawing.Size(77, 13)
        DTENTREGALabel.TabIndex = 18
        DTENTREGALabel.Text = "DTENTREGA:"
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Enabled = False
        CPFLabel.Location = New System.Drawing.Point(243, 60)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 19
        CPFLabel.Text = "CPF:"
        '
        'CPFLabel1
        '
        CPFLabel1.AutoSize = True
        CPFLabel1.Enabled = False
        CPFLabel1.Location = New System.Drawing.Point(243, 88)
        CPFLabel1.Name = "CPFLabel1"
        CPFLabel1.Size = New System.Drawing.Size(30, 13)
        CPFLabel1.TabIndex = 21
        CPFLabel1.Text = "CPF:"
        '
        'MODELOLabel
        '
        MODELOLabel.AutoSize = True
        MODELOLabel.Enabled = False
        MODELOLabel.Location = New System.Drawing.Point(217, 114)
        MODELOLabel.Name = "MODELOLabel"
        MODELOLabel.Size = New System.Drawing.Size(56, 13)
        MODELOLabel.TabIndex = 23
        MODELOLabel.Text = "MODELO:"
        '
        'ANOLabel
        '
        ANOLabel.AutoSize = True
        ANOLabel.Enabled = False
        ANOLabel.Location = New System.Drawing.Point(386, 114)
        ANOLabel.Name = "ANOLabel"
        ANOLabel.Size = New System.Drawing.Size(33, 13)
        ANOLabel.TabIndex = 25
        ANOLabel.Text = "ANO:"
        '
        'CORLabel
        '
        CORLabel.AutoSize = True
        CORLabel.Enabled = False
        CORLabel.Location = New System.Drawing.Point(532, 117)
        CORLabel.Name = "CORLabel"
        CORLabel.Size = New System.Drawing.Size(33, 13)
        CORLabel.TabIndex = 27
        CORLabel.Text = "COR:"
        '
        'DISPONIBILIDADELabel
        '
        DISPONIBILIDADELabel.AutoSize = True
        DISPONIBILIDADELabel.Enabled = False
        DISPONIBILIDADELabel.Location = New System.Drawing.Point(677, 118)
        DISPONIBILIDADELabel.Name = "DISPONIBILIDADELabel"
        DISPONIBILIDADELabel.Size = New System.Drawing.Size(103, 13)
        DISPONIBILIDADELabel.TabIndex = 29
        DISPONIBILIDADELabel.Text = "DISPONIBILIDADE:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ALUGUELBindingSource
        '
        Me.ALUGUELBindingSource.DataMember = "ALUGUEL"
        Me.ALUGUELBindingSource.DataSource = Me.DataSet1
        '
        'ALUGUELTableAdapter
        '
        Me.ALUGUELTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUGUELTableAdapter = Me.ALUGUELTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Me.CARROSTableAdapter
        Me.TableAdapterManager.CLIENTESTableAdapter = Me.CLIENTESTableAdapter
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Me.FUNCIONARIOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CARROSTableAdapter
        '
        Me.CARROSTableAdapter.ClearBeforeFill = True
        '
        'CLIENTESTableAdapter
        '
        Me.CLIENTESTableAdapter.ClearBeforeFill = True
        '
        'FUNCIONARIOSTableAdapter
        '
        Me.FUNCIONARIOSTableAdapter.ClearBeforeFill = True
        '
        'ALUGUELBindingNavigator
        '
        Me.ALUGUELBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.ALUGUELBindingNavigator.BindingSource = Me.ALUGUELBindingSource
        Me.ALUGUELBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.ALUGUELBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.ALUGUELBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.ALUGUELBindingNavigatorSaveItem})
        Me.ALUGUELBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.ALUGUELBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.ALUGUELBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.ALUGUELBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.ALUGUELBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.ALUGUELBindingNavigator.Name = "ALUGUELBindingNavigator"
        Me.ALUGUELBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.ALUGUELBindingNavigator.Size = New System.Drawing.Size(917, 25)
        Me.ALUGUELBindingNavigator.TabIndex = 0
        Me.ALUGUELBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Adicionar novo"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primeiro"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posição"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posição atual"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover próximo"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ALUGUELBindingNavigatorSaveItem
        '
        Me.ALUGUELBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ALUGUELBindingNavigatorSaveItem.Image = CType(resources.GetObject("ALUGUELBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.ALUGUELBindingNavigatorSaveItem.Name = "ALUGUELBindingNavigatorSaveItem"
        Me.ALUGUELBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.ALUGUELBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CODIGOTextBox
        '
        Me.CODIGOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "CODIGO", True))
        Me.CODIGOTextBox.Enabled = False
        Me.CODIGOTextBox.Location = New System.Drawing.Point(89, 28)
        Me.CODIGOTextBox.Name = "CODIGOTextBox"
        Me.CODIGOTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CODIGOTextBox.TabIndex = 2
        '
        'CPF_FUNCComboBox
        '
        Me.CPF_FUNCComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "CPF_FUNC", True))
        Me.CPF_FUNCComboBox.DataSource = Me.FUNCIONARIOSBindingSource
        Me.CPF_FUNCComboBox.DisplayMember = "NOME"
        Me.CPF_FUNCComboBox.FormattingEnabled = True
        Me.CPF_FUNCComboBox.Location = New System.Drawing.Point(89, 54)
        Me.CPF_FUNCComboBox.Name = "CPF_FUNCComboBox"
        Me.CPF_FUNCComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CPF_FUNCComboBox.TabIndex = 4
        Me.CPF_FUNCComboBox.ValueMember = "NOME"
        '
        'FUNCIONARIOSBindingSource
        '
        Me.FUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS"
        Me.FUNCIONARIOSBindingSource.DataSource = Me.DataSet1
        '
        'CPF_CLIComboBox
        '
        Me.CPF_CLIComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "CPF_CLI", True))
        Me.CPF_CLIComboBox.DataSource = Me.CLIENTESBindingSource
        Me.CPF_CLIComboBox.DisplayMember = "NOME"
        Me.CPF_CLIComboBox.FormattingEnabled = True
        Me.CPF_CLIComboBox.Location = New System.Drawing.Point(89, 81)
        Me.CPF_CLIComboBox.Name = "CPF_CLIComboBox"
        Me.CPF_CLIComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CPF_CLIComboBox.TabIndex = 6
        Me.CPF_CLIComboBox.ValueMember = "NOME"
        '
        'CLIENTESBindingSource
        '
        Me.CLIENTESBindingSource.DataMember = "CLIENTES"
        Me.CLIENTESBindingSource.DataSource = Me.DataSet1
        '
        'PLACA_CARComboBox
        '
        Me.PLACA_CARComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "PLACA_CAR", True))
        Me.PLACA_CARComboBox.DataSource = Me.CARROSBindingSource
        Me.PLACA_CARComboBox.DisplayMember = "PLACA"
        Me.PLACA_CARComboBox.FormattingEnabled = True
        Me.PLACA_CARComboBox.Location = New System.Drawing.Point(89, 108)
        Me.PLACA_CARComboBox.Name = "PLACA_CARComboBox"
        Me.PLACA_CARComboBox.Size = New System.Drawing.Size(121, 21)
        Me.PLACA_CARComboBox.TabIndex = 8
        Me.PLACA_CARComboBox.ValueMember = "PLACA"
        '
        'CARROSBindingSource
        '
        Me.CARROSBindingSource.DataMember = "CARROS"
        Me.CARROSBindingSource.DataSource = Me.DataSet1
        '
        'DTALUGUELMaskedTextBox
        '
        Me.DTALUGUELMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "DTALUGUEL", True))
        Me.DTALUGUELMaskedTextBox.Location = New System.Drawing.Point(89, 160)
        Me.DTALUGUELMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DTALUGUELMaskedTextBox.Name = "DTALUGUELMaskedTextBox"
        Me.DTALUGUELMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DTALUGUELMaskedTextBox.TabIndex = 10
        Me.DTALUGUELMaskedTextBox.ValidatingType = GetType(Date)
        '
        'DTPREVISAOMaskedTextBox
        '
        Me.DTPREVISAOMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "DTPREVISAO", True))
        Me.DTPREVISAOMaskedTextBox.Location = New System.Drawing.Point(89, 186)
        Me.DTPREVISAOMaskedTextBox.Mask = "00/00/0000 90:00"
        Me.DTPREVISAOMaskedTextBox.Name = "DTPREVISAOMaskedTextBox"
        Me.DTPREVISAOMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DTPREVISAOMaskedTextBox.TabIndex = 12
        '
        'ENTREGAComboBox
        '
        Me.ENTREGAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "ENTREGA", True))
        Me.ENTREGAComboBox.FormattingEnabled = True
        Me.ENTREGAComboBox.Items.AddRange(New Object() {"Não", "Sim"})
        Me.ENTREGAComboBox.Location = New System.Drawing.Point(89, 213)
        Me.ENTREGAComboBox.Name = "ENTREGAComboBox"
        Me.ENTREGAComboBox.Size = New System.Drawing.Size(121, 21)
        Me.ENTREGAComboBox.TabIndex = 16
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(89, 240)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(121, 55)
        Me.OBSTextBox.TabIndex = 18
        '
        'DTENTREGAMaskedTextBox
        '
        Me.DTENTREGAMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ALUGUELBindingSource, "DTENTREGA", True))
        Me.DTENTREGAMaskedTextBox.Location = New System.Drawing.Point(89, 133)
        Me.DTENTREGAMaskedTextBox.Name = "DTENTREGAMaskedTextBox"
        Me.DTENTREGAMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.DTENTREGAMaskedTextBox.TabIndex = 19
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FUNCIONARIOSBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Enabled = False
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(279, 57)
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFMaskedTextBox.TabIndex = 20
        '
        'CPFMaskedTextBox1
        '
        Me.CPFMaskedTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CLIENTESBindingSource, "CPF", True))
        Me.CPFMaskedTextBox1.Enabled = False
        Me.CPFMaskedTextBox1.Location = New System.Drawing.Point(279, 85)
        Me.CPFMaskedTextBox1.Name = "CPFMaskedTextBox1"
        Me.CPFMaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.CPFMaskedTextBox1.TabIndex = 22
        '
        'MODELOTextBox
        '
        Me.MODELOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "MODELO", True))
        Me.MODELOTextBox.Enabled = False
        Me.MODELOTextBox.Location = New System.Drawing.Point(279, 111)
        Me.MODELOTextBox.Name = "MODELOTextBox"
        Me.MODELOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.MODELOTextBox.TabIndex = 24
        '
        'ANOTextBox
        '
        Me.ANOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "ANO", True))
        Me.ANOTextBox.Enabled = False
        Me.ANOTextBox.Location = New System.Drawing.Point(425, 111)
        Me.ANOTextBox.Name = "ANOTextBox"
        Me.ANOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ANOTextBox.TabIndex = 26
        '
        'CORTextBox
        '
        Me.CORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "COR", True))
        Me.CORTextBox.Enabled = False
        Me.CORTextBox.Location = New System.Drawing.Point(571, 114)
        Me.CORTextBox.Name = "CORTextBox"
        Me.CORTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CORTextBox.TabIndex = 28
        '
        'DISPONIBILIDADETextBox
        '
        Me.DISPONIBILIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "DISPONIBILIDADE", True))
        Me.DISPONIBILIDADETextBox.Enabled = False
        Me.DISPONIBILIDADETextBox.Location = New System.Drawing.Point(786, 115)
        Me.DISPONIBILIDADETextBox.Name = "DISPONIBILIDADETextBox"
        Me.DISPONIBILIDADETextBox.Size = New System.Drawing.Size(100, 20)
        Me.DISPONIBILIDADETextBox.TabIndex = 30
        '
        'FrmAluguel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 386)
        Me.Controls.Add(DISPONIBILIDADELabel)
        Me.Controls.Add(Me.DISPONIBILIDADETextBox)
        Me.Controls.Add(CORLabel)
        Me.Controls.Add(Me.CORTextBox)
        Me.Controls.Add(ANOLabel)
        Me.Controls.Add(Me.ANOTextBox)
        Me.Controls.Add(MODELOLabel)
        Me.Controls.Add(Me.MODELOTextBox)
        Me.Controls.Add(CPFLabel1)
        Me.Controls.Add(Me.CPFMaskedTextBox1)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(DTENTREGALabel)
        Me.Controls.Add(Me.DTENTREGAMaskedTextBox)
        Me.Controls.Add(CODIGOLabel)
        Me.Controls.Add(Me.CODIGOTextBox)
        Me.Controls.Add(CPF_FUNCLabel)
        Me.Controls.Add(Me.CPF_FUNCComboBox)
        Me.Controls.Add(CPF_CLILabel)
        Me.Controls.Add(Me.CPF_CLIComboBox)
        Me.Controls.Add(PLACA_CARLabel)
        Me.Controls.Add(Me.PLACA_CARComboBox)
        Me.Controls.Add(DTALUGUELLabel)
        Me.Controls.Add(Me.DTALUGUELMaskedTextBox)
        Me.Controls.Add(DTPREVISAOLabel)
        Me.Controls.Add(Me.DTPREVISAOMaskedTextBox)
        Me.Controls.Add(ENTREGALabel)
        Me.Controls.Add(Me.ENTREGAComboBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.ALUGUELBindingNavigator)
        Me.Name = "FrmAluguel"
        Me.Text = "Cadastro de  Aluguel"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUGUELBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ALUGUELBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ALUGUELBindingNavigator.ResumeLayout(False)
        Me.ALUGUELBindingNavigator.PerformLayout()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CLIENTESBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents ALUGUELBindingSource As BindingSource
    Friend WithEvents ALUGUELTableAdapter As DataSet1TableAdapters.ALUGUELTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents ALUGUELBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents ALUGUELBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CODIGOTextBox As TextBox
    Friend WithEvents CPF_FUNCComboBox As ComboBox
    Friend WithEvents CPF_CLIComboBox As ComboBox
    Friend WithEvents PLACA_CARComboBox As ComboBox
    Friend WithEvents DTALUGUELMaskedTextBox As MaskedTextBox
    Friend WithEvents DTPREVISAOMaskedTextBox As MaskedTextBox
    Friend WithEvents ENTREGAComboBox As ComboBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents DTENTREGAMaskedTextBox As MaskedTextBox
    Friend WithEvents FUNCIONARIOSTableAdapter As DataSet1TableAdapters.FUNCIONARIOSTableAdapter
    Friend WithEvents FUNCIONARIOSBindingSource As BindingSource
    Friend WithEvents CLIENTESTableAdapter As DataSet1TableAdapters.CLIENTESTableAdapter
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents CLIENTESBindingSource As BindingSource
    Friend WithEvents CPFMaskedTextBox1 As MaskedTextBox
    Friend WithEvents CARROSTableAdapter As DataSet1TableAdapters.CARROSTableAdapter
    Friend WithEvents CARROSBindingSource As BindingSource
    Friend WithEvents MODELOTextBox As TextBox
    Friend WithEvents ANOTextBox As TextBox
    Friend WithEvents CORTextBox As TextBox
    Friend WithEvents DISPONIBILIDADETextBox As TextBox
End Class
