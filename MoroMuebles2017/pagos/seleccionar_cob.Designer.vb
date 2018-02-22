<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleccionar_cob
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
        Me.cmb_cobrador = New System.Windows.Forms.ComboBox()
        Me.btn_cambiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CAMBIAR COBRADOR"
        '
        'cmb_cobrador
        '
        Me.cmb_cobrador.FormattingEnabled = True
        Me.cmb_cobrador.Location = New System.Drawing.Point(151, 17)
        Me.cmb_cobrador.Name = "cmb_cobrador"
        Me.cmb_cobrador.Size = New System.Drawing.Size(257, 21)
        Me.cmb_cobrador.TabIndex = 1
        '
        'btn_cambiar
        '
        Me.btn_cambiar.Location = New System.Drawing.Point(267, 44)
        Me.btn_cambiar.Name = "btn_cambiar"
        Me.btn_cambiar.Size = New System.Drawing.Size(141, 23)
        Me.btn_cambiar.TabIndex = 4
        Me.btn_cambiar.Text = "CAMBIAR COBRADOR"
        Me.btn_cambiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 49)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(25, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "ruta"
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoSize = True
        Me.lbl_ruta.Location = New System.Drawing.Point(53, 49)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ruta.TabIndex = 6
        Me.lbl_ruta.Text = "Label3"
        '
        'seleccionar_cob
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(420, 94)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cambiar)
        Me.Controls.Add(Me.cmb_cobrador)
        Me.Controls.Add(Me.Label1)
        Me.Name = "seleccionar_cob"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "seleccionar_cob_sup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cmb_cobrador As ComboBox
    Friend WithEvents btn_cambiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_ruta As Label
End Class
