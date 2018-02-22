Public Class modificar_plazo
    Dim fecha, fecha_n As Date
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Nombre, credito.saldo, credito.fecha,plazo from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        Label6.Text = lector.Item("plazo")
    '        Label11.Text = lector.Item("fecha")
    '        fecha = lector.Item("fecha")



    '        ' Label13.Text = lector.Item("cliente")
    '    Else
    '        If MsgBox("No se encuentra la venta o ya no tiene saldo" + vbCrLf + "Intentar otro numero de venta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            llena(InputBox("Numero de venta a modificar"))
    '        Else
    '            Me.Close()
    '        End If
    '    End If
    '    conexion.Close()
    '    Button1.Enabled = False
    'End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_plazo.SelectedIndexChanged

        fecha_n = DateAdd(DateInterval.Month, Val(cmb_plazo.Text), fecha)
        Label13.Text = Format(fecha_n, "dd-MM-yyyy")
        If fecha_n > Now Then
            btn_modificar.Enabled = True
        Else
            btn_modificar.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If MsgBox("Se cambiara el plazo de la venta " + lbl_venta.Text + " de " + lbl_plazo.Text + " a " + cmb_plazo.Text + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
            Dim conexion As New base_local
            conexion.InsertarSQL("call venta_cambia_plazo(" & lbl_venta.Text & "," & lbl_plazo.Text & "," & cmb_plazo.Text & "," & txt_motivo.Text & ",'" & usuario & "','" & My.Computer.Name & "')")
            conexion.dispose()
            'conexion = New Odbc.OdbcConnection
            'conexion.ConnectionString = cad_con
            'conexion.Open()



            'comando = New Odbc.OdbcCommand("update credito set plazo=" + ComboBox1.Text + " , fecha_ven='" + Format(fecha_n, "yyyy-MM-dd") + "' where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            '    comando.ExecuteNonQuery()

            'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE PLAZO DE " + Label6.Text + " A " + ComboBox1.Text + " " + UCase(TextBox1.Text) + " CUENTA" + Label2.Text + "'," + Label9.Text + ")", conexion)
            'comando.ExecuteNonQuery()
            'conexion.Close()

            MsgBox("Cambio de plazo correcto")


            Me.Close()

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Dispose()
    End Sub
End Class