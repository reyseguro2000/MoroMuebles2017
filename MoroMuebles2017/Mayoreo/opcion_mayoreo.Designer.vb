<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcion_mayoreo
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
        Me.dg_mayoristas = New System.Windows.Forms.DataGridView()
        Me.btn_nueva_venta = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_clave_cliente = New System.Windows.Forms.MaskedTextBox()
        Me.txt_cliente = New System.Windows.Forms.TextBox()
        Me.btn_cliente = New System.Windows.Forms.Button()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dg_mayoristas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_mayoristas
        '
        Me.dg_mayoristas.AllowUserToAddRows = False
        Me.dg_mayoristas.AllowUserToDeleteRows = False
        Me.dg_mayoristas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_mayoristas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_mayoristas.Location = New System.Drawing.Point(12, 95)
        Me.dg_mayoristas.Name = "dg_mayoristas"
        Me.dg_mayoristas.ReadOnly = True
        Me.dg_mayoristas.Size = New System.Drawing.Size(560, 254)
        Me.dg_mayoristas.TabIndex = 0
        '
        'btn_nueva_venta
        '
        Me.btn_nueva_venta.BackgroundImage = Global.Captura.My.Resources.Resources.agregar_venta
        Me.btn_nueva_venta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_nueva_venta.Enabled = False
        Me.btn_nueva_venta.Location = New System.Drawing.Point(393, 12)
        Me.btn_nueva_venta.Name = "btn_nueva_venta"
        Me.btn_nueva_venta.Size = New System.Drawing.Size(88, 59)
        Me.btn_nueva_venta.TabIndex = 1
        Me.btn_nueva_venta.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(103, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CLIENTE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(103, 51)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(41, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "CLAVE"
        '
        'txt_clave_cliente
        '
        Me.txt_clave_cliente.Location = New System.Drawing.Point(166, 48)
        Me.txt_clave_cliente.Name = "txt_clave_cliente"
        Me.txt_clave_cliente.Size = New System.Drawing.Size(40, 20)
        Me.txt_clave_cliente.TabIndex = 4
        '
        'txt_cliente
        '
        Me.txt_cliente.Location = New System.Drawing.Point(166, 68)
        Me.txt_cliente.Name = "txt_cliente"
        Me.txt_cliente.Size = New System.Drawing.Size(212, 20)
        Me.txt_cliente.TabIndex = 5
        '
        'btn_cliente
        '
        Me.btn_cliente.BackgroundImage = Global.Captura.My.Resources.Resources.agregar_cliente
        Me.btn_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cliente.Location = New System.Drawing.Point(293, 5)
        Me.btn_cliente.Name = "btn_cliente"
        Me.btn_cliente.Size = New System.Drawing.Size(85, 59)
        Me.btn_cliente.TabIndex = 6
        Me.btn_cliente.UseVisualStyleBackColor = True
        '
        'btn_ver
        '
        Me.btn_ver.BackgroundImage = Global.Captura.My.Resources.Resources.ver_ventas
        Me.btn_ver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_ver.Enabled = False
        Me.btn_ver.Location = New System.Drawing.Point(484, 12)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(88, 59)
        Me.btn_ver.TabIndex = 7
        Me.btn_ver.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(390, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "NUEVA VENTA"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(497, 74)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "VER VENTAS"
        '
        'opcion_mayoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(584, 361)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.btn_cliente)
        Me.Controls.Add(Me.txt_cliente)
        Me.Controls.Add(Me.txt_clave_cliente)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_nueva_venta)
        Me.Controls.Add(Me.dg_mayoristas)
        Me.Name = "opcion_mayoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MAYOREO"
        CType(Me.dg_mayoristas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_mayoristas As DataGridView
    Friend WithEvents btn_nueva_venta As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_clave_cliente As MaskedTextBox
    Friend WithEvents txt_cliente As TextBox
    Friend WithEvents btn_cliente As Button
    Friend WithEvents btn_ver As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
