<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingredientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingredientes))
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dgingredientes = New System.Windows.Forms.DataGridView()
        Me.txtcodingre = New System.Windows.Forms.TextBox()
        Me.txtcosto = New System.Windows.Forms.TextBox()
        Me.txtdescripingre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcoddieta = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.bteditar = New System.Windows.Forms.Button()
        CType(Me.dgingredientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(158, 234)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(80, 40)
        Me.btneliminar.TabIndex = 20
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(40, 234)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(92, 40)
        Me.btnguardar.TabIndex = 19
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'dgingredientes
        '
        Me.dgingredientes.AllowUserToAddRows = False
        Me.dgingredientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgingredientes.Location = New System.Drawing.Point(259, 61)
        Me.dgingredientes.Name = "dgingredientes"
        Me.dgingredientes.RowHeadersWidth = 51
        Me.dgingredientes.RowTemplate.Height = 28
        Me.dgingredientes.Size = New System.Drawing.Size(580, 213)
        Me.dgingredientes.TabIndex = 18
        '
        'txtcodingre
        '
        Me.txtcodingre.Location = New System.Drawing.Point(158, 61)
        Me.txtcodingre.Name = "txtcodingre"
        Me.txtcodingre.Size = New System.Drawing.Size(89, 27)
        Me.txtcodingre.TabIndex = 17
        '
        'txtcosto
        '
        Me.txtcosto.Location = New System.Drawing.Point(158, 191)
        Me.txtcosto.Name = "txtcosto"
        Me.txtcosto.Size = New System.Drawing.Size(89, 27)
        Me.txtcosto.TabIndex = 16
        '
        'txtdescripingre
        '
        Me.txtdescripingre.Location = New System.Drawing.Point(158, 105)
        Me.txtdescripingre.Name = "txtdescripingre"
        Me.txtdescripingre.Size = New System.Drawing.Size(89, 27)
        Me.txtdescripingre.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(97, 194)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 20)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Costo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(60, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Descripcion:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(14, 61)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 20)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Codigo Ingrediente:"
        '
        'txtcoddieta
        '
        Me.txtcoddieta.Location = New System.Drawing.Point(158, 148)
        Me.txtcoddieta.Name = "txtcoddieta"
        Me.txtcoddieta.Size = New System.Drawing.Size(89, 27)
        Me.txtcoddieta.TabIndex = 22
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 20)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Codigo Dieta:"
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(756, 297)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(108, 44)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'bteditar
        '
        Me.bteditar.Location = New System.Drawing.Point(40, 280)
        Me.bteditar.Name = "bteditar"
        Me.bteditar.Size = New System.Drawing.Size(92, 40)
        Me.bteditar.TabIndex = 27
        Me.bteditar.Text = "Editar"
        Me.bteditar.UseVisualStyleBackColor = True
        '
        'Ingredientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(876, 353)
        Me.Controls.Add(Me.bteditar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.txtcoddieta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgingredientes)
        Me.Controls.Add(Me.txtcodingre)
        Me.Controls.Add(Me.txtcosto)
        Me.Controls.Add(Me.txtdescripingre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Ingredientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingredientes"
        CType(Me.dgingredientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btneliminar As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents dgingredientes As DataGridView
    Friend WithEvents txtcodingre As TextBox
    Friend WithEvents txtcosto As TextBox
    Friend WithEvents txtdescripingre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtcoddieta As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnatras As Button
    Friend WithEvents bteditar As Button
End Class
