Public Class cambiar_chofer
    Private Sub btn_cambiar_Click(sender As Object, e As EventArgs) Handles btn_cambiar.Click
        'Dim conexion_principal As New base_principal
        'conexion_principal.InsertarSQL("call modifica_personal_puesto(" & lbl_clave.Text & ",'" & lbl_puesto.Text & "  " & lbl_sueldo.Text & "','" & cmb_puesto.Text & "'," & txt_sueldo.Text & ",'" & bodega & "','" & My.Computer.Name & "','" & usuario & "')")
        'conexion_principal.dispose()

        Dim conexion_local As New base_local
        conexion_local.InsertarSQL("call cambio_chofer('" & Mid(lbl_tipo.Text, 1, 1) & "'," & lbl_unidad.Text & " , " & cmb_chofer.SelectedValue & ",'" & txt_motivo.Text & "','" & My.Computer.Name & "','" & usuario & "')")
        conexion_local.dispose()

    End Sub

    Private Sub cambiar_chofer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        Dim conexion_local As New base_local
        conexion_local.llena_combo(cmb_chofer, "select clave, nombre from personal where bodega='" & bodega & "' order by nombre")
        cmb_chofer.ValueMember = "clave"
        cmb_chofer.DisplayMember = "nombre"
        conexion_local.llena_tabla(DGmovimientos_unidad, "select nombre,fecha,usuario,maquina from movimiento_unidades,personal where chofer=clave and tipo='" + Mid(lbl_tipo.Text, 1, 1) + "' and unidad=" + lbl_unidad.Text + "")

        conexion_local.dispose()

    End Sub
End Class