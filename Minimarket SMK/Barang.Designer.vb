<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Barang
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
        Me.edit = New System.Windows.Forms.Button()
        Me.input = New System.Windows.Forms.Button()
        Me.namaBarang = New System.Windows.Forms.TextBox()
        Me.kodeBarang = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.keluar = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.kategori = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.satuan = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.hargaBeli = New System.Windows.Forms.TextBox()
        Me.hargaJual = New System.Windows.Forms.TextBox()
        Me.id = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(371, 130)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(642, 449)
        Me.DataGridView1.TabIndex = 31
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(32, 509)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(321, 32)
        Me.edit.TabIndex = 30
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(32, 471)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(321, 32)
        Me.input.TabIndex = 29
        Me.input.Text = "Input"
        Me.input.UseVisualStyleBackColor = True
        '
        'namaBarang
        '
        Me.namaBarang.Location = New System.Drawing.Point(32, 194)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(321, 23)
        Me.namaBarang.TabIndex = 27
        '
        'kodeBarang
        '
        Me.kodeBarang.Location = New System.Drawing.Point(32, 130)
        Me.kodeBarang.Name = "kodeBarang"
        Me.kodeBarang.Size = New System.Drawing.Size(321, 23)
        Me.kodeBarang.TabIndex = 26
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 233)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 15)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Kategori"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 25
        Me.Label4.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(144, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(95, 32)
        Me.Label1.TabIndex = 23
        Me.Label1.Text = "Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 112)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 15)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Kode Barang"
        '
        'keluar
        '
        Me.keluar.Location = New System.Drawing.Point(195, 547)
        Me.keluar.Name = "keluar"
        Me.keluar.Size = New System.Drawing.Size(158, 32)
        Me.keluar.TabIndex = 33
        Me.keluar.Text = "Keluar"
        Me.keluar.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(32, 547)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(157, 32)
        Me.hapus.TabIndex = 32
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'kategori
        '
        Me.kategori.FormattingEnabled = True
        Me.kategori.Location = New System.Drawing.Point(32, 251)
        Me.kategori.Name = "kategori"
        Me.kategori.Size = New System.Drawing.Size(321, 23)
        Me.kategori.TabIndex = 34
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 15)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "Satuan"
        '
        'satuan
        '
        Me.satuan.FormattingEnabled = True
        Me.satuan.Location = New System.Drawing.Point(32, 312)
        Me.satuan.Name = "satuan"
        Me.satuan.Size = New System.Drawing.Size(321, 23)
        Me.satuan.TabIndex = 34
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(32, 350)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 15)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Harga Beli"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(32, 407)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 15)
        Me.Label7.TabIndex = 24
        Me.Label7.Text = "Harga Jual"
        '
        'hargaBeli
        '
        Me.hargaBeli.Location = New System.Drawing.Point(32, 368)
        Me.hargaBeli.Name = "hargaBeli"
        Me.hargaBeli.Size = New System.Drawing.Size(321, 23)
        Me.hargaBeli.TabIndex = 35
        '
        'hargaJual
        '
        Me.hargaJual.Location = New System.Drawing.Point(32, 425)
        Me.hargaJual.Name = "hargaJual"
        Me.hargaJual.Size = New System.Drawing.Size(321, 23)
        Me.hargaJual.TabIndex = 35
        '
        'id
        '
        Me.id.Location = New System.Drawing.Point(2, 2)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(10, 23)
        Me.id.TabIndex = 26
        '
        'Barang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1036, 602)
        Me.Controls.Add(Me.hargaJual)
        Me.Controls.Add(Me.hargaBeli)
        Me.Controls.Add(Me.satuan)
        Me.Controls.Add(Me.kategori)
        Me.Controls.Add(Me.keluar)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.namaBarang)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.id)
        Me.Controls.Add(Me.kodeBarang)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Barang"
        Me.Text = "Barang"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents edit As Button
    Friend WithEvents input As Button
    Friend WithEvents namaBarang As TextBox
    Friend WithEvents kodeBarang As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents keluar As Button
    Friend WithEvents hapus As Button
    Friend WithEvents kategori As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents satuan As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents hargaBeli As TextBox
    Friend WithEvents hargaJual As TextBox
    Friend WithEvents id As TextBox
End Class
