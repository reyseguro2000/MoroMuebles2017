
Imports System.Data
Public Class nuevo_cliente_mayoreo


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        On Error GoTo fin
        Dim conexion As New base_local
        Dim mayorista As Integer
        mayorista = conexion.InsertaEscalar("call inserta_cliente_mayoreo('" + txt_nombre.Text + "','" + txt_rfc.Text + "','" + Me.txt_calle.Text + "','" + txt_colonia.Text + "','" + txt_ciudad.Text + "','" + txt_telefono.Text + "'," + txt_limite.Text + ",'" + usuario + "','" + My.Computer.Name + "')")
        conexion.dispose()
        'comando3 = New Odbc.OdbcConnection
        'comando3.ConnectionString = cad_con '"DRIVER={MySQL ODBC 3.51 Driver};SERVER=MSM;DATABASE=Facturas;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"
        'comando3.Open()
        'nuevo = New Odbc.OdbcCommand("insert into clientes values('','" + txt_nombre.Text + "','" + Me.txt_calle.Text + "','" + txt_colonia.Text + "','" + txt_ciudad.Text + "','" + Me.MaskedTextBox1.Text + "','" + txt_rfc.Text + "')", comando3)
        'nuevo.ExecuteNonQuery()
        'comando3.Close()
        'comando3.Dispose()
        MsgBox("Cliente registrado no " + mayorista.ToString)
fin:
    End Sub

    Private Sub TextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_nombre.Text = UCase(txt_nombre.Text)
            txt_calle.Focus()
        End If
    End Sub

    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_calle.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_calle.Text = UCase(txt_calle.Text)
            Me.txt_colonia.Focus()
        End If
    End Sub

    'Private Sub MaskedTextBox1_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs)
    '    If e.KeyChar = Chr(Keys.Enter) Then
    '        Me.txt_colonia.Focus()
    '    End If
    'End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_colonia.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_colonia.Text = UCase(txt_colonia.Text)
            Me.txt_ciudad.Focus()
        End If
    End Sub
    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ciudad.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_ciudad.Text = UCase(txt_ciudad.Text)
            Me.txt_rfc.Focus()
        End If
    End Sub
    Private Sub TextBox5_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_rfc.KeyPress
        If e.KeyChar = Chr(Keys.Enter) Then
            txt_rfc.Text = UCase(txt_rfc.Text)

            If Button1.Visible = True Then Me.Button1.Focus()
            If Button2.Visible = True Then Me.Button2.Focus()
        End If
    End Sub

    Private Sub nuevo_cliente_mayoreo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackgroundImage = My.Resources.Fondo4
    End Sub

    'Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
    '    'On Error GoTo fin
    '    comando3 = New Odbc.OdbcConnection
    '    comando3.ConnectionString = cad_con '"DRIVER={MySQL ODBC 3.51 Driver};SERVER=MSM;DATABASE=Facturas;UID=tony;PWD=;OPTIONS=&1+2+8+32+2048+16384"
    '    comando3.Open()
    '    nuevo = New Odbc.OdbcCommand("update clientes set nombre='" + txt_nombre.Text + "', direccion='" + Me.txt_calle.Text + "',colonia='" + txt_colonia.Text + "',ciudad='" + txt_ciudad.Text + "',cp='" + Me.MaskedTextBox1.Text + "',rfc='" + txt_rfc.Text + "' WHERE CLIENTE=" + txt_telefono.Text, comando3)
    '    nuevo.ExecuteNonQuery()
    '    comando3.Close()
    '    comando3.Dispose()
    '    MsgBox("Cliente modificado")
    '    'fin:
    'End Sub

End Class