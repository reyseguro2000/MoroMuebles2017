<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class detalle_carga
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
        Me.validar = New System.Windows.Forms.Button()
        Me.lblmovimiento = New System.Windows.Forms.Label()
        Me.txtfolio = New System.Windows.Forms.TextBox()
        Me.cambiarboton = New System.Windows.Forms.Button()
        Me.guardarboton = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblarticulo = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.detalle = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbl_salida = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'validar
        '
        Me.validar.Enabled = False
        Me.validar.Location = New System.Drawing.Point(235, 9)
        Me.validar.Name = "validar"
        Me.validar.Size = New System.Drawing.Size(110, 50)
        Me.validar.TabIndex = 28
        Me.validar.Text = "VERIFICAR MERCANCIA CARGADA"
        Me.validar.UseVisualStyleBackColor = True
        '
        'lblmovimiento
        '
        Me.lblmovimiento.AutoSize = True
        Me.lblmovimiento.Location = New System.Drawing.Point(235, 9)
        Me.lblmovimiento.Name = "lblmovimiento"
        Me.lblmovimiento.Size = New System.Drawing.Size(39, 13)
        Me.lblmovimiento.TabIndex = 27
        Me.lblmovimiento.Text = "Label4"
        '
        'txtfolio
        '
        Me.txtfolio.AutoCompleteCustomSource.AddRange(New String() {"PENDIENTE", "REGRESO"})
        Me.txtfolio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtfolio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtfolio.Location = New System.Drawing.Point(55, 20)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.Size = New System.Drawing.Size(93, 20)
        Me.txtfolio.TabIndex = 26
        '
        'cambiarboton
        '
        Me.cambiarboton.Enabled = False
        Me.cambiarboton.Location = New System.Drawing.Point(154, 20)
        Me.cambiarboton.Name = "cambiarboton"
        Me.cambiarboton.Size = New System.Drawing.Size(75, 23)
        Me.cambiarboton.TabIndex = 25
        Me.cambiarboton.Text = "CAMBIAR"
        Me.cambiarboton.UseVisualStyleBackColor = True
        '
        'guardarboton
        '
        Me.guardarboton.Enabled = False
        Me.guardarboton.Location = New System.Drawing.Point(351, 11)
        Me.guardarboton.Name = "guardarboton"
        Me.guardarboton.Size = New System.Drawing.Size(110, 47)
        Me.guardarboton.TabIndex = 24
        Me.guardarboton.Text = "CARGA DE CAMIONETA REVISADA"
        Me.guardarboton.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 23
        Me.Label5.Text = "FOLIO"
        '
        'lblarticulo
        '
        Me.lblarticulo.AutoSize = True
        Me.lblarticulo.Location = New System.Drawing.Point(280, 9)
        Me.lblarticulo.Name = "lblarticulo"
        Me.lblarticulo.Size = New System.Drawing.Size(39, 13)
        Me.lblarticulo.TabIndex = 22
        Me.lblarticulo.Text = "Label4"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(179, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "SALIDA"
        '
        'detalle
        '
        Me.detalle.AllowUserToAddRows = False
        Me.detalle.AllowUserToDeleteRows = False
        Me.detalle.AllowUserToOrderColumns = True
        Me.detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalle.Location = New System.Drawing.Point(12, 96)
        Me.detalle.Name = "detalle"
        Me.detalle.ReadOnly = True
        Me.detalle.Size = New System.Drawing.Size(469, 322)
        Me.detalle.TabIndex = 20
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "SALIDA"
        '
        'lbl_salida
        '
        Me.lbl_salida.AutoSize = True
        Me.lbl_salida.Location = New System.Drawing.Point(71, 10)
        Me.lbl_salida.Name = "lbl_salida"
        Me.lbl_salida.Size = New System.Drawing.Size(50, 13)
        Me.lbl_salida.TabIndex = 31
        Me.lbl_salida.Text = "lbl_salida"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.validar)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.guardarboton)
        Me.GroupBox1.Controls.Add(Me.txtfolio)
        Me.GroupBox1.Controls.Add(Me.cambiarboton)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 25)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(469, 65)
        Me.GroupBox1.TabIndex = 32
        Me.GroupBox1.TabStop = False
        '
        'detalle_carga
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(502, 430)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lbl_salida)
        Me.Controls.Add(Me.detalle)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblmovimiento)
        Me.Controls.Add(Me.lblarticulo)
        Me.Name = "detalle_carga"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "DETALLE DE SALIDA"
        CType(Me.detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents validar As Button
    Friend WithEvents lblmovimiento As Label
    Friend WithEvents txtfolio As TextBox
    Friend WithEvents cambiarboton As Button
    Friend WithEvents guardarboton As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents lblarticulo As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents detalle As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents lbl_salida As Label
    Friend WithEvents GroupBox1 As GroupBox
End Class
