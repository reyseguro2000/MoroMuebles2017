Public Class nuevo_taller
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion As New base_local
        Dim no_taller As Integer
        no_taller = conexion.InsertaEscalar("call insertar_taller('" + txt_taller.Text + "','" + txt_encargado.Text + "','" + txt_calle.Text + "','" + txt_colonia.Text + "','" + txt_telefono.Text + "','" + usuario + "','" + My.Computer.Name + "')")
        MsgBox("TALLER GUARDADO CON LA CLAVE " + no_taller.ToString)
        conexion.dispose()
    End Sub
End Class