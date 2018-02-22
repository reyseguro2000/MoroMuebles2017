Public Class opcion_Fabrica
    Private Sub bt_entradas_Click(sender As Object, e As EventArgs) Handles bt_entradas.Click
        entradas_fabrica.clave_provedor = cmb_provedor.SelectedValue
        entradas_fabrica.nombre_provedor = cmb_provedor.Text

        entradas_fabrica.ShowDialog()
    End Sub

    Private Sub bt_salidas_Click(sender As Object, e As EventArgs) Handles bt_salidas.Click
        salida_fabrica.lbl_clave_provedor.Text = lbl_clave_prov.Text
        salida_fabrica.lbl_provedor.Text = lbl_nombre_provedor.Text
        salida_fabrica.ShowDialog()
        carga()
    End Sub

    Private Sub opcion_Fabrica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        Dim conexion_local As New base_local

        conexion_local.llena_combo(cmb_provedor, "select * from provedores where activo='A' order by nombre")
        cmb_provedor.DisplayMember = "nombre"
        cmb_provedor.ValueMember = "clave"
        conexion_local.dispose()
    End Sub

    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        lbl_clave_prov.Text = cmb_provedor.SelectedValue.ToString
        lbl_nombre_provedor.Text = cmb_provedor.Text

        carga()

        bt_entradas.Enabled = True
        bt_salidas.Enabled = True
    End Sub

    Private Sub dg_compras_DoubleClick(sender As Object, e As EventArgs) Handles dg_compras.DoubleClick
        entrada_detalle.lbl_provedor.Text = lbl_clave_prov.Text
        entrada_detalle.lbl_folio.Text = dg_compras.Item("folio", dg_compras.CurrentRow.Index).Value.ToString
        entrada_detalle.lbl_saldo.Text = dg_compras.Item("saldo", dg_compras.CurrentRow.Index).Value.ToString
        entrada_detalle.ShowDialog()
        carga()
    End Sub

    Private Sub dg_pendientes_DoubleClick(sender As Object, e As EventArgs) Handles dg_pendientes.DoubleClick
        salida_fabrica_detalle.lbl_clave_provedor.Text = lbl_clave_prov.Text
        salida_fabrica_detalle.lbl_provedor.Text = lbl_nombre_provedor.Text
        salida_fabrica_detalle.lbl_salida.Text = dg_pendientes.Item("id", dg_pendientes.CurrentRow.Index).Value
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(salida_fabrica_detalle.dg_articulos, "select idsalidas_fabrica_d as id, salidas_fabrica_d.articulo as clave, articulos.articulo as articulo, detalle, estado from salidas_fabrica_d, articulos where articulos.clave=salidas_fabrica_d.articulo and clave_salida = " & dg_pendientes.Item("id", dg_pendientes.CurrentRow.Index).Value.ToString)
        conexion_local.dispose()
        salida_fabrica_detalle.ShowDialog()
        carga()
    End Sub
    Private Sub carga()
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(dg_compras, "select folio_c as folio, fecha, total, saldo from entradas_fabrica where folio_c like '" & cmb_provedor.SelectedValue.ToString & "-%' order by fecha desc")
        conexion_local.llena_tabla(dg_pendientes, "select clave_salidas_fabrica as Id, Cantidad, Fecha, PENDIENTES from salidas_fabrica where provedor = " & lbl_clave_prov.Text & " order by pendientes")
        conexion_local.dispose()
    End Sub
End Class