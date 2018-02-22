Public Class entradas_fabrica
    Dim primera As Boolean
    Dim claver As String
    Public clave_provedor, nombre_provedor As String
    Dim registrados As String
    Dim dta As DataTable
    Dim dr As DataRow
    Private Sub foliotxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles foliotxt.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            Dim conexion As New base_local
            Dim compra As DataRow = Nothing
            compra = conexion.repetido("select folio_c, fecha from entradas_fabrica where folio_c ='" + clave_provedor + "-" + Me.foliotxt.Text + "'", "entradas_fabrica")
            If compra.IsNull(0) Then
                'Me.provedortxt.Enabled = False
                Me.foliotxt.Enabled = False
                Me.cantidadtxt.Enabled = True
                Me.cantidadtxt.Focus()
            Else
                Entrada_repetida.lblprovedor.Text = nombre_provedor
                Entrada_repetida.lbl_clave_provedor.Text = clave_provedor
                Entrada_repetida.lbl_folio.Text = foliotxt.Text
                Entrada_repetida.lbl_fecha.Text = compra.ToString
                Entrada_repetida.Show()

            End If
            conexion.dispose()
        End If
    End Sub


    Private Sub entradas_fabrica_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
        'cargar()
        cargar_articulos()
        lbl_provedor.Text = nombre_provedor
        Me.foliotxt.Focus()
    End Sub
    Private Sub cargar()

        'Dim conexion As New base_local
        'conexion.llena_combo(provedortxt, "select clave, nombre from provedores where activo='A' order by nombre")
        'Me.provedortxt.DisplayMember = "nombre"
        'Me.provedortxt.ValueMember = "clave"
        'provedortxt.Enabled = True
        'conexion.dispose()
    End Sub

    Private Sub cargar_articulos()
        Dim conexion As New base_local
        conexion.llena_combo(articulotxt, "select clave, articulo, precio from articulos where clave like'" + clave_provedor + "-%' and  activo='A' order by articulo")
        dta = articulotxt.DataSource
        Dim key(0) As DataColumn
        Dim col As DataColumn
        col = New DataColumn
        col = dta.Columns(0)
        key(0) = col
        dta.PrimaryKey = key
        dta = articulotxt.DataSource
        Me.articulotxt.DisplayMember = "articulo"
        Me.articulotxt.ValueMember = "clave"
        conexion.dispose()
    End Sub

    Private Sub cantidadtxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cantidadtxt.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            If Me.cantidadtxt.Text <> "" Then
                primera = True
                Me.articulotxt.Enabled = True
                Me.articulotxt.Focus()
            Else
                Me.cantidadtxt.Focus()
            End If
        End If
    End Sub

    Private Sub articulotxt_KeyPress(sender As Object, e As KeyPressEventArgs) Handles articulotxt.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            dr = dta.NewRow
            dr = dta.Rows.Find(Me.articulotxt.SelectedValue)
            Me.preciotxt.Text = dr.Item("costo")
            agregar.Enabled = True
            agregar.Focus()

        End If
    End Sub

    Private Sub agregar_Click(sender As Object, e As EventArgs) Handles agregar.Click
        Me.DataGridView1.Rows.Add()
        Me.DataGridView1.Item("t_clave", Me.DataGridView1.Rows.Count - 1).Value = Me.articulotxt.SelectedValue
        Me.DataGridView1.Item("t_cantidad", Me.DataGridView1.Rows.Count - 1).Value = Me.cantidadtxt.Text
        Me.DataGridView1.Item("t_articulo", Me.DataGridView1.Rows.Count - 1).Value = Me.articulotxt.Text
        Me.DataGridView1.Item("t_costo", Me.DataGridView1.Rows.Count - 1).Value = Val(Me.preciotxt.Text)
        Me.Label7.Text = Val(Me.Label7.Text) + Me.cantidadtxt.Text
        Me.lbltotal.Text = Val(Me.lbltotal.Text) + Me.cantidadtxt.Text * Me.DataGridView1.Item("t_costo", Me.DataGridView1.Rows.Count - 1).Value
        Me.articulotxt.Enabled = False
        Me.cantidadtxt.Focus()
        Me.guardar.Enabled = True
        Me.agregar.Enabled = False
    End Sub

    Private Sub DataGridView1_UserDeletingRow(sender As Object, e As DataGridViewRowCancelEventArgs) Handles DataGridView1.UserDeletingRow
        Me.Label7.Text = Val(Me.Label7.Text) - Me.DataGridView1.Item("t_cantidad", Me.DataGridView1.CurrentRow.Index).Value
        Me.lbltotal.Text = Val(Me.lbltotal.Text) - (Me.DataGridView1.Item("t_costo", Me.DataGridView1.CurrentRow.Index).Value * Me.DataGridView1.Item("t_cantidad", Me.DataGridView1.CurrentRow.Index).Value)
        If Me.DataGridView1.Rows.Count = 1 Then Me.guardar.Enabled = False
    End Sub

    'Private Sub provedortxt_KeyUp(sender As Object, e As KeyEventArgs)
    '    If e.KeyCode = 13 Then

    '        If Me.provedortxt.SelectedIndex >= 0 Then
    '            't1.Text = Me.provedor.SelectedValue
    '            'primera = False
    '            'Dim i As Integer = 0
    '            'primera = True
    '            cargar_articulos()
    '            If Me.articulotxt.Items.Count = 0 Then
    '                MsgBox("El provedor no tiene articulos registrados" + vbCrLf + "Opciones" + vbCrLf + "Salir y actualizar datos" + vbCrLf + "Seleccionar otro provedor")
    '                Me.provedortxt.Enabled = True
    '            Else
    '                Me.foliotxt.Enabled = True
    '                Me.foliotxt.Focus()
    '                Me.provedortxt.Enabled = False
    '            End If


    '        Else
    '            Me.provedortxt.Focus()
    '        End If
    '    End If
    'End Sub

    Private Sub articulotxt_KeyUp(sender As Object, e As KeyEventArgs) Handles articulotxt.KeyUp
        If e.KeyCode = 13 Then
            If primera = True Then
                primera = False
            Else

                dr = dta.NewRow
                dr = dta.Rows.Find(Me.articulotxt.SelectedValue)
                Me.preciotxt.Text = dr.Item("precio")
                'Me.preciotxt.Enabled = True
                'Me.preciotxt.Focus()
                agregar.Enabled = True
                agregar.Focus()
            End If
        End If
    End Sub

    Private Sub guardar_Click(sender As Object, e As EventArgs) Handles guardar.Click
        Dim articulos As String = ""
        Dim conexion As New base_local
        For i As Integer = 0 To Me.DataGridView1.RowCount - 1
            articulos = articulos + Me.DataGridView1.Item("t_clave", i).Value.PadRight(10, " "c) + Str(Me.DataGridView1.Item("t_costo", i).Value).PadRight(5, " "c) + Str(Me.DataGridView1.Item("t_cantidad", i).Value).PadRight(5, " "c)
        Next
        conexion.InsertarSQL("call entrada_fabrica('" + clave_provedor + "-" + foliotxt.Text + "','" + articulos + "'," + Me.DataGridView1.RowCount.ToString + "," + lbltotal.Text + ",'" + My.Computer.Name + "','" + usuario + "')")
        conexion.dispose()
        If MsgBox("Compra guardada desea dar de alta otra Compra", MsgBoxStyle.YesNoCancel) = MsgBoxResult.Yes Then
            ' Me.provedortxt.Enabled = True
            Me.DataGridView1.Rows.Clear()
            Me.foliotxt.Text = ""
            Me.Label7.Text = ""
            Me.lbltotal.Text = ""
            Me.foliotxt.Enabled = True
            Me.foliotxt.Focus()
            Me.cantidadtxt.Enabled = False
            Me.guardar.Enabled = False
            Me.agregar.Enabled = False
            Me.cantidadtxt.Text = "1"
            Me.articulotxt.SelectedIndex = -1
            Me.articulotxt.Enabled = False
            Me.preciotxt.Text = ""
            Me.preciotxt.Enabled = False
            Me.cantidadtxt.Enabled = False
            'Me.impuesto.Enabled = False
            Me.foliotxt.Enabled = False
        Else
            Me.Close()
        End If
    End Sub


    Private Sub lbltotal_TextChanged(sender As Object, e As EventArgs) Handles lbltotal.TextChanged
        txt_totoal_nota.Text = lbltotal.Text
    End Sub
End Class