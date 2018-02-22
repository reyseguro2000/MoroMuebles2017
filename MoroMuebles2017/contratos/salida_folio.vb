Public Class salida_folio
    Private Sub cambiar_ruta()
        lblruta.Text = InputBox("Numero de ruta")
        If Val(lblruta.Text) = 0 Then
            MsgBox("Error en la ruta")
            Me.Close()
        End If
    End Sub
    Private Sub txt_folio_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_folio.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            'buscamos folio
            txtfolio_old.Text = UCase(txtfolio_old.Text)
            Dim conexion As New base_local
            Dim encontrado As DataRow

            encontrado = conexion.repetido("select * from  vista_clientes_folios where ESTADO='PENDIENTE' and folio='" + txt_folio.Text + "'", "vista_clientes_folios")

            If IsDBNull(encontrado.Item("nombre")) = False Then
                lblnombre.Text = encontrado.Item("nombre")
                lbldireccion.Text = encontrado.Item("direccion")
                lblcliente.Text = encontrado.Item("cliente")
                txtfolio_old.Text = Trim(txtfolio_old.Text)
                DateTimePicker1.Focus()
            Else
                MsgBox("No se encuentra el cliente con ese folio")

            End If
            conexion.dispose()
        End If
    End Sub
    Private Sub btcambiar_ruta_Click(sender As Object, e As EventArgs) Handles btcambiar_ruta.Click
        cambiar_ruta()
    End Sub

    Private Sub salida_folio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cambiar_ruta()
        Dim conexion As New base_local
        conexion.llena_combo(txtvendedor, "select clave, nombre from  personal where bodega='" + bodega + "' and estado='A' order by nombre")
        Me.txtvendedor.DisplayMember = "nombre"
        Me.txtvendedor.ValueMember = "clave"
        conexion.llena_combo(cmb_articulo, "select clave, articulo,precio,formula from  articulos order by articulo")
        cmb_articulo.DisplayMember = "articulo"
        cmb_articulo.ValueMember = "clave"
        ' conexion.cargar_datos()
        conexion.dispose()
        txtvendedor.Enabled = True
        Me.dgarticulos.Columns("precio").Visible = False
        Me.dgarticulos.Columns("formula").Visible = False
        Me.dgarticulos.Columns("p_lista").Visible = False
        Me.dgarticulos.Columns("comicion").Visible = False
    End Sub
    Private Sub btprecios_Click(sender As Object, e As EventArgs) Handles btprecios.Click

        txtcomicion.Text = lista1(3) ' "0"
        lbltotal.Text = "0"
        For Each row In dgarticulos.Rows

            Select Case row.cells("formula").value
                Case 1

                    row.cells("unitario").value = row.cells("p_lista").value * (lista1(Val(txtplazo.Text)) / 100)
                    row.cells("unitario").value = row.cells("unitario").value + row.cells("p_lista").value
                    row.cells("unitario").value = Int(row.cells("unitario").value + 0.5)
                    row.cells("COMICION").value = Int(row.cells("p_lista").value * (lista1(13) / 100) + 0.5)
                    txtcomicion.Text = Int((Val(txtcomicion.Text) + row.cells("p_lista").value * (lista1(13) / 100)) + 0.5)

                Case 2
                    row.cells("unitario").value = row.cells("p_lista").value * (lista2(Val(txtplazo.Text)) / 100)
                    row.cells("unitario").value = row.cells("unitario").value + row.cells("p_lista").value
                    row.cells("unitario").value = Int(row.cells("unitario").value + 0.5)
                    row.cells("COMICION").value = Int(row.cells("p_lista").value * (lista2(13) / 100) + 0.5)
                    txtcomicion.Text = Int((Val(txtcomicion.Text) + row.cells("p_lista").value * (lista2(13) / 100)) + 0.5)
                Case 3
                    row.cells("unitario").value = row.cells("p_lista").value * (lista3(Val(txtplazo.Text)) / 100)
                    row.cells("unitario").value = row.cells("unitario").value + row.cells("p_lista").value
                    row.cells("unitario").value = Int(row.cells("unitario").value + 0.5)
                    row.cells("COMICION").value = Int(row.cells("p_lista").value * (lista3(13) / 100) + 0.5)
                    txtcomicion.Text = Int((Val(txtcomicion.Text) + row.cells("p_lista").value * (lista3(13) / 100)) + 0.5)

            End Select
            lbltotal.Text = Val(lbltotal.Text) + (Val(row.CELLS("unitario").value) * Val(row.CELLS("cantidad").value))
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
            lbltotal.Text = Val(lbltotal.Text) + (row.cells("cantidad").value * row.cells("unitario").value)
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
            articulos = articulos + Me.dgarticulos.Item("clave", i).Value.PadRight(10, " "c) + Str(Me.dgarticulos.Item("precio", i).Value).PadRight(5, " "c) + Str(Me.dgarticulos.Item("cantidad", i).Value).PadRight(5, " "c) + Str(Me.dgarticulos.Item("unitario", i).Value).PadRight(5, " "c) + Str(Me.dgarticulos.Item("formula", i).Value).PadRight(5, " "c)
        Next
        Dim conexion As New base_local
        conexion.InsertarSQL("call ventas_sin_camioneta(" + lblcliente.Text.ToString + ", '" + txt_folio.Text + "', " + lblruta.Text + ", '" + Format(DateTimePicker1.Value, "yyyy-MM-dd") + "'," + txtplazo.Text + "," + Str(txtforma.SelectedIndex + 1) + "," + lbltotal.Text + "," + txtenganche.Text + "," + txtdescuentocant.Text + ",'" + txtdescuento.Text + "', " + txtvendedor.SelectedValue.ToString + "," + txtcomicion.Text + "," + Str(chekaval.CheckState) + ",'" + txtnombreaval.Text + "','" + txtcalleaval.Text + "','" + txtcoloniaaval.Text + "','" + txtciudadaval.Text + "','" + txttelaval.Text + "','" + articulos + "'," + dgarticulos.RowCount.ToString + ",'" + usuario + "','" + My.Computer.Name + "'," + lblsaldo.Text + ")")
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

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim fila_articulo As Integer
        dgarticulos.Rows.Add()
        fila_articulo = dgarticulos.RowCount - 1
        dgarticulos.Item("cantidad", fila_articulo).Value = txt_cantidad.Text
        dgarticulos.Item("clave", fila_articulo).Value = cmb_articulo.SelectedValue
        dgarticulos.Item("articulo", fila_articulo).Value = cmb_articulo.Text
        dgarticulos.Item("precio", fila_articulo).Value = cmb_articulo.Items(cmb_articulo.SelectedIndex)("precio").ToString
        dgarticulos.Item("formula", fila_articulo).Value = cmb_articulo.Items(cmb_articulo.SelectedIndex)("formula").ToString
        dgarticulos.Item("p_lista", fila_articulo).Value = cmb_articulo.Items(cmb_articulo.SelectedIndex)("precio").ToString
        dgarticulos.Item("unitario", fila_articulo).Value = cmb_articulo.Items(cmb_articulo.SelectedIndex)("precio").ToString
        dgarticulos.Item("comicion", fila_articulo).Value = "" ' cmb_articulo.Items("precio")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        dgarticulos.Rows.Clear()
    End Sub

    Private Sub PrintContrato_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintContrato.PrintPage

    End Sub
End Class