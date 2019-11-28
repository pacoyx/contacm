Public Class AdmisionBE

    Public Class SG_AD_TB_TOPICO

        Private _TO_ID As System.Int32

        Public Property TO_ID As System.Int32
            Get
                Return (_TO_ID)
            End Get
            Set(ByVal value As System.Int32)
                _TO_ID = value
            End Set
        End Property

        Private _TO_IDNUMHIST As System.Int32

        Public Property TO_IDNUMHIST As System.Int32
            Get
                Return (_TO_IDNUMHIST)
            End Get
            Set(ByVal value As System.Int32)
                _TO_IDNUMHIST = value
            End Set
        End Property

        Private _TO_FECHA As System.DateTime

        Public Property TO_FECHA As System.DateTime
            Get
                Return (_TO_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _TO_FECHA = value
            End Set
        End Property

        Private _TO_NUM_ORDEN As System.Int32

        Public Property TO_NUM_ORDEN As System.Int32
            Get
                Return (_TO_NUM_ORDEN)
            End Get
            Set(ByVal value As System.Int32)
                _TO_NUM_ORDEN = value
            End Set
        End Property

        Private _TO_IDTURNO As System.Int32

        Public Property TO_IDTURNO As System.Int32
            Get
                Return (_TO_IDTURNO)
            End Get
            Set(ByVal value As System.Int32)
                _TO_IDTURNO = value
            End Set
        End Property

        Private _TO_HORA_ATENC As System.String

        Public Property TO_HORA_ATENC As System.String
            Get
                Return (_TO_HORA_ATENC)
            End Get
            Set(ByVal value As System.String)
                _TO_HORA_ATENC = value
            End Set
        End Property

        Private _TO_TOTAL As System.Double

        Public Property TO_TOTAL As System.Double
            Get
                Return (_TO_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _TO_TOTAL = value
            End Set
        End Property

        Private _TO_OBSERVACION As System.String

        Public Property TO_OBSERVACION As System.String
            Get
                Return (_TO_OBSERVACION)
            End Get
            Set(ByVal value As System.String)
                _TO_OBSERVACION = value
            End Set
        End Property

        Private _TO_MEDICODER As System.String

        Public Property TO_MEDICODER As System.String
            Get
                Return (_TO_MEDICODER)
            End Get
            Set(ByVal value As System.String)
                _TO_MEDICODER = value
            End Set
        End Property

        Private _TO_IDEMPRESA As System.Int32

        Public Property TO_IDEMPRESA As System.Int32
            Get
                Return (_TO_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _TO_IDEMPRESA = value
            End Set
        End Property

        Private _TO_ESTADO As System.Int32

        Public Property TO_ESTADO As System.Int32
            Get
                Return (_TO_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _TO_ESTADO = value
            End Set
        End Property

        Private _TO_PERSONAS As System.String

        Public Property TO_PERSONAS As System.String
            Get
                Return (_TO_PERSONAS)
            End Get
            Set(ByVal value As System.String)
                _TO_PERSONAS = value
            End Set
        End Property
    End Class

    Public Class SG_AD_TB_TOPICO_DET

        Private _DT_IDCAB As System.Int32

        Public Property DT_IDCAB As System.Int32
            Get
                Return (_DT_IDCAB)
            End Get
            Set(ByVal value As System.Int32)
                _DT_IDCAB = value
            End Set
        End Property

        Private _DT_IDARTICULO As System.Int32

        Public Property DT_IDARTICULO As System.Int32
            Get
                Return (_DT_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _DT_IDARTICULO = value
            End Set
        End Property

        Private _DT_CANT As System.Int32

        Public Property DT_CANT As System.Int32
            Get
                Return (_DT_CANT)
            End Get
            Set(ByVal value As System.Int32)
                _DT_CANT = value
            End Set
        End Property

        Private _DT_PRECIO As System.Double

        Public Property DT_PRECIO As System.Double
            Get
                Return (_DT_PRECIO)
            End Get
            Set(ByVal value As System.Double)
                _DT_PRECIO = value
            End Set
        End Property

        Private _DT_SUBTOTAL As System.Double

        Public Property DT_SUBTOTAL As System.Double
            Get
                Return (_DT_SUBTOTAL)
            End Get
            Set(ByVal value As System.Double)
                _DT_SUBTOTAL = value
            End Set
        End Property

        Private _DT_IGV As System.Double

        Public Property DT_IGV As System.Double
            Get
                Return (_DT_IGV)
            End Get
            Set(ByVal value As System.Double)
                _DT_IGV = value
            End Set
        End Property

        Private _DT_TOTAL As System.Double

        Public Property DT_TOTAL As System.Double
            Get
                Return (_DT_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _DT_TOTAL = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_RECETA_MEDICA

        Private _RM_ID As System.Int32

        Public Property RM_ID As System.Int32
            Get
                Return (_RM_ID)
            End Get
            Set(ByVal value As System.Int32)
                _RM_ID = value
            End Set
        End Property

        Private _RM_IDCITA As System.Int32

        Public Property RM_IDCITA As System.Int32
            Get
                Return (_RM_IDCITA)
            End Get
            Set(ByVal value As System.Int32)
                _RM_IDCITA = value
            End Set
        End Property

        Private _RM_IDHISTORIA As System.Int32

        Public Property RM_IDHISTORIA As System.Int32
            Get
                Return (_RM_IDHISTORIA)
            End Get
            Set(ByVal value As System.Int32)
                _RM_IDHISTORIA = value
            End Set
        End Property

        Private _RM_FECHA As System.DateTime

        Public Property RM_FECHA As System.DateTime
            Get
                Return (_RM_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _RM_FECHA = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_RECETA_DET

        Private _DR_OBS As String

        Public Property DR_OBS As String
            Get
                Return _DR_OBS
            End Get
            Set(value As String)
                _DR_OBS = value
            End Set
        End Property


        Private _DR_IDRECETA As System.Int32

        Public Property DR_IDRECETA As System.Int32
            Get
                Return (_DR_IDRECETA)
            End Get
            Set(ByVal value As System.Int32)
                _DR_IDRECETA = value
            End Set
        End Property

        Private _DR_IDMEDICAMENTO As System.Int32

        Public Property DR_IDMEDICAMENTO As System.Int32
            Get
                Return (_DR_IDMEDICAMENTO)
            End Get
            Set(ByVal value As System.Int32)
                _DR_IDMEDICAMENTO = value
            End Set
        End Property

        Private _DR_RECETA As System.String

        Public Property DR_RECETA As System.String
            Get
                Return (_DR_RECETA)
            End Get
            Set(ByVal value As System.String)
                _DR_RECETA = value
            End Set
        End Property

        Private _DR_CANT_TOMA As System.Int32

        Public Property DR_CANT_TOMA As System.Int32
            Get
                Return (_DR_CANT_TOMA)
            End Get
            Set(ByVal value As System.Int32)
                _DR_CANT_TOMA = value
            End Set
        End Property
    End Class

    Public Class SG_AD_TB_TURNO

        Private _TU_ID As System.Int32

        Public Property TU_ID As System.Int32
            Get
                Return (_TU_ID)
            End Get
            Set(ByVal value As System.Int32)
                _TU_ID = value
            End Set
        End Property

        Private _TU_DESCRIPCION As System.String

        Public Property TU_DESCRIPCION As System.String
            Get
                Return (_TU_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _TU_DESCRIPCION = value
            End Set
        End Property

        Private _TU_IDEMPRESA As System.Int32

        Public Property TU_IDEMPRESA As System.Int32
            Get
                Return (_TU_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _TU_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_UBICACION

        Private _UB_ID As System.Int32

        Public Property UB_ID As System.Int32
            Get
                Return (_UB_ID)
            End Get
            Set(ByVal value As System.Int32)
                _UB_ID = value
            End Set
        End Property

        Private _UB_Descripcion As System.String

        Public Property UB_Descripcion As System.String
            Get
                Return (_UB_Descripcion)
            End Get
            Set(ByVal value As System.String)
                _UB_Descripcion = value
            End Set
        End Property

        Private _UB_IdEmpresa As System.Int32

        Public Property UB_IdEmpresa As System.Int32
            Get
                Return (_UB_IdEmpresa)
            End Get
            Set(ByVal value As System.Int32)
                _UB_IdEmpresa = value
            End Set
        End Property

    End Class


    Public Class SG_AD_TB_COBERTURA

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _CB_ID As System.Int32

        Public Property CB_ID As System.Int32
            Get
                Return (_CB_ID)
            End Get
            Set(ByVal value As System.Int32)
                _CB_ID = value
            End Set
        End Property

        Private _CB_IDTIPO_ORIGEN As System.Int32

        Public Property CB_IDTIPO_ORIGEN As System.Int32
            Get
                Return (_CB_IDTIPO_ORIGEN)
            End Get
            Set(ByVal value As System.Int32)
                _CB_IDTIPO_ORIGEN = value
            End Set
        End Property

        Private _CB_DESCRIPCION As System.String

        Public Property CB_DESCRIPCION As System.String
            Get
                Return (_CB_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _CB_DESCRIPCION = value
            End Set
        End Property

        Private _CB_IDSUNASA As System.String

        Public Property CB_IDSUNASA As System.String
            Get
                Return (_CB_IDSUNASA)
            End Get
            Set(ByVal value As System.String)
                _CB_IDSUNASA = value
            End Set
        End Property

        Private _CB_SITEDS As System.String

        Public Property CB_SITEDS As System.String
            Get
                Return (_CB_SITEDS)
            End Get
            Set(ByVal value As System.String)
                _CB_SITEDS = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_UsuXMedico

        Private _UM_IDUSUARIO As System.Int32

        Public Property UM_IDUSUARIO As System.Int32
            Get
                Return (_UM_IDUSUARIO)
            End Get
            Set(ByVal value As System.Int32)
                _UM_IDUSUARIO = value
            End Set
        End Property

        Private _UM_IDMEDICO As System.String

        Public Property UM_IDMEDICO As System.String
            Get
                Return (_UM_IDMEDICO)
            End Get
            Set(ByVal value As System.String)
                _UM_IDMEDICO = value
            End Set
        End Property

        Private _UM_IDEMPRESA As System.Int32

        Public Property UM_IDEMPRESA As System.Int32
            Get
                Return (_UM_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _UM_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_RECOMENDADO

        Private _RE_ID As System.Int32

        Public Property RE_ID As System.Int32
            Get
                Return (_RE_ID)
            End Get
            Set(ByVal value As System.Int32)
                _RE_ID = value
            End Set
        End Property

        Private _RE_NOMBRE As System.String

        Public Property RE_NOMBRE As System.String
            Get
                Return (_RE_NOMBRE)
            End Get
            Set(ByVal value As System.String)
                _RE_NOMBRE = value
            End Set
        End Property

        Private _RE_ESTADO As System.Int32

        Public Property RE_ESTADO As System.Int32
            Get
                Return (_RE_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _RE_ESTADO = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_GrupoSanguineo

        Private _GS_ID As System.Int32

        Public Property GS_ID As System.Int32
            Get
                Return (_GS_ID)
            End Get
            Set(ByVal value As System.Int32)
                _GS_ID = value
            End Set
        End Property

        Private _GS_NOMBRE As System.String

        Public Property GS_NOMBRE As System.String
            Get
                Return (_GS_NOMBRE)
            End Get
            Set(ByVal value As System.String)
                _GS_NOMBRE = value
            End Set
        End Property

        Private _GS_ESTADO As System.Int32

        Public Property GS_ESTADO As System.Int32
            Get
                Return (_GS_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _GS_ESTADO = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_CONDICION_ASEGURADO

        Private _CA_ID As System.Int32

        Public Property CA_ID As System.Int32
            Get
                Return (_CA_ID)
            End Get
            Set(ByVal value As System.Int32)
                _CA_ID = value
            End Set
        End Property

        Private _CA_NOMBRE As System.String

        Public Property CA_NOMBRE As System.String
            Get
                Return (_CA_NOMBRE)
            End Get
            Set(ByVal value As System.String)
                _CA_NOMBRE = value
            End Set
        End Property

        Private _CA_ESTADO As System.Int32

        Public Property CA_ESTADO As System.Int32
            Get
                Return (_CA_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _CA_ESTADO = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_OCUPACIONES_MEDICAS

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _OM_ID As System.Int32

        Public Property OM_ID As System.Int32
            Get
                Return (_OM_ID)
            End Get
            Set(ByVal value As System.Int32)
                _OM_ID = value
            End Set
        End Property

        Private _OM_IDPROGRAMACION As System.Int32

        Public Property OM_IDPROGRAMACION As System.Int32
            Get
                Return (_OM_IDPROGRAMACION)
            End Get
            Set(ByVal value As System.Int32)
                _OM_IDPROGRAMACION = value
            End Set
        End Property

        Private _OM_DESCRIPCION As System.String

        Public Property OM_DESCRIPCION As System.String
            Get
                Return (_OM_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _OM_DESCRIPCION = value
            End Set
        End Property

        Private _OM_NUM_ORDEN As System.Int32

        Public Property OM_NUM_ORDEN As System.Int32
            Get
                Return (_OM_NUM_ORDEN)
            End Get
            Set(ByVal value As System.Int32)
                _OM_NUM_ORDEN = value
            End Set
        End Property

        Private _OM_HORA_PROG As System.String

        Public Property OM_HORA_PROG As System.String
            Get
                Return (_OM_HORA_PROG)
            End Get
            Set(ByVal value As System.String)
                _OM_HORA_PROG = value
            End Set
        End Property

        Private _OM_FECHA As System.DateTime

        Public Property OM_FECHA As System.DateTime
            Get
                Return (_OM_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _OM_FECHA = value
            End Set
        End Property

        Private _OM_IDEMPRESA As System.Int32

        Public Property OM_IDEMPRESA As System.Int32
            Get
                Return (_OM_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _OM_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_CUENTA_CAB

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property
        Private _Cant As System.Int32

        Public Property Cant As System.Int32
            Get
                Return (_Cant)
            End Get
            Set(ByVal value As System.Int32)
                _Cant = value
            End Set
        End Property

        Private _CC_ID As System.Int32

        Public Property CC_ID As System.Int32
            Get
                Return (_CC_ID)
            End Get
            Set(ByVal value As System.Int32)
                _CC_ID = value
            End Set
        End Property

        Private _CC_IDTIPO_ORI As System.Int32

        Public Property CC_IDTIPO_ORI As System.Int32
            Get
                Return (_CC_IDTIPO_ORI)
            End Get
            Set(ByVal value As System.Int32)
                _CC_IDTIPO_ORI = value
            End Set
        End Property

        Private _CC_IDNUM_HIST As System.Int32

        Public Property CC_IDNUM_HIST As System.Int32
            Get
                Return (_CC_IDNUM_HIST)
            End Get
            Set(ByVal value As System.Int32)
                _CC_IDNUM_HIST = value
            End Set
        End Property

        Private _CC_IDCLIENTE As System.Int32

        Public Property CC_IDCLIENTE As System.Int32
            Get
                Return (_CC_IDCLIENTE)
            End Get
            Set(ByVal value As System.Int32)
                _CC_IDCLIENTE = value
            End Set
        End Property

        Private _CC_IDTIPO_ATENC As System.Int32

        Public Property CC_IDTIPO_ATENC As System.Int32
            Get
                Return (_CC_IDTIPO_ATENC)
            End Get
            Set(ByVal value As System.Int32)
                _CC_IDTIPO_ATENC = value
            End Set
        End Property

        Private _CC_IDSEGURO As System.String

        Public Property CC_IDSEGURO As System.String
            Get
                Return (_CC_IDSEGURO)
            End Get
            Set(ByVal value As System.String)
                _CC_IDSEGURO = value
            End Set
        End Property

        Private _CC_FECHA As System.DateTime

        Public Property CC_FECHA As System.DateTime
            Get
                Return (_CC_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _CC_FECHA = value
            End Set
        End Property

        Private _CC_ESTADO_CTA As System.Int32

        Public Property CC_ESTADO_CTA As System.Int32
            Get
                Return (_CC_ESTADO_CTA)
            End Get
            Set(ByVal value As System.Int32)
                _CC_ESTADO_CTA = value
            End Set
        End Property

        Private _CC_ESTADO_REG As System.Int32

        Public Property CC_ESTADO_REG As System.Int32
            Get
                Return (_CC_ESTADO_REG)
            End Get
            Set(ByVal value As System.Int32)
                _CC_ESTADO_REG = value
            End Set
        End Property

        Private _CC_USUARIO As System.String

        Public Property CC_USUARIO As System.String
            Get
                Return (_CC_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _CC_USUARIO = value
            End Set
        End Property

        Private _CC_TERMINAL As System.String

        Public Property CC_TERMINAL As System.String
            Get
                Return (_CC_TERMINAL)
            End Get
            Set(ByVal value As System.String)
                _CC_TERMINAL = value
            End Set
        End Property

        Private _CC_FECREG As System.DateTime

        Public Property CC_FECREG As System.DateTime
            Get
                Return (_CC_FECREG)
            End Get
            Set(ByVal value As System.DateTime)
                _CC_FECREG = value
            End Set
        End Property

        Private _CC_IDEMPRESA As System.Int32

        Public Property CC_IDEMPRESA As System.Int32
            Get
                Return (_CC_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _CC_IDEMPRESA = value
            End Set
        End Property

        Private _CC_IDCITA As System.Int32

        Public Property CC_IDCITA As System.Int32
            Get
                Return (_CC_IDCITA)
            End Get
            Set(ByVal value As System.Int32)
                _CC_IDCITA = value
            End Set
        End Property

        Private _CC_IDPREFAC As System.Int32

        Public Property CC_IDPREFAC As System.Int32
            Get
                Return (_CC_IDPREFAC)
            End Get
            Set(ByVal value As System.Int32)
                _CC_IDPREFAC = value
            End Set
        End Property

        Private _CC_MEDICO As System.String

        Public Property CC_MEDICO As System.String
            Get
                Return (_CC_MEDICO)
            End Get
            Set(ByVal value As System.String)
                _CC_MEDICO = value
            End Set
        End Property

        Private _CC_SIT_COD_EPS As System.String

        Public Property CC_SIT_COD_EPS As System.String
            Get
                Return (_CC_SIT_COD_EPS)
            End Get
            Set(ByVal value As System.String)
                _CC_SIT_COD_EPS = value
            End Set
        End Property

        Private _CC_SIT_COD_ASEG As System.String

        Public Property CC_SIT_COD_ASEG As System.String
            Get
                Return (_CC_SIT_COD_ASEG)
            End Get
            Set(ByVal value As System.String)
                _CC_SIT_COD_ASEG = value
            End Set
        End Property

        Private _CC_SIT_FEC_AUTORI As System.DateTime

        Public Property CC_SIT_FEC_AUTORI As System.DateTime
            Get
                Return (_CC_SIT_FEC_AUTORI)
            End Get
            Set(ByVal value As System.DateTime)
                _CC_SIT_FEC_AUTORI = value
            End Set
        End Property

        Private _CC_SIT_COD_COBER As System.Int32

        Public Property CC_SIT_COD_COBER As System.Int32
            Get
                Return (_CC_SIT_COD_COBER)
            End Get
            Set(ByVal value As System.Int32)
                _CC_SIT_COD_COBER = value
            End Set
        End Property

        Private _CC_SIT_COPG_FIJO As System.Double

        Public Property CC_SIT_COPG_FIJO As System.Double
            Get
                Return (_CC_SIT_COPG_FIJO)
            End Get
            Set(ByVal value As System.Double)
                _CC_SIT_COPG_FIJO = value
            End Set
        End Property

        Private _CC_SIT_COPG_VARI As System.Double

        Public Property CC_SIT_COPG_VARI As System.Double
            Get
                Return (_CC_SIT_COPG_VARI)
            End Get
            Set(ByVal value As System.Double)
                _CC_SIT_COPG_VARI = value
            End Set
        End Property

        Private _CC_SIT_COD_GENE As System.String

        Public Property CC_SIT_COD_GENE As System.String
            Get
                Return (_CC_SIT_COD_GENE)
            End Get
            Set(ByVal value As System.String)
                _CC_SIT_COD_GENE = value
            End Set
        End Property

        Private _CC_INGRESO_MANUAL As System.Int32

        Public Property CC_INGRESO_MANUAL As System.Int32
            Get
                Return (_CC_INGRESO_MANUAL)
            End Get
            Set(ByVal value As System.Int32)
                _CC_INGRESO_MANUAL = value
            End Set
        End Property

        Private _CC_TIPOAFILIACION As System.Int32

        Public Property CC_TIPOAFILIACION As System.Int32
            Get
                Return (_CC_TIPOAFILIACION)
            End Get
            Set(ByVal value As System.Int32)
                _CC_TIPOAFILIACION = value
            End Set
        End Property

        Private _CC_SIT_MONTO_IMP As System.Double

        Public Property CC_SIT_MONTO_IMP As System.Double
            Get
                Return (_CC_SIT_MONTO_IMP)
            End Get
            Set(ByVal value As System.Double)
                _CC_SIT_MONTO_IMP = value
            End Set
        End Property

        Private _CC_ESTADO_PROC As System.Int32

        Public Property CC_ESTADO_PROC As System.Int32
            Get
                Return (_CC_ESTADO_PROC)
            End Get
            Set(ByVal value As System.Int32)
                _CC_ESTADO_PROC = value
            End Set
        End Property

        Private _CC_FECHA_PROC As System.DateTime

        Public Property CC_FECHA_PROC As System.DateTime
            Get
                Return (_CC_FECHA_PROC)
            End Get
            Set(ByVal value As System.DateTime)
                _CC_FECHA_PROC = value
            End Set
        End Property

    End Class

    Public Class TMP_SG_AD_TB_CUENTA_DET

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _TCD_IDCAB As System.Int32

        Public Property TCD_IDCAB As System.Int32
            Get
                Return (_TCD_IDCAB)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_IDCAB = value
            End Set
        End Property

        Private _TCD_ITEM As System.Int32

        Public Property TCD_ITEM As System.Int32
            Get
                Return (_TCD_ITEM)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_ITEM = value
            End Set
        End Property

        Private _TCD_IDARTICULO As System.Int32

        Public Property TCD_IDARTICULO As System.Int32
            Get
                Return (_TCD_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_IDARTICULO = value
            End Set
        End Property

        Private _TCD_CANT As System.Int32

        Public Property TCD_CANT As System.Int32
            Get
                Return (_TCD_CANT)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_CANT = value
            End Set
        End Property

        Private _TCD_TOTAL As System.Double

        Public Property TCD_TOTAL As System.Double
            Get
                Return (_TCD_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _TCD_TOTAL = value
            End Set
        End Property

        Private _TCD_PRECIO As System.Double

        Public Property TCD_PRECIO As System.Double
            Get
                Return (_TCD_PRECIO)
            End Get
            Set(ByVal value As System.Double)
                _TCD_PRECIO = value
            End Set
        End Property

        Private _TCD_DESCUENTO As System.Double

        Public Property TCD_DESCUENTO As System.Double
            Get
                Return (_TCD_DESCUENTO)
            End Get
            Set(ByVal value As System.Double)
                _TCD_DESCUENTO = value
            End Set
        End Property

        Private _TCD_SUB_TOTAL As System.Double

        Public Property TCD_SUB_TOTAL As System.Double
            Get
                Return (_TCD_SUB_TOTAL)
            End Get
            Set(ByVal value As System.Double)
                _TCD_SUB_TOTAL = value
            End Set
        End Property

        Private _TCD_IGV As System.Double

        Public Property TCD_IGV As System.Double
            Get
                Return (_TCD_IGV)
            End Get
            Set(ByVal value As System.Double)
                _TCD_IGV = value
            End Set
        End Property

        Private _TCD_ESTADO As System.Int32

        Public Property TCD_ESTADO As System.Int32
            Get
                Return (_TCD_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_ESTADO = value
            End Set
        End Property

        Private _TCD_IDCITA As System.Int32

        Public Property TCD_IDCITA As System.Int32
            Get
                Return (_TCD_IDCITA)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_IDCITA = value
            End Set
        End Property

        Private _TCD_IDCOMPROBANTE As System.Int32

        Public Property TCD_IDCOMPROBANTE As System.Int32
            Get
                Return (_TCD_IDCOMPROBANTE)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_IDCOMPROBANTE = value
            End Set
        End Property

        Private _TCD_IDempresa As System.Int32

        Public Property TCD_IDempresa As System.Int32
            Get
                Return (_TCD_IDempresa)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_IDempresa = value
            End Set
        End Property

        Private _TCD_DESCRIPCION As System.String

        Public Property TCD_DESCRIPCION As System.String
            Get
                Return (_TCD_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _TCD_DESCRIPCION = value
            End Set
        End Property

        Private _TCD_FECHA As System.DateTime

        Public Property TCD_FECHA As System.DateTime
            Get
                Return (_TCD_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _TCD_FECHA = value
            End Set
        End Property

        Private _TCD_SINPAGO As System.Int32

        Public Property TCD_SINPAGO As System.Int32
            Get
                Return (_TCD_SINPAGO)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_SINPAGO = value
            End Set
        End Property

        Private _TCD_DSCTO_OTRO As System.Double

        Public Property TCD_DSCTO_OTRO As System.Double
            Get
                Return (_TCD_DSCTO_OTRO)
            End Get
            Set(ByVal value As System.Double)
                _TCD_DSCTO_OTRO = value
            End Set
        End Property

        Private _TCD_SEG_CUBRE As System.Int32

        Public Property TCD_SEG_CUBRE As System.Int32
            Get
                Return (_TCD_SEG_CUBRE)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_SEG_CUBRE = value
            End Set
        End Property

        Private _TCD_DEDUCIBLE As System.Int32

        Public Property TCD_DEDUCIBLE As System.Int32
            Get
                Return (_TCD_DEDUCIBLE)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_DEDUCIBLE = value
            End Set
        End Property

        Private _TCD_DSCTO_PORC As System.Int32

        Public Property TCD_DSCTO_PORC As System.Int32
            Get
                Return (_TCD_DSCTO_PORC)
            End Get
            Set(ByVal value As System.Int32)
                _TCD_DSCTO_PORC = value
            End Set
        End Property
    End Class

    Public Class SG_AD_TB_MEDICO

        Private _ME_CODIGO As System.String

        Public Property ME_CODIGO As System.String
            Get
                Return (_ME_CODIGO)
            End Get
            Set(ByVal value As System.String)
                _ME_CODIGO = value
            End Set
        End Property

        Private _ME_APE_PAT As System.String

        Public Property ME_APE_PAT As System.String
            Get
                Return (_ME_APE_PAT)
            End Get
            Set(ByVal value As System.String)
                _ME_APE_PAT = value
            End Set
        End Property

        Private _ME_APE_MAT As System.String

        Public Property ME_APE_MAT As System.String
            Get
                Return (_ME_APE_MAT)
            End Get
            Set(ByVal value As System.String)
                _ME_APE_MAT = value
            End Set
        End Property

        Private _ME_NOMBRES As System.String

        Public Property ME_NOMBRES As System.String
            Get
                Return (_ME_NOMBRES)
            End Get
            Set(ByVal value As System.String)
                _ME_NOMBRES = value
            End Set
        End Property

        Private _ME_NUM_COLEG As System.String

        Public Property ME_NUM_COLEG As System.String
            Get
                Return (_ME_NUM_COLEG)
            End Get
            Set(ByVal value As System.String)
                _ME_NUM_COLEG = value
            End Set
        End Property

        Private _ME_ESTADO As System.Int32

        Public Property ME_ESTADO As System.Int32
            Get
                Return (_ME_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _ME_ESTADO = value
            End Set
        End Property

        Private _ME_ESPECIALIDAD As System.Int32

        Public Property ME_ESPECIALIDAD As System.Int32
            Get
                Return (_ME_ESPECIALIDAD)
            End Get
            Set(ByVal value As System.Int32)
                _ME_ESPECIALIDAD = value
            End Set
        End Property

        Private _ME_RUC As System.String

        Public Property ME_RUC As System.String
            Get
                Return (_ME_RUC)
            End Get
            Set(ByVal value As System.String)
                _ME_RUC = value
            End Set
        End Property

        Private _ME_DIRECCION As System.String

        Public Property ME_DIRECCION As System.String
            Get
                Return (_ME_DIRECCION)
            End Get
            Set(ByVal value As System.String)
                _ME_DIRECCION = value
            End Set
        End Property

        Private _ME_TELEFONOFIJO As System.String

        Public Property ME_TELEFONOFIJO As System.String
            Get
                Return (_ME_TELEFONOFIJO)
            End Get
            Set(ByVal value As System.String)
                _ME_TELEFONOFIJO = value
            End Set
        End Property

        Private _ME_TELEFONOCELULAR As System.String

        Public Property ME_TELEFONOCELULAR As System.String
            Get
                Return (_ME_TELEFONOCELULAR)
            End Get
            Set(ByVal value As System.String)
                _ME_TELEFONOCELULAR = value
            End Set
        End Property

        Private _ME_INTERVALO As System.Double

        Public Property ME_INTERVALO As System.Double
            Get
                Return (_ME_INTERVALO)
            End Get
            Set(ByVal value As System.Double)
                _ME_INTERVALO = value
            End Set
        End Property

        Private _ME_FECNAC As System.DateTime

        Public Property ME_FECNAC As System.DateTime
            Get
                Return (_ME_FECNAC)
            End Get
            Set(ByVal value As System.DateTime)
                _ME_FECNAC = value
            End Set
        End Property

        Private _ME_CORREO As System.String

        Public Property ME_CORREO As System.String
            Get
                Return (_ME_CORREO)
            End Get
            Set(ByVal value As System.String)
                _ME_CORREO = value
            End Set
        End Property

        Private _ME_USUARIO As System.String

        Public Property ME_USUARIO As System.String
            Get
                Return (_ME_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _ME_USUARIO = value
            End Set
        End Property

        Private _ME_PC As System.String

        Public Property ME_PC As System.String
            Get
                Return (_ME_PC)
            End Get
            Set(ByVal value As System.String)
                _ME_PC = value
            End Set
        End Property

        Private _ME_IDEMPRESA As System.Int32

        Public Property ME_IDEMPRESA As System.Int32
            Get
                Return (_ME_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _ME_IDEMPRESA = value
            End Set
        End Property

        Private _ME_NDOC As System.String

        Public Property ME_NDOC As System.String
            Get
                Return (_ME_NDOC)
            End Get
            Set(ByVal value As System.String)
                _ME_NDOC = value
            End Set
        End Property

        Private _ME_TDOC As System.Int32

        Public Property ME_TDOC As System.Int32
            Get
                Return (_ME_TDOC)
            End Get
            Set(ByVal value As System.Int32)
                _ME_TDOC = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_CITA_MED

        Private _HasRow As System.Boolean

        Public Property HasRow As System.Boolean
            Get
                Return (_HasRow)
            End Get
            Set(ByVal value As System.Boolean)
                _HasRow = value
            End Set
        End Property

        Private _CM_ID As System.Int32

        Public Property CM_ID As System.Int32
            Get
                Return (_CM_ID)
            End Get
            Set(ByVal value As System.Int32)
                _CM_ID = value
            End Set
        End Property

        Private _CM_IDPROGRAMACION As System.Int32

        Public Property CM_IDPROGRAMACION As System.Int32
            Get
                Return (_CM_IDPROGRAMACION)
            End Get
            Set(ByVal value As System.Int32)
                _CM_IDPROGRAMACION = value
            End Set
        End Property

        Private _CM_IDNUMHIST As System.Int32

        Public Property CM_IDNUMHIST As System.Int32
            Get
                Return (_CM_IDNUMHIST)
            End Get
            Set(ByVal value As System.Int32)
                _CM_IDNUMHIST = value
            End Set
        End Property

        Private _CM_FECHACITA As System.DateTime

        Public Property CM_FECHACITA As System.DateTime
            Get
                Return (_CM_FECHACITA)
            End Get
            Set(ByVal value As System.DateTime)
                _CM_FECHACITA = value
            End Set
        End Property

        Private _CM_NUM_ORDEN As System.Int32

        Public Property CM_NUM_ORDEN As System.Int32
            Get
                Return (_CM_NUM_ORDEN)
            End Get
            Set(ByVal value As System.Int32)
                _CM_NUM_ORDEN = value
            End Set
        End Property

        Private _CM_HORA_PROG As System.String

        Public Property CM_HORA_PROG As System.String
            Get
                Return (_CM_HORA_PROG)
            End Get
            Set(ByVal value As System.String)
                _CM_HORA_PROG = value
            End Set
        End Property

        Private _CM_HORA_ATENC As System.String

        Public Property CM_HORA_ATENC As System.String
            Get
                Return (_CM_HORA_ATENC)
            End Get
            Set(ByVal value As System.String)
                _CM_HORA_ATENC = value
            End Set
        End Property

        Private _CM_HORA_ING As System.String

        Public Property CM_HORA_ING As System.String
            Get
                Return (_CM_HORA_ING)
            End Get
            Set(ByVal value As System.String)
                _CM_HORA_ING = value
            End Set
        End Property

        Private _CM_HORA_SAL As System.String

        Public Property CM_HORA_SAL As System.String
            Get
                Return (_CM_HORA_SAL)
            End Get
            Set(ByVal value As System.String)
                _CM_HORA_SAL = value
            End Set
        End Property

        Private _CM_OBSERVACIONES As System.String

        Public Property CM_OBSERVACIONES As System.String
            Get
                Return (_CM_OBSERVACIONES)
            End Get
            Set(ByVal value As System.String)
                _CM_OBSERVACIONES = value
            End Set
        End Property

        Private _CM_EDAD_ATENC As System.Int32

        Public Property CM_EDAD_ATENC As System.Int32
            Get
                Return (_CM_EDAD_ATENC)
            End Get
            Set(ByVal value As System.Int32)
                _CM_EDAD_ATENC = value
            End Set
        End Property

        Private _CM_IDTIPO_ATENC As System.Int32

        Public Property CM_IDTIPO_ATENC As System.Int32
            Get
                Return (_CM_IDTIPO_ATENC)
            End Get
            Set(ByVal value As System.Int32)
                _CM_IDTIPO_ATENC = value
            End Set
        End Property

        Private _CM_IDSEGURO As System.String

        Public Property CM_IDSEGURO As System.String
            Get
                Return (_CM_IDSEGURO)
            End Get
            Set(ByVal value As System.String)
                _CM_IDSEGURO = value
            End Set
        End Property

        Private _CM_ESTADO As System.Int32

        Public Property CM_ESTADO As System.Int32
            Get
                Return (_CM_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _CM_ESTADO = value
            End Set
        End Property

        Private _CM_USUARIO As System.String

        Public Property CM_USUARIO As System.String
            Get
                Return (_CM_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _CM_USUARIO = value
            End Set
        End Property

        Private _CM_PC As System.String

        Public Property CM_PC As System.String
            Get
                Return (_CM_PC)
            End Get
            Set(ByVal value As System.String)
                _CM_PC = value
            End Set
        End Property

        Private _CM_FECREG As System.DateTime

        Public Property CM_FECREG As System.DateTime
            Get
                Return (_CM_FECREG)
            End Get
            Set(ByVal value As System.DateTime)
                _CM_FECREG = value
            End Set
        End Property

        Private _CM_IDEMPRESA As System.Int32

        Public Property CM_IDEMPRESA As System.Int32
            Get
                Return (_CM_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _CM_IDEMPRESA = value
            End Set
        End Property

        Private _CM_IDCLIENTE As System.Int32

        Public Property CM_IDCLIENTE As System.Int32
            Get
                Return (_CM_IDCLIENTE)
            End Get
            Set(ByVal value As System.Int32)
                _CM_IDCLIENTE = value
            End Set
        End Property

        Private _CM_IDMEDICODERI As System.String

        Public Property CM_IDMEDICODERI As System.String
            Get
                Return (_CM_IDMEDICODERI)
            End Get
            Set(ByVal value As System.String)
                _CM_IDMEDICODERI = value
            End Set
        End Property

        Private _CM_Anamnesis As System.Int32

        Public Property CM_Anamnesis As System.Int32
            Get
                Return (_CM_Anamnesis)
            End Get
            Set(ByVal value As System.Int32)
                _CM_Anamnesis = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_PROGRAMA_CITA
        Private _PR_ID As Integer
        Private _PR_MEDICO As String
        Private _PR_IDCONSULTORIO As Integer
        Private _PR_IDSERVICIO As Integer
        Private _PR_TURNO_INI As String
        Private _PR_TURNO_FIN As String
        Private _PR_FECHA As String
        Private _PR_ESTADO As Integer
        Private _PR_CUPOS As Integer
        Private _PR_PC As String
        Private _PR_USUARIO As String
        Private _PR_FECREG As String
        Private _PR_IDEMPRESA As Integer

        Private _PR_Tipo As System.Int32

        Public Property PR_Tipo As System.Int32
            Get
                Return (_PR_Tipo)
            End Get
            Set(ByVal value As System.Int32)
                _PR_Tipo = value
            End Set
        End Property

        Private _PR_Turno As System.Int32

        Public Property PR_Turno As System.Int32
            Get
                Return (_PR_Turno)
            End Get
            Set(ByVal value As System.Int32)
                _PR_Turno = value
            End Set
        End Property

        Private _PR_DIAS As System.String

        Public Property PR_DIAS As System.String
            Get
                Return (_PR_DIAS)
            End Get
            Set(ByVal value As System.String)
                _PR_DIAS = value
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

        Public Sub New(ByVal PR_ID_ As Integer, ByVal PR_MEDICO_ As String, ByVal PR_IDCONSULTORIO_ As Integer, ByVal PR_IDSERVICIO_ As Integer, ByVal PR_TURNO_INI_ As String, ByVal PR_TURNO_FIN_ As String, ByVal PR_FECHA_ As String, ByVal PR_ESTADO_ As Integer, ByVal PR_CUPOS_ As Integer, ByVal PR_PC_ As String, ByVal PR_USUARIO_ As String, ByVal PR_FECREG_ As String, ByVal PR_IDEMPRESA_ As Integer)
            _PR_ID = PR_ID_
            _PR_MEDICO = PR_MEDICO_
            _PR_IDCONSULTORIO = PR_IDCONSULTORIO_
            _PR_IDSERVICIO = PR_IDSERVICIO_
            _PR_TURNO_INI = PR_TURNO_INI_
            _PR_TURNO_FIN = PR_TURNO_FIN_
            _PR_FECHA = PR_FECHA_
            _PR_ESTADO = PR_ESTADO_
            _PR_CUPOS = PR_CUPOS_
            _PR_PC = PR_PC_
            _PR_USUARIO = PR_USUARIO_
            _PR_FECREG = PR_FECREG_
            _PR_IDEMPRESA = PR_IDEMPRESA_
        End Sub


        Public Sub New()
            _PR_ID = 0
            _PR_MEDICO = String.Empty
            _PR_IDCONSULTORIO = 0
            _PR_IDSERVICIO = 0
            _PR_TURNO_INI = String.Empty
            _PR_TURNO_FIN = String.Empty
            _PR_FECHA = String.Empty
            _PR_ESTADO = 0
            _PR_CUPOS = 0
            _PR_PC = String.Empty
            _PR_USUARIO = String.Empty
            _PR_FECREG = String.Empty
            _PR_IDEMPRESA = 0
        End Sub

        Public Property PR_ID As Integer
            Get
                Return _PR_ID
            End Get
            Set(ByVal value As Integer)
                _PR_ID = value
            End Set
        End Property

        Public Property PR_MEDICO As String
            Get
                Return _PR_MEDICO
            End Get
            Set(ByVal value As String)
                _PR_MEDICO = value
            End Set
        End Property

        Public Property PR_IDCONSULTORIO As Integer
            Get
                Return _PR_IDCONSULTORIO
            End Get
            Set(ByVal value As Integer)
                _PR_IDCONSULTORIO = value
            End Set
        End Property

        Public Property PR_IDSERVICIO As Integer
            Get
                Return _PR_IDSERVICIO
            End Get
            Set(ByVal value As Integer)
                _PR_IDSERVICIO = value
            End Set
        End Property

        Public Property PR_TURNO_INI As String
            Get
                Return _PR_TURNO_INI
            End Get
            Set(ByVal value As String)
                _PR_TURNO_INI = value
            End Set
        End Property

        Public Property PR_TURNO_FIN As String
            Get
                Return _PR_TURNO_FIN
            End Get
            Set(ByVal value As String)
                _PR_TURNO_FIN = value
            End Set
        End Property

        Public Property PR_FECHA As String
            Get
                Return _PR_FECHA
            End Get
            Set(ByVal value As String)
                _PR_FECHA = value
            End Set
        End Property

        Public Property PR_ESTADO As Integer
            Get
                Return _PR_ESTADO
            End Get
            Set(ByVal value As Integer)
                _PR_ESTADO = value
            End Set
        End Property

        Public Property PR_CUPOS As Integer
            Get
                Return _PR_CUPOS
            End Get
            Set(ByVal value As Integer)
                _PR_CUPOS = value
            End Set
        End Property

        Public Property PR_PC As String
            Get
                Return _PR_PC
            End Get
            Set(ByVal value As String)
                _PR_PC = value
            End Set
        End Property

        Public Property PR_USUARIO As String
            Get
                Return _PR_USUARIO
            End Get
            Set(ByVal value As String)
                _PR_USUARIO = value
            End Set
        End Property

        Public Property PR_FECREG As String
            Get
                Return _PR_FECREG
            End Get
            Set(ByVal value As String)
                _PR_FECREG = value
            End Set
        End Property

        Public Property PR_IDEMPRESA As Integer
            Get
                Return _PR_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _PR_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_TIP_DOC_PER
        Private _TD_ID As Integer
        Private _TD_DESCRIPCION As String
        Private _TD_ABREVIATURA As String
        Private _TD_COD_SUNAT As String
        Private _TD_IDEMPRESA As Integer
        Private _TD_USUARIO As String
        Private _TD_TERMINAL As String
        Private _TD_FECREG As String
        Private _TD_COD_CONTA As String

        Public Sub New(ByVal TD_ID_ As Integer, ByVal TD_DESCRIPCION_ As String, ByVal TD_ABREVIATURA_ As String, ByVal TD_COD_SUNAT_ As String, ByVal TD_IDEMPRESA_ As Integer, ByVal TD_USUARIO_ As String, ByVal TD_TERMINAL_ As String, ByVal TD_FECREG_ As String, ByVal TD_COD_CONTA_ As String)
            _TD_COD_CONTA = TD_COD_CONTA_
            _TD_ID = TD_ID_
            _TD_DESCRIPCION = TD_DESCRIPCION_
            _TD_ABREVIATURA = TD_ABREVIATURA_
            _TD_COD_SUNAT = TD_COD_SUNAT_
            _TD_IDEMPRESA = TD_IDEMPRESA_
            _TD_USUARIO = TD_USUARIO_
            _TD_TERMINAL = TD_TERMINAL_
            _TD_FECREG = TD_FECREG_
        End Sub

        Public Sub New()
            _TD_COD_CONTA = String.Empty
            _TD_ID = 0
            _TD_DESCRIPCION = String.Empty
            _TD_ABREVIATURA = String.Empty
            _TD_COD_SUNAT = String.Empty
            _TD_IDEMPRESA = 0
            _TD_USUARIO = String.Empty
            _TD_TERMINAL = String.Empty
            _TD_FECREG = String.Empty
        End Sub

        Public Property TD_COD_CONTA As String
            Get
                Return _TD_COD_CONTA
            End Get
            Set(ByVal value As String)
                _TD_COD_CONTA = value
            End Set
        End Property

        Public Property TD_ID As Integer
            Get
                Return _TD_ID
            End Get
            Set(ByVal value As Integer)
                _TD_ID = value
            End Set
        End Property

        Public Property TD_DESCRIPCION As String
            Get
                Return _TD_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _TD_DESCRIPCION = value
            End Set
        End Property

        Public Property TD_ABREVIATURA As String
            Get
                Return _TD_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _TD_ABREVIATURA = value
            End Set
        End Property

        Public Property TD_COD_SUNAT As String
            Get
                Return _TD_COD_SUNAT
            End Get
            Set(ByVal value As String)
                _TD_COD_SUNAT = value
            End Set
        End Property

        Public Property TD_IDEMPRESA As Integer
            Get
                Return _TD_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _TD_IDEMPRESA = value
            End Set
        End Property

        Public Property TD_USUARIO As String
            Get
                Return _TD_USUARIO
            End Get
            Set(ByVal value As String)
                _TD_USUARIO = value
            End Set
        End Property

        Public Property TD_TERMINAL As String
            Get
                Return _TD_TERMINAL
            End Get
            Set(ByVal value As String)
                _TD_TERMINAL = value
            End Set
        End Property

        Public Property TD_FECREG As String
            Get
                Return _TD_FECREG
            End Get
            Set(ByVal value As String)
                _TD_FECREG = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_ESTADO_CIVIL
        Private _EC_ID As Integer
        Private _EC_DESCRIPCION As String
        Private _EC_ABREVIATURA As String
        Private _EC_IDEMPRESA As Integer

        Public Sub New(ByVal EC_ID_ As Integer, ByVal EC_DESCRIPCION_ As String, ByVal EC_ABREVIATURA_ As String, ByVal EC_IDEMPRESA_ As Integer)
            _EC_ID = EC_ID_
            _EC_DESCRIPCION = EC_DESCRIPCION_
            _EC_ABREVIATURA = EC_ABREVIATURA_
            _EC_IDEMPRESA = EC_IDEMPRESA_
        End Sub

        Public Sub New()
            _EC_ID = 0
            _EC_DESCRIPCION = String.Empty
            _EC_ABREVIATURA = String.Empty
            _EC_IDEMPRESA = 0
        End Sub

        Public Property EC_IDEMPRESA As Integer
            Get
                Return _EC_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _EC_IDEMPRESA = value
            End Set
        End Property

        Public Property EC_ABREVIATURA As String
            Get
                Return _EC_ABREVIATURA
            End Get
            Set(ByVal value As String)
                _EC_ABREVIATURA = value
            End Set
        End Property

        Public Property EC_DESCRIPCION As String
            Get
                Return _EC_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _EC_DESCRIPCION = value
            End Set
        End Property

        Public Property EC_ID As Integer
            Get
                Return _EC_ID
            End Get
            Set(ByVal value As Integer)
                _EC_ID = value
            End Set
        End Property


    End Class

    Public Class SG_AD_TB_NACIONALIDAD
        Private _NA_ID As String
        Private _NA_DESCRIPCION As String
        Private _NA_IDEMPRESA As Integer
        Private _NA_USUARIO As String
        Private _NA_TERMINAL As String
        Private _NA_FECREG As String

        Public Sub New(ByVal NA_ID_ As String, ByVal NA_DESCRIPCION_ As String, ByVal NA_IDEMPRESA_ As Integer, ByVal NA_USUARIO_ As String, ByVal NA_TERMINAL_ As String, ByVal NA_FECREG_ As String)
            _NA_ID = NA_ID_
            _NA_DESCRIPCION = NA_DESCRIPCION_
            _NA_IDEMPRESA = NA_IDEMPRESA_
            _NA_USUARIO = NA_USUARIO_
            _NA_TERMINAL = NA_TERMINAL_
            _NA_FECREG = NA_FECREG_
        End Sub

        Public Sub New()
            _NA_ID = 0
            _NA_DESCRIPCION = String.Empty
            _NA_IDEMPRESA = 0
            _NA_USUARIO = String.Empty
            _NA_TERMINAL = String.Empty
            _NA_FECREG = String.Empty
        End Sub

        Public Property NA_ID As String
            Get
                Return _NA_ID
            End Get
            Set(ByVal value As String)
                _NA_ID = value
            End Set
        End Property

        Public Property NA_DESCRIPCION As String
            Get
                Return _NA_DESCRIPCION
            End Get
            Set(ByVal value As String)
                _NA_DESCRIPCION = value
            End Set
        End Property

        Public Property NA_IDEMPRESA As Integer
            Get
                Return _NA_IDEMPRESA
            End Get
            Set(ByVal value As Integer)
                _NA_IDEMPRESA = value
            End Set
        End Property

        Public Property NA_USUARIO As String
            Get
                Return _NA_USUARIO
            End Get
            Set(ByVal value As String)
                _NA_USUARIO = value
            End Set
        End Property

        Public Property NA_TERMINAL As String
            Get
                Return _NA_TERMINAL
            End Get
            Set(ByVal value As String)
                _NA_TERMINAL = value
            End Set
        End Property

        Public Property NA_FECREG As String
            Get
                Return _NA_FECREG
            End Get
            Set(ByVal value As String)
                _NA_FECREG = value
            End Set
        End Property



    End Class

    'Public Class SG_AD_TB_HISTO_CLINI
    '    Private _HC_NUM_HIST As Integer
    '    Private _HC_IDCLIENTE As Integer
    '    Private _HC_NOMBRE1 As String
    '    Private _HC_NOMBRE2 As String
    '    Private _HC_APE_PAT As String
    '    Private _HC_APE_MAT As String
    '    Private _HC_APE_CASADA As String
    '    Private _HC_TDOC As BE.AdmisionBE.SG_AD_TB_TIP_DOC_PER
    '    Private _HC_NDOC As String
    '    Private _HC_FNAC As String
    '    Private _HC_FING As String
    '    Private _HC_SEXO As String
    '    Private _HC_EST_CIVIL As Integer
    '    Private _HC_DIR As String
    '    Private _HC_OCUPACION As String
    '    Private _HC_IDNACIONALIDAD As String
    '    Private _HC_USUARIO As String
    '    Private _HC_TERMINAL As String
    '    Private _HC_FECREG As String
    '    Private _HC_IDEMPRESA As Integer

    '    Public Sub New(HC_NUM_HIST_ As Integer, HC_IDCLIENTE_ As Integer, HC_NOMBRE1_ As String, HC_NOMBRE2_ As String, HC_APE_PAT_ As String, HC_APE_MAT_ As String, HC_APE_CASADA_ As String, HC_TDOC_ As BE.AdmisionBE.SG_AD_TB_TIP_DOC_PER, HC_NDOC_ As String, HC_FNAC_ As String, HC_FING_ As String, HC_SEXO_ As String, HC_EST_CIVIL_ As Integer, HC_DIR_ As String, HC_OCUPACION_ As String, HC_IDNACIONALIDAD_ As String, HC_USUARIO_ As String, HC_TERMINAL_ As String, HC_FECREG_ As String, HC_IDEMPRESA_ As Integer)
    '        _HC_IDEMPRESA = HC_IDEMPRESA_
    '        _HC_NUM_HIST = HC_NUM_HIST_
    '        _HC_IDCLIENTE = HC_IDCLIENTE_
    '        _HC_NOMBRE1 = HC_NOMBRE1_
    '        _HC_NOMBRE2 = HC_NOMBRE2_
    '        _HC_APE_PAT = HC_APE_PAT_
    '        _HC_APE_MAT = HC_APE_MAT_
    '        _HC_APE_CASADA = HC_APE_CASADA_
    '        _HC_TDOC = HC_TDOC_
    '        _HC_NDOC = HC_NDOC_
    '        _HC_FNAC = HC_FNAC_
    '        _HC_FING = HC_FING_
    '        _HC_SEXO = HC_SEXO_
    '        _HC_EST_CIVIL = HC_EST_CIVIL_
    '        _HC_DIR = HC_DIR_
    '        _HC_OCUPACION = HC_OCUPACION_
    '        _HC_IDNACIONALIDAD = HC_IDNACIONALIDAD_
    '        _HC_USUARIO = HC_USUARIO_
    '        _HC_TERMINAL = HC_TERMINAL_
    '        _HC_FECREG = HC_FECREG_
    '    End Sub

    '    Public Sub New()
    '        _HC_NUM_HIST = 0
    '        _HC_IDCLIENTE = 0
    '        _HC_NOMBRE1 = String.Empty
    '        _HC_NOMBRE2 = String.Empty
    '        _HC_APE_PAT = String.Empty
    '        _HC_APE_MAT = String.Empty
    '        _HC_APE_CASADA = String.Empty
    '        _HC_TDOC = Nothing
    '        _HC_NDOC = String.Empty
    '        _HC_FNAC = String.Empty
    '        _HC_FING = String.Empty
    '        _HC_SEXO = String.Empty
    '        _HC_EST_CIVIL = 0
    '        _HC_DIR = String.Empty
    '        _HC_OCUPACION = String.Empty
    '        _HC_IDNACIONALIDAD = String.Empty
    '        _HC_USUARIO = String.Empty
    '        _HC_TERMINAL = String.Empty
    '        _HC_FECREG = String.Empty
    '        _HC_IDEMPRESA = 0
    '    End Sub

    '    Public Property HC_IDEMPRESA As Integer
    '        Get
    '            Return _HC_IDEMPRESA
    '        End Get
    '        Set(value As Integer)
    '            _HC_IDEMPRESA = value
    '        End Set
    '    End Property

    '    Public Property HC_NUM_HIST As Integer
    '        Get
    '            Return _HC_NUM_HIST
    '        End Get
    '        Set(value As Integer)
    '            _HC_NUM_HIST = value
    '        End Set
    '    End Property

    '    Public Property HC_IDCLIENTE As Integer
    '        Get
    '            Return _HC_IDCLIENTE
    '        End Get
    '        Set(value As Integer)
    '            _HC_IDCLIENTE = value
    '        End Set
    '    End Property

    '    Public Property HC_NOMBRE1 As String
    '        Get
    '            Return _HC_NOMBRE1
    '        End Get
    '        Set(value As String)
    '            _HC_NOMBRE1 = value
    '        End Set
    '    End Property

    '    Public Property HC_NOMBRE2 As String
    '        Get
    '            Return _HC_NOMBRE2
    '        End Get
    '        Set(value As String)
    '            _HC_NOMBRE2 = value
    '        End Set
    '    End Property

    '    Public Property HC_APE_PAT As String
    '        Get
    '            Return _HC_APE_PAT
    '        End Get
    '        Set(value As String)
    '            _HC_APE_PAT = value
    '        End Set
    '    End Property


    '    Public Property HC_APE_MAT As String
    '        Get
    '            Return _HC_APE_MAT
    '        End Get
    '        Set(value As String)
    '            _HC_APE_MAT = value
    '        End Set
    '    End Property


    '    Public Property HC_APE_CASADA As String
    '        Get
    '            Return _HC_APE_CASADA
    '        End Get
    '        Set(value As String)
    '            _HC_APE_CASADA = value
    '        End Set
    '    End Property

    '    Public Property HC_TDOC As BE.AdmisionBE.SG_AD_TB_TIP_DOC_PER
    '        Get
    '            Return _HC_TDOC
    '        End Get
    '        Set(value As BE.AdmisionBE.SG_AD_TB_TIP_DOC_PER)
    '            _HC_TDOC = value
    '        End Set
    '    End Property

    '    Public Property HC_NDOC As String
    '        Get
    '            Return _HC_NDOC
    '        End Get
    '        Set(value As String)
    '            _HC_NDOC = value
    '        End Set
    '    End Property

    '    Public Property HC_FNAC As String
    '        Get
    '            Return _HC_FNAC
    '        End Get
    '        Set(value As String)
    '            _HC_FNAC = value
    '        End Set
    '    End Property

    '    Public Property HC_FING As String
    '        Get
    '            Return _HC_FING
    '        End Get
    '        Set(value As String)
    '            _HC_FING = value
    '        End Set
    '    End Property

    '    Public Property HC_SEXO As String
    '        Get
    '            Return _HC_SEXO
    '        End Get
    '        Set(value As String)
    '            _HC_SEXO = value
    '        End Set
    '    End Property

    '    Public Property HC_EST_CIVIL As Integer
    '        Get
    '            Return _HC_EST_CIVIL
    '        End Get
    '        Set(value As Integer)
    '            _HC_EST_CIVIL = value
    '        End Set
    '    End Property

    '    Public Property HC_DIR As String
    '        Get
    '            Return _HC_DIR
    '        End Get
    '        Set(value As String)
    '            _HC_DIR = value
    '        End Set
    '    End Property

    '    Public Property HC_OCUPACION As String
    '        Get
    '            Return _HC_OCUPACION
    '        End Get
    '        Set(value As String)
    '            _HC_OCUPACION = value
    '        End Set
    '    End Property

    '    Public Property HC_IDNACIONALIDAD As String
    '        Get
    '            Return _HC_IDNACIONALIDAD
    '        End Get
    '        Set(value As String)
    '            _HC_IDNACIONALIDAD = value
    '        End Set
    '    End Property

    '    Public Property HC_USUARIO As String
    '        Get
    '            Return _HC_USUARIO
    '        End Get
    '        Set(value As String)
    '            _HC_USUARIO = value
    '        End Set
    '    End Property

    '    Public Property HC_TERMINAL As String
    '        Get
    '            Return _HC_TERMINAL
    '        End Get
    '        Set(value As String)
    '            _HC_TERMINAL = value
    '        End Set
    '    End Property

    '    Public Property HC_FECREG As String
    '        Get
    '            Return _HC_FECREG
    '        End Get
    '        Set(value As String)
    '            _HC_FECREG = value
    '        End Set
    '    End Property

    'End Class

    Public Class SG_AD_TB_HISTO_CLINI

        Private _HC_NUM_HIST As System.Int32

        Public Property HC_NUM_HIST As System.Int32
            Get
                Return (_HC_NUM_HIST)
            End Get
            Set(ByVal value As System.Int32)
                _HC_NUM_HIST = value
            End Set
        End Property

        Private _HC_IDCLIENTE As System.Int32

        Public Property HC_IDCLIENTE As System.Int32
            Get
                Return (_HC_IDCLIENTE)
            End Get
            Set(ByVal value As System.Int32)
                _HC_IDCLIENTE = value
            End Set
        End Property

        Private _HC_TIPO_H_C As System.Int32
        Public Property HC_TIPO_H_C As System.Int32
            Get
                Return (_HC_TIPO_H_C)
            End Get
            Set(ByVal value As System.Int32)
                _HC_TIPO_H_C = value
            End Set
        End Property

        Private _HC_EDAD_REG As System.Int32
        Public Property HC_EDAD_REG As System.Int32
            Get
                Return (_HC_EDAD_REG)
            End Get
            Set(ByVal value As System.Int32)
                _HC_EDAD_REG = value
            End Set
        End Property

        Private _HC_NOMBRE1 As System.String

        Public Property HC_NOMBRE1 As System.String
            Get
                Return (_HC_NOMBRE1)
            End Get
            Set(ByVal value As System.String)
                _HC_NOMBRE1 = value
            End Set
        End Property

        Private _HC_NOMBRE2 As System.String

        Public Property HC_NOMBRE2 As System.String
            Get
                Return (_HC_NOMBRE2)
            End Get
            Set(ByVal value As System.String)
                _HC_NOMBRE2 = value
            End Set
        End Property

        Private _HC_APE_PAT As System.String

        Public Property HC_APE_PAT As System.String
            Get
                Return (_HC_APE_PAT)
            End Get
            Set(ByVal value As System.String)
                _HC_APE_PAT = value
            End Set
        End Property

        Private _HC_APE_MAT As System.String

        Public Property HC_APE_MAT As System.String
            Get
                Return (_HC_APE_MAT)
            End Get
            Set(ByVal value As System.String)
                _HC_APE_MAT = value
            End Set
        End Property

        Private _HC_APE_CASADA As System.String

        Public Property HC_APE_CASADA As System.String
            Get
                Return (_HC_APE_CASADA)
            End Get
            Set(ByVal value As System.String)
                _HC_APE_CASADA = value
            End Set
        End Property

        Private _HC_TDOC As System.Int32

        Public Property HC_TDOC As System.Int32
            Get
                Return (_HC_TDOC)
            End Get
            Set(ByVal value As System.Int32)
                _HC_TDOC = value
            End Set
        End Property

        Private _HC_NDOC As System.String

        Public Property HC_NDOC As System.String
            Get
                Return (_HC_NDOC)
            End Get
            Set(ByVal value As System.String)
                _HC_NDOC = value
            End Set
        End Property

        Private _HC_FNAC As System.DateTime

        Public Property HC_FNAC As System.DateTime
            Get
                Return (_HC_FNAC)
            End Get
            Set(ByVal value As System.DateTime)
                _HC_FNAC = value
            End Set
        End Property

        Private _HC_FING As System.DateTime

        Public Property HC_FING As System.DateTime
            Get
                Return (_HC_FING)
            End Get
            Set(ByVal value As System.DateTime)
                _HC_FING = value
            End Set
        End Property

        Private _HC_SEXO As System.String

        Public Property HC_SEXO As System.String
            Get
                Return (_HC_SEXO)
            End Get
            Set(ByVal value As System.String)
                _HC_SEXO = value
            End Set
        End Property

        Private _HC_EST_CIVIL As System.Int32

        Public Property HC_EST_CIVIL As System.Int32
            Get
                Return (_HC_EST_CIVIL)
            End Get
            Set(ByVal value As System.Int32)
                _HC_EST_CIVIL = value
            End Set
        End Property

        Private _HC_DIR As System.String

        Public Property HC_DIR As System.String
            Get
                Return (_HC_DIR)
            End Get
            Set(ByVal value As System.String)
                _HC_DIR = value
            End Set
        End Property

        Private _HC_OCUPACION As System.String

        Public Property HC_OCUPACION As System.String
            Get
                Return (_HC_OCUPACION)
            End Get
            Set(ByVal value As System.String)
                _HC_OCUPACION = value
            End Set
        End Property

        Private _HC_IDNACIONALIDAD As System.String

        Public Property HC_IDNACIONALIDAD As System.String
            Get
                Return (_HC_IDNACIONALIDAD)
            End Get
            Set(ByVal value As System.String)
                _HC_IDNACIONALIDAD = value
            End Set
        End Property

        Private _HC_USUARIO As System.String

        Public Property HC_USUARIO As System.String
            Get
                Return (_HC_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _HC_USUARIO = value
            End Set
        End Property

        Private _HC_TERMINAL As System.String

        Public Property HC_TERMINAL As System.String
            Get
                Return (_HC_TERMINAL)
            End Get
            Set(ByVal value As System.String)
                _HC_TERMINAL = value
            End Set
        End Property

        Private _HC_IDEMPRESA As System.Int32

        Public Property HC_IDEMPRESA As System.Int32
            Get
                Return (_HC_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _HC_IDEMPRESA = value
            End Set
        End Property

        Private _HC_UBIGEO As System.String

        Public Property HC_UBIGEO As System.String
            Get
                Return (_HC_UBIGEO)
            End Get
            Set(ByVal value As System.String)
                _HC_UBIGEO = value
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

        Private _HC_IDGRUPO_S As System.Int32

        Public Property HC_IDGRUPO_S As System.Int32
            Get
                Return (_HC_IDGRUPO_S)
            End Get
            Set(ByVal value As System.Int32)
                _HC_IDGRUPO_S = value
            End Set
        End Property

        Private _HC_IDCONDICION As System.Int32

        Public Property HC_IDCONDICION As System.Int32
            Get
                Return (_HC_IDCONDICION)
            End Get
            Set(ByVal value As System.Int32)
                _HC_IDCONDICION = value
            End Set
        End Property

        Private _HC_IDRECOMENDACION As System.Int32

        Public Property HC_IDRECOMENDACION As System.Int32
            Get
                Return (_HC_IDRECOMENDACION)
            End Get
            Set(ByVal value As System.Int32)
                _HC_IDRECOMENDACION = value
            End Set
        End Property

        Private _HC_IDMEDICO As System.String

        Public Property HC_IDMEDICO As System.String
            Get
                Return (_HC_IDMEDICO)
            End Get
            Set(ByVal value As System.String)
                _HC_IDMEDICO = value
            End Set
        End Property

        Private _HC_FNAC_TITU As System.DateTime

        Public Property HC_FNAC_TITU As System.DateTime
            Get
                Return (_HC_FNAC_TITU)
            End Get
            Set(ByVal value As System.DateTime)
                _HC_FNAC_TITU = value
            End Set
        End Property

        Private _HC_TITULAR As System.String

        Public Property HC_TITULAR As System.String
            Get
                Return (_HC_TITULAR)
            End Get
            Set(ByVal value As System.String)
                _HC_TITULAR = value
            End Set
        End Property

        Private _HC_UBICACION As System.Int32

        Public Property HC_UBICACION As System.Int32
            Get
                Return (_HC_UBICACION)
            End Get
            Set(ByVal value As System.Int32)
                _HC_UBICACION = value
            End Set
        End Property

        Private _HC_ALERGIAS As System.String

        Public Property HC_ALERGIAS As System.String
            Get
                Return (_HC_ALERGIAS)
            End Get
            Set(ByVal value As System.String)
                _HC_ALERGIAS = value
            End Set
        End Property

        Private _HC_DetRecom As System.String

        Public Property HC_DetRecom As System.String
            Get
                Return (_HC_DetRecom)
            End Get
            Set(ByVal value As System.String)
                _HC_DetRecom = value
            End Set
        End Property

        'Public Property HasRow As Boolean
        '    Get
        '        Return _HasRow
        '    End Get
        '    Set(ByVal value As Boolean)
        '        _HasRow = value
        '    End Set
        'End Property

    End Class

    Public Class SG_AD_TB_CONSULTORIO_MEDICO
        Private _CM_ID As System.Int32

        Public Property CM_ID As System.Int32
            Get
                Return (_CM_ID)
            End Get
            Set(ByVal value As System.Int32)
                _CM_ID = value
            End Set
        End Property

        Private _CM_DES_CORTA As System.String

        Public Property CM_DES_CORTA As System.String
            Get
                Return (_CM_DES_CORTA)
            End Get
            Set(ByVal value As System.String)
                _CM_DES_CORTA = value
            End Set
        End Property

        Private _CM_DESCRIPCION As System.String

        Public Property CM_DESCRIPCION As System.String
            Get
                Return (_CM_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _CM_DESCRIPCION = value
            End Set
        End Property

        Private _CM_USUARIO As System.String

        Public Property CM_USUARIO As System.String
            Get
                Return (_CM_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _CM_USUARIO = value
            End Set
        End Property

        Private _CM_PC As System.String

        Public Property CM_PC As System.String
            Get
                Return (_CM_PC)
            End Get
            Set(ByVal value As System.String)
                _CM_PC = value
            End Set
        End Property

        Private _CM_IDEMPRESA As System.Int32

        Public Property CM_IDEMPRESA As System.Int32
            Get
                Return (_CM_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _CM_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_SERVICIO_MEDICO

        Private _SM_ID As System.Int32

        Public Property SM_ID As System.Int32
            Get
                Return (_SM_ID)
            End Get
            Set(ByVal value As System.Int32)
                _SM_ID = value
            End Set
        End Property

        Private _SM_DESCRIPCION As System.String

        Public Property SM_DESCRIPCION As System.String
            Get
                Return (_SM_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _SM_DESCRIPCION = value
            End Set
        End Property

        Private _SM_ABREVIATURA As System.String

        Public Property SM_ABREVIATURA As System.String
            Get
                Return (_SM_ABREVIATURA)
            End Get
            Set(ByVal value As System.String)
                _SM_ABREVIATURA = value
            End Set
        End Property

        Private _SM_USUARIO As System.String

        Public Property SM_USUARIO As System.String
            Get
                Return (_SM_USUARIO)
            End Get
            Set(ByVal value As System.String)
                _SM_USUARIO = value
            End Set
        End Property

        Private _SM_TERMINAL As System.String

        Public Property SM_TERMINAL As System.String
            Get
                Return (_SM_TERMINAL)
            End Get
            Set(ByVal value As System.String)
                _SM_TERMINAL = value
            End Set
        End Property

        Private _SM_IDEMPRESA As System.Int32

        Public Property SM_IDEMPRESA As System.Int32
            Get
                Return (_SM_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _SM_IDEMPRESA = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_ESPECIALIDADES

        Private _ES_ID As System.Int32

        Public Property ES_ID As System.Int32
            Get
                Return (_ES_ID)
            End Get
            Set(ByVal value As System.Int32)
                _ES_ID = value
            End Set
        End Property

        Private _ES_DESCRIPCION As System.String

        Public Property ES_DESCRIPCION As System.String
            Get
                Return (_ES_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _ES_DESCRIPCION = value
            End Set
        End Property

        Private _ES_ABREVIATURA As System.String

        Public Property ES_ABREVIATURA As System.String
            Get
                Return (_ES_ABREVIATURA)
            End Get
            Set(ByVal value As System.String)
                _ES_ABREVIATURA = value
            End Set
        End Property

        Private _ES_IDEMPRESA As System.Int32

        Public Property ES_IDEMPRESA As System.Int32
            Get
                Return (_ES_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _ES_IDEMPRESA = value
            End Set
        End Property
        Private _ES_IDCC As System.String
        Public Property ES_IDCC As System.Int32
            Get
                Return (_ES_IDCC)
            End Get
            Set(ByVal value As System.Int32)
                _ES_IDCC = value
            End Set
        End Property

    End Class

    Public Class SG_AD_TB_CENTRO_COSTO
        Private _id As String
        Private _descripcion As String
        Private _abreviatura As String
        Private _idcc_conta As Integer
        Private _usuario As String
        Private _terminal As String
        Private _fecreg As Date
        Private _idempresa As Integer

        Public Sub New()
            _id = ""
            _descripcion = ""
            _abreviatura = ""
            _idcc_conta = 0
            _usuario = ""
            _terminal = ""
            _fecreg = Now
            _idempresa = 0
        End Sub
        Public Property id As String
            Get
                Return _id
            End Get
            Set(ByVal value As String)
                _id = value
            End Set
        End Property
        Public Property descripcion As String
            Get
                Return _descripcion
            End Get
            Set(ByVal value As String)
                _descripcion = value
            End Set
        End Property
        Public Property abreviatura As String
            Get
                Return _abreviatura
            End Get
            Set(ByVal value As String)
                _abreviatura = value
            End Set
        End Property
        Public Property idcc_conta As Integer
            Get
                Return _idcc_conta
            End Get
            Set(ByVal value As Integer)
                _idcc_conta = value
            End Set
        End Property
        Public Property usuario As String
            Get
                Return _usuario
            End Get
            Set(ByVal value As String)
                _usuario = value
            End Set
        End Property
        Public Property terminal As String
            Get
                Return _terminal
            End Get
            Set(ByVal value As String)
                _terminal = value
            End Set
        End Property
        Public Property fecreg As Date
            Get
                Return _fecreg
            End Get
            Set(ByVal value As Date)
                _fecreg = value
            End Set
        End Property
        Public Property idempresa As Integer
            Get
                Return _idempresa
            End Get
            Set(ByVal value As Integer)
                _idempresa = value
            End Set
        End Property
    End Class

    Public Class SG_AD_TB_MEDICA_RE
        Private _id As Integer
        Private _descripcion As String
        Private _idcat As Integer
        Private _compo_gene As String
        Private _presentacion As String
        Private _idarticulo As Integer
        Private _idempresa As Integer

        Public Sub New()
            _id = 0
            _descripcion = ""
            _idcat = 0
            _compo_gene = ""
            _presentacion = ""
            _idarticulo = 0
            _idempresa = 0
        End Sub

        Public Property id As Integer
            Get
                Return _id
            End Get
            Set(value As Integer)
                _id = value
            End Set
        End Property
        Public Property descripcion As String
            Get
                Return _descripcion
            End Get
            Set(value As String)
                _descripcion = value
            End Set
        End Property
        Public Property idcat As Integer
            Get
                Return _idcat
            End Get
            Set(value As Integer)
                _idcat = value
            End Set
        End Property
        Public Property compo_gene As String
            Get
                Return _compo_gene
            End Get
            Set(value As String)
                _compo_gene = value
            End Set
        End Property
        Public Property presentacion As String
            Get
                Return _presentacion
            End Get
            Set(value As String)
                _presentacion = value
            End Set
        End Property
        Public Property idarticulo As Integer
            Get
                Return _idarticulo
            End Get
            Set(value As Integer)
                _idarticulo = value
            End Set
        End Property
        Public Property idempresa As Integer
            Get
                Return _idempresa
            End Get
            Set(value As Integer)
                _idempresa = value
            End Set
        End Property
    End Class
End Class
