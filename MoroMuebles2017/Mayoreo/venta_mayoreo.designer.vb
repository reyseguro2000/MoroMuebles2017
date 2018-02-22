<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class venta_mayoreo
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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_folio = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CatalogoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label12 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.prdalfa = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ClientesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmb_articulos = New System.Windows.Forms.ComboBox()
        Me.ArticulosBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ArticulosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label6 = New System.Windows.Forms.Label()
        Me.prdalfa2 = New System.Drawing.Printing.PrintDocument()
        Me.RadioButton3 = New System.Windows.Forms.RadioButton()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.RadioButton4 = New System.Windows.Forms.RadioButton()
        Me.dt_articulos = New System.Windows.Forms.DataGridView()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_clave_cliente = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.lbl_bodega = New System.Windows.Forms.Label()
        CType(Me.CatalogoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(331, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "FOLIO"
        '
        'txt_folio
        '
        Me.txt_folio.Enabled = False
        Me.txt_folio.Location = New System.Drawing.Point(375, 6)
        Me.txt_folio.Name = "txt_folio"
        Me.txt_folio.Size = New System.Drawing.Size(64, 20)
        Me.txt_folio.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(459, 99)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(71, 29)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "AGRAGAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(155, 43)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "ARTICULO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(570, 215)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "ARTICULO"
        Me.Label4.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(482, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 13)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "PRECIO"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(532, 60)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(47, 20)
        Me.txt_precio.TabIndex = 9
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(458, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(70, 25)
        Me.Button2.TabIndex = 11
        Me.Button2.Text = "GUARDAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton1.Location = New System.Drawing.Point(458, 134)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(70, 17)
        Me.RadioButton1.TabIndex = 13
        Me.RadioButton1.Text = "PAGADO"
        Me.RadioButton1.UseVisualStyleBackColor = False
        Me.RadioButton1.Visible = False
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton2.Location = New System.Drawing.Point(458, 157)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(151, 17)
        Me.RadioButton2.TabIndex = 14
        Me.RadioButton2.Text = "PAGADO Y ENTREGADO"
        Me.RadioButton2.UseVisualStyleBackColor = False
        Me.RadioButton2.Visible = False
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(264, 36)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(29, 20)
        Me.TextBox4.TabIndex = 17
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(222, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(36, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "CANT"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Transparent
        Me.Label8.Location = New System.Drawing.Point(456, 306)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(462, 434)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "0"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.BackColor = System.Drawing.Color.Transparent
        Me.Label10.Location = New System.Drawing.Point(529, 264)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(13, 13)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "0"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(456, 264)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(68, 13)
        Me.Label11.TabIndex = 20
        Me.Label11.Text = "ARTICULOS"
        '
        'CatalogoBindingSource
        '
        Me.CatalogoBindingSource.DataMember = "catalogo"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(459, 335)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(13, 13)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "0"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Captura.My.Resources.Resources.PAGADO1
        Me.PictureBox2.Location = New System.Drawing.Point(714, 141)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(83, 56)
        Me.PictureBox2.TabIndex = 25
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Captura.My.Resources.Resources.PAGADOYENTREGADO
        Me.PictureBox1.Location = New System.Drawing.Point(714, 71)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(83, 57)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'cmb_articulos
        '
        Me.cmb_articulos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_articulos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_articulos.DataSource = Me.ArticulosBindingSource1
        Me.cmb_articulos.DisplayMember = "articulo"
        Me.cmb_articulos.FormattingEnabled = True
        Me.cmb_articulos.Location = New System.Drawing.Point(158, 59)
        Me.cmb_articulos.Name = "cmb_articulos"
        Me.cmb_articulos.Size = New System.Drawing.Size(290, 21)
        Me.cmb_articulos.TabIndex = 27
        Me.cmb_articulos.ValueMember = "clave"
        '
        'ArticulosBindingSource1
        '
        Me.ArticulosBindingSource1.DataMember = "articulos"
        '
        'ArticulosBindingSource
        '
        Me.ArticulosBindingSource.DataMember = "articulos"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(459, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "0"
        '
        'prdalfa2
        '
        '
        'RadioButton3
        '
        Me.RadioButton3.AutoSize = True
        Me.RadioButton3.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton3.Location = New System.Drawing.Point(459, 180)
        Me.RadioButton3.Name = "RadioButton3"
        Me.RadioButton3.Size = New System.Drawing.Size(93, 17)
        Me.RadioButton3.TabIndex = 29
        Me.RadioButton3.Text = "ENTREGADO"
        Me.RadioButton3.UseVisualStyleBackColor = False
        Me.RadioButton3.Visible = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Captura.My.Resources.Resources.JAIMELOGO
        Me.PictureBox3.Location = New System.Drawing.Point(640, 303)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(174, 60)
        Me.PictureBox3.TabIndex = 30
        Me.PictureBox3.TabStop = False
        Me.PictureBox3.Visible = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.Transparent
        Me.Label13.Location = New System.Drawing.Point(462, 394)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(13, 13)
        Me.Label13.TabIndex = 33
        Me.Label13.Text = "0"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Location = New System.Drawing.Point(459, 363)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(74, 13)
        Me.Label14.TabIndex = 32
        Me.Label14.Text = "DESCUENTO"
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Captura.My.Resources.Resources.Porcobrar
        Me.PictureBox4.Location = New System.Drawing.Point(714, 215)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(83, 57)
        Me.PictureBox4.TabIndex = 34
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'RadioButton4
        '
        Me.RadioButton4.AutoSize = True
        Me.RadioButton4.BackColor = System.Drawing.Color.Transparent
        Me.RadioButton4.Checked = True
        Me.RadioButton4.Location = New System.Drawing.Point(459, 203)
        Me.RadioButton4.Name = "RadioButton4"
        Me.RadioButton4.Size = New System.Drawing.Size(96, 17)
        Me.RadioButton4.TabIndex = 35
        Me.RadioButton4.TabStop = True
        Me.RadioButton4.Text = "POR COBRAR"
        Me.RadioButton4.UseVisualStyleBackColor = False
        Me.RadioButton4.Visible = False
        '
        'dt_articulos
        '
        Me.dt_articulos.AllowUserToAddRows = False
        Me.dt_articulos.AllowUserToDeleteRows = False
        Me.dt_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_articulos.Location = New System.Drawing.Point(15, 87)
        Me.dt_articulos.Name = "dt_articulos"
        Me.dt_articulos.ReadOnly = True
        Me.dt_articulos.Size = New System.Drawing.Size(433, 360)
        Me.dt_articulos.TabIndex = 36
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cliente.Location = New System.Drawing.Point(209, 10)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(45, 13)
        Me.lbl_cliente.TabIndex = 37
        Me.lbl_cliente.Text = "Label15"
        '
        'lbl_clave_cliente
        '
        Me.lbl_clave_cliente.AutoSize = True
        Me.lbl_clave_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave_cliente.Location = New System.Drawing.Point(155, 9)
        Me.lbl_clave_cliente.Name = "lbl_clave_cliente"
        Me.lbl_clave_cliente.Size = New System.Drawing.Size(45, 13)
        Me.lbl_clave_cliente.TabIndex = 38
        Me.lbl_clave_cliente.Text = "Label15"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.BackColor = System.Drawing.Color.Transparent
        Me.lbl_total.Location = New System.Drawing.Point(515, 306)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total.TabIndex = 39
        Me.lbl_total.Text = "0"
        '
        'lbl_bodega
        '
        Me.lbl_bodega.AutoSize = True
        Me.lbl_bodega.Location = New System.Drawing.Point(548, 22)
        Me.lbl_bodega.Name = "lbl_bodega"
        Me.lbl_bodega.Size = New System.Drawing.Size(95, 13)
        Me.lbl_bodega.TabIndex = 40
        Me.lbl_bodega.Text = "EL GRAN SUEÑO"
        Me.lbl_bodega.Visible = False
        '
        'venta_mayoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(655, 484)
        Me.Controls.Add(Me.lbl_bodega)
        Me.Controls.Add(Me.lbl_total)
        Me.Controls.Add(Me.lbl_clave_cliente)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.dt_articulos)
        Me.Controls.Add(Me.RadioButton4)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.RadioButton3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.cmb_articulos)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.RadioButton2)
        Me.Controls.Add(Me.RadioButton1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txt_folio)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "venta_mayoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "NOTA MAYOREO"
        CType(Me.CatalogoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArticulosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_folio As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    ' Friend WithEvents FacturasDataSet As FACTURAS.facturasDataSet
    Friend WithEvents CatalogoBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents CatalogoTableAdapter As FACTURAS.facturasDataSetTableAdapters.catalogoTableAdapter
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents prdalfa As System.Drawing.Printing.PrintDocument
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ClientesBindingSource As System.Windows.Forms.BindingSource
    'Friend WithEvents ClientesTableAdapter As FACTURAS.facturasDataSetTableAdapters.clientesTableAdapter
    Friend WithEvents cmb_articulos As System.Windows.Forms.ComboBox
    Friend WithEvents ArticulosBindingSource As System.Windows.Forms.BindingSource
    ' Friend WithEvents ArticulosTableAdapter As FACTURAS.facturasDataSetTableAdapters.articulosTableAdapter
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents prdalfa2 As System.Drawing.Printing.PrintDocument
    Friend WithEvents ArticulosBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents RadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents RadioButton4 As System.Windows.Forms.RadioButton
    Friend WithEvents dt_articulos As System.Windows.Forms.DataGridView
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_clave_cliente As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents lbl_bodega As Label
End Class
