Public Class configuracion
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        Dim conexion_configura As New base_local

        conexion_configura.InsertarSQL("update usuarios set fondo='" & color_fondo_sel.BackColor.Name & "', texto='" & color_text_sel.BackColor.Name & "', l1='" & color_L1_sel.BackColor.Name & "', L2='" & color_L2_sel.BackColor.Name & "', l3='" & color_fondo_sel.BackColor.Name & "' where usuario='" & usuario & "'")
        conexion_configura.dispose()
        'Principal.Defa = color_fondo_sel.BackColor
    End Sub



    Private Sub color_fondo_sel_DoubleClick(sender As Object, e As EventArgs) Handles color_fondo_sel.DoubleClick

        ColorSeleccion.ShowDialog()
        Me.BackColor = ColorSeleccion.Color
        color_fondo_sel.BackColor = ColorSeleccion.Color

    End Sub


    Private Sub color_text_sel_DoubleClick(sender As Object, e As EventArgs) Handles color_text_sel.DoubleClick
        ColorSeleccion.ShowDialog()
        Me.ForeColor = ColorSeleccion.Color
        color_text_sel.BackColor = ColorSeleccion.Color
    End Sub

    Private Sub color_L1_sel_DoubleClick(sender As Object, e As EventArgs) Handles color_L1_sel.DoubleClick
        ColorSeleccion.ShowDialog()
        Me.ForeColor = ColorSeleccion.Color
        color_L1_sel.BackColor = ColorSeleccion.Color
    End Sub

    Private Sub color_L2_sel_DoubleClick(sender As Object, e As EventArgs) Handles color_L2_sel.DoubleClick
        ColorSeleccion.ShowDialog()
        Me.ForeColor = ColorSeleccion.Color
        color_L2_sel.BackColor = ColorSeleccion.Color
    End Sub

    Private Sub color_L3_sel_DoubleClick(sender As Object, e As EventArgs) Handles color_L3_sel.DoubleClick
        ColorSeleccion.ShowDialog()
        Me.ForeColor = ColorSeleccion.Color
        color_L3_sel.BackColor = ColorSeleccion.Color
    End Sub

    Private Sub configuracion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.FromName(usuario_fondo)
        Me.ForeColor = Color.FromName(usuario_texto)

        color_fondo_sel.BackColor = Color.FromName(usuario_fondo)
        color_text_sel.BackColor = Color.FromName(usuario_texto)
        color_L1_sel.BackColor = Color.FromName(usuario_l1)
        color_L2_sel.BackColor = Color.FromName(usuario_l2)
        color_L3_sel.BackColor = Color.FromName(usuario_l3)

    End Sub
End Class