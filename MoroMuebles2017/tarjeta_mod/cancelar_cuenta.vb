Public Class cancelar_cuenta

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Se cancelara la venta " + lbl_venta.Text + vbCrLf + "Se incrementara la mercancia en el inventario y se dejara el saldo en 0" + vbCrLf + " Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
            Dim conexion As New base_local
            conexion.InsertarSQL("call cancelar_venta('" & lbl_venta.Text & "','" & txt_motivo.Text & "','" & usuario & "','" & My.Computer.Name & "')")
            conexion.dispose()

            'conexion = New Odbc.OdbcConnection
            'conexion.ConnectionString = cad_con
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("update credito set saldo=0 where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            'comando.ExecuteNonQuery()
            'comando = New Odbc.OdbcCommand("update CLIENTES set saldo=saldo-" + Label9.Text + " where cli_clave=" + Label5.Text, conexion)
            'comando.ExecuteNonQuery()
            'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CANCELAR " + UCase(TextBox1.Text) + " CUENTA" + Label2.Text + "'," + Label9.Text + ")", conexion)
            'comando.ExecuteNonQuery()
            'conexion.Close()
            MsgBox("SE CANCELO LA VENTA")
            Me.Close()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Dispose()
    End Sub
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Ruta, Nombre, credito.saldo,folio,cliente from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        Label5.Text = lector.Item("cliente")
    '    Else
    '        MsgBox("No se encuentra la venta o ya no tiene saldo")
    '        '     llena(InputBox("Numero de venta a modificar"))
    '        ' Else
    '        Me.Close()

    '    End If
    '    conexion.Close()
    'End Sub

End Class