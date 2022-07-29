Imports System.Data.OleDb
Public Class Form13
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim count As Integer
    Dim str As String

    Dim c1, c2, c3 As String
    Dim ra As Integer




    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet11.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDataSet11.student)

        ComboBox1.Items.Add("FEMALE")
        ComboBox1.Items.Add("MALE")
        ComboBox2.Items.Add("COMPUTER")
        ComboBox2.Items.Add("INFORMATION TECHNOLOGY")
        ComboBox2.Items.Add("MECHANICAL")
        ComboBox2.Items.Add("ELECTRICAL")
        ComboBox2.Items.Add("ELECTRONICS")
        ComboBox2.Items.Add("CIVIL")
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\student.mdb")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form17.Show()
        Me.Hide()

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conn.Open()
        c3 = InputBox("Enter ID of student whose records needs to be deleted.")
        If MessageBox.Show("DO YOU REALLY WANT TO DELETE THIS RECORD?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            MsgBox("OPERATIION CANCELED")
            Exit Sub
        End If
        cmd = New OleDbCommand("delete from student where ID='" & c3 & "'", conn)
        ra = cmd.ExecuteNonQuery()
        MsgBox("RECORD DELETED")
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form14.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click

        conn.Open()
        c3 = InputBox("Enter ID of student whose records needs to be updated.")
        c1 = ComboBox1.SelectedItem.ToString()
        c2 = ComboBox2.SelectedItem.ToString()
        str = "update student set ID='" & TextBox1.Text & "' , Dob='" & TextBox2.Text & "',gender='" & c1 & "',age=" & CInt(TextBox4.Text) & ",mob_no='" & TextBox7.Text & "',
address='" & TextBox9.Text & "',s_name='" & TextBox5.Text & "',dept=
'" & c2 & "',batch=" & CInt(TextBox3.Text) & ",m_name='" & TextBox8.Text & "',f_name='" & TextBox6.Text & "'
 where ID ='" & c3 & "'"
        cmd = New OleDbCommand(str, conn)
        ra = cmd.ExecuteNonQuery()
        MsgBox(ra & " record updated")
        conn.Close()

    End Sub









    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        StudentBindingSource.EndEdit()
        StudentTableAdapter.Update(StudentDataSet11.student)
        MsgBox("RECORD IS SAVED")

    End Sub
End Class