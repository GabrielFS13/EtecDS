<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmListaClientes1
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.imgRecuperar = New System.Windows.Forms.PictureBox()
        Me.btnVisualizar = New System.Windows.Forms.Button()
        Me.dgvClientes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.imgRecuperar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cartoonist", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(25, 84)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(250, 20)
        Me.txtNome.TabIndex = 1
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'imgRecuperar
        '
        Me.imgRecuperar.Location = New System.Drawing.Point(525, 39)
        Me.imgRecuperar.Name = "imgRecuperar"
        Me.imgRecuperar.Size = New System.Drawing.Size(142, 118)
        Me.imgRecuperar.TabIndex = 3
        Me.imgRecuperar.TabStop = False
        '
        'btnVisualizar
        '
        Me.btnVisualizar.Font = New System.Drawing.Font("Cartoonist", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVisualizar.Location = New System.Drawing.Point(525, 185)
        Me.btnVisualizar.Name = "btnVisualizar"
        Me.btnVisualizar.Size = New System.Drawing.Size(142, 55)
        Me.btnVisualizar.TabIndex = 4
        Me.btnVisualizar.Text = "Visualizar Cliente"
        Me.btnVisualizar.UseVisualStyleBackColor = True
        '
        'dgvClientes
        '
        Me.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvClientes.Location = New System.Drawing.Point(3, 136)
        Me.dgvClientes.Name = "dgvClientes"
        Me.dgvClientes.Size = New System.Drawing.Size(454, 209)
        Me.dgvClientes.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cartoonist", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(463, 326)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 19)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Aluno: gabriel falcao"
        '
        'frmListaClientes1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(714, 357)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dgvClientes)
        Me.Controls.Add(Me.btnVisualizar)
        Me.Controls.Add(Me.imgRecuperar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmListaClientes1"
        Me.Text = "frmListaClientes1"
        CType(Me.imgRecuperar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents imgRecuperar As PictureBox
    Friend WithEvents btnVisualizar As Button
    Friend WithEvents dgvClientes As DataGridView
    Friend WithEvents Label2 As Label
End Class
