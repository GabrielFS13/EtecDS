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
        Me.lblstatus = New System.Windows.Forms.Label()
        Me.cblpermissoes = New System.Windows.Forms.CheckedListBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TXT_NOME = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(61, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Alterar Usuário"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nome do usuário"
        '
        'lblstatus
        '
        Me.lblstatus.AutoSize = True
        Me.lblstatus.Location = New System.Drawing.Point(62, 284)
        Me.lblstatus.Name = "lblstatus"
        Me.lblstatus.Size = New System.Drawing.Size(40, 13)
        Me.lblstatus.TabIndex = 2
        Me.lblstatus.Text = "Status:"
        '
        'cblpermissoes
        '
        Me.cblpermissoes.FormattingEnabled = True
        Me.cblpermissoes.Items.AddRange(New Object() {"Alterar", "Consultar", "Excluir", "Incluir"})
        Me.cblpermissoes.Location = New System.Drawing.Point(65, 141)
        Me.cblpermissoes.Name = "cblpermissoes"
        Me.cblpermissoes.Size = New System.Drawing.Size(120, 94)
        Me.cblpermissoes.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(297, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Alterar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TXT_NOME
        '
        Me.TXT_NOME.Location = New System.Drawing.Point(65, 115)
        Me.TXT_NOME.Name = "TXT_NOME"
        Me.TXT_NOME.Size = New System.Drawing.Size(120, 20)
        Me.TXT_NOME.TabIndex = 5
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Location = New System.Drawing.Point(63, 256)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(46, 13)
        Me.lblUser.TabIndex = 6
        Me.lblUser.Text = "Usuario:"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(389, 364)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.TXT_NOME)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cblpermissoes)
        Me.Controls.Add(Me.lblstatus)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Alterar usuário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblstatus As Label
    Friend WithEvents cblpermissoes As CheckedListBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TXT_NOME As TextBox
    Friend WithEvents lblUser As Label
End Class
