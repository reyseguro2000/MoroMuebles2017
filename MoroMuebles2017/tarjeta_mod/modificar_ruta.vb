﻿Public Class modificar_ruta

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_ruta.Text <> "" Then
            If MsgBox("Se cambiara la venta " + lbl_venta.Text + " de ruta " + lbl_ruta.Text + " a ruta " + txt_ruta.Text + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
                Dim conexion As New base_local
                conexion.InsertarSQL("call venta_cambia_ruta(" & lbl_venta.Text & "," & lbl_ruta.Text & "," & txt_ruta.Text & "," & txt_motivo.Text & ",'" & usuario & "','" & My.Computer.Name & "')")
                conexion.dispose()
                'conexion = New Odbc.OdbcConnection
                'conexion.ConnectionString = cad_con
                'conexion.Open()
                'comando = New Odbc.OdbcCommand("update credito set ruta=" + MaskedTextBox1.Text + " where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
                'comando.ExecuteNonQuery()
                'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE RUTA DE " + Label6.Text + " A " + MaskedTextBox1.Text + " " + TextBox1.Text + " CUENTA" + Label2.Text + "',0)", conexion)
                'comando.ExecuteNonQuery()
                'conexion.Close()

                'If MsgBox("Cambio de ruta correcto" + vbCrLf + "Cambiar otra venta", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                '    ' llena(InputBox("Numero de venta a modificar"))
                'Else
                Me.Close()
                'End If
            End If
        Else
            MsgBox("Llenar Ruta nueva")
            txt_ruta.Focus()
        End If
    End Sub
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()
    '    comando = New Odbc.OdbcCommand("select Ruta, Nombre, credito.saldo from clientes, credito where credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()
    '    If lector.Read Then
    '        Label2.Text = venta
    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        Label6.Text = lector.Item("ruta")
    '    Else
    '        If MsgBox("No se encuentra la venta o ya no tiene saldo" + vbCrLf + "Intentar otro numero de venta?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    '            llena(InputBox("Numero de venta a modificar"))
    '        Else
    '            Me.Close()
    '        End If
    '    End If
    '    conexion.Close()
    'End Sub
    Private Sub MaskedTextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ruta.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txt_ruta.Text = "" Then
                MsgBox("Llenar Ruta nueva")
                txt_ruta.Focus()
            Else
                txt_motivo.Focus()
            End If
        End If
    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_motivo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub
End Class