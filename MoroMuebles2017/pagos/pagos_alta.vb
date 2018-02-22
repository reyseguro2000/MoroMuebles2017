Public Class pagos_alta
    Dim rp As Int16
    'Public lector As Odbc.OdbcDataReader
    'Public nuevo As Odbc.OdbcCommand
    'Public comando3 As Odbc.OdbcConnection
    Public cliente, bodega1 As String
    'Public cad_con As String = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=msm;DATABASE=msm;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"
    Private Sub Form31_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        rp = opcion_Pagos.lbl_ruta.Text 'InputBox("Ruta")
        If bodega = "ACA" Then bodega1 = "ACAMBARO"
        If bodega = "ACT" Then bodega1 = "ACTOPAN"
        If bodega = "MAR" Then bodega1 = "MARAVATIO"
        If bodega = "MOR" Then bodega1 = "MOROLEON"
        If bodega = "VAL" Then bodega1 = "VALLE"
        If bodega = "IRA" Then bodega1 = "IRAPUATO"
        If bodega = "SAN" Then bodega1 = "SAN JUAN"
        If bodega = "TEC" Then bodega1 = "TECOZAUTLA"

        Me.Text = "Alta de pago ruta " + Str(rp) + " Bodega " + bodega
        Me.Label9.Text = bodega
        Me.Label11.Text = Trim(Str(rp))
        Me.Label13.Text = 0
        Me.Label15.Text = 0
        If bodega = "MOR" Then Me.TextBox4.Text = "MOR" + Trim(Str(rp)) + "-"
        Me.DateTimePicker1.Focus()
        'If bodega = "IRA" Then Me.TextBox4.Text = "IRA" + Trim(Str(rp)) + "-"
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        Dim CANTIDAD As Int32
        If e.KeyChar = Chr(Keys.Enter) Then
            If Me.TextBox1.Text = "c" Or Me.TextBox1.Text = "C" Then
                Me.DataGridView1.Rows.Add()
                Me.DataGridView1.Item("r_venta", Me.DataGridView1.Rows.Count - 1).Value = "C"
                Me.DataGridView1.Item("r_recibo", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox4.Text + Me.TextBox2.Text
                Me.Label13.Text = Me.DataGridView1.Rows.Count
                Me.Label17.Text = Me.Label17.Text + 1
                LIMPIAR()
            Else
                If Mid(Me.TextBox1.Text, 1, 1) = "f" Or Mid(Me.TextBox1.Text, 1, 1) = "F" Then
                    If Len(Me.TextBox1.Text) > 1 Then
                        Dim cliente_busca As New base_local
                        Dim encontrado As DataRow
                        encontrado = cliente_busca.repetido("select cliente,saldo,nombre,venta from vista_ventas_camionetas where VENTA='" + bodega + TextBox1.Text + "' and ruta=" + Str(rp), "vista_ventas_camionetas")

                        'comando3 = New Odbc.OdbcConnection
                        'comando3.ConnectionString = cad_con
                        'comando3.Open()
                        'nuevo = New Odbc.OdbcCommand("select cliente,credito.saldo,nombre,numero_venta from credito,clientes where cli_clave=cliente and bodega='" + bodega + "' and ruta=" + Str(rp) + " and folio='" + Mid(Me.TextBox1.Text, 2) + "'", comando3)
                        'lector = nuevo.ExecuteReader()

                        If IsDBNull(encontrado.Item("venta")) = False Then
                            Me.TextBox1.Text = encontrado.Item("venta")
                            Me.Label5.Text = encontrado.Item("nombre")
                            cliente = encontrado.Item("cliente")
                            Me.Label21.Text = cliente
                            Label8.Text = encontrado.Item("saldo")
                            Me.Button1.Enabled = False
                            Me.TextBox4.Focus()
                        Else
                            CANTIDAD = InputBox("Cantidad")
                            Me.DataGridView1.Rows.Add()
                            Me.DataGridView1.Item("r_venta", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox1.Text
                            Me.DataGridView1.Item("r_recibo", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox4.Text + Me.TextBox2.Text
                            Me.DataGridView1.Item("r_cantidad", Me.DataGridView1.Rows.Count - 1).Value = CANTIDAD
                            Me.DataGridView1.Item("r_fecha", Me.DataGridView1.Rows.Count - 1).Value = Format(Me.DateTimePicker1.Value, "dd-MM-yyyy")
                            Me.Label13.Text = Me.DataGridView1.Rows.Count
                            Me.Label19.Text = Me.Label19.Text + 1
                            Me.Label15.Text = Val(Me.Label15.Text) + CANTIDAD
                            LIMPIAR()
                        End If
                        cliente_busca.dispose()
                    Else
                        CANTIDAD = InputBox("Cantidad")
                        Me.DataGridView1.Rows.Add()
                        Me.DataGridView1.Item("r_venta", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox1.Text
                        Me.DataGridView1.Item("r_recibo", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox4.Text + Me.TextBox2.Text
                        Me.DataGridView1.Item("r_cantidad", Me.DataGridView1.Rows.Count - 1).Value = CANTIDAD
                        Me.DataGridView1.Item("r_fecha", Me.DataGridView1.Rows.Count - 1).Value = Format(Me.DateTimePicker1.Value, "dd-MM-yyyy")
                        Me.Label13.Text = Me.DataGridView1.Rows.Count
                        Me.Label19.Text = Me.Label19.Text + 1
                        Me.Label15.Text = Val(Me.Label15.Text) + CANTIDAD
                        LIMPIAR()
                    End If

                Else
                    Dim cliente_busca As New base_local
                    Dim encontrado As DataRow
                    encontrado = cliente_busca.repetido("select cliente,saldo,nombre,venta from vista_ventas_camionetas where venta='" + bodega + TextBox1.Text + "' and ruta=" + Str(rp), "vista_ventas_camionetas")
                    'comando3 = New Odbc.OdbcConnection
                    'comando3.ConnectionString = cad_con
                    'comando3.Open()
                    'nuevo = New Odbc.OdbcCommand("select cliente,credito.saldo,nombre from credito,clientes where cli_clave=cliente and ruta=" + Str(rp) + " and venta_clave='" + bodega + Me.TextBox1.Text + "'", comando3)
                    'lector = nuevo.ExecuteReader()
                    If IsDBNull(encontrado.Item("venta")) = False Then 'lector.Read Then
                        If encontrado.Item("saldo") > 0 Then
                            Me.Label5.Text = encontrado.Item("nombre")
                            cliente = encontrado.Item("cliente")
                            Me.Label21.Text = cliente
                            Label8.Text = encontrado.Item("saldo")
                            Me.Button1.Enabled = False
                            Me.TextBox4.Focus()
                        Else
                            MsgBox("La venta no tiene saldo")
                        End If
                    Else
                        MsgBox("No se encuentra el numero de venta en la ruta actual")
                    End If
                End If
                End If
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TextBox3.Focus()
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If IsNumeric(Me.TextBox3.Text) Then
                If Val(Me.TextBox3.Text) > Val(Label8.Text) Or Val(Me.TextBox3.Text) = 0 Then
                    MsgBox("La cantidad deve ser menor o igual al saldo")
                    Me.TextBox3.Focus()
                Else
                    Me.Label8.Text = Val(Label8.Text) - Val(Me.TextBox3.Text)
                    Me.Button3.Enabled = True
                    Me.Button3.Focus()
                End If
            Else
                MsgBox("El campo deve ser numerico")
                Me.TextBox3.Focus()
            End If
        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Me.TextBox2.Focus()
        End If
    End Sub


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim i As Int16 = 0
        Dim FECHA As Date

        Try
            Dim conexion As New base_local
            'comando3 = New Odbc.OdbcConnection
            'comando3.ConnectionString = cad_con
            'comando3.Open()
            For i = 0 To Me.DataGridView1.Rows.Count - 1
                If Mid(Me.DataGridView1.Item("r_venta", i).Value, 1, 1) = "C" Then
                    FECHA = Now 'Me.DataGridView1.Item("r_fecha", i).Value
                    conexion.InsertarSQL("insert into p_cancelados values('" + Me.DataGridView1.Item("r_cliente", i).Value + "','" + Me.DataGridView1.Item("r_venta", i).Value + "','" + Me.DataGridView1.Item("r_recibo", i).Value + "',0,'" + Format(FECHA, "yyyy-MM-dd") + "','" + Format(FECHA, "yyyy-MM-dd") + "'," + Str(rp) + ",'" + bodega + "')")

                    'nuevo = New Odbc.OdbcCommand("insert into p_cancelados values('" + Me.DataGridView1.Item("r_cliente", i).Value + "','" + Me.DataGridView1.Item("r_venta", i).Value + "','" + Me.DataGridView1.Item("r_recibo", i).Value + "',0,'" + Format(FECHA, "yyyy-MM-dd") + "','" + Format(FECHA, "yyyy-MM-dd") + "'," + Str(rp) + ",'" + bodega + "')", comando3)
                    'nuevo.ExecuteNonQuery()
                ElseIf Mid(Me.DataGridView1.Item("r_venta", i).Value, 1, 1) = "F" Or Mid(Me.DataGridView1.Item("r_venta", i).Value, 1, 1) = "f" Then
                    FECHA = Me.DataGridView1.Item("r_fecha", i).Value
                    conexion.InsertarSQL("insert into p_cancelados values('','" + Me.DataGridView1.Item("r_venta", i).Value + "','" + Me.DataGridView1.Item("r_recibo", i).Value + "'," + Str(Me.DataGridView1.Item("r_cantidad", i).Value) + ",'" + Format(FECHA, "yyyy-MM-dd") + "','" + Format(FECHA, "yyyy-MM-dd") + "'," + Str(rp) + ",'" + bodega + "')")
                    'nuevo = New Odbc.OdbcCommand("insert into p_cancelados values('','" + Me.DataGridView1.Item("r_venta", i).Value + "','" + Me.DataGridView1.Item("r_recibo", i).Value + "'," + Str(Me.DataGridView1.Item("r_cantidad", i).Value) + ",'" + Format(FECHA, "yyyy-MM-dd") + "','" + Format(FECHA, "yyyy-MM-dd") + "'," + Str(rp) + ",'" + bodega + "')", comando3)
                    'nuevo.ExecuteNonQuery()

                Else
                    FECHA = Me.DataGridView1.Item("r_fecha", i).Value
                    conexion.InsertarSQL("call insertar_pago('" + Me.DataGridView1.Item("r_recibo", i).Value + "','" + Me.DataGridView1.Item("r_cliente", i).Value + "','" + bodega + Me.DataGridView1.Item("r_venta", i).Value + "'," + rp.ToString + "," + Me.DataGridView1.Item("r_cantidad", i).Value + ",'" + Format(FECHA, "yyyy-MM-dd") + "','" + usuario + "','" + My.Computer.Name + "')")

                    'nuevo = New Odbc.OdbcCommand("insert into pagos values('" + Me.DataGridView1.Item("r_cliente", i).Value + "','" + Me.DataGridView1.Item("r_venta", i).Value + "','" + bodega + "'," + Str(rp) + ",'" + Me.DataGridView1.Item("r_recibo", i).Value + "'," + Me.DataGridView1.Item("r_cantidad", i).Value + ",'" + Format(FECHA, "yyyy-MM-dd") + "'," + Me.DataGridView1.Item("r_saldo", i).Value + ")", comando3)
                    'nuevo.ExecuteNonQuery()
                    'nuevo = New Odbc.OdbcCommand("update credito set saldo=saldo-" + Me.DataGridView1.Item("r_cantidad", i).Value + " where venta_clave='" + bodega + Me.DataGridView1.Item("r_venta", i).Value + "'", comando3)
                    'nuevo.ExecuteNonQuery()
                    ''nuevo = New Odbc.OdbcCommand("update clientes set saldo=saldo-" + Me.DataGridView1.Item("r_cantidad", i).Value + " where cli_clave='" + Me.DataGridView1.Item("r_cliente", i).Value + "'", comando3)
                    ''nuevo.ExecuteNonQuery()
                    'nuevo = New Odbc.OdbcCommand("insert into movimientos values('" + usuario + ".','" + Format(Now, "yyyy-MM-dd HH:mm:ss") + "','" + bodega1 + "','Alta de pago recivo no " + Me.DataGridView1.Item("r_recibo", i).Value + " cuenta" + Me.DataGridView1.Item("r_venta", i).Value + "'," + Me.DataGridView1.Item("r_cantidad", i).Value + ")", comando3)
                    'nuevo.ExecuteNonQuery()

                End If
            Next
            conexion.dispose()
            'comando3.Close()
            MsgBox("Recibos guardados")
            Me.DataGridView1.Rows.Clear()
            Me.Label13.Text = "0"
            Me.Label15.Text = "0"
            Me.Label17.Text = "0"
            Me.Label19.Text = "0"
            Me.Button1.Enabled = False
            Me.TextBox1.Focus()
            LIMPIAR()
            Me.TextBox2.Text = ""
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.TextBox1.Focus()
        End Try
    End Sub
    Private Sub LIMPIAR()
        Me.TextBox1.Text = ""
        Me.TextBox3.Text = ""
        Me.Label5.Text = "-----"
        Me.Label8.Text = "00000"
        Me.Label21.Text = "-----"
        Me.TextBox2.Text = Val(Me.TextBox2.Text) + 1
        Me.TextBox1.Focus()
    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged
        Me.TextBox1.Focus()
    End Sub


    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.TextBox1.Text = ""
        Me.TextBox2.Text = ""
        Me.TextBox3.Text = ""
        Me.Label5.Text = "-----"
        Me.Label8.Text = "00000"
        Me.TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        If Me.TextBox4.Text = "" Then
            MsgBox("Llenar campo con la letra del recibo")
            Me.TextBox4.Focus()
            GoTo fin
        End If
        If Me.TextBox2.Text = "" Then
            MsgBox("Llenar campo con el numero del recibo")
            Me.TextBox2.Focus()
            GoTo fin
        End If
        If Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") >= Format(Now, "yyyy-MM-dd") Then
            MsgBox("La fecha no puede ser igual o mayor a la actual")
            Me.DateTimePicker1.Focus()
            GoTo fin
        End If

        Me.Panel1.Visible = True
        Me.Label23.Focus()
        Me.Label23.Text = Me.Label21.Text
        Me.Label24.Text = Me.Label5.Text
        Me.Label26.Text = Me.TextBox3.Text
        Me.Label28.Text = Me.Label8.Text
fin:
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Button1.Enabled = True
        Me.Button1.Focus()
    End Sub

    Private Sub DataGridView1_UserDeletingRow(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Dim AAAA As String
        Me.Label13.Text = Me.DataGridView1.Rows.Count - 1
        If Mid(Me.DataGridView1.Item("r_venta", Me.DataGridView1.CurrentRow.Index).Value, 1, 1) = "F" Then Me.Label19.Text = Val(Me.Label19.Text) - 1
        If Mid(Me.DataGridView1.Item("r_venta", Me.DataGridView1.CurrentRow.Index).Value, 1, 1) = "C" Then Me.Label19.Text = Val(Me.Label19.Text) - 1
        AAAA = Mid(Me.DataGridView1.Item("r_venta", Me.DataGridView1.CurrentRow.Index).Value, 1)
        AAAA = Val(Me.Label15.Text) - Me.DataGridView1.Item("r_cantidad", Me.DataGridView1.CurrentRow.Index).Value
        Me.Label15.Text = Val(Me.Label15.Text) - Me.DataGridView1.Item("r_cantidad", Me.DataGridView1.CurrentRow.Index).Value
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Try
            Me.DataGridView1.Rows.Add()
            Me.DataGridView1.Item("r_cliente", Me.DataGridView1.Rows.Count - 1).Value = cliente
            Me.DataGridView1.Item("r_venta", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox1.Text
            Me.DataGridView1.Item("r_recibo", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox4.Text + Me.TextBox2.Text
            Me.DataGridView1.Item("r_cantidad", Me.DataGridView1.Rows.Count - 1).Value = Me.TextBox3.Text
            Me.DataGridView1.Item("r_fecha", Me.DataGridView1.Rows.Count - 1).Value = Format(Me.DateTimePicker1.Value, "dd-MM-yyyy")
            Me.DataGridView1.Item("r_saldo", Me.DataGridView1.Rows.Count - 1).Value = Me.Label8.Text
            Me.DataGridView1.Item("nombre", Me.DataGridView1.Rows.Count - 1).Value = Me.Label5.Text
            Me.Label13.Text = Me.DataGridView1.Rows.Count
            Me.Label15.Text = Val(Me.Label15.Text) + Val(Me.TextBox3.Text)
            LIMPIAR()
            Me.Panel1.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
            Me.TextBox1.Focus()
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Panel1.Visible = False
        Me.TextBox3.Focus()
    End Sub
End Class