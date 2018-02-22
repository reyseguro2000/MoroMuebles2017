Public Class salidas_camioneta
    Dim no As Boolean
    Dim id_salida As Integer
    Dim dta As DataTable
    Dim dr As DataRow
    Private Sub cargar()

        ' Dim conexion As New base_local
        'conexion.llena_combo(txtchofer, "select unidades_camionetas.id as clave, nombre from unidades_camionetas, personal where personal.clave=chofer and unidades_camionetas.estado='activa' and mid(unidades_camionetas.bodega,1,3)='" + bodega + "' order by nombre")
        'conexion.Open()

        'comando = New Odbc.OdbcCommand("select camionetas.clave as clave, nombre from camionetas, personal where personal.clave=chofer and activa='Si' and camionetas.bodega='" + bodega1 + "' order by nombre", conexion)
        'da = New Odbc.OdbcDataAdapter
        'da.SelectCommand = comando
        'dt = New DataTable
        'da.Fill(dt)
        'Me.txtchofer.DataSource = dt
        ' Me.txtchofer.DisplayMember = "nombre"
        '  Me.txtchofer.ValueMember = "clave"
        ' txtchofer.Enabled = True
        cargar_articulos()
        'conexion.llena_combo(txtarticulo, "Select Clave, articulo, maquina FROM articulos WHERE activo='A' order by articulo")
        ''comando = New Odbc.OdbcCommand("select Clave, Articulo, maquina FROM articulos WHERE activo='A' order by articulo", conexion)
        ''da = New Odbc.OdbcDataAdapter
        ''da.SelectCommand = comando
        'dta = New DataTable
        ''da.Fill(dt)
        'dta = txtarticulo.DataSource
        'Dim key(0) As DataColumn
        'Dim col As DataColumn
        'col = New DataColumn
        'col = dta.Columns(0)
        'key(0) = col
        'dta.PrimaryKey = key

        ''Me.txtarticulo.DataSource = dt
        'Me.txtarticulo.DisplayMember = "articulo"
        'Me.txtarticulo.ValueMember = "clave"
        'txtchofer.Enabled = True
        'conexion.dispose()



    End Sub
    Private Sub cargar_articulos()

        Dim conexion As New base_local
        conexion.llena_combo(txtarticulo, "Select Clave, articulo, maquina FROM articulos WHERE activo='A' order by articulo")
        dta = New DataTable
        dta = txtarticulo.DataSource
        Dim key(0) As DataColumn
        Dim col As DataColumn
        col = New DataColumn
        col = dta.Columns(0)
        key(0) = col
        dta.PrimaryKey = key
        Me.txtarticulo.DisplayMember = "articulo"
        Me.txtarticulo.ValueMember = "clave"
        'txtchofer.Enabled = True

        'conexion.Open()
        'comando = New Odbc.OdbcCommand("select clave, articulo, maquina from articulos where activo='A' order by articulo", conexion)
        'da = New Odbc.OdbcDataAdapter
        'da.SelectCommand = comando
        'dt = New DataTable
        'da.Fill(dt)
        'Dim key(0) As DataColumn
        'Dim col As DataColumn
        'col = New DataColumn
        'col = dt.Columns(0)
        'key(0) = col
        'dt.PrimaryKey = key

        'Me.txtarticulo.DataSource = dt
        'Me.txtarticulo.DisplayMember = "articulo"
        'Me.txtarticulo.ValueMember = "clave"
        'txtchofer.Enabled = True


        conexion.dispose()
    End Sub
    Private Sub salidas_camioneta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        cargar()
    End Sub

    Private Sub txtarticulo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtarticulo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dr = dta.NewRow
            dr = dta.Rows.Find(Me.txtarticulo.SelectedValue)
            'revisar existencia
            Me.lblcantidad.Text = dr("maquina")
            'If Val(Me.txtcantidad.Text) > Val(Me.lblcantidad.Text) Then
            '    MsgBox("La cantidad es mayor a la existente en el inventario maquina" + vbCrLf + "Opciones" + vbCrLf + "1 Cerrar venta y revisar entradas" + vbCrLf + "2 Pedir codigo para desbloquear")
            'Else

            '    Me.agregar.Focus()
            'End If


        End If
    End Sub


    Private Sub txtcantidad_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcantidad.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If Val(txtcantidad.Text) > 0 Then

                txtarticulo.Focus()
                no = True

            End If
        End If
    End Sub

    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click

        If txtarticulo.SelectedIndex <> -1 Then
            dr = dta.NewRow
            dr = dta.Rows.Find(Me.txtarticulo.SelectedValue)
            'revisar existencia
            Me.lblcantidad.Text = dr("maquina")
            'If Val(Me.txtcantidad.Text) > Val(Me.lblcantidad.Text) Then
            '    MsgBox("La cantidad es mayor a la existente en el inventario virtual" + vbCrLf + "Opciones" + vbCrLf + "1 Cerrar venta y revisar entradas" + vbCrLf + "2 Pedir codigo para desbloquear")
            'Else
            For i As Int16 = 1 To txtcantidad.Text
                    articulosdg.Rows.Add()
                    ' articulosdg.Item("cantidad", articulosdg.RowCount - 1).Value = txtcantidad.Text
                    articulosdg.Item("clave", articulosdg.RowCount - 1).Value = txtarticulo.SelectedValue
                    articulosdg.Item("articulo", articulosdg.RowCount - 1).Value = txtarticulo.Text
                dr = dta.NewRow
                dr = dta.Rows.Find(Me.txtarticulo.SelectedValue)
                dr("maquina") = dr("maquina") - 1
            Next
                txtcantidad.Text = "1"
                txtcantidad.SelectAll()
                txtcantidad.Focus()

            'End If


        End If



    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim articulos As String = ""
        Dim folio As Integer
        Dim conexion As New base_local


        'comando = New Odbc.OdbcCommand("insert into movimientos values('" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + usuario + "','Alta de compra " + provedortxt.SelectedValue.ToString + "-" + foliotxt.Text + "')", conexion)
        'comando.ExecuteNonQuery()
        'comando = New Odbc.OdbcCommand("insert into entradas_fabrica values('" + provedortxt.SelectedValue.ToString + "-" + foliotxt.Text + "','" + Format(Now, "yyyy-MM-dd") + "'," + Me.Label9.Text + ",'" + Me.Label9.Text + "')", conexion)
        'comando.ExecuteNonQuery()


        For i As Integer = 0 To Me.articulosdg.RowCount - 1
            articulos = articulos + Me.articulosdg.Item("clave", i).Value.PadRight(10, " "c)
            'comando = New Odbc.OdbcCommand("insert into entradas_fabrica_d values('" + provedortxt.SelectedValue.ToString + "-" + foliotxt.Text + "'," + Str(Me.DataGridView1.Item("t_cantidad", i).Value) + ",'" + Me.DataGridView1.Item("t_clave", i).Value + "','" + Str(Me.DataGridView1.Item("t_costo", i).Value) + "')", conexion)
            'comando.ExecuteNonQuery()
            'comando = New Odbc.OdbcCommand("insert into entradas values('FABRICA','" + provedortxt.SelectedValue.ToString + "-" + foliotxt.Text + "'," + Str(Me.DataGridView1.Item("t_cantidad", i).Value) + ",'" + Me.DataGridView1.Item("t_clave", i).Value + "','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "')", conexion)
            'comando.ExecuteNonQuery()
            'comando = New Odbc.OdbcCommand("update articulos set virtual= virtual+ " + Str(Me.DataGridView1.Item("t_cantidad", i).Value) + " where clave='" + Me.DataGridView1.Item("t_clave", i).Value + "'", conexion)
            'comando.ExecuteNonQuery()
        Next
        folio = conexion.InsertaEscalar("call salida_camioneta('" + lbl_clave_camioneta.Text + "','" + articulos + "'," + Me.articulosdg.RowCount.ToString + ",'" + My.Computer.Name + "','" + usuario + "')")
        '        comando = New Odbc.OdbcCommand("call salida_camioneta('" + txtchofer.SelectedValue.ToString + "','" + articulos + "'," + Me.articulosdg.RowCount.ToString + ",'" + My.Computer.Name + "','" + usuario + "')", conexion)
        ' folio = comando.ExecuteScalar
        MsgBox("Salida guardada con el folio " + folio.ToString + vbCrLf + "")
        Me.Close()
        'If MsgBox("Salida guardada con el folio " + folio.ToString + vbCrLf + "") = MsgBoxResult.Yes Then
        '    Me.Close()
        '    cargar()
        '    articulosdg.Rows.Clear()
        'Else
        '    Me.Close()
        'End If

        conexion.dispose()
    End Sub



    Private Sub articulosdg_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles articulosdg.UserDeletingRow
        dr = dta.NewRow
        dr = dta.Rows.Find(articulosdg.Item("clave", articulosdg.CurrentRow.Index).Value)
        dr("maquina") = dr("maquina") + 1
    End Sub


    ''Private Sub txtchofer_KeyPress(sender As Object, e As KeyPressEventArgs)
    ''    Dim repetida As DataRow
    ''    If e.KeyChar = Chr(Keys.Enter) Then
    ''        Dim conexion As New base_local
    ''        repetida = conexion.repetido("select * from salidas_camionetas where camioneta=" + txtchofer.SelectedValue.ToString + " order by fecha desc", "salidas_camioneta")
    ''        'comando = New Odbc.OdbcCommand("select * from salidas_camionetas where camioneta=" + txtchofer.SelectedValue.ToString + " order by fecha desc", conexion)

    ''        If repetida.IsNull(0) = False Then
    ''            If repetida.Item("regresa") = -1 Then

    ''                If repetida.Item("fecha") = Now Then
    ''                    MsgBox("misma fecha")

    ''                End If
    ''                If MsgBox("La camioneta tiene una salida pendiente con " + repetida.Item("sale") + " articulos con fecha " + repetida.Item("fecha") + vbCrLf + "continuar con la salida?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    ''                    Continuar.Visible = True
    ''                    guardar.Visible = False
    ''                    'id_salida = repetida.Item("idx")
    ''                    'comando = New Odbc.OdbcCommand("select * from salidas_camionetas where camioneta=" + txtchofer.SelectedValue.ToString + " order by fecha desc", conexion)
    ''                    'lector = comando.ExecuteReader
    ''                    'While lector.Read

    ''                    'End While
    ''                    'dar entrada
    ''                Else
    ''                    Me.Close()
    ''                End If
    ''            End If
    ''            If MsgBox("La ultima salida regreso " + repetida.Item("regresa") + " articulos " + vbCrLf + "Cargar datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    ''                id_salida = repetida.Item("idx")

    ''                'leer
    ''            Else
    ''                txtcantidad.Focus()
    ''            End If
    ''        Else
    ''            Continuar.Visible = False
    ''            guardar.Visible = True
    ''            txtcantidad.Focus()
    ''        End If

    ''    End If
    ''End Sub
    ''Private Sub txtchofer_KeyUp(sender As Object, e As KeyEventArgs)
    ''    'If e.KeyCode = 13 Then
    ''    '    Dim conexion As New base_principal
    ''    '    conexion.Open()
    ''    '    comando = New Odbc.OdbcCommand("select * from salidas_camionetas where camioneta=" + txtchofer.SelectedValue.ToString + " order by fecha desc", conexion)
    ''    '    lector = comando.ExecuteReader
    ''    '    If lector.Read Then
    ''    '        If lector.Item("regresa") = -1 Then

    ''    '            If lector.Item("fecha") = Format(Now, "yyyy-MM-dd") Then
    ''    '                MsgBox("hoy")


    ''    '                If MsgBox("La camioneta tiene una salida pendiente con " + lector.Item("sale").ToString + " articulos de hoy" + vbCrLf + "continuar con la salida?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    ''    '                    'continua
    ''    '                    lblfolio.Text = lector.Item("idx")
    ''    '                    Continuar.Visible = True
    ''    '                    guardar.Visible = False
    ''    '                    txtcantidad.Focus()
    ''    '                Else
    ''    '                    Me.Close()
    ''    '                End If


    ''    '            Else
    ''    '                MsgBox("La venta tiene una salida del " + lector.Item("fecha") + vbCrLf + "cerrar la venta para continuar")
    ''    '                Me.Close()
    ''    '            End If

    ''    '        Else
    ''    '            txtcantidad.Focus()
    ''    '            'If MsgBox("La ultima salida regreso " + lector.Item("regresa") + " articulos " + vbCrLf + "Cargar datos", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
    ''    '            '    'leer
    ''    '            'Else
    ''    '            '    txtcantidad.Focus()
    ''    '            'End If
    ''    '        End If
    ''    '    Else
    ''    '        txtcantidad.Focus()
    ''    '    End If
    ''    '    'txtcantidad.Focus()
    ''    'End If
    ''End Sub

    ''Private Sub txtarticulo_KeyUp(sender As Object, e As KeyEventArgs) Handles txtarticulo.KeyUp
    ''    If no = False Then
    ''        If e.KeyCode = 13 And txtarticulo.SelectedIndex <> -1 Then
    ''            dr = dta.NewRow
    ''            dr = dta.Rows.Find(Me.txtarticulo.SelectedValue)
    ''            'revisar existencia
    ''            Me.lblcantidad.Text = dr("maquina")
    ''            'If Val(Me.txtcantidad.Text) > Val(Me.lblcantidad.Text) Then
    ''            '    MsgBox("La cantidad es mayor a la existente en el inventario virtual" + vbCrLf + "Opciones" + vbCrLf + "1 Cerrar venta y revisar entradas" + vbCrLf + "2 Pedir codigo para desbloquear")
    ''            '    no = True
    ''            '    txtcantidad.Focus()
    ''            'Else

    ''            Me.agregar.Focus()
    ''            'End If

    ''        End If
    ''    Else
    ''        no = False
    ''    End If
    ''End Sub


    Private Sub Continuar_Click(sender As Object, e As EventArgs) Handles Continuar.Click
        Continuar.Visible = False
        guardar.Visible = True
        Dim articulos As String = ""
        Dim folio As Integer
        Dim conexion As New base_local


        For i As Integer = 0 To Me.articulosdg.RowCount - 1
            articulos = articulos + Me.articulosdg.Item("clave", i).Value.PadRight(10, " "c)
        Next
        conexion.InsertarSQL("call salida_camioneta_continua('" + lbl_clave_camioneta.Text + "','" + articulos + "'," + Me.articulosdg.RowCount.ToString + ",'" + My.Computer.Name + "','" + usuario + "'," + lblfolio.Text + ")")
        'comando.ExecuteNonQuery()
        If MsgBox("Salida guardada con el folio " + folio.ToString + vbCrLf + "Guardar otra salida", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            cargar()
            articulosdg.Rows.Clear()
        Else
            Me.Close()
        End If

        conexion.dispose()
    End Sub



    Private Sub articulosdg_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs) Handles articulosdg.RowsAdded
        lblcuantos.Text = articulosdg.RowCount
    End Sub

    Private Sub articulosdg_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles articulosdg.RowsRemoved
        lblcuantos.Text = articulosdg.RowCount
    End Sub
    
End Class