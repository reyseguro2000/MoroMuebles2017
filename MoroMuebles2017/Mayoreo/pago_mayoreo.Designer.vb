<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pago_mayoreo
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbl_resta = New System.Windows.Forms.Label()
        Me.lbl_saldo = New System.Windows.Forms.Label()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lbl_folio = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_cliente = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(12, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 21
        Me.Label9.Text = "RESTA"
        '
        'lbl_resta
        '
        Me.lbl_resta.AutoSize = True
        Me.lbl_resta.BackColor = System.Drawing.Color.Transparent
        Me.lbl_resta.Location = New System.Drawing.Point(86, 149)
        Me.lbl_resta.Name = "lbl_resta"
        Me.lbl_resta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_resta.TabIndex = 20
        Me.lbl_resta.Text = "Label8"
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_saldo.Location = New System.Drawing.Point(86, 79)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_saldo.TabIndex = 19
        Me.lbl_saldo.Text = "Label7"
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(89, 105)
        Me.txt_cantidad.Mask = "99999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(51, 20)
        Me.txt_cantidad.TabIndex = 11
        Me.txt_cantidad.ValidatingType = GetType(Integer)
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(163, 139)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 18
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(12, 112)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "CANTIDAD"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(12, 79)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "SALDO"
        '
        'lbl_folio
        '
        Me.lbl_folio.AutoSize = True
        Me.lbl_folio.BackColor = System.Drawing.Color.Transparent
        Me.lbl_folio.Location = New System.Drawing.Point(313, 9)
        Me.lbl_folio.Name = "lbl_folio"
        Me.lbl_folio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_folio.TabIndex = 15
        Me.lbl_folio.Text = "Label4"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(239, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "FOLIO"
        '
        'lbl_cliente
        '
        Me.lbl_cliente.AutoSize = True
        Me.lbl_cliente.BackColor = System.Drawing.Color.Transparent
        Me.lbl_cliente.Location = New System.Drawing.Point(86, 51)
        Me.lbl_cliente.Name = "lbl_cliente"
        Me.lbl_cliente.Size = New System.Drawing.Size(39, 13)
        Me.lbl_cliente.TabIndex = 13
        Me.lbl_cliente.Text = "Label2"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "CLIENTE"
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre.Location = New System.Drawing.Point(160, 51)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(39, 13)
        Me.lbl_nombre.TabIndex = 22
        Me.lbl_nombre.Text = "Label2"
        '
        'pago_mayoreo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(360, 183)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_resta)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_folio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_cliente)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pago_mayoreo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "pago_mayoreo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label9 As Label
    Friend WithEvents lbl_resta As Label
    Friend WithEvents lbl_saldo As Label
    Friend WithEvents txt_cantidad As MaskedTextBox
    Friend WithEvents btn_guardar As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents lbl_folio As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_cliente As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_nombre As Label
End Class
