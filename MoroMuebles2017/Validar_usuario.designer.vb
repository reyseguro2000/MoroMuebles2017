<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Validar_usuario
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
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.txt_servidor = New System.Windows.Forms.TextBox()
        Me.btn_ver = New System.Windows.Forms.Button()
        Me.txt_base = New System.Windows.Forms.TextBox()
        Me.lbl_muebleria = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.img_logo = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label5.Location = New System.Drawing.Point(26, 93)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(114, 19)
        Me.Label5.TabIndex = 14
        Me.Label5.Text = "CONTRASEÑA"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label6.Location = New System.Drawing.Point(26, 52)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 19)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "USUARIO"
        '
        'TextBox2
        '
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(153, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(38)
        Me.TextBox2.Size = New System.Drawing.Size(207, 31)
        Me.TextBox2.TabIndex = 10
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(153, 45)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(207, 31)
        Me.TextBox1.TabIndex = 9
        '
        'txt_servidor
        '
        Me.txt_servidor.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_servidor.Location = New System.Drawing.Point(55, 241)
        Me.txt_servidor.Name = "txt_servidor"
        Me.txt_servidor.Size = New System.Drawing.Size(207, 31)
        Me.txt_servidor.TabIndex = 19
        Me.txt_servidor.Text = "localhost"
        '
        'btn_ver
        '
        Me.btn_ver.Location = New System.Drawing.Point(268, 248)
        Me.btn_ver.Name = "btn_ver"
        Me.btn_ver.Size = New System.Drawing.Size(75, 23)
        Me.btn_ver.TabIndex = 20
        Me.btn_ver.Text = "..."
        Me.btn_ver.UseVisualStyleBackColor = True
        Me.btn_ver.Visible = False
        '
        'txt_base
        '
        Me.txt_base.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_base.Location = New System.Drawing.Point(55, 278)
        Me.txt_base.Name = "txt_base"
        Me.txt_base.Size = New System.Drawing.Size(207, 31)
        Me.txt_base.TabIndex = 21
        Me.txt_base.Text = "moroleon"
        Me.txt_base.Visible = False
        '
        'lbl_muebleria
        '
        Me.lbl_muebleria.AutoSize = True
        Me.lbl_muebleria.BackColor = System.Drawing.Color.Transparent
        Me.lbl_muebleria.Font = New System.Drawing.Font("Broadway", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_muebleria.Location = New System.Drawing.Point(40, 502)
        Me.lbl_muebleria.Name = "lbl_muebleria"
        Me.lbl_muebleria.Size = New System.Drawing.Size(301, 27)
        Me.lbl_muebleria.TabIndex = 22
        Me.lbl_muebleria.Text = "nombre de muebleria"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Broadway", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(118, 461)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "MUEBLERIA"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(343, 9)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(42, 13)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "1.00pm"
        '
        'img_logo
        '
        Me.img_logo.Location = New System.Drawing.Point(122, 532)
        Me.img_logo.Name = "img_logo"
        Me.img_logo.Size = New System.Drawing.Size(138, 83)
        Me.img_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img_logo.TabIndex = 16
        Me.img_logo.TabStop = False
        '
        'Button2
        '
        Me.Button2.BackgroundImage = Global.Captura.My.Resources.Resources.SALIR_mor
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(215, 125)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(94, 93)
        Me.Button2.TabIndex = 12
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackgroundImage = Global.Captura.My.Resources.Resources.ENTRAR_mor
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Location = New System.Drawing.Point(71, 125)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(108, 93)
        Me.Button1.TabIndex = 11
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Validar_usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImage = Global.Captura.My.Resources.Resources.Fondo4
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(389, 244)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lbl_muebleria)
        Me.Controls.Add(Me.txt_base)
        Me.Controls.Add(Me.btn_ver)
        Me.Controls.Add(Me.txt_servidor)
        Me.Controls.Add(Me.img_logo)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Validar_usuario"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BIENVENIDO"
        CType(Me.img_logo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents img_logo As PictureBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents txt_servidor As TextBox
    Friend WithEvents btn_ver As Button
    Friend WithEvents txt_base As TextBox
    Friend WithEvents lbl_muebleria As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
End Class
