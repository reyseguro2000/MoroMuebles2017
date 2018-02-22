<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class lista_tarjetas_pva
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.dg_atrazadas = New System.Windows.Forms.DataGridView()
        Me.cnuevasl2 = New System.Windows.Forms.PictureBox()
        Me.curgentes = New System.Windows.Forms.PictureBox()
        Me.clista2 = New System.Windows.Forms.PictureBox()
        Me.cbaja = New System.Windows.Forms.PictureBox()
        Me.csube = New System.Windows.Forms.PictureBox()
        Me.btn_atrazadas = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.opc_sin = New System.Windows.Forms.RadioButton()
        Me.opc_vencidas = New System.Windows.Forms.RadioButton()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_semanal = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_quincenal = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_mensual = New System.Windows.Forms.NumericUpDown()
        Me.lbl_supervisor = New System.Windows.Forms.Label()
        Me.lbl_cobrador = New System.Windows.Forms.Label()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbl_total_ventas = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        CType(Me.dg_atrazadas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cnuevasl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.curgentes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.clista2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cbaja, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.csube, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_semanal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_quincenal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txt_mensual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(502, 30)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 13)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Bajo el atraso"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(502, 6)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 13)
        Me.Label12.TabIndex = 40
        Me.Label12.Text = "Subio el atraso"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(608, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 13)
        Me.Label10.TabIndex = 46
        Me.Label10.Text = "Lista 2"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(608, 6)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 44
        Me.Label9.Text = "Urgentes"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(608, 53)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(38, 13)
        Me.Label14.TabIndex = 48
        Me.Label14.Text = "Lista 1"
        '
        'dg_atrazadas
        '
        Me.dg_atrazadas.AllowUserToAddRows = False
        Me.dg_atrazadas.AllowUserToDeleteRows = False
        Me.dg_atrazadas.AllowUserToOrderColumns = True
        Me.dg_atrazadas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_atrazadas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_atrazadas.Location = New System.Drawing.Point(12, 120)
        Me.dg_atrazadas.Name = "dg_atrazadas"
        Me.dg_atrazadas.ReadOnly = True
        Me.dg_atrazadas.Size = New System.Drawing.Size(660, 513)
        Me.dg_atrazadas.TabIndex = 49
        '
        'cnuevasl2
        '
        Me.cnuevasl2.BackColor = System.Drawing.Color.GreenYellow
        Me.cnuevasl2.Location = New System.Drawing.Point(586, 53)
        Me.cnuevasl2.Name = "cnuevasl2"
        Me.cnuevasl2.Size = New System.Drawing.Size(16, 17)
        Me.cnuevasl2.TabIndex = 47
        Me.cnuevasl2.TabStop = False
        '
        'curgentes
        '
        Me.curgentes.BackColor = System.Drawing.Color.CornflowerBlue
        Me.curgentes.Location = New System.Drawing.Point(586, 6)
        Me.curgentes.Name = "curgentes"
        Me.curgentes.Size = New System.Drawing.Size(16, 17)
        Me.curgentes.TabIndex = 45
        Me.curgentes.TabStop = False
        '
        'clista2
        '
        Me.clista2.BackColor = System.Drawing.Color.Gold
        Me.clista2.Location = New System.Drawing.Point(586, 30)
        Me.clista2.Name = "clista2"
        Me.clista2.Size = New System.Drawing.Size(16, 17)
        Me.clista2.TabIndex = 43
        Me.clista2.TabStop = False
        '
        'cbaja
        '
        Me.cbaja.BackColor = System.Drawing.Color.Coral
        Me.cbaja.Location = New System.Drawing.Point(480, 30)
        Me.cbaja.Name = "cbaja"
        Me.cbaja.Size = New System.Drawing.Size(16, 17)
        Me.cbaja.TabIndex = 41
        Me.cbaja.TabStop = False
        '
        'csube
        '
        Me.csube.BackColor = System.Drawing.Color.Violet
        Me.csube.Location = New System.Drawing.Point(480, 6)
        Me.csube.Name = "csube"
        Me.csube.Size = New System.Drawing.Size(16, 17)
        Me.csube.TabIndex = 39
        Me.csube.TabStop = False
        '
        'btn_atrazadas
        '
        Me.btn_atrazadas.BackgroundImage = Global.Captura.My.Resources.Resources.busqueda
        Me.btn_atrazadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_atrazadas.Location = New System.Drawing.Point(508, 59)
        Me.btn_atrazadas.Name = "btn_atrazadas"
        Me.btn_atrazadas.Size = New System.Drawing.Size(65, 50)
        Me.btn_atrazadas.TabIndex = 50
        Me.btn_atrazadas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_atrazadas.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "COBRADOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 52
        Me.Label2.Text = "SUPERVISOR"
        '
        'opc_sin
        '
        Me.opc_sin.AutoSize = True
        Me.opc_sin.Checked = True
        Me.opc_sin.Location = New System.Drawing.Point(391, 71)
        Me.opc_sin.Name = "opc_sin"
        Me.opc_sin.Size = New System.Drawing.Size(90, 17)
        Me.opc_sin.TabIndex = 53
        Me.opc_sin.TabStop = True
        Me.opc_sin.Text = "SIN VENCER"
        Me.opc_sin.UseVisualStyleBackColor = True
        '
        'opc_vencidas
        '
        Me.opc_vencidas.AutoSize = True
        Me.opc_vencidas.Location = New System.Drawing.Point(391, 94)
        Me.opc_vencidas.Name = "opc_vencidas"
        Me.opc_vencidas.Size = New System.Drawing.Size(62, 17)
        Me.opc_vencidas.TabIndex = 54
        Me.opc_vencidas.Text = "TODAS"
        Me.opc_vencidas.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(99, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(58, 13)
        Me.Label6.TabIndex = 55
        Me.Label6.Text = "SEMANAL"
        '
        'txt_semanal
        '
        Me.txt_semanal.Location = New System.Drawing.Point(102, 89)
        Me.txt_semanal.Name = "txt_semanal"
        Me.txt_semanal.Size = New System.Drawing.Size(35, 20)
        Me.txt_semanal.TabIndex = 56
        Me.txt_semanal.Value = New Decimal(New Integer() {4, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(177, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(69, 13)
        Me.Label3.TabIndex = 57
        Me.Label3.Text = "QUINCENAL"
        '
        'txt_quincenal
        '
        Me.txt_quincenal.Location = New System.Drawing.Point(180, 89)
        Me.txt_quincenal.Name = "txt_quincenal"
        Me.txt_quincenal.Size = New System.Drawing.Size(35, 20)
        Me.txt_quincenal.TabIndex = 58
        Me.txt_quincenal.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(264, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 13)
        Me.Label4.TabIndex = 59
        Me.Label4.Text = "MENSUAL"
        '
        'txt_mensual
        '
        Me.txt_mensual.Location = New System.Drawing.Point(267, 89)
        Me.txt_mensual.Name = "txt_mensual"
        Me.txt_mensual.Size = New System.Drawing.Size(35, 20)
        Me.txt_mensual.TabIndex = 60
        Me.txt_mensual.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'lbl_supervisor
        '
        Me.lbl_supervisor.AutoSize = True
        Me.lbl_supervisor.Location = New System.Drawing.Point(98, 48)
        Me.lbl_supervisor.Name = "lbl_supervisor"
        Me.lbl_supervisor.Size = New System.Drawing.Size(77, 13)
        Me.lbl_supervisor.TabIndex = 62
        Me.lbl_supervisor.Text = "SUPERVISOR"
        '
        'lbl_cobrador
        '
        Me.lbl_cobrador.AutoSize = True
        Me.lbl_cobrador.Location = New System.Drawing.Point(98, 25)
        Me.lbl_cobrador.Name = "lbl_cobrador"
        Me.lbl_cobrador.Size = New System.Drawing.Size(68, 13)
        Me.lbl_cobrador.TabIndex = 61
        Me.lbl_cobrador.Text = "COBRADOR"
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoSize = True
        Me.lbl_ruta.Location = New System.Drawing.Point(98, 6)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(68, 13)
        Me.lbl_ruta.TabIndex = 64
        Me.lbl_ruta.Text = "COBRADOR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 6)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 63
        Me.Label11.Text = "RUTA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(9, 73)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "TOLERANCIA"
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(94, 261)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(387, 23)
        Me.ProgressBar1.TabIndex = 66
        Me.ProgressBar1.Visible = False
        '
        'lbl_total_ventas
        '
        Me.lbl_total_ventas.AutoSize = True
        Me.lbl_total_ventas.Location = New System.Drawing.Point(12, 104)
        Me.lbl_total_ventas.Name = "lbl_total_ventas"
        Me.lbl_total_ventas.Size = New System.Drawing.Size(13, 13)
        Me.lbl_total_ventas.TabIndex = 67
        Me.lbl_total_ventas.Text = "0"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(128, 499)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(324, 150)
        Me.DataGridView1.TabIndex = 68
        Me.DataGridView1.Visible = False
        '
        'lista_tarjetas_pva
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(684, 661)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.lbl_total_ventas)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_supervisor)
        Me.Controls.Add(Me.lbl_cobrador)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_mensual)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_quincenal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txt_semanal)
        Me.Controls.Add(Me.opc_vencidas)
        Me.Controls.Add(Me.opc_sin)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_atrazadas)
        Me.Controls.Add(Me.dg_atrazadas)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.cnuevasl2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.curgentes)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.clista2)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cbaja)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.csube)
        Me.Name = "lista_tarjetas_pva"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CUENTAS ATRAZADAS"
        CType(Me.dg_atrazadas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cnuevasl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.curgentes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.clista2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cbaja, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.csube, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_semanal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_quincenal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txt_mensual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents cbaja As PictureBox
    Friend WithEvents Label12 As Label
    Friend WithEvents csube As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents curgentes As PictureBox
    Friend WithEvents Label9 As Label
    Friend WithEvents clista2 As PictureBox
    Friend WithEvents Label14 As Label
    Friend WithEvents cnuevasl2 As PictureBox
    Friend WithEvents dg_atrazadas As DataGridView
    Friend WithEvents btn_atrazadas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents opc_sin As RadioButton
    Friend WithEvents opc_vencidas As RadioButton
    Friend WithEvents Label6 As Label
    Friend WithEvents txt_semanal As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_quincenal As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents txt_mensual As NumericUpDown
    Friend WithEvents lbl_supervisor As Label
    Friend WithEvents lbl_cobrador As Label
    Friend WithEvents lbl_ruta As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents lbl_total_ventas As Label
    Friend WithEvents DataGridView1 As DataGridView
End Class
