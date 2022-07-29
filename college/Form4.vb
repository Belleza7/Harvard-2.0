Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.Image = Image.FromFile("CC:\Users\MM COMPUTER\Desktop\teacher.png")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        ComboBox1.Items.Add("FEMALE")
        ComboBox1.Items.Add("MALE")
        ComboBox2.Items.Add("COMPUTER")
        ComboBox2.Items.Add("INFORMATION TECHNOLOGY")
        ComboBox2.Items.Add("MECHANICAL")
        ComboBox2.Items.Add("ELECTRICAL")
        ComboBox2.Items.Add("ELECTRONICS")
        ComboBox2.Items.Add("CIVIL")

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form14.Show()
    End Sub
End Class