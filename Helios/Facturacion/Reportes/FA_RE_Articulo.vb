Public Class FA_RE_Articulo
    Dim Bol_Nuevo As Boolean = False
    Public IGVTas As Double

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub FA_MA_Articulo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Call CargarDatos()
        Call Formatear_Grilla_Selector(ug_Lista)
    End Sub

    Private Sub CargarDatos()
        Dim articuloBL As New BL.FacturacionBL.SG_FA_TB_ARTICULO
        ug_Lista.DataSource = articuloBL.get_Articulos_FA(gInt_IdEmpresa)
        articuloBL = Nothing
    End Sub

End Class