Imports System.Data.OleDb

Public Class Form25
    Dim cmd As OleDbCommand = New OleDbCommand
    Dim reader As OleDbDataReader
    Dim conn As OleDbConnection = New OleDbConnection
    Dim adpt As OleDbDataAdapter = New OleDbDataAdapter
    Dim ds As New DataSet

    Private Sub Form25_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'LoginDataSet2.login' table. You can move, or remove it, as needed.
        Me.LoginTableAdapter.Fill(Me.LoginDataSet2.login)

        conn = New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Users\Batool\Desktop\college\login.mdb")
    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox1.Validating

        Dim expression As New System.Text.RegularExpressions.Regex("[a-zA-z]|[0-9]|\W")
        If expression.IsMatch(TextBox1.Text) Then
            ErrorProvider1.SetError(TextBox1, "")
        Else
            ErrorProvider1.SetError(TextBox1, "Not a valid Username")
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form29.Show()
        If Form29.ProgressBar1.Value = 100 Then



            conn.Open()
            cmd = New OleDbCommand("select * from login where username='" & TextBox1.Text & "'and password='" & TextBox2.Text & "'", conn)
            adpt = New OleDbDataAdapter(cmd)
            adpt.Fill(ds, "login")
            reader = cmd.ExecuteReader()

            If reader.Read = True Then
                MsgBox("Username and password already exists.Enter unique values")

            Else
                MsgBox("Sign Up successful.")
                Dim str As String
                str = "insert into login values('" & (TextBox1.Text) & "','" & (TextBox2.Text) & "')"
                cmd = New OleDbCommand(str, conn)
                adpt = New OleDbDataAdapter(cmd)
                adpt.Fill(ds, "login")


                Form24.Show()
                Me.Hide()
            End If
            conn.Close()
            Me.Hide()
            Form14.Show()
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles TextBox2.Validating


        Dim expression As New System.Text.RegularExpressions.Regex("[a-zA-z]|[0-9]")
        If expression.IsMatch(TextBox2.Text) Then
            ErrorProvider1.SetError(TextBox2, "")
        Else
            ErrorProvider1.SetError(TextBox2, "Not a valid Password.")
        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub
End Class