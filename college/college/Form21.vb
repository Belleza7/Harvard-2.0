Public Class Form21
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)
        Me.Hide()
        Form17.Show()
    End Sub

    Private Sub Form21_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.ImageLocation = "C:\Users\Batool\Desktop\college\if.jfif"
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub
End Class