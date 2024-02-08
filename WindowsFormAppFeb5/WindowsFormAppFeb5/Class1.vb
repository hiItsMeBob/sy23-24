Public Class Clicker
    Public Property Count As Integer
    Public Property increment As Integer = 1
    Public Sub click()
        Count = Count + increment
    End Sub
    Public Sub click2()
        Count = Count + increment
    End Sub
    Public Sub click3()
        Count = Count + increment
    End Sub

    Public Sub reset()
        Count = 0
    End Sub
End Class
