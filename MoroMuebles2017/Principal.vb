Public Class Principal
    Private Sub bt_fabrica_Click(sender As Object, e As EventArgs) Handles bt_fabrica.Click
        opcion_Fabrica.ShowDialog()
    End Sub

    Private Sub bt_camioneta_Click(sender As Object, e As EventArgs) Handles bt_camioneta.Click
        opcion_Camioneta.ShowDialog()

    End Sub

    Private Sub bt_taller_Click(sender As Object, e As EventArgs) Handles bt_taller.Click
        opcion_Taller.ShowDialog()

    End Sub



    Private Sub bt_pagos_Click(sender As Object, e As EventArgs) Handles bt_pagos.Click
        opcion_Pagos.Show()

    End Sub

    Private Sub bt_listados_Click(sender As Object, e As EventArgs) Handles btn_myoreo.Click
        opcion_mayoreo.ShowDialog()
        'opcion_Listado.Show()
        'lista_precios_12meses.ShowDialog()
    End Sub

    Private Sub bt_contrato_Click(sender As Object, e As EventArgs) Handles bt_contrato.Click
        opcion_Contrato.ShowDialog()

    End Sub

    Private Sub bt_clientes_Click(sender As Object, e As EventArgs) Handles bt_clientes.Click
        opcion_clientes.ShowDialog()

    End Sub

    Private Sub Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        img_logo.ImageLocation = "c:\fotos\logo.jpg"
        '  Me.BackgroundImage = Captura.My.Resources.Fondo4
        Me.Text = "MUEBLERIA  " + muebleria_nombre

        'Me.BackColor = Color.FromName(usuario_fondo)
        Me.ForeColor = Color.FromName(usuario_texto)

        lbl_muebleria.Text = muebleria_nombre
        lbl_usuario.Text = usuario
        lbl_boega.Text = bodega
        lbl_actualizacion.Text = Format(ultima_actualizacion, "dd-MM-yyyy HH:mm:ss")
    End Sub



    Private Sub busca_venta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles busca_venta.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If tipo = 1 Then
                tarjeta.l_venta.Text = bodega + busca_venta.Text
                tarjeta.llena(tarjeta.l_venta.Text)
                tarjeta.ShowDialog()
            ElseIf tipo = 2 Then
                tarjeta_s.l_venta.Text = bodega + busca_venta.Text
                tarjeta_s.ShowDialog()
            End If

        End If

    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        actualiza.ShowDialog()

    End Sub

    Private Sub bt_reportes_Click(sender As Object, e As EventArgs) Handles bt_reportes.Click
        reporte_entradas_salidas.ShowDialog()

    End Sub

    Private Sub bt_tarjetas_Click(sender As Object, e As EventArgs) Handles bt_tarjetas.Click
        'listado_tarjetas.Dispose()

        'listado_tarjetas.ShowDialog()
        configuracion.ShowDialog()


    End Sub

    Private Sub bt_personal_Click(sender As Object, e As EventArgs) Handles bt_personal.Click
        opcion_Personal.ShowDialog()

    End Sub

    Private Sub bt_unidades_Click_1(sender As Object, e As EventArgs) Handles bt_unidades.Click
        opcion_unidades.ShowDialog()
    End Sub

    Private Sub bt_articulos_Click(sender As Object, e As EventArgs) Handles bt_articulos.Click
        listado_articulos.ShowDialog()

    End Sub
End Class
