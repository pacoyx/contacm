Public Class MarcacionesBE


    Public Class SG_MA_TB_RELA_PERSONAL
        Private _IDPERSONAL_A As Integer
        Private _IDPERSONAL_B As Integer
        Private _IDEMPRESA As Integer

        Public Sub New(IDPERSONAL_A_ As Integer, IDPERSONAL_B_ As Integer, IDEMPRESA_ As Integer)
            _IDPERSONAL_A = IDPERSONAL_A_
            _IDPERSONAL_B = IDPERSONAL_B_
            _IDEMPRESA = IDEMPRESA_
        End Sub

        Public Sub New()
            _IDPERSONAL_A = 0
            _IDPERSONAL_B = 0
            _IDEMPRESA = 0
        End Sub

        Public Property IDPERSONAL_A As Integer
            Get
                Return _IDPERSONAL_A
            End Get
            Set(value As Integer)
                _IDPERSONAL_A = value
            End Set
        End Property

        Public Property IDPERSONAL_B As Integer
            Get
                Return _IDPERSONAL_B
            End Get
            Set(value As Integer)
                _IDPERSONAL_B = value
            End Set
        End Property

        Public Property IDEMPRESA As Integer
            Get
                Return _IDEMPRESA
            End Get
            Set(value As Integer)
                _IDEMPRESA = value
            End Set
        End Property

    End Class



    Public Class SG_MA_TB_PAPELETA

        Private _PA_ID As Integer
        Private _PA_IDPERSONAL As Integer
        Private _PA_IDJEFE As Integer
        Private _PA_IDMOTIVO As Integer
        Private _PA_FEC_INI As String
        Private _PA_FEC_FIN As String
        Private _PA_HOR_INI As String
        Private _PA_HOR_FIN As String
        Private _PA_DET_OTROS As String
        Private _PA_VISTO_JEFE As Integer
        Private _PA_FEC_VIS_JEFE As String
        Private _PA_VISTO_RRHH As Integer
        Private _PA_FEC_VIS_RRHH As String
        Private _PA_USER As String
        Private _PA_FEC_REG As String
        Private _PA_PC As String
        Private _PA_FEC_MOD As String
        Private _PA_PERIODO_VACA As String

        Public Sub New(PA_ID_ As Integer, PA_IDPERSONAL_ As Integer, PA_IDJEFE_ As Integer, PA_IDMOTIVO_ As Integer, PA_FEC_INI_ As String, PA_FEC_FIN_ As String, PA_HOR_INI_ As String, PA_HOR_FIN_ As String, PA_DET_OTROS_ As String, PA_VISTO_JEFE_ As Integer, PA_FEC_VIS_JEFE_ As String, PA_VISTO_RRHH_ As Integer, PA_FEC_VIS_RRHH_ As String, PA_USER_ As String, PA_FEC_REG_ As String, PA_PC_ As String, PA_FEC_MOD_ As String, PA_PERIODO_VACA_ As String)
            _PA_PERIODO_VACA = PA_PERIODO_VACA_
            _PA_ID = PA_ID_
            _PA_IDPERSONAL = PA_IDPERSONAL_
            _PA_IDJEFE = PA_IDJEFE_
            _PA_IDMOTIVO = PA_IDMOTIVO_
            _PA_FEC_INI = PA_FEC_INI_
            _PA_FEC_FIN = PA_FEC_FIN_
            _PA_HOR_INI = PA_HOR_INI_
            _PA_HOR_FIN = PA_HOR_FIN_
            _PA_DET_OTROS = PA_DET_OTROS_
            _PA_VISTO_JEFE = PA_VISTO_JEFE_
            _PA_FEC_VIS_JEFE = PA_FEC_VIS_JEFE_
            _PA_VISTO_RRHH = PA_VISTO_RRHH_
            _PA_FEC_VIS_RRHH = PA_FEC_VIS_RRHH_
            _PA_USER = PA_USER_
            _PA_FEC_REG = PA_FEC_REG_
            _PA_PC = PA_PC_
            _PA_FEC_MOD = PA_FEC_MOD_
        End Sub

        Public Sub New()
            _PA_PERIODO_VACA = String.Empty
            _PA_ID = 0
            _PA_IDPERSONAL = 0
            _PA_IDJEFE = 0
            _PA_IDMOTIVO = 0
            _PA_FEC_INI = String.Empty
            _PA_FEC_FIN = String.Empty
            _PA_HOR_INI = String.Empty
            _PA_HOR_FIN = String.Empty
            _PA_DET_OTROS = String.Empty
            _PA_VISTO_JEFE = 0
            _PA_FEC_VIS_JEFE = String.Empty
            _PA_VISTO_RRHH = 0
            _PA_FEC_VIS_RRHH = String.Empty
            _PA_USER = String.Empty
            _PA_FEC_REG = String.Empty
            _PA_PC = String.Empty
            _PA_FEC_MOD = String.Empty
        End Sub

        Public Property PA_PERIODO_VACA As String
            Get
                Return _PA_PERIODO_VACA
            End Get
            Set(value As String)
                _PA_PERIODO_VACA = value
            End Set
        End Property

        Public Property PA_ID As Integer
            Get
                Return _PA_ID
            End Get
            Set(value As Integer)
                _PA_ID = value
            End Set
        End Property

        Public Property PA_IDPERSONAL As Integer
            Get
                Return _PA_IDPERSONAL
            End Get
            Set(value As Integer)
                _PA_IDPERSONAL = value
            End Set
        End Property

        Public Property PA_IDJEFE As Integer
            Get
                Return _PA_IDJEFE
            End Get
            Set(value As Integer)
                _PA_IDJEFE = value
            End Set
        End Property

        Public Property PA_IDMOTIVO As Integer
            Get
                Return _PA_IDMOTIVO
            End Get
            Set(value As Integer)
                _PA_IDMOTIVO = value
            End Set
        End Property

        Public Property PA_FEC_INI As String
            Get
                Return _PA_FEC_INI
            End Get
            Set(value As String)
                _PA_FEC_INI = value
            End Set
        End Property

        Public Property PA_FEC_FIN As String
            Get
                Return _PA_FEC_FIN
            End Get
            Set(value As String)
                _PA_FEC_FIN = value
            End Set
        End Property

        Public Property PA_HOR_INI As String
            Get
                Return _PA_HOR_INI
            End Get
            Set(value As String)
                _PA_HOR_INI = value
            End Set
        End Property

        Public Property PA_HOR_FIN As String
            Get
                Return _PA_HOR_FIN
            End Get
            Set(value As String)
                _PA_HOR_FIN = value
            End Set
        End Property

        Public Property PA_DET_OTROS As String
            Get
                Return _PA_DET_OTROS
            End Get
            Set(value As String)
                _PA_DET_OTROS = value
            End Set
        End Property

        Public Property PA_VISTO_JEFE As Integer
            Get
                Return _PA_VISTO_JEFE
            End Get
            Set(value As Integer)
                _PA_VISTO_JEFE = value
            End Set
        End Property

        Public Property PA_FEC_VIS_JEFE As String
            Get
                Return _PA_FEC_VIS_JEFE
            End Get
            Set(value As String)
                _PA_FEC_VIS_JEFE = value
            End Set
        End Property

        Public Property PA_VISTO_RRHH As Integer
            Get
                Return _PA_VISTO_RRHH
            End Get
            Set(value As Integer)
                _PA_VISTO_RRHH = value
            End Set
        End Property

        Public Property PA_FEC_VIS_RRHH As String
            Get
                Return _PA_FEC_VIS_RRHH
            End Get
            Set(value As String)
                _PA_FEC_VIS_RRHH = value
            End Set
        End Property


        Public Property PA_USER As String
            Get
                Return _PA_USER
            End Get
            Set(value As String)
                _PA_USER = value
            End Set
        End Property

        Public Property PA_FEC_REG As String
            Get
                Return _PA_FEC_REG
            End Get
            Set(value As String)
                _PA_FEC_REG = value
            End Set
        End Property

        Public Property PA_PC As String
            Get
                Return _PA_PC
            End Get
            Set(value As String)
                _PA_PC = value
            End Set
        End Property

        Public Property PA_FEC_MOD As String
            Get
                Return _PA_FEC_MOD
            End Get
            Set(value As String)
                _PA_FEC_MOD = value
            End Set
        End Property

    End Class

    Public Class SG_MA_TB_MOTIVO
        Private _MO_ID As Integer
        Private _MO_DESCRIPCION As String
        Private _MO_ES_DM As Integer
        Private _MO_ES_VA As Integer

        Public Sub New(MO_ID_ As Integer, MO_DESCRIPCION_ As String, MO_ES_DM_ As Integer, MO_ES_VA_ As Integer)
            _MO_ID = MO_ID_
            _MO_DESCRIPCION = MO_DESCRIPCION_
            _MO_ES_DM = MO_ES_DM_
            _MO_ES_VA = MO_ES_VA_
        End Sub

        Public Sub New()
            _MO_ID = 0
            _MO_DESCRIPCION = String.Empty
            _MO_ES_DM = 0
            _MO_ES_VA = 0
        End Sub

        Public Property MO_ID As Integer
            Get
                Return _MO_ID
            End Get
            Set(value As Integer)
                _MO_ID = value
            End Set
        End Property

        Public Property MO_DESCRIPCION As String
            Get
                Return _MO_DESCRIPCION
            End Get
            Set(value As String)
                _MO_DESCRIPCION = value
            End Set
        End Property

        Public Property MO_ES_DM As Integer
            Get
                Return _MO_ES_DM
            End Get
            Set(value As Integer)
                _MO_ES_DM = value
            End Set
        End Property

        Public Property MO_ES_VA As Integer
            Get
                Return _MO_ES_VA
            End Get
            Set(value As Integer)
                _MO_ES_VA = value
            End Set
        End Property

    End Class

End Class
