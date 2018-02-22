Public Class agregar_indicacion
    Dim actualizar As String
    Public Sub llena(venta As String, nombre As String, estado As String, fecha As Date)

        

        Me.l_venta.Text = venta
        'Me.l_cli_clave.Text = em("cliente")
        Me.l_nombre.Text = nombre
        Me.Label7.Text = "DESDE " + Format(fecha, "dd-MM-yyyy")
        Me.l_estado.Text = estado

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim conexion As New base_local
        conexion.InsertarSQL("call agrega_indicacion_comp")
        conexion.dispose()
        MsgBox("Se Agrego nueva indicacion")
        Me.Close()
        'conexion = New Odbc.OdbcConnection
        'conexion.ConnectionString = cad_con
        'conexion.Open()

        'comando = New Odbc.OdbcCommand("update indicaciones set captura='" + Format(Now, "yyyy-MM-dd") + "' where bodega='" + bodega + "' and venta='" + l_venta.Text + "' and captura='1900-01-01'", conexion)
        'comando.ExecuteNonQuery()

        'comando = New Odbc.OdbcCommand("select max(mid(clave_ind,2,2)) from indicaciones  where bodega='" + bodega + "' and venta='" + l_venta.Text + "' and mid(clave_ind,1,1)='C'", conexion)
        'lector = comando.ExecuteReader
        'lector.Read()
        'If Not IsDBNull(lector.Item(0)) Then
        '    actualizar = lector.Item(0) + 1
        'Else
        '    actualizar = 1
        'End If
        'comando = New Odbc.OdbcCommand("insert into indicaciones values('" + l_venta.Text + "','" + bodega + "','" + usuario + "','1900-01-01','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + Me.ComboBox1.Text + "','" + Me.ComboBox2.Text + "','" + Me.TextBox2.Text + "','" + Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") + "','C" + actualizar.ToString + "')", conexion)
        'comando.ExecuteNonQuery()
        'MsgBox("Se Agrego nueva indicacion")
        'conexion.Close()
        'Me.Close()
    End Sub
End Class