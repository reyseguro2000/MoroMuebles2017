<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class camioneta
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.cmb_modelo = New System.Windows.Forms.ComboBox()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.cmb_motor = New System.Windows.Forms.ComboBox()
        Me.cmb_transmicion = New System.Windows.Forms.ComboBox()
        Me.cmb_tipo = New System.Windows.Forms.ComboBox()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me.fecha_compra = New System.Windows.Forms.DateTimePicker()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.cmb_propietario = New System.Windows.Forms.ComboBox()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.cmb_poliza = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmb_chofer = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.cmb_tenencia = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.foto_3 = New System.Windows.Forms.PictureBox()
        Me.foto_2 = New System.Windows.Forms.PictureBox()
        Me.foto_1 = New System.Windows.Forms.PictureBox()
        CType(Me.foto_3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto_1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 110)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MARCA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 109)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "MODELO"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(18, 139)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "# SERIE"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "TRANSMICIÓN"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(246, 136)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "MOTOR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(249, 184)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(51, 13)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "# PLACA"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 165)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "TIPO"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(419, 41)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 9
        Me.lbl_id.Text = "ID"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 240)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "FECHA DE COMPRA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(256, 214)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "PRECIO"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(21, 218)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "PROPIETARIO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(21, 258)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "OBSERVACIONES"
        '
        'cmb_marca
        '
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(103, 107)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(121, 21)
        Me.cmb_marca.TabIndex = 14
        '
        'cmb_modelo
        '
        Me.cmb_modelo.FormattingEnabled = True
        Me.cmb_modelo.Location = New System.Drawing.Point(309, 106)
        Me.cmb_modelo.Name = "cmb_modelo"
        Me.cmb_modelo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_modelo.TabIndex = 15
        '
        'txt_serie
        '
        Me.txt_serie.Location = New System.Drawing.Point(103, 131)
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(122, 20)
        Me.txt_serie.TabIndex = 16
        '
        'cmb_motor
        '
        Me.cmb_motor.FormattingEnabled = True
        Me.cmb_motor.Location = New System.Drawing.Point(309, 131)
        Me.cmb_motor.Name = "cmb_motor"
        Me.cmb_motor.Size = New System.Drawing.Size(121, 21)
        Me.cmb_motor.TabIndex = 18
        '
        'cmb_transmicion
        '
        Me.cmb_transmicion.FormattingEnabled = True
        Me.cmb_transmicion.Items.AddRange(New Object() {"MANUAL", "AUTOMATICA"})
        Me.cmb_transmicion.Location = New System.Drawing.Point(104, 156)
        Me.cmb_transmicion.Name = "cmb_transmicion"
        Me.cmb_transmicion.Size = New System.Drawing.Size(122, 21)
        Me.cmb_transmicion.TabIndex = 19
        '
        'cmb_tipo
        '
        Me.cmb_tipo.FormattingEnabled = True
        Me.cmb_tipo.Location = New System.Drawing.Point(103, 181)
        Me.cmb_tipo.Name = "cmb_tipo"
        Me.cmb_tipo.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tipo.TabIndex = 20
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(309, 181)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(121, 20)
        Me.txt_placa.TabIndex = 21
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(309, 207)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(121, 20)
        Me.txt_precio.TabIndex = 22
        '
        'fecha_compra
        '
        Me.fecha_compra.Location = New System.Drawing.Point(136, 234)
        Me.fecha_compra.Name = "fecha_compra"
        Me.fecha_compra.Size = New System.Drawing.Size(200, 20)
        Me.fecha_compra.TabIndex = 23
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(136, 255)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(294, 20)
        Me.txt_observaciones.TabIndex = 24
        '
        'cmb_propietario
        '
        Me.cmb_propietario.FormattingEnabled = True
        Me.cmb_propietario.Location = New System.Drawing.Point(105, 207)
        Me.cmb_propietario.Name = "cmb_propietario"
        Me.cmb_propietario.Size = New System.Drawing.Size(121, 21)
        Me.cmb_propietario.TabIndex = 25
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImage = Global.Captura.My.Resources.Resources.camioneta
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nuevo.Location = New System.Drawing.Point(458, 173)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(78, 70)
        Me.btn_nuevo.TabIndex = 29
        Me.btn_nuevo.Text = "Guardar"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        Me.btn_nuevo.Visible = False
        '
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(458, 253)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 70)
        Me.btn_modificar.TabIndex = 30
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        Me.btn_modificar.Visible = False
        '
        'cmb_poliza
        '
        Me.cmb_poliza.FormattingEnabled = True
        Me.cmb_poliza.Location = New System.Drawing.Point(104, 278)
        Me.cmb_poliza.Name = "cmb_poliza"
        Me.cmb_poliza.Size = New System.Drawing.Size(121, 21)
        Me.cmb_poliza.TabIndex = 32
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 13)
        Me.Label3.TabIndex = 31
        Me.Label3.Text = "POLIZA"
        '
        'cmb_chofer
        '
        Me.cmb_chofer.FormattingEnabled = True
        Me.cmb_chofer.Location = New System.Drawing.Point(81, 74)
        Me.cmb_chofer.Name = "cmb_chofer"
        Me.cmb_chofer.Size = New System.Drawing.Size(349, 21)
        Me.cmb_chofer.TabIndex = 34
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 82)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 33
        Me.Label9.Text = "CHOFER"
        '
        'cmb_tenencia
        '
        Me.cmb_tenencia.FormattingEnabled = True
        Me.cmb_tenencia.Location = New System.Drawing.Point(309, 156)
        Me.cmb_tenencia.Name = "cmb_tenencia"
        Me.cmb_tenencia.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tenencia.TabIndex = 36
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(237, 159)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 35
        Me.Label14.Text = "TENENCIA"
        '
        'foto_3
        '
        Me.foto_3.Location = New System.Drawing.Point(555, 233)
        Me.foto_3.Name = "foto_3"
        Me.foto_3.Size = New System.Drawing.Size(100, 90)
        Me.foto_3.TabIndex = 28
        Me.foto_3.TabStop = False
        '
        'foto_2
        '
        Me.foto_2.Location = New System.Drawing.Point(555, 137)
        Me.foto_2.Name = "foto_2"
        Me.foto_2.Size = New System.Drawing.Size(100, 90)
        Me.foto_2.TabIndex = 27
        Me.foto_2.TabStop = False
        '
        'foto_1
        '
        Me.foto_1.Location = New System.Drawing.Point(555, 41)
        Me.foto_1.Name = "foto_1"
        Me.foto_1.Size = New System.Drawing.Size(100, 90)
        Me.foto_1.TabIndex = 26
        Me.foto_1.TabStop = False
        '
        'camioneta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(684, 361)
        Me.Controls.Add(Me.cmb_tenencia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmb_chofer)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.cmb_poliza)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btn_modificar)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.foto_3)
        Me.Controls.Add(Me.foto_2)
        Me.Controls.Add(Me.foto_1)
        Me.Controls.Add(Me.cmb_propietario)
        Me.Controls.Add(Me.txt_observaciones)
        Me.Controls.Add(Me.fecha_compra)
        Me.Controls.Add(Me.txt_precio)
        Me.Controls.Add(Me.txt_placa)
        Me.Controls.Add(Me.cmb_tipo)
        Me.Controls.Add(Me.cmb_transmicion)
        Me.Controls.Add(Me.cmb_motor)
        Me.Controls.Add(Me.txt_serie)
        Me.Controls.Add(Me.cmb_modelo)
        Me.Controls.Add(Me.cmb_marca)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "camioneta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMIONETAS"
        CType(Me.foto_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents cmb_marca As ComboBox
    Friend WithEvents cmb_modelo As ComboBox
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents cmb_motor As ComboBox
    Friend WithEvents cmb_transmicion As ComboBox
    Friend WithEvents cmb_tipo As ComboBox
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents fecha_compra As DateTimePicker
    Friend WithEvents txt_observaciones As TextBox
    Friend WithEvents cmb_propietario As ComboBox
    Friend WithEvents foto_1 As PictureBox
    Friend WithEvents foto_2 As PictureBox
    Friend WithEvents foto_3 As PictureBox
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents btn_modificar As Button
    Friend WithEvents cmb_poliza As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cmb_chofer As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents cmb_tenencia As ComboBox
    Friend WithEvents Label14 As Label
End Class
