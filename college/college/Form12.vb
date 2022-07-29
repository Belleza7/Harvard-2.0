Public Class Form12
    Private Sub Form12_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "C:\Users\Batool\Desktop\college\college\nodis.jfif"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label3.Text = "     As a Radcliffe fellow, Anthony Romero is working on a multimedia 
   research and visual art project that includes a collection of related but discrete works
   which attempt to articulate how indigenous populations,under European colonial rule in Australia, 
   South Asia, and the United States, were controlled through the criminalization and legislating
   of native sound and music practices."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form9.Hide()
        Form14.Show()
    End Sub
End Class