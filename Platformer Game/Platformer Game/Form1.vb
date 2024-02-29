
Public Class Form1
    Dim moveSpeed As Integer = 15
    Dim isJumping As Boolean
    Private Sub frm2DPlatformer_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        Select Case e.KeyCode
            Case Keys.D
                tmrRight.Start()
            Case Keys.A
                TmrLeft.Start()
            Case Keys.W
                TmrUp.Start()
                isJumping = True
        End Select
    End Sub

    Private Sub tmrRight_Tick(sender As Object, e As EventArgs) Handles tmrRight.Tick
        Picplayer.Left += moveSpeed
    End Sub

    Private Sub frm2Dplatformer_KeyUp(sender As Object, e As KeyEventArgs) Handles Me.KeyUp
        Select Case e.KeyCode
            Case Keys.D
                tmrRight.Stop()
            Case Keys.A
                TmrLeft.Stop()
            Case Keys.W
                TmrUp.Stop()
                isJumping = False
        End Select
    End Sub

    Private Sub tmrLeft_Tick(sender As Object, e As EventArgs) Handles TmrLeft.Tick
        Picplayer.Left -= moveSpeed
    End Sub

    Private Sub tmrUp_Tick(sender As Object, e As EventArgs) Handles TmrUp.Tick
        Picplayer.Top -= moveSpeed
    End Sub

    Private Sub frm2Dplatformer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tmrGameLogic.Start()
    End Sub

    Private Sub tmrGameLogic_Tick(sender As Object, e As EventArgs) Handles tmrGameLogic.Tick
        If Picplayer.Bounds.IntersectsWith(Picair.Bounds) Then
            If isJumping = False Then
                TmrGrav.Start()
            End If
        ElseIf Picplayer.Bounds.IntersectsWith(PicGround.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(PictureBox1.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(PictureBox2.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(PictureBox3.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(TextBox1.Bounds) Then
            Me.Close()
        End If
        If Picplayer.Bounds.IntersectsWith(PicSpikeWall.Bounds) Then
            Me.Close()
        End If
        If Picplayer.Bounds.IntersectsWith(PicCoin.Bounds) Then
            CoinLabel.Text = (+1)
            PicCoin.Visible = False
        End If
        If Picplayer.Bounds.IntersectsWith(EndPic.Bounds) Then
            Me.BackColor = Color.Green
            Picair.BackColor = Color.Green
            PictureBox1.BackColor = Color.Green
            PictureBox2.BackColor = Color.Green
            PictureBox3.BackColor = Color.Green
            PictureBox4.BackColor = Color.Green
            PictureBox5.BackColor = Color.Green
            TextBox1.Visible = True

        End If

        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGrav.Stop()
                    End If
                End If
            End If

        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGrav.Tick
        Picplayer.Top += moveSpeed
    End Sub

  
End Class
