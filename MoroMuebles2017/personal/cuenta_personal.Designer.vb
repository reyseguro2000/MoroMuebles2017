<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class cuenta_personal
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
        Me.dg_ultimos_pagos = New System.Windows.Forms.DataGridView()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.lbl_puesto = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_sugerido = New System.Windows.Forms.Label()
        Me.lbl_guardar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBox1 = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lbl_deposito = New System.Windows.Forms.Button()
        Me.lbl_retiro = New System.Windows.Forms.Button()
        Me.dg_depositos = New System.Windows.Forms.DataGridView()
        Me.dg_retiros = New System.Windows.Forms.DataGridView()
        Me.dg_prestamos = New System.Windows.Forms.DataGridView()
        Me.lbl_prestamo = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_comicion = New System.Windows.Forms.Label()
        Me.lbl_buscar = New System.Windows.Forms.Button()
        CType(Me.dg_ultimos_pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_depositos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_retiros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_prestamos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dg_ultimos_pagos
        '
        Me.dg_ultimos_pagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ultimos_pagos.Location = New System.Drawing.Point(12, 36)
        Me.dg_ultimos_pagos.Name = "dg_ultimos_pagos"
        Me.dg_ultimos_pagos.Size = New System.Drawing.Size(240, 221)
        Me.dg_ultimos_pagos.TabIndex = 0
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Location = New System.Drawing.Point(32, 12)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(39, 13)
        Me.lbl_clave.TabIndex = 1
        Me.lbl_clave.Text = "Label1"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(77, 12)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nombre.TabIndex = 2
        Me.lbl_nombre.Text = "Label2"
        '
        'lbl_puesto
        '
        Me.lbl_puesto.AutoSize = True
        Me.lbl_puesto.Location = New System.Drawing.Point(169, 14)
        Me.lbl_puesto.Name = "lbl_puesto"
        Me.lbl_puesto.Size = New System.Drawing.Size(39, 13)
        Me.lbl_puesto.TabIndex = 3
        Me.lbl_puesto.Text = "Label3"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(281, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(97, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "PAGO SUGERIDO"
        '
        'lbl_sugerido
        '
        Me.lbl_sugerido.AutoSize = True
        Me.lbl_sugerido.Location = New System.Drawing.Point(384, 36)
        Me.lbl_sugerido.Name = "lbl_sugerido"
        Me.lbl_sugerido.Size = New System.Drawing.Size(39, 13)
        Me.lbl_sugerido.TabIndex = 5
        Me.lbl_sugerido.Text = "Label2"
        '
        'lbl_guardar
        '
        Me.lbl_guardar.Location = New System.Drawing.Point(284, 163)
        Me.lbl_guardar.Name = "lbl_guardar"
        Me.lbl_guardar.Size = New System.Drawing.Size(75, 23)
        Me.lbl_guardar.TabIndex = 6
        Me.lbl_guardar.Text = "GUARDAR"
        Me.lbl_guardar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(281, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "PAGO"
        '
        'MaskedTextBox1
        '
        Me.MaskedTextBox1.Location = New System.Drawing.Point(324, 89)
        Me.MaskedTextBox1.Mask = "99999"
        Me.MaskedTextBox1.Name = "MaskedTextBox1"
        Me.MaskedTextBox1.Size = New System.Drawing.Size(54, 20)
        Me.MaskedTextBox1.TabIndex = 8
        Me.MaskedTextBox1.ValidatingType = GetType(Integer)
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(281, 126)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "COMENTARIO"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(366, 123)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 10
        '
        'lbl_deposito
        '
        Me.lbl_deposito.Location = New System.Drawing.Point(12, 303)
        Me.lbl_deposito.Name = "lbl_deposito"
        Me.lbl_deposito.Size = New System.Drawing.Size(75, 23)
        Me.lbl_deposito.TabIndex = 11
        Me.lbl_deposito.Text = "DEPOSITO"
        Me.lbl_deposito.UseVisualStyleBackColor = True
        '
        'lbl_retiro
        '
        Me.lbl_retiro.Location = New System.Drawing.Point(167, 303)
        Me.lbl_retiro.Name = "lbl_retiro"
        Me.lbl_retiro.Size = New System.Drawing.Size(75, 23)
        Me.lbl_retiro.TabIndex = 12
        Me.lbl_retiro.Text = "RETIRO"
        Me.lbl_retiro.UseVisualStyleBackColor = True
        '
        'dg_depositos
        '
        Me.dg_depositos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_depositos.Location = New System.Drawing.Point(12, 332)
        Me.dg_depositos.Name = "dg_depositos"
        Me.dg_depositos.Size = New System.Drawing.Size(149, 150)
        Me.dg_depositos.TabIndex = 13
        '
        'dg_retiros
        '
        Me.dg_retiros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_retiros.Location = New System.Drawing.Point(167, 332)
        Me.dg_retiros.Name = "dg_retiros"
        Me.dg_retiros.Size = New System.Drawing.Size(138, 150)
        Me.dg_retiros.TabIndex = 14
        '
        'dg_prestamos
        '
        Me.dg_prestamos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_prestamos.Location = New System.Drawing.Point(311, 332)
        Me.dg_prestamos.Name = "dg_prestamos"
        Me.dg_prestamos.Size = New System.Drawing.Size(138, 150)
        Me.dg_prestamos.TabIndex = 16
        '
        'lbl_prestamo
        '
        Me.lbl_prestamo.Location = New System.Drawing.Point(311, 303)
        Me.lbl_prestamo.Name = "lbl_prestamo"
        Me.lbl_prestamo.Size = New System.Drawing.Size(75, 23)
        Me.lbl_prestamo.TabIndex = 15
        Me.lbl_prestamo.Text = "PRESTAMO"
        Me.lbl_prestamo.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(281, 244)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(101, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CUENTA AHORRO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(298, 276)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(20, 24)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "0"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(281, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(63, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "COMICION "
        '
        'lbl_comicion
        '
        Me.lbl_comicion.AutoSize = True
        Me.lbl_comicion.Location = New System.Drawing.Point(384, 60)
        Me.lbl_comicion.Name = "lbl_comicion"
        Me.lbl_comicion.Size = New System.Drawing.Size(39, 13)
        Me.lbl_comicion.TabIndex = 20
        Me.lbl_comicion.Text = "Label7"
        '
        'lbl_buscar
        '
        Me.lbl_buscar.Location = New System.Drawing.Point(397, 244)
        Me.lbl_buscar.Name = "lbl_buscar"
        Me.lbl_buscar.Size = New System.Drawing.Size(75, 23)
        Me.lbl_buscar.TabIndex = 21
        Me.lbl_buscar.Text = "Buscar"
        Me.lbl_buscar.UseVisualStyleBackColor = True
        '
        'cuenta_personal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 511)
        Me.Controls.Add(Me.lbl_buscar)
        Me.Controls.Add(Me.lbl_comicion)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg_prestamos)
        Me.Controls.Add(Me.lbl_prestamo)
        Me.Controls.Add(Me.dg_retiros)
        Me.Controls.Add(Me.dg_depositos)
        Me.Controls.Add(Me.lbl_retiro)
        Me.Controls.Add(Me.lbl_deposito)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.MaskedTextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_guardar)
        Me.Controls.Add(Me.lbl_sugerido)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_puesto)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.dg_ultimos_pagos)
        Me.Name = "cuenta_personal"
        Me.Text = "cuenta_personal"
        CType(Me.dg_ultimos_pagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_depositos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_retiros, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_prestamos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dg_ultimos_pagos As DataGridView
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_nombre As Label
    Friend WithEvents lbl_puesto As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_sugerido As Label
    Friend WithEvents lbl_guardar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBox1 As MaskedTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents lbl_deposito As Button
    Friend WithEvents lbl_retiro As Button
    Friend WithEvents dg_depositos As DataGridView
    Friend WithEvents dg_retiros As DataGridView
    Friend WithEvents dg_prestamos As DataGridView
    Friend WithEvents lbl_prestamo As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_comicion As Label
    Friend WithEvents lbl_buscar As Button
End Class
