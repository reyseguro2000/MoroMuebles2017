<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcion_Personal
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
        Me.dtpersonal = New System.Windows.Forms.DataGridView()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.busca_imagen = New System.Windows.Forms.OpenFileDialog()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label47 = New System.Windows.Forms.Label()
        Me.Label46 = New System.Windows.Forms.Label()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_telefono = New System.Windows.Forms.Label()
        Me.lbl_calle = New System.Windows.Forms.Label()
        Me.lbl_ciudad = New System.Windows.Forms.Label()
        Me.lbl_sueldo = New System.Windows.Forms.Label()
        Me.lbl_colonia = New System.Windows.Forms.Label()
        Me.lbl_puesto = New System.Windows.Forms.Label()
        Me.lbl_naci = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.btn_baja = New System.Windows.Forms.Button()
        Me.btn_activar = New System.Windows.Forms.Button()
        Me.btn_cambiar_puesto = New System.Windows.Forms.Button()
        Me.btn_cuenta = New System.Windows.Forms.Button()
        Me.op_activos = New System.Windows.Forms.CheckBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cmb_puesto = New System.Windows.Forms.ComboBox()
        Me.dg_anteriores = New System.Windows.Forms.DataGridView()
        Me.txt_sueldo = New System.Windows.Forms.MaskedTextBox()
        Me.grp_persona = New System.Windows.Forms.GroupBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.foto_cara = New System.Windows.Forms.PictureBox()
        Me.foto_completo = New System.Windows.Forms.PictureBox()
        Me.bt_nuevo = New System.Windows.Forms.Button()
        CType(Me.dtpersonal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_anteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_persona.SuspendLayout()
        CType(Me.foto_cara, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.foto_completo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpersonal
        '
        Me.dtpersonal.AllowUserToAddRows = False
        Me.dtpersonal.AllowUserToDeleteRows = False
        Me.dtpersonal.AllowUserToOrderColumns = True
        Me.dtpersonal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtpersonal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtpersonal.Location = New System.Drawing.Point(5, 77)
        Me.dtpersonal.Name = "dtpersonal"
        Me.dtpersonal.ReadOnly = True
        Me.dtpersonal.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtpersonal.Size = New System.Drawing.Size(767, 130)
        Me.dtpersonal.TabIndex = 2
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.BackColor = System.Drawing.Color.Transparent
        Me.Label31.Location = New System.Drawing.Point(393, 54)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(54, 13)
        Me.Label31.TabIndex = 3
        Me.Label31.Text = "NOMBRE"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(453, 51)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(319, 20)
        Me.TextBox6.TabIndex = 4
        '
        'busca_imagen
        '
        Me.busca_imagen.FileName = "OpenFileDialog1"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 68
        Me.Label7.Text = "TELÉFONO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 91)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 13)
        Me.Label6.TabIndex = 67
        Me.Label6.Text = "CIUDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(205, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 66
        Me.Label5.Text = "COLONIA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(60, 13)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "CALLE Y #"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(534, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 13)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "FECHA DE NAC."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "NOMBRE"
        '
        'Label47
        '
        Me.Label47.AutoSize = True
        Me.Label47.Location = New System.Drawing.Point(393, 43)
        Me.Label47.Name = "Label47"
        Me.Label47.Size = New System.Drawing.Size(95, 13)
        Me.Label47.TabIndex = 70
        Me.Label47.Text = "ULTIMO SUELDO"
        '
        'Label46
        '
        Me.Label46.AutoSize = True
        Me.Label46.Location = New System.Drawing.Point(208, 67)
        Me.Label46.Name = "Label46"
        Me.Label46.Size = New System.Drawing.Size(96, 13)
        Me.Label46.TabIndex = 69
        Me.Label46.Text = "PUESTO ACTUAL"
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Location = New System.Drawing.Point(53, 16)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(25, 13)
        Me.lbl_clave.TabIndex = 71
        Me.lbl_clave.Text = "000"
        '
        'lbl_telefono
        '
        Me.lbl_telefono.AutoSize = True
        Me.lbl_telefono.Location = New System.Drawing.Point(76, 43)
        Me.lbl_telefono.Name = "lbl_telefono"
        Me.lbl_telefono.Size = New System.Drawing.Size(39, 13)
        Me.lbl_telefono.TabIndex = 72
        Me.lbl_telefono.Text = "Label4"
        '
        'lbl_calle
        '
        Me.lbl_calle.AutoSize = True
        Me.lbl_calle.Location = New System.Drawing.Point(76, 67)
        Me.lbl_calle.Name = "lbl_calle"
        Me.lbl_calle.Size = New System.Drawing.Size(39, 13)
        Me.lbl_calle.TabIndex = 73
        Me.lbl_calle.Text = "Label8"
        '
        'lbl_ciudad
        '
        Me.lbl_ciudad.AutoSize = True
        Me.lbl_ciudad.Location = New System.Drawing.Point(76, 91)
        Me.lbl_ciudad.Name = "lbl_ciudad"
        Me.lbl_ciudad.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ciudad.TabIndex = 74
        Me.lbl_ciudad.Text = "Label9"
        '
        'lbl_sueldo
        '
        Me.lbl_sueldo.AutoSize = True
        Me.lbl_sueldo.Location = New System.Drawing.Point(402, 67)
        Me.lbl_sueldo.Name = "lbl_sueldo"
        Me.lbl_sueldo.Size = New System.Drawing.Size(45, 13)
        Me.lbl_sueldo.TabIndex = 77
        Me.lbl_sueldo.Text = "Label10"
        '
        'lbl_colonia
        '
        Me.lbl_colonia.AutoSize = True
        Me.lbl_colonia.Location = New System.Drawing.Point(265, 43)
        Me.lbl_colonia.Name = "lbl_colonia"
        Me.lbl_colonia.Size = New System.Drawing.Size(45, 13)
        Me.lbl_colonia.TabIndex = 76
        Me.lbl_colonia.Text = "Label11"
        '
        'lbl_puesto
        '
        Me.lbl_puesto.AutoSize = True
        Me.lbl_puesto.Location = New System.Drawing.Point(310, 67)
        Me.lbl_puesto.Name = "lbl_puesto"
        Me.lbl_puesto.Size = New System.Drawing.Size(45, 13)
        Me.lbl_puesto.TabIndex = 75
        Me.lbl_puesto.Text = "Label12"
        '
        'lbl_naci
        '
        Me.lbl_naci.AutoSize = True
        Me.lbl_naci.Location = New System.Drawing.Point(628, 16)
        Me.lbl_naci.Name = "lbl_naci"
        Me.lbl_naci.Size = New System.Drawing.Size(43, 13)
        Me.lbl_naci.TabIndex = 80
        Me.lbl_naci.Text = "lbl_naci"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(167, 16)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(45, 13)
        Me.lbl_nombre.TabIndex = 79
        Me.lbl_nombre.Text = "Label14"
        '
        'btn_baja
        '
        Me.btn_baja.Enabled = False
        Me.btn_baja.Location = New System.Drawing.Point(537, 152)
        Me.btn_baja.Name = "btn_baja"
        Me.btn_baja.Size = New System.Drawing.Size(75, 23)
        Me.btn_baja.TabIndex = 81
        Me.btn_baja.Text = "ACT"
        Me.btn_baja.UseVisualStyleBackColor = True
        '
        'btn_activar
        '
        Me.btn_activar.Enabled = False
        Me.btn_activar.Location = New System.Drawing.Point(654, 152)
        Me.btn_activar.Name = "btn_activar"
        Me.btn_activar.Size = New System.Drawing.Size(75, 23)
        Me.btn_activar.TabIndex = 82
        Me.btn_activar.Text = "ACT"
        Me.btn_activar.UseVisualStyleBackColor = True
        '
        'btn_cambiar_puesto
        '
        Me.btn_cambiar_puesto.Enabled = False
        Me.btn_cambiar_puesto.Location = New System.Drawing.Point(391, 89)
        Me.btn_cambiar_puesto.Name = "btn_cambiar_puesto"
        Me.btn_cambiar_puesto.Size = New System.Drawing.Size(119, 23)
        Me.btn_cambiar_puesto.TabIndex = 83
        Me.btn_cambiar_puesto.Text = "CAMBIAR PUESTO"
        Me.btn_cambiar_puesto.UseVisualStyleBackColor = True
        '
        'btn_cuenta
        '
        Me.btn_cuenta.Enabled = False
        Me.btn_cuenta.Location = New System.Drawing.Point(5, 123)
        Me.btn_cuenta.Name = "btn_cuenta"
        Me.btn_cuenta.Size = New System.Drawing.Size(75, 23)
        Me.btn_cuenta.TabIndex = 84
        Me.btn_cuenta.Text = "CUENTA"
        Me.btn_cuenta.UseVisualStyleBackColor = True
        '
        'op_activos
        '
        Me.op_activos.AutoSize = True
        Me.op_activos.BackColor = System.Drawing.Color.Transparent
        Me.op_activos.Checked = True
        Me.op_activos.CheckState = System.Windows.Forms.CheckState.Checked
        Me.op_activos.Location = New System.Drawing.Point(453, 28)
        Me.op_activos.Name = "op_activos"
        Me.op_activos.Size = New System.Drawing.Size(104, 17)
        Me.op_activos.TabIndex = 85
        Me.op_activos.Text = "SOLO ACTIVOS"
        Me.op_activos.UseVisualStyleBackColor = False
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(6, 16)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(41, 13)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "CLAVE"
        '
        'cmb_puesto
        '
        Me.cmb_puesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmb_puesto.FormattingEnabled = True
        Me.cmb_puesto.Items.AddRange(New Object() {"VENDEDOR", "SUPERVISOR", "PROMOTOR", "OFICINA", "COBRADOR", "CHOFER", "BODEG", "AYUDANTE", "BAJA"})
        Me.cmb_puesto.Location = New System.Drawing.Point(208, 91)
        Me.cmb_puesto.Name = "cmb_puesto"
        Me.cmb_puesto.Size = New System.Drawing.Size(118, 21)
        Me.cmb_puesto.TabIndex = 88
        '
        'dg_anteriores
        '
        Me.dg_anteriores.AllowUserToAddRows = False
        Me.dg_anteriores.AllowUserToDeleteRows = False
        Me.dg_anteriores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_anteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_anteriores.Location = New System.Drawing.Point(208, 118)
        Me.dg_anteriores.Name = "dg_anteriores"
        Me.dg_anteriores.ReadOnly = True
        Me.dg_anteriores.Size = New System.Drawing.Size(302, 67)
        Me.dg_anteriores.TabIndex = 89
        '
        'txt_sueldo
        '
        Me.txt_sueldo.Location = New System.Drawing.Point(332, 92)
        Me.txt_sueldo.Mask = "99999"
        Me.txt_sueldo.Name = "txt_sueldo"
        Me.txt_sueldo.Size = New System.Drawing.Size(53, 20)
        Me.txt_sueldo.TabIndex = 90
        '
        'grp_persona
        '
        Me.grp_persona.BackColor = System.Drawing.Color.Transparent
        Me.grp_persona.Controls.Add(Me.btn_modificar)
        Me.grp_persona.Controls.Add(Me.Label14)
        Me.grp_persona.Controls.Add(Me.txt_sueldo)
        Me.grp_persona.Controls.Add(Me.foto_cara)
        Me.grp_persona.Controls.Add(Me.dg_anteriores)
        Me.grp_persona.Controls.Add(Me.foto_completo)
        Me.grp_persona.Controls.Add(Me.cmb_puesto)
        Me.grp_persona.Controls.Add(Me.lbl_clave)
        Me.grp_persona.Controls.Add(Me.Label46)
        Me.grp_persona.Controls.Add(Me.Label47)
        Me.grp_persona.Controls.Add(Me.btn_cuenta)
        Me.grp_persona.Controls.Add(Me.Label1)
        Me.grp_persona.Controls.Add(Me.btn_cambiar_puesto)
        Me.grp_persona.Controls.Add(Me.Label2)
        Me.grp_persona.Controls.Add(Me.btn_activar)
        Me.grp_persona.Controls.Add(Me.Label3)
        Me.grp_persona.Controls.Add(Me.btn_baja)
        Me.grp_persona.Controls.Add(Me.Label5)
        Me.grp_persona.Controls.Add(Me.lbl_naci)
        Me.grp_persona.Controls.Add(Me.Label6)
        Me.grp_persona.Controls.Add(Me.lbl_nombre)
        Me.grp_persona.Controls.Add(Me.Label7)
        Me.grp_persona.Controls.Add(Me.lbl_sueldo)
        Me.grp_persona.Controls.Add(Me.lbl_telefono)
        Me.grp_persona.Controls.Add(Me.lbl_colonia)
        Me.grp_persona.Controls.Add(Me.lbl_calle)
        Me.grp_persona.Controls.Add(Me.lbl_puesto)
        Me.grp_persona.Controls.Add(Me.lbl_ciudad)
        Me.grp_persona.Location = New System.Drawing.Point(5, 204)
        Me.grp_persona.Name = "grp_persona"
        Me.grp_persona.Size = New System.Drawing.Size(767, 195)
        Me.grp_persona.TabIndex = 91
        Me.grp_persona.TabStop = False
        Me.grp_persona.Visible = False
        '
        'btn_modificar
        '
        Me.btn_modificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_modificar.Location = New System.Drawing.Point(86, 123)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(76, 61)
        Me.btn_modificar.TabIndex = 91
        Me.btn_modificar.Text = "MODIFICAR"
        Me.btn_modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_modificar.UseVisualStyleBackColor = True
        '
        'foto_cara
        '
        Me.foto_cara.Location = New System.Drawing.Point(537, 43)
        Me.foto_cara.Name = "foto_cara"
        Me.foto_cara.Size = New System.Drawing.Size(106, 103)
        Me.foto_cara.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto_cara.TabIndex = 56
        Me.foto_cara.TabStop = False
        '
        'foto_completo
        '
        Me.foto_completo.Location = New System.Drawing.Point(654, 43)
        Me.foto_completo.Name = "foto_completo"
        Me.foto_completo.Size = New System.Drawing.Size(106, 103)
        Me.foto_completo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.foto_completo.TabIndex = 57
        Me.foto_completo.TabStop = False
        '
        'bt_nuevo
        '
        Me.bt_nuevo.BackgroundImage = Global.Captura.My.Resources.Resources.Agregar_mor
        Me.bt_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_nuevo.Location = New System.Drawing.Point(303, 12)
        Me.bt_nuevo.Name = "bt_nuevo"
        Me.bt_nuevo.Size = New System.Drawing.Size(84, 59)
        Me.bt_nuevo.TabIndex = 5
        Me.bt_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_nuevo.UseVisualStyleBackColor = True
        '
        'opcion_Personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(784, 411)
        Me.Controls.Add(Me.grp_persona)
        Me.Controls.Add(Me.op_activos)
        Me.Controls.Add(Me.bt_nuevo)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label31)
        Me.Controls.Add(Me.dtpersonal)
        Me.Name = "opcion_Personal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PERSONAL "
        CType(Me.dtpersonal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_anteriores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_persona.ResumeLayout(False)
        Me.grp_persona.PerformLayout()
        CType(Me.foto_cara, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.foto_completo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpersonal As DataGridView
    Friend WithEvents Label31 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents busca_imagen As OpenFileDialog
    Friend WithEvents bt_nuevo As Button
    Friend WithEvents foto_completo As PictureBox
    Friend WithEvents foto_cara As PictureBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label47 As Label
    Friend WithEvents Label46 As Label
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_telefono As Label
    Friend WithEvents lbl_calle As Label
    Friend WithEvents lbl_ciudad As Label
    Friend WithEvents lbl_sueldo As Label
    Friend WithEvents lbl_colonia As Label
    Friend WithEvents lbl_puesto As Label
    Friend WithEvents lbl_naci As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents btn_baja As Button
    Friend WithEvents btn_activar As Button
    Friend WithEvents btn_cambiar_puesto As Button
    Friend WithEvents btn_cuenta As Button
    Friend WithEvents op_activos As CheckBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cmb_puesto As ComboBox
    Friend WithEvents dg_anteriores As DataGridView
    Friend WithEvents txt_sueldo As MaskedTextBox
    Friend WithEvents grp_persona As GroupBox
    Friend WithEvents btn_modificar As Button
End Class
