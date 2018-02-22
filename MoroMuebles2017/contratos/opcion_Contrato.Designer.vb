<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class opcion_Contrato
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
        Me.bt_entradas = New System.Windows.Forms.Button()
        Me.dgventas = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgventas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(215, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECCIONA UNA OPCIÓN"
        '
        'bt_entradas
        '
        Me.bt_entradas.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bt_entradas.Location = New System.Drawing.Point(257, 9)
        Me.bt_entradas.Name = "bt_entradas"
        Me.bt_entradas.Size = New System.Drawing.Size(100, 52)
        Me.bt_entradas.TabIndex = 3
        Me.bt_entradas.Text = "CAPTURA DE DATOS EN VENTA"
        Me.bt_entradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_entradas.UseVisualStyleBackColor = True
        '
        'dgventas
        '
        Me.dgventas.AllowUserToAddRows = False
        Me.dgventas.AllowUserToDeleteRows = False
        Me.dgventas.AllowUserToOrderColumns = True
        Me.dgventas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgventas.Location = New System.Drawing.Point(26, 72)
        Me.dgventas.Name = "dgventas"
        Me.dgventas.ReadOnly = True
        Me.dgventas.Size = New System.Drawing.Size(483, 190)
        Me.dgventas.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(387, 9)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 52)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Folio sin camioneta"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Ventas pendientes"
        '
        'opcion_Contrato
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(536, 288)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dgventas)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_entradas)
        Me.Name = "opcion_Contrato"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CONTRATO"
        CType(Me.dgventas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bt_entradas As Button
    Friend WithEvents dgventas As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Label2 As Label
End Class
