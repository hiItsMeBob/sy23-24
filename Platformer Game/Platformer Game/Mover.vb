Imports Microsoft.VisualBasic.ApplicationServices

Public Class Mover
    Public Property Speed As Integer = 10
    Public Property itvl As Integer = 500
    Dim xdir As Integer = 1
    Dim ydir As Integer = 0
    Public Property Sprite As PictureBox

    Private Sub Mover_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
        Timer1.Interval = itvl
        Sprite.Left = Me.Left
        Sprite.Top = Me.Top

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Not Sprite Is Nothing Then
            Sprite.Left += xdir * Speed
            Sprite.Top += ydir * Speed
        End If
    End Sub
End Class
