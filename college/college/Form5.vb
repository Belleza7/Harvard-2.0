Imports System.Data.OleDb
Public Class Form5


    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet
    Dim count As Integer
    Dim str As String
    Dim inc, max_rows As Integer
    Dim c1, c2, c3 As String
    Dim idd As String

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'TeacherDataSet6.teacher' table. You can move, or remove it, as needed.
        Me.TeacherTableAdapter.Fill(Me.TeacherDataSet6.teacher)
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
        conn.Open()
        cmd = New OleDbCommand("select * from teacher", conn)
        adpt = New OleDbDataAdapter(cmd)
        adpt.Fill(ds, "teacher")
        reader = cmd.ExecuteReader()
        reader.Read()
        TextBox1.Text = reader.GetValue(0)
        TextBox2.Text = reader.GetValue(1)
        ComboBox1.SelectedItem = reader.GetValue(2)
        ComboBox3.SelectedItem = reader.GetValue(8)
        TextBox5.Text = reader.GetValue(6)
        ComboBox2.SelectedItem = reader.GetValue(7)
        TextBox6.Text = reader.GetValue(10)
        TextBox8.Text = reader.GetValue(9)
        TextBox7.Text = reader.GetValue(4)
        TextBox4.Text = reader.GetValue(3)
        TextBox9.Text = reader.GetValue(5)
        conn.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        form2.Show()
        Me.Hide()

    End Sub

    Private Sub DataGridView2_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellContentClick

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        conn.Open()
        idd = InputBox("Enter ID of teacher whose records you want to delete.")

        If MessageBox.Show("DO YOU REALLY WANT TO DELETE THIS RECORD?", "DELETE", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = Windows.Forms.DialogResult.No Then
            MsgBox("OPERATIION CANCELED")
            Exit Sub
        End If

        cmd = New OleDbCommand("delete from teacher where ID='" & idd & "'", conn)
        cmd.ExecuteNonQuery()
        MsgBox("RECORD DELETED")
        conn.Close()

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Dim ra As Integer
        Dim str As String

        idd = InputBox("Enter ID of teacher whose records you want to update.")

        conn.Open()
        c2 = ComboBox1.SelectedItem.ToString()
        c3 = ComboBox2.SelectedItem.ToString()
        c1 = ComboBox3.SelectedItem.ToString()
        str = "update teacher set ID='" & TextBox1.Text & "' , dob='" & TextBox2.Text & "',gender='" & c2 & "',post='" & c1 & "',t_name='" & TextBox5.Text & "',dept=
'" & c3 & "',f_name='" & TextBox6.Text & "',qual='" & TextBox8.Text & "',mob='" & TextBox7.Text & "',age=" & TextBox4.Text & ",
address='" & TextBox9.Text & "' where ID='" & idd & "'"
        cmd = New OleDbCommand(str, conn)
        ra = cmd.ExecuteNonQuery()
        MsgBox("record updated" & ra)
        conn.Close()

    End Sub










    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TeacherBindingSource.EndEdit()
        TeacherTableAdapter.Update(TeacherDataSet6.teacher)
        MsgBox("RECORD IS SAVED")

    End Sub
End Class