Public Class detalle_carga
    Private Sub cambiarboton_Click(sender As Object, e As EventArgs) Handles cambiarboton.Click
        Dim id_salida As DataRow
        If txtfolio.Text <> "" Then
            txtfolio.Text = UCase(txtfolio.Text)
            'BUSCAR FOLIO
            'guardar

            Dim conexion As New base_local


            If txtfolio.Text = "REGRESO" Then
                detalle.Item("estado", detalle.CurrentRow.Index).Value = "REGRESO"
                conexion.InsertarSQL("call entrada_camionetas(" + lblmovimiento.Text + ", '" + txtfolio.Text + "', '" + lbl_salida.Text + "', '" + usuario + "', '" + My.Computer.Name + "')")
                cambiarboton.Enabled = False
                'comando = New Odbc.OdbcCommand("call entrada_camionetas(" + lblmovimiento.Text + ", '" + txtfolio.Text + "', '" + lblclave.Text + "', '" + usuario + "', '" + My.Computer.Name + "')", conexion)
                'comando.ExecuteNonQuery()
            Else

                id_salida = conexion.repetido("select salida from salidas_camionetas_d where estado='" + txtfolio.Text + "' and salida<>" + lbl_salida.Text, "salidas_camionetas")

                'comando = New Odbc.OdbcCommand("select salida from salidas_camionetas_d where estado='" + txtfolio.Text + "' and salida<>" + salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString, conexion)
                'lector = comando.ExecuteReader
                If id_salida.IsNull("salida") = False Then
                    MsgBox("Ya se encuentra el folio registrado en la salida de camioneta " + id_salida.Item("salida").ToString)

                Else
                    conexion.InsertarSQL("update salidas_camionetas_d set estado='" + txtfolio.Text + "' where idx=" + lblmovimiento.Text)
                    'comando = New Odbc.OdbcCommand("update salidas_camionetas_d set estado='" + txtfolio.Text + "' where idx=" + lblmovimiento.Text, conexion)
                    'comando.ExecuteNonQuery()
                    detalle.Item("estado", detalle.CurrentRow.Index).Value = txtfolio.Text
                    cambiarboton.Enabled = False
                End If
            End If
            conexion.dispose()

        Else
            MsgBox("Llenar campo folio")
            txtfolio.Focus()
        End If
    End Sub

    Private Sub validar_Click(sender As Object, e As EventArgs) Handles validar.Click
        Dim conexion As New base_local

        For i As Int16 = 0 To detalle.RowCount - 1
            If detalle.Item("estado", i).Value = "CARGADO" Then

                If MsgBox("tiene articulos marcados como Cargado cambiar a regreso", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    conexion.InsertarSQL("call entrada_camionetas(" + detalle.Item("idx", i).Value.ToString + ", 'REGRESO', '" + detalle.Item("clave", i).Value.ToString + "', '" + usuario + "', '" + My.Computer.Name + "')")
                    detalle.Item("estado", i).Value = "REGRESO"
                Else
                    guardarboton.Enabled = False
                    GoTo sal
                End If
            End If
            'comando = New Odbc.OdbcCommand("select idx,articulos.articulo as Articulo,Estado from salidas_camionetas_d, articulos where clave=salidas_camionetas_d.articulo and salida=" + salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString, conexion)
            'comando.ExecuteNonQuery()
        Next
        guardarboton.Enabled = True
sal:
        conexion.dispose()
    End Sub

    Private Sub guardarboton_Click(sender As Object, e As EventArgs) Handles guardarboton.Click
        Dim cregreso As Int16
        Dim conexion As New base_local
        cregreso = 0
        For i As Int16 = 0 To detalle.RowCount - 1
            If detalle.Item("estado", i).Value = "REGRESO" Then cregreso = cregreso + 1
            If detalle.Item("estado", i).Value = "CARGADO" Then
                conexion.InsertarSQL("call entrada_camionetas(" + detalle.Item("idx", i).Value.ToString + ", '" + detalle.Item("estado", i).Value + "', '" + detalle.Item("clave", i).Value.ToString + "', '" + usuario + "', '" + My.Computer.Name + "')")
                ' comando = New Odbc.OdbcCommand("call entrada_camionetas(" + detalle.Item("idx", i).Value.ToString + ", '" + detalle.Item("estado", i).Value + "', '" + detalle.Item("clave", i).Value.ToString + "', '" + usuario + "', '" + My.Computer.Name + "')", conexion)
                'comando.ExecuteNonQuery()
                cregreso = cregreso + 1
            End If
        Next
        conexion.InsertarSQL("call entrada_camionetas_c(" + lbl_salida.Text + ", " + cregreso.ToString + ", '" + usuario + "', '" + My.Computer.Name + "')")
        'comando = New Odbc.OdbcCommand("call entrada_camionetas_c(" + lblsailda.Text + ", " + cregreso.ToString + ", '" + usuario + "', '" + My.Computer.Name + "')", conexion)
        'comando.ExecuteNonQuery()
        conexion.dispose()
    End Sub

    Private Sub detalle_DoubleClick(sender As Object, e As EventArgs) Handles detalle.DoubleClick
        If validar.Enabled = False And detalle.Item("Estado", detalle.CurrentRow.Index).Value <> "PENDIENTE" Then
            MsgBox("No se puede modificar si ya se cerro")
            cambiarboton.Enabled = False
        Else
            lblarticulo.Text = detalle.Item("articulo", detalle.CurrentRow.Index).Value
            'lblclave.Text = detalle.Item("clave", detalle.CurrentRow.Index).Value
            lblmovimiento.Text = detalle.Item("idx", detalle.CurrentRow.Index).Value
            If detalle.Item("estado", detalle.CurrentRow.Index).Value = "REGRESO" Then
                MsgBox("Ya se marco como regreado seleccionar otro")
                cambiarboton.Enabled = False
            Else
                txtfolio.Text = "REGRESO"
                txtfolio.SelectAll()
                cambiarboton.Enabled = True
            End If
        End If
    End Sub
    Private Sub detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles detalle.CellContentClick
        cambiarboton.Enabled = False
        guardarboton.Enabled = False
    End Sub

End Class