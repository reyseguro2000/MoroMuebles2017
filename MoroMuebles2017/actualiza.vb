Public Class actualiza
    Private Sub actualiza_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim mi_conexion_principal As New base_principal
        Dim mi_conexion_local As New base_local

        mi_conexion_principal.llena_tabla(dg_provedor_principal, "select * from provedores")
        mi_conexion_principal.llena_tabla(dg_articulos_principal, "select * from articulos")
        mi_conexion_principal.llena_tabla(dg_personal_principal, "select * from personal")
        mi_conexion_principal.llena_tabla(dg_camionetas_principal, "select * from unidades_camionetas")
        mi_conexion_principal.llena_tabla(dg_motos_principal, "select * from unidades_motos")
        mi_conexion_principal.dispose()

        mi_conexion_local.llena_tabla(dg_provedor_local, "select * from provedores")
        mi_conexion_local.llena_tabla(dg_articulos_local, "select * from articulos")
        mi_conexion_local.llena_tabla(dg_personal_local, "select * from personal")
        mi_conexion_local.llena_tabla(dg_camionetas_local, "select * from unidades_camionetas")
        mi_conexion_local.llena_tabla(dg_motos_local, "select * from unidades_motos")
        mi_conexion_local.dispose()
        'provedores
        For fila_local As Integer = 0 To dg_provedor_local.RowCount - 1
            For fila_princial As Integer = 0 To dg_provedor_principal.RowCount - 1
                If dg_provedor_principal.Item("id", fila_princial).Value = dg_provedor_local.Item("clave", fila_local).Value Then
                    'si lo encuento
                    If dg_provedor_principal.Item("encargado", fila_princial).Value = dg_provedor_local.Item("encargado", fila_local).Value And dg_provedor_principal.Item("tel", fila_princial).Value = dg_provedor_local.Item("tel", fila_local).Value And dg_provedor_principal.Item("cel", fila_princial).Value = dg_provedor_local.Item("cel", fila_local).Value And dg_provedor_principal.Item("activo", fila_princial).Value = dg_provedor_local.Item("activo", fila_local).Value Then
                        'si no cambia algo
                        dg_provedor_principal.Rows(fila_princial).DefaultCellStyle.ForeColor = Color.Green
                    End If
                    GoTo siguiente_provedor
                End If
            Next
siguiente_provedor:
        Next
        'articulos
        For fila_local As Integer = 0 To dg_articulos_local.RowCount - 1
            For fila_princial As Integer = 0 To dg_articulos_principal.RowCount - 1
                If dg_articulos_principal.Item("clave", fila_princial).Value = dg_articulos_local.Item("clave", fila_local).Value Then
                    'si lo encuento
                    If dg_articulos_principal.Item("precio", fila_princial).Value = dg_articulos_local.Item("precio", fila_local).Value And dg_articulos_principal.Item("formula", fila_princial).Value = dg_articulos_local.Item("formula", fila_local).Value And dg_articulos_principal.Item("p_lista", fila_princial).Value = dg_articulos_local.Item("p_lista", fila_local).Value And dg_articulos_principal.Item("activo", fila_princial).Value = dg_articulos_local.Item("activo", fila_local).Value Then
                        'si cambia algo
                        dg_articulos_principal.Rows(fila_princial).DefaultCellStyle.ForeColor = Color.Green
                    End If
                    GoTo siguiente_articulo
                End If
            Next
siguiente_articulo:
        Next


        'persoanl
        For fila_local As Integer = 0 To dg_personal_local.RowCount - 1
            For fila_princial As Integer = 0 To dg_personal_principal.RowCount - 1
                If dg_personal_principal.Item("clave", fila_princial).Value = dg_personal_local.Item("clave", fila_local).Value Then
                    'si lo encuento

                    If dg_personal_principal.Item("PUESTO_ACT", fila_princial).Value = dg_personal_local.Item("PUESTO_ACT", fila_local).Value And dg_personal_principal.Item("estado", fila_princial).Value = dg_personal_local.Item("estado", fila_local).Value And dg_personal_principal.Item("sueldo_ACT", fila_princial).Value = dg_personal_local.Item("sueldo_ACT", fila_local).Value Then
                        'si cambia algo
                        dg_personal_principal.Rows(fila_princial).DefaultCellStyle.ForeColor = Color.Green

                    End If
                    GoTo siguiente_personal
                End If
            Next
siguiente_personal:
        Next
        'camionetas
        For fila_local As Integer = 0 To dg_camionetas_local.RowCount - 1
            For fila_princial As Integer = 0 To dg_camionetas_principal.RowCount - 1
                If dg_camionetas_principal.Item("id", fila_princial).Value = dg_camionetas_local.Item("id", fila_local).Value Then
                    'si lo encuento

                    If dg_camionetas_principal.Item("ESTADO", fila_princial).Value = dg_camionetas_local.Item("ESTADO", fila_local).Value Then
                        'si cambia algo


                        dg_camionetas_principal.Rows(fila_princial).DefaultCellStyle.ForeColor = Color.Green

                    End If
                    GoTo siguiente_camioneta
                End If
            Next
siguiente_camioneta:
        Next
        'motos
        For fila_local As Integer = 0 To dg_motos_local.RowCount - 1
            For fila_princial As Integer = 0 To dg_motos_principal.RowCount - 1
                If dg_motos_principal.Item("id", fila_princial).Value = dg_motos_local.Item("id", fila_local).Value Then
                    'si lo encuento
                    If dg_motos_principal.Item("ESTADO", fila_princial).Value = dg_motos_local.Item("ESTADO", fila_local).Value Then
                        'si cambia algo

                        dg_motos_principal.Rows(fila_princial).DefaultCellStyle.ForeColor = Color.Green

                    End If
                    GoTo siguiente_moto
                End If
            Next
siguiente_moto:
        Next


    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion_actualiza As New base_local
        For fila_princial As Integer = 0 To dg_provedor_principal.RowCount - 1
            conexion_actualiza.InsertarSQL("insert into provedores values(" + dg_provedor_principal.Item("id", fila_princial).Value.ToString + ",'" + dg_provedor_principal.Item("nombre", fila_princial).Value + "','" + dg_provedor_principal.Item("encargado", fila_princial).Value + "','" + dg_provedor_principal.Item("tel", fila_princial).Value + "','" + dg_provedor_principal.Item("cel", fila_princial).Value + "','" + dg_provedor_principal.Item("activo", fila_princial).Value + "') ON DUPLICATE KEY UPDATE encargado='" + dg_provedor_principal.Item("encargado", fila_princial).Value + "', tel='" + dg_provedor_principal.Item("tel", fila_princial).Value + "', cel='" + dg_provedor_principal.Item("cel", fila_princial).Value + "', activo='" + dg_provedor_principal.Item("activo", fila_princial).Value + "'")
        Next

        'articulos

        For fila_princial As Integer = 0 To dg_articulos_principal.RowCount - 1
            conexion_actualiza.InsertarSQL("insert into articulos values('" + dg_articulos_principal.Item("clave", fila_princial).Value + "','" + dg_articulos_principal.Item("articulo", fila_princial).Value + "'," + dg_articulos_principal.Item("precio", fila_princial).Value.ToString + ",0,0,0,0,'" + dg_articulos_principal.Item("formula", fila_princial).Value.ToString + "'," + dg_articulos_principal.Item("p_lista", fila_princial).Value.ToString + ",'" + dg_articulos_principal.Item("activo", fila_princial).Value + "') ON DUPLICATE KEY UPDATE precio=" + dg_articulos_principal.Item("precio", fila_princial).Value.ToString + ", formula='" + dg_articulos_principal.Item("formula", fila_princial).Value.ToString + "', p_lista=" + dg_articulos_principal.Item("p_lista", fila_princial).Value.ToString + ", activo='" + dg_articulos_principal.Item("activo", fila_princial).Value + "'")
        Next


        'persoanl

        For fila_princial As Integer = 0 To dg_personal_principal.RowCount - 1
            conexion_actualiza.InsertarSQL("insert into personal values(" & dg_personal_principal.Item("clave", fila_princial).Value.ToString & ",'" & dg_personal_principal.Item("nombre", fila_princial).Value & "','" & dg_personal_principal.Item("calle", fila_princial).Value & "','" & dg_personal_principal.Item("colonia", fila_princial).Value & "','" & dg_personal_principal.Item("ciudad", fila_princial).Value & "','" & dg_personal_principal.Item("telefono", fila_princial).Value & "','" & dg_personal_principal.Item("peso", fila_princial).Value.ToString & "','" & dg_personal_principal.Item("estatura", fila_princial).Value & "','" & dg_personal_principal.Item("civil", fila_princial).Value & "','" & dg_personal_principal.Item("nacimiento", fila_princial).Value & "','" & dg_personal_principal.Item("curp", fila_princial).Value & "','" & dg_personal_principal.Item("nss", fila_princial).Value & "','" & dg_personal_principal.Item("padre", fila_princial).Value & "','" & dg_personal_principal.Item("madre", fila_princial).Value & "','" & dg_personal_principal.Item("conyuge", fila_princial).Value & "',0,'','','',0,'','',0,'','','',0,'','','','','','',0,'','','','',0,'" & dg_personal_principal.Item("estado", fila_princial).Value & "','" & dg_personal_principal.Item("bodega", fila_princial).Value & "','','','" & dg_personal_principal.Item("puesto_act", fila_princial).Value & "',0,'" & dg_personal_principal.Item("fecha_registro", fila_princial).Value & "') ON DUPLICATE KEY UPDATE bodega='" + dg_personal_principal.Item("bodega", fila_princial).Value + "', puesto_act='" + dg_personal_principal.Item("puesto_act", fila_princial).Value + "', sueldo_act='" + dg_personal_principal.Item("sueldo_act", fila_princial).Value.ToString + "',estado='" + dg_personal_principal.Item("estado", fila_princial).Value + "'")
        Next
        'camionetas

        For fila_princial As Integer = 0 To dg_camionetas_principal.RowCount - 1

        Next

        'motos

        For fila_princial As Integer = 0 To dg_motos_principal.RowCount - 1

        Next

    End Sub
End Class