Public Class Form19
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Hide()
        Form17.Show()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Form19_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.ImageLocation = "C:\Users\Batool\Desktop\college\elect.jfif"
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class