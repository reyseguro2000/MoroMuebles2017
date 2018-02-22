Public Class modificar_articulos
    Private Sub modificar_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btn_cambio_Click(sender As Object, e As EventArgs) Handles btn_cambio.Click
        grp_salida.Visible = True
        grp_seleccion.Visible = False
        Dim conexion_local As New base_local
        conexion_local.llena_combo(cmb_articulo, "select clave, articulo, formula, p_lista from articulos where activo='A' order by articulo")
        conexion_local.llena_tabla(dg_articulos, "select id, cantidad, articulo, nombre_articulo, precio from articulos_ventas where venta='" & lbl_venta.Text & "'")
        conexion_local.dispose()
        cmb_articulo.ValueMember = "clave"
        cmb_articulo.DisplayMember = "articulo"
    End Sub

    Private Sub btn_servicio_Click(sender As Object, e As EventArgs) Handles btn_servicio.Click
        llena_salida()
        btn_servicio_entrada.Visible = True

    End Sub

    Private Sub btn_garantia_Click(sender As Object, e As EventArgs) Handles btn_garantia.Click
        llena_salida()
        btn_garantia_entrada.Visible = True
    End Sub

    Private Sub btn_parcial_Click(sender As Object, e As EventArgs) Handles btn_parcial.Click
        llena_salida()
        btn_parcial_entrada.Visible = True
    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        grp_salida.Enabled = False
        grp_entrada.Visible = True
        lbl_saldo_nuevo.Text = Val(lbl_saldo_act.Text) + Val(lbl_saldo_nuevo.Text) + (Val(txt_precio.Text) * Val(txt_cantidad_salida.Value))
        'btn_cambio_entrada.Visible = True
    End Sub

    Private Sub llena_salida()
        grp_entrada.Visible = True
        grp_salida.Visible = False
        grp_seleccion.Visible = False
        Dim conexion_local As New base_local

        conexion_local.llena_tabla(dg_articulos, "select id, cantidad, articulo, nombre_articulo, precio from articulos_ventas where venta='" & lbl_venta.Text & "'")
        conexion_local.dispose()
    End Sub


    Private Sub dg_articulos_DoubleClick(sender As Object, e As EventArgs) Handles dg_articulos.DoubleClick
        lbl_idx.Text = dg_articulos.Item("id", dg_articulos.CurrentRow.Index).Value
        lbl_articulo.Text = dg_articulos.Item("nombre_articulo", dg_articulos.CurrentRow.Index).Value
        lbl_clave_articulo.Text = dg_articulos.Item("articulo", dg_articulos.CurrentRow.Index).Value
        txt_cantidad_entrada.Text = dg_articulos.Item("cantidad", dg_articulos.CurrentRow.Index).Value
        txt_cantidad_entrada.Maximum = dg_articulos.Item("cantidad", dg_articulos.CurrentRow.Index).Value
        lbl_precio_articulo.Text = dg_articulos.Item("precio", dg_articulos.CurrentRow.Index).Value
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        btn_cambio_entrada.Visible = True
        lbl_saldo_nuevo.Text = Val(lbl_saldo_act.Text) - (Val(txt_cantidad_entrada.Value) * Val(txt_precio.Text))
        If lbl_saldo_nuevo.Text <= 0 Then
            MsgBox("La cuenta quedara Pagada")
        Else
            MsgBox("La cuenta quedara con saldo " & lbl_saldo_nuevo.Text)
        End If
    End Sub

    Private Sub txt_cantidad_entrada_ValueChanged(sender As Object, e As EventArgs) Handles txt_cantidad_entrada.ValueChanged
        lbl_precio_articulo.Text = txt_cantidad_entrada.Value * Val(dg_articulos.Item("precio", dg_articulos.CurrentRow.Index).Value)
    End Sub

    Private Sub btn_cambio_entrada_Click(sender As Object, e As EventArgs) Handles btn_cambio_entrada.Click
        If MsgBox("") = MsgBoxResult.Yes Then
            Dim conexion_local As New base_local
            conexion_local.InsertarSQL("call venta_articulo_('" & lbl_venta.Text & "'," & lbl_saldo_nuevo.Text & ",'" & lbl_clave_articulo.Text & "'," & txt_cantidad_entrada.Value.ToString & ",'" & txt_motivo.Text & "','" & usuario & "','" & My.Computer.Name & "')")
            conexion_local.dispose()
        End If

    End Sub

    Private Sub btn_parcial_entrada_Click(sender As Object, e As EventArgs) Handles btn_parcial_entrada.Click
        If lbl_saldo_nuevo.Text <= 0 Then
            MsgBox("La cuenta quedara en 0")
        Else
            MsgBox("La cuenta quedara con saldo " & lbl_saldo_nuevo.Text)
        End If
    End Sub

    Private Sub btn_garantia_entrada_Click(sender As Object, e As EventArgs) Handles btn_garantia_entrada.Click
        If MsgBox("SE CAMBIARA LA VENTA " & lbl_venta.Text & " A GARANTIA, CONTINUAR?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim conexion_local As New base_local
            conexion_local.InsertarSQL("call venta_articulo_entrada('G'," & lbl_venta.Text & ",'" & lbl_clave_articulo.Text & "'," & txt_cantidad_entrada.Value.ToString & ",'" & txt_motivo.Text & "','" & usuario & "','" & My.Computer.Name & "')")
            conexion_local.dispose()
        End If
    End Sub

    Private Sub btn_servicio_entrada_Click(sender As Object, e As EventArgs) Handles btn_servicio_entrada.Click
        If MsgBox("SE CAMBIARA LA VENTA " & lbl_venta.Text & " A SERVICIO, CONTINUAR?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim conexion_local As New base_local
            conexion_local.InsertarSQL("call venta_articulo_entrada('S'," & lbl_venta.Text & ",'" & lbl_clave_articulo.Text & "'," & txt_cantidad_entrada.Value.ToString & ",'" & txt_motivo.Text & "','" & usuario & "','" & My.Computer.Name & "')")
            conexion_local.dispose()
        End If
    End Sub
End Class