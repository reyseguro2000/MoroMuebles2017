Public Class modificar_folio
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Se cambiara el folio a la venta " + Label2.Text + " de " + Label6.Text + " a " + MaskedTextBox1.Text + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
            'conexion = New Odbc.OdbcConnection
            'conexion.ConnectionString = cad_con
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("update credito set folio=" + MaskedTextBox1.Text + " where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            'comando.ExecuteNonQuery()
            'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE FOLIO DE " + Label6.Text + " A " + MaskedTextBox1.Text + " " + UCase(TextBox1.Text) + " CUENTA" + Label2.Text + "',0)", conexion)
            'comando.ExecuteNonQuery()
            'conexion.Close()

            'If MsgBox("Cambio de folio correcto" + vbCrLf + "Cambiar otra venta", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            '    llena(InputBox("Numero de venta a modificar"))
            'Else
            '    Me.Close()
            'End If
        End If

    End Sub
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Ruta, Nombre, credito.saldo,folio from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        Label6.Text = lector.Item("folio")
    '    Else
    '        If MsgBox("No se encuentra la venta o ya no tiene saldo" + vbCrLf + "Intentar otro numero de venta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            llena(InputBox("Numero de venta a modificar"))
    '        Else
    '            Me.Close()
    '        End If
    '    End If
    '    conexion.Close()
    'End Sub

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If MaskedTextBox1.Text = "" Then
                MsgBox("Llenar folio")
                MaskedTextBox1.Focus()
            Else
                TextBox1.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class