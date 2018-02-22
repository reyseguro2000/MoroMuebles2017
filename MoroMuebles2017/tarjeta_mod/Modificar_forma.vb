Public Class Modificar_forma
    Dim forma As String
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Nombre, credito.saldo, forma from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta

    '        Select Case lector.Item("FORMA")
    '            Case "1"
    '                Label6.Text = "SEMANAL"
    '            Case "2"
    '                Label6.Text = "QUINCENAL"
    '            Case "3"
    '                Label6.Text = "MENSUAL"

    '        End Select
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")



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

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.Text <> Label6.Text Then
            Button1.Enabled = True
        Else
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Se cambiara la forma de pago de la venta " + Label2.Text + " de " + Label6.Text + " a " + ComboBox1.Text + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
            'conexion = New Odbc.OdbcConnection
            'conexion.ConnectionString = cad_con
            'conexion.Open()

            'Select Case ComboBox1.Text
            '    Case "SEMANAL"
            '        forma = "1"
            '    Case "QUINCENAL"
            '        forma = "2"
            '    Case "MENSUAL"
            '        forma = "3"

            'End Select


            'comando = New Odbc.OdbcCommand("update credito set forma=" + forma + " where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            'comando.ExecuteNonQuery()

            'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE FORMA DE PAGO DE " + Label6.Text + " A " + ComboBox1.Text + " " + UCase(TextBox1.Text) + " CUENTA" + Label2.Text + "'," + Label9.Text + ")", conexion)
            'comando.ExecuteNonQuery()
            'conexion.Close()

            'MsgBox("Cambio de plazo correcto")


            Me.Close()

        End If
    End Sub
End Class