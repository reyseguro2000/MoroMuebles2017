<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcion_Fabrica
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
        Me.dg_pendientes = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dg_compras = New System.Windows.Forms.DataGridView()
        Me.cmb_provedor = New System.Windows.Forms.ComboBox()
        Me.lbl_nombre_provedor = New System.Windows.Forms.Label()
        Me.lbl_clave_prov = New System.Windows.Forms.Label()
        Me.btn_buscar = New System.Windows.Forms.Button()
        Me.bt_salidas = New System.Windows.Forms.Button()
        Me.bt_entradas = New System.Windows.Forms.Button()
        CType(Me.dg_pendientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_compras, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(130, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(157, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "SELECCIONA UN PROVEDOR"
        '
        'dg_pendientes
        '
        Me.dg_pendientes.AllowUserToAddRows = False
        Me.dg_pendientes.AllowUserToDeleteRows = False
        Me.dg_pendientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_pendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_pendientes.Location = New System.Drawing.Point(31, 311)
        Me.dg_pendientes.Name = "dg_pendientes"
        Me.dg_pendientes.ReadOnly = True
        Me.dg_pendientes.Size = New System.Drawing.Size(385, 123)
        Me.dg_pendientes.TabIndex = 37
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Location = New System.Drawing.Point(28, 295)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "PENDIENTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(130, 60)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(116, 13)
        Me.Label5.TabIndex = 42
        Me.Label5.Text = "ULTIMAS ENTRADAS"
        '
        'dg_compras
        '
        Me.dg_compras.AllowUserToAddRows = False
        Me.dg_compras.AllowUserToDeleteRows = False
        Me.dg_compras.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_compras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_compras.Location = New System.Drawing.Point(31, 74)
        Me.dg_compras.Name = "dg_compras"
        Me.dg_compras.ReadOnly = True
        Me.dg_compras.Size = New System.Drawing.Size(385, 195)
        Me.dg_compras.TabIndex = 41
        '
        'cmb_provedor
        '
        Me.cmb_provedor.FormattingEnabled = True
        Me.cmb_provedor.Location = New System.Drawing.Point(133, 32)
        Me.cmb_provedor.Name = "cmb_provedor"
        Me.cmb_provedor.Size = New System.Drawing.Size(283, 21)
        Me.cmb_provedor.TabIndex = 44
        '
        'lbl_nombre_provedor
        '
        Me.lbl_nombre_provedor.AutoSize = True
        Me.lbl_nombre_provedor.BackColor = System.Drawing.Color.Transparent
        Me.lbl_nombre_provedor.Location = New System.Drawing.Point(208, 284)
        Me.lbl_nombre_provedor.Name = "lbl_nombre_provedor"
        Me.lbl_nombre_provedor.Size = New System.Drawing.Size(52, 13)
        Me.lbl_nombre_provedor.TabIndex = 47
        Me.lbl_nombre_provedor.Text = "SALIDAS"
        '
        'lbl_clave_prov
        '
        Me.lbl_clave_prov.AutoSize = True
        Me.lbl_clave_prov.BackColor = System.Drawing.Color.Transparent
        Me.lbl_clave_prov.Location = New System.Drawing.Point(130, 284)
        Me.lbl_clave_prov.Name = "lbl_clave_prov"
        Me.lbl_clave_prov.Size = New System.Drawing.Size(66, 13)
        Me.lbl_clave_prov.TabIndex = 46
        Me.lbl_clave_prov.Text = "ENTRADAS"
        '
        'btn_buscar
        '
        Me.btn_buscar.BackgroundImage = Global.Captura.My.Resources.Resources.busqueda
        Me.btn_buscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_buscar.Location = New System.Drawing.Point(422, 16)
        Me.btn_buscar.Name = "btn_buscar"
        Me.btn_buscar.Size = New System.Drawing.Size(100, 100)
        Me.btn_buscar.TabIndex = 45
        Me.btn_buscar.UseVisualStyleBackColor = True
        '
        'bt_salidas
        '
        Me.bt_salidas.BackgroundImage = Global.Captura.My.Resources.Resources.Salidas_mor
        Me.bt_salidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_salidas.Enabled = False
        Me.bt_salidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_salidas.Location = New System.Drawing.Point(422, 228)
        Me.bt_salidas.Name = "bt_salidas"
        Me.bt_salidas.Size = New System.Drawing.Size(100, 100)
        Me.bt_salidas.TabIndex = 1
        Me.bt_salidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_salidas.UseVisualStyleBackColor = True
        '
        'bt_entradas
        '
        Me.bt_entradas.BackgroundImage = Global.Captura.My.Resources.Resources.Entradas_mor
        Me.bt_entradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_entradas.Enabled = False
        Me.bt_entradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_entradas.Location = New System.Drawing.Point(422, 122)
        Me.bt_entradas.Name = "bt_entradas"
        Me.bt_entradas.Size = New System.Drawing.Size(100, 100)
        Me.bt_entradas.TabIndex = 0
        Me.bt_entradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_entradas.UseVisualStyleBackColor = True
        '
        'opcion_Fabrica
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(534, 461)
        Me.Controls.Add(Me.lbl_nombre_provedor)
        Me.Controls.Add(Me.lbl_clave_prov)
        Me.Controls.Add(Me.btn_buscar)
        Me.Controls.Add(Me.cmb_provedor)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.dg_compras)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg_pendientes)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_salidas)
        Me.Controls.Add(Me.bt_entradas)
        Me.Name = "opcion_Fabrica"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PROVEDOR"
        CType(Me.dg_pendientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_compras, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bt_entradas As Button
    Friend WithEvents bt_salidas As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents dg_pendientes As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dg_compras As DataGridView
    Friend WithEvents cmb_provedor As ComboBox
    Friend WithEvents btn_buscar As Button
    Friend WithEvents lbl_nombre_provedor As Label
    Friend WithEvents lbl_clave_prov As Label
End Class
