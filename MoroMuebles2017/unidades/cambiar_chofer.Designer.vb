<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cambiar_chofer
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.lbl_tipo = New System.Windows.Forms.Label()
        Me.lbl_unidad = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbl_chofer = New System.Windows.Forms.Label()
        Me.cmb_chofer = New System.Windows.Forms.ComboBox()
        Me.btn_cambiar = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_motivo = New System.Windows.Forms.TextBox()
        Me.DGmovimientos_unidad = New System.Windows.Forms.DataGridView()
        CType(Me.DGmovimientos_unidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_tipo
        '
        Me.lbl_tipo.AutoSize = True
        Me.lbl_tipo.BackColor = System.Drawing.Color.Transparent
        Me.lbl_tipo.Location = New System.Drawing.Point(120, 9)
        Me.lbl_tipo.Name = "lbl_tipo"
        Me.lbl_tipo.Size = New System.Drawing.Size(39, 13)
        Me.lbl_tipo.TabIndex = 0
        Me.lbl_tipo.Text = "Label1"
        '
        'lbl_unidad
        '
        Me.lbl_unidad.AutoSize = True
        Me.lbl_unidad.BackColor = System.Drawing.Color.Transparent
        Me.lbl_unidad.Location = New System.Drawing.Point(175, 9)
        Me.lbl_unidad.Name = "lbl_unidad"
        Me.lbl_unidad.Size = New System.Drawing.Size(39, 13)
        Me.lbl_unidad.TabIndex = 1
        Me.lbl_unidad.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(12, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "CHOFER"
        '
        'lbl_chofer
        '
        Me.lbl_chofer.AutoSize = True
        Me.lbl_chofer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_chofer.Location = New System.Drawing.Point(220, 9)
        Me.lbl_chofer.Name = "lbl_chofer"
        Me.lbl_chofer.Size = New System.Drawing.Size(39, 13)
        Me.lbl_chofer.TabIndex = 3
        Me.lbl_chofer.Text = "Label2"
        '
        'cmb_chofer
        '
        Me.cmb_chofer.FormattingEnabled = True
        Me.cmb_chofer.Location = New System.Drawing.Point(87, 43)
        Me.cmb_chofer.Name = "cmb_chofer"
        Me.cmb_chofer.Size = New System.Drawing.Size(280, 21)
        Me.cmb_chofer.TabIndex = 4
        '
        'btn_cambiar
        '
        Me.btn_cambiar.BackgroundImage = Global.Captura.My.Resources.Resources.Cambiochofer_mor
        Me.btn_cambiar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cambiar.Location = New System.Drawing.Point(371, 18)
        Me.btn_cambiar.Name = "btn_cambiar"
        Me.btn_cambiar.Size = New System.Drawing.Size(101, 79)
        Me.btn_cambiar.TabIndex = 5
        Me.btn_cambiar.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(12, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "MOTIVO"
        '
        'txt_motivo
        '
        Me.txt_motivo.Location = New System.Drawing.Point(87, 76)
        Me.txt_motivo.Name = "txt_motivo"
        Me.txt_motivo.Size = New System.Drawing.Size(278, 20)
        Me.txt_motivo.TabIndex = 7
        '
        'DGmovimientos_unidad
        '
        Me.DGmovimientos_unidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGmovimientos_unidad.Location = New System.Drawing.Point(19, 102)
        Me.DGmovimientos_unidad.Name = "DGmovimientos_unidad"
        Me.DGmovimientos_unidad.Size = New System.Drawing.Size(453, 197)
        Me.DGmovimientos_unidad.TabIndex = 8
        '
        'cambiar_chofer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(484, 311)
        Me.Controls.Add(Me.DGmovimientos_unidad)
        Me.Controls.Add(Me.txt_motivo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cambiar)
        Me.Controls.Add(Me.cmb_chofer)
        Me.Controls.Add(Me.lbl_chofer)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl_unidad)
        Me.Controls.Add(Me.lbl_tipo)
        Me.Name = "cambiar_chofer"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMBIO DE CHOFER"
        CType(Me.DGmovimientos_unidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_tipo As Label
    Friend WithEvents lbl_unidad As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents lbl_chofer As Label
    Friend WithEvents cmb_chofer As ComboBox
    Friend WithEvents btn_cambiar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_motivo As TextBox
    Friend WithEvents DGmovimientos_unidad As DataGridView
End Class
