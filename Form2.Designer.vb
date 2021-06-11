<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtusuario = New System.Windows.Forms.TextBox()
        Me.txtcontra = New System.Windows.Forms.TextBox()
        Me.dtgcrear = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.txttipo = New System.Windows.Forms.TextBox()
        Me.txtcod = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.dtgcrear, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 70)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(59, 197)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Tipo:"
        '
        'txtusuario
        '
        Me.txtusuario.Location = New System.Drawing.Point(111, 70)
        Me.txtusuario.Name = "txtusuario"
        Me.txtusuario.Size = New System.Drawing.Size(125, 27)
        Me.txtusuario.TabIndex = 3
        '
        'txtcontra
        '
        Me.txtcontra.Location = New System.Drawing.Point(111, 129)
        Me.txtcontra.Name = "txtcontra"
        Me.txtcontra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtcontra.Size = New System.Drawing.Size(125, 27)
        Me.txtcontra.TabIndex = 4
        '
        'dtgcrear
        '
        Me.dtgcrear.AllowUserToAddRows = False
        Me.dtgcrear.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgcrear.Location = New System.Drawing.Point(272, 32)
        Me.dtgcrear.Name = "dtgcrear"
        Me.dtgcrear.RowHeadersWidth = 51
        Me.dtgcrear.RowTemplate.Height = 29
        Me.dtgcrear.Size = New System.Drawing.Size(501, 168)
        Me.dtgcrear.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(252, 235)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(94, 29)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Guardar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(390, 235)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 29)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Modificar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(521, 235)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(94, 29)
        Me.Button3.TabIndex = 9
        Me.Button3.Text = "Eliminar"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(654, 235)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(94, 29)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "salir"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'txttipo
        '
        Me.txttipo.Location = New System.Drawing.Point(111, 194)
        Me.txttipo.Name = "txttipo"
        Me.txttipo.Size = New System.Drawing.Size(125, 27)
        Me.txttipo.TabIndex = 11
        '
        'txtcod
        '
        Me.txtcod.Location = New System.Drawing.Point(111, 23)
        Me.txtcod.Name = "txtcod"
        Me.txtcod.Size = New System.Drawing.Size(125, 27)
        Me.txtcod.TabIndex = 13
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(36, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 20)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Codigo:"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(800, 289)
        Me.Controls.Add(Me.txtcod)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txttipo)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtgcrear)
        Me.Controls.Add(Me.txtcontra)
        Me.Controls.Add(Me.txtusuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.dtgcrear, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtusuario As TextBox
    Friend WithEvents txtcontra As TextBox
    Friend WithEvents dtgcrear As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents txttipo As TextBox
    Friend WithEvents txtcod As TextBox
    Friend WithEvents Label4 As Label
End Class
