Imports System.Data.OleDb
Public Class form2
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet

    Dim str As String

    Dim c1, c2, c3 As String
    Dim count As Integer
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeacherDataSet5.teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.TeacherDataSet5.teacher)

        PictureBox1.Image = Image.FromFile("C:\Users\Batool\Desktop\college\teacher.png")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        ComboBox1.Items.Add("FEMALE")
        ComboBox1.Items.Add("MALE")
        ComboBox2.Items.Add("COMPUTER")
        ComboBox2.Items.Add("INFORMATION TECHNOLOGY")
        ComboBox2.Items.Add("MECHANICAL")
        ComboBox2.Items.Add("ELECTRICAL")
        ComboBox2.Items.Add("ELECTRONICS")
        ComboBox2.Items.Add("CIVIL")
        ComboBox3.Items.Add("HOD")
        ComboBox3.Items.Add("FACULTY")
        ComboBox3.Items.Add("CLERK")
        ComboBox3.Items.Add("CO-WORKER")
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\teacher.mdb")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn.Open()
        c2 = ComboBox1.SelectedItem.ToString()
        c3 = ComboBox2.SelectedItem.ToString()
        c1 = ComboBox3.SelectedItem.ToString()
        str = "insert into teacher values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & c2 & "',
" & CInt(TextBox4.Text) & ",'" & TextBox6.Text & "','" & TextBox9.Text & "','" & TextBox5.Text & "',
'" & c3 & "','" & c1 & "','" & TextBox7.Text & "',
'" & TextBox3.Text & "')"
        cmd = New OleDbCommand(str, conn)
        count = cmd.ExecuteNonQuery()
        MsgBox(count & " Details Submitted Successfully")
        conn.Close()
        Me.Hide()
        Form5.Show()
    End Sub
    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating
        If TextBox1.Text = "" Then
            ErrorProvider1.SetError(TextBox1, "This field data is compulsory")
            e.Cancel = True

        Else
            ErrorProvider1.SetError(TextBox1, "")
        End If
    End Sub
    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating
        Dim expression As New System.Text.RegularExpressions.Regex("(0[1-9]|1[012])[-./](0[1-9]|12[0-9]|3[01])[-/.](19|20)\d\d")
        If expression.IsMatch(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "")
        Else
            ErrorProvider1.SetError(TextBox2, "Not a valid date ")
        End If

    End Sub
    Private Sub TextBox4_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox4.Validating
        If TextBox4.Text = "" Then
            ErrorProvider1.SetError(TextBox4, "This field data is compulsory")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox4, "")
        End If
    End Sub
    Private Sub TextBox6_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox6.Validating
        If TextBox6.Text = "" Then
            ErrorProvider1.SetError(TextBox6, "This field data is compulsory")
            e.Cancel = True
        End If
        If Not TextBox6.TextLength = 10 Then
            ErrorProvider1.SetError(TextBox6, "The mobile no must be of 10 digits.")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox6, "")
        End If
    End Sub

    Private Sub TextBox9_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox9.Validating
        If TextBox9.Text = "" Then
            ErrorProvider1.SetError(TextBox9, "This field data is compulsory")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox9, "")
        End If
    End Sub
    Private Sub TextBox5_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox5.Validating
        If TextBox5.Text = "" Then
            ErrorProvider1.SetError(TextBox5, "This field data is compulsory")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox5, "")
        End If
    End Sub
    Private Sub TextBox7_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox7.Validating
        If TextBox7.Text = "" Then
            ErrorProvider1.SetError(TextBox7, "This field data is compulsory")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox7, "")
        End If
    End Sub
    Private Sub TextBox3_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox3.Validating
        If TextBox3.Text = "" Then
            ErrorProvider1.SetError(TextBox3, "This field data is compulsory")
            e.Cancel = True
        Else
            ErrorProvider1.SetError(TextBox3, "")
        End If
    End Sub
End Class
