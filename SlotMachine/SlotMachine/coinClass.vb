Public Class CoinSlot

    Public Event coinReternEvent(d As Integer, q As Integer, dm As Integer, n As Integer, c As Integer)
    Public Property Nickles As Integer
    Public Property Quortors As Integer

    Public Property Dimes As Integer
    Public Property Dollars As Integer
    Public Property cent As Integer
    Dim _Total As Decimal
    Public ReadOnly Property Total As Decimal
        Get
            _Total = Dollars + Quortors * 0.25 + Dimes * 0.1 + Nickles * 0.5 + cent * 0.1
            Return _Total
        End Get

    End Property
    Public Sub coinreturn()
        RaiseEvent coinReternEvent(Dollars, Quortors, Dimes, Nickles, cent)
        Quortors = 0
        Dimes = 0
        Dollars = 0
        Nickles = 0
        cent = 0

    End Sub


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
    Public Sub Insetcent()
        cent = cent + 1
    End Sub

End Class



