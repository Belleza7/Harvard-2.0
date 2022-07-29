Public Class Form10
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "C:\Users\Batool\Desktop\college\college\rel.jfif"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.ImageLocation = "C:\Users\Batool\Desktop\college\college\rel2.jfif"
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Label2.Text = "                 Instead of worshiping in wooden church pews, CrossFit has millennials jumping on top of wooden boxes 
    until exhaustion hits. The workout is not intended to replace church, but to build community." + vbCrLf + "Millennials, the generation of
    18- to 34-year-olds, are not practicing religion the same way their parents and grandparents did. According to a Pew Research Center 
    study, more than one-third of millennials are not affiliated with a religion, which is double the number of baby boomers who identify 
    as unaffiliated."
        Label3.Text = "                 We are offering a challenge, And this Is more of a challenge to the world 
             of religion, that … if you think religion Is dying, we are saying religion Is changing."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form14.Show()
        Form9.Hide()
    End Sub
End Class