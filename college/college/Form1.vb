Public Class Form1






    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "C:\Users\Batool\Desktop\college\college\sym.png"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        PictureBox2.ImageLocation = "C:\Users\Batool\Desktop\college\back.png"
        PictureBox2.SizeMode = PictureBoxSizeMode.StretchImage
        Timer1.Start()

    End Sub




    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label1.Location.X + Label1.Width < 0 Then
            Label1.Location = New Point(Me.Width, Label1.Location.Y)
        Else
            Label1.Location = New Point(Label1.Location.X - 5, Label1.Location.Y)
        End If



    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Form24.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Form25.Show()
        Me.Hide()



    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
