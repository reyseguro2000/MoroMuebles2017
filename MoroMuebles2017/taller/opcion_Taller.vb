Public Class opcion_Taller
    Private Sub bt_salidas_Click(sender As Object, e As EventArgs) Handles bt_salidas.Click
        salida_taller.lbl_clave.Text = lbl_clave.Text
        salida_taller.lbl_taller.Text = lbl_taller.Text

        salida_taller.ShowDialog()
        'Me.Close()
        carga()
    End Sub

    Private Sub opcion_Taller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        Dim conexion_local As New base_local
        conexion_local.llena_combo(cmb_taller, "select * from taller order by taller")
        cmb_taller.DisplayMember = "taller"
        cmb_taller.ValueMember = "clave_taller"
        conexion_local.dispose()
    End Sub


    Private Sub btn_buscar_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(dtg_salida_taller, "select clave_taller_folio as id, cantidad, pendientes, fecha from taller_folio where taller=" & cmb_taller.SelectedValue.ToString & " order by taller")
        conexion_local.dispose()
        bt_salidas.Enabled = True
        lbl_clave.Text = cmb_taller.SelectedValue.ToString
        lbl_taller.Text = cmb_taller.Text
    End Sub

    Private Sub btn_taller_Click(sender As Object, e As EventArgs) Handles btn_taller.Click
        nuevo_taller.ShowDialog()
    End Sub


    Private Sub dtg_merca_taller_DoubleClick(sender As Object, e As EventArgs) Handles dtg_salida_taller.DoubleClick
        detalle_salida.lbl_clave_taller.Text = lbl_clave.Text
        detalle_salida.lbl_taller.Text = lbl_taller.Text
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(detalle_salida.dg_detalle, "select idtaller_detalle as id, taller_folio_d.articulo as clave, articulos.articulo as articulo, detalle, estado from taller_folio_d, articulos where articulos.clave=taller_folio_d.articulo and clave_taller_folio = " & dtg_salida_taller.Item("id", dtg_salida_taller.CurrentRow.Index).Value.ToString)
        conexion_local.dispose()
        detalle_salida.ShowDialog()
        carga()

    End Sub

    Private Sub carga()
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(dtg_salida_taller, "select clave_taller_folio as id, taller, cantidad, pendientes, fecha from taller_folio where taller= " & lbl_clave.Text & " order by pendientes desc")
        'conexion_local.llena_tabla(dg_pendientes, "select clave_salidas_fabrica as Id, Cantidad, Fecha, PENDIENTES from salidas_fabrica where provedor = " & lbl_clave_prov.Text & " order by pendientes")
        conexion_local.dispose()
    End Sub

End Class