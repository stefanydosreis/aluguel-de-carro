<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmCarro
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim PLACALabel As System.Windows.Forms.Label
        Dim MODELOLabel As System.Windows.Forms.Label
        Dim FABRICANTELabel As System.Windows.Forms.Label
        Dim CORLabel As System.Windows.Forms.Label
        Dim ANOLabel As System.Windows.Forms.Label
        Dim FOTOLabel As System.Windows.Forms.Label
        Dim CATEGORIALabel As System.Windows.Forms.Label
        Dim MOTORLabel As System.Windows.Forms.Label
        Dim OPCIONAISLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim DISPONIBILIDADELabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCarro))
        Me.DataSet1 = New WindowsApp1.DataSet1()
        Me.CARROSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CARROSTableAdapter = New WindowsApp1.DataSet1TableAdapters.CARROSTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.DataSet1TableAdapters.TableAdapterManager()
        Me.CARROSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CARROSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PLACAMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.MODELOTextBox = New System.Windows.Forms.TextBox()
        Me.FABRICANTEComboBox = New System.Windows.Forms.ComboBox()
        Me.CORTextBox = New System.Windows.Forms.TextBox()
        Me.ANOTextBox = New System.Windows.Forms.TextBox()
        Me.FOTOPictureBox = New System.Windows.Forms.PictureBox()
        Me.CATEGORIAComboBox = New System.Windows.Forms.ComboBox()
        Me.MOTORTextBox = New System.Windows.Forms.TextBox()
        Me.OPCIONAISTextBox = New System.Windows.Forms.TextBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        Me.DISPONIBILIDADETextBox = New System.Windows.Forms.TextBox()
        PLACALabel = New System.Windows.Forms.Label()
        MODELOLabel = New System.Windows.Forms.Label()
        FABRICANTELabel = New System.Windows.Forms.Label()
        CORLabel = New System.Windows.Forms.Label()
        ANOLabel = New System.Windows.Forms.Label()
        FOTOLabel = New System.Windows.Forms.Label()
        CATEGORIALabel = New System.Windows.Forms.Label()
        MOTORLabel = New System.Windows.Forms.Label()
        OPCIONAISLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        DISPONIBILIDADELabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CARROSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CARROSBindingNavigator.SuspendLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PLACALabel
        '
        PLACALabel.AutoSize = True
        PLACALabel.Location = New System.Drawing.Point(16, 31)
        PLACALabel.Name = "PLACALabel"
        PLACALabel.Size = New System.Drawing.Size(44, 13)
        PLACALabel.TabIndex = 1
        PLACALabel.Text = "PLACA:"
        '
        'MODELOLabel
        '
        MODELOLabel.AutoSize = True
        MODELOLabel.Location = New System.Drawing.Point(16, 57)
        MODELOLabel.Name = "MODELOLabel"
        MODELOLabel.Size = New System.Drawing.Size(56, 13)
        MODELOLabel.TabIndex = 3
        MODELOLabel.Text = "MODELO:"
        '
        'FABRICANTELabel
        '
        FABRICANTELabel.AutoSize = True
        FABRICANTELabel.Location = New System.Drawing.Point(16, 83)
        FABRICANTELabel.Name = "FABRICANTELabel"
        FABRICANTELabel.Size = New System.Drawing.Size(77, 13)
        FABRICANTELabel.TabIndex = 5
        FABRICANTELabel.Text = "FABRICANTE:"
        AddHandler FABRICANTELabel.Click, AddressOf Me.FABRICANTELabel_Click
        '
        'CORLabel
        '
        CORLabel.AutoSize = True
        CORLabel.Location = New System.Drawing.Point(16, 110)
        CORLabel.Name = "CORLabel"
        CORLabel.Size = New System.Drawing.Size(33, 13)
        CORLabel.TabIndex = 7
        CORLabel.Text = "COR:"
        '
        'ANOLabel
        '
        ANOLabel.AutoSize = True
        ANOLabel.Location = New System.Drawing.Point(16, 136)
        ANOLabel.Name = "ANOLabel"
        ANOLabel.Size = New System.Drawing.Size(33, 13)
        ANOLabel.TabIndex = 9
        ANOLabel.Text = "ANO:"
        '
        'FOTOLabel
        '
        FOTOLabel.AutoSize = True
        FOTOLabel.Location = New System.Drawing.Point(16, 159)
        FOTOLabel.Name = "FOTOLabel"
        FOTOLabel.Size = New System.Drawing.Size(39, 13)
        FOTOLabel.TabIndex = 11
        FOTOLabel.Text = "FOTO:"
        '
        'CATEGORIALabel
        '
        CATEGORIALabel.AutoSize = True
        CATEGORIALabel.Location = New System.Drawing.Point(16, 251)
        CATEGORIALabel.Name = "CATEGORIALabel"
        CATEGORIALabel.Size = New System.Drawing.Size(72, 13)
        CATEGORIALabel.TabIndex = 13
        CATEGORIALabel.Text = "CATEGORIA:"
        '
        'MOTORLabel
        '
        MOTORLabel.AutoSize = True
        MOTORLabel.Location = New System.Drawing.Point(16, 278)
        MOTORLabel.Name = "MOTORLabel"
        MOTORLabel.Size = New System.Drawing.Size(50, 13)
        MOTORLabel.TabIndex = 15
        MOTORLabel.Text = "MOTOR:"
        '
        'OPCIONAISLabel
        '
        OPCIONAISLabel.AutoSize = True
        OPCIONAISLabel.Location = New System.Drawing.Point(16, 304)
        OPCIONAISLabel.Name = "OPCIONAISLabel"
        OPCIONAISLabel.Size = New System.Drawing.Size(68, 13)
        OPCIONAISLabel.TabIndex = 17
        OPCIONAISLabel.Text = "OPCIONAIS:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(16, 330)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 19
        OBSLabel.Text = "OBS:"
        '
        'DISPONIBILIDADELabel
        '
        DISPONIBILIDADELabel.AutoSize = True
        DISPONIBILIDADELabel.Location = New System.Drawing.Point(16, 356)
        DISPONIBILIDADELabel.Name = "DISPONIBILIDADELabel"
        DISPONIBILIDADELabel.Size = New System.Drawing.Size(103, 13)
        DISPONIBILIDADELabel.TabIndex = 21
        DISPONIBILIDADELabel.Text = "DISPONIBILIDADE:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CARROSBindingSource
        '
        Me.CARROSBindingSource.DataMember = "CARROS"
        Me.CARROSBindingSource.DataSource = Me.DataSet1
        '
        'CARROSTableAdapter
        '
        Me.CARROSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUGUELTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Me.CARROSTableAdapter
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CARROSBindingNavigator
        '
        Me.CARROSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CARROSBindingNavigator.BindingSource = Me.CARROSBindingSource
        Me.CARROSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CARROSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CARROSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CARROSBindingNavigatorSaveItem})
        Me.CARROSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CARROSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CARROSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CARROSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CARROSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CARROSBindingNavigator.Name = "CARROSBindingNavigator"
        Me.CARROSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CARROSBindingNavigator.Size = New System.Drawing.Size(310, 25)
        Me.CARROSBindingNavigator.TabIndex = 0
        Me.CARROSBindingNavigator.Text = "BindingNavigator1"
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
        'CARROSBindingNavigatorSaveItem
        '
        Me.CARROSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CARROSBindingNavigatorSaveItem.Image = CType(resources.GetObject("CARROSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CARROSBindingNavigatorSaveItem.Name = "CARROSBindingNavigatorSaveItem"
        Me.CARROSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CARROSBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'PLACAMaskedTextBox
        '
        Me.PLACAMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "PLACA", True))
        Me.PLACAMaskedTextBox.Location = New System.Drawing.Point(125, 28)
        Me.PLACAMaskedTextBox.Mask = "AAA0A00"
        Me.PLACAMaskedTextBox.Name = "PLACAMaskedTextBox"
        Me.PLACAMaskedTextBox.Size = New System.Drawing.Size(121, 20)
        Me.PLACAMaskedTextBox.TabIndex = 2
        '
        'MODELOTextBox
        '
        Me.MODELOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "MODELO", True))
        Me.MODELOTextBox.Location = New System.Drawing.Point(125, 54)
        Me.MODELOTextBox.Name = "MODELOTextBox"
        Me.MODELOTextBox.Size = New System.Drawing.Size(121, 20)
        Me.MODELOTextBox.TabIndex = 4
        '
        'FABRICANTEComboBox
        '
        Me.FABRICANTEComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "FABRICANTE", True))
        Me.FABRICANTEComboBox.FormattingEnabled = True
        Me.FABRICANTEComboBox.Items.AddRange(New Object() {"Audi.", "BMW.", "CAOA Chery.", "Chevrolet.", "Citroën.", "Jeep", "Fiat", "Ford", "Nissan", "Peugeot", "KIA", "Honda", "Chevrolet", "Ferrari", "Hyundai", "Jaguar", "VolksWagen", "Suzuki", "Renault"})
        Me.FABRICANTEComboBox.Location = New System.Drawing.Point(125, 80)
        Me.FABRICANTEComboBox.Name = "FABRICANTEComboBox"
        Me.FABRICANTEComboBox.Size = New System.Drawing.Size(121, 21)
        Me.FABRICANTEComboBox.TabIndex = 6
        '
        'CORTextBox
        '
        Me.CORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "COR", True))
        Me.CORTextBox.Location = New System.Drawing.Point(125, 107)
        Me.CORTextBox.Name = "CORTextBox"
        Me.CORTextBox.Size = New System.Drawing.Size(121, 20)
        Me.CORTextBox.TabIndex = 8
        '
        'ANOTextBox
        '
        Me.ANOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "ANO", True))
        Me.ANOTextBox.Location = New System.Drawing.Point(125, 133)
        Me.ANOTextBox.Name = "ANOTextBox"
        Me.ANOTextBox.Size = New System.Drawing.Size(121, 20)
        Me.ANOTextBox.TabIndex = 10
        '
        'FOTOPictureBox
        '
        Me.FOTOPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.CARROSBindingSource, "FOTO", True))
        Me.FOTOPictureBox.Location = New System.Drawing.Point(125, 159)
        Me.FOTOPictureBox.Name = "FOTOPictureBox"
        Me.FOTOPictureBox.Size = New System.Drawing.Size(121, 83)
        Me.FOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FOTOPictureBox.TabIndex = 12
        Me.FOTOPictureBox.TabStop = False
        '
        'CATEGORIAComboBox
        '
        Me.CATEGORIAComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "CATEGORIA", True))
        Me.CATEGORIAComboBox.FormattingEnabled = True
        Me.CATEGORIAComboBox.Items.AddRange(New Object() {"Hatch (Hatchback)", "Sedan", "SUV", "Crossover", "Minivan", "Picape (Truck)", "Wagon", "Diesel", "Elétrico", "Híbrido", "Conversível", "Cupê (Coupe)", "Luxo"})
        Me.CATEGORIAComboBox.Location = New System.Drawing.Point(125, 248)
        Me.CATEGORIAComboBox.Name = "CATEGORIAComboBox"
        Me.CATEGORIAComboBox.Size = New System.Drawing.Size(121, 21)
        Me.CATEGORIAComboBox.TabIndex = 14
        '
        'MOTORTextBox
        '
        Me.MOTORTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "MOTOR", True))
        Me.MOTORTextBox.Location = New System.Drawing.Point(125, 275)
        Me.MOTORTextBox.Name = "MOTORTextBox"
        Me.MOTORTextBox.Size = New System.Drawing.Size(121, 20)
        Me.MOTORTextBox.TabIndex = 16
        '
        'OPCIONAISTextBox
        '
        Me.OPCIONAISTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "OPCIONAIS", True))
        Me.OPCIONAISTextBox.Location = New System.Drawing.Point(125, 301)
        Me.OPCIONAISTextBox.Name = "OPCIONAISTextBox"
        Me.OPCIONAISTextBox.Size = New System.Drawing.Size(121, 20)
        Me.OPCIONAISTextBox.TabIndex = 18
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(125, 327)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(121, 20)
        Me.OBSTextBox.TabIndex = 20
        '
        'DISPONIBILIDADETextBox
        '
        Me.DISPONIBILIDADETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CARROSBindingSource, "DISPONIBILIDADE", True))
        Me.DISPONIBILIDADETextBox.Enabled = False
        Me.DISPONIBILIDADETextBox.Location = New System.Drawing.Point(125, 353)
        Me.DISPONIBILIDADETextBox.Multiline = True
        Me.DISPONIBILIDADETextBox.Name = "DISPONIBILIDADETextBox"
        Me.DISPONIBILIDADETextBox.Size = New System.Drawing.Size(121, 20)
        Me.DISPONIBILIDADETextBox.TabIndex = 22
        '
        'FrmCarro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(310, 402)
        Me.Controls.Add(PLACALabel)
        Me.Controls.Add(Me.PLACAMaskedTextBox)
        Me.Controls.Add(MODELOLabel)
        Me.Controls.Add(Me.MODELOTextBox)
        Me.Controls.Add(FABRICANTELabel)
        Me.Controls.Add(Me.FABRICANTEComboBox)
        Me.Controls.Add(CORLabel)
        Me.Controls.Add(Me.CORTextBox)
        Me.Controls.Add(ANOLabel)
        Me.Controls.Add(Me.ANOTextBox)
        Me.Controls.Add(FOTOLabel)
        Me.Controls.Add(Me.FOTOPictureBox)
        Me.Controls.Add(CATEGORIALabel)
        Me.Controls.Add(Me.CATEGORIAComboBox)
        Me.Controls.Add(MOTORLabel)
        Me.Controls.Add(Me.MOTORTextBox)
        Me.Controls.Add(OPCIONAISLabel)
        Me.Controls.Add(Me.OPCIONAISTextBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(DISPONIBILIDADELabel)
        Me.Controls.Add(Me.DISPONIBILIDADETextBox)
        Me.Controls.Add(Me.CARROSBindingNavigator)
        Me.Name = "FrmCarro"
        Me.Text = "Cadastro de  Carro"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARROSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CARROSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CARROSBindingNavigator.ResumeLayout(False)
        Me.CARROSBindingNavigator.PerformLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents CARROSBindingSource As BindingSource
    Friend WithEvents CARROSTableAdapter As DataSet1TableAdapters.CARROSTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents CARROSBindingNavigator As BindingNavigator
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
    Friend WithEvents CARROSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PLACAMaskedTextBox As MaskedTextBox
    Friend WithEvents MODELOTextBox As TextBox
    Friend WithEvents FABRICANTEComboBox As ComboBox
    Friend WithEvents CORTextBox As TextBox
    Friend WithEvents ANOTextBox As TextBox
    Friend WithEvents FOTOPictureBox As PictureBox
    Friend WithEvents CATEGORIAComboBox As ComboBox
    Friend WithEvents MOTORTextBox As TextBox
    Friend WithEvents OPCIONAISTextBox As TextBox
    Friend WithEvents OBSTextBox As TextBox
    Friend WithEvents DISPONIBILIDADETextBox As TextBox
End Class
