<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class User
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.password = New System.Windows.Forms.TextBox()
        Me.namaUser = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.level = New System.Windows.Forms.ComboBox()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.kosongkan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(382, 203)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 29)
        Me.keluar.TabIndex = 46
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(301, 203)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 29)
        Me.hapus.TabIndex = 45
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(220, 204)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 29)
        Me.edit.TabIndex = 44
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(139, 204)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(75, 29)
        Me.input.TabIndex = 43
        Me.input.Text = "Input"
        Me.input.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 249)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(579, 195)
        Me.DataGridView1.TabIndex = 42
        '
        'password
        '
        Me.password.Location = New System.Drawing.Point(252, 109)
        Me.password.Name = "password"
        Me.password.Size = New System.Drawing.Size(205, 23)
        Me.password.TabIndex = 38
        '
        'namaUser
        '
        Me.namaUser.Location = New System.Drawing.Point(252, 80)
        Me.namaUser.Name = "namaUser"
        Me.namaUser.Size = New System.Drawing.Size(205, 23)
        Me.namaUser.TabIndex = 37
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(139, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 15)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Level"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(139, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Status"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(139, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(57, 15)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(139, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 15)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Nama User"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(3, 0)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(10, 23)
        Me.ID.TabIndex = 31
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(257, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 32)
        Me.Label2.TabIndex = 30
        Me.Label2.Text = "User"
        '
        'level
        '
        Me.level.FormattingEnabled = True
        Me.level.Location = New System.Drawing.Point(252, 167)
        Me.level.Name = "level"
        Me.level.Size = New System.Drawing.Size(205, 23)
        Me.level.TabIndex = 47
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Location = New System.Drawing.Point(252, 138)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(205, 23)
        Me.status.TabIndex = 48
        '
        'kosongkan
        '
        Me.kosongkan.Location = New System.Drawing.Point(496, 127)
        Me.kosongkan.Name = "kosongkan"
        Me.kosongkan.Size = New System.Drawing.Size(75, 29)
        Me.kosongkan.TabIndex = 49
        Me.kosongkan.Text = "Kosongkan"
        Me.kosongkan.UseVisualStyleBackColor = True
        '
        'User
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 462)
        Me.Controls.Add(Me.kosongkan)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.level)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.password)
        Me.Controls.Add(Me.namaUser)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label2)
        Me.Name = "User"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents keluar As Button
    Friend WithEvents hapus As Button
    Friend WithEvents edit As Button
    Friend WithEvents input As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents password As TextBox
    Friend WithEvents namaUser As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents level As ComboBox
    Friend WithEvents status As ComboBox
    Friend WithEvents kosongkan As Button
End Class
