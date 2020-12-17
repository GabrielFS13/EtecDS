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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.btnGravar = New System.Windows.Forms.Button()
        Me.btnConsult = New System.Windows.Forms.Button()
        Me.btnLoad = New System.Windows.Forms.Button()
        Me.imgSalvar = New System.Windows.Forms.PictureBox()
        CType(Me.imgSalvar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cartoonist", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(49, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nome:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Cartoonist", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(50, 266)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(228, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Aluno: Gabriel Falcao"
        '
        'txtNome
        '
        Me.txtNome.Location = New System.Drawing.Point(53, 96)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(241, 20)
        Me.txtNome.TabIndex = 2
        '
        'btnGravar
        '
        Me.btnGravar.Font = New System.Drawing.Font("Cartoonist", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGravar.Location = New System.Drawing.Point(43, 136)
        Me.btnGravar.Name = "btnGravar"
        Me.btnGravar.Size = New System.Drawing.Size(128, 42)
        Me.btnGravar.TabIndex = 3
        Me.btnGravar.Text = "Gravar Cliente"
        Me.btnGravar.UseVisualStyleBackColor = True
        '
        'btnConsult
        '
        Me.btnConsult.Font = New System.Drawing.Font("Cartoonist", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConsult.Location = New System.Drawing.Point(177, 136)
        Me.btnConsult.Name = "btnConsult"
        Me.btnConsult.Size = New System.Drawing.Size(127, 42)
        Me.btnConsult.TabIndex = 4
        Me.btnConsult.Text = "Consultar Clientes"
        Me.btnConsult.UseVisualStyleBackColor = True
        '
        'btnLoad
        '
        Me.btnLoad.Font = New System.Drawing.Font("Cartoonist", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoad.Location = New System.Drawing.Point(379, 195)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(138, 29)
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Adicionar Fotos"
        Me.btnLoad.UseVisualStyleBackColor = True
        '
        'imgSalvar
        '
        Me.imgSalvar.Location = New System.Drawing.Point(379, 65)
        Me.imgSalvar.Name = "imgSalvar"
        Me.imgSalvar.Size = New System.Drawing.Size(138, 113)
        Me.imgSalvar.TabIndex = 6
        Me.imgSalvar.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(586, 335)
        Me.Controls.Add(Me.imgSalvar)
        Me.Controls.Add(Me.btnLoad)
        Me.Controls.Add(Me.btnConsult)
        Me.Controls.Add(Me.btnGravar)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Cadastro de Clientes"
        CType(Me.imgSalvar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents btnGravar As Button
    Friend WithEvents btnConsult As Button
    Friend WithEvents btnLoad As Button
    Friend WithEvents imgSalvar As PictureBox
End Class
