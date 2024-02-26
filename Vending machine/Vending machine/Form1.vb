Public Class Form1
    Dim WithEvents CS As New CoinSlot


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click, Button7.Click
        CS.InsetQuorter()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click, Button8.Click
        CS.InsetDimes()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click, Button9.Click
        CS.InsetNickles()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click, Button10.Click
        CS.InsetDollor()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CS.Insetcent()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CS.coinreturn()
        Label1.Text = CS.Total.ToString("C2")
    End Sub

    Private Sub CS_coinReternEvent(d As Integer, q As Integer, dm As Integer, n As Integer, c As Integer) Handles CS.coinReternEvent
        If d > 0 Then
            DollarPictureBox.Visible = True
        Else
            DollarPictureBox.Visible = False
        End If

        If q > 0 Then
            QuorterPictureBox.Visible = True
        Else
            QuorterPictureBox.Visible = False
        End If

        If dm > 0 Then
            NicklePictureBox.Visible = True
        Else
            NicklePictureBox.Visible = False
        End If

        If n > 0 Then
            DimePictureBox.Visible = True
        Else
            DimePictureBox.Visible = False
        End If

        If c > 0 Then
            CentPictureBox.Visible = True
        Else
            CentPictureBox.Visible = False
        End If
    End Sub

    Private Sub BuyButton_Click(sender As Object, e As EventArgs) Handles BuyButton.Click




    End Sub
End Class

