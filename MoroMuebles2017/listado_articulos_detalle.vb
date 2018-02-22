Public Class listado_articulos_detalle
    Private Sub op_inicio_CheckedChanged(sender As Object, e As EventArgs) Handles op_inicio.CheckedChanged

        If op_inicio.Checked = True Then
            Dim conexion_local As New base_local
            conexion_local.llena_tabla(dg_entradas, "select * from entradas where articulo='" & lbl_clave.Text & "' ")
            conexion_local.llena_tabla(dg_salidas, "select * from salidas where articulo='" & lbl_clave.Text & "' ")
            conexion_local.dispose()
        End If
    End Sub

    Private Sub op_ultimo_CheckedChanged(sender As Object, e As EventArgs) Handles op_ultimo.CheckedChanged
        If op_ultimo.Checked = True Then
            Dim ultimo_invenario As Date = lbl_ultimo.Text
            Dim conexion_local As New base_local
            conexion_local.llena_tabla(dg_entradas, "select * from entradas where articulo='" & lbl_clave.Text & "' and fecha >'" & Format(ultimo_invenario, "yyyy-MM-dd HH:mm:ss") & "'")
            conexion_local.llena_tabla(dg_salidas, "select * from salidas where articulo='" & lbl_clave.Text & "' and fecha >'" & Format(ultimo_invenario, "yyyy-MM-dd HH:mm:ss") & "'")
            conexion_local.dispose()
        End If
    End Sub

    Private Sub op_ultimo_corte_CheckedChanged(sender As Object, e As EventArgs) Handles op_ultimo_corte.CheckedChanged
        If op_ultimo_corte.Checked = True Then
            Dim ultimo_invenario As Date = lbl_ultimo.Text
            Dim conexion_local As New base_local
            conexion_local.llena_tabla(dg_entradas, "select * from entradas where articulo='" & lbl_clave.Text & "' and fecha >'" & Format(ultimo_invenario, "yyyy-MM-dd HH:mm:ss") & "'")
            conexion_local.llena_tabla(dg_salidas, "select * from salidas where articulo='" & lbl_clave.Text & "' and fecha >'" & Format(ultimo_invenario, "yyyy-MM-dd HH:mm:ss") & "'")
            conexion_local.dispose()
        End If
    End Sub
End Class