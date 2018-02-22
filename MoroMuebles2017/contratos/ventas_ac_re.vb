Public Class ventas_ac_re
    Dim venta_asignada As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'guardar venta
        Dim conexion As New base_local
        venta_asignada = conexion.InsertaEscalar("call ventas_aceptar('" + l_folio.Text + "','" + bodega + "','" + usuario + "','" + My.Computer.Name + "')")
        conexion.dispose()
        'conexion = New Odbc.OdbcConnection(cad_con)
        'conexion.Open()
        'comando = New Odbc.OdbcCommand("call ventas_aceptar('" + l_folio.Text + "','" + bodega + "','" + usuario + "','" + My.Computer.Name + "')", conexion)
        'venta_asignada = comando.ExecuteScalar
        PrintDialog1.ShowDialog()
        Printtarjeta.PrinterSettings = PrintDialog1.PrinterSettings
        Printtarjeta.Print()
        MsgBox("Venta guardada con el numero" + venta_asignada.ToString)
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'rechazar
        'entrada articulos
        Dim conexion As New base_local
        conexion.InsertarSQL("call venta_rechazar('" + l_folio.Text + "','" + bodega + "','" + usuario + "','" + My.Computer.Name + "')")
        conexion.dispose()
        MsgBox("VENTA RECHAZADA")
        Me.Close()
    End Sub

    Private Sub Printtarjeta_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Printtarjeta.PrintPage

        Dim datos_cliente As DataRow
        Dim datos_aval As DataRow
        Dim conexion As New base_local
        Dim Fuente As New System.Drawing.Font("Arial", 8)
        Dim Fuente2 As New System.Drawing.Font("Arial", 10)
        Dim Fuente3 As New System.Drawing.Font("Arial", 8)
        Dim codigo As New System.Drawing.Font("C39HrP48DhTt", 45)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Dim y, x As Int16
        Dim caca, tipo_desc As String

        datos_cliente = conexion.repetido("select * from clientes where clave_i=" + l_cliente.Text, "clientes")
        x = 5

        Grafico.DrawLine(Pens.Black, x + 10, 40, x + 210, 40)
        Grafico.DrawLine(Pens.Black, x + 10, 90, x + 210, 90)
        Grafico.DrawLine(Pens.Black, x + 10, 40, x + 10, 90)
        Grafico.DrawLine(Pens.Black, x + 100, 40, x + 100, 90)
        Grafico.DrawLine(Pens.Black, x + 140, 40, x + 140, 90)
        Grafico.DrawLine(Pens.Black, x + 210, 40, x + 210, 90)

        If bodega = "ACA" Then Grafico.DrawString("BODEGA ACAMBARO", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "MAR" Then Grafico.DrawString("BODEGA MARAVATIO", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "MOR" Then Grafico.DrawString("BODEGA MOROLEON", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "VAL" Then Grafico.DrawString("BODEGA VALLE", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "IRA" Then Grafico.DrawString("BODEGA IRAPUATO", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "ACT" Then Grafico.DrawString("BODEGA ACTOPAN", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "SAN" Then Grafico.DrawString("BODEGA SAN JUAN", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "ZIT" Then Grafico.DrawString("BODEGA ZITACUARO", Fuente3, Brushes.Black, x + 10, 20)
        If bodega = "TEC" Then Grafico.DrawString("BODEGA TECOZAUTLA", Fuente3, Brushes.Black, x + 10, 20)

        Grafico.DrawString("*" + venta_asignada.ToString + "*", codigo, Brushes.Black, x + 210, 35)
        Grafico.DrawString(l_cliente.Text, Fuente2, Brushes.Black, x + 20, 55)
        Grafico.DrawString(l_ruta.Text, Fuente2, Brushes.Black, x + 110, 55)
        Grafico.DrawString(l_folio.Text, Fuente2, Brushes.Black, x + 150, 55)
        tipo_desc = ""
        If Val(l_descuento.Text) > 0 Then
            Grafico.DrawString("SE DESCONTO " + l_t_descuento.Text + " $ " + Str(l_descuento.Text), Fuente2, Brushes.Black, x + 310, 55)
        End If

        Grafico.DrawString("CLIENTE # ", Fuente3, Brushes.Black, x + 20, 75)
        Grafico.DrawString("RUTA ", Fuente3, Brushes.Black, x + 100, 75)
        Grafico.DrawString("FOLIO ", Fuente3, Brushes.Black, x + 160, 75)

        Grafico.DrawString("Nombre: " + l_nombre.Text, Fuente, Brushes.Black, x + 10, 100)
        Grafico.DrawString("Calle:  " + l_dir.Text, Fuente, Brushes.Black, x + 10, 110)
        Grafico.DrawString("Colonia: " + datos_cliente.Item("colonia"), Fuente, Brushes.Black, x + 10, 120)

        Grafico.DrawString("Vendedor:  " + l_vendedor.Text, Fuente, Brushes.Black, x + 10, 130)
        Grafico.DrawString("Telefono: " + datos_cliente.Item("telefono"), Fuente, Brushes.Black, x + 10, 140)
        ' Grafico.DrawString("Domicilio: " + l_detalle.Text, Fuente, Brushes.Black, x + 310, 240)
        Grafico.DrawString("Cantidad", Fuente, Brushes.Black, x + 10, 150)
        Grafico.DrawString("Articulo", Fuente, Brushes.Black, x + 70, 150)
        Grafico.DrawString("Precio", Fuente, Brushes.Black, x + 250, 150)
        y = 140

        For fila As Integer = 0 To dgarticulos.RowCount - 1
            Grafico.DrawString(dgarticulos.Item("cantidad", fila).Value, Fuente, Brushes.Black, x + 10, y + 20)
            Grafico.DrawString(dgarticulos.Item("articulo", fila).Value, Fuente, Brushes.Black, x + 70, y + 20)
            Grafico.DrawString(dgarticulos.Item("precio", fila).Value, Fuente, Brushes.Black, x + 250, y + 20)
            y = y + 10
        Next



        Grafico.DrawString("Total: " + l_total.Text, Fuente, Brushes.Black, x + 10, 200)
        Grafico.DrawString("Enganche: " + l_enganche.Text, Fuente, Brushes.Black, x + 150, 200)

        Grafico.DrawString("Forma de pago: " + l_forma.Text, Fuente, Brushes.Black, x + 10, 210)


        If l_forma.Text = "1" Then Grafico.DrawString("Forma de pago: Semanal", Fuente, Brushes.Black, x + 10, 210)
        If l_forma.Text = "2" Then Grafico.DrawString("Forma de pago: Quincenal", Fuente, Brushes.Black, x + 10, 210)
        If l_forma.Text = "3" Then Grafico.DrawString("Forma de pago: Mensual", Fuente, Brushes.Black, x + 10, 210)
        If l_plazo.Text = "1" Then
            Grafico.DrawString("Plazo: 1 Mes", Fuente, Brushes.Black, x + 10, 220)
        Else
            Grafico.DrawString("Plazo: " + l_plazo.Text + " Meses", Fuente, Brushes.Black, x + 10, 220)
        End If
        caca = "0"
        If l_forma.Text = "1" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text)) / (4 * Val(l_plazo.Text)))
        If l_forma.Text = "2" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text)) / (2 * Val(l_plazo.Text)))
        If l_forma.Text = "3" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text)) / (Val(l_plazo.Text)))
        Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 150, 220)



        'If lector.Item("venta_clave") = "IRA476" Then
        '        Grafico.DrawString("Plazo: 15 Dias", Fuente, Brushes.Black, x + 10, 220)
        '        Grafico.DrawString("Abonos $" + Str(lector.Item("Saldo")), Fuente, Brushes.Black, x + 150, 220)
        '    Else
        '        If lector.Item("plazo") = "1" Then
        '            Grafico.DrawString("Plazo: 1 Mes", Fuente, Brushes.Black, x + 10, 220)
        '        Else
        '            Grafico.DrawString("Plazo: " + lector.Item("plazo") + " Meses", Fuente, Brushes.Black, x + 10, 220)
        '        End If
        '        caca = "0"
        '        If lector.Item("forma") = "1" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche"))) / (4 * Val(lector.Item("plazo"))))
        '        If lector.Item("forma") = "2" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche"))) / (2 * Val(lector.Item("plazo"))))
        '        If lector.Item("forma") = "3" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche"))) / (Val(lector.Item("plazo"))))
        '        Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 150, 220)
        '    End If



        'If lector.Item("dia") = "1" Then Grafico.DrawString("Dia de pago: Domingo", Fuente, Brushes.Black, x + 10, 230)
        'If lector.Item("dia") = "2" Then Grafico.DrawString("Dia de pago: Lunes", Fuente, Brushes.Black, x + 10, 230)
        'If lector.Item("dia") = "3" Then Grafico.DrawString("Dia de pago: Martes", Fuente, Brushes.Black, x + 10, 230)
        'If lector.Item("dia") = "4" Then Grafico.DrawString("Dia de pago: Miercoles", Fuente, Brushes.Black, x + 10, 230)
        'If lector.Item("dia") = "5" Then Grafico.DrawString("Dia de pago: Jueves", Fuente, Brushes.Black, x + 10, 230)
        'If lector.Item("dia") = "6" Then Grafico.DrawString("Dia de pago: Viernes", Fuente, Brushes.Black, x + 10, 230)
        'If lector.Item("dia") = "7" Then Grafico.DrawString("Dia de pago: Sabado", Fuente, Brushes.Black, x + 10, 230)


        'Grafico.DrawString("Primer pago: " + lector.Item("primer_pago"), Fuente, Brushes.Black, 10, 240)
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

        Grafico.DrawString("Fecha de venta: " + l_fecha.Text, Fuente, Brushes.Black, x + 350, 25)
        Grafico.DrawString("Fecha de vencimiento: " + l_vence.Text, Fuente, Brushes.Black, x + 320, 35)

        Grafico.DrawString("Ref1 " + datos_cliente.Item("rnombre"), Fuente, Brushes.Black, x + 310, 90)
        Grafico.DrawString("Calle: " + datos_cliente.Item("rcalle"), Fuente, Brushes.Black, x + 310, 100)
        Grafico.DrawString("Colonia" + datos_cliente.Item("rcolonia") + " Ciudad" + datos_cliente.Item("rciudad"), Fuente, Brushes.Black, x + 310, 120)

        datos_aval = conexion.repetido("select * from aval where folio='" + l_folio.Text + "'", "aval")
        If IsDBNull(datos_aval.Item("folio")) Then
            Grafico.DrawString("Esposo " + datos_cliente.Item("conyuge"), Fuente, Brushes.Black, x + 310, 140)
        Else
            Grafico.DrawString("Esposo " + datos_aval.Item("nombre"), Fuente, Brushes.Black, x + 310, 140)
            Grafico.DrawString("Calle: " + datos_aval.Item("clle"), Fuente, Brushes.Black, x + 310, 150)
            Grafico.DrawString("Colonia" + datos_aval.Item("colonia") + " Ciudad" + datos_aval.Item("ciudad"), Fuente, Brushes.Black, x + 310, 160)
        End If

        '  Grafico.DrawString("Esposo " + datos_cliente.Item("conyuge"), Fuente, Brushes.Black, x + 310, 140)
        'Grafico.DrawString("Calle: " + datos_cliente.Item("espcalle") + " # " + datos_cliente.Item("espno"), Fuente, Brushes.Black, x + 310, 150)
        'Grafico.DrawString("Colonia" + datos_cliente.Item("espcol") + " Ciudad" + datos_cliente.Item("espciudad"), Fuente, Brushes.Black, x + 310, 160)


        Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 310, 180)
        Grafico.DrawString(casa, Fuente, Brushes.Black, x + 310, 190)

        Grafico.DrawString("SALDO  " + l_saldo.Text, Fuente2, Brushes.Black, x + 90, 330)
        e.HasMorePages = False
        GoTo fin

fin:
        conexion.dispose()




        '        Dim datos_cliente As DataRow
        '        Dim conexion As New base_local
        '        Dim Fuente As New System.Drawing.Font("Arial", 8)
        '        Dim Fuente2 As New System.Drawing.Font("Arial", 10)
        '        Dim Fuente3 As New System.Drawing.Font("Arial", 8)
        '        Dim codigo As New System.Drawing.Font("C39HrP48DhTt", 45)
        '        Dim Grafico As System.Drawing.Graphics = e.Graphics
        '        Dim y, x As Int16
        '        Dim caca, tipo_desc As String

        '        datos_cliente = conexion.repetido("select * from clientes where clave_i=" + l_cliente.Text, "clientes")


        '        x = 5

        '        'CUADRO
        '        'Grafico.DrawLine(Pens.Black, x + 10, 30, x + 220, 30)
        '        'Grafico.DrawLine(Pens.Black, x + 10, 90, x + 220, 90)

        '        'Grafico.DrawLine(Pens.Black, x + 10, 30, x + 10, 90)
        '        'Grafico.DrawLine(Pens.Black, x + 220, 30, x + 220, 90)

        '        'Grafico.DrawLine(Pens.Black, x + 80, 30, x + 80, 90)
        '        'Grafico.DrawLine(Pens.Black, x + 160, 30, x + 160, 90)

        '        Grafico.DrawLine(Pens.Black, x + 10, 40, x + 210, 40)
        '        Grafico.DrawLine(Pens.Black, x + 10, 90, x + 210, 90)

        '        'Grafico.DrawLine(Pens.Black, x + 10, 30, x + 10, 90)
        '        Grafico.DrawLine(Pens.Black, x + 10, 40, x + 10, 90)
        '        Grafico.DrawLine(Pens.Black, x + 100, 40, x + 100, 90)

        '        Grafico.DrawLine(Pens.Black, x + 140, 40, x + 140, 90)
        '        Grafico.DrawLine(Pens.Black, x + 210, 40, x + 210, 90)



        '        If bodega = "ACA" Then Grafico.DrawString("BODEGA ACAMBARO", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "MAR" Then Grafico.DrawString("BODEGA MARAVATIO", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "MOR" Then Grafico.DrawString("BODEGA MOROLEON", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "VAL" Then Grafico.DrawString("BODEGA VALLE", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "IRA" Then Grafico.DrawString("BODEGA IRAPUATO", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "ACT" Then Grafico.DrawString("BODEGA ACTOPAN", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "SAN" Then Grafico.DrawString("BODEGA SAN JUAN", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "ZIT" Then Grafico.DrawString("BODEGA ZITACUARO", Fuente3, Brushes.Black, x + 10, 20)
        '        If bodega = "TEC" Then Grafico.DrawString("BODEGA TECOZAUTLA", Fuente3, Brushes.Black, x + 10, 20)

        '        'Grafico.DrawString("BODEGA IRAPUATO", Fuente3, Brushes.Black, x + 10, 20)
        '        Grafico.DrawString("*" + venta_asignada.ToString + "*", codigo, Brushes.Black, x + 210, 35)
        '        'Grafico.DrawString(lector.Item("numero_venta"), Fuente2, Brushes.Black, x + 20, 55)
        '        Grafico.DrawString(l_cliente.Text, Fuente2, Brushes.Black, x + 20, 55)
        '        Grafico.DrawString(l_ruta.Text, Fuente2, Brushes.Black, x + 110, 55)

        '        Grafico.DrawString(l_folio.Text, Fuente2, Brushes.Black, x + 150, 55)
        '        tipo_desc = ""
        '        If Val(l_descuento.Text) > 0 Then

        '            'If lector.Item("tipo_desc") = 1 Then tipo_desc = "MAYO $"
        '            'If lector.Item("tipo_desc") = 2 Then tipo_desc = "DICI $"
        '            'If lector.Item("tipo_desc") = 3 Then tipo_desc = "BUEN FIN $"
        '            'If lector.Item("tipo_desc") = 4 Then tipo_desc = "REMATE 1 $"
        '            'If lector.Item("tipo_desc") = 5 Then tipo_desc = "REMATE 2 $"
        '            'If lector.Item("tipo_desc") = 6 Then tipo_desc = "EXPO $"
        '            'If lector.Item("tipo_desc") = 7 Then tipo_desc = "PAQUETE $"
        '            'If lector.Item("tipo_desc") = 8 Then tipo_desc = "OTRO  $"
        '            'If lector.Item("tipo_desc") = 9 Then tipo_desc = "OFERTA $"


        '            'If lector.Item("tipo_desc") = 1 Then tipo_desc = "MAYO $"
        '            'If lector.Item("tipo_desc") = 2 Then tipo_desc = "DIC $"
        '            'If lector.Item("tipo_desc") = 3 Then tipo_desc = "BUEN FIN $"
        '            'If lector.Item("tipo_desc") = 4 Then tipo_desc = "REMATE 1 $"
        '            'If lector.Item("tipo_desc") = 5 Then tipo_desc = "REMATE 2 $"
        '            'If lector.Item("tipo_desc") = 6 Then tipo_desc = "EXPO $"
        '            'If lector.Item("tipo_desc") = 7 Then tipo_desc = "OTRO $"

        '            'If lector.Item("descuento") <> 0 Then 
        '            Grafico.DrawString("SE DESCONTO " + l_t_descuento.Text + " $ " + Str(l_descuento.Text), Fuente2, Brushes.Black, x + 310, 55)
        '        End If
        '        'If lector.Item("descuento") <> 0 Then Grafico.DrawString("Descuento:  " + Str(lector.Item("descuento")), Fuente2, Brushes.Black, x + 310, 55)



        '        ' Grafico.DrawString("VENTA # ", Fuente3, Brushes.Black, x + 20, 75)
        '        Grafico.DrawString("CLIENTE # ", Fuente3, Brushes.Black, x + 20, 75)
        '        Grafico.DrawString("RUTA ", Fuente3, Brushes.Black, x + 100, 75)
        '        Grafico.DrawString("FOLIO ", Fuente3, Brushes.Black, x + 160, 75)


        '        Grafico.DrawString("Nombre: " + l_nombre.Text, Fuente, Brushes.Black, x + 10, 100)
        '        Grafico.DrawString("Calle:  " + l_dir.Text, Fuente, Brushes.Black, x + 10, 110)
        '        'Grafico.DrawString("Colonia: " + l_colonia"), Fuente, Brushes.Black, x + 10, 120)

        '        Grafico.DrawString("Vendedor: " + l_vendedor.Text, Fuente, Brushes.Black, x + 10, 130)
        '        'Grafico.DrawString("Telefono: " + l_telefono"), Fuente, Brushes.Black, x + 10, 140)
        '        Grafico.DrawString("Domicilio: " + l_detalle.Text, Fuente, Brushes.Black, x + 310, 240)
        '        Grafico.DrawString("Cantidad", Fuente, Brushes.Black, x + 10, 150)
        '        Grafico.DrawString("Articulo", Fuente, Brushes.Black, x + 70, 150)
        '        Grafico.DrawString("Precio", Fuente, Brushes.Black, x + 250, 150)
        '        y = 140

        '        For fila As Integer = 0 To dgarticulos.RowCount
        '            Grafico.DrawString(dgarticulos.Item("cantidad", fila).Value, Fuente, Brushes.Black, x + 10, y + 20)
        '            Grafico.DrawString(dgarticulos.Item("articulo", fila).Value, Fuente, Brushes.Black, x + 70, y + 20)
        '            Grafico.DrawString(dgarticulos.Item("precio", fila).Value, Fuente, Brushes.Black, x + 250, y + 20)
        '            y = y + 10
        '        Next



        '        Grafico.DrawString("Total: " + l_total.Text, Fuente, Brushes.Black, x + 10, 200)
        '        Grafico.DrawString("Enganche: " + l_enganche.Text, Fuente, Brushes.Black, x + 150, 200)

        '        Grafico.DrawString("Forma de pago: " + l_forma.Text, Fuente, Brushes.Black, x + 10, 210)


        '        If l_forma.Text = "1" Then Grafico.DrawString("Forma de pago: Semanal", Fuente, Brushes.Black, x + 10, 210)
        '        If l_forma.Text = "2" Then Grafico.DrawString("Forma de pago: Quincenal", Fuente, Brushes.Black, x + 10, 210)
        '        If l_forma.Text = "3" Then Grafico.DrawString("Forma de pago: Mensual", Fuente, Brushes.Black, x + 10, 210)
        '        If l_plazo.Text = "1" Then
        '            Grafico.DrawString("Plazo: 1 Mes", Fuente, Brushes.Black, x + 10, 220)
        '        Else
        '            Grafico.DrawString("Plazo: " + l_plazo.Text + " Meses", Fuente, Brushes.Black, x + 10, 220)
        '        End If
        '        caca = "0"
        '        If l_forma.Text = "1" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text)) / (4 * Val(l_plazo.Text)))
        '        If l_forma.Text = "2" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text)) / (2 * Val(l_plazo.Text)))
        '        If l_forma.Text = "3" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text)) / (Val(l_plazo.Text)))
        '        Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 150, 220)



        '        'If lector.Item("venta_clave") = "IRA476" Then
        '        '        Grafico.DrawString("Plazo: 15 Dias", Fuente, Brushes.Black, x + 10, 220)
        '        '        Grafico.DrawString("Abonos $" + Str(lector.Item("Saldo")), Fuente, Brushes.Black, x + 150, 220)
        '        '    Else
        '        '        If lector.Item("plazo") = "1" Then
        '        '            Grafico.DrawString("Plazo: 1 Mes", Fuente, Brushes.Black, x + 10, 220)
        '        '        Else
        '        '            Grafico.DrawString("Plazo: " + lector.Item("plazo") + " Meses", Fuente, Brushes.Black, x + 10, 220)
        '        '        End If
        '        '        caca = "0"
        '        '        If lector.Item("forma") = "1" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche"))) / (4 * Val(lector.Item("plazo"))))
        '        '        If lector.Item("forma") = "2" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche"))) / (2 * Val(lector.Item("plazo"))))
        '        '        If lector.Item("forma") = "3" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche"))) / (Val(lector.Item("plazo"))))
        '        '        Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 150, 220)
        '        '    End If



        '        'If lector.Item("dia") = "1" Then Grafico.DrawString("Dia de pago: Domingo", Fuente, Brushes.Black, x + 10, 230)
        '        'If lector.Item("dia") = "2" Then Grafico.DrawString("Dia de pago: Lunes", Fuente, Brushes.Black, x + 10, 230)
        '        'If lector.Item("dia") = "3" Then Grafico.DrawString("Dia de pago: Martes", Fuente, Brushes.Black, x + 10, 230)
        '        'If lector.Item("dia") = "4" Then Grafico.DrawString("Dia de pago: Miercoles", Fuente, Brushes.Black, x + 10, 230)
        '        'If lector.Item("dia") = "5" Then Grafico.DrawString("Dia de pago: Jueves", Fuente, Brushes.Black, x + 10, 230)
        '        'If lector.Item("dia") = "6" Then Grafico.DrawString("Dia de pago: Viernes", Fuente, Brushes.Black, x + 10, 230)
        '        'If lector.Item("dia") = "7" Then Grafico.DrawString("Dia de pago: Sabado", Fuente, Brushes.Black, x + 10, 230)


        '        'Grafico.DrawString("Primer pago: " + lector.Item("primer_pago"), Fuente, Brushes.Black, 10, 240)
        '        Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 10, 230)
        '        Dim l, li As Integer
        '        Dim casa As String
        '        l = 1
        '        li = 1
        '        casa = ""
        '        While l <= Len(l_detalle.Text)
        '            casa = casa + Mid(l_detalle.Text, l, 1)
        '            If li > 35 And Mid(l_detalle.Text, l, 1) = " " Then
        '                li = 1
        '                casa = casa + vbCrLf
        '            Else
        '                li = li + 1
        '            End If
        '            l = l + 1
        '        End While

        '        Grafico.DrawString(casa, Fuente, Brushes.Black, x + 10, 250)

        '        Grafico.DrawString("Fecha de venta: " + l_fecha.Text, Fuente, Brushes.Black, x + 350, 25)
        '        Grafico.DrawString("Fecha de vencimiento: " + l_vence.Text, Fuente, Brushes.Black, x + 320, 35)

        '        'Grafico.DrawString("Ref1 " + lref1nom"), Fuente, Brushes.Black, x + 310, 90)
        '        Grafico.DrawString("Calle: " + datos_cliente.Item("ref1calle") + " # " + datos_cliente.Item("ref1no"), Fuente, Brushes.Black, x + 310, 100)
        '        Grafico.DrawString("Colonia" + datos_cliente.Item("ref1col") + " Ciudad" + datos_cliente.Item("ref1ciudad"), Fuente, Brushes.Black, x + 310, 120)

        '        Grafico.DrawString("Esposo " + datos_cliente.Item("conyuge"), Fuente, Brushes.Black, x + 310, 140)
        '        'Grafico.DrawString("Calle: " + datos_cliente.Item("espcalle") + " # " + datos_cliente.Item("espno"), Fuente, Brushes.Black, x + 310, 150)
        '        'Grafico.DrawString("Colonia" + datos_cliente.Item("espcol") + " Ciudad" + datos_cliente.Item("espciudad"), Fuente, Brushes.Black, x + 310, 160)


        '        Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 310, 180)
        '        Grafico.DrawString(casa, Fuente, Brushes.Black, x + 310, 190)

        '        Grafico.DrawString("SALDO  " + l_bodega.Text, Fuente2, Brushes.Black, x + 90, 330)
        '        e.HasMorePages = True
        '        GoTo fin

        'fin:
        '        conexion.dispose()
    End Sub
End Class