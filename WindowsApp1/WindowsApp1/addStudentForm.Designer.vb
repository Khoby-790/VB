<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class addStudentForm
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lnameTextBox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.contactTextBox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.addressTextBox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.studentPictureBox = New System.Windows.Forms.PictureBox()
        Me.uploadButton = New System.Windows.Forms.Button()
        Me.saveStudentButton = New System.Windows.Forms.Button()
        Me.cancelStudentButton = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.femaleRadioButton = New System.Windows.Forms.RadioButton()
        Me.maleRadioButton = New System.Windows.Forms.RadioButton()
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(28, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "First Name"
        '
        'fnameTextBox
        '
        Me.fnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fnameTextBox.Location = New System.Drawing.Point(38, 47)
        Me.fnameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.fnameTextBox.Name = "fnameTextBox"
        Me.fnameTextBox.Size = New System.Drawing.Size(415, 30)
        Me.fnameTextBox.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(33, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 25)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Last Name"
        '
        'lnameTextBox
        '
        Me.lnameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnameTextBox.Location = New System.Drawing.Point(38, 118)
        Me.lnameTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.lnameTextBox.Name = "lnameTextBox"
        Me.lnameTextBox.Size = New System.Drawing.Size(415, 30)
        Me.lnameTextBox.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(37, 162)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 25)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Date of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "dd/MM/yyyy"
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(42, 198)
        Me.DateTimePicker1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(411, 23)
        Me.DateTimePicker1.TabIndex = 5
        '
        'contactTextBox
        '
        Me.contactTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.contactTextBox.Location = New System.Drawing.Point(42, 347)
        Me.contactTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.contactTextBox.Name = "contactTextBox"
        Me.contactTextBox.Size = New System.Drawing.Size(415, 30)
        Me.contactTextBox.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(42, 320)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(87, 25)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Contact"
        '
        'addressTextBox
        '
        Me.addressTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.addressTextBox.Location = New System.Drawing.Point(38, 429)
        Me.addressTextBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.addressTextBox.Multiline = True
        Me.addressTextBox.Name = "addressTextBox"
        Me.addressTextBox.Size = New System.Drawing.Size(415, 91)
        Me.addressTextBox.TabIndex = 9
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(46, 391)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 25)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "Address"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(477, 24)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(116, 25)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Add Image"
        '
        'studentPictureBox
        '
        Me.studentPictureBox.BackColor = System.Drawing.Color.PaleTurquoise
        Me.studentPictureBox.Location = New System.Drawing.Point(482, 69)
        Me.studentPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.studentPictureBox.Name = "studentPictureBox"
        Me.studentPictureBox.Size = New System.Drawing.Size(376, 412)
        Me.studentPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.studentPictureBox.TabIndex = 11
        Me.studentPictureBox.TabStop = False
        '
        'uploadButton
        '
        Me.uploadButton.Location = New System.Drawing.Point(482, 485)
        Me.uploadButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.uploadButton.Name = "uploadButton"
        Me.uploadButton.Size = New System.Drawing.Size(376, 45)
        Me.uploadButton.TabIndex = 12
        Me.uploadButton.Text = "Upload Image"
        Me.uploadButton.UseVisualStyleBackColor = True
        '
        'saveStudentButton
        '
        Me.saveStudentButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.saveStudentButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.saveStudentButton.ForeColor = System.Drawing.Color.White
        Me.saveStudentButton.Location = New System.Drawing.Point(59, 556)
        Me.saveStudentButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.saveStudentButton.Name = "saveStudentButton"
        Me.saveStudentButton.Size = New System.Drawing.Size(100, 32)
        Me.saveStudentButton.TabIndex = 13
        Me.saveStudentButton.Text = "Save"
        Me.saveStudentButton.UseVisualStyleBackColor = False
        '
        'cancelStudentButton
        '
        Me.cancelStudentButton.BackColor = System.Drawing.Color.Red
        Me.cancelStudentButton.ForeColor = System.Drawing.Color.White
        Me.cancelStudentButton.Location = New System.Drawing.Point(247, 556)
        Me.cancelStudentButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.cancelStudentButton.Name = "cancelStudentButton"
        Me.cancelStudentButton.Size = New System.Drawing.Size(100, 32)
        Me.cancelStudentButton.TabIndex = 14
        Me.cancelStudentButton.Text = "Cancel"
        Me.cancelStudentButton.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(40, 230)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(83, 25)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Gender"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.femaleRadioButton)
        Me.GroupBox1.Controls.Add(Me.maleRadioButton)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 257)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(292, 44)
        Me.GroupBox1.TabIndex = 16
        Me.GroupBox1.TabStop = False
        '
        'femaleRadioButton
        '
        Me.femaleRadioButton.AutoSize = True
        Me.femaleRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.femaleRadioButton.ForeColor = System.Drawing.Color.White
        Me.femaleRadioButton.Location = New System.Drawing.Point(148, 9)
        Me.femaleRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.femaleRadioButton.Name = "femaleRadioButton"
        Me.femaleRadioButton.Size = New System.Drawing.Size(98, 29)
        Me.femaleRadioButton.TabIndex = 1
        Me.femaleRadioButton.Text = "Female"
        Me.femaleRadioButton.UseVisualStyleBackColor = True
        '
        'maleRadioButton
        '
        Me.maleRadioButton.AutoSize = True
        Me.maleRadioButton.Checked = True
        Me.maleRadioButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.maleRadioButton.ForeColor = System.Drawing.Color.White
        Me.maleRadioButton.Location = New System.Drawing.Point(5, 9)
        Me.maleRadioButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.maleRadioButton.Name = "maleRadioButton"
        Me.maleRadioButton.Size = New System.Drawing.Size(76, 29)
        Me.maleRadioButton.TabIndex = 0
        Me.maleRadioButton.TabStop = True
        Me.maleRadioButton.Text = "Male"
        Me.maleRadioButton.UseVisualStyleBackColor = True
        '
        'addStudentForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(888, 610)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cancelStudentButton)
        Me.Controls.Add(Me.saveStudentButton)
        Me.Controls.Add(Me.uploadButton)
        Me.Controls.Add(Me.studentPictureBox)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.addressTextBox)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.contactTextBox)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.lnameTextBox)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.fnameTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "addStudentForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Add Student"
        CType(Me.studentPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents fnameTextBox As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents lnameTextBox As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents contactTextBox As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents addressTextBox As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents studentPictureBox As PictureBox
    Friend WithEvents uploadButton As Button
    Friend WithEvents saveStudentButton As Button
    Friend WithEvents cancelStudentButton As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents femaleRadioButton As RadioButton
    Friend WithEvents maleRadioButton As RadioButton
End Class
