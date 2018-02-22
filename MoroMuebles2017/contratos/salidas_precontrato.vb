Public Class salidas_precontrato
    Private Sub salidas_precontrato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiar_ruta()
        Dim conexion As New base_local
        conexion.llena_combo(txtvendedor, "select clave, nombre from  personal where bodega='" + bodega + "' and estado='A' order by nombre")
        Me.txtvendedor.DisplayMember = "nombre"
        Me.txtvendedor.ValueMember = "clave"
        'conexion = New Odbc.OdbcConnection(cad_con)
        'conexion.Open()
        'comando = New Odbc.OdbcCommand("select clave, nombre from  personal where bodega='" + bodega + "' and estado='A' order by nombre", conexion)
        'da = New Odbc.OdbcDataAdapter
        'da.SelectCommand = comando
        'dt = New DataTable
        'da.Fill(dt)
        'Me.txtvendedor.DataSource = dt


        txtvendedor.Enabled = True
        conexion.dispose()
        llena_folio()
        txtdescuento.SelectedIndex = 0
    End Sub
    Private Sub llena_folio()
        Dim conexion As New base_local
        conexion.llena_combo(txt_folio, "select folio from vista_clientes_folios where estado='PENDIENTE'")
        txt_folio.DisplayMember = "folio"
        conexion.dispose()
    End Sub
    Private Sub cambiar_ruta()

        lblruta.Text = InputBox("Numero de ruta")
        If Val(lblruta.Text) = 0 Then
            MsgBox("Error en la ruta")
            Me.Close()
        End If
    End Sub

    Private Sub btcambiar_ruta_Click(sender As Object, e As EventArgs) Handles btcambiar_ruta.Click
        cambiar_ruta()

    End Sub

    Private Sub txtfolio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtfolio_old.KeyPress
        ' Dim lector_articulos As Odbc.OdbcDataReader
        If e.KeyChar = Chr(Keys.Enter) Then
            'buscamos folio
            txtfolio_old.Text = UCase(txtfolio_old.Text)
            Dim conexion As New base_local
            Dim encontrado As DataRow

            encontrado = conexion.repetido("select * from  clientes, clientes_folio where ESTADO='PENDIENTE' and folio='" + txtfolio_old.Text + "'", "vista_clientes_folios")

            'conexion = New Odbc.OdbcConnection(cad_con)
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("select Cliente, Nombre, concat(calle,' ',colonia,' ', ciudad) as direccion, folio from  clientes, clientes_folio where cliente=clave_i AND ESTADO='PENDIENTE' and folio='" + txtfolio.Text + "'", conexion)
            'lector = comando.ExecuteReader
            If IsDBNull(encontrado) = False Then
                lblnombre.Text = encontrado.Item("nombre")
                lbldireccion.Text = encontrado.Item("direccion")
                lblcliente.Text = encontrado.Item("cliente")
                conexion.llena_tabla(dgarticulos, "select count(salidas_camionetas_d.articulo) as Cantidad, clave, articulos.articulo, precio, formula, p_lista,'' as 'p-u', '' as Comicion FROM articulos,salidas_camionetas_d   WHERE estado='" + txtfolio_old.Text + "' AND clave=salidas_camionetas_d.articulo GROUP BY clave")
                'comando = New Odbc.OdbcCommand("select count(salidas_camionetas_d.articulo) as Cantidad, clave, articulos.articulo, precio, formula, p_lista,'' as 'p-u', '' as Comicion FROM articulos,salidas_camionetas_d   WHERE estado='" + txtfolio.Text + "' AND clave=salidas_camionetas_d.articulo GROUP BY clave", conexion)
                'da = New Odbc.OdbcDataAdapter(comando)
                'ds = New DataSet
                'da.Fill(ds)
                'Me.dgarticulos.DataSource = Nothing
                'Me.dgarticulos.DataSource = ds.Tables(0).DefaultView
                Me.dgarticulos.Columns("precio").Visible = False
                Me.dgarticulos.Columns("formula").Visible = False
                Me.dgarticulos.Columns("p_lista").Visible = False
                Me.dgarticulos.Columns("comicion").Visible = False

                e.KeyChar = Chr(Keys.Tab)
                txtfolio_old.Text = Trim(txtfolio_old.Text)
                DateTimePicker1.Focus()

            Else
                MsgBox("No se encuentra el cliente con ese folio")

            End If
            conexion.dispose()
        End If
    End Sub

    Private Sub btprecios_Click(sender As Object, e As EventArgs) Handles btprecios.Click

        txtcomicion.Text = "0"
        lbltotal.Text = "0"
        For Each row In dgarticulos.Rows

            Select Case row.cells("formula").value
                Case 1

                    row.cells("p-u").value = row.cells("p_lista").value * (lista1(Val(txtplazo.Text)) / 100)
                    row.cells("p-u").value = row.cells("p-u").value + row.cells("p_lista").value
                    row.cells("p-u").value = Int(row.cells("p-u").value + 0.5)
                    row.cells("COMICION").value = Int(row.cells("p_lista").value * (lista1(13) / 100) + 0.5)
                    txtcomicion.Text = Int((Val(txtcomicion.Text) + row.cells("p_lista").value * (lista1(13) / 100)) + 0.5)

                Case 2
                    row.cells("p-u").value = row.cells("p_lista").value * (lista2(Val(txtplazo.Text)) / 100)
                    row.cells("p-u").value = row.cells("p-u").value + row.cells("p_lista").value
                    row.cells("p-u").value = Int(row.cells("p-u").value + 0.5)
                    row.cells("COMICION").value = Int(row.cells("p_lista").value * (lista2(13) / 100) + 0.5)
                    txtcomicion.Text = Int((Val(txtcomicion.Text) + row.cells("p_lista").value * (lista2(13) / 100)) + 0.5)
                Case 3
                    row.cells("p-u").value = row.cells("p_lista").value * (lista3(Val(txtplazo.Text)) / 100)
                    row.cells("p-u").value = row.cells("p-u").value + row.cells("p_lista").value
                    row.cells("p-u").value = Int(row.cells("p-u").value + 0.5)
                    row.cells("COMICION").value = Int(row.cells("p_lista").value * (lista3(13) / 100) + 0.5)
                    txtcomicion.Text = Int((Val(txtcomicion.Text) + row.cells("p_lista").value * (lista3(13) / 100)) + 0.5)

            End Select
            lbltotal.Text = Val(lbltotal.Text) + (Val(row.CELLS("p-u").value) * Val(row.CELLS("cantidad").value))
        Next
        lblsaldo.Text = lbltotal.Text
        txtcomicion.Focus()
    End Sub
    Private Sub actualiza_total()
        lbltotal.Text = "0"
        Select Case txtforma.Text
            Case "Semanal"
                lblnopagos.Text = Val(txtplazo.Text) * 4
            Case "Quincenal"
                lblnopagos.Text = Val(txtplazo.Text) * 2
            Case "Mensual"
                lblnopagos.Text = Val(txtplazo.Text)
        End Select
        For Each row In dgarticulos.Rows
            lbltotal.Text = Val(lbltotal.Text) + (row.cells("cantidad").value * row.cells("p-u").value)
            ' txtcomicion.Text = Val(txtcomicion.Text) + (row.cells("cantidad").value * row.cells("comicion").value)
        Next
        lblsaldo.Text = Val(lbltotal.Text) - Val(txtenganche.Text) - Val(txtdescuentocant.Text)
        lblpagos.Text = Int(Val((lblsaldo.Text) / Val(lblnopagos.Text)) + 0.5)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btsaldo.Click
        actualiza_total()
        btguardar.Enabled = True
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        If DateTimePicker1.Value > Now Then
            MsgBox("La fecha no puede ser mayor a la actual")
            DateTimePicker1.Value = Now
            DateTimePicker1.Focus()
        End If
    End Sub


    Private Sub txtvendedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtvendedor.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtplazo.Focus()
        End If
    End Sub


    Private Sub txtplazo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtplazo.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txtplazo.SelectedIndex >= 0 Then
                lblvence.Text = Format(DateAdd(DateInterval.Month, Val(txtplazo.Text), DateTimePicker1.Value), "dd-MM-yyyy")
                txtforma.Focus()
            Else
                MsgBox("Seleccionar plazo")
                txtplazo.DroppedDown = True
            End If

        End If
    End Sub



    Private Sub txtforma_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtforma.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Select Case txtforma.Text
                Case "Semanal"
                    lblnopagos.Text = Val(txtplazo.Text) * 4
                Case "Quincenal"
                    lblnopagos.Text = Val(txtplazo.Text) * 2
                Case "Mensual"
                    lblnopagos.Text = Val(txtplazo.Text)
                Case Else
                    MsgBox("Seleccionar forma de pago")
                    GoTo sal
            End Select
            btprecios.Focus()
sal:
        End If
    End Sub


    Private Sub txtdescuento_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuento.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If txtdescuento.SelectedIndex > 0 Then

                txtdescuentocant.Focus()
                txtdescuentocant.SelectAll()
            Else
                txtenganche.Focus()
            End If

        End If
    End Sub



    Private Sub txtdescuentocant_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtdescuentocant.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            lblsaldo.Text = Val(lbltotal.Text) - Val(txtdescuentocant.Text)
            txtenganche.Focus()
            txtenganche.SelectAll()
        End If
    End Sub

    Private Sub txtenganche_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtenganche.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            lblsaldo.Text = Val(lblsaldo.Text) - Val(txtenganche.Text)
            btsaldo.Focus()
        End If
    End Sub

    Private Sub btguardar_Click(sender As Object, e As EventArgs) Handles btguardar.Click
        Dim articulos As String
        articulos = ""
        For i As Integer = 0 To Me.dgarticulos.RowCount - 1
            articulos = articulos + Me.dgarticulos.Item("clave", i).Value.PadRight(10, " "c) + Str(Me.dgarticulos.Item("precio", i).Value).PadRight(5, " "c) + Str(Me.dgarticulos.Item("cantidad", i).Value).PadRight(5, " "c) + Str(Me.dgarticulos.Item("p-u", i).Value).PadRight(5, " "c) + Str(Me.dgarticulos.Item("formula", i).Value).PadRight(5, " "c)
        Next
        Dim conexion As New base_local
        conexion.InsertarSQL("call ventas_camioneta(" + lblcliente.Text.ToString + ", '" + txt_folio.Text + "', " + lblruta.Text + ", '" + Format(DateTimePicker1.Value, "yyyy-MM-dd") + "'," + txtplazo.Text + "," + Str(txtforma.SelectedIndex + 1) + "," + lbltotal.Text + "," + txtenganche.Text + "," + txtdescuentocant.Text + ",'" + txtdescuento.Text + "', " + txtvendedor.SelectedValue.ToString + "," + txtcomicion.Text + "," + Str(chekaval.CheckState) + ",'" + txtnombreaval.Text + "','" + txtcalleaval.Text + "','" + txtcoloniaaval.Text + "','" + txtciudadaval.Text + "','" + txttelaval.Text + "','" + articulos + "'," + dgarticulos.RowCount.ToString + ",'" + usuario + "','" + My.Computer.Name + "'," + lblsaldo.Text + ")")
        conexion.dispose()
        'conexion = New Odbc.OdbcConnection(cad_con)
        'conexion.Open()
        'comando = New Odbc.OdbcCommand("call ventas_camioneta(" + lblcliente.Text.ToString + ", '" + txtfolio.Text + "', " + lblruta.Text + ", '" + Format(DateTimePicker1.Value, "yyyy-MM-dd") + "'," + txtplazo.Text + "," + Str(txtforma.SelectedIndex + 1) + "," + lbltotal.Text + "," + txtenganche.Text + "," + txtdescuentocant.Text + ",'" + txtdescuento.Text + "', " + txtvendedor.SelectedValue.ToString + "," + txtcomicion.Text + "," + Str(chekaval.CheckState) + ",'" + txtnombreaval.Text + "','" + txtcalleaval.Text + "','" + txtcoloniaaval.Text + "','" + txtciudadaval.Text + "','" + txttelaval.Text + "','" + articulos + "'," + dgarticulos.RowCount.ToString + ",'" + usuario + "','" + My.Computer.Name + "'," + lblsaldo.Text + ")", conexion)
        'comando.ExecuteNonQuery()
        'conexion.Close()

        MsgBox("Guardado aqui")
        Me.Close()
    End Sub

    Private Sub txtvendedor_KeyUp(sender As Object, e As KeyEventArgs) Handles txtvendedor.KeyUp
        If sender.NAME = "txtvendedor" Then
            If e.KeyCode = 13 Then
                txtplazo.Focus()
            End If
        End If
    End Sub

    Private Sub txtdescuento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtdescuento.SelectedIndexChanged
        If txtdescuento.SelectedIndex > 0 Then
            txtdescuentocant.Visible = True
            ' txtdescuentocant.Focus()
        Else
            txtdescuentocant.Text = "0"
            txtdescuentocant.Visible = False
        End If
    End Sub

    Private Sub DateTimePicker1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles DateTimePicker1.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtvendedor.DroppedDown = True
        End If
    End Sub

    Private Sub txtcomicion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcomicion.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtdescuento.Focus()
        End If
    End Sub

    Private Sub chekaval_CheckedChanged(sender As Object, e As EventArgs) Handles chekaval.CheckedChanged
        If chekaval.Checked = True Then
            aval_datos.Visible = True
            txtnombreaval.Focus()
        Else
            aval_datos.Visible = False
        End If
    End Sub

    Private Sub txtnombreaval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtnombreaval.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtnombreaval.Text = UCase(txtnombreaval.Text)
            txtcalleaval.Focus()
        End If
    End Sub

    Private Sub txtcalleaval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcalleaval.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtcalleaval.Text = UCase(txtcalleaval.Text)
            txtcoloniaaval.Focus()
        End If
    End Sub


    Private Sub txtcoloniaaval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtcoloniaaval.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtcoloniaaval.Text = UCase(txtcoloniaaval.Text)
            txtciudadaval.Focus()
        End If
    End Sub



    Private Sub txtciudadaval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtciudadaval.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txtciudadaval.Text = UCase(txtciudadaval.Text)
            txttelaval.Focus()
        End If
    End Sub

    Private Sub txttelaval_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txttelaval.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txttelaval.Text = UCase(txttelaval.Text)
            'txtcalleaval.Focus()
        End If
    End Sub




    Private Sub txt_folio_KeyUp(sender As Object, e As KeyEventArgs) Handles txt_folio.KeyUp
        If e.KeyCode = 13 Then
            'buscamos folio
            txtfolio_old.Text = UCase(txtfolio_old.Text)
            Dim conexion As New base_local
            Dim encontrado As DataRow

            encontrado = conexion.repetido("select * from  vista_clientes_folios where ESTADO='PENDIENTE' and folio='" + txt_folio.Text + "'", "vista_clientes_folios")

            'conexion = New Odbc.OdbcConnection(cad_con)
            'conexion.Open()
            'comando = New Odbc.OdbcCommand("select Cliente, Nombre, concat(calle,' ',colonia,' ', ciudad) as direccion, folio from  clientes, clientes_folio where cliente=clave_i AND ESTADO='PENDIENTE' and folio='" + txtfolio.Text + "'", conexion)
            'lector = comando.ExecuteReader
            If IsDBNull(encontrado) = False Then
                lblnombre.Text = encontrado.Item("nombre")
                lbldireccion.Text = encontrado.Item("direccion")
                lblcliente.Text = encontrado.Item("cliente")
                conexion.llena_tabla(dgarticulos, "select count(salidas_camionetas_d.articulo) as Cantidad, clave, articulos.articulo, precio, formula, p_lista,'' as 'p-u', '' as Comicion FROM articulos,salidas_camionetas_d   WHERE estado='" + txt_folio.Text + "' AND clave=salidas_camionetas_d.articulo GROUP BY clave")
                'comando = New Odbc.OdbcCommand("select count(salidas_camionetas_d.articulo) as Cantidad, clave, articulos.articulo, precio, formula, p_lista,'' as 'p-u', '' as Comicion FROM articulos,salidas_camionetas_d   WHERE estado='" + txtfolio.Text + "' AND clave=salidas_camionetas_d.articulo GROUP BY clave", conexion)
                'da = New Odbc.OdbcDataAdapter(comando)
                'ds = New DataSet
                'da.Fill(ds)
                'Me.dgarticulos.DataSource = Nothing
                'Me.dgarticulos.DataSource = ds.Tables(0).DefaultView
                Me.dgarticulos.Columns("precio").Visible = False
                Me.dgarticulos.Columns("formula").Visible = False
                Me.dgarticulos.Columns("p_lista").Visible = False
                Me.dgarticulos.Columns("comicion").Visible = False

                'e.KeyChar = Chr(Keys.Tab)
                txtfolio_old.Text = Trim(txtfolio_old.Text)
                DateTimePicker1.Focus()

            Else
                MsgBox("No se encuentra el cliente con ese folio")

            End If
            conexion.dispose()
        End If
    End Sub

    Private Sub PrintContrato_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintContrato.PrintPage
        Dim datos_cliente As DataRow

        Dim conexion As New base_local
        Dim Fuente As New System.Drawing.Font("Arial", 8)
        Dim Fuente2 As New System.Drawing.Font("Arial", 10)
        Dim Fuente3 As New System.Drawing.Font("Arial", 8)
        Dim codigo As New System.Drawing.Font("C39HrP48DhTt", 45)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Dim y, x As Int16
        y = 30

        datos_cliente = conexion.repetido("select * from clientes where clave_i=" + lblcliente.Text, "clientes")
        x = 5

        Grafico.DrawLine(Pens.Black, x + 10, 40, x + 210, 40)
        Grafico.DrawLine(Pens.Black, x + 10, 90, x + 210, 90)
        Grafico.DrawLine(Pens.Black, x + 10, 40, x + 10, 90)
        Grafico.DrawLine(Pens.Black, x + 100, 40, x + 100, 90)
        Grafico.DrawLine(Pens.Black, x + 140, 40, x + 140, 90)
        Grafico.DrawLine(Pens.Black, x + 210, 40, x + 210, 90)

        conexion.dispose()

    End Sub
End Class