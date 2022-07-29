Public Class Form15
    Private Sub Form15_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Panel1.Visible = True
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel1.Visible = False
        Panel2.Visible = True
        Panel3.Visible = False
        Panel4.Visible = False
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = False
        Panel4.Visible = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Panel1.Visible = False
        Panel2.Visible = False
        Panel3.Visible = True

        Panel4.Visible = False
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "An era of darkness" Or TextBox1.Text = "The guide" Or TextBox1.Text = "The god of small things" Or TextBox1.Text = "Narcopolis" Then
            MsgBox("Book is Present.")
            Me.Hide()
            Form27.Show()
        Else
            MsgBox("Book is not Present.")
        End If
    End Sub
End Class