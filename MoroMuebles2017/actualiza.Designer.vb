<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class actualiza
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
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.dg_provedor_principal = New System.Windows.Forms.DataGridView()
        Me.dg_articulos_principal = New System.Windows.Forms.DataGridView()
        Me.dg_personal_principal = New System.Windows.Forms.DataGridView()
        Me.dg_camionetas_principal = New System.Windows.Forms.DataGridView()
        Me.dg_motos_principal = New System.Windows.Forms.DataGridView()
        Me.dg_motos_local = New System.Windows.Forms.DataGridView()
        Me.dg_camionetas_local = New System.Windows.Forms.DataGridView()
        Me.dg_personal_local = New System.Windows.Forms.DataGridView()
        Me.dg_articulos_local = New System.Windows.Forms.DataGridView()
        Me.dg_provedor_local = New System.Windows.Forms.DataGridView()
        CType(Me.dg_provedor_principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_articulos_principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_personal_principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_camionetas_principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_motos_principal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_motos_local, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_camionetas_local, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_personal_local, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_articulos_local, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_provedor_local, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btn_guardar
        '
        Me.btn_guardar.Location = New System.Drawing.Point(588, 12)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(75, 23)
        Me.btn_guardar.TabIndex = 0
        Me.btn_guardar.Text = "GUARDAR"
        Me.btn_guardar.UseVisualStyleBackColor = True
        '
        'dg_provedor_principal
        '
        Me.dg_provedor_principal.AllowUserToAddRows = False
        Me.dg_provedor_principal.AllowUserToDeleteRows = False
        Me.dg_provedor_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_provedor_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_provedor_principal.Location = New System.Drawing.Point(12, 48)
        Me.dg_provedor_principal.Name = "dg_provedor_principal"
        Me.dg_provedor_principal.ReadOnly = True
        Me.dg_provedor_principal.Size = New System.Drawing.Size(240, 150)
        Me.dg_provedor_principal.TabIndex = 1
        '
        'dg_articulos_principal
        '
        Me.dg_articulos_principal.AllowUserToAddRows = False
        Me.dg_articulos_principal.AllowUserToDeleteRows = False
        Me.dg_articulos_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos_principal.Location = New System.Drawing.Point(258, 48)
        Me.dg_articulos_principal.Name = "dg_articulos_principal"
        Me.dg_articulos_principal.ReadOnly = True
        Me.dg_articulos_principal.Size = New System.Drawing.Size(240, 150)
        Me.dg_articulos_principal.TabIndex = 2
        '
        'dg_personal_principal
        '
        Me.dg_personal_principal.AllowUserToAddRows = False
        Me.dg_personal_principal.AllowUserToDeleteRows = False
        Me.dg_personal_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_personal_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_personal_principal.Location = New System.Drawing.Point(504, 48)
        Me.dg_personal_principal.Name = "dg_personal_principal"
        Me.dg_personal_principal.ReadOnly = True
        Me.dg_personal_principal.Size = New System.Drawing.Size(240, 150)
        Me.dg_personal_principal.TabIndex = 3
        '
        'dg_camionetas_principal
        '
        Me.dg_camionetas_principal.AllowUserToAddRows = False
        Me.dg_camionetas_principal.AllowUserToDeleteRows = False
        Me.dg_camionetas_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_camionetas_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_camionetas_principal.Location = New System.Drawing.Point(754, 48)
        Me.dg_camionetas_principal.Name = "dg_camionetas_principal"
        Me.dg_camionetas_principal.ReadOnly = True
        Me.dg_camionetas_principal.Size = New System.Drawing.Size(240, 150)
        Me.dg_camionetas_principal.TabIndex = 4
        '
        'dg_motos_principal
        '
        Me.dg_motos_principal.AllowUserToAddRows = False
        Me.dg_motos_principal.AllowUserToDeleteRows = False
        Me.dg_motos_principal.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_motos_principal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_motos_principal.Location = New System.Drawing.Point(12, 214)
        Me.dg_motos_principal.Name = "dg_motos_principal"
        Me.dg_motos_principal.ReadOnly = True
        Me.dg_motos_principal.Size = New System.Drawing.Size(240, 150)
        Me.dg_motos_principal.TabIndex = 5
        '
        'dg_motos_local
        '
        Me.dg_motos_local.AllowUserToAddRows = False
        Me.dg_motos_local.AllowUserToDeleteRows = False
        Me.dg_motos_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_motos_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_motos_local.Location = New System.Drawing.Point(12, 561)
        Me.dg_motos_local.Name = "dg_motos_local"
        Me.dg_motos_local.ReadOnly = True
        Me.dg_motos_local.Size = New System.Drawing.Size(240, 150)
        Me.dg_motos_local.TabIndex = 10
        '
        'dg_camionetas_local
        '
        Me.dg_camionetas_local.AllowUserToAddRows = False
        Me.dg_camionetas_local.AllowUserToDeleteRows = False
        Me.dg_camionetas_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_camionetas_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_camionetas_local.Location = New System.Drawing.Point(754, 395)
        Me.dg_camionetas_local.Name = "dg_camionetas_local"
        Me.dg_camionetas_local.ReadOnly = True
        Me.dg_camionetas_local.Size = New System.Drawing.Size(240, 150)
        Me.dg_camionetas_local.TabIndex = 9
        '
        'dg_personal_local
        '
        Me.dg_personal_local.AllowUserToAddRows = False
        Me.dg_personal_local.AllowUserToDeleteRows = False
        Me.dg_personal_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_personal_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_personal_local.Location = New System.Drawing.Point(504, 395)
        Me.dg_personal_local.Name = "dg_personal_local"
        Me.dg_personal_local.ReadOnly = True
        Me.dg_personal_local.Size = New System.Drawing.Size(240, 150)
        Me.dg_personal_local.TabIndex = 8
        '
        'dg_articulos_local
        '
        Me.dg_articulos_local.AllowUserToAddRows = False
        Me.dg_articulos_local.AllowUserToDeleteRows = False
        Me.dg_articulos_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_articulos_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_articulos_local.Location = New System.Drawing.Point(258, 395)
        Me.dg_articulos_local.Name = "dg_articulos_local"
        Me.dg_articulos_local.ReadOnly = True
        Me.dg_articulos_local.Size = New System.Drawing.Size(240, 150)
        Me.dg_articulos_local.TabIndex = 7
        '
        'dg_provedor_local
        '
        Me.dg_provedor_local.AllowUserToAddRows = False
        Me.dg_provedor_local.AllowUserToDeleteRows = False
        Me.dg_provedor_local.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_provedor_local.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_provedor_local.Location = New System.Drawing.Point(12, 395)
        Me.dg_provedor_local.Name = "dg_provedor_local"
        Me.dg_provedor_local.ReadOnly = True
        Me.dg_provedor_local.Size = New System.Drawing.Size(240, 150)
        Me.dg_provedor_local.TabIndex = 6
        '
        'actualiza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 824)
        Me.Controls.Add(Me.dg_motos_local)
        Me.Controls.Add(Me.dg_camionetas_local)
        Me.Controls.Add(Me.dg_personal_local)
        Me.Controls.Add(Me.dg_articulos_local)
        Me.Controls.Add(Me.dg_provedor_local)
        Me.Controls.Add(Me.dg_motos_principal)
        Me.Controls.Add(Me.dg_camionetas_principal)
        Me.Controls.Add(Me.dg_personal_principal)
        Me.Controls.Add(Me.dg_articulos_principal)
        Me.Controls.Add(Me.dg_provedor_principal)
        Me.Controls.Add(Me.btn_guardar)
        Me.Name = "actualiza"
        Me.Text = "actualiza"
        CType(Me.dg_provedor_principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_articulos_principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_personal_principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_camionetas_principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_motos_principal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_motos_local, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_camionetas_local, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_personal_local, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_articulos_local, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_provedor_local, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btn_guardar As Button
    Friend WithEvents dg_provedor_principal As DataGridView
    Friend WithEvents dg_articulos_principal As DataGridView
    Friend WithEvents dg_personal_principal As DataGridView
    Friend WithEvents dg_camionetas_principal As DataGridView
    Friend WithEvents dg_motos_principal As DataGridView
    Friend WithEvents dg_motos_local As DataGridView
    Friend WithEvents dg_camionetas_local As DataGridView
    Friend WithEvents dg_personal_local As DataGridView
    Friend WithEvents dg_articulos_local As DataGridView
    Friend WithEvents dg_provedor_local As DataGridView
End Class
