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
        Me.TXT_nota1 = New System.Windows.Forms.TextBox()
        Me.TXT_NOTA4 = New System.Windows.Forms.TextBox()
        Me.txt_NOTA3 = New System.Windows.Forms.TextBox()
        Me.TXT_NOTA2 = New System.Windows.Forms.TextBox()
        Me.BTN_OK = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(166, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nota 1:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(166, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nota 3:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(166, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 25)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nota 2:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(166, 249)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(69, 25)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nota 4:"
        '
        'TXT_nota1
        '
        Me.TXT_nota1.Location = New System.Drawing.Point(259, 125)
        Me.TXT_nota1.Name = "TXT_nota1"
        Me.TXT_nota1.Size = New System.Drawing.Size(100, 20)
        Me.TXT_nota1.TabIndex = 4
        '
        'TXT_NOTA4
        '
        Me.TXT_NOTA4.Location = New System.Drawing.Point(259, 248)
        Me.TXT_NOTA4.Name = "TXT_NOTA4"
        Me.TXT_NOTA4.Size = New System.Drawing.Size(100, 20)
        Me.TXT_NOTA4.TabIndex = 5
        '
        'txt_NOTA3
        '
        Me.txt_NOTA3.Location = New System.Drawing.Point(259, 207)
        Me.txt_NOTA3.Name = "txt_NOTA3"
        Me.txt_NOTA3.Size = New System.Drawing.Size(100, 20)
        Me.txt_NOTA3.TabIndex = 6
        '
        'TXT_NOTA2
        '
        Me.TXT_NOTA2.Location = New System.Drawing.Point(259, 166)
        Me.TXT_NOTA2.Name = "TXT_NOTA2"
        Me.TXT_NOTA2.Size = New System.Drawing.Size(100, 20)
        Me.TXT_NOTA2.TabIndex = 7
        '
        'BTN_OK
        '
        Me.BTN_OK.BackColor = System.Drawing.Color.White
        Me.BTN_OK.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_OK.Location = New System.Drawing.Point(241, 308)
        Me.BTN_OK.Name = "BTN_OK"
        Me.BTN_OK.Size = New System.Drawing.Size(68, 41)
        Me.BTN_OK.TabIndex = 8
        Me.BTN_OK.Text = "Ok"
        Me.BTN_OK.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(229, 365)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 36)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Limpar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.RoyalBlue
        Me.ClientSize = New System.Drawing.Size(548, 477)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.BTN_OK)
        Me.Controls.Add(Me.TXT_NOTA2)
        Me.Controls.Add(Me.txt_NOTA3)
        Me.Controls.Add(Me.TXT_NOTA4)
        Me.Controls.Add(Me.TXT_nota1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Sistema de notas"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TXT_nota1 As TextBox
    Friend WithEvents TXT_NOTA4 As TextBox
    Friend WithEvents txt_NOTA3 As TextBox
    Friend WithEvents TXT_NOTA2 As TextBox
    Friend WithEvents BTN_OK As Button
    Friend WithEvents Button1 As Button
End Class
