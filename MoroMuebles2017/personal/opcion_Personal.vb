Public Class opcion_Personal
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles foto_cara.Click
        Try
            busca_imagen.ShowDialog()
            foto_cara.ImageLocation = busca_imagen.FileName
        Catch ex As Exception
            MsgBox("Seleccionar imagen valida" + ex.ToString)
        End Try
    End Sub
    Private Sub foto_completo_Click(sender As Object, e As EventArgs) Handles foto_completo.Click
        Try
            busca_imagen.ShowDialog()
            foto_completo.ImageLocation = busca_imagen.FileName
        Catch ex As Exception
            MsgBox("Seleccionar imagen valida" + ex.ToString)
        End Try
    End Sub
    Private Sub actualiza_tabla()
        Dim conexion As New base_local
        conexion.llena_tabla(dtpersonal, "select * from personal where bodega='" + bodega + "'")
        conexion.dispose()
    End Sub
    Private Sub opcion_Personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        actualiza_tabla()
    End Sub

    Private Sub TextBox6_TextChanged(sender As Object, e As EventArgs) Handles TextBox6.TextChanged
        Dim conexion As New base_local
        conexion.llena_tabla(dtpersonal, "select * from personal where nombre like '%" + TextBox6.Text + "%' and bodega='" + bodega + "'")
        conexion.dispose()
    End Sub

    Private Sub dtpersonal_DoubleClick(sender As Object, e As EventArgs) Handles dtpersonal.DoubleClick
        grp_persona.Visible = True

        lbl_clave.Text = dtpersonal.Item("clave", dtpersonal.CurrentRow.Index).Value
        lbl_nombre.Text = dtpersonal.Item("nombre", dtpersonal.CurrentRow.Index).Value
        lbl_naci.Text = dtpersonal.Item("nacimiento", dtpersonal.CurrentRow.Index).Value
        lbl_telefono.Text = dtpersonal.Item("telefono", dtpersonal.CurrentRow.Index).Value
        lbl_calle.Text = dtpersonal.Item("calle", dtpersonal.CurrentRow.Index).Value
        lbl_ciudad.Text = dtpersonal.Item("ciudad", dtpersonal.CurrentRow.Index).Value
        lbl_colonia.Text = dtpersonal.Item("colonia", dtpersonal.CurrentRow.Index).Value
        lbl_puesto.Text = dtpersonal.Item("puesto_act", dtpersonal.CurrentRow.Index).Value
        lbl_sueldo.Text = dtpersonal.Item("sueldo_act", dtpersonal.CurrentRow.Index).Value
        btn_cuenta.Enabled = True
        btn_cambiar_puesto.Enabled = True

        'lleno ultimos movimientos
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(dg_anteriores, "select movimiento, fecha from movimiento_personal where id_personal=" & lbl_clave.Text)
        conexion_local.dispose()


        nuevo_personal.lbl_clave.Text = dtpersonal.Item("clave", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_nombre.Text = dtpersonal.Item("nombre", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_calle.Text = dtpersonal.Item("calle", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_colonia.Text = dtpersonal.Item("colonia", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_cidudad.Text = dtpersonal.Item("ciudad", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_telefono.Text = dtpersonal.Item("telefono", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_peso.Text = dtpersonal.Item("peso", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_estatura.Text = dtpersonal.Item("estatura", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_civil.Text = dtpersonal.Item("civil", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.f_nac.Value = dtpersonal.Item("nacimiento", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_curp.Text = dtpersonal.Item("curp", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_nss.Text = dtpersonal.Item("nss", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_padre.Text = dtpersonal.Item("padre", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_madre.Text = dtpersonal.Item("madre", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_conyuge.Text = dtpersonal.Item("conyuge", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_puesto.Text = dtpersonal.Item("puesto_act", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_sueldo.Text = dtpersonal.Item("sueldo_act", dtpersonal.CurrentRow.Index).Value
        If System.IO.File.Exists("c:\fotos\personal\" + dtpersonal.Item("clave", dtpersonal.CurrentRow.Index).Value.ToString + "_frente.jpg") Then
            foto_cara.ImageLocation = "c:\fotos\personal\" + dtpersonal.Item("clave", dtpersonal.CurrentRow.Index).Value.ToString + "_frente.jpg"
        Else
            foto_cara.ImageLocation = "c:\fotos\personal\pon_frente.jpg"
        End If
        If System.IO.File.Exists("c:\fotos\personal\" + dtpersonal.Item("clave", dtpersonal.CurrentRow.Index).Value.ToString + "_completo.jpg") Then
            foto_completo.ImageLocation = "c:\fotos\personal\" + dtpersonal.Item("clave", dtpersonal.CurrentRow.Index).Value.ToString + "_completo.jpg"
        Else
            foto_completo.ImageLocation = "c:\fotos\personal\pon_completo.jpg"
        End If

        'trabajo anterior 1
        nuevo_personal.txt_t1_empresa.Text = dtpersonal.Item("t1empresa", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t1_tiempo.Text = dtpersonal.Item("t1tiempo", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t1_dir.Text = dtpersonal.Item("t1dir", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t1_puesto.Text = dtpersonal.Item("t1puesto", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t1_sueldo.Text = dtpersonal.Item("t1sueldo", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t2_jefe.Text = dtpersonal.Item("t1jefe", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t1_tel.Text = dtpersonal.Item("t1tel", dtpersonal.CurrentRow.Index).Value

        'trabajo anterior 2
        nuevo_personal.txt_t2_empresa.Text = dtpersonal.Item("t2empresa", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t2_tiempo.Text = dtpersonal.Item("t2tiempo", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t2_dir.Text = dtpersonal.Item("t2dir", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t2_puesto.Text = dtpersonal.Item("t2puesto", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t2_sueldo.Text = dtpersonal.Item("t2sueldo", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t2_jefe.Text = dtpersonal.Item("t2jefe", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_t2_tel.Text = dtpersonal.Item("t2tel", dtpersonal.CurrentRow.Index).Value

        'referencia 1
        nuevo_personal.txt_r1_nombre.Text = dtpersonal.Item("r1nombre", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r1_tiempo.Text = dtpersonal.Item("r1tiempo", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r1_dir.Text = dtpersonal.Item("r1dir", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r1_ocupacion.Text = dtpersonal.Item("r1ocupacion", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r1_tel.Text = dtpersonal.Item("r1tel", dtpersonal.CurrentRow.Index).Value

        'referencia2
        nuevo_personal.txt_r2_nombre.Text = dtpersonal.Item("r2nombre", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r2_tiempo.Text = dtpersonal.Item("r2tiempo", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r2_dir.Text = dtpersonal.Item("r2dir", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r2_ocupacion.Text = dtpersonal.Item("r2ocupacion", dtpersonal.CurrentRow.Index).Value
        nuevo_personal.txt_r2_tel.Text = dtpersonal.Item("r2tel", dtpersonal.CurrentRow.Index).Value

        nuevo_personal.bt_modificar.Visible = True
        nuevo_personal.bt_guardar.Visible = False

        bt_nuevo.Visible = True
    End Sub

    Private Sub bt_nuevo_Click(sender As Object, e As EventArgs) Handles bt_nuevo.Click



        nuevo_personal.bt_modificar.Visible = False
        nuevo_personal.bt_guardar.Visible = True
        nuevo_personal.Dispose()

        nuevo_personal.ShowDialog()

        'bt_nuevo.Visible = False
    End Sub

    Private Sub btn_cuenta_Click(sender As Object, e As EventArgs) Handles btn_cuenta.Click
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(cuenta_personal.dg_ultimos_pagos, "select cantidad, fecha, nota from pago_personal where personal=" & lbl_clave.Text & " order by fecha desc")
        conexion_local.dispose()
        cuenta_personal.lbl_clave.Text = lbl_clave.Text
        cuenta_personal.lbl_nombre.Text = lbl_nombre.Text
        cuenta_personal.lbl_puesto.Text = lbl_puesto.Text
        If lbl_puesto.Text = "VENDEDOR" Or lbl_puesto.Text = "COBRADOR" Then
            cuenta_personal.lbl_sugerido.Text = "0"
        Else
            cuenta_personal.lbl_sugerido.Text = lbl_sueldo.Text
        End If

        cuenta_personal.ShowDialog()

    End Sub

    Private Sub btn_baja_Click(sender As Object, e As EventArgs) Handles btn_baja.Click
        Try
            foto_cara.Image.Save("C:\fotos\personal\" + lbl_clave.Text + "_frente.jpg", Drawing.Imaging.ImageFormat.Jpeg)
            MsgBox("Modificado correctamente")
        Catch ex As Exception
            MsgBox("ERROR" & ex.ToString)
        End Try

    End Sub

    Private Sub btn_activar_Click(sender As Object, e As EventArgs) Handles btn_activar.Click
        Try
            foto_cara.Image.Save("C:\fotos\personal\" + lbl_clave.Text + "_frente.jpg", Drawing.Imaging.ImageFormat.Jpeg)
            MsgBox("Modificado correctamente")
        Catch ex As Exception
            MsgBox("ERROR" & ex.ToString)
        End Try


    End Sub

    Private Sub btn_cambiar_puesto_Click(sender As Object, e As EventArgs) Handles btn_cambiar_puesto.Click
        If cmb_puesto.Text = "" Then
            MsgBox("Selecciona un puesto")

        Else
            Try
                Dim conexion_principal As New base_principal
                conexion_principal.InsertarSQL("call modifica_personal_puesto(" & lbl_clave.Text & ",'" & lbl_puesto.Text & "  " & lbl_sueldo.Text & "','" & cmb_puesto.Text & "'," & txt_sueldo.Text & ",'" & bodega & "','" & My.Computer.Name & "','" & usuario & "')")
                conexion_principal.dispose()
                Dim conexion_local As New base_local
                conexion_local.InsertarSQL("call modifica_personal_puesto(" & lbl_clave.Text & ",'" & lbl_puesto.Text & "  " & lbl_sueldo.Text & "','" & cmb_puesto.Text & "'," & txt_sueldo.Text & ",'" & bodega & "','" & My.Computer.Name & "','" & usuario & "')")
                conexion_local.dispose()
            Catch ex As Exception
                MsgBox(ex.ToString)
            End Try

        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        nuevo_personal.ShowDialog()
    End Sub



    'Private Sub bt_modificar_Click(sender As Object, e As EventArgs)
    '    foto_cara.Image.Save("C:\fotos\personal\" + lbl_clave.Text + "_frente.jpg", Drawing.Imaging.ImageFormat.Jpeg)
    '    foto_completo.Image.Save("C:\fotos\personal\" + lbl_clave.Text + "_completo.jpg", Drawing.Imaging.ImageFormat.Jpeg)
    '    bt_modificar.Visible = False
    '    bt_guardar.Visible = False
    '    bt_nuevo.Visible = True
    'End Sub

    'Private Sub bt_guardar_Click(sender As Object, e As EventArgs)
    '    Dim clave As String
    '    Dim conexion_local As New base_local
    '    Dim conexion_principal As New base_principal
    '    Try
    '        clave = conexion_principal.InsertaEscalar("call inserta_personal('" + txt_nombre.Text + "', '" + txt_calle.Text + "', '" + txt_colonia.Text + "', '" + txt_cidudad.Text + "', '" + txt_telefono.Text + "', " + txt_peso.Text + ", " + txt_estatura.Text + ", '" + txt_civil.Text + "', '" + Format(f_nac.Value, "yyyy-MM-dd") + "', '" + txt_curp.Text + "', '" + txt_nss.Text + "', '" + txt_padre.Text + "', '" + txt_madre.Text + "', '" + txt_conyuge.Text + "', " + txt_t1_tiempo.Text + ", '" + txt_t1_empresa.Text + "', '" + txt_t1_dir.Text + "', '" + txt_t1_puesto.Text + "', " + txt_t1_sueldo.Text + " ,'" + txt_t1_jefe.Text + "', '" + txt_t1_tel.Text + "', " + txt_t2_tiempo.Text + ", '" + txt_t2_empresa.Text + "', '" + txt_t2_dir.Text + "', '" + txt_t2_puesto.Text + "', " + txt_t2_sueldo.Text + ", '" + txt_t2_jefe.Text + "', '" + txt_t2_tel.Text + "', '" + txt_r1_nombre.Text + "', '" + txt_r1_dir.Text + "', '" + txt_r1_tel.Text + "', '" + txt_r1_ocupacion.Text + "', " + txt_r1_tiempo.Text + ", '" + txt_r2_nombre.Text + "', '" + txt_r2_dir.Text + "', '" + txt_r2_tel.Text + "', '" + txt_r2_ocupacion.Text + "', " + txt_r2_tiempo.Text + ", '" + bodega + "', '" + usuario + "', '" + My.Computer.Name + "')")
    '        conexion_local.InsertarSQL("call inserta_personal(" + clave + ",'" + txt_nombre.Text + "', '" + txt_calle.Text + "', '" + txt_colonia.Text + "', '" + txt_cidudad.Text + "', '" + txt_telefono.Text + "', " + txt_peso.Text + ", " + txt_estatura.Text + ", '" + txt_civil.Text + "', '" + Format(f_nac.Value, "yyyy-MM-dd") + "', '" + txt_curp.Text + "', '" + txt_nss.Text + "', '" + txt_padre.Text + "', '" + txt_madre.Text + "', '" + txt_conyuge.Text + "', " + txt_t1_tiempo.Text + ", '" + txt_t1_empresa.Text + "', '" + txt_t1_dir.Text + "', '" + txt_t1_puesto.Text + "', " + txt_t1_sueldo.Text + " ,'" + txt_t1_jefe.Text + "', '" + txt_t1_tel.Text + "', " + txt_t2_tiempo.Text + ", '" + txt_t2_empresa.Text + "', '" + txt_t2_dir.Text + "', '" + txt_t2_puesto.Text + "', " + txt_t2_sueldo.Text + ", '" + txt_t2_jefe.Text + "', '" + txt_t2_tel.Text + "', '" + txt_r1_nombre.Text + "', '" + txt_r1_dir.Text + "', '" + txt_r1_tel.Text + "', '" + txt_r1_ocupacion.Text + "', " + txt_r1_tiempo.Text + ", '" + txt_r2_nombre.Text + "', '" + txt_r2_dir.Text + "', '" + txt_r2_tel.Text + "', '" + txt_r2_ocupacion.Text + "', " + txt_r2_tiempo.Text + ", '" + bodega + "', '" + usuario + "', '" + My.Computer.Name + "')")
    '        foto_cara.Image.Save("C:\fotos\personal\" + clave + "_frente.jpg", Drawing.Imaging.ImageFormat.Jpeg)
    '        foto_completo.Image.Save("C:\fotos\personal\" + clave + "_completo.jpg", Drawing.Imaging.ImageFormat.Jpeg)
    '        MsgBox("Registro guardado con clave " + clave.ToString)
    '        bt_modificar.Visible = False
    '        bt_guardar.Visible = False
    '        bt_nuevo.Visible = True
    '        actualiza_tabla()
    '        limpiar()
    '    Catch ex As Exception
    '        MsgBox("Error al enviar datos" + ex.ToString)
    '    End Try
    '    conexion_local.dispose()
    '    conexion_principal.dispose()
    'End Sub
    'Private Sub limpiar()
    '    txt_nombre.Text = ""
    '    txt_calle.Text = ""
    '    txt_colonia.Text = ""
    '    txt_cidudad.Text = ""
    '    txt_telefono.Text = ""
    '    txt_peso.Text = "0"
    '    txt_estatura.Text = "0"
    '    txt_civil.Text = ""
    '    f_nac.Value = Now
    '    txt_curp.Text = ""
    '    txt_nss.Text = ""
    '    txt_padre.Text = ""
    '    txt_madre.Text = ""
    '    txt_conyuge.Text = ""
    '    txt_puesto.Text = ""
    '    txt_sueldo.Text = ""


    '    foto_cara.ImageLocation = "c:\fotos\personal\pon_frente.jpg"

    '    foto_completo.ImageLocation = "c:\fotos\personal\pon_completo.jpg"

    '    'trabajo anterior 1
    '    txt_t1_empresa.Text = ""
    '    txt_t1_tiempo.Text = "0"
    '    txt_t1_dir.Text = ""
    '    txt_t1_puesto.Text = ""
    '    txt_t1_sueldo.Text = "0"
    '    txt_t2_jefe.Text = ""
    '    txt_t1_tel.Text = ""

    '    'trabajo anterior 2
    '    txt_t2_empresa.Text = ""
    '    txt_t2_tiempo.Text = "0"
    '    txt_t2_dir.Text = ""
    '    txt_t2_puesto.Text = ""
    '    txt_t2_sueldo.Text = "0"
    '    txt_t2_jefe.Text = ""
    '    txt_t2_tel.Text = ""

    '    'referencia 1
    '    txt_r1_nombre.Text = ""
    '    txt_r1_tiempo.Text = "0"
    '    txt_r1_dir.Text = ""
    '    txt_r1_ocupacion.Text = ""
    '    txt_r1_tel.Text = ""

    '    'referencia2
    '    txt_r2_nombre.Text = ""
    '    txt_r2_tiempo.Text = "0"
    '    txt_r2_dir.Text = ""
    '    txt_r2_ocupacion.Text = ""
    '    txt_r2_tel.Text = ""
    'End Sub



End Class