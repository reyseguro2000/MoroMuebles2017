<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Principal
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_usuario = New System.Windows.Forms.Label()
        Me.lbl_boega = New System.Windows.Forms.Label()
        Me.lbl_actualizacion = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lbl_muebleria = New System.Windows.Forms.Label()
        Me.busca_venta = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.bt_articulos = New System.Windows.Forms.Button()
        Me.bt_tarjetas = New System.Windows.Forms.Button()
        Me.bt_personal = New System.Windows.Forms.Button()
        Me.bt_unidades = New System.Windows.Forms.Button()
        Me.bt_reportes = New System.Windows.Forms.Button()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.btn_myoreo = New System.Windows.Forms.Button()
        Me.bt_pagos = New System.Windows.Forms.Button()
        Me.bt_contrato = New System.Windows.Forms.Button()
        Me.bt_clientes = New System.Windows.Forms.Button()
        Me.bt_taller = New System.Windows.Forms.Button()
        Me.bt_camioneta = New System.Windows.Forms.Button()
        Me.bt_fabrica = New System.Windows.Forms.Button()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(252, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 16)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label2.Location = New System.Drawing.Point(598, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 16)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "1.0BODEGA"
        Me.Label2.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Century Gothic", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label3.Location = New System.Drawing.Point(252, 102)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 16)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "ULTIMA ACTUALIZACION"
        '
        'lbl_usuario
        '
        Me.lbl_usuario.AutoSize = True
        Me.lbl_usuario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_usuario.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_usuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_usuario.Location = New System.Drawing.Point(324, 9)
        Me.lbl_usuario.Name = "lbl_usuario"
        Me.lbl_usuario.Size = New System.Drawing.Size(47, 16)
        Me.lbl_usuario.TabIndex = 11
        Me.lbl_usuario.Text = "Label4"
        '
        'lbl_boega
        '
        Me.lbl_boega.AutoSize = True
        Me.lbl_boega.BackColor = System.Drawing.Color.Transparent
        Me.lbl_boega.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_boega.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_boega.Location = New System.Drawing.Point(670, 9)
        Me.lbl_boega.Name = "lbl_boega"
        Me.lbl_boega.Size = New System.Drawing.Size(47, 16)
        Me.lbl_boega.TabIndex = 12
        Me.lbl_boega.Text = "Label4"
        Me.lbl_boega.Visible = False
        '
        'lbl_actualizacion
        '
        Me.lbl_actualizacion.AutoSize = True
        Me.lbl_actualizacion.BackColor = System.Drawing.Color.Transparent
        Me.lbl_actualizacion.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_actualizacion.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lbl_actualizacion.Location = New System.Drawing.Point(409, 102)
        Me.lbl_actualizacion.Name = "lbl_actualizacion"
        Me.lbl_actualizacion.Size = New System.Drawing.Size(47, 16)
        Me.lbl_actualizacion.TabIndex = 13
        Me.lbl_actualizacion.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(849, 449)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(144, 24)
        Me.Label4.TabIndex = 40
        Me.Label4.Text = "MUEBLERIA"
        Me.Label4.Visible = False
        '
        'lbl_muebleria
        '
        Me.lbl_muebleria.AutoSize = True
        Me.lbl_muebleria.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_muebleria.Location = New System.Drawing.Point(848, 494)
        Me.lbl_muebleria.Name = "lbl_muebleria"
        Me.lbl_muebleria.Size = New System.Drawing.Size(269, 27)
        Me.lbl_muebleria.TabIndex = 39
        Me.lbl_muebleria.Text = "nombre_muebleria"
        Me.lbl_muebleria.Visible = False
        '
        'busca_venta
        '
        Me.busca_venta.Location = New System.Drawing.Point(686, 54)
        Me.busca_venta.Name = "busca_venta"
        Me.busca_venta.Size = New System.Drawing.Size(81, 22)
        Me.busca_venta.TabIndex = 49
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label14.Location = New System.Drawing.Point(634, 57)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(46, 16)
        Me.Label14.TabIndex = 50
        Me.Label14.Text = "VENTA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.Transparent
        Me.Label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label15.Location = New System.Drawing.Point(534, 57)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(94, 16)
        Me.Label15.TabIndex = 51
        Me.Label15.Text = "BUSCA RAPIDA"
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Location = New System.Drawing.Point(693, 95)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(75, 23)
        Me.btn_actualizar.TabIndex = 53
        Me.btn_actualizar.Text = "CARGAR"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'bt_articulos
        '
        Me.bt_articulos.BackgroundImage = Global.Captura.My.Resources.Resources.Lista_Artículos_mor
        Me.bt_articulos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_articulos.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_articulos.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_articulos.Location = New System.Drawing.Point(82, 303)
        Me.bt_articulos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_articulos.Name = "bt_articulos"
        Me.bt_articulos.Size = New System.Drawing.Size(167, 150)
        Me.bt_articulos.TabIndex = 57
        Me.bt_articulos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_articulos.UseVisualStyleBackColor = True
        '
        'bt_tarjetas
        '
        Me.bt_tarjetas.BackgroundImage = Global.Captura.My.Resources.Resources.AtencionCliente_mor
        Me.bt_tarjetas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_tarjetas.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_tarjetas.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_tarjetas.Location = New System.Drawing.Point(601, 303)
        Me.bt_tarjetas.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_tarjetas.Name = "bt_tarjetas"
        Me.bt_tarjetas.Size = New System.Drawing.Size(167, 150)
        Me.bt_tarjetas.TabIndex = 56
        Me.bt_tarjetas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_tarjetas.UseVisualStyleBackColor = True
        '
        'bt_personal
        '
        Me.bt_personal.BackgroundImage = Global.Captura.My.Resources.Resources.Personal_mor
        Me.bt_personal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_personal.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_personal.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_personal.Location = New System.Drawing.Point(428, 483)
        Me.bt_personal.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_personal.Name = "bt_personal"
        Me.bt_personal.Size = New System.Drawing.Size(167, 150)
        Me.bt_personal.TabIndex = 55
        Me.bt_personal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_personal.UseVisualStyleBackColor = True
        '
        'bt_unidades
        '
        Me.bt_unidades.BackgroundImage = Global.Captura.My.Resources.Resources.Unidades_mor
        Me.bt_unidades.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_unidades.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_unidades.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_unidades.Location = New System.Drawing.Point(428, 129)
        Me.bt_unidades.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_unidades.Name = "bt_unidades"
        Me.bt_unidades.Size = New System.Drawing.Size(167, 150)
        Me.bt_unidades.TabIndex = 54
        Me.bt_unidades.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_unidades.UseVisualStyleBackColor = True
        '
        'bt_reportes
        '
        Me.bt_reportes.BackgroundImage = Global.Captura.My.Resources.Resources.Reportes_mor
        Me.bt_reportes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_reportes.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_reportes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_reportes.Location = New System.Drawing.Point(601, 483)
        Me.bt_reportes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_reportes.Name = "bt_reportes"
        Me.bt_reportes.Size = New System.Drawing.Size(167, 150)
        Me.bt_reportes.TabIndex = 35
        Me.bt_reportes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_reportes.UseVisualStyleBackColor = True
        '
        'img_logo
        '
        Me.img_logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.img_logo.Location = New System.Drawing.Point(999, 441)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(72, 41)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 34
        Me.img_logo.TabStop = False
        Me.img_logo.Visible = False
        '
        'btn_myoreo
        '
        Me.btn_myoreo.BackgroundImage = Global.Captura.My.Resources.Resources.Mayoreo_mor
        Me.btn_myoreo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_myoreo.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_myoreo.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btn_myoreo.Location = New System.Drawing.Point(601, 129)
        Me.btn_myoreo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_myoreo.Name = "btn_myoreo"
        Me.btn_myoreo.Size = New System.Drawing.Size(167, 150)
        Me.btn_myoreo.TabIndex = 7
        Me.btn_myoreo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_myoreo.UseVisualStyleBackColor = True
        '
        'bt_pagos
        '
        Me.bt_pagos.BackgroundImage = Global.Captura.My.Resources.Resources.Rutas_mor
        Me.bt_pagos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_pagos.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_pagos.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_pagos.Location = New System.Drawing.Point(428, 303)
        Me.bt_pagos.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_pagos.Name = "bt_pagos"
        Me.bt_pagos.Size = New System.Drawing.Size(167, 150)
        Me.bt_pagos.TabIndex = 6
        Me.bt_pagos.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_pagos.UseVisualStyleBackColor = True
        '
        'bt_contrato
        '
        Me.bt_contrato.BackgroundImage = Global.Captura.My.Resources.Resources.Contrato_mor
        Me.bt_contrato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_contrato.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_contrato.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_contrato.Location = New System.Drawing.Point(255, 483)
        Me.bt_contrato.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_contrato.Name = "bt_contrato"
        Me.bt_contrato.Size = New System.Drawing.Size(167, 150)
        Me.bt_contrato.TabIndex = 5
        Me.bt_contrato.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_contrato.UseVisualStyleBackColor = True
        '
        'bt_clientes
        '
        Me.bt_clientes.BackgroundImage = Global.Captura.My.Resources.Resources.Clientes_mor
        Me.bt_clientes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_clientes.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_clientes.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_clientes.Location = New System.Drawing.Point(255, 303)
        Me.bt_clientes.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_clientes.Name = "bt_clientes"
        Me.bt_clientes.Size = New System.Drawing.Size(167, 150)
        Me.bt_clientes.TabIndex = 4
        Me.bt_clientes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_clientes.UseVisualStyleBackColor = True
        '
        'bt_taller
        '
        Me.bt_taller.BackgroundImage = Global.Captura.My.Resources.Resources.Taller_mor
        Me.bt_taller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_taller.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_taller.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_taller.Location = New System.Drawing.Point(82, 483)
        Me.bt_taller.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_taller.Name = "bt_taller"
        Me.bt_taller.Size = New System.Drawing.Size(156, 150)
        Me.bt_taller.TabIndex = 2
        Me.bt_taller.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_taller.UseVisualStyleBackColor = True
        '
        'bt_camioneta
        '
        Me.bt_camioneta.BackgroundImage = Global.Captura.My.Resources.Resources.Libreta_mor
        Me.bt_camioneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_camioneta.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_camioneta.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_camioneta.Location = New System.Drawing.Point(255, 129)
        Me.bt_camioneta.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_camioneta.Name = "bt_camioneta"
        Me.bt_camioneta.Size = New System.Drawing.Size(167, 150)
        Me.bt_camioneta.TabIndex = 1
        Me.bt_camioneta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_camioneta.UseVisualStyleBackColor = True
        '
        'bt_fabrica
        '
        Me.bt_fabrica.BackgroundImage = Global.Captura.My.Resources.Resources.Proveedores_mor
        Me.bt_fabrica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_fabrica.Font = New System.Drawing.Font("Century Gothic", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_fabrica.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.bt_fabrica.Location = New System.Drawing.Point(82, 129)
        Me.bt_fabrica.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.bt_fabrica.Name = "bt_fabrica"
        Me.bt_fabrica.Size = New System.Drawing.Size(167, 150)
        Me.bt_fabrica.TabIndex = 0
        Me.bt_fabrica.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_fabrica.UseVisualStyleBackColor = True
        '
        'Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Captura.My.Resources.Resources.Fondo4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(884, 661)
        Me.Controls.Add(Me.bt_articulos)
        Me.Controls.Add(Me.bt_tarjetas)
        Me.Controls.Add(Me.bt_personal)
        Me.Controls.Add(Me.bt_unidades)
        Me.Controls.Add(Me.btn_actualizar)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.busca_venta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lbl_muebleria)
        Me.Controls.Add(Me.bt_reportes)
        Me.Controls.Add(Me.img_logo)
        Me.Controls.Add(Me.lbl_actualizacion)
        Me.Controls.Add(Me.lbl_boega)
        Me.Controls.Add(Me.lbl_usuario)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_myoreo)
        Me.Controls.Add(Me.bt_pagos)
        Me.Controls.Add(Me.bt_contrato)
        Me.Controls.Add(Me.bt_clientes)
        Me.Controls.Add(Me.bt_taller)
        Me.Controls.Add(Me.bt_camioneta)
        Me.Controls.Add(Me.bt_fabrica)
        Me.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Principal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MUEBLERIA"
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_fabrica As Button
    Friend WithEvents bt_camioneta As Button
    Friend WithEvents bt_taller As Button
    Friend WithEvents btn_myoreo As Button
    Friend WithEvents bt_pagos As Button
    Friend WithEvents bt_contrato As Button
    Friend WithEvents bt_clientes As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_usuario As Label
    Friend WithEvents lbl_boega As Label
    Friend WithEvents lbl_actualizacion As Label
    Friend WithEvents img_logo As PictureBox
    Friend WithEvents bt_reportes As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lbl_muebleria As Label
    Friend WithEvents busca_venta As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents btn_actualizar As Button
    Friend WithEvents bt_articulos As Button
    Friend WithEvents bt_tarjetas As Button
    Friend WithEvents bt_personal As Button
    Friend WithEvents bt_unidades As Button
End Class
