<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class opcion_Taller
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.bt_salidas = New System.Windows.Forms.Button()
        Me.bt_entradas = New System.Windows.Forms.Button()
        Me.dtg_salida_taller = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmb_taller = New System.Windows.Forms.ComboBox()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.btn_taller = New System.Windows.Forms.Button()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_taller = New System.Windows.Forms.Label()
        CType(Me.dtg_salida_taller, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(25, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "MERCANCIA EN TALLER"
        '
        'bt_salidas
        '
        Me.bt_salidas.Enabled = False
        Me.bt_salidas.Location = New System.Drawing.Point(291, 66)
        Me.bt_salidas.Name = "bt_salidas"
        Me.bt_salidas.Size = New System.Drawing.Size(81, 37)
        Me.bt_salidas.TabIndex = 4
        Me.bt_salidas.Text = "NUEVA SALIDA"
        Me.bt_salidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_salidas.UseVisualStyleBackColor = True
        '
        'bt_entradas
        '
        Me.bt_entradas.Location = New System.Drawing.Point(28, 312)
        Me.bt_entradas.Name = "bt_entradas"
        Me.bt_entradas.Size = New System.Drawing.Size(81, 37)
        Me.bt_entradas.TabIndex = 3
        Me.bt_entradas.Text = "ENTRADAS"
        Me.bt_entradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_entradas.UseVisualStyleBackColor = True
        Me.bt_entradas.Visible = False
        '
        'dtg_salida_taller
        '
        Me.dtg_salida_taller.AllowUserToAddRows = False
        Me.dtg_salida_taller.AllowUserToDeleteRows = False
        Me.dtg_salida_taller.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dtg_salida_taller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtg_salida_taller.Location = New System.Drawing.Point(28, 115)
        Me.dtg_salida_taller.Name = "dtg_salida_taller"
        Me.dtg_salida_taller.ReadOnly = True
        Me.dtg_salida_taller.Size = New System.Drawing.Size(344, 174)
        Me.dtg_salida_taller.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(109, 23)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(48, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "TALLER"
        '
        'cmb_taller
        '
        Me.cmb_taller.FormattingEnabled = True
        Me.cmb_taller.Location = New System.Drawing.Point(112, 39)
        Me.cmb_taller.Name = "cmb_taller"
        Me.cmb_taller.Size = New System.Drawing.Size(170, 21)
        Me.cmb_taller.TabIndex = 8
        '
        'btn_buscar
        '
        Me.btn_buscar.Location = New System.Drawing.Point(288, 10)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(61, 50)
        Me.btn_buscar.TabIndex = 13
        Me.btn_buscar.Text = "BUSCAR"
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'btn_taller
        '
        Me.btn_taller.Location = New System.Drawing.Point(164, 10)
        Me.btn_taller.Name = "btn_taller"
        Me.btn_taller.Size = New System.Drawing.Size(24, 23)
        Me.btn_taller.TabIndex = 14
        Me.btn_taller.Text = "+"
        Me.btn_taller.UseVisualStyleBackColor = True
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave.Location = New System.Drawing.Point(33, 99)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(39, 13)
        Me.lbl_clave.TabIndex = 15
        Me.lbl_clave.Text = "Label3"
        '
        'lbl_taller
        '
        Me.lbl_taller.AutoSize = True
        Me.lbl_taller.BackColor = System.Drawing.Color.Transparent
        Me.lbl_taller.Location = New System.Drawing.Point(78, 99)
        Me.lbl_taller.Name = "lbl_taller"
        Me.lbl_taller.Size = New System.Drawing.Size(39, 13)
        Me.lbl_taller.TabIndex = 16
        Me.lbl_taller.Text = "Label4"
        '
        'opcion_Taller
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.lbl_taller)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.btn_taller)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cmb_taller)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dtg_salida_taller)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_salidas)
        Me.Controls.Add(Me.bt_entradas)
        Me.Name = "opcion_Taller"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "TALLER"
        CType(Me.dtg_salida_taller, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bt_salidas As Button
    Friend WithEvents bt_entradas As Button
    Friend WithEvents dtg_salida_taller As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents cmb_taller As ComboBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents btn_taller As Button
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_taller As Label
End Class
