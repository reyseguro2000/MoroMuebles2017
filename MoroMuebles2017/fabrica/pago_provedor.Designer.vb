<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pago_provedor
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbl_folio = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_cantidad = New System.Windows.Forms.MaskedTextBox()
        Me.lbl_saldo = New System.Windows.Forms.Label()
        Me.lbl_resta = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PROVEDOR"
        '
        'lbl_provedor
        '
        Me.lbl_provedor.AutoSize = True
        Me.lbl_provedor.Location = New System.Drawing.Point(86, 18)
        Me.lbl_provedor.Name = "lbl_provedor"
        Me.lbl_provedor.Size = New System.Drawing.Size(39, 13)
        Me.lbl_provedor.TabIndex = 1
        Me.lbl_provedor.Text = "Label2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "FOLIO"
        '
        'lbl_folio
        '
        Me.lbl_folio.AutoSize = True
        Me.lbl_folio.Location = New System.Drawing.Point(86, 49)
        Me.lbl_folio.Name = "lbl_folio"
        Me.lbl_folio.Size = New System.Drawing.Size(39, 13)
        Me.lbl_folio.TabIndex = 3
        Me.lbl_folio.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 88)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "SALDO"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 121)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "CANTIDAD"
        '
        'btn_guardar
        '
        Me.btn_guardar.Enabled = False
        Me.btn_guardar.Location = New System.Drawing.Point(163, 148)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 6
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_cantidad
        '
        Me.txt_cantidad.Location = New System.Drawing.Point(89, 114)
        Me.txt_cantidad.Mask = "99999"
        Me.txt_cantidad.Name = "txt_cantidad"
        Me.txt_cantidad.Size = New System.Drawing.Size(51, 20)
        Me.txt_cantidad.TabIndex = 0
        Me.txt_cantidad.ValidatingType = GetType(Integer)
        '
        'lbl_saldo
        '
        Me.lbl_saldo.AutoSize = True
        Me.lbl_saldo.Location = New System.Drawing.Point(86, 88)
        Me.lbl_saldo.Name = "lbl_saldo"
        Me.lbl_saldo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_saldo.TabIndex = 8
        Me.lbl_saldo.Text = "Label7"
        '
        'lbl_resta
        '
        Me.lbl_resta.AutoSize = True
        Me.lbl_resta.Location = New System.Drawing.Point(86, 158)
        Me.lbl_resta.Name = "lbl_resta"
        Me.lbl_resta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_resta.TabIndex = 9
        Me.lbl_resta.Text = "Label8"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(12, 158)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "RESTA"
        '
        'pago_provedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(311, 191)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.lbl_resta)
        Me.Controls.Add(Me.lbl_saldo)
        Me.Controls.Add(Me.txt_cantidad)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lbl_folio)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lbl_provedor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "pago_provedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGO PROVEDOR"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_provedor As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents lbl_folio As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_cantidad As MaskedTextBox
    Friend WithEvents lbl_saldo As Label
    Friend WithEvents lbl_resta As Label
    Friend WithEvents Label9 As Label
End Class
