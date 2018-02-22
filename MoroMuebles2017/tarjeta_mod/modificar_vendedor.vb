Public Class modificar_vendedor
    'Public Sub llena(venta As String)
    '    conexion = New Odbc.OdbcConnection
    '    conexion.ConnectionString = cad_con
    '    conexion.Open()


    '    comando = New Odbc.OdbcCommand("SELECT ven_clave,nombre from vendedores where bodega='" + bodega1 + "' order by nombre", conexion)
    '    da1 = New Odbc.OdbcDataAdapter(comando)
    '    ds = New DataSet
    '    da1.Fill(ds)
    '    ComboBox1.DataSource = ds.Tables(0).DefaultView
    '    ComboBox1.DisplayMember = "Nombre"
    '    ComboBox1.ValueMember = "ven_clave"

    '    comando = New Odbc.OdbcCommand("select clientes.Nombre as nombre, credito.saldo, vendedores.nombre as vendedor from clientes, credito, vendedores where vendedor=ven_clave and credito.saldo>0 and cli_clave=cliente and credito.bodega='" + bodega + "' and numero_venta=" + venta, conexion)
    '    lector = comando.ExecuteReader()



    '    If lector.Read Then
    '        Label2.Text = venta

    '        Label4.Text = lector.Item("nombre")
    '        Label9.Text = lector.Item("saldo")
    '        Label6.Text = lector.Item("vendedor")


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

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'conexion = New Odbc.OdbcConnection
        'conexion.ConnectionString = cad_con
        'conexion.Open()

        'comando = New Odbc.OdbcCommand("update credito set vendedor='" + ComboBox1.SelectedValue.ToString + "' where credito.bodega='" + bodega + "' and numero_venta=" + Label2.Text, conexion)
        'comando.ExecuteNonQuery()
        'comando = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','CAMBIO DE VENDEDOR DE " + Label6.Text + " A " + ComboBox1.Text + " " + UCase(TextBox1.Text) + " CUENTA" + Label2.Text + "',0)", conexion)
        'comando.ExecuteNonQuery()
        'conexion.Close()
        MsgBox("Cambio de vendedor realizado")
        Me.Close()
    End Sub
End Class