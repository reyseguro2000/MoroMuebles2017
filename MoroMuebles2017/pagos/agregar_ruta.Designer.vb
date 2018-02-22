<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class agregar_ruta
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
        Me.cmb_supervisor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_cobrador = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ruta = New System.Windows.Forms.NumericUpDown()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.btn_validar = New System.Windows.Forms.Button()
        Me.lbl_ruta = New System.Windows.Forms.Label()
        CType(Me.txt_ruta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'cmb_supervisor
        '
        Me.cmb_supervisor.FormattingEnabled = True
        Me.cmb_supervisor.Location = New System.Drawing.Point(95, 48)
        Me.cmb_supervisor.Name = "cmb_supervisor"
        Me.cmb_supervisor.Size = New System.Drawing.Size(218, 21)
        Me.cmb_supervisor.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "SUPERVISOR"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 93)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "COBRADOR"
        '
        'cmb_cobrador
        '
        Me.cmb_cobrador.FormattingEnabled = True
        Me.cmb_cobrador.Location = New System.Drawing.Point(95, 85)
        Me.cmb_cobrador.Name = "cmb_cobrador"
        Me.cmb_cobrador.Size = New System.Drawing.Size(218, 21)
        Me.cmb_cobrador.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "RUTA"
        '
        'txt_ruta
        '
        Me.txt_ruta.Location = New System.Drawing.Point(192, 13)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(39, 20)
        Me.txt_ruta.TabIndex = 6
        Me.txt_ruta.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(218, 112)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(95, 23)
        Me.btn_guardar.TabIndex = 7
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'btn_validar
        '
        Me.btn_validar.Location = New System.Drawing.Point(237, 13)
        Me.btn_validar.Name = "btn_validar"
        Me.btn_validar.Size = New System.Drawing.Size(75, 23)
        Me.btn_validar.TabIndex = 8
        Me.btn_validar.Text = "VER"
        Me.btn_validar.UseVisualStyleBackColor = True
        '
        'lbl_ruta
        '
        Me.lbl_ruta.AutoSize = True
        Me.lbl_ruta.Location = New System.Drawing.Point(92, 23)
        Me.lbl_ruta.Name = "lbl_ruta"
        Me.lbl_ruta.Size = New System.Drawing.Size(39, 13)
        Me.lbl_ruta.TabIndex = 9
        Me.lbl_ruta.Text = "Label4"
        '
        'agregar_ruta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(393, 178)
        Me.Controls.Add(Me.lbl_ruta)
        Me.Controls.Add(Me.btn_validar)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.txt_ruta)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmb_cobrador)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmb_supervisor)
        Me.Name = "agregar_ruta"
        Me.Text = "agregar_ruta"
        CType(Me.txt_ruta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmb_supervisor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_cobrador As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_ruta As NumericUpDown
    Friend WithEvents btn_guardar As Button
    Friend WithEvents btn_validar As Button
    Friend WithEvents lbl_ruta As Label
End Class
