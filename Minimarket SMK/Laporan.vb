Imports MySql.Data.MySqlClient
Imports System.Globalization

Public Class Laporan
    Sub KondisiAwal()
        IDPembelian.Text = ""
        LBLSupplier.Text = ""
        LBLNamaBarang.Text = ""
        LBLNoTransaksi.Text = ""
        LBLTanggal.Text = ""
        LBLJumlahBarang.Text = ""
        LBLHarga.Text = ""
        LBLDiskon.Text = ""
        LBLStatus.Text = ""
        LBLHargaDenganDiskon.Text = ""
        LBLTotal.Text = ""

        NamaSupplier.Text = ""
        LBLAlamat.Text = ""
        LBLNoTelepon.Text = ""
        LBLNamaBank.Text = ""
        LBLNoRekening.Text = ""
    End Sub

    Sub tampilIdPembelian()
        Call Koneksi()
        Dim str As String
        str = "select id_pembelian from tbl_pembelian"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read()
                IDPembelian.Items.Add(rd("id_pembelian"))
            Loop
        End If
    End Sub

    Sub tampilNamaSupplier()
        Call Koneksi()
        Dim str As String
        str = "select nama_supplier from tbl_supplier"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read()
                NamaSupplier.Items.Add(rd("nama_supplier"))
            Loop
        End If
    End Sub

    Private Sub Laporan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call tampilIdPembelian()
        Call tampilNamaSupplier()
        Call KondisiAwal()
    End Sub

    Private Sub IDPembelian_KeyPress(sender As Object, e As KeyPressEventArgs) Handles IDPembelian.KeyPress
        Call Koneksi()
        Dim str As String
        str = "select * from tbl_pembelian where id_pembelian='" & IDPembelian.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Maaf Daftar Barang Tidak Ada!", MsgBoxStyle.Information, "Informasi")
        Else
            IDPembelian.Text = rd.Item("id_pembelian")
            LBLSupplier.Text = rd.Item("nama_supplier")
            LBLNamaBarang.Text = rd.Item("nama_barang")
            LBLNoTransaksi.Text = rd.Item("no_transaksi")
            LBLTanggal.Text = rd.Item("tanggal")
            LBLJumlahBarang.Text = rd.Item("jumlah_barang")
            Dim rupiahHarga As Decimal
            rupiahHarga = rd.Item("harga")
            LBLHarga.Text = rupiahHarga.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
            LBLDiskon.Text = rd.Item("diskon")
            LBLStatus.Text = rd.Item("status")

            Dim rupiahTotal As Decimal
            Dim rupiahDiskon As Decimal
            rupiahDiskon = rupiahHarga - ((rupiahHarga / 100) * Val(LBLDiskon.Text))
            rupiahTotal = rupiahDiskon * Val(LBLJumlahBarang.Text)
            LBLHargaDenganDiskon.Text = rupiahDiskon.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
            LBLTotal.Text = rupiahTotal.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))
        End If
    End Sub

    Private Sub NamaSupplier_KeyPress(sender As Object, e As KeyPressEventArgs) Handles NamaSupplier.KeyPress
        Call Koneksi()
        Dim str As String
        str = "select * from tbl_supplier where nama_supplier='" & NamaSupplier.Text & "'"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            MsgBox("Maaf Daftar Supplier Tidak Tersedia!", MsgBoxStyle.Information, "Informasi")
        Else
            NamaSupplier.Text = rd.Item("nama_supplier")
            LBLAlamat.Text = rd.Item("alamat")
            LBLNoTelepon.Text = rd.Item("no_tlp")
            LBLNamaBank.Text = rd.Item("nama_bank")
            LBLNoRekening.Text = rd.Item("no_rekening")
        End If
    End Sub

    Private Sub clearDataPembelian_Click(sender As Object, e As EventArgs) Handles clearDataPembelian.Click
        IDPembelian.Text = ""
        LBLSupplier.Text = ""
        LBLNamaBarang.Text = ""
        LBLNoTransaksi.Text = ""
        LBLTanggal.Text = ""
        LBLJumlahBarang.Text = ""
        LBLHarga.Text = ""
        LBLDiskon.Text = ""
        LBLStatus.Text = ""
        LBLHargaDenganDiskon.Text = ""
        LBLTotal.Text = ""
    End Sub

    Private Sub clearDataSupploer_Click(sender As Object, e As EventArgs) Handles clearDataSupploer.Click
        NamaSupplier.Text = ""
        LBLAlamat.Text = ""
        LBLNoTelepon.Text = ""
        LBLNamaBank.Text = ""
        LBLNoRekening.Text = ""
    End Sub
End Class