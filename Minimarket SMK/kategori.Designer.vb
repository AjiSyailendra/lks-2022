<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class kategori
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.id = New System.Windows.Forms.TextBox()
        Me.keteranganKategori = New System.Windows.Forms.TextBox()
        Me.input = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.keluar = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.namaKategori = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(130, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(112, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Kategori"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(26, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(18, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(26, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nama Kategori"
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(26, 130)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(321, 23)
        Me.id.TabIndex = 5
        '
        'keteranganKategori
        '
        Me.keteranganKategori.Location = New System.Drawing.Point(26, 251)
        Me.keteranganKategori.Name = "keteranganKategori"
        Me.keteranganKategori.Size = New System.Drawing.Size(321, 23)
        Me.keteranganKategori.TabIndex = 6
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(26, 298)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(321, 32)
        Me.input.TabIndex = 7
        Me.input.Text = "Input"
        Me.input.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(26, 336)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(321, 32)
        Me.edit.TabIndex = 8
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(26, 374)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(157, 32)
        Me.hapus.TabIndex = 9
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(189, 374)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(158, 32)
        Me.keluar.TabIndex = 10
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(367, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(396, 259)
        Me.DataGridView1.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(26, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Keterangan"
        '
        'namaKategori
        '
        Me.namaKategori.Location = New System.Drawing.Point(26, 194)
        Me.namaKategori.Name = "namaKategori"
        Me.namaKategori.Size = New System.Drawing.Size(321, 23)
        Me.namaKategori.TabIndex = 6
        '
        'kategori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(791, 440)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.namaKategori)
        Me.Controls.Add(Me.keteranganKategori)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "kategori"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "kategori"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents id As TextBox
    Friend WithEvents keteranganKategori As TextBox
    Friend WithEvents input As Button
    Friend WithEvents edit As Button
    Friend WithEvents hapus As Button
    Friend WithEvents keluar As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents namaKategori As TextBox
End Class
