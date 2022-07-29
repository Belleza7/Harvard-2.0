Imports System.Data.OleDb
Public Class form3
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim str, str1 As String
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FeesDataSet2.fees' table. You can move, or remove it, as needed.
        Me.FeesTableAdapter.Fill(Me.FeesDataSet2.fees)

        'TODO: This line of code loads data into the 'StudentDataSet8.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDataSet8.student)

        PictureBox1.Image = Image.FromFile("C:\Users\Batool\Desktop\college\stud.png")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\student.mdb")

        conn.Open()

        str = InputBox("Enter your ID")
        cmd = New OleDbCommand("select * from student where ID='" & str & "'", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "student")
        TextBox1.DataBindings.Add("text", ds, "student.ID")

        TextBox2.DataBindings.Add("text", ds, "student.f_name")
        TextBox3.DataBindings.Add("text", ds, "student.batch")
        TextBox6.DataBindings.Add("text", ds, "student.Dob")
        TextBox10.DataBindings.Add("text", ds, "student.s_name")
        TextBox7.DataBindings.Add("text", ds, "student.m_name")
        TextBox11.DataBindings.Add("text", ds, "student.dept")
        TextBox5.DataBindings.Add("text", ds, "student.mob_no")
        TextBox9.DataBindings.Add("text", ds, "student.gender")
        conn.Close()


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str1 = "insert into fees values('" & TextBox1.Text & "','" & TextBox4.Text & "','" & TextBox8.Text & "')"
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\fees.mdb")
        conn.Open()
        cmd = New OleDbCommand(str1, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "fees")
        cmd.ExecuteNonQuery()
        conn.Close()

        MsgBox("Details Submitted Successfully")
        Me.Hide()
        Form14.Show()
    End Sub


End Class