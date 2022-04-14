<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pembelian
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.noTransaksi = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tanggal = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.jumlahBarang = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.harga = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.diskon = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.input = New System.Windows.Forms.Button()
        Me.edit = New System.Windows.Forms.Button()
        Me.hapus = New System.Windows.Forms.Button()
        Me.batal = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.status = New System.Windows.Forms.ComboBox()
        Me.namaSupplier = New System.Windows.Forms.ComboBox()
        Me.namaBarang = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(334, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 30)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Pembelian"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "ID Pembelian"
        '
        'ID
        '
        Me.ID.Location = New System.Drawing.Point(136, 95)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(210, 23)
        Me.ID.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Nama Supplier"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(24, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Nama Barang"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "No. Transaksi"
        '
        'noTransaksi
        '
        Me.noTransaksi.Location = New System.Drawing.Point(136, 182)
        Me.noTransaksi.Name = "noTransaksi"
        Me.noTransaksi.Size = New System.Drawing.Size(210, 23)
        Me.noTransaksi.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(24, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Tanggal"
        '
        'tanggal
        '
        Me.tanggal.Location = New System.Drawing.Point(136, 211)
        Me.tanggal.Name = "tanggal"
        Me.tanggal.Size = New System.Drawing.Size(210, 23)
        Me.tanggal.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(406, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Jumlah Barang"
        '
        'jumlahBarang
        '
        Me.jumlahBarang.Location = New System.Drawing.Point(518, 95)
        Me.jumlahBarang.Name = "jumlahBarang"
        Me.jumlahBarang.Size = New System.Drawing.Size(197, 23)
        Me.jumlahBarang.TabIndex = 2
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(406, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Harga"
        '
        'harga
        '
        Me.harga.Location = New System.Drawing.Point(518, 124)
        Me.harga.Name = "harga"
        Me.harga.Size = New System.Drawing.Size(197, 23)
        Me.harga.TabIndex = 2
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(406, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Diskon"
        '
        'diskon
        '
        Me.diskon.Location = New System.Drawing.Point(518, 153)
        Me.diskon.Name = "diskon"
        Me.diskon.Size = New System.Drawing.Size(197, 23)
        Me.diskon.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(406, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Status"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 302)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 25
        Me.DataGridView1.Size = New System.Drawing.Size(802, 204)
        Me.DataGridView1.TabIndex = 3
        '
        'input
        '
        Me.input.Location = New System.Drawing.Point(215, 249)
        Me.input.Name = "input"
        Me.input.Size = New System.Drawing.Size(81, 37)
        Me.input.TabIndex = 4
        Me.input.Text = "Input"
        Me.input.UseVisualStyleBackColor = True
        '
        'edit
        '
        Me.edit.Location = New System.Drawing.Point(313, 249)
        Me.edit.Name = "edit"
        Me.edit.Size = New System.Drawing.Size(81, 37)
        Me.edit.TabIndex = 4
        Me.edit.Text = "Edit"
        Me.edit.UseVisualStyleBackColor = True
        '
        'hapus
        '
        Me.hapus.Location = New System.Drawing.Point(410, 249)
        Me.hapus.Name = "hapus"
        Me.hapus.Size = New System.Drawing.Size(81, 37)
        Me.hapus.TabIndex = 4
        Me.hapus.Text = "Hapus"
        Me.hapus.UseVisualStyleBackColor = True
        '
        'batal
        '
        Me.batal.Location = New System.Drawing.Point(509, 249)
        Me.batal.Name = "batal"
        Me.batal.Size = New System.Drawing.Size(81, 37)
        Me.batal.TabIndex = 4
        Me.batal.Text = "Batal"
        Me.batal.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(733, 168)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(81, 37)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Bersihkan"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'status
        '
        Me.status.FormattingEnabled = True
        Me.status.Location = New System.Drawing.Point(518, 182)
        Me.status.Name = "status"
        Me.status.Size = New System.Drawing.Size(197, 23)
        Me.status.TabIndex = 5
        '
        'namaSupplier
        '
        Me.namaSupplier.FormattingEnabled = True
        Me.namaSupplier.Location = New System.Drawing.Point(136, 124)
        Me.namaSupplier.Name = "namaSupplier"
        Me.namaSupplier.Size = New System.Drawing.Size(210, 23)
        Me.namaSupplier.TabIndex = 5
        '
        'namaBarang
        '
        Me.namaBarang.FormattingEnabled = True
        Me.namaBarang.Location = New System.Drawing.Point(136, 153)
        Me.namaBarang.Name = "namaBarang"
        Me.namaBarang.Size = New System.Drawing.Size(210, 23)
        Me.namaBarang.TabIndex = 5
        '
        'Pembelian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(826, 518)
        Me.Controls.Add(Me.namaBarang)
        Me.Controls.Add(Me.namaSupplier)
        Me.Controls.Add(Me.status)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.batal)
        Me.Controls.Add(Me.hapus)
        Me.Controls.Add(Me.edit)
        Me.Controls.Add(Me.input)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.diskon)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.harga)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.jumlahBarang)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.tanggal)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.noTransaksi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pembelian"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pembelian"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents noTransaksi As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents tanggal As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents jumlahBarang As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents harga As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents diskon As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents input As Button
    Friend WithEvents edit As Button
    Friend WithEvents hapus As Button
    Friend WithEvents batal As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents status As ComboBox
    Friend WithEvents namaSupplier As ComboBox
    Friend WithEvents namaBarang As ComboBox
End Class
