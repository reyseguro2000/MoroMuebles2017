Public Class salida_fabrica
    Private Sub salida_fabrica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        Dim conexion_local As New base_local
        conexion_local.llena_combo(cmb_articulo, "select clave, articulo from articulos where clave like '" & lbl_clave_provedor.Text & "-%' order by articulo")
        conexion_local.dispose()
        cmb_articulo.DisplayMember = "articulo"
        cmb_articulo.ValueMember = "clave"
    End Sub

    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        dg_articulos.Rows.Add()
        dg_articulos.Item("t_clave", dg_articulos.RowCount - 1).Value = cmb_articulo.SelectedValue
        dg_articulos.Item("t_articulo", dg_articulos.RowCount - 1).Value = cmb_articulo.Text
        dg_articulos.Item("t_detalle", dg_articulos.RowCount - 1).Value = txt_detalle.Text
        lbl_piezaz.Text = dg_articulos.RowCount
        btn_guardar.Enabled = True

    End Sub



    Private Sub dg_articulos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dg_articulos.RowsRemoved
        lbl_piezaz.Text = dg_articulos.RowCount
        If dg_articulos.RowCount > 0 Then
            btn_guardar.Enabled = True
        Else
            btn_guardar.Enabled = False
        End If
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim folio_salida As Integer
        Dim articulos As String = ""
        Dim conexion_local As New base_local
        For fila_regresa As Integer = 0 To dg_articulos.RowCount - 1
            articulos = articulos & dg_articulos.Item("t_clave", fila_regresa).Value.PadRight(15, " "c) & dg_articulos.Item("t_detalle", fila_regresa).Value.PadRight(20, " "c)
        Next
        folio_salida = conexion_local.InsertaEscalar("call insertar_salida_fabrica(" & lbl_clave_provedor.Text & ",'" & articulos & "'," & lbl_piezaz.Text & ",'" & My.Computer.Name & "','" & usuario & "')")
        conexion_local.dispose()
        MsgBox("Salida guardada con el folio " & folio_salida.ToString)
        Me.Dispose()
    End Sub
End Class