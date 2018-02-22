Public Class clientes_alta

    Private Sub INE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles INE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'Dim conexion = New base_local ' Odbc.OdbcConnection(cad_con)
            'conexion.llena_tabla(dt_clientes_encontrados, "select Clave_i, Clave, Nombre, Conyuge, Calle, Colonia, Ciudad, Calificacion from clientes where ine='" + Me.INE.Text + "'")
            ''conexion.Open()
            ''comando = New Odbc.OdbcCommand("select Clave_i, Clave, Nombre, Conyuge, Calle, Colonia, Ciudad, Saldo, Calificacion from clientes where ine='" + Me.INE.Text + "'", conexion)
            ''da = New Odbc.OdbcDataAdapter(comando)
            ''ds = New DataSet
            ''da.Fill(ds)
            ''Me.DataGridView1.DataSource = Nothing
            ''Me.DataGridView1.DataSource = ds.Tables(0).DefaultView
            'If Me.dt_clientes_encontrados.Rows.Count > 0 Then
            '    Me.GroupBox9.Visible = True
            '    For i As Int16 = 0 To Me.dt_clientes_encontrados.Rows.Count - 1
            '        If Me.dt_clientes_encontrados.Item("calificacion", i).Value = "MALO" Then Me.dt_clientes_encontrados.Rows(i).DefaultCellStyle.BackColor = Color.Red
            '    Next

            '    'QUIEN = "N"
            '    Button3.Enabled = False
            '    'Me.Button3.Focus()
            'Else
            '    Me.GroupBox9.Visible = False
            '    Me.NOMBRE.Focus()
            'End If
            'conexion.dispose()

            Me.NOMBRE.Focus()
        End If
    End Sub

    Private Sub NOMBRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles NOMBRE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.NOMBRE.Text = UCase(Me.NOMBRE.Text)
            Me.CONYUGE.Focus()
        End If
    End Sub

    Private Sub CONYUGE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CONYUGE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.CONYUGE.Text = UCase(Me.CONYUGE.Text)
            Me.CALLE.Focus()
        End If
    End Sub

    Private Sub CALLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CALLE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.CALLE.Text = UCase(Me.CALLE.Text)
            Me.COLONIA.Focus()
        End If
    End Sub

    Private Sub COLONIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles COLONIA.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.COLONIA.Text = UCase(Me.COLONIA.Text)
            Me.POBLACION.Focus()
        End If
    End Sub

    Private Sub POBLACION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles POBLACION.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.POBLACION.Text = UCase(Me.POBLACION.Text)
            Me.CIUDAD.Focus()
        End If
    End Sub

    Private Sub CIUDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CIUDAD.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.CIUDAD.Text = UCase(Me.CIUDAD.Text)
            Me.ENTRE1.Focus()
            'Dim conexion = New base_local 'Odbc.OdbcConnection(cad_con)
            'conexion.llena_tabla(dt_clientes_encontrados, "select Clave_i, Clave, Nombre, Conyuge, Calle, Colonia, Ciudad, Saldo, Calificacion from clientes where calle='" + Me.CALLE.Text + "' and colonia='" + Me.COLONIA.Text + "' and poblacion='" + Me.POBLACION.Text + "' and ciudad='" + Me.CIUDAD.Text + "'")
            ''conexion.Open()
            ''comando = New Odbc.OdbcCommand("select Clave_i, Clave, Nombre, Conyuge, Calle, Colonia, Ciudad, Saldo, Calificacion from clientes where calle='" + Me.CALLE.Text + "' and colonia='" + Me.COLONIA.Text + "' and poblacion='" + Me.POBLACION.Text + "' and ciudad='" + Me.CIUDAD.Text + "'", conexion)
            ''da = New Odbc.OdbcDataAdapter(comando)
            ''ds = New DataSet
            ''da.Fill(ds)
            ''Me.dt_clientes_encontrados.DataSource = Nothing
            ''Me.dt_clientes_encontrados.DataSource = ds.Tables(0).DefaultView
            'If Me.dt_clientes_encontrados.Rows.Count > 0 Then
            '    Me.GroupBox9.Visible = True
            '    For i As Int16 = 0 To Me.dt_clientes_encontrados.Rows.Count - 1
            '        If Me.dt_clientes_encontrados.Item("calificacion", i).Value = "MALO" Then Me.dt_clientes_encontrados.Rows(i).DefaultCellStyle.BackColor = Color.Red
            '    Next

            '    'QUIEN = "N"
            '    'Me.Button3.Focus()
            '    Button3.Enabled = False
            'Else
            '    Me.ENTRE1.Focus()
            'End If
            'conexion.dispose()

        End If
    End Sub

    Private Sub ENTRE1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ENTRE1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.ENTRE1.Text = UCase(Me.ENTRE1.Text)
            Me.ENTRE2.Focus()
        End If
    End Sub

    Private Sub ENTRE2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ENTRE2.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.ENTRE2.Text = UCase(Me.ENTRE2.Text)
            Me.CASA.Focus()
        End If
    End Sub

    Private Sub CASA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles CASA.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.QUIEN.Focus()
        End If
    End Sub

    Private Sub QUIEN_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles QUIEN.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.QUIEN.Text = UCase(Me.QUIEN.Text)
            Me.ANOS.Focus()
        End If
    End Sub

    Private Sub ANOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ANOS.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.LOCALIZA.Focus()
        End If
    End Sub

    Private Sub LOCALIZA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles LOCALIZA.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.LOCALIZA.Text = UCase(Me.LOCALIZA.Text)
            Me.TELEFONO.Focus()
        End If
    End Sub

    Private Sub TELEFONO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TELEFONO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TELEFONO.Text = UCase(Me.TELEFONO.Text)
            Me.DOCUMENTO.Focus()
        End If
    End Sub

    Private Sub DOCUMENTO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DOCUMENTO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.DETALLE.Focus()
        End If
    End Sub

    Private Sub DETALLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles DETALLE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.DETALLE.Text = UCase(Me.DETALLE.Text)
            Me.TRABAJO.Focus()
        End If
    End Sub

    Private Sub TRABAJO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TRABAJO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TRABAJO.Text = UCase(Me.TRABAJO.Text)
            Me.TANOS.Focus()
        End If
    End Sub

    Private Sub TANOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TANOS.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TCALLE.Focus()
        End If
    End Sub

    Private Sub TCALLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCALLE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TCALLE.Text = UCase(Me.TCALLE.Text)
            Me.TCOLONIA.Focus()
        End If
    End Sub

    Private Sub TCOLONIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCOLONIA.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TCOLONIA.Text = UCase(Me.TCOLONIA.Text)
            Me.TCIUDAD.Focus()
        End If
    End Sub

    Private Sub TCIUDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TCIUDAD.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TCIUDAD.Text = UCase(Me.TCIUDAD.Text)
            Me.RNOMBRE.Focus()
        End If
    End Sub

    Private Sub RNOMBRE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RNOMBRE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.RNOMBRE.Text = UCase(Me.RNOMBRE.Text)
            Me.RCALLE.Focus()
        End If
    End Sub

    Private Sub RCALLE_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RCALLE.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.RCALLE.Text = UCase(Me.RCALLE.Text)
            Me.RCOLONIA.Focus()
        End If
    End Sub

    Private Sub RCOLONIA_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RCOLONIA.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.RCOLONIA.Text = UCase(Me.RCOLONIA.Text)
            Me.RCIUDAD.Focus()
        End If
    End Sub

    Private Sub ROCUPACION_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles ROCUPACION.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.ROCUPACION.Text = UCase(Me.ROCUPACION.Text)
            Me.RANOS.Focus()
        End If
    End Sub

    Private Sub RANOS_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RANOS.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then

            Me.PARENTESCO.Focus()
        End If
    End Sub

    Private Sub PARENTESCO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles PARENTESCO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.PARENTESCO.Text = UCase(Me.PARENTESCO.Text)
            Me.RTELEFONO.Focus()
        End If
    End Sub

    Private Sub RTELEFONO_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RTELEFONO.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.RTELEFONO.Text = UCase(Me.RTELEFONO.Text)
            Me.Button1.Focus()
        End If
    End Sub

    Private Sub clientes_alta_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = Captura.My.Resources.Fondo4
        Me.INE.Focus()
    End Sub

    Private Sub RCIUDAD_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles RCIUDAD.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.RCIUDAD.Text = UCase(Me.RCIUDAD.Text)
            Me.ROCUPACION.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Me.NOMBRE.Text = "" Then
            MsgBox("Falta llenar campo")
            Me.NOMBRE.Focus()
            GoTo no
        End If
        If Me.CALLE.Text = "" Then
            MsgBox("Falta llenar campo")
            Me.CALLE.Focus()
            GoTo no
        End If
        If Me.COLONIA.Text = "" Then
            MsgBox("Falta llenar campo")
            Me.COLONIA.Focus()
            GoTo no
        End If
        Dim conexion = New base_local 'Odbc.OdbcConnection(cad_con)
        'conexion.Open()
        Dim insertar As String
        Dim id As String

        insertar = "('" + Me.INE.Text + "','" + Me.NOMBRE.Text + "', '" + Me.CONYUGE.Text + "', '" + CALLE.Text + "', '" + COLONIA.Text + "', '" + POBLACION.Text + "', '" + CIUDAD.Text + "', '" + Me.ENTRE1.Text & " Y " & Me.ENTRE2.Text + "', '" + CASA.Text + "', '" + QUIEN.Text + "', '" + ANOS.Text + "', '" + LOCALIZA.Text + "', '" + TELEFONO.Text + "', '" + Me.DOCUMENTO.Text + " ', '" + DETALLE.Text + "', '" + TRABAJO.Text + "', '" + TANOS.Text + "', '" + TCALLE.Text + "', '" + TCOLONIA.Text + "', '" + TCIUDAD.Text + "', '" + RNOMBRE.Text + "', '" + RCALLE.Text + "', '" + RCOLONIA.Text + "', '" + RCIUDAD.Text + "', '" + Me.ROCUPACION.Text + "', '" + RANOS.Text + "', '" + PARENTESCO.Text + "', '" + RTELEFONO.Text + "', '" + TextBox1.Text + "','" + usuario + "','" + My.Computer.Name + "')"
        'comando = New Odbc.OdbcCommand("call insertar_cliente_local" + insertar, conexion)
        'comando.CommandType = CommandType.StoredProcedure
        'id = comando.ExecuteScalar

        id = conexion.InsertaEscalar("call insertar_cliente_local" + insertar)
        'If lector.Read() Then id = lector.Item(0).ToString
        'comando = New Odbc.OdbcCommand("insert into movimientos values('" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + usuario + "','Alta de cliente')", conexion)
        'comando.ExecuteNonQuery()

        'comando = New Odbc.OdbcCommand("insert into clientes_folio values()", conexion)
        'comando.ExecuteNonQuery()

        conexion.dispose()

        If MsgBox("Registro Guardado con clave interna " + id.ToString + vbCrLf + "Registrar otro", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            limpiar()
        Else
            Me.Close()
        End If
no:
    End Sub
    Private Sub limpiar()
        TextBox1.Text = ""
        Me.INE.Text = ""
        Me.NOMBRE.Text = ""
        Me.CONYUGE.Text = ""
        Me.CALLE.Text = ""
        Me.COLONIA.Text = ""
        Me.POBLACION.Text = ""
        Me.CIUDAD.Text = ""
        Me.ENTRE1.Text = ""
        Me.ENTRE2.Text = ""
        Me.CASA.Text = ""
        Me.QUIEN.Text = ""
        Me.ANOS.Text = ""
        Me.LOCALIZA.Text = ""
        Me.TELEFONO.Text = ""
        Me.DOCUMENTO.Text = ""
        Me.DETALLE.Text = ""
        Me.TRABAJO.Text = ""
        Me.TANOS.Text = ""
        Me.TCALLE.Text = ""
        Me.TCOLONIA.Text = ""
        Me.TCIUDAD.Text = ""
        Me.RNOMBRE.Text = ""
        Me.RCALLE.Text = ""
        Me.RCOLONIA.Text = ""
        Me.ROCUPACION.Text = ""
        Me.RANOS.Text = ""
        Me.PARENTESCO.Text = ""
        Me.RTELEFONO.Text = ""
        Me.RCIUDAD.Text = ""
        TextBox1.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.GroupBox9.Visible = False
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If MsgBox("Se guardara el folio con el cliente no " + lblclienteex.Text, MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim conexion = New base_local 'Odbc.OdbcConnection(cad_con)
            conexion.InsertarSQL("call insertar_cliente_existente(" + lblclienteex.Text + ",'" + TextBox1.Text + "','" + usuario + "','" + My.Computer.Name + "')")
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("call insertar_cliente_existente(" + lblclienteex.Text + ",'" + TextBox1.Text + "','" + usuario + "','" + My.Computer.Name + "')", conexion)
            'comando.ExecuteNonQuery()
            Me.GroupBox9.Visible = False
            conexion.dispose()

            If MsgBox("Folio registra" + vbCrLf + "Registrar otro", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                limpiar()
            Else
                Me.Close()
            End If
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        limpiar()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim conexion As New base_local
            Dim encontrado As DataRow
            encontrado = conexion.repetido("select * from clientes_folio where folio ='" + Me.TextBox1.Text + "'", "clientes_folio")
            'conexion.Close()
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("select * from clientes_folio where folio ='" + Me.TextBox1.Text + "'", conexion)
            'lector = comando.ExecuteReader
            If IsDBNull(encontrado.Item(0)) = False Then
                'f = le.Item("fecha")

                MsgBox("Ya existe un folio registrado con el cliente " + encontrado.Item("cliente").ToString + " ")
                'conexion.Close()
                TextBox1.Focus()
            Else
                'TabControl1.Enabled = True
                INE.Focus()

            End If
            conexion.dispose()
        End If
    End Sub


    Private Sub DataGridView1_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dt_clientes_encontrados.CellContentDoubleClick
        lblclienteex.Text = dt_clientes_encontrados.Item("clave_i", dt_clientes_encontrados.CurrentRow.Index).Value
        Button3.Enabled = True
    End Sub


End Class