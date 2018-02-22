Public Class seleccionar_tarjeta
    Private Sub btn_chicas_Click(sender As Object, e As EventArgs) Handles btn_chicas.Click
        formato_tarjeta = "CHICAS"
        Me.Dispose()

    End Sub

    Private Sub btn_grandes_Click(sender As Object, e As EventArgs) Handles btn_grandes.Click
        formato_tarjeta = "GRANDES"
        Me.Dispose()

    End Sub
End Class