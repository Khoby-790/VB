<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LoginForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.usernameText = New System.Windows.Forms.TextBox()
        Me.passwordText = New System.Windows.Forms.TextBox()
        Me.passwordCheckBox = New System.Windows.Forms.CheckBox()
        Me.loginButton = New System.Windows.Forms.Button()
        Me.loginPictureBox = New System.Windows.Forms.PictureBox()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.loginPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Label1.Location = New System.Drawing.Point(720, 53)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 20)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Username"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(720, 143)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(91, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Password"
        '
        'usernameText
        '
        Me.usernameText.Location = New System.Drawing.Point(724, 92)
        Me.usernameText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.usernameText.Name = "usernameText"
        Me.usernameText.Size = New System.Drawing.Size(343, 22)
        Me.usernameText.TabIndex = 3
        Me.usernameText.Text = "Abena Mmra"
        '
        'passwordText
        '
        Me.passwordText.Location = New System.Drawing.Point(724, 178)
        Me.passwordText.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passwordText.Multiline = True
        Me.passwordText.Name = "passwordText"
        Me.passwordText.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passwordText.Size = New System.Drawing.Size(343, 28)
        Me.passwordText.TabIndex = 4
        Me.passwordText.Text = "29677777"
        '
        'passwordCheckBox
        '
        Me.passwordCheckBox.AutoSize = True
        Me.passwordCheckBox.Location = New System.Drawing.Point(724, 225)
        Me.passwordCheckBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.passwordCheckBox.Name = "passwordCheckBox"
        Me.passwordCheckBox.Size = New System.Drawing.Size(129, 21)
        Me.passwordCheckBox.TabIndex = 5
        Me.passwordCheckBox.Text = "Show Password"
        Me.passwordCheckBox.UseVisualStyleBackColor = True
        '
        'loginButton
        '
        Me.loginButton.BackColor = System.Drawing.Color.DodgerBlue
        Me.loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.loginButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.loginButton.Location = New System.Drawing.Point(724, 276)
        Me.loginButton.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.loginButton.Name = "loginButton"
        Me.loginButton.Size = New System.Drawing.Size(343, 48)
        Me.loginButton.TabIndex = 6
        Me.loginButton.Text = "Login"
        Me.loginButton.UseVisualStyleBackColor = False
        '
        'loginPictureBox
        '
        Me.loginPictureBox.ErrorImage = CType(resources.GetObject("loginPictureBox.ErrorImage"), System.Drawing.Image)
        Me.loginPictureBox.Image = CType(resources.GetObject("loginPictureBox.Image"), System.Drawing.Image)
        Me.loginPictureBox.InitialImage = CType(resources.GetObject("loginPictureBox.InitialImage"), System.Drawing.Image)
        Me.loginPictureBox.Location = New System.Drawing.Point(-5, -5)
        Me.loginPictureBox.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.loginPictureBox.Name = "loginPictureBox"
        Me.loginPictureBox.Size = New System.Drawing.Size(623, 584)
        Me.loginPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.loginPictureBox.TabIndex = 7
        Me.loginPictureBox.TabStop = False
        '
        'LoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1208, 580)
        Me.Controls.Add(Me.loginPictureBox)
        Me.Controls.Add(Me.loginButton)
        Me.Controls.Add(Me.passwordCheckBox)
        Me.Controls.Add(Me.passwordText)
        Me.Controls.Add(Me.usernameText)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.MaximizeBox = False
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "LoginForm"
        CType(Me.loginPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents usernameText As TextBox
    Friend WithEvents passwordText As TextBox
    Friend WithEvents passwordCheckBox As CheckBox
    Friend WithEvents loginButton As Button
    Friend WithEvents loginPictureBox As PictureBox
    Friend WithEvents BindingSource1 As BindingSource
End Class
