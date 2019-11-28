Public Class TE_RE_Facturas_por_fecha

    Private Sub TE_RE_Facturas_por_fecha_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        uce_tipCom.SelectedIndex = 0
        btn_Consultar.Appearance.Image = My.Resources._16__Search_
        udte_fecha1.Value = Now
        udte_fecha2.Value = Now
        upb_fts.Visible = False
    End Sub

    Private Sub Tool_Salir_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub btn_Consultar_Click(sender As System.Object, e As System.EventArgs) Handles btn_Consultar.Click
        Dim tesoreriaBL As New BL.TesoreriaBL.SG_TE_TB_REPORTES
        ug_fts.DataSource = tesoreriaBL.get_Lista_Factu_x_fecha(uce_tipCom.Value, CDate(udte_fecha1.Value).ToShortDateString, CDate(udte_fecha2.Value).ToShortDateString, gInt_IdEmpresa)
        tesoreriaBL = Nothing
    End Sub

    Private Sub ug_fts_InitializeRow(sender As System.Object, e As Infragistics.Win.UltraWinGrid.InitializeRowEventArgs) Handles ug_fts.InitializeRow
        If e.Row.Cells("ESTADO").Value.ToString = "ANULADO" Then
            e.Row.Appearance.ForeColor = Color.Tomato
        End If
    End Sub

    Private Sub Tool_Exportar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Exportar.Click

        Try
            Me.Cursor = Cursors.WaitCursor
       
            Const xlEdgeLeft = 7
            Const xlEdgeRight = 10
            Const xlEdgeTop = 8
            Const xlEdgeBottom = 9
            Const xlInsideHorizontal = 12
            Const xlInsideVertical = 11
            Const xlContinuous = 1
            Const xlThin = 2

            Dim excel As Object
            Dim wBook As Object
            Dim wSheet As Object

            excel = CreateObject("Excel.Application")
            wBook = excel.Workbooks.Add
            wSheet = wBook.Worksheets(1)


            wSheet.Name = CDate(udte_fecha1.Value).Day & "." & CDate(udte_fecha1.Value).Month & "__" & CDate(udte_fecha2.Value).Day & "." & CDate(udte_fecha2.Value).Month
            wSheet.Range("A1", "A3").Font.Bold = True
            wSheet.Range("C1", "C2").Font.Bold = True

            wSheet.Range("B3", "C3").Font.Bold = True

            wSheet.Range("D8", "D35").NumberFormat = "#,##0.00"
            wSheet.Range("H8", "H35").NumberFormat = "#,##0.00"

            wSheet.Range("B3", "C3").Merge()
            wSheet.Range("B3", "C3").HorizontalAlignment = 3
            wSheet.Range("B1", "C1").Merge()
            wSheet.Range("B1", "C1").HorizontalAlignment = 3

            excel.Cells(1, 1) = "Empresa :"
            excel.Cells(1, 2) = gStr_NomEmpresa

            excel.Cells(3, 1) = "Reporte :"
            excel.Cells(3, 2) = "Facturas por Fecha "

            'wSheet.Range("C3", "G3").HorizontalAlignment = 3'HorizontalAlignment.Center
            'wSheet.Range("C3", "G4").Interior.ColorIndex = 34
            'wSheet.Range("C3", "G4").Font.ColorIndex = 0

            'With wSheet.Range("C3", "G4").Borders(xlEdgeBottom)
            '    .Weight = xlThin
            '    .LineStyle = xlContinuous
            '    .ColorIndex = 0
            'End With

            'With wSheet.Range("C3", "G4").Borders(xlEdgeTop)
            '    .Weight = xlThin
            '    .LineStyle = xlContinuous
            '    .ColorIndex = 0
            'End With

            'wSheet.Range("C3", "G4").Interior.ColorIndex = 34
            'wSheet.Range("C3", "G4").Font.ColorIndex = 0


            Dim FilaInicioTmp As Integer = 4
            Dim fecha As String = ""

            upb_fts.Minimum = 0
            upb_fts.Maximum = ug_fts.Rows.Count
            upb_fts.Value = 0
            upb_fts.Visible = True

            For f As Integer = 0 To ug_fts.Rows.Count - 1

                If fecha <> CDate(ug_fts.Rows(f).Cells("FECHA").Value).ToShortDateString Then
                    fecha = CDate(ug_fts.Rows(f).Cells("FECHA").Value).ToShortDateString
                    FilaInicioTmp += 2

                    excel.Cells(FilaInicioTmp, 1) = "Facturas del " & fecha
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Merge()
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Font.Bold = True
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Font.size = 20
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).HorizontalAlignment = 3
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Font.ColorIndex = 25


                    FilaInicioTmp += 1
                    For c As Integer = 1 To ug_fts.DisplayLayout.Bands(0).Columns.Count
                        excel.Cells(FilaInicioTmp, c) = ug_fts.DisplayLayout.Bands(0).Columns(c - 1).Header.Caption.ToString
                    Next

                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Interior.ColorIndex = 47
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Font.ColorIndex = 2
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Font.Bold = True
                    wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).HorizontalAlignment = 3


                    With wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Borders(xlEdgeBottom)
                        .Weight = xlThin
                        .LineStyle = xlContinuous
                        .ColorIndex = 0
                    End With

                    With wSheet.Range("A" & FilaInicioTmp, "M" & FilaInicioTmp).Borders(xlEdgeTop)
                        .Weight = xlThin
                        .LineStyle = xlContinuous
                        .ColorIndex = 0
                    End With


                    FilaInicioTmp += 1

                    excel.Cells(FilaInicioTmp, 1) = ug_fts.Rows(f).Cells("fecha").Value
                    excel.Cells(FilaInicioTmp, 2) = ug_fts.Rows(f).Cells("factura").Value
                    excel.Cells(FilaInicioTmp, 3) = ug_fts.Rows(f).Cells("ruc").Value
                    excel.Cells(FilaInicioTmp, 4) = ug_fts.Rows(f).Cells("MONEDA").Value
                    excel.Cells(FilaInicioTmp, 5) = ug_fts.Rows(f).Cells("TIPCAM").Value
                    excel.Cells(FilaInicioTmp, 6) = ug_fts.Rows(f).Cells("SUBTOTAL").Value
                    excel.Cells(FilaInicioTmp, 7) = ug_fts.Rows(f).Cells("IGV").Value
                    excel.Cells(FilaInicioTmp, 8) = ug_fts.Rows(f).Cells("TOTAL").Value
                    excel.Cells(FilaInicioTmp, 9) = ug_fts.Rows(f).Cells("PACIENTE").Value
                    excel.Cells(FilaInicioTmp, 10) = ug_fts.Rows(f).Cells("USUARIO").Value
                    excel.Cells(FilaInicioTmp, 11) = ug_fts.Rows(f).Cells("OBSERVACIONES").Value
                    excel.Cells(FilaInicioTmp, 12) = ug_fts.Rows(f).Cells("FORMA_PAGO").Value
                    excel.Cells(FilaInicioTmp, 13) = ug_fts.Rows(f).Cells("ESTADO").Value
                    FilaInicioTmp += 1
                Else

                    excel.Cells(FilaInicioTmp, 1) = ug_fts.Rows(f).Cells("fecha").Value
                    excel.Cells(FilaInicioTmp, 2) = ug_fts.Rows(f).Cells("factura").Value
                    excel.Cells(FilaInicioTmp, 3) = ug_fts.Rows(f).Cells("ruc").Value
                    excel.Cells(FilaInicioTmp, 4) = ug_fts.Rows(f).Cells("MONEDA").Value
                    excel.Cells(FilaInicioTmp, 5) = ug_fts.Rows(f).Cells("TIPCAM").Value
                    excel.Cells(FilaInicioTmp, 6) = ug_fts.Rows(f).Cells("SUBTOTAL").Value
                    excel.Cells(FilaInicioTmp, 7) = ug_fts.Rows(f).Cells("IGV").Value
                    excel.Cells(FilaInicioTmp, 8) = ug_fts.Rows(f).Cells("TOTAL").Value
                    excel.Cells(FilaInicioTmp, 9) = ug_fts.Rows(f).Cells("PACIENTE").Value
                    excel.Cells(FilaInicioTmp, 10) = ug_fts.Rows(f).Cells("USUARIO").Value
                    excel.Cells(FilaInicioTmp, 11) = ug_fts.Rows(f).Cells("OBSERVACIONES").Value
                    excel.Cells(FilaInicioTmp, 12) = ug_fts.Rows(f).Cells("FORMA_PAGO").Value
                    excel.Cells(FilaInicioTmp, 13) = ug_fts.Rows(f).Cells("ESTADO").Value
                    FilaInicioTmp += 1

                End If
                upb_fts.IncrementValue(1)
            Next
            upb_fts.Visible = False
            

            wSheet.Columns.AutoFit()

            '****************** finalizamos *******************
            Dim strFileName As String = Application.StartupPath & "Facturas_" & Now.Year & Now.Month & Now.Day & Now.Hour & Now.Minute & ".xls"
            Dim blnFileOpen As Boolean = False
            Try
                Dim fileTemp As System.IO.FileStream = System.IO.File.OpenWrite(strFileName)
                fileTemp.Close()
            Catch ex As Exception
                blnFileOpen = False
            End Try

            If System.IO.File.Exists(strFileName) Then
                System.IO.File.Delete(strFileName)
            End If

            wBook.SaveAs(strFileName)
            excel.Workbooks.Open(strFileName)
            excel.Visible = True

            Me.Cursor = Cursors.Default

        Catch ex As Exception
            Me.Cursor = Cursors.Default
        End Try
    End Sub
End Class