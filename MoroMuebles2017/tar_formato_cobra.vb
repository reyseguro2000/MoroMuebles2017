Public Class tar_formato_cobra
    Dim fs As Integer
    Private Sub impr_cobra_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles impr_cobra.PrintPage
        Dim Fuente As New System.Drawing.Font("Arial", 12)
        Dim Fuente2 As New System.Drawing.Font("Arial", 14)
        Dim Fuente3 As New System.Drawing.Font("Arial", 12)
        Dim codigo As New System.Drawing.Font("C39HrP48DhTt", 45)
        Dim Grafico As System.Drawing.Graphics = e.Graphics
        Dim pagoss As Integer
        Dim bodegaimprimir As String = ""
        Dim articulos_venta As String = ""
        Dim x, y As Integer
        x = 1
        articulos_venta = ""
        For arti As Integer = 0 To tarjeta_s.dg_articulos.RowCount - 1
            articulos_venta = articulos_venta + Trim(Str(tarjeta_s.dg_articulos.Item("cantidad", arti).Value)) + " " + tarjeta_s.dg_articulos.Item("articulo", arti).Value + ", "
        Next

        Grafico.DrawImage(Principal.img_logo.Image, 50, 10, 100, 100)
        Grafico.DrawString(muebleria_nombre, Fuente3, Brushes.Black, 320, 40)
        Grafico.DrawString(muebleria_direccion + "       " + muebleria_ciudad + "          " + muebleria_tel, Fuente3, Brushes.Black, 120, 70)
        pagoss = Val(tarjeta_s.l_pagos.Text) ' 0.5 + (Val(Me.Label10.Text) / Val(Me.Label7.Text))
        Select Case fs
            Case 1
                Grafico.DrawString(muebleria_ciudad + " A " + Now.ToString("D"), Fuente3, Brushes.Black, 20, 150)
                Grafico.DrawString("Cuenta:" + lbl_venta.Text, Fuente3, Brushes.Black, 350, 150)
                Grafico.DrawString("Ruta" + tarjeta_s.l_ruta.Text, Fuente3, Brushes.Black, 600, 150)
                Grafico.DrawString("ESTIMADO CLIENTE " + lbl_nombre.Text + " E PASADO POR LOS ABONOS DE LA VENTA " + lbl_venta.Text, Fuente3, Brushes.Black, 20, 170)
                Grafico.DrawString("Y NO LE E ENCONTRADO NI ME HA DEJADO EL ABONO, RECUERDE QUE YO ESTOY PASANDO LOS DIAS", Fuente3, Brushes.Black, 20, 210)
                Grafico.DrawString("PERO  REGRESO   EL   DIA   ", Fuente3, Brushes.Black, 20, 230)

                'Grafico.DrawString("______________.        PERO    SI   NO    ME     PUEDE      ESPERAR     DEJEME     EL   ABONO    CON    ALGUN   FAMILIAR.", Fuente3, Brushes.Black, 20, 250)
                'Grafico.DrawString("visita del Sr. Cobrador liquide el atraso ya mencionado, o también puede pasar a visitarnos en nuestras", Fuente3, Brushes.Black, 20, 270)
                'Grafico.DrawString("oficinas para llegar a un arreglo. Evitándose así más recargos y futuras molestias.", Fuente3, Brushes.Black, 20, 290)
                'Grafico.DrawString("Recuerde   que  el  pago de  su  cuenta  es  en  abonos  y  nunca  a  plazo  cumplido.", Fuente3, Brushes.Black, 150, 340)
                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 370, 370)
                Grafico.DrawString("COBRADOR", Fuente3, Brushes.Black, 310, 440)
                Grafico.DrawLine(Pens.Black, 280, 430, 600, 430)
                Grafico.DrawString("ESTE DOCUMENTO NO ES VALIDO COMO RECIBO DE PAGO", Fuente3, Brushes.Black, 210, 470)

            Case 2
                Dim pago_vence As Double = Val(tarjeta_s.lbl_atrazado.Text)
                Grafico.DrawString(muebleria_direccion + " A " + UCase(Now.ToString("D")), Fuente3, Brushes.Black, 20, 150)

                Grafico.DrawString("cuenta: " + lbl_venta.Text, Fuente3, Brushes.Black, 500, 150)
                Grafico.DrawString("Ruta" + tarjeta_s.l_ruta.Text, Fuente3, Brushes.Black, 600, 150)
                Grafico.DrawString("Estimado cliente:" + lbl_nombre.Text, Fuente3, Brushes.Black, 20, 170)
                Grafico.DrawString("Estimado cliente, por medio de la presente me permito comunicarle a UD. Que adquirió los siguientes  articulos", Fuente3, Brushes.Black, 20, 190)
                Grafico.DrawString(articulos_venta, Fuente3, Brushes.Black, 20, 210)
                Grafico.DrawString("y  que  tiene  un  atraso  de  " + " abonos   equivalentes  a   $ " + pago_vence.ToString + "  $ de abono atrasado.", Fuente3, Brushes.Black, 20, 230)
                Grafico.DrawString("Por  lo  que   hasta el  momento  no  esta  cumpliendo con   las  condiciones  de  pago  pactadas  en  el  contrato  que  UD  firmo ", Fuente3, Brushes.Black, 20, 250)
                Grafico.DrawString("se  le  ruega  de la  manera  mas  atenta  que  en  la  próxima  visita  del  Sr.  Cobrador  UD  se   ponga  al  corriente  con  sus  pagos.", Fuente3, Brushes.Black, 20, 270)
                Grafico.DrawString("Recuerde   que  el  pago  de  su  cuenta  es  en  abonos   y   nunca  a  plazo  cumplido", Fuente3, Brushes.Black, 20, 290)
                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 350, 350)
                Grafico.DrawLine(Pens.Black, 280, 445, 600, 445)
                Grafico.DrawString("Departamento  de   crédito y cobranza", Fuente3, Brushes.Black, 310, 450)


            Case 3

                Grafico.DrawString(" R E C O R D A T O R I O", Fuente, Brushes.Black, 350, 120)
                y = 80
                Grafico.DrawString("ESTIMADO CLIENTE: " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, y + 140)

                Grafico.DrawString("CUENTA No. " + lbl_venta.Text, Fuente3, Brushes.Black, 50, y + 170)
                Grafico.DrawString("ARTICULO(S): " + articulos_venta, Fuente3, Brushes.Black, 50, y + 190)
                Grafico.DrawString("Se  le  informa  que  la  cuenta  que  tiene  conosotros  ya  tiene" + tarjeta_s.lbl_pagos_vencidos.Text, Fuente3, Brushes.Black, 250, y + 210)
                Grafico.DrawString("y  se  le  pide  que  se  ponga  al  corriente  hoy  mismo  con  el  Sr.  Cobrador." + muebleria_ciudad, Fuente3, Brushes.Black, 450, y + 230)
                Grafico.DrawString("Evítese  molestias  y  evítenos  la  pena  de  visitar  a  sus  referencias  o  avales, o de  cargarle  intereses moratorios   a  su cuenta y  gastos  de cobranza   ya  que  cada  visita  del  Sr.  Supervisor    tiene un  costo  para usted  de   $ 50.00  que  se  acumularan  a su  cuenta." + articulos_venta, Fuente3, Brushes.Black, 50, y + 250)
                Grafico.DrawString("              Si  tiene  algún  problema  económico  y  no puede  sacar el compromiso  que  tiene  conos otros  no  tenga  pena  y  platique  con  el  gerente  de  bodega ,  puede  usted   regresar  la  mercancía  y  con  ello  evitarse  mas  problemas ." + tarjeta_s.lbl_atrazado.Text, Fuente3, Brushes.Black, 50, y + 290)
                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 340, y + 700)
                Grafico.DrawString("____________________________________________", Fuente3, Brushes.Black, 200, y + 750)
                Grafico.DrawString("Supervisor  regional", Fuente3, Brushes.Black, 300, y + 770)


                'Case 4
                '    Grafico.DrawString(" ARREGLOS    DEL   COBRADOR ", Fuente, Brushes.Black, 350, 120)
                '    Grafico.DrawString("FECHA: " + Format(Now, "dd-MM-yyyy"), Fuente3, Brushes.Black, 50, 140)
                '    Grafico.DrawString("CUENTA: " + lbl_venta.Text, Fuente3, Brushes.Black, 250, 140)
                '    Grafico.DrawString("CLIENTE: " + lbl_clave_cliente.Text, Fuente3, Brushes.Black, 450, 140)

                '    Grafico.DrawString("SR(A).: " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, 170)

                '    Grafico.DrawString("DIRECCION: " + tarjeta_s.l_dir.Text, Fuente3, Brushes.Black, 50, 200)

                '    Grafico.DrawString("ARTICULO EN LITIGIO: " + articulos_venta, Fuente3, Brushes.Black, 50, 245)

                '    Grafico.DrawString("SALDO $ " + tarjeta_s.l_saldo.Text + " SIN INTERESES", Fuente3, Brushes.Black, 50, 270)


                '    Grafico.DrawString("PRESENTE ", Fuente3, Brushes.Black, 350, 340)

                '    Grafico.DrawString("EN RELACION A SU FALTA DE INTERES POR LIQUIDAR SU ADEUDO CON " + vbCrLf + "MOROMUEBLES. HACEMOS DE SU CONOCIMIENTO QUE PRESENTAREMOS DEMANDA " + vbCrLf + "JUDICIAL EN SU CONTRA, Y SE DEPOSITARA EN EL JUZGADO CORRESPONDIENTE, " + vbCrLf + "PROCEDIENDO A EJECUTAR DILIGENCIA DE EMBARGO, Y TODOS LOS GASTOS " + vbCrLf + "CORRERAN POR SU CUENTA.", Fuente3, Brushes.Black, 50, 400)
                '    Grafico.DrawString("SI USTED TIENE INTERES DE DETENER LA DEMANDA,  ANTES DE EMPLAZAR, PAGUE " + vbCrLf + "DE FORMA INMEDIATA A SU AGENTE DE COBRANZA O ACUDA CON CARÁCTER DE URGENTE " + vbCrLf + "A REALIZAR EL PAGO A NUESTRAS OFICINAS  EN " + vbCrLf + muebleria_direccion + "," + muebleria_ciudad + ".", Fuente3, Brushes.Black, 50, 500)

                '    Grafico.DrawString("PARA CUALQUIER DUDA O ACLARACION SOBRE ESTE ASUNTO, SIRVASE COMUNICARSE " + vbCrLf + "AL TELEFONO " + muebleria_tel + "  O PRESENTARSE DE 8 AM A 5 PM DE LUNES A SABADO EN EL " + vbCrLf + "DOMICILIO ANTES DESCRITO", Fuente3, Brushes.Black, 50, 600)


                '    Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 350, 700)

                '    Grafico.DrawString("__________________", Fuente3, Brushes.Black, 50, 800)
                '    Grafico.DrawString("CREDITO Y COBRANZA ", Fuente3, Brushes.Black, 50, 820)

                '    Grafico.DrawString("______________________", Fuente3, Brushes.Black, 350, 800)
                '    Grafico.DrawString("DEPARTAMENTO JURIDICO ", Fuente3, Brushes.Black, 350, 820)

                '    Grafico.DrawString("____________", Fuente3, Brushes.Black, 650, 800)
                '    Grafico.DrawString("MOROMUEBLES ", Fuente3, Brushes.Black, 650, 820)



        End Select
    End Sub

    Private Sub bt_f1_Click(sender As Object, e As EventArgs) Handles bt_f1.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            impr_cobra.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 1
            impr_cobra.Print()
        End If
    End Sub

    Private Sub bt_f2_Click(sender As Object, e As EventArgs) Handles bt_f2.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            impr_cobra.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 2
            impr_cobra.Print()
        End If
    End Sub
    Private Sub bt_f3_Click(sender As Object, e As EventArgs) Handles bt_f3.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            impr_cobra.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 3
            impr_cobra.Print()
        End If
    End Sub
    Private Sub bt_f4_Click(sender As Object, e As EventArgs)
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            impr_cobra.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 4
            impr_cobra.Print()
        End If
    End Sub

End Class