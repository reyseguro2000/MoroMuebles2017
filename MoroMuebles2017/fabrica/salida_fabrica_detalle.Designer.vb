<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salida_fabrica_detalle
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
        Me.lbl_clave_provedor = New System.Windows.Forms.Label()
        Me.lbl_salida = New System.Windows.Forms.Label()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.lbl_idx = New System.Windows.Forms.Label()
        Me.lbl_clave_articulo = New System.Windows.Forms.Label()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.lbl_provedor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_detalle = New System.Windows.Forms.TextBox()
        Me.bt_modificar = New System.Windows.Forms.Button()
        Me.btn_baja = New System.Windows.Forms.Button()
        Me.btn_regreso = New System.Windows.Forms.Button()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(153, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROVEDOR"
        '
        'lbl_clave_provedor
        '
        Me.lbl_clave_provedor.AutoSize = True
        Me.lbl_clave_provedor.Location = New System.Drawing.Point(227, 19)
        Me.lbl_clave_provedor.Name = "lbl_clave_provedor"
        Me.lbl_clave_provedor.Size = New System.Drawing.Size(33, 13)
        Me.lbl_clave_provedor.TabIndex = 1
        Me.lbl_clave_provedor.Text = "id pro"
        '
        'lbl_salida
        '
        Me.lbl_salida.AutoSize = True
        Me.lbl_salida.Location = New System.Drawing.Point(12, 42)
        Me.lbl_salida.Name = "lbl_salida"
        Me.lbl_salida.Size = New System.Drawing.Size(26, 13)
        Me.lbl_salida.TabIndex = 2
        Me.lbl_salida.Text = "folio"
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AllowUserToDeleteRows = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Location = New System.Drawing.Point(15, 58)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.ReadOnly = True
        Me.dg_articulos.Size = New System.Drawing.Size(357, 150)
        Me.dg_articulos.TabIndex = 3
        '
        'lbl_idx
        '
        Me.lbl_idx.AutoSize = True
        Me.lbl_idx.Location = New System.Drawing.Point(12, 213)
        Me.lbl_idx.Name = "lbl_idx"
        Me.lbl_idx.Size = New System.Drawing.Size(15, 13)
        Me.lbl_idx.TabIndex = 4
        Me.lbl_idx.Text = "id"
        '
        'lbl_clave_articulo
        '
        Me.lbl_clave_articulo.AutoSize = True
        Me.lbl_clave_articulo.Location = New System.Drawing.Point(72, 213)
        Me.lbl_clave_articulo.Name = "lbl_clave_articulo"
        Me.lbl_clave_articulo.Size = New System.Drawing.Size(21, 13)
        Me.lbl_clave_articulo.TabIndex = 5
        Me.lbl_clave_articulo.Text = "cla"
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(117, 213)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_articulo.TabIndex = 6
        Me.lbl_articulo.Text = "articulo"
        '
        'lbl_provedor
        '
        Me.lbl_provedor.AutoSize = True
        Me.lbl_provedor.Location = New System.Drawing.Point(266, 19)
        Me.lbl_provedor.Name = "lbl_provedor"
        Me.lbl_provedor.Size = New System.Drawing.Size(49, 13)
        Me.lbl_provedor.TabIndex = 7
        Me.lbl_provedor.Text = "provedor"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 248)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "DETALLE"
        '
        'txt_detalle
        '
        Me.txt_detalle.Location = New System.Drawing.Point(75, 241)
        Me.txt_detalle.MaxLength = 20
        Me.txt_detalle.Name = "txt_detalle"
        Me.txt_detalle.Size = New System.Drawing.Size(153, 20)
        Me.txt_detalle.TabIndex = 9
        '
        'bt_modificar
        '
        Me.bt_modificar.Location = New System.Drawing.Point(234, 239)
        Me.bt_modificar.Name = "bt_modificar"
        Me.bt_modificar.Size = New System.Drawing.Size(75, 23)
        Me.bt_modificar.TabIndex = 10
        Me.bt_modificar.Text = "MODIFICAR"
        Me.bt_modificar.UseVisualStyleBackColor = True
        '
        'btn_baja
        '
        Me.btn_baja.Enabled = False
        Me.btn_baja.Location = New System.Drawing.Point(75, 276)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(75, 23)
        Me.btn_baja.TabIndex = 11
        Me.btn_baja.Text = "BAJA"
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'btn_regreso
        '
        Me.btn_regreso.Enabled = False
        Me.btn_regreso.Location = New System.Drawing.Point(156, 276)
        Me.btn_regreso.Name = "btn_regreso"
        Me.btn_regreso.Size = New System.Drawing.Size(75, 23)
        Me.btn_regreso.TabIndex = 12
        Me.btn_regreso.Text = "REGRESO"
        Me.btn_regreso.UseVisualStyleBackColor = True
        '
        'salida_fabrica_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.btn_regreso)
        Me.Controls.Add(Me.btn_baja)
        Me.Controls.Add(Me.bt_modificar)
        Me.Controls.Add(Me.txt_detalle)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_provedor)
        Me.Controls.Add(Me.lbl_articulo)
        Me.Controls.Add(Me.lbl_clave_articulo)
        Me.Controls.Add(Me.lbl_idx)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.lbl_salida)
        Me.Controls.Add(Me.lbl_clave_provedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "salida_fabrica_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "salida_fabrica_detalle"
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_clave_provedor As Label
    Friend WithEvents lbl_salida As Label
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents lbl_idx As Label
    Friend WithEvents lbl_clave_articulo As Label
    Friend WithEvents lbl_articulo As Label
    Friend WithEvents lbl_provedor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_detalle As TextBox
    Friend WithEvents bt_modificar As Button
    Friend WithEvents btn_baja As Button
    Friend WithEvents btn_regreso As Button
End Class
