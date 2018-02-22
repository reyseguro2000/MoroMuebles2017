Public Class opcion_Camioneta
    Private Sub bt_entradas_Click(sender As Object, e As EventArgs) Handles bt_entradas.Click

        entradas_camioneta.ShowDialog()

    End Sub

    Private Sub bt_salidas_Click(sender As Object, e As EventArgs) Handles bt_salidas.Click
        If dg_ultimas_salidas.RowCount > 0 Then
            'dg_ultimas_salidas.Columns().s
            If dg_ultimas_salidas.Item("regresa", dg_ultimas_salidas.CurrentRow.Index).Value = -1 Then

                If MsgBox("Ya existe una salida pendite selecciona una opcion" & vbCrLf & "Yes para continuar" & vbCrLf & "No para cerrar", MsgBoxStyle.YesNo) = MsgBoxResult.Ok Then
                    salidas_camioneta.Continuar.Visible = True
                    salidas_camioneta.guardar.Enabled = False
                ElseIf MsgBoxResult.No Then
                    salidas_camioneta.Close()
                    llena_detalle()


                    GoTo sal

                End If
                
            End If

        End If
        salidas_camioneta.Close()
        salidas_camioneta.lbl_clave_camioneta.Text = lbl_clave.Text
        salidas_camioneta.lbl_chofer.Text = lbl_chofer.Text
        salidas_camioneta.ShowDialog()

        salidas_camioneta.Continuar.Visible = False
        salidas_camioneta.guardar.Enabled = True
sal:

    End Sub

    Private Sub opcion_Camioneta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_buscar.Click
        Dim conexion_local As New base_local
        'conexion_local.llena_tabla(dg_ultimas_salidas, "select idx,fecha,sale,regresa,estado from salidas_camionetas order by fecha desc")
        lbl_chofer.Text = cmb_camioneta.Text
        lbl_clave.Text = cmb_camioneta.SelectedValue
        conexion_local.llena_tabla(dg_ultimas_salidas, "select idx,fecha,sale,regresa,(select count(salida) from salidas_camionetas_d where estado='PENDIENTE' and salidas_camionetas_d.salida=salidas_camionetas.idx) as Pendientes from salidas_camionetas where camioneta=" + lbl_clave.Text + " group by idx order by fecha desc")
        conexion_local.dispose()
        If dg_ultimas_salidas.RowCount > 0 Then
            lbl_ultima_salida.Text = dg_ultimas_salidas.Item("idx", 0).Value
            If dg_ultimas_salidas.Item("regresa", 0).Value = -1 Then
                bt_salidas.Visible = False
                dg_ultimas_salidas.Rows(0).DefaultCellStyle.BackColor = Color.Red
            Else
                bt_salidas.Enabled = True
                bt_entradas.Enabled = False
            End If
        Else

            bt_salidas.Enabled = True
            bt_entradas.Enabled = False
        End If

    End Sub

    Private Sub dg_ultimas_salidas_DoubleClick(sender As Object, e As EventArgs) Handles dg_ultimas_salidas.DoubleClick
        If dg_ultimas_salidas.Item("regresa", dg_ultimas_salidas.CurrentRow.Index).Value = -1 Then

            If MsgBox("Ya existe una salida pendite selecciona una opcion" & vbCrLf & "Si para continuar" & vbCrLf & "No para cerrar", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                salidas_camioneta.Continuar.Visible = True
                salidas_camioneta.guardar.Enabled = False
            ElseIf MsgBoxResult.No Then
                detalle_carga.validar.Enabled = True

                'carga detalle
                lbl_ultima_salida.Text = dg_ultimas_salidas.Item("idx", dg_ultimas_salidas.CurrentRow.Index).Value

                llena_detalle()
                GoTo sal2
            End If
        Else
            detalle_carga.validar.Enabled = False
            ' detalle_carga.GroupBox1.Visible = False
            'carga detalle
            lbl_ultima_salida.Text = dg_ultimas_salidas.Item("idx", dg_ultimas_salidas.CurrentRow.Index).Value

            llena_detalle()
            GoTo sal2
        End If
        salidas_camioneta.lbl_clave_camioneta.Text = lbl_clave.Text
        salidas_camioneta.lbl_chofer.Text = lbl_chofer.Text
        salidas_camioneta.ShowDialog()
sal2:

    End Sub
    Private Sub llena_detalle()
        detalle_carga.lbl_salida.Text = lbl_ultima_salida.Text

        Dim conexion_detalle As New base_local
        conexion_detalle.llena_tabla(detalle_carga.detalle, "select idx,clave, articulos.articulo,estado from salidas_camionetas_d,articulos where clave=salidas_camionetas_d.articulo and salida=" & lbl_ultima_salida.Text)
        conexion_detalle.dispose()
        detalle_carga.ShowDialog()
    End Sub

    Private Sub opcion_Camioneta_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        Dim conexion_local As New base_local
        'conexion_local.llena_combo(cmb_camioneta, "select id,nombre from unidades_camionetas,personal where chofer=clave and mid(unidades_camionetas.bodega,1,3)='" & Mid(muebleria_ciudad, 1, 3) & "' order by nombre")
        conexion_local.llena_combo(cmb_camioneta, "select id,nombre from vista_camionetas where mid(bodega,1,3)='" & Mid(muebleria_ciudad, 1, 3) & "' order by nombre")
        cmb_camioneta.ValueMember = "id"
        cmb_camioneta.DisplayMember = "nombre"
        conexion_local.dispose()
    End Sub
End Class