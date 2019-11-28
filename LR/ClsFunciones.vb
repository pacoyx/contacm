Imports System.Data
Imports System.IO
Imports Microsoft.Office.Interop
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared

Public Class ClsFunciones

    Public Sub exportar_A_OO_Calc(ByVal dt_datos As DataTable, ByVal Str_Titulo As String)
        Try

            Dim ServiceManager As Object
            Dim Desktop As Object
            Dim Document As Object
            Dim Feuille As Object


            Dim PrintArea(0)
            Dim PrintArgs(2)

            ' Creacion de un service OpenOffice
            ServiceManager = CreateObject("com.sun.star.ServiceManager")
            Desktop = ServiceManager.createInstance("com.sun.star.frame.Desktop")

            Dim args(-1) As Object
            'args = ServiceManager.Bridge_GetStruct("com.sun.star.beans.PropertyValue")
            'args(0).Name = "Dummy!"
            'args(0).Value = 0

            Document = Desktop.loadComponentFromURL("private:factory/scalc", "_blank", 0, args)
            Feuille = Document.getSheets().getByIndex(0)

            Const ROW_FIRST = 4
            Dim iRow As Int64 = 1
            Dim iCols As Int16 = dt_datos.Columns.Count

            Call Feuille.getcellbyposition(1, 1).setFormula(Str_Titulo)
            'oSheet.Cells(1, 1).font.bold = True


            'Llenamos la cabecera
            For i As Integer = 1 To iCols - 1
                Call Feuille.getcellbyposition(i, ROW_FIRST).setFormula(dt_datos.Columns(i).Caption)
            Next

            'Llenamos las filas
            For j As Integer = 0 To dt_datos.Rows.Count - 1
                Dim iCurrRow As Int64 = ROW_FIRST + iRow

                For iCol As Integer = 1 To iCols - 1
                    Call Feuille.getcellbyposition(iCol, iCurrRow).setFormula(dt_datos.Rows(j)(iCol))
                Next

                iRow += 1
            Next

            Call Document.getCurrentController.getFrame.getContainerWindow.setVisible(True)
            Call Document.getCurrentController.getFrame.getComponentWindow.setVisible(True)

        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub exportar_A_MS_Excel(ByVal dt_datos As DataTable, ByVal Str_Titulo As String)

        Dim oExcel As Object
        Dim oBooks As Object
        Dim oSheet As Object

        oExcel = CreateObject("Excel.Application")

        oBooks = oExcel.Workbooks

        'Inicia Excel y abre el workbook
        oExcel.Visible = True
        oBooks = oExcel.Workbooks.Add
        oSheet = oBooks.Sheets(1)

        Const ROW_FIRST = 4
        Dim iRow As Int64 = 1
        Dim iCols As Int16 = dt_datos.Columns.Count


        oSheet.Cells(1, 1) = Str_Titulo
        oSheet.Cells(1, 1).font.bold = True

        'Llenamos la cabecera
        For i As Integer = 0 To iCols - 1
            oSheet.Cells(ROW_FIRST, i + 1) = dt_datos.Columns(i).Caption
            oSheet.Cells(ROW_FIRST, i + 1).font.bold = True
            oSheet.Columns(i + 1).ColumnWidth = 15
        Next

        'Loop que almacena los datos
        For j As Integer = 0 To dt_datos.Rows.Count - 1
            Dim iCurrRow As Int64 = ROW_FIRST + iRow

            For iCol As Integer = 0 To iCols - 1
                oSheet.Cells(iCurrRow, iCol + 1) = dt_datos.Rows(j)(iCol)
            Next

            iRow += 1
        Next

    End Sub

    Public Function ReadBinaryFile(ByVal fileName As String) As Byte()
        'http://www.mvp-access.es/softjaen/bases/adonet/sjadonet13.htm
        ' Si no existe el archivo, abandono la función.
        '
        If Not System.IO.File.Exists(fileName) Then Return Nothing

        Try
            ' Creamos un objeto Stream para poder leer el archivo especificado.
            '
            Dim fs As New FileStream(fileName, FileMode.Open, FileAccess.Read)

            ' Creamos un array de bytes, cuyo límite superior se corresponderá
            ' con la longitud en bytes de la secuencia.
            '
            Dim data() As Byte = New Byte(Convert.ToInt32(fs.Length)) {}

            ' Al leer la secuencia, se rellenará la matriz.
            '
            fs.Read(data, 0, Convert.ToInt32(fs.Length))

            ' Cerramos la secuencia.
            '
            fs.Close()

            ' Devolvemos el array de bytes.
            '
            Return data

        Catch ex As Exception
            ' Cualquier excepción producida, hace que la
            ' función devuelva el valor Nothing.
            '
            Return Nothing

        End Try

    End Function

    Public Sub WriteBinaryFile(ByVal aByte() As Byte, _
                            ByVal fileName As String)
        'http://www.mvp-access.es/softjaen/bases/adonet/sjadonet14.htm
        ' El procedimiento creará un archivo con la secuencia de bytes
        ' especificada en el argumento.

        ' Compruebo los distintos parámetros pasados a la función.
        '
        If (aByte Is Nothing) OrElse (fileName = "") Then Return

        Try

            ' Compruebo si existe el archivo especificado.
            If System.IO.File.Exists(fileName) Then
                ' Elimino el archivo
                System.IO.File.Delete(fileName)
            End If

            ' Número de bytes que se van a escribir
            Dim data As Int64 = aByte.Length

            ' Obtengo el nombre de un archivo temporal, donde
            ' primeramente se guardará el documento.
            '
            Dim tempFileName As String = System.IO.Path.GetTempFileName

            ' Abrimos o creamos el archivo.
            Dim fs As New FileStream(tempFileName, FileMode.OpenOrCreate)

            ' Crea el escritor para los datos.
            Dim bw As New BinaryWriter(fs)

            ' Escribimos en el archivo los datos realmente leídos.
            bw.Write(aByte, 0, Convert.ToInt32(data))

            ' Borra todos los búferes del sistema de escritura actual y hace
            ' que todos los datos almacenados en el búfer se escriban en el
            ' dispositivo subyacente. 
            bw.Flush()

            ' Cerramos los distintos objetos.
            bw.Close()
            fs.Close()
            bw = Nothing
            fs = Nothing

            ' Muevo el archivo a la ruta indicada.
            System.IO.File.Move(tempFileName, fileName)

        Catch ex As Exception

        End Try

    End Sub

    Public Sub CrearPDF(ByVal ds As DataTable, ruta_ As String, ByRef ruta_archivo_pdf_ As String, ByRef nombre_archivo_ As String)

        'Esta es la instancia del reporte que tengo hecho con un binding del dataset tipado
        Dim cr As New SG_PL_21_1

        Dim parametros As New ParameterFields
        Dim parametro1 As New ParameterField
        Dim parametro2 As New ParameterField
        Dim dVal1 As New ParameterDiscreteValue
        Dim dVal2 As New ParameterDiscreteValue

        dVal1.Value = "Clinica Miraflores"
        dVal2.Value = "01/01/2012"

        parametro1.ParameterFieldName = "pEmp"
        parametro1.CurrentValues.Add(dVal1)

        parametro2.ParameterFieldName = "pFecha"
        parametro2.CurrentValues.Add(dVal2)

        parametros.Add(parametro1)
        parametros.Add(parametro2)




        cr.SetDataSource(ds)

        Try
            'En la siguiente línea determinamos el formato final del reporte. 
            cr.ExportOptions.ExportFormatType = CrystalDecisions.[Shared].ExportFormatType.PortableDocFormat
            Dim filedest As New CrystalDecisions.Shared.DiskFileDestinationOptions
            'Determinamos la ruta donde se va a crear nuestro archivo al finalizar el proceso en este caso,
            'concatenamos horas, minutos, segundos, para mantener control en caso de usar la misma ruta en otras instancias.
            nombre_archivo_ = "PDF" & Date.Now.Hour & Date.Now.Minute & Date.Now.Millisecond & ".pdf"
            Dim nombrearchivopdf As String = ruta_ & "\PDFS\" & nombre_archivo_
            filedest.DiskFileName = nombrearchivopdf
            ruta_archivo_pdf_ = nombrearchivopdf

            'Le pasamos al reporte el parámetro destino del reporte (ruta) 
            cr.ExportOptions.DestinationOptions = filedest
            'Le indicamos que el reporte no es para mostrarse en pantalla, sino, que es para guardar en disco
            cr.ExportOptions.ExportDestinationType = CrystalDecisions.[Shared].ExportDestinationType.DiskFile
            'Indicamos el formato de la página del reporte
            cr.PrintOptions.PaperOrientation = CrystalDecisions.[Shared].PaperOrientation.DefaultPaperOrientation
            'Finalmente exportamos el reporte a PDF
            cr.Export()
            'Como buenos samaritanos nos curamos en salud, y atrapamos las posibles excepciones que se pudieran presentar.
        Catch ex3 As CrystalDecisions.CrystalReports.Engine.InternalException
            MsgBox(ex3.Message & "       -----" & ex3.StackTrace)
        Catch ex2 As CrystalDecisions.CrystalReports.Engine.ExportException
            MsgBox("Se ha producido un error cargando los archivos a PDF. Error: " & ex2.Message, MsgBoxStyle.Information, "PDF Creator")
        Catch ex As System.IO.IOException
            MsgBox("Se ha producido un error cargando los archivos a PDF. Error: " & ex.Message, MsgBoxStyle.Information, "PDF Creator")
        End Try
    End Sub

End Class
