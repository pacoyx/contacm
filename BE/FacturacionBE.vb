Public Class FacturacionBE


    Public Class SG_FA_TB_TIPO_CONGELA
        Private _TC_ID As Integer
        Private _TC_DESCRIPCION As String
        Private _TC_IDEMPRESA As Integer


        Public Sub New()
            _TC_ID = 0
            _TC_DESCRIPCION = String.Empty
            _TC_IDEMPRESA = 0
        End Sub

        Public Property TC_ID As Integer
            Get
                Return _TC_ID
            End Get
            Set(value As Integer)
                _TC_ID = value
            End Set
        End Property

        Public Property TC_DESCRIPCION As String
            Get
                Return _TC_DESCRIPCION
            End Get
            Set(value As String)
                _TC_DESCRIPCION = value
            End Set
        End Property

        Public Property TC_IDEMPRESA As Integer
            Get
                Return _TC_IDEMPRESA
            End Get
            Set(value As Integer)
                _TC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PAGO_CONGE_C
        Private _PG_ID As Integer
        Private _PG_FEC_CONGE As String
        Private _PG_IDCOMPROBANTE As Integer
        Private _PG_IDCLIENTE As Integer
        Private _PG_IDCONGELACION As Integer
        Private _PG_IDMEDICO As String
        Private _PG_COMENTARIOS As String
        Private _PG_IMPORTE As Double
        Private _PG_ESTADO As Integer
        Private _PG_USUARIO As String
        Private _PG_TERMINAL As String
        Private _PG_FECREG As String
        Private _PG_IDEMPRESA As Integer
        Private _PG_REF As String
        Private _PG_IDMONEDA As String
        Private _PG_TIPCAM As Double

        Public Sub New()
            _PG_IDMONEDA = String.Empty
            _PG_TIPCAM = 0
            _PG_REF = String.Empty
            _PG_ID = 0
            _PG_FEC_CONGE = String.Empty
            _PG_IDCOMPROBANTE = 0
            _PG_IDCLIENTE = 0
            _PG_IDCONGELACION = 0
            _PG_IDMEDICO = String.Empty
            _PG_COMENTARIOS = String.Empty
            _PG_IMPORTE = 0
            _PG_ESTADO = 0
            _PG_USUARIO = String.Empty
            _PG_TERMINAL = String.Empty
            _PG_FECREG = String.Empty
            _PG_IDEMPRESA = 0
        End Sub

        Public Property PG_IDMONEDA As String
            Get
                Return _PG_IDMONEDA
            End Get
            Set(value As String)
                _PG_IDMONEDA = value
            End Set
        End Property

        Public Property PG_TIPCAM As Double
            Get
                Return _PG_TIPCAM
            End Get
            Set(value As Double)
                _PG_TIPCAM = value
            End Set
        End Property

        Public Property PG_REF As String
            Get
                Return _PG_REF
            End Get
            Set(value As String)
                _PG_REF = value
            End Set
        End Property

        Public Property PG_ID As Integer
            Get
                Return _PG_ID
            End Get
            Set(value As Integer)
                _PG_ID = value
            End Set
        End Property

        Public Property PG_FEC_CONGE As String
            Get
                Return _PG_FEC_CONGE
            End Get
            Set(value As String)
                _PG_FEC_CONGE = value
            End Set
        End Property

        Public Property PG_IDCOMPROBANTE As Integer
            Get
                Return _PG_IDCOMPROBANTE
            End Get
            Set(value As Integer)
                _PG_IDCOMPROBANTE = value
            End Set
        End Property

        Public Property PG_IDCLIENTE As Integer
            Get
                Return _PG_IDCLIENTE
            End Get
            Set(value As Integer)
                _PG_IDCLIENTE = value
            End Set
        End Property


        Public Property PG_IDCONGELACION As Integer
            Get
                Return _PG_IDCONGELACION
            End Get
            Set(value As Integer)
                _PG_IDCONGELACION = value
            End Set
        End Property


        Public Property PG_IDMEDICO As String
            Get
                Return _PG_IDMEDICO
            End Get
            Set(value As String)
                _PG_IDMEDICO = value
            End Set
        End Property

        Public Property PG_COMENTARIOS As String
            Get
                Return _PG_COMENTARIOS
            End Get
            Set(value As String)
                _PG_COMENTARIOS = value
            End Set
        End Property

        Public Property PG_IMPORTE As Double
            Get
                Return _PG_IMPORTE
            End Get
            Set(value As Double)
                _PG_IMPORTE = value
            End Set
        End Property

        Public Property PG_ESTADO As Integer
            Get
                Return _PG_ESTADO
            End Get
            Set(value As Integer)
                _PG_ESTADO = value
            End Set
        End Property

        Public Property PG_USUARIO As String
            Get
                Return _PG_USUARIO
            End Get
            Set(value As String)
                _PG_USUARIO = value
            End Set
        End Property

        Public Property PG_TERMINAL As String
            Get
                Return _PG_TERMINAL
            End Get
            Set(value As String)
                _PG_TERMINAL = value
            End Set
        End Property

        Public Property PG_FECREG As String
            Get
                Return _PG_FECREG
            End Get
            Set(value As String)
                _PG_FECREG = value
            End Set
        End Property

        Public Property PG_IDEMPRESA As Integer
            Get
                Return _PG_IDEMPRESA
            End Get
            Set(value As Integer)
                _PG_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PAGO_CONGE_D

        Private _PD_IDCAB As Integer
        Private _PD_ANHO As Integer
        Private _PD_MES As Integer
        Private _PD_FECPAGO As String
        Private _PD_IMPORTE As Double
        Private _PD_IDCOMPROBANTE As Integer
        Private _PD_EST_CUOTA As Integer
        Private _PD_COMENTARIOS As String
        Private _PD_IDMONEDA As String
        Private _PD_TIPCAM As Double
        Private _PD_REF As String

        Public Sub New()
            _PD_IDMONEDA = String.Empty
            _PD_TIPCAM = 0
            _PD_REF = String.Empty
            _PD_IDCAB = 0
            _PD_ANHO = 0
            _PD_MES = 0
            _PD_FECPAGO = String.Empty
            _PD_IMPORTE = 0.0R
            _PD_IDCOMPROBANTE = 0
            _PD_EST_CUOTA = 0
            _PD_COMENTARIOS = String.Empty
        End Sub

        Public Property PD_IDMONEDA As String
            Get
                Return _PD_IDMONEDA
            End Get
            Set(value As String)
                _PD_IDMONEDA = value
            End Set
        End Property

        Public Property PD_TIPCAM As Double
            Get
                Return _PD_TIPCAM
            End Get
            Set(value As Double)
                _PD_TIPCAM = value
            End Set
        End Property

        Public Property PD_REF As String
            Get
                Return _PD_REF
            End Get
            Set(value As String)
                _PD_REF = value
            End Set
        End Property

        Public Property PD_IDCAB As Integer
            Get
                Return _PD_IDCAB
            End Get
            Set(value As Integer)
                _PD_IDCAB = value
            End Set
        End Property

        Public Property PD_ANHO As Integer
            Get
                Return _PD_ANHO
            End Get
            Set(value As Integer)
                _PD_ANHO = value
            End Set
        End Property

        Public Property PD_MES As Integer
            Get
                Return _PD_MES
            End Get
            Set(value As Integer)
                _PD_MES = value
            End Set
        End Property

        Public Property PD_FECPAGO As String
            Get
                Return _PD_FECPAGO
            End Get
            Set(value As String)
                _PD_FECPAGO = value
            End Set
        End Property

        Public Property PD_IMPORTE As Double
            Get
                Return _PD_IMPORTE
            End Get
            Set(value As Double)
                _PD_IMPORTE = value
            End Set
        End Property

        Public Property PD_IDCOMPROBANTE As Integer
            Get
                Return _PD_IDCOMPROBANTE
            End Get
            Set(value As Integer)
                _PD_IDCOMPROBANTE = value
            End Set
        End Property

        Public Property PD_EST_CUOTA As Integer
            Get
                Return _PD_EST_CUOTA
            End Get
            Set(value As Integer)
                _PD_EST_CUOTA = value
            End Set
        End Property

        Public Property PD_COMENTARIOS As String
            Get
                Return _PD_COMENTARIOS
            End Get
            Set(value As String)
                _PD_COMENTARIOS = value
            End Set
        End Property

    End Class


    Public Class SG_FA_TB_PRE_FACTURA_DETALLE

        Private _PFD_IDCAB_CUENTA As System.Int32

        Public Property PFD_IDCAB_CUENTA As System.Int32
            Get
                Return (_PFD_IDCAB_CUENTA)
            End Get
            Set(ByVal value As System.Int32)
                _PFD_IDCAB_CUENTA = value
            End Set
        End Property

        Private _PFD_ITEM As System.Int32

        Public Property PFD_ITEM As System.Int32
            Get
                Return (_PFD_ITEM)
            End Get
            Set(ByVal value As System.Int32)
                _PFD_ITEM = value
            End Set
        End Property

        Private _PFD_IDARTICULO As System.Int32

        Public Property PFD_IDARTICULO As System.Int32
            Get
                Return (_PFD_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _PFD_IDARTICULO = value
            End Set
        End Property

        Private _PFD_CANT As System.Int32

        Public Property PFD_CANT As System.Int32
            Get
                Return (_PFD_CANT)
            End Get
            Set(ByVal value As System.Int32)
                _PFD_CANT = value
            End Set
        End Property

        Private _PFD_TOTAL As System.Double

        Public Property PFD_TOTAL As System.Double
            Get
                Return (_PFD_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _PFD_TOTAL = value
            End Set
        End Property

        Private _PFD_PRECIO As System.Double

        Public Property PFD_PRECIO As System.Double
            Get
                Return (_PFD_PRECIO)
            End Get
            Set(ByVal value As System.Double)
                _PFD_PRECIO = value
            End Set
        End Property

        Private _PFD_USUARIO As System.String

        Public Property PFD_USUARIO As System.String
            Get
                Return (_PFD_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _PFD_USUARIO = value
            End Set
        End Property

        Private _PFD_ESTACION As System.String

        Public Property PFD_ESTACION As System.String
            Get
                Return (_PFD_ESTACION)
            End Get
            Set(ByVal value As System.String)
                _PFD_ESTACION = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PAQUETE_DET

        Private _PD_IDCAB As System.Int32

        Public Property PD_IDCAB As System.Int32
            Get
                Return (_PD_IDCAB)
            End Get
            Set(ByVal value As System.Int32)
                _PD_IDCAB = value
            End Set
        End Property

        Private _PD_IDARTICULO As System.Int32

        Public Property PD_IDARTICULO As System.Int32
            Get
                Return (_PD_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _PD_IDARTICULO = value
            End Set
        End Property

        Private _PD_IDEMPRESA As System.Int32

        Public Property PD_IDEMPRESA As System.Int32
            Get
                Return (_PD_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _PD_IDEMPRESA = value
            End Set
        End Property

        Private _PD_CANTIDAD As System.Int32

        Public Property PD_CANTIDAD As System.Int32
            Get
                Return (_PD_CANTIDAD)
            End Get
            Set(ByVal value As System.Int32)
                _PD_CANTIDAD = value
            End Set
        End Property
    End Class

    Public Class SG_FA_TB_PAQUETE_CAB

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _PC_ID As System.Int32

        Public Property PC_ID As System.Int32
            Get
                Return (_PC_ID)
            End Get
            Set(ByVal value As System.Int32)
                _PC_ID = value
            End Set
        End Property

        Private _PC_DESCRIPCION As System.String

        Public Property PC_DESCRIPCION As System.String
            Get
                Return (_PC_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _PC_DESCRIPCION = value
            End Set
        End Property

        Private _PC_ESTADO As System.Int32

        Public Property PC_ESTADO As System.Int32
            Get
                Return (_PC_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _PC_ESTADO = value
            End Set
        End Property

        Private _PC_USUARIO As System.String

        Public Property PC_USUARIO As System.String
            Get
                Return (_PC_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _PC_USUARIO = value
            End Set
        End Property

        Private _PC_TERMINAL As System.String

        Public Property PC_TERMINAL As System.String
            Get
                Return (_PC_TERMINAL)
            End Get
            Set(ByVal value As System.String)
                _PC_TERMINAL = value
            End Set
        End Property

        Private _PC_FECREG As System.DateTime

        Public Property PC_FECREG As System.DateTime
            Get
                Return (_PC_FECREG)
            End Get
            Set(ByVal value As System.DateTime)
                _PC_FECREG = value
            End Set
        End Property

        Private _PC_IDEMPRESA As System.Int32

        Public Property PC_IDEMPRESA As System.Int32
            Get
                Return (_PC_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _PC_IDEMPRESA = value
            End Set
        End Property

        Private _PC_CuentaCont As System.String

        Public Property PC_CuentaCont As System.String
            Get
                Return (_PC_CuentaCont)
            End Get
            Set(ByVal value As System.String)
                _PC_CuentaCont = value
            End Set
        End Property

        Private _PC_IDARTICULO As System.Int32

        Public Property PC_IDARTICULO As System.Int32
            Get
                Return (_PC_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _PC_IDARTICULO = value
            End Set
        End Property
    End Class


    Public Class SG_FA_TB_PRESUPUESTO_DET

        Private _DP_ID As System.Int32

        Public Property DP_ID As System.Int32
            Get
                Return (_DP_ID)
            End Get
            Set(ByVal value As System.Int32)
                _DP_ID = value
            End Set
        End Property

        Private _DP_ITEMS As System.Int32

        Public Property DP_ITEMS As System.Int32
            Get
                Return (_DP_ITEMS)
            End Get
            Set(ByVal value As System.Int32)
                _DP_ITEMS = value
            End Set
        End Property

        Private _DP_IDARTICULO As System.Int32

        Public Property DP_IDARTICULO As System.Int32
            Get
                Return (_DP_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _DP_IDARTICULO = value
            End Set
        End Property

        Private _DP_CANT As System.Int32

        Public Property DP_CANT As System.Int32
            Get
                Return (_DP_CANT)
            End Get
            Set(ByVal value As System.Int32)
                _DP_CANT = value
            End Set
        End Property

        Private _DP_PRECIO As System.Double

        Public Property DP_PRECIO As System.Double
            Get
                Return (_DP_PRECIO)
            End Get
            Set(ByVal value As System.Double)
                _DP_PRECIO = value
            End Set
        End Property

        Private _DP_DSCTO_SEG As System.Double

        Public Property DP_DSCTO_SEG As System.Double
            Get
                Return (_DP_DSCTO_SEG)
            End Get
            Set(ByVal value As System.Double)
                _DP_DSCTO_SEG = value
            End Set
        End Property

        Private _DP_DSCTO_OTRO As System.Double

        Public Property DP_DSCTO_OTRO As System.Double
            Get
                Return (_DP_DSCTO_OTRO)
            End Get
            Set(ByVal value As System.Double)
                _DP_DSCTO_OTRO = value
            End Set
        End Property

        Private _DP_SUB_TOTAL As System.Double

        Public Property DP_SUB_TOTAL As System.Double
            Get
                Return (_DP_SUB_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _DP_SUB_TOTAL = value
            End Set
        End Property

        Private _DP_IGV As System.Double

        Public Property DP_IGV As System.Double
            Get
                Return (_DP_IGV)
            End Get
            Set(ByVal value As System.Double)
                _DP_IGV = value
            End Set
        End Property

        Private _DP_TOTAL As System.Double

        Public Property DP_TOTAL As System.Double
            Get
                Return (_DP_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _DP_TOTAL = value
            End Set
        End Property

        Private _DP_SEG_CUBRE As System.Int32

        Public Property DP_SEG_CUBRE As System.Int32
            Get
                Return (_DP_SEG_CUBRE)
            End Get
            Set(ByVal value As System.Int32)
                _DP_SEG_CUBRE = value
            End Set
        End Property

        Private _DP_DEDUCIBLE As System.Int32

        Public Property DP_DEDUCIBLE As System.Int32
            Get
                Return (_DP_DEDUCIBLE)
            End Get
            Set(ByVal value As System.Int32)
                _DP_DEDUCIBLE = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PRESUPUESTO_CAB

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _Detalles As New List(Of BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET)
        Public Property Detalles As List(Of BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET)
            Get
                Return _Detalles
            End Get
            Set(ByVal value As List(Of BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET))
                _Detalles = value
            End Set
        End Property

        Private _PR_IDpreFac As System.Int32

        Public Property PR_IDpreFac As System.Int32
            Get
                Return (_PR_IDpreFac)
            End Get
            Set(ByVal value As System.Int32)
                _PR_IDpreFac = value
            End Set
        End Property

        Private _PR_ID As System.Int32

        Public Property PR_ID As System.Int32
            Get
                Return (_PR_ID)
            End Get
            Set(ByVal value As System.Int32)
                _PR_ID = value
            End Set
        End Property

        Private _PR_IDSEGURO As System.String

        Public Property PR_IDSEGURO As System.String
            Get
                Return (_PR_IDSEGURO)
            End Get
            Set(ByVal value As System.String)
                _PR_IDSEGURO = value
            End Set
        End Property

        Private _PR_IDNUMHIST As System.Int32

        Public Property PR_IDNUMHIST As System.Int32
            Get
                Return (_PR_IDNUMHIST)
            End Get
            Set(ByVal value As System.Int32)
                _PR_IDNUMHIST = value
            End Set
        End Property

        Private _PR_IDCLIENTE As System.Int32

        Public Property PR_IDCLIENTE As System.Int32
            Get
                Return (_PR_IDCLIENTE)
            End Get
            Set(ByVal value As System.Int32)
                _PR_IDCLIENTE = value
            End Set
        End Property

        Private _PR_IDMEDICO As System.String

        Public Property PR_IDMEDICO As System.String
            Get
                Return (_PR_IDMEDICO)
            End Get
            Set(ByVal value As System.String)
                _PR_IDMEDICO = value
            End Set
        End Property

        Private _PR_IDPAQUETE As System.Int32

        Public Property PR_IDPAQUETE As System.Int32
            Get
                Return (_PR_IDPAQUETE)
            End Get
            Set(ByVal value As System.Int32)
                _PR_IDPAQUETE = value
            End Set
        End Property

        Private _PR_COPG_FIJO As System.Double

        Public Property PR_COPG_FIJO As System.Double
            Get
                Return (_PR_COPG_FIJO)
            End Get
            Set(ByVal value As System.Double)
                _PR_COPG_FIJO = value
            End Set
        End Property

        Private _PR_COPG_VARI As System.Double

        Public Property PR_COPG_VARI As System.Double
            Get
                Return (_PR_COPG_VARI)
            End Get
            Set(ByVal value As System.Double)
                _PR_COPG_VARI = value
            End Set
        End Property

        Private _PR_ESTADO_PRE As System.Int32

        Public Property PR_ESTADO_PRE As System.Int32
            Get
                Return (_PR_ESTADO_PRE)
            End Get
            Set(ByVal value As System.Int32)
                _PR_ESTADO_PRE = value
            End Set
        End Property

        Private _PR_FECHA As System.DateTime

        Public Property PR_FECHA As System.DateTime
            Get
                Return (_PR_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _PR_FECHA = value
            End Set
        End Property

        Private _PR_IDEMPRESA As System.Int32

        Public Property PR_IDEMPRESA As System.Int32
            Get
                Return (_PR_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _PR_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PRE_FACTURA_CAB

        Private _Detalles As New List(Of BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET)
        Public Property Detalles As List(Of BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET)
            Get
                Return _Detalles
            End Get
            Set(ByVal value As List(Of BE.FacturacionBE.SG_FA_TB_PRESUPUESTO_DET))
                _Detalles = value
            End Set
        End Property

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _PF_ID As System.Int32

        Public Property PF_ID As System.Int32
            Get
                Return (_PF_ID)
            End Get
            Set(ByVal value As System.Int32)
                _PF_ID = value
            End Set
        End Property

        Private _PF_IDCUENTA As System.Int32

        Public Property PF_IDCUENTA As System.Int32
            Get
                Return (_PF_IDCUENTA)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDCUENTA = value
            End Set
        End Property

        Private _PF_IDTIPO_ATENC As System.Int32

        Public Property PF_IDTIPO_ATENC As System.Int32
            Get
                Return (_PF_IDTIPO_ATENC)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDTIPO_ATENC = value
            End Set
        End Property

        Private _PF_IDSEGURO As System.String

        Public Property PF_IDSEGURO As System.String
            Get
                Return (_PF_IDSEGURO)
            End Get
            Set(ByVal value As System.String)
                _PF_IDSEGURO = value
            End Set
        End Property

        Private _PF_IDNUMHIST As System.Int32

        Public Property PF_IDNUMHIST As System.Int32
            Get
                Return (_PF_IDNUMHIST)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDNUMHIST = value
            End Set
        End Property

        Private _PF_IDCLIENTE As System.Int32

        Public Property PF_IDCLIENTE As System.Int32
            Get
                Return (_PF_IDCLIENTE)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDCLIENTE = value
            End Set
        End Property

        Private _PF_IDMEDICO As System.String

        Public Property PF_IDMEDICO As System.String
            Get
                Return (_PF_IDMEDICO)
            End Get
            Set(ByVal value As System.String)
                _PF_IDMEDICO = value
            End Set
        End Property

        Private _PF_SUBTOTAL As System.Double

        Public Property PF_SUBTOTAL As System.Double
            Get
                Return (_PF_SUBTOTAL)
            End Get
            Set(ByVal value As System.Double)
                _PF_SUBTOTAL = value
            End Set
        End Property

        Private _PF_IGV As System.Double

        Public Property PF_IGV As System.Double
            Get
                Return (_PF_IGV)
            End Get
            Set(ByVal value As System.Double)
                _PF_IGV = value
            End Set
        End Property

        Private _PF_TOTAL As System.Double

        Public Property PF_TOTAL As System.Double
            Get
                Return (_PF_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _PF_TOTAL = value
            End Set
        End Property

        Private _PF_ESTADO_PRE_F As System.Int32

        Public Property PF_ESTADO_PRE_F As System.Int32
            Get
                Return (_PF_ESTADO_PRE_F)
            End Get
            Set(ByVal value As System.Int32)
                _PF_ESTADO_PRE_F = value
            End Set
        End Property

        Private _PF_ESTADO_REG As System.Int32

        Public Property PF_ESTADO_REG As System.Int32
            Get
                Return (_PF_ESTADO_REG)
            End Get
            Set(ByVal value As System.Int32)
                _PF_ESTADO_REG = value
            End Set
        End Property

        Private _PF_USUARIO As System.String

        Public Property PF_USUARIO As System.String
            Get
                Return (_PF_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _PF_USUARIO = value
            End Set
        End Property

        Private _PF_TERMINAL As System.String

        Public Property PF_TERMINAL As System.String
            Get
                Return (_PF_TERMINAL)
            End Get
            Set(ByVal value As System.String)
                _PF_TERMINAL = value
            End Set
        End Property

        Private _PF_FECREG As System.DateTime

        Public Property PF_FECREG As System.DateTime
            Get
                Return (_PF_FECREG)
            End Get
            Set(ByVal value As System.DateTime)
                _PF_FECREG = value
            End Set
        End Property

        Private _PF_IDEMPRESA As System.Int32

        Public Property PF_IDEMPRESA As System.Int32
            Get
                Return (_PF_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDEMPRESA = value
            End Set
        End Property

        Private _PF_FECHA As System.DateTime

        Public Property PF_FECHA As System.DateTime
            Get
                Return (_PF_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _PF_FECHA = value
            End Set
        End Property

        Private _PF_IDCIE10 As System.Int32

        Public Property PF_IDCIE10 As System.Int32
            Get
                Return (_PF_IDCIE10)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDCIE10 = value
            End Set
        End Property

        Private _PF_IDPRESUPUESTO As System.Int32

        Public Property PF_IDPRESUPUESTO As System.Int32
            Get
                Return (_PF_IDPRESUPUESTO)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDPRESUPUESTO = value
            End Set
        End Property

        Private _PF_FECHAIngreso As System.DateTime

        Public Property PF_FECHAIngreso As System.DateTime
            Get
                Return (_PF_FECHAIngreso)
            End Get
            Set(ByVal value As System.DateTime)
                _PF_FECHAIngreso = value
            End Set
        End Property

        Private _PF_FECHAAlta As System.DateTime

        Public Property PF_FECHAAlta As System.DateTime
            Get
                Return (_PF_FECHAAlta)
            End Get
            Set(ByVal value As System.DateTime)
                _PF_FECHAAlta = value
            End Set
        End Property

        Private _PF_Tratamiento As System.String

        Public Property PF_Tratamiento As System.String
            Get
                Return (_PF_Tratamiento)
            End Get
            Set(ByVal value As System.String)
                _PF_Tratamiento = value
            End Set
        End Property

        Private _PF_IDPaquete As System.Int32

        Public Property PF_IDPaquete As System.Int32
            Get
                Return (_PF_IDPaquete)
            End Get
            Set(ByVal value As System.Int32)
                _PF_IDPaquete = value
            End Set
        End Property


        Private _PF_FacTramite As System.Int32

        Public Property PF_FacTramite As System.Int32
            Get
                Return (_PF_FacTramite)
            End Get
            Set(ByVal value As System.Int32)
                _PF_FacTramite = value
            End Set
        End Property
    End Class


    Public Class SG_FA_TB_TARIFA_MEDICA

        Private _TM_IDARTICULO As System.Int32

        Public Property TM_IDARTICULO As System.Int32
            Get
                Return (_TM_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _TM_IDARTICULO = value
            End Set
        End Property

        Private _TM_IDMEDICO As System.String

        Public Property TM_IDMEDICO As System.String
            Get
                Return (_TM_IDMEDICO)
            End Get
            Set(ByVal value As System.String)
                _TM_IDMEDICO = value
            End Set
        End Property

        Private _TM_IDEMPRESA As System.Int32

        Public Property TM_IDEMPRESA As System.Int32
            Get
                Return (_TM_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _TM_IDEMPRESA = value
            End Set
        End Property

        Private _TM_PRECIO As System.Double

        Public Property TM_PRECIO As System.Double
            Get
                Return (_TM_PRECIO)
            End Get
            Set(ByVal value As System.Double)
                _TM_PRECIO = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_ARTI_SEGU

        Private _AS_IDARTICULO As System.Int32

        Public Property AS_IDARTICULO As System.Int32
            Get
                Return (_AS_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _AS_IDARTICULO = value
            End Set
        End Property

        Private _AS_IDSEGURO As System.String

        Public Property AS_IDSEGURO As System.String
            Get
                Return (_AS_IDSEGURO)
            End Get
            Set(ByVal value As System.String)
                _AS_IDSEGURO = value
            End Set
        End Property

        Private _AS_IMPORTE As System.Double

        Public Property AS_IMPORTE As System.Double
            Get
                Return (_AS_IMPORTE)
            End Get
            Set(ByVal value As System.Double)
                _AS_IMPORTE = value
            End Set
        End Property

        Private _AS_IDEMPRESA As System.Int32

        Public Property AS_IDEMPRESA As System.Int32
            Get
                Return (_AS_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _AS_IDEMPRESA = value
            End Set
        End Property

        Private _AS_USUARIO As System.String

        Public Property AS_USUARIO As System.String
            Get
                Return (_AS_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _AS_USUARIO = value
            End Set
        End Property

        Private _AS_TERMINAL As System.String

        Public Property AS_TERMINAL As System.String
            Get
                Return (_AS_TERMINAL)
            End Get
            Set(ByVal value As System.String)
                _AS_TERMINAL = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_TURNO
        Private _TU_ID As String
        Private _TU_DESCRIPCION As String
        Private _TU_IDEMPRESA As Integer

        Public Sub New()
            _TU_ID = String.Empty
            _TU_DESCRIPCION = String.Empty
            _TU_IDEMPRESA = 0
        End Sub

        Public Property TU_ID As String
            Get
                Return _TU_ID
            End Get
            Set(ByVal value As String)
                _TU_ID = value
            End Set
        End Property

        Public Property TU_DESCRIPCION As String
            Get
                Return _TU_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TU_DESCRIPCION = value
            End Set
        End Property

        Public Property TU_IDEMPRESA As Integer
            Get
                Return _TU_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _TU_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_CAJA_DET
        Private _CD_IDCAB As Integer
        Private _CD_IDCOMPRO As Integer

        Public Sub New()
            _CD_IDCAB = 0
            _CD_IDCOMPRO = 0
        End Sub

        Public Property CD_IDCAB As Integer
            Get
                Return _CD_IDCAB
            End Get
            Set(ByVal value As Integer)
                _CD_IDCAB = value
            End Set
        End Property

        Public Property CD_IDCOMPRO As Integer
            Get
                Return _CD_IDCOMPRO
            End Get
            Set(ByVal value As Integer)
                _CD_IDCOMPRO = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_CAJA_CAB
        Private _CA_ID As Integer
        Private _CA_APE_SOL As Double
        Private _CA_APE_DOL As Double
        Private _CA_CIE_SOL As Double
        Private _CA_CIE_DOL As Double
        Private _CA_IDUSUARIO As Integer
        Private _CA_IDTURNO As String
        Private _CA_FECHA As String
        Private _CA_ESTADO As Integer
        Private _CA_USUARIO As String
        Private _CA_TERMINAL As String
        Private _CA_FECREG As String
        Private _CA_IDEMPRESA As Integer
        Private _CA_USUARIO_CIE As String
        Private _CA_TERMINAL_CIE As String
        Private _CA_FECREG_CIE As String
        Private _CA_NUM_VOU_CONTA As String
        Private _CA_IDVOUCHER As Integer

        Public Sub New()
            _CA_ID = 0
            _CA_APE_SOL = 0.0R
            _CA_APE_DOL = 0.0R
            _CA_CIE_SOL = 0.0R
            _CA_CIE_DOL = 0.0R
            _CA_IDUSUARIO = 0
            _CA_IDTURNO = String.Empty
            _CA_FECHA = String.Empty
            _CA_ESTADO = 0
            _CA_USUARIO = String.Empty
            _CA_TERMINAL = String.Empty
            _CA_FECREG = String.Empty
            _CA_IDEMPRESA = 0
            _CA_USUARIO_CIE = String.Empty
            _CA_TERMINAL_CIE = String.Empty
            _CA_FECREG_CIE = String.Empty
            _CA_NUM_VOU_CONTA = String.Empty
            _CA_IDVOUCHER = 0
        End Sub

        Public Property CA_NUM_VOU_CONTA As String
            Get
                Return _CA_NUM_VOU_CONTA
            End Get
            Set(ByVal value As String)
                _CA_NUM_VOU_CONTA = value
            End Set
        End Property

        Public Property CA_IDVOUCHER As Integer
            Get
                Return _CA_IDVOUCHER
            End Get
            Set(ByVal value As Integer)
                _CA_IDVOUCHER = value
            End Set
        End Property

        Public Property CA_ID As Integer
            Get
                Return _CA_ID
            End Get
            Set(ByVal value As Integer)
                _CA_ID = value
            End Set
        End Property

        Public Property CA_APE_SOL As Double
            Get
                Return _CA_APE_SOL
            End Get
            Set(ByVal value As Double)
                _CA_APE_SOL = value
            End Set
        End Property

        Public Property CA_APE_DOL As Double
            Get
                Return _CA_APE_DOL
            End Get
            Set(ByVal value As Double)
                _CA_APE_DOL = value
            End Set
        End Property

        Public Property CA_CIE_SOL As Double
            Get
                Return _CA_CIE_SOL
            End Get
            Set(ByVal value As Double)
                _CA_CIE_SOL = value
            End Set
        End Property

        Public Property CA_CIE_DOL As Double
            Get
                Return _CA_CIE_DOL
            End Get
            Set(ByVal value As Double)
                _CA_CIE_DOL = value
            End Set
        End Property

        Public Property CA_IDUSUARIO As Integer
            Get
                Return _CA_IDUSUARIO
            End Get
            Set(ByVal value As Integer)
                _CA_IDUSUARIO = value
            End Set
        End Property

        Public Property CA_IDTURNO As String
            Get
                Return _CA_IDTURNO
            End Get
            Set(ByVal value As String)
                _CA_IDTURNO = value
            End Set
        End Property

        Public Property CA_FECHA As String
            Get
                Return _CA_FECHA
            End Get
            Set(ByVal value As String)
                _CA_FECHA = value
            End Set
        End Property

        Public Property CA_ESTADO As Integer
            Get
                Return _CA_ESTADO
            End Get
            Set(ByVal value As Integer)
                _CA_ESTADO = value
            End Set
        End Property

        Public Property CA_USUARIO As String
            Get
                Return _CA_USUARIO
            End Get
            Set(ByVal value As String)
                _CA_USUARIO = value
            End Set
        End Property

        Public Property CA_TERMINAL As String
            Get
                Return _CA_TERMINAL
            End Get
            Set(ByVal value As String)
                _CA_TERMINAL = value
            End Set
        End Property

        Public Property CA_FECREG As String
            Get
                Return _CA_FECREG
            End Get
            Set(ByVal value As String)
                _CA_FECREG = value
            End Set
        End Property

        Public Property CA_IDEMPRESA As Integer
            Get
                Return _CA_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _CA_IDEMPRESA = value
            End Set
        End Property

        Public Property CA_USUARIO_CIE As String
            Get
                Return _CA_USUARIO_CIE
            End Get
            Set(ByVal value As String)
                _CA_USUARIO_CIE = value
            End Set
        End Property

        Public Property CA_TERMINAL_CIE As String
            Get
                Return _CA_TERMINAL_CIE
            End Get
            Set(ByVal value As String)
                _CA_TERMINAL_CIE = value
            End Set
        End Property

        Public Property CA_FECREG_CIE As String
            Get
                Return _CA_FECREG_CIE
            End Get
            Set(ByVal value As String)
                _CA_FECREG_CIE = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_COMPRO_DOCPAGO
        Private _CD_IDCOMPROBANTE As Integer
        Private _CD_IDDOCPAGO As String
        Private _CD_IMPORTE As Double
        Private _CD_IMPORTED As Double
        Private _CD_USUARIO As String
        Private _CD_PC As String
        Private _CD_FECREG As String

        Public Sub New()
            _CD_IDCOMPROBANTE = 0
            _CD_IDDOCPAGO = String.Empty
            _CD_IMPORTE = 0.0R
            _CD_IMPORTED = 0.0R
            _CD_USUARIO = String.Empty
            _CD_PC = String.Empty
            _CD_FECREG = String.Empty
        End Sub

        Public Property CD_IDCOMPROBANTE As Integer
            Get
                Return _CD_IDCOMPROBANTE
            End Get
            Set(ByVal value As Integer)
                _CD_IDCOMPROBANTE = value
            End Set
        End Property

        Public Property CD_IDDOCPAGO As String
            Get
                Return _CD_IDDOCPAGO
            End Get
            Set(ByVal value As String)
                _CD_IDDOCPAGO = value
            End Set
        End Property

        Public Property CD_IMPORTE As Double
            Get
                Return _CD_IMPORTE
            End Get
            Set(ByVal value As Double)
                _CD_IMPORTE = value
            End Set
        End Property

        Public Property CD_IMPORTED As Double
            Get
                Return _CD_IMPORTED
            End Get
            Set(ByVal value As Double)
                _CD_IMPORTED = value
            End Set
        End Property

        Public Property CD_USUARIO As String
            Get
                Return _CD_USUARIO
            End Get
            Set(ByVal value As String)
                _CD_USUARIO = value
            End Set
        End Property

        Public Property CD_PC As String
            Get
                Return _CD_PC
            End Get
            Set(ByVal value As String)
                _CD_PC = value
            End Set
        End Property

        Public Property CD_FECREG As String
            Get
                Return _CD_FECREG
            End Get
            Set(ByVal value As String)
                _CD_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_CLIENTE_COMUNI
        Private _CC_IDCLIENTE As Integer
        Private _CC_IDCOMUNICA As Integer
        Private _CC_DESCRIPCION As String

        Public Sub New(ByVal CC_IDCLIENTE_ As Integer, ByVal CC_IDCOMUNICA_ As Integer, ByVal CC_DESCRIPCION_ As String)
            _CC_IDCLIENTE = CC_IDCLIENTE_
            _CC_IDCOMUNICA = CC_IDCOMUNICA_
            _CC_DESCRIPCION = CC_DESCRIPCION_
        End Sub

        Public Sub New()
            _CC_IDCLIENTE = 0
            _CC_IDCOMUNICA = 0
            _CC_DESCRIPCION = String.Empty
        End Sub

        Public Property CC_DESCRIPCION As String
            Get
                Return _CC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CC_DESCRIPCION = value
            End Set
        End Property

        Public Property CC_IDCLIENTE As Integer
            Get
                Return _CC_IDCLIENTE
            End Get
            Set(ByVal value As Integer)
                _CC_IDCLIENTE = value
            End Set
        End Property

        Public Property CC_IDCOMUNICA As Integer
            Get
                Return _CC_IDCOMUNICA
            End Get
            Set(ByVal value As Integer)
                _CC_IDCOMUNICA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_CIA_ASEG

        Private _CA_ID As System.String

        Public Property CA_ID As System.String
            Get
                Return (_CA_ID)
            End Get
            Set(ByVal value As System.String)
                _CA_ID = value
            End Set
        End Property

        Private _CA_IDTIPO_CIA_ASEG As System.String

        Public Property CA_IDTIPO_CIA_ASEG As System.String
            Get
                Return (_CA_IDTIPO_CIA_ASEG)
            End Get
            Set(ByVal value As System.String)
                _CA_IDTIPO_CIA_ASEG = value
            End Set
        End Property

        Private _CA_DESCRIPCION As System.String

        Public Property CA_DESCRIPCION As System.String
            Get
                Return (_CA_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _CA_DESCRIPCION = value
            End Set
        End Property

        Private _CA_DIRECCION As System.String

        Public Property CA_DIRECCION As System.String
            Get
                Return (_CA_DIRECCION)
            End Get
            Set(ByVal value As System.String)
                _CA_DIRECCION = value
            End Set
        End Property

        Private _CA_IDTIPO_DOC As System.Int32

        Public Property CA_IDTIPO_DOC As System.Int32
            Get
                Return (_CA_IDTIPO_DOC)
            End Get
            Set(ByVal value As System.Int32)
                _CA_IDTIPO_DOC = value
            End Set
        End Property

        Private _CA_NUM_DOC As System.String

        Public Property CA_NUM_DOC As System.String
            Get
                Return (_CA_NUM_DOC)
            End Get
            Set(ByVal value As System.String)
                _CA_NUM_DOC = value
            End Set
        End Property

        Private _CA_TELEFONO As System.String

        Public Property CA_TELEFONO As System.String
            Get
                Return (_CA_TELEFONO)
            End Get
            Set(ByVal value As System.String)
                _CA_TELEFONO = value
            End Set
        End Property

        Private _CA_PAG_WEB As System.String

        Public Property CA_PAG_WEB As System.String
            Get
                Return (_CA_PAG_WEB)
            End Get
            Set(ByVal value As System.String)
                _CA_PAG_WEB = value
            End Set
        End Property

        Private _CA_REPRE As System.String

        Public Property CA_REPRE As System.String
            Get
                Return (_CA_REPRE)
            End Get
            Set(ByVal value As System.String)
                _CA_REPRE = value
            End Set
        End Property

        Private _CA_IDEMPRESA As System.Int32

        Public Property CA_IDEMPRESA As System.Int32
            Get
                Return (_CA_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _CA_IDEMPRESA = value
            End Set
        End Property

        Private _CA_IDASEGU_SITED As System.String

        Public Property CA_IDASEGU_SITED As System.String
            Get
                Return (_CA_IDASEGU_SITED)
            End Get
            Set(ByVal value As System.String)
                _CA_IDASEGU_SITED = value
            End Set
        End Property


        Private _CA_IDSUNASA As System.String

        Public Property CA_IDSUNASA As System.String
            Get
                Return (_CA_IDSUNASA)
            End Get
            Set(ByVal value As System.String)
                _CA_IDSUNASA = value
            End Set
        End Property

        Private _CA_FactorHonorario As System.Double

        Public Property CA_FactorHonorario As System.Double
            Get
                Return (_CA_FactorHonorario)
            End Get
            Set(ByVal value As System.Double)
                _CA_FactorHonorario = value
            End Set
        End Property

        Private _CA_FactorServicio As System.Double

        Public Property CA_FactorServicio As System.Double
            Get
                Return (_CA_FactorServicio)
            End Get
            Set(ByVal value As System.Double)
                _CA_FactorServicio = value
            End Set
        End Property
    End Class

    Public Class SG_FA_TB_TIPO_CIA_ASEG

        Private _TA_ID As System.String

        Public Property TA_ID As System.String
            Get
                Return (_TA_ID)
            End Get
            Set(ByVal value As System.String)
                _TA_ID = value
            End Set
        End Property

        Private _TA_DESCRIPCION As System.String

        Public Property TA_DESCRIPCION As System.String
            Get
                Return (_TA_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _TA_DESCRIPCION = value
            End Set
        End Property

        Private _TA_IDEMPRESA As System.Int32

        Public Property TA_IDEMPRESA As System.Int32
            Get
                Return (_TA_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _TA_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_DOCU_PAGO
        Private _DP_CODIGO As String
        Private _DP_DESCRIPCION As String
        Private _DP_ABREVIATURA As String
        Private _DP_CTA_CONTA As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
        Private _DP_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal DP_CODIGO_ As String, ByVal DP_DESCRIPCION_ As String, ByVal DP_ABREVIATURA_ As String, ByVal DP_CTA_CONTA_ As BE.ContabilidadBE.SG_CO_TB_PLANCTAS, ByVal DP_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _DP_CODIGO = DP_CODIGO_
            _DP_DESCRIPCION = DP_DESCRIPCION_
            _DP_ABREVIATURA = DP_ABREVIATURA_
            _DP_CTA_CONTA = DP_CTA_CONTA_
            _DP_IDEMPRESA = DP_IDEMPRESA_
        End Sub

        Public Sub New()
            _DP_CODIGO = String.Empty
            _DP_DESCRIPCION = String.Empty
            _DP_ABREVIATURA = String.Empty
            _DP_CTA_CONTA = Nothing
            _DP_IDEMPRESA = Nothing
        End Sub

        Public Property DP_CODIGO As String
            Get
                Return _DP_CODIGO
            End Get
            Set(ByVal value As String)
                _DP_CODIGO = value
            End Set
        End Property

        Public Property DP_DESCRIPCION As String
            Get
                Return _DP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DP_DESCRIPCION = value
            End Set
        End Property

        Public Property DP_ABREVIATURA As String
            Get
                Return _DP_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _DP_ABREVIATURA = value
            End Set
        End Property

        Public Property DP_CTA_CONTA As BE.ContabilidadBE.SG_CO_TB_PLANCTAS
            Get
                Return _DP_CTA_CONTA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_PLANCTAS)
                _DP_CTA_CONTA = value
            End Set
        End Property

        Public Property DP_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _DP_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _DP_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PARIDAD
        Private _PA_FECHA As String
        Private _PA_IDMONEDA As BE.FacturacionBE.SG_FA_TB_MONEDA
        Private _PA_COMPRA As Double
        Private _PA_VENTA As Double
        Private _PA_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _PA_USUARIO As String
        Private _PA_TERMINAL As String
        Private _PA_FECREG As String

        Public Sub New(ByVal PA_FECHA_ As String, ByVal PA_IDMONEDA_ As BE.FacturacionBE.SG_FA_TB_MONEDA, ByVal PA_COMPRA_ As Double, ByVal PA_VENTA_ As Double, ByVal PA_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal PA_USUARIO_ As String, ByVal PA_TERMINAL_ As String, ByVal PA_FECREG_ As String)
            _PA_FECHA = PA_FECHA_
            _PA_IDMONEDA = PA_IDMONEDA_
            _PA_COMPRA = PA_COMPRA_
            _PA_VENTA = PA_VENTA_
            _PA_IDEMPRESA = PA_IDEMPRESA_
            _PA_USUARIO = PA_USUARIO_
            _PA_TERMINAL = PA_TERMINAL_
            _PA_FECREG = PA_FECREG_
        End Sub

        Public Sub New()
            _PA_FECHA = String.Empty
            _PA_IDMONEDA = Nothing
            _PA_COMPRA = 0
            _PA_VENTA = 0
            _PA_IDEMPRESA = Nothing
            _PA_USUARIO = String.Empty
            _PA_TERMINAL = String.Empty
            _PA_FECREG = String.Empty
        End Sub

        Public Property PA_FECHA As String
            Get
                Return _PA_FECHA
            End Get
            Set(ByVal value As String)
                _PA_FECHA = value
            End Set
        End Property

        Public Property PA_IDMONEDA As BE.FacturacionBE.SG_FA_TB_MONEDA
            Get
                Return _PA_IDMONEDA
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_MONEDA)
                _PA_IDMONEDA = value
            End Set
        End Property

        Public Property PA_COMPRA As Double
            Get
                Return _PA_COMPRA
            End Get
            Set(ByVal value As Double)
                _PA_COMPRA = value
            End Set
        End Property

        Public Property PA_VENTA As Double
            Get
                Return _PA_VENTA
            End Get
            Set(ByVal value As Double)
                _PA_VENTA = value
            End Set
        End Property

        Public Property PA_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _PA_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _PA_IDEMPRESA = value
            End Set
        End Property

        Public Property PA_USUARIO As String
            Get
                Return _PA_USUARIO
            End Get
            Set(ByVal value As String)
                _PA_USUARIO = value
            End Set
        End Property

        Public Property PA_TERMINAL As String
            Get
                Return _PA_TERMINAL
            End Get
            Set(ByVal value As String)
                _PA_TERMINAL = value
            End Set
        End Property

        Public Property PA_FECREG As String
            Get
                Return _PA_FECREG
            End Get
            Set(ByVal value As String)
                _PA_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_MONEDA
        Private _MO_ID As String
        Private _MO_DESCRIPCION As String
        Private _MO_ABREVIATURA As String
        Private _MO_SIMBOLO As String
        Private _MO_IDMON_CONTA As BE.ContabilidadBE.SG_CO_TB_MONEDA
        Private _MO_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal MO_ID_ As String, ByVal MO_DESCRIPCION_ As String, ByVal MO_ABREVIATURA_ As String, ByVal MO_SIMBOLO_ As String, ByVal MO_IDMON_CONTA_ As BE.ContabilidadBE.SG_CO_TB_MONEDA, ByVal MO_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _MO_ID = MO_ID_
            _MO_DESCRIPCION = MO_DESCRIPCION_
            _MO_ABREVIATURA = MO_ABREVIATURA_
            _MO_SIMBOLO = MO_SIMBOLO_
            _MO_IDMON_CONTA = MO_IDMON_CONTA_
            _MO_IDEMPRESA = MO_IDEMPRESA_
        End Sub

        Public Sub New()
            _MO_ID = String.Empty
            _MO_DESCRIPCION = String.Empty
            _MO_ABREVIATURA = String.Empty
            _MO_SIMBOLO = String.Empty
            _MO_IDMON_CONTA = Nothing
            _MO_IDEMPRESA = Nothing
        End Sub

        Public Property MO_ID As String
            Get
                Return _MO_ID
            End Get
            Set(ByVal value As String)
                _MO_ID = value
            End Set
        End Property

        Public Property MO_DESCRIPCION As String
            Get
                Return _MO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _MO_DESCRIPCION = value
            End Set
        End Property

        Public Property MO_ABREVIATURA As String
            Get
                Return _MO_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _MO_ABREVIATURA = value
            End Set
        End Property

        Public Property MO_SIMBOLO As String
            Get
                Return _MO_SIMBOLO
            End Get
            Set(ByVal value As String)
                _MO_SIMBOLO = value
            End Set
        End Property

        Public Property MO_IDMON_CONTA As BE.ContabilidadBE.SG_CO_TB_MONEDA
            Get
                Return _MO_IDMON_CONTA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_MONEDA)
                _MO_IDMON_CONTA = value
            End Set
        End Property

        Public Property MO_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _MO_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _MO_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_CAJERO
        Private _CA_ID As String
        Private _CA_NOMBRES As String
        Private _CA_IDUSUARIO As BE.ContabilidadBE.SG_CO_TB_USUARIO
        Private _CA_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _CA_USUARIO As String
        Private _CA_TERMINAL As String
        Private _CA_FECREG As String
        Private _CA_ESTADO As Integer

        Public Sub New(ByVal CA_ID_ As String, ByVal CA_NOMBRES_ As String, ByVal CA_IDUSUARIO_ As BE.ContabilidadBE.SG_CO_TB_USUARIO, ByVal CA_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal CA_USUARIO_ As String, ByVal CA_TERMINAL_ As String, ByVal CA_FECREG_ As String, ByVal CA_ESTADO_ As Integer)
            _CA_ID = CA_ID_
            _CA_NOMBRES = CA_NOMBRES_
            _CA_IDUSUARIO = CA_IDUSUARIO_
            _CA_IDEMPRESA = CA_IDEMPRESA_
            _CA_USUARIO = CA_USUARIO_
            _CA_TERMINAL = CA_TERMINAL_
            _CA_FECREG = CA_FECREG_
            _CA_ESTADO = CA_ESTADO_
        End Sub

        Public Sub New()
            _CA_ID = String.Empty
            _CA_NOMBRES = String.Empty
            _CA_IDUSUARIO = Nothing
            _CA_IDEMPRESA = Nothing
            _CA_USUARIO = String.Empty
            _CA_TERMINAL = String.Empty
            _CA_FECREG = String.Empty
            _CA_ESTADO = 0
        End Sub

        Public Property CA_ID As String
            Get
                Return _CA_ID
            End Get
            Set(ByVal value As String)
                _CA_ID = value
            End Set
        End Property
        Public Property CA_NOMBRES As String
            Get
                Return _CA_NOMBRES
            End Get
            Set(ByVal value As String)
                _CA_NOMBRES = value
            End Set
        End Property

        Public Property CA_IDUSUARIO As BE.ContabilidadBE.SG_CO_TB_USUARIO
            Get
                Return _CA_IDUSUARIO
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_USUARIO)
                _CA_IDUSUARIO = value
            End Set
        End Property

        Public Property CA_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _CA_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _CA_IDEMPRESA = value
            End Set
        End Property

        Public Property CA_USUARIO As String
            Get
                Return _CA_USUARIO
            End Get
            Set(ByVal value As String)
                _CA_USUARIO = value
            End Set
        End Property

        Public Property CA_TERMINAL As String
            Get
                Return _CA_TERMINAL
            End Get
            Set(ByVal value As String)
                _CA_TERMINAL = value
            End Set
        End Property

        Public Property CA_FECREG As String
            Get
                Return _CA_FECREG
            End Get
            Set(ByVal value As String)
                _CA_FECREG = value
            End Set
        End Property

        Public Property CA_ESTADO As Integer
            Get
                Return _CA_ESTADO
            End Get
            Set(ByVal value As Integer)
                _CA_ESTADO = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_DOCUMENTO
        Private _DO_CODIGO As String
        Private _DO_DESCRIPCION As String
        Private _DO_ABREVIATURA As String
        Private _DO_ES_RESTA As Integer
        Private _DO_ISTATUS As Integer
        Private _DO_CODIGO_SUNAT As String
        Private _DO_USUARIO As String
        Private _DO_TERMINAL As String
        Private _DO_FECREG As String
        Private _DO_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _DO_COD_CONTA As String

        Public Sub New(ByVal DO_CODIGO_ As String, ByVal DO_DESCRIPCION_ As String, ByVal DO_ABREVIATURA_ As String, ByVal DO_ES_RESTA_ As Integer, ByVal DO_ISTATUS_ As Integer, ByVal DO_CODIGO_SUNAT_ As String, ByVal DO_USUARIO_ As String, ByVal DO_TERMINAL_ As String, ByVal DO_FECREG_ As String, ByVal DO_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal DO_COD_CONTA_ As String)
            _DO_CODIGO = DO_CODIGO_
            _DO_DESCRIPCION = DO_DESCRIPCION_
            _DO_ABREVIATURA = DO_ABREVIATURA_
            _DO_ES_RESTA = DO_ES_RESTA_
            _DO_ISTATUS = DO_ISTATUS_
            _DO_CODIGO_SUNAT = DO_CODIGO_SUNAT_
            _DO_USUARIO = DO_USUARIO_
            _DO_TERMINAL = DO_TERMINAL_
            _DO_FECREG = DO_FECREG_
            _DO_IDEMPRESA = DO_IDEMPRESA_
            _DO_COD_CONTA = DO_COD_CONTA_
        End Sub

        Public Sub New()
            _DO_CODIGO = String.Empty
            _DO_DESCRIPCION = String.Empty
            _DO_ABREVIATURA = String.Empty
            _DO_ES_RESTA = 0
            _DO_ISTATUS = 0
            _DO_CODIGO_SUNAT = String.Empty
            _DO_USUARIO = String.Empty
            _DO_TERMINAL = String.Empty
            _DO_FECREG = String.Empty
            _DO_IDEMPRESA = Nothing
            _DO_COD_CONTA = String.Empty
        End Sub


        Public Property DO_CODIGO As String
            Get
                Return _DO_CODIGO
            End Get
            Set(ByVal value As String)
                _DO_CODIGO = value
            End Set
        End Property

        Public Property DO_DESCRIPCION As String
            Get
                Return _DO_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _DO_DESCRIPCION = value
            End Set
        End Property

        Public Property DO_ABREVIATURA As String
            Get
                Return _DO_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _DO_ABREVIATURA = value
            End Set
        End Property

        Public Property DO_ES_RESTA As Integer
            Get
                Return _DO_ES_RESTA
            End Get
            Set(ByVal value As Integer)
                _DO_ES_RESTA = value
            End Set
        End Property

        Public Property DO_ISTATUS As Integer
            Get
                Return _DO_ISTATUS
            End Get
            Set(ByVal value As Integer)
                _DO_ISTATUS = value
            End Set
        End Property

        Public Property DO_CODIGO_SUNAT As String
            Get
                Return _DO_CODIGO_SUNAT
            End Get
            Set(ByVal value As String)
                _DO_CODIGO_SUNAT = value
            End Set
        End Property

        Public Property DO_USUARIO As String
            Get
                Return _DO_USUARIO
            End Get
            Set(ByVal value As String)
                _DO_USUARIO = value
            End Set
        End Property


        Public Property DO_TERMINAL As String
            Get
                Return _DO_TERMINAL
            End Get
            Set(ByVal value As String)
                _DO_TERMINAL = value
            End Set
        End Property

        Public Property DO_FECREG As String
            Get
                Return _DO_FECREG
            End Get
            Set(ByVal value As String)
                _DO_FECREG = value
            End Set
        End Property


        Public Property DO_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _DO_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _DO_IDEMPRESA = value
            End Set
        End Property

        Public Property DO_COD_CONTA As String
            Get
                Return _DO_COD_CONTA
            End Get
            Set(ByVal value As String)
                _DO_COD_CONTA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PARAMETROS
        Private _AD_TIPO As String
        Private _AD_NOMBRE As String
        Private _AD_VALOR As String
        Private _AD_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal AD_TIPO_ As String, ByVal AD_NOMBRE_ As String, ByVal AD_VALOR_ As String, ByVal AD_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _AD_TIPO = AD_TIPO_
            _AD_NOMBRE = AD_NOMBRE_
            _AD_VALOR = AD_VALOR_
            _AD_IDEMPRESA = AD_IDEMPRESA_
        End Sub

        Public Sub New()
            _AD_TIPO = String.Empty
            _AD_NOMBRE = String.Empty
            _AD_VALOR = String.Empty
            _AD_IDEMPRESA = Nothing
        End Sub

        Public Property AD_TIPO As String
            Get
                Return _AD_TIPO
            End Get
            Set(ByVal value As String)
                _AD_TIPO = value
            End Set
        End Property

        Public Property AD_NOMBRE As String
            Get
                Return _AD_NOMBRE
            End Get
            Set(ByVal value As String)
                _AD_NOMBRE = value
            End Set
        End Property

        Public Property AD_VALOR As String
            Get
                Return _AD_VALOR
            End Get
            Set(ByVal value As String)
                _AD_VALOR = value
            End Set
        End Property

        Public Property AD_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _AD_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _AD_IDEMPRESA = value
            End Set
        End Property


    End Class

    Public Class SG_FA_TB_USU_PTOVTA
        Private _UP_IDUSARIO As BE.ContabilidadBE.SG_CO_TB_USUARIO
        Private _UP_IDPTO_VTA As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA
        Private _UP_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA


        Public Sub New(ByVal UP_IDUSARIO_ As BE.ContabilidadBE.SG_CO_TB_USUARIO, ByVal UP_IDPTO_VTA_ As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA, ByVal UP_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _UP_IDUSARIO = UP_IDUSARIO_
            _UP_IDPTO_VTA = UP_IDPTO_VTA_
            _UP_IDEMPRESA = UP_IDEMPRESA_
        End Sub

        Public Sub New()
            _UP_IDUSARIO = Nothing
            _UP_IDPTO_VTA = Nothing
            _UP_IDEMPRESA = Nothing
        End Sub

        Public Property UP_IDUSARIO As BE.ContabilidadBE.SG_CO_TB_USUARIO
            Get
                Return _UP_IDUSARIO
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_USUARIO)
                _UP_IDUSARIO = value
            End Set
        End Property

        Public Property UP_IDPTO_VTA As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA
            Get
                Return _UP_IDPTO_VTA
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
                _UP_IDPTO_VTA = value
            End Set
        End Property

        Public Property UP_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _UP_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _UP_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_FORMA_PAGO
        Private _FP_ID As String
        Private _FP_DESCRIPCION As String
        Private _FP_ES_CREDITO As Integer
        Private _FP_DIAS_CREDITO As Integer
        Private _FP_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA


        Public Sub New(ByVal FP_ID_ As String, ByVal FP_DESCRIPCION_ As String, ByVal FP_ES_CREDITO_ As Integer, ByVal FP_DIAS_CREDITO_ As Integer, ByVal FP_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _FP_ID = FP_ID_
            _FP_DESCRIPCION = FP_DESCRIPCION_
            _FP_ES_CREDITO = FP_ES_CREDITO_
            _FP_DIAS_CREDITO = FP_DIAS_CREDITO_
            _FP_IDEMPRESA = FP_IDEMPRESA_
        End Sub

        Public Sub New()
            _FP_ID = String.Empty
            _FP_DESCRIPCION = String.Empty
            _FP_ES_CREDITO = 0
            _FP_DIAS_CREDITO = 0
            _FP_IDEMPRESA = Nothing
        End Sub

        Public Property FP_ID As String
            Get
                Return _FP_ID
            End Get
            Set(ByVal value As String)
                _FP_ID = value
            End Set
        End Property

        Public Property FP_DESCRIPCION As String
            Get
                Return _FP_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _FP_DESCRIPCION = value
            End Set
        End Property

        Public Property FP_ES_CREDITO As Integer
            Get
                Return _FP_ES_CREDITO
            End Get
            Set(ByVal value As Integer)
                _FP_ES_CREDITO = value
            End Set
        End Property

        Public Property FP_DIAS_CREDITO As Integer
            Get
                Return _FP_DIAS_CREDITO
            End Get
            Set(ByVal value As Integer)
                _FP_DIAS_CREDITO = value
            End Set
        End Property

        Public Property FP_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _FP_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _FP_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PTO_VTA_SERIE
        Private _PS_IDPUNTOVTA As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA
        Private _PS_SERIE As String
        Private _PC_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _PS_TD As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO

        Public Sub New(ByVal PS_IDPUNTOVTA_ As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA, ByVal PS_SERIE_ As String, ByVal PC_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal PS_TD_ As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
            _PS_TD = PS_TD_
            _PS_IDPUNTOVTA = PS_IDPUNTOVTA_
            _PS_SERIE = PS_SERIE_
            _PC_IDEMPRESA = PC_IDEMPRESA_
        End Sub

        Public Sub New()
            _PS_TD = Nothing
            _PS_IDPUNTOVTA = Nothing
            _PS_SERIE = String.Empty
            _PC_IDEMPRESA = Nothing
        End Sub

        Public Property PS_TD As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO
            Get
                Return _PS_TD
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_DOCUMENTO)
                _PS_TD = value
            End Set
        End Property

        Public Property PS_IDPUNTOVTA As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA
            Get
                Return _PS_IDPUNTOVTA
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
                _PS_IDPUNTOVTA = value
            End Set
        End Property

        Public Property PS_SERIE As String
            Get
                Return _PS_SERIE
            End Get
            Set(ByVal value As String)
                _PS_SERIE = value
            End Set
        End Property

        Public Property PC_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _PC_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _PC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_PUNTO_VENTA
        Private _PV_ID As String
        Private _PV_DESCRIPCION As String
        Private _PV_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal PV_ID_ As String, ByVal PV_DESCRIPCION_ As String, ByVal PV_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _PV_ID = PV_ID_
            _PV_DESCRIPCION = PV_DESCRIPCION_
            _PV_IDEMPRESA = PV_IDEMPRESA_
        End Sub

        Public Sub New()
            _PV_ID = String.Empty
            _PV_DESCRIPCION = String.Empty
            _PV_IDEMPRESA = Nothing
        End Sub

        Public Property PV_ID As String
            Get
                Return _PV_ID
            End Get
            Set(ByVal value As String)
                _PV_ID = value
            End Set
        End Property

        Public Property PV_DESCRIPCION As String
            Get
                Return _PV_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _PV_DESCRIPCION = value
            End Set
        End Property

        Public Property PV_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _PV_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _PV_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_NUM_COMPRO
        Private _NC_IDTIPO As BE.FacturacionBE.SG_FA_TB_DOCUMENTO
        Private _NC_SERIE As String
        Private _NC_NUMERO As String
        Private _NC_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA

        Public Sub New(ByVal NC_IDTIPO_ As BE.FacturacionBE.SG_FA_TB_DOCUMENTO, ByVal NC_SERIE_ As String, ByVal NC_NUMERO_ As String, ByVal NC_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
            _NC_IDTIPO = NC_IDTIPO_
            _NC_SERIE = NC_SERIE_
            _NC_NUMERO = NC_NUMERO_
            _NC_IDEMPRESA = NC_IDEMPRESA_
        End Sub

        Public Sub New()
            _NC_IDTIPO = Nothing
            _NC_SERIE = String.Empty
            _NC_NUMERO = String.Empty
            _NC_IDEMPRESA = Nothing
        End Sub

        Public Property NC_IDTIPO As BE.FacturacionBE.SG_FA_TB_DOCUMENTO
            Get
                Return _NC_IDTIPO
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
                _NC_IDTIPO = value
            End Set
        End Property

        Public Property NC_SERIE As String
            Get
                Return _NC_SERIE
            End Get
            Set(ByVal value As String)
                _NC_SERIE = value
            End Set
        End Property

        Public Property NC_NUMERO As String
            Get
                Return _NC_NUMERO
            End Get
            Set(ByVal value As String)
                _NC_NUMERO = value
            End Set
        End Property

        Public Property NC_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _NC_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _NC_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_FAMILIA_ARTI
        Private _FA_CODIGO As String
        Private _FA_DESCRIPCION As String
        Private _FA_IDEMPRESA As Integer

        Public Sub New()
            _FA_CODIGO = String.Empty
            _FA_DESCRIPCION = String.Empty
            _FA_IDEMPRESA = 0
        End Sub

        Public Sub New(ByVal FA_CODIGO_ As String, ByVal FA_DESCRIPCION_ As String, ByVal FA_IDEMPRESA_ As Integer)
            _FA_CODIGO = FA_CODIGO_
            _FA_DESCRIPCION = FA_DESCRIPCION_
            _FA_IDEMPRESA = FA_IDEMPRESA_
        End Sub

        Public Property FA_CODIGO As String
            Get
                Return _FA_CODIGO
            End Get
            Set(ByVal value As String)
                _FA_CODIGO = value
            End Set
        End Property

        Public Property FA_DESCRIPCION As String
            Get
                Return _FA_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _FA_DESCRIPCION = value
            End Set
        End Property

        Public Property FA_IDEMPRESA As Integer
            Get
                Return _FA_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _FA_IDEMPRESA = value
            End Set
        End Property


    End Class

    Public Class SG_FA_TB_CATEGORIA_ARTI

        Private _CA_CODIGO As String
        Private _CA_DESCRIPCION As String
        Private _CA_IDFAMILIA As String
        Private _CA_IDEMPRESA As Integer

        Public Sub New(ByVal CA_CODIGO_ As String, ByVal CA_DESCRIPCION_ As String, ByVal CA_IDFAMILIA_ As String, ByVal CA_IDEMPRESA_ As Integer)
            _CA_CODIGO = CA_CODIGO_
            _CA_DESCRIPCION = CA_DESCRIPCION_
            _CA_IDFAMILIA = CA_IDFAMILIA_
            _CA_IDEMPRESA = CA_IDEMPRESA_
        End Sub

        Public Sub New()
            _CA_CODIGO = String.Empty
            _CA_DESCRIPCION = String.Empty
            _CA_IDFAMILIA = String.Empty
            _CA_IDEMPRESA = 0
        End Sub

        Public Property CA_CODIGO As String
            Get
                Return _CA_CODIGO
            End Get
            Set(ByVal value As String)
                _CA_CODIGO = value
            End Set
        End Property

        Public Property CA_DESCRIPCION As String
            Get
                Return _CA_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _CA_DESCRIPCION = value
            End Set
        End Property

        Public Property CA_IDFAMILIA As String
            Get
                Return _CA_IDFAMILIA
            End Get
            Set(ByVal value As String)
                _CA_IDFAMILIA = value
            End Set
        End Property

        Public Property CA_IDEMPRESA As Integer
            Get
                Return _CA_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _CA_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_ARTICULO
        Private _AR_CODIGO As String
        Private _AR_CODIGO_ALT As String
        Private _AR_DESCRIPCION As String
        Private _AR_PRECIO_VENTA As Double
        Private _AR_IDFAMILIA As String
        Private _AR_IDCATEGORIA As String
        Private _AR_NUM_CTA_CONTA As String
        Private _AR_ESTADO As Integer
        Private _AR_IDEMPRESA As Integer
        Private _AR_USUARIO As String
        Private _AR_TERMINAL As String
        Private _AR_FECREG As String
        Private _AR_TIPO_ARTI As String
        Private _AR_INCLUYE_IGV As Integer
        Private _AR_ING_RAP As Integer
        Private _AR_MON_VTA As String
        Private _AR_IDPROVEEDOR As Integer
        Private _AR_IDGRUPO As Integer
        Private _AR_IDUBICACION As Integer
        Private _AR_IDPAIS As Integer
        Private _AR_IDFABRICANTE As Integer
        Private _AR_MODELO As String
        Private _AR_MARCA As Integer
        Private _AR_UM_COMPRA As String
        Private _AR_UM_VENTA As String
        Private _AR_UM_DISTRI As String
        Private _AR_CANT_UMC As Double
        Private _AR_COLOR As String
        Private _AR_PESO As Double
        Private _AR_UM_PESO As String
        Private _AR_STOCK_MIN As Double
        Private _AR_CTRL_STOCK As Integer
        Private _AR_ORIGEN As String

        Public Sub New(ByVal AR_CODIGO_ As String, ByVal AR_CODIGO_ALT_ As String, ByVal AR_DESCRIPCION_ As String, ByVal AR_PRECIO_VENTA_ As Double, ByVal AR_IDFAMILIA_ As String, ByVal AR_IDCATEGORIA_ As String, ByVal AR_NUM_CTA_CONTA_ As String, ByVal AR_ESTADO_ As String, ByVal AR_IDEMPRESA_ As Integer, ByVal AR_USUARIO_ As String, ByVal AR_TERMINAL_ As String, ByVal AR_FECREG_ As String, ByVal AR_TIPO_ARTI_ As String, ByVal AR_INCLUYE_IGV_ As Integer, ByVal AR_ING_RAP_ As Integer, _
                       ByVal AR_MON_VTA_ As String, ByVal AR_IDPROVEEDOR_ As Integer, ByVal AR_IDGRUPO_ As Integer, ByVal AR_IDUBICACION_ As Integer, ByVal AR_IDPAIS_ As Integer, ByVal AR_IDFABRICANTE_ As Integer, ByVal AR_MODELO_ As String, ByVal AR_MARCA_ As Integer, ByVal AR_UM_COMPRA_ As String, ByVal AR_UM_VENTA_ As String, ByVal AR_UM_DISTRI_ As String, ByVal AR_CANT_UMC_ As Double, ByVal AR_COLOR_ As String, ByVal AR_PESO_ As Double, ByVal AR_UM_PESO_ As String, ByVal AR_STOCK_MIN_ As Double, ByVal AR_CTRL_STOCK_ As Integer, ByVal AR_ORIGEN_ As String)

            _AR_ORIGEN = AR_ORIGEN_
            _AR_MON_VTA = AR_MON_VTA_
            _AR_IDPROVEEDOR = AR_IDPROVEEDOR_
            _AR_IDGRUPO = AR_IDGRUPO_
            _AR_IDUBICACION = AR_IDUBICACION_
            _AR_IDPAIS = AR_IDPAIS_
            _AR_IDFABRICANTE = AR_IDFABRICANTE_
            _AR_MODELO = AR_MODELO_
            _AR_MARCA = AR_MARCA_
            _AR_UM_COMPRA = AR_UM_COMPRA_
            _AR_UM_VENTA = AR_UM_VENTA_
            _AR_UM_DISTRI = AR_UM_DISTRI_
            _AR_CANT_UMC = AR_CANT_UMC_
            _AR_COLOR = AR_COLOR_
            _AR_PESO = AR_PESO_
            _AR_UM_PESO = AR_UM_PESO_
            _AR_STOCK_MIN = AR_STOCK_MIN_
            _AR_CTRL_STOCK = AR_CTRL_STOCK_
            _AR_ING_RAP = AR_ING_RAP_
            _AR_INCLUYE_IGV = AR_INCLUYE_IGV_
            _AR_TIPO_ARTI = AR_TIPO_ARTI_
            _AR_CODIGO = AR_CODIGO_
            _AR_CODIGO_ALT = AR_CODIGO_ALT_
            _AR_DESCRIPCION = AR_DESCRIPCION_
            _AR_PRECIO_VENTA = AR_PRECIO_VENTA_
            _AR_IDFAMILIA = AR_IDFAMILIA_
            _AR_IDCATEGORIA = AR_IDCATEGORIA_
            _AR_NUM_CTA_CONTA = AR_NUM_CTA_CONTA_
            _AR_ESTADO = AR_ESTADO_
            _AR_IDEMPRESA = AR_IDEMPRESA_
            _AR_USUARIO = AR_USUARIO_
            _AR_TERMINAL = AR_TERMINAL_
            _AR_FECREG = AR_FECREG_
        End Sub

        Public Sub New()
            _AR_ORIGEN = String.Empty
            _AR_MON_VTA = String.Empty
            _AR_IDPROVEEDOR = 0
            _AR_IDGRUPO = 0
            _AR_IDUBICACION = 0
            _AR_IDPAIS = 0
            _AR_IDFABRICANTE = 0
            _AR_MODELO = 0
            _AR_MARCA = 0
            _AR_UM_COMPRA = String.Empty
            _AR_UM_VENTA = String.Empty
            _AR_UM_DISTRI = String.Empty
            _AR_CANT_UMC = 0.0R
            _AR_COLOR = String.Empty
            _AR_PESO = 0.0R
            _AR_UM_PESO = String.Empty
            _AR_STOCK_MIN = 0.0R
            _AR_CTRL_STOCK = 0
            _AR_ING_RAP = 0
            _AR_INCLUYE_IGV = 0
            _AR_TIPO_ARTI = String.Empty
            _AR_CODIGO = String.Empty
            _AR_CODIGO_ALT = String.Empty
            _AR_DESCRIPCION = String.Empty
            _AR_PRECIO_VENTA = 0.0R
            _AR_IDFAMILIA = String.Empty
            _AR_IDCATEGORIA = String.Empty
            _AR_NUM_CTA_CONTA = String.Empty
            _AR_ESTADO = 0
            _AR_IDEMPRESA = 0
            _AR_USUARIO = String.Empty
            _AR_TERMINAL = String.Empty
            _AR_FECREG = String.Empty
        End Sub

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Public Property AR_ORIGEN As String
            Get
                Return _AR_ORIGEN
            End Get
            Set(ByVal value As String)
                _AR_ORIGEN = value
            End Set
        End Property

        Public Property AR_MON_VTA As String
            Get
                Return _AR_MON_VTA
            End Get
            Set(ByVal value As String)
                _AR_MON_VTA = value
            End Set
        End Property

        Public Property AR_IDPROVEEDOR As Integer
            Get
                Return _AR_IDPROVEEDOR
            End Get
            Set(ByVal value As Integer)
                _AR_IDPROVEEDOR = value
            End Set
        End Property

        Public Property AR_IDGRUPO As Integer
            Get
                Return _AR_IDGRUPO
            End Get
            Set(ByVal value As Integer)
                _AR_IDGRUPO = value
            End Set
        End Property

        Public Property AR_IDUBICACION As Integer
            Get
                Return _AR_IDUBICACION
            End Get
            Set(ByVal value As Integer)
                _AR_IDUBICACION = value
            End Set
        End Property

        Public Property AR_IDPAIS As Integer
            Get
                Return _AR_IDPAIS
            End Get
            Set(ByVal value As Integer)
                _AR_IDPAIS = value
            End Set
        End Property

        Public Property AR_IDFABRICANTE As Integer
            Get
                Return _AR_IDFABRICANTE
            End Get
            Set(ByVal value As Integer)
                _AR_IDFABRICANTE = value
            End Set
        End Property

        Public Property AR_MODELO As String
            Get
                Return _AR_MODELO
            End Get
            Set(ByVal value As String)
                _AR_MODELO = value
            End Set
        End Property

        Public Property AR_MARCA As Integer
            Get
                Return _AR_MARCA
            End Get
            Set(ByVal value As Integer)
                _AR_MARCA = value
            End Set
        End Property

        Public Property AR_UM_COMPRA As String
            Get
                Return _AR_UM_COMPRA
            End Get
            Set(ByVal value As String)
                _AR_UM_COMPRA = value
            End Set
        End Property

        Public Property AR_UM_VENTA As String
            Get
                Return _AR_UM_VENTA
            End Get
            Set(ByVal value As String)
                _AR_UM_VENTA = value
            End Set
        End Property

        Public Property AR_UM_DISTRI As String
            Get
                Return _AR_UM_DISTRI
            End Get
            Set(ByVal value As String)
                _AR_UM_DISTRI = value
            End Set
        End Property

        Public Property AR_CANT_UMC As Double
            Get
                Return _AR_CANT_UMC
            End Get
            Set(ByVal value As Double)
                _AR_CANT_UMC = value
            End Set
        End Property

        Public Property AR_COLOR As String
            Get
                Return _AR_COLOR
            End Get
            Set(ByVal value As String)
                _AR_COLOR = value
            End Set
        End Property

        Public Property AR_PESO As Double
            Get
                Return _AR_PESO
            End Get
            Set(ByVal value As Double)
                _AR_PESO = value
            End Set
        End Property

        Public Property AR_UM_PESO As String
            Get
                Return _AR_UM_PESO
            End Get
            Set(ByVal value As String)
                _AR_UM_PESO = value
            End Set
        End Property

        Public Property AR_STOCK_MIN As Double
            Get
                Return _AR_STOCK_MIN
            End Get
            Set(ByVal value As Double)
                _AR_STOCK_MIN = value
            End Set
        End Property

        Public Property AR_CTRL_STOCK As Integer
            Get
                Return _AR_CTRL_STOCK
            End Get
            Set(ByVal value As Integer)
                _AR_CTRL_STOCK = value
            End Set
        End Property

        Public Property AR_ING_RAP As Integer
            Get
                Return _AR_ING_RAP
            End Get
            Set(ByVal value As Integer)
                _AR_ING_RAP = value
            End Set
        End Property

        Public Property AR_INCLUYE_IGV As Integer
            Get
                Return _AR_INCLUYE_IGV
            End Get
            Set(ByVal value As Integer)
                _AR_INCLUYE_IGV = value
            End Set
        End Property

        Public Property AR_TIPO_ARTI As String
            Get
                Return _AR_TIPO_ARTI
            End Get
            Set(ByVal value As String)
                _AR_TIPO_ARTI = value
            End Set
        End Property

        Public Property AR_CODIGO As String
            Get
                Return _AR_CODIGO
            End Get
            Set(ByVal value As String)
                _AR_CODIGO = value
            End Set
        End Property

        Public Property AR_CODIGO_ALT As String
            Get
                Return _AR_CODIGO_ALT
            End Get
            Set(ByVal value As String)
                _AR_CODIGO_ALT = value
            End Set
        End Property

        Public Property AR_DESCRIPCION As String
            Get
                Return _AR_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _AR_DESCRIPCION = value
            End Set
        End Property

        Public Property AR_PRECIO_VENTA As Double
            Get
                Return _AR_PRECIO_VENTA
            End Get
            Set(ByVal value As Double)
                _AR_PRECIO_VENTA = value
            End Set
        End Property

        Public Property AR_IDFAMILIA As String
            Get
                Return _AR_IDFAMILIA
            End Get
            Set(ByVal value As String)
                _AR_IDFAMILIA = value
            End Set
        End Property

        Public Property AR_IDCATEGORIA As String
            Get
                Return _AR_IDCATEGORIA
            End Get
            Set(ByVal value As String)
                _AR_IDCATEGORIA = value
            End Set
        End Property

        Public Property AR_NUM_CTA_CONTA As String
            Get
                Return _AR_NUM_CTA_CONTA
            End Get
            Set(ByVal value As String)
                _AR_NUM_CTA_CONTA = value
            End Set
        End Property

        Public Property AR_ESTADO As Integer
            Get
                Return _AR_ESTADO
            End Get
            Set(ByVal value As Integer)
                _AR_ESTADO = value
            End Set
        End Property

        Public Property AR_IDEMPRESA As Integer
            Get
                Return _AR_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _AR_IDEMPRESA = value
            End Set
        End Property

        Public Property AR_USUARIO As String
            Get
                Return _AR_USUARIO
            End Get
            Set(ByVal value As String)
                _AR_USUARIO = value
            End Set
        End Property

        Public Property AR_TERMINAL As String
            Get
                Return _AR_TERMINAL
            End Get
            Set(ByVal value As String)
                _AR_TERMINAL = value
            End Set
        End Property

        Public Property AR_FECREG As String
            Get
                Return _AR_FECREG
            End Get
            Set(ByVal value As String)
                _AR_FECREG = value
            End Set
        End Property

        Private _AR_ID As System.Int32

        Public Property AR_ID As System.Int32
            Get
                Return (_AR_ID)
            End Get
            Set(ByVal value As System.Int32)
                _AR_ID = value
            End Set
        End Property

        Private _CA_Consulta As System.Int32

        Public Property CA_Consulta As System.Int32
            Get
                Return (_CA_Consulta)
            End Get
            Set(ByVal value As System.Int32)
                _CA_Consulta = value
            End Set
        End Property

        Private _CA_SINPAGO As System.Int32

        Public Property CA_SINPAGO As System.Int32
            Get
                Return (_CA_SINPAGO)
            End Get
            Set(ByVal value As System.Int32)
                _CA_SINPAGO = value
            End Set
        End Property

        Private _UM_Des As System.String

        Public Property UM_Des As System.String
            Get
                Return (_UM_Des)
            End Get
            Set(ByVal value As System.String)
                _UM_Des = value
            End Set
        End Property

        Private _UM_DesV As System.String

        Public Property UM_DesV As System.String
            Get
                Return (_UM_DesV)
            End Get
            Set(ByVal value As System.String)
                _UM_DesV = value
            End Set
        End Property

        Private _AR_UNIDAD As System.Decimal

        Public Property AR_UNIDAD As System.Decimal
            Get
                Return (_AR_UNIDAD)
            End Get
            Set(ByVal value As System.Decimal)
                _AR_UNIDAD = value
            End Set
        End Property

        Private _AR_FACTOR As System.Int32

        Public Property AR_FACTOR As System.Int32
            Get
                Return (_AR_FACTOR)
            End Get
            Set(ByVal value As System.Int32)
                _AR_FACTOR = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_CLIENTE
        Private _CL_ID As Integer
        Private _CL_NOMBRE As String
        Private _CL_TDOC As BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD
        Private _CL_NDOC As String
        Private _CL_DIRECCION As String
        Private _CL_ES_RELACIONADO As Integer
        Private _CL_USUARIO As String
        Private _CL_TERMINAL As String
        Private _CL_FECREG As String
        Private _CL_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _CL_ESTADO As Integer
        Private _CL_FICHA_TEC As String
        Private _CL_UBIGEO As String
        Private _HasRow As Boolean
        Private _CL_IDANEX_CONTA As Integer

        Public Sub New(ByVal CL_ID_ As Integer, ByVal CL_NOMBRE_ As String, ByVal CL_TDOC_ As BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD, ByVal CL_NDOC_ As String, ByVal CL_DIRECCION_ As String, ByVal CL_ES_RELACIONADO_ As Integer, ByVal CL_USUARIO_ As String, ByVal CL_TERMINAL_ As String, ByVal CL_FECREG_ As String, ByVal CL_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal CL_ESTADO_ As Integer, ByVal CL_FICHA_TEC_ As String, ByVal CL_UBIGEO_ As String, ByVal CL_IDANEX_CONTA_ As Integer)
            _CL_IDANEX_CONTA = CL_IDANEX_CONTA_
            _CL_UBIGEO = CL_UBIGEO_
            _CL_FICHA_TEC = CL_FICHA_TEC_
            _CL_ESTADO = CL_ESTADO_
            _CL_ID = CL_ID_
            _CL_NOMBRE = CL_NOMBRE_
            _CL_TDOC = CL_TDOC_
            _CL_NDOC = CL_NDOC_
            _CL_DIRECCION = CL_DIRECCION_
            _CL_ES_RELACIONADO = CL_ES_RELACIONADO_
            _CL_USUARIO = CL_USUARIO_
            _CL_TERMINAL = CL_TERMINAL_
            _CL_FECREG = CL_FECREG_
            _CL_IDEMPRESA = CL_IDEMPRESA_
        End Sub

        Public Sub New()
            _CL_IDANEX_CONTA = 0
            _CL_UBIGEO = String.Empty
            _CL_FICHA_TEC = String.Empty
            _CL_ESTADO = 1
            _CL_ID = 0
            _CL_NOMBRE = String.Empty
            _CL_TDOC = Nothing
            _CL_NDOC = String.Empty
            _CL_DIRECCION = String.Empty
            _CL_ES_RELACIONADO = 0
            _CL_USUARIO = String.Empty
            _CL_TERMINAL = String.Empty
            _CL_FECREG = String.Empty
            _CL_IDEMPRESA = Nothing
            _HasRow = False
        End Sub

        Public Property CL_IDANEX_CONTA As Integer
            Get
                Return _CL_IDANEX_CONTA
            End Get
            Set(ByVal value As Integer)
                _CL_IDANEX_CONTA = value
            End Set
        End Property

        Public Property CL_UBIGEO As String
            Get
                Return _CL_UBIGEO
            End Get
            Set(ByVal value As String)
                _CL_UBIGEO = value
            End Set
        End Property

        Public Property CL_FICHA_TEC As String
            Get
                Return _CL_FICHA_TEC
            End Get
            Set(ByVal value As String)
                _CL_FICHA_TEC = value
            End Set
        End Property

        Public Property CL_ESTADO As Integer
            Get
                Return _CL_ESTADO
            End Get
            Set(ByVal value As Integer)
                _CL_ESTADO = value
            End Set
        End Property

        Public Property HasRow As Boolean
            Get
                Return _HasRow
            End Get
            Set(ByVal value As Boolean)
                _HasRow = value
            End Set
        End Property

        Public Property CL_ID As Integer
            Get
                Return _CL_ID
            End Get
            Set(ByVal value As Integer)
                _CL_ID = value
            End Set
        End Property

        Public Property CL_NOMBRE As String
            Get
                Return _CL_NOMBRE
            End Get
            Set(ByVal value As String)
                _CL_NOMBRE = value
            End Set
        End Property

        Public Property CL_TDOC As BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD
            Get
                Return _CL_TDOC
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_TIPO_DOC_IDENTIDAD)
                _CL_TDOC = value
            End Set
        End Property

        Public Property CL_NDOC As String
            Get
                Return _CL_NDOC
            End Get
            Set(ByVal value As String)
                _CL_NDOC = value
            End Set
        End Property

        Public Property CL_DIRECCION As String
            Get
                Return _CL_DIRECCION
            End Get
            Set(ByVal value As String)
                _CL_DIRECCION = value
            End Set
        End Property

        Public Property CL_ES_RELACIONADO As Integer
            Get
                Return _CL_ES_RELACIONADO
            End Get
            Set(ByVal value As Integer)
                _CL_ES_RELACIONADO = value
            End Set
        End Property

        Public Property CL_USUARIO As String
            Get
                Return _CL_USUARIO
            End Get
            Set(ByVal value As String)
                _CL_USUARIO = value
            End Set
        End Property

        Public Property CL_TERMINAL As String
            Get
                Return _CL_TERMINAL
            End Get
            Set(ByVal value As String)
                _CL_TERMINAL = value
            End Set
        End Property

        Public Property CL_FECREG As String
            Get
                Return _CL_FECREG
            End Get
            Set(ByVal value As String)
                _CL_FECREG = value
            End Set
        End Property

        Public Property CL_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _CL_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _CL_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_FA_TB_COMPROBANTE_D
        Private _CD_IDCAB As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
        Private _CD_ITEM As Integer
        Private _CD_IDARTICULO As BE.FacturacionBE.SG_FA_TB_ARTICULO
        Private _CD_CANT As Double
        Private _CD_PRECIO As Double
        Private _CD_DSCTO As Double
        Private _CD_SUBTOTAL As Double
        Private _CD_INAFECTO As Integer
        Private _CD_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _CD_IGV As Double
        Private _CD_TOTAL As Double
        Private _CD_INC_IGV As Integer
        Private _CD_IDCOMPRO_ADELA As Integer


        Public Sub New(ByVal CD_IDCAB_ As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C, ByVal CD_ITEM_ As Integer, ByVal CD_IDARTICULO_ As BE.FacturacionBE.SG_FA_TB_ARTICULO, ByVal CD_CANT_ As Double, ByVal CD_PRECIO_ As Double, ByVal CD_DSCTO_ As Double, ByVal CD_SUBTOTAL_ As Double, ByVal CD_INAFECTO_ As Integer, ByVal CD_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal CD_IGV_ As Double, ByVal CD_TOTAL_ As Double, ByVal CD_INC_IGV_ As Integer, CD_IDCOMPRO_ADELA_ As Integer)
            _CD_IDCOMPRO_ADELA = CD_IDCOMPRO_ADELA_
            _CD_INC_IGV = CD_INC_IGV_
            _CD_TOTAL = CD_TOTAL_
            _CD_IGV = CD_IGV_
            _CD_IDCAB = CD_IDCAB_
            _CD_ITEM = CD_ITEM_
            _CD_IDARTICULO = CD_IDARTICULO_
            _CD_CANT = CD_CANT_
            _CD_PRECIO = CD_PRECIO_
            _CD_DSCTO = CD_DSCTO_
            _CD_SUBTOTAL = CD_SUBTOTAL_
            _CD_INAFECTO = CD_INAFECTO_
            _CD_IDEMPRESA = CD_IDEMPRESA_
        End Sub

        Public Sub New()
            _CD_INC_IGV = 0
            _CD_TOTAL = 0
            _CD_IGV = 0
            _CD_IDCAB = Nothing
            _CD_ITEM = 0
            _CD_IDARTICULO = Nothing
            _CD_CANT = 0.0R
            _CD_PRECIO = 0.0R
            _CD_DSCTO = 0.0R
            _CD_SUBTOTAL = 0.0R
            _CD_INAFECTO = 0
            _CD_IDEMPRESA = Nothing
            _CD_IDCOMPRO_ADELA = 0
        End Sub

        Public Property CD_IDCOMPRO_ADELA As Integer
            Get
                Return _CD_IDCOMPRO_ADELA
            End Get
            Set(value As Integer)
                _CD_IDCOMPRO_ADELA = value
            End Set
        End Property

        Private _CD_DSCTO_OTRO As System.Double

        Public Property CD_DSCTO_OTRO As System.Double
            Get
                Return (_CD_DSCTO_OTRO)
            End Get
            Set(ByVal value As System.Double)
                _CD_DSCTO_OTRO = value
            End Set
        End Property

        Private _CD_IDCUENTA As System.Int32

        Public Property CD_IDCUENTA As System.Int32
            Get
                Return (_CD_IDCUENTA)
            End Get
            Set(ByVal value As System.Int32)
                _CD_IDCUENTA = value
            End Set
        End Property

        Private _CD_CUENTA_ITEM As System.Int32

        Public Property CD_CUENTA_ITEM As System.Int32
            Get
                Return (_CD_CUENTA_ITEM)
            End Get
            Set(ByVal value As System.Int32)
                _CD_CUENTA_ITEM = value
            End Set
        End Property

        Public Property CD_INC_IGV As Integer
            Get
                Return _CD_INC_IGV
            End Get
            Set(ByVal value As Integer)
                _CD_INC_IGV = value
            End Set
        End Property

        Public Property CD_TOTAL As Double
            Get
                Return _CD_TOTAL
            End Get
            Set(ByVal value As Double)
                _CD_TOTAL = value
            End Set
        End Property

        Public Property CD_IGV As Double
            Get
                Return _CD_IGV
            End Get
            Set(ByVal value As Double)
                _CD_IGV = value
            End Set
        End Property

        Public Property CD_IDCAB As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C
            Get
                Return _CD_IDCAB
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_COMPROBANTE_C)
                _CD_IDCAB = value
            End Set
        End Property

        Public Property CD_ITEM As Integer
            Get
                Return _CD_ITEM
            End Get
            Set(ByVal value As Integer)
                _CD_ITEM = value
            End Set
        End Property

        Public Property CD_IDARTICULO As BE.FacturacionBE.SG_FA_TB_ARTICULO
            Get
                Return _CD_IDARTICULO
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_ARTICULO)
                _CD_IDARTICULO = value
            End Set
        End Property

        Public Property CD_CANT As Double
            Get
                Return _CD_CANT
            End Get
            Set(ByVal value As Double)
                _CD_CANT = value
            End Set
        End Property

        Public Property CD_PRECIO As Double
            Get
                Return _CD_PRECIO
            End Get
            Set(ByVal value As Double)
                _CD_PRECIO = value
            End Set
        End Property

        Public Property CD_DSCTO As Double
            Get
                Return _CD_DSCTO
            End Get
            Set(ByVal value As Double)
                _CD_DSCTO = value
            End Set
        End Property

        Public Property CD_SUBTOTAL As Double
            Get
                Return _CD_SUBTOTAL
            End Get
            Set(ByVal value As Double)
                _CD_SUBTOTAL = value
            End Set
        End Property

        Public Property CD_INAFECTO As Integer
            Get
                Return _CD_INAFECTO
            End Get
            Set(ByVal value As Integer)
                _CD_INAFECTO = value
            End Set
        End Property

        Public Property CD_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _CD_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _CD_IDEMPRESA = value
            End Set
        End Property

        Private _CD_LOTE As String
        Public Property CD_LOTE As String
            Get
                Return _CD_LOTE
            End Get
            Set(ByVal value As String)
                _CD_LOTE = value
            End Set
        End Property
    End Class

    Public Class SG_FA_TB_COMPROBANTE_C
        Private _CO_ID As Integer
        Private _CO_TDOC As BE.FacturacionBE.SG_FA_TB_DOCUMENTO
        Private _CO_SDOC As String
        Private _CO_NDOC As String
        Private _CO_FEC_EMI As String
        Private _CO_FEC_VEN As String
        Private _CO_SUBTOTAL As Double
        Private _CO_SUBTOTAL_NA As Double
        Private _CO_IGV As Double
        Private _CO_TOTAL As Double
        Private _CO_IDMONEDA As BE.FacturacionBE.SG_FA_TB_MONEDA
        Private _CO_TCAM As Double
        Private _CO_TDOC_REF As BE.FacturacionBE.SG_FA_TB_DOCUMENTO
        Private _CO_SDOC_REF As String
        Private _CO_NDOC_REF As String
        Private _CO_FEC_EMI_REF As String
        Private _CO_FEC_VEN_REF As String
        Private _CO_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
        Private _CO_USUARIO As String
        Private _CO_TERMINAL As String
        Private _CO_FECREG As String
        Private _Detalles As New List(Of BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D)
        Private _CO_IDCLIENTE As New BE.FacturacionBE.SG_FA_TB_CLIENTE
        Private _CO_NOTAS As String
        Private _CO_ESTADO As Integer
        Private _CO_IDPTOVTA As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA
        Private _CO_IDFORMA_PAGO As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO
        Private _CO_ES_CONTA_PROVI As Integer
        Private _CO_ES_CONTA_CANCE As Integer
        Private _CO_TASA_IGV As Double
        Private _CO_IDVOUCHER As Integer
        Private _CO_NUMVOUCHER As String
        Private _CO_IDUSUARIO As BE.ContabilidadBE.SG_CO_TB_USUARIO
        Private _CO_IDDOCU_PAGO As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO
        Private _CO_REF_PAGO As String
        Private _CO_ES_REEMPLA As Integer
        Private _CO_DNI As String

        Public Sub New(ByVal CO_ID_ As Integer, ByVal CO_TDOC_ As BE.FacturacionBE.SG_FA_TB_DOCUMENTO, ByVal CO_SDOC_ As String, ByVal CO_NDOC_ As String, ByVal CO_FEC_EMI_ As String, ByVal CO_FEC_VEN_ As String, ByVal CO_SUBTOTAL_ As Double, ByVal CO_SUBTOTAL_NA_ As Double, ByVal CO_IGV_ As Double, ByVal CO_TOTAL_ As Double, ByVal CO_IDMONEDA_ As BE.FacturacionBE.SG_FA_TB_MONEDA, ByVal CO_TCAM_ As Double, ByVal CO_TDOC_REF_ As BE.FacturacionBE.SG_FA_TB_DOCUMENTO, ByVal CO_SDOC_REF_ As String, ByVal CO_NDOC_REF_ As String, ByVal CO_FEC_EMI_REF_ As String, ByVal CO_FEC_VEN_REF_ As String, ByVal CO_IDEMPRESA_ As BE.ContabilidadBE.SG_CO_TB_EMPRESA, ByVal CO_USUARIO_ As String, ByVal CO_TERMINAL_ As String, ByVal CO_FECREG_ As String, ByVal CO_IDCLIENTE_ As BE.FacturacionBE.SG_FA_TB_CLIENTE, ByVal CO_NOTAS_ As String, ByVal CO_ESTADO_ As Integer, ByVal CO_IDPTOVTA_ As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA, ByVal CO_IDFORMA_PAGO_ As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO, ByVal CO_ES_CONTA_PROVI_ As Integer, ByVal CO_ES_CONTA_CANCE_ As Integer, ByVal CO_TASA_IGV_ As Double, ByVal CO_IDVOUCHER_ As Integer, ByVal CO_NUMVOUCHER_ As String, ByVal CO_IDUSUARIO_ As BE.ContabilidadBE.SG_CO_TB_USUARIO, ByVal CO_IDDOCU_PAGO_ As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO, ByVal CO_REF_PAGO_ As String, ByVal CO_ES_REEMPLA_ As Integer, ByVal CO_DNI_ As String)
            _CO_DNI = CO_DNI_
            _CO_ES_REEMPLA = CO_ES_REEMPLA_
            _CO_IDDOCU_PAGO = CO_IDDOCU_PAGO_
            _CO_REF_PAGO = CO_REF_PAGO_
            _CO_IDUSUARIO = CO_IDUSUARIO_
            _CO_IDVOUCHER = CO_IDVOUCHER_
            _CO_NUMVOUCHER = CO_NUMVOUCHER_
            _CO_TASA_IGV = CO_TASA_IGV_
            _CO_ES_CONTA_PROVI = CO_ES_CONTA_PROVI_
            _CO_ES_CONTA_CANCE = CO_ES_CONTA_CANCE_
            _CO_IDPTOVTA = CO_IDPTOVTA_
            _CO_IDFORMA_PAGO = CO_IDFORMA_PAGO_
            _CO_ESTADO = CO_ESTADO_
            _CO_NOTAS = CO_NOTAS_
            _CO_IDCLIENTE = CO_IDCLIENTE_
            _CO_ID = CO_ID_
            _CO_TDOC = CO_TDOC_
            _CO_SDOC = CO_SDOC_
            _CO_NDOC = CO_NDOC_
            _CO_FEC_EMI = CO_FEC_EMI_
            _CO_FEC_VEN = CO_FEC_VEN_
            _CO_SUBTOTAL = CO_SUBTOTAL_
            _CO_SUBTOTAL_NA = CO_SUBTOTAL_NA_
            _CO_IGV = CO_IGV_
            _CO_TOTAL = CO_TOTAL_
            _CO_IDMONEDA = CO_IDMONEDA_
            _CO_TCAM = CO_TCAM_
            _CO_TDOC_REF = CO_TDOC_REF_
            _CO_SDOC_REF = CO_SDOC_REF_
            _CO_NDOC_REF = CO_NDOC_REF_
            _CO_FEC_EMI_REF = CO_FEC_EMI_REF_
            _CO_FEC_VEN_REF = CO_FEC_VEN_REF_
            _CO_IDEMPRESA = CO_IDEMPRESA_
            _CO_USUARIO = CO_USUARIO_
            _CO_TERMINAL = CO_TERMINAL_
            _CO_FECREG = CO_FECREG_
        End Sub

        Public Sub New()
            _CO_DNI = String.Empty
            _CO_ES_REEMPLA = 0
            _CO_IDDOCU_PAGO = Nothing
            _CO_REF_PAGO = String.Empty
            _CO_IDUSUARIO = Nothing
            _CO_IDVOUCHER = 0
            _CO_NUMVOUCHER = String.Empty
            _CO_TASA_IGV = 0
            _CO_ES_CONTA_PROVI = 0
            _CO_ES_CONTA_CANCE = 0
            _CO_IDPTOVTA = Nothing
            _CO_IDFORMA_PAGO = Nothing
            _CO_ESTADO = 0
            _CO_NOTAS = String.Empty
            _CO_IDCLIENTE = Nothing
            _CO_ID = 0
            _CO_TDOC = Nothing
            _CO_SDOC = String.Empty
            _CO_NDOC = String.Empty
            _CO_FEC_EMI = String.Empty
            _CO_FEC_VEN = String.Empty
            _CO_SUBTOTAL = 0.0R
            _CO_SUBTOTAL_NA = 0.0R
            _CO_IGV = 0.0R
            _CO_TOTAL = 0.0R
            _CO_IDMONEDA = Nothing
            _CO_TCAM = 0.0R
            _CO_TDOC_REF = Nothing
            _CO_SDOC_REF = String.Empty
            _CO_NDOC_REF = String.Empty
            _CO_FEC_EMI_REF = String.Empty
            _CO_FEC_VEN_REF = String.Empty
            _CO_IDEMPRESA = Nothing
            _CO_USUARIO = String.Empty
            _CO_TERMINAL = String.Empty
            _CO_FECREG = String.Empty
        End Sub

        Private _CO_SERIET As System.Int32

        Public Property CO_SERIET As System.Int32
            Get
                Return (_CO_SERIET)
            End Get
            Set(ByVal value As System.Int32)
                _CO_SERIET = value
            End Set
        End Property

        Private _CO_NUMEROT As System.Int32

        Public Property CO_NUMEROT As System.Int32
            Get
                Return (_CO_NUMEROT)
            End Get
            Set(ByVal value As System.Int32)
                _CO_NUMEROT = value
            End Set
        End Property

        Private _CO_IDTIPO_ORI As System.Int32

        Public Property CO_IDTIPO_ORI As System.Int32
            Get
                Return (_CO_IDTIPO_ORI)
            End Get
            Set(ByVal value As System.Int32)
                _CO_IDTIPO_ORI = value
            End Set
        End Property

        Private _CO_ESTADO_PAGO As System.Int32

        Public Property CO_ESTADO_PAGO As System.Int32
            Get
                Return (_CO_ESTADO_PAGO)
            End Get
            Set(ByVal value As System.Int32)
                _CO_ESTADO_PAGO = value
            End Set
        End Property

        Private _CO_FECHA_CANCELACION As System.DateTime

        Public Property CO_FECHA_CANCELACION As System.DateTime
            Get
                Return (_CO_FECHA_CANCELACION)
            End Get
            Set(ByVal value As System.DateTime)
                _CO_FECHA_CANCELACION = value
            End Set
        End Property

        Private _CO_DEDUCIBLE As System.Double

        Public Property CO_DEDUCIBLE As System.Double
            Get
                Return (_CO_DEDUCIBLE)
            End Get
            Set(ByVal value As System.Double)
                _CO_DEDUCIBLE = value
            End Set
        End Property

        Private _CO_SEGURO As System.Double

        Public Property CO_SEGURO As System.Double
            Get
                Return (_CO_SEGURO)
            End Get
            Set(ByVal value As System.Double)
                _CO_SEGURO = value
            End Set
        End Property

        Private _CO_SEGURO_PORC As System.Int32

        Public Property CO_SEGURO_PORC As System.Int32
            Get
                Return (_CO_SEGURO_PORC)
            End Get
            Set(ByVal value As System.Int32)
                _CO_SEGURO_PORC = value
            End Set
        End Property

        Private _CO_MEDICO As System.String

        Public Property CO_MEDICO As System.String
            Get
                Return (_CO_MEDICO)
            End Get
            Set(ByVal value As System.String)
                _CO_MEDICO = value
            End Set
        End Property

        Private _CO_DESTINO As System.Int32

        Public Property CO_DESTINO As System.Int32
            Get
                Return (_CO_DESTINO)
            End Get
            Set(ByVal value As System.Int32)
                _CO_DESTINO = value
            End Set
        End Property

        Private _CO_NUM_HIST As System.Int32

        Public Property CO_NUM_HIST As System.Int32
            Get
                Return (_CO_NUM_HIST)
            End Get
            Set(ByVal value As System.Int32)
                _CO_NUM_HIST = value
            End Set
        End Property

        Public Property CO_DNI As String
            Get
                Return _CO_DNI
            End Get
            Set(ByVal value As String)
                _CO_DNI = value
            End Set
        End Property

        Public Property CO_ES_REEMPLA As Integer
            Get
                Return _CO_ES_REEMPLA
            End Get
            Set(ByVal value As Integer)
                _CO_ES_REEMPLA = value
            End Set
        End Property

        Public Property CO_IDDOCU_PAGO As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO
            Get
                Return _CO_IDDOCU_PAGO
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_DOCU_PAGO)
                _CO_IDDOCU_PAGO = value
            End Set
        End Property

        Public Property CO_REF_PAGO As String
            Get
                Return _CO_REF_PAGO
            End Get
            Set(ByVal value As String)
                _CO_REF_PAGO = value
            End Set
        End Property

        Public Property CO_IDUSUARIO As BE.ContabilidadBE.SG_CO_TB_USUARIO
            Get
                Return _CO_IDUSUARIO
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_USUARIO)
                _CO_IDUSUARIO = value
            End Set
        End Property

        Public Property CO_IDVOUCHER As Integer
            Get
                Return _CO_IDVOUCHER
            End Get
            Set(ByVal value As Integer)
                _CO_IDVOUCHER = value
            End Set
        End Property

        Public Property CO_NUMVOUCHER As String
            Get
                Return _CO_NUMVOUCHER
            End Get
            Set(ByVal value As String)
                _CO_NUMVOUCHER = value
            End Set
        End Property

        Public Property CO_TASA_IGV As Double
            Get
                Return _CO_TASA_IGV
            End Get
            Set(ByVal value As Double)
                _CO_TASA_IGV = value
            End Set
        End Property

        Public Property CO_ES_CONTA_PROVI As Integer
            Get
                Return _CO_ES_CONTA_PROVI
            End Get
            Set(ByVal value As Integer)
                _CO_ES_CONTA_PROVI = value
            End Set
        End Property

        Public Property CO_ES_CONTA_CANCE As Integer
            Get
                Return _CO_ES_CONTA_CANCE
            End Get
            Set(ByVal value As Integer)
                _CO_ES_CONTA_CANCE = value
            End Set
        End Property

        Public Property CO_IDPTOVTA As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA
            Get
                Return _CO_IDPTOVTA
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_PUNTO_VENTA)
                _CO_IDPTOVTA = value
            End Set
        End Property

        Public Property CO_IDFORMA_PAGO As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO
            Get
                Return _CO_IDFORMA_PAGO
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_FORMA_PAGO)
                _CO_IDFORMA_PAGO = value
            End Set
        End Property

        Public Property CO_ESTADO As Integer
            Get
                Return _CO_ESTADO
            End Get
            Set(ByVal value As Integer)
                _CO_ESTADO = value
            End Set
        End Property

        Public Property CO_NOTAS As String
            Get
                Return _CO_NOTAS
            End Get
            Set(ByVal value As String)
                _CO_NOTAS = value
            End Set
        End Property

        Public Property Detalles As List(Of BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D)
            Get
                Return _Detalles
            End Get
            Set(ByVal value As List(Of BE.FacturacionBE.SG_FA_TB_COMPROBANTE_D))
                _Detalles = value
            End Set
        End Property

        Public Property CO_IDCLIENTE As BE.FacturacionBE.SG_FA_TB_CLIENTE
            Get
                Return _CO_IDCLIENTE
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_CLIENTE)
                _CO_IDCLIENTE = value
            End Set
        End Property

        Public Property CO_ID As Integer
            Get
                Return _CO_ID
            End Get
            Set(ByVal value As Integer)
                _CO_ID = value
            End Set
        End Property

        Public Property CO_TDOC As BE.FacturacionBE.SG_FA_TB_DOCUMENTO
            Get
                Return _CO_TDOC
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
                _CO_TDOC = value
            End Set
        End Property

        Public Property CO_SDOC As String
            Get
                Return _CO_SDOC
            End Get
            Set(ByVal value As String)
                _CO_SDOC = value
            End Set
        End Property

        Public Property CO_NDOC As String
            Get
                Return _CO_NDOC
            End Get
            Set(ByVal value As String)
                _CO_NDOC = value
            End Set
        End Property

        Public Property CO_FEC_EMI As String
            Get
                Return _CO_FEC_EMI
            End Get
            Set(ByVal value As String)
                _CO_FEC_EMI = value
            End Set
        End Property

        Public Property CO_FEC_VEN As String
            Get
                Return _CO_FEC_VEN
            End Get
            Set(ByVal value As String)
                _CO_FEC_VEN = value
            End Set
        End Property

        Public Property CO_SUBTOTAL As Double
            Get
                Return _CO_SUBTOTAL
            End Get
            Set(ByVal value As Double)
                _CO_SUBTOTAL = value
            End Set
        End Property

        Public Property CO_SUBTOTAL_NA As Double
            Get
                Return _CO_SUBTOTAL_NA
            End Get
            Set(ByVal value As Double)
                _CO_SUBTOTAL_NA = value
            End Set
        End Property

        Public Property CO_IGV As Double
            Get
                Return _CO_IGV
            End Get
            Set(ByVal value As Double)
                _CO_IGV = value
            End Set
        End Property

        Public Property CO_TOTAL As Double
            Get
                Return _CO_TOTAL
            End Get
            Set(ByVal value As Double)
                _CO_TOTAL = value
            End Set
        End Property

        Public Property CO_IDMONEDA As BE.FacturacionBE.SG_FA_TB_MONEDA
            Get
                Return _CO_IDMONEDA
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_MONEDA)
                _CO_IDMONEDA = value
            End Set
        End Property

        Public Property CO_TCAM As Double
            Get
                Return _CO_TCAM
            End Get
            Set(ByVal value As Double)
                _CO_TCAM = value
            End Set
        End Property

        Public Property CO_TDOC_REF As BE.FacturacionBE.SG_FA_TB_DOCUMENTO
            Get
                Return _CO_TDOC_REF
            End Get
            Set(ByVal value As BE.FacturacionBE.SG_FA_TB_DOCUMENTO)
                _CO_TDOC_REF = value
            End Set
        End Property

        Public Property CO_SDOC_REF As String
            Get
                Return _CO_SDOC_REF
            End Get
            Set(ByVal value As String)
                _CO_SDOC_REF = value
            End Set
        End Property

        Public Property CO_NDOC_REF As String
            Get
                Return _CO_NDOC_REF
            End Get
            Set(ByVal value As String)
                _CO_NDOC_REF = value
            End Set
        End Property

        Public Property CO_FEC_EMI_REF As String
            Get
                Return _CO_FEC_EMI_REF
            End Get
            Set(ByVal value As String)
                _CO_FEC_EMI_REF = value
            End Set
        End Property

        Public Property CO_FEC_VEN_REF As String
            Get
                Return _CO_FEC_VEN_REF
            End Get
            Set(ByVal value As String)
                _CO_FEC_VEN_REF = value
            End Set
        End Property

        Public Property CO_IDEMPRESA As BE.ContabilidadBE.SG_CO_TB_EMPRESA
            Get
                Return _CO_IDEMPRESA
            End Get
            Set(ByVal value As BE.ContabilidadBE.SG_CO_TB_EMPRESA)
                _CO_IDEMPRESA = value
            End Set
        End Property

        Public Property CO_USUARIO As String
            Get
                Return _CO_USUARIO
            End Get
            Set(ByVal value As String)
                _CO_USUARIO = value
            End Set
        End Property

        Public Property CO_TERMINAL As String
            Get
                Return _CO_TERMINAL
            End Get
            Set(ByVal value As String)
                _CO_TERMINAL = value
            End Set
        End Property

        Public Property CO_FECREG As String
            Get
                Return _CO_FECREG
            End Get
            Set(ByVal value As String)
                _CO_FECREG = value
            End Set
        End Property

        Private _CO_CENTCOS As System.String

        Public Property CO_CENTCOS As System.String
            Get
                Return (_CO_CENTCOS)
            End Get
            Set(ByVal value As System.String)
                _CO_CENTCOS = value
            End Set
        End Property

        Private _CO_GLOSA_D As System.Double

        Public Property CO_GLOSA_D As System.Double
            Get
                Return (_CO_GLOSA_D)
            End Get
            Set(ByVal value As System.Double)
                _CO_GLOSA_D = value
            End Set
        End Property

    End Class
End Class

