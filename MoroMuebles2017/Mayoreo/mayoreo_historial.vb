Public Class mayoreo_historial
    Private Sub dg_ventas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_ventas.CellContentClick

    End Sub

    Private Sub dg_ventas_DoubleClick(sender As Object, e As EventArgs) Handles dg_ventas.DoubleClick
        Dim conexion As New base_local
        lbl_folio.Text = dg_ventas.Item("folio", dg_ventas.CurrentRow.Index).Value
        lbl_saldo.Text = dg_ventas.Item("saldo", dg_ventas.CurrentRow.Index).Value
        conexion.llena_tabla(dg_articulos, "select Cantidad, articulos.Articulo as Articulo, mayoreo_detalle.Precio as Precio  from mayoreo_detalle, articulos where clave=mayoreo_detalle.articulo and folio=" & lbl_folio.Text)
        conexion.llena_tabla(dg_pagos, "select Rec, Cantidad, Fecha  from mayoreo_pagos where venta=" & lbl_folio.Text & " order by fecha")
        conexion.dispose()
    End Sub

    Private Sub bt_pago_Click(sender As Object, e As EventArgs) Handles bt_pago.Click
        pago_mayoreo.lbl_cliente.Text = lbl_cliente.Text
        pago_mayoreo.lbl_nombre.Text = lbl_nombre.Text
        pago_mayoreo.lbl_folio.Text = lbl_folio.Text
        pago_mayoreo.lbl_saldo.Text = lbl_saldo.Text
        pago_mayoreo.ShowDialog()

    End Sub

    Private Sub mayoreo_historial_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub
End Class