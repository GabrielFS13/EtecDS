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
        Me.btnAdicionar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.btnExcluir = New System.Windows.Forms.Button()
        Me.btnSalvar = New System.Windows.Forms.Button()
        Me.btnSair = New System.Windows.Forms.Button()
        Me.cmbFiltro = New System.Windows.Forms.ComboBox()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.TxtTelefones = New System.Windows.Forms.TextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtObervacao = New System.Windows.Forms.TextBox()
        Me.lv1 = New System.Windows.Forms.ListView()
        Me.Codigo = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Nome = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Telefones = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Email = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.SuspendLayout()
        '
        'btnAdicionar
        '
        Me.btnAdicionar.Location = New System.Drawing.Point(64, 85)
        Me.btnAdicionar.Name = "btnAdicionar"
        Me.btnAdicionar.Size = New System.Drawing.Size(75, 23)
        Me.btnAdicionar.TabIndex = 0
        Me.btnAdicionar.Text = "Adicionar"
        Me.btnAdicionar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(185, 85)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 1
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'btnExcluir
        '
        Me.btnExcluir.Location = New System.Drawing.Point(427, 85)
        Me.btnExcluir.Name = "btnExcluir"
        Me.btnExcluir.Size = New System.Drawing.Size(75, 23)
        Me.btnExcluir.TabIndex = 3
        Me.btnExcluir.Text = "Excluir"
        Me.btnExcluir.UseVisualStyleBackColor = True
        '
        'btnSalvar
        '
        Me.btnSalvar.Location = New System.Drawing.Point(306, 85)
        Me.btnSalvar.Name = "btnSalvar"
        Me.btnSalvar.Size = New System.Drawing.Size(75, 23)
        Me.btnSalvar.TabIndex = 2
        Me.btnSalvar.Text = "Salvar"
        Me.btnSalvar.UseVisualStyleBackColor = True
        '
        'btnSair
        '
        Me.btnSair.Location = New System.Drawing.Point(548, 85)
        Me.btnSair.Name = "btnSair"
        Me.btnSair.Size = New System.Drawing.Size(75, 23)
        Me.btnSair.TabIndex = 4
        Me.btnSair.Text = "Sair"
        Me.btnSair.UseVisualStyleBackColor = True
        '
        'cmbFiltro
        '
        Me.cmbFiltro.FormattingEnabled = True
        Me.cmbFiltro.Items.AddRange(New Object() {"Código", "Nome", "Telefones", "Email"})
        Me.cmbFiltro.Location = New System.Drawing.Point(64, 237)
        Me.cmbFiltro.Name = "cmbFiltro"
        Me.cmbFiltro.Size = New System.Drawing.Size(121, 21)
        Me.cmbFiltro.TabIndex = 5
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(321, 237)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(100, 20)
        Me.txtBuscar.TabIndex = 6
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(303, 379)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(40, 13)
        Me.lblCodigo.TabIndex = 7
        Me.lblCodigo.Text = "Codigo"
        Me.lblCodigo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(427, 349)
        Me.txtNome.MaxLength = 50
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(100, 20)
        Me.txtNome.TabIndex = 8
        '
        'TxtTelefones
        '
        Me.TxtTelefones.Location = New System.Drawing.Point(427, 428)
        Me.TxtTelefones.MaxLength = 30
        Me.TxtTelefones.Name = "TxtTelefones"
        Me.TxtTelefones.Size = New System.Drawing.Size(100, 20)
        Me.TxtTelefones.TabIndex = 9
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(602, 379)
        Me.txtEmail.MaxLength = 50
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(100, 20)
        Me.txtEmail.TabIndex = 10
        '
        'txtObervacao
        '
        Me.txtObervacao.Location = New System.Drawing.Point(602, 483)
        Me.txtObervacao.MaxLength = 50
        Me.txtObervacao.Multiline = True
        Me.txtObervacao.Name = "txtObervacao"
        Me.txtObervacao.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtObervacao.Size = New System.Drawing.Size(100, 20)
        Me.txtObervacao.TabIndex = 11
        '
        'lv1
        '
        Me.lv1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Codigo, Me.Nome, Me.Telefones, Me.Email})
        Me.lv1.FullRowSelect = True
        Me.lv1.GridLines = True
        Me.lv1.HideSelection = False
        Me.lv1.Location = New System.Drawing.Point(78, 399)
        Me.lv1.MultiSelect = False
        Me.lv1.Name = "lv1"
        Me.lv1.Size = New System.Drawing.Size(121, 97)
        Me.lv1.TabIndex = 12
        Me.lv1.UseCompatibleStateImageBehavior = False
        '
        'Codigo
        '
        Me.Codigo.Tag = "Codigo"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 611)
        Me.Controls.Add(Me.lv1)
        Me.Controls.Add(Me.txtObervacao)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.TxtTelefones)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.cmbFiltro)
        Me.Controls.Add(Me.btnSair)
        Me.Controls.Add(Me.btnExcluir)
        Me.Controls.Add(Me.btnSalvar)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAdicionar)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdicionar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents btnExcluir As Button
    Friend WithEvents btnSalvar As Button
    Friend WithEvents btnSair As Button
    Friend WithEvents cmbFiltro As ComboBox
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents lblCodigo As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents TxtTelefones As TextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtObervacao As TextBox
    Friend WithEvents lv1 As ListView
    Friend WithEvents Codigo As ColumnHeader
    Friend WithEvents Nome As ColumnHeader
    Friend WithEvents Telefones As ColumnHeader
    Friend WithEvents Email As ColumnHeader
End Class
