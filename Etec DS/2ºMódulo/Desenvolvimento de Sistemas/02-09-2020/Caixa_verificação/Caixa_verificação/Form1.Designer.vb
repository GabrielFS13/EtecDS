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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TXT_nome = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.chkAlterar = New System.Windows.Forms.CheckBox()
        Me.chkConsultar = New System.Windows.Forms.CheckBox()
        Me.chkExcluir = New System.Windows.Forms.CheckBox()
        Me.chkIncluir = New System.Windows.Forms.CheckBox()
        Me.rbFemenino = New System.Windows.Forms.RadioButton()
        Me.rbMasculino = New System.Windows.Forms.RadioButton()
        Me.lblPermissoes = New System.Windows.Forms.Label()
        Me.lblSexo = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(135, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Incluir novo usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(49, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Permissões"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(266, 195)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 16)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Sexo"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(40, 102)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(91, 16)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nome do Usuário"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(58, 343)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(40, 13)
        Me.lblStatus.TabIndex = 4
        Me.lblStatus.Text = "Status:"
        '
        'TXT_nome
        '
        Me.TXT_nome.Location = New System.Drawing.Point(43, 121)
        Me.TXT_nome.Name = "TXT_nome"
        Me.TXT_nome.Size = New System.Drawing.Size(140, 20)
        Me.TXT_nome.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(203, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Incluir"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(269, 415)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Fechar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'chkAlterar
        '
        Me.chkAlterar.AutoSize = True
        Me.chkAlterar.Location = New System.Drawing.Point(43, 220)
        Me.chkAlterar.Name = "chkAlterar"
        Me.chkAlterar.Size = New System.Drawing.Size(56, 17)
        Me.chkAlterar.TabIndex = 8
        Me.chkAlterar.Text = "Alterar"
        Me.chkAlterar.UseVisualStyleBackColor = True
        '
        'chkConsultar
        '
        Me.chkConsultar.AutoSize = True
        Me.chkConsultar.Location = New System.Drawing.Point(43, 243)
        Me.chkConsultar.Name = "chkConsultar"
        Me.chkConsultar.Size = New System.Drawing.Size(70, 17)
        Me.chkConsultar.TabIndex = 9
        Me.chkConsultar.Text = "Consultar"
        Me.chkConsultar.UseVisualStyleBackColor = True
        '
        'chkExcluir
        '
        Me.chkExcluir.AutoSize = True
        Me.chkExcluir.Location = New System.Drawing.Point(43, 266)
        Me.chkExcluir.Name = "chkExcluir"
        Me.chkExcluir.Size = New System.Drawing.Size(57, 17)
        Me.chkExcluir.TabIndex = 10
        Me.chkExcluir.Text = "Excluir"
        Me.chkExcluir.UseVisualStyleBackColor = True
        '
        'chkIncluir
        '
        Me.chkIncluir.AutoSize = True
        Me.chkIncluir.Location = New System.Drawing.Point(43, 289)
        Me.chkIncluir.Name = "chkIncluir"
        Me.chkIncluir.Size = New System.Drawing.Size(54, 17)
        Me.chkIncluir.TabIndex = 11
        Me.chkIncluir.Text = "Incluir"
        Me.chkIncluir.UseVisualStyleBackColor = True
        '
        'rbFemenino
        '
        Me.rbFemenino.AutoSize = True
        Me.rbFemenino.Location = New System.Drawing.Point(229, 220)
        Me.rbFemenino.Name = "rbFemenino"
        Me.rbFemenino.Size = New System.Drawing.Size(67, 17)
        Me.rbFemenino.TabIndex = 12
        Me.rbFemenino.TabStop = True
        Me.rbFemenino.Text = "Feminino"
        Me.rbFemenino.UseVisualStyleBackColor = True
        '
        'rbMasculino
        '
        Me.rbMasculino.AutoSize = True
        Me.rbMasculino.Location = New System.Drawing.Point(229, 243)
        Me.rbMasculino.Name = "rbMasculino"
        Me.rbMasculino.Size = New System.Drawing.Size(73, 17)
        Me.rbMasculino.TabIndex = 13
        Me.rbMasculino.TabStop = True
        Me.rbMasculino.Text = "Masculino"
        Me.rbMasculino.UseVisualStyleBackColor = True
        '
        'lblPermissoes
        '
        Me.lblPermissoes.AutoSize = True
        Me.lblPermissoes.Location = New System.Drawing.Point(58, 366)
        Me.lblPermissoes.Name = "lblPermissoes"
        Me.lblPermissoes.Size = New System.Drawing.Size(63, 13)
        Me.lblPermissoes.TabIndex = 14
        Me.lblPermissoes.Text = "Permissões:"
        '
        'lblSexo
        '
        Me.lblSexo.AutoSize = True
        Me.lblSexo.Location = New System.Drawing.Point(58, 390)
        Me.lblSexo.Name = "lblSexo"
        Me.lblSexo.Size = New System.Drawing.Size(34, 13)
        Me.lblSexo.TabIndex = 15
        Me.lblSexo.Text = "Sexo:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(369, 450)
        Me.Controls.Add(Me.lblSexo)
        Me.Controls.Add(Me.lblPermissoes)
        Me.Controls.Add(Me.rbMasculino)
        Me.Controls.Add(Me.rbFemenino)
        Me.Controls.Add(Me.chkIncluir)
        Me.Controls.Add(Me.chkExcluir)
        Me.Controls.Add(Me.chkConsultar)
        Me.Controls.Add(Me.chkAlterar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TXT_nome)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Incluir usuario"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents TXT_nome As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents chkAlterar As CheckBox
    Friend WithEvents chkConsultar As CheckBox
    Friend WithEvents chkExcluir As CheckBox
    Friend WithEvents chkIncluir As CheckBox
    Friend WithEvents rbFemenino As RadioButton
    Friend WithEvents rbMasculino As RadioButton
    Friend WithEvents lblPermissoes As Label
    Friend WithEvents lblSexo As Label
End Class
