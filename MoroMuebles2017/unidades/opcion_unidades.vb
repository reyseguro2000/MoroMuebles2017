Public Class opcion_unidades
    Private Sub opcion_unidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        carga_camionetas()
        carga_motos()
    End Sub
    Private Sub carga_camionetas()
        Dim conexion As New base_local
        conexion.llena_tabla(dt_camionetas, "select * from vista_camionetas where mid(bodega,1,3)='" & Mid(muebleria_ciudad, 1, 3) & "'")
        'conexion.llena_tabla(dt_camionetas, "select * from unidades_camionetas where mid(unidades_camionetas.bodega,1,3)='" & Mid(muebleria_ciudad, 1, 3) & "'")
        conexion.dispose()
    End Sub
    Private Sub carga_motos()
        Dim conexion As New base_local
        conexion.llena_tabla(dt_motos, "select * from vista_motos where mid(bodega,1,3)='" & Mid(muebleria_ciudad, 1, 3) & "'")
        'conexion.llena_tabla(dt_motos, "select * from unidades_motos where mid(unidades_motos.bodega,1,3)='" & Mid(muebleria_ciudad, 1, 3) & "'")
        conexion.dispose()
    End Sub

    Private Sub bt_nuevo_camioneta_Click(sender As Object, e As EventArgs) Handles bt_nuevo_camioneta.Click
        camioneta.btn_modificar.Visible = False
        camioneta.btn_nuevo.Visible = True
        camioneta.ShowDialog()

    End Sub

    Private Sub btn_nuevo_moto_Click(sender As Object, e As EventArgs) Handles btn_nuevo_moto.Click
        moto.btn_nuevo.Visible = True
        moto.btn_modificar.Visible = False
        moto.ShowDialog()

    End Sub

    Private Sub dt_camionetas_DoubleClick(sender As Object, e As EventArgs) Handles dt_camionetas.DoubleClick
        'camioneta.btn_modificar.Visible = True
        'camioneta.btn_nuevo.Visible = False
        'camioneta.ShowDialog()
        lbl_id_camioneta.Text = dt_camionetas.Item("id", dt_camionetas.CurrentRow.Index).Value
        lbl_chofer_camioneta.Text = dt_camionetas.Item("nombre", dt_camionetas.CurrentRow.Index).Value
    End Sub

    Private Sub dt_motos_DoubleClick(sender As Object, e As EventArgs) Handles dt_motos.DoubleClick
        'moto.btn_modificar.Visible = True
        'moto.btn_nuevo.Visible = False
        'moto.ShowDialog()
        lbl_chofer_moto.Text = dt_motos.Item("nombre", dt_motos.CurrentRow.Index).Value
        lbl_id_moto.Text = dt_motos.Item("id", dt_motos.CurrentRow.Index).Value
    End Sub

    Private Sub btn_cambio_camioneta_Click(sender As Object, e As EventArgs) Handles btn_cambio_camioneta.Click
        cambiar_chofer.lbl_tipo.Text = "Camioneta"
        cambiar_chofer.lbl_unidad.Text = lbl_id_camioneta.Text
        cambiar_chofer.lbl_chofer.Text = lbl_chofer_camioneta.Text
        cambiar_chofer.ShowDialog()

    End Sub

    Private Sub btn_cambio_moto_Click(sender As Object, e As EventArgs) Handles btn_cambio_moto.Click
        cambiar_chofer.lbl_tipo.Text = "Moto"
        cambiar_chofer.lbl_unidad.Text = lbl_id_moto.Text
        cambiar_chofer.lbl_chofer.Text = lbl_chofer_moto.Text
        cambiar_chofer.ShowDialog()
    End Sub
End Class