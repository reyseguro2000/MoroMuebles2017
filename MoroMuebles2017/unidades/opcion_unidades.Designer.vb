<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class opcion_unidades
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dt_camionetas = New System.Windows.Forms.DataGridView()
        Me.grupo_motos = New System.Windows.Forms.GroupBox()
        Me.btn_observacion_moto = New System.Windows.Forms.Button()
        Me.btn_baja_moto = New System.Windows.Forms.Button()
        Me.btn_pago_moto = New System.Windows.Forms.Button()
        Me.btn_cambio_moto = New System.Windows.Forms.Button()
        Me.dt_motos = New System.Windows.Forms.DataGridView()
        Me.grupo_camionetas = New System.Windows.Forms.GroupBox()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.btn_observacion_camioneta = New System.Windows.Forms.Button()
        Me.btn_pago_camioneta = New System.Windows.Forms.Button()
        Me.btn_cambio_camioneta = New System.Windows.Forms.Button()
        Me.bt_nuevo_camioneta = New System.Windows.Forms.Button()
        Me.btn_nuevo_moto = New System.Windows.Forms.Button()
        Me.lbl_id_camioneta = New System.Windows.Forms.Label()
        Me.lbl_chofer_camioneta = New System.Windows.Forms.Label()
        Me.lbl_chofer_moto = New System.Windows.Forms.Label()
        Me.lbl_id_moto = New System.Windows.Forms.Label()
        CType(Me.dt_camionetas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_motos.SuspendLayout()
        CType(Me.dt_motos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grupo_camionetas.SuspendLayout()
        Me.SuspendLayout()
        '
        'dt_camionetas
        '
        Me.dt_camionetas.AllowUserToAddRows = False
        Me.dt_camionetas.AllowUserToDeleteRows = False
        Me.dt_camionetas.AllowUserToOrderColumns = True
        Me.dt_camionetas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_camionetas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_camionetas.Location = New System.Drawing.Point(12, 120)
        Me.dt_camionetas.Name = "dt_camionetas"
        Me.dt_camionetas.ReadOnly = True
        Me.dt_camionetas.Size = New System.Drawing.Size(744, 192)
        Me.dt_camionetas.TabIndex = 8
        '
        'grupo_motos
        '
        Me.grupo_motos.BackColor = System.Drawing.Color.Transparent
        Me.grupo_motos.Controls.Add(Me.btn_observacion_moto)
        Me.grupo_motos.Controls.Add(Me.btn_baja_moto)
        Me.grupo_motos.Controls.Add(Me.btn_pago_moto)
        Me.grupo_motos.Controls.Add(Me.btn_cambio_moto)
        Me.grupo_motos.Location = New System.Drawing.Point(283, 318)
        Me.grupo_motos.Name = "grupo_motos"
        Me.grupo_motos.Size = New System.Drawing.Size(339, 104)
        Me.grupo_motos.TabIndex = 14
        Me.grupo_motos.TabStop = False
        Me.grupo_motos.Text = "Motos"
        '
        'btn_observacion_moto
        '
        Me.btn_observacion_moto.BackgroundImage = Global.Captura.My.Resources.Resources.Observaciones_mor
        Me.btn_observacion_moto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_observacion_moto.Location = New System.Drawing.Point(166, 14)
        Me.btn_observacion_moto.Name = "btn_observacion_moto"
        Me.btn_observacion_moto.Size = New System.Drawing.Size(75, 72)
        Me.btn_observacion_moto.TabIndex = 25
        Me.btn_observacion_moto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_observacion_moto.UseVisualStyleBackColor = True
        '
        'btn_baja_moto
        '
        Me.btn_baja_moto.BackgroundImage = Global.Captura.My.Resources.Resources.BajaMoto
        Me.btn_baja_moto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_baja_moto.Location = New System.Drawing.Point(247, 14)
        Me.btn_baja_moto.Name = "btn_baja_moto"
        Me.btn_baja_moto.Size = New System.Drawing.Size(75, 72)
        Me.btn_baja_moto.TabIndex = 15
        Me.btn_baja_moto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_baja_moto.UseVisualStyleBackColor = True
        '
        'btn_pago_moto
        '
        Me.btn_pago_moto.BackgroundImage = Global.Captura.My.Resources.Resources.Pagos_mor
        Me.btn_pago_moto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_pago_moto.Location = New System.Drawing.Point(85, 14)
        Me.btn_pago_moto.Name = "btn_pago_moto"
        Me.btn_pago_moto.Size = New System.Drawing.Size(75, 72)
        Me.btn_pago_moto.TabIndex = 14
        Me.btn_pago_moto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_pago_moto.UseVisualStyleBackColor = True
        '
        'btn_cambio_moto
        '
        Me.btn_cambio_moto.BackgroundImage = Global.Captura.My.Resources.Resources.Cambiochofer_mor
        Me.btn_cambio_moto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cambio_moto.Location = New System.Drawing.Point(4, 14)
        Me.btn_cambio_moto.Name = "btn_cambio_moto"
        Me.btn_cambio_moto.Size = New System.Drawing.Size(75, 72)
        Me.btn_cambio_moto.TabIndex = 13
        Me.btn_cambio_moto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cambio_moto.UseVisualStyleBackColor = True
        '
        'dt_motos
        '
        Me.dt_motos.AllowUserToAddRows = False
        Me.dt_motos.AllowUserToDeleteRows = False
        Me.dt_motos.AllowUserToOrderColumns = True
        Me.dt_motos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_motos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_motos.Location = New System.Drawing.Point(12, 428)
        Me.dt_motos.Name = "dt_motos"
        Me.dt_motos.ReadOnly = True
        Me.dt_motos.Size = New System.Drawing.Size(744, 193)
        Me.dt_motos.TabIndex = 9
        '
        'grupo_camionetas
        '
        Me.grupo_camionetas.BackColor = System.Drawing.Color.Transparent
        Me.grupo_camionetas.Controls.Add(Me.Button7)
        Me.grupo_camionetas.Controls.Add(Me.btn_observacion_camioneta)
        Me.grupo_camionetas.Controls.Add(Me.btn_pago_camioneta)
        Me.grupo_camionetas.Controls.Add(Me.btn_cambio_camioneta)
        Me.grupo_camionetas.Location = New System.Drawing.Point(275, 5)
        Me.grupo_camionetas.Name = "grupo_camionetas"
        Me.grupo_camionetas.Size = New System.Drawing.Size(347, 109)
        Me.grupo_camionetas.TabIndex = 15
        Me.grupo_camionetas.TabStop = False
        Me.grupo_camionetas.Text = "Camionetas"
        '
        'Button7
        '
        Me.Button7.BackgroundImage = Global.Captura.My.Resources.Resources.BajaCamioneta
        Me.Button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button7.Location = New System.Drawing.Point(252, 19)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 72)
        Me.Button7.TabIndex = 25
        Me.Button7.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button7.UseVisualStyleBackColor = True
        '
        'btn_observacion_camioneta
        '
        Me.btn_observacion_camioneta.BackgroundImage = Global.Captura.My.Resources.Resources.Observaciones_mor
        Me.btn_observacion_camioneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_observacion_camioneta.Location = New System.Drawing.Point(169, 19)
        Me.btn_observacion_camioneta.Name = "btn_observacion_camioneta"
        Me.btn_observacion_camioneta.Size = New System.Drawing.Size(75, 72)
        Me.btn_observacion_camioneta.TabIndex = 21
        Me.btn_observacion_camioneta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_observacion_camioneta.UseVisualStyleBackColor = True
        '
        'btn_pago_camioneta
        '
        Me.btn_pago_camioneta.BackgroundImage = Global.Captura.My.Resources.Resources.Pagos_mor
        Me.btn_pago_camioneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_pago_camioneta.Location = New System.Drawing.Point(88, 19)
        Me.btn_pago_camioneta.Name = "btn_pago_camioneta"
        Me.btn_pago_camioneta.Size = New System.Drawing.Size(75, 72)
        Me.btn_pago_camioneta.TabIndex = 20
        Me.btn_pago_camioneta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_pago_camioneta.UseVisualStyleBackColor = True
        '
        'btn_cambio_camioneta
        '
        Me.btn_cambio_camioneta.BackgroundImage = Global.Captura.My.Resources.Resources.Cambiochofer_mor
        Me.btn_cambio_camioneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cambio_camioneta.Location = New System.Drawing.Point(7, 19)
        Me.btn_cambio_camioneta.Name = "btn_cambio_camioneta"
        Me.btn_cambio_camioneta.Size = New System.Drawing.Size(75, 72)
        Me.btn_cambio_camioneta.TabIndex = 19
        Me.btn_cambio_camioneta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cambio_camioneta.UseVisualStyleBackColor = True
        '
        'bt_nuevo_camioneta
        '
        Me.bt_nuevo_camioneta.BackgroundImage = Global.Captura.My.Resources.Resources.AgregarCamioneta_mor
        Me.bt_nuevo_camioneta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_nuevo_camioneta.Location = New System.Drawing.Point(681, 42)
        Me.bt_nuevo_camioneta.Name = "bt_nuevo_camioneta"
        Me.bt_nuevo_camioneta.Size = New System.Drawing.Size(75, 72)
        Me.bt_nuevo_camioneta.TabIndex = 11
        Me.bt_nuevo_camioneta.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_nuevo_camioneta.UseVisualStyleBackColor = True
        '
        'btn_nuevo_moto
        '
        Me.btn_nuevo_moto.BackgroundImage = Global.Captura.My.Resources.Resources.AgregarUnidadMoto_mor
        Me.btn_nuevo_moto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nuevo_moto.Location = New System.Drawing.Point(681, 350)
        Me.btn_nuevo_moto.Name = "btn_nuevo_moto"
        Me.btn_nuevo_moto.Size = New System.Drawing.Size(75, 72)
        Me.btn_nuevo_moto.TabIndex = 12
        Me.btn_nuevo_moto.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_nuevo_moto.UseVisualStyleBackColor = True
        '
        'lbl_id_camioneta
        '
        Me.lbl_id_camioneta.AutoSize = True
        Me.lbl_id_camioneta.Location = New System.Drawing.Point(12, 104)
        Me.lbl_id_camioneta.Name = "lbl_id_camioneta"
        Me.lbl_id_camioneta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_id_camioneta.TabIndex = 16
        Me.lbl_id_camioneta.Text = "Label1"
        '
        'lbl_chofer_camioneta
        '
        Me.lbl_chofer_camioneta.AutoSize = True
        Me.lbl_chofer_camioneta.Location = New System.Drawing.Point(57, 104)
        Me.lbl_chofer_camioneta.Name = "lbl_chofer_camioneta"
        Me.lbl_chofer_camioneta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_chofer_camioneta.TabIndex = 17
        Me.lbl_chofer_camioneta.Text = "Label2"
        '
        'lbl_chofer_moto
        '
        Me.lbl_chofer_moto.AutoSize = True
        Me.lbl_chofer_moto.Location = New System.Drawing.Point(57, 409)
        Me.lbl_chofer_moto.Name = "lbl_chofer_moto"
        Me.lbl_chofer_moto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_chofer_moto.TabIndex = 19
        Me.lbl_chofer_moto.Text = "Label3"
        '
        'lbl_id_moto
        '
        Me.lbl_id_moto.AutoSize = True
        Me.lbl_id_moto.Location = New System.Drawing.Point(12, 409)
        Me.lbl_id_moto.Name = "lbl_id_moto"
        Me.lbl_id_moto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_id_moto.TabIndex = 18
        Me.lbl_id_moto.Text = "Label4"
        '
        'opcion_unidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 661)
        Me.Controls.Add(Me.lbl_chofer_moto)
        Me.Controls.Add(Me.lbl_id_moto)
        Me.Controls.Add(Me.lbl_chofer_camioneta)
        Me.Controls.Add(Me.lbl_id_camioneta)
        Me.Controls.Add(Me.grupo_camionetas)
        Me.Controls.Add(Me.grupo_motos)
        Me.Controls.Add(Me.dt_camionetas)
        Me.Controls.Add(Me.bt_nuevo_camioneta)
        Me.Controls.Add(Me.dt_motos)
        Me.Controls.Add(Me.btn_nuevo_moto)
        Me.Name = "opcion_unidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "UNIDADES"
        CType(Me.dt_camionetas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_motos.ResumeLayout(False)
        CType(Me.dt_motos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grupo_camionetas.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_nuevo_camioneta As Button
    Friend WithEvents dt_camionetas As DataGridView
    Friend WithEvents grupo_motos As GroupBox
    Friend WithEvents btn_nuevo_moto As Button
    Friend WithEvents dt_motos As DataGridView
    Friend WithEvents grupo_camionetas As GroupBox
    Friend WithEvents btn_observacion_moto As Button
    Friend WithEvents btn_baja_moto As Button
    Friend WithEvents btn_pago_moto As Button
    Friend WithEvents btn_cambio_moto As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents btn_observacion_camioneta As Button
    Friend WithEvents btn_pago_camioneta As Button
    Friend WithEvents btn_cambio_camioneta As Button
    Friend WithEvents lbl_id_camioneta As Label
    Friend WithEvents lbl_chofer_camioneta As Label
    Friend WithEvents lbl_chofer_moto As Label
    Friend WithEvents lbl_id_moto As Label
End Class
