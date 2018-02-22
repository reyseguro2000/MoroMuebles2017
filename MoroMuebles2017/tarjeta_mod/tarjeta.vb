Public Class tarjeta
    Dim meses As Integer
    Dim fventa As Date
    Dim lector2 As Odbc.OdbcDataReader
    Dim caca, pagos As Integer
    Dim fila_ventas, fila_pendientessupervisor As DataRow
    'Public Sub llena(venta As String)
    '    fila_ventas = tabla_ventas.Select("venta='" + venta + "'")
    '    If fila_ventas.Length > 0 Then
    '        l_bodega.Text = bodega
    '        l_venta.Text = venta
    '        l_ruta.Text = fila_ventas(0)("ruta")
    '        l_cliente.Text = fila_ventas(0)("cliente")
    '        l_folio.Text = fila_ventas(0)("folio")
    '        l_fecha.Text = fila_ventas(0)("fecha")
    '        l_nombre.Text = fila_ventas(0)("nombre")
    '        l_dir.Text = fila_ventas(0)("direccion")
    '        l_total.Text = fila_ventas(0)("total")
    '        l_enganche.Text = fila_ventas(0)("enganche")
    '        l_saldo.Text = fila_ventas(0)("saldo")
    '        l_plazo.Text = fila_ventas(0)("plazo")
    '        ' l_forma.Text = fila_ventas(0)("forma")
    '        Select Case fila_ventas(0)("FORMA")
    '            Case "1"
    '                l_forma.Text = "SEMANAL"
    '            Case "2"
    '                l_forma.Text = "QUINCENAL"
    '            Case "3"
    '                l_forma.Text = "MENSUAL"
    '        End Select
    '        l_vendedor.Text = fila_ventas(0)("vendedor")
    '        l_descuento.Text = fila_ventas(0)("descuento")
    '        l_cracteristicas.Text = fila_ventas(0)("fachada")
    '        fventa = fila_ventas(0)("fecha")
    '        Select Case fila_ventas(0)("tipo_desc")
    '            Case "0"
    '                l_t_descuento.Text = "SIN DESCUENTO"
    '                l_descuento.Text = "0"
    '            Case "1"
    '                l_t_descuento.Text = "MAYO"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "2"
    '                l_t_descuento.Text = "DICIEMBRE"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "3"
    '                l_t_descuento.Text = "BUEN FIN"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "4"
    '                l_t_descuento.Text = "REMATE 1"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "5"
    '                l_t_descuento.Text = "REMATE 2"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "6"
    '                l_t_descuento.Text = "EXPO"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "7"
    '                l_t_descuento.Text = "PAQUETE"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "8"
    '                l_t_descuento.Text = "OFERTA"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '            Case "9"
    '                l_t_descuento.Text = "OTRO"
    '                l_descuento.Text = fila_ventas(0)("DESCUENTO")

    '        End Select
    '        meses = fila_ventas(0)("plazo")
    '        l_vence.Text = DateAdd(DateInterval.Month, meses, fventa)
    '        If fila_ventas(0)("forma") = 1 Then
    '            l_pagos.Text = (fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")) / (fila_ventas(0)("plazo") * 4)
    '        End If
    '        If fila_ventas(0)("forma") = 2 Then
    '            l_pagos.Text = (fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")) / (fila_ventas(0)("plazo") * 2)
    '        End If
    '        If fila_ventas(0)("forma") = 3 Then
    '            l_pagos.Text = (fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")) / fila_ventas(0)("plazo")
    '        End If
    '        l_pagos.Text = Int(l_pagos.Text)
    '        Dim NPAGOS, CPAGOS, LLEVA, DEVEN, ATRAZO As Integer
    '        If fila_ventas(0)("forma") = 1 Then
    '            NPAGOS = DateDiff("w", fventa, Now)
    '            CPAGOS = (fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")) / (fila_ventas(0)("plazo") * 4)
    '            NPAGOS = NPAGOS - 2
    '        End If
    '        If fila_ventas(0)("forma") = 2 Then
    '            NPAGOS = DateDiff("w", fventa, Now) / 2
    '            CPAGOS = (fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")) / (fila_ventas(0)("plazo") * 2)
    '            NPAGOS = NPAGOS - 1
    '        End If
    '        If fila_ventas(0)("forma") = 3 Then
    '            NPAGOS = DateDiff("m", fventa, Now)
    '            CPAGOS = (fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")) / fila_ventas(0)("plazo")
    '            NPAGOS = NPAGOS - 1
    '        End If
    '        LLEVA = fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche") - fila_ventas(0)("saldo")

    '        If l_vence.Text < Now Then
    '            DEVEN = fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")
    '        Else
    '            DEVEN = NPAGOS * CPAGOS
    '        End If
    '        If DEVEN > fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche") Then
    '            DEVEN = fila_ventas(0)("total") - fila_ventas(0)("descuento") - fila_ventas(0)("enganche")
    '        End If



    '        ATRAZO = DEVEN - LLEVA
    '        Label20.Text = Int(ATRAZO / CPAGOS)
    '        Label22.Text = ATRAZO
    '        fila_pendientessupervisor = tabla_pendientessupervisor.Select("venta='" + venta + "'")
    '        If fila_pendientessupervisor.Length > 0 Then

    '            Label24.Text = fila_pendientessupervisor(0).Item("fecha")
    '            Label26.Text = fila_pendientessupervisor(0).Item("pvg")
    '            If fila_pendientessupervisor(0).Item("estado") = "P" Then Label29.Text = "Pendiente"
    '            If fila_pendientessupervisor(0).Item("estado") = "M" Then Label29.Text = "Maquina"
    '            If fila_pendientessupervisor(0).Item("estado") = "U" Then Label29.Text = "Urgente"
    '            If fila_pendientessupervisor(0).Item("estado") = "R" Then Label29.Text = "Revisada"
    '            If fila_pendientessupervisor(0).Item("estado") = "L" Then Label29.Text = "1 Seleccion"
    '            If fila_pendientessupervisor(0).Item("estado") = "2" Then Label29.Text = "2 Seleccion"
    '            If fila_pendientessupervisor(0).Item("estado") = "S" Then Label29.Text = "Revisar Urgente"
    '            Button1.Visible = True
    '            'Button15.Visible = True
    '            Button16.Visible = True

    '        Else
    '            Label24.Text = "No se encuentra"
    '            Label26.Text = ""
    '            Label29.Text = ""
    '            Button1.Visible = False
    '            Button15.Visible = False
    '            Button16.Visible = False
    '        End If

    '        Dim f_indicacion, f_pagos, f_movimientos, f_articulos As New DataTable
    '        'f_indicacion()

    '        'indicaciones
    '        f_indicacion = tabla_indicaciones.Clone
    '        fila_indicacion = tabla_indicaciones.Select("venta='" + venta + "'", "visita desc")
    '        Dim dataRows As DataRow() = fila_indicacion 'dt_v.Select(a)
    '        Dim typeDataRow As DataRow
    '        For Each typeDataRow In fila_indicacion
    '            f_indicacion.ImportRow(typeDataRow)
    '        Next
    '        Me.DataGridView3.DataSource = f_indicacion

    '        'pagos
    '        f_pagos = tabla_pagos.Clone
    '        fila_pagos = tabla_pagos.Select("venta='" + venta + "'", "fecha desc")
    '        Dim dataRows1 As DataRow() = fila_pagos 'dt_v.Select(a)
    '        Dim typeDataRow1 As DataRow
    '        For Each typeDataRow1 In fila_pagos
    '            f_pagos.ImportRow(typeDataRow1)
    '        Next
    '        Me.DataGridView2.DataSource = f_pagos

    '        'movimientos
    '        f_movimientos = tabla_movimientos.Clone
    '        fila_movimientos = tabla_movimientos.Select("accion like '%" + venta + "'", "hora desc")
    '        Dim dataRows2 As DataRow() = fila_movimientos 'dt_v.Select(a)
    '        Dim typeDataRow2 As DataRow
    '        For Each typeDataRow2 In fila_movimientos
    '            f_movimientos.ImportRow(typeDataRow2)
    '        Next
    '        Me.DataGridView4.DataSource = f_movimientos

    '        'articulos
    '        f_articulos = tabla_articulos.Clone
    '        fila_articulos = tabla_articulos.Select("venta='" + bodega + venta + "'")
    '        Dim dataRows3 As DataRow() = fila_articulos 'dt_v.Select(a)
    '        Dim typeDataRow3 As DataRow
    '        For Each typeDataRow3 In fila_articulos
    '            f_articulos.ImportRow(typeDataRow3)
    '        Next
    '        Me.DataGridView1.DataSource = f_articulos
    '        If Val(Label26.Text) > 0 Then
    '            Button1.Visible = True
    '        Else
    '            Button1.Visible = False
    '        End If

    '    Else
    '        MsgBox("No se encuentra el numero de venta " + venta)
    '        Me.Close()
    '    End If

    '    'conexion = New Odbc.OdbcConnection
    '    'conexion.ConnectionString = cad_con
    '    'conexion.Open()
    '    'comando = New Odbc.OdbcCommand("select ruta, clientes.cli_clave as Cliente, folio, credito.fecha, clientes.nombre as nombre, vendedores.nombre as vendedor, clientes.calle as calle, noint, noext, clientes.colonia as colonia, clientes.ciudad as ciudad, total, enganche, credito.saldo, plazo, forma, descuento, casadatos,tipo_desc  from clientes, credito, vendedores where cli_clave=cliente and vendedor=ven_clave and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    'lector = comando.ExecuteReader()
    '    'If lector.Read Then
    '    '    comando = New Odbc.OdbcCommand("select pvg,fecha,estado from pendientessupervisor where bodega='" + bodega + "' and venta=" + venta, conexion)
    '    '    lector2 = comando.ExecuteReader
    '    '    If lector2.Read Then

    '    '        Label24.Text = lector2.Item("fecha")
    '    '        Label26.Text = lector2.Item("pvg")
    '    '        If lector2.Item("estado") = "P" Then Label29.Text = "Pendiente"
    '    '        If lector2.Item("estado") = "M" Then Label29.Text = "Maquina"
    '    '        If lector2.Item("estado") = "U" Then Label29.Text = "Urgente"
    '    '        If lector2.Item("estado") = "R" Then Label29.Text = "Revisada"
    '    '        If lector2.Item("estado") = "S" Then Label29.Text = "Revisar-Urgente"
    '    '        If lector2.Item("estado") = "L" Then Label29.Text = "Listado1"
    '    '        If lector2.Item("estado") = "2" Then Label29.Text = "Listado 2"
    '    '        Button14.Visible = True
    '    '        'Button15.Visible = True
    '    '        Button16.Visible = True

    '    '    Else
    '    '        Label24.Text = "No se encuentra"
    '    '        Label26.Text = ""
    '    '        Label29.Text = ""
    '    '        Button14.Visible = False
    '    '        Button15.Visible = False
    '    '        Button16.Visible = False
    '    '    End If
    '    '    l_bodega.Text = bodega
    '    '    l_venta.Text = venta
    '    '    l_ruta.Text = lector.Item("ruta")
    '    '    l_cliente.Text = lector.Item("cliente")
    '    '    l_folio.Text = lector.Item("folio")
    '    '    l_fecha.Text = lector.Item("fecha")
    '    '    l_nombre.Text = lector.Item("nombre")
    '    '    l_dir.Text = lector.Item("calle") + " #" + lector.Item("noint") + ", " + lector.Item("noext") + " " + lector.Item("colonia") + ", " + lector.Item("ciudad")
    '    '    l_total.Text = lector.Item("total")
    '    '    l_enganche.Text = lector.Item("enganche")
    '    '    l_saldo.Text = lector.Item("saldo")
    '    '    l_plazo.Text = lector.Item("plazo")

    '    '    Select Case lector.Item("FORMA")
    '    '        Case "1"
    '    '            l_forma.Text = "SEMANAL"
    '    '        Case "2"
    '    '            l_forma.Text = "QUINCENAL"
    '    '        Case "3"
    '    '            l_forma.Text = "MENSUAL"

    '    '    End Select
    '    '    'l_forma.Text = lector.Item("forma")


    '    '    l_vendedor.Text = lector.Item("vendedor")
    '    '    l_descuento.Text = lector.Item("descuento")
    '    '    l_cracteristicas.Text = lector.Item("casadatos")
    '    '    fventa = lector.Item("fecha")
    '    '    Select Case lector.Item("tipo_desc")
    '    '        Case "0"
    '    '            l_t_descuento.Text = "SIN DESCUENTO"
    '    '            l_descuento.Text = "0"
    '    '        Case "1"
    '    '            l_t_descuento.Text = "MAYO"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "2"
    '    '            l_t_descuento.Text = "DICIEMBRE"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "3"
    '    '            l_t_descuento.Text = "BUEN FIN"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "4"
    '    '            l_t_descuento.Text = "REMATE 1"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "5"
    '    '            l_t_descuento.Text = "REMATE 2"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "6"
    '    '            l_t_descuento.Text = "EXPO"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "7"
    '    '            l_t_descuento.Text = "PAQUETE"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "8"
    '    '            l_t_descuento.Text = "OFERTA"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '        Case "9"
    '    '            l_t_descuento.Text = "OTRO"
    '    '            l_descuento.Text = lector.Item("DESCUENTO")

    '    '    End Select

    '    '    meses = lector.Item("plazo")
    '    '    l_vence.Text = DateAdd(DateInterval.Month, meses, fventa)
    '    '    caca = lector.Item("total") - lector.Item("descuento") - lector.Item("enganche")




    '    '    Dim NPAGOS, CPAGOS, LLEVA, DEVEN, ATRAZO As Integer

    '    '    Select Case lector.Item("forma")
    '    '        Case 1
    '    '            NPAGOS = DateDiff("w", fventa, Now)
    '    '            pagos = lector.Item("plazo") * 4
    '    '            l_pagos.Text = caca / pagos
    '    '            NPAGOS = NPAGOS - 2
    '    '        Case 2
    '    '            NPAGOS = DateDiff("w", fventa, Now) / 2
    '    '            pagos = (lector.Item("plazo") * 2)
    '    '            l_pagos.Text = caca / pagos
    '    '            NPAGOS = NPAGOS - 1

    '    '        Case 3
    '    '            NPAGOS = DateDiff("m", fventa, Now)
    '    '            l_pagos.Text = caca / lector.Item("plazo")
    '    '    End Select
    '    '    l_pagos.Text = Int(l_pagos.Text)
    '    '    CPAGOS = l_pagos.Text

    '    '    LLEVA = lector.Item("total") - lector.Item("descuento") - lector.Item("enganche") - lector.Item("saldo")


    '    '    If l_vence.Text < Now Then
    '    '        DEVEN = lector.Item("total") - lector.Item("descuento") - lector.Item("enganche")
    '    '    Else
    '    '        DEVEN = NPAGOS * CPAGOS
    '    '    End If

    '    '    ATRAZO = DEVEN - LLEVA
    '    '    Label20.Text = Int(ATRAZO / CPAGOS)
    '    '    Label22.Text = ATRAZO


    '    '    comando = New Odbc.OdbcCommand("SELECT Usuario, Cumple, Visita, Persona, Indicacion, Comentario, Captura as Resuelto, Clave_ind from indicaciones where bodega='" + bodega + "' and venta=" + venta + " order by visita", conexion)
    '    '    da1 = New Odbc.OdbcDataAdapter(comando)
    '    '    ds = New DataSet
    '    '    da1.Fill(ds)
    '    '    Me.DataGridView3.DataSource = Nothing
    '    '    Me.DataGridView3.DataSource = ds.Tables(0).DefaultView

    '    '    comando = New Odbc.OdbcCommand("SELECT Accion, Hora, Usuario, Importe from movimientos where (bodega='" + bodega1 + "' or bodega='" + bodega + "') and Accion like '%CUENTA" + l_venta.Text + "' order by hora", conexion)
    '    '    da1 = New Odbc.OdbcDataAdapter(comando)
    '    '    ds = New DataSet
    '    '    da1.Fill(ds)
    '    '    Me.DataGridView4.DataSource = ds.Tables(0).DefaultView

    '    '    comando = New Odbc.OdbcCommand("SELECT Cantidad,Articulo, Precio from detalle where venta='" + bodega + venta + "'", conexion)
    '    '    da1 = New Odbc.OdbcDataAdapter(comando)
    '    '    ds = New DataSet
    '    '    da1.Fill(ds)
    '    '    Me.DataGridView1.DataSource = ds.Tables(0).DefaultView

    '    '    'comando = New Odbc.OdbcCommand("SELECT Recibo, Cantidad, Fecha from pagos_" + bodega + " where venta=" + venta + " order by fecha", conexion)
    '    '    comando = New Odbc.OdbcCommand("SELECT Recibo, Cantidad, Fecha from pagos where bodega='" + bodega + "' and venta=" + venta + " order by fecha", conexion)
    '    '    da1 = New Odbc.OdbcDataAdapter(comando)
    '    '    ds = New DataSet
    '    '    da1.Fill(ds)
    '    '    Me.DataGridView2.DataSource = ds.Tables(0).DefaultView
    '    'Else
    '    'MsgBox("No se encuentra el numero de venta " + venta)
    '    'End If
    '    'conexion.Close()
    'End Sub
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
            l_dir.Text = fila_ventas("calle") + "  " + fila_ventas("colonia")
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
            Label20.Text = Int(ATRAZO / CPAGOS)
            Label22.Text = ATRAZO
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

            conexion.llena_tabla(DataGridView3, "select indicacion,comentario,usuario,captura from indicaciones where venta='" + venta + "' order by visita desc")
            conexion.llena_tabla(DataGridView2, "select recibo,ruta,cantidad,fecha from pagos_credito where venta='" + venta + "' order by fecha desc")
            conexion.llena_tabla(DataGridView4, "select movimiento,fecha from movimiento_venta where venta='" + venta + "' order by fecha desc")
            conexion.llena_tabla(DataGridView1, "select cantidad,nombre_articulo as articulo,precio from articulos_ventas where venta='" + venta + "'")

            'conexion.llena_tabla(DataGridView3, "select * from indicaciones where venta='" + venta + "' order by visita desc")
            'conexion.llena_tabla(DataGridView2, "select * from pagos_credito where venta='" + venta + "' order by fecha desc")
            'conexion.llena_tabla(DataGridView4, "select * from movimiento_venta where venta='" + venta + "' order by fecha desc")
            'conexion.llena_tabla(DataGridView1, "select * from articulos_ventas where venta='" + venta + "'")

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
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        'bonificar_cuenta.llena(l_venta.Text)
        bonificar_cuenta.lbl_venta.Text = l_venta.Text
        bonificar_cuenta.Label4.Text = l_nombre.Text 'lector.Item("nombre")
        bonificar_cuenta.Label9.Text = l_saldo.Text 'lector.Item("saldo")
        bonificar_cuenta.Label5.Text = l_cliente.Text 'lector.Item("cliente")
        bonificar_cuenta.ShowDialog()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'modificar_ruta.llena(l_venta.Text)
        modificar_ruta.lbl_venta.Text = l_venta.Text
        modificar_ruta.Label4.Text = l_nombre.Text 'lector.Item("nombre")
        modificar_ruta.Label9.Text = l_saldo.Text 'lector.Item("saldo")
        modificar_ruta.Label5.Text = l_cliente.Text 'lector.Item("cliente")
        modificar_ruta.lbl_ruta.Text = l_ruta.Text 'lector.Item("cliente")

        modificar_ruta.ShowDialog()

    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles Button13.Click
        Dim conexion As New base_local
        conexion.InsertarSQL("call marcar_urgente()")
        conexion.dispose()


        MsgBox("VENTA MARCADA COMO URGENTE")
        Me.Close()
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles Button14.Click
        Dim conexion As New base_local
        conexion.InsertarSQL("call desmarcar_listados()")
        conexion.dispose()


        MsgBox("VENTA DESMARCADA, SE QUITARA DE LA LISTA LA PROXIMA VEZ QUE BUSQUE")
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        modificar_folio.Dispose()
        'modificar_folio.llena(l_venta.Text)
        modificar_folio.Label2.Text = l_venta.Text
        modificar_folio.Label4.Text = l_nombre.Text 'lector.Item("nombre")
        modificar_folio.Label9.Text = l_saldo.Text 'lector.Item("saldo")
        modificar_folio.Label5.Text = l_cliente.Text 'lector.Item("cliente")
        modificar_folio.Label6.Text = l_folio.Text 'lector.Item("cliente")
        modificar_folio.ShowDialog()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        modificar_fecha.Dispose()
        'modificar_fecha.llena(l_venta.Text)
        modificar_fecha.Label2.Text = l_venta.Text
        modificar_fecha.Label4.Text = l_nombre.Text 'lector.Item("nombre")
        modificar_fecha.Label9.Text = l_saldo.Text 'lector.Item("saldo")
        modificar_fecha.Label5.Text = l_cliente.Text 'lector.Item("cliente")
        modificar_fecha.Label6.Text = l_fecha.Text 'lector.Item("cliente")
        modificar_fecha.ShowDialog()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        modificar_enganche.Dispose()
        'modificar_enganche.llena(l_venta.Text)
        modificar_enganche.lbl_venta.Text = l_venta.Text
        modificar_enganche.Label4.Text = l_nombre.Text 'lector.Item("nombre")
        modificar_enganche.lbl_saldo.Text = l_saldo.Text 'lector.Item("saldo")
        modificar_enganche.Label5.Text = l_cliente.Text 'lector.Item("cliente")
        modificar_enganche.lbl_enganche.Text = l_enganche.Text 'lector.Item("cliente")
        modificar_enganche.ShowDialog()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        agregar_indicacion.llena(Me.l_venta.Text, l_nombre.Text, Label29.Text, Label24.Text)
        agregar_indicacion.ShowDialog()
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        Dim conexion As New base_local
        conexion.InsertarSQL("call marcar_cumplio()")
        conexion.llena_tabla(DataGridView3, "SELECT Usuario,Captura as Resuelto, Visita, Persona, Indicacion, Comentario,Cumple, Clave_ind from indicaciones where bodega='" + bodega + "' and venta=" + l_venta.Text + " order by visita")
        conexion.dispose()


        MsgBox("Indicacion cambio de estado")
    End Sub

    Private Sub DataGridView3_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView3.SelectionChanged
        If Me.DataGridView3.RowCount > 0 Then
            If Me.DataGridView3.Item("captura", Me.DataGridView3.CurrentRow.Index).Value = "1900-01-01" Then
                Me.Button15.Visible = True
                Me.Button15.Enabled = True

            Else
                Me.Button15.Visible = False
                Me.Button15.Enabled = False
            End If
        End If
    End Sub


    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles Button12.Click
        'cancelar_cuenta.llena(l_venta.Text)
        cancelar_cuenta.lbl_venta.Text = l_venta.Text
        cancelar_cuenta.lbl_cliente.Text = l_nombre.Text 'lector.Item("nombre")
        cancelar_cuenta.lbl_saldo.Text = l_saldo.Text 'lector.Item("saldo")
        cancelar_cuenta.Label5.Text = l_cliente.Text 'lector.Item("cliente")
        cancelar_cuenta.ShowDialog()
    End Sub

    Private Sub btn_cancelar_Click(sender As Object, e As EventArgs) Handles btn_cancelar.Click
        pagos_cancelar.lbl_venta.Text = l_venta.Text
        pagos_cancelar.lbl_cliente.Text = l_nombre.Text
        pagos_cancelar.lbl_clave_cliente.Text = l_cliente.Text
        pagos_cancelar.lbl_recibo.Text = btn_cancelar.Text
        pagos_cancelar.lbl_cantidad.Text = lbl_cantidad_pago.Text

        pagos_cancelar.Show()
    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        modificar_articulos.Dispose()

        modificar_articulos.lbl_clave.Text = l_cliente.Text
        modificar_articulos.lbl_cliente.Text = l_nombre.Text
        modificar_articulos.lbl_venta.Text = l_venta.Text
        modificar_articulos.lbl_saldo_act.Text = l_saldo.Text

        modificar_articulos.ShowDialog()
        llena(l_venta.Text)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

    End Sub

    Private Sub tarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        ' modificar_plazo.llena(l_venta.Text)
        modificar_plazo.lbl_venta.Text = l_venta.Text
        modificar_plazo.Label4.Text = l_nombre.Text 'lector.Item("nombre")
        modificar_plazo.Label9.Text = l_saldo.Text 'lector.Item("saldo")
        modificar_plazo.Label11.Text = l_fecha.Text 'lector.Item("cliente")
        modificar_plazo.lbl_plazo.Text = l_plazo.Text 'lector.Item("cliente")
        modificar_plazo.ShowDialog()
    End Sub

    Private Sub DataGridView2_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView2.DoubleClick
        btn_cancelar.Enabled = True
        btn_cancelar.Text = DataGridView2.Item("recibo", DataGridView2.CurrentRow.Index).Value
        lbl_cantidad_pago.Text = DataGridView2.Item("cantidad", DataGridView2.CurrentRow.Index).Value
    End Sub

    'Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
    '    Modificar_forma.llena(l_venta.Text)
    '    Modificar_forma.ShowDialog()
    'End Sub

    'Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
    '    modificar_vendedor.llena(l_venta.Text)
    '    modificar_vendedor.ShowDialog()
    'End Sub

    'Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
    '    modificar_descuento.llena(l_venta.Text)
    '    modificar_descuento.ShowDialog()
    'End Sub

End Class