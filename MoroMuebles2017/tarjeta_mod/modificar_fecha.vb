Public Class modificar_fecha

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Se cambiara la fecha de la venta " + Label2.Text + " de " + Label6.Text + " a " + Format(DateTimePicker1.Value, "dd-MM-yyyy") + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
            'conexion = New Odbc.OdbcConnection
            'conexion.ConnectionString = cad_con
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("update credito set fecha='" + Format(DateTimePicker1.Value, "yyyy-MM-dd") + "', primer_pago='" + Format(DateAdd(DateInterval.Day, 15, DateTimePicker1.Value), "yyyy-MM-dd") + "', fecha_ven='" + Format(DateAdd(DateInterval.Month, Val(Label11.Text), DateTimePicker1.Value), "yyyy-MM-dd") + "' where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            'comando.ExecuteNonQuery()
            'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE FECHA DE " + Label6.Text + " A " + Format(DateTimePicker1.Value, "dd-MM-yyyy") + " " + TextBox1.Text + " CUENTA" + Label2.Text + "',0)", conexion)
            'comando.ExecuteNonQuery()
            'conexion.Close()

            MsgBox("Cambio de fecha correcto")


            Me.Close()

        End If

    End Sub
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Ruta, Nombre, credito.saldo,folio,credito.fecha,plazo from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        Label6.Text = Format(lector.Item("fecha"), "dd-MM-yyyy")
    '        Label11.Text = lector.Item("plazo")
    '        DateTimePicker1.Value = Label6.Text

    '        Label13.Text = Format(DateAdd(DateInterval.Month, Val(Label11.Text), DateTimePicker1.Value), "dd-MM-yyyy")

    '    Else
    '        If MsgBox("No se encuentra la venta o ya no tiene saldo" + vbCrLf + "Intentar otro numero de venta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            llena(InputBox("Numero de venta a modificar"))
    '        Else
    '            Me.Close()
    '        End If
    '    End If
    '    conexion.Close()
    'End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Label13.Text = Format(DateAdd(DateInterval.Month, Val(Label11.Text), DateTimePicker1.Value), "dd-MM-yyyy")
        Button1.Enabled = True
        TextBox1.Focus()
    End Sub
    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles Label12.Click

    End Sub
End Class