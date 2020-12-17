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
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.lbCargo = New System.Windows.Forms.ListBox()
        Me.lblCargo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblCargo1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'cbCargo
        '
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Items.AddRange(New Object() {"Analista de Sistema", "DBA", "Programador", "Web Designer", "Suporte Técnico", "Estagiário"})
        Me.cbCargo.Location = New System.Drawing.Point(56, 47)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(121, 21)
        Me.cbCargo.TabIndex = 0
        '
        'lbCargo
        '
        Me.lbCargo.FormattingEnabled = True
        Me.lbCargo.Items.AddRange(New Object() {"Analista de sistema", "DBA", "Programador", "Web Designer", "Suporte Técnico", "Estagiário"})
        Me.lbCargo.Location = New System.Drawing.Point(57, 149)
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(120, 95)
        Me.lbCargo.TabIndex = 1
        '
        'lblCargo
        '
        Me.lblCargo.AutoSize = True
        Me.lblCargo.Location = New System.Drawing.Point(54, 269)
        Me.lblCargo.Name = "lblCargo"
        Me.lblCargo.Size = New System.Drawing.Size(41, 13)
        Me.lblCargo.TabIndex = 2
        Me.lblCargo.Text = "Cargo: "
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 117)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Selecione o Cargo"
        '
        'lblCargo1
        '
        Me.lblCargo1.AutoSize = True
        Me.lblCargo1.Location = New System.Drawing.Point(59, 80)
        Me.lblCargo1.Name = "lblCargo1"
        Me.lblCargo1.Size = New System.Drawing.Size(41, 13)
        Me.lblCargo1.TabIndex = 4
        Me.lblCargo1.Text = "Cargo: "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(53, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(123, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Selecione o Cargo"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(229, 149)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Adicionar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(229, 180)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Excluir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(229, 211)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "Limpar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(329, 343)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblCargo1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lblCargo)
        Me.Controls.Add(Me.lbCargo)
        Me.Controls.Add(Me.cbCargo)
        Me.Name = "Form1"
        Me.Text = "Lista de cargos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents lbCargo As ListBox
    Friend WithEvents lblCargo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lblCargo1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
