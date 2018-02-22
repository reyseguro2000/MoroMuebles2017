<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class tar_formato_cobra
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
        Me.bt_f1 = New System.Windows.Forms.Button()
        Me.lbl_clave_cliente = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_venta = New System.Windows.Forms.Label()
        Me.bt_f2 = New System.Windows.Forms.Button()
        Me.bt_f3 = New System.Windows.Forms.Button()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.impr_cobra = New System.Drawing.Printing.PrintDocument()
        Me.SuspendLayout()
        '
        'bt_f1
        '
        Me.bt_f1.Location = New System.Drawing.Point(12, 58)
        Me.bt_f1.Name = "bt_f1"
        Me.bt_f1.Size = New System.Drawing.Size(56, 32)
        Me.bt_f1.TabIndex = 1
        Me.bt_f1.Text = "1"
        Me.bt_f1.UseVisualStyleBackColor = True
        '
        'lbl_clave_cliente
        '
        Me.lbl_clave_cliente.AutoSize = True
        Me.lbl_clave_cliente.Location = New System.Drawing.Point(16, 12)
        Me.lbl_clave_cliente.Name = "lbl_clave_cliente"
        Me.lbl_clave_cliente.Size = New System.Drawing.Size(33, 13)
        Me.lbl_clave_cliente.TabIndex = 2
        Me.lbl_clave_cliente.Text = "clave"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(92, 12)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(38, 13)
        Me.lbl_nombre.TabIndex = 3
        Me.lbl_nombre.Text = "cliente"
        '
        'lbl_venta
        '
        Me.lbl_venta.AutoSize = True
        Me.lbl_venta.Location = New System.Drawing.Point(16, 42)
        Me.lbl_venta.Name = "lbl_venta"
        Me.lbl_venta.Size = New System.Drawing.Size(34, 13)
        Me.lbl_venta.TabIndex = 4
        Me.lbl_venta.Text = "venta"
        '
        'bt_f2
        '
        Me.bt_f2.Location = New System.Drawing.Point(74, 58)
        Me.bt_f2.Name = "bt_f2"
        Me.bt_f2.Size = New System.Drawing.Size(56, 32)
        Me.bt_f2.TabIndex = 5
        Me.bt_f2.Text = "2"
        Me.bt_f2.UseVisualStyleBackColor = True
        '
        'bt_f3
        '
        Me.bt_f3.Location = New System.Drawing.Point(136, 58)
        Me.bt_f3.Name = "bt_f3"
        Me.bt_f3.Size = New System.Drawing.Size(56, 32)
        Me.bt_f3.TabIndex = 6
        Me.bt_f3.Text = "3"
        Me.bt_f3.UseVisualStyleBackColor = True
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'impr_cobra
        '
        '
        'tar_formato_cobra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(384, 145)
        Me.Controls.Add(Me.bt_f3)
        Me.Controls.Add(Me.bt_f2)
        Me.Controls.Add(Me.lbl_venta)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_clave_cliente)
        Me.Controls.Add(Me.bt_f1)
        Me.Name = "tar_formato_cobra"
        Me.Text = "tar_formato_cobra"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents bt_f1 As Button
    Friend WithEvents lbl_clave_cliente As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_venta As Label
    Friend WithEvents bt_f2 As Button
    Friend WithEvents bt_f3 As Button
    Friend WithEvents PrintDialog1 As PrintDialog
    Friend WithEvents impr_cobra As Printing.PrintDocument
End Class
