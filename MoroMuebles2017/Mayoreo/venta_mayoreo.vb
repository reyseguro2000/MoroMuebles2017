Public Class venta_mayoreo
    Dim filas As Integer
    Dim pagado As String
    Dim resp As MsgBoxResult
    Dim fecha As Date
    Dim nombre As String
    Dim pagadoss As String
    Dim letras As String
    Dim descuento As Double
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If TextBox4.Text = "" Or txt_precio.Text = "" Then
            MsgBox("Faltan datos")
            txt_precio.Focus()
        Else
            dt_articulos.Rows.Add()
            dt_articulos.Item(0, Me.dt_articulos.RowCount - 1).Value = Me.TextBox4.Text
            dt_articulos.Item(1, Me.dt_articulos.RowCount - 1).Value = Me.cmb_articulos.SelectedValue
            dt_articulos.Item(2, Me.dt_articulos.RowCount - 1).Value = Me.cmb_articulos.Text
            dt_articulos.Item(3, Me.dt_articulos.RowCount - 1).Value = Me.txt_precio.Text

            'mitabla.set_TextMatrix(mitabla.Rows - 2, 0, TextBox4.Text)
            'mitabla.set_TextMatrix(mitabla.Rows - 2, 1, ComboBox3.SelectedValue)
            'mitabla.set_TextMatrix(mitabla.Rows - 2, 2, ComboBox3.Text)
            'mitabla.set_TextMatrix(mitabla.Rows - 2, 3, TextBox3.Text)
            Label9.Text = Val(Label9.Text) + (Val(TextBox4.Text) * Val(txt_precio.Text))
            Label10.Text = Val(Label10.Text) + Val(TextBox4.Text)

            Label12.Text = UCase(EnLetras(Label9.Text))
            If dt_articulos.RowCount > 1 Then
                'Button3.Enabled = True
                Button2.Enabled = True
            End If
            TextBox4.Focus()
            cmb_articulos.Text = ""
            txt_precio.Text = ""
            TextBox4.Text = ""
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim conexion As New base_local

        If RadioButton1.Checked = True Then pagado = "P"
        If RadioButton2.Checked = True Then pagado = "P/E"
        If RadioButton3.Checked = True Then pagado = "E"
        If RadioButton4.Checked = True Then pagado = "P/C"

        descuento = Val(InputBox("Descuento"))
        Label13.Text = Str(Int((Val(Label9.Text) * descuento) / 100))
        lbl_total.Text = Label9.Text
        Label9.Text = Str(Val(Label9.Text) - (Int((Val(Label9.Text) * descuento) / 100)))


        Dim articulos As String
        articulos = ""
        For i As Integer = 0 To Me.dt_articulos.RowCount - 1
            articulos = articulos + Me.dt_articulos.Item("clave", i).Value.PadRight(10, " "c) + Str(Me.dt_articulos.Item("precio", i).Value).PadRight(5, " "c) + Str(Me.dt_articulos.Item("cantidad", i).Value).PadRight(5, " "c)
        Next
        conexion.InsertarSQL("call venta_mayoreo(" + lbl_clave_cliente.Text.ToString + ", " + lbl_total.Text + "," + Label9.Text + "," + Label13.Text + "," + dt_articulos.RowCount.ToString + ",'" + articulos + "','" + usuario + "','" + My.Computer.Name + "')")
        conexion.dispose()



        resp = MsgBox("Desea imprimir", MsgBoxStyle.YesNo)
        If resp = MsgBoxResult.Yes Then
            prdalfa2.Print()
            'resp = MsgBox("Desea Factura", MsgBoxStyle.YesNo)
            'If resp = MsgBoxResult.Yes Then
            '    prdalfa.Print()
            'ElseIf resp = MsgBoxResult.No Then
            '    prdalfa2.Print()
            'End If
        End If
        MsgBox("Guardado aqui")
        limpiar()

        Me.Close()


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        llena_combo()
        limpiar()
        TextBox4.Focus()
        Me.BackgroundImage = My.Resources.Fondo4

    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            cmb_articulos.Text = ""
            cmb_articulos.Focus()
        End If
    End Sub
    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_folio.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim datos_venta As DataRow
            Dim conexion As New base_local

            datos_venta = conexion.repetido("select folio_m,cliente,fecha from mayoreo_ventas where folio_m='" + txt_folio.Text + "'", "mayoreo_ventas")
            conexion.dispose()
            If IsDBNull(datos_venta.Item("folio_m")) Then
                'entra
            Else
                MsgBox("El numero de folio ya exite con la fecha: " + datos_venta.Item("fecha"))

            End If
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub limpiar()
        dt_articulos.Rows.Clear()
        Me.dt_articulos.Columns.Clear()

        Me.dt_articulos.Columns.Add("cantidad", "Cantidad")
        Me.dt_articulos.Columns.Add("clave", "Clave")
        Me.dt_articulos.Columns.Add("articulo", "Articulo")
        Me.dt_articulos.Columns.Add("precio", "Precio")

        cmb_articulos.Text = ""
        txt_precio.Text = ""
        TextBox4.Text = ""
        Label9.Text = "0"
        Label10.Text = "0"
        Label12.Text = "0"
        Label13.Text = ""
    End Sub

    ''Private Sub prdAlfa_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdalfa.PrintPage
    ''    Dim Fuente As New System.Drawing.Font("Arial", 10)
    ''    Dim Grafico As System.Drawing.Graphics = e.Graphics
    ''    Dim x As Integer = 15
    ''    Dim y As Integer = 350
    ''    comando3 = New Odbc.OdbcConnection
    ''    comando3.ConnectionString = cad_con '"DRIVER={MySQL ODBC 3.51 Driver};SERVER=MSM;DATABASE=facturas;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"
    ''    comando3.Open()
    ''    nuevo = New Odbc.OdbcCommand("SELECT * FROM ventas WHERE folio =  '" + txt_folio.Text + "'", comando3)
    ''    lector1 = nuevo.ExecuteReader()
    ''    Try
    ''        lector1.Read()

    ''        nuevo = New Odbc.OdbcCommand("SELECT * FROM clientes WHERE cliente = " + lector1.Item("cliente"), comando3)
    ''        lector = nuevo.ExecuteReader()
    ''        lector.Read()

    ''        letras = lector1.Item(2)
    ''        fecha = lector1.Item(1)
    ''        nombre = lector.Item(1)
    ''        pagadoss = lector1.Item("pagado")
    ''        Grafico.DrawString(letras, Fuente, Brushes.Black, 415, 770)



    ''        Grafico.DrawString("Folio " + txt_folio.Text, Fuente, Brushes.Black, 205, 225)
    ''        letras = EnLetras(letras) + " Pesos"
    ''        Grafico.DrawString(letras, Fuente, Brushes.Black, 25, 770)
    ''        Grafico.DrawString(Format(fecha, "dd"), Fuente, Brushes.Black, 25, 225)
    ''        Grafico.DrawString(Format(fecha, "MM"), Fuente, Brushes.Black, 80, 225)
    ''        Grafico.DrawString(Format(fecha, "yyyy"), Fuente, Brushes.Black, 155, 225)
    ''        Grafico.DrawString(nombre + "    FRC " + lector.Item("rfc"), Fuente, Brushes.Black, 60, 260)
    ''        Grafico.DrawString(lector.Item("direccion") + "    Colonia " + lector.Item("colonia"), Fuente, Brushes.Black, 60, 280)
    ''        Grafico.DrawString(lector.Item("ciudad") + " CP " + lector.Item("cp"), Fuente, Brushes.Black, 60, 300)
    ''        'Grafico.DrawString(nombre, Fuente, Brushes.Black, 55, 260)



    ''        If pagadoss = "P" Then Grafico.DrawImage(PictureBox1.Image, 150, 600)
    ''        If pagadoss = "P/E" Then Grafico.DrawImage(PictureBox2.Image, 150, 600)
    ''        If pagadoss = "E" Then Grafico.DrawImage(PictureBox3.Image, 150, 600)
    ''        If pagadoss = "P/C" Then Grafico.DrawImage(PictureBox4.Image, 150, 600)


    ''        nuevo = New Odbc.OdbcCommand("SELECT cantidad, articulos.articulo, detalle.costo, detalle.articulo FROM articulos, detalle WHERE detalle.articulo = articulos.clave AND detalle.folio =  '" + lector1.Item(0) + "'", comando3)
    ''        lector = nuevo.ExecuteReader()
    ''        While lector.Read()
    ''            Grafico.DrawString(lector.Item(0), Fuente, Brushes.Black, x + 10, y)
    ''            Grafico.DrawString(lector.Item(3), Fuente, Brushes.Black, x + 40, y) '+30

    ''            Grafico.DrawString(lector.Item(1), Fuente, Brushes.Black, x + 100, y)
    ''            Grafico.DrawString(lector.Item(2), Fuente, Brushes.Black, x + 360, y)
    ''            Grafico.DrawString(Str(lector.Item(0) * lector.Item(2)), Fuente, Brushes.Black, x + 430, y)
    ''            y = y + 20
    ''        End While
    ''    Catch
    ''        MsgBox("No se encuentra ese folio")
    ''    End Try
    ''End Sub

    Private Sub prdAlfa2_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles prdalfa2.PrintPage
        Dim Fuente As New System.Drawing.Font("Arial", 10)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Dim x As Integer = 15
        Dim y As Integer = 150

        'comando3 = New Odbc.OdbcConnection
        'comando3.ConnectionString = cad_con '"DRIVER={MySQL ODBC 3.51 Driver};SERVER=MSM;DATABASE=facturas;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"
        'comando3.Open()
        'nuevo = New Odbc.OdbcCommand("SELECT * FROM ventas WHERE folio =  '" + txt_folio.Text + "'", comando3)
        'lector1 = nuevo.ExecuteReader()
        Try
            'lector1.Read()

            'nuevo = New Odbc.OdbcCommand("SELECT * FROM clientes WHERE cliente = " + lector1.Item("cliente"), comando3)
            'lector = nuevo.ExecuteReader()
            'lector.Read()

            'letras = lector1.Item(2)
            'fecha = lector1.Item(1)
            'nombre = lector.Item(1)
            'pagadoss = lector1.Item("pagado")
            'Grafico.DrawString(letras, Fuente, Brushes.Black, 415, 490)
            'Grafico.DrawString(letras, Fuente, Brushes.Black, 415, 1050)
            letras = EnLetras(Label9.Text) + " Pesos"
            Grafico.DrawString(letras, Fuente, Brushes.Black, 25, 490)
            Grafico.DrawString(letras, Fuente, Brushes.Black, 25, 1050)


            Grafico.DrawString("Subtotal  " + lbl_total.Text, Fuente, Brushes.Black, 600, 200)
            Grafico.DrawString("Descuento " + Label13.Text, Fuente, Brushes.Black, 600, 250)
            Grafico.DrawString("Total     " + Label9.Text, Fuente, Brushes.Black, 600, 300)


            Grafico.DrawString("Subtotal  " + lbl_total.Text, Fuente, Brushes.Black, 600, 700)
            Grafico.DrawString("Descuento " + Label13.Text, Fuente, Brushes.Black, 600, 750)
            Grafico.DrawString("Total     " + Label9.Text, Fuente, Brushes.Black, 600, 800)



            Grafico.DrawString(Format(fecha, "dd/MM/yy"), Fuente, Brushes.Black, 600, 25)
            Grafico.DrawString(Format(fecha, "dd/MM/yy"), Fuente, Brushes.Black, 600, 575)

            Grafico.DrawString("Folio " + txt_folio.Text, Fuente, Brushes.Black, 25, 25)
            Grafico.DrawString("Folio " + txt_folio.Text, Fuente, Brushes.Black, 25, 575)

            Grafico.DrawString(lbl_bodega.Text, Fuente, Brushes.Black, 250, 25)
            Grafico.DrawString(lbl_bodega.Text, Fuente, Brushes.Black, 250, 575)

            Grafico.DrawLine(Pens.Black, 10, 530, 750, 530)

            Grafico.DrawString(lbl_cliente.Text, Fuente, Brushes.Black, 60, 60)
            'Grafico.DrawString(lector.Item("direccion") + "    Colonia " + lector.Item("colonia"), Fuente, Brushes.Black, 60, 80)
            'Grafico.DrawString(lector.Item("ciudad") + " CP " + lector.Item("cp"), Fuente, Brushes.Black, 60, 100)

            Grafico.DrawString(lbl_cliente.Text, Fuente, Brushes.Black, 60, 610)
            'Grafico.DrawString(lector.Item("direccion") + "    Colonia " + lector.Item("colonia"), Fuente, Brushes.Black, 60, 630)
            'Grafico.DrawString(lector.Item("ciudad") + " CP " + lector.Item("cp"), Fuente, Brushes.Black, 60, 650)


            If pagadoss = "P" Then
                Grafico.DrawImage(PictureBox1.Image, 150, 380)
                Grafico.DrawImage(PictureBox1.Image, 150, 930)
            End If
            If pagadoss = "P/E" Then
                Grafico.DrawImage(PictureBox2.Image, 150, 380)
                Grafico.DrawImage(PictureBox2.Image, 150, 930)
            End If

            If pagadoss = "E" Then
                Grafico.DrawImage(PictureBox3.Image, 150, 380)
                Grafico.DrawImage(PictureBox3.Image, 150, 930)
            End If
            If pagadoss = "P/C" Then

            End If
            Grafico.DrawImage(PictureBox4.Image, 150, 380)
            Grafico.DrawImage(PictureBox4.Image, 150, 930)
            For im_art As Integer = 0 To dt_articulos.RowCount - 1
                Grafico.DrawString(dt_articulos.Item("cantidad", im_art).Value, Fuente, Brushes.Black, x + 10, y)
                Grafico.DrawString(dt_articulos.Item("CLAVE", im_art).Value, Fuente, Brushes.Black, x + 40, y) '+30

                Grafico.DrawString(dt_articulos.Item("articulo", im_art).Value, Fuente, Brushes.Black, x + 100, y)
                Grafico.DrawString(dt_articulos.Item("precio", im_art).Value, Fuente, Brushes.Black, x + 360, y)
                Grafico.DrawString(dt_articulos.Item("cantidad", im_art).Value * dt_articulos.Item("precio", im_art).Value, Fuente, Brushes.Black, x + 430, y)


                Grafico.DrawString(dt_articulos.Item("cantidad", im_art).Value, Fuente, Brushes.Black, x + 10, y + 550)
                Grafico.DrawString(dt_articulos.Item("clave", im_art).Value, Fuente, Brushes.Black, x + 40, y + 550) '+30

                Grafico.DrawString(dt_articulos.Item("articulo", im_art).Value, Fuente, Brushes.Black, x + 100, y + 550)
                Grafico.DrawString(dt_articulos.Item("precio", im_art).Value, Fuente, Brushes.Black, x + 360, y + 550)
                Grafico.DrawString(dt_articulos.Item("cantidad", im_art).Value * dt_articulos.Item("precio", im_art).Value, Fuente, Brushes.Black, x + 430, y + 550)
                y = y + 20

            Next

            'nuevo = New Odbc.OdbcCommand("SELECT cantidad, articulos.articulo, detalle.costo, detalle.articulo FROM articulos, detalle WHERE detalle.articulo = articulos.clave AND detalle.folio =  '" + lector1.Item(0) + "'", comando3)
            'lector = nuevo.ExecuteReader()
            'While lector.Read()
            '    Grafico.DrawString(lector.Item(0), Fuente, Brushes.Black, x + 10, y)
            '    Grafico.DrawString(lector.Item(3), Fuente, Brushes.Black, x + 40, y) '+30

            '    Grafico.DrawString(lector.Item(1), Fuente, Brushes.Black, x + 100, y)
            '    Grafico.DrawString(lector.Item(2), Fuente, Brushes.Black, x + 360, y)
            '    Grafico.DrawString(Str(lector.Item(0) * lector.Item(2)), Fuente, Brushes.Black, x + 430, y)


            '    Grafico.DrawString(lector.Item(0), Fuente, Brushes.Black, x + 10, y + 550)
            '    Grafico.DrawString(lector.Item(3), Fuente, Brushes.Black, x + 40, y + 550) '+30

            '    Grafico.DrawString(lector.Item(1), Fuente, Brushes.Black, x + 100, y + 550)
            '    Grafico.DrawString(lector.Item(2), Fuente, Brushes.Black, x + 360, y + 550)
            '    Grafico.DrawString(Str(lector.Item(0) * lector.Item(2)), Fuente, Brushes.Black, x + 430, y + 550)
            '    y = y + 20
            'End While
        Catch
            MsgBox("No se encuentra ese folio")
        End Try
    End Sub



    Private Sub ComboBox3_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_articulos.KeyDown
        jayalo(sender, e)
    End Sub

    Private Sub ComboBox3_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles cmb_articulos.KeyUp
        jayalo(sender, e)

    End Sub


    Private Sub jayalo(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If cmb_articulos.SelectedIndex > -1 Then
            'Label4.Text = ComboBox3.SelectedValue
            txt_precio.Text = cmb_articulos.Items(Me.cmb_articulos.SelectedIndex)("precio").ToString()
            txt_precio.Text = Int(Val(txt_precio.Text) + (Val(txt_precio.Text) * (lista1(14) / 100)) + 0.5)


            Label6.Text = cmb_articulos.Items(Me.cmb_articulos.SelectedIndex)("maquina").ToString()
        End If
        If e.KeyCode = 13 Then
            If cmb_articulos.Text = "" Then
                cmb_articulos.Focus()
            Else
                txt_precio.Focus()

            End If
        End If
    End Sub

    Private Sub ComboBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then
            TextBox4.Focus()
        End If
    End Sub
    Private Sub ComboBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
        If e.KeyChar = Chr(Keys.Enter) Then
            TextBox4.Focus()
        End If
    End Sub

    Private Sub mitabla_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles dt_articulos.DoubleClick
        ' Dim X, n As Integer
        If dt_articulos.RowCount = 1 Or dt_articulos.RowCount = 0 Then
            MsgBox("No se puede eliminar la fial")
        Else
            TextBox4.Text = dt_articulos.Item(0, dt_articulos.CurrentRow.Index).Value
            cmb_articulos.Text = dt_articulos.Item(2, dt_articulos.CurrentRow.Index).Value ' mitabla.get_TextMatrix(mitabla.Row, 2)
            Label4.Text = dt_articulos.Item(2, dt_articulos.CurrentRow.Index).Value ' mitabla.get_TextMatrix(mitabla.Row, 2)
            txt_precio.Text = dt_articulos.Item(3, dt_articulos.CurrentRow.Index).Value ' mitabla.get_TextMatrix(mitabla.Row, 3)
            Label10.Text = Val(Label10.Text) - Val(TextBox4.Text)
            Label9.Text = Val(Label9.Text) - (Val(TextBox4.Text) * Val(txt_precio.Text))
            Label12.Text = UCase(EnLetras(Label9.Text))
            'For n = mitabla.Row To mitabla.Rows - 2
            '    For X = 0 To 3
            '        mitabla.set_TextMatrix(n, X, mitabla.get_TextMatrix(n + 1, X))
            '    Next X
            'Next
            dt_articulos.Rows.Remove(Me.dt_articulos.Rows(Me.dt_articulos.CurrentRow.Index)) ' = mitabla.Rows - 1
            If dt_articulos.RowCount = 0 Then
                '                Button3.Enabled = False
                Button2.Enabled = False
            End If
        End If

    End Sub
    Private Sub llena_combo()
        Dim no_venta As DataRow
        Dim conexion As New base_local
        conexion.llena_combo(cmb_articulos, "select * from articulos order by articulo")
        no_venta = conexion.repetido("select max(folio_m) as folio_m from mayoreo_ventas", "mayoreo_ventas")
        If IsDBNull(no_venta.Item("folio_m")) Then
            txt_folio.Text = "1"
        Else
            txt_folio.Text = no_venta.Item("folio_m") + 1
        End If
        conexion.dispose()
    End Sub
End Class
