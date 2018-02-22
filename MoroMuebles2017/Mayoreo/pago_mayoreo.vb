Public Class pago_mayoreo
    Private Sub txt_cantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cantidad.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txt_cantidad.Text <> "" Then
                lbl_resta.Text = Val(lbl_saldo.Text) - txt_cantidad.Text
                btn_guardar.Enabled = True
            End If
        End If
    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim recibo_provedor As Integer
        Dim inserta_recibo As New base_local
        recibo_provedor = inserta_recibo.InsertaEscalar("call insertar_pago_mayoreo('" & lbl_folio.Text & "'," & txt_cantidad.Text & ",'" & usuario & "','" & My.Computer.Name & "')")

        inserta_recibo.dispose()
        MsgBox("Recibo guardado No " & recibo_provedor.ToString)
        Me.Dispose()

    End Sub

    Private Sub pago_mayoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub
End Class