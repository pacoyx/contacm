Public Class SO_RE_PROGRAMACION

    Private Sub SO_RE_PROGRAMACION_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        utc_Datos.Tabs(0).Text = Format(Now.Date, "dddd dd, MMMM yyyy")
        utc_Datos.Tabs(1).Text = Format(DateAdd(DateInterval.Day, 1, Now.Date), "dddd dd, MMMM yyyy")
        utc_Datos.Tabs(2).Text = Format(DateAdd(DateInterval.Day, 2, Now.Date), "dddd dd, MMMM yyyy")
        utc_Datos.Tabs(3).Text = Format(DateAdd(DateInterval.Day, 3, Now.Date), "dddd dd, MMMM yyyy")
        utc_Datos.Tabs(4).Text = Format(DateAdd(DateInterval.Day, 4, Now.Date), "dddd dd, MMMM yyyy")

        utc_Datos.Tabs(0).Selected = True
        Cargar()
    End Sub

    Private Sub Tool_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Consultar.Click
        Cargar()
    End Sub
    Private Sub Cargar()
        Dim ReportBL As New BL.SalaOperacionBL.SG_SO_TB_Reportes
        ug_Lista.DataSource = ReportBL.get_PROGRAMACION(Now.Date.ToString)
        ug_Lista2.DataSource = ReportBL.get_PROGRAMACION(DateAdd(DateInterval.Day, 1, Now.Date))
        ug_Lista3.DataSource = ReportBL.get_PROGRAMACION(DateAdd(DateInterval.Day, 2, Now.Date))
        ug_Lista4.DataSource = ReportBL.get_PROGRAMACION(DateAdd(DateInterval.Day, 3, Now.Date))
        ug_Lista5.DataSource = ReportBL.get_PROGRAMACION(DateAdd(DateInterval.Day, 4, Now.Date))

        ug_Lista.DisplayLayout.Bands(0).Columns(0).Width = 90
        ug_Lista.DisplayLayout.Bands(0).Columns(1).Width = 40
        ug_Lista.DisplayLayout.Bands(0).Columns(2).Width = 260
        ug_Lista.DisplayLayout.Bands(0).Columns(3).Width = 200
        ug_Lista.DisplayLayout.Bands(0).Columns(4).Width = 200
        ug_Lista.DisplayLayout.Bands(0).Columns(5).Width = 150

        ug_Lista2.DisplayLayout.Bands(0).Columns(0).Width = 90
        ug_Lista2.DisplayLayout.Bands(0).Columns(1).Width = 40
        ug_Lista2.DisplayLayout.Bands(0).Columns(2).Width = 260
        ug_Lista2.DisplayLayout.Bands(0).Columns(3).Width = 200
        ug_Lista2.DisplayLayout.Bands(0).Columns(4).Width = 200
        ug_Lista2.DisplayLayout.Bands(0).Columns(5).Width = 150

        ug_Lista3.DisplayLayout.Bands(0).Columns(0).Width = 90
        ug_Lista3.DisplayLayout.Bands(0).Columns(1).Width = 40
        ug_Lista3.DisplayLayout.Bands(0).Columns(2).Width = 260
        ug_Lista3.DisplayLayout.Bands(0).Columns(3).Width = 200
        ug_Lista3.DisplayLayout.Bands(0).Columns(4).Width = 200
        ug_Lista3.DisplayLayout.Bands(0).Columns(5).Width = 150

        ug_Lista4.DisplayLayout.Bands(0).Columns(0).Width = 90
        ug_Lista4.DisplayLayout.Bands(0).Columns(1).Width = 40
        ug_Lista4.DisplayLayout.Bands(0).Columns(2).Width = 260
        ug_Lista4.DisplayLayout.Bands(0).Columns(3).Width = 200
        ug_Lista4.DisplayLayout.Bands(0).Columns(4).Width = 200
        ug_Lista4.DisplayLayout.Bands(0).Columns(5).Width = 150

        ug_Lista5.DisplayLayout.Bands(0).Columns(0).Width = 90
        ug_Lista5.DisplayLayout.Bands(0).Columns(1).Width = 40
        ug_Lista5.DisplayLayout.Bands(0).Columns(2).Width = 260
        ug_Lista5.DisplayLayout.Bands(0).Columns(3).Width = 200
        ug_Lista5.DisplayLayout.Bands(0).Columns(4).Width = 200
        ug_Lista5.DisplayLayout.Bands(0).Columns(5).Width = 150
    End Sub

    Private Sub Tool_Salir_Click_1(sender As System.Object, e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub
End Class