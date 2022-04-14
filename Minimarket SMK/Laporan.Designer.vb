<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Laporan
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
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IDPembelian = New System.Windows.Forms.ComboBox()
        Me.LBLSupplier = New System.Windows.Forms.Label()
        Me.LBLNamaBarang = New System.Windows.Forms.Label()
        Me.LBLNoTransaksi = New System.Windows.Forms.Label()
        Me.LBLTanggal = New System.Windows.Forms.Label()
        Me.LBLJumlahBarang = New System.Windows.Forms.Label()
        Me.LBLHarga = New System.Windows.Forms.Label()
        Me.LBLDiskon = New System.Windows.Forms.Label()
        Me.LBLStatus = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.LBLAlamat = New System.Windows.Forms.Label()
        Me.LBLNoTelepon = New System.Windows.Forms.Label()
        Me.LBLNamaBank = New System.Windows.Forms.Label()
        Me.LBLNoRekening = New System.Windows.Forms.Label()
        Me.LBLTotal = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.LBLHargaDenganDiskon = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.NamaSupplier = New System.Windows.Forms.ComboBox()
        Me.clearDataPembelian = New System.Windows.Forms.Button()
        Me.clearDataSupploer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(359, 21)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Laporan"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(427, 156)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(43, 15)
        Me.Label9.TabIndex = 11
        Me.Label9.Text = "Diskon"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(427, 127)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Harga"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(427, 98)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(85, 15)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Jumlah Barang"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(45, 214)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Tanggal"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(45, 185)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(76, 15)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "No. Transaksi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 156)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 15)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nama Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(45, 127)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 15)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Nama Supplier"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 98)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 15)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "ID Pembelian"
        '
        'IDPembelian
        '
        Me.IDPembelian.FormattingEnabled = True
        Me.IDPembelian.Location = New System.Drawing.Point(157, 95)
        Me.IDPembelian.Name = "IDPembelian"
        Me.IDPembelian.Size = New System.Drawing.Size(210, 23)
        Me.IDPembelian.TabIndex = 22
        '
        'LBLSupplier
        '
        Me.LBLSupplier.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLSupplier.Location = New System.Drawing.Point(157, 126)
        Me.LBLSupplier.Name = "LBLSupplier"
        Me.LBLSupplier.Size = New System.Drawing.Size(210, 20)
        Me.LBLSupplier.TabIndex = 7
        Me.LBLSupplier.Text = "Nama Supplier"
        '
        'LBLNamaBarang
        '
        Me.LBLNamaBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaBarang.Location = New System.Drawing.Point(157, 155)
        Me.LBLNamaBarang.Name = "LBLNamaBarang"
        Me.LBLNamaBarang.Size = New System.Drawing.Size(210, 20)
        Me.LBLNamaBarang.TabIndex = 7
        Me.LBLNamaBarang.Text = "Nama Barang"
        '
        'LBLNoTransaksi
        '
        Me.LBLNoTransaksi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoTransaksi.Location = New System.Drawing.Point(157, 184)
        Me.LBLNoTransaksi.Name = "LBLNoTransaksi"
        Me.LBLNoTransaksi.Size = New System.Drawing.Size(210, 20)
        Me.LBLNoTransaksi.TabIndex = 7
        Me.LBLNoTransaksi.Text = "No Transaksi"
        '
        'LBLTanggal
        '
        Me.LBLTanggal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTanggal.Location = New System.Drawing.Point(157, 213)
        Me.LBLTanggal.Name = "LBLTanggal"
        Me.LBLTanggal.Size = New System.Drawing.Size(210, 20)
        Me.LBLTanggal.TabIndex = 7
        Me.LBLTanggal.Text = "Tanggal"
        '
        'LBLJumlahBarang
        '
        Me.LBLJumlahBarang.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLJumlahBarang.Location = New System.Drawing.Point(555, 98)
        Me.LBLJumlahBarang.Name = "LBLJumlahBarang"
        Me.LBLJumlahBarang.Size = New System.Drawing.Size(210, 20)
        Me.LBLJumlahBarang.TabIndex = 7
        Me.LBLJumlahBarang.Text = "Jumlah Barang"
        '
        'LBLHarga
        '
        Me.LBLHarga.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLHarga.Location = New System.Drawing.Point(555, 126)
        Me.LBLHarga.Name = "LBLHarga"
        Me.LBLHarga.Size = New System.Drawing.Size(210, 20)
        Me.LBLHarga.TabIndex = 7
        Me.LBLHarga.Text = "Harga"
        '
        'LBLDiskon
        '
        Me.LBLDiskon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLDiskon.Location = New System.Drawing.Point(555, 156)
        Me.LBLDiskon.Name = "LBLDiskon"
        Me.LBLDiskon.Size = New System.Drawing.Size(210, 20)
        Me.LBLDiskon.TabIndex = 7
        Me.LBLDiskon.Text = "Diskon"
        '
        'LBLStatus
        '
        Me.LBLStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLStatus.Location = New System.Drawing.Point(555, 184)
        Me.LBLStatus.Name = "LBLStatus"
        Me.LBLStatus.Size = New System.Drawing.Size(210, 20)
        Me.LBLStatus.TabIndex = 7
        Me.LBLStatus.Text = "Status"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(45, 422)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(75, 15)
        Me.Label21.TabIndex = 28
        Me.Label21.Text = "No Rekening"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(45, 393)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(68, 15)
        Me.Label22.TabIndex = 29
        Me.Label22.Text = "Nama Bank"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(45, 364)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(70, 15)
        Me.Label23.TabIndex = 30
        Me.Label23.Text = "No. Telepon"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(45, 335)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(45, 15)
        Me.Label24.TabIndex = 31
        Me.Label24.Text = "Alamat"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(45, 306)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(85, 15)
        Me.Label25.TabIndex = 32
        Me.Label25.Text = "Nama Supplier"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label20.Location = New System.Drawing.Point(45, 275)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(133, 25)
        Me.Label20.TabIndex = 0
        Me.Label20.Text = "Data Supplier"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label19.Location = New System.Drawing.Point(45, 67)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(150, 25)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Data Pembelian"
        '
        'LBLAlamat
        '
        Me.LBLAlamat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLAlamat.Location = New System.Drawing.Point(158, 335)
        Me.LBLAlamat.Name = "LBLAlamat"
        Me.LBLAlamat.Size = New System.Drawing.Size(210, 20)
        Me.LBLAlamat.TabIndex = 7
        Me.LBLAlamat.Text = "Alamat"
        '
        'LBLNoTelepon
        '
        Me.LBLNoTelepon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoTelepon.Location = New System.Drawing.Point(158, 364)
        Me.LBLNoTelepon.Name = "LBLNoTelepon"
        Me.LBLNoTelepon.Size = New System.Drawing.Size(210, 20)
        Me.LBLNoTelepon.TabIndex = 7
        Me.LBLNoTelepon.Text = "No Telpon"
        '
        'LBLNamaBank
        '
        Me.LBLNamaBank.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNamaBank.Location = New System.Drawing.Point(158, 393)
        Me.LBLNamaBank.Name = "LBLNamaBank"
        Me.LBLNamaBank.Size = New System.Drawing.Size(210, 20)
        Me.LBLNamaBank.TabIndex = 7
        Me.LBLNamaBank.Text = "Nama Bank"
        '
        'LBLNoRekening
        '
        Me.LBLNoRekening.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLNoRekening.Location = New System.Drawing.Point(158, 422)
        Me.LBLNoRekening.Name = "LBLNoRekening"
        Me.LBLNoRekening.Size = New System.Drawing.Size(210, 20)
        Me.LBLNoRekening.TabIndex = 7
        Me.LBLNoRekening.Text = "No Rekening"
        '
        'LBLTotal
        '
        Me.LBLTotal.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLTotal.Font = New System.Drawing.Font("Segoe UI Semibold", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LBLTotal.Location = New System.Drawing.Point(555, 248)
        Me.LBLTotal.Name = "LBLTotal"
        Me.LBLTotal.Size = New System.Drawing.Size(210, 52)
        Me.LBLTotal.TabIndex = 7
        Me.LBLTotal.Text = "Total"
        Me.LBLTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label33.Location = New System.Drawing.Point(427, 258)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(61, 30)
        Me.Label33.TabIndex = 13
        Me.Label33.Text = "Total"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(427, 185)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(39, 15)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Status"
        '
        'LBLHargaDenganDiskon
        '
        Me.LBLHargaDenganDiskon.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.LBLHargaDenganDiskon.Location = New System.Drawing.Point(555, 215)
        Me.LBLHargaDenganDiskon.Name = "LBLHargaDenganDiskon"
        Me.LBLHargaDenganDiskon.Size = New System.Drawing.Size(210, 20)
        Me.LBLHargaDenganDiskon.TabIndex = 7
        Me.LBLHargaDenganDiskon.Text = "harga with diskon"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(427, 215)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(121, 15)
        Me.Label27.TabIndex = 9
        Me.Label27.Text = "Harga dengan Diskon"
        '
        'NamaSupplier
        '
        Me.NamaSupplier.FormattingEnabled = True
        Me.NamaSupplier.Location = New System.Drawing.Point(157, 303)
        Me.NamaSupplier.Name = "NamaSupplier"
        Me.NamaSupplier.Size = New System.Drawing.Size(210, 23)
        Me.NamaSupplier.TabIndex = 22
        '
        'clearDataPembelian
        '
        Me.clearDataPembelian.Location = New System.Drawing.Point(817, 146)
        Me.clearDataPembelian.Name = "clearDataPembelian"
        Me.clearDataPembelian.Size = New System.Drawing.Size(81, 37)
        Me.clearDataPembelian.TabIndex = 33
        Me.clearDataPembelian.Text = "Bersihkan"
        Me.clearDataPembelian.UseVisualStyleBackColor = True
        '
        'clearDataSupploer
        '
        Me.clearDataSupploer.Location = New System.Drawing.Point(407, 354)
        Me.clearDataSupploer.Name = "clearDataSupploer"
        Me.clearDataSupploer.Size = New System.Drawing.Size(81, 37)
        Me.clearDataSupploer.TabIndex = 33
        Me.clearDataSupploer.Text = "Bersihkan"
        Me.clearDataSupploer.UseVisualStyleBackColor = True
        '
        'Laporan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1035, 524)
        Me.Controls.Add(Me.clearDataSupploer)
        Me.Controls.Add(Me.clearDataPembelian)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label23)
        Me.Controls.Add(Me.Label24)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.NamaSupplier)
        Me.Controls.Add(Me.IDPembelian)
        Me.Controls.Add(Me.Label27)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label33)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LBLHargaDenganDiskon)
        Me.Controls.Add(Me.LBLStatus)
        Me.Controls.Add(Me.LBLDiskon)
        Me.Controls.Add(Me.LBLHarga)
        Me.Controls.Add(Me.LBLJumlahBarang)
        Me.Controls.Add(Me.LBLTotal)
        Me.Controls.Add(Me.LBLNoRekening)
        Me.Controls.Add(Me.LBLTanggal)
        Me.Controls.Add(Me.LBLNamaBank)
        Me.Controls.Add(Me.LBLNoTransaksi)
        Me.Controls.Add(Me.LBLNoTelepon)
        Me.Controls.Add(Me.LBLNamaBarang)
        Me.Controls.Add(Me.LBLAlamat)
        Me.Controls.Add(Me.LBLSupplier)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Laporan"
        Me.Text = "Laporan"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IDPembelian As ComboBox
    Friend WithEvents LBLSupplier As Label
    Friend WithEvents LBLNamaBarang As Label
    Friend WithEvents LBLNoTransaksi As Label
    Friend WithEvents LBLTanggal As Label
    Friend WithEvents LBLJumlahBarang As Label
    Friend WithEvents LBLHarga As Label
    Friend WithEvents LBLDiskon As Label
    Friend WithEvents LBLStatus As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label22 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents LBLAlamat As Label
    Friend WithEvents LBLNoTelepon As Label
    Friend WithEvents LBLNamaBank As Label
    Friend WithEvents LBLNoRekening As Label
    Friend WithEvents LBLTotal As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents LBLHargaDenganDiskon As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents NamaSupplier As ComboBox
    Friend WithEvents clearDataPembelian As Button
    Friend WithEvents clearDataSupploer As Button
End Class
