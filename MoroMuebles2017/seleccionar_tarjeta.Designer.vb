<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class seleccionar_tarjeta
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
        Me.btn_chicas = New System.Windows.Forms.Button()
        Me.btn_grandes = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btn_chicas
        '
        Me.btn_chicas.Location = New System.Drawing.Point(6, 70)
        Me.btn_chicas.Name = "btn_chicas"
        Me.btn_chicas.Size = New System.Drawing.Size(130, 130)
        Me.btn_chicas.TabIndex = 0
        Me.btn_chicas.Text = "CHICAS"
        Me.btn_chicas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_chicas.UseVisualStyleBackColor = True
        '
        'btn_grandes
        '
        Me.btn_grandes.Location = New System.Drawing.Point(142, 70)
        Me.btn_grandes.Name = "btn_grandes"
        Me.btn_grandes.Size = New System.Drawing.Size(130, 130)
        Me.btn_grandes.TabIndex = 1
        Me.btn_grandes.Text = "GRANDES"
        Me.btn_grandes.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btn_grandes.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(51, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SELECCIONA EL TIPO DE TARJETA"
        '
        'seleccionar_tarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 261)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btn_grandes)
        Me.Controls.Add(Me.btn_chicas)
        Me.Name = "seleccionar_tarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SELECCION DE FOMRATO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btn_chicas As Button
    Friend WithEvents btn_grandes As Button
    Friend WithEvents Label1 As Label
End Class
