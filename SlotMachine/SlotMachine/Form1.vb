Imports System.Reflection.Emit
Imports System.Threading

Public Class Form1
    Dim dollars As Integer

    Dim cs As New CoinSlot
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        ReelControl1.Spin()
        ReelControl2.Spin()
        ReelControl3.Spin()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        r1Label.Text = ReelControl1.itemValue
        r2Label.Text = ReelControl2.itemValue
        r3Label.Text = ReelControl3.itemValue

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cs.InsetDollor()
        Label4.Text = cs.Total.ToString("c2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If dollars >= 1 Then
            dollars -= 1
            r1Label.Text = dollars.ToString("c2")
            ReelControl1.Spin()
            ReelControl2.Spin()
            ReelControl3.Spin()
            r1Label.Text = ReelControl1.itemValue
            r2Label.Text = ReelControl2.itemValue
            r3Label.Text = ReelControl3.itemValue
        End If
        If ReelControl1.itemValue = ReelControl2.itemValue And
         ReelControl2.itemValue = ReelControl3.itemValue Then
            r2Label.Text = "WIN"
        Else
            r2Label.Text = "LOSE"
        End If
    End Sub
End Class

