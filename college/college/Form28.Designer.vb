<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form28
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form28))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TeacherDataSet7 = New college.teacherDataSet7()
        Me.TeacherTableAdapter = New college.teacherDataSet7TableAdapters.teacherTableAdapter()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherDataSet7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.White
        Me.GroupBox2.Controls.Add(Me.Button8)
        Me.GroupBox2.Controls.Add(Me.Button4)
        Me.GroupBox2.Controls.Add(Me.Button7)
        Me.GroupBox2.Controls.Add(Me.Button3)
        Me.GroupBox2.Font = New System.Drawing.Font("Copperplate Gothic Bold", 13.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(295, 475)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(5)
        Me.GroupBox2.Size = New System.Drawing.Size(725, 335)
        Me.GroupBox2.TabIndex = 133
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Traversing Options"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.IndianRed
        Me.Button8.Location = New System.Drawing.Point(398, 211)
        Me.Button8.Margin = New System.Windows.Forms.Padding(5)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(274, 88)
        Me.Button8.TabIndex = 106
        Me.Button8.Text = "Last Record"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.IndianRed
        Me.Button4.Location = New System.Drawing.Point(49, 84)
        Me.Button4.Margin = New System.Windows.Forms.Padding(5)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(224, 88)
        Me.Button4.TabIndex = 101
        Me.Button4.Text = "Next"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button7
        '
        Me.Button7.BackColor = System.Drawing.Color.IndianRed
        Me.Button7.Location = New System.Drawing.Point(398, 87)
        Me.Button7.Margin = New System.Windows.Forms.Padding(5)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(274, 88)
        Me.Button7.TabIndex = 105
        Me.Button7.Text = "First Record"
        Me.Button7.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.IndianRed
        Me.Button3.Location = New System.Drawing.Point(58, 211)
        Me.Button3.Margin = New System.Windows.Forms.Padding(5)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(224, 88)
        Me.Button3.TabIndex = 104
        Me.Button3.Text = "Previous"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(314, 17)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(194, 110)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 136
        Me.PictureBox1.TabStop = False
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.BackColor = System.Drawing.Color.White
        Me.Label13.Font = New System.Drawing.Font("Copperplate Gothic Bold", 19.8!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Brown
        Me.Label13.Location = New System.Drawing.Point(538, 35)
        Me.Label13.Margin = New System.Windows.Forms.Padding(12, 0, 12, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(482, 37)
        Me.Label13.TabIndex = 137
        Me.Label13.Text = "View Of Teacher Details "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Century Schoolbook", 16.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(545, 822)
        Me.Button1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(230, 75)
        Me.Button1.TabIndex = 138
        Me.Button1.Text = "Home"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(17, 177)
        Me.Label1.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 22)
        Me.Label1.TabIndex = 139
        Me.Label1.Text = "ID"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(149, 174)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(246, 29)
        Me.TextBox1.TabIndex = 140
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(6, 245)
        Me.Label5.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(118, 22)
        Me.Label5.TabIndex = 141
        Me.Label5.Text = "Date of birth"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(149, 245)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(246, 29)
        Me.TextBox2.TabIndex = 142
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(17, 328)
        Me.Label3.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 22)
        Me.Label3.TabIndex = 143
        Me.Label3.Text = "Gender"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.Location = New System.Drawing.Point(17, 401)
        Me.Label11.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 22)
        Me.Label11.TabIndex = 145
        Me.Label11.Text = "Post"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Cambria", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(464, 174)
        Me.Label2.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 22)
        Me.Label2.TabIndex = 147
        Me.Label2.Text = "Name"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(606, 174)
        Me.TextBox5.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(244, 29)
        Me.TextBox5.TabIndex = 148
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Cambria", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(464, 245)
        Me.Label4.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(113, 22)
        Me.Label4.TabIndex = 149
        Me.Label4.Text = "Department"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(464, 328)
        Me.Label6.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 22)
        Me.Label6.TabIndex = 151
        Me.Label6.Text = "Father's Name"
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(610, 328)
        Me.TextBox6.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(244, 29)
        Me.TextBox6.TabIndex = 152
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.BackColor = System.Drawing.Color.Transparent
        Me.Label14.Font = New System.Drawing.Font("Cambria", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(464, 414)
        Me.Label14.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(123, 22)
        Me.Label14.TabIndex = 153
        Me.Label14.Text = "Qualification"
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(610, 401)
        Me.TextBox8.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(244, 29)
        Me.TextBox8.TabIndex = 154
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(947, 174)
        Me.Label7.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 22)
        Me.Label7.TabIndex = 155
        Me.Label7.Text = "Mobile No"
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(1049, 174)
        Me.TextBox7.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(238, 29)
        Me.TextBox7.TabIndex = 156
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.Transparent
        Me.Label12.Location = New System.Drawing.Point(947, 252)
        Me.Label12.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(42, 22)
        Me.Label12.TabIndex = 157
        Me.Label12.Text = "Age"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(1049, 249)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(238, 29)
        Me.TextBox4.TabIndex = 158
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.Transparent
        Me.Label9.Location = New System.Drawing.Point(947, 328)
        Me.Label9.Margin = New System.Windows.Forms.Padding(8, 0, 8, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 22)
        Me.Label9.TabIndex = 159
        Me.Label9.Text = "Address"
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(1049, 328)
        Me.TextBox9.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(238, 29)
        Me.TextBox9.TabIndex = 160
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataMember = "teacher"
        Me.TeacherBindingSource.DataSource = Me.TeacherDataSet7
        '
        'TeacherDataSet7
        '
        Me.TeacherDataSet7.DataSetName = "teacherDataSet7"
        Me.TeacherDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TeacherTableAdapter
        '
        Me.TeacherTableAdapter.ClearBeforeFill = True
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(151, 328)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(244, 29)
        Me.TextBox3.TabIndex = 162
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(610, 242)
        Me.TextBox10.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(244, 29)
        Me.TextBox10.TabIndex = 163
        '
        'TextBox11
        '
        Me.TextBox11.Location = New System.Drawing.Point(149, 411)
        Me.TextBox11.Margin = New System.Windows.Forms.Padding(6, 7, 6, 7)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(244, 29)
        Me.TextBox11.TabIndex = 164
        '
        'Form28
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.IndianRed
        Me.ClientSize = New System.Drawing.Size(1315, 1030)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Font = New System.Drawing.Font("Cambria", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form28"
        Me.Text = "Form28"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherDataSet7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button7 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label13 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TeacherDataSet7 As teacherDataSet7
    Friend WithEvents TeacherBindingSource As BindingSource
    Friend WithEvents TeacherTableAdapter As teacherDataSet7TableAdapters.teacherTableAdapter
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents TextBox11 As TextBox
End Class
