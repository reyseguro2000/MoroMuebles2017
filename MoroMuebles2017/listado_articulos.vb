Public Class listado_articulos
    Private Sub listado_articulos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4

        Me.BackColor = Color.FromName(usuario_fondo)
        Me.ForeColor = Color.FromName(usuario_texto)
        carga_otra()
    End Sub
    Private Sub carga_otra()
        Dim si_activo As Char
        If op_activos.Checked = True Then
            si_activo = "A"
        Else
            si_activo = "B"
        End If
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(dg_articulos, "select Clave, Articulo, maquina as Exi, formula,p_lista from articulos where articulo like '%" & txt_articulo.Text & "%' and activo='" & si_activo & "' order by articulo")
        conexion_local.dispose()
        dg_articulos.Columns("formula").Visible = False
        dg_articulos.Columns("p_lista").Visible = False

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_articulo.TextChanged
        carga_otra()
    End Sub

    Private Sub dg_articulos_DoubleClick(sender As Object, e As EventArgs) Handles dg_articulos.DoubleClick
        img_articulo.ImageLocation = "c:\fotos\articulos\" & dg_articulos.Item("clave", dg_articulos.CurrentRow.Index).Value & ".jpg"
        lbl_clave.Text = dg_articulos.Item("clave", dg_articulos.CurrentRow.Index).Value
        lbl_articulo.Text = dg_articulos.Item("articulo", dg_articulos.CurrentRow.Index).Value
        Select Case dg_articulos.Item("formula", dg_articulos.CurrentRow.Index).Value
            Case "1"

                lbl_contado.Text = "CONTADO   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(0) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_1mes.Text = "1 MES     $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(1) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_2mes.Text = "2 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(2) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_3mes.Text = "3 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(3) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_4mes.Text = "4 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(4) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_5mes.Text = "5 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(5) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_6mes.Text = "6 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(6) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_7mes.Text = "7 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(7) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_8mes.Text = "8 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(8) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_9mes.Text = "9 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(9) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_10mes.Text = "10 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(10) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_11mes.Text = "11 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(11) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_12mes.Text = "12 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(12) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_com.Text = "COMICION  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(13) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                    lbl_mayoreo.Text = "MAYOREO   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista1(14) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)


            Case "2"
                lbl_contado.Text = "CONTADO   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(0) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_1mes.Text = "1 MES     $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(1) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_2mes.Text = "2 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(2) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_3mes.Text = "3 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(3) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_4mes.Text = "4 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(4) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_5mes.Text = "5 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(5) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_6mes.Text = "6 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(6) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_7mes.Text = "7 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(7) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_8mes.Text = "8 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(8) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_9mes.Text = "9 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(9) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_10mes.Text = "10 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(10) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_11mes.Text = "11 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(11) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_12mes.Text = "12 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(12) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_com.Text = "COMICION  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(13) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_mayoreo.Text = "MAYOREO   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista2(14) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)

            Case "3"

                lbl_contado.Text = "CONTADO   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(0) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_1mes.Text = "1 MES     $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(1) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_2mes.Text = "2 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(2) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_3mes.Text = "3 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(3) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_4mes.Text = "4 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(4) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_5mes.Text = "5 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(5) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_6mes.Text = "6 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(6) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_7mes.Text = "7 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(7) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_8mes.Text = "8 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(8) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_9mes.Text = "9 MESES   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(9) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_10mes.Text = "10 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(10) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_11mes.Text = "11 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(11) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_12mes.Text = "12 MESES  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(12) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_com.Text = "COMICION  $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(13) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)
                lbl_mayoreo.Text = "MAYOREO   $   " & Int(((dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value * lista3(14) / 100) + dg_articulos.Item("p_lista", dg_articulos.CurrentRow.Index).Value) + 0.5)

        End Select
    End Sub

    Private Sub btn_detalle_Click(sender As Object, e As EventArgs) Handles btn_detalle.Click
        listado_articulos_detalle.lbl_clave.Text = lbl_clave.Text
        listado_articulos_detalle.lbl_articulo.Text = lbl_articulo.Text
        listado_articulos_detalle.ShowDialog()
    End Sub
End Class