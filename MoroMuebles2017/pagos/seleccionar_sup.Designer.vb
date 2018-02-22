<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleccionar_sup
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
        Me.lbl_ruta = New System.Windows.Forms.Label()
        Me.btn_cambiar = New System.Windows.Forms.Button()
        Me.cmb_supervisor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoSize = True
        Me.lbl_ruta.Location = New System.Drawing.Point(12, 43)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(25, 13)
        Me.lbl_ruta.TabIndex = 11
        Me.lbl_ruta.Text = "ruta"
        '
        'btn_cambiar
        '
        Me.btn_cambiar.Location = New System.Drawing.Point(318, 43)
        Me.btn_cambiar.Name = "btn_cambiar"
        Me.btn_cambiar.Size = New System.Drawing.Size(141, 23)
        Me.btn_cambiar.TabIndex = 9
        Me.btn_cambiar.Text = "CAMBIAR SUPERVISOR"
        Me.btn_cambiar.UseVisualStyleBackColor = True
        '
        'cmb_supervisor
        '
        Me.cmb_supervisor.FormattingEnabled = True
        Me.cmb_supervisor.Location = New System.Drawing.Point(157, 11)
        Me.cmb_supervisor.Name = "cmb_supervisor"
        Me.cmb_supervisor.Size = New System.Drawing.Size(302, 21)
        Me.cmb_supervisor.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "MODIFICAR SUPERVISOR"
        '
        'seleccionar_sup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(471, 85)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.btn_cambiar)
        Me.Controls.Add(Me.cmb_supervisor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "seleccionar_sup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "seleccionar_sup"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_ruta As Label
    Friend WithEvents btn_cambiar As Button
    Friend WithEvents cmb_supervisor As ComboBox
    Friend WithEvents Label1 As Label
End Class
