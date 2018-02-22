<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class entradas_camioneta
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.salidas = New System.Windows.Forms.DataGridView()
        Me.chofer = New System.Windows.Forms.ListBox()
        Me.detalle = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lblarticulo = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.guardarboton = New System.Windows.Forms.Button()
        Me.cambiarboton = New System.Windows.Forms.Button()
        Me.lblmovimiento = New System.Windows.Forms.Label()
        Me.validar = New System.Windows.Forms.Button()
        Me.txtfolio = New System.Windows.Forms.TextBox()
        Me.lblsailda = New System.Windows.Forms.Label()
        Me.lblclave = New System.Windows.Forms.Label()
        CType(Me.salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.detalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "CHOFER"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(145, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "FECHA"
        '
        'salidas
        '
        Me.salidas.AllowUserToAddRows = False
        Me.salidas.AllowUserToDeleteRows = False
        Me.salidas.AllowUserToOrderColumns = True
        Me.salidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.salidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.salidas.Location = New System.Drawing.Point(275, 33)
        Me.salidas.Name = "salidas"
        Me.salidas.ReadOnly = True
        Me.salidas.Size = New System.Drawing.Size(441, 133)
        Me.salidas.TabIndex = 6
        '
        'chofer
        '
        Me.chofer.FormattingEnabled = True
        Me.chofer.Location = New System.Drawing.Point(29, 33)
        Me.chofer.Name = "chofer"
        Me.chofer.Size = New System.Drawing.Size(240, 134)
        Me.chofer.TabIndex = 7
        '
        'detalle
        '
        Me.detalle.AllowUserToAddRows = False
        Me.detalle.AllowUserToDeleteRows = False
        Me.detalle.AllowUserToOrderColumns = True
        Me.detalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.detalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.detalle.Location = New System.Drawing.Point(29, 172)
        Me.detalle.Name = "detalle"
        Me.detalle.ReadOnly = True
        Me.detalle.Size = New System.Drawing.Size(448, 249)
        Me.detalle.TabIndex = 8
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(483, 182)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SALIDA"
        '
        'lblarticulo
        '
        Me.lblarticulo.AutoSize = True
        Me.lblarticulo.Location = New System.Drawing.Point(584, 182)
        Me.lblarticulo.Name = "lblarticulo"
        Me.lblarticulo.Size = New System.Drawing.Size(39, 13)
        Me.lblarticulo.TabIndex = 10
        Me.lblarticulo.Text = "Label4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(483, 216)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "FOLIO"
        '
        'guardarboton
        '
        Me.guardarboton.Enabled = False
        Me.guardarboton.Location = New System.Drawing.Point(647, 361)
        Me.guardarboton.Name = "guardarboton"
        Me.guardarboton.Size = New System.Drawing.Size(137, 60)
        Me.guardarboton.TabIndex = 13
        Me.guardarboton.Text = "CARGA DE CAMIONETA REVISADA"
        Me.guardarboton.UseVisualStyleBackColor = True
        '
        'cambiarboton
        '
        Me.cambiarboton.Enabled = False
        Me.cambiarboton.Location = New System.Drawing.Point(641, 211)
        Me.cambiarboton.Name = "cambiarboton"
        Me.cambiarboton.Size = New System.Drawing.Size(75, 23)
        Me.cambiarboton.TabIndex = 14
        Me.cambiarboton.Text = "CAMBIAR"
        Me.cambiarboton.UseVisualStyleBackColor = True
        '
        'lblmovimiento
        '
        Me.lblmovimiento.AutoSize = True
        Me.lblmovimiento.Location = New System.Drawing.Point(539, 182)
        Me.lblmovimiento.Name = "lblmovimiento"
        Me.lblmovimiento.Size = New System.Drawing.Size(39, 13)
        Me.lblmovimiento.TabIndex = 16
        Me.lblmovimiento.Text = "Label4"
        '
        'validar
        '
        Me.validar.Enabled = False
        Me.validar.Location = New System.Drawing.Point(483, 358)
        Me.validar.Name = "validar"
        Me.validar.Size = New System.Drawing.Size(137, 63)
        Me.validar.TabIndex = 17
        Me.validar.Text = "VERIFICAR MERCANCIA CARGADA"
        Me.validar.UseVisualStyleBackColor = True
        '
        'txtfolio
        '
        Me.txtfolio.AutoCompleteCustomSource.AddRange(New String() {"PENDIENTE", "REGRESO"})
        Me.txtfolio.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.txtfolio.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource
        Me.txtfolio.Location = New System.Drawing.Point(542, 213)
        Me.txtfolio.Name = "txtfolio"
        Me.txtfolio.Size = New System.Drawing.Size(93, 20)
        Me.txtfolio.TabIndex = 15
        '
        'lblsailda
        '
        Me.lblsailda.AutoSize = True
        Me.lblsailda.Location = New System.Drawing.Point(745, 17)
        Me.lblsailda.Name = "lblsailda"
        Me.lblsailda.Size = New System.Drawing.Size(39, 13)
        Me.lblsailda.TabIndex = 18
        Me.lblsailda.Text = "Label4"
        '
        'lblclave
        '
        Me.lblclave.AutoSize = True
        Me.lblclave.Location = New System.Drawing.Point(483, 267)
        Me.lblclave.Name = "lblclave"
        Me.lblclave.Size = New System.Drawing.Size(39, 13)
        Me.lblclave.TabIndex = 19
        Me.lblclave.Text = "Label4"
        '
        'entradas_camioneta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(802, 446)
        Me.Controls.Add(Me.lblclave)
        Me.Controls.Add(Me.lblsailda)
        Me.Controls.Add(Me.validar)
        Me.Controls.Add(Me.lblmovimiento)
        Me.Controls.Add(Me.txtfolio)
        Me.Controls.Add(Me.cambiarboton)
        Me.Controls.Add(Me.guardarboton)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.lblarticulo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.detalle)
        Me.Controls.Add(Me.chofer)
        Me.Controls.Add(Me.salidas)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "entradas_camioneta"
        Me.Text = "ENTRADA DE CAMIONETA"
        CType(Me.salidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.detalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents salidas As System.Windows.Forms.DataGridView
    Friend WithEvents chofer As System.Windows.Forms.ListBox
    Friend WithEvents detalle As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lblarticulo As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents guardarboton As System.Windows.Forms.Button
    Friend WithEvents cambiarboton As System.Windows.Forms.Button
    Friend WithEvents lblmovimiento As System.Windows.Forms.Label
    Friend WithEvents validar As System.Windows.Forms.Button
    Friend WithEvents txtfolio As System.Windows.Forms.TextBox
    Friend WithEvents lblsailda As System.Windows.Forms.Label
    Friend WithEvents lblclave As Label
End Class
