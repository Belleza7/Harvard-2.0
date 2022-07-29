Public Class Form11
    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        PictureBox1.ImageLocation = "C:\Users\Batool\Desktop\college\college\pubdef.jpg"
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        Label3.Text = "                The new movement of public defenders in Russia, equipped with 
only basic legal training and scant resources, has been eagerly confronting the Russian judicial 
system to protect the human rights ofpolitical prisoners and people jailed for legitimate
political protest. " + vbCrLf +
 "                        The speaker is a graduate of the Public Defender School, a grassroots educational 
project organized by the Russia Behind Bars foundation in collaboration with the Sakharov Center. 
She works together with Human Rights groups OVD-Info and Public Verdict."
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form9.Hide()
        Me.Hide()
        Form14.Show()
    End Sub
End Class