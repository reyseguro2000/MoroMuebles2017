Public Class moto
    Private Sub carga_combos()
        Dim conexion As New base_local
        cmb_tenencia.Items.Clear()
        For ano_tenencia = 0 To 20
            cmb_tenencia.Items.Add(Now.Year - ano_tenencia)
        Next
        cmb_marca.DataSource = Nothing
        conexion.llena_combo(cmb_marca, "sELECT distinct( marca) FROM unidades_MOTOS order by marca")
        cmb_marca.DisplayMember = "marca"
        conexion.llena_combo(cmb_modelo, "sELECT distinct( modelo) FROM unidades_motos order by modelo desc")
        cmb_modelo.DisplayMember = "modelo"
        conexion.llena_combo(cmb_propietario, "sELECT distinct( propietario) FROM unidades_motos order by propietario")
        cmb_propietario.DisplayMember = "propietario"
        conexion.llena_combo(cmb_chofer, "sELECT clave, nombre FROM personal order by nombre")
        cmb_chofer.DisplayMember = "nombre"
        cmb_chofer.ValueMember = "clave"
        'conexion.llena_combo(cmb_poliza, "sELECT distinct( transmicion) FROM polizas order by transmicion")
        'cmb_poliza.DisplayMember = "nombre"
        'cmb_poliza.ValueMember = "clave"
        conexion.dispose()
    End Sub
    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        Dim conexion_local As New base_local
        Dim conexion_principal As New base_principal
        Dim clave_moto As Integer
        Try
            clave_moto = conexion_principal.InsertaEscalar("call inserta_moto('" + cmb_marca.Text + "', " + cmb_modelo.Text + ", '" + txt_serie.Text + "', '" + bodega + "', '" + txt_placa.Text + "', " + txt_precio.Text + ", '" + Format(fecha_compra.Value, "yyyy-MM-dd") + "'," + cmb_chofer.SelectedValue.ToString + ", '" + txt_observaciones.Text + "', '" + cmb_propietario.Text + "','" + cmb_tenencia.Text + "', '" + My.Computer.Name + "' ,'" + usuario + "')")
            conexion_local.InsertarSQL("call inserta_moto(" + clave_moto.ToString + ", '" + cmb_marca.Text + "', " + cmb_modelo.Text + ", '" + txt_serie.Text + "', '" + bodega + "', '" + txt_placa.Text + "', " + txt_precio.Text + ", '" + Format(fecha_compra.Value, "yyyy-MM-dd") + "', " + cmb_chofer.SelectedValue.ToString + ", '" + txt_observaciones.Text + "', '" + cmb_propietario.Text + "','" + cmb_tenencia.Text + "', '" + My.Computer.Name + "' ,'" + usuario + "')")
            MsgBox("Alta correcta")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
        conexion_local.dispose()
        conexion_principal.dispose()
    End Sub

    Private Sub moto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga_combos()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

    End Sub
End Class