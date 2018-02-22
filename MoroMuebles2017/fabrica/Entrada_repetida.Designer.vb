<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Entrada_repetida
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
        Me.lbl_folio = New System.Windows.Forms.Label()
        Me.dgv_repetidos = New System.Windows.Forms.DataGridView()
        Me.lbl_fecha = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_clave_provedor = New System.Windows.Forms.Label()
        Me.lblprovedor = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        CType(Me.dgv_repetidos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_folio
        '
        Me.lbl_folio.AutoSize = True
        Me.lbl_folio.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_folio.Location = New System.Drawing.Point(485, 29)
        Me.lbl_folio.Name = "lbl_folio"
        Me.lbl_folio.Size = New System.Drawing.Size(43, 20)
        Me.lbl_folio.TabIndex = 0
        Me.lbl_folio.Text = "Folio"
        '
        'dgv_repetidos
        '
        Me.dgv_repetidos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_repetidos.Location = New System.Drawing.Point(14, 64)
        Me.dgv_repetidos.Name = "dgv_repetidos"
        Me.dgv_repetidos.Size = New System.Drawing.Size(525, 290)
        Me.dgv_repetidos.TabIndex = 1
        '
        'lbl_fecha
        '
        Me.lbl_fecha.AutoSize = True
        Me.lbl_fecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_fecha.Location = New System.Drawing.Point(485, 9)
        Me.lbl_fecha.Name = "lbl_fecha"
        Me.lbl_fecha.Size = New System.Drawing.Size(54, 20)
        Me.lbl_fecha.TabIndex = 2
        Me.lbl_fecha.Text = "Fecha"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "PROVEEDOR"
        '
        'lbl_clave_provedor
        '
        Me.lbl_clave_provedor.AutoSize = True
        Me.lbl_clave_provedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_clave_provedor.Location = New System.Drawing.Point(128, 9)
        Me.lbl_clave_provedor.Name = "lbl_clave_provedor"
        Me.lbl_clave_provedor.Size = New System.Drawing.Size(18, 20)
        Me.lbl_clave_provedor.TabIndex = 4
        Me.lbl_clave_provedor.Text = "0"
        '
        'lblprovedor
        '
        Me.lblprovedor.AutoSize = True
        Me.lblprovedor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblprovedor.Location = New System.Drawing.Point(152, 9)
        Me.lblprovedor.Name = "lblprovedor"
        Me.lblprovedor.Size = New System.Drawing.Size(57, 20)
        Me.lblprovedor.TabIndex = 5
        Me.lblprovedor.Text = "Label2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(416, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "FECHA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(416, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 20)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "FOLIO"
        '
        'Entrada_repetida
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(580, 380)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lblprovedor)
        Me.Controls.Add(Me.lbl_clave_provedor)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_fecha)
        Me.Controls.Add(Me.dgv_repetidos)
        Me.Controls.Add(Me.lbl_folio)
        Me.Name = "Entrada_repetida"
        Me.Text = "ENTRADA REPETIDA"
        CType(Me.dgv_repetidos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_folio As Label
    Friend WithEvents dgv_repetidos As DataGridView
    Friend WithEvents lbl_fecha As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_clave_provedor As Label
    Friend WithEvents lblprovedor As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
End Class
