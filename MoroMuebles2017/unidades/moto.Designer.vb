<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class moto
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
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.cmb_propietario = New System.Windows.Forms.ComboBox()
        Me.txt_observaciones = New System.Windows.Forms.TextBox()
        Me.fecha_compra = New System.Windows.Forms.DateTimePicker()
        Me.txt_precio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_placa = New System.Windows.Forms.TextBox()
        Me.txt_serie = New System.Windows.Forms.TextBox()
        Me.cmb_modelo = New System.Windows.Forms.ComboBox()
        Me.cmb_marca = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_id = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cmb_chofer = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
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
        'btn_modificar
        '
        Me.btn_modificar.Location = New System.Drawing.Point(374, 237)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(75, 62)
        Me.btn_modificar.TabIndex = 60
        Me.btn_modificar.Text = "Modificar"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        Me.btn_modificar.Visible = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImage = Global.Captura.My.Resources.Resources.moto
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nuevo.Location = New System.Drawing.Point(272, 237)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(75, 62)
        Me.btn_nuevo.TabIndex = 59
        Me.btn_nuevo.Text = "Guardar"
        Me.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo.UseVisualStyleBackColor = True
        Me.btn_nuevo.Visible = False
        '
        'cmb_propietario
        '
        Me.cmb_propietario.FormattingEnabled = True
        Me.cmb_propietario.Location = New System.Drawing.Point(114, 210)
        Me.cmb_propietario.Name = "cmb_propietario"
        Me.cmb_propietario.Size = New System.Drawing.Size(218, 21)
        Me.cmb_propietario.TabIndex = 55
        '
        'txt_observaciones
        '
        Me.txt_observaciones.Location = New System.Drawing.Point(283, 143)
        Me.txt_observaciones.Name = "txt_observaciones"
        Me.txt_observaciones.Size = New System.Drawing.Size(121, 20)
        Me.txt_observaciones.TabIndex = 54
        '
        'fecha_compra
        '
        Me.fecha_compra.Location = New System.Drawing.Point(132, 178)
        Me.fecha_compra.Name = "fecha_compra"
        Me.fecha_compra.Size = New System.Drawing.Size(200, 20)
        Me.fecha_compra.TabIndex = 53
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(69, 143)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.Size = New System.Drawing.Size(104, 20)
        Me.txt_precio.TabIndex = 52
        '
        'txt_placa
        '
        Me.txt_placa.Location = New System.Drawing.Point(69, 87)
        Me.txt_placa.Name = "txt_placa"
        Me.txt_placa.Size = New System.Drawing.Size(121, 20)
        Me.txt_placa.TabIndex = 51
        '
        'txt_serie
        '
        Me.txt_serie.Location = New System.Drawing.Point(282, 113)
        Me.txt_serie.Name = "txt_serie"
        Me.txt_serie.Size = New System.Drawing.Size(122, 20)
        Me.txt_serie.TabIndex = 46
        '
        'cmb_modelo
        '
        Me.cmb_modelo.FormattingEnabled = True
        Me.cmb_modelo.Location = New System.Drawing.Point(68, 116)
        Me.cmb_modelo.Name = "cmb_modelo"
        Me.cmb_modelo.Size = New System.Drawing.Size(125, 21)
        Me.cmb_modelo.TabIndex = 45
        '
        'cmb_marca
        '
        Me.cmb_marca.FormattingEnabled = True
        Me.cmb_marca.Location = New System.Drawing.Point(69, 61)
        Me.cmb_marca.Name = "cmb_marca"
        Me.cmb_marca.Size = New System.Drawing.Size(121, 21)
        Me.cmb_marca.TabIndex = 44
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(18, 210)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(80, 13)
        Me.Label12.TabIndex = 43
        Me.Label12.Text = "PROPIETARIO"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(179, 150)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(98, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "OBSERVACIONES"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(109, 13)
        Me.Label10.TabIndex = 41
        Me.Label10.Text = "FECHA DE COMPRA"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(16, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(47, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "PRECIO"
        '
        'lbl_id
        '
        Me.lbl_id.AutoSize = True
        Me.lbl_id.Location = New System.Drawing.Point(351, 34)
        Me.lbl_id.Name = "lbl_id"
        Me.lbl_id.Size = New System.Drawing.Size(18, 13)
        Me.lbl_id.TabIndex = 39
        Me.lbl_id.Text = "ID"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 89)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(54, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = " # PLACA"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(220, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "# SERIE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 120)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "MODELO"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "MARCA"
        '
        'cmb_chofer
        '
        Me.cmb_chofer.FormattingEnabled = True
        Me.cmb_chofer.Location = New System.Drawing.Point(69, 34)
        Me.cmb_chofer.Name = "cmb_chofer"
        Me.cmb_chofer.Size = New System.Drawing.Size(243, 21)
        Me.cmb_chofer.TabIndex = 62
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(10, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 13)
        Me.Label5.TabIndex = 61
        Me.Label5.Text = "CHOFER"
        '
        'cmb_tenencia
        '
        Me.cmb_tenencia.FormattingEnabled = True
        Me.cmb_tenencia.Location = New System.Drawing.Point(283, 86)
        Me.cmb_tenencia.Name = "cmb_tenencia"
        Me.cmb_tenencia.Size = New System.Drawing.Size(121, 21)
        Me.cmb_tenencia.TabIndex = 64
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(216, 87)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(61, 13)
        Me.Label14.TabIndex = 63
        Me.Label14.Text = "TENENCIA"
        '
        'foto_3
        '
        Me.foto_3.Location = New System.Drawing.Point(456, 189)
        Me.foto_3.Name = "foto_3"
        Me.foto_3.Size = New System.Drawing.Size(87, 75)
        Me.foto_3.TabIndex = 58
        Me.foto_3.TabStop = False
        '
        'foto_2
        '
        Me.foto_2.Location = New System.Drawing.Point(456, 108)
        Me.foto_2.Name = "foto_2"
        Me.foto_2.Size = New System.Drawing.Size(87, 75)
        Me.foto_2.TabIndex = 57
        Me.foto_2.TabStop = False
        '
        'foto_1
        '
        Me.foto_1.Location = New System.Drawing.Point(456, 25)
        Me.foto_1.Name = "foto_1"
        Me.foto_1.Size = New System.Drawing.Size(87, 75)
        Me.foto_1.TabIndex = 56
        Me.foto_1.TabStop = False
        '
        'moto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(577, 311)
        Me.Controls.Add(Me.cmb_tenencia)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cmb_chofer)
        Me.Controls.Add(Me.Label5)
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
        Me.Controls.Add(Me.txt_serie)
        Me.Controls.Add(Me.cmb_modelo)
        Me.Controls.Add(Me.cmb_marca)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_id)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "moto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MOTOS"
        CType(Me.foto_3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto_1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_modificar As Button
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents foto_3 As PictureBox
    Friend WithEvents foto_2 As PictureBox
    Friend WithEvents foto_1 As PictureBox
    Friend WithEvents cmb_propietario As ComboBox
    Friend WithEvents txt_observaciones As TextBox
    Friend WithEvents fecha_compra As DateTimePicker
    Friend WithEvents txt_precio As MaskedTextBox
    Friend WithEvents txt_placa As TextBox
    Friend WithEvents txt_serie As TextBox
    Friend WithEvents cmb_modelo As ComboBox
    Friend WithEvents cmb_marca As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_id As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_chofer As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents cmb_tenencia As ComboBox
    Friend WithEvents Label14 As Label
End Class
