<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class opcion_clientes
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_clave = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.dt_clientes = New System.Windows.Forms.DataGridView()
        Me.txt_ine = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dt_pendientes = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.btn_ventas = New System.Windows.Forms.Button()
        Me.btn_folio = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        CType(Me.dt_clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dt_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(621, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CLAVE"
        '
        'txt_clave
        '
        Me.txt_clave.Location = New System.Drawing.Point(894, 58)
        Me.txt_clave.Name = "txt_clave"
        Me.txt_clave.Size = New System.Drawing.Size(100, 20)
        Me.txt_clave.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(274, 64)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "NOMBRE"
        '
        'txt_nombre
        '
        Me.txt_nombre.Location = New System.Drawing.Point(346, 57)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(471, 20)
        Me.txt_nombre.TabIndex = 3
        '
        'dt_clientes
        '
        Me.dt_clientes.AllowUserToAddRows = False
        Me.dt_clientes.AllowUserToDeleteRows = False
        Me.dt_clientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_clientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_clientes.Location = New System.Drawing.Point(75, 174)
        Me.dt_clientes.Name = "dt_clientes"
        Me.dt_clientes.ReadOnly = True
        Me.dt_clientes.Size = New System.Drawing.Size(952, 240)
        Me.dt_clientes.TabIndex = 5
        '
        'txt_ine
        '
        Me.txt_ine.Location = New System.Drawing.Point(346, 112)
        Me.txt_ine.Name = "txt_ine"
        Me.txt_ine.Size = New System.Drawing.Size(471, 20)
        Me.txt_ine.TabIndex = 7
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(346, 86)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(471, 20)
        Me.txt_direccion.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(274, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(25, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "INE"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(717, 138)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 11
        '
        'dt_pendientes
        '
        Me.dt_pendientes.AllowUserToAddRows = False
        Me.dt_pendientes.AllowUserToDeleteRows = False
        Me.dt_pendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dt_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dt_pendientes.Location = New System.Drawing.Point(75, 445)
        Me.dt_pendientes.Name = "dt_pendientes"
        Me.dt_pendientes.ReadOnly = True
        Me.dt_pendientes.Size = New System.Drawing.Size(952, 143)
        Me.dt_pendientes.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(75, 429)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(177, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "CLIENTES SIN VENTA ASIGNADA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 89)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "DOMICILIO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(673, 139)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(38, 13)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "FOLIO"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(836, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(52, 13)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "CLIENTE"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(836, 155)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(79, 13)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "NUEVO FOLIO"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(959, 155)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(50, 13)
        Me.Label9.TabIndex = 19
        Me.Label9.Text = "VENTAS"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(175, 155)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(93, 13)
        Me.Label10.TabIndex = 20
        Me.Label10.Text = "NUEVO CLIENTE"
        '
        'btn_ventas
        '
        Me.btn_ventas.BackgroundImage = Global.Captura.My.Resources.Resources.ver_ventas
        Me.btn_ventas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ventas.Location = New System.Drawing.Point(939, 89)
        Me.btn_ventas.Name = "btn_ventas"
        Me.btn_ventas.Size = New System.Drawing.Size(88, 63)
        Me.btn_ventas.TabIndex = 12
        Me.btn_ventas.UseVisualStyleBackColor = True
        '
        'btn_folio
        '
        Me.btn_folio.BackgroundImage = Global.Captura.My.Resources.Resources.agregar_venta
        Me.btn_folio.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_folio.Location = New System.Drawing.Point(839, 89)
        Me.btn_folio.Name = "btn_folio"
        Me.btn_folio.Size = New System.Drawing.Size(76, 63)
        Me.btn_folio.TabIndex = 10
        Me.btn_folio.UseVisualStyleBackColor = True
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackgroundImage = Global.Captura.My.Resources.Resources.agregar_cliente
        Me.btn_nuevo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nuevo.Location = New System.Drawing.Point(167, 64)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(101, 88)
        Me.btn_nuevo.TabIndex = 6
        Me.btn_nuevo.UseVisualStyleBackColor = True
        '
        'opcion_clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1040, 652)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dt_pendientes)
        Me.Controls.Add(Me.btn_ventas)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.btn_folio)
        Me.Controls.Add(Me.txt_direccion)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txt_ine)
        Me.Controls.Add(Me.btn_nuevo)
        Me.Controls.Add(Me.dt_clientes)
        Me.Controls.Add(Me.txt_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_clave)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "opcion_clientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BUSQUEDA DE CLIENTES"
        CType(Me.dt_clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dt_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txt_clave As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_nombre As TextBox
    Friend WithEvents dt_clientes As DataGridView
    Friend WithEvents btn_nuevo As Button
    Friend WithEvents txt_ine As TextBox
    Friend WithEvents txt_direccion As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_folio As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents btn_ventas As Button
    Friend WithEvents dt_pendientes As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
End Class
