Public Class Entrada_repetida
    Private Sub Entrada_repetida_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As New base_local
        conexion.llena_tabla(dgv_repetidos, "select cantidad,articulos.articulo,costo from entradas_fabrica_d,articulos where entradas_fabrica_d.articulo=clave and folio_c ='" + lbl_clave_provedor.Text + "-" + lbl_folio.Text.ToString + "'")
        conexion.dispose()
    End Sub
End Class