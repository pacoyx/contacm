Public Class FertilidadBE
 
    Public Class SG_CF_TB_CUENTA_CRIO_C
        Private _IDHISTORIA As Integer
        Private _IDFICHA As String
        Private _IDARTICULO As Integer
        Private _FEC_PROCESO As Date
        Private _NOMBRES As String
        Private _APE_PAT As String
        Private _APE_MAT As String
        Private _IDTIPO_DOC As Integer
        Private _NUM_DOC As String
        Private _IDMEDICO As String
        Private _FEC_CONGE As Date
        Private _IMP_CONGELACION As Double
        Private _IDMONEDA_CONGE As Integer
        Private _IMP_SEMESTRAL As Double
        Private _IDMONEDA_SEME As Integer
        Private _DIR1 As String
        Private _DIR2 As String
        Private _UBIGEO As String
        Private _EMAIL As String
        Private _OBS As String
        Private _REFERIDO As Integer
        Private _RESPONSABLE As String
        Private _ESTADO As Integer
        Private _USUARIO As String
        Private _TERMINAL As String
        Private _FECREG As Date
        Private _IDEMPRESA As Integer

        Public Sub New()
            _IDHISTORIA = 0
            _IDFICHA = ""
            _IDARTICULO = 0
            _FEC_PROCESO = Now
            _NOMBRES = ""
            _APE_PAT = ""
            _APE_MAT = ""
            _IDTIPO_DOC = 0
            _NUM_DOC = ""
            _IDMEDICO = ""
            _FEC_CONGE = Now
            _IMP_CONGELACION = 0.0
            _IDMONEDA_CONGE = 0
            _IMP_SEMESTRAL = 0.0
            _IDMONEDA_SEME = 0
            _DIR1 = ""
            _DIR2 = ""
            _UBIGEO = ""
            _EMAIL = ""
            _OBS = ""
            _REFERIDO = 0
            _RESPONSABLE = ""
            _ESTADO = 0
            _USUARIO = ""
            _TERMINAL = ""
            _FECREG = Now
            _IDEMPRESA = 0
        End Sub
        Public Property IDHISTORIA As Integer
            Get
                Return _IDHISTORIA
            End Get
            Set(ByVal value As Integer)
                _IDHISTORIA = value
            End Set
        End Property
        Public Property IDFICHA As String
            Get
                Return _IDFICHA
            End Get
            Set(ByVal value As String)
                _IDFICHA = value
            End Set
        End Property
        Public Property IDARTICULO As Integer
            Get
                Return _IDARTICULO
            End Get
            Set(ByVal value As Integer)
                _IDARTICULO = value
            End Set
        End Property
        Public Property FEC_PROCESO As Date
            Get
                Return _FEC_PROCESO
            End Get
            Set(ByVal value As Date)
                _FEC_PROCESO = value
            End Set
        End Property
        Public Property NOMBRES As String
            Get
                Return _NOMBRES
            End Get
            Set(ByVal value As String)
                _NOMBRES = value
            End Set
        End Property
        Public Property APE_PAT As String
            Get
                Return _APE_PAT
            End Get
            Set(ByVal value As String)
                _APE_PAT = value
            End Set
        End Property
        Public Property APE_MAT As String
            Get
                Return _APE_MAT
            End Get
            Set(ByVal value As String)
                _APE_MAT = value
            End Set
        End Property
        Public Property IDTIPO_DOC As Integer
            Get
                Return _IDTIPO_DOC
            End Get
            Set(ByVal value As Integer)
                _IDTIPO_DOC = value
            End Set
        End Property
        Public Property NUM_DOC As String
            Get
                Return _NUM_DOC
            End Get
            Set(ByVal value As String)
                _NUM_DOC = value
            End Set
        End Property
        Public Property IDMEDICO As String
            Get
                Return _IDMEDICO
            End Get
            Set(ByVal value As String)
                _IDMEDICO = value
            End Set
        End Property
        Public Property FEC_CONGE As Date
            Get
                Return _FEC_CONGE
            End Get
            Set(ByVal value As Date)
                _FEC_CONGE = value
            End Set
        End Property
        Public Property IMP_CONGELACION As Double
            Get
                Return _IMP_CONGELACION
            End Get
            Set(ByVal value As Double)
                _IMP_CONGELACION = value
            End Set
        End Property
        Public Property IDMONEDA_CONGE As Integer
            Get
                Return _IDMONEDA_CONGE
            End Get
            Set(ByVal value As Integer)
                _IDMONEDA_CONGE = value
            End Set
        End Property
        Public Property IMP_SEMESTRAL As Double
            Get
                Return _IMP_SEMESTRAL
            End Get
            Set(ByVal value As Double)
                _IMP_SEMESTRAL = value
            End Set
        End Property
        Public Property IDMONEDA_SEME As Integer
            Get
                Return _IDMONEDA_SEME
            End Get
            Set(ByVal value As Integer)
                _IDMONEDA_SEME = value
            End Set
        End Property
        Public Property DIR1 As String
            Get
                Return _DIR1
            End Get
            Set(ByVal value As String)
                _DIR1 = value
            End Set
        End Property
        Public Property DIR2 As String
            Get
                Return _DIR2
            End Get
            Set(ByVal value As String)
                _DIR2 = value
            End Set
        End Property
        Public Property UBIGEO As String
            Get
                Return _UBIGEO
            End Get
            Set(ByVal value As String)
                _UBIGEO = value
            End Set
        End Property
        Public Property EMAIL As String
            Get
                Return _EMAIL
            End Get
            Set(ByVal value As String)
                _EMAIL = value
            End Set
        End Property
        Public Property OBS As String
            Get
                Return _OBS
            End Get
            Set(ByVal value As String)
                _OBS = value
            End Set
        End Property
        Public Property REFERIDO As Integer
            Get
                Return _REFERIDO
            End Get
            Set(ByVal value As Integer)
                _REFERIDO = value
            End Set
        End Property
        Public Property RESPONSABLE As String
            Get
                Return _RESPONSABLE
            End Get
            Set(ByVal value As String)
                _RESPONSABLE = value
            End Set
        End Property
        Public Property ESTADO As Integer
            Get
                Return _ESTADO
            End Get
            Set(ByVal value As Integer)
                _ESTADO = value
            End Set
        End Property
        Public Property USUARIO As String
            Get
                Return _USUARIO
            End Get
            Set(ByVal value As String)
                _USUARIO = value
            End Set
        End Property
        Public Property TERMINAL As String
            Get
                Return _TERMINAL
            End Get
            Set(ByVal value As String)
                _TERMINAL = value
            End Set
        End Property
        Public Property FECREG As Date
            Get
                Return _FECREG
            End Get
            Set(ByVal value As Date)
                _FECREG = value
            End Set
        End Property
        Public Property IDEMPRESA As Integer
            Get
                Return _IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _IDEMPRESA = value
            End Set
        End Property
    End Class
End Class
