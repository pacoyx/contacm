Module ModAdmision
    Public ServicioEmergencia As Integer = 22

    Public Function fKeyPress(ByVal oChar As String,
                         ByVal oDato As String,
                         Optional ByVal oTipo As Integer = 1,
                         Optional ByVal oMay As Boolean = True) As String

        Dim vChar As String = oChar
        Dim vCadena As String = ""
        If Asc(vChar) = 13 Then vChar = Convert.ToChar(Keys.Tab)
        If Asc(vChar) = 8 Then GoTo oReturnOK
        ' If oMay Then vChar = UCase(oChar)
        Select Case oTipo
            Case 1      ' Enteros
                vCadena = "0123456789"
                If InStr(vCadena, vChar) = 0 Then GoTo oReturnErr
            Case 2      ' Decimales
                vCadena = "0123456789."
                If InStr(vCadena, vChar) = 0 Then GoTo oReturnErr
                If vChar = "." Then If InStr(oDato, vChar) > 0 Then GoTo oReturnErr
            Case 101    ' Cadenas
                vCadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ "
                If InStr(vCadena, vChar) = 0 Then GoTo oReturnErr
            Case 102    ' Direccion
                vCadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ-1234567890. "
                If InStr(vCadena, vChar) = 0 Then GoTo oReturnErr
            Case 103    'Mail
                vCadena = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZ-1234567890.@_"
                If InStr(vCadena, vChar) = 0 Then GoTo oReturnErr
        End Select
oReturnOK:
        Return vChar
        Exit Function
oReturnErr:
        Return ""
    End Function

End Module
