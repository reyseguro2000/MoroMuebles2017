Public Class base_local
    Private lector As Odbc.OdbcDataReader
    Private comando As New Odbc.OdbcCommand
    Private conexion As New Odbc.OdbcConnection
    Private ds As DataSet
    Private adaptador As New Odbc.OdbcDataAdapter
    Private tabla As DataTable

    Public Sub New()
        Try
            'conexion.ConnectionString = cadenapaconectarlocal '"DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=127.0.0.1;DATABASE=moromuebles;UID=tony;PWD=xxxx;OPTIONS=&1+2+8+32+2048+16384" '“Server=LocalHost;” & “DataBase=principal;UID=root;PWD=1234;Port=3306”
            conexion.ConnectionString = cadenapaconectarlocal '"DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=;DATABASE=moromuebles;UID=tony;PWD=xxxx;OPTIONS=&1+2+8+32+2048+16384" '“Server=LocalHost;” & “DataBase=principal;UID=root;PWD=1234;Port=3306”
            conexion.Open()
            comando.Connection = conexion
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, “Error”)
        End Try
    End Sub

    Public Sub dispose()
        conexion.Close()
        conexion.Dispose()
        comando.Dispose()
    End Sub

    Public Sub InsertarSQL(ByVal SentenciaSQL As String)

        comando.CommandText = SentenciaSQL

        comando.ExecuteNonQuery()

    End Sub
    Function InsertaEscalar(ByVal cadena As String) As VariantType
        Try
            'Dim provedor As Int32
            comando.CommandText = cadena '"call insertar_provedor" + valores
            comando.CommandType = CommandType.StoredProcedure
            'comando.ExecuteNonQuery()
            'provedor = Convert.ToInt32(comando.ExecuteScalar())
            'Return provedor
            Return comando.ExecuteScalar()
        Catch ex As Exception
            MsgBox("Error en: " + ex.ToString)
            Return 0
        End Try

    End Function
    Function nuevo_provedor(ByVal valores As String) As Int32
        Try
            Dim provedor As Int32
            comando.CommandText = "call insertar_provedor" + valores
            comando.CommandType = CommandType.StoredProcedure
            'comando.ExecuteNonQuery()
            provedor = Convert.ToInt32(comando.ExecuteScalar())
            Return provedor
        Catch ex As Exception
            MsgBox("Error en: " + ex.ToString)
            Return 0
        End Try

    End Function

    Public Sub modificar_proverdor(ByVal valores As String)
        Try
            comando.CommandText = "call modificar_provedor" + valores
            comando.CommandType = CommandType.StoredProcedure
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error en: " + ex.ToString)
        End Try
    End Sub


    Function nuevo_articulo(ByVal valores As String) As String
        Try
            comando.CommandText = "call insertar_articulos" + valores
            comando.CommandType = CommandType.StoredProcedure
            Return comando.ExecuteScalar
        Catch ex As Exception
            MsgBox("Error en: " + ex.ToString)
            Return 0
        End Try

    End Function

    Public Sub modificar_articulo(ByVal valores As String)
        Try
            comando.CommandText = "call modificar_articulos" + valores
            comando.CommandType = CommandType.StoredProcedure
            comando.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("Error en: " + ex.ToString)
        End Try
    End Sub


    Public Sub llena_tabla(ByVal grilla As DataGridView, ByVal consulta As String)
        comando.CommandText = consulta '"select * from provedores order by nombre"
        adaptador = New Odbc.OdbcDataAdapter
        adaptador.SelectCommand = comando
        tabla = New DataTable
        adaptador.Fill(tabla)
        grilla.DataSource = tabla
    End Sub

    Public Sub llena_combo(ByVal combo As ComboBox, ByVal consulta As String)
        comando.CommandText = consulta '"select * from provedores order by nombre"
        adaptador = New Odbc.OdbcDataAdapter
        adaptador.SelectCommand = comando
        tabla = New DataTable
        adaptador.Fill(tabla)
        combo.DataSource = tabla
    End Sub
    Public Sub llena_lista(ByVal lista As ListBox, ByVal consulta As String)
        comando.CommandText = consulta '"select * from provedores order by nombre"
        adaptador = New Odbc.OdbcDataAdapter
        adaptador.SelectCommand = comando
        tabla = New DataTable
        adaptador.Fill(tabla)
        lista.DataSource = tabla
    End Sub
    Function buscar_articulo(ByVal consulta As String) As Int32
        Dim articulo As Int32
        Try
            comando.CommandText = consulta
            lector = comando.ExecuteReader
            lector.Read()
            articulo = lector.Item(0)
            lector.Close()
            Return articulo + 1
        Catch ex As Exception
            lector.Close()
            Return 1
        End Try

    End Function
    Function ValidaUsuario(ByVal usuario As String, ByVal pass As String) As Boolean
        Try
            adaptador = New Odbc.OdbcDataAdapter("select * from usuarios where usuario='" & usuario & "' and password=MD5('" & pass & "')", conexion)
            ds = New DataSet
            adaptador.Fill(ds, "usuarios")
            If ds.Tables("usuarios").Rows.Count > 0 Then
                bodega = ds.Tables("usuarios").Rows(0).Item("bodega")
                tipo = ds.Tables("usuarios").Rows(0).Item("tipo")

                usuario_fondo = ds.Tables("usuarios").Rows(0).Item("fondo")
                usuario_texto = ds.Tables("usuarios").Rows(0).Item("texto")
                usuario_l1 = ds.Tables("usuarios").Rows(0).Item("l1")
                usuario_l2 = ds.Tables("usuarios").Rows(0).Item("l2")
                usuario_l3 = ds.Tables("usuarios").Rows(0).Item("l3")


                Module1.usuario = usuario
                valido = True
            Else
                valido = False
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return valido
    End Function

    Function repetido(ByVal consulta As String, ByVal busca_tabla As String) As DataRow
        Dim existe As DataRow = Nothing

        Try
            adaptador = New Odbc.OdbcDataAdapter(consulta, conexion)
            ds = New DataSet
            adaptador.Fill(ds, busca_tabla)
            '.Rows(0)
            If ds.Tables(busca_tabla).Rows.Count > 0 Then
                existe = ds.Tables(busca_tabla).Rows(0)
            Else
                existe = ds.Tables(busca_tabla).NewRow
                'existe = existe = ds.Tables(busca_tabla).
            End If
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Return existe
    End Function

    Public Sub cargar_datos()
        adaptador = New Odbc.OdbcDataAdapter("select * from lista order by fecha desc", conexion)
        ds = New DataSet
        adaptador.Fill(ds, "lista")


        lista1(0) = ds.Tables("lista").Rows(0).Item("l1_c")
        lista1(1) = ds.Tables("lista").Rows(0).Item("l1_1")
        lista1(2) = ds.Tables("lista").Rows(0).Item("l1_2")
        lista1(3) = ds.Tables("lista").Rows(0).Item("l1_3")
        lista1(4) = ds.Tables("lista").Rows(0).Item("l1_4")
        lista1(5) = ds.Tables("lista").Rows(0).Item("l1_5")
        lista1(6) = ds.Tables("lista").Rows(0).Item("l1_6")
        lista1(7) = ds.Tables("lista").Rows(0).Item("l1_7")
        lista1(8) = ds.Tables("lista").Rows(0).Item("l1_8")
        lista1(9) = ds.Tables("lista").Rows(0).Item("l1_9")
        lista1(10) = ds.Tables("lista").Rows(0).Item("l1_10")
        lista1(11) = ds.Tables("lista").Rows(0).Item("l1_11")
        lista1(12) = ds.Tables("lista").Rows(0).Item("l1_12")
        lista1(13) = ds.Tables("lista").Rows(0).Item("l1_com")
        lista1(14) = ds.Tables("lista").Rows(0).Item("l1_may")
        'lista2
        lista2(0) = ds.Tables("lista").Rows(0).Item("l2_c")
        lista2(1) = ds.Tables("lista").Rows(0).Item("l2_1")
        lista2(2) = ds.Tables("lista").Rows(0).Item("l2_2")
        lista2(3) = ds.Tables("lista").Rows(0).Item("l2_3")
        lista2(4) = ds.Tables("lista").Rows(0).Item("l2_4")
        lista2(5) = ds.Tables("lista").Rows(0).Item("l2_5")
        lista2(6) = ds.Tables("lista").Rows(0).Item("l2_6")
        lista2(7) = ds.Tables("lista").Rows(0).Item("l2_7")
        lista2(8) = ds.Tables("lista").Rows(0).Item("l2_8")
        lista2(9) = ds.Tables("lista").Rows(0).Item("l2_9")
        lista2(10) = ds.Tables("lista").Rows(0).Item("l2_10")
        lista2(11) = ds.Tables("lista").Rows(0).Item("l2_11")
        lista2(12) = ds.Tables("lista").Rows(0).Item("l2_12")
        lista2(13) = ds.Tables("lista").Rows(0).Item("l2_com")
        lista2(14) = ds.Tables("lista").Rows(0).Item("l2_may")
        'lista3
        lista3(0) = ds.Tables("lista").Rows(0).Item("l3_c")
        lista3(1) = ds.Tables("lista").Rows(0).Item("l3_1")
        lista3(2) = ds.Tables("lista").Rows(0).Item("l3_2")
        lista3(3) = ds.Tables("lista").Rows(0).Item("l3_3")
        lista3(4) = ds.Tables("lista").Rows(0).Item("l3_4")
        lista3(5) = ds.Tables("lista").Rows(0).Item("l3_5")
        lista3(6) = ds.Tables("lista").Rows(0).Item("l3_6")
        lista3(7) = ds.Tables("lista").Rows(0).Item("l3_7")
        lista3(8) = ds.Tables("lista").Rows(0).Item("l3_8")
        lista3(9) = ds.Tables("lista").Rows(0).Item("l3_9")
        lista3(11) = ds.Tables("lista").Rows(0).Item("l3_11")
        lista3(12) = ds.Tables("lista").Rows(0).Item("l3_12")
        lista3(13) = ds.Tables("lista").Rows(0).Item("l3_com")
        lista3(14) = ds.Tables("lista").Rows(0).Item("l3_may")
    End Sub
End Class
