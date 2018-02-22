<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcion_Pagos
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
        Me.btn_cobro_terminal = New System.Windows.Forms.Button()
        Me.btn_cobro_manual = New System.Windows.Forms.Button()
        Me.dg_rutas = New System.Windows.Forms.DataGridView()
        Me.btn_agregar = New System.Windows.Forms.Button()
        Me.btn_super_terminal = New System.Windows.Forms.Button()
        Me.btn_super_listado = New System.Windows.Forms.Button()
        Me.btn_cobro_cambio = New System.Windows.Forms.Button()
        Me.btn_super_cambio = New System.Windows.Forms.Button()
        Me.grp_cobrador = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_inventario_t = New System.Windows.Forms.Button()
        Me.grp_supervisor = New System.Windows.Forms.GroupBox()
        Me.btn_atrazadas = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.grp_rango = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_inicio = New System.Windows.Forms.MaskedTextBox()
        Me.txt_fin = New System.Windows.Forms.MaskedTextBox()
        Me.btn_imprimir_rango = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.Printtarjeta = New System.Drawing.Printing.PrintDocument()
        Me.PrinttarjetaChica = New System.Drawing.Printing.PrintDocument()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.dg_faltantes = New System.Windows.Forms.DataGridView()
        Me.dg_supervisor = New System.Windows.Forms.DataGridView()
        CType(Me.dg_rutas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grp_cobrador.SuspendLayout()
        Me.grp_supervisor.SuspendLayout()
        Me.grp_rango.SuspendLayout()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_faltantes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_supervisor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(140, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECCIONA UNA OPCIÓN"
        '
        'btn_cobro_terminal
        '
        Me.btn_cobro_terminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cobro_terminal.Location = New System.Drawing.Point(104, 19)
        Me.btn_cobro_terminal.Name = "btn_cobro_terminal"
        Me.btn_cobro_terminal.Size = New System.Drawing.Size(107, 50)
        Me.btn_cobro_terminal.TabIndex = 4
        Me.btn_cobro_terminal.Text = "TERMINAL"
        Me.btn_cobro_terminal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cobro_terminal.UseVisualStyleBackColor = True
        '
        'btn_cobro_manual
        '
        Me.btn_cobro_manual.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cobro_manual.Location = New System.Drawing.Point(6, 19)
        Me.btn_cobro_manual.Name = "btn_cobro_manual"
        Me.btn_cobro_manual.Size = New System.Drawing.Size(88, 50)
        Me.btn_cobro_manual.TabIndex = 3
        Me.btn_cobro_manual.Text = "MANUAL"
        Me.btn_cobro_manual.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_cobro_manual.UseVisualStyleBackColor = True
        '
        'dg_rutas
        '
        Me.dg_rutas.AllowUserToAddRows = False
        Me.dg_rutas.AllowUserToDeleteRows = False
        Me.dg_rutas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_rutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_rutas.Location = New System.Drawing.Point(12, 61)
        Me.dg_rutas.Name = "dg_rutas"
        Me.dg_rutas.ReadOnly = True
        Me.dg_rutas.Size = New System.Drawing.Size(224, 150)
        Me.dg_rutas.TabIndex = 6
        '
        'btn_agregar
        '
        Me.btn_agregar.Location = New System.Drawing.Point(384, 23)
        Me.btn_agregar.Name = "btn_agregar"
        Me.btn_agregar.Size = New System.Drawing.Size(75, 23)
        Me.btn_agregar.TabIndex = 7
        Me.btn_agregar.Text = "Agregar"
        Me.btn_agregar.UseVisualStyleBackColor = True
        '
        'btn_super_terminal
        '
        Me.btn_super_terminal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_super_terminal.Location = New System.Drawing.Point(117, 19)
        Me.btn_super_terminal.Name = "btn_super_terminal"
        Me.btn_super_terminal.Size = New System.Drawing.Size(107, 50)
        Me.btn_super_terminal.TabIndex = 9
        Me.btn_super_terminal.Text = "TERMINAL"
        Me.btn_super_terminal.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_super_terminal.UseVisualStyleBackColor = True
        '
        'btn_super_listado
        '
        Me.btn_super_listado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_super_listado.Location = New System.Drawing.Point(9, 19)
        Me.btn_super_listado.Name = "btn_super_listado"
        Me.btn_super_listado.Size = New System.Drawing.Size(101, 50)
        Me.btn_super_listado.TabIndex = 8
        Me.btn_super_listado.Text = "LISTADOS"
        Me.btn_super_listado.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_super_listado.UseVisualStyleBackColor = True
        '
        'btn_cobro_cambio
        '
        Me.btn_cobro_cambio.Location = New System.Drawing.Point(6, 122)
        Me.btn_cobro_cambio.Name = "btn_cobro_cambio"
        Me.btn_cobro_cambio.Size = New System.Drawing.Size(75, 23)
        Me.btn_cobro_cambio.TabIndex = 10
        Me.btn_cobro_cambio.Text = "CAMBIAR"
        Me.btn_cobro_cambio.UseVisualStyleBackColor = True
        '
        'btn_super_cambio
        '
        Me.btn_super_cambio.Location = New System.Drawing.Point(9, 122)
        Me.btn_super_cambio.Name = "btn_super_cambio"
        Me.btn_super_cambio.Size = New System.Drawing.Size(75, 23)
        Me.btn_super_cambio.TabIndex = 11
        Me.btn_super_cambio.Text = "CAMBIAR"
        Me.btn_super_cambio.UseVisualStyleBackColor = True
        '
        'grp_cobrador
        '
        Me.grp_cobrador.Controls.Add(Me.Label5)
        Me.grp_cobrador.Controls.Add(Me.Label4)
        Me.grp_cobrador.Controls.Add(Me.btn_inventario_t)
        Me.grp_cobrador.Controls.Add(Me.btn_cobro_cambio)
        Me.grp_cobrador.Controls.Add(Me.btn_cobro_terminal)
        Me.grp_cobrador.Controls.Add(Me.btn_cobro_manual)
        Me.grp_cobrador.Location = New System.Drawing.Point(12, 232)
        Me.grp_cobrador.Name = "grp_cobrador"
        Me.grp_cobrador.Size = New System.Drawing.Size(224, 151)
        Me.grp_cobrador.TabIndex = 12
        Me.grp_cobrador.TabStop = False
        Me.grp_cobrador.Text = "COBRADOR"
        Me.grp_cobrador.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(120, 76)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "ACT TERMINAL"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(77, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "REC MANUAL"
        '
        'btn_inventario_t
        '
        Me.btn_inventario_t.BackgroundImage = Global.Captura.My.Resources.Resources.verificar
        Me.btn_inventario_t.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_inventario_t.Location = New System.Drawing.Point(123, 92)
        Me.btn_inventario_t.Name = "btn_inventario_t"
        Me.btn_inventario_t.Size = New System.Drawing.Size(65, 50)
        Me.btn_inventario_t.TabIndex = 2
        Me.btn_inventario_t.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_inventario_t.UseVisualStyleBackColor = True
        '
        'grp_supervisor
        '
        Me.grp_supervisor.Controls.Add(Me.btn_atrazadas)
        Me.grp_supervisor.Controls.Add(Me.Label7)
        Me.grp_supervisor.Controls.Add(Me.Label6)
        Me.grp_supervisor.Controls.Add(Me.btn_super_cambio)
        Me.grp_supervisor.Controls.Add(Me.btn_super_terminal)
        Me.grp_supervisor.Controls.Add(Me.btn_super_listado)
        Me.grp_supervisor.Location = New System.Drawing.Point(242, 232)
        Me.grp_supervisor.Name = "grp_supervisor"
        Me.grp_supervisor.Size = New System.Drawing.Size(230, 151)
        Me.grp_supervisor.TabIndex = 13
        Me.grp_supervisor.TabStop = False
        Me.grp_supervisor.Text = "SUPERVISOR"
        Me.grp_supervisor.Visible = False
        '
        'btn_atrazadas
        '
        Me.btn_atrazadas.BackgroundImage = Global.Captura.My.Resources.Resources.Lista_supervisor
        Me.btn_atrazadas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_atrazadas.Location = New System.Drawing.Point(134, 92)
        Me.btn_atrazadas.Name = "btn_atrazadas"
        Me.btn_atrazadas.Size = New System.Drawing.Size(65, 50)
        Me.btn_atrazadas.TabIndex = 15
        Me.btn_atrazadas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_atrazadas.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(16, 76)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(82, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "IMP LISTADOS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(131, 76)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "ACT TERMINAL"
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoSize = True
        Me.lbl_ruta.Location = New System.Drawing.Point(17, 215)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(10, 13)
        Me.lbl_ruta.TabIndex = 14
        Me.lbl_ruta.Text = "r"
        '
        'grp_rango
        '
        Me.grp_rango.Controls.Add(Me.Label2)
        Me.grp_rango.Controls.Add(Me.Label3)
        Me.grp_rango.Controls.Add(Me.txt_inicio)
        Me.grp_rango.Controls.Add(Me.txt_fin)
        Me.grp_rango.Controls.Add(Me.btn_imprimir_rango)
        Me.grp_rango.Location = New System.Drawing.Point(135, 389)
        Me.grp_rango.Name = "grp_rango"
        Me.grp_rango.Size = New System.Drawing.Size(209, 64)
        Me.grp_rango.TabIndex = 17
        Me.grp_rango.TabStop = False
        Me.grp_rango.Text = "RANGO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "INICIO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(24, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FIN"
        '
        'txt_inicio
        '
        Me.txt_inicio.Location = New System.Drawing.Point(51, 12)
        Me.txt_inicio.Mask = "9999999"
        Me.txt_inicio.Name = "txt_inicio"
        Me.txt_inicio.Size = New System.Drawing.Size(59, 20)
        Me.txt_inicio.TabIndex = 5
        '
        'txt_fin
        '
        Me.txt_fin.Location = New System.Drawing.Point(51, 37)
        Me.txt_fin.Mask = "9999999"
        Me.txt_fin.Name = "txt_fin"
        Me.txt_fin.Size = New System.Drawing.Size(59, 20)
        Me.txt_fin.TabIndex = 6
        '
        'btn_imprimir_rango
        '
        Me.btn_imprimir_rango.Enabled = False
        Me.btn_imprimir_rango.Location = New System.Drawing.Point(126, 9)
        Me.btn_imprimir_rango.Name = "btn_imprimir_rango"
        Me.btn_imprimir_rango.Size = New System.Drawing.Size(75, 51)
        Me.btn_imprimir_rango.TabIndex = 7
        Me.btn_imprimir_rango.Text = "IMPRIMIR"
        Me.btn_imprimir_rango.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
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
        Me.dg_articulos.Location = New System.Drawing.Point(366, 436)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.Size = New System.Drawing.Size(93, 10)
        Me.dg_articulos.TabIndex = 19
        Me.dg_articulos.Visible = False
        '
        'dg_faltantes
        '
        Me.dg_faltantes.AllowUserToAddRows = False
        Me.dg_faltantes.AllowUserToDeleteRows = False
        Me.dg_faltantes.AllowUserToOrderColumns = True
        Me.dg_faltantes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_faltantes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_faltantes.Location = New System.Drawing.Point(376, 389)
        Me.dg_faltantes.Name = "dg_faltantes"
        Me.dg_faltantes.ReadOnly = True
        Me.dg_faltantes.Size = New System.Drawing.Size(55, 44)
        Me.dg_faltantes.TabIndex = 18
        Me.dg_faltantes.Visible = False
        '
        'dg_supervisor
        '
        Me.dg_supervisor.AllowUserToAddRows = False
        Me.dg_supervisor.AllowUserToDeleteRows = False
        Me.dg_supervisor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_supervisor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_supervisor.Location = New System.Drawing.Point(248, 61)
        Me.dg_supervisor.Name = "dg_supervisor"
        Me.dg_supervisor.ReadOnly = True
        Me.dg_supervisor.Size = New System.Drawing.Size(224, 150)
        Me.dg_supervisor.TabIndex = 20
        '
        'opcion_Pagos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 461)
        Me.Controls.Add(Me.dg_supervisor)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.dg_faltantes)
        Me.Controls.Add(Me.grp_rango)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.grp_supervisor)
        Me.Controls.Add(Me.grp_cobrador)
        Me.Controls.Add(Me.btn_agregar)
        Me.Controls.Add(Me.dg_rutas)
        Me.Controls.Add(Me.Label1)
        Me.Name = "opcion_Pagos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGOS"
        CType(Me.dg_rutas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grp_cobrador.ResumeLayout(False)
        Me.grp_cobrador.PerformLayout()
        Me.grp_supervisor.ResumeLayout(False)
        Me.grp_supervisor.PerformLayout()
        Me.grp_rango.ResumeLayout(False)
        Me.grp_rango.PerformLayout()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_faltantes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_supervisor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btn_cobro_terminal As Button
    Friend WithEvents btn_cobro_manual As Button
    Friend WithEvents dg_rutas As DataGridView
    Friend WithEvents btn_agregar As Button
    Friend WithEvents btn_super_terminal As Button
    Friend WithEvents btn_super_listado As Button
    Friend WithEvents btn_cobro_cambio As Button
    Friend WithEvents btn_super_cambio As Button
    Friend WithEvents grp_cobrador As GroupBox
    Friend WithEvents grp_supervisor As GroupBox
    Friend WithEvents lbl_ruta As Label
    Friend WithEvents btn_inventario_t As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents grp_rango As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_inicio As MaskedTextBox
    Friend WithEvents txt_fin As MaskedTextBox
    Friend WithEvents btn_imprimir_rango As Button
    Friend WithEvents btn_atrazadas As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents Printtarjeta As Printing.PrintDocument
    Friend WithEvents PrinttarjetaChica As Printing.PrintDocument
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents dg_faltantes As DataGridView
    Friend WithEvents dg_supervisor As DataGridView
End Class
