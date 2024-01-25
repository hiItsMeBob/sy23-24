Imports System.IO
Imports System.Web

Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub WaternooseButton1_Click(sender As Object, e As EventArgs) Handles WaternooseButton1.Click
        WaternoosePictureBox1.Visible = True
        JamesPictureBox2.Visible = False
        MikePictureBox3.Visible = False
        YetiPictureBox4.Visible = False
        Fld1.Text = "Henry J. Waternoose III"
        Fld2.Text = "James P.Sullivan"
        Fld3.Text = "N/A"
        Fld4.Text = "Boss"
        Fld5.Text = "Initially, Mr. Waternoose has a calm and fatherly personality and has always been on good terms with Sulley and Mike. He has an affable and boisterous personality, especially when he is excited. However, he is only driven to villainy out of desperation to keep Monsters, Inc. afloat in the midst of the energy crisis (unlike Randall, whose jealousy towards Sulley gives him more of a villainous motivation). Mr. Waternoose becomes more villainous as this drive and desperation strip away his morals and he is determined to not let anything stop what he thinks will be the best way for the company to keep going, never taking into account looking for other energy resources.Despite his actions, Mr. Waternoose still has a good chance at redemption as he was simply trying to save Monstropolis from the energy crisis, as well as being Randall's minion in the plot."
    End Sub

    Private Sub JamesButton2_Click(sender As Object, e As EventArgs) Handles JamesButton2.Click
        JamesPictureBox2.Visible = True
        WaternoosePictureBox1.Visible = False
        MikePictureBox3.Visible = False
        YetiPictureBox4.Visible = False
        Fld1.Text = "James P.Sullivan"
        Fld2.Text = "Mike Wazowski"
        Fld3.Text = "100,021"
        Fld4.Text = "Scarer"
        Fld5.Text = "Sulley was born to famous scarer Bill Sullivan and an unnamed Sulley's Mom. His father cared deeply about the family's reputation, and put a lot of pressure onto Sulley to live up to the family name as a scarer."
    End Sub

    Private Sub MikeWazowskiButton3_Click(sender As Object, e As EventArgs) Handles MikeWazowskiButton3.Click
        JamesPictureBox2.Visible = False
        WaternoosePictureBox1.Visible = False
        MikePictureBox3.Visible = True
        YetiPictureBox4.Visible = False
        Fld1.Text = "Mike Wazowski"
        Fld2.Text = "James P.Sullivan"
        Fld3.Text = "7"
        Fld4.Text = "Jokester"
        Fld5.Text = "In Monsters, Inc., Mike and Sulley are at each other's throats sometimes; however, it is usually Mike who gets annoyed by Sulley first. He is funny, smart, and brave, but can sometimes fail to see the obvious in a situation. He's also a very caring and dedicated friend, never going through with abandoning Sulley, no matter what. In Monsters University, Mike was vaguely the same but, due to his youth, he had richer determination and planned to become a Scarer in MU's prestigious Scaring Program. As a child, he'd been overlooked for being smaller than everyone but was inspired by Scarer Frank McCay to become one himself. With hard work and studying, he was accepted into MU and confidently strove to succeed. Unfortunately, Mike's shame of not being scary came back to affect him following the games' conclusion, where, determined to prove everyone wrong, Mike stole a key into the door lab and entered the human world to scare a child, only to realize the hard way, that Sulley and Hardscarbble had been right when the children aren't scared of him at all. but became joker for Monsters Inc"
    End Sub
    Private Sub YetiButton4_Click(sender As Object, e As EventArgs) Handles YetiButton4.Click
        JamesPictureBox2.Visible = False
        WaternoosePictureBox1.Visible = False
        MikePictureBox3.Visible = False
        YetiPictureBox4.Visible = True

        'Timer1.Enabled = True
        'eggTextBox.Visible = True

        MsgBox("Most Data Was Lost, Would You Like To Continue?")
        Fld1.Text = "All Data Deleted"
        Fld2.Text = "All Data Deleted"
        Fld3.Text = "All Data Deleted"
        Fld4.Text = "All Data Deleted"
        Fld5.Text = "The Yeti is a monster who worked at ___=====++-__++-+, Inc. until he got __--__-__--_ to the Himalayas by Water___---__-_ for discovering letters regarding the latter's involvement with the ____+=++++=___  ___==++-__. Despite being ____----__-_-__, he likes living in the human world."
    End Sub

    'To this point you do not need this code, it was just an adding a most recent search. You will need to add 4 buttons to use 


    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        Fld1.Text = ""
        Fld2.Text = ""
        Fld3.Text = ""
        Fld4.Text = ""
        Fld5.Text = ""
        WaternoosePictureBox1.Image = Nothing
        current = count
        count = count + 1
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles WaternoosePictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        WaternoosePictureBox1.Load(OpenFileDialog1.FileName)
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem2.Click
        SaveToFile()
    End Sub
    Sub SaveToFile()
        Dim r As String
        r += Fld1.Text
        r += "|"
        r += Fld2.Text
        r += "|"
        r += Fld3.Text
        r += "|"
        r += Fld4.Text
        r += "|"
        r += Fld5.Text
        r += "|"
        r += WaternoosePictureBox1.ImageLocation
        If count = 0 Then count = 1
        records(current) = r

        Dim outFile As New StreamWriter("data.txt")
        For index = 0 To count - 1
            outFile.WriteLine(records(index))
        Next
        outFile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("data.txt") Then
            Dim inFile As New StreamReader("data.txt")
            While (Not inFile.EndOfStream)
                records(count) = inFile.ReadLine
                count = count + 1
            End While
            inFile.Close()
            ShowRecord(0)
        End If
    End Sub
    Public Sub ShowRecord(index As Integer)
        WaternoosePictureBox1.Image = Nothing
        If records(index) <> Nothing Then
            Dim Fields() As String
            Fields = records(index).Split("|")
            Fld1.Text = Fields(0)
            Fld2.Text = Fields(1)
            Fld3.Text = Fields(2)
            Fld4.Text = Fields(3)
            Fld5.Text = Fields(4)
            If File.Exists(Fields(5)) Then
                WaternoosePictureBox1.Load(Fields(5))
            End If
        End If
    End Sub

    Private Sub FirstButton_Click(sender As Object, e As EventArgs) Handles FirstButton.Click
        SaveToFile()
        current = 0
        ShowRecord(current)
    End Sub

    Private Sub PrevButton_Click(sender As Object, e As EventArgs) Handles PrevButton.Click
        SaveToFile()
        If current > 0 Then
            current = current - 1
        End If
        ShowRecord(current)
    End Sub

    Private Sub NextButton_Click(sender As Object, e As EventArgs) Handles NextButton.Click
        SaveToFile()
        If current < count - 1 Then
            current = current + 1
        End If
        ShowRecord(current)
    End Sub

    Private Sub LastButton_Click(sender As Object, e As EventArgs) Handles LastButton.Click
        SaveToFile()
        If count > 0 Then
            current = count - 1
            ShowRecord(current)
        End If
    End Sub
End Class