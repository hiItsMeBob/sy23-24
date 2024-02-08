Public Class CoinSlot
    Public Property Nickles As Integer
    Public Property Quortors As Integer
    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Public ReadOnly Property Total As Decimal
        Get
            Return Dollars + Quortors * 0.25 + Dimes * 0.1 + Nickles * 0.5
        End Get
    End Property
    Public Sub InsetNickles()
        Nickles = Nickles + 1
    End Sub
    Public Sub InsetQuorter()
        Quortors = Quortors + 1
    End Sub
    Public Sub InsetDimes()
        Dimes = Dimes + 1
    End Sub
    Public Sub InsetDollor()
        Dollars = Dollars + 1
    End Sub
End Class
