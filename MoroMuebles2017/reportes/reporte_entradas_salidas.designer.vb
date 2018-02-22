<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class reporte_entradas_salidas
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dg_reportes_anteriores = New System.Windows.Forms.DataGridView()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txt_fecha_ini = New System.Windows.Forms.Label()
        Me.txt_fecha_fin = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.dg_egresos = New System.Windows.Forms.DataGridView()
        Me.dg_ingresos = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.dg_salidas = New System.Windows.Forms.DataGridView()
        Me.dg_entradas = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_reportes_anteriores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dg_egresos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_ingresos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.dg_salidas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dg_entradas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "INGRESOS"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(470, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "EGRESOS"
        '
        'PrintDialog1
        '
        Me.PrintDialog1.UseEXDialog = True
        '
        'PrintDocument1
        '
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(359, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(100, 50)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 48
        Me.PictureBox2.TabStop = False
        Me.PictureBox2.Visible = False
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(771, 48)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(128, 63)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "IMPRIMIR"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button1.Location = New System.Drawing.Point(477, 45)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(115, 66)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "GENERA"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dg_reportes_anteriores
        '
        Me.dg_reportes_anteriores.AllowUserToAddRows = False
        Me.dg_reportes_anteriores.AllowUserToDeleteRows = False
        Me.dg_reportes_anteriores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_reportes_anteriores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_reportes_anteriores.Location = New System.Drawing.Point(18, 45)
        Me.dg_reportes_anteriores.Name = "dg_reportes_anteriores"
        Me.dg_reportes_anteriores.ReadOnly = True
        Me.dg_reportes_anteriores.Size = New System.Drawing.Size(441, 66)
        Me.dg_reportes_anteriores.TabIndex = 49
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button3.Location = New System.Drawing.Point(633, 45)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(115, 66)
        Me.Button3.TabIndex = 50
        Me.Button3.Text = "GUARDAR"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txt_fecha_ini
        '
        Me.txt_fecha_ini.AutoSize = True
        Me.txt_fecha_ini.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_ini.Location = New System.Drawing.Point(202, 9)
        Me.txt_fecha_ini.Name = "txt_fecha_ini"
        Me.txt_fecha_ini.Size = New System.Drawing.Size(57, 20)
        Me.txt_fecha_ini.TabIndex = 51
        Me.txt_fecha_ini.Text = "Label3"
        '
        'txt_fecha_fin
        '
        Me.txt_fecha_fin.AutoSize = True
        Me.txt_fecha_fin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_fecha_fin.Location = New System.Drawing.Point(401, 9)
        Me.txt_fecha_fin.Name = "txt_fecha_fin"
        Me.txt_fecha_fin.Size = New System.Drawing.Size(57, 20)
        Me.txt_fecha_fin.TabIndex = 52
        Me.txt_fecha_fin.Text = "Label4"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(12, 127)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(953, 508)
        Me.TabControl1.TabIndex = 53
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Button5)
        Me.TabPage1.Controls.Add(Me.Button4)
        Me.TabPage1.Controls.Add(Me.dg_egresos)
        Me.TabPage1.Controls.Add(Me.dg_ingresos)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(945, 482)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "DINERO"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(599, 13)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(133, 23)
        Me.Button5.TabIndex = 13
        Me.Button5.Text = "AGREGAR EGRESO"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(170, 13)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(133, 23)
        Me.Button4.TabIndex = 12
        Me.Button4.Text = "AGREGAR INGRESO"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'dg_egresos
        '
        Me.dg_egresos.AllowUserToAddRows = False
        Me.dg_egresos.AllowUserToDeleteRows = False
        Me.dg_egresos.AllowUserToOrderColumns = True
        Me.dg_egresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_egresos.BackgroundColor = System.Drawing.Color.White
        Me.dg_egresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_egresos.Location = New System.Drawing.Point(474, 35)
        Me.dg_egresos.Name = "dg_egresos"
        Me.dg_egresos.ReadOnly = True
        Me.dg_egresos.Size = New System.Drawing.Size(460, 439)
        Me.dg_egresos.TabIndex = 11
        '
        'dg_ingresos
        '
        Me.dg_ingresos.AllowUserToAddRows = False
        Me.dg_ingresos.AllowUserToDeleteRows = False
        Me.dg_ingresos.AllowUserToOrderColumns = True
        Me.dg_ingresos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_ingresos.BackgroundColor = System.Drawing.Color.White
        Me.dg_ingresos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ingresos.Location = New System.Drawing.Point(14, 37)
        Me.dg_ingresos.Name = "dg_ingresos"
        Me.dg_ingresos.ReadOnly = True
        Me.dg_ingresos.Size = New System.Drawing.Size(429, 439)
        Me.dg_ingresos.TabIndex = 10
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.Button6)
        Me.TabPage2.Controls.Add(Me.Button7)
        Me.TabPage2.Controls.Add(Me.dg_salidas)
        Me.TabPage2.Controls.Add(Me.dg_entradas)
        Me.TabPage2.Controls.Add(Me.Label3)
        Me.TabPage2.Controls.Add(Me.Label4)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(945, 482)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "MERCANCIA"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(585, 12)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(133, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "AGREGAR SALIDA"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(156, 12)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(133, 23)
        Me.Button7.TabIndex = 14
        Me.Button7.Text = "AGREGAR ENTRADA"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'dg_salidas
        '
        Me.dg_salidas.AllowUserToAddRows = False
        Me.dg_salidas.AllowUserToDeleteRows = False
        Me.dg_salidas.AllowUserToOrderColumns = True
        Me.dg_salidas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_salidas.BackgroundColor = System.Drawing.Color.White
        Me.dg_salidas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_salidas.Location = New System.Drawing.Point(474, 35)
        Me.dg_salidas.Name = "dg_salidas"
        Me.dg_salidas.ReadOnly = True
        Me.dg_salidas.Size = New System.Drawing.Size(460, 439)
        Me.dg_salidas.TabIndex = 9
        '
        'dg_entradas
        '
        Me.dg_entradas.AllowUserToAddRows = False
        Me.dg_entradas.AllowUserToDeleteRows = False
        Me.dg_entradas.AllowUserToOrderColumns = True
        Me.dg_entradas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_entradas.BackgroundColor = System.Drawing.Color.White
        Me.dg_entradas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_entradas.Location = New System.Drawing.Point(14, 37)
        Me.dg_entradas.Name = "dg_entradas"
        Me.dg_entradas.ReadOnly = True
        Me.dg_entradas.Size = New System.Drawing.Size(429, 439)
        Me.dg_entradas.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Entradas"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Berlin Sans FB Demi", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(470, 9)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Salidas"
        '
        'reporte_entradas_salidas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(991, 695)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.txt_fecha_fin)
        Me.Controls.Add(Me.txt_fecha_ini)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.dg_reportes_anteriores)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "reporte_entradas_salidas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "REPORTE DE ENTRADAS Y SALIDAS"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_reportes_anteriores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dg_egresos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_ingresos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dg_salidas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dg_entradas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents dg_reportes_anteriores As DataGridView
    Friend WithEvents Button3 As Button
    Friend WithEvents txt_fecha_ini As Label
    Friend WithEvents txt_fecha_fin As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents dg_salidas As DataGridView
    Friend WithEvents dg_entradas As DataGridView
    Friend WithEvents dg_egresos As DataGridView
    Friend WithEvents dg_ingresos As DataGridView
    Friend WithEvents Button5 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button6 As Button
    Friend WithEvents Button7 As Button
End Class
