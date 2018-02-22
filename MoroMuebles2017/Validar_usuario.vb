Public Class Validar_usuario

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        'cadenapaconectarlocal = "DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=" + txt_servidor.Text + ";DATABASE=jaime;UID=tony;PWD=xxxx;OPTIONS=&1+2+8+32+2048+16384" '“Server=LocalHost;” & “DataBase=principal;UID=root;PWD=1234;Port=3306”
        Dim Dts As New base_local
        If Dts.ValidaUsuario(TextBox1.Text, TextBox2.Text) = True Then
            Principal.Show()
            Dts.cargar_datos()
            Me.Close()
        Else
            MsgBox("Error en los datos")
        End If
        Dts.dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            TextBox2.Focus()
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Button1.Focus()
        End If
    End Sub

    Private Sub Validar_usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cadenapaconectarlocal = "DRIVER={MySQL ODBC 5.3 Unicode Driver};SERVER=" + txt_servidor.Text + ";DATABASE=" + txt_base.Text + ";UID=tony;PWD=xxxx;OPTIONS=&1+2+8+32+2048+16384" '“Server=LocalHost;” & “DataBase=principal;UID=root;PWD=1234;Port=3306”
        img_logo.ImageLocation = "c:\fotos\logo.jpg"

        Me.BackgroundImage = Captura.My.Resources.Fondo4
        'lbl_muebleria.Text = muebleria_nombre
        Dim fila_bodega As DataRow

        Dim carga_logo As New base_local

        fila_bodega = carga_logo.repetido("select nombre, encargado,concat(calle,' ',colonia) as direccion, ciudad, telefono,actualizacion from bodega", "bodega")

        muebleria_nombre = fila_bodega.Item("nombre")
        muebleria_encargado = fila_bodega.Item("encargado")
        muebleria_direccion = fila_bodega.Item("direccion")
        muebleria_ciudad = fila_bodega.Item("ciudad")
        muebleria_tel = fila_bodega.Item("telefono")
        ultima_actualizacion = fila_bodega.Item("actualizacion")
        carga_logo.dispose()
        lbl_muebleria.Text = muebleria_nombre
    End Sub
End Class