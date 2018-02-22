Public Class modificar_enganche
    Dim diferencia As Integer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If MsgBox("Se cambiara el enganche de la venta " + lbl_venta.Text + " de " + lbl_enganche.Text + " a " + txt_enganche.Text + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
            Dim conexion As New base_local
            conexion.InsertarSQL("call bonificar_venta(" & lbl_venta.Text & "," & lbl_enganche.Text & "," & txt_enganche.Text & "," & txt_motivo.Text & ",'" & usuario & "','" & My.Computer.Name & "')")
            conexion.dispose()
            'conexion = New Odbc.OdbcConnection
            'conexion.ConnectionString = cad_con
            'conexion.Open()

            'If Val(MaskedTextBox1.Text) > Val(Label6.Text) Then
            '    diferencia = Val(MaskedTextBox1.Text) - Val(Label6.Text)
            '    comando = New Odbc.OdbcCommand("update credito set enganche=" + MaskedTextBox1.Text + " , saldo=saldo-" + diferencia.ToString + " where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            '    comando.ExecuteNonQuery()
            '    comando = New Odbc.OdbcCommand("update clientes set saldo=saldo-" + diferencia.ToString + " where cli_clave=" + Label13.Text, conexion)
            '    comando.ExecuteNonQuery()
            'Else
            '    diferencia = Val(Label6.Text) - Val(MaskedTextBox1.Text)
            '    comando = New Odbc.OdbcCommand("update credito set enganche=" + MaskedTextBox1.Text + " , saldo=saldo+" + diferencia.ToString + " where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
            '    comando.ExecuteNonQuery()
            '    comando = New Odbc.OdbcCommand("update clientes set saldo=saldo+" + diferencia.ToString + " where cli_clave=" + Label13.Text, conexion)
            '    comando.ExecuteNonQuery()
            'End If




            'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE ENGANCHE DE " + Label6.Text + " A " + MaskedTextBox1.Text + " " + UCase(TextBox1.Text) + " CUENTA" + Label2.Text + "'," + Label11.Text + ")", conexion)
            'comando.ExecuteNonQuery()
            'conexion.Close()

            MsgBox("Cambio de engache correcto")


            Me.Close()

        End If

    End Sub
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Ruta, Nombre, credito.saldo,cliente,enganche from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        Label6.Text = lector.Item("enganche")
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Button1.Enabled = True
        Button1.Focus()
    End Sub

    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_enganche.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txt_enganche.Text = "" Then
                MsgBox("Llenar nuevo enganche")
                txt_enganche.Focus()
            Else
                If Val(txt_enganche.Text) > Val(lbl_enganche.Text) Then
                    diferencia = Val(txt_enganche.Text) - Val(lbl_enganche.Text)
                    Label11.Text = Val(lbl_saldo.Text) - diferencia
                    If Val(txt_enganche.Text) > Val(lbl_saldo.Text) Then
                        MsgBox("El enganche no puede ser mayor al saldo restante")
                        txt_enganche.Focus()
                        Button1.Enabled = False
                    Else
                        txt_motivo.Focus()
                        Button1.Enabled = True
                    End If
                Else
                    diferencia = Val(lbl_enganche.Text) - Val(txt_enganche.Text)
                    Label11.Text = Val(lbl_saldo.Text) + diferencia
                    Button1.Enabled = True
                End If



            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_motivo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button3.Focus()
        End If
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_motivo.TextChanged
        Button1.Enabled = False
    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub
End Class