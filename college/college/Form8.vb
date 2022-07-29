Imports System.Data.OleDb
Public Class Form8
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim a As Integer


    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeacherDataSet11.teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.TeacherDataSet11.teacher)
        'TODO: This line of code loads data into the 'FeestDataSet1.fees_t' table. You can move, or remove it, as needed.
        Me.Fees_tTableAdapter.Fill(Me.FeestDataSet1.fees_t)




        Label2.Text = "M X INTEGRATED INSTUTIONAL AREA,(Near telephone exchange,MUMBAI-40008" + vbCrLf + "                        TEL:22345678,66789945 TELEFAX:223434324
 EMAIL:ideal_institute@rediffmail.com, ideal_institute@gmail.com, " + vbCrLf + "                       PROMOTED BY:NEW MILLENIUM EDUCATION SOCIETY"
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\teacher.mdb")
        conn.Open()
        a = InputBox("Enter you ID to view the details.")
        cmd = New OleDbCommand("select * from teacher where ID= '" & a & "'", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "teacher")
        TextBox4.DataBindings.Add("text", ds, "teacher.ID")
        TextBox8.DataBindings.Add("text", ds, "teacher.qual")
        TextBox7.DataBindings.Add("text", ds, "teacher.dob")
        TextBox6.DataBindings.Add("text", ds, "teacher.gender")
        TextBox1.DataBindings.Add("text", ds, "teacher.t_name")
        TextBox2.DataBindings.Add("text", ds, "teacher.f_name")
        TextBox3.DataBindings.Add("text", ds, "teacher.mob")
        TextBox5.DataBindings.Add("text", ds, "teacher.gender")

        TextBox11.DataBindings.Add("text", ds, "teacher.age")
        TextBox10.DataBindings.Add("text", ds, "teacher.address")
        TextBox12.DataBindings.Add("text", ds, "teacher.post")
        conn.Close()
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\feest.mdb")
        conn.Open()
        cmd = New OleDbCommand("select * from fees_t where ID = '" & a & "'", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "fees_t")
        TextBox9.DataBindings.Add("text", ds, "fees_t.fees")
        TextBox13.DataBindings.Add("text", ds, "fees_t.f_i_w")
        conn.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Hide()
        Form14.Show()
    End Sub
End Class