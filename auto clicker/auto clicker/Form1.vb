
Public Class Form1
    Public Const MOUSEEVENTF_LEFTDOWN = &H2
    Public Const MOUSEEVENTF_LEFTUP = &H4
    Private Const MOUSEEVENTF_RIGHTDOWN = &H8
    Private Const MOUSEEVENTF_RIGHTUP = &H10

    Declare Function apimouse_event Lib "user32.dll" Alias "mouse_event" (ByVal dwFlags As Int32, ByVal dX As Int32, ByVal dY As Int32, ByVal cButtons As Int32, ByVal dwExtraInfo As Int32) As Boolean
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (NumericUpDown1.Value > 0) Then
            MsgBox("Please position your mouse over the clicking position, then press enter to close this messagebox and continue.")
            For i As Integer = 0 To NumericUpDown1.Value - 1
                Call apimouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0)
                Call apimouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0)
            Next
        End If
    End Sub
End Class