Public Class BoticaBE

    Public Class SG_BO_TB_ATENCION

        Private _AT_ID As System.Int32

        Public Property AT_ID As System.Int32
            Get
                Return (_AT_ID)
            End Get
            Set(ByVal value As System.Int32)
                _AT_ID = value
            End Set
        End Property

        Private _AT_IDCuenta As System.Int32

        Public Property AT_IDCuenta As System.Int32
            Get
                Return (_AT_IDCuenta)
            End Get
            Set(ByVal value As System.Int32)
                _AT_IDCuenta = value
            End Set
        End Property

        Private _AT_IDTipoDoc As System.String

        Public Property AT_IDTipoDoc As System.String
            Get
                Return (_AT_IDTipoDoc)
            End Get
            Set(ByVal value As System.String)
                _AT_IDTipoDoc = value
            End Set
        End Property

        Private _AT_Serie As System.Int32

        Public Property AT_Serie As System.Int32
            Get
                Return (_AT_Serie)
            End Get
            Set(ByVal value As System.Int32)
                _AT_Serie = value
            End Set
        End Property

        Private _AT_Numero As System.Int32

        Public Property AT_Numero As System.Int32
            Get
                Return (_AT_Numero)
            End Get
            Set(ByVal value As System.Int32)
                _AT_Numero = value
            End Set
        End Property

    End Class

End Class
