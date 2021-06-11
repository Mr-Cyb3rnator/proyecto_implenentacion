<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VentaGanado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(VentaGanado))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtcodventa = New System.Windows.Forms.TextBox()
        Me.txtcodcliente = New System.Windows.Forms.TextBox()
        Me.txtlibras_totales = New System.Windows.Forms.TextBox()
        Me.txtcodgrupo = New System.Windows.Forms.TextBox()
        Me.txt_preciolibra = New System.Windows.Forms.TextBox()
        Me.dgventaganado = New System.Windows.Forms.DataGridView()
        Me.btcargar_grupo = New System.Windows.Forms.Button()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.dtpfecha = New System.Windows.Forms.DateTimePicker()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.txttotalventa = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        CType(Me.dgventaganado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo Venta:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(158, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Libras del Grupo:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(22, 260)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Precio Por Libra:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(22, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Codigo Cliente: "
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 184)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Codigo Grupo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 340)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Fecha:"
        '
        'txtcodventa
        '
        Me.txtcodventa.Location = New System.Drawing.Point(183, 81)
        Me.txtcodventa.Name = "txtcodventa"
        Me.txtcodventa.Size = New System.Drawing.Size(89, 27)
        Me.txtcodventa.TabIndex = 6
        '
        'txtcodcliente
        '
        Me.txtcodcliente.Location = New System.Drawing.Point(183, 135)
        Me.txtcodcliente.Name = "txtcodcliente"
        Me.txtcodcliente.Size = New System.Drawing.Size(89, 27)
        Me.txtcodcliente.TabIndex = 7
        '
        'txtlibras_totales
        '
        Me.txtlibras_totales.Location = New System.Drawing.Point(186, 217)
        Me.txtlibras_totales.Name = "txtlibras_totales"
        Me.txtlibras_totales.Size = New System.Drawing.Size(89, 27)
        Me.txtlibras_totales.TabIndex = 8
        '
        'txtcodgrupo
        '
        Me.txtcodgrupo.Location = New System.Drawing.Point(183, 181)
        Me.txtcodgrupo.Name = "txtcodgrupo"
        Me.txtcodgrupo.Size = New System.Drawing.Size(89, 27)
        Me.txtcodgrupo.TabIndex = 9
        '
        'txt_preciolibra
        '
        Me.txt_preciolibra.Location = New System.Drawing.Point(186, 260)
        Me.txt_preciolibra.Name = "txt_preciolibra"
        Me.txt_preciolibra.Size = New System.Drawing.Size(89, 27)
        Me.txt_preciolibra.TabIndex = 10
        '
        'dgventaganado
        '
        Me.dgventaganado.AllowUserToAddRows = False
        Me.dgventaganado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventaganado.Location = New System.Drawing.Point(303, 84)
        Me.dgventaganado.Name = "dgventaganado"
        Me.dgventaganado.RowHeadersWidth = 51
        Me.dgventaganado.RowTemplate.Height = 28
        Me.dgventaganado.Size = New System.Drawing.Size(803, 180)
        Me.dgventaganado.TabIndex = 19
        '
        'btcargar_grupo
        '
        Me.btcargar_grupo.Location = New System.Drawing.Point(549, 301)
        Me.btcargar_grupo.Name = "btcargar_grupo"
        Me.btcargar_grupo.Size = New System.Drawing.Size(108, 62)
        Me.btcargar_grupo.TabIndex = 22
        Me.btcargar_grupo.Text = "Cagar Grupo"
        Me.btcargar_grupo.UseVisualStyleBackColor = True
        '
        'btnguardar
        '
        Me.btnguardar.Location = New System.Drawing.Point(375, 299)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(111, 62)
        Me.btnguardar.TabIndex = 21
        Me.btnguardar.Text = "Guardar"
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'dtpfecha
        '
        Me.dtpfecha.Location = New System.Drawing.Point(125, 335)
        Me.dtpfecha.Name = "dtpfecha"
        Me.dtpfecha.Size = New System.Drawing.Size(178, 27)
        Me.dtpfecha.TabIndex = 24
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(1004, 365)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(102, 53)
        Me.btnatras.TabIndex = 25
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'txttotalventa
        '
        Me.txttotalventa.Location = New System.Drawing.Point(186, 299)
        Me.txttotalventa.Name = "txttotalventa"
        Me.txttotalventa.Size = New System.Drawing.Size(89, 27)
        Me.txttotalventa.TabIndex = 27
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(22, 299)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(82, 20)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Total venta"
        '
        'VentaGanado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1118, 430)
        Me.Controls.Add(Me.txttotalventa)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.dtpfecha)
        Me.Controls.Add(Me.btcargar_grupo)
        Me.Controls.Add(Me.btnguardar)
        Me.Controls.Add(Me.dgventaganado)
        Me.Controls.Add(Me.txt_preciolibra)
        Me.Controls.Add(Me.txtcodgrupo)
        Me.Controls.Add(Me.txtlibras_totales)
        Me.Controls.Add(Me.txtcodcliente)
        Me.Controls.Add(Me.txtcodventa)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "VentaGanado"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "VentaGanado"
        CType(Me.dgventaganado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtcodventa As TextBox
    Friend WithEvents txtcodcliente As TextBox
    Friend WithEvents txtlibras_totales As TextBox
    Friend WithEvents txtcodgrupo As TextBox
    Friend WithEvents txt_preciolibra As TextBox
    Friend WithEvents dgventaganado As DataGridView
    Friend WithEvents btcargar_grupo As Button
    Friend WithEvents btnguardar As Button
    Friend WithEvents dtpfecha As DateTimePicker
    Friend WithEvents btnatras As Button
    Friend WithEvents txttotalventa As TextBox
    Friend WithEvents Label8 As Label
End Class
