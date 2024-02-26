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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.r1Label = New System.Windows.Forms.Label()
        Me.r2Label = New System.Windows.Forms.Label()
        Me.r3Label = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ReelControl3 = New SlotMachine.ReelControl()
        Me.ReelControl2 = New SlotMachine.ReelControl()
        Me.ReelControl1 = New SlotMachine.ReelControl()
        Me.SuspendLayout()
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "PiretChests.PNG")
        Me.ImageList1.Images.SetKeyName(1, "Apple.PNG")
        Me.ImageList1.Images.SetKeyName(2, "cherry.PNG")
        '
        'Timer1
        '
        Me.Timer1.Interval = 250
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(361, 308)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "SPIN!!!!"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'r1Label
        '
        Me.r1Label.AutoSize = True
        Me.r1Label.Location = New System.Drawing.Point(71, 110)
        Me.r1Label.Name = "r1Label"
        Me.r1Label.Size = New System.Drawing.Size(48, 16)
        Me.r1Label.TabIndex = 4
        Me.r1Label.Text = "Label1"
        '
        'r2Label
        '
        Me.r2Label.AutoSize = True
        Me.r2Label.Location = New System.Drawing.Point(372, 110)
        Me.r2Label.Name = "r2Label"
        Me.r2Label.Size = New System.Drawing.Size(48, 16)
        Me.r2Label.TabIndex = 5
        Me.r2Label.Text = "Label2"
        '
        'r3Label
        '
        Me.r3Label.AutoSize = True
        Me.r3Label.Location = New System.Drawing.Point(682, 110)
        Me.r3Label.Name = "r3Label"
        Me.r3Label.Size = New System.Drawing.Size(48, 16)
        Me.r3Label.TabIndex = 6
        Me.r3Label.Text = "Label3"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(68, 331)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(361, 47)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 8
        Me.Button3.Text = "1$"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(372, 28)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 16)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Label4"
        '
        'ReelControl3
        '
        Me.ReelControl3.itemValue = 1
        Me.ReelControl3.Location = New System.Drawing.Point(610, 139)
        Me.ReelControl3.Name = "ReelControl3"
        Me.ReelControl3.Size = New System.Drawing.Size(178, 173)
        Me.ReelControl3.spinTime = 5
        Me.ReelControl3.TabIndex = 12
        '
        'ReelControl2
        '
        Me.ReelControl2.itemValue = 0
        Me.ReelControl2.Location = New System.Drawing.Point(308, 129)
        Me.ReelControl2.Name = "ReelControl2"
        Me.ReelControl2.Size = New System.Drawing.Size(178, 173)
        Me.ReelControl2.spinTime = 5
        Me.ReelControl2.TabIndex = 11
        '
        'ReelControl1
        '
        Me.ReelControl1.itemValue = 2
        Me.ReelControl1.Location = New System.Drawing.Point(12, 129)
        Me.ReelControl1.Name = "ReelControl1"
        Me.ReelControl1.Size = New System.Drawing.Size(178, 173)
        Me.ReelControl1.spinTime = 5
        Me.ReelControl1.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReelControl3)
        Me.Controls.Add(Me.ReelControl2)
        Me.Controls.Add(Me.ReelControl1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.r3Label)
        Me.Controls.Add(Me.r2Label)
        Me.Controls.Add(Me.r1Label)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Timer2 As Timer
    Friend WithEvents Button1 As Button
    Friend WithEvents r1Label As Label
    Friend WithEvents r2Label As Label
    Friend WithEvents r3Label As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents ReelControl1 As ReelControl
    Friend WithEvents ReelControl2 As ReelControl
    Friend WithEvents ReelControl3 As ReelControl
End Class
