<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Satuan
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.Button()
        Me.namaSatuan = New System.Windows.Forms.TextBox()
        Me.keteranganSatuan = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(373, 97)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(396, 238)
        Me.DataGridView1.TabIndex = 22
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(195, 303)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(158, 32)
        Me.keluar.TabIndex = 21
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(32, 303)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(157, 32)
        Me.hapus.TabIndex = 20
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(32, 265)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(321, 32)
        Me.edit.TabIndex = 19
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(32, 227)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(321, 32)
        Me.input.TabIndex = 18
        Me.input.Text = "Input"
        Me.input.UseVisualStyleBackColor = True
        '
        'namaSatuan
        '
        Me.namaSatuan.Location = New System.Drawing.Point(32, 118)
        Me.namaSatuan.Name = "namaSatuan"
        Me.namaSatuan.Size = New System.Drawing.Size(321, 23)
        Me.namaSatuan.TabIndex = 16
        '
        'keteranganSatuan
        '
        Me.keteranganSatuan.Location = New System.Drawing.Point(32, 175)
        Me.keteranganSatuan.Name = "keteranganSatuan"
        Me.keteranganSatuan.Size = New System.Drawing.Size(321, 23)
        Me.keteranganSatuan.TabIndex = 17
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(12, 12)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(10, 23)
        Me.id.TabIndex = 15
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 157)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Keterangan"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Nama Satuan"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(144, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(92, 32)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Satuan"
        '
        'Satuan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 389)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.namaSatuan)
        Me.Controls.Add(Me.keteranganSatuan)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Satuan"
        Me.Text = "Satuan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents keluar As Button
    Friend WithEvents hapus As Button
    Friend WithEvents edit As Button
    Friend WithEvents input As Button
    Friend WithEvents namaSatuan As TextBox
    Friend WithEvents keteranganSatuan As TextBox
    Friend WithEvents id As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
End Class
