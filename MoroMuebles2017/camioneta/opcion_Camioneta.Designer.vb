<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcion_Camioneta
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
        Me.bt_salidas = New System.Windows.Forms.Button()
        Me.bt_entradas = New System.Windows.Forms.Button()
        Me.cmb_camioneta = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_ultimas_salidas = New System.Windows.Forms.DataGridView()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_chofer = New System.Windows.Forms.Label()
        Me.lbl_ultima_salida = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        CType(Me.dg_ultimas_salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(200, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECCIONA UNA CAMIONETA"
        '
        'bt_salidas
        '
        Me.bt_salidas.Enabled = False
        Me.bt_salidas.Location = New System.Drawing.Point(302, 62)
        Me.bt_salidas.Name = "bt_salidas"
        Me.bt_salidas.Size = New System.Drawing.Size(74, 40)
        Me.bt_salidas.TabIndex = 4
        Me.bt_salidas.Text = "NUEVA SALIDA"
        Me.bt_salidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_salidas.UseVisualStyleBackColor = True
        '
        'bt_entradas
        '
        Me.bt_entradas.Enabled = False
        Me.bt_entradas.Location = New System.Drawing.Point(48, 279)
        Me.bt_entradas.Name = "bt_entradas"
        Me.bt_entradas.Size = New System.Drawing.Size(120, 117)
        Me.bt_entradas.TabIndex = 3
        Me.bt_entradas.Text = "ENTRADAS"
        Me.bt_entradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_entradas.UseVisualStyleBackColor = True
        Me.bt_entradas.Visible = False
        '
        'cmb_camioneta
        '
        Me.cmb_camioneta.FormattingEnabled = True
        Me.cmb_camioneta.Location = New System.Drawing.Point(102, 82)
        Me.cmb_camioneta.Name = "cmb_camioneta"
        Me.cmb_camioneta.Size = New System.Drawing.Size(134, 21)
        Me.cmb_camioneta.TabIndex = 10
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(26, 90)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "CAMIONETA"
        '
        'dg_ultimas_salidas
        '
        Me.dg_ultimas_salidas.AllowUserToAddRows = False
        Me.dg_ultimas_salidas.AllowUserToDeleteRows = False
        Me.dg_ultimas_salidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_ultimas_salidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ultimas_salidas.Location = New System.Drawing.Point(29, 109)
        Me.dg_ultimas_salidas.Name = "dg_ultimas_salidas"
        Me.dg_ultimas_salidas.ReadOnly = True
        Me.dg_ultimas_salidas.Size = New System.Drawing.Size(311, 240)
        Me.dg_ultimas_salidas.TabIndex = 11
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave.Location = New System.Drawing.Point(181, 9)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(13, 13)
        Me.lbl_clave.TabIndex = 13
        Me.lbl_clave.Text = "0"
        '
        'lbl_chofer
        '
        Me.lbl_chofer.AutoSize = True
        Me.lbl_chofer.BackColor = System.Drawing.Color.Transparent
        Me.lbl_chofer.Location = New System.Drawing.Point(217, 9)
        Me.lbl_chofer.Name = "lbl_chofer"
        Me.lbl_chofer.Size = New System.Drawing.Size(19, 13)
        Me.lbl_chofer.TabIndex = 14
        Me.lbl_chofer.Text = "ch"
        '
        'lbl_ultima_salida
        '
        Me.lbl_ultima_salida.AutoSize = True
        Me.lbl_ultima_salida.BackColor = System.Drawing.Color.Transparent
        Me.lbl_ultima_salida.Location = New System.Drawing.Point(181, 34)
        Me.lbl_ultima_salida.Name = "lbl_ultima_salida"
        Me.lbl_ultima_salida.Size = New System.Drawing.Size(13, 13)
        Me.lbl_ultima_salida.TabIndex = 15
        Me.lbl_ultima_salida.Text = "0"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImage = Global.Captura.My.Resources.Resources.busqueda
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_buscar.Location = New System.Drawing.Point(242, 50)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(54, 52)
        Me.btn_buscar.TabIndex = 12
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'opcion_Camioneta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(384, 361)
        Me.Controls.Add(Me.lbl_ultima_salida)
        Me.Controls.Add(Me.lbl_chofer)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.dg_ultimas_salidas)
        Me.Controls.Add(Me.cmb_camioneta)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_salidas)
        Me.Controls.Add(Me.bt_entradas)
        Me.Name = "opcion_Camioneta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CAMIONETAS"
        CType(Me.dg_ultimas_salidas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bt_salidas As Button
    Friend WithEvents bt_entradas As Button
    Friend WithEvents cmb_camioneta As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents dg_ultimas_salidas As DataGridView
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_chofer As Label
    Friend WithEvents lbl_ultima_salida As Label
End Class
