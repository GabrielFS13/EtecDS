<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Dim CódigoLabel As System.Windows.Forms.Label
        Dim NomeLabel As System.Windows.Forms.Label
        Dim EnderecoLabel As System.Windows.Forms.Label
        Dim CEPLabel As System.Windows.Forms.Label
        Dim EstadoLabel As System.Windows.Forms.Label
        Dim SenhaLabel As System.Windows.Forms.Label
        Dim CPFLabel As System.Windows.Forms.Label
        Dim RGLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Me.CadastroBDDataSet = New CadastroPessoas.cadastroBDDataSet()
        Me.CadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadastroTableAdapter = New CadastroPessoas.cadastroBDDataSetTableAdapters.CadastroTableAdapter()
        Me.TableAdapterManager = New CadastroPessoas.cadastroBDDataSetTableAdapters.TableAdapterManager()
        Me.CadastroBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.CadastroBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.CadastroDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CódigoTextBox = New System.Windows.Forms.TextBox()
        Me.NomeTextBox = New System.Windows.Forms.TextBox()
        Me.EnderecoTextBox = New System.Windows.Forms.TextBox()
        Me.CEPTextBox = New System.Windows.Forms.TextBox()
        Me.EstadoTextBox = New System.Windows.Forms.TextBox()
        Me.SenhaTextBox = New System.Windows.Forms.TextBox()
        Me.CPFTextBox = New System.Windows.Forms.TextBox()
        Me.RGTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CódigoLabel = New System.Windows.Forms.Label()
        NomeLabel = New System.Windows.Forms.Label()
        EnderecoLabel = New System.Windows.Forms.Label()
        CEPLabel = New System.Windows.Forms.Label()
        EstadoLabel = New System.Windows.Forms.Label()
        SenhaLabel = New System.Windows.Forms.Label()
        CPFLabel = New System.Windows.Forms.Label()
        RGLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        CType(Me.CadastroBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CadastroBindingNavigator.SuspendLayout()
        CType(Me.CadastroDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CadastroBDDataSet
        '
        Me.CadastroBDDataSet.DataSetName = "cadastroBDDataSet"
        Me.CadastroBDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CadastroBindingSource
        '
        Me.CadastroBindingSource.DataMember = "Cadastro"
        Me.CadastroBindingSource.DataSource = Me.CadastroBDDataSet
        '
        'CadastroTableAdapter
        '
        Me.CadastroTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadastroTableAdapter = Me.CadastroTableAdapter
        Me.TableAdapterManager.UpdateOrder = CadastroPessoas.cadastroBDDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'CadastroBindingNavigator
        '
        Me.CadastroBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CadastroBindingNavigator.BindingSource = Me.CadastroBindingSource
        Me.CadastroBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CadastroBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CadastroBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CadastroBindingNavigatorSaveItem})
        Me.CadastroBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CadastroBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CadastroBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CadastroBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CadastroBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CadastroBindingNavigator.Name = "CadastroBindingNavigator"
        Me.CadastroBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CadastroBindingNavigator.Size = New System.Drawing.Size(973, 25)
        Me.CadastroBindingNavigator.TabIndex = 0
        Me.CadastroBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de itens"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Excluir"
        '
        'CadastroBindingNavigatorSaveItem
        '
        Me.CadastroBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CadastroBindingNavigatorSaveItem.Image = CType(resources.GetObject("CadastroBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CadastroBindingNavigatorSaveItem.Name = "CadastroBindingNavigatorSaveItem"
        Me.CadastroBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CadastroBindingNavigatorSaveItem.Text = "Salvar Dados"
        '
        'CadastroDataGridView
        '
        Me.CadastroDataGridView.AutoGenerateColumns = False
        Me.CadastroDataGridView.BackgroundColor = System.Drawing.Color.White
        Me.CadastroDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CadastroDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.CadastroDataGridView.DataSource = Me.CadastroBindingSource
        Me.CadastroDataGridView.Location = New System.Drawing.Point(7, 257)
        Me.CadastroDataGridView.Name = "CadastroDataGridView"
        Me.CadastroDataGridView.Size = New System.Drawing.Size(946, 220)
        Me.CadastroDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Código"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Código"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nome"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nome"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Endereco"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Endereco"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "CEP"
        Me.DataGridViewTextBoxColumn4.HeaderText = "CEP"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Estado"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Estado"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Senha"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Senha"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "CPF"
        Me.DataGridViewTextBoxColumn7.HeaderText = "CPF"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "RG"
        Me.DataGridViewTextBoxColumn8.HeaderText = "RG"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "E-mail"
        Me.DataGridViewTextBoxColumn9.HeaderText = "E-mail"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'CódigoLabel
        '
        CódigoLabel.AutoSize = True
        CódigoLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CódigoLabel.Location = New System.Drawing.Point(2, 69)
        CódigoLabel.Name = "CódigoLabel"
        CódigoLabel.Size = New System.Drawing.Size(79, 25)
        CódigoLabel.TabIndex = 2
        CódigoLabel.Text = "Código:"
        '
        'CódigoTextBox
        '
        Me.CódigoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Código", True))
        Me.CódigoTextBox.Location = New System.Drawing.Point(88, 69)
        Me.CódigoTextBox.Name = "CódigoTextBox"
        Me.CódigoTextBox.Size = New System.Drawing.Size(144, 20)
        Me.CódigoTextBox.TabIndex = 3
        '
        'NomeLabel
        '
        NomeLabel.AutoSize = True
        NomeLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        NomeLabel.Location = New System.Drawing.Point(2, 105)
        NomeLabel.Name = "NomeLabel"
        NomeLabel.Size = New System.Drawing.Size(66, 25)
        NomeLabel.TabIndex = 4
        NomeLabel.Text = "Nome:"
        '
        'NomeTextBox
        '
        Me.NomeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Nome", True))
        Me.NomeTextBox.Location = New System.Drawing.Point(88, 110)
        Me.NomeTextBox.Name = "NomeTextBox"
        Me.NomeTextBox.Size = New System.Drawing.Size(144, 20)
        Me.NomeTextBox.TabIndex = 5
        '
        'EnderecoLabel
        '
        EnderecoLabel.AutoSize = True
        EnderecoLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EnderecoLabel.Location = New System.Drawing.Point(648, 75)
        EnderecoLabel.Name = "EnderecoLabel"
        EnderecoLabel.Size = New System.Drawing.Size(99, 25)
        EnderecoLabel.TabIndex = 6
        EnderecoLabel.Text = "Endereco:"
        '
        'EnderecoTextBox
        '
        Me.EnderecoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Endereco", True))
        Me.EnderecoTextBox.Location = New System.Drawing.Point(777, 84)
        Me.EnderecoTextBox.Name = "EnderecoTextBox"
        Me.EnderecoTextBox.Size = New System.Drawing.Size(149, 20)
        Me.EnderecoTextBox.TabIndex = 7
        '
        'CEPLabel
        '
        CEPLabel.AutoSize = True
        CEPLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CEPLabel.Location = New System.Drawing.Point(678, 109)
        CEPLabel.Name = "CEPLabel"
        CEPLabel.Size = New System.Drawing.Size(52, 25)
        CEPLabel.TabIndex = 8
        CEPLabel.Text = "CEP:"
        '
        'CEPTextBox
        '
        Me.CEPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "CEP", True))
        Me.CEPTextBox.Location = New System.Drawing.Point(777, 115)
        Me.CEPTextBox.Name = "CEPTextBox"
        Me.CEPTextBox.Size = New System.Drawing.Size(149, 20)
        Me.CEPTextBox.TabIndex = 9
        '
        'EstadoLabel
        '
        EstadoLabel.AutoSize = True
        EstadoLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EstadoLabel.Location = New System.Drawing.Point(669, 143)
        EstadoLabel.Name = "EstadoLabel"
        EstadoLabel.Size = New System.Drawing.Size(77, 25)
        EstadoLabel.TabIndex = 10
        EstadoLabel.Text = "Estado:"
        '
        'EstadoTextBox
        '
        Me.EstadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Estado", True))
        Me.EstadoTextBox.Location = New System.Drawing.Point(777, 149)
        Me.EstadoTextBox.Name = "EstadoTextBox"
        Me.EstadoTextBox.Size = New System.Drawing.Size(149, 20)
        Me.EstadoTextBox.TabIndex = 11
        '
        'SenhaLabel
        '
        SenhaLabel.AutoSize = True
        SenhaLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        SenhaLabel.Location = New System.Drawing.Point(3, 177)
        SenhaLabel.Name = "SenhaLabel"
        SenhaLabel.Size = New System.Drawing.Size(71, 25)
        SenhaLabel.TabIndex = 12
        SenhaLabel.Text = "Senha:"
        '
        'SenhaTextBox
        '
        Me.SenhaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "Senha", True))
        Me.SenhaTextBox.Location = New System.Drawing.Point(88, 186)
        Me.SenhaTextBox.Name = "SenhaTextBox"
        Me.SenhaTextBox.Size = New System.Drawing.Size(144, 20)
        Me.SenhaTextBox.TabIndex = 13
        '
        'CPFLabel
        '
        CPFLabel.AutoSize = True
        CPFLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CPFLabel.Location = New System.Drawing.Point(682, 177)
        CPFLabel.Name = "CPFLabel"
        CPFLabel.Size = New System.Drawing.Size(52, 25)
        CPFLabel.TabIndex = 14
        CPFLabel.Text = "CPF:"
        '
        'CPFTextBox
        '
        Me.CPFTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "CPF", True))
        Me.CPFTextBox.Location = New System.Drawing.Point(777, 182)
        Me.CPFTextBox.Name = "CPFTextBox"
        Me.CPFTextBox.Size = New System.Drawing.Size(149, 20)
        Me.CPFTextBox.TabIndex = 15
        '
        'RGLabel
        '
        RGLabel.AutoSize = True
        RGLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        RGLabel.Location = New System.Drawing.Point(691, 211)
        RGLabel.Name = "RGLabel"
        RGLabel.Size = New System.Drawing.Size(43, 25)
        RGLabel.TabIndex = 16
        RGLabel.Text = "RG:"
        '
        'RGTextBox
        '
        Me.RGTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "RG", True))
        Me.RGTextBox.Location = New System.Drawing.Point(777, 214)
        Me.RGTextBox.Name = "RGTextBox"
        Me.RGTextBox.Size = New System.Drawing.Size(149, 20)
        Me.RGTextBox.TabIndex = 17
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        E_mailLabel.Location = New System.Drawing.Point(3, 139)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(70, 25)
        E_mailLabel.TabIndex = 18
        E_mailLabel.Text = "E-mail:"
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadastroBindingSource, "E-mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(88, 145)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(144, 20)
        Me.E_mailTextBox.TabIndex = 19
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(46, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 25)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Informações de conta"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(627, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(200, 25)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Informações pessoais"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(973, 497)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(E_mailLabel)
        Me.Controls.Add(Me.E_mailTextBox)
        Me.Controls.Add(RGLabel)
        Me.Controls.Add(Me.RGTextBox)
        Me.Controls.Add(CPFLabel)
        Me.Controls.Add(Me.CPFTextBox)
        Me.Controls.Add(SenhaLabel)
        Me.Controls.Add(Me.SenhaTextBox)
        Me.Controls.Add(EstadoLabel)
        Me.Controls.Add(Me.EstadoTextBox)
        Me.Controls.Add(CEPLabel)
        Me.Controls.Add(Me.CEPTextBox)
        Me.Controls.Add(EnderecoLabel)
        Me.Controls.Add(Me.EnderecoTextBox)
        Me.Controls.Add(NomeLabel)
        Me.Controls.Add(Me.NomeTextBox)
        Me.Controls.Add(CódigoLabel)
        Me.Controls.Add(Me.CódigoTextBox)
        Me.Controls.Add(Me.CadastroDataGridView)
        Me.Controls.Add(Me.CadastroBindingNavigator)
        Me.Name = "Form1"
        Me.Text = "Cadastro Pessoas DataSource"
        CType(Me.CadastroBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CadastroBindingNavigator.ResumeLayout(False)
        Me.CadastroBindingNavigator.PerformLayout()
        CType(Me.CadastroDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CadastroBDDataSet As cadastroBDDataSet
    Friend WithEvents CadastroBindingSource As BindingSource
    Friend WithEvents CadastroTableAdapter As cadastroBDDataSetTableAdapters.CadastroTableAdapter
    Friend WithEvents TableAdapterManager As cadastroBDDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CadastroBindingNavigator As BindingNavigator
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
    Friend WithEvents CadastroBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents CadastroDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents CódigoTextBox As TextBox
    Friend WithEvents NomeTextBox As TextBox
    Friend WithEvents EnderecoTextBox As TextBox
    Friend WithEvents CEPTextBox As TextBox
    Friend WithEvents EstadoTextBox As TextBox
    Friend WithEvents SenhaTextBox As TextBox
    Friend WithEvents CPFTextBox As TextBox
    Friend WithEvents RGTextBox As TextBox
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
