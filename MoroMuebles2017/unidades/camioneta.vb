Public Class camioneta
    Private Sub camioneta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        carga_combos()

    End Sub
    Private Sub carga_combos()
        Dim conexion As New base_local
        cmb_tenencia.Items.Clear()
        For ano_tenencia = 0 To 20
            cmb_tenencia.Items.Add(Now.Year - ano_tenencia)
        Next
        cmb_marca.DataSource = Nothing
        conexion.llena_combo(cmb_marca, "sELECT distinct( marca) FROM unidades_camionetas order by marca")
        cmb_marca.DisplayMember = "marca"
        conexion.llena_combo(cmb_modelo, "sELECT distinct( modelo) FROM unidades_camionetas order by modelo desc")
        cmb_modelo.DisplayMember = "modelo"
        conexion.llena_combo(cmb_motor, "sELECT distinct( motor) FROM unidades_camionetas order by motor")
        cmb_motor.DisplayMember = "motor"
        conexion.llena_combo(cmb_propietario, "sELECT distinct( propietario) FROM unidades_camionetas order by propietario")
        cmb_propietario.DisplayMember = "propietario"
        conexion.llena_combo(cmb_tipo, "sELECT distinct( tipo) FROM unidades_camionetas order by tipo")
        cmb_tipo.DisplayMember = "tipo"
        conexion.llena_combo(cmb_transmicion, "sELECT distinct( transmicion) FROM unidades_camionetas order by transmicion")
        cmb_transmicion.DisplayMember = "transmicion"
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
        Dim clave_camioneta As Integer
        Try
            clave_camioneta = conexion_principal.InsertaEscalar("call inserta_camioneta('" + cmb_marca.Text + "', " + cmb_modelo.Text + ", '" + txt_serie.Text + "', '" + bodega + "', '" + cmb_motor.Text + "', '" + cmb_transmicion.Text + "', '" + cmb_tipo.Text + "', '" + txt_placa.Text + "', " + txt_precio.Text + ", '" + Format(fecha_compra.Value, "yyyy-MM-dd") + "',  0, " + cmb_chofer.SelectedValue.ToString + ", '" + txt_observaciones.Text + "', '" + cmb_propietario.Text + "','" + cmb_tenencia.Text + "', '" + My.Computer.Name + "' ,'" + usuario + "')")
            conexion_local.InsertarSQL("call inserta_camioneta(" + clave_camioneta.ToString + ", '" + cmb_marca.Text + "', " + cmb_modelo.Text + ", '" + txt_serie.Text + "', '" + bodega + "', '" + cmb_motor.Text + "', '" + cmb_transmicion.Text + "', '" + cmb_tipo.Text + "', '" + txt_placa.Text + "', " + txt_precio.Text + ", '" + Format(fecha_compra.Value, "yyyy-MM-dd") + "',  0, " + cmb_chofer.SelectedValue.ToString + ", '" + txt_observaciones.Text + "', '" + cmb_propietario.Text + "','" + cmb_tenencia.Text + "', '" + My.Computer.Name + "' ,'" + usuario + "')")
            MsgBox("Alta correcta")
        Catch ex As Exception
            MsgBox("Error: " + ex.ToString)
        End Try
        conexion_local.dispose()
        conexion_principal.dispose()
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

    End Sub


End Class