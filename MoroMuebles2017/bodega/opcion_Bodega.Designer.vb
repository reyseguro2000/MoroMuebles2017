<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class opcion_Bodega
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(177, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SELECCIONA UNA OPCIÓN"
        '
        'bt_salidas
        '
        Me.bt_salidas.BackgroundImage = Global.Captura.My.Resources.Resources.SALID
        Me.bt_salidas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_salidas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_salidas.Location = New System.Drawing.Point(74, 25)
        Me.bt_salidas.Name = "bt_salidas"
        Me.bt_salidas.Size = New System.Drawing.Size(126, 84)
        Me.bt_salidas.TabIndex = 4
        Me.bt_salidas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_salidas.UseVisualStyleBackColor = True
        '
        'bt_entradas
        '
        Me.bt_entradas.BackgroundImage = Global.Captura.My.Resources.Resources.ENTTRADA
        Me.bt_entradas.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.bt_entradas.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.bt_entradas.Location = New System.Drawing.Point(231, 25)
        Me.bt_entradas.Name = "bt_entradas"
        Me.bt_entradas.Size = New System.Drawing.Size(126, 84)
        Me.bt_entradas.TabIndex = 3
        Me.bt_entradas.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.bt_entradas.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.Control
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 163)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(437, 341)
        Me.DataGridView1.TabIndex = 6
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 147)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 13)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "PENDIENTES"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(66, 13)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "ENTRADAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(269, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "SALIDAS"
        '
        'opcion_Bodega
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DimGray
        Me.ClientSize = New System.Drawing.Size(469, 545)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.bt_salidas)
        Me.Controls.Add(Me.bt_entradas)
        Me.Name = "opcion_Bodega"
        Me.Text = "BODEGA"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents bt_salidas As Button
    Friend WithEvents bt_entradas As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
