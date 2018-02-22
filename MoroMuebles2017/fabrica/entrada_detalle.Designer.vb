<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entrada_detalle
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
        Me.lbl_provedor = New System.Windows.Forms.Label()
        Me.dg_articulos = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dg_pagos = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.bt_pago = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_folio = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_saldo = New System.Windows.Forms.Label()
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROVEDOR"
        '
        'lbl_provedor
        '
        Me.lbl_provedor.AutoSize = True
        Me.lbl_provedor.Location = New System.Drawing.Point(95, 9)
        Me.lbl_provedor.Name = "lbl_provedor"
        Me.lbl_provedor.Size = New System.Drawing.Size(39, 13)
        Me.lbl_provedor.TabIndex = 1
        Me.lbl_provedor.Text = "Label2"
        '
        'dg_articulos
        '
        Me.dg_articulos.AllowUserToAddRows = False
        Me.dg_articulos.AllowUserToDeleteRows = False
        Me.dg_articulos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos.Location = New System.Drawing.Point(12, 90)
        Me.dg_articulos.Name = "dg_articulos"
        Me.dg_articulos.ReadOnly = True
        Me.dg_articulos.Size = New System.Drawing.Size(469, 150)
        Me.dg_articulos.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 74)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "ARTICULOS"
        '
        'dg_pagos
        '
        Me.dg_pagos.AllowUserToAddRows = False
        Me.dg_pagos.AllowUserToDeleteRows = False
        Me.dg_pagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pagos.Location = New System.Drawing.Point(15, 281)
        Me.dg_pagos.Name = "dg_pagos"
        Me.dg_pagos.ReadOnly = True
        Me.dg_pagos.Size = New System.Drawing.Size(240, 150)
        Me.dg_pagos.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "PAGOS"
        '
        'bt_pago
        '
        Me.bt_pago.Location = New System.Drawing.Point(262, 286)
        Me.bt_pago.Name = "bt_pago"
        Me.bt_pago.Size = New System.Drawing.Size(75, 23)
        Me.bt_pago.TabIndex = 6
        Me.bt_pago.Text = "PAGO"
        Me.bt_pago.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(22, 43)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "FOLIO"
        '
        'lbl_folio
        '
        Me.lbl_folio.AutoSize = True
        Me.lbl_folio.Location = New System.Drawing.Point(95, 43)
        Me.lbl_folio.Name = "lbl_folio"
        Me.lbl_folio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_folio.TabIndex = 8
        Me.lbl_folio.Text = "Label6"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(212, 43)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "SALDO"
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.Location = New System.Drawing.Point(261, 43)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_saldo.TabIndex = 10
        Me.lbl_saldo.Text = "Label6"
        '
        'entrada_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(568, 582)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_folio)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.bt_pago)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dg_pagos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.dg_articulos)
        Me.Controls.Add(Me.lbl_provedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "entrada_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE DE ENTRADA"
        CType(Me.dg_articulos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_provedor As Label
    Friend WithEvents dg_articulos As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dg_pagos As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents bt_pago As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_folio As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_saldo As Label
End Class
