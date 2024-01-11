
Public Class Form1

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
End Class



