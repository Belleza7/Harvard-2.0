Public Class Form22
    Private Sub Form22_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox2.ImageLocation = "C:\Users\Batool\Desktop\college\civil.jfif"
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form17.Show()
    End Sub
End Class