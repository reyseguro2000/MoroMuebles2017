Public Class seleccionar_cob
    Private Sub btn_cambiar_Click(sender As Object, e As EventArgs) Handles btn_cambiar.Click
        Dim conexion_cambio As New base_local
        conexion_cambio.InsertarSQL("call rutas_modificar('C'," & lbl_ruta.Text & "," & cmb_cobrador.SelectedValue & ",'" & usuario & "','" & My.Computer.Name & "')")
        conexion_cambio.dispose()
        Me.Dispose()

    End Sub
End Class