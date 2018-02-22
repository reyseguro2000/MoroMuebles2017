Public Class ventas_pendientes
    Dim fecha_v As Date
    Private Sub ventas_pendientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New base_local
        conexion.llena_tabla(dgventas, "select * from vista_ventas_camionetas where estado='PENDIENTE' order by fecha desc")
        'conexion = New Odbc.OdbcConnection
        'conexion.ConnectionString = cad_con
        'conexion.Open()

        'comando = New Odbc.OdbcCommand("select * from vista_ventas_camionetas where estado='PENDIENTE' order by fecha desc", conexion)
        'da = New Odbc.OdbcDataAdapter
        'da.SelectCommand = comando
        'dt = New DataTable
        'da.Fill(dt)
        'Me.dgventas.DataSource = dt
        conexion.dispose()
    End Sub

    Private Sub dgventas_DoubleClick(sender As Object, e As EventArgs) Handles dgventas.DoubleClick
        llena_datos()
        ventas_ac_re.ShowDialog()
    End Sub
    Public Sub llena_datos()
        ventas_ac_re.l_ruta.Text = dgventas.Item("ruta", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_cliente.Text = dgventas.Item("cliente", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_folio.Text = dgventas.Item("folio", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_fecha.Text = dgventas.Item("fecha", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_nombre.Text = dgventas.Item("nombre", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_dir.Text = dgventas.Item("calle", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_total.Text = dgventas.Item("total", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_enganche.Text = dgventas.Item("enganche", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_plazo.Text = dgventas.Item("plazo", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_saldo.Text = dgventas.Item("saldo", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_forma.Text = dgventas.Item("forma", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_vendedor.Text = dgventas.Item("vendedor", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_descuento.Text = dgventas.Item("descuento", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_t_descuento.Text = dgventas.Item("tipo_d", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_detalle.Text = dgventas.Item("detalle", dgventas.CurrentRow.Index).Value
        fecha_v = dgventas.Item("fecha", dgventas.CurrentRow.Index).Value
        ventas_ac_re.l_vence.Text = DateAdd(DateInterval.Month, Val(ventas_ac_re.l_plazo.Text), fecha_v)
        Dim conexion As New base_local
        conexion.llena_tabla(ventas_ac_re.dgarticulos, "select Cantidad, Articulo, Precio from vista_articulos_ventas where folio='" + ventas_ac_re.l_folio.Text + "'")
        'conexion = New Odbc.OdbcConnection
        'conexion.ConnectionString = cad_con
        'conexion.Open()

        'comando = New Odbc.OdbcCommand("select Cantidad, Articulo, Precio from vista_articulos_ventas where folio='" + ventas_ac_re.l_folio.Text + "'", conexion)
        'da = New Odbc.OdbcDataAdapter
        'da.SelectCommand = comando
        'dt = New DataTable
        'da.Fill(dt)
        'ventas_ac_re.dgarticulos.DataSource = dt
        conexion.dispose()
    End Sub
End Class