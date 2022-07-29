Imports System.Data.OleDb
Public Class Form4
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim str, str1 As String
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FeestDataSet.fees_t' table. You can move, or remove it, as needed.
        Me.Fees_tTableAdapter.Fill(Me.FeestDataSet.fees_t)
        'TODO: This line of code loads data into the 'TeacherDataSet8.teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.TeacherDataSet8.teacher)
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\teacher.mdb")
        conn.Open()
        PictureBox1.Image = Image.FromFile("C:\Users\Batool\Desktop\college\teacher.png")
        PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage


        str = InputBox("Enter your ID")
        cmd = New OleDbCommand("select * from teacher where ID='" & str & "'", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "teacher")
        TextBox11.DataBindings.Add("text", ds, "teacher.ID")
        TextBox2.DataBindings.Add("text", ds, "teacher.qual")
        TextBox3.DataBindings.Add("text", ds, "teacher.age")
        TextBox6.DataBindings.Add("text", ds, "teacher.dob")
        TextBox10.DataBindings.Add("text", ds, "teacher.t_name")
        TextBox7.DataBindings.Add("text", ds, "teacher.post")
        TextBox1.DataBindings.Add("text", ds, "teacher.dept")

        TextBox5.DataBindings.Add("text", ds, "teacher.mob")
        TextBox9.DataBindings.Add("text", ds, "teacher.gender")
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        str1 = "insert into fees_t values('" & TextBox11.Text & "','" & TextBox4.Text & "','" & TextBox8.Text & "')"
        conn = New OleDbConnection("Provider = Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\feest.mdb")
        conn.Open()
        cmd = New OleDbCommand(str1, conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "fees_t")
        cmd.ExecuteNonQuery()
        MsgBox("Details submitted successfully.")
        conn.Close()

        Me.Hide()
        Form14.Show()
    End Sub
End Class