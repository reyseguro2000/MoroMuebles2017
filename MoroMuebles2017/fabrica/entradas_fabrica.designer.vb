<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entradas_fabrica
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
        Me.foliotxt = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.articulotxt = New System.Windows.Forms.ComboBox()
        Me.agregar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.t_clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.t_costo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cantidadtxt = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.preciotxt = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_totoal_nota = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_provedor = New System.Windows.Forms.Label()
        Me.guardar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'foliotxt
        '
        Me.foliotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.foliotxt.Location = New System.Drawing.Point(641, 37)
        Me.foliotxt.Name = "foliotxt"
        Me.foliotxt.Size = New System.Drawing.Size(93, 29)
        Me.foliotxt.TabIndex = 25
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(506, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(125, 24)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "FOLIO NOTA"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(253, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 24)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "CANTIDAD"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(148, 80)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 24)
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "ARTÍCULO"
        '
        'articulotxt
        '
        Me.articulotxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.articulotxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.articulotxt.Enabled = False
        Me.articulotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.articulotxt.FormattingEnabled = True
        Me.articulotxt.Location = New System.Drawing.Point(257, 77)
        Me.articulotxt.Name = "articulotxt"
        Me.articulotxt.Size = New System.Drawing.Size(477, 32)
        Me.articulotxt.TabIndex = 30
        '
        'agregar
        '
        Me.agregar.BackgroundImage = Global.Captura.My.Resources.Resources.busqueda
        Me.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.agregar.Enabled = False
        Me.agregar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.agregar.Location = New System.Drawing.Point(641, 128)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(100, 100)
        Me.agregar.TabIndex = 31
        Me.agregar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.t_clave, Me.t_cantidad, Me.t_articulo, Me.t_costo})
        Me.DataGridView1.Location = New System.Drawing.Point(11, 128)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(620, 316)
        Me.DataGridView1.TabIndex = 32
        '
        't_clave
        '
        Me.t_clave.HeaderText = "Clave"
        Me.t_clave.Name = "t_clave"
        Me.t_clave.ReadOnly = True
        Me.t_clave.Width = 59
        '
        't_cantidad
        '
        Me.t_cantidad.HeaderText = "Cantidad"
        Me.t_cantidad.Name = "t_cantidad"
        Me.t_cantidad.ReadOnly = True
        Me.t_cantidad.Width = 74
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
        'cantidadtxt
        '
        Me.cantidadtxt.Enabled = False
        Me.cantidadtxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cantidadtxt.Location = New System.Drawing.Point(364, 35)
        Me.cantidadtxt.Mask = "9999999"
        Me.cantidadtxt.Name = "cantidadtxt"
        Me.cantidadtxt.Size = New System.Drawing.Size(61, 29)
        Me.cantidadtxt.TabIndex = 56
        Me.cantidadtxt.Text = "1"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(637, 274)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 24)
        Me.Label6.TabIndex = 49
        Me.Label6.Text = "PIEZAS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(721, 274)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(20, 24)
        Me.Label7.TabIndex = 50
        Me.Label7.Text = "0"
        '
        'preciotxt
        '
        Me.preciotxt.Enabled = False
        Me.preciotxt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.preciotxt.Location = New System.Drawing.Point(641, 234)
        Me.preciotxt.Name = "preciotxt"
        Me.preciotxt.Size = New System.Drawing.Size(93, 29)
        Me.preciotxt.TabIndex = 59
        Me.preciotxt.Visible = False
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.BackColor = System.Drawing.Color.Transparent
        Me.lbltotal.Font = New System.Drawing.Font("Arial", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(668, 298)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(21, 22)
        Me.lbltotal.TabIndex = 60
        Me.lbltotal.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(184, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(117, 24)
        Me.Label3.TabIndex = 62
        Me.Label3.Text = "PROVEDOR"
        '
        'txt_totoal_nota
        '
        Me.txt_totoal_nota.Location = New System.Drawing.Point(637, 323)
        Me.txt_totoal_nota.Mask = "99999"
        Me.txt_totoal_nota.Name = "txt_totoal_nota"
        Me.txt_totoal_nota.Size = New System.Drawing.Size(100, 20)
        Me.txt_totoal_nota.TabIndex = 63
        Me.txt_totoal_nota.ValidatingType = GetType(Integer)
        '
        'lbl_provedor
        '
        Me.lbl_provedor.AutoSize = True
        Me.lbl_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_provedor.Location = New System.Drawing.Point(307, 9)
        Me.lbl_provedor.Name = "lbl_provedor"
        Me.lbl_provedor.Size = New System.Drawing.Size(117, 24)
        Me.lbl_provedor.TabIndex = 64
        Me.lbl_provedor.Text = "PROVEDOR"
        '
        'guardar
        '
        Me.guardar.BackgroundImage = Global.Captura.My.Resources.Resources.Guardar_mor
        Me.guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.guardar.Enabled = False
        Me.guardar.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.guardar.Location = New System.Drawing.Point(637, 349)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(100, 100)
        Me.guardar.TabIndex = 34
        Me.guardar.UseVisualStyleBackColor = True
        '
        'entradas_fabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 461)
        Me.Controls.Add(Me.lbl_provedor)
        Me.Controls.Add(Me.txt_totoal_nota)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbltotal)
        Me.Controls.Add(Me.preciotxt)
        Me.Controls.Add(Me.cantidadtxt)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.articulotxt)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.foliotxt)
        Me.Controls.Add(Me.Label14)
        Me.Name = "entradas_fabrica"
        Me.Text = "ENTRADA DE FABRICA"
        CType(Me.DataGridView1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents foliotxt As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents articulotxt As System.Windows.Forms.ComboBox
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents cantidadtxt As System.Windows.Forms.MaskedTextBox
    Friend WithEvents t_clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents t_costo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents preciotxt As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_totoal_nota As MaskedTextBox
    Friend WithEvents lbl_provedor As Label
    Friend WithEvents guardar As Button
End Class
