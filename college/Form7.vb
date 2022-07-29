Public Class Form7
    Private Sub Form7_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = "                                             Cambridge, MA, United States" + vbCrLf + "                        TEL:22345678,66789945 TELEFAX:223434324
 EMAIL:Havard_institute@rediffmail.com, Havard_institute@gmail.com, " + vbCrLf + "                       PROMOTED BY:NEW MILLENIUM EDUCATION SOCIETY"
    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form14.Show()
    End Sub
End Class