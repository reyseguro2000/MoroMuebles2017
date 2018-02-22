Public Class clientes_ventas
    Private Sub clientes_ventas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub
    Private Sub dg_ventas_DoubleClick(sender As Object, e As EventArgs) Handles dg_ventas.DoubleClick


        If tipo = 1 Then
            tarjeta.l_venta.Text = dg_ventas.Item("venta", dg_ventas.CurrentRow.Index).Value
            tarjeta.llena(tarjeta.l_venta.Text)
            tarjeta.ShowDialog()
        ElseIf tipo = 2 Then
            tarjeta_s.l_venta.Text = dg_ventas.Item("venta", dg_ventas.CurrentRow.Index).Value
            'tarjeta.llena(dg_ventas.Item("venta", dg_ventas.CurrentRow.Index).Value)
            tarjeta_s.ShowDialog()
        End If

    End Sub

End Class