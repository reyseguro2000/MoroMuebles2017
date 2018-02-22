<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class nuevo_taller
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.txt_taller = New System.Windows.Forms.TextBox()
        Me.txt_encargado = New System.Windows.Forms.TextBox()
        Me.txt_calle = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_colonia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "TALLER"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(75, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ENCARGADO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "CALLE"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 146)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(64, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "TELÉFONO"
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(97, 165)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 4
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'txt_taller
        '
        Me.txt_taller.Location = New System.Drawing.Point(97, 32)
        Me.txt_taller.Name = "txt_taller"
        Me.txt_taller.Size = New System.Drawing.Size(320, 20)
        Me.txt_taller.TabIndex = 5
        '
        'txt_encargado
        '
        Me.txt_encargado.Location = New System.Drawing.Point(97, 60)
        Me.txt_encargado.Name = "txt_encargado"
        Me.txt_encargado.Size = New System.Drawing.Size(320, 20)
        Me.txt_encargado.TabIndex = 6
        '
        'txt_calle
        '
        Me.txt_calle.Location = New System.Drawing.Point(97, 87)
        Me.txt_calle.Name = "txt_calle"
        Me.txt_calle.Size = New System.Drawing.Size(320, 20)
        Me.txt_calle.TabIndex = 7
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(97, 139)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(320, 20)
        Me.txt_telefono.TabIndex = 8
        '
        'txt_colonia
        '
        Me.txt_colonia.Location = New System.Drawing.Point(97, 112)
        Me.txt_colonia.Name = "txt_colonia"
        Me.txt_colonia.Size = New System.Drawing.Size(320, 20)
        Me.txt_colonia.TabIndex = 10
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 119)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(54, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "COLONIA"
        '
        'nuevo_taller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(445, 216)
        Me.Controls.Add(Me.txt_colonia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txt_telefono)
        Me.Controls.Add(Me.txt_calle)
        Me.Controls.Add(Me.txt_encargado)
        Me.Controls.Add(Me.txt_taller)
        Me.Controls.Add(Me.btn_guardar)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "nuevo_taller"
        Me.Text = "ALTA DE TALLER"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents btn_guardar As Button
    Friend WithEvents txt_taller As TextBox
    Friend WithEvents txt_encargado As TextBox
    Friend WithEvents txt_calle As TextBox
    Friend WithEvents txt_telefono As TextBox
    Friend WithEvents txt_colonia As TextBox
    Friend WithEvents Label5 As Label
End Class
