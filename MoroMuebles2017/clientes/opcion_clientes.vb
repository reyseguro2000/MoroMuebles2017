Public Class opcion_clientes
    Private Sub opcion_clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Captura.My.Resources.Fondo4
        Dim conexion As New base_local
        conexion.llena_tabla(dt_pendientes, "select Folio, Nombre, Calle, Colonia, Conyuge from clientes, clientes_folio where clave_i=cliente and estado='PENDIENTE'")
        conexion.dispose()
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        clientes_alta.ShowDialog()
    End Sub


    Private Sub txt_clave_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_clave.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim conexion As New base_local
            conexion.llena_tabla(dt_clientes, "select * from vista_clientes where clave_i=" + txt_clave.Text.ToString + " order by nombre")
            conexion.dispose()
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim conexion As New base_local
            conexion.llena_tabla(dt_clientes, "select * from vista_clientes where nombre like '%" + txt_nombre.Text + "%' order by nombre")
            conexion.dispose()
        End If
    End Sub

    Private Sub txt_ine_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ine.KeyPress
        Dim conexion As New base_local
        conexion.llena_tabla(dt_clientes, "select * from vista_clientes where nombre ine '%" + txt_ine.Text + "%' order by nombre")
        conexion.dispose()
    End Sub

    Private Sub txt_direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_direccion.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim conexion As New base_local
            conexion.llena_tabla(dt_clientes, "select * from vista_clientes where calle like '%" + txt_direccion.Text + "%' order by nombre")
            conexion.dispose()
        End If
    End Sub

    Private Sub btn_folio_Click(sender As Object, e As EventArgs) Handles btn_folio.Click
        If MsgBox("Se guardara el folio con el cliente no " + txt_clave.Text, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim conexion = New base_local 'Odbc.OdbcConnection(cad_con)
            conexion.InsertarSQL("call insertar_cliente_existente(" + txt_clave.Text + ",'" + TextBox1.Text + "','" + usuario + "','" + My.Computer.Name + "')")
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("call insertar_cliente_existente(" + lblclienteex.Text + ",'" + TextBox1.Text + "','" + usuario + "','" + My.Computer.Name + "')", conexion)
            'comando.ExecuteNonQuery()
            'Me.GroupBox9.Visible = False
            conexion.dispose()

            If MsgBox("Folio registra" + vbCrLf + "Registrar otro", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                limpiar()
            Else
                Me.Close()
            End If
        End If
    End Sub
    Private Sub limpiar()
        txt_clave.Text = ""
        txt_nombre.Text = ""
        txt_direccion.Text = ""
        txt_ine.Text = ""
        TextBox1.Text = ""
        TextBox1.Visible = False
        btn_folio.Visible = False
    End Sub

    Private Sub dt_clientes_DoubleClick(sender As Object, e As EventArgs) Handles dt_clientes.DoubleClick

        txt_clave.Text = dt_clientes.Item("clave_i", dt_clientes.CurrentRow.Index).Value
        txt_nombre.Text = dt_clientes.Item("nombre", dt_clientes.CurrentRow.Index).Value
        txt_direccion.Text = dt_clientes.Item("calle", dt_clientes.CurrentRow.Index).Value
        txt_ine.Text = dt_clientes.Item("ine", dt_clientes.CurrentRow.Index).Value
        TextBox1.Visible = True
        btn_folio.Visible = True
        btn_ventas.Visible = True
    End Sub

    Private Sub btn_ventas_Click(sender As Object, e As EventArgs) Handles btn_ventas.Click

        clientes_ventas.lbl_clave.Text = txt_clave.Text
        clientes_ventas.lbl_nombre.Text = txt_nombre.Text
        Dim conexion As New base_local
        conexion.llena_tabla(clientes_ventas.dg_ventas, "select * from vista_ventas_camionetas where cliente=" + txt_clave.Text)
        conexion.dispose()
        clientes_ventas.Show()
    End Sub

End Class