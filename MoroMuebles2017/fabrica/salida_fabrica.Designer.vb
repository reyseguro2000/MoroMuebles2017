<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salida_fabrica
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
        Me.lbl_piezaz = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.t_clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_detalle = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.agregar = New System.Windows.Forms.Button()
        Me.cmb_articulo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_detalle = New System.Windows.Forms.TextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.lbl_clave_provedor = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_provedor = New System.Windows.Forms.Label()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_piezaz
        '
        Me.lbl_piezaz.AutoSize = True
        Me.lbl_piezaz.BackColor = System.Drawing.Color.Transparent
        Me.lbl_piezaz.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_piezaz.Location = New System.Drawing.Point(646, 219)
        Me.lbl_piezaz.Name = "lbl_piezaz"
        Me.lbl_piezaz.Size = New System.Drawing.Size(20, 24)
        Me.lbl_piezaz.TabIndex = 70
        Me.lbl_piezaz.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(646, 185)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "PIEZAS"
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.t_clave, Me.t_articulo, Me.t_costo, Me.t_detalle})
        Me.dg_articulos.Location = New System.Drawing.Point(20, 116)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.ReadOnly = True
        Me.dg_articulos.Size = New System.Drawing.Size(620, 316)
        Me.dg_articulos.TabIndex = 68
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
        't_costo
        '
        Me.t_costo.HeaderText = "Costo"
        Me.t_costo.Name = "t_costo"
        Me.t_costo.ReadOnly = True
        Me.t_costo.Visible = False
        Me.t_costo.Width = 59
        '
        't_detalle
        '
        Me.t_detalle.HeaderText = "Detalle"
        Me.t_detalle.Name = "t_detalle"
        Me.t_detalle.ReadOnly = True
        Me.t_detalle.Width = 65
        '
        'agregar
        '
        Me.agregar.BackgroundImage = Global.Captura.My.Resources.Resources.agregar
        Me.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.Location = New System.Drawing.Point(643, 76)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(100, 100)
        Me.agregar.TabIndex = 67
        Me.agregar.UseVisualStyleBackColor = True
        '
        'cmb_articulo
        '
        Me.cmb_articulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmb_articulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmb_articulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmb_articulo.FormattingEnabled = True
        Me.cmb_articulo.Location = New System.Drawing.Point(247, 38)
        Me.cmb_articulo.Name = "cmb_articulo"
        Me.cmb_articulo.Size = New System.Drawing.Size(492, 28)
        Me.cmb_articulo.TabIndex = 66
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(144, 46)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 20)
        Me.Label2.TabIndex = 65
        Me.Label2.Text = "ARTÍCULO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(144, 87)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 20)
        Me.Label4.TabIndex = 76
        Me.Label4.Text = "DETALLE"
        '
        'txt_detalle
        '
        Me.txt_detalle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_detalle.Location = New System.Drawing.Point(247, 81)
        Me.txt_detalle.MaxLength = 20
        Me.txt_detalle.Name = "txt_detalle"
        Me.txt_detalle.Size = New System.Drawing.Size(393, 26)
        Me.txt_detalle.TabIndex = 75
        '
        'btn_guardar
        '
        Me.btn_guardar.BackgroundImage = Global.Captura.My.Resources.Resources.Guardar_mor
        Me.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar.Location = New System.Drawing.Point(642, 332)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(100, 100)
        Me.btn_guardar.TabIndex = 77
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'lbl_clave_provedor
        '
        Me.lbl_clave_provedor.AutoSize = True
        Me.lbl_clave_provedor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clave_provedor.Location = New System.Drawing.Point(460, 9)
        Me.lbl_clave_provedor.Name = "lbl_clave_provedor"
        Me.lbl_clave_provedor.Size = New System.Drawing.Size(54, 24)
        Me.lbl_clave_provedor.TabIndex = 79
        Me.lbl_clave_provedor.Text = "clave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(328, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 24)
        Me.Label3.TabIndex = 78
        Me.Label3.Text = "PROVEDOR"
        '
        'lbl_provedor
        '
        Me.lbl_provedor.AutoSize = True
        Me.lbl_provedor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_provedor.Location = New System.Drawing.Point(520, 9)
        Me.lbl_provedor.Name = "lbl_provedor"
        Me.lbl_provedor.Size = New System.Drawing.Size(117, 24)
        Me.lbl_provedor.TabIndex = 80
        Me.lbl_provedor.Text = "PROVEDOR"
        '
        'salida_fabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lbl_provedor)
        Me.Controls.Add(Me.lbl_clave_provedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_detalle)
        Me.Controls.Add(Me.lbl_piezaz)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.cmb_articulo)
        Me.Controls.Add(Me.Label2)
        Me.Name = "salida_fabrica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALIDA DE FABRICA"
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_piezaz As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents agregar As Button
    Friend WithEvents cmb_articulo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_detalle As TextBox
    Friend WithEvents t_clave As DataGridViewTextBoxColumn
    Friend WithEvents t_articulo As DataGridViewTextBoxColumn
    Friend WithEvents t_costo As DataGridViewTextBoxColumn
    Friend WithEvents t_detalle As DataGridViewTextBoxColumn
    Friend WithEvents btn_guardar As Button
    Friend WithEvents lbl_clave_provedor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_provedor As Label
End Class
