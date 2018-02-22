<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salida_taller
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
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_detalle = New System.Windows.Forms.TextBox()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.t_clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.lbl_taller = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_piezaz = New System.Windows.Forms.Label()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(230, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TALLER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "ARTÍCULO"
        '
        'cmb_articulo
        '
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(79, 51)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(298, 21)
        Me.cmb_articulo.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 85)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "DETALLE"
        '
        'txt_detalle
        '
        Me.txt_detalle.Location = New System.Drawing.Point(79, 82)
        Me.txt_detalle.Name = "txt_detalle"
        Me.txt_detalle.Size = New System.Drawing.Size(298, 20)
        Me.txt_detalle.TabIndex = 6
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.t_clave, Me.t_articulo, Me.t_detalle})
        Me.dg_articulos.Location = New System.Drawing.Point(79, 108)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.ReadOnly = True
        Me.dg_articulos.Size = New System.Drawing.Size(379, 150)
        Me.dg_articulos.TabIndex = 7
        '
        't_clave
        '
        Me.t_clave.HeaderText = "Clave"
        Me.t_clave.Name = "t_clave"
        Me.t_clave.ReadOnly = True
        Me.t_clave.Width = 59
        '
        't_articulo
        '
        Me.t_articulo.HeaderText = "Articulo"
        Me.t_articulo.Name = "t_articulo"
        Me.t_articulo.ReadOnly = True
        Me.t_articulo.Width = 67
        '
        't_detalle
        '
        Me.t_detalle.HeaderText = "Detalle"
        Me.t_detalle.Name = "t_detalle"
        Me.t_detalle.ReadOnly = True
        Me.t_detalle.Width = 65
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(383, 264)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 52)
        Me.btn_guardar.TabIndex = 8
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(383, 80)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 9
        Me.btn_agregar.Text = "AGREGAR"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'lbl_taller
        '
        Me.lbl_taller.AutoSize = True
        Me.lbl_taller.BackColor = System.Drawing.Color.Transparent
        Me.lbl_taller.Location = New System.Drawing.Point(339, 9)
        Me.lbl_taller.Name = "lbl_taller"
        Me.lbl_taller.Size = New System.Drawing.Size(39, 13)
        Me.lbl_taller.TabIndex = 10
        Me.lbl_taller.Text = "Label4"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave.Location = New System.Drawing.Point(294, 9)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(39, 13)
        Me.lbl_clave.TabIndex = 11
        Me.lbl_clave.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(208, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "PIEZAS"
        '
        'lbl_piezaz
        '
        Me.lbl_piezaz.AutoSize = True
        Me.lbl_piezaz.BackColor = System.Drawing.Color.Transparent
        Me.lbl_piezaz.Location = New System.Drawing.Point(277, 284)
        Me.lbl_piezaz.Name = "lbl_piezaz"
        Me.lbl_piezaz.Size = New System.Drawing.Size(39, 13)
        Me.lbl_piezaz.TabIndex = 13
        Me.lbl_piezaz.Text = "Label5"
        '
        'salida_taller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(506, 328)
        Me.Controls.Add(Me.lbl_piezaz)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.lbl_taller)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.txt_detalle)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_articulo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "salida_taller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALIDA A TALLER"
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_detalle As TextBox
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_agregar As Button
    Friend WithEvents t_clave As DataGridViewTextBoxColumn
    Friend WithEvents t_articulo As DataGridViewTextBoxColumn
    Friend WithEvents t_detalle As DataGridViewTextBoxColumn
    Friend WithEvents lbl_taller As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_piezaz As Label
End Class
