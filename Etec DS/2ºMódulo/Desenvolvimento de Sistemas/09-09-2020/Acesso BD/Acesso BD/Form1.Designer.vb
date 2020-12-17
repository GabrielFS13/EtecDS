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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CadastroBDDataSet = New Acesso_BD.cadastroBDDataSet()
        Me.CadastroBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CadastroTableAdapter = New Acesso_BD.cadastroBDDataSetTableAdapters.CadastroTableAdapter()
        Me.CódigoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CEPDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EstadoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroBDDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CódigoDataGridViewTextBoxColumn, Me.NomeDataGridViewTextBoxColumn, Me.EnderecoDataGridViewTextBoxColumn, Me.CEPDataGridViewTextBoxColumn, Me.EstadoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CadastroBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(77, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(545, 150)
        Me.DataGridView1.TabIndex = 0
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
        'CódigoDataGridViewTextBoxColumn
        '
        Me.CódigoDataGridViewTextBoxColumn.DataPropertyName = "Código"
        Me.CódigoDataGridViewTextBoxColumn.HeaderText = "Código"
        Me.CódigoDataGridViewTextBoxColumn.Name = "CódigoDataGridViewTextBoxColumn"
        '
        'NomeDataGridViewTextBoxColumn
        '
        Me.NomeDataGridViewTextBoxColumn.DataPropertyName = "Nome"
        Me.NomeDataGridViewTextBoxColumn.HeaderText = "Nome"
        Me.NomeDataGridViewTextBoxColumn.Name = "NomeDataGridViewTextBoxColumn"
        '
        'EnderecoDataGridViewTextBoxColumn
        '
        Me.EnderecoDataGridViewTextBoxColumn.DataPropertyName = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.HeaderText = "Endereco"
        Me.EnderecoDataGridViewTextBoxColumn.Name = "EnderecoDataGridViewTextBoxColumn"
        '
        'CEPDataGridViewTextBoxColumn
        '
        Me.CEPDataGridViewTextBoxColumn.DataPropertyName = "CEP"
        Me.CEPDataGridViewTextBoxColumn.HeaderText = "CEP"
        Me.CEPDataGridViewTextBoxColumn.Name = "CEPDataGridViewTextBoxColumn"
        '
        'EstadoDataGridViewTextBoxColumn
        '
        Me.EstadoDataGridViewTextBoxColumn.DataPropertyName = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.HeaderText = "Estado"
        Me.EstadoDataGridViewTextBoxColumn.Name = "EstadoDataGridViewTextBoxColumn"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Gabriel Falcão"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(735, 459)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "Sistema de  Acesso ao Banco de Dados"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroBDDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadastroBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents CadastroBDDataSet As cadastroBDDataSet
    Friend WithEvents CadastroBindingSource As BindingSource
    Friend WithEvents CadastroTableAdapter As cadastroBDDataSetTableAdapters.CadastroTableAdapter
    Friend WithEvents CódigoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NomeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CEPDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EstadoDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
End Class
