
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
    Private Sub RightAngryTmr_Tick(sender As Object, e As EventArgs) Handles RightAngryTmr.Tick
        PictureBox2.Left += moveSpeed
        PictureBox8.Left += moveSpeed
        PictureBox5.Left += moveSpeed
        PictureBox10.Left += moveSpeed
        PictureBox1.Left += moveSpeed
        PictureBox7.Left += moveSpeed
        PictureBox4.Left += moveSpeed
        PictureBox9.Left += moveSpeed
        PicSpikeWall.Left += moveSpeed
    End Sub
    Private Sub LeftAngryTmr_Tick(sender As Object, e As EventArgs) Handles LeftAngryTmr.Tick
        PictureBox2.Left += moveSpeed
        PictureBox8.Left += moveSpeed
        PictureBox5.Left += moveSpeed
        PictureBox10.Left += moveSpeed
        PictureBox1.Left += moveSpeed
        PictureBox7.Left += moveSpeed
        PictureBox4.Left += moveSpeed
        PictureBox9.Left += moveSpeed
        PicSpikeWall.Left += moveSpeed
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
        TextBox1.Select()
        Timer1.Start()

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

        If Picplayer.Bounds.IntersectsWith(PictureBox4.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(PictureBox5.Bounds) Then
            TmrGrav.Stop()
        End If
        If Picplayer.Bounds.IntersectsWith(PicSpikeWall.Bounds) Then
            Me.Close()
        End If

        If Picplayer.Bounds.IntersectsWith(PicCoin.Bounds) Then
            CoinLabel.Text = ("1-1")
            PicCoin.Visible = False
            LeftAngryTmr.Enabled = True
            up.Enabled = True

        End If
        If Picplayer.Bounds.IntersectsWith(EndPic.Bounds) Then
            Me.BackColor = Color.Green
            Picair.BackColor = Color.Green
            PictureBox1.BackColor = Color.Green
            PictureBox2.BackColor = Color.Green
            PictureBox4.BackColor = Color.Green
            PictureBox5.BackColor = Color.Green
            wallpic.BackColor = Color.Green
            Wallpic2.BackColor = Color.Green
            EndPic.Visible = False
            TextBox1.Visible = True
            ENDTMR.Start()
            Timer1.Stop()
            Timer2.Stop()

        End If
        If Picplayer.Bounds.IntersectsWith(Angrypic.Bounds) Then
            Me.BackColor = Color.Red
            Picair.BackColor = Color.Red
            PictureBox1.BackColor = Color.Red
            PictureBox2.BackColor = Color.Red
            PictureBox4.BackColor = Color.Red
            PictureBox5.BackColor = Color.Red
            PictureBox10.BackColor = Color.Red
            PictureBox5.BackColor = Color.Red
            PictureBox7.BackColor = Color.Red
            PictureBox9.BackColor = Color.Red
            PictureBox8.BackColor = Color.Red
            PicGround.BackColor = Color.Red
            cloud.BackColor = Color.Red
            cloud1.BackColor = Color.Red
            cloud2.BackColor = Color.Red
            cloud3.BackColor = Color.Red
            wallpic.BackColor = Color.Red
            Wallpic2.BackColor = Color.Red
            PicCoin.Visible = False
            EndPic.Visible = False
            TextBox2.Visible = True
            Timer1.Stop()
            Timer2.Stop()
            ENDTMR.Start()
        End If


        For Each b As Control In Me.Controls
            If TypeOf b Is PictureBox Then
                If b.Tag = "bound" Then
                    If Picplayer.Bounds.IntersectsWith(b.Bounds) Then
                        TmrGrav.Stop()
                    End If
                End If
            End If

            If Angrypic.Bounds.IntersectsWith(wallpic.Bounds) Then
                Timer2.Start()
                Timer1.Stop()
                TmrLeft.Stop()

            End If
            If Angrypic.Bounds.IntersectsWith(Wallpic2.Bounds) Then
                Timer1.Start()
                Timer2.Stop()
                tmrRight.Stop()
            End If
        Next

    End Sub

    Private Sub tmrGravity_Tick(sender As Object, e As EventArgs) Handles TmrGrav.Tick
        Picplayer.Top += moveSpeed
    End Sub

    Private Sub up_Tick(sender As Object, e As EventArgs) Handles up.Tick
        cloud.Top += moveSpeed
        cloud1.Top += moveSpeed
        cloud2.Top += moveSpeed
        cloud3.Top += moveSpeed
    End Sub

    Private Sub ENDTMR_Tick(sender As Object, e As EventArgs) Handles ENDTMR.Tick
        Me.Close()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Angrypic.Left -= 5
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Angrypic.Left += 5
    End Sub


End Class





' Hello This Is my first 200 lined code game 