Public Class modifica_forma
    Private Sub btn_salir_Click(sender As Object, e As EventArgs) Handles btn_salir.Click
        Me.Dispose()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If cmb_forma.Text <> lbl_forma.Text Then
            If MsgBox("Se cambiara la venta " + lbl_venta.Text + " de forma " + lbl_forma.Text + " a forma " + cmb_forma.Text + vbCrLf + "Datos correctos?", MsgBoxStyle.YesNo, "Verificar datos") = MsgBoxResult.Yes Then
                Dim conexion As New base_local
                conexion.InsertarSQL("call venta_cambia_ruta(" & lbl_venta.Text & "," & lbl_forma.Text & "," & cmb_forma.Text & "," & txt_motivo.Text & ",'" & usuario & "','" & My.Computer.Name & "')")
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
            cmb_forma.Focus()
        End If
    End Sub
End Class