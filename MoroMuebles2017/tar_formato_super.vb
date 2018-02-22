Public Class tar_formato_super
    Dim fs As Integer
    Private Sub imprimir_sup_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles imprimir_sup.PrintPage
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
                Grafico.DrawString("A  V  I  S  O", Fuente, Brushes.Black, 350, 120)
                Grafico.DrawString(muebleria_ciudad + " A " + Now.ToString("D"), Fuente3, Brushes.Black, 20, 150)
                Grafico.DrawString("Estimado señor(a):" + lbl_nombre.Text, Fuente3, Brushes.Black, 20, 170)
                Grafico.DrawString("Pasamos a su domicilio a notificarle que su cuenta sigue teniendo un atraso de" + Str(pagoss) + " Abonos que", Fuente3, Brushes.Black, 20, 210)
                Grafico.DrawString("equivalen a $ " + tarjeta_s.lbl_atrazado.Text + "  retrazado.", Fuente3, Brushes.Black, 20, 230)
                Grafico.DrawString("Generando con esto un recargo en su saldo de $_______________. Esperando que en la próxima", Fuente3, Brushes.Black, 20, 250)
                Grafico.DrawString("visita del Sr. Cobrador liquide el atraso ya mencionado, o también puede pasar a visitarnos en nuestras", Fuente3, Brushes.Black, 20, 270)
                Grafico.DrawString("oficinas para llegar a un arreglo. Evitándose así más recargos y futuras molestias.", Fuente3, Brushes.Black, 20, 290)
                Grafico.DrawString("Recuerde   que  el  pago de  su  cuenta  es  en  abonos  y  nunca  a  plazo  cumplido.", Fuente3, Brushes.Black, 150, 340)
                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 370, 370)
                Grafico.DrawString("Departamento  de   crédito y cobranza", Fuente3, Brushes.Black, 310, 440)
                Grafico.DrawLine(Pens.Black, 280, 430, 600, 430)

            Case 2
                Dim pago_vence As Double = Val(tarjeta_s.lbl_atrazado.Text)
                Grafico.DrawString(muebleria_direccion + " A " + UCase(Now.ToString("D")), Fuente3, Brushes.Black, 20, 150)

                Grafico.DrawString("cuenta: " + lbl_venta.Text, Fuente3, Brushes.Black, 500, 150)
                Grafico.DrawString("Estimado señor(a):" + lbl_nombre.Text, Fuente3, Brushes.Black, 20, 170)
                Grafico.DrawString("por medio de este conducto me permito comunicarle a usted que tiene hasta el día de hoy ", Fuente3, Brushes.Black, 20, 190)
                Grafico.DrawString(pago_vence.ToString + "  $ de abono atrasado.", Fuente3, Brushes.Black, 20, 210)
                Grafico.DrawString("Por lo cual no esta cumpliendo con el contrato firmado por usted con la mueblería. Le pedimos ", Fuente3, Brushes.Black, 20, 230)
                Grafico.DrawString("se ponga al corriente dando su atraso o aumentando su pago a" + Str(pago_vence) + " $ ", Fuente3, Brushes.Black, 20, 250)
                Grafico.DrawString("Si dentro de los _______ días no tenemos respuesta de su parte por los motivos expuestos ", Fuente3, Brushes.Black, 20, 270)
                Grafico.DrawString("tendremos que recogerle _____________________________ ya que la mueblería ", Fuente3, Brushes.Black, 20, 290)
                Grafico.DrawString("únicamente espera al cliente tres pagos retrasados y además de que por lo estipulado en las ", Fuente3, Brushes.Black, 20, 310)
                Grafico.DrawString("clausulas del contrato, se le recogerá la mercancía sin regresar al cliente ningún abono. ", Fuente3, Brushes.Black, 20, 330)

                Grafico.DrawLine(Pens.Black, 280, 395, 600, 395)
                Grafico.DrawString("Atte.   Supervisor  regional", Fuente3, Brushes.Black, 310, 400)


            Case 3

                Grafico.DrawString("Despacho    Jurídico    MENLOBA", Fuente3, Brushes.Black, 50, 140)
                y = 80
                Grafico.DrawString("ESTIMADO(A): " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, y + 140)

                Grafico.DrawString("CUENTA No. " + lbl_venta.Text, Fuente3, Brushes.Black, 50, y + 170)
                Grafico.DrawString("RUTA: " + tarjeta_s.l_ruta.Text, Fuente3, Brushes.Black, 250, y + 170)
                Grafico.DrawString("OFICINA: " + muebleria_ciudad, Fuente3, Brushes.Black, 450, y + 170)

                Grafico.DrawString("ARTICULO(S) EN LITIGIO: " + articulos_venta, Fuente3, Brushes.Black, 50, y + 200)
                Grafico.DrawString("SALDO PENDIENTE $ " + tarjeta_s.lbl_atrazado.Text, Fuente3, Brushes.Black, 50, y + 230)

                Grafico.DrawString("PRESENTE: ", Fuente3, Brushes.Black, 50, y + 260)
                y = y + 60
                Grafico.DrawString("AVISO", Fuente3, Brushes.Black, 340, y + 280)

                Grafico.DrawString("Por  medio  de  este  conducto,  me  dirijo  a  UD ,  con  el  objeto  de  recordarle" + vbCrLf + "que  a la  fecha  en  que  recibe  el  presente  aviso, tiene  varios  " + vbCrLf + "pagos  atrasados  con  la  mueblería MOROMUEBLES , respecto  del  o  los  " + vbCrLf + "artículos  que  adquirió  mediante contrato  de  compra- venta  de  esta  empresa.", Fuente3, Brushes.Black, 50, y + 310)

                Grafico.DrawString("Igualmente , también  es  importante  recordarle que al  acumularse  " + vbCrLf + "consecutivamente tres pagos atrasados, la deuda se  hace exigible  en  su  " + vbCrLf + "totalidad, y  a partir  del  primer  atraso,  se  cobran los intereses moratorios, " + vbCrLf + "según se desprende  del  contrato que usted firmo y  que  obra en la empresa.", Fuente3, Brushes.Black, 50, y + 400)
                Grafico.DrawString("Por los motivos expuestos, es recomendable que con el carácter de urgente, se " + vbCrLf + "regularice su saldo, estando al corriente en sus pagos, ya sea con su cobrador o " + vbCrLf + "bien en  el siguiente domicilio: " + muebleria_direccion + vbCrLf + " " + muebleria_ciudad + ".  A fin de evitar la iniciación de un proceso judicial en " + vbCrLf + "su contra, en el que se le sumaran a su saldo, los intereses moratorios que " + vbCrLf + "correspondan más el pago de gastos, constas judicial y honorarios.", Fuente3, Brushes.Black, 50, y + 500)


                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 340, y + 700)
                Grafico.DrawString("____________________________________________", Fuente3, Brushes.Black, 200, y + 750)
                Grafico.DrawString("David  Torres  Ramírez", Fuente3, Brushes.Black, 300, y + 770)
                Grafico.DrawString("ABOGADO", Fuente3, Brushes.Black, 330, y + 800)

            Case 4

                Grafico.DrawString("FECHA: " + Format(Now, "dd-MM-yyyy"), Fuente3, Brushes.Black, 50, 140)
                Grafico.DrawString("CUENTA: " + lbl_venta.Text, Fuente3, Brushes.Black, 250, 140)
                Grafico.DrawString("CLIENTE: " + lbl_clave_cliente.Text, Fuente3, Brushes.Black, 450, 140)

                Grafico.DrawString("SR(A).: " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, 170)

                Grafico.DrawString("DIRECCION: " + tarjeta_s.l_dir.Text, Fuente3, Brushes.Black, 50, 200)

                Grafico.DrawString("ARTICULO EN LITIGIO: " + articulos_venta, Fuente3, Brushes.Black, 50, 245)

                Grafico.DrawString("SALDO $ " + tarjeta_s.l_saldo.Text + " SIN INTERESES", Fuente3, Brushes.Black, 50, 270)


                Grafico.DrawString("PRESENTE ", Fuente3, Brushes.Black, 350, 340)

                Grafico.DrawString("EN RELACION A SU FALTA DE INTERES POR LIQUIDAR SU ADEUDO CON " + vbCrLf + "MOROMUEBLES. HACEMOS DE SU CONOCIMIENTO QUE PRESENTAREMOS DEMANDA " + vbCrLf + "JUDICIAL EN SU CONTRA, Y SE DEPOSITARA EN EL JUZGADO CORRESPONDIENTE, " + vbCrLf + "PROCEDIENDO A EJECUTAR DILIGENCIA DE EMBARGO, Y TODOS LOS GASTOS " + vbCrLf + "CORRERAN POR SU CUENTA.", Fuente3, Brushes.Black, 50, 400)
                Grafico.DrawString("SI USTED TIENE INTERES DE DETENER LA DEMANDA,  ANTES DE EMPLAZAR, PAGUE " + vbCrLf + "DE FORMA INMEDIATA A SU AGENTE DE COBRANZA O ACUDA CON CARÁCTER DE URGENTE " + vbCrLf + "A REALIZAR EL PAGO A NUESTRAS OFICINAS  EN " + vbCrLf + muebleria_direccion + "," + muebleria_ciudad + ".", Fuente3, Brushes.Black, 50, 500)

                Grafico.DrawString("PARA CUALQUIER DUDA O ACLARACION SOBRE ESTE ASUNTO, SIRVASE COMUNICARSE " + vbCrLf + "AL TELEFONO " + muebleria_tel + "  O PRESENTARSE DE 8 AM A 5 PM DE LUNES A SABADO EN EL " + vbCrLf + "DOMICILIO ANTES DESCRITO", Fuente3, Brushes.Black, 50, 600)


                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 350, 700)

                Grafico.DrawString("__________________", Fuente3, Brushes.Black, 50, 800)
                Grafico.DrawString("CREDITO Y COBRANZA ", Fuente3, Brushes.Black, 50, 820)

                Grafico.DrawString("______________________", Fuente3, Brushes.Black, 350, 800)
                Grafico.DrawString("DEPARTAMENTO JURIDICO ", Fuente3, Brushes.Black, 350, 820)

                Grafico.DrawString("____________", Fuente3, Brushes.Black, 650, 800)
                Grafico.DrawString("MOROMUEBLES ", Fuente3, Brushes.Black, 650, 820)


            Case 5
                Grafico.DrawString("SR(A).: " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, 140)
                Grafico.DrawString("CUENTA: " + lbl_venta.Text, Fuente3, Brushes.Black, 600, 140)
                Grafico.DrawString("ARTICULO EN LITIGIO: " + articulos_venta, Fuente3, Brushes.Black, 50, 180)
                Grafico.DrawString("SALDO $ " + tarjeta_s.l_saldo.Text + " SIN INTERESES", Fuente3, Brushes.Black, 600, 180)

                Grafico.DrawString("N O T I F I C A C I O N", Fuente3, Brushes.Black, 300, 220)

                Grafico.DrawString("Por  medio  de  este  conducto,  nos  dirigimos  a  usted  con el  objeto  de informarle  que  " + vbCrLf + "MoroMuebles nos  a  endosado  un  documento  de  los  denominados  por  la ley  PAGARES  " + vbCrLf + "por  la  cantidad  de  $   XXXXX,  dicho  documento, ampara el  adeudo  que  usted  tiene  con  la  citada  " + vbCrLf + "mueblería, respecto de  los  artículos  que  adquirió  mediante  compra – venta.", Fuente3, Brushes.Black, 50, 250)

                Grafico.DrawString("En  términos  de  la  ley general de títulos y operaciones de crédito y comercio la casa  acreedora tiene " + vbCrLf + "derecho de que el juez competente dicte acuerdo de embargo de bienes del deudor hasta por 3 veces el " + vbCrLf + "importe del adeudo poniendo en deposito de la persona que designe al acreedor, en caso de opción, el " + vbCrLf + "juez tiene la facultad de dictar las medidas de apremio que considere pertinentes, tales como el " + vbCrLf + "remate de bienes embargados.", Fuente3, Brushes.Black, 50, 350)
                Grafico.DrawString("SI USTED TIENE INTERES DE DETENER LA DEMANDA,  ANTES DE EMPLAZAR, PAGUE " + vbCrLf + "DE FORMA INMEDIATA A SU AGENTE DE COBRANZA O ACUDA CON CARÁCTER DE URGENTE " + vbCrLf + "A REALIZAR EL PAGO A NUESTRAS OFICINAS  EN " + vbCrLf + muebleria_direccion + muebleria_ciudad + "." + "", Fuente3, Brushes.Black, 50, 500)


                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 350, 650)


                Grafico.DrawString("lic.   DAVID  TORRES  RAMIREZ", Fuente3, Brushes.Black, 350, 700)
               ' Grafico.DrawString("SI USTED TIENE INTERES DE DETENER LA DEMANDA,  ANTES DE EMPLAZAR, PAGUE " + vbCrLf + "DE FORMA INMEDIATA A SU AGENTE DE COBRANZA O ACUDA CON CARÁCTER DE URGENTE " + vbCrLf + "A REALIZAR EL PAGO A NUESTRAS OFICINAS  EN CARRETERA A MORELIA 1374  COL " + vbCrLf + "EVERARDO MORALES  DE ACAMBARO  GTO." + "", Fuente3, Brushes.Black, 50, 500)

            Case 6




                Grafico.DrawString("SR(A).: " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, 140)
                'Grafico.DrawString("CUENTA: " + Me.Label15.Text, Fuente3, Brushes.Black, 600, 140)
                Grafico.DrawString("ARTICULO EN LITIGIO: " + articulos_venta, Fuente3, Brushes.Black, 50, 180)
                Grafico.DrawString("SALDO $ " + tarjeta_s.l_saldo.Text + " SIN INTERESES", Fuente3, Brushes.Black, 600, 180)

                Grafico.DrawString("PRESENTE", Fuente3, Brushes.Black, 50, 220)


                Grafico.DrawString("Por  medio  de  este conducto, me dirijo  a usted, con el objeto de hacer  de su conocimiento, que la " + vbCrLf + "mueblería MOROMUEBLES  ha  endosado  a mí favor por conducto de su apoderado legal, un pagare que " + vbCrLf + "ampara el saldo inicial que se menciona en este requerimiento.", Fuente3, Brushes.Black, 50, 250)
                Grafico.DrawString("SI USTED TIENE INTERES DE DETENER LA DEMANDA,  ANTES DE EMPLAZAR, PAGUE " + vbCrLf + "DE FORMA INMEDIATA A SU AGENTE DE COBRANZA O ACUDA CON CARÁCTER DE URGENTE " + vbCrLf + "A REALIZAR EL PAGO A NUESTRAS OFICINAS  EN " + vbCrLf + muebleria_direccion + muebleria_ciudad + "." + "", Fuente3, Brushes.Black, 50, 500)
                Grafico.DrawString("De  lo  contrario me veré en la penosa necesidad de  acudir a los  tribunales  competentes  en  la " + vbCrLf + "materia y llevar  acabo  el  embargo precautorio  de  bienes  que  garanticen la  suerte  principal , así como  el " + vbCrLf + "pago  inmediato de intereses moratorios , honorarios  profesionales, gastos ordinarios y extraordinarios  que  se " + vbCrLf + "generen con motivo  de la tramitación del juicio respectivo  así que  queda enterado (a)  del juicio que se llevara " + vbCrLf + "en su contra así como los gastos que originen en cada visita a los tribunales de la ciudad en la que se tramite,  y  " + vbCrLf + "que  serán cargados  a su  cuenta.", Fuente3, Brushes.Black, 50, 450)

                Grafico.DrawString("ATENTAMENTE", Fuente3, Brushes.Black, 350, 650)

                Grafico.DrawString("lic.   DAVID  TORRES  RAMIREZ", Fuente3, Brushes.Black, 350, 700)

            Case 7

                Grafico.DrawString(muebleria_ciudad + ". A " + UCase(Now.ToString("D")), Fuente3, Brushes.Black, 50, 150)


                Grafico.DrawString("SR(A).: " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, 170)
                'Grafico.DrawString("CUENTA: " + Me.Label15.Text, Fuente3, Brushes.Black, 600, 140)
                Grafico.DrawString("ARTICULO EN LITIGIO: " + articulos_venta, Fuente3, Brushes.Black, 50, 190)

                Grafico.DrawString("Despacho    Jurídico    MENLOBA", Fuente3, Brushes.Black, 300, 240)
                Grafico.DrawString("I N F O R M A", Fuente3, Brushes.Black, 350, 280)




                Grafico.DrawString("Se ha iniciado una demanda mercantil en su contra, evite que se le embarguen sus bienes.", Fuente3, Brushes.Black, 50, 350)

                Grafico.DrawString("Al no haber tenido repuesta del pago que adeuda a la mueblería MOROMUEBLES nos vemos en" + vbCrLf + "la penosa necesidad de molestar a sus referencias familiares, amistades y avales que UD proporciono" + vbCrLf + "a la hora de elaborar el contrato de compra-venta, por otro lado el juicio en su contra continua y la" + vbCrLf + "diligencia de embargo en su domicilio se realizara sin previo aviso y puede tener lugar en cualquier" + vbCrLf + "momento. También ya le registramos en el buró nacional de crédito como demandado cuyos" + vbCrLf + "registros son consultados por bancos, compañías automotrices, arrendadoras, compañías telefónicas," + vbCrLf + "establecimientos comerciales o tiendas departamentales, entre otros para evaluar a los solicitantes de un" + vbCrLf + "crédito, lo que le afectara para cuando solicite tarjetas de crédito, créditos hipotecarios, prestamos" + vbCrLf + "personales, financiamiento automotriz, tarjetas de tiendas departamentales, arrendamientos de casas o" + vbCrLf + "departamentos, llegando incluso hasta la cancelación de los mismos.", Fuente3, Brushes.Black, 50, 370)

                Grafico.DrawString("Y todo estos  puede  resolverse  pagando.  Sus  pagares  tienen   XXX   días  de  vencidos  y  el  total  que  " + vbCrLf + "adeuda  a la fecha  es  de  $   XXXXXXXX.", Fuente3, Brushes.Black, 50, 570)

                Grafico.DrawString("Esta  es  la  ultima  oportunidad  de  pagar  sin  intereses  , de  que  se  detenga la  demanda y  que  le  " + vbCrLf + "borremos  del  buró   nacional  de  crédito.", Fuente3, Brushes.Black, 50, 610)

                Grafico.DrawString("Evítese  las   penas  tanto económicas  como  morales  que  un  embargo    implica  liquide  su  adeudo  antes  " + vbCrLf + "del  día   XXXXXXXXXXXXXXXXXXXXXX  ya   que  si  así  lo  hiciera   el  saldo  que  tendría  que  " + vbCrLf + "depositar  sin  los  intereses  seria  de $   XXXXXXX  UD  sale  ahorrando   $   XXXXXXXX   y  no  habrá  " + vbCrLf + "embargo  judicial ,  aproveche  esta  ultima  oportunidad  liquidando. Saque  sus  ahorros, pida  prestado, " + vbCrLf + "venda  algo. ya que  después   del  ultimo  día  de  plazo  no  le  aseguramos  detener  el  embargo  y  " + vbCrLf + "dependemos  del  viaje  del  actuario  del  juzgado  y  de  la mudanza.  No  hay  plazo  que  no  se  cumpla,  " + vbCrLf + "un  pagare  es  pagadero  y  autónomo.  Si  quiere  aprovechar  esta  ultima  oportunidad  visítenos  con  su  " + vbCrLf + "liquidación  total  en  las  oficinas  del  despacho  jurídico  MENLOBA  con  el  licenciado  o  directamente  a " + vbCrLf + "las  oficinas  de  la  mueblería  en  un  plazo  no  mayor  a  24  horas.", Fuente3, Brushes.Black, 50, 650)


                Grafico.DrawString("DEPARTAMENTO JURIDICO", Fuente3, Brushes.Black, 350, 850)
                Grafico.DrawLine(Pens.Black, 300, 950, 600, 950)




            Case 8

                Grafico.DrawString("Despacho    Jurídico    MENLOBA", Fuente3, Brushes.Black, 300, 150)

                Grafico.DrawString("SR(A).: " + lbl_nombre.Text, Fuente3, Brushes.Black, 50, 200)
                Grafico.DrawString("CUENTA: " + lbl_venta.Text, Fuente3, Brushes.Black, 50, 220)
                Grafico.DrawString("Demanda No. 354554-45" + lbl_venta.Text, Fuente3, Brushes.Black, 550, 220)

                Grafico.DrawString("ARTICULO EN LITIGIO: " + articulos_venta, Fuente3, Brushes.Black, 50, 240)





                Grafico.DrawString("En relación al juicio ejecutivo mercantil que tenemos promovido en su contra derivado del adeudo " + vbCrLf + "que tiene con MOROMUEBLES nos permitimos manifestarle que por esta ultima ocasión se le dará " + vbCrLf + "la oportunidad de pasar a liquidar su adeudo, en un termino que no exceda las 24 horas.", Fuente3, Brushes.Black, 50, 300)
                Grafico.DrawString("En caso contrario entenderemos que a hecho caso omiso a la presente y en consecuencia se continuara " + vbCrLf + "con el procedimiento judicial consistente en la diligencia de embargo aplicándose las medidas de " + vbCrLf + "apremio necesarias que comprenden el rompimiento de chapas y cerraduras así como la " + vbCrLf + "utilización de la fuerza publica en caso de ser necesario al fin de complementar el acto de ejecución.", Fuente3, Brushes.Black, 50, 400)


                Grafico.DrawString("   ATENTAMENTE", Fuente3, Brushes.Black, 350, 600)
                Grafico.DrawString("DEPARTAMENTO JURIDICO", Fuente3, Brushes.Black, 350, 700)
                Grafico.DrawString(muebleria_ciudad + " A " + UCase(Now.ToString("D")), Fuente3, Brushes.Black, 50, 750)

        End Select
    End Sub

    Private Sub bt_f1_Click(sender As Object, e As EventArgs) Handles bt_f1.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 1
            imprimir_sup.Print()
        End If
    End Sub

    Private Sub bt_f2_Click(sender As Object, e As EventArgs) Handles bt_f2.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 2
            imprimir_sup.Print()
        End If
    End Sub
    Private Sub bt_f3_Click(sender As Object, e As EventArgs) Handles bt_f3.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 3
            imprimir_sup.Print()
        End If
    End Sub
    Private Sub bt_f4_Click(sender As Object, e As EventArgs) Handles bt_f4.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 4
            imprimir_sup.Print()
        End If
    End Sub
    Private Sub bt_f5_Click(sender As Object, e As EventArgs) Handles bt_f5.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 5
            imprimir_sup.Print()
        End If
    End Sub
    Private Sub bt_f6_Click(sender As Object, e As EventArgs) Handles bt_f6.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 6
            imprimir_sup.Print()
        End If
    End Sub
    Private Sub bt_f7_Click(sender As Object, e As EventArgs) Handles bt_f7.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 7
            imprimir_sup.Print()
        End If
    End Sub
    Private Sub bt_f8_Click(sender As Object, e As EventArgs) Handles bt_f8.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 8
            imprimir_sup.Print()
        End If
    End Sub
    Private Sub bt_f9_Click(sender As Object, e As EventArgs) Handles bt_f9.Click
        If Me.PrintDialog1.ShowDialog = DialogResult.OK Then
            imprimir_sup.PrinterSettings = Me.PrintDialog1.PrinterSettings
            fs = 9
            imprimir_sup.Print()
        End If
    End Sub
End Class