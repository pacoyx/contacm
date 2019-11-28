Public Class HospitalBE

    Public Class SG_HO_TB_PACI_HOSPI
        Private _PH_IDHISTORIA As Integer
        Private _PH_IDSOLICI As Integer
        Private _PH_FEC_ING As String
        Private _PH_FEC_ALTA As String
        Private _PH_NUM_CAM As String
        Private _PH_DIAGNOS As String
        Private _PH_INDICACION As String
        Private _PH_DIAS As Integer
        Private _PH_ESTADO As Integer
        Private _PH_FAMILIAR As String
        Private _PH_TELEF As String
        Private _PH_DIR As String
        Private _PH_USUARIO As String
        Private _PH_PC As String
        Private _PH_FECREG As String
        Private _PH_IDEMPRESA As Integer
        Private _PH_IDCAMA As Integer


        Public Sub New()
            _PH_IDCAMA = 0
            _PH_IDHISTORIA = 0
            _PH_IDSOLICI = 0
            _PH_FEC_ING = String.Empty
            _PH_FEC_ALTA = String.Empty
            _PH_NUM_CAM = String.Empty
            _PH_DIAGNOS = String.Empty
            _PH_INDICACION = String.Empty
            _PH_DIAS = 0
            _PH_ESTADO = 0
            _PH_FAMILIAR = String.Empty
            _PH_TELEF = String.Empty
            _PH_DIR = String.Empty
            _PH_USUARIO = String.Empty
            _PH_PC = String.Empty
            _PH_FECREG = String.Empty
            _PH_IDEMPRESA = 0
        End Sub

        Public Property PH_IDCAMA As Integer
            Get
                Return _PH_IDCAMA
            End Get
            Set(value As Integer)
                _PH_IDCAMA = value
            End Set
        End Property

        Public Property PH_IDHISTORIA As Integer
            Get
                Return _PH_IDHISTORIA
            End Get
            Set(value As Integer)
                _PH_IDHISTORIA = value
            End Set
        End Property

        Public Property PH_IDSOLICI As Integer
            Get
                Return _PH_IDSOLICI
            End Get
            Set(value As Integer)
                _PH_IDSOLICI = value
            End Set
        End Property

        Public Property PH_FEC_ING As String
            Get
                Return _PH_FEC_ING
            End Get
            Set(value As String)
                _PH_FEC_ING = value
            End Set
        End Property

        Public Property PH_FEC_ALTA As String
            Get
                Return _PH_FEC_ALTA
            End Get
            Set(value As String)
                _PH_FEC_ALTA = value
            End Set
        End Property

        Public Property PH_NUM_CAM As String
            Get
                Return _PH_NUM_CAM
            End Get
            Set(value As String)
                _PH_NUM_CAM = value
            End Set
        End Property

        Public Property PH_DIAGNOS As String
            Get
                Return _PH_DIAGNOS
            End Get
            Set(value As String)
                _PH_DIAGNOS = value
            End Set
        End Property

        Public Property PH_INDICACION As String
            Get
                Return _PH_INDICACION
            End Get
            Set(value As String)
                _PH_INDICACION = value
            End Set
        End Property

        Public Property PH_DIAS As Integer
            Get
                Return _PH_DIAS
            End Get
            Set(value As Integer)
                _PH_DIAS = value
            End Set
        End Property

        Public Property PH_ESTADO As Integer
            Get
                Return _PH_ESTADO
            End Get
            Set(value As Integer)
                _PH_ESTADO = value
            End Set
        End Property

        Public Property PH_FAMILIAR As String
            Get
                Return _PH_FAMILIAR
            End Get
            Set(value As String)
                _PH_FAMILIAR = value
            End Set
        End Property

        Public Property PH_TELEF As String
            Get
                Return _PH_TELEF
            End Get
            Set(value As String)
                _PH_TELEF = value
            End Set
        End Property

        Public Property PH_DIR As String
            Get
                Return _PH_DIR
            End Get
            Set(value As String)
                _PH_DIR = value
            End Set
        End Property

        Public Property PH_USUARIO As String
            Get
                Return _PH_USUARIO
            End Get
            Set(value As String)
                _PH_USUARIO = value
            End Set
        End Property

        Public Property PH_PC As String
            Get
                Return _PH_PC
            End Get
            Set(value As String)
                _PH_PC = value
            End Set
        End Property

        Public Property PH_FECREG As String
            Get
                Return _PH_FECREG
            End Get
            Set(value As String)
                _PH_FECREG = value
            End Set
        End Property

        Public Property PH_IDEMPRESA As Integer
            Get
                Return _PH_IDEMPRESA
            End Get
            Set(value As Integer)
                _PH_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_HO_TB_TIPO_PACI
        Private _TP_ID As Integer
        Private _TP_DESCRIPCION As String

        Public Sub New()
            _TP_ID = 0
            _TP_DESCRIPCION = String.Empty
        End Sub

        Public Property TP_ID As Integer
            Get
                Return _TP_ID
            End Get
            Set(value As Integer)
                _TP_ID = value
            End Set
        End Property

        Public Property TP_DESCRIPCION As String
            Get
                Return _TP_DESCRIPCION
            End Get
            Set(value As String)
                _TP_DESCRIPCION = value
            End Set
        End Property
        
    End Class

    Public Class SG_HO_TB_SOLICITUD_HOSPI
        Private _SH_ID As Integer
        Private _SH_FECHA_SOLI As String
        Private _SH_IDHISTORIA As Integer
        Private _SH_IDTIPPAC As Integer
        Private _SH_IDPROCED As Integer
        Private _SH_IDSERVICIO As Integer
        Private _SH_IDMEDICO As String
        Private _SH_DIAGNISTICO As String
        Private _SH_IDESTADO_PAC As Integer
        Private _SH_IDHABITACION As Integer
        Private _SH_IDGES As Integer
        Private _SH_ESTADO_SOL As Integer
        Private _SH_USUARIO As String
        Private _SH_TERMINAL As String
        Private _SH_FECREG As String
        Private _SH_IDEMPRESA As Integer

        Public Sub New(SH_ID_ As Integer, SH_FECHA_SOLI_ As String, SH_IDHISTORIA_ As Integer, SH_IDTIPPAC_ As Integer, SH_IDPROCED_ As Integer, SH_IDSERVICIO_ As Integer, SH_IDMEDICO_ As String, SH_DIAGNISTICO_ As String, SH_IDESTADO_PAC_ As Integer, SH_IDHABITACION_ As Integer, SH_IDGES_ As Integer, SH_ESTADO_SOL_ As Integer, SH_USUARIO_ As String, SH_TERMINAL_ As String, SH_FECREG_ As String, SH_IDEMPRESA_ As Integer)
            _SH_ID = SH_ID_
            _SH_FECHA_SOLI = SH_FECHA_SOLI_
            _SH_IDHISTORIA = SH_IDHISTORIA_
            _SH_IDTIPPAC = SH_IDTIPPAC_
            _SH_IDPROCED = SH_IDPROCED_
            _SH_IDSERVICIO = SH_IDSERVICIO_
            _SH_IDMEDICO = SH_IDMEDICO_
            _SH_DIAGNISTICO = SH_DIAGNISTICO_
            _SH_IDESTADO_PAC = SH_IDESTADO_PAC_
            _SH_IDHABITACION = SH_IDHABITACION_
            _SH_IDGES = SH_IDGES_
            _SH_ESTADO_SOL = SH_ESTADO_SOL_
            _SH_USUARIO = SH_USUARIO_
            _SH_TERMINAL = SH_TERMINAL_
            _SH_FECREG = SH_FECREG_
            _SH_IDEMPRESA = SH_IDEMPRESA_
        End Sub

        Public Sub New()
            _SH_ID = 0
            _SH_FECHA_SOLI = String.Empty
            _SH_IDHISTORIA = 0
            _SH_IDTIPPAC = 0
            _SH_IDPROCED = 0
            _SH_IDSERVICIO = 0
            _SH_IDMEDICO = String.Empty
            _SH_DIAGNISTICO = String.Empty
            _SH_IDESTADO_PAC = 0
            _SH_IDHABITACION = 0
            _SH_IDGES = 0
            _SH_ESTADO_SOL = 0
            _SH_USUARIO = String.Empty
            _SH_TERMINAL = String.Empty
            _SH_FECREG = String.Empty
            _SH_IDEMPRESA = 0
        End Sub

        Public Property SH_ID As Integer
            Get
                Return _SH_ID
            End Get
            Set(value As Integer)
                _SH_ID = value
            End Set
        End Property

        Public Property SH_FECHA_SOLI As String
            Get
                Return _SH_FECHA_SOLI
            End Get
            Set(value As String)
                _SH_FECHA_SOLI = value
            End Set
        End Property

        Public Property SH_IDHISTORIA As Integer
            Get
                Return _SH_IDHISTORIA
            End Get
            Set(value As Integer)
                _SH_IDHISTORIA = value
            End Set
        End Property

        Public Property SH_IDTIPPAC As Integer
            Get
                Return _SH_IDTIPPAC
            End Get
            Set(value As Integer)
                _SH_IDTIPPAC = value
            End Set
        End Property

        Public Property SH_IDPROCED As Integer
            Get
                Return _SH_IDPROCED
            End Get
            Set(value As Integer)
                _SH_IDPROCED = value
            End Set
        End Property

        Public Property SH_IDSERVICIO As Integer
            Get
                Return _SH_IDSERVICIO
            End Get
            Set(value As Integer)
                _SH_IDSERVICIO = value
            End Set
        End Property

        Public Property SH_IDMEDICO As String
            Get
                Return _SH_IDMEDICO
            End Get
            Set(value As String)
                _SH_IDMEDICO = value
            End Set
        End Property

        Public Property SH_DIAGNISTICO As String
            Get
                Return _SH_DIAGNISTICO
            End Get
            Set(value As String)
                _SH_DIAGNISTICO = value
            End Set
        End Property

        Public Property SH_IDESTADO_PAC As Integer
            Get
                Return _SH_IDESTADO_PAC
            End Get
            Set(value As Integer)
                _SH_IDESTADO_PAC = value
            End Set
        End Property

        Public Property SH_IDHABITACION As Integer
            Get
                Return _SH_IDHABITACION
            End Get
            Set(value As Integer)
                _SH_IDHABITACION = value
            End Set
        End Property

        Public Property SH_IDGES As Integer
            Get
                Return _SH_IDGES
            End Get
            Set(value As Integer)
                _SH_IDGES = value
            End Set
        End Property

        Public Property SH_ESTADO_SOL As Integer
            Get
                Return _SH_ESTADO_SOL
            End Get
            Set(value As Integer)
                _SH_ESTADO_SOL = value
            End Set
        End Property

        Public Property SH_USUARIO As String
            Get
                Return _SH_USUARIO
            End Get
            Set(value As String)
                _SH_USUARIO = value
            End Set
        End Property

        Public Property SH_TERMINAL As String
            Get
                Return _SH_TERMINAL
            End Get
            Set(value As String)
                _SH_TERMINAL = value
            End Set
        End Property

        Public Property SH_FECREG As String
            Get
                Return _SH_FECREG
            End Get
            Set(value As String)
                _SH_FECREG = value
            End Set
        End Property

        Public Property SH_IDEMPRESA As Integer
            Get
                Return _SH_IDEMPRESA
            End Get
            Set(value As Integer)
                _SH_IDEMPRESA = value
            End Set
        End Property

        Private _SH_IDCuenta As System.Int32

        Public Property SH_IDCuenta As System.Int32
            Get
                Return (_SH_IDCuenta)
            End Get
            Set(ByVal value As System.Int32)
                _SH_IDCuenta = value
            End Set
        End Property

        Private _SH_IDSEGURO As System.String

        Public Property SH_IDSEGURO As System.String
            Get
                Return (_SH_IDSEGURO)
            End Get
            Set(ByVal value As System.String)
                _SH_IDSEGURO = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_MARCA_ASIS
        Private _MA_IDPERSONAL As Integer
        Private _MA_FECHA As String
        Private _MA_HORA_ENT As String
        Private _MA_TM_ENT As String
        Private _MA_HORA_SAL As String
        Private _MA_TM_SAL As String
        Private _MA_TIEMPO As String
        Private _MA_IDTIPO_REG As Integer
        Private _MA_OBS As String
        Private _MA_IDEMPRESA As Integer
        Private _MA_IDSERVICIO As Integer
        Private _MA_ITEM As Integer
        Private _MA_VACA_INI As String
        Private _MA_VACA_FIN As String
        Private _MA_ES_REFRI As Integer
        Private _MA_ES_FERIADO As Integer
        Private _MA_TERMINAL As String
        Private _MA_USUARIO As String
        Private _MA_FECREG As String

        Public Sub New()
            _MA_VACA_INI = String.Empty
            _MA_VACA_FIN = String.Empty
            _MA_ITEM = 0
            _MA_IDPERSONAL = 0
            _MA_FECHA = String.Empty
            _MA_HORA_ENT = String.Empty
            _MA_TM_ENT = String.Empty
            _MA_HORA_SAL = String.Empty
            _MA_TM_SAL = String.Empty
            _MA_TIEMPO = String.Empty
            _MA_IDTIPO_REG = 0
            _MA_OBS = String.Empty
            _MA_IDEMPRESA = 0
            _MA_IDSERVICIO = 0
            _MA_ES_REFRI = 0
            _MA_ES_FERIADO = 0
            _MA_TERMINAL = String.Empty
            _MA_USUARIO = String.Empty
            _MA_FECREG = String.Empty
        End Sub

        Public Sub New(ByVal MA_IDPERSONAL_ As Integer, ByVal MA_FECHA_ As String, ByVal MA_HORA_ENT_ As String, ByVal MA_TM_ENT_ As String, ByVal MA_HORA_SAL_ As String, ByVal MA_TM_SAL_ As String, ByVal MA_TIEMPO_ As String, ByVal MA_IDTIPO_REG_ As Integer, ByVal MA_OBS_ As String, ByVal MA_IDEMPRESA_ As Integer, ByVal MA_IDSERVICIO_ As Integer, ByVal MA_ITEM_ As Integer, ByVal MA_VACA_INI_ As String, ByVal MA_VACA_FIN_ As String, ByVal MA_ES_REFRI_ As Integer, ByVal MA_ES_FERIADO_ As Integer, MA_TERMINAL_ As String, MA_USUARIO_ As String, MA_FECREG_ As String)
            _MA_ES_REFRI = MA_ES_REFRI_
            _MA_ES_FERIADO = MA_ES_FERIADO_
            _MA_VACA_INI = MA_VACA_INI_
            _MA_VACA_FIN = MA_VACA_FIN_
            _MA_ITEM = MA_ITEM_
            _MA_IDSERVICIO = MA_IDSERVICIO_
            _MA_IDPERSONAL = MA_IDPERSONAL_
            _MA_FECHA = MA_FECHA_
            _MA_HORA_ENT = MA_HORA_ENT_
            _MA_TM_ENT = MA_TM_ENT_
            _MA_HORA_SAL = MA_HORA_SAL_
            _MA_TM_SAL = MA_TM_SAL_
            _MA_TIEMPO = MA_TIEMPO_
            _MA_IDTIPO_REG = MA_IDTIPO_REG_
            _MA_OBS = MA_OBS_
            _MA_IDEMPRESA = MA_IDEMPRESA_
            _MA_TERMINAL = MA_TERMINAL_
            _MA_USUARIO = MA_USUARIO_
            _MA_FECREG = MA_FECREG_
        End Sub

        Public Property MA_FECREG As String
            Get
                Return _MA_FECREG
            End Get
            Set(value As String)
                _MA_FECREG = value
            End Set
        End Property

        Public Property MA_USUARIO As String
            Get
                Return _MA_USUARIO
            End Get
            Set(value As String)
                _MA_USUARIO = value
            End Set
        End Property

        Public Property MA_TERMINAL As String
            Get
                Return _MA_TERMINAL
            End Get
            Set(value As String)
                _MA_TERMINAL = value
            End Set
        End Property

        Public Property MA_ES_REFRI() As Integer
            Get
                Return _MA_ES_REFRI
            End Get
            Set(ByVal value As Integer)
                _MA_ES_REFRI = value
            End Set
        End Property

        Public Property MA_ES_FERIADO() As Integer
            Get
                Return _MA_ES_FERIADO
            End Get
            Set(ByVal value As Integer)
                _MA_ES_FERIADO = value
            End Set
        End Property

        Public Property MA_VACA_INI() As String
            Get
                Return _MA_VACA_INI
            End Get
            Set(ByVal value As String)
                _MA_VACA_INI = value
            End Set
        End Property

        Public Property MA_VACA_FIN() As String
            Get
                Return _MA_VACA_FIN
            End Get
            Set(ByVal value As String)
                _MA_VACA_FIN = value
            End Set
        End Property

        Public Property MA_ITEM() As Integer
            Get
                Return _MA_ITEM
            End Get
            Set(ByVal value As Integer)
                _MA_ITEM = value
            End Set
        End Property

        Public Property MA_IDSERVICIO() As Integer
            Get
                Return _MA_IDSERVICIO
            End Get
            Set(ByVal value As Integer)
                _MA_IDSERVICIO = value
            End Set
        End Property

        Public Property MA_IDPERSONAL() As Integer
            Get
                Return _MA_IDPERSONAL
            End Get
            Set(ByVal value As Integer)
                _MA_IDPERSONAL = value
            End Set
        End Property

        Public Property MA_FECHA() As String
            Get
                Return _MA_FECHA
            End Get
            Set(ByVal value As String)
                _MA_FECHA = value
            End Set
        End Property

        Public Property MA_HORA_ENT() As String
            Get
                Return _MA_HORA_ENT
            End Get
            Set(ByVal value As String)
                _MA_HORA_ENT = value
            End Set
        End Property

        Public Property MA_TM_ENT() As String
            Get
                Return _MA_TM_ENT
            End Get
            Set(ByVal value As String)
                _MA_TM_ENT = value
            End Set
        End Property

        Public Property MA_HORA_SAL() As String
            Get
                Return _MA_HORA_SAL
            End Get
            Set(ByVal value As String)
                _MA_HORA_SAL = value
            End Set
        End Property

        Public Property MA_TM_SAL() As String
            Get
                Return _MA_TM_SAL
            End Get
            Set(ByVal value As String)
                _MA_TM_SAL = value
            End Set
        End Property

        Public Property MA_TIEMPO() As String
            Get
                Return _MA_TIEMPO
            End Get
            Set(ByVal value As String)
                _MA_TIEMPO = value
            End Set
        End Property

        Public Property MA_IDTIPO_REG() As Integer
            Get
                Return _MA_IDTIPO_REG
            End Get
            Set(ByVal value As Integer)
                _MA_IDTIPO_REG = value
            End Set
        End Property

        Public Property MA_OBS() As String
            Get
                Return _MA_OBS
            End Get
            Set(ByVal value As String)
                _MA_OBS = value
            End Set
        End Property

        Public Property MA_IDEMPRESA() As Integer
            Get
                Return _MA_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _MA_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_PL_TB_PERSONAL_HORAS_DET

        Private _PHD_IDPERSONAL As Integer
        Private _PHD_IDTIPO_TARIFA As Integer
        Private _PHD_VALOR_HORA As Double
        Private _PHD_ANHO As Integer
        Private _PHD_MES As Integer
        Private _PHD_IDEMPRESA As Integer
        Private _PHD_USUARIO As String
        Private _PHD_TERMINAL As String
        Private _PHD_FECREG As String
        Private _PHD_OBS As String
        Private _PHD_SIS_OK As Integer
        Private _PHD_HORA_F As Double
        Private _PHD_HORA_E As Double
        Private _PHD_HORA_E_DOBLE As Double
        Private _PHD_TOT_HOR_SALA_BBS As Double
        Private _PHD_TOT_REFRI As Integer

        Public Sub New(ByVal PHD_IDPERSONAL_ As Integer, ByVal PHD_IDTIPO_TARIFA_ As Integer, ByVal PHD_VALOR_HORA_ As Double, ByVal PHD_ANHO_ As Integer, ByVal PHD_MES_ As Integer, ByVal PHD_IDEMPRESA_ As Integer, ByVal PHD_USUARIO_ As String, ByVal PHD_TERMINAL_ As String, ByVal PHD_FECREG_ As String, ByVal PHD_OBS_ As String, ByVal PHD_SIS_OK_ As Integer, ByVal PHD_HORA_F_ As Double, ByVal PHD_HORA_E_ As Double, ByVal PHD_HORA_E_DOBLE_ As Double, ByVal PHD_TOT_HOR_SALA_BBS_ As Double, ByVal PHD_TOT_REFRI_ As Integer)
            _PHD_TOT_REFRI = PHD_TOT_REFRI_
            _PHD_TOT_HOR_SALA_BBS = PHD_TOT_HOR_SALA_BBS_
            _PHD_HORA_E_DOBLE = PHD_HORA_E_DOBLE_
            _PHD_HORA_E = PHD_HORA_E_
            _PHD_HORA_F = PHD_HORA_F_
            _PHD_SIS_OK = PHD_SIS_OK_
            _PHD_OBS = PHD_OBS_
            _PHD_IDPERSONAL = PHD_IDPERSONAL_
            _PHD_IDTIPO_TARIFA = PHD_IDTIPO_TARIFA_
            _PHD_VALOR_HORA = PHD_VALOR_HORA_
            _PHD_ANHO = PHD_ANHO_
            _PHD_MES = PHD_MES_
            _PHD_IDEMPRESA = PHD_IDEMPRESA_
            _PHD_USUARIO = PHD_USUARIO_
            _PHD_TERMINAL = PHD_TERMINAL_
            _PHD_FECREG = PHD_FECREG_
        End Sub

        Public Sub New()
            _PHD_TOT_REFRI = 0
            _PHD_TOT_HOR_SALA_BBS = 0
            _PHD_HORA_E_DOBLE = 0
            _PHD_HORA_E = 0
            _PHD_HORA_F = 0
            _PHD_SIS_OK = 0
            _PHD_OBS = String.Empty
            _PHD_IDPERSONAL = 0
            _PHD_IDTIPO_TARIFA = 0
            _PHD_VALOR_HORA = 0
            _PHD_ANHO = 0
            _PHD_MES = 0
            _PHD_IDEMPRESA = 0
            _PHD_USUARIO = String.Empty
            _PHD_TERMINAL = String.Empty
            _PHD_FECREG = String.Empty
        End Sub

        Public Property PHD_TOT_REFRI() As Integer
            Get
                Return _PHD_TOT_REFRI
            End Get
            Set(ByVal value As Integer)
                _PHD_TOT_REFRI = value
            End Set
        End Property

        Public Property PHD_TOT_HOR_SALA_BBS() As Double
            Get
                Return _PHD_TOT_HOR_SALA_BBS
            End Get
            Set(ByVal value As Double)
                _PHD_TOT_HOR_SALA_BBS = value
            End Set
        End Property

        Public Property PHD_HORA_E_DOBLE() As Double
            Get
                Return _PHD_HORA_E_DOBLE
            End Get
            Set(ByVal value As Double)
                _PHD_HORA_E_DOBLE = value
            End Set
        End Property

        Public Property PHD_HORA_E() As Double
            Get
                Return _PHD_HORA_E
            End Get
            Set(ByVal value As Double)
                _PHD_HORA_E = value
            End Set
        End Property

        Public Property PHD_HORA_F() As Double
            Get
                Return _PHD_HORA_F
            End Get
            Set(ByVal value As Double)
                _PHD_HORA_F = value
            End Set
        End Property

        Public Property PHD_SIS_OK() As Integer
            Get
                Return _PHD_SIS_OK
            End Get
            Set(ByVal value As Integer)
                _PHD_SIS_OK = value
            End Set
        End Property

        Public Property PHD_OBS() As String
            Get
                Return _PHD_OBS
            End Get
            Set(ByVal value As String)
                _PHD_OBS = value
            End Set
        End Property

        Public Property PHD_IDPERSONAL() As Integer
            Get
                Return _PHD_IDPERSONAL
            End Get
            Set(ByVal value As Integer)
                _PHD_IDPERSONAL = value
            End Set
        End Property

        Public Property PHD_IDTIPO_TARIFA() As Integer
            Get
                Return _PHD_IDTIPO_TARIFA
            End Get
            Set(ByVal value As Integer)
                _PHD_IDTIPO_TARIFA = value
            End Set
        End Property

        Public Property PHD_VALOR_HORA() As Double
            Get
                Return _PHD_VALOR_HORA
            End Get
            Set(ByVal value As Double)
                _PHD_VALOR_HORA = value
            End Set
        End Property

        Public Property PHD_ANHO() As Integer
            Get
                Return _PHD_ANHO
            End Get
            Set(ByVal value As Integer)
                _PHD_ANHO = value
            End Set
        End Property

        Public Property PHD_MES() As Integer
            Get
                Return _PHD_MES
            End Get
            Set(ByVal value As Integer)
                _PHD_MES = value
            End Set
        End Property

        Public Property PHD_IDEMPRESA() As Integer
            Get
                Return _PHD_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PHD_IDEMPRESA = value
            End Set
        End Property

        Public Property PHD_USUARIO() As String
            Get
                Return _PHD_USUARIO
            End Get
            Set(ByVal value As String)
                _PHD_USUARIO = value
            End Set
        End Property

        Public Property PHD_TERMINAL() As String
            Get
                Return _PHD_TERMINAL
            End Get
            Set(ByVal value As String)
                _PHD_TERMINAL = value
            End Set
        End Property

        Public Property PHD_FECREG() As String
            Get
                Return _PHD_FECREG
            End Get
            Set(ByVal value As String)
                _PHD_FECREG = value
            End Set
        End Property


    End Class

    Public Class SG_PL_TB_PERSONAL_HORAS_CAB
        Private _PHC_ANHO As Integer
        Private _PHC_MES As Integer
        Private _PHC_OK_SISTEMAS As Integer
        Private _PHC_OK_CONTABILIDAD As Integer
        Private _PHC_ESTADO As Integer
        Private _PHC_IDEMPRESA As Integer
        Private _PHC_USUARIO As String
        Private _PHC_TERMINAL As String
        Private _PHC_FECREG As String

        Public Sub New(ByVal PHC_ANHO_ As Integer, ByVal PHC_MES_ As Integer, ByVal PHC_OK_SISTEMAS_ As Integer, ByVal PHC_OK_CONTABILIDAD_ As Integer, ByVal PHC_ESTADO_ As Integer, ByVal PHC_IDEMPRESA_ As Integer, ByVal PHC_USUARIO_ As String, ByVal PHC_TERMINAL_ As String, ByVal PHC_FECREG_ As String)
            _PHC_ANHO = PHC_ANHO_
            _PHC_MES = PHC_MES_
            _PHC_OK_SISTEMAS = PHC_OK_SISTEMAS_
            _PHC_OK_CONTABILIDAD = PHC_OK_CONTABILIDAD_
            _PHC_ESTADO = PHC_ESTADO_
            _PHC_IDEMPRESA = PHC_IDEMPRESA_
            _PHC_USUARIO = PHC_USUARIO_
            _PHC_TERMINAL = PHC_TERMINAL_
            _PHC_FECREG = PHC_FECREG_
        End Sub

        Public Sub New()
            _PHC_ANHO = 0
            _PHC_MES = 0
            _PHC_OK_SISTEMAS = 0
            _PHC_OK_CONTABILIDAD = 0
            _PHC_ESTADO = 0
            _PHC_IDEMPRESA = 0
            _PHC_USUARIO = String.Empty
            _PHC_TERMINAL = String.Empty
            _PHC_FECREG = String.Empty
        End Sub

        Public Property PHC_ANHO() As Integer
            Get
                Return _PHC_ANHO
            End Get
            Set(ByVal value As Integer)
                _PHC_ANHO = value
            End Set
        End Property

        Public Property PHC_MES() As Integer
            Get
                Return _PHC_MES
            End Get
            Set(ByVal value As Integer)
                _PHC_MES = value
            End Set
        End Property

        Public Property PHC_OK_SISTEMAS() As Integer
            Get
                Return _PHC_OK_SISTEMAS
            End Get
            Set(ByVal value As Integer)
                _PHC_OK_SISTEMAS = value
            End Set
        End Property

        Public Property PHC_OK_CONTABILIDAD() As Integer
            Get
                Return _PHC_OK_CONTABILIDAD
            End Get
            Set(ByVal value As Integer)
                _PHC_OK_CONTABILIDAD = value
            End Set
        End Property

        Public Property PHC_ESTADO() As Integer
            Get
                Return _PHC_ESTADO
            End Get
            Set(ByVal value As Integer)
                _PHC_ESTADO = value
            End Set
        End Property

        Public Property PHC_IDEMPRESA() As Integer
            Get
                Return _PHC_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PHC_IDEMPRESA = value
            End Set
        End Property

        Public Property PHC_USUARIO() As String
            Get
                Return _PHC_USUARIO
            End Get
            Set(ByVal value As String)
                _PHC_USUARIO = value
            End Set
        End Property

        Public Property PHC_TERMINAL() As String
            Get
                Return _PHC_TERMINAL
            End Get
            Set(ByVal value As String)
                _PHC_TERMINAL = value
            End Set
        End Property

        Public Property PHC_FECREG() As String
            Get
                Return _PHC_FECREG
            End Get
            Set(ByVal value As String)
                _PHC_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_HO_TB_PISO
        Private _HO_ID As Integer
        Private _HO_DESCRIPCION As String
        Private _HO_IDEMPRESA As Integer

        Public Sub New()
            _HO_ID = 0
            _HO_DESCRIPCION = String.Empty
            _HO_IDEMPRESA = 0
        End Sub
        Public Property HO_ID As Integer
            Get
                Return _HO_ID
            End Get
            Set(ByVal value As Integer)
                _HO_ID = value
            End Set
        End Property

        Public Property HO_DESCRIPCION As String
            Get
                Return _HO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _HO_DESCRIPCION = value
            End Set
        End Property

        Public Property HO_IDEMPRESA As Integer
            Get
                Return _HO_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _HO_IDEMPRESA = value
            End Set
        End Property
    End Class

    Public Class SG_HO_TB_TIPO_HABITACION
        Private _HO_ID As Integer
        Private _HO_DESCRIPCION As String
        Private _HO_CANTIDAD As Integer
        Private _HO_PRECIO As Double
        Private _HO_ESTADO As Integer
        Private _HO_IDEMPRESA As Integer

        Public Sub New()
            _HO_ID = 0
            _HO_DESCRIPCION = String.Empty
            _HO_CANTIDAD = 0
            _HO_PRECIO = 0.0
            _HO_ESTADO = 0
            _HO_IDEMPRESA = 0
        End Sub
        Public Property HO_ID As Integer
            Get
                Return _HO_ID
            End Get
            Set(ByVal value As Integer)
                _HO_ID = value
            End Set
        End Property

        Public Property HO_DESCRIPCION As String
            Get
                Return _HO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _HO_DESCRIPCION = value
            End Set
        End Property
        Public Property HO_CANTIDAD As Integer
            Get
                Return _HO_CANTIDAD
            End Get
            Set(ByVal value As Integer)
                _HO_CANTIDAD = value
            End Set
        End Property
        Public Property HO_PRECIO As Double
            Get
                Return _HO_PRECIO
            End Get
            Set(ByVal value As Double)
                _HO_PRECIO = value
            End Set
        End Property
        Public Property HO_ESTADO As Integer
            Get
                Return _HO_ESTADO
            End Get
            Set(ByVal value As Integer)
                _HO_ESTADO = value
            End Set
        End Property

        Public Property HO_IDEMPRESA As Integer
            Get
                Return _HO_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _HO_IDEMPRESA = value
            End Set
        End Property
    End Class

    Public Class SG_HO_TB_HABITACION
        Private _HO_ID As Integer
        Private _HO_NUMERO As Integer
        Private _HO_PISO As Integer
        Private _HO_DESCRIPCION As String
        Private _HO_TIPO_HABITACION As Integer
        Private _HO_ESTADO As Integer
        Private _HO_IDEMPRESA As Integer

        Public Sub New()
            _HO_ID = 0
            _HO_NUMERO = 0
            _HO_PISO = 0
            _HO_DESCRIPCION = String.Empty
            _HO_TIPO_HABITACION = 0
            _HO_ESTADO = 0
            _HO_IDEMPRESA = 0
        End Sub
        Public Property HO_ID As Integer
            Get
                Return _HO_ID
            End Get
            Set(ByVal value As Integer)
                _HO_ID = value
            End Set
        End Property
        Public Property HO_NUMERO As Integer
            Get
                Return _HO_NUMERO
            End Get
            Set(ByVal value As Integer)
                _HO_NUMERO = value
            End Set
        End Property
        Public Property HO_PISO As Integer
            Get
                Return _HO_PISO
            End Get
            Set(ByVal value As Integer)
                _HO_PISO = value
            End Set
        End Property

        Public Property HO_DESCRIPCION As String
            Get
                Return _HO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _HO_DESCRIPCION = value
            End Set
        End Property
        Public Property HO_TIPO_HABITACION As Integer
            Get
                Return _HO_TIPO_HABITACION
            End Get
            Set(ByVal value As Integer)
                _HO_TIPO_HABITACION = value
            End Set
        End Property
        Public Property HO_ESTADO As Integer
            Get
                Return _HO_ESTADO
            End Get
            Set(ByVal value As Integer)
                _HO_ESTADO = value
            End Set
        End Property

        Public Property HO_IDEMPRESA As Integer
            Get
                Return _HO_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _HO_IDEMPRESA = value
            End Set
        End Property
    End Class

    Public Class SG_HO_TB_CAMA
        Private _CA_CODIGO As Integer
        Private _CA_NUMERO As Integer
        Private _CA_DESCRIPCION As String
        Private _CA_HABITACION As Integer
        Private _CA_ESTADO As Integer
        Private _CA_IDEMPRESA As Integer

        Public Sub New()

            _CA_CODIGO = 0
            _CA_NUMERO = 0
            _CA_DESCRIPCION = String.Empty
            _CA_HABITACION = 0
            _CA_ESTADO = 0
            _CA_IDEMPRESA = 0
        End Sub

        Public Property CODIGO As Integer
            Get
                Return _CA_CODIGO
            End Get
            Set(ByVal value As Integer)
                _CA_CODIGO = value
            End Set
        End Property
        Public Property NUMERO As Integer
            Get
                Return _CA_NUMERO
            End Get
            Set(ByVal value As Integer)
                _CA_NUMERO = value
            End Set
        End Property
        Public Property DESCRIPCION As String
            Get
                Return _CA_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CA_DESCRIPCION = value
            End Set
        End Property
        Public Property ESTADO As Integer
            Get
                Return _CA_ESTADO
            End Get
            Set(ByVal value As Integer)
                _CA_ESTADO = value
            End Set
        End Property
        Public Property IDEMPRESA As Integer
            Get
                Return _CA_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _CA_IDEMPRESA = value
            End Set
        End Property
        Public Property HABITACION As Integer
            Get
                Return _CA_HABITACION
            End Get
            Set(ByVal value As Integer)
                _CA_HABITACION = value
            End Set
        End Property
    End Class

    Public Class SG_HO_TB_TIPO_GESTANTE
        Private _TG_ID As Integer
        Private _TG_DESCRIPCION As String
        Private _TG_IDEMPRESA As Integer

        Public Sub New()
            _TG_ID = 0
            _TG_DESCRIPCION = String.Empty
            _TG_IDEMPRESA = 0
        End Sub

        Public Property ID As Integer
            Get
                Return _TG_ID
            End Get
            Set(ByVal value As Integer)
                _TG_ID = value
            End Set
        End Property

        Public Property DESCRIPCION As String
            Get
                Return _TG_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TG_DESCRIPCION = value
            End Set
        End Property
        Public Property IDEMPRESA As Integer
            Get
                Return _TG_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _TG_IDEMPRESA = value
            End Set
        End Property
    End Class

End Class
