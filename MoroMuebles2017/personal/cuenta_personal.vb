Public Class cuenta_personal
    Private Sub lbl_buscar_Click(sender As Object, e As EventArgs) Handles lbl_buscar.Click
        Try
            Dim conexion_principal As New base_principal

            conexion_principal.llena_tabla(dg_depositos, "")
            conexion_principal.llena_tabla(dg_retiros, "")
            conexion_principal.llena_tabla(dg_prestamos, "")

            conexion_principal.dispose()

        Catch ex As Exception
            MsgBox("No se puede conectar")
        End Try
    End Sub
End Class