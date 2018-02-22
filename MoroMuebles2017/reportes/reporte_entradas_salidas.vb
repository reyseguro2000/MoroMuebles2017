Public Class reporte_entradas_salidas
    Dim salidas, entradas As Integer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        txt_fecha_fin.Text = Now
        entra_sale()

    End Sub

    Private Sub reporte_entradas_salidas_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        Dim conexion_local As New base_local
        conexion_local.llena_tabla(dg_reportes_anteriores, "select id_reportes as Reporte, Inicio, Fin from reportes order by reporte")
        txt_fecha_ini.Text = dg_reportes_anteriores.Item("inicio", 0).Value
        txt_fecha_fin.Text = dg_reportes_anteriores.Item("fin", 0).Value
        conexion_local.dispose()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            Me.PrintDocument1.PrinterSettings = Me.PrintDialog1.PrinterSettings
            entradas = 0
            salidas = 0
            Me.PrintDocument1.Print()
        End If
    End Sub

    Private Sub PrintDocument1_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fuente12 As New Font("Arial", 12, FontStyle.Bold)
        Dim fuente18 As New Font("Arial", 16, FontStyle.Bold)
        Dim fuente10 As New Font("Arial", 10, FontStyle.Bold)
        Dim fuente8 As New Font("Arial", 8, FontStyle.Bold)

        Dim x, y As Integer
        y = 10

        e.Graphics.DrawImage(Me.PictureBox2.Image, 5, 5, 40, 40)
        e.Graphics.DrawString("REPORTE DE ENTRADA-SALIDA DE MERCANCIA DEL " + txt_fecha_ini.Text + " AL " + txt_fecha_fin.Text, fuente12, Brushes.Black, x + 100, y + 10)
        y = 30
        If entradas < Me.dg_entradas.RowCount - 1 Then
            e.Graphics.DrawString("ENTRADAS", fuente12, Brushes.Black, 250, y + 10)
        Else
            e.Graphics.DrawString("SALIDAS", fuente12, Brushes.Black, 250, y + 10)
        End If
        y = 50
        e.Graphics.DrawString("TIPO", fuente12, Brushes.Black, 20, y + 10)
        e.Graphics.DrawString("FOLIO", fuente12, Brushes.Black, 80, y + 10)
        e.Graphics.DrawString("CANT", fuente12, Brushes.Black, 200, y + 10)
        e.Graphics.DrawString("ARTICULO", fuente12, Brushes.Black, 270, y + 10)
        e.Graphics.DrawString("FECHA", fuente12, Brushes.Black, 600, y + 10)
        While entradas < Me.dg_entradas.RowCount
            y = y + 15
            e.Graphics.DrawLine(Pens.Black, 10, y + 11, 700, y + 11)
            e.Graphics.DrawString(Me.dg_entradas.Item("tipo", entradas).Value, fuente10, Brushes.Black, 20, y + 10)
            e.Graphics.DrawString(Me.dg_entradas.Item("FOLIO", entradas).Value, fuente10, Brushes.Black, 80, y + 10)
            e.Graphics.DrawString(Me.dg_entradas.Item("CANTIDAD", entradas).Value, fuente10, Brushes.Black, 200, y + 10)
            e.Graphics.DrawString(Me.dg_entradas.Item("ARTICULO", entradas).Value, fuente10, Brushes.Black, 270, y + 10)
            e.Graphics.DrawString(Format(Me.dg_entradas.Item("FECHA", entradas).Value, "dd-MM-yyyy"), fuente10, Brushes.Black, 600, y + 10)
            entradas = entradas + 1
            If y > 1000 Then
                e.HasMorePages = True
                GoTo fin
            End If
        End While
        If salidas = 0 Then
            y = y + 20
            e.Graphics.DrawString("SALIDAS", fuente12, Brushes.Black, 250, y + 10)
            y = y + 20
            e.Graphics.DrawString("TIPO", fuente12, Brushes.Black, 20, y + 10)
            e.Graphics.DrawString("FOLIO", fuente12, Brushes.Black, 80, y + 10)
            e.Graphics.DrawString("CANT", fuente12, Brushes.Black, 200, y + 10)
            e.Graphics.DrawString("ARTICULO", fuente12, Brushes.Black, 270, y + 10)
            e.Graphics.DrawString("FECHA", fuente12, Brushes.Black, 600, y + 10)
        End If
        While salidas < Me.dg_salidas.RowCount
            y = y + 15
            e.Graphics.DrawLine(Pens.Black, 10, y + 11, 700, y + 11)
            e.Graphics.DrawString(Me.dg_salidas.Item("tipo", salidas).Value, fuente10, Brushes.Black, 20, y + 10)
            e.Graphics.DrawString(Me.dg_salidas.Item("FOLIO", salidas).Value, fuente10, Brushes.Black, 80, y + 10)
            e.Graphics.DrawString(Me.dg_salidas.Item("CANTIDAD", salidas).Value, fuente10, Brushes.Black, 200, y + 10)
            e.Graphics.DrawString(Me.dg_salidas.Item("ARTICULO", salidas).Value, fuente10, Brushes.Black, 270, y + 10)
            e.Graphics.DrawString(Format(Me.dg_salidas.Item("FECHA", salidas).Value, "dd-MM-yyyy"), fuente10, Brushes.Black, 600, y + 10)
            salidas = salidas + 1
            If y > 1000 Then
                e.HasMorePages = True
                GoTo fin
            End If
        End While

fin:

    End Sub

    Private Sub dg_reportes_anteriores_DoubleClick(sender As Object, e As EventArgs) Handles dg_reportes_anteriores.DoubleClick
        txt_fecha_ini.Text = dg_reportes_anteriores.Item("inicio", 0).Value
        txt_fecha_fin.Text = dg_reportes_anteriores.Item("fin", 0).Value
        entra_sale()
    End Sub
    Private Sub entra_sale()
        Dim conexion_local As New base_local
        Dim f_i, f_f As Date
        f_i = txt_fecha_ini.Text
        f_f = txt_fecha_fin.Text
        conexion_local.llena_tabla(dg_entradas, "select * from entradas where fecha between '" & Format(f_i, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(f_f, "yyyy-MM-dd HH:mm:ss") & "' order by fecha")
        conexion_local.llena_tabla(dg_salidas, "select * from salidas where fecha between '" & Format(f_i, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(f_f, "yyyy-MM-dd HH:mm:ss") & "' order by fecha")

        conexion_local.llena_tabla(dg_ingresos, "select * from ingresos where fecha between '" & Format(f_i, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(f_f, "yyyy-MM-dd HH:mm:ss") & "' order by fecha")
        conexion_local.llena_tabla(dg_egresos, "select * from egresos where fecha between '" & Format(f_i, "yyyy-MM-dd HH:mm:ss") & "' and '" & Format(f_f, "yyyy-MM-dd HH:mm:ss") & "' order by fecha")
        conexion_local.dispose()
    End Sub
End Class