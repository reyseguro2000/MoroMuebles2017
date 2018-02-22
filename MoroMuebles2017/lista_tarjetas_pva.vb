Public Class lista_tarjetas_pva
    Private Sub btn_atrazadas_Click(sender As Object, e As EventArgs) Handles btn_atrazadas.Click
        Dim recorre_ventas, agrega_venta, saldo_inicial, deve_llevar, lleva_pagado, atrazo_venta, sus_pagos, no_pagos, pagos_atrazados, no_total_pagos As Integer
        Dim tabla_filtro_super = New DataTable
        Dim forma_pago As String = ""
        Dim fila_indicacion, fila_pagos, fila_pendientessupervisor As DataRow
        agrega_venta = 0
        tabla_filtro_super.Columns.Add("Cliente").DataType = System.Type.GetType("System.String")
        tabla_filtro_super.Columns.Add("Venta").DataType = System.Type.GetType("System.String")
        tabla_filtro_super.Columns.Add("Total").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Saldo").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Ultimo")
        tabla_filtro_super.Columns.Add("Vence")
        tabla_filtro_super.Columns.Add("Atraso$").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("PVA").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("PVG").DataType = System.Type.GetType("System.String")
        tabla_filtro_super.Columns.Add("Indicaciones").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Visto").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Novisto").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Estado")
        tabla_filtro_super.Columns.Add("Nombre").DataType = System.Type.GetType("System.String")
        tabla_filtro_super.Columns.Add("Direccion").DataType = System.Type.GetType("System.String")
        tabla_filtro_super.Columns.Add("Fechav")
        tabla_filtro_super.Columns.Add("Plazo").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Enganche").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Descuento").DataType = System.Type.GetType("System.Int32")
        tabla_filtro_super.Columns.Add("Forma").DataType = System.Type.GetType("System.String")
        Dim conexion_retrazada As New base_local

        If opc_sin.Checked = True Then

            conexion_retrazada.llena_tabla(dg_atrazadas, "select * from vista_ventas_camionetas where saldo>0 and ruta=" & lbl_ruta.Text & " and fecha>date_add(now(), INTERVAL -plazo+" & txt_mensual.Value.ToString & " MONTH)")

        ElseIf opc_vencidas.Checked = True Then

            conexion_retrazada.llena_tabla(dg_atrazadas, "select * from vista_ventas_camionetas where saldo>0 and ruta=" & lbl_ruta.Text)

        End If
        ProgressBar1.Minimum = 1
        ProgressBar1.Maximum = dg_atrazadas.RowCount
        ProgressBar1.Visible = True
        lbl_total_ventas.Text = dg_atrazadas.RowCount

        For recorre_ventas = 0 To dg_atrazadas.RowCount - 1
            saldo_inicial = Int(dg_atrazadas.Item("total", recorre_ventas).Value - dg_atrazadas.Item("descuento", recorre_ventas).Value - dg_atrazadas.Item("enganche", recorre_ventas).Value)

            Select Case dg_atrazadas.Item("forma", recorre_ventas).Value
                Case "1"
                    no_total_pagos = dg_atrazadas.Item("plazo", recorre_ventas).Value * 4
                    sus_pagos = Int(saldo_inicial / no_total_pagos)
                    no_pagos = DateDiff("w", dg_atrazadas.Item("fecha", recorre_ventas).Value, Now) - txt_semanal.Value
                    forma_pago = "SEMANAL"

                Case "2"
                    no_total_pagos = dg_atrazadas.Item("plazo", recorre_ventas).Value * 2
                    sus_pagos = Int(saldo_inicial / no_total_pagos)
                    no_pagos = (DateDiff("w", dg_atrazadas.Item("fecha", recorre_ventas).Value, Now) / 2) - txt_semanal.Value
                    forma_pago = "QUINCENAL"
                Case "3"
                    no_total_pagos = dg_atrazadas.Item("plazo", recorre_ventas).Value
                    sus_pagos = Int(saldo_inicial / no_total_pagos)
                    no_pagos = DateDiff("m", dg_atrazadas.Item("fecha", recorre_ventas).Value, Now) - txt_semanal.Value
                    forma_pago = "MENSUAL"
            End Select

            lleva_pagado = saldo_inicial - dg_atrazadas.Item("saldo", recorre_ventas).Value
            deve_llevar = no_pagos * sus_pagos

            If deve_llevar > saldo_inicial Then
                deve_llevar = saldo_inicial
            End If
            atrazo_venta = deve_llevar - lleva_pagado
            pagos_atrazados = atrazo_venta / sus_pagos

            If pagos_atrazados >= 1 Then


                tabla_filtro_super.Rows.Add()
                tabla_filtro_super(agrega_venta)("Cliente") = dg_atrazadas.Item("cliente", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Venta") = dg_atrazadas.Item("venta", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Total") = dg_atrazadas.Item("total", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Saldo") = dg_atrazadas.Item("saldo", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Vence") = DateAdd(DateInterval.Month, dg_atrazadas.Item("plazo", recorre_ventas).Value, dg_atrazadas.Item("fecha", recorre_ventas).Value)
                tabla_filtro_super(agrega_venta)("Atraso$") = atrazo_venta
                tabla_filtro_super(agrega_venta)("PVA") = pagos_atrazados

                fila_pagos = conexion_retrazada.repetido("select cantidad, fecha, recibo from vista_ultimos_pagos where venta='" & dg_atrazadas.Item("venta", recorre_ventas).Value & "' order by fecha desc", "vista_ultimos_pagos")

                'tabla_pagos.Select("venta='" + dg_atrazadas.Item("venta") + "'", "fecha desc")
                If IsDBNull(fila_pagos.Item("recibo")) = False Then tabla_filtro_super(agrega_venta)("Ultimo") = fila_pagos.Item("fecha")

                fila_pendientessupervisor = conexion_retrazada.repetido("select visto, novisto, pvg, estado from pendientessupervisor where venta='" & dg_atrazadas.Item("venta", recorre_ventas).Value & "' order by fecha desc", "pendientessupervisor")
                'tabla_pendientessupervisor.Select("venta='" + dg_atrazadas.Item("venta") + "'")



                If IsDBNull(fila_pendientessupervisor.Item("pvg")) = False Then
                    tabla_filtro_super(agrega_venta)("Visto") = fila_pendientessupervisor.Item("visto")
                    tabla_filtro_super(agrega_venta)("novisto") = fila_pendientessupervisor.Item("novisto")
                    tabla_filtro_super(agrega_venta)("PVG") = fila_pendientessupervisor.Item("PVG")
                    tabla_filtro_super(agrega_venta)("estado") = fila_pendientessupervisor.Item("estado")

                    'fila_indicacion = conexion_retrazada.repetido("select visto, novisto, pvg from pendientessupervisor where venta='" & dg_atrazadas.Item("venta", recorre_ventas).Value & "' order fecha desc", "pendientessupervisor")
                    'tabla_indicaciones.Select("venta='" + dg_atrazadas.Item("venta") + "'", "captura asc")
                    ''tabla_filtro_super(agrega_venta)("Pintar") = fila_indicacion(0)("captura")
                    'If IsDBNull(fila_indicacion.Item("indicaciones")) = False Then
                    '    'tabla_filtro_super(agrega_venta)("indicaciones") = fila_indicacion.Length

                    'End If
                End If

                tabla_filtro_super(agrega_venta)("Nombre") = dg_atrazadas.Item("Nombre", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Direccion") = dg_atrazadas.Item("calle", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Fechav") = dg_atrazadas.Item("fecha", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Plazo") = dg_atrazadas.Item("plazo", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Enganche") = dg_atrazadas.Item("enganche", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Descuento") = dg_atrazadas.Item("descuento", recorre_ventas).Value
                tabla_filtro_super(agrega_venta)("Forma") = forma_pago

                agrega_venta = agrega_venta + 1



            End If

            ProgressBar1.Value = recorre_ventas + 1
        Next





        conexion_retrazada.dispose()
        dg_atrazadas.DataSource = tabla_filtro_super
        dg_atrazadas.Sort(dg_atrazadas.Columns("pva"), System.ComponentModel.ListSortDirection.Descending)
        ProgressBar1.Visible = False
    End Sub

    Private Sub marcar()
        For i = 0 To dg_atrazadas.RowCount - 1
            If IsDBNull(dg_atrazadas.Item("estado", i).Value) = False Then
                If dg_atrazadas.Item("estado", i).Value = "P" Then dg_atrazadas.Rows(i).DefaultCellStyle.BackColor = Color.Green
                If dg_atrazadas.Item("estado", i).Value = "S" Then dg_atrazadas.Rows(i).DefaultCellStyle.BackColor = curgentes.BackColor
                If dg_atrazadas.Item("estado", i).Value = "2" Then dg_atrazadas.Rows(i).DefaultCellStyle.BackColor = Color.Gold
            End If
            If IsDBNull(dg_atrazadas.Item("pvg", i).Value) = False Then
                If dg_atrazadas.Item("pva", i).Value < dg_atrazadas.Item("pvg", i).Value And dg_atrazadas.Item("pvg", i).Value > 0 Then dg_atrazadas.Rows(i).Cells("PVG").Style.BackColor = Color.Coral 'DataGridView1.DefaultCellStyle.BackColor = Color.Beige
                If dg_atrazadas.Item("pva", i).Value >= dg_atrazadas.Item("pvg", i).Value And dg_atrazadas.Item("pvg", i).Value > 0 Then dg_atrazadas.Rows(i).Cells("PVG").Style.BackColor = Color.BlueViolet 'DataGridView1.DefaultCellStyle.BackColor = Color.Blue
            Else
                dg_atrazadas.Item("pvg", i).Value = "0"
            End If

        Next



    End Sub

    Private Sub DataGridView1_Sorted(sender As Object, e As EventArgs) Handles dg_atrazadas.Sorted
        marcar()
    End Sub

End Class