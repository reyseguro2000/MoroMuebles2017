<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listado_articulos_detalle
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
        Me.lbl_salidas = New System.Windows.Forms.Label()
        Me.lbl_entradas = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dg_salidas = New System.Windows.Forms.DataGridView()
        Me.dg_entradas = New System.Windows.Forms.DataGridView()
        Me.lbl_clave = New System.Windows.Forms.Label()
        Me.lbl_articulo = New System.Windows.Forms.Label()
        Me.op_ultimo = New System.Windows.Forms.RadioButton()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.op_inicio = New System.Windows.Forms.RadioButton()
        Me.lbl_ultimo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.op_ultimo_corte = New System.Windows.Forms.RadioButton()
        CType(Me.dg_salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_entradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_salidas
        '
        Me.lbl_salidas.AutoSize = True
        Me.lbl_salidas.Location = New System.Drawing.Point(351, 67)
        Me.lbl_salidas.Name = "lbl_salidas"
        Me.lbl_salidas.Size = New System.Drawing.Size(39, 13)
        Me.lbl_salidas.TabIndex = 22
        Me.lbl_salidas.Text = "Label8"
        '
        'lbl_entradas
        '
        Me.lbl_entradas.AutoSize = True
        Me.lbl_entradas.Location = New System.Drawing.Point(109, 67)
        Me.lbl_entradas.Name = "lbl_entradas"
        Me.lbl_entradas.Size = New System.Drawing.Size(39, 13)
        Me.lbl_entradas.TabIndex = 21
        Me.lbl_entradas.Text = "Label7"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(277, 67)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "SALIDAS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 13)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "ENTRADAS"
        '
        'dg_salidas
        '
        Me.dg_salidas.AllowUserToAddRows = False
        Me.dg_salidas.AllowUserToDeleteRows = False
        Me.dg_salidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_salidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_salidas.Location = New System.Drawing.Point(280, 83)
        Me.dg_salidas.Name = "dg_salidas"
        Me.dg_salidas.ReadOnly = True
        Me.dg_salidas.Size = New System.Drawing.Size(250, 297)
        Me.dg_salidas.TabIndex = 18
        '
        'dg_entradas
        '
        Me.dg_entradas.AllowUserToAddRows = False
        Me.dg_entradas.AllowUserToDeleteRows = False
        Me.dg_entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_entradas.Location = New System.Drawing.Point(14, 83)
        Me.dg_entradas.Name = "dg_entradas"
        Me.dg_entradas.ReadOnly = True
        Me.dg_entradas.Size = New System.Drawing.Size(250, 297)
        Me.dg_entradas.TabIndex = 17
        '
        'lbl_clave
        '
        Me.lbl_clave.AutoSize = True
        Me.lbl_clave.Location = New System.Drawing.Point(12, 9)
        Me.lbl_clave.Name = "lbl_clave"
        Me.lbl_clave.Size = New System.Drawing.Size(33, 13)
        Me.lbl_clave.TabIndex = 23
        Me.lbl_clave.Text = "clave"
        '
        'lbl_articulo
        '
        Me.lbl_articulo.AutoSize = True
        Me.lbl_articulo.Location = New System.Drawing.Point(67, 8)
        Me.lbl_articulo.Name = "lbl_articulo"
        Me.lbl_articulo.Size = New System.Drawing.Size(41, 13)
        Me.lbl_articulo.TabIndex = 24
        Me.lbl_articulo.Text = "articulo"
        '
        'op_ultimo
        '
        Me.op_ultimo.AutoSize = True
        Me.op_ultimo.Location = New System.Drawing.Point(282, 43)
        Me.op_ultimo.Name = "op_ultimo"
        Me.op_ultimo.Size = New System.Drawing.Size(135, 17)
        Me.op_ultimo.TabIndex = 25
        Me.op_ultimo.Text = "ULTIMO INVENTARIO"
        Me.op_ultimo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(148, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "VER MOVIMIENTOS DESDE"
        '
        'op_inicio
        '
        Me.op_inicio.AutoSize = True
        Me.op_inicio.Checked = True
        Me.op_inicio.Location = New System.Drawing.Point(165, 30)
        Me.op_inicio.Name = "op_inicio"
        Me.op_inicio.Size = New System.Drawing.Size(57, 17)
        Me.op_inicio.TabIndex = 27
        Me.op_inicio.TabStop = True
        Me.op_inicio.Text = "INICIO"
        Me.op_inicio.UseVisualStyleBackColor = True
        '
        'lbl_ultimo
        '
        Me.lbl_ultimo.AutoSize = True
        Me.lbl_ultimo.Location = New System.Drawing.Point(422, 22)
        Me.lbl_ultimo.Name = "lbl_ultimo"
        Me.lbl_ultimo.Size = New System.Drawing.Size(106, 13)
        Me.lbl_ultimo.TabIndex = 28
        Me.lbl_ultimo.Text = "2016-04-26 13:00:00"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(422, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 30
        Me.Label1.Text = "2016-04-26 13:00:00"
        '
        'op_ultimo_corte
        '
        Me.op_ultimo_corte.AutoSize = True
        Me.op_ultimo_corte.Location = New System.Drawing.Point(280, 18)
        Me.op_ultimo_corte.Name = "op_ultimo_corte"
        Me.op_ultimo_corte.Size = New System.Drawing.Size(106, 17)
        Me.op_ultimo_corte.TabIndex = 29
        Me.op_ultimo_corte.Text = "ULTIMO CORTE"
        Me.op_ultimo_corte.UseVisualStyleBackColor = True
        '
        'listado_articulos_detalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(546, 437)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.op_ultimo_corte)
        Me.Controls.Add(Me.lbl_ultimo)
        Me.Controls.Add(Me.op_inicio)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.op_ultimo)
        Me.Controls.Add(Me.lbl_articulo)
        Me.Controls.Add(Me.lbl_clave)
        Me.Controls.Add(Me.lbl_salidas)
        Me.Controls.Add(Me.lbl_entradas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.dg_salidas)
        Me.Controls.Add(Me.dg_entradas)
        Me.Name = "listado_articulos_detalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLES DEL ARTICULO"
        CType(Me.dg_salidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_entradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_salidas As Label
    Friend WithEvents lbl_entradas As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents dg_salidas As DataGridView
    Friend WithEvents dg_entradas As DataGridView
    Friend WithEvents lbl_clave As Label
    Friend WithEvents lbl_articulo As Label
    Friend WithEvents op_ultimo As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents op_inicio As RadioButton
    Friend WithEvents lbl_ultimo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents op_ultimo_corte As RadioButton
End Class
