<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnentrar = New System.Windows.Forms.Button()
        Me.btncrear = New System.Windows.Forms.Button()
        Me.btnsalir = New System.Windows.Forms.Button()
        Me.txtusu1 = New System.Windows.Forms.TextBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(49, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(38, 173)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'btnentrar
        '
        Me.btnentrar.BackColor = System.Drawing.SystemColors.Control
        Me.btnentrar.Location = New System.Drawing.Point(104, 211)
        Me.btnentrar.Name = "btnentrar"
        Me.btnentrar.Size = New System.Drawing.Size(94, 29)
        Me.btnentrar.TabIndex = 2
        Me.btnentrar.Text = "Entrar"
        Me.btnentrar.UseVisualStyleBackColor = False
        '
        'btncrear
        '
        Me.btncrear.BackColor = System.Drawing.SystemColors.Control
        Me.btncrear.Location = New System.Drawing.Point(247, 211)
        Me.btncrear.Name = "btncrear"
        Me.btncrear.Size = New System.Drawing.Size(94, 29)
        Me.btncrear.TabIndex = 3
        Me.btncrear.Text = "Crear"
        Me.btncrear.UseVisualStyleBackColor = False
        '
        'btnsalir
        '
        Me.btnsalir.BackColor = System.Drawing.SystemColors.Control
        Me.btnsalir.Location = New System.Drawing.Point(389, 211)
        Me.btnsalir.Name = "btnsalir"
        Me.btnsalir.Size = New System.Drawing.Size(94, 29)
        Me.btnsalir.TabIndex = 4
        Me.btnsalir.Text = "Salir"
        Me.btnsalir.UseVisualStyleBackColor = False
        '
        'txtusu1
        '
        Me.txtusu1.Location = New System.Drawing.Point(117, 66)
        Me.txtusu1.Name = "txtusu1"
        Me.txtusu1.Size = New System.Drawing.Size(125, 27)
        Me.txtusu1.TabIndex = 5
        '
        'txtpass
        '
        Me.txtpass.Location = New System.Drawing.Point(130, 166)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpass.Size = New System.Drawing.Size(125, 27)
        Me.txtpass.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.Location = New System.Drawing.Point(38, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(73, 54)
        Me.Button1.TabIndex = 7
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(38, 112)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(73, 54)
        Me.Button2.TabIndex = 8
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(550, 281)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpass)
        Me.Controls.Add(Me.txtusu1)
        Me.Controls.Add(Me.btnsalir)
        Me.Controls.Add(Me.btncrear)
        Me.Controls.Add(Me.btnentrar)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnentrar As Button
    Friend WithEvents btncrear As Button
    Friend WithEvents btnsalir As Button
    Friend WithEvents txtusu1 As TextBox
    Friend WithEvents txtpass As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
