Public Class entradas_camioneta
    Dim PRIMERA As Boolean

    Private Sub entradas_camioneta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PRIMERA = True

        Dim conexion As New base_local
        conexion.llena_lista(chofer, "select unidades_camionetas.id as clave, nombre from unidades_camionetas, personal where personal.clave=chofer and unidades_camionetas.estado='activa' and mid(unidades_camionetas.bodega,1,3)='" + bodega + "' order by nombre")

        '        comando = New Odbc.OdbcCommand("select camionetas.clave as clave, nombre from camionetas, personal where personal.clave=chofer and activa='Si' and camionetas.bodega='" + bodega1 + "' order by nombre", conexion)
        '       da = New Odbc.OdbcDataAdapter
        '      da.SelectCommand = comando
        '     dt = New DataTable
        '    da.Fill(dt)
        '   Me.chofer.DataSource = dt
        Me.chofer.DisplayMember = "nombre"
        Me.chofer.ValueMember = "clave"
        chofer.Enabled = True
        conexion.dispose()
        PRIMERA = False
    End Sub

    Private Sub chofer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chofer.SelectedIndexChanged
       
        If PRIMERA = False Then
            Dim conexion As New base_local
            conexion.llena_tabla(salidas, "select idx,fecha,sale,regresa,(select count(salida) from salidas_camionetas_d where estado='PENDIENTE' and salidas_camionetas_d.salida=salidas_camionetas.idx) as Pendientes from salidas_camionetas where camioneta=" + chofer.SelectedValue.ToString + " group by idx order by fecha desc")
            '            comando = New Odbc.OdbcCommand("select idx,fecha,sale,regresa,(select count(salida) from salidas_camionetas_d where estado='PENDIENTE' and salidas_camionetas_d.salida=salidas_camionetas.idx) as Pendientes from salidas_camionetas where camioneta=" + chofer.SelectedValue.ToString + " group by idx order by fecha desc", conexion)
            '           da = New Odbc.OdbcDataAdapter
            '          da.SelectCommand = comando
            '         dt = New DataTable
            '        da.Fill(dt)
            '       Me.salidas.DataSource = dt
            conexion.dispose()
            detalle.DataSource = Nothing
            validar.Enabled = False
        End If
        

    End Sub

    Private Sub salidas_DoubleClick(sender As Object, e As EventArgs) Handles salidas.DoubleClick
        Dim conexion As New base_local
        conexion.llena_tabla(detalle, "select idx,articulos.articulo as Articulo,Estado, clave from salidas_camionetas_d, articulos where clave=salidas_camionetas_d.articulo and salida=" + salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString)

        '       comando = New Odbc.OdbcCommand("select idx,articulos.articulo as Articulo,Estado, clave from salidas_camionetas_d, articulos where clave=salidas_camionetas_d.articulo and salida=" + salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString, conexion)
        '      da = New Odbc.OdbcDataAdapter
        '     da.SelectCommand = comando
        '    dt = New DataTable
        '   da.Fill(dt)
        'Me.detalle.DataSource = dt
        conexion.dispose()
        lblsailda.Text = salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString
        cambiarboton.Enabled = False
        If salidas.Item("regresa", salidas.CurrentRow.Index).Value = -1 Then
            validar.Enabled = True
        Else
            validar.Enabled = False
        End If

    End Sub



    Private Sub detalle_DoubleClick(sender As Object, e As EventArgs) Handles detalle.DoubleClick
        If validar.Enabled = False And detalle.Item("Estado", detalle.CurrentRow.Index).Value <> "PENDIENTE" Then
            MsgBox("No se puede modificar si ya se cerro")
            cambiarboton.Enabled = False
        Else
            lblarticulo.Text = detalle.Item("articulo", detalle.CurrentRow.Index).Value
            lblclave.Text = detalle.Item("clave", detalle.CurrentRow.Index).Value
            lblmovimiento.Text = detalle.Item("idx", detalle.CurrentRow.Index).Value
            If detalle.Item("estado", detalle.CurrentRow.Index).Value = "REGRESO" Then
                MsgBox("Ya se marco como regreado seleccionar otro")
                cambiarboton.Enabled = False
            Else
                txtfolio.Text = "REGRESO"
                txtfolio.SelectAll()
                cambiarboton.Enabled = True
            End If
        End If

    End Sub


    Private Sub cambiarboton_Click(sender As Object, e As EventArgs) Handles cambiarboton.Click
        Dim id_salida As DataRow
        If txtfolio.Text <> "" Then
            txtfolio.Text = UCase(txtfolio.Text)
            'BUSCAR FOLIO
            'guardar

            Dim conexion As New base_local


            If txtfolio.Text = "REGRESO" Then
                detalle.Item("estado", detalle.CurrentRow.Index).Value = "REGRESO"
                conexion.InsertarSQL("call entrada_camionetas(" + lblmovimiento.Text + ", '" + txtfolio.Text + "', '" + lblclave.Text + "', '" + usuario + "', '" + My.Computer.Name + "')")
                cambiarboton.Enabled = False
                'comando = New Odbc.OdbcCommand("call entrada_camionetas(" + lblmovimiento.Text + ", '" + txtfolio.Text + "', '" + lblclave.Text + "', '" + usuario + "', '" + My.Computer.Name + "')", conexion)
                'comando.ExecuteNonQuery()
            Else

                id_salida = conexion.repetido("select salida from salidas_camionetas_d where estado='" + txtfolio.Text + "' and salida<>" + salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString, "salidas_camionetas")

                'comando = New Odbc.OdbcCommand("select salida from salidas_camionetas_d where estado='" + txtfolio.Text + "' and salida<>" + salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString, conexion)
                'lector = comando.ExecuteReader
                If id_salida.IsNull("salida") = False Then
                    MsgBox("Ya se encuentra el folio registrado en la salida de camioneta " + id_salida.Item("salida").ToString)

                Else
                    conexion.InsertarSQL("update salidas_camionetas_d set estado='" + txtfolio.Text + "' where idx=" + lblmovimiento.Text)
                    'comando = New Odbc.OdbcCommand("update salidas_camionetas_d set estado='" + txtfolio.Text + "' where idx=" + lblmovimiento.Text, conexion)
                    'comando.ExecuteNonQuery()
                    detalle.Item("estado", detalle.CurrentRow.Index).Value = txtfolio.Text
                    cambiarboton.Enabled = False
                End If
            End If
            conexion.dispose()

        Else
            MsgBox("Llenar campo folio")
            txtfolio.Focus()
        End If

    End Sub


    Private Sub guardarboton_Click(sender As Object, e As EventArgs) Handles guardarboton.Click
        Dim cregreso As Int16
        Dim conexion As New base_local
        cregreso = 0
        For i As Int16 = 0 To detalle.RowCount - 1
            If detalle.Item("estado", i).Value = "REGRESO" Then cregreso = cregreso + 1
            If detalle.Item("estado", i).Value = "CARGADO" Then
                conexion.InsertarSQL("call entrada_camionetas(" + detalle.Item("idx", i).Value.ToString + ", '" + detalle.Item("estado", i).Value + "', '" + detalle.Item("clave", i).Value.ToString + "', '" + usuario + "', '" + My.Computer.Name + "')")
                ' comando = New Odbc.OdbcCommand("call entrada_camionetas(" + detalle.Item("idx", i).Value.ToString + ", '" + detalle.Item("estado", i).Value + "', '" + detalle.Item("clave", i).Value.ToString + "', '" + usuario + "', '" + My.Computer.Name + "')", conexion)
                'comando.ExecuteNonQuery()
                cregreso = cregreso + 1
            End If
        Next
        conexion.InsertarSQL("call entrada_camionetas_c(" + lblsailda.Text + ", " + cregreso.ToString + ", '" + usuario + "', '" + My.Computer.Name + "')")
        'comando = New Odbc.OdbcCommand("call entrada_camionetas_c(" + lblsailda.Text + ", " + cregreso.ToString + ", '" + usuario + "', '" + My.Computer.Name + "')", conexion)
        'comando.ExecuteNonQuery()
        conexion.dispose()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles validar.Click
        Dim conexion As New base_local

        For i As Int16 = 0 To detalle.RowCount - 1
            If detalle.Item("estado", i).Value = "CARGADO" Then

                If MsgBox("tiene articulos marcados como Cargado cambiar a regreso", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                    conexion.InsertarSQL("call entrada_camionetas(" + detalle.Item("idx", i).Value.ToString + ", 'REGRESO', '" + detalle.Item("clave", i).Value.ToString + "', '" + usuario + "', '" + My.Computer.Name + "')")
                    detalle.Item("estado", i).Value = "REGRESO"
                Else
                    guardarboton.Enabled = False
                    GoTo sal
                End If
            End If
            'comando = New Odbc.OdbcCommand("select idx,articulos.articulo as Articulo,Estado from salidas_camionetas_d, articulos where clave=salidas_camionetas_d.articulo and salida=" + salidas.Item("idx", salidas.CurrentRow.Index).Value.ToString, conexion)
            'comando.ExecuteNonQuery()
        Next
        guardarboton.Enabled = True
sal:
        conexion.dispose()
    End Sub

    Private Sub detalle_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles detalle.CellContentClick
        cambiarboton.Enabled = False
        guardarboton.Enabled = False
    End Sub

End Class