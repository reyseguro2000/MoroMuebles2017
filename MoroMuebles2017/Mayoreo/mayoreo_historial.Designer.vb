<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mayoreo_historial
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
        Me.lbl_saldo = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_folio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.bt_pago = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dg_pagos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.dg_ventas = New System.Windows.Forms.DataGridView()
        CType(Me.dg_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_saldo.Location = New System.Drawing.Point(387, 54)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_saldo.TabIndex = 21
        Me.lbl_saldo.Text = "Label6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(338, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "SALDO"
        '
        'lbl_folio
        '
        Me.lbl_folio.AutoSize = True
        Me.lbl_folio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_folio.Location = New System.Drawing.Point(221, 54)
        Me.lbl_folio.Name = "lbl_folio"
        Me.lbl_folio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_folio.TabIndex = 19
        Me.lbl_folio.Text = "Label6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(148, 54)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "FOLIO"
        '
        'bt_pago
        '
        Me.bt_pago.Location = New System.Drawing.Point(290, 342)
        Me.bt_pago.Name = "bt_pago"
        Me.bt_pago.Size = New System.Drawing.Size(75, 23)
        Me.bt_pago.TabIndex = 17
        Me.bt_pago.Text = "PAGO"
        Me.bt_pago.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(16, 323)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "PAGOS"
        '
        'dg_pagos
        '
        Me.dg_pagos.AllowUserToAddRows = False
        Me.dg_pagos.AllowUserToDeleteRows = False
        Me.dg_pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pagos.Location = New System.Drawing.Point(15, 342)
        Me.dg_pagos.Name = "dg_pagos"
        Me.dg_pagos.ReadOnly = True
        Me.dg_pagos.Size = New System.Drawing.Size(269, 93)
        Me.dg_pagos.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(12, 174)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ARTICULOS"
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AllowUserToDeleteRows = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Location = New System.Drawing.Point(12, 190)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.ReadOnly = True
        Me.dg_articulos.Size = New System.Drawing.Size(469, 125)
        Me.dg_articulos.TabIndex = 13
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cliente.Location = New System.Drawing.Point(222, 9)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cliente.TabIndex = 12
        Me.lbl_cliente.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(148, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "CLIENTE"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Location = New System.Drawing.Point(295, 9)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nombre.TabIndex = 22
        Me.lbl_nombre.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(68, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "ARTICULOS"
        '
        'dg_ventas
        '
        Me.dg_ventas.AllowUserToAddRows = False
        Me.dg_ventas.AllowUserToDeleteRows = False
        Me.dg_ventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ventas.Location = New System.Drawing.Point(12, 80)
        Me.dg_ventas.Name = "dg_ventas"
        Me.dg_ventas.ReadOnly = True
        Me.dg_ventas.Size = New System.Drawing.Size(469, 91)
        Me.dg_ventas.TabIndex = 23
        '
        'mayoreo_historial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(493, 454)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.dg_ventas)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_folio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_pago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dg_pagos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "mayoreo_historial"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "HOSTORIAL DE MAYOREO"
        CType(Me.dg_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_ventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_saldo As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_folio As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents bt_pago As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dg_pagos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents dg_ventas As DataGridView
End Class
