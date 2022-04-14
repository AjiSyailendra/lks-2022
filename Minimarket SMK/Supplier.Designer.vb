<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Supplier
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.namaSupplier = New System.Windows.Forms.TextBox()
        Me.alamat = New System.Windows.Forms.TextBox()
        Me.telpon = New System.Windows.Forms.TextBox()
        Me.namaBank = New System.Windows.Forms.TextBox()
        Me.noRek = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.input = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.keluar = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(255, 21)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(109, 32)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Supplier"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(1, -1)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(10, 23)
        Me.ID.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(137, 82)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 15)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Nama Supplier"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(137, 111)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Alamat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(70, 15)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "No. Telepon"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 15)
        Me.Label5.TabIndex = 26
        Me.Label5.Text = "Nama Bank"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(137, 198)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(75, 15)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "No Rekening"
        '
        'namaSupplier
        '
        Me.namaSupplier.Location = New System.Drawing.Point(250, 79)
        Me.namaSupplier.Name = "namaSupplier"
        Me.namaSupplier.Size = New System.Drawing.Size(205, 23)
        Me.namaSupplier.TabIndex = 27
        '
        'alamat
        '
        Me.alamat.Location = New System.Drawing.Point(250, 108)
        Me.alamat.Name = "alamat"
        Me.alamat.Size = New System.Drawing.Size(205, 23)
        Me.alamat.TabIndex = 27
        '
        'telpon
        '
        Me.telpon.Location = New System.Drawing.Point(250, 137)
        Me.telpon.Name = "telpon"
        Me.telpon.Size = New System.Drawing.Size(205, 23)
        Me.telpon.TabIndex = 27
        '
        'namaBank
        '
        Me.namaBank.Location = New System.Drawing.Point(250, 166)
        Me.namaBank.Name = "namaBank"
        Me.namaBank.Size = New System.Drawing.Size(205, 23)
        Me.namaBank.TabIndex = 27
        '
        'noRek
        '
        Me.noRek.Location = New System.Drawing.Point(250, 195)
        Me.noRek.Name = "noRek"
        Me.noRek.Size = New System.Drawing.Size(205, 23)
        Me.noRek.TabIndex = 27
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 288)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(579, 180)
        Me.DataGridView1.TabIndex = 28
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(137, 236)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(75, 29)
        Me.input.TabIndex = 29
        Me.input.Text = "Input"
        Me.input.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(218, 236)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(75, 29)
        Me.edit.TabIndex = 29
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(299, 235)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(75, 29)
        Me.hapus.TabIndex = 29
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(380, 235)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(75, 29)
        Me.keluar.TabIndex = 29
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'Supplier
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(603, 497)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.noRek)
        Me.Controls.Add(Me.namaBank)
        Me.Controls.Add(Me.telpon)
        Me.Controls.Add(Me.alamat)
        Me.Controls.Add(Me.namaSupplier)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Supplier"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Supplier"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents namaSupplier As TextBox
    Friend WithEvents alamat As TextBox
    Friend WithEvents telpon As TextBox
    Friend WithEvents namaBank As TextBox
    Friend WithEvents noRek As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents input As Button
    Friend WithEvents edit As Button
    Friend WithEvents hapus As Button
    Friend WithEvents keluar As Button
End Class
