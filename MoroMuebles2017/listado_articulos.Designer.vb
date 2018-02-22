<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_articulos
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
        Me.txt_articulo = New System.Windows.Forms.TextBox()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.op_activos = New System.Windows.Forms.CheckBox()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.lbl_mayoreo = New System.Windows.Forms.Label()
        Me.lbl_1mes = New System.Windows.Forms.Label()
        Me.img_articulo = New System.Windows.Forms.PictureBox()
        Me.lbl_2mes = New System.Windows.Forms.Label()
        Me.lbl_3mes = New System.Windows.Forms.Label()
        Me.lbl_7mes = New System.Windows.Forms.Label()
        Me.lbl_6mes = New System.Windows.Forms.Label()
        Me.lbl_5mes = New System.Windows.Forms.Label()
        Me.lbl_4mes = New System.Windows.Forms.Label()
        Me.lbl_9mes = New System.Windows.Forms.Label()
        Me.lbl_8mes = New System.Windows.Forms.Label()
        Me.lbl_11mes = New System.Windows.Forms.Label()
        Me.lbl_10mes = New System.Windows.Forms.Label()
        Me.lbl_contado = New System.Windows.Forms.Label()
        Me.lbl_com = New System.Windows.Forms.Label()
        Me.lbl_12mes = New System.Windows.Forms.Label()
        Me.btn_detalle = New System.Windows.Forms.Button()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.img_articulo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(240, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ARTICULO"
        '
        'txt_articulo
        '
        Me.txt_articulo.Location = New System.Drawing.Point(307, 11)
        Me.txt_articulo.Name = "txt_articulo"
        Me.txt_articulo.Size = New System.Drawing.Size(122, 20)
        Me.txt_articulo.TabIndex = 1
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AllowUserToDeleteRows = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Location = New System.Drawing.Point(15, 44)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.ReadOnly = True
        Me.dg_articulos.Size = New System.Drawing.Size(507, 309)
        Me.dg_articulos.TabIndex = 2
        '
        'op_activos
        '
        Me.op_activos.AutoSize = True
        Me.op_activos.Checked = True
        Me.op_activos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.op_activos.Location = New System.Drawing.Point(447, 17)
        Me.op_activos.Name = "op_activos"
        Me.op_activos.Size = New System.Drawing.Size(72, 17)
        Me.op_activos.TabIndex = 5
        Me.op_activos.Text = "ACTIVOS"
        Me.op_activos.UseVisualStyleBackColor = True
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave.Location = New System.Drawing.Point(12, 371)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(39, 13)
        Me.lbl_clave.TabIndex = 6
        Me.lbl_clave.Text = "Label2"
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(88, 371)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_articulo.TabIndex = 7
        Me.lbl_articulo.Text = "Label2"
        '
        'lbl_mayoreo
        '
        Me.lbl_mayoreo.AutoSize = True
        Me.lbl_mayoreo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_mayoreo.Location = New System.Drawing.Point(349, 539)
        Me.lbl_mayoreo.Name = "lbl_mayoreo"
        Me.lbl_mayoreo.Size = New System.Drawing.Size(48, 13)
        Me.lbl_mayoreo.TabIndex = 8
        Me.lbl_mayoreo.Text = "Mayoreo"
        '
        'lbl_1mes
        '
        Me.lbl_1mes.AutoSize = True
        Me.lbl_1mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_1mes.Location = New System.Drawing.Point(12, 400)
        Me.lbl_1mes.Name = "lbl_1mes"
        Me.lbl_1mes.Size = New System.Drawing.Size(36, 13)
        Me.lbl_1mes.TabIndex = 10
        Me.lbl_1mes.Text = "1 Mes"
        '
        'img_articulo
        '
        Me.img_articulo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_articulo.Location = New System.Drawing.Point(352, 393)
        Me.img_articulo.Name = "img_articulo"
        Me.img_articulo.Size = New System.Drawing.Size(170, 132)
        Me.img_articulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_articulo.TabIndex = 12
        Me.img_articulo.TabStop = False
        '
        'lbl_2mes
        '
        Me.lbl_2mes.AutoSize = True
        Me.lbl_2mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_2mes.Location = New System.Drawing.Point(12, 423)
        Me.lbl_2mes.Name = "lbl_2mes"
        Me.lbl_2mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_2mes.TabIndex = 13
        Me.lbl_2mes.Text = "2 Meses"
        '
        'lbl_3mes
        '
        Me.lbl_3mes.AutoSize = True
        Me.lbl_3mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_3mes.Location = New System.Drawing.Point(13, 445)
        Me.lbl_3mes.Name = "lbl_3mes"
        Me.lbl_3mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_3mes.TabIndex = 14
        Me.lbl_3mes.Text = "3 Meses"
        '
        'lbl_7mes
        '
        Me.lbl_7mes.AutoSize = True
        Me.lbl_7mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_7mes.Location = New System.Drawing.Point(177, 400)
        Me.lbl_7mes.Name = "lbl_7mes"
        Me.lbl_7mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_7mes.TabIndex = 16
        Me.lbl_7mes.Text = "7 Meses"
        '
        'lbl_6mes
        '
        Me.lbl_6mes.AutoSize = True
        Me.lbl_6mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_6mes.Location = New System.Drawing.Point(14, 514)
        Me.lbl_6mes.Name = "lbl_6mes"
        Me.lbl_6mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_6mes.TabIndex = 15
        Me.lbl_6mes.Text = "6 Meses"
        '
        'lbl_5mes
        '
        Me.lbl_5mes.AutoSize = True
        Me.lbl_5mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_5mes.Location = New System.Drawing.Point(14, 490)
        Me.lbl_5mes.Name = "lbl_5mes"
        Me.lbl_5mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_5mes.TabIndex = 18
        Me.lbl_5mes.Text = "5 Meses"
        '
        'lbl_4mes
        '
        Me.lbl_4mes.AutoSize = True
        Me.lbl_4mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_4mes.Location = New System.Drawing.Point(13, 468)
        Me.lbl_4mes.Name = "lbl_4mes"
        Me.lbl_4mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_4mes.TabIndex = 17
        Me.lbl_4mes.Text = "4 Meses"
        '
        'lbl_9mes
        '
        Me.lbl_9mes.AutoSize = True
        Me.lbl_9mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_9mes.Location = New System.Drawing.Point(177, 445)
        Me.lbl_9mes.Name = "lbl_9mes"
        Me.lbl_9mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_9mes.TabIndex = 20
        Me.lbl_9mes.Text = "9 Meses"
        '
        'lbl_8mes
        '
        Me.lbl_8mes.AutoSize = True
        Me.lbl_8mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_8mes.Location = New System.Drawing.Point(176, 423)
        Me.lbl_8mes.Name = "lbl_8mes"
        Me.lbl_8mes.Size = New System.Drawing.Size(47, 13)
        Me.lbl_8mes.TabIndex = 19
        Me.lbl_8mes.Text = "8 Meses"
        '
        'lbl_11mes
        '
        Me.lbl_11mes.AutoSize = True
        Me.lbl_11mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_11mes.Location = New System.Drawing.Point(178, 490)
        Me.lbl_11mes.Name = "lbl_11mes"
        Me.lbl_11mes.Size = New System.Drawing.Size(53, 13)
        Me.lbl_11mes.TabIndex = 22
        Me.lbl_11mes.Text = "11 Meses"
        '
        'lbl_10mes
        '
        Me.lbl_10mes.AutoSize = True
        Me.lbl_10mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_10mes.Location = New System.Drawing.Point(177, 468)
        Me.lbl_10mes.Name = "lbl_10mes"
        Me.lbl_10mes.Size = New System.Drawing.Size(53, 13)
        Me.lbl_10mes.TabIndex = 21
        Me.lbl_10mes.Text = "10 Meses"
        '
        'lbl_contado
        '
        Me.lbl_contado.AutoSize = True
        Me.lbl_contado.BackColor = System.Drawing.Color.Transparent
        Me.lbl_contado.Location = New System.Drawing.Point(178, 539)
        Me.lbl_contado.Name = "lbl_contado"
        Me.lbl_contado.Size = New System.Drawing.Size(60, 13)
        Me.lbl_contado.TabIndex = 23
        Me.lbl_contado.Text = "CONTADO"
        '
        'lbl_com
        '
        Me.lbl_com.AutoSize = True
        Me.lbl_com.BackColor = System.Drawing.Color.Transparent
        Me.lbl_com.Location = New System.Drawing.Point(14, 539)
        Me.lbl_com.Name = "lbl_com"
        Me.lbl_com.Size = New System.Drawing.Size(50, 13)
        Me.lbl_com.TabIndex = 25
        Me.lbl_com.Text = "Comicion"
        '
        'lbl_12mes
        '
        Me.lbl_12mes.AutoSize = True
        Me.lbl_12mes.BackColor = System.Drawing.Color.Transparent
        Me.lbl_12mes.Location = New System.Drawing.Point(177, 512)
        Me.lbl_12mes.Name = "lbl_12mes"
        Me.lbl_12mes.Size = New System.Drawing.Size(53, 13)
        Me.lbl_12mes.TabIndex = 24
        Me.lbl_12mes.Text = "12 Meses"
        '
        'btn_detalle
        '
        Me.btn_detalle.Location = New System.Drawing.Point(352, 364)
        Me.btn_detalle.Name = "btn_detalle"
        Me.btn_detalle.Size = New System.Drawing.Size(75, 23)
        Me.btn_detalle.TabIndex = 26
        Me.btn_detalle.Text = "VER MOV"
        Me.btn_detalle.UseVisualStyleBackColor = True
        '
        'listado_articulos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 573)
        Me.Controls.Add(Me.btn_detalle)
        Me.Controls.Add(Me.lbl_com)
        Me.Controls.Add(Me.lbl_12mes)
        Me.Controls.Add(Me.lbl_contado)
        Me.Controls.Add(Me.lbl_11mes)
        Me.Controls.Add(Me.lbl_10mes)
        Me.Controls.Add(Me.lbl_9mes)
        Me.Controls.Add(Me.lbl_8mes)
        Me.Controls.Add(Me.lbl_5mes)
        Me.Controls.Add(Me.lbl_4mes)
        Me.Controls.Add(Me.lbl_7mes)
        Me.Controls.Add(Me.lbl_6mes)
        Me.Controls.Add(Me.lbl_3mes)
        Me.Controls.Add(Me.lbl_2mes)
        Me.Controls.Add(Me.img_articulo)
        Me.Controls.Add(Me.lbl_1mes)
        Me.Controls.Add(Me.lbl_mayoreo)
        Me.Controls.Add(Me.lbl_articulo)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.op_activos)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.txt_articulo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listado_articulos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ARTICULOS"
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.img_articulo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_articulo As TextBox
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents op_activos As CheckBox
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_articulo As Label
    Friend WithEvents lbl_mayoreo As Label
    Friend WithEvents lbl_1mes As Label
    Friend WithEvents img_articulo As PictureBox
    Friend WithEvents lbl_2mes As Label
    Friend WithEvents lbl_3mes As Label
    Friend WithEvents lbl_7mes As Label
    Friend WithEvents lbl_6mes As Label
    Friend WithEvents lbl_5mes As Label
    Friend WithEvents lbl_4mes As Label
    Friend WithEvents lbl_9mes As Label
    Friend WithEvents lbl_8mes As Label
    Friend WithEvents lbl_11mes As Label
    Friend WithEvents lbl_10mes As Label
    Friend WithEvents lbl_contado As Label
    Friend WithEvents lbl_com As Label
    Friend WithEvents lbl_12mes As Label
    Friend WithEvents btn_detalle As Button
End Class
