Public Class lista_precios_12meses
    Dim p, y, i As Integer
    Dim da As New Odbc.OdbcDataAdapter
    Dim dt As DataTable
    Dim x1 As Integer

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        llenar()
    End Sub
    Private Sub llenar()
        Dim conexion As New base_local
        Dim costo As Integer
        conexion.llena_tabla(t_articulos, "select * from articulos order by articulo")
        conexion.dispose()
        Me.DataGridView1.Rows.Clear()



        For filia_precio As Integer = 0 To t_articulos.RowCount - 1
            Me.DataGridView1.Rows.Add()
            Me.DataGridView1.Item("clave", Me.DataGridView1.RowCount - 1).Value = t_articulos.Item("clave", filia_precio).Value
            Me.DataGridView1.Item("articulo", Me.DataGridView1.RowCount - 1).Value = t_articulos.Item("articulo", filia_precio).Value
            costo = t_articulos.Item("precio", filia_precio).Value

            If t_articulos.Item("formula", filia_precio).Value = "1" Then
                Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l1c.Text) / 100)) + 0.5) 'CONTADO
                Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l11.Text) / 100)) + 0.5) '1
                Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l12.Text) / 100)) + 0.5) '2
                Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l13.Text) / 100)) + 0.5) '3
                Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l14.Text) / 100)) + 0.5) '4
                Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l15.Text) / 100)) + 0.5) '5
                Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l16.Text) / 100)) + 0.5) '6
                Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l17.Text) / 100)) + 0.5) '7
                Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l18.Text) / 100)) + 0.5) '8
                Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l19.Text) / 100)) + 0.5) '9
                Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l110.Text) / 100)) + 0.5) '10
                Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l111.Text) / 100)) + 0.5) '11
                Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l112.Text) / 100)) + 0.5) '12
                Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l1com.Text) / 100)) + 0.5)
                Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = costo


            ElseIf t_articulos.Item("formula", filia_precio).Value = "2" Then
                Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l2c.Text) / 100)) + 0.5) 'CONTADO
                Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l21.Text) / 100)) + 0.5) '1
                Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l22.Text) / 100)) + 0.5) '2
                Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l23.Text) / 100)) + 0.5) '3
                Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l24.Text) / 100)) + 0.5) '4
                Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l25.Text) / 100)) + 0.5) '5
                Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l26.Text) / 100)) + 0.5) '6
                Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l27.Text) / 100)) + 0.5) '7
                Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l28.Text) / 100)) + 0.5) '8
                Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l29.Text) / 100)) + 0.5) '9
                Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l210.Text) / 100)) + 0.5) '10
                Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l211.Text) / 100)) + 0.5) '11
                Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l212.Text) / 100)) + 0.5) '12
                Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l2com.Text) / 100)) + 0.5)
                Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = costo



            ElseIf t_articulos.Item("formula", filia_precio).Value = "3" Then
                Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l3c.Text) / 100)) + 0.5) 'CONTADO
                Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l31.Text) / 100)) + 0.5) '1
                Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l32.Text) / 100)) + 0.5) '2
                Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l33.Text) / 100)) + 0.5) '3
                Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l34.Text) / 100)) + 0.5) '4
                Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l35.Text) / 100)) + 0.5) '5
                Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l36.Text) / 100)) + 0.5) '6
                Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l37.Text) / 100)) + 0.5) '7
                Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l38.Text) / 100)) + 0.5) '8
                Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l39.Text) / 100)) + 0.5) '9
                Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l310.Text) / 100)) + 0.5) '10
                Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l311.Text) / 100)) + 0.5) '11
                Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(costo + (costo * (Val(Me.l312.Text) / 100)) + 0.5) '12
                Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l3com.Text) / 100)) + 0.5)
                Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = costo

            End If

            Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((costo + (costo * 0.12)) + 0.5)

        Next
        'If lector.Item("formula") = "1" Then
        '    Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l1c.Text) / 100)) + 0.5) 'CONTADO
        '    Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l11.Text) / 100)) + 0.5) '1
        '    Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l12.Text) / 100)) + 0.5) '2
        '    Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l13.Text) / 100)) + 0.5) '3
        '    Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l14.Text) / 100)) + 0.5) '4
        '    Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l15.Text) / 100)) + 0.5) '5
        '    Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l16.Text) / 100)) + 0.5) '6
        '    Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l17.Text) / 100)) + 0.5) '7
        '    Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l18.Text) / 100)) + 0.5) '8
        '    Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l19.Text) / 100)) + 0.5) '9
        '    Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l110.Text) / 100)) + 0.5) '10
        '    Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l111.Text) / 100)) + 0.5) '11
        '    Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l112.Text) / 100)) + 0.5) '12
        '    Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l1com.Text) / 100)) + 0.5)
        '    Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = lector.Item("precio")


        'ElseIf lector.Item("formula") = "2" Then
        '    Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l2c.Text) / 100)) + 0.5) 'CONTADO
        '    Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l21.Text) / 100)) + 0.5) '1
        '    Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l22.Text) / 100)) + 0.5) '2
        '    Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l23.Text) / 100)) + 0.5) '3
        '    Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l24.Text) / 100)) + 0.5) '4
        '    Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l25.Text) / 100)) + 0.5) '5
        '    Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l26.Text) / 100)) + 0.5) '6
        '    Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l27.Text) / 100)) + 0.5) '7
        '    Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l28.Text) / 100)) + 0.5) '8
        '    Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l29.Text) / 100)) + 0.5) '9
        '    Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l210.Text) / 100)) + 0.5) '10
        '    Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l211.Text) / 100)) + 0.5) '11
        '    Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l212.Text) / 100)) + 0.5) '12
        '    Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l2com.Text) / 100)) + 0.5)
        '    Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = lector.Item("precio")



        'ElseIf lector.Item("formula") = "3" Then
        '    Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l3c.Text) / 100)) + 0.5) 'CONTADO
        '    Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l31.Text) / 100)) + 0.5) '1
        '    Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l32.Text) / 100)) + 0.5) '2
        '    Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l33.Text) / 100)) + 0.5) '3
        '    Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l34.Text) / 100)) + 0.5) '4
        '    Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l35.Text) / 100)) + 0.5) '5
        '    Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l36.Text) / 100)) + 0.5) '6
        '    Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l37.Text) / 100)) + 0.5) '7
        '    Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l38.Text) / 100)) + 0.5) '8
        '    Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l39.Text) / 100)) + 0.5) '9
        '    Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l310.Text) / 100)) + 0.5) '10
        '    Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l311.Text) / 100)) + 0.5) '11
        '    Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l312.Text) / 100)) + 0.5) '12
        '    Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l3com.Text) / 100)) + 0.5)
        '    Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = lector.Item("precio")



        '    Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item("precio") + (lector.Item("precio") * 0.12)) + 0.5)


        '        cad_con = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=MSM;DATABASE=catalogo;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"
        'cad_con = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=MSM;DATABASE=catalogo;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"

        'coneccion = New Odbc.OdbcConnection
        'coneccion.ConnectionString = cad_con
        'coneccion.Open()

        ''comando = New Odbc.OdbcCommand("select articulos.clave,articulo,precio,formula,mayoreo,actopan,general,mashogar,evento from articulos,precios where articulos.clave=precios.clave and (articulos.clave like '47-%' or articulos.clave like '48-%')  order by articulos.clave", coneccion)
        'comando = New Odbc.OdbcCommand("select articulos.clave,articulo,precio,formula,mayoreo,actopan,general,mashogar,evento from articulos,precios where articulos.clave=precios.clave and activo='A' order by articulos.ARTICULO", coneccion)
        'lector = comando.ExecuteReader
        'While lector.Read

        '    If lector.Item("general") = "1" Then
        '        Me.DataGridView1.Rows.Add()
        '        Me.DataGridView1.Item("clave", Me.DataGridView1.RowCount - 1).Value = lector.Item("clave")
        '        Me.DataGridView1.Item("articulo", Me.DataGridView1.RowCount - 1).Value = lector.Item("articulo")


        '        If lector.Item("formula") = "1" Then
        '            Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l1c.Text) / 100)) + 0.5) 'CONTADO
        '            Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l11.Text) / 100)) + 0.5) '1
        '            Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l12.Text) / 100)) + 0.5) '2
        '            Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l13.Text) / 100)) + 0.5) '3
        '            Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l14.Text) / 100)) + 0.5) '4
        '            Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l15.Text) / 100)) + 0.5) '5
        '            Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l16.Text) / 100)) + 0.5) '6
        '            Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l17.Text) / 100)) + 0.5) '7
        '            Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l18.Text) / 100)) + 0.5) '8
        '            Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l19.Text) / 100)) + 0.5) '9
        '            Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l110.Text) / 100)) + 0.5) '10
        '            Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l111.Text) / 100)) + 0.5) '11
        '            Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l112.Text) / 100)) + 0.5) '12
        '            Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l1com.Text) / 100)) + 0.5)
        '            Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = lector.Item("precio")


        '        ElseIf lector.Item("formula") = "2" Then
        '            Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l2c.Text) / 100)) + 0.5) 'CONTADO
        '            Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l21.Text) / 100)) + 0.5) '1
        '            Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l22.Text) / 100)) + 0.5) '2
        '            Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l23.Text) / 100)) + 0.5) '3
        '            Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l24.Text) / 100)) + 0.5) '4
        '            Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l25.Text) / 100)) + 0.5) '5
        '            Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l26.Text) / 100)) + 0.5) '6
        '            Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l27.Text) / 100)) + 0.5) '7
        '            Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l28.Text) / 100)) + 0.5) '8
        '            Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l29.Text) / 100)) + 0.5) '9
        '            Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l210.Text) / 100)) + 0.5) '10
        '            Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l211.Text) / 100)) + 0.5) '11
        '            Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l212.Text) / 100)) + 0.5) '12
        '            Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l2com.Text) / 100)) + 0.5)
        '            Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = lector.Item("precio")



        '        ElseIf lector.Item("formula") = "3" Then
        '            Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l3c.Text) / 100)) + 0.5) 'CONTADO
        '            Me.DataGridView1.Item("M1", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l31.Text) / 100)) + 0.5) '1
        '            Me.DataGridView1.Item("M2", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l32.Text) / 100)) + 0.5) '2
        '            Me.DataGridView1.Item("M3", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l33.Text) / 100)) + 0.5) '3
        '            Me.DataGridView1.Item("M4", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l34.Text) / 100)) + 0.5) '4
        '            Me.DataGridView1.Item("M5", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l35.Text) / 100)) + 0.5) '5
        '            Me.DataGridView1.Item("M6", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l36.Text) / 100)) + 0.5) '6
        '            Me.DataGridView1.Item("M7", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l37.Text) / 100)) + 0.5) '7
        '            Me.DataGridView1.Item("M8", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l38.Text) / 100)) + 0.5) '8
        '            Me.DataGridView1.Item("M9", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l39.Text) / 100)) + 0.5) '9
        '            Me.DataGridView1.Item("M10", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l310.Text) / 100)) + 0.5) '10
        '            Me.DataGridView1.Item("M11", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l311.Text) / 100)) + 0.5) '11
        '            Me.DataGridView1.Item("M12", Me.DataGridView1.RowCount - 1).Value = Int(lector.Item("precio") + (lector.Item("precio") * (Val(Me.l312.Text) / 100)) + 0.5) '12
        '            Me.DataGridView1.Item("comicion", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.l3com.Text) / 100)) + 0.5)
        '            Me.DataGridView1.Item("costo", Me.DataGridView1.RowCount - 1).Value = lector.Item("precio")



        '            Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item("precio") + (lector.Item("precio") * 0.12)) + 0.5)

        '        End If

        '        If lector.Item("mayoreo") = "1" Then
        '            If Mid(lector.Item(0), 1, 2) <> "10" Then




        '                'octavio

        '                'Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item(2) + (lector.Item(2) * 0.065)) + 0.5)



        '                'If Mid(lector.Item("clave"), 1, 2) = "33" Then Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item(2) + (lector.Item(2) * 0.1)) + 0.5)
        '                'If Mid(lector.Item("clave"), 1, 2) = "1-" Then Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item(2) + (lector.Item(2) * 0.1)) + 0.5)


        '                ''normal()
        '                'If Mid(lector.Item("clave"), 1, 2) <> "33" And Mid(lector.Item(0), 1, 2) <> "1-" And Mid(lector.Item(0), 1, 2) <> "10" Then Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item("precio") + (lector.Item("precio") * 0.12)) + 0.5)


        '                ''para actopan
        '                ' If Mid(lector.Item("clave"), 1, 2) = "4-" Then Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item(2) + (lector.Item(2) * 0.17)) + 0.5)
        '                'If Mid(lector.Item("clave"), 1, 2) <> "33" And Mid(lector.Item(0), 1, 2) <> "4-" And Mid(lector.Item(0), 1, 2) <> "1-" And Mid(lector.Item(0), 1, 2) <> "10" Then Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = Int((lector.Item("precio") + (lector.Item("precio") * 0.12)) + 0.5)


        '            Else
        '                Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = 0
        '            End If
        '        Else
        '            Me.DataGridView1.Item("pmayoreo", Me.DataGridView1.RowCount - 1).Value = 0
        '        End If






        '        If lector.Item("evento") = "1" Then

        '            'Me.DataGridView1.Item(11, Me.DataGridView1.RowCount - 1).Value = 1
        '            Me.DataGridView1.Item("descuento", Me.DataGridView1.RowCount - 1).Value = Int((Me.DataGridView1.Item("contado", Me.DataGridView1.RowCount - 1).Value * (Val(Me.desc.Text) / 100)) + 0.5) '12
        '        Else
        '            Me.DataGridView1.Item("descuento", Me.DataGridView1.RowCount - 1).Value = 0 '12
        '        End If

        '        'Me.DataGridView1.Item(12, Me.DataGridView1.RowCount - 1).Value = lector.Item(2)
        '    End If

        ' End While
        conexion.dispose()

    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click


        p = 1
        y = 0
        i = 0

        If Me.PrintDialog1.ShowDialog() = DialogResult.OK Then
            '  Me.menudeo.PrinterSettings.DefaultPageSettings.Landscape = True
            Me.menudeo.PrinterSettings = Me.PrintDialog1.PrinterSettings
            'Me.menudeo.PrinterSettings.DefaultPageSettings.Landscape = True
            Me.menudeo.DefaultPageSettings.Landscape = True
            menudeo.Print()
        End If

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click

        p = 1
        y = 0
        i = 0
        If Me.PrintDialog1.ShowDialog() = DialogResult.OK Then
            Me.mayoreo.PrinterSettings = Me.PrintDialog1.PrinterSettings
            Me.mayoreo.PrinterSettings.DefaultPageSettings.Landscape = False
            mayoreo.Print()

        End If
    End Sub
    Private Sub menudeo_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles menudeo.PrintPage
        e.PageSettings.Landscape = True
        Dim Fuente As New System.Drawing.Font("Arial", 9)
        Dim Fuente1 As New System.Drawing.Font("Arial", 11)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        x1 = -50
        Me.menudeo.PrinterSettings.DefaultPageSettings.Landscape = True
        Me.menudeo.DefaultPageSettings.Landscape = True
        If p = 1 Then
            Grafico.DrawImage(Me.PictureBox1.Image, 65, 5, 300, 60)
            'If promo = "" Then
            '    Grafico.DrawString("LISTA DE PRECIOS  " + Format(Now, "dd-MM-yyyy"), Fuente, Brushes.Black, 350, 10)
            'Else
            '    Grafico.DrawString("LISTA DE PRECIOS  " + promo, Fuente, Brushes.Black, 350, 10)
            'End If
            y = 100

        Else
            y = 50
        End If
        'y = 50
        'y = 90
        'y = 40

        'Grafico.DrawString("PRECIOS RUTA RUBEN", Fuente, Brushes.Black, 600, 10)

        Grafico.DrawString("Clave", Fuente, Brushes.Black, 60, y - 20)
        Grafico.DrawString("Articulo", Fuente, Brushes.Black, 110, y - 20)
        Grafico.DrawString("RC", Fuente, Brushes.Black, 420 + x1, y - 20)
        Grafico.DrawString("C1", Fuente, Brushes.Black, 470 + x1, y - 20)
        Grafico.DrawString("2", Fuente, Brushes.Black, 520 + x1, y - 20)
        Grafico.DrawString("3", Fuente, Brushes.Black, 570 + x1, y - 20)
        Grafico.DrawString("4", Fuente, Brushes.Black, 620 + x1, y - 20)
        Grafico.DrawString("5", Fuente, Brushes.Black, 670 + x1, y - 20)
        Grafico.DrawString("6", Fuente, Brushes.Black, 720 + x1, y - 20)
        Grafico.DrawString("7", Fuente, Brushes.Black, 770 + x1, y - 20)
        Grafico.DrawString("8", Fuente, Brushes.Black, 820 + x1, y - 20)
        Grafico.DrawString("9", Fuente, Brushes.Black, 870 + x1, y - 20)
        Grafico.DrawString("10", Fuente, Brushes.Black, 920 + x1, y - 20)
        Grafico.DrawString("11", Fuente, Brushes.Black, 970 + x1, y - 20)
        Grafico.DrawString("12", Fuente, Brushes.Black, 1020 + x1, y - 20)
        Grafico.DrawString("COM", Fuente, Brushes.Black, 1070 + x1, y - 20)
        'Grafico.DrawString("DESCUENTO POR ", Fuente1, Brushes.Black, 900, y - 40)
        'Grafico.DrawString("REMATE", Fuente, Brushes.Black, 870, y - 20)
        'Grafico.DrawString("OFERTA", Fuente, Brushes.Black, 940, y - 20)
        'Grafico.DrawString("PAQUETE", Fuente, Brushes.Black, 1010, y - 20)
        'Grafico.DrawString("C.C.", Fuente, Brushes.Black, 700, y - 20)





        Grafico.DrawLine(Pens.Black, 55, y - 25, 1125 + x1, y - 25) 'arriba
        Grafico.DrawLine(Pens.Black, 55, y - 5, 1125 + x1, y - 5) 'abajo
        Grafico.DrawLine(Pens.Black, 55, y - 25, 55, y - 5) 'primera
        Grafico.DrawLine(Pens.Black, 105, y - 25, 105, y - 5) 'clave
        Grafico.DrawLine(Pens.Black, 415 + x1, y - 25, 415 + x1, y - 5) 'CONT
        Grafico.DrawLine(Pens.Black, 465 + x1, y - 25, 465 + x1, y - 5) '1
        Grafico.DrawLine(Pens.Black, 515 + x1, y - 25, 515 + x1, y - 5) '2
        Grafico.DrawLine(Pens.Black, 565 + x1, y - 25, 565 + x1, y - 5) '3
        Grafico.DrawLine(Pens.Black, 615 + x1, y - 25, 615 + x1, y - 5) '4
        Grafico.DrawLine(Pens.Black, 665 + x1, y - 25, 665 + x1, y - 5) '5
        Grafico.DrawLine(Pens.Black, 715 + x1, y - 25, 715 + x1, y - 5) '6
        Grafico.DrawLine(Pens.Black, 765 + x1, y - 25, 765 + x1, y - 5) '7
        Grafico.DrawLine(Pens.Black, 815 + x1, y - 25, 815 + x1, y - 5) '8
        Grafico.DrawLine(Pens.Black, 865 + x1, y - 25, 865 + x1, y - 5) '9
        Grafico.DrawLine(Pens.Black, 915 + x1, y - 25, 915 + x1, y - 5) '10
        Grafico.DrawLine(Pens.Black, 965 + x1, y - 25, 965 + x1, y - 5) '11
        Grafico.DrawLine(Pens.Black, 1015 + x1, y - 25, 1015 + x1, y - 5) '12
        Grafico.DrawLine(Pens.Black, 1065 + x1, y - 25, 1065 + x1, y - 5) 'comicion
        Grafico.DrawLine(Pens.Black, 1125 + x1, y - 25, 1125 + x1, y - 5) 'ultima


        'Grafico.DrawLine(Pens.Black, 795, y - 25, 795, y - 5) 'CC
        'Grafico.DrawLine(Pens.Black, 865, y - 25, 865, y - 5) 'articulo

        'Grafico.DrawLine(Pens.Black, 935, y - 25, 935, y - 5) 'articulo
        'Grafico.DrawLine(Pens.Black, 1005, y - 25, 1005, y - 5) 'articulo
        'Grafico.DrawLine(Pens.Black, 1075, y - 25, 1075, y - 5) 'articulo
        ''Grafico.DrawLine(Pens.Black, 800, y - 25, 800, y - 5) 'CRD
        'y = 100
        While i < Me.DataGridView1.RowCount
            If y > 780 Then
                e.HasMorePages = True
                GoTo fin
            End If

            Grafico.DrawString(Me.DataGridView1.Item("clave", i).Value, Fuente, Brushes.Black, 60, y)
            Grafico.DrawString(Mid(Me.DataGridView1.Item("articulo", i).Value, 1, 30), Fuente, Brushes.Black, 110, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("contado", i).Value + 0.5)), Fuente1, Brushes.Black, 416 + x1, y)

            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m1", i).Value + 0.5)), Fuente1, Brushes.Black, 466 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m2", i).Value + 0.5)), Fuente1, Brushes.Black, 516 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m3", i).Value + 0.5)), Fuente1, Brushes.Black, 566 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m4", i).Value + 0.5)), Fuente1, Brushes.Black, 616 + x1, y)

            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m5", i).Value + 0.5)), Fuente1, Brushes.Black, 666 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m6", i).Value + 0.5)), Fuente1, Brushes.Black, 716 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m7", i).Value + 0.5)), Fuente1, Brushes.Black, 766 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m8", i).Value + 0.5)), Fuente1, Brushes.Black, 816 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m9", i).Value + 0.5)), Fuente1, Brushes.Black, 866 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m10", i).Value + 0.5)), Fuente1, Brushes.Black, 916 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m11", i).Value + 0.5)), Fuente1, Brushes.Black, 966 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("m12", i).Value + 0.5)), Fuente1, Brushes.Black, 1016 + x1, y)
            Grafico.DrawString(Str(Int(Me.DataGridView1.Item("comicion", i).Value + 0.5)), Fuente1, Brushes.Black, 1066 + x1, y)




            'Grafico.DrawString(Str(Int(Me.DataGridView1.Item(7, i).Value + 0.5)), Fuente1, Brushes.Black, 700, y)
            'Grafico.DrawString(Str(Int(Me.DataGridView1.Item(8, i).Value + 0.5)), Fuente1, Brushes.Black, 800, y)

            Grafico.DrawLine(Pens.Black, 55, y + 15, 1125 + x1, y + 15) 'abajo
            Grafico.DrawLine(Pens.Black, 55, y - 5, 55, y + 15) 'primera
            Grafico.DrawLine(Pens.Black, 105, y - 5, 105, y + 15) 'clave
            Grafico.DrawLine(Pens.Black, 415 + x1, y - 5, 415 + x1, y + 15) 'CONT
            Grafico.DrawLine(Pens.Black, 465 + x1, y - 5, 465 + x1, y + 15) '1
            Grafico.DrawLine(Pens.Black, 515 + x1, y - 5, 515 + x1, y + 15) '2
            Grafico.DrawLine(Pens.Black, 565 + x1, y - 5, 565 + x1, y + 15) '3
            Grafico.DrawLine(Pens.Black, 615 + x1, y - 5, 615 + x1, y + 15) '4
            Grafico.DrawLine(Pens.Black, 665 + x1, y - 5, 665 + x1, y + 15) '5
            Grafico.DrawLine(Pens.Black, 715 + x1, y - 5, 715 + x1, y + 15) '6
            Grafico.DrawLine(Pens.Black, 765 + x1, y - 5, 765 + x1, y + 15) '7
            Grafico.DrawLine(Pens.Black, 815 + x1, y - 5, 815 + x1, y + 15) '8
            Grafico.DrawLine(Pens.Black, 865 + x1, y - 5, 865 + x1, y + 15) '9
            Grafico.DrawLine(Pens.Black, 915 + x1, y - 5, 915 + x1, y + 15) '10
            Grafico.DrawLine(Pens.Black, 965 + x1, y - 5, 965 + x1, y + 15) '11
            Grafico.DrawLine(Pens.Black, 1015 + x1, y - 5, 1015 + x1, y + 15) '12

            Grafico.DrawLine(Pens.Black, 1065 + x1, y - 5, 1065 + x1, y + 15) 'CC
            Grafico.DrawLine(Pens.Black, 1125 + x1, y - 5, 1125 + x1, y + 15) 'articulo



            'If Val(Me.DataGridView1.Item("remate", i).Value) > 0 Or Val(Me.DataGridView1.Item("oferta", i).Value) > 0 Or Val(Me.DataGridView1.Item("paquete", i).Value) > 0 Then
            '    Grafico.DrawLine(Pens.Black, 5, y + 15, 1075, y + 15) 'arriba
            '    Grafico.DrawLine(Pens.Black, 5, y + 17, 1075, y + 17) 'arriba
            '    Grafico.DrawLine(Pens.Black, 5, y - 7, 1075, y - 7) 'abajo

            '    Grafico.DrawLine(Pens.Black, 935, y - 5, 935, y + 15)
            '    Grafico.DrawLine(Pens.Black, 1005, y - 5, 1005, y + 15)
            '    Grafico.DrawLine(Pens.Black, 1075, y - 5, 1075, y + 15)
            'End If

            'If Val(Me.DataGridView1.Item("remate", i).Value) > 0 Then Grafico.DrawString(Str(Int(Me.DataGridView1.Item("remate", i).Value + 0.5)), Fuente1, Brushes.Black, 870, y)
            'If Val(Me.DataGridView1.Item("oferta", i).Value) > 0 Then Grafico.DrawString(Str(Int(Me.DataGridView1.Item("oferta", i).Value + 0.5)), Fuente1, Brushes.Black, 940, y)
            'If Val(Me.DataGridView1.Item("paquete", i).Value) > 0 Then Grafico.DrawString(Str(Int(Me.DataGridView1.Item("paquete", i).Value + 0.5)), Fuente1, Brushes.Black, 1010, y)

            'Grafico.DrawString("REMATE", Fuente, Brushes.Black, 750, y - 20)
            'Grafico.DrawString("OFERTA", Fuente, Brushes.Black, 830, y - 20)
            'Grafico.DrawString("PAQUETE", Fuente, Brushes.Black, 910, y - 20)



            'Grafico.DrawLine(Pens.Black, 800, y - 5, 800, y + 15) 'CRD
            y += 22
            i += 1
        End While
fin:
        Grafico.DrawString("P " + Str(p), Fuente, Brushes.Black, 1000, 790)
        p += 1
    End Sub

    Private Sub mayoreo_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles mayoreo.PrintPage
        Dim Fuente As New System.Drawing.Font("Arial", 10)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Me.mayoreo.PrinterSettings.DefaultPageSettings.Landscape = False
        Me.mayoreo.DefaultPageSettings.Landscape = False
        If p = 1 Then
            Grafico.DrawImage(Me.PictureBox1.Image, 5, 5, 300, 60)
            y = 100
        Else
            y = 60
        End If

        If bodega <> "MAS" Then Grafico.DrawString("LISTA MAYOREO  " + Format(Now, "dd-MM-yyyy"), Fuente, Brushes.Black, 350, 10)
        'If bodega = "MAS" Then Grafico.DrawString("LISTA EVENTO  " + Format(Now, "dd-MM-yyyy"), Fuente, Brushes.Black, 350, 10)

        Grafico.DrawString("Clave", Fuente, Brushes.Black, 10, y - 20)
        Grafico.DrawString("Articulo", Fuente, Brushes.Black, 100, y - 20)
        Grafico.DrawString("Precio", Fuente, Brushes.Black, 500, y - 20)

        Grafico.DrawLine(Pens.Black, 5, y - 25, 600, y - 25) 'arriba
        Grafico.DrawLine(Pens.Black, 5, y - 5, 600, y - 5) 'abajo
        Grafico.DrawLine(Pens.Black, 5, y - 25, 5, y - 5) 'primera
        Grafico.DrawLine(Pens.Black, 90, y - 25, 90, y - 5) 'clave
        Grafico.DrawLine(Pens.Black, 490, y - 25, 490, y - 5) 'articulo
        Grafico.DrawLine(Pens.Black, 600, y - 25, 600, y - 5) 'precio

        While i < Me.DataGridView1.RowCount
            If y > 1020 Then
                e.HasMorePages = True
                GoTo fin
            End If
            If Val(Me.DataGridView1.Item("pmayoreo", i).Value) > 0 Then
                Grafico.DrawString(Me.DataGridView1.Item("clave", i).Value, Fuente, Brushes.Black, 10, y)
                Grafico.DrawString(Me.DataGridView1.Item("articulo", i).Value, Fuente, Brushes.Black, 100, y)
                Grafico.DrawString(Str(Int(Me.DataGridView1.Item("pmayoreo", i).Value + 0.5)), Fuente, Brushes.Black, 500, y)
                Grafico.DrawLine(Pens.Black, 5, y + 15, 600, y + 15) 'abajo
                Grafico.DrawLine(Pens.Black, 5, y - 5, 5, y + 15) 'primera
                Grafico.DrawLine(Pens.Black, 90, y - 5, 90, y + 15) 'clave
                Grafico.DrawLine(Pens.Black, 490, y - 5, 490, y + 15) 'articulo
                Grafico.DrawLine(Pens.Black, 600, y - 5, 600, y + 15) 'precio
                y += 20
                i += 1
            Else
                i += 1
            End If
        End While
fin:
        Grafico.DrawString("P " + Str(p), Fuente, Brushes.Black, 750, 1040)
        p += 1
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        ' cad_con = "DRIVER={MySQL ODBC 3.51 Driver};SERVER=MSM;DATABASE=catalogo;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"
        Dim conexion As New base_local
        'coneccion = New Odbc.OdbcConnection
        'coneccion.ConnectionString = cad_con
        'coneccion.Open()
        For i As Integer = 0 To Me.DataGridView1.RowCount - 1
            conexion.InsertarSQL("Update articulos set p_lista=" + Str(Me.DataGridView1.Item("costo", i).Value) + " where clave='" + Me.DataGridView1.Item("clave", i).Value + "'")
            'comando = New Odbc.OdbcCommand("update articulos set p_lista=" + Str(Me.DataGridView1.Item("costo", i).Value) + " where clave='" + Me.DataGridView1.Item("clave", i).Value + "'", coneccion)
            'comando.ExecuteNonQuery()
        Next
        conexion.InsertarSQL("insert into lista values(''," + Me.l1c.Text + "," + Me.l11.Text + "," + Me.l12.Text + "," + Me.l13.Text + "," + Me.l14.Text + "," + Me.l15.Text + "," + Me.l16.Text + "," + Me.l17.Text + "," + Me.l18.Text + "," + Me.l19.Text + "," + Me.l110.Text + "," + Me.l111.Text + "," + Me.l112.Text + "," + Me.l1com.Text + "," + Me.l1m.Text + "," + Me.l2c.Text + "," + Me.l21.Text + "," + Me.l22.Text + "," + Me.l23.Text + "," + Me.l24.Text + "," + Me.l25.Text + "," + Me.l26.Text + "," + Me.l27.Text + "," + Me.l28.Text + "," + Me.l29.Text + "," + Me.l210.Text + "," + Me.l211.Text + "," + Me.l212.Text + "," + Me.l2com.Text + "," + Me.l2m.Text + "," + Me.l3c.Text + "," + Me.l31.Text + "," + Me.l32.Text + "," + Me.l33.Text + "," + Me.l34.Text + "," + Me.l35.Text + "," + Me.l36.Text + "," + Me.l37.Text + "," + Me.l38.Text + "," + Me.l39.Text + "," + Me.l310.Text + "," + Me.l311.Text + "," + Me.l312.Text + "," + Me.l3com.Text + ", " + Me.l3m.Text + ",'" + Format(Now, "yyyy-MM-dd") + "')")
        conexion.dispose()
        'comando = New Odbc.OdbcCommand("insert into lista values(''," + Me.l1c.Text + "," + Me.l11.Text + "," + Me.l12.Text + "," + Me.l13.Text + "," + Me.l14.Text + "," + Me.l15.Text + "," + Me.l16.Text + "," + Me.l17.Text + "," + Me.l18.Text + "," + Me.l19.Text + "," + Me.l110.Text + "," + Me.l111.Text + "," + Me.l112.Text + "," + Me.l1com.Text + "," + Me.l1m.Text + "," + Me.l2c.Text + "," + Me.l21.Text + "," + Me.l22.Text + "," + Me.l23.Text + "," + Me.l24.Text + "," + Me.l25.Text + "," + Me.l26.Text + "," + Me.l27.Text + "," + Me.l28.Text + "," + Me.l29.Text + "," + Me.l210.Text + "," + Me.l211.Text + "," + Me.l212.Text + "," + Me.l2com.Text + "," + Me.l2m.Text + "," + Me.l3c.Text + "," + Me.l31.Text + "," + Me.l32.Text + "," + Me.l33.Text + "," + Me.l34.Text + "," + Me.l35.Text + "," + Me.l36.Text + "," + Me.l37.Text + "," + Me.l38.Text + "," + Me.l39.Text + "," + Me.l310.Text + "," + Me.l311.Text + "," + Me.l312.Text + "," + Me.l3com.Text + ", " + Me.l3m.Text + ",'" + Format(Now, "yyyy-MM-dd") + "')", coneccion)
        'comando.ExecuteNonQuery()

        'coneccion.Close()
        MsgBox("Precios guardados")
    End Sub

    Private Sub lista_precios_12meses_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.DateTimePicker1.Value = DateAdd(DateInterval.Month, 1, Now)

        Dim conexion As New base_local
        conexion.llena_combo(ComboBox1, "select lista,fecha from lista")

        'coneccion = New Odbc.OdbcConnection
        'coneccion.ConnectionString = cad_con
        'coneccion.Open()

        'comando = New Odbc.OdbcCommand("select lista,fecha from lista", coneccion)
        'da.SelectCommand = comando
        'dt = New DataTable
        'da.Fill(dt)
        'Me.ComboBox1.DataSource = dt
        Me.ComboBox1.ValueMember = "lista"
        Me.ComboBox1.DisplayMember = "fecha"

        'Me.TextBox1.Text = lector.Item("l1_c")
        'Me.TextBox2.Text = lector.Item("l1_1")
        'Me.TextBox3.Text = lector.Item("l1_2")
        'Me.TextBox4.Text = lector.Item("l1_3")
        'Me.TextBox5.Text = lector.Item("l1_4")
        'Me.TextBox6.Text = lector.Item("l1_5")
        'Me.TextBox7.Text = lector.Item("l1_6")
        'Me.TextBox8.Text = lector.Item("l1_7")
        'Me.TextBox9.Text = lector.Item("l1_8")
        'Me.TextBox10.Text = lector.Item("l1_9")
        'Me.TextBox11.Text = lector.Item("l1_10")
        'Me.TextBox12.Text = lector.Item("l1_11")
        'Me.TextBox13.Text = lector.Item("l1_12")
        'Me.TextBox14.Text = lector.Item("l1_com")
        'Me.TextBox31.Text = lector.Item("l1_may")

        'Me.TextBox30.Text = lector.Item("l2_c")
        'Me.TextBox29.Text = lector.Item("l2_1")
        'Me.TextBox28.Text = lector.Item("l2_2")
        'Me.TextBox27.Text = lector.Item("l2_3")
        'Me.TextBox26.Text = lector.Item("l2_4")
        'Me.TextBox25.Text = lector.Item("l2_5")
        'Me.TextBox24.Text = lector.Item("l2_6")
        'Me.TextBox23.Text = lector.Item("l2_7")
        'Me.TextBox22.Text = lector.Item("l2_8")
        'Me.TextBox21.Text = lector.Item("l2_9")
        'Me.TextBox20.Text = lector.Item("l2_10")
        'Me.TextBox19.Text = lector.Item("l2_11")
        'Me.TextBox18.Text = lector.Item("l2_12")
        'Me.TextBox17.Text = lector.Item("l2_com")
        'Me.TextBox16.Text = lector.Item("l2_may")



        'coneccion.Close()
        conexion.dispose()
    End Sub

    'Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
    '    p = 1
    '    y = 0
    '    i = 0
    '    If Me.PrintDialog1.ShowDialog() = DialogResult.OK Then
    '        Me.promocion.PrinterSettings = Me.PrintDialog1.PrinterSettings
    '        Me.promocion.PrinterSettings.DefaultPageSettings.Landscape = True
    '        promocion.Print()

    '        coneccion = New Odbc.OdbcConnection
    '        coneccion.ConnectionString = cad_con
    '        coneccion.Open()
    '        comando = New Odbc.OdbcCommand("insert into promocion values(''," + Me.desc.Text + ",'" + Format(Now, "yyyy-MM-dd") + "','" + Format(Me.DateTimePicker1.Value, "yyyy-MM-dd") + "')", coneccion)
    '        comando.ExecuteNonQuery()

    '        coneccion.Close()
    '        MsgBox("Precios guardados")
    '    End If
    'End Sub

    Private Sub promocion_PrintPage(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles promocion.PrintPage
        Dim Fuente As New System.Drawing.Font("Arial", 10)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Me.mayoreo.PrinterSettings.DefaultPageSettings.Landscape = False
        Me.mayoreo.DefaultPageSettings.Landscape = False
        If p = 1 Then
            Grafico.DrawImage(Me.PictureBox1.Image, 5, 5, 300, 60)
        End If

        If bodega <> "MAS" Then Grafico.DrawString("LISTA DE ARTICULOS EN PROMOCION   VIGENCIA HASTA EL   " + Format(Me.DateTimePicker1.Value, "dd-MM-yyyy"), Fuente, Brushes.Black, 350, 10)
        'If bodega = "MAS" Then Grafico.DrawString("LISTA EVENTO  " + Format(Now, "dd-MM-yyyy"), Fuente, Brushes.Black, 350, 10)
        y = 100
        Grafico.DrawString("Clave", Fuente, Brushes.Black, 10, 80)
        Grafico.DrawString("Articulo", Fuente, Brushes.Black, 100, 80)
        Grafico.DrawString("Descuento", Fuente, Brushes.Black, 500, 80)

        Grafico.DrawLine(Pens.Black, 5, 75, 600, 75) 'arriba
        Grafico.DrawLine(Pens.Black, 5, 95, 600, 95) 'abajo
        Grafico.DrawLine(Pens.Black, 5, 75, 5, 95) 'primera
        Grafico.DrawLine(Pens.Black, 90, 75, 90, 95) 'clave
        Grafico.DrawLine(Pens.Black, 490, 75, 490, 95) 'articulo
        Grafico.DrawLine(Pens.Black, 600, 75, 600, 95) 'precio

        While i < Me.DataGridView1.RowCount
            If y > 800 Then
                e.HasMorePages = True
                GoTo fin
            End If

            If Me.DataGridView1.Item("descuento", i).Value > 0 Then
                Grafico.DrawString(Me.DataGridView1.Item("clave", i).Value, Fuente, Brushes.Black, 10, y)
                Grafico.DrawString(Me.DataGridView1.Item("articulo", i).Value, Fuente, Brushes.Black, 100, y)
                Grafico.DrawString(Str(Int(Me.DataGridView1.Item("descuento", i).Value + 0.5)), Fuente, Brushes.Black, 500, y)
                Grafico.DrawLine(Pens.Black, 5, y + 15, 600, y + 15) 'abajo
                Grafico.DrawLine(Pens.Black, 5, y - 5, 5, y + 15) 'primera
                Grafico.DrawLine(Pens.Black, 90, y - 5, 90, y + 15) 'clave
                Grafico.DrawLine(Pens.Black, 490, y - 5, 490, y + 15) 'articulo
                Grafico.DrawLine(Pens.Black, 600, y - 5, 600, y + 15) 'precio
                y += 20
                i += 1
            Else
                i += 1
            End If
        End While
fin:
        Grafico.DrawString("P " + Str(p), Fuente, Brushes.Black, 750, 800)
        p += 1
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Dim conexion As New base_local
        Dim fila_precios As DataRow
        fila_precios = conexion.repetido("select * from lista where lista=" + Me.ComboBox1.SelectedValue.ToString, "lista")
        'coneccion = New Odbc.OdbcConnection
        'coneccion.ConnectionString = cad_con
        'coneccion.Open()

        'comando = New Odbc.OdbcCommand("select * from lista where lista=" + Me.ComboBox1.SelectedValue.ToString, coneccion)
        'lector = comando.ExecuteReader
        'lector.Read()

        Me.l1c.Text = fila_precios.Item("l1_c")
        Me.l11.Text = fila_precios.Item("l1_1")
        Me.l12.Text = fila_precios.Item("l1_2")
        Me.l13.Text = fila_precios.Item("l1_3")
        Me.l14.Text = fila_precios.Item("l1_4")
        Me.l15.Text = fila_precios.Item("l1_5")
        Me.l16.Text = fila_precios.Item("l1_6")
        Me.l17.Text = fila_precios.Item("l1_7")
        Me.l18.Text = fila_precios.Item("l1_8")
        Me.l19.Text = fila_precios.Item("l1_9")
        Me.l110.Text = fila_precios.Item("l1_10")
        Me.l111.Text = fila_precios.Item("l1_11")
        Me.l112.Text = fila_precios.Item("l1_12")
        Me.l1com.Text = fila_precios.Item("l1_com")
        Me.l1m.Text = fila_precios.Item("l1_may")

        Me.l2c.Text = fila_precios.Item("l2_c")
        Me.l21.Text = fila_precios.Item("l2_1")
        Me.l22.Text = fila_precios.Item("l2_2")
        Me.l23.Text = fila_precios.Item("l2_3")
        Me.l24.Text = fila_precios.Item("l2_4")
        Me.l25.Text = fila_precios.Item("l2_5")
        Me.l26.Text = fila_precios.Item("l2_6")
        Me.l27.Text = fila_precios.Item("l2_7")
        Me.l28.Text = fila_precios.Item("l2_8")
        Me.l29.Text = fila_precios.Item("l2_9")
        Me.l210.Text = fila_precios.Item("l2_10")
        Me.l211.Text = fila_precios.Item("l2_11")
        Me.l212.Text = fila_precios.Item("l2_12")
        Me.l2com.Text = fila_precios.Item("l2_com")
        Me.l2m.Text = fila_precios.Item("l2_may")

        Me.l3c.Text = fila_precios.Item("l3_c")
        Me.l31.Text = fila_precios.Item("l3_1")
        Me.l32.Text = fila_precios.Item("l3_2")
        Me.l33.Text = fila_precios.Item("l3_3")
        Me.l34.Text = fila_precios.Item("l3_4")
        Me.l35.Text = fila_precios.Item("l3_5")
        Me.l36.Text = fila_precios.Item("l3_6")
        Me.l37.Text = fila_precios.Item("l3_7")
        Me.l38.Text = fila_precios.Item("l3_8")
        Me.l39.Text = fila_precios.Item("l3_9")
        Me.l310.Text = fila_precios.Item("l3_10")
        Me.l311.Text = fila_precios.Item("l3_11")
        Me.l312.Text = fila_precios.Item("l3_12")
        Me.l3com.Text = fila_precios.Item("l3_com")
        Me.l3m.Text = fila_precios.Item("l3_may")



        conexion.dispose()

    End Sub


End Class