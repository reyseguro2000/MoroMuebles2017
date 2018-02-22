<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salida_folio
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
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.btguardar = New System.Windows.Forms.Button()
        Me.lblnopagos = New System.Windows.Forms.Label()
        Me.txtdescuentocant = New System.Windows.Forms.MaskedTextBox()
        Me.txtdescuento = New System.Windows.Forms.ComboBox()
        Me.lblpagos = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.aval_datos = New System.Windows.Forms.Panel()
        Me.txttelaval = New System.Windows.Forms.TextBox()
        Me.txtciudadaval = New System.Windows.Forms.TextBox()
        Me.txtcoloniaaval = New System.Windows.Forms.TextBox()
        Me.txtcalleaval = New System.Windows.Forms.TextBox()
        Me.txtnombreaval = New System.Windows.Forms.TextBox()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.lblsaldo = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txtforma = New System.Windows.Forms.ComboBox()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.lblvence = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.txtenganche = New System.Windows.Forms.MaskedTextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.txtplazo = New System.Windows.Forms.ComboBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.dgarticulos = New System.Windows.Forms.DataGridView()
        Me.cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.precio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.formula = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p_lista = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.unitario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.comicion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtcomicion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtvendedor = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.chekaval = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbldireccion = New System.Windows.Forms.Label()
        Me.lblnombre = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btcambiar_ruta = New System.Windows.Forms.Button()
        Me.lblruta = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtfolio_old = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.btsaldo = New System.Windows.Forms.Button()
        Me.btprecios = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintContrato = New System.Drawing.Printing.PrintDocument()
        Me.aval_datos.SuspendLayout()
        CType(Me.dgarticulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.Location = New System.Drawing.Point(28, 75)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(48, 25)
        Me.lblcliente.TabIndex = 126
        Me.lblcliente.Text = "000"
        '
        'btguardar
        '
        Me.btguardar.BackgroundImage = Global.Captura.My.Resources.Resources.agregar_venta
        Me.btguardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btguardar.Enabled = False
        Me.btguardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btguardar.Location = New System.Drawing.Point(600, 342)
        Me.btguardar.Name = "btguardar"
        Me.btguardar.Size = New System.Drawing.Size(105, 75)
        Me.btguardar.TabIndex = 88
        Me.btguardar.Text = "GUARDAR"
        Me.btguardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btguardar.UseVisualStyleBackColor = True
        '
        'lblnopagos
        '
        Me.lblnopagos.AutoSize = True
        Me.lblnopagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnopagos.Location = New System.Drawing.Point(18, 564)
        Me.lblnopagos.Name = "lblnopagos"
        Me.lblnopagos.Size = New System.Drawing.Size(53, 37)
        Me.lblnopagos.TabIndex = 123
        Me.lblnopagos.Text = "00"
        '
        'txtdescuentocant
        '
        Me.txtdescuentocant.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuentocant.Location = New System.Drawing.Point(394, 387)
        Me.txtdescuentocant.Mask = "99999"
        Me.txtdescuentocant.Name = "txtdescuentocant"
        Me.txtdescuentocant.Size = New System.Drawing.Size(70, 26)
        Me.txtdescuentocant.TabIndex = 122
        Me.txtdescuentocant.Text = "0"
        Me.txtdescuentocant.ValidatingType = GetType(Integer)
        Me.txtdescuentocant.Visible = False
        '
        'txtdescuento
        '
        Me.txtdescuento.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdescuento.FormattingEnabled = True
        Me.txtdescuento.Items.AddRange(New Object() {"SIN DESCUENTO", "MAYO", "BUEN FIN", "DICIEMBRE", "REMATE", "OTRO"})
        Me.txtdescuento.Location = New System.Drawing.Point(131, 382)
        Me.txtdescuento.Name = "txtdescuento"
        Me.txtdescuento.Size = New System.Drawing.Size(252, 28)
        Me.txtdescuento.TabIndex = 121
        '
        'lblpagos
        '
        Me.lblpagos.AutoSize = True
        Me.lblpagos.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpagos.Location = New System.Drawing.Point(174, 564)
        Me.lblpagos.Name = "lblpagos"
        Me.lblpagos.Size = New System.Drawing.Size(125, 37)
        Me.lblpagos.TabIndex = 120
        Me.lblpagos.Text = "000000"
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label36.Location = New System.Drawing.Point(75, 569)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(93, 20)
        Me.Label36.TabIndex = 119
        Me.Label36.Text = "PAGOS DE"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(16, 385)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(109, 20)
        Me.Label24.TabIndex = 118
        Me.Label24.Text = "DESCUENTO"
        '
        'aval_datos
        '
        Me.aval_datos.Controls.Add(Me.txttelaval)
        Me.aval_datos.Controls.Add(Me.txtciudadaval)
        Me.aval_datos.Controls.Add(Me.txtcoloniaaval)
        Me.aval_datos.Controls.Add(Me.txtcalleaval)
        Me.aval_datos.Controls.Add(Me.txtnombreaval)
        Me.aval_datos.Controls.Add(Me.Label30)
        Me.aval_datos.Controls.Add(Me.Label29)
        Me.aval_datos.Controls.Add(Me.Label28)
        Me.aval_datos.Controls.Add(Me.Label26)
        Me.aval_datos.Controls.Add(Me.Label25)
        Me.aval_datos.Location = New System.Drawing.Point(341, 463)
        Me.aval_datos.Name = "aval_datos"
        Me.aval_datos.Size = New System.Drawing.Size(360, 145)
        Me.aval_datos.TabIndex = 117
        Me.aval_datos.Visible = False
        '
        'txttelaval
        '
        Me.txttelaval.Location = New System.Drawing.Point(53, 116)
        Me.txttelaval.Name = "txttelaval"
        Me.txttelaval.Size = New System.Drawing.Size(290, 20)
        Me.txttelaval.TabIndex = 11
        '
        'txtciudadaval
        '
        Me.txtciudadaval.Location = New System.Drawing.Point(53, 90)
        Me.txtciudadaval.Name = "txtciudadaval"
        Me.txtciudadaval.Size = New System.Drawing.Size(290, 20)
        Me.txtciudadaval.TabIndex = 10
        '
        'txtcoloniaaval
        '
        Me.txtcoloniaaval.Location = New System.Drawing.Point(53, 64)
        Me.txtcoloniaaval.Name = "txtcoloniaaval"
        Me.txtcoloniaaval.Size = New System.Drawing.Size(290, 20)
        Me.txtcoloniaaval.TabIndex = 9
        '
        'txtcalleaval
        '
        Me.txtcalleaval.Location = New System.Drawing.Point(53, 38)
        Me.txtcalleaval.Name = "txtcalleaval"
        Me.txtcalleaval.Size = New System.Drawing.Size(290, 20)
        Me.txtcalleaval.TabIndex = 7
        '
        'txtnombreaval
        '
        Me.txtnombreaval.Location = New System.Drawing.Point(53, 12)
        Me.txtnombreaval.Name = "txtnombreaval"
        Me.txtnombreaval.Size = New System.Drawing.Size(290, 20)
        Me.txtnombreaval.TabIndex = 6
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(4, 123)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(49, 13)
        Me.Label30.TabIndex = 5
        Me.Label30.Text = "Telefono"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 97)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(40, 13)
        Me.Label29.TabIndex = 4
        Me.Label29.Text = "Ciudad"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(3, 69)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(42, 13)
        Me.Label28.TabIndex = 3
        Me.Label28.Text = "Colonia"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 43)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(40, 13)
        Me.Label26.TabIndex = 1
        Me.Label26.Text = "Calle #"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 19)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(44, 13)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Nombre"
        '
        'lblsaldo
        '
        Me.lblsaldo.AutoSize = True
        Me.lblsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsaldo.Location = New System.Drawing.Point(98, 526)
        Me.lblsaldo.Name = "lblsaldo"
        Me.lblsaldo.Size = New System.Drawing.Size(125, 37)
        Me.lblsaldo.TabIndex = 116
        Me.lblsaldo.Text = "000000"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(20, 528)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(64, 20)
        Me.Label22.TabIndex = 115
        Me.Label22.Text = "SALDO"
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(98, 488)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(125, 37)
        Me.lbltotal.TabIndex = 114
        Me.lbltotal.Text = "000000"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(21, 488)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(59, 20)
        Me.Label19.TabIndex = 113
        Me.Label19.Text = "TOTAL"
        '
        'txtforma
        '
        Me.txtforma.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtforma.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtforma.FormattingEnabled = True
        Me.txtforma.Items.AddRange(New Object() {"Semanal", "Quincenal", "Mensual"})
        Me.txtforma.Location = New System.Drawing.Point(455, 152)
        Me.txtforma.Name = "txtforma"
        Me.txtforma.Size = New System.Drawing.Size(149, 28)
        Me.txtforma.TabIndex = 111
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.Location = New System.Drawing.Point(305, 159)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(144, 20)
        Me.Label33.TabIndex = 110
        Me.Label33.Text = "FORMA DE PAGO"
        '
        'lblvence
        '
        Me.lblvence.AutoSize = True
        Me.lblvence.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblvence.Location = New System.Drawing.Point(210, 160)
        Me.lblvence.Name = "lblvence"
        Me.lblvence.Size = New System.Drawing.Size(89, 20)
        Me.lblvence.TabIndex = 109
        Me.lblvence.Text = "01/01/1900"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.Location = New System.Drawing.Point(140, 157)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(64, 20)
        Me.Label31.TabIndex = 108
        Me.Label31.Text = "VENCE"
        '
        'txtenganche
        '
        Me.txtenganche.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtenganche.Location = New System.Drawing.Point(131, 422)
        Me.txtenganche.Mask = "99999"
        Me.txtenganche.Name = "txtenganche"
        Me.txtenganche.Size = New System.Drawing.Size(70, 26)
        Me.txtenganche.TabIndex = 107
        Me.txtenganche.Text = "0"
        Me.txtenganche.ValidatingType = GetType(Integer)
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 424)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(100, 20)
        Me.Label21.TabIndex = 106
        Me.Label21.Text = "ENGANCHE"
        '
        'txtplazo
        '
        Me.txtplazo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtplazo.FormattingEnabled = True
        Me.txtplazo.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.txtplazo.Location = New System.Drawing.Point(82, 149)
        Me.txtplazo.Name = "txtplazo"
        Me.txtplazo.Size = New System.Drawing.Size(52, 28)
        Me.txtplazo.TabIndex = 105
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(15, 157)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(61, 20)
        Me.Label18.TabIndex = 104
        Me.Label18.Text = "PLAZO"
        '
        'dgarticulos
        '
        Me.dgarticulos.AllowUserToAddRows = False
        Me.dgarticulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgarticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgarticulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cantidad, Me.clave, Me.articulo, Me.precio, Me.formula, Me.p_lista, Me.unitario, Me.comicion})
        Me.dgarticulos.Location = New System.Drawing.Point(23, 220)
        Me.dgarticulos.Name = "dgarticulos"
        Me.dgarticulos.ReadOnly = True
        Me.dgarticulos.Size = New System.Drawing.Size(672, 112)
        Me.dgarticulos.TabIndex = 103
        '
        'cantidad
        '
        Me.cantidad.HeaderText = "Cantidad"
        Me.cantidad.Name = "cantidad"
        Me.cantidad.ReadOnly = True
        Me.cantidad.Width = 74
        '
        'clave
        '
        Me.clave.HeaderText = "Clave"
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        Me.clave.Width = 59
        '
        'articulo
        '
        Me.articulo.HeaderText = "Articulo"
        Me.articulo.Name = "articulo"
        Me.articulo.ReadOnly = True
        Me.articulo.Width = 67
        '
        'precio
        '
        Me.precio.HeaderText = "Precio"
        Me.precio.Name = "precio"
        Me.precio.ReadOnly = True
        Me.precio.Width = 62
        '
        'formula
        '
        Me.formula.HeaderText = "formula"
        Me.formula.Name = "formula"
        Me.formula.ReadOnly = True
        Me.formula.Width = 66
        '
        'p_lista
        '
        Me.p_lista.HeaderText = "p_lista"
        Me.p_lista.Name = "p_lista"
        Me.p_lista.ReadOnly = True
        Me.p_lista.Width = 62
        '
        'unitario
        '
        Me.unitario.HeaderText = "unitario"
        Me.unitario.Name = "unitario"
        Me.unitario.ReadOnly = True
        Me.unitario.Width = 66
        '
        'comicion
        '
        Me.comicion.HeaderText = "comicion"
        Me.comicion.Name = "comicion"
        Me.comicion.ReadOnly = True
        Me.comicion.Width = 74
        '
        'txtcomicion
        '
        Me.txtcomicion.Location = New System.Drawing.Point(131, 349)
        Me.txtcomicion.Name = "txtcomicion"
        Me.txtcomicion.Size = New System.Drawing.Size(45, 20)
        Me.txtcomicion.TabIndex = 102
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 349)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(89, 20)
        Me.Label7.TabIndex = 101
        Me.Label7.Text = "COMISIÓN"
        '
        'txtvendedor
        '
        Me.txtvendedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtvendedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtvendedor.DisplayMember = "nombre"
        Me.txtvendedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtvendedor.FormattingEnabled = True
        Me.txtvendedor.Location = New System.Drawing.Point(122, 118)
        Me.txtvendedor.Name = "txtvendedor"
        Me.txtvendedor.Size = New System.Drawing.Size(552, 28)
        Me.txtvendedor.TabIndex = 100
        Me.txtvendedor.ValueMember = "ven_clave"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(15, 126)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(101, 20)
        Me.Label13.TabIndex = 99
        Me.Label13.Text = "VENDEDOR"
        '
        'chekaval
        '
        Me.chekaval.AutoSize = True
        Me.chekaval.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chekaval.ForeColor = System.Drawing.Color.Red
        Me.chekaval.Location = New System.Drawing.Point(363, 416)
        Me.chekaval.Name = "chekaval"
        Me.chekaval.Size = New System.Drawing.Size(110, 46)
        Me.chekaval.TabIndex = 125
        Me.chekaval.Text = "Aval"
        Me.chekaval.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(556, 15)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(189, 20)
        Me.DateTimePicker1.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(374, 15)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(176, 24)
        Me.Label6.TabIndex = 97
        Me.Label6.Text = "FECHA DE VENTA"
        '
        'lbldireccion
        '
        Me.lbldireccion.AutoSize = True
        Me.lbldireccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldireccion.Location = New System.Drawing.Point(101, 87)
        Me.lbldireccion.Name = "lbldireccion"
        Me.lbldireccion.Size = New System.Drawing.Size(66, 24)
        Me.lbldireccion.TabIndex = 96
        Me.lbldireccion.Text = "FOLIO"
        '
        'lblnombre
        '
        Me.lblnombre.AutoSize = True
        Me.lblnombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnombre.Location = New System.Drawing.Point(101, 51)
        Me.lblnombre.Name = "lblnombre"
        Me.lblnombre.Size = New System.Drawing.Size(66, 24)
        Me.lblnombre.TabIndex = 95
        Me.lblnombre.Text = "FOLIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(15, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(89, 24)
        Me.Label3.TabIndex = 94
        Me.Label3.Text = "CLIENTE"
        '
        'btcambiar_ruta
        '
        Me.btcambiar_ruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btcambiar_ruta.Location = New System.Drawing.Point(286, 8)
        Me.btcambiar_ruta.Name = "btcambiar_ruta"
        Me.btcambiar_ruta.Size = New System.Drawing.Size(91, 31)
        Me.btcambiar_ruta.TabIndex = 93
        Me.btcambiar_ruta.Text = "CAMBIAR"
        Me.btcambiar_ruta.UseVisualStyleBackColor = True
        '
        'lblruta
        '
        Me.lblruta.AutoSize = True
        Me.lblruta.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblruta.Location = New System.Drawing.Point(233, 9)
        Me.lblruta.Name = "lblruta"
        Me.lblruta.Size = New System.Drawing.Size(34, 24)
        Me.lblruta.TabIndex = 92
        Me.lblruta.Text = "----"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(179, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 24)
        Me.Label1.TabIndex = 91
        Me.Label1.Text = "RUTA"
        '
        'txtfolio_old
        '
        Me.txtfolio_old.Enabled = False
        Me.txtfolio_old.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtfolio_old.Location = New System.Drawing.Point(664, 48)
        Me.txtfolio_old.Name = "txtfolio_old"
        Me.txtfolio_old.Size = New System.Drawing.Size(81, 29)
        Me.txtfolio_old.TabIndex = 89
        Me.txtfolio_old.Visible = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(15, 13)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(66, 24)
        Me.Label14.TabIndex = 90
        Me.Label14.Text = "FOLIO"
        '
        'txt_folio
        '
        Me.txt_folio.Location = New System.Drawing.Point(99, 15)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(69, 20)
        Me.txt_folio.TabIndex = 127
        '
        'cmb_articulo
        '
        Me.cmb_articulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_articulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_articulo.DisplayMember = "nombre"
        Me.cmb_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(237, 189)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(368, 28)
        Me.cmb_articulo.TabIndex = 129
        Me.cmb_articulo.Text = "cmb_articulo"
        Me.cmb_articulo.ValueMember = "ven_clave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(141, 192)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 128
        Me.Label2.Text = "ARTÍCULO"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_cantidad.FormattingEnabled = True
        Me.txt_cantidad.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15"})
        Me.txt_cantidad.Location = New System.Drawing.Point(83, 189)
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(52, 28)
        Me.txt_cantidad.TabIndex = 131
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 197)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(51, 20)
        Me.Label4.TabIndex = 130
        Me.Label4.Text = "CANT"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(609, 197)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 20)
        Me.Button1.TabIndex = 132
        Me.Button1.Text = "AGREGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(701, 220)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(63, 23)
        Me.Button2.TabIndex = 133
        Me.Button2.Text = "LIMPIAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btsaldo
        '
        Me.btsaldo.BackgroundImage = Global.Captura.My.Resources.Resources.actualizacion
        Me.btsaldo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btsaldo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btsaldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btsaldo.Location = New System.Drawing.Point(213, 424)
        Me.btsaldo.Name = "btsaldo"
        Me.btsaldo.Size = New System.Drawing.Size(86, 58)
        Me.btsaldo.TabIndex = 124
        Me.btsaldo.Text = "ACTUALIZAR"
        Me.btsaldo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btsaldo.UseVisualStyleBackColor = True
        '
        'btprecios
        '
        Me.btprecios.BackgroundImage = Global.Captura.My.Resources.Resources.actualizacion
        Me.btprecios.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btprecios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btprecios.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btprecios.Location = New System.Drawing.Point(610, 152)
        Me.btprecios.Name = "btprecios"
        Me.btprecios.Size = New System.Drawing.Size(95, 39)
        Me.btprecios.TabIndex = 112
        Me.btprecios.Text = "ACTUALIZAR"
        Me.btprecios.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btprecios.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintContrato
        '
        '
        'salida_folio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(766, 665)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cmb_articulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.lblcliente)
        Me.Controls.Add(Me.btguardar)
        Me.Controls.Add(Me.btsaldo)
        Me.Controls.Add(Me.lblnopagos)
        Me.Controls.Add(Me.txtdescuentocant)
        Me.Controls.Add(Me.txtdescuento)
        Me.Controls.Add(Me.lblpagos)
        Me.Controls.Add(Me.Label36)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.aval_datos)
        Me.Controls.Add(Me.lblsaldo)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.btprecios)
        Me.Controls.Add(Me.txtforma)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.lblvence)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.txtenganche)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.txtplazo)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.dgarticulos)
        Me.Controls.Add(Me.txtcomicion)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.txtvendedor)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.chekaval)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.lbldireccion)
        Me.Controls.Add(Me.lblnombre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btcambiar_ruta)
        Me.Controls.Add(Me.lblruta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtfolio_old)
        Me.Controls.Add(Me.Label14)
        Me.Name = "salida_folio"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALIDA  FOLIO"
        Me.aval_datos.ResumeLayout(False)
        Me.aval_datos.PerformLayout()
        CType(Me.dgarticulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblcliente As Label
    Friend WithEvents btguardar As Button
    Friend WithEvents btsaldo As Button
    Friend WithEvents lblnopagos As Label
    Friend WithEvents txtdescuentocant As MaskedTextBox
    Friend WithEvents txtdescuento As ComboBox
    Friend WithEvents lblpagos As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents aval_datos As Panel
    Friend WithEvents txttelaval As TextBox
    Friend WithEvents txtciudadaval As TextBox
    Friend WithEvents txtcoloniaaval As TextBox
    Friend WithEvents txtcalleaval As TextBox
    Friend WithEvents txtnombreaval As TextBox
    Friend WithEvents Label30 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label28 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents lblsaldo As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents lbltotal As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents btprecios As Button
    Friend WithEvents txtforma As ComboBox
    Friend WithEvents Label33 As Label
    Friend WithEvents lblvence As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents txtenganche As MaskedTextBox
    Friend WithEvents Label21 As Label
    Friend WithEvents txtplazo As ComboBox
    Friend WithEvents Label18 As Label
    Friend WithEvents dgarticulos As DataGridView
    Friend WithEvents txtcomicion As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtvendedor As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents chekaval As CheckBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents lbldireccion As Label
    Friend WithEvents lblnombre As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btcambiar_ruta As Button
    Friend WithEvents lblruta As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtfolio_old As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents txt_folio As TextBox
    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_cantidad As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents cantidad As DataGridViewTextBoxColumn
    Friend WithEvents clave As DataGridViewTextBoxColumn
    Friend WithEvents articulo As DataGridViewTextBoxColumn
    Friend WithEvents precio As DataGridViewTextBoxColumn
    Friend WithEvents formula As DataGridViewTextBoxColumn
    Friend WithEvents p_lista As DataGridViewTextBoxColumn
    Friend WithEvents unitario As DataGridViewTextBoxColumn
    Friend WithEvents comicion As DataGridViewTextBoxColumn
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents PrintContrato As Printing.PrintDocument
End Class
