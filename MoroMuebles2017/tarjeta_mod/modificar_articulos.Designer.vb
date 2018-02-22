<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class modificar_articulos
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
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_venta = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cantidad_salida = New System.Windows.Forms.NumericUpDown()
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.txt_cantidad_entrada = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_clave_articulo = New System.Windows.Forms.Label()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.lbl_idx = New System.Windows.Forms.Label()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_saldo_act = New System.Windows.Forms.Label()
        Me.lbl_saldo_nuevo = New System.Windows.Forms.Label()
        Me.btn_cambio = New System.Windows.Forms.Button()
        Me.btn_parcial = New System.Windows.Forms.Button()
        Me.btn_garantia = New System.Windows.Forms.Button()
        Me.btn_servicio = New System.Windows.Forms.Button()
        Me.grp_salida = New System.Windows.Forms.GroupBox()
        Me.txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me.grp_entrada = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_precio_articulo = New System.Windows.Forms.Label()
        Me.btn_servicio_entrada = New System.Windows.Forms.Button()
        Me.btn_garantia_entrada = New System.Windows.Forms.Button()
        Me.btn_parcial_entrada = New System.Windows.Forms.Button()
        Me.btn_cambio_entrada = New System.Windows.Forms.Button()
        Me.grp_seleccion = New System.Windows.Forms.GroupBox()
        Me.grp_saldo = New System.Windows.Forms.GroupBox()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.txt_cantidad_salida, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_cantidad_entrada, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_salida.SuspendLayout()
        Me.grp_entrada.SuspendLayout()
        Me.grp_seleccion.SuspendLayout()
        Me.grp_saldo.SuspendLayout()
        Me.SuspendLayout()
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Location = New System.Drawing.Point(12, 22)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(33, 13)
        Me.lbl_clave.TabIndex = 0
        Me.lbl_clave.Text = "clave"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(57, 22)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(38, 13)
        Me.lbl_cliente.TabIndex = 1
        Me.lbl_cliente.Text = "cliente"
        '
        'lbl_venta
        '
        Me.lbl_venta.AutoSize = True
        Me.lbl_venta.Location = New System.Drawing.Point(11, 45)
        Me.lbl_venta.Name = "lbl_venta"
        Me.lbl_venta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_venta.TabIndex = 2
        Me.lbl_venta.Text = "venta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(123, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "ARTICULO"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(14, 25)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "CANTIDAD"
        '
        'txt_cantidad_salida
        '
        Me.txt_cantidad_salida.Location = New System.Drawing.Point(82, 18)
        Me.txt_cantidad_salida.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_cantidad_salida.Name = "txt_cantidad_salida"
        Me.txt_cantidad_salida.Size = New System.Drawing.Size(35, 20)
        Me.txt_cantidad_salida.TabIndex = 5
        Me.txt_cantidad_salida.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'cmb_articulo
        '
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(190, 17)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(203, 21)
        Me.cmb_articulo.TabIndex = 6
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(476, 15)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 7
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AllowUserToDeleteRows = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Location = New System.Drawing.Point(18, 19)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.ReadOnly = True
        Me.dg_articulos.Size = New System.Drawing.Size(533, 125)
        Me.dg_articulos.TabIndex = 8
        '
        'txt_cantidad_entrada
        '
        Me.txt_cantidad_entrada.Location = New System.Drawing.Point(107, 177)
        Me.txt_cantidad_entrada.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.txt_cantidad_entrada.Name = "txt_cantidad_entrada"
        Me.txt_cantidad_entrada.Size = New System.Drawing.Size(35, 20)
        Me.txt_cantidad_entrada.TabIndex = 11
        Me.txt_cantidad_entrada.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(39, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "CANTIDAD"
        '
        'lbl_clave_articulo
        '
        Me.lbl_clave_articulo.AutoSize = True
        Me.lbl_clave_articulo.Location = New System.Drawing.Point(151, 184)
        Me.lbl_clave_articulo.Name = "lbl_clave_articulo"
        Me.lbl_clave_articulo.Size = New System.Drawing.Size(61, 13)
        Me.lbl_clave_articulo.TabIndex = 9
        Me.lbl_clave_articulo.Text = "ARTICULO"
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(218, 184)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(61, 13)
        Me.lbl_articulo.TabIndex = 12
        Me.lbl_articulo.Text = "ARTICULO"
        '
        'lbl_idx
        '
        Me.lbl_idx.AutoSize = True
        Me.lbl_idx.Location = New System.Drawing.Point(16, 192)
        Me.lbl_idx.Name = "lbl_idx"
        Me.lbl_idx.Size = New System.Drawing.Size(15, 13)
        Me.lbl_idx.TabIndex = 13
        Me.lbl_idx.Text = "id"
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(217, 15)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(85, 23)
        Me.btn_modificar.TabIndex = 14
        Me.btn_modificar.Text = "CALCULAR"
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(10, 25)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 13)
        Me.Label10.TabIndex = 15
        Me.Label10.Text = "SALDO ACTUAL"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(365, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(84, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "NUEVO SALDO"
        '
        'lbl_saldo_act
        '
        Me.lbl_saldo_act.AutoSize = True
        Me.lbl_saldo_act.Location = New System.Drawing.Point(115, 25)
        Me.lbl_saldo_act.Name = "lbl_saldo_act"
        Me.lbl_saldo_act.Size = New System.Drawing.Size(37, 13)
        Me.lbl_saldo_act.TabIndex = 17
        Me.lbl_saldo_act.Text = "00000"
        '
        'lbl_saldo_nuevo
        '
        Me.lbl_saldo_nuevo.AutoSize = True
        Me.lbl_saldo_nuevo.Location = New System.Drawing.Point(455, 25)
        Me.lbl_saldo_nuevo.Name = "lbl_saldo_nuevo"
        Me.lbl_saldo_nuevo.Size = New System.Drawing.Size(37, 13)
        Me.lbl_saldo_nuevo.TabIndex = 18
        Me.lbl_saldo_nuevo.Text = "00000"
        '
        'btn_cambio
        '
        Me.btn_cambio.Location = New System.Drawing.Point(23, 16)
        Me.btn_cambio.Name = "btn_cambio"
        Me.btn_cambio.Size = New System.Drawing.Size(75, 23)
        Me.btn_cambio.TabIndex = 19
        Me.btn_cambio.Text = "CAMBIO"
        Me.btn_cambio.UseVisualStyleBackColor = True
        '
        'btn_parcial
        '
        Me.btn_parcial.Location = New System.Drawing.Point(118, 16)
        Me.btn_parcial.Name = "btn_parcial"
        Me.btn_parcial.Size = New System.Drawing.Size(75, 23)
        Me.btn_parcial.TabIndex = 20
        Me.btn_parcial.Text = "R PARCIAL"
        Me.btn_parcial.UseVisualStyleBackColor = True
        '
        'btn_garantia
        '
        Me.btn_garantia.Location = New System.Drawing.Point(214, 16)
        Me.btn_garantia.Name = "btn_garantia"
        Me.btn_garantia.Size = New System.Drawing.Size(75, 23)
        Me.btn_garantia.TabIndex = 21
        Me.btn_garantia.Text = "GARANTIA"
        Me.btn_garantia.UseVisualStyleBackColor = True
        '
        'btn_servicio
        '
        Me.btn_servicio.Location = New System.Drawing.Point(307, 16)
        Me.btn_servicio.Name = "btn_servicio"
        Me.btn_servicio.Size = New System.Drawing.Size(75, 23)
        Me.btn_servicio.TabIndex = 22
        Me.btn_servicio.Text = "SERVICIO"
        Me.btn_servicio.UseVisualStyleBackColor = True
        '
        'grp_salida
        '
        Me.grp_salida.Controls.Add(Me.txt_precio)
        Me.grp_salida.Controls.Add(Me.Label5)
        Me.grp_salida.Controls.Add(Me.Label4)
        Me.grp_salida.Controls.Add(Me.txt_cantidad_salida)
        Me.grp_salida.Controls.Add(Me.cmb_articulo)
        Me.grp_salida.Controls.Add(Me.btn_agregar)
        Me.grp_salida.Location = New System.Drawing.Point(15, 129)
        Me.grp_salida.Name = "grp_salida"
        Me.grp_salida.Size = New System.Drawing.Size(557, 58)
        Me.grp_salida.TabIndex = 23
        Me.grp_salida.TabStop = False
        Me.grp_salida.Text = "SALIDA DE MERCANCIA"
        Me.grp_salida.Visible = False
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(399, 19)
        Me.txt_precio.Mask = "99999"
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(56, 20)
        Me.txt_precio.TabIndex = 8
        Me.txt_precio.ValidatingType = GetType(Integer)
        '
        'grp_entrada
        '
        Me.grp_entrada.Controls.Add(Me.Label2)
        Me.grp_entrada.Controls.Add(Me.txt_motivo)
        Me.grp_entrada.Controls.Add(Me.grp_saldo)
        Me.grp_entrada.Controls.Add(Me.Label1)
        Me.grp_entrada.Controls.Add(Me.lbl_precio_articulo)
        Me.grp_entrada.Controls.Add(Me.btn_servicio_entrada)
        Me.grp_entrada.Controls.Add(Me.btn_garantia_entrada)
        Me.grp_entrada.Controls.Add(Me.btn_parcial_entrada)
        Me.grp_entrada.Controls.Add(Me.btn_cambio_entrada)
        Me.grp_entrada.Controls.Add(Me.dg_articulos)
        Me.grp_entrada.Controls.Add(Me.lbl_clave_articulo)
        Me.grp_entrada.Controls.Add(Me.Label6)
        Me.grp_entrada.Controls.Add(Me.txt_cantidad_entrada)
        Me.grp_entrada.Controls.Add(Me.lbl_articulo)
        Me.grp_entrada.Controls.Add(Me.lbl_idx)
        Me.grp_entrada.Location = New System.Drawing.Point(15, 193)
        Me.grp_entrada.Name = "grp_entrada"
        Me.grp_entrada.Size = New System.Drawing.Size(557, 356)
        Me.grp_entrada.TabIndex = 24
        Me.grp_entrada.TabStop = False
        Me.grp_entrada.Text = "ENTRADA DE MERCANCIA"
        Me.grp_entrada.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(150, 13)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "MERCANCIA A DESCONTAR"
        '
        'lbl_precio_articulo
        '
        Me.lbl_precio_articulo.AutoSize = True
        Me.lbl_precio_articulo.Location = New System.Drawing.Point(512, 184)
        Me.lbl_precio_articulo.Name = "lbl_precio_articulo"
        Me.lbl_precio_articulo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_precio_articulo.TabIndex = 27
        Me.lbl_precio_articulo.Text = "Label1"
        '
        'btn_servicio_entrada
        '
        Me.btn_servicio_entrada.Location = New System.Drawing.Point(326, 309)
        Me.btn_servicio_entrada.Name = "btn_servicio_entrada"
        Me.btn_servicio_entrada.Size = New System.Drawing.Size(75, 23)
        Me.btn_servicio_entrada.TabIndex = 26
        Me.btn_servicio_entrada.Text = "SERVICIO"
        Me.btn_servicio_entrada.UseVisualStyleBackColor = True
        Me.btn_servicio_entrada.Visible = False
        '
        'btn_garantia_entrada
        '
        Me.btn_garantia_entrada.Location = New System.Drawing.Point(233, 309)
        Me.btn_garantia_entrada.Name = "btn_garantia_entrada"
        Me.btn_garantia_entrada.Size = New System.Drawing.Size(75, 23)
        Me.btn_garantia_entrada.TabIndex = 25
        Me.btn_garantia_entrada.Text = "GARANTIA"
        Me.btn_garantia_entrada.UseVisualStyleBackColor = True
        Me.btn_garantia_entrada.Visible = False
        '
        'btn_parcial_entrada
        '
        Me.btn_parcial_entrada.Location = New System.Drawing.Point(137, 309)
        Me.btn_parcial_entrada.Name = "btn_parcial_entrada"
        Me.btn_parcial_entrada.Size = New System.Drawing.Size(75, 23)
        Me.btn_parcial_entrada.TabIndex = 24
        Me.btn_parcial_entrada.Text = "R PARCIAL"
        Me.btn_parcial_entrada.UseVisualStyleBackColor = True
        Me.btn_parcial_entrada.Visible = False
        '
        'btn_cambio_entrada
        '
        Me.btn_cambio_entrada.Location = New System.Drawing.Point(42, 309)
        Me.btn_cambio_entrada.Name = "btn_cambio_entrada"
        Me.btn_cambio_entrada.Size = New System.Drawing.Size(75, 23)
        Me.btn_cambio_entrada.TabIndex = 23
        Me.btn_cambio_entrada.Text = "CAMBIO"
        Me.btn_cambio_entrada.UseVisualStyleBackColor = True
        Me.btn_cambio_entrada.Visible = False
        '
        'grp_seleccion
        '
        Me.grp_seleccion.Controls.Add(Me.btn_cambio)
        Me.grp_seleccion.Controls.Add(Me.btn_parcial)
        Me.grp_seleccion.Controls.Add(Me.btn_garantia)
        Me.grp_seleccion.Controls.Add(Me.btn_servicio)
        Me.grp_seleccion.Location = New System.Drawing.Point(15, 78)
        Me.grp_seleccion.Name = "grp_seleccion"
        Me.grp_seleccion.Size = New System.Drawing.Size(401, 45)
        Me.grp_seleccion.TabIndex = 25
        Me.grp_seleccion.TabStop = False
        Me.grp_seleccion.Text = "SELECCIONE UNA OPCION"
        '
        'grp_saldo
        '
        Me.grp_saldo.Controls.Add(Me.btn_modificar)
        Me.grp_saldo.Controls.Add(Me.Label11)
        Me.grp_saldo.Controls.Add(Me.Label10)
        Me.grp_saldo.Controls.Add(Me.lbl_saldo_act)
        Me.grp_saldo.Controls.Add(Me.lbl_saldo_nuevo)
        Me.grp_saldo.Location = New System.Drawing.Point(17, 237)
        Me.grp_saldo.Name = "grp_saldo"
        Me.grp_saldo.Size = New System.Drawing.Size(534, 52)
        Me.grp_saldo.TabIndex = 29
        Me.grp_saldo.TabStop = False
        Me.grp_saldo.Text = "AJUSTAR SALDO"
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(82, 211)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(469, 20)
        Me.txt_motivo.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 214)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 31
        Me.Label2.Text = "MOTIVO"
        '
        'modificar_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(584, 561)
        Me.Controls.Add(Me.grp_seleccion)
        Me.Controls.Add(Me.grp_entrada)
        Me.Controls.Add(Me.grp_salida)
        Me.Controls.Add(Me.lbl_venta)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.lbl_clave)
        Me.Name = "modificar_articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "tarjeta_modificar_articulos"
        CType(Me.txt_cantidad_salida, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_cantidad_entrada, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_salida.ResumeLayout(False)
        Me.grp_salida.PerformLayout()
        Me.grp_entrada.ResumeLayout(False)
        Me.grp_entrada.PerformLayout()
        Me.grp_seleccion.ResumeLayout(False)
        Me.grp_saldo.ResumeLayout(False)
        Me.grp_saldo.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_venta As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_cantidad_salida As NumericUpDown
    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents btn_agregar As Button
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents txt_cantidad_entrada As NumericUpDown
    Friend WithEvents Label6 As Label
    Friend WithEvents lbl_clave_articulo As Label
    Friend WithEvents lbl_articulo As Label
    Friend WithEvents lbl_idx As Label
    Friend WithEvents btn_modificar As Button
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_saldo_act As Label
    Friend WithEvents lbl_saldo_nuevo As Label
    Friend WithEvents btn_cambio As Button
    Friend WithEvents btn_parcial As Button
    Friend WithEvents btn_garantia As Button
    Friend WithEvents btn_servicio As Button
    Friend WithEvents grp_salida As GroupBox
    Friend WithEvents grp_entrada As GroupBox
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents btn_servicio_entrada As Button
    Friend WithEvents btn_garantia_entrada As Button
    Friend WithEvents btn_parcial_entrada As Button
    Friend WithEvents btn_cambio_entrada As Button
    Friend WithEvents grp_seleccion As GroupBox
    Friend WithEvents lbl_precio_articulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_motivo As TextBox
    Friend WithEvents grp_saldo As GroupBox
End Class
