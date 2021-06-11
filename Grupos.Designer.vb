<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Grupos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Grupos))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtcodgrup = New System.Windows.Forms.TextBox()
        Me.DTfechaini = New System.Windows.Forms.DateTimePicker()
        Me.DTfechafin = New System.Windows.Forms.DateTimePicker()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DGgrupos = New System.Windows.Forms.DataGridView()
        Me.Codigo_grupo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_anim = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Codigo_dieta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_ini = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha_final = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.obs = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.rtxtobs = New System.Windows.Forms.RichTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtnumanimales = New System.Windows.Forms.TextBox()
        Me.txtcodigodieta = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.bteliminar = New System.Windows.Forms.Button()
        Me.btagregar = New System.Windows.Forms.Button()
        Me.btnatras = New System.Windows.Forms.Button()
        Me.btnedi = New System.Windows.Forms.Button()
        CType(Me.DGgrupos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(33, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Codigo de grupo"
        '
        'txtcodgrup
        '
        Me.txtcodgrup.Location = New System.Drawing.Point(203, 54)
        Me.txtcodgrup.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcodgrup.Name = "txtcodgrup"
        Me.txtcodgrup.Size = New System.Drawing.Size(100, 27)
        Me.txtcodgrup.TabIndex = 1
        '
        'DTfechaini
        '
        Me.DTfechaini.Location = New System.Drawing.Point(217, 226)
        Me.DTfechaini.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTfechaini.Name = "DTfechaini"
        Me.DTfechaini.Size = New System.Drawing.Size(200, 27)
        Me.DTfechaini.TabIndex = 2
        '
        'DTfechafin
        '
        Me.DTfechafin.Location = New System.Drawing.Point(217, 291)
        Me.DTfechafin.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DTfechafin.Name = "DTfechafin"
        Me.DTfechafin.Size = New System.Drawing.Size(200, 27)
        Me.DTfechafin.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(171, 20)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Fecha inicial de engorde"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 291)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(163, 20)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Fecha Final de engorde"
        '
        'DGgrupos
        '
        Me.DGgrupos.AllowUserToAddRows = False
        Me.DGgrupos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGgrupos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo_grupo, Me.Numero_anim, Me.Codigo_dieta, Me.Fecha_ini, Me.Fecha_final, Me.obs})
        Me.DGgrupos.Location = New System.Drawing.Point(449, 58)
        Me.DGgrupos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.DGgrupos.Name = "DGgrupos"
        Me.DGgrupos.RowHeadersWidth = 51
        Me.DGgrupos.RowTemplate.Height = 24
        Me.DGgrupos.Size = New System.Drawing.Size(870, 421)
        Me.DGgrupos.TabIndex = 6
        '
        'Codigo_grupo
        '
        Me.Codigo_grupo.HeaderText = "Codigo Grupo"
        Me.Codigo_grupo.MinimumWidth = 6
        Me.Codigo_grupo.Name = "Codigo_grupo"
        Me.Codigo_grupo.Width = 125
        '
        'Numero_anim
        '
        Me.Numero_anim.HeaderText = "Numero de animales"
        Me.Numero_anim.MinimumWidth = 6
        Me.Numero_anim.Name = "Numero_anim"
        Me.Numero_anim.Width = 125
        '
        'Codigo_dieta
        '
        Me.Codigo_dieta.HeaderText = "Codigo Dieta"
        Me.Codigo_dieta.MinimumWidth = 6
        Me.Codigo_dieta.Name = "Codigo_dieta"
        Me.Codigo_dieta.Width = 125
        '
        'Fecha_ini
        '
        Me.Fecha_ini.HeaderText = "Fecha inicial"
        Me.Fecha_ini.MinimumWidth = 6
        Me.Fecha_ini.Name = "Fecha_ini"
        Me.Fecha_ini.Width = 125
        '
        'Fecha_final
        '
        Me.Fecha_final.HeaderText = "Fecha final"
        Me.Fecha_final.MinimumWidth = 6
        Me.Fecha_final.Name = "Fecha_final"
        Me.Fecha_final.Width = 125
        '
        'obs
        '
        Me.obs.HeaderText = "Observaciones"
        Me.obs.MinimumWidth = 6
        Me.obs.Name = "obs"
        Me.obs.Width = 125
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(46, 370)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 20)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Observaciones"
        '
        'rtxtobs
        '
        Me.rtxtobs.Location = New System.Drawing.Point(179, 366)
        Me.rtxtobs.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.rtxtobs.Name = "rtxtobs"
        Me.rtxtobs.Size = New System.Drawing.Size(200, 224)
        Me.rtxtobs.TabIndex = 8
        Me.rtxtobs.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(33, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(151, 20)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Numero  de animales"
        '
        'txtnumanimales
        '
        Me.txtnumanimales.Location = New System.Drawing.Point(203, 96)
        Me.txtnumanimales.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtnumanimales.Name = "txtnumanimales"
        Me.txtnumanimales.Size = New System.Drawing.Size(100, 27)
        Me.txtnumanimales.TabIndex = 10
        '
        'txtcodigodieta
        '
        Me.txtcodigodieta.Location = New System.Drawing.Point(203, 145)
        Me.txtcodigodieta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtcodigodieta.Name = "txtcodigodieta"
        Me.txtcodigodieta.Size = New System.Drawing.Size(100, 27)
        Me.txtcodigodieta.TabIndex = 12
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(33, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 20)
        Me.Label6.TabIndex = 11
        Me.Label6.Text = "Codigo Dieta"
        '
        'bteliminar
        '
        Me.bteliminar.Location = New System.Drawing.Point(667, 560)
        Me.bteliminar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bteliminar.Name = "bteliminar"
        Me.bteliminar.Size = New System.Drawing.Size(113, 70)
        Me.bteliminar.TabIndex = 26
        Me.bteliminar.Text = "Eliminar"
        Me.bteliminar.UseVisualStyleBackColor = True
        '
        'btagregar
        '
        Me.btagregar.Location = New System.Drawing.Point(512, 560)
        Me.btagregar.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btagregar.Name = "btagregar"
        Me.btagregar.Size = New System.Drawing.Size(113, 70)
        Me.btagregar.TabIndex = 25
        Me.btagregar.Text = "Agregar "
        Me.btagregar.UseVisualStyleBackColor = True
        '
        'btnatras
        '
        Me.btnatras.BackColor = System.Drawing.SystemColors.Control
        Me.btnatras.Image = CType(resources.GetObject("btnatras.Image"), System.Drawing.Image)
        Me.btnatras.Location = New System.Drawing.Point(983, 560)
        Me.btnatras.Name = "btnatras"
        Me.btnatras.Size = New System.Drawing.Size(108, 70)
        Me.btnatras.TabIndex = 27
        Me.btnatras.UseVisualStyleBackColor = False
        '
        'btnedi
        '
        Me.btnedi.Location = New System.Drawing.Point(824, 560)
        Me.btnedi.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnedi.Name = "btnedi"
        Me.btnedi.Size = New System.Drawing.Size(113, 70)
        Me.btnedi.TabIndex = 28
        Me.btnedi.Text = "Editar"
        Me.btnedi.UseVisualStyleBackColor = True
        '
        'Grupos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1356, 725)
        Me.Controls.Add(Me.btnedi)
        Me.Controls.Add(Me.btnatras)
        Me.Controls.Add(Me.bteliminar)
        Me.Controls.Add(Me.btagregar)
        Me.Controls.Add(Me.txtcodigodieta)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtnumanimales)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.rtxtobs)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DGgrupos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DTfechafin)
        Me.Controls.Add(Me.DTfechaini)
        Me.Controls.Add(Me.txtcodgrup)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Grupos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Grupos"
        CType(Me.DGgrupos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtcodgrup As TextBox
    Friend WithEvents DTfechaini As DateTimePicker
    Friend WithEvents DTfechafin As DateTimePicker
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DGgrupos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents rtxtobs As RichTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtnumanimales As TextBox
    Friend WithEvents txtcodigodieta As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Codigo_grupo As DataGridViewTextBoxColumn
    Friend WithEvents Numero_anim As DataGridViewTextBoxColumn
    Friend WithEvents Codigo_dieta As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_ini As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_final As DataGridViewTextBoxColumn
    Friend WithEvents obs As DataGridViewTextBoxColumn
    Friend WithEvents bteliminar As Button
    Friend WithEvents btagregar As Button
    Friend WithEvents btnatras As Button
    Friend WithEvents btnedi As Button
End Class
