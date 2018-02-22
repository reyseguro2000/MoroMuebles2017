Public Class listado_tarjetas
    Dim filas_recorida As Int16 = 0
    Dim conexion_imprimir As base_local


    Private Sub btn_imprimir_reporte_Click(sender As Object, e As EventArgs) Handles btn_imprimir_reporte.Click
        'imprimir reporte
        btn_imprimir_faltantes.Enabled = True

    End Sub

    Private Sub btn_imprimir_faltantes_Click(sender As Object, e As EventArgs) Handles btn_imprimir_faltantes.Click
        'imprimir faltante

        seleccionar_tarjeta.ShowDialog()
        PrintDialog1.ShowDialog()
        conexion_imprimir = New base_local
        filas_recorida = 0
        If formato_tarjeta = "CHICAS" Then
            PrinttarjetaChica.PrinterSettings = PrintDialog1.PrinterSettings
            PrinttarjetaChica.Print()
        ElseIf formato_tarjeta = "GRANDES" Then
            Printtarjeta.PrinterSettings = PrintDialog1.PrinterSettings
            Printtarjeta.Print()
        End If
        conexion_imprimir.dispose()

    End Sub





    Private Sub dg_faltantes_DoubleClick(sender As Object, e As EventArgs) Handles dg_faltantes.DoubleClick

        If tipo = 1 Then
            tarjeta.l_venta.Text = dg_faltantes.Item("venta", dg_faltantes.CurrentRow.Index).Value
            tarjeta.llena(tarjeta.l_venta.Text)
            tarjeta.ShowDialog()
        ElseIf tipo = 2 Then
            tarjeta_s.l_venta.Text = dg_faltantes.Item("venta", dg_faltantes.CurrentRow.Index).Value
            tarjeta_s.ShowDialog()
        End If
        'tarjeta_s.l_venta.Text = dg_faltantes.Item("venta", dg_faltantes.CurrentRow.Index).Value
        'tarjeta_s.Show()
        'llena tarjeta
    End Sub
    Private Sub dg_sobrantes_DoubleClick(sender As Object, e As EventArgs) Handles dg_sobrantes.DoubleClick
        If tipo = 1 Then
            tarjeta.l_venta.Text = dg_sobrantes.Item("venta", dg_sobrantes.CurrentRow.Index).Value
            tarjeta.llena(tarjeta.l_venta.Text)
            tarjeta.ShowDialog()
        ElseIf tipo = 2 Then
            tarjeta_s.l_venta.Text = dg_sobrantes.Item("venta", dg_sobrantes.CurrentRow.Index).Value
            tarjeta_s.ShowDialog()
        End If
        'tarjeta_s.l_venta.Text = dg_sobrantes.Item("venta", dg_sobrantes.CurrentRow.Index).Value
        'tarjeta_s.Show()
        'llena tarjeta
    End Sub
    Private Sub dg_diferencia_DoubleClick(sender As Object, e As EventArgs) Handles dg_diferencia.DoubleClick
        If tipo = 1 Then
            tarjeta.l_venta.Text = dg_diferencia.Item("venta", dg_diferencia.CurrentRow.Index).Value
            tarjeta.llena(tarjeta.l_venta.Text)
            tarjeta.ShowDialog()
        ElseIf tipo = 2 Then
            tarjeta_s.l_venta.Text = dg_diferencia.Item("venta", dg_diferencia.CurrentRow.Index).Value
            tarjeta_s.ShowDialog()
        End If
    End Sub
    Private Sub txt_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_venta.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Or e.KeyChar = Chr(Keys.Tab) Then
            ' If txt_venta.Text <> bodega Then txt_venta.Text = bodega & txt_venta.Text

            For filas_recorida = 0 To dg_faltantes.RowCount - 1
                Dim busca As String = bodega & Trim(txt_venta.Text)
                If busca = dg_faltantes.Item("venta", filas_recorida).Value Then
                    lbl_cliente.Text = dg_faltantes.Item("cliente", filas_recorida).Value
                    lbl_nombre.Text = dg_faltantes.Item("nombre", filas_recorida).Value
                    lbl_saldo.Text = dg_faltantes.Item("saldo", filas_recorida).Value
                    btn_diferencia.Enabled = True
                    bt_correcto.Enabled = True
                    GoTo salte
                End If

            Next
            If MsgBox("No se encuenta en esta ruta buscar?", vbYesNo) = MsgBoxResult.Yes Then
                Dim venta_busca As DataRow
                Dim conexion_local As New base_local
                venta_busca = conexion_local.repetido("select * from vista_ventas_camionetas where venta=" & txt_venta.Text, "vista_ventas_camionetas") 'busca tarjetas
                conexion_local.dispose()
                If IsDBNull(venta_busca.Item("Venta")) Then
                    MsgBox("No se encontro la venta")
                Else
                    'agregar a sobrante
                    dg_sobrantes.Rows.Add()
                    dg_sobrantes.Item("cliente_sob", dg_sobrantes.RowCount - 1).Value = venta_busca.Item("cliente")
                    dg_sobrantes.Item("venta_sob", dg_sobrantes.RowCount - 1).Value = venta_busca.Item("Venta")
                    dg_sobrantes.Item("saldo_sob", dg_sobrantes.RowCount - 1).Value = venta_busca.Item("saldo")
                    dg_sobrantes.Item("ruta_sob", dg_sobrantes.RowCount - 1).Value = venta_busca.Item("ruta")



                End If
            End If

        End If
salte:
    End Sub


    Private Sub bt_correcto_Click(sender As Object, e As EventArgs) Handles bt_correcto.Click
        dg_faltantes.Rows.RemoveAt(filas_recorida)
        lbl_correcto.Text = Val(lbl_correcto.Text) + 1
        lbl_faltantes.Text = dg_faltantes.RowCount
        bt_correcto.Enabled = False
        btn_diferencia.Enabled = False
    End Sub

    Private Sub btn_diferencia_Click(sender As Object, e As EventArgs) Handles btn_diferencia.Click
        'agregar a diferencia
        dg_diferencia.Rows.Add()
        dg_diferencia.Item("cliente_dif", dg_diferencia.RowCount - 1).Value = dg_faltantes.Item("cliente", filas_recorida).Value
        dg_diferencia.Item("venta_dif", dg_diferencia.RowCount - 1).Value = dg_faltantes.Item("cliente", filas_recorida).Value
        dg_diferencia.Item("saldo_m", dg_diferencia.RowCount - 1).Value = dg_faltantes.Item("cliente", filas_recorida).Value
        dg_diferencia.Item("saldo_t", dg_diferencia.RowCount - 1).Value = InputBox("Saldo en tarjeta")
        dg_faltantes.Rows.RemoveAt(filas_recorida)
        lbl_diferencia.Text = Val(lbl_diferencia.Text) + 1
        lbl_faltantes.Text = dg_faltantes.RowCount
        bt_correcto.Enabled = False
        btn_diferencia.Enabled = False
    End Sub

    Private Sub Printtarjeta_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Printtarjeta.PrintPage
        Dim datos_cliente As DataRow
        Dim datos_aval As DataRow

        Dim Fuente As New System.Drawing.Font("Arial", 8)
        Dim Fuente2 As New System.Drawing.Font("Arial", 10)
        Dim Fuente3 As New System.Drawing.Font("Arial", 8)
        Dim codigo As New System.Drawing.Font("C39HrP48DhTt", 45)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Dim y, x As Int16
        Dim fecha_v As Date
        Dim caca, tipo_desc As String

        datos_cliente = conexion_imprimir.repetido("select * from clientes where clave_i=" + dg_faltantes.Item("cliente", filas_recorida).Value.ToString, "clientes")
        x = 5
        While filas_recorida < dg_faltantes.RowCount
            Grafico.DrawLine(Pens.Black, x + 10, 40, x + 210, 40)
            Grafico.DrawLine(Pens.Black, x + 10, 90, x + 210, 90)
            Grafico.DrawLine(Pens.Black, x + 10, 40, x + 10, 90)
            Grafico.DrawLine(Pens.Black, x + 100, 40, x + 100, 90)
            Grafico.DrawLine(Pens.Black, x + 140, 40, x + 140, 90)
            Grafico.DrawLine(Pens.Black, x + 210, 40, x + 210, 90)
            Grafico.DrawString("BODEGA " & muebleria_ciudad, Fuente3, Brushes.Black, x + 10, 20)



            Grafico.DrawString("*" + dg_faltantes.Item("venta", filas_recorida).Value + "*", codigo, Brushes.Black, x + 210, 35)
            Grafico.DrawString(dg_faltantes.Item("cliente", filas_recorida).Value, Fuente2, Brushes.Black, x + 20, 55)
            Grafico.DrawString(dg_faltantes.Item("ruta", filas_recorida).Value, Fuente2, Brushes.Black, x + 110, 55)
            Grafico.DrawString(dg_faltantes.Item("folio", filas_recorida).Value, Fuente2, Brushes.Black, x + 150, 55)
            tipo_desc = ""
            Select Case dg_faltantes("tipo_d", filas_recorida).Value
                Case "0"
                    tipo_desc = "SIN DESCUENTO"

                Case "1"
                    tipo_desc = "MAYO"


                Case "2"
                    tipo_desc = "DICIEMBRE"


                Case "3"
                    tipo_desc = "BUEN FIN"


                Case "4"
                    tipo_desc = "REMATE 1"


                Case "5"
                    tipo_desc = "REMATE 2"


                Case "6"
                    tipo_desc = "EXPO"


                Case "7"
                    tipo_desc = "PAQUETE"


                Case "8"
                    tipo_desc = "OFERTA"


                Case "9"
                    tipo_desc = "OTRO"


            End Select
            If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) > 0 Then
                Grafico.DrawString("SE DESCONTO " + tipo_desc + " $ " + dg_faltantes.Item("descuento", filas_recorida).Value.ToString, Fuente2, Brushes.Black, x + 310, 55)
            End If

            Grafico.DrawString("CLIENTE # ", Fuente3, Brushes.Black, x + 20, 75)
            Grafico.DrawString("RUTA ", Fuente3, Brushes.Black, x + 100, 75)
            Grafico.DrawString("FOLIO ", Fuente3, Brushes.Black, x + 160, 75)

            Grafico.DrawString("Nombre: " + dg_faltantes.Item("nombre", filas_recorida).Value, Fuente, Brushes.Black, x + 10, 100)
            Grafico.DrawString("Calle:  " + dg_faltantes.Item("calle", filas_recorida).Value, Fuente, Brushes.Black, x + 10, 110)
            Grafico.DrawString("Colonia: " + dg_faltantes.Item("colonia", filas_recorida).Value, Fuente, Brushes.Black, x + 10, 120)

            Grafico.DrawString("Vendedor:  " + dg_faltantes.Item("vendedor", filas_recorida).Value, Fuente, Brushes.Black, x + 10, 130)
            '  Grafico.DrawString("Telefono: " + dg_faltantes.Item("tipo_d", filas_recorida).Value, Fuente, Brushes.Black, x + 10, 140)
            ' Grafico.DrawString("Domicilio: " + l_detalle.Text, Fuente, Brushes.Black, x + 310, 240)
            Grafico.DrawString("Cantidad", Fuente, Brushes.Black, x + 10, 150)
            Grafico.DrawString("Articulo", Fuente, Brushes.Black, x + 70, 150)
            Grafico.DrawString("Precio", Fuente, Brushes.Black, x + 250, 150)
            y = 140

            conexion_imprimir.llena_tabla(dg_articulos, "select cantidad, nombre_articulo as articulo, precio from articulos_ventas where venta='" & dg_faltantes.Item("venta", filas_recorida).Value & "'")
            For fila As Integer = 0 To dg_articulos.RowCount - 1
                Grafico.DrawString(dg_articulos.Item("cantidad", fila).Value, Fuente, Brushes.Black, x + 10, y + 20)
                Grafico.DrawString(dg_articulos.Item("articulo", fila).Value, Fuente, Brushes.Black, x + 70, y + 20)
                Grafico.DrawString(dg_articulos.Item("precio", fila).Value, Fuente, Brushes.Black, x + 250, y + 20)
                y = y + 10
            Next



            Grafico.DrawString("Total: " + dg_faltantes.Item("total", filas_recorida).Value.ToString, Fuente, Brushes.Black, x + 10, 200)
            Grafico.DrawString("Enganche: " + dg_faltantes.Item("enganche", filas_recorida).Value.ToString, Fuente, Brushes.Black, x + 150, 200)

            If dg_faltantes.Item("forma", filas_recorida).Value = "1" Then Grafico.DrawString("Forma de pago: Semanal", Fuente, Brushes.Black, x + 10, 210)
            If dg_faltantes.Item("forma", filas_recorida).Value = "2" Then Grafico.DrawString("Forma de pago: Quincenal", Fuente, Brushes.Black, x + 10, 210)
            If dg_faltantes.Item("forma", filas_recorida).Value = "3" Then Grafico.DrawString("Forma de pago: Mensual", Fuente, Brushes.Black, x + 10, 210)
            If dg_faltantes.Item("plazo", filas_recorida).Value = "1" Then
                Grafico.DrawString("Plazo: 1 Mes", Fuente, Brushes.Black, x + 10, 220)
            Else
                Grafico.DrawString("Plazo: " + dg_faltantes.Item("plazo", filas_recorida).Value + " Meses", Fuente, Brushes.Black, x + 10, 220)
            End If
            caca = "0"

            If dg_faltantes.Item("forma", filas_recorida).Value = "1" Then caca = Int((Val(dg_faltantes.Item("total", filas_recorida).Value) - Val(dg_faltantes.Item("enganche", filas_recorida).Value)) / (4 * Val(dg_faltantes.Item("plazo", filas_recorida).Value)))
            If dg_faltantes.Item("forma", filas_recorida).Value = "2" Then caca = Int((Val(dg_faltantes.Item("total", filas_recorida).Value) - Val(dg_faltantes.Item("enganche", filas_recorida).Value)) / (2 * Val(dg_faltantes.Item("plazo", filas_recorida).Value)))
            If dg_faltantes.Item("forma", filas_recorida).Value = "3" Then caca = Int((Val(dg_faltantes.Item("total", filas_recorida).Value) - Val(dg_faltantes.Item("enganche", filas_recorida).Value)) / (Val(dg_faltantes.Item("plazo", filas_recorida).Value)))
            Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 150, 220)


            Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 10, 230)
            Dim l, li As Integer
            Dim casa As String
            l = 1
            li = 1
            casa = ""
            While l <= Len(datos_cliente.Item("detalle"))
                casa = casa + Mid(datos_cliente.Item("detalle"), l, 1)
                If li > 35 And Mid(datos_cliente.Item("detalle"), l, 1) = " " Then
                    li = 1
                    casa = casa + vbCrLf
                Else
                    li = li + 1
                End If
                l = l + 1
            End While

            Grafico.DrawString(casa, Fuente, Brushes.Black, x + 10, 250)
            fecha_v = dg_faltantes.Item("fecha", filas_recorida).Value

            Grafico.DrawString("Fecha de venta: " + Format(fecha_v, "dd/MM/yyyy"), Fuente, Brushes.Black, x + 350, 25)

            fecha_v = DateAdd(DateInterval.Month, dg_faltantes.Item("plazo", filas_recorida).Value, fecha_v)
            Grafico.DrawString("Fecha de vencimiento: " + Format(fecha_v, "dd/MM/yyyy"), Fuente, Brushes.Black, x + 320, 35)

            Grafico.DrawString("Ref1 " + datos_cliente.Item("rnombre"), Fuente, Brushes.Black, x + 310, 90)
            Grafico.DrawString("Calle: " + datos_cliente.Item("rcalle"), Fuente, Brushes.Black, x + 310, 100)
            Grafico.DrawString("Colonia" + datos_cliente.Item("rcolonia") + " Ciudad" + datos_cliente.Item("rciudad"), Fuente, Brushes.Black, x + 310, 120)

            datos_aval = conexion_imprimir.repetido("select * from aval where folio='" + dg_faltantes.Item("folio", filas_recorida).Value + "'", "aval")
            If IsDBNull(datos_aval.Item("folio")) Then
                Grafico.DrawString("Esposo " + datos_cliente.Item("conyuge"), Fuente, Brushes.Black, x + 310, 140)
            Else
                Grafico.DrawString("Esposo " + datos_aval.Item("nombre"), Fuente, Brushes.Black, x + 310, 140)
                Grafico.DrawString("Calle: " + datos_aval.Item("clle"), Fuente, Brushes.Black, x + 310, 150)
                Grafico.DrawString("Colonia" + datos_aval.Item("colonia") + " Ciudad" + datos_aval.Item("ciudad"), Fuente, Brushes.Black, x + 310, 160)
            End If


            Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 310, 180)
            Grafico.DrawString(casa, Fuente, Brushes.Black, x + 310, 190)

            Grafico.DrawString("SALDO  " + dg_faltantes.Item("saldo", filas_recorida).Value.ToString, Fuente2, Brushes.Black, x + 90, 330)
            '            e.HasMorePages = False
            '  GoTo fin


            filas_recorida += 1
            If filas_recorida < dg_faltantes.RowCount - 1 Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If
            GoTo fin
        End While

fin:
    End Sub

    Private Sub PrinttarjetaChica_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrinttarjetaChica.PrintPage
        Dim Fuente As New System.Drawing.Font("Arial", 8)
        Dim Fuente2 As New System.Drawing.Font("Arial", 13)
        Dim Fuente3 As New System.Drawing.Font("Arial", 10)
        Dim codigo As New System.Drawing.Font("C39HrP48DhTt", 130)
        Dim Grafico As System.Drawing.Graphics = e.Graphics

        Dim x, y As Int16
        Dim caca As String
        Dim l, li As Integer
        Dim fecha_v As Date
        Dim articulos, tipo_desc As String

        While filas_recorida < dg_faltantes.RowCount


            x = 0
            y = 110



            Grafico.DrawString("R: " + dg_faltantes.Item("ruta", filas_recorida).Value.ToString + "  " + bodega, Fuente3, Brushes.Black, x + 10, 210)
            Grafico.DrawString("CLIENTE: " + dg_faltantes.Item("cliente", filas_recorida).Value.ToString, Fuente3, Brushes.Black, x + 110, 210)

            Grafico.DrawString("FOLIO: " + dg_faltantes.Item("folio", filas_recorida).Value, Fuente3, Brushes.Black, x + 250, 210)

            Grafico.DrawString("*" + dg_faltantes.Item("venta", filas_recorida).Value + "*", codigo, Brushes.Black, x + 20, 20)

            fecha_v = dg_faltantes.Item("fecha", filas_recorida).Value

            Grafico.DrawString("Fecha de venta: " + Format(fecha_v, "dd/MM/yyyy"), Fuente, Brushes.Black, x + 10, 230)

            fecha_v = DateAdd(DateInterval.Month, dg_faltantes.Item("plazo", filas_recorida).Value, fecha_v)
            Grafico.DrawString("Fecha de vencimiento: " + Format(fecha_v, "dd/MM/yyyy"), Fuente, Brushes.Black, x + 200, 230)

            Grafico.DrawString("Nombre: " + dg_faltantes.Item("nombre", filas_recorida).Value, Fuente, Brushes.Black, x + 10, y + 160)

            Grafico.DrawString("Calle: " + dg_faltantes.Item("calle", filas_recorida).Value, Fuente, Brushes.Black, x + 10, y + 180)

            Grafico.DrawString("Colonia: " + dg_faltantes.Item("colonia", filas_recorida).Value, Fuente, Brushes.Black, x + 10, y + 200)

            y += 20

            tipo_desc = ""
            If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) > 0 Then
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 1 Then tipo_desc = "MAYO $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 2 Then tipo_desc = "DICIEMBRE $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 3 Then tipo_desc = "BUEN FIN $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 4 Then tipo_desc = "REMATE 1 $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 5 Then tipo_desc = "REMATE 2 $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 6 Then tipo_desc = "EXPO $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 7 Then tipo_desc = "PAQUETE $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 8 Then tipo_desc = "OTRO  $"
                If Val(dg_faltantes.Item("tipo_d", filas_recorida).Value) = 9 Then tipo_desc = "OFERTA $"

                Grafico.DrawString("SE DESCONTO " + tipo_desc + Str(dg_faltantes.Item("descuento", filas_recorida).Value), Fuente2, Brushes.Black, x + 10, 250)
            End If

            articulos = ""
            conexion_imprimir.llena_tabla(dg_articulos, "select cantidad, nombre_articulo as articulo, precio from articulos_ventas where venta='" & dg_faltantes.Item("venta", filas_recorida).Value & "'")

            Dim i_arti As Int16 = 0
            While i_arti < dg_articulos.RowCount
                articulos = articulos & dg_articulos.Item("cantidad", i_arti).Value & " " & dg_articulos.Item("articulo", i_arti).Value & " $" & dg_articulos.Item("precio", i_arti).Value & ","
                'Grafico.DrawString(lector1.Item("articulo"), Fuente, Brushes.Black, x + 70, y + 20)
                'Grafico.DrawString(lector1.Item("precio"), Fuente, Brushes.Black, x + 250, y + 20)
                'y = y + 10
                i_arti += 1
            End While
            l = 1
            li = 1
            Dim art As String
            art = ""
            While l <= Len(articulos)
                art = art + Mid(articulos, l, 1)
                If li > 35 And Mid(articulos, l, 1) = " " Then
                    li = 1
                    art = art + vbCrLf
                Else
                    li = li + 1
                End If
                l = l + 1
            End While

            Grafico.DrawString("Articulo:", Fuente, Brushes.Black, x + 10, y + 200)
            Grafico.DrawString(art, Fuente, Brushes.Black, x + 10, y + 220)

            'y = y + 20

            Grafico.DrawString("Total $" + dg_faltantes.Item("total", filas_recorida).Value.ToString, Fuente, Brushes.Black, x + 10, y + 270)
            Grafico.DrawString("Enganche $" + dg_faltantes.Item("enganche", filas_recorida).Value.ToString, Fuente, Brushes.Black, x + 90, y + 270)

            If dg_faltantes.Item("forma", filas_recorida).Value = "1" Then Grafico.DrawString("Forma de pago: Semanal", Fuente, Brushes.Black, x + 10, y + 280)
            If dg_faltantes.Item("forma", filas_recorida).Value = "2" Then Grafico.DrawString("Forma de pago: Quincenal", Fuente, Brushes.Black, x + 10, y + 280)
            If dg_faltantes.Item("forma", filas_recorida).Value = "3" Then Grafico.DrawString("Forma de pago: Mensual", Fuente, Brushes.Black, x + 10, y + 280)


            If dg_faltantes.Item("plazo", filas_recorida).Value = "1" Then
                Grafico.DrawString("Plazo 1 Mes", Fuente, Brushes.Black, x + 260, y + 270)
            Else
                Grafico.DrawString("Plazo " + dg_faltantes.Item("plazo", filas_recorida).Value + " Meses", Fuente, Brushes.Black, x + 260, y + 270)
            End If
                caca = "0"
            If dg_faltantes.Item("forma", filas_recorida).Value = "1" Then caca = Int((Val(dg_faltantes.Item("total", filas_recorida).Value) - Val(dg_faltantes.Item("enganche", filas_recorida).Value) - Val(dg_faltantes.Item("descuento", filas_recorida).Value)) / (4 * Val(dg_faltantes.Item("plazo", filas_recorida).Value)))
            If dg_faltantes.Item("forma", filas_recorida).Value = "2" Then caca = Int((Val(dg_faltantes.Item("total", filas_recorida).Value) - Val(dg_faltantes.Item("enganche", filas_recorida).Value) - Val(dg_faltantes.Item("descuento", filas_recorida).Value)) / (2 * Val(dg_faltantes.Item("plazo", filas_recorida).Value)))
            If dg_faltantes.Item("forma", filas_recorida).Value = "3" Then caca = Int((Val(dg_faltantes.Item("total", filas_recorida).Value) - Val(dg_faltantes.Item("enganche", filas_recorida).Value) - Val(dg_faltantes.Item("descuento", filas_recorida).Value)) / (Val(dg_faltantes.Item("plazo", filas_recorida).Value)))
            Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 180, y + 270)


            Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 10, y + 290)
            Grafico.DrawString("Vendedor: " + dg_faltantes.Item("vendedor", filas_recorida).Value, Fuente, Brushes.Black, x + 180, y + 280)
            Dim casa As String
            l = 1
            li = 1
            casa = ""
            While l <= Len(dg_faltantes.Item("detalle", filas_recorida).Value)
                casa = casa + Mid(dg_faltantes.Item("detalle", filas_recorida).Value, l, 1)
                If li > 35 And Mid(dg_faltantes.Item("detalle", filas_recorida).Value, l, 1) = " " Then
                    li = 1
                    casa = casa + vbCrLf
                Else
                    li = li + 1
                End If
                l = l + 1
            End While
            Grafico.DrawString(casa, Fuente, Brushes.Black, x + 30, y + 300)



            filas_recorida += 1
            If filas_recorida < dg_faltantes.RowCount - 1 Then
                e.HasMorePages = True
            Else
                e.HasMorePages = False
            End If

            GoTo fin
        End While

fin:
    End Sub

    'Private Sub btn_atrazadas_Click(sender As Object, e As EventArgs) Handles btn_atrazadas.Click
    '    Dim conexion_ruta As New base_local
    '    Dim ruta_pv As DataRow
    '    ruta_pv = conexion_ruta.repetido("select * from vista_rutas where ruta=" & txt_ruta_atrazada.Value.ToString, "vista_rutas")
    '    conexion_ruta.dispose()
    '    If IsDBNull(ruta_pv.Item("ruta")) Then
    '        MsgBox("No se encuentra la ruta")

    '    Else
    '        lista_tarjetas_pva.lbl_ruta.Text = ruta_pv.Item("ruta")
    '        lista_tarjetas_pva.lbl_cobrador.Text = ruta_pv.Item("cobrador")
    '        lista_tarjetas_pva.lbl_supervisor.Text = ruta_pv.Item("supervisor")
    '        lista_tarjetas_pva.ShowDialog()
    '        Me.Dispose()
    '    End If


    'End Sub
    'Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
    '    ' dg_faltantes.Rows.Clear()
    '    dg_sobrantes.Rows.Clear()
    '    dg_diferencia.Rows.Clear()
    '    conexion_imprimir = New base_local

    '    conexion_imprimir.llena_tabla(dg_faltantes, "select * from vista_ventas_camionetas where saldo>0 and ruta=" & txt_ruta.Value.ToString) 'busca tarjetas

    '    lbl_total.Text = dg_faltantes.RowCount
    '    lbl_faltantes.Text = dg_faltantes.RowCount
    '    lbl_sobrantes.Text = dg_sobrantes.RowCount
    '    grp_venta.Visible = True
    '    grp_rango.Visible = False
    '    lbl_diferencia.Text = "0"
    '    lbl_correcto.Text = "0"
    '    conexion_imprimir.dispose()
    'End Sub

    'Private Sub btn_imprimir_rango_Click(sender As Object, e As EventArgs) Handles btn_imprimir_rango.Click
    '    If MsgBox("Se va a imprimir de la venta " & txt_inicio.Text & " a la " & txt_fin.Text, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '        'imprimir  
    '        conexion_imprimir = New base_local

    '        conexion_imprimir.llena_tabla(dg_faltantes, "select * from vista_ventas_camionetas where saldo>0 and venta between '" & bodega & txt_inicio.Text & "' and '" & bodega & txt_fin.Text & "'") 'busca tarjetas


    '        seleccionar_tarjeta.ShowDialog()
    '        PrintDialog1.ShowDialog()

    '        filas_recorida = 0
    '        If formato_tarjeta = "CHICAS" Then
    '            PrinttarjetaChica.PrinterSettings = PrintDialog1.PrinterSettings
    '            PrinttarjetaChica.Print()
    '        ElseIf formato_tarjeta = "GRANDES" Then
    '            Printtarjeta.PrinterSettings = PrintDialog1.PrinterSettings
    '            Printtarjeta.Print()
    '        End If

    '        conexion_imprimir.dispose()
    '        'Me.Close()
    '    End If
    '    'imprimir rango

    'End Sub
    'Private Sub txt_inicio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_inicio.KeyPress
    '    If e.KeyChar = Chr(Keys.Enter) And txt_inicio.Text <> "" Then
    '        txt_fin.Focus()
    '    End If
    'End Sub
    'Private Sub txt_fin_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_fin.KeyPress
    '    If e.KeyChar = Chr(Keys.Enter) And txt_inicio.Text <> "" Then
    '        If Val(txt_inicio.Text) > Val(txt_inicio.Text) Then
    '            MsgBox("EL NUMERO INICIAL NO PUEDE SER MAYOR AL FINAL")
    '            txt_inicio.Focus()
    '        Else
    '            btn_imprimir_rango.Enabled = True

    '        End If
    '    End If
    'End Sub
End Class