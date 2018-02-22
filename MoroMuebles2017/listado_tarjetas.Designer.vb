<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listado_tarjetas
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
        Me.lbl_faltantes = New System.Windows.Forms.Label()
        Me.Tablitas = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dg_faltantes = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dg_sobrantes = New System.Windows.Forms.DataGridView()
        Me.cliente_sob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta_sob = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.dg_diferencia = New System.Windows.Forms.DataGridView()
        Me.cliente_dif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.venta_dif = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo_m = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.saldo_t = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lbl_sobrantes = New System.Windows.Forms.Label()
        Me.lbl_total = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_imprimir_reporte = New System.Windows.Forms.Button()
        Me.btn_imprimir_faltantes = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_venta = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.lbl_saldo = New System.Windows.Forms.Label()
        Me.bt_correcto = New System.Windows.Forms.Button()
        Me.btn_diferencia = New System.Windows.Forms.Button()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.grp_venta = New System.Windows.Forms.GroupBox()
        Me.lbl_diferencia = New System.Windows.Forms.Label()
        Me.lbl_correcto = New System.Windows.Forms.Label()
        Me.Printtarjeta = New System.Drawing.Printing.PrintDocument()
        Me.PrinttarjetaChica = New System.Drawing.Printing.PrintDocument()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.lbl_supervisor = New System.Windows.Forms.Label()
        Me.lbl_cobrador = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Tablitas.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg_faltantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dg_sobrantes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.dg_diferencia, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_venta.SuspendLayout()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_faltantes
        '
        Me.lbl_faltantes.AutoSize = True
        Me.lbl_faltantes.Location = New System.Drawing.Point(9, 46)
        Me.lbl_faltantes.Name = "lbl_faltantes"
        Me.lbl_faltantes.Size = New System.Drawing.Size(39, 13)
        Me.lbl_faltantes.TabIndex = 8
        Me.lbl_faltantes.Text = "Label4"
        '
        'Tablitas
        '
        Me.Tablitas.Controls.Add(Me.TabPage1)
        Me.Tablitas.Controls.Add(Me.TabPage2)
        Me.Tablitas.Controls.Add(Me.TabPage3)
        Me.Tablitas.Location = New System.Drawing.Point(12, 70)
        Me.Tablitas.Name = "Tablitas"
        Me.Tablitas.SelectedIndex = 0
        Me.Tablitas.Size = New System.Drawing.Size(597, 374)
        Me.Tablitas.TabIndex = 9
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dg_faltantes)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(589, 348)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "FALTANTES"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dg_faltantes
        '
        Me.dg_faltantes.AllowUserToAddRows = False
        Me.dg_faltantes.AllowUserToDeleteRows = False
        Me.dg_faltantes.AllowUserToOrderColumns = True
        Me.dg_faltantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_faltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_faltantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_faltantes.Location = New System.Drawing.Point(3, 3)
        Me.dg_faltantes.Name = "dg_faltantes"
        Me.dg_faltantes.ReadOnly = True
        Me.dg_faltantes.Size = New System.Drawing.Size(583, 342)
        Me.dg_faltantes.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dg_sobrantes)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(589, 308)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "SOBRANTES"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dg_sobrantes
        '
        Me.dg_sobrantes.AllowUserToAddRows = False
        Me.dg_sobrantes.AllowUserToDeleteRows = False
        Me.dg_sobrantes.AllowUserToOrderColumns = True
        Me.dg_sobrantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_sobrantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_sobrantes.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliente_sob, Me.venta_sob})
        Me.dg_sobrantes.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_sobrantes.Location = New System.Drawing.Point(3, 3)
        Me.dg_sobrantes.Name = "dg_sobrantes"
        Me.dg_sobrantes.ReadOnly = True
        Me.dg_sobrantes.Size = New System.Drawing.Size(583, 302)
        Me.dg_sobrantes.TabIndex = 1
        '
        'cliente_sob
        '
        Me.cliente_sob.HeaderText = "Cliente"
        Me.cliente_sob.Name = "cliente_sob"
        Me.cliente_sob.ReadOnly = True
        Me.cliente_sob.Width = 64
        '
        'venta_sob
        '
        Me.venta_sob.HeaderText = "Venta"
        Me.venta_sob.Name = "venta_sob"
        Me.venta_sob.ReadOnly = True
        Me.venta_sob.Width = 60
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.dg_diferencia)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(589, 308)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "DIFERENCIA"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'dg_diferencia
        '
        Me.dg_diferencia.AllowUserToAddRows = False
        Me.dg_diferencia.AllowUserToDeleteRows = False
        Me.dg_diferencia.AllowUserToOrderColumns = True
        Me.dg_diferencia.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_diferencia.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_diferencia.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.cliente_dif, Me.venta_dif, Me.saldo_m, Me.saldo_t})
        Me.dg_diferencia.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dg_diferencia.Location = New System.Drawing.Point(3, 3)
        Me.dg_diferencia.Name = "dg_diferencia"
        Me.dg_diferencia.ReadOnly = True
        Me.dg_diferencia.Size = New System.Drawing.Size(583, 302)
        Me.dg_diferencia.TabIndex = 2
        '
        'cliente_dif
        '
        Me.cliente_dif.HeaderText = "Cliente"
        Me.cliente_dif.Name = "cliente_dif"
        Me.cliente_dif.ReadOnly = True
        Me.cliente_dif.Width = 64
        '
        'venta_dif
        '
        Me.venta_dif.HeaderText = "Venta"
        Me.venta_dif.Name = "venta_dif"
        Me.venta_dif.ReadOnly = True
        Me.venta_dif.Width = 60
        '
        'saldo_m
        '
        Me.saldo_m.HeaderText = "Maquina"
        Me.saldo_m.Name = "saldo_m"
        Me.saldo_m.ReadOnly = True
        Me.saldo_m.Width = 73
        '
        'saldo_t
        '
        Me.saldo_t.HeaderText = "Tarjeta"
        Me.saldo_t.Name = "saldo_t"
        Me.saldo_t.ReadOnly = True
        Me.saldo_t.Width = 65
        '
        'lbl_sobrantes
        '
        Me.lbl_sobrantes.AutoSize = True
        Me.lbl_sobrantes.Location = New System.Drawing.Point(100, 49)
        Me.lbl_sobrantes.Name = "lbl_sobrantes"
        Me.lbl_sobrantes.Size = New System.Drawing.Size(39, 13)
        Me.lbl_sobrantes.TabIndex = 10
        Me.lbl_sobrantes.Text = "Label4"
        '
        'lbl_total
        '
        Me.lbl_total.AutoSize = True
        Me.lbl_total.Location = New System.Drawing.Point(253, 51)
        Me.lbl_total.Name = "lbl_total"
        Me.lbl_total.Size = New System.Drawing.Size(39, 13)
        Me.lbl_total.TabIndex = 11
        Me.lbl_total.Text = "Label4"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(190, 49)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(42, 13)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "TOTAL"
        '
        'btn_imprimir_reporte
        '
        Me.btn_imprimir_reporte.Location = New System.Drawing.Point(410, 16)
        Me.btn_imprimir_reporte.Name = "btn_imprimir_reporte"
        Me.btn_imprimir_reporte.Size = New System.Drawing.Size(75, 37)
        Me.btn_imprimir_reporte.TabIndex = 13
        Me.btn_imprimir_reporte.Text = "IMPRIMIR REPORTE"
        Me.btn_imprimir_reporte.UseVisualStyleBackColor = True
        '
        'btn_imprimir_faltantes
        '
        Me.btn_imprimir_faltantes.Enabled = False
        Me.btn_imprimir_faltantes.Location = New System.Drawing.Point(509, 16)
        Me.btn_imprimir_faltantes.Name = "btn_imprimir_faltantes"
        Me.btn_imprimir_faltantes.Size = New System.Drawing.Size(81, 37)
        Me.btn_imprimir_faltantes.TabIndex = 14
        Me.btn_imprimir_faltantes.Text = "IMPRIMIR FALTANTES"
        Me.btn_imprimir_faltantes.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "VENTA"
        '
        'txt_venta
        '
        Me.txt_venta.Location = New System.Drawing.Point(62, 16)
        Me.txt_venta.Mask = "9999999"
        Me.txt_venta.Name = "txt_venta"
        Me.txt_venta.Size = New System.Drawing.Size(54, 20)
        Me.txt_venta.TabIndex = 16
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.Location = New System.Drawing.Point(122, 23)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(38, 13)
        Me.lbl_cliente.TabIndex = 17
        Me.lbl_cliente.Text = "cliente"
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.Location = New System.Drawing.Point(339, 23)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(32, 13)
        Me.lbl_saldo.TabIndex = 18
        Me.lbl_saldo.Text = "saldo"
        '
        'bt_correcto
        '
        Me.bt_correcto.Enabled = False
        Me.bt_correcto.Location = New System.Drawing.Point(342, 41)
        Me.bt_correcto.Name = "bt_correcto"
        Me.bt_correcto.Size = New System.Drawing.Size(75, 23)
        Me.bt_correcto.TabIndex = 19
        Me.bt_correcto.Text = "CORRECTO"
        Me.bt_correcto.UseVisualStyleBackColor = True
        '
        'btn_diferencia
        '
        Me.btn_diferencia.Enabled = False
        Me.btn_diferencia.Location = New System.Drawing.Point(473, 41)
        Me.btn_diferencia.Name = "btn_diferencia"
        Me.btn_diferencia.Size = New System.Drawing.Size(84, 23)
        Me.btn_diferencia.TabIndex = 20
        Me.btn_diferencia.Text = "DIFERENCIA"
        Me.btn_diferencia.UseVisualStyleBackColor = True
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(169, 23)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nombre.TabIndex = 21
        Me.lbl_nombre.Text = "Label6"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'grp_venta
        '
        Me.grp_venta.Controls.Add(Me.lbl_diferencia)
        Me.grp_venta.Controls.Add(Me.lbl_correcto)
        Me.grp_venta.Controls.Add(Me.Label5)
        Me.grp_venta.Controls.Add(Me.lbl_nombre)
        Me.grp_venta.Controls.Add(Me.lbl_faltantes)
        Me.grp_venta.Controls.Add(Me.btn_diferencia)
        Me.grp_venta.Controls.Add(Me.lbl_sobrantes)
        Me.grp_venta.Controls.Add(Me.Tablitas)
        Me.grp_venta.Controls.Add(Me.bt_correcto)
        Me.grp_venta.Controls.Add(Me.lbl_total)
        Me.grp_venta.Controls.Add(Me.lbl_saldo)
        Me.grp_venta.Controls.Add(Me.Label4)
        Me.grp_venta.Controls.Add(Me.lbl_cliente)
        Me.grp_venta.Controls.Add(Me.txt_venta)
        Me.grp_venta.Location = New System.Drawing.Point(12, 67)
        Me.grp_venta.Name = "grp_venta"
        Me.grp_venta.Size = New System.Drawing.Size(615, 461)
        Me.grp_venta.TabIndex = 1
        Me.grp_venta.TabStop = False
        Me.grp_venta.Text = "VENTA"
        '
        'lbl_diferencia
        '
        Me.lbl_diferencia.AutoSize = True
        Me.lbl_diferencia.Location = New System.Drawing.Point(559, 54)
        Me.lbl_diferencia.Name = "lbl_diferencia"
        Me.lbl_diferencia.Size = New System.Drawing.Size(42, 13)
        Me.lbl_diferencia.TabIndex = 23
        Me.lbl_diferencia.Text = "cont dif"
        '
        'lbl_correcto
        '
        Me.lbl_correcto.AutoSize = True
        Me.lbl_correcto.Location = New System.Drawing.Point(420, 54)
        Me.lbl_correcto.Name = "lbl_correcto"
        Me.lbl_correcto.Size = New System.Drawing.Size(43, 13)
        Me.lbl_correcto.TabIndex = 22
        Me.lbl_correcto.Text = "con cor"
        '
        'Printtarjeta
        '
        '
        'PrinttarjetaChica
        '
        '
        'dg_articulos
        '
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Location = New System.Drawing.Point(435, 491)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.Size = New System.Drawing.Size(161, 44)
        Me.dg_articulos.TabIndex = 17
        Me.dg_articulos.Visible = False
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoSize = True
        Me.lbl_ruta.Location = New System.Drawing.Point(98, 9)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(68, 13)
        Me.lbl_ruta.TabIndex = 70
        Me.lbl_ruta.Text = "COBRADOR"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(12, 9)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(37, 13)
        Me.Label11.TabIndex = 69
        Me.Label11.Text = "RUTA"
        '
        'lbl_supervisor
        '
        Me.lbl_supervisor.AutoSize = True
        Me.lbl_supervisor.Location = New System.Drawing.Point(98, 51)
        Me.lbl_supervisor.Name = "lbl_supervisor"
        Me.lbl_supervisor.Size = New System.Drawing.Size(77, 13)
        Me.lbl_supervisor.TabIndex = 68
        Me.lbl_supervisor.Text = "SUPERVISOR"
        '
        'lbl_cobrador
        '
        Me.lbl_cobrador.AutoSize = True
        Me.lbl_cobrador.Location = New System.Drawing.Point(98, 28)
        Me.lbl_cobrador.Name = "lbl_cobrador"
        Me.lbl_cobrador.Size = New System.Drawing.Size(68, 13)
        Me.lbl_cobrador.TabIndex = 67
        Me.lbl_cobrador.Text = "COBRADOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 13)
        Me.Label2.TabIndex = 66
        Me.Label2.Text = "SUPERVISOR"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 65
        Me.Label1.Text = "COBRADOR"
        '
        'listado_tarjetas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(639, 540)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.lbl_supervisor)
        Me.Controls.Add(Me.lbl_cobrador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_imprimir_faltantes)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.grp_venta)
        Me.Controls.Add(Me.btn_imprimir_reporte)
        Me.Name = "listado_tarjetas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TARJETAS"
        Me.Tablitas.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dg_faltantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dg_sobrantes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.dg_diferencia, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_venta.ResumeLayout(False)
        Me.grp_venta.PerformLayout()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_faltantes As Label
    Friend WithEvents Tablitas As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dg_faltantes As DataGridView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dg_sobrantes As DataGridView
    Friend WithEvents lbl_sobrantes As Label
    Friend WithEvents lbl_total As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_imprimir_reporte As Button
    Friend WithEvents btn_imprimir_faltantes As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_venta As MaskedTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents dg_diferencia As DataGridView
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents lbl_saldo As Label
    Friend WithEvents bt_correcto As Button
    Friend WithEvents btn_diferencia As Button
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents grp_venta As GroupBox
    Friend WithEvents Printtarjeta As Printing.PrintDocument
    Friend WithEvents PrinttarjetaChica As Printing.PrintDocument
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents cliente_sob As DataGridViewTextBoxColumn
    Friend WithEvents venta_sob As DataGridViewTextBoxColumn
    Friend WithEvents cliente_dif As DataGridViewTextBoxColumn
    Friend WithEvents venta_dif As DataGridViewTextBoxColumn
    Friend WithEvents saldo_m As DataGridViewTextBoxColumn
    Friend WithEvents saldo_t As DataGridViewTextBoxColumn
    Friend WithEvents lbl_diferencia As Label
    Friend WithEvents lbl_correcto As Label
    Friend WithEvents lbl_ruta As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents lbl_supervisor As Label
    Friend WithEvents lbl_cobrador As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
