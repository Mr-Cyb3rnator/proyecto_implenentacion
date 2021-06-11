<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Dieta
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dieta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.TextBox()
        Me.txtcomidaxdia = New System.Windows.Forms.TextBox()
        Me.txtcoddieta = New System.Windows.Forms.TextBox()
        Me.dgdieta = New System.Windows.Forms.DataGridView()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btneliminar = New System.Windows.Forms.Button()
        Me.txtcodingre = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.dgingredientes_dieta = New System.Windows.Forms.DataGridView()
        Me.btselecionar_dierta = New System.Windows.Forms.Button()
        CType(Me.dgdieta, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgingredientes_dieta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(68, 85)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Dieta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(36, 166)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cantidad en libras:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(48, 209)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Comidas por dia:"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(166, 163)
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(89, 27)
        Me.txtcantidad.TabIndex = 3
        '
        'txtcomidaxdia
        '
        Me.txtcomidaxdia.Location = New System.Drawing.Point(166, 206)
        Me.txtcomidaxdia.Name = "txtcomidaxdia"
        Me.txtcomidaxdia.Size = New System.Drawing.Size(89, 27)
        Me.txtcomidaxdia.TabIndex = 4
        '
        'txtcoddieta
        '
        Me.txtcoddieta.Location = New System.Drawing.Point(166, 81)
        Me.txtcoddieta.Name = "txtcoddieta"
        Me.txtcoddieta.Size = New System.Drawing.Size(89, 27)
        Me.txtcoddieta.TabIndex = 5
        '
        'dgdieta
        '
        Me.dgdieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdieta.Location = New System.Drawing.Point(278, 81)
        Me.dgdieta.Name = "dgdieta"
        Me.dgdieta.RowHeadersWidth = 51
        Me.dgdieta.RowTemplate.Height = 28
        Me.dgdieta.Size = New System.Drawing.Size(413, 345)
        Me.dgdieta.TabIndex = 9
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(52, 289)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(92, 40)
        Me.btnguardar.TabIndex = 10
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btneliminar
        '
        Me.btneliminar.Location = New System.Drawing.Point(166, 289)
        Me.btneliminar.Name = "btneliminar"
        Me.btneliminar.Size = New System.Drawing.Size(80, 40)
        Me.btneliminar.TabIndex = 11
        Me.btneliminar.Text = "Eliminar"
        Me.btneliminar.UseVisualStyleBackColor = True
        '
        'txtcodingre
        '
        Me.txtcodingre.Location = New System.Drawing.Point(166, 122)
        Me.txtcodingre.Name = "txtcodingre"
        Me.txtcodingre.Size = New System.Drawing.Size(89, 27)
        Me.txtcodingre.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(29, 125)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(141, 20)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Codigo Ingrediente:"
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(985, 466)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(89, 45)
        Me.btnatras.TabIndex = 26
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btagregar
        '
        Me.btagregar.Location = New System.Drawing.Point(12, 361)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(234, 40)
        Me.btagregar.TabIndex = 27
        Me.btagregar.Text = "Agregar Ingrediente a  dieta"
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'dgingredientes_dieta
        '
        Me.dgingredientes_dieta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgingredientes_dieta.Location = New System.Drawing.Point(749, 81)
        Me.dgingredientes_dieta.Name = "dgingredientes_dieta"
        Me.dgingredientes_dieta.RowHeadersWidth = 51
        Me.dgingredientes_dieta.RowTemplate.Height = 29
        Me.dgingredientes_dieta.Size = New System.Drawing.Size(434, 345)
        Me.dgingredientes_dieta.TabIndex = 28
        '
        'btselecionar_dierta
        '
        Me.btselecionar_dierta.Location = New System.Drawing.Point(48, 407)
        Me.btselecionar_dierta.Name = "btselecionar_dierta"
        Me.btselecionar_dierta.Size = New System.Drawing.Size(156, 40)
        Me.btselecionar_dierta.TabIndex = 29
        Me.btselecionar_dierta.Text = "Seleccionar    dieta"
        Me.btselecionar_dierta.UseVisualStyleBackColor = True
        '
        'Dieta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1265, 523)
        Me.Controls.Add(Me.btselecionar_dierta)
        Me.Controls.Add(Me.dgingredientes_dieta)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.txtcodingre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btneliminar)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgdieta)
        Me.Controls.Add(Me.txtcoddieta)
        Me.Controls.Add(Me.txtcomidaxdia)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Dieta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DIETA"
        CType(Me.dgdieta, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgingredientes_dieta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtcantidad As TextBox
    Friend WithEvents txtcomidaxdia As TextBox
    Friend WithEvents txtcoddieta As TextBox
    Friend WithEvents dgdieta As DataGridView
    Friend WithEvents btnguardar As Button
    Friend WithEvents btneliminar As Button
    Friend WithEvents txtcodingre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnatras As Button
    Friend WithEvents btagregar As Button
    Friend WithEvents dgingredientes_dieta As DataGridView
    Friend WithEvents btselecionar_dierta As Button
End Class
