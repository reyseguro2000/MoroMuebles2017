<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_indicacion
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
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.l_estado = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.l_cli_clave = New System.Windows.Forms.Label()
        Me.l_nombre = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.l_venta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(158, 223)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(330, 89)
        Me.TextBox2.TabIndex = 99
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(2, 226)
        Me.Label10.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(160, 38)
        Me.Label10.TabIndex = 101
        Me.Label10.Text = "COMENTARIO"
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(2, 188)
        Me.Label9.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(99, 38)
        Me.Label9.TabIndex = 102
        Me.Label9.Text = "VENCE"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(123, 183)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(6)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(365, 29)
        Me.DateTimePicker1.TabIndex = 98
        '
        'l_estado
        '
        Me.l_estado.Location = New System.Drawing.Point(272, 77)
        Me.l_estado.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.l_estado.Name = "l_estado"
        Me.l_estado.Size = New System.Drawing.Size(108, 28)
        Me.l_estado.TabIndex = 103
        Me.l_estado.Text = "ESTADO"
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(2, 85)
        Me.Label7.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(248, 28)
        Me.Label7.TabIndex = 104
        Me.Label7.Text = "DESDE    0000-00-00"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.Button3.Location = New System.Drawing.Point(344, 324)
        Me.Button3.Margin = New System.Windows.Forms.Padding(6)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(144, 32)
        Me.Button3.TabIndex = 96
        Me.Button3.Text = "GUARDAR"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'ComboBox2
        '
        Me.ComboBox2.Items.AddRange(New Object() {"Abono en 7 dias", "Abono en 15 dias", "Liquida en 15 dias", "Liquida en 30 dias", "Regresa mercancia 7 dias", "Regresa mercancia 15 dias"})
        Me.ComboBox2.Location = New System.Drawing.Point(123, 147)
        Me.ComboBox2.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(365, 33)
        Me.ComboBox2.TabIndex = 95
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(2, 150)
        Me.Label6.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(121, 38)
        Me.Label6.TabIndex = 105
        Me.Label6.Text = "ACUERDO"
        '
        'ComboBox1
        '
        Me.ComboBox1.Items.AddRange(New Object() {"Titular", "Conyuge", "Padres", "Cobrador"})
        Me.ComboBox1.Location = New System.Drawing.Point(186, 112)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(6)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(302, 33)
        Me.ComboBox1.TabIndex = 94
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(2, 112)
        Me.Label4.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(178, 38)
        Me.Label4.TabIndex = 106
        Me.Label4.Text = "QUIÉN ATENDIO"
        '
        'l_cli_clave
        '
        Me.l_cli_clave.Location = New System.Drawing.Point(288, 9)
        Me.l_cli_clave.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.l_cli_clave.Name = "l_cli_clave"
        Me.l_cli_clave.Size = New System.Drawing.Size(108, 38)
        Me.l_cli_clave.TabIndex = 107
        Me.l_cli_clave.Text = "---"
        Me.l_cli_clave.Visible = False
        '
        'l_nombre
        '
        Me.l_nombre.Location = New System.Drawing.Point(109, 47)
        Me.l_nombre.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.l_nombre.Name = "l_nombre"
        Me.l_nombre.Size = New System.Drawing.Size(344, 58)
        Me.l_nombre.TabIndex = 108
        Me.l_nombre.Text = "----"
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(2, 47)
        Me.Label2.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 38)
        Me.Label2.TabIndex = 109
        Me.Label2.Text = "CLIENTE"
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(2, 12)
        Me.Label1.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 35)
        Me.Label1.TabIndex = 110
        Me.Label1.Text = "VENTA"
        '
        'l_venta
        '
        Me.l_venta.Location = New System.Drawing.Point(104, -1)
        Me.l_venta.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.l_venta.Name = "l_venta"
        Me.l_venta.Size = New System.Drawing.Size(108, 38)
        Me.l_venta.TabIndex = 111
        Me.l_venta.Text = "---"
        '
        'agregar_indicacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(503, 379)
        Me.Controls.Add(Me.l_venta)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.l_estado)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.l_cli_clave)
        Me.Controls.Add(Me.l_nombre)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "agregar_indicacion"
        Me.Text = "AGREGAR INDICACION"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents l_estado As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents l_cli_clave As System.Windows.Forms.Label
    Friend WithEvents l_nombre As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents l_venta As System.Windows.Forms.Label
End Class
