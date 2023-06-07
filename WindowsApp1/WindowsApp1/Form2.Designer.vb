<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmFuncionario
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
        Dim CPFLabel As System.Windows.Forms.Label
        Dim NOMELabel As System.Windows.Forms.Label
        Dim CELULARLabel As System.Windows.Forms.Label
        Dim ENDERECOLabel As System.Windows.Forms.Label
        Dim FOTOLabel As System.Windows.Forms.Label
        Dim OBSLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmFuncionario))
        Me.DataSet1 = New WindowsApp1.DataSet1()
        Me.FUNCIONARIOSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FUNCIONARIOSTableAdapter = New WindowsApp1.DataSet1TableAdapters.FUNCIONARIOSTableAdapter()
        Me.TableAdapterManager = New WindowsApp1.DataSet1TableAdapters.TableAdapterManager()
        Me.FUNCIONARIOSBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.FUNCIONARIOSBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CPFMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.NOMETextBox = New System.Windows.Forms.TextBox()
        Me.CELULARMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ENDERECOTextBox = New System.Windows.Forms.TextBox()
        Me.FOTOPictureBox = New System.Windows.Forms.PictureBox()
        Me.OBSTextBox = New System.Windows.Forms.TextBox()
        CPFLabel = New System.Windows.Forms.Label()
        NOMELabel = New System.Windows.Forms.Label()
        CELULARLabel = New System.Windows.Forms.Label()
        ENDERECOLabel = New System.Windows.Forms.Label()
        FOTOLabel = New System.Windows.Forms.Label()
        OBSLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FUNCIONARIOSBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FUNCIONARIOSBindingNavigator.SuspendLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Location = New System.Drawing.Point(21, 31)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(30, 13)
        CPFLabel.TabIndex = 1
        CPFLabel.Text = "CPF:"
        '
        'NOMELabel
        '
        NOMELabel.AutoSize = True
        NOMELabel.Location = New System.Drawing.Point(21, 57)
        NOMELabel.Name = "NOMELabel"
        NOMELabel.Size = New System.Drawing.Size(42, 13)
        NOMELabel.TabIndex = 3
        NOMELabel.Text = "NOME:"
        '
        'CELULARLabel
        '
        CELULARLabel.AutoSize = True
        CELULARLabel.Location = New System.Drawing.Point(21, 83)
        CELULARLabel.Name = "CELULARLabel"
        CELULARLabel.Size = New System.Drawing.Size(59, 13)
        CELULARLabel.TabIndex = 5
        CELULARLabel.Text = "CELULAR:"
        '
        'ENDERECOLabel
        '
        ENDERECOLabel.AutoSize = True
        ENDERECOLabel.Location = New System.Drawing.Point(21, 109)
        ENDERECOLabel.Name = "ENDERECOLabel"
        ENDERECOLabel.Size = New System.Drawing.Size(70, 13)
        ENDERECOLabel.TabIndex = 7
        ENDERECOLabel.Text = "ENDERECO:"
        '
        'FOTOLabel
        '
        FOTOLabel.AutoSize = True
        FOTOLabel.Location = New System.Drawing.Point(21, 132)
        FOTOLabel.Name = "FOTOLabel"
        FOTOLabel.Size = New System.Drawing.Size(39, 13)
        FOTOLabel.TabIndex = 9
        FOTOLabel.Text = "FOTO:"
        '
        'OBSLabel
        '
        OBSLabel.AutoSize = True
        OBSLabel.Location = New System.Drawing.Point(21, 234)
        OBSLabel.Name = "OBSLabel"
        OBSLabel.Size = New System.Drawing.Size(32, 13)
        OBSLabel.TabIndex = 11
        OBSLabel.Text = "OBS:"
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FUNCIONARIOSBindingSource
        '
        Me.FUNCIONARIOSBindingSource.DataMember = "FUNCIONARIOS"
        Me.FUNCIONARIOSBindingSource.DataSource = Me.DataSet1
        '
        'FUNCIONARIOSTableAdapter
        '
        Me.FUNCIONARIOSTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.ALUGUELTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CARROSTableAdapter = Nothing
        Me.TableAdapterManager.CLIENTESTableAdapter = Nothing
        Me.TableAdapterManager.FUNCIONARIOSTableAdapter = Me.FUNCIONARIOSTableAdapter
        Me.TableAdapterManager.UpdateOrder = WindowsApp1.DataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'FUNCIONARIOSBindingNavigator
        '
        Me.FUNCIONARIOSBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.FUNCIONARIOSBindingNavigator.BindingSource = Me.FUNCIONARIOSBindingSource
        Me.FUNCIONARIOSBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.FUNCIONARIOSBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.FUNCIONARIOSBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.FUNCIONARIOSBindingNavigatorSaveItem})
        Me.FUNCIONARIOSBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.FUNCIONARIOSBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.FUNCIONARIOSBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.FUNCIONARIOSBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.FUNCIONARIOSBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.FUNCIONARIOSBindingNavigator.Name = "FUNCIONARIOSBindingNavigator"
        Me.FUNCIONARIOSBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.FUNCIONARIOSBindingNavigator.Size = New System.Drawing.Size(297, 25)
        Me.FUNCIONARIOSBindingNavigator.TabIndex = 0
        Me.FUNCIONARIOSBindingNavigator.Text = "BindingNavigator1"
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
        'FUNCIONARIOSBindingNavigatorSaveItem
        '
        Me.FUNCIONARIOSBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.FUNCIONARIOSBindingNavigatorSaveItem.Image = CType(resources.GetObject("FUNCIONARIOSBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.FUNCIONARIOSBindingNavigatorSaveItem.Name = "FUNCIONARIOSBindingNavigatorSaveItem"
        Me.FUNCIONARIOSBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.FUNCIONARIOSBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CPFMaskedTextBox
        '
        Me.CPFMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FUNCIONARIOSBindingSource, "CPF", True))
        Me.CPFMaskedTextBox.Location = New System.Drawing.Point(97, 28)
        Me.CPFMaskedTextBox.Mask = "000.000.000-00"
        Me.CPFMaskedTextBox.Name = "CPFMaskedTextBox"
        Me.CPFMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CPFMaskedTextBox.TabIndex = 2
        '
        'NOMETextBox
        '
        Me.NOMETextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FUNCIONARIOSBindingSource, "NOME", True))
        Me.NOMETextBox.Location = New System.Drawing.Point(97, 54)
        Me.NOMETextBox.Name = "NOMETextBox"
        Me.NOMETextBox.Size = New System.Drawing.Size(100, 20)
        Me.NOMETextBox.TabIndex = 4
        '
        'CELULARMaskedTextBox
        '
        Me.CELULARMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FUNCIONARIOSBindingSource, "CELULAR", True))
        Me.CELULARMaskedTextBox.Location = New System.Drawing.Point(97, 80)
        Me.CELULARMaskedTextBox.Mask = "(00) 00000-0000"
        Me.CELULARMaskedTextBox.Name = "CELULARMaskedTextBox"
        Me.CELULARMaskedTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CELULARMaskedTextBox.TabIndex = 6
        '
        'ENDERECOTextBox
        '
        Me.ENDERECOTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FUNCIONARIOSBindingSource, "ENDERECO", True))
        Me.ENDERECOTextBox.Location = New System.Drawing.Point(97, 106)
        Me.ENDERECOTextBox.Name = "ENDERECOTextBox"
        Me.ENDERECOTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ENDERECOTextBox.TabIndex = 8
        '
        'FOTOPictureBox
        '
        Me.FOTOPictureBox.DataBindings.Add(New System.Windows.Forms.Binding("Image", Me.FUNCIONARIOSBindingSource, "FOTO", True))
        Me.FOTOPictureBox.Location = New System.Drawing.Point(97, 132)
        Me.FOTOPictureBox.Name = "FOTOPictureBox"
        Me.FOTOPictureBox.Size = New System.Drawing.Size(100, 93)
        Me.FOTOPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.FOTOPictureBox.TabIndex = 10
        Me.FOTOPictureBox.TabStop = False
        '
        'OBSTextBox
        '
        Me.OBSTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.FUNCIONARIOSBindingSource, "OBS", True))
        Me.OBSTextBox.Location = New System.Drawing.Point(97, 231)
        Me.OBSTextBox.Multiline = True
        Me.OBSTextBox.Name = "OBSTextBox"
        Me.OBSTextBox.Size = New System.Drawing.Size(100, 99)
        Me.OBSTextBox.TabIndex = 12
        '
        'FrmFuncionario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(297, 346)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFMaskedTextBox)
        Me.Controls.Add(NOMELabel)
        Me.Controls.Add(Me.NOMETextBox)
        Me.Controls.Add(CELULARLabel)
        Me.Controls.Add(Me.CELULARMaskedTextBox)
        Me.Controls.Add(ENDERECOLabel)
        Me.Controls.Add(Me.ENDERECOTextBox)
        Me.Controls.Add(FOTOLabel)
        Me.Controls.Add(Me.FOTOPictureBox)
        Me.Controls.Add(OBSLabel)
        Me.Controls.Add(Me.OBSTextBox)
        Me.Controls.Add(Me.FUNCIONARIOSBindingNavigator)
        Me.Name = "FrmFuncionario"
        Me.Text = "Cadastro de  Funcionário"
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUNCIONARIOSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FUNCIONARIOSBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FUNCIONARIOSBindingNavigator.ResumeLayout(False)
        Me.FUNCIONARIOSBindingNavigator.PerformLayout()
        CType(Me.FOTOPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents FUNCIONARIOSBindingSource As BindingSource
    Friend WithEvents FUNCIONARIOSTableAdapter As DataSet1TableAdapters.FUNCIONARIOSTableAdapter
    Friend WithEvents TableAdapterManager As DataSet1TableAdapters.TableAdapterManager
    Friend WithEvents FUNCIONARIOSBindingNavigator As BindingNavigator
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
    Friend WithEvents FUNCIONARIOSBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CPFMaskedTextBox As MaskedTextBox
    Friend WithEvents NOMETextBox As TextBox
    Friend WithEvents CELULARMaskedTextBox As MaskedTextBox
    Friend WithEvents ENDERECOTextBox As TextBox
    Friend WithEvents FOTOPictureBox As PictureBox
    Friend WithEvents OBSTextBox As TextBox
End Class
