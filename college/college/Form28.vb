Imports System.Data.OleDb
Public Class Form28

    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim count As Integer
    Dim str As String
    Dim inc, inc1, max_rows As Integer
    Dim c1, c2, c3 As String
    Dim idd As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        If inc <> max_rows Then
            TextBox1.Text = ds.Tables("teacher").Rows(inc).Item(0)
            TextBox2.Text = ds.Tables("teacher").Rows(inc).Item(1)
            TextBox3.Text = ds.Tables("teacher").Rows(inc).Item(2)
            TextBox11.Text = ds.Tables("teacher").Rows(inc).Item(8)
            TextBox5.Text = ds.Tables("teacher").Rows(inc).Item(6)
            TextBox10.Text = ds.Tables("teacher").Rows(inc).Item(7)
            TextBox6.Text = ds.Tables("teacher").Rows(inc).Item(10)
            TextBox8.Text = ds.Tables("teacher").Rows(inc).Item(9)
            TextBox7.Text = ds.Tables("teacher").Rows(inc).Item(4)
            TextBox4.Text = ds.Tables("teacher").Rows(inc).Item(3)
            TextBox9.Text = ds.Tables("teacher").Rows(inc).Item(5)
            inc = inc + 1
        Else
            MessageBox.Show("NO more rows")
        End If
        conn.Close()

    End Sub

    Private Sub Button8_Click_1(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(0)
        TextBox2.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(1)
        TextBox3.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(2)
        TextBox11.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(8)
        TextBox5.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(6)
        TextBox10.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(7)
        TextBox6.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(10)
        TextBox8.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(9)
        TextBox7.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(4)
        TextBox4.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(3)
        TextBox9.Text = ds.Tables("teacher").Rows(max_rows - 1).Item(5)
        conn.Close()



    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        If inc1 <> -1 Then
            TextBox1.Text = ds.Tables("teacher").Rows(inc1).Item(0)
            TextBox2.Text = ds.Tables("teacher").Rows(inc1).Item(1)
            TextBox3.Text = ds.Tables("teacher").Rows(inc1).Item(2)
            TextBox11.Text = ds.Tables("teacher").Rows(inc1).Item(8)
            TextBox5.Text = ds.Tables("teacher").Rows(inc1).Item(6)
            TextBox10.Text = ds.Tables("teacher").Rows(inc1).Item(7)
            TextBox6.Text = ds.Tables("teacher").Rows(inc1).Item(10)
            TextBox8.Text = ds.Tables("teacher").Rows(inc1).Item(9)
            TextBox7.Text = ds.Tables("teacher").Rows(inc1).Item(4)
            TextBox4.Text = ds.Tables("teacher").Rows(inc1).Item(3)
            TextBox9.Text = ds.Tables("teacher").Rows(inc1).Item(5)

            inc1 = inc1 - 1
        Else
            MessageBox.Show("NO more rows")
        End If
        conn.Close()

    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click

        TextBox1.Text = ds.Tables("teacher").Rows(0).Item(0)
        TextBox2.Text = ds.Tables("teacher").Rows(0).Item(1)
        TextBox3.Text = ds.Tables("teacher").Rows(0).Item(2)
        TextBox11.Text = ds.Tables("teacher").Rows(0).Item(8)

        TextBox5.Text = ds.Tables("teacher").Rows(0).Item(6)
        TextBox10.Text = ds.Tables("teacher").Rows(0).Item(7)
        TextBox6.Text = ds.Tables("teacher").Rows(0).Item(10)
        TextBox8.Text = ds.Tables("teacher").Rows(0).Item(9)
        TextBox7.Text = ds.Tables("teacher").Rows(0).Item(4)
        TextBox4.Text = ds.Tables("teacher").Rows(0).Item(3)
        TextBox9.Text = ds.Tables("teacher").Rows(0).Item(5)

    End Sub





    Private Sub Form28_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeacherDataSet7.teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.TeacherDataSet7.teacher)
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\teacher.mdb")
        conn.Open()
        cmd = New OleDbCommand("select * from teacher", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "teacher")
        reader = cmd.ExecuteReader()
        reader.Read()
        max_rows = ds.Tables("teacher").Rows.Count
        inc = 1
        inc1 = max_rows - 1
        TextBox1.Text = reader.GetValue(0)
        TextBox2.Text = reader.GetValue(1)
        TextBox3.Text = reader.GetValue(2)
        TextBox11.Text = reader.GetValue(8)
        TextBox5.Text = reader.GetValue(6)
        TextBox10.Text = reader.GetValue(7)
        TextBox6.Text = reader.GetValue(10)
        TextBox8.Text = reader.GetValue(9)
        TextBox7.Text = reader.GetValue(4)
        TextBox4.Text = reader.GetValue(3)
        TextBox9.Text = reader.GetValue(5)

    End Sub

End Class