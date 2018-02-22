Public Class entrada_detalle
    Private Sub entrada_detalle_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub bt_pago_Click(sender As Object, e As EventArgs) Handles bt_pago.Click
        pago_provedor.lbl_provedor.Text = lbl_provedor.Text
        pago_provedor.lbl_folio.Text = lbl_folio.Text
        pago_provedor.lbl_saldo.Text = lbl_saldo.Text

        pago_provedor.ShowDialog()

    End Sub

    Private Sub entrada_detalle_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(dg_articulos, "select * from entradas_fabrica where folio_c='" & lbl_folio.Text & "' order by fecha")
        conexion_local.llena_tabla(dg_pagos, "select cantidad,fecha from pago_provedor where folio='" & lbl_folio.Text & "' order by fecha")
        conexion_local.dispose()
    End Sub
End Class