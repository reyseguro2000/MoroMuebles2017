<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalle_salida
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
        Me.lbl_salida = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_idx = New System.Windows.Forms.Label()
        Me.txt_detalle = New System.Windows.Forms.TextBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg_detalle = New System.Windows.Forms.DataGridView()
        Me.btn_regreso = New System.Windows.Forms.Button()
        Me.lbl_taller = New System.Windows.Forms.Label()
        Me.lbl_clave_taller = New System.Windows.Forms.Label()
        Me.btn_baja = New System.Windows.Forms.Button()
        Me.lbl_clave_articulo = New System.Windows.Forms.Label()
        CType(Me.dg_detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_salida
        '
        Me.lbl_salida.AutoSize = True
        Me.lbl_salida.Location = New System.Drawing.Point(66, 233)
        Me.lbl_salida.Name = "lbl_salida"
        Me.lbl_salida.Size = New System.Drawing.Size(50, 13)
        Me.lbl_salida.TabIndex = 40
        Me.lbl_salida.Text = "lbl_salida"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 232)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 39
        Me.Label2.Text = "SALIDA"
        '
        'lbl_idx
        '
        Me.lbl_idx.AutoSize = True
        Me.lbl_idx.Location = New System.Drawing.Point(83, 250)
        Me.lbl_idx.Name = "lbl_idx"
        Me.lbl_idx.Size = New System.Drawing.Size(15, 13)
        Me.lbl_idx.TabIndex = 38
        Me.lbl_idx.Text = "id"
        '
        'txt_detalle
        '
        Me.txt_detalle.AutoCompleteCustomSource.AddRange(New String() {"PENDIENTE", "REGRESO"})
        Me.txt_detalle.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txt_detalle.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txt_detalle.Location = New System.Drawing.Point(75, 277)
        Me.txt_detalle.MaxLength = 20
        Me.txt_detalle.Name = "txt_detalle"
        Me.txt_detalle.Size = New System.Drawing.Size(93, 20)
        Me.txt_detalle.TabIndex = 37
        '
        'btn_modificar
        '
        Me.btn_modificar.Enabled = False
        Me.btn_modificar.Location = New System.Drawing.Point(174, 275)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 23)
        Me.btn_modificar.TabIndex = 36
        Me.btn_modificar.Text = "CAMBIAR"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 280)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "DETALLE"
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(174, 250)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(19, 13)
        Me.lbl_articulo.TabIndex = 34
        Me.lbl_articulo.Text = "art"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 250)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ARTICULO"
        '
        'dg_detalle
        '
        Me.dg_detalle.AllowUserToAddRows = False
        Me.dg_detalle.AllowUserToDeleteRows = False
        Me.dg_detalle.AllowUserToOrderColumns = True
        Me.dg_detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_detalle.Location = New System.Drawing.Point(12, 38)
        Me.dg_detalle.Name = "dg_detalle"
        Me.dg_detalle.ReadOnly = True
        Me.dg_detalle.Size = New System.Drawing.Size(360, 191)
        Me.dg_detalle.TabIndex = 32
        '
        'btn_regreso
        '
        Me.btn_regreso.Enabled = False
        Me.btn_regreso.Location = New System.Drawing.Point(93, 327)
        Me.btn_regreso.Name = "btn_regreso"
        Me.btn_regreso.Size = New System.Drawing.Size(75, 23)
        Me.btn_regreso.TabIndex = 41
        Me.btn_regreso.Text = "REGRESAR"
        Me.btn_regreso.UseVisualStyleBackColor = True
        '
        'lbl_taller
        '
        Me.lbl_taller.AutoSize = True
        Me.lbl_taller.Location = New System.Drawing.Point(238, 10)
        Me.lbl_taller.Name = "lbl_taller"
        Me.lbl_taller.Size = New System.Drawing.Size(39, 13)
        Me.lbl_taller.TabIndex = 43
        Me.lbl_taller.Text = "Label3"
        '
        'lbl_clave_taller
        '
        Me.lbl_clave_taller.AutoSize = True
        Me.lbl_clave_taller.Location = New System.Drawing.Point(188, 9)
        Me.lbl_clave_taller.Name = "lbl_clave_taller"
        Me.lbl_clave_taller.Size = New System.Drawing.Size(48, 13)
        Me.lbl_clave_taller.TabIndex = 42
        Me.lbl_clave_taller.Text = "TALLER"
        '
        'btn_baja
        '
        Me.btn_baja.Enabled = False
        Me.btn_baja.Location = New System.Drawing.Point(12, 326)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(75, 23)
        Me.btn_baja.TabIndex = 44
        Me.btn_baja.Text = "BAJA"
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'lbl_clave_articulo
        '
        Me.lbl_clave_articulo.AutoSize = True
        Me.lbl_clave_articulo.Location = New System.Drawing.Point(129, 250)
        Me.lbl_clave_articulo.Name = "lbl_clave_articulo"
        Me.lbl_clave_articulo.Size = New System.Drawing.Size(33, 13)
        Me.lbl_clave_articulo.TabIndex = 45
        Me.lbl_clave_articulo.Text = "clave"
        '
        'detalle_salida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.lbl_clave_articulo)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.lbl_taller)
        Me.Controls.Add(Me.lbl_clave_taller)
        Me.Controls.Add(Me.btn_regreso)
        Me.Controls.Add(Me.lbl_salida)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_idx)
        Me.Controls.Add(Me.txt_detalle)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_articulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dg_detalle)
        Me.Name = "detalle_salida"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "detalle_salida"
        CType(Me.dg_detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_salida As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_idx As Label
    Friend WithEvents txt_detalle As TextBox
    Friend WithEvents btn_modificar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_articulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dg_detalle As DataGridView
    Friend WithEvents btn_regreso As Button
    Friend WithEvents lbl_taller As Label
    Friend WithEvents lbl_clave_taller As Label
    Friend WithEvents btn_baja As Button
    Friend WithEvents lbl_clave_articulo As Label
End Class
