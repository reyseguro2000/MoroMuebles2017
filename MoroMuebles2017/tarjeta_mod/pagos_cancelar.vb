Public Class pagos_cancelar
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim conexion As New base_local
        conexion.InsertarSQL("call cancelar_pago('" + lbl_recibo.Text + "','" + lbl_venta.Text + "'," + lbl_cantidad.Text + ",'" + TextBox1.Text + "','" + usuario + "','" + My.Computer.Name + "')") '+recibo text", in _venta text, in _cantidad int, in _motivo text, in _usuario text, in _maquina text)
        conexion.dispose()
        MsgBox("PAGO CANCELADO")
        Me.Close()
    End Sub
End Class