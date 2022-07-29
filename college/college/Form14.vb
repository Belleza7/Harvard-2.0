Public Class Form14
    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Timer1.Start()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub AboutUsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutUsToolStripMenuItem.Click
        Me.Hide()
        Form9.Show()
    End Sub

    Private Sub StudentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentDetailsToolStripMenuItem.Click
        Me.Hide()
        Form17.Show()
    End Sub

    Private Sub StudentFeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StudentFeeDetailsToolStripMenuItem.Click
        Me.Hide()
        form3.Show()
    End Sub

    Private Sub ViewStudentDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewStudentDetailsToolStripMenuItem.Click
        Me.Hide()
        Form7.Show()
    End Sub

    Private Sub TeacherDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherDetailsToolStripMenuItem.Click
        Me.Hide()
        form2.Show()
    End Sub

    Private Sub TeacherFeeDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TeacherFeeDetailsToolStripMenuItem.Click
        Me.Hide()
        Form4.Show()
    End Sub

    Private Sub ViewTeacherDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewTeacherDetailsToolStripMenuItem.Click
        Me.Hide()
        Form8.Show()
    End Sub

    Private Sub ArchitectureToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchitectureToolStripMenuItem.Click
        Me.Hide()
        Form15.Show()
    End Sub

    Private Sub AchievementsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AchievementsToolStripMenuItem.Click
        Me.Hide()
        Form16.Show()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        If Label2.Location.X + Label2.Width < 0 Then
            Label2.Location = New Point(Me.Width, Label2.Location.Y)
        Else
            Label2.Location = New Point(Label2.Location.X - 7, Label2.Location.Y)
        End If
    End Sub

    Private Sub ComputerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ComputerToolStripMenuItem.Click
        Me.Hide()
        Form18.Show()
    End Sub

    Private Sub ElectricalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElectricalToolStripMenuItem.Click
        Me.Hide()
        Form19.Show()
    End Sub

    Private Sub ElectronicToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ElectronicToolStripMenuItem.Click
        Me.Hide()
        Form20.Show()
    End Sub

    Private Sub InformationTechnologyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InformationTechnologyToolStripMenuItem.Click
        Me.Hide()
        Form21.Show()
    End Sub

    Private Sub MechanicalToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MechanicalToolStripMenuItem.Click
        Me.Hide()
        Form23.Show()
    End Sub

    Private Sub CivilToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CivilToolStripMenuItem.Click
        Me.Hide()
        Form22.Show()
    End Sub

    Private Sub ViewFeereceiptToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewFeereceiptToolStripMenuItem.Click
        Me.Hide()
        Form6.Show()
    End Sub

    Private Sub NavigateDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigateDetailsToolStripMenuItem.Click
        Me.Hide()
        Form26.Show()
    End Sub

    Private Sub ModifyDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ModifyDetailsToolStripMenuItem.Click
        Me.Hide()
        Form13.Show()
    End Sub

    Private Sub NavigateDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles NavigateDetailsToolStripMenuItem1.Click
        Me.Hide()
        Form28.Show()

    End Sub

    Private Sub ModifyDetailsToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ModifyDetailsToolStripMenuItem1.Click
        Me.Hide()
        Form5.Show()
    End Sub
End Class