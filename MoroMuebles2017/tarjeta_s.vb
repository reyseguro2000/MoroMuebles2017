Public Class tarjeta_s

    Dim meses As Integer
    Dim lector2 As Odbc.OdbcDataReader
    Dim fventa As Date
    Dim fila_ventas, fila_pendientessupervisor As DataRow
    Public Sub llena(venta As String)
        Dim conexion As New base_local
        fila_ventas = conexion.repetido("select * from vista_ventas_camionetas where venta='" + l_venta.Text + "'", "vista_ventas_camionetas")
        'fila_ventas = tabla_ventas.Select("venta='" + venta + "'")
        If IsDBNull(fila_ventas("Ruta")) = False Then
            l_bodega.Text = bodega
            l_venta.Text = venta
            l_ruta.Text = fila_ventas("ruta")
            l_cliente.Text = fila_ventas("cliente")
            l_folio.Text = fila_ventas("folio")
            l_fecha.Text = fila_ventas("fecha")
            l_nombre.Text = fila_ventas("nombre")
            l_dir.Text = fila_ventas("calle")+ "  " +fila_ventas("colonia")
            l_total.Text = fila_ventas("total")
            l_enganche.Text = fila_ventas("enganche")
            l_saldo.Text = fila_ventas("saldo")
            l_plazo.Text = fila_ventas("plazo")
            ' l_forma.Text = fila_ventas(0)("forma")
            Select Case fila_ventas("FORMA")
                Case "1"
                    l_forma.Text = "SEMANAL"
                Case "2"
                    l_forma.Text = "QUINCENAL"
                Case "3"
                    l_forma.Text = "MENSUAL"
            End Select
            l_vendedor.Text = fila_ventas("vendedor")
            l_descuento.Text = fila_ventas("descuento")
            l_cracteristicas.Text = fila_ventas("detalle")
            fventa = fila_ventas("fecha")
            Select Case fila_ventas("tipo_d")
                Case "0"
                    l_t_descuento.Text = "SIN DESCUENTO"
                    l_descuento.Text = "0"
                Case "1"
                    l_t_descuento.Text = "MAYO"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "2"
                    l_t_descuento.Text = "DICIEMBRE"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "3"
                    l_t_descuento.Text = "BUEN FIN"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "4"
                    l_t_descuento.Text = "REMATE 1"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "5"
                    l_t_descuento.Text = "REMATE 2"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "6"
                    l_t_descuento.Text = "EXPO"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "7"
                    l_t_descuento.Text = "PAQUETE"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "8"
                    l_t_descuento.Text = "OFERTA"
                    l_descuento.Text = fila_ventas("DESCUENTO")

                Case "9"
                    l_t_descuento.Text = "OTRO"
                    l_descuento.Text = fila_ventas("DESCUENTO")

            End Select
            meses = fila_ventas("plazo")
            l_vence.Text = DateAdd(DateInterval.Month, meses, fventa)
            If fila_ventas("forma") = 1 Then
                l_pagos.Text = (fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")) / (fila_ventas("plazo") * 4)
            End If
            If fila_ventas("forma") = 2 Then
                l_pagos.Text = (fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")) / (fila_ventas("plazo") * 2)
            End If
            If fila_ventas("forma") = 3 Then
                l_pagos.Text = (fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")) / fila_ventas("plazo")
            End If
            l_pagos.Text = Int(l_pagos.Text)
            Dim NPAGOS, CPAGOS, LLEVA, DEVEN, ATRAZO As Integer
            If fila_ventas("forma") = 1 Then
                NPAGOS = DateDiff("w", fventa, Now)
                CPAGOS = (fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")) / (fila_ventas("plazo") * 4)
                NPAGOS = NPAGOS - 4 '2 iniciales 2 filtro 
            End If
            If fila_ventas("forma") = 2 Then
                NPAGOS = DateDiff("w", fventa, Now) / 2
                CPAGOS = (fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")) / (fila_ventas("plazo") * 2)
                NPAGOS = NPAGOS - 2 '1inicial 1 filtro
            End If
            If fila_ventas("forma") = 3 Then
                NPAGOS = DateDiff("m", fventa, Now)
                CPAGOS = (fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")) / fila_ventas("plazo")
                NPAGOS = NPAGOS - 1 '1 filtro
            End If
            LLEVA = fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche") - fila_ventas("saldo")
            'validar pagos fecha de venc
            If l_vence.Text < Now Then
                DEVEN = fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")
            Else
                DEVEN = NPAGOS * CPAGOS
            End If
            'validar pagos mayor a total
            If DEVEN > fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche") Then
                DEVEN = fila_ventas("total") - fila_ventas("descuento") - fila_ventas("enganche")
            End If

            ATRAZO = DEVEN - LLEVA
            lbl_pagos_vencidos.Text = Int(ATRAZO / CPAGOS)
            lbl_atrazado.Text = ATRAZO
            fila_pendientessupervisor = conexion.repetido("select * from pendientessupervisor where venta='" + Mid(l_venta.Text, 4) + "'", "pendientessupervisor")
            'fila_pendientessupervisor = tabla_pendientessupervisor.Select("venta='" + venta + "'")
            If IsDBNull(fila_pendientessupervisor.Item("venta")) = False Then

                Label24.Text = fila_pendientessupervisor.Item("fecha")
                Label26.Text = fila_pendientessupervisor.Item("pvg")
                If fila_pendientessupervisor.Item("estado") = "P" Then Label29.Text = "Pendiente"
                If fila_pendientessupervisor.Item("estado") = "M" Then Label29.Text = "Maquina"
                If fila_pendientessupervisor.Item("estado") = "U" Then Label29.Text = "Urgente"
                If fila_pendientessupervisor.Item("estado") = "R" Then Label29.Text = "Revisada"
                If fila_pendientessupervisor.Item("estado") = "L" Then Label29.Text = "1 Seleccion"
                If fila_pendientessupervisor.Item("estado") = "2" Then Label29.Text = "2 Seleccion"
                If fila_pendientessupervisor.Item("estado") = "S" Then Label29.Text = "Revisar Urgente"
                Button1.Visible = True
                'Button15.Visible = True
                Button16.Visible = True

            Else
                Label24.Text = "No se encuentra"
                Label26.Text = ""
                Label29.Text = ""
                Button1.Visible = False
                Button15.Visible = False
                Button16.Visible = False
            End If
            conexion.llena_tabla(dg_indicaciones, "select indicacion,comentario,usuario,captura from indicaciones where venta='" + venta + "' order by visita desc")
            conexion.llena_tabla(dg_pagos, "select recibo,ruta,cantidad,fecha from pagos_credito where venta='" + venta + "' order by fecha desc")
            conexion.llena_tabla(dg_movimientos, "select movimiento,fecha from movimiento_venta where venta='" + venta + "' order by fecha desc")
            conexion.llena_tabla(dg_articulos, "select cantidad,nombre_articulo as articulo,precio from articulos_ventas where venta='" + venta + "'")


            If Val(Label26.Text) > 0 Then
                Button1.Visible = True
            Else
                Button1.Visible = False
            End If

        Else
            MsgBox("No se encuentra el numero de venta " + venta)
            Me.Close()
        End If

        conexion.dispose()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim conexion As New base_local
        Dim encontrado As DataRow
        encontrado = conexion.repetido("select pvg,fecha,estado from pendientessupervisor where bodega='" + bodega + "' and venta=" + l_venta.Text, "pendientessupervisor")

        If IsDBNull(encontrado.Item("")) = False Then 'lecotr.read
            conexion.InsertarSQL("update pendientessupervisor set estado='S', fecha='" + Format(Now, "yyyy-MM-dd") + "', pvg=" + lbl_pagos_vencidos.Text + " where bodega='" + bodega + "' and venta=" + l_venta.Text)
            conexion.InsertarSQL("INSERT INTO MOVIMIENTOS VALUES('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega + "', 'SE CAMBIO ESTADO REVISION-URGENTE CUENTA" + l_venta.Text + "'," + lbl_pagos_vencidos.Text + ")")

        Else
            conexion.InsertarSQL("insert into pendientessupervisor values ('" + l_venta.Text + "','" + bodega + "'," + l_ruta.Text + ",'" + Format(Now, "yyyy-MM-dd") + "'," + lbl_pagos_vencidos.Text + ",'S')")
            conexion.InsertarSQL("INSERT INTO MOVIMIENTOS VALUES('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega + "', 'SE AGREGO A REVISION-URGENTE CUENTA" + l_venta.Text + "'," + lbl_pagos_vencidos.Text + ")")



        End If
        conexion.dispose()
        MsgBox("VENTA MARCADA COMO URGENTE")
        Me.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New base_local
        Dim encontrado As DataRow
        encontrado = conexion.repetido("select pvg,fecha,estado from pendientessupervisor where bodega='" + bodega + "' and venta=" + l_venta.Text, "pendientessupervisor")

        If IsDBNull(encontrado.Item("venta")) = False Then
            conexion.InsertarSQL("update pendientessupervisor set estado='R' where bodega='" + bodega + "' and venta=" + l_venta.Text)
            conexion.InsertarSQL("INSERT INTO MOVIMIENTOS VALUES('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega + "', 'SE CAMBIO ESTADO A REVISADA CUENTA" + l_venta.Text + "',0)")


        Else
            MsgBox("La venta no esta marcada")
        End If
        conexion.dispose()
        MsgBox("VENTA DESMARCADA, SE QUITARA DE LA LISTA LA PROXIMA VEZ QUE BUSQUE")
        Me.Close()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        agregar_indicacion.llena(Me.l_venta.Text, l_nombre.Text, Label29.Text, Label24.Text)
        agregar_indicacion.ShowDialog()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim conexion As New base_local
        conexion.InsertarSQL("update indicaciones set captura='" + Format(Now, "yyyy-MM-dd") + "' where bodega='" + bodega + "' and clave_ind='" + Me.dg_indicaciones.Item("clave_ind", Me.dg_indicaciones.CurrentRow.Index).Value + "' and venta=" + l_venta.Text)
        conexion.llena_tabla(dg_indicaciones, "SELECT Usuario,Captura as Resuelto, Visita, Persona, Indicacion, Comentario,Cumple, Clave_ind from indicaciones where bodega='" + bodega + "' and venta=" + l_venta.Text + " order by visita")
        conexion.dispose()
        MsgBox("Indicacion cambio de estado")
    End Sub
    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles dg_indicaciones.SelectionChanged
        If Me.dg_indicaciones.RowCount > 0 Then
            If Me.dg_indicaciones.Item("captura", Me.dg_indicaciones.CurrentRow.Index).Value = "1900-01-01" Then
                Me.Button15.Visible = True
                Me.Button15.Enabled = True

            Else
                Me.Button15.Visible = False
                Me.Button15.Enabled = False
            End If
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        PrintDialog1.ShowDialog()
        Printtarjeta.PrinterSettings = PrintDialog1.PrinterSettings
        Printtarjeta.Print()
    End Sub

    Private Sub Printcuenta_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles Printcuenta.PrintPage
        Dim datos_cliente As DataRow
        Dim datos_aval As DataRow
        Dim conexion As New base_local
        Dim Fuente As New System.Drawing.Font("Arial", 8)
        Dim Fuente2 As New System.Drawing.Font("Arial", 14)
        Dim Fuente3 As New System.Drawing.Font("Arial", 8)
        Dim codigo As New System.Drawing.Font("C39HrP48DhTt", 45)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Dim y, x As Int16
        Dim caca As String
        x = 10
        datos_cliente = conexion.repetido("select * from clientes where clave_i=" + l_cliente.Text, "clientes")



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
        If bodega = "TEC" Then Grafico.DrawString("BODEGA TECOZAUTLA", Fuente3, Brushes.Black, x + 10, 20)

        Grafico.DrawString("*" + l_venta.Text + "*", codigo, Brushes.Black, x + 210, 35)
        Grafico.DrawString(l_cliente.Text, Fuente2, Brushes.Black, x + 20, 55)
        Grafico.DrawString(l_ruta.Text, Fuente2, Brushes.Black, x + 110, 55)

        Grafico.DrawString(l_folio.Text, Fuente2, Brushes.Black, x + 150, 55)
        If Val(l_descuento.Text) <> 0 Then Grafico.DrawString("Descuento:  " + Str(l_descuento.Text), Fuente2, Brushes.Black, x + 310, 55)



        ' Grafico.DrawString("VENTA # ", Fuente3, Brushes.Black, x + 20, 75)
        Grafico.DrawString("CLIENTE # ", Fuente3, Brushes.Black, x + 20, 75)
        Grafico.DrawString("RUTA ", Fuente3, Brushes.Black, x + 100, 75)
        Grafico.DrawString("FOLIO ", Fuente3, Brushes.Black, x + 160, 75)


        Grafico.DrawString("Nombre: " + l_nombre.Text, Fuente, Brushes.Black, x + 10, 100)
        Grafico.DrawString("Calle: " + l_dir.Text, Fuente, Brushes.Black, x + 10, 110)
        Grafico.DrawString("Colonia: " + datos_cliente.Item("colonia"), Fuente, Brushes.Black, x + 10, 120)

        Grafico.DrawString("Vendedor: " + l_vendedor.Text, Fuente, Brushes.Black, x + 10, 130)
        Grafico.DrawString("Telefono: " + datos_cliente.Item("telefono"), Fuente, Brushes.Black, x + 10, 140)
        Grafico.DrawString("Domicilio: " + datos_cliente.Item("casa"), Fuente, Brushes.Black, x + 310, 240)
        Grafico.DrawString("Cantidad", Fuente, Brushes.Black, x + 10, 150)
        Grafico.DrawString("Articulo", Fuente, Brushes.Black, x + 70, 150)
        Grafico.DrawString("Precio", Fuente, Brushes.Black, x + 250, 150)
        y = 140

        For fila As Integer = 0 To dg_articulos.RowCount - 1
            Grafico.DrawString(dg_articulos.Item("cantidad", fila).Value, Fuente, Brushes.Black, x + 10, y + 20)
            Grafico.DrawString(dg_articulos.Item("articulo", fila).Value, Fuente, Brushes.Black, x + 70, y + 20)
            Grafico.DrawString(dg_articulos.Item("precio", fila).Value, Fuente, Brushes.Black, x + 250, y + 20)
            y = y + 10
        Next


        Grafico.DrawString("Total: " + Str(l_total.Text), Fuente, Brushes.Black, x + 10, 200)
        Grafico.DrawString("Enganche: " + Str(l_enganche.Text), Fuente, Brushes.Black, x + 150, 200)



        If l_forma.Text = "1" Then Grafico.DrawString("Forma de pago: Semanal", Fuente, Brushes.Black, x + 10, 210)
        If l_forma.Text = "2" Then Grafico.DrawString("Forma de pago: Quincenal", Fuente, Brushes.Black, x + 10, 210)
        If l_forma.Text = "3" Then Grafico.DrawString("Forma de pago: Mensual", Fuente, Brushes.Black, x + 10, 210)
        If l_plazo.Text = "1" Then
            Grafico.DrawString("Plazo: 1 Mes", Fuente, Brushes.Black, x + 10, 220)
        Else
            Grafico.DrawString("Plazo: " + l_plazo.Text + " Meses", Fuente, Brushes.Black, x + 10, 220)
        End If
        caca = "0"
        If l_forma.Text = "1" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text) - Val(l_descuento.Text)) / (4 * Val(l_plazo.Text)))
        If l_forma.Text = "2" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text) - Val(l_descuento.Text)) / (2 * Val(l_plazo.Text)))
        If l_forma.Text = "3" Then caca = Int((Val(l_total.Text) - Val(l_enganche.Text) - Val(l_descuento.Text)) / (Val(l_plazo.Text)))
        Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 150, 220)


        'If lector.Item("venta_clave") = "IRA476" Then
        '    Grafico.DrawString("Plazo: 15 Dias", Fuente, Brushes.Black, x + 10, 220)
        '    Grafico.DrawString("Abonos $" + Str(lector.Item("Saldo")), Fuente, Brushes.Black, x + 150, 220)
        'Else
        '    If lector.Item("plazo") = "1" Then
        '        Grafico.DrawString("Plazo: 1 Mes", Fuente, Brushes.Black, x + 10, 220)
        '    Else
        '        Grafico.DrawString("Plazo: " + lector.Item("plazo") + " Meses", Fuente, Brushes.Black, x + 10, 220)
        '    End If
        '    caca = "0"
        '    If lector.Item("forma") = "1" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche")) - Val(lector.Item("DESCUENTO"))) / (4 * Val(lector.Item("plazo"))))
        '    If lector.Item("forma") = "2" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche")) - Val(lector.Item("DESCUENTO"))) / (2 * Val(lector.Item("plazo"))))
        '    If lector.Item("forma") = "3" Then caca = Int((Val(lector.Item("total")) - Val(lector.Item("enganche")) - Val(lector.Item("DESCUENTO"))) / (Val(lector.Item("plazo"))))
        '    Grafico.DrawString("Abonos $" + caca, Fuente, Brushes.Black, x + 150, 220)
        'End If




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

        'Grafico.DrawString("Esposo " + lector.Item("esposo"), Fuente, Brushes.Black, x + 310, 140)
        'Grafico.DrawString("Calle: " + lector.Item("espcalle") + " # " + lector.Item("espno"), Fuente, Brushes.Black, x + 310, 150)
        'Grafico.DrawString("Colonia" + lector.Item("espcol") + " Ciudad" + lector.Item("espciudad"), Fuente, Brushes.Black, x + 310, 160)


        Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 310, 180)
        Grafico.DrawString(datos_cliente.Item("detalle"), Fuente, Brushes.Black, x + 310, 190)


        Grafico.DrawString("SALDO " + Me.Label2.Text, Fuente2, Brushes.Black, x + 20, 310)
        Grafico.DrawString("A DADO " + Me.Label9.Text, Fuente, Brushes.Black, 500, 250)
        Grafico.DrawString("DEVERIA " + Me.Label8.Text, Fuente, Brushes.Black, 500, 270)
        Grafico.DrawString("DIFERENCIA " + Me.Label10.Text, Fuente, Brushes.Black, 500, 290)
        Grafico.DrawString(Me.Label3.Text, Fuente2, Brushes.Black, 500, 310)



        Grafico.DrawString("RECIBO ", Fuente3, Brushes.Black, x + 80, 350)
        Grafico.DrawString("ABONO ", Fuente3, Brushes.Black, x + 160, 350)
        Grafico.DrawString("FECHA ", Fuente3, Brushes.Black, x + 10, 350)
        ' Grafico.DrawString("SALDO ", Fuente3, Brushes.Black, x + 240, 350)
        y = 350
        For i As Int16 = 0 To dg_pagos.RowCount - 1
            If i = 35 Or i = 70 Or i = 105 Or i = 140 Then
                y = 350
                x = x + 200
                Grafico.DrawString("RECIBO ", Fuente3, Brushes.Black, x + 80, 350)
                Grafico.DrawString("ABONO ", Fuente3, Brushes.Black, x + 160, 350)
                Grafico.DrawString("FECHA ", Fuente3, Brushes.Black, x + 10, 350)
                '        Grafico.DrawString("SALDO ", Fuente3, Brushes.Black, x + 240, 350)
            End If

            Grafico.DrawString(dg_pagos.Item("recibo", i).Value, Fuente3, Brushes.Black, x + 80, y + 20)
            Grafico.DrawString(dg_pagos.Item("cantidad", i).Value, Fuente3, Brushes.Black, x + 160, y + 20)
            Grafico.DrawString(Format(dg_pagos.Item("fecha", i).Value, "dd-MM-yyyy"), Fuente3, Brushes.Black, x + 10, y + 20)
            '   Grafico.DrawString(DataGridView4.Item(4, i).Value, Fuente3, Brushes.Black, x + 240, y + 20)
            y = y + 20
        Next

        ' comando3.Close()


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

        Grafico.DrawString("*" + l_venta.Text + "*", codigo, Brushes.Black, x + 210, 35)
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

        For fila As Integer = 0 To dg_articulos.RowCount - 1
            Grafico.DrawString(dg_articulos.Item("cantidad", fila).Value, Fuente, Brushes.Black, x + 10, y + 20)
            Grafico.DrawString(dg_articulos.Item("articulo", fila).Value, Fuente, Brushes.Black, x + 70, y + 20)
            Grafico.DrawString(dg_articulos.Item("precio", fila).Value, Fuente, Brushes.Black, x + 250, y + 20)
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


        Grafico.DrawString("Caracteristicas del domicilio", Fuente, Brushes.Black, x + 310, 180)
        Grafico.DrawString(casa, Fuente, Brushes.Black, x + 310, 190)

        Grafico.DrawString("SALDO  " + l_saldo.Text, Fuente2, Brushes.Black, x + 90, 330)
        e.HasMorePages = False
        GoTo fin

fin:
        conexion.dispose()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        PrintDialog1.ShowDialog()
        Printcuenta.PrinterSettings = PrintDialog1.PrinterSettings
        Printcuenta.Print()
    End Sub

    Private Sub lbl_formato_cob_Click(sender As Object, e As EventArgs) Handles lbl_formato_cob.Click
        tar_formato_cobra.lbl_clave_cliente.Text = l_cliente.Text
        tar_formato_cobra.lbl_nombre.Text = l_nombre.Text
        tar_formato_cobra.lbl_venta.Text = l_venta.Text
        tar_formato_cobra.ShowDialog()

    End Sub

    Private Sub lbl_formato_sup_Click(sender As Object, e As EventArgs) Handles lbl_formato_sup.Click
        tar_formato_super.lbl_clave_cliente.Text = l_cliente.Text
        tar_formato_super.lbl_nombre.Text = l_nombre.Text
        tar_formato_super.lbl_venta.Text = l_venta.Text
        tar_formato_super.ShowDialog()
    End Sub

    Private Sub bt_modificar_art_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tarjeta_s_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub

    Private Sub l_venta_TextChanged(sender As Object, e As EventArgs) Handles l_venta.TextChanged
        If l_venta.Text <> "Label18" Then
            llena(l_venta.Text)
        End If
    End Sub
End Class