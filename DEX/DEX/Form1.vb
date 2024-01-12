
Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Dim Records(50) As String

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
        Fld2.Text = "Mike Wazowski"
        Fld3.Text = "7"
        Fld4.Text = "Jokester"
        Fld5.Text = "In Monsters, Inc., Mike and Sulley are at each other's throats sometimes; however, it is usually Mike who gets annoyed by Sulley first. He is funny, smart, and brave, but can sometimes fail to see the obvious in a situation. He's also a very caring and dedicated friend, never going through with abandoning Sulley, no matter what. In Monsters University, Mike was vaguely the same but, due to his youth, he had richer determination and planned to become a Scarer in MU's prestigious Scaring Program. As a child, he'd been overlooked for being smaller than everyone but was inspired by Scarer Frank McCay to become one himself. With hard work and studying, he was accepted into MU and confidently strove to succeed. Unfortunately, Mike's shame of not being scary came back to affect him following the games' conclusion, where, determined to prove everyone wrong, Mike stole a key into the door lab and entered the human world to scare a child, only to realize the hard way, that Sulley and Hardscarbble had been right when the children aren't scared of him at all. And now is just a joker"
    End Sub
    Private Sub YetiButton4_Click(sender As Object, e As EventArgs) Handles YetiButton4.Click
        JamesPictureBox2.Visible = False
        WaternoosePictureBox1.Visible = False
        MikePictureBox3.Visible = False
        YetiPictureBox4.Visible = True
        MsgBox("Most Data Was Lost, Would You Like To Continue?")
        Fld1.Text = "All Data Deleted"
        Fld2.Text = "All Data Deleted"
        Fld3.Text = "All Data Deleted"
        Fld4.Text = "All Data Deleted"
        Fld5.Text = "The Yeti is a monster who worked at ___=====++-__++-+, Inc. until he got __--__-__--_ to the Himalayas by Water___---__-_ for discovering letters regarding the latter's involvement with the ____+=++++=___  ___==++-__. Despite being ____----__-_-__, he likes living in the human world."
    End Sub

    Private Sub NewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem1.Click
        WaternoosePictureBox1.Image = Nothing
        Fld1.Text = ""
        Fld2.Text = ""
        Fld3.Text = ""
        Fld4.Text = ""
        Fld5.Text = ""
    End Sub

    Private Sub WaternoosePictureBox1_Click(sender As Object, e As EventArgs) Handles WaternoosePictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub
    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        WaternoosePictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
    Private Sub SaveToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem2.Click
        Dim outFile As New IO.StreamWriter("Data.txt")
        outFile.Write(Fld1.Text)
        outFile.Write("|")
        outFile.Write(Fld2.Text)
        outFile.Write("|")
        outFile.Write(Fld3.Text)
        outFile.Write("|")
        outFile.Write(Fld4.Text)
        outFile.Write("|")
        outFile.Write(Fld5.Text)
        outFile.Write("|")
        outFile.Write(WaternoosePictureBox1.ImageLocation)
        outFile.WriteLine()
        outFile.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim infile As New StreamReader("Data.txt")
            Records(0) = infile.ReadLine
            Records(1) = infile.ReadLine
            infile.Close()
        End If
    End Sub
End Class



