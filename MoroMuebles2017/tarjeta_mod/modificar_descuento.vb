Public Class modificar_descuento
    Dim diferencia As Integer
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Nombre, credito.saldo, cliente, descuento,tipo_desc from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        l_descuento.Text = lector.Item("descuento")
    '        Select Case lector.Item("tipo_desc")
    '            Case "0"
    '                l_t_descuento.Text = "SIN DESCUENTO"
    '                l_descuento.Text = "0"
    '            Case "1"
    '                l_t_descuento.Text = "MAYO"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "2"
    '                l_t_descuento.Text = "DICIEMBRE"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "3"
    '                l_t_descuento.Text = "BUEN FIN"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "4"
    '                l_t_descuento.Text = "REMATE 1"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "5"
    '                l_t_descuento.Text = "REMATE 2"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "6"
    '                l_t_descuento.Text = "EXPO"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "7"
    '                l_t_descuento.Text = "PAQUETE"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "8"
    '                l_t_descuento.Text = "OFERTA"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '            Case "9"
    '                l_t_descuento.Text = "OTRO"
    '                l_descuento.Text = lector.Item("DESCUENTO")

    '        End Select

    '        Label13.Text = lector.Item("cliente")

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

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MaskedTextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If MaskedTextBox1.Text = "" Then
                MsgBox("Llenar nuevo enganche")
                MaskedTextBox1.Focus()
            Else
                If Val(MaskedTextBox1.Text) > Val(l_descuento.Text) Then
                    diferencia = Val(MaskedTextBox1.Text) - Val(l_descuento.Text)
                    Label14.Text = Val(Label9.Text) - diferencia
                    If Val(MaskedTextBox1.Text) > Val(Label9.Text) Then
                        MsgBox("El enganche no puede ser mayor al saldo restante")
                        MaskedTextBox1.Focus()
                        Button1.Enabled = False
                    Else
                        TextBox1.Focus()
                        Button1.Enabled = True
                    End If
                Else
                    diferencia = Val(l_descuento.Text) - Val(MaskedTextBox1.Text)
                    Label14.Text = Val(Label9.Text) + diferencia
                    Button1.Enabled = True
                End If
            End If
        End If
    End Sub



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Se cambiara el descuento de la venta " + Label2.Text + " de " + l_descuento.Text + " a " + MaskedTextBox1.Text + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then

            'conexion = New Odbc.OdbcConnection
            'conexion.ConnectionString = cad_con
            'conexion.Open()

            'If Val(MaskedTextBox1.Text) > Val(l_descuento.Text) Then
            '    diferencia = Val(MaskedTextBox1.Text) - Val(l_descuento.Text)
            '    comando = New Odbc.OdbcCommand("update credito set descuento=" + MaskedTextBox1.Text + " ,tipo_desc='" + ComboBox1.SelectedIndex.ToString + "'  , saldo=saldo-" + diferencia.ToString + " where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            '    comando.ExecuteNonQuery()
            '    comando = New Odbc.OdbcCommand("update clientes set saldo=saldo-" + diferencia.ToString + " where cli_clave=" + Label13.Text, conexion)
            '    comando.ExecuteNonQuery()
            'Else
            '    diferencia = Val(l_descuento.Text) - Val(MaskedTextBox1.Text)
            '    comando = New Odbc.OdbcCommand("update credito set descuento=" + MaskedTextBox1.Text + " ,tipo_desc='" + ComboBox1.SelectedIndex.ToString + "' , saldo=saldo+" + diferencia.ToString + " where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            '    comando.ExecuteNonQuery()
            '    comando = New Odbc.OdbcCommand("update clientes set saldo=saldo+" + diferencia.ToString + " where cli_clave=" + Label13.Text, conexion)
            '    comando.ExecuteNonQuery()
            'End If




            'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE DESCUENTO DE " + l_descuento.Text + " A " + MaskedTextBox1.Text + " " + UCase(TextBox1.Text) + " CUENTA" + Label2.Text + "'," + Label14.Text + ")", conexion)
            'comando.ExecuteNonQuery()
            'conexion.Close()

            MsgBox("Cambio de descuento correcto")


            Me.Close()

        End If
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class