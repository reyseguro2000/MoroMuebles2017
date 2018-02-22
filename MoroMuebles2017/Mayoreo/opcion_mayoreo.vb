Public Class opcion_mayoreo
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cliente.Click
        nuevo_cliente_mayoreo.ShowDialog()
    End Sub

    Private Sub btn_ver_Click(sender As Object, e As EventArgs) Handles btn_ver.Click
        mayoreo_historial.lbl_cliente.Text = txt_clave_cliente.Text
        mayoreo_historial.lbl_nombre.Text = txt_cliente.Text
        Dim conexion As New base_local
        conexion.llena_tabla(mayoreo_historial.dg_ventas, "select folio_m as Folio, Fecha, Total, Saldo, Estado, Descuento  from mayoreo_ventas where cliente=" & txt_clave_cliente.Text & " order by saldo, fecha")
        conexion.dispose()
        mayoreo_historial.ShowDialog()

    End Sub

    Private Sub opcion_mayoreo_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim conexion As New base_local
        conexion.llena_tabla(dg_mayoristas, "select cliente,count(folio_m) as Ventas, sum(mayoreo_ventas.saldo) as Saldo, Nombre,tel, Calle, Colonia, Ciudad, Limite from mayoreo_clientes, mayoreo_ventas where clave_i=cliente group by cliente")
        conexion.dispose()
    End Sub

    Private Sub dg_mayoristas_DoubleClick(sender As Object, e As EventArgs) Handles dg_mayoristas.DoubleClick
        txt_clave_cliente.Text = dg_mayoristas.Item("cliente", dg_mayoristas.CurrentRow.Index).Value
        txt_cliente.Text = dg_mayoristas.Item("nombre", dg_mayoristas.CurrentRow.Index).Value
        btn_nueva_venta.Enabled = True
        btn_ver.Enabled = True
    End Sub

    Private Sub btn_nueva_venta_Click(sender As Object, e As EventArgs) Handles btn_nueva_venta.Click
        venta_mayoreo.lbl_clave_cliente.Text = txt_clave_cliente.Text
        venta_mayoreo.lbl_cliente.Text = txt_cliente.Text
        venta_mayoreo.ShowDialog()

    End Sub

    Private Sub opcion_mayoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub


End Class