<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class studentListForm
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.refreshButton = New System.Windows.Forms.Button()
        Me.totalLabel = New System.Windows.Forms.Label()
        Me.malePanel = New System.Windows.Forms.Panel()
        Me.maleLabel = New System.Windows.Forms.Label()
        Me.femalePanel = New System.Windows.Forms.Panel()
        Me.femaleLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchTextBox = New System.Windows.Forms.TextBox()
        Me.searchButton = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.malePanel.SuspendLayout()
        Me.femalePanel.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(119, 166)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.RowTemplate.Height = 28
        Me.DataGridView1.Size = New System.Drawing.Size(747, 450)
        Me.DataGridView1.TabIndex = 0
        '
        'refreshButton
        '
        Me.refreshButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.refreshButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.refreshButton.ForeColor = System.Drawing.Color.White
        Me.refreshButton.Location = New System.Drawing.Point(119, 622)
        Me.refreshButton.Name = "refreshButton"
        Me.refreshButton.Size = New System.Drawing.Size(747, 40)
        Me.refreshButton.TabIndex = 31
        Me.refreshButton.Text = "Refresh"
        Me.refreshButton.UseVisualStyleBackColor = False
        '
        'totalLabel
        '
        Me.totalLabel.BackColor = System.Drawing.Color.MediumTurquoise
        Me.totalLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.totalLabel.ForeColor = System.Drawing.Color.White
        Me.totalLabel.Location = New System.Drawing.Point(116, 77)
        Me.totalLabel.Name = "totalLabel"
        Me.totalLabel.Size = New System.Drawing.Size(260, 72)
        Me.totalLabel.TabIndex = 0
        Me.totalLabel.Text = "Total Students : 1000"
        Me.totalLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'malePanel
        '
        Me.malePanel.BackColor = System.Drawing.Color.DarkTurquoise
        Me.malePanel.Controls.Add(Me.maleLabel)
        Me.malePanel.Location = New System.Drawing.Point(412, 77)
        Me.malePanel.Name = "malePanel"
        Me.malePanel.Size = New System.Drawing.Size(226, 78)
        Me.malePanel.TabIndex = 33
        '
        'maleLabel
        '
        Me.maleLabel.AutoSize = True
        Me.maleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maleLabel.ForeColor = System.Drawing.Color.White
        Me.maleLabel.Location = New System.Drawing.Point(67, 28)
        Me.maleLabel.Name = "maleLabel"
        Me.maleLabel.Size = New System.Drawing.Size(101, 17)
        Me.maleLabel.TabIndex = 0
        Me.maleLabel.Text = "Males : 1000"
        Me.maleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'femalePanel
        '
        Me.femalePanel.BackColor = System.Drawing.Color.Turquoise
        Me.femalePanel.Controls.Add(Me.femaleLabel)
        Me.femalePanel.Location = New System.Drawing.Point(671, 80)
        Me.femalePanel.Name = "femalePanel"
        Me.femalePanel.Size = New System.Drawing.Size(195, 75)
        Me.femalePanel.TabIndex = 34
        '
        'femaleLabel
        '
        Me.femaleLabel.AutoSize = True
        Me.femaleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.femaleLabel.ForeColor = System.Drawing.Color.White
        Me.femaleLabel.Location = New System.Drawing.Point(22, 25)
        Me.femaleLabel.Name = "femaleLabel"
        Me.femaleLabel.Size = New System.Drawing.Size(114, 17)
        Me.femaleLabel.TabIndex = 1
        Me.femaleLabel.Text = "Females :1000"
        Me.femaleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(115, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(153, 23)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Enter search term"
        '
        'searchTextBox
        '
        Me.searchTextBox.Location = New System.Drawing.Point(274, 36)
        Me.searchTextBox.Name = "searchTextBox"
        Me.searchTextBox.Size = New System.Drawing.Size(391, 23)
        Me.searchTextBox.TabIndex = 36
        '
        'searchButton
        '
        Me.searchButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.searchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(61, Byte), Integer), CType(CType(131, Byte), Integer), CType(CType(215, Byte), Integer))
        Me.searchButton.ForeColor = System.Drawing.Color.White
        Me.searchButton.Location = New System.Drawing.Point(696, 36)
        Me.searchButton.Name = "searchButton"
        Me.searchButton.Size = New System.Drawing.Size(170, 25)
        Me.searchButton.TabIndex = 37
        Me.searchButton.Text = "Search"
        Me.searchButton.UseVisualStyleBackColor = False
        '
        'studentListForm
        '
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(935, 671)
        Me.Controls.Add(Me.totalLabel)
        Me.Controls.Add(Me.searchButton)
        Me.Controls.Add(Me.searchTextBox)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.malePanel)
        Me.Controls.Add(Me.femalePanel)
        Me.Controls.Add(Me.refreshButton)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "studentListForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "studentListForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.malePanel.ResumeLayout(False)
        Me.malePanel.PerformLayout()
        Me.femalePanel.ResumeLayout(False)
        Me.femalePanel.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents refreshButton As Button
    Friend WithEvents malePanel As Panel
    Friend WithEvents femalePanel As Panel
    Friend WithEvents totalLabel As Label
    Friend WithEvents maleLabel As Label
    Friend WithEvents femaleLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents searchTextBox As TextBox
    Friend WithEvents searchButton As Button
End Class
