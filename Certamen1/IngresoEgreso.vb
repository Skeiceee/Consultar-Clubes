Public Class IngresoEgreso

    Protected _id As Integer
    Protected _nombre As String
    Protected _detalle As String
    Protected _fecha As Date
    Protected _monto As Integer
    Protected _IDTipoMovimiento As Integer
    Protected _IDClub As Integer

    Public Property ID As Integer
        Get
            Return _id
        End Get
        Set(value As Integer)
            _id = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Detalle As String
        Get
            Return _detalle
        End Get
        Set(value As String)
            _detalle = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property
    Public Property Monto As Integer
        Get
            Return _monto
        End Get
        Set(value As Integer)
            _monto = value
        End Set
    End Property
    Public Property IDTipoMovimiento As Integer
        Get
            Return _IDTipoMovimiento
        End Get
        Set(value As Integer)
            _IDTipoMovimiento = value
        End Set
    End Property

    Public Property IDClub As Integer
        Get
            Return _IDClub
        End Get
        Set(value As Integer)
            _IDClub = value
        End Set
    End Property

End Class
