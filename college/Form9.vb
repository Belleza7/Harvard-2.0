Public Class Form9


    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Label2.Text = "             Harvard University possesses the title of America's oldest learning institution, founded in 1636. 
     At its inception, this university's name was New College,and its purpose was mainly to educate clergy. In 1639, the school's
     name became Harvard University, so named for the Rev. John Harvard. Harvard bequeathed half of his estate and his entire library
     to the school upon his death. This significant bequest led the school to honor him by taking his name."
        PictureBox1.Image = Image.FromFile("C:\Users\MM COMPUTER\Desktop\his1.jfif")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label1.Text = "             Harvard University is a private Ivy League research university in Cambridge, Massachusetts,
     with about 6,800 undergraduate students and about 14,000 postgraduate students. Established in 1636 and named for its first
     benefactor, clergyman John Harvard, Harvard is the United States' oldest institution of higher learning.[7] Its history, 
     influence, wealth, and academic reputation have made it one of the most prestigious universities in the world."
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        Form10.Show()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        form11.show()
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        form12.show()
    End Sub

    Private Sub TabPage2_Click(sender As Object, e As EventArgs) Handles TabPage2.Click


    End Sub

    Private Sub TabPage5_Click(sender As Object, e As EventArgs) Handles TabPage5.Click

    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.CheckedChanged


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form14.Show()
    End Sub
End Class