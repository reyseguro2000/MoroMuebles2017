Public Class detalle_salida
    Private Sub bt_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MsgBox("Se va a modificar el estado del articulo id " & lbl_idx.Text) = MsgBoxResult.Ok Then
            Dim conexion_local As New base_local
            conexion_local.InsertarSQL("CALL modificar_detalle_taller(" & lbl_salida.Text & "," & lbl_idx.Text & ",'" & lbl_clave_articulo.Text & "','" & txt_detalle.Text & "','N','" & My.Computer.Name & "','" & usuario & "')")
            conexion_local.dispose()
            dg_detalle.Item("detalle", dg_detalle.CurrentRow.Index).Value = txt_detalle.Text
            MsgBox("modificado")

        End If
    End Sub
    Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_baja.Click
        If MsgBox("Se va a marcar como baja el articulo id " & lbl_idx.Text) = MsgBoxResult.Ok Then
            Dim conexion_local As New base_local
            conexion_local.InsertarSQL("CALL modificar_detalle_taller(" & lbl_salida.Text & "," & lbl_idx.Text & ",'" & lbl_clave_articulo.Text & "','" & txt_detalle.Text & "','B','" & My.Computer.Name & "','" & usuario & "')")
            conexion_local.dispose()
            dg_detalle.Item("detalle", dg_detalle.CurrentRow.Index).Value = txt_detalle.Text
            dg_detalle.Item("estado", dg_detalle.CurrentRow.Index).Value = "BAJA"
            MsgBox("modificado")
            btn_regreso.Enabled = False
            btn_baja.Enabled = False
        End If
    End Sub
    Private Sub btn_regreso_Click(sender As Object, e As EventArgs) Handles btn_regreso.Click
        If MsgBox("Se va a marcar como regresado el articulo id " & lbl_idx.Text) = MsgBoxResult.Ok Then
            Dim conexion_local As New base_local
            conexion_local.InsertarSQL("CALL modificar_detalle_taller(" & lbl_salida.Text & "," & lbl_idx.Text & ",'" & lbl_clave_articulo.Text & "','" & txt_detalle.Text & "','R','" & My.Computer.Name & "','" & usuario & "')")
            conexion_local.dispose()
            dg_detalle.Item("detalle", dg_detalle.CurrentRow.Index).Value = txt_detalle.Text
            dg_detalle.Item("estado", dg_detalle.CurrentRow.Index).Value = "REGRESO"
            btn_regreso.Enabled = False
            MsgBox("modificado")
            btn_regreso.Enabled = False
            btn_baja.Enabled = False
        End If
    End Sub

    Private Sub dg_detalle_DoubleClick(sender As Object, e As EventArgs) Handles dg_detalle.DoubleClick
        If dg_detalle.Item("ESTADO", dg_detalle.CurrentRow.Index).Value = "REGRESO" Or dg_detalle.Item("ESTADO", dg_detalle.CurrentRow.Index).Value = "BAJA" Then
            MsgBox("EL ARTICULO YA SE MARCO COMO REGRESADO")
            lbl_idx.Text = dg_detalle.Item("id", dg_detalle.CurrentRow.Index).Value
            lbl_clave_articulo.Text = dg_detalle.Item("clave", dg_detalle.CurrentRow.Index).Value
            lbl_articulo.Text = dg_detalle.Item("articulo", dg_detalle.CurrentRow.Index).Value
            txt_detalle.Text = dg_detalle.Item("detalle", dg_detalle.CurrentRow.Index).Value
            btn_regreso.Enabled = False
            btn_baja.Enabled = False
        Else
            lbl_idx.Text = dg_detalle.Item("id", dg_detalle.CurrentRow.Index).Value
            lbl_clave_articulo.Text = dg_detalle.Item("clave", dg_detalle.CurrentRow.Index).Value
            lbl_articulo.Text = dg_detalle.Item("articulo", dg_detalle.CurrentRow.Index).Value
            txt_detalle.Text = dg_detalle.Item("detalle", dg_detalle.CurrentRow.Index).Value
            btn_regreso.Enabled = True
            btn_baja.Enabled = True
        End If

    End Sub

    Private Sub detalle_salida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub
End Class