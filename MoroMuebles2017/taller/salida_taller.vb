Public Class salida_taller
    Private Sub salida_taller_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        Dim conexion As New base_local
        'conexion.llena_combo(cmb_taller, "select * from taller order by taller")
        'cmb_taller.DisplayMember = "taller"
        'cmb_taller.ValueMember = "clave_taller"
        conexion.llena_combo(cmb_articulo, "select * from articulos order by articulo")
        cmb_articulo.DisplayMember = "articulo"
        cmb_articulo.ValueMember = "clave"
        conexion.dispose()

    End Sub

    Private Sub btn_taller_Click(sender As Object, e As EventArgs)
        nuevo_taller.ShowDialog()

    End Sub

    Private Sub salida_taller_Activated(sender As Object, e As EventArgs) Handles Me.Activated
        'Dim conexion As New base_local
        'conexion.llena_combo(cmb_taller, "select * from taller order by taller")
        'cmb_taller.DisplayMember = "taller"
        'cmb_taller.ValueMember = "clave_taller"
        'conexion.dispose()
    End Sub

    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        'Dim conexion As New base_local
        'Dim id_salida As Integer
        'id_salida = conexion.InsertaEscalar("call salida_taller_d(" + lbl_clave.Text + "," + dg_articulos.RowCount.ToString + ",'" + usuario + "','" + My.Computer.Name + "')")
        'For i_art As Int16 = 0 To dg_articulos.RowCount - 1
        '    conexion.InsertarSQL("call salida_taller_d('" + dg_articulos.Item("clave", i_art).Value + "','" + txt_detalle.Text + "')")
        'Next
        'conexion.dispose()

        Dim folio_salida As Integer
        Dim articulos As String = ""
        Dim conexion_local As New base_local
        For fila_regresa As Integer = 0 To dg_articulos.RowCount - 1
            articulos = articulos & dg_articulos.Item("t_clave", fila_regresa).Value.PadRight(15, " "c) & dg_articulos.Item("t_detalle", fila_regresa).Value.PadRight(20, " "c)
        Next
        folio_salida = conexion_local.InsertaEscalar("call insertar_salida_taller(" & lbl_clave.Text & ",'" & articulos & "'," & lbl_piezaz.Text & ",'" & My.Computer.Name & "','" & usuario & "')")
        conexion_local.dispose()
        MsgBox("Salida guardada con el folio " & folio_salida.ToString)
        Me.Dispose()


    End Sub

    Private Sub btn_agregar_Click(sender As Object, e As EventArgs) Handles btn_agregar.Click
        dg_articulos.Rows.Add()
        dg_articulos.Item("t_clave", dg_articulos.RowCount - 1).Value = cmb_articulo.SelectedValue
        dg_articulos.Item("t_articulo", dg_articulos.RowCount - 1).Value = cmb_articulo.Text
        dg_articulos.Item("t_detalle", dg_articulos.RowCount - 1).Value = txt_detalle.Text
        lbl_piezaz.Text = Val(lbl_piezaz.Text) + 1

    End Sub

    Private Sub dg_articulos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg_articulos.CellContentClick

    End Sub

    Private Sub dg_articulos_RowsRemoved(sender As Object, e As DataGridViewRowsRemovedEventArgs) Handles dg_articulos.RowsRemoved
        lbl_piezaz.Text = Val(lbl_piezaz.Text) - 1
    End Sub
End Class