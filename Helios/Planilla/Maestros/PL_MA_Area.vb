Public Class PL_MA_Area

    Private Sub PL_MA_Area_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txt_des.Focus()
    End Sub

    Private Sub PL_MA_Area_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call Cargar_Personal_Jefe()
    End Sub

    Private Sub Cargar_Personal_Jefe()
        Dim personalBL As New BL.PlanillaBL.SG_PL_TB_PERSONAL
        uce_Jefe_Area.DataSource = personalBL.getPersonal_Cmb_Login(gInt_IdEmpresa)
        uce_Jefe_Area.DisplayMember = "NOMBRES"
        uce_Jefe_Area.ValueMember = "PE_ID"
        personalBL = Nothing
    End Sub

    Private Sub Tool_Salir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Salir.Click
        Me.Close()
    End Sub

    Private Sub Tool_Grabar_Click(sender As System.Object, e As System.EventArgs) Handles Tool_Grabar.Click

        If txt_des.Text.Trim.Length = 0 Then
            Avisar("Ingresar Descripcion de Area")
            txt_des.Focus()
            Exit Sub
        End If

        If uce_Jefe_Area.SelectedIndex = -1 Then
            Avisar("Seleccione Jefe de Area")
            uce_Jefe_Area.Focus()
            Exit Sub
        End If

        Dim areaBL As New BL.PlanillaBL.SG_PL_TB_AREA
        Dim areaBE As New BE.PlanillaBE.SG_PL_TB_AREA

        areaBE.AR_DESCRIPCION = txt_des.Text.Trim
        areaBE.AR_ID_EMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
        areaBE.AR_IDJEFE = uce_Jefe_Area.Value

        areaBL.Insert(areaBE)

        areaBE = Nothing
        areaBL = Nothing

    End Sub

    Private Sub txt_des_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles txt_des.KeyDown
        If e.KeyCode = Keys.Enter Then
            uce_Jefe_Area.Focus()
        End If
    End Sub

    Private Sub uce_Jefe_Area_KeyDown(sender As System.Object, e As System.Windows.Forms.KeyEventArgs) Handles uce_Jefe_Area.KeyDown
        If e.KeyCode = Keys.Enter Then
            If Preguntar("Desea Grabar?") Then
                Call Tool_Grabar_Click(sender, e)
            End If
        End If
    End Sub
End Class