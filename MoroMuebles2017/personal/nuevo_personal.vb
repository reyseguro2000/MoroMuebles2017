Public Class nuevo_personal
    Private Sub bt_guardar_Click(sender As Object, e As EventArgs) Handles bt_guardar.Click
        Dim clave As String
        Dim conexion_local As New base_local
        Dim conexion_principal As New base_principal
        Try
            clave = conexion_principal.InsertaEscalar("call inserta_personal('" + txt_nombre.Text + "', '" + txt_calle.Text + "', '" + txt_colonia.Text + "', '" + txt_cidudad.Text + "', '" + txt_telefono.Text + "', " + txt_peso.Text + ", " + txt_estatura.Text + ", '" + txt_civil.Text + "', '" + Format(f_nac.Value, "yyyy-MM-dd") + "', '" + txt_curp.Text + "', '" + txt_nss.Text + "', '" + txt_padre.Text + "', '" + txt_madre.Text + "', '" + txt_conyuge.Text + "', " + txt_t1_tiempo.Text + ", '" + txt_t1_empresa.Text + "', '" + txt_t1_dir.Text + "', '" + txt_t1_puesto.Text + "', " + txt_t1_sueldo.Text + " ,'" + txt_t1_jefe.Text + "', '" + txt_t1_tel.Text + "', " + txt_t2_tiempo.Text + ", '" + txt_t2_empresa.Text + "', '" + txt_t2_dir.Text + "', '" + txt_t2_puesto.Text + "', " + txt_t2_sueldo.Text + ", '" + txt_t2_jefe.Text + "', '" + txt_t2_tel.Text + "', '" + txt_r1_nombre.Text + "', '" + txt_r1_dir.Text + "', '" + txt_r1_tel.Text + "', '" + txt_r1_ocupacion.Text + "', " + txt_r1_tiempo.Text + ", '" + txt_r2_nombre.Text + "', '" + txt_r2_dir.Text + "', '" + txt_r2_tel.Text + "', '" + txt_r2_ocupacion.Text + "', " + txt_r2_tiempo.Text + ", '" + bodega + "', '" + usuario + "', '" + My.Computer.Name + "')")
            conexion_local.InsertarSQL("call inserta_personal(" + clave + ",'" + txt_nombre.Text + "', '" + txt_calle.Text + "', '" + txt_colonia.Text + "', '" + txt_cidudad.Text + "', '" + txt_telefono.Text + "', " + txt_peso.Text + ", " + txt_estatura.Text + ", '" + txt_civil.Text + "', '" + Format(f_nac.Value, "yyyy-MM-dd") + "', '" + txt_curp.Text + "', '" + txt_nss.Text + "', '" + txt_padre.Text + "', '" + txt_madre.Text + "', '" + txt_conyuge.Text + "', " + txt_t1_tiempo.Text + ", '" + txt_t1_empresa.Text + "', '" + txt_t1_dir.Text + "', '" + txt_t1_puesto.Text + "', " + txt_t1_sueldo.Text + " ,'" + txt_t1_jefe.Text + "', '" + txt_t1_tel.Text + "', " + txt_t2_tiempo.Text + ", '" + txt_t2_empresa.Text + "', '" + txt_t2_dir.Text + "', '" + txt_t2_puesto.Text + "', " + txt_t2_sueldo.Text + ", '" + txt_t2_jefe.Text + "', '" + txt_t2_tel.Text + "', '" + txt_r1_nombre.Text + "', '" + txt_r1_dir.Text + "', '" + txt_r1_tel.Text + "', '" + txt_r1_ocupacion.Text + "', " + txt_r1_tiempo.Text + ", '" + txt_r2_nombre.Text + "', '" + txt_r2_dir.Text + "', '" + txt_r2_tel.Text + "', '" + txt_r2_ocupacion.Text + "', " + txt_r2_tiempo.Text + ", '" + bodega + "', '" + usuario + "', '" + My.Computer.Name + "')")
            foto_cara.Image.Save("C:\fotos\personal\" + clave + "_frente.jpg", Drawing.Imaging.ImageFormat.Jpeg)
            foto_completo.Image.Save("C:\fotos\personal\" + clave + "_completo.jpg", Drawing.Imaging.ImageFormat.Jpeg)
            MsgBox("Registro guardado con clave " + clave.ToString)
            bt_modificar.Visible = False
            bt_guardar.Visible = False
            'bt_nuevo.Visible = True
            'actualiza_tabla()
            limpiar()
        Catch ex As Exception
            MsgBox("Error al enviar datos" + ex.ToString)
        End Try
        conexion_local.dispose()
        conexion_principal.dispose()
        Me.Dispose()
    End Sub

    Private Sub bt_modificar_Click(sender As Object, e As EventArgs) Handles bt_modificar.Click
        foto_cara.Image.Save("C:\fotos\personal\" + lbl_clave.Text + "_frente.jpg", Drawing.Imaging.ImageFormat.Jpeg)
        foto_completo.Image.Save("C:\fotos\personal\" + lbl_clave.Text + "_completo.jpg", Drawing.Imaging.ImageFormat.Jpeg)
        Try
            'Dim conexion_principal As New base_principal
            'conexion_principal.InsertarSQL("call modifica_personal_puesto(" & lbl_clave.Text & ",'" & lbl_puesto.Text & "  " & lbl_sueldo.Text & "','" & cmb_puesto.Text & "'," & txt_sueldo.Text & ",'" & bodega & "','" & My.Computer.Name & "','" & usuario & "')")
            'conexion_principal.dispose()
            'Dim conexion_local As New base_local
            'conexion_local.InsertarSQL("call modifica_personal_puesto(" & lbl_clave.Text & ",'" & lbl_puesto.Text & "  " & lbl_sueldo.Text & "','" & cmb_puesto.Text & "'," & txt_sueldo.Text & ",'" & bodega & "','" & My.Computer.Name & "','" & usuario & "')")
            'conexion_local.dispose()
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
        Me.Dispose()
        'bt_nuevo.Visible = True
    End Sub
    Private Sub limpiar()
        txt_nombre.Text = ""
        txt_calle.Text = ""
        txt_colonia.Text = ""
        txt_cidudad.Text = ""
        txt_telefono.Text = ""
        txt_peso.Text = "0"
        txt_estatura.Text = "0"
        txt_civil.Text = ""
        f_nac.Value = Now
        txt_curp.Text = ""
        txt_nss.Text = ""
        txt_padre.Text = ""
        txt_madre.Text = ""
        txt_conyuge.Text = ""
        txt_puesto.Text = ""
        txt_sueldo.Text = ""


        foto_cara.ImageLocation = "c:\fotos\personal\pon_frente.jpg"

        foto_completo.ImageLocation = "c:\fotos\personal\pon_completo.jpg"

        'trabajo anterior 1
        txt_t1_empresa.Text = ""
        txt_t1_tiempo.Text = "0"
        txt_t1_dir.Text = ""
        txt_t1_puesto.Text = ""
        txt_t1_sueldo.Text = "0"
        txt_t2_jefe.Text = ""
        txt_t1_tel.Text = ""

        'trabajo anterior 2
        txt_t2_empresa.Text = ""
        txt_t2_tiempo.Text = "0"
        txt_t2_dir.Text = ""
        txt_t2_puesto.Text = ""
        txt_t2_sueldo.Text = "0"
        txt_t2_jefe.Text = ""
        txt_t2_tel.Text = ""

        'referencia 1
        txt_r1_nombre.Text = ""
        txt_r1_tiempo.Text = "0"
        txt_r1_dir.Text = ""
        txt_r1_ocupacion.Text = ""
        txt_r1_tel.Text = ""

        'referencia2
        txt_r2_nombre.Text = ""
        txt_r2_tiempo.Text = "0"
        txt_r2_dir.Text = ""
        txt_r2_ocupacion.Text = ""
        txt_r2_tel.Text = ""
    End Sub

    Private Sub nuevo_personal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub
End Class