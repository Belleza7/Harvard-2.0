Imports System.Data.OleDb
Public Class Form6
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim a As String
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'FeesDataSet3.fees' table. You can move, or remove it, as needed.
        Me.FeesTableAdapter.Fill(Me.FeesDataSet3.fees)
        'TODO: This line of code loads data into the 'StudentDataSet10.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDataSet10.student)
        Label2.Text = "                                             Cambridge, MA, United States" + vbCrLf + "                        TEL:22345678,66789945 TELEFAX:223434324
 EMAIL:Havard_institute@rediffmail.com, Havard_institute@gmail.com, " + vbCrLf + "                       PROMOTED BY:NEW MILLENIUM EDUCATION SOCIETY"
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\student.mdb")
        conn.Open()
        a = InputBox("Enter you ID to view the details.")
        cmd = New OleDbCommand("select * from student where ID = '" & a & "'", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "student")
        TextBox1.DataBindings.Add("text", ds, "student.ID")
        TextBox8.DataBindings.Add("text", ds, "student.s_name")
        TextBox7.DataBindings.Add("text", ds, "student.Dob")
        TextBox4.DataBindings.Add("text", ds, "student.gender")
        TextBox3.DataBindings.Add("text", ds, "student.age")
        TextBox5.DataBindings.Add("text", ds, "student.mob_no")
        TextBox2.DataBindings.Add("text", ds, "student.batch")
        TextBox9.DataBindings.Add("text", ds, "student.m_name")

        TextBox6.DataBindings.Add("text", ds, "student.f_name")
        TextBox10.DataBindings.Add("text", ds, "student.dept")
        TextBox13.DataBindings.Add("text", ds, "student.address")
        conn.Close()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\fees.mdb")
        conn.Open()
        cmd = New OleDbCommand("select * from fees where ID = '" & a & "'", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "fees")
        TextBox11.DataBindings.Add("text", ds, "fees.fees")
        TextBox14.DataBindings.Add("text", ds, "fees.f_i_w")
        conn.Close()


    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form14.Show()
    End Sub
End Class