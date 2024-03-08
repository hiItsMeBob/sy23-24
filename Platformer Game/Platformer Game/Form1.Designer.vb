<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.tmrRight = New System.Windows.Forms.Timer(Me.components)
        Me.TmrLeft = New System.Windows.Forms.Timer(Me.components)
        Me.TmrUp = New System.Windows.Forms.Timer(Me.components)
        Me.tmrGameLogic = New System.Windows.Forms.Timer(Me.components)
        Me.TmrGrav = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CoinLabel = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.RightAngryTmr = New System.Windows.Forms.Timer(Me.components)
        Me.LeftAngryTmr = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox10 = New System.Windows.Forms.PictureBox()
        Me.PictureBox9 = New System.Windows.Forms.PictureBox()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.cloud = New System.Windows.Forms.PictureBox()
        Me.PicSpikeWall = New System.Windows.Forms.PictureBox()
        Me.PicCoin = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.EndPic = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Picplayer = New System.Windows.Forms.PictureBox()
        Me.Picair = New System.Windows.Forms.PictureBox()
        Me.PicGround = New System.Windows.Forms.PictureBox()
        Me.up = New System.Windows.Forms.Timer(Me.components)
        Me.ENDTMR = New System.Windows.Forms.Timer(Me.components)
        Me.cloud2 = New System.Windows.Forms.PictureBox()
        Me.cloud1 = New System.Windows.Forms.PictureBox()
        Me.cloud3 = New System.Windows.Forms.PictureBox()
        Me.Angrypic = New System.Windows.Forms.PictureBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.wallpic = New System.Windows.Forms.PictureBox()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Wallpic2 = New System.Windows.Forms.PictureBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cloud, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicSpikeWall, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicCoin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EndPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cloud2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cloud1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cloud3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Angrypic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wallpic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Wallpic2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tmrRight
        '
        Me.tmrRight.Enabled = True
        Me.tmrRight.Interval = 60
        '
        'TmrLeft
        '
        Me.TmrLeft.Interval = 60
        '
        'TmrUp
        '
        Me.TmrUp.Interval = 60
        '
        'tmrGameLogic
        '
        Me.tmrGameLogic.Interval = 50
        '
        'TmrGrav
        '
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "COINS:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(69, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 16)
        Me.Label2.TabIndex = 12
        '
        'CoinLabel
        '
        Me.CoinLabel.AutoSize = True
        Me.CoinLabel.Location = New System.Drawing.Point(75, 9)
        Me.CoinLabel.Name = "CoinLabel"
        Me.CoinLabel.Size = New System.Drawing.Size(25, 16)
        Me.CoinLabel.TabIndex = 13
        Me.CoinLabel.Text = "0-1"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Yellow
        Me.TextBox1.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(15, 37)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(433, 204)
        Me.TextBox1.TabIndex = 15
        Me.TextBox1.Text = "YOU WINN!!!!!"
        Me.TextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox1.Visible = False
        '
        'RightAngryTmr
        '
        Me.RightAngryTmr.Interval = 60
        '
        'LeftAngryTmr
        '
        Me.LeftAngryTmr.Interval = 60
        '
        'PictureBox10
        '
        Me.PictureBox10.BackColor = System.Drawing.Color.Lime
        Me.PictureBox10.Location = New System.Drawing.Point(827, 83)
        Me.PictureBox10.Name = "PictureBox10"
        Me.PictureBox10.Size = New System.Drawing.Size(173, 10)
        Me.PictureBox10.TabIndex = 20
        Me.PictureBox10.TabStop = False
        '
        'PictureBox9
        '
        Me.PictureBox9.BackColor = System.Drawing.Color.Lime
        Me.PictureBox9.Location = New System.Drawing.Point(1048, 196)
        Me.PictureBox9.Name = "PictureBox9"
        Me.PictureBox9.Size = New System.Drawing.Size(173, 10)
        Me.PictureBox9.TabIndex = 19
        Me.PictureBox9.TabStop = False
        '
        'PictureBox8
        '
        Me.PictureBox8.BackColor = System.Drawing.Color.Lime
        Me.PictureBox8.Location = New System.Drawing.Point(595, 196)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(173, 10)
        Me.PictureBox8.TabIndex = 18
        Me.PictureBox8.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.BackColor = System.Drawing.Color.Lime
        Me.PictureBox7.Location = New System.Drawing.Point(827, 311)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(173, 10)
        Me.PictureBox7.TabIndex = 17
        Me.PictureBox7.TabStop = False
        '
        'cloud
        '
        Me.cloud.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cloud.Location = New System.Drawing.Point(100, 65)
        Me.cloud.Name = "cloud"
        Me.cloud.Size = New System.Drawing.Size(191, 28)
        Me.cloud.TabIndex = 16
        Me.cloud.TabStop = False
        '
        'PicSpikeWall
        '
        Me.PicSpikeWall.BackColor = System.Drawing.Color.Red
        Me.PicSpikeWall.Location = New System.Drawing.Point(1341, 12)
        Me.PicSpikeWall.Name = "PicSpikeWall"
        Me.PicSpikeWall.Size = New System.Drawing.Size(112, 441)
        Me.PicSpikeWall.TabIndex = 14
        Me.PicSpikeWall.TabStop = False
        '
        'PicCoin
        '
        Me.PicCoin.Image = Global.Platformer_Game.My.Resources.Resources.PXLCoin
        Me.PicCoin.Location = New System.Drawing.Point(868, 27)
        Me.PicCoin.Name = "PicCoin"
        Me.PicCoin.Size = New System.Drawing.Size(100, 50)
        Me.PicCoin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicCoin.TabIndex = 11
        Me.PicCoin.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox5.Location = New System.Drawing.Point(827, 83)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(173, 33)
        Me.PictureBox5.TabIndex = 8
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox4.Location = New System.Drawing.Point(1048, 196)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(173, 33)
        Me.PictureBox4.TabIndex = 7
        Me.PictureBox4.TabStop = False
        '
        'EndPic
        '
        Me.EndPic.Image = Global.Platformer_Game.My.Resources.Resources.PiretChests
        Me.EndPic.Location = New System.Drawing.Point(1341, 336)
        Me.EndPic.Name = "EndPic"
        Me.EndPic.Size = New System.Drawing.Size(100, 62)
        Me.EndPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EndPic.TabIndex = 6
        Me.EndPic.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox2.Location = New System.Drawing.Point(595, 196)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(173, 33)
        Me.PictureBox2.TabIndex = 4
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Yellow
        Me.PictureBox1.Location = New System.Drawing.Point(827, 311)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(173, 33)
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'Picplayer
        '
        Me.Picplayer.BackColor = System.Drawing.Color.Red
        Me.Picplayer.Location = New System.Drawing.Point(123, 336)
        Me.Picplayer.Name = "Picplayer"
        Me.Picplayer.Size = New System.Drawing.Size(48, 43)
        Me.Picplayer.TabIndex = 0
        Me.Picplayer.TabStop = False
        '
        'Picair
        '
        Me.Picair.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Picair.Location = New System.Drawing.Point(0, -3)
        Me.Picair.Name = "Picair"
        Me.Picair.Size = New System.Drawing.Size(1489, 405)
        Me.Picair.TabIndex = 1
        Me.Picair.TabStop = False
        '
        'PicGround
        '
        Me.PicGround.BackColor = System.Drawing.Color.Green
        Me.PicGround.Location = New System.Drawing.Point(0, 401)
        Me.PicGround.Name = "PicGround"
        Me.PicGround.Size = New System.Drawing.Size(1453, 52)
        Me.PicGround.TabIndex = 2
        Me.PicGround.TabStop = False
        '
        'up
        '
        '
        'ENDTMR
        '
        Me.ENDTMR.Interval = 5000
        '
        'cloud2
        '
        Me.cloud2.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cloud2.Location = New System.Drawing.Point(511, 140)
        Me.cloud2.Name = "cloud2"
        Me.cloud2.Size = New System.Drawing.Size(191, 28)
        Me.cloud2.TabIndex = 21
        Me.cloud2.TabStop = False
        '
        'cloud1
        '
        Me.cloud1.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cloud1.Location = New System.Drawing.Point(632, 27)
        Me.cloud1.Name = "cloud1"
        Me.cloud1.Size = New System.Drawing.Size(191, 28)
        Me.cloud1.TabIndex = 22
        Me.cloud1.TabStop = False
        '
        'cloud3
        '
        Me.cloud3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.cloud3.Location = New System.Drawing.Point(43, 187)
        Me.cloud3.Name = "cloud3"
        Me.cloud3.Size = New System.Drawing.Size(191, 28)
        Me.cloud3.TabIndex = 23
        Me.cloud3.TabStop = False
        '
        'Angrypic
        '
        Me.Angrypic.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Angrypic.Location = New System.Drawing.Point(1183, 388)
        Me.Angrypic.Name = "Angrypic"
        Me.Angrypic.Size = New System.Drawing.Size(100, 50)
        Me.Angrypic.TabIndex = 24
        Me.Angrypic.TabStop = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 1
        '
        'wallpic
        '
        Me.wallpic.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.wallpic.Location = New System.Drawing.Point(0, 257)
        Me.wallpic.Name = "wallpic"
        Me.wallpic.Size = New System.Drawing.Size(16, 196)
        Me.wallpic.TabIndex = 25
        Me.wallpic.TabStop = False
        '
        'Timer2
        '
        Me.Timer2.Interval = 1
        '
        'Wallpic2
        '
        Me.Wallpic2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Wallpic2.Location = New System.Drawing.Point(1430, 257)
        Me.Wallpic2.Name = "Wallpic2"
        Me.Wallpic2.Size = New System.Drawing.Size(23, 196)
        Me.Wallpic2.TabIndex = 26
        Me.Wallpic2.TabStop = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Red
        Me.TextBox2.Font = New System.Drawing.Font("MS Reference Sans Serif", 48.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(15, 37)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(433, 204)
        Me.TextBox2.TabIndex = 27
        Me.TextBox2.Text = "YOU LOSE :("
        Me.TextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.TextBox2.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1453, 450)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Wallpic2)
        Me.Controls.Add(Me.wallpic)
        Me.Controls.Add(Me.Angrypic)
        Me.Controls.Add(Me.cloud3)
        Me.Controls.Add(Me.cloud1)
        Me.Controls.Add(Me.cloud2)
        Me.Controls.Add(Me.PictureBox10)
        Me.Controls.Add(Me.PictureBox9)
        Me.Controls.Add(Me.PictureBox8)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.cloud)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PicSpikeWall)
        Me.Controls.Add(Me.CoinLabel)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PicCoin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.EndPic)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Picplayer)
        Me.Controls.Add(Me.Picair)
        Me.Controls.Add(Me.PicGround)
        Me.Name = "Form1"
        Me.Text = "a"
        CType(Me.PictureBox10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cloud, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicSpikeWall, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicCoin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EndPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picplayer, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Picair, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PicGround, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cloud2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cloud1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cloud3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Angrypic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wallpic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Wallpic2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Picplayer As PictureBox
    Friend WithEvents Picair As PictureBox
    Friend WithEvents PicGround As PictureBox
    Friend WithEvents tmrRight As Timer
    Friend WithEvents TmrLeft As Timer
    Friend WithEvents TmrUp As Timer
    Friend WithEvents tmrGameLogic As Timer
    Friend WithEvents TmrGrav As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents EndPic As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PicCoin As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CoinLabel As Label
    Friend WithEvents PicSpikeWall As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents cloud As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents PictureBox9 As PictureBox
    Friend WithEvents PictureBox10 As PictureBox
    Friend WithEvents RightAngryTmr As Timer
    Friend WithEvents LeftAngryTmr As Timer
    Friend WithEvents up As Timer
    Friend WithEvents ENDTMR As Timer
    Friend WithEvents cloud2 As PictureBox
    Friend WithEvents cloud1 As PictureBox
    Friend WithEvents cloud3 As PictureBox
    Friend WithEvents Angrypic As PictureBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents wallpic As PictureBox
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Wallpic2 As PictureBox
    Friend WithEvents TextBox2 As TextBox
End Class
