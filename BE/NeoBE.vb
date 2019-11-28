Public Class NeoBE

    Public Class SA_TB_BB_UBICACION

        Private _UB_ID As System.Int32

        Public Property UB_ID As System.Int32
            Get
                Return (_UB_ID)
            End Get
            Set(ByVal value As System.Int32)
                _UB_ID = value
            End Set
        End Property

        Private _UB_NOMBRE As System.String

        Public Property UB_NOMBRE As System.String
            Get
                Return (_UB_NOMBRE)
            End Get
            Set(ByVal value As System.String)
                _UB_NOMBRE = value
            End Set
        End Property

        Private _UB_IDTIPO As System.Int32

        Public Property UB_IDTIPO As System.Int32
            Get
                Return (_UB_IDTIPO)
            End Get
            Set(ByVal value As System.Int32)
                _UB_IDTIPO = value
            End Set
        End Property

        Private _UB_IDARTICULO As System.Int32

        Public Property UB_IDARTICULO As System.Int32
            Get
                Return (_UB_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _UB_IDARTICULO = value
            End Set
        End Property

        Private _UB_IDEMPRESA As System.Int32

        Public Property UB_IDEMPRESA As System.Int32
            Get
                Return (_UB_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _UB_IDEMPRESA = value
            End Set
        End Property

        Private _UB_ESTADO As System.Int32

        Public Property UB_ESTADO As System.Int32
            Get
                Return (_UB_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _UB_ESTADO = value
            End Set
        End Property

    End Class

    Public Class SA_TB_BB_TIPO_UBI

        Private _TI_ID As System.Int32

        Public Property TI_ID As System.Int32
            Get
                Return (_TI_ID)
            End Get
            Set(ByVal value As System.Int32)
                _TI_ID = value
            End Set
        End Property

        Private _TI_DESCRIPCION As System.String

        Public Property TI_DESCRIPCION As System.String
            Get
                Return (_TI_DESCRIPCION)
            End Get
            Set(ByVal value As System.String)
                _TI_DESCRIPCION = value
            End Set
        End Property

    End Class

    Public Class SA_TB_BB_REGISTRO

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

        Private _RE_IDCUENTA As System.Int32

        Public Property RE_IDCUENTA As System.Int32
            Get
                Return (_RE_IDCUENTA)
            End Get
            Set(ByVal value As System.Int32)
                _RE_IDCUENTA = value
            End Set
        End Property

        Private _RE_IDMEDICO As System.String

        Public Property RE_IDMEDICO As System.String
            Get
                Return (_RE_IDMEDICO)
            End Get
            Set(ByVal value As System.String)
                _RE_IDMEDICO = value
            End Set
        End Property

        Private _RE_DIAGNOSTICO As System.String

        Public Property RE_DIAGNOSTICO As System.String
            Get
                Return (_RE_DIAGNOSTICO)
            End Get
            Set(ByVal value As System.String)
                _RE_DIAGNOSTICO = value
            End Set
        End Property

        Private _RE_OBSERVACION As System.String

        Public Property RE_OBSERVACION As System.String
            Get
                Return (_RE_OBSERVACION)
            End Get
            Set(ByVal value As System.String)
                _RE_OBSERVACION = value
            End Set
        End Property

        Private _RE_PESO As System.Double

        Public Property RE_PESO As System.Double
            Get
                Return (_RE_PESO)
            End Get
            Set(ByVal value As System.Double)
                _RE_PESO = value
            End Set
        End Property

        Private _RE_TALLA As System.Double

        Public Property RE_TALLA As System.Double
            Get
                Return (_RE_TALLA)
            End Get
            Set(ByVal value As System.Double)
                _RE_TALLA = value
            End Set
        End Property

        Private _RE_MADRE As System.String

        Public Property RE_MADRE As System.String
            Get
                Return (_RE_MADRE)
            End Get
            Set(ByVal value As System.String)
                _RE_MADRE = value
            End Set
        End Property

        Private _RE_FEC_REG As System.DateTime

        Public Property RE_FEC_REG As System.DateTime
            Get
                Return (_RE_FEC_REG)
            End Get
            Set(ByVal value As System.DateTime)
                _RE_FEC_REG = value
            End Set
        End Property

        Private _RE_IDEMPRESA As System.Int32

        Public Property RE_IDEMPRESA As System.Int32
            Get
                Return (_RE_IDEMPRESA)
            End Get
            Set(ByVal value As System.Int32)
                _RE_IDEMPRESA = value
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

        Private _RE_IDGRUPO_SANG As System.Int32

        Public Property RE_IDGRUPO_SANG As System.Int32
            Get
                Return (_RE_IDGRUPO_SANG)
            End Get
            Set(ByVal value As System.Int32)
                _RE_IDGRUPO_SANG = value
            End Set
        End Property

        Private _RE_FECHA_INGRESO As System.DateTime

        Public Property RE_FECHA_INGRESO As System.DateTime
            Get
                Return (_RE_FECHA_INGRESO)
            End Get
            Set(ByVal value As System.DateTime)
                _RE_FECHA_INGRESO = value
            End Set
        End Property

        Private _RE_FECHA_ALTA As System.DateTime

        Public Property RE_FECHA_ALTA As System.DateTime
            Get
                Return (_RE_FECHA_ALTA)
            End Get
            Set(ByVal value As System.DateTime)
                _RE_FECHA_ALTA = value
            End Set
        End Property
    End Class

    Public Class SA_TB_BB_CONSUMO

        Private _CB_IDREGISTRO As System.Int32

        Public Property CB_IDREGISTRO As System.Int32
            Get
                Return (_CB_IDREGISTRO)
            End Get
            Set(ByVal value As System.Int32)
                _CB_IDREGISTRO = value
            End Set
        End Property

        Private _CB_ITEM As System.Int32

        Public Property CB_ITEM As System.Int32
            Get
                Return (_CB_ITEM)
            End Get
            Set(ByVal value As System.Int32)
                _CB_ITEM = value
            End Set
        End Property

        Private _CB_IDARTICULO As System.Int32

        Public Property CB_IDARTICULO As System.Int32
            Get
                Return (_CB_IDARTICULO)
            End Get
            Set(ByVal value As System.Int32)
                _CB_IDARTICULO = value
            End Set
        End Property

        Private _CB_IDUBICACION As System.Int32

        Public Property CB_IDUBICACION As System.Int32
            Get
                Return (_CB_IDUBICACION)
            End Get
            Set(ByVal value As System.Int32)
                _CB_IDUBICACION = value
            End Set
        End Property

        Private _CB_FECHA As System.DateTime

        Public Property CB_FECHA As System.DateTime
            Get
                Return (_CB_FECHA)
            End Get
            Set(ByVal value As System.DateTime)
                _CB_FECHA = value
            End Set
        End Property

        Private _CB_HORA_INI As System.String

        Public Property CB_HORA_INI As System.String
            Get
                Return (_CB_HORA_INI)
            End Get
            Set(ByVal value As System.String)
                _CB_HORA_INI = value
            End Set
        End Property

        Private _CB_HORA_FIN As System.String

        Public Property CB_HORA_FIN As System.String
            Get
                Return (_CB_HORA_FIN)
            End Get
            Set(ByVal value As System.String)
                _CB_HORA_FIN = value
            End Set
        End Property

        Private _CB_OBSERVACION As System.String

        Public Property CB_OBSERVACION As System.String
            Get
                Return (_CB_OBSERVACION)
            End Get
            Set(ByVal value As System.String)
                _CB_OBSERVACION = value
            End Set
        End Property

        Private _CB_ESTADO As System.Int32

        Public Property CB_ESTADO As System.Int32
            Get
                Return (_CB_ESTADO)
            End Get
            Set(ByVal value As System.Int32)
                _CB_ESTADO = value
            End Set
        End Property

        Private _CB_FECREG As System.DateTime

        Public Property CB_FECREG As System.DateTime
            Get
                Return (_CB_FECREG)
            End Get
            Set(ByVal value As System.DateTime)
                _CB_FECREG = value
            End Set
        End Property

        Private _CB_CANTIDAD As System.Int32

        Public Property CB_CANTIDAD As System.Int32
            Get
                Return (_CB_CANTIDAD)
            End Get
            Set(ByVal value As System.Int32)
                _CB_CANTIDAD = value
            End Set
        End Property

        Private _CB_TOTAL_HORAS As System.String

        Public Property CB_TOTAL_HORAS As System.String
            Get
                Return (_CB_TOTAL_HORAS)
            End Get
            Set(ByVal value As System.String)
                _CB_TOTAL_HORAS = value
            End Set
        End Property
    End Class

End Class

