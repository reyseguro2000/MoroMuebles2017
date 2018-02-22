<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class salidas_camioneta
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtcantidad = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtarticulo = New System.Windows.Forms.ComboBox()
        Me.articulosdg = New System.Windows.Forms.DataGridView()
        Me.articulo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clave = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.guardar = New System.Windows.Forms.Button()
        Me.lblcantidad = New System.Windows.Forms.Label()
        Me.Continuar = New System.Windows.Forms.Button()
        Me.lblfolio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblcuantos = New System.Windows.Forms.Label()
        Me.lbl_clave_camioneta = New System.Windows.Forms.Label()
        Me.lbl_chofer = New System.Windows.Forms.Label()
        Me.agregar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.articulosdg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(149, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CHOFER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(34, 92)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "CANTIDAD"
        '
        'txtcantidad
        '
        Me.txtcantidad.Location = New System.Drawing.Point(102, 85)
        Me.txtcantidad.Mask = "99999"
        Me.txtcantidad.Name = "txtcantidad"
        Me.txtcantidad.Size = New System.Drawing.Size(37, 20)
        Me.txtcantidad.TabIndex = 4
        Me.txtcantidad.Text = "1"
        Me.txtcantidad.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 92)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(61, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "ARTÍCULO"
        '
        'txtarticulo
        '
        Me.txtarticulo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtarticulo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.txtarticulo.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtarticulo.FormattingEnabled = True
        Me.txtarticulo.Location = New System.Drawing.Point(206, 77)
        Me.txtarticulo.Name = "txtarticulo"
        Me.txtarticulo.Size = New System.Drawing.Size(328, 28)
        Me.txtarticulo.TabIndex = 6
        '
        'articulosdg
        '
        Me.articulosdg.AllowUserToAddRows = False
        Me.articulosdg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.articulosdg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.articulosdg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.articulo, Me.clave})
        Me.articulosdg.Location = New System.Drawing.Point(36, 111)
        Me.articulosdg.Name = "articulosdg"
        Me.articulosdg.ReadOnly = True
        Me.articulosdg.Size = New System.Drawing.Size(614, 215)
        Me.articulosdg.TabIndex = 8
        '
        'articulo
        '
        Me.articulo.HeaderText = "Articulo"
        Me.articulo.Name = "articulo"
        Me.articulo.ReadOnly = True
        Me.articulo.Width = 67
        '
        'clave
        '
        Me.clave.HeaderText = "Clave"
        Me.clave.Name = "clave"
        Me.clave.ReadOnly = True
        Me.clave.Width = 59
        '
        'guardar
        '
        Me.guardar.Location = New System.Drawing.Point(501, 332)
        Me.guardar.Name = "guardar"
        Me.guardar.Size = New System.Drawing.Size(88, 23)
        Me.guardar.TabIndex = 9
        Me.guardar.Text = "GUARDAR"
        Me.guardar.UseVisualStyleBackColor = True
        '
        'lblcantidad
        '
        Me.lblcantidad.AutoSize = True
        Me.lblcantidad.Location = New System.Drawing.Point(540, 80)
        Me.lblcantidad.Name = "lblcantidad"
        Me.lblcantidad.Size = New System.Drawing.Size(39, 13)
        Me.lblcantidad.TabIndex = 10
        Me.lblcantidad.Text = "Label2"
        '
        'Continuar
        '
        Me.Continuar.Location = New System.Drawing.Point(403, 332)
        Me.Continuar.Name = "Continuar"
        Me.Continuar.Size = New System.Drawing.Size(88, 23)
        Me.Continuar.TabIndex = 11
        Me.Continuar.Text = "CONTINUAR"
        Me.Continuar.UseVisualStyleBackColor = True
        Me.Continuar.Visible = False
        '
        'lblfolio
        '
        Me.lblfolio.AutoSize = True
        Me.lblfolio.Location = New System.Drawing.Point(358, 337)
        Me.lblfolio.Name = "lblfolio"
        Me.lblfolio.Size = New System.Drawing.Size(39, 13)
        Me.lblfolio.TabIndex = 12
        Me.lblfolio.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(34, 335)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 13)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "TOTAL DE ARTÍCULOS"
        '
        'lblcuantos
        '
        Me.lblcuantos.AutoSize = True
        Me.lblcuantos.Location = New System.Drawing.Point(164, 335)
        Me.lblcuantos.Name = "lblcuantos"
        Me.lblcuantos.Size = New System.Drawing.Size(13, 13)
        Me.lblcuantos.TabIndex = 14
        Me.lblcuantos.Text = "0"
        '
        'lbl_clave_camioneta
        '
        Me.lbl_clave_camioneta.AutoSize = True
        Me.lbl_clave_camioneta.Location = New System.Drawing.Point(215, 50)
        Me.lbl_clave_camioneta.Name = "lbl_clave_camioneta"
        Me.lbl_clave_camioneta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_clave_camioneta.TabIndex = 15
        Me.lbl_clave_camioneta.Text = "Label5"
        '
        'lbl_chofer
        '
        Me.lbl_chofer.AutoSize = True
        Me.lbl_chofer.Location = New System.Drawing.Point(260, 50)
        Me.lbl_chofer.Name = "lbl_chofer"
        Me.lbl_chofer.Size = New System.Drawing.Size(39, 13)
        Me.lbl_chofer.TabIndex = 16
        Me.lbl_chofer.Text = "Label6"
        '
        'agregar
        '
        Me.agregar.BackgroundImage = Global.Captura.My.Resources.Resources.agregar
        Me.agregar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.agregar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.agregar.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.agregar.Location = New System.Drawing.Point(585, 31)
        Me.agregar.Name = "agregar"
        Me.agregar.Size = New System.Drawing.Size(69, 62)
        Me.agregar.TabIndex = 7
        Me.agregar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.agregar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(590, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "AGREGAR"
        '
        'salidas_camioneta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_chofer)
        Me.Controls.Add(Me.lbl_clave_camioneta)
        Me.Controls.Add(Me.lblcuantos)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblfolio)
        Me.Controls.Add(Me.Continuar)
        Me.Controls.Add(Me.lblcantidad)
        Me.Controls.Add(Me.guardar)
        Me.Controls.Add(Me.articulosdg)
        Me.Controls.Add(Me.agregar)
        Me.Controls.Add(Me.txtarticulo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtcantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "salidas_camioneta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SALIDAS CAMIONETA"
        CType(Me.articulosdg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtcantidad As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtarticulo As System.Windows.Forms.ComboBox
    Friend WithEvents agregar As System.Windows.Forms.Button
    Friend WithEvents articulosdg As System.Windows.Forms.DataGridView
    Friend WithEvents guardar As System.Windows.Forms.Button
    Friend WithEvents lblcantidad As System.Windows.Forms.Label
    Friend WithEvents articulo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents clave As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Continuar As System.Windows.Forms.Button
    Friend WithEvents lblfolio As System.Windows.Forms.Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lblcuantos As Label
    Friend WithEvents lbl_clave_camioneta As Label
    Friend WithEvents lbl_chofer As Label
    Friend WithEvents Label5 As Label
End Class
