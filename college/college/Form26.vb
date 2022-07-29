Imports System.Data.OleDb
Public Class Form26
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim count As Integer
    Dim str As String
    Dim inc, inc1, max_rows As Integer
    Private Sub Form26_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StudentDataSet4.student' table. You can move, or remove it, as needed.
        Me.StudentTableAdapter.Fill(Me.StudentDataSet4.student)
        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\student.mdb")
        conn.Open()
        cmd = New OleDbCommand("select * from student", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "student")
        reader = cmd.ExecuteReader()
        reader.Read()

        TextBox1.Text = reader.GetValue(0)
        TextBox2.Text = reader.GetValue(1)
        TextBox11.Text = reader.GetValue(2)
        TextBox8.Text = reader.GetValue(3)
        TextBox5.Text = reader.GetValue(4)
        TextBox10.Text = reader.GetValue(5)
        TextBox6.Text = reader.GetValue(6)
        TextBox9.Text = reader.GetValue(7)
        TextBox7.Text = reader.GetValue(8)
        TextBox3.Text = reader.GetValue(9)
        TextBox4.Text = reader.GetValue(10)
        max_rows = ds.Tables("student").Rows.Count
        inc = 1
        inc1 = max_rows - 1

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        TextBox1.Text = ds.Tables("student").Rows(max_rows - 1).Item(0)
        TextBox2.Text = ds.Tables("student").Rows(max_rows - 1).Item(1)
        TextBox11.Text = ds.Tables("student").Rows(max_rows - 1).Item(2)
        TextBox8.Text = ds.Tables("student").Rows(max_rows - 1).Item(3)
        TextBox5.Text = ds.Tables("student").Rows(max_rows - 1).Item(4)
        TextBox10.Text = ds.Tables("student").Rows(max_rows - 1).Item(5)
        TextBox6.Text = ds.Tables("student").Rows(max_rows - 1).Item(6)
        TextBox9.Text = ds.Tables("student").Rows(max_rows - 1).Item(7)
        TextBox7.Text = ds.Tables("student").Rows(max_rows - 1).Item(8)
        TextBox3.Text = ds.Tables("student").Rows(max_rows - 1).Item(9)
        TextBox4.Text = ds.Tables("student").Rows(max_rows - 1).Item(10)
        conn.Close()

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TextBox1.Text = ds.Tables("student").Rows(0).Item(0)
        TextBox2.Text = ds.Tables("student").Rows(0).Item(1)
        TextBox11.Text = ds.Tables("student").Rows(0).Item(2)
        TextBox8.Text = ds.Tables("student").Rows(0).Item(3)
        TextBox5.Text = ds.Tables("student").Rows(0).Item(4)
        TextBox10.Text = ds.Tables("student").Rows(0).Item(5)
        TextBox6.Text = ds.Tables("student").Rows(0).Item(6)
        TextBox9.Text = ds.Tables("student").Rows(0).Item(7)
        TextBox7.Text = ds.Tables("student").Rows(0).Item(8)
        TextBox3.Text = ds.Tables("student").Rows(0).Item(9)
        TextBox4.Text = ds.Tables("student").Rows(0).Item(10)
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form24.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If inc1 <> -1 Then
            TextBox1.Text = ds.Tables("student").Rows(inc1).Item(0)
            TextBox2.Text = ds.Tables("student").Rows(inc1).Item(1)
            TextBox11.Text = ds.Tables("student").Rows(inc1).Item(2)
            TextBox8.Text = ds.Tables("student").Rows(inc1).Item(3)
            TextBox5.Text = ds.Tables("student").Rows(inc1).Item(4)
            TextBox10.Text = ds.Tables("student").Rows(inc1).Item(5)
            TextBox6.Text = ds.Tables("student").Rows(inc1).Item(6)
            TextBox9.Text = ds.Tables("student").Rows(inc1).Item(7)
            TextBox7.Text = ds.Tables("student").Rows(inc1).Item(8)
            TextBox3.Text = ds.Tables("student").Rows(inc1).Item(9)
            TextBox4.Text = ds.Tables("student").Rows(inc1).Item(10)


            inc1 = inc1 - 1
        Else
            MessageBox.Show("NO more rows")
        End If
        conn.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If inc <> max_rows Then
            TextBox1.Text = ds.Tables("student").Rows(inc).Item(0)
            TextBox2.Text = ds.Tables("student").Rows(inc).Item(1)
            TextBox11.Text = ds.Tables("student").Rows(inc).Item(2)
            TextBox8.Text = ds.Tables("student").Rows(inc).Item(3)
            TextBox5.Text = ds.Tables("student").Rows(inc).Item(4)
            TextBox10.Text = ds.Tables("student").Rows(inc).Item(5)
            TextBox6.Text = ds.Tables("student").Rows(inc).Item(6)
            TextBox9.Text = ds.Tables("student").Rows(inc).Item(7)
            TextBox7.Text = ds.Tables("student").Rows(inc).Item(8)
            TextBox3.Text = ds.Tables("student").Rows(inc).Item(9)
            TextBox4.Text = ds.Tables("student").Rows(inc).Item(10)


            inc = inc + 1
        Else
            MessageBox.Show("NO more rows")
        End If
        conn.Close()
    End Sub
End Class