Public Class agregar_ruta
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion_local As New base_local
        conexion_local.InsertarSQL("call rutas_nueva(" & lbl_ruta.Text & "," & cmb_cobrador.SelectedValue.ToString & "," & cmb_supervisor.SelectedValue.ToString & ",'" & usuario & "','" & My.Computer.Name & "')")

        conexion_local.dispose()
        MsgBox("Registrado correctamente")
        Me.Dispose()
    End Sub
End Class