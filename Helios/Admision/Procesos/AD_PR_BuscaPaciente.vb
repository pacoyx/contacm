Public Class AD_PR_BuscaPaciente
    Private obe As BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
    Private obr As BL.AdmisionBL.SG_AD_TB_HISTO_CLINI

    Dim lista As New List(Of String)
    Dim apepat As String
    Dim Docu As String
    Dim apemat As String
    Dim apecas As String
    Dim nombre As String
    Dim historia As String

    Public Sub New()
        InitializeComponent()
        obe = New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        obr = New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
    End Sub

    Public Function GetLista() As List(Of String)
        Return lista
    End Function

    Private Sub AD_PR_BuscaPaciente_Activated(sender As Object, e As System.EventArgs) Handles Me.Activated
        txt_ApePat.Focus()
    End Sub
    Private Sub pKeyPressNumero(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles utxt_Historia.KeyPress
        e.KeyChar = fKeyPress(e.KeyChar, sender.Text, 1)
        e.Handled = (e.KeyChar = "")
    End Sub
    Private Sub pKeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Me.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Return) Then
            SendKeys.Send("{TAB}")
            e.Handled = True
        End If
    End Sub

    Private Sub ubtn_Aceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Aceptar.Click
        lista.Clear()

        If ug_Lista_Hist_Clin.Rows.Count > 0 Then
            If Not ug_Lista_Hist_Clin.ActiveRow Is Nothing Then
                'txt_num_histo.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(0).Value
                'txt_cod_id.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(1).Value
                'txt_NombreC.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(2).Value
                'txt_ape_pat.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(3).Value
                'txt_ape_mat.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(4).Value
                'txt_ape_cas.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(5).Value
                'txt_nom1.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(6).Value
                'txt_nom2.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(7).Value
                'uce_tip_doc.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(8).Value
                'txt_num_doc.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(9).Value
                'udte_fec_nac.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(10).Value
                'udte_fec_reg.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(11).Value
                'uos_sexo.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(12).Value
                'uce_est_civil.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(13).Value
                'txt_dir.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(14).Value
                'txt_ocupacion.Text = ug_Lista_Hist_Clin.ActiveRow.Cells(15).Value
                'uce_Nacionalidad.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(16).Value
                'uce_Departamento.Value = Mid(ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value, 1, 2)
                'uce_Provincia.Value = Mid(ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value, 1, 4)
                'uce_Ubigeo.Value = ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value

                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(0).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(1).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(2).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(3).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(4).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(5).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(6).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(7).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(8).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(9).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(10).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(11).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(12).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(13).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(14).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(15).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(16).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(17).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(18).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(19).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(20).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(21).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(22).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(23).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(24).Value.ToString)
                lista.Add(ug_Lista_Hist_Clin.ActiveRow.Cells(25).Value.ToString)
            End If
        End If

        '  bol_Aceptar = True
        Me.Close()
    End Sub

    Private Sub ug_Lista_Hist_Clin_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles ug_Lista_Hist_Clin.KeyDown
        Try
            If ug_Lista_Hist_Clin.Rows.Count > 0 Then
                If ug_Lista_Hist_Clin.ActiveRow.Index = 0 Then
                    If e.KeyCode = Keys.Up Then
                        txt_ApePat.Focus()
                    End If
                End If
                If e.KeyCode = Keys.Enter Then
                    ubtn_Aceptar_Click(sender, e)
                End If

            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub ug_Lista_Hist_Clin_DoubleClickRow(ByVal sender As System.Object, ByVal e As Infragistics.Win.UltraWinGrid.DoubleClickRowEventArgs) Handles ug_Lista_Hist_Clin.DoubleClickRow
        If ug_Lista_Hist_Clin.ActiveRow.IsFilterRow Then Exit Sub
        If ug_Lista_Hist_Clin.Rows.Count > 0 Then ubtn_Aceptar_Click(sender, e)
    End Sub

    Private Sub AD_PR_BuscaPaciente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ubtn_Aceptar.Appearance.Image = My.Resources._16__Ok_
        ubtn_Consultar.Appearance.Image = My.Resources._16__Search_
        'ubtn_Cancelar.Appearance.Image = My.Resources._16__Cancel_

        apepat = ""
        Docu = ""
        apemat = ""
        apecas = ""
        nombre = ""
        historia = ""

        uck_ApePat.Checked = True
        uck_ApeMat.Checked = False
        uck_ApeCas.Checked = False
        uck_Nombres.Checked = False
        uck_Historia.Checked = False
        uck_Doc.Checked = False
        txt_ApePat.Text = ""
        utxt_ApeMat.Text = ""
        utxt_Nombres.Text = ""
        utxt_ApeCas.Text = ""
        utxt_Historia.Text = ""
        utxt_Documento.Text = ""

        txt_ApePat.Enabled = True
        utxt_ApeMat.Enabled = False
        utxt_Nombres.Enabled = False
        utxt_ApeCas.Enabled = False
        utxt_Historia.Enabled = False
        utxt_Documento.Enabled = False

        obe = New BE.AdmisionBE.SG_AD_TB_HISTO_CLINI
        obr = New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI

        Call Formatear_Grilla_Selector(ug_Lista_Hist_Clin)

        Call cargar_datos()
        lista.Clear()
        txt_ApePat.Focus()
        'Call Formatear_Grilla_Selector(ug_Listado)

        'Dim historiaBL As New BL.AdmisionBL.SG_AD_TB_HISTO_CLINI
        'ug_Listado.DataSource = historiaBL.get_Historias_Ayuda(gInt_IdEmpresa)
        'historiaBL = Nothing
        Me.KeyPreview = True
    End Sub

    Private Sub ubtn_Consultar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ubtn_Consultar.Click
        Call cargar_datos()
    End Sub

    Private Sub Tool_Agregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Agregar.Click
        FA_PR_IngClienteRapido.ShowDialog()
        If FA_PR_IngClienteRapido.bol_Grabo Then

            Dim clienteBL As New BL.FacturacionBL.SG_FA_TB_CLIENTE
            Dim clienteBE As New BE.FacturacionBE.SG_FA_TB_CLIENTE

            clienteBE.CL_NDOC = FA_PR_IngClienteRapido.str_num_ruc
            clienteBE.CL_IDEMPRESA = New BE.ContabilidadBE.SG_CO_TB_EMPRESA With {.EM_ID = gInt_IdEmpresa}
            clienteBL.get_Cliente_x_Ruc(clienteBE)

            lista.Clear()
            If clienteBE.HasRow Then
                lista.Add(clienteBE.CL_ID)
                lista.Add(clienteBE.CL_NDOC)
                lista.Add(clienteBE.CL_NOMBRE)
            End If

            clienteBE = Nothing
            clienteBL = Nothing

            Me.Close()
        End If

    End Sub

    Private Sub Tool_Historia_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tool_Historia.Click
        AD_MA_HistoClini_DatGen.ShowDialog()
          Call cargar_datos()
    End Sub

    Private Sub consul(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txt_ApePat.KeyDown, utxt_ApeMat.KeyDown, utxt_ApeCas.KeyDown, utxt_Nombres.KeyDown, utxt_Historia.KeyDown, utxt_Documento.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call cargar_datos()
        End If
    End Sub

    Private Sub uck_ApePat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_ApePat.CheckedChanged
        If uck_ApePat.Checked = True Then
            txt_ApePat.Enabled = True
            apepat = " AND HC_APE_PAT like '" & txt_ApePat.Text & "%'"
        Else
            txt_ApePat.Enabled = False
            txt_ApePat.Text = ""
            apepat = ""
        End If
    End Sub
    Private Sub uck_ApeMat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_ApeMat.CheckedChanged
        If uck_ApeMat.Checked = True Then
            utxt_ApeMat.Enabled = True
            apemat = " AND HC_APE_MAT like '" & utxt_ApeMat.Text & "%'"
        Else
            utxt_ApeMat.Enabled = False
            utxt_ApeMat.Text = ""
            apemat = ""
        End If
    End Sub
    Private Sub uck_ApeCas_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_ApeCas.CheckedChanged
        If uck_ApeCas.Checked = True Then
            utxt_ApeCas.Enabled = True
            apecas = " AND HC_APE_CASADA like '" & utxt_ApeCas.Text & "%'"
        Else
            utxt_ApeCas.Enabled = False
            utxt_ApeCas.Text = ""
            apecas = ""
        End If
    End Sub
    Private Sub uck_Nombres_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Nombres.CheckedChanged
        If uck_Nombres.Checked = True Then
            utxt_Nombres.Enabled = True
            nombre = " AND HC_NOMBRE1 +' '+ HC_NOMBRE2 like '%" & utxt_Nombres.Text & "%'"
        Else
            utxt_Nombres.Enabled = False
            utxt_Nombres.Text = ""
            nombre = ""
        End If
    End Sub
    Private Sub uck_Historia_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Historia.CheckedChanged
        If uck_Historia.Checked = True Then
            utxt_Historia.Enabled = True
            historia = " AND HC_NUM_HIST like '" & utxt_Historia.Text & "%'"
        Else
            utxt_Historia.Enabled = False
            utxt_Historia.Text = ""
            historia = ""
        End If
    End Sub
    Private Sub uck_Doc_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles uck_Doc.CheckedChanged
        If uck_Doc.Checked = True Then
            utxt_Documento.Enabled = True
            Docu = " AND HC_NDOC like '" & utxt_Documento.Text & "%'"
        Else
            utxt_Documento.Enabled = False
            utxt_Documento.Text = ""
            Docu = ""
        End If
    End Sub
    Private Sub cargar_datos()
        validar()
        Dim obj As New DataTable
        obe.HC_IDEMPRESA = 1
        obr.SEL01(obe, apepat, apemat, apecas, nombre, historia, Docu, obj)
        ug_Lista_Hist_Clin.DataSource = obj
    End Sub
    Private Sub validar()
        If uck_ApePat.Checked = True Then
            apepat = " AND HC_APE_PAT like '" & txt_ApePat.Text & "%'"
        Else
            apepat = ""
        End If
        If uck_ApeMat.Checked = True Then
            apemat = " AND HC_APE_MAT like '" & utxt_ApeMat.Text & "%'"
        Else
            apemat = ""
        End If
        If uck_ApeCas.Checked = True Then
            apecas = " AND HC_APE_CASADA like '" & utxt_ApeCas.Text & "%'"
        Else
            apecas = ""
        End If
        If uck_Nombres.Checked = True Then
            nombre = " AND HC_NOMBRE1 +' '+ HC_NOMBRE2 like '%" & utxt_Nombres.Text & "%'"
        Else
            nombre = ""
        End If
        If uck_Historia.Checked = True Then
            historia = " AND HC_NUM_HIST like '" & utxt_Historia.Text & "%'"
        Else
            historia = ""
        End If
        If uck_Doc.Checked = True Then
            Docu = " AND HC_NDOC like '" & utxt_Documento.Text & "%'"
        Else
            Docu = ""
        End If
    End Sub

End Class
