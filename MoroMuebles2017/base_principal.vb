Public Class base_principal
    Private comando As New Odbc.OdbcCommand
    Private conexion As New Odbc.OdbcConnection
    Private adaptador As New Odbc.OdbcDataAdapter
    Private tabla As DataTable
    Public Sub New()
        Try
            conexion.ConnectionString = "DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=127.0.0.1;DATABASE=principal;UID=tony;PWD=xxxx;OPTIONS=&1+2+8+32+2048+16384" '“Server=LocalHost;” & “DataBase=principal;UID=root;PWD=1234;Port=3306”
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
    Public Sub llena_tabla(ByVal grilla As DataGridView, ByVal consulta As String)
        comando.CommandText = consulta '"select * from provedores order by nombre"
        adaptador = New Odbc.OdbcDataAdapter
        adaptador.SelectCommand = comando
        tabla = New DataTable
        adaptador.Fill(tabla)
        grilla.DataSource = tabla
    End Sub
End Class
