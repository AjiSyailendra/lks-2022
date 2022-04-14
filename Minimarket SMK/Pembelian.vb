Imports MySql.Data.MySqlClient

Public Class Pembelian
    Sub KondisiAwal()
        Call Koneksi()
        da = New MySqlDataAdapter("select id_pembelian as id_pembelian,nama_supplier as Nama_supplier,nama_barang as Nama_Barang,no_transaksi as No_Transaksi,tanggal as Tanggal,jumlah_barang as Jumlah_Barang,harga as Harga,diskon as Diskon,status as Status from tbl_pembelian", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_pembelian")
        DataGridView1.DataSource = (ds.Tables("tbl_pembelian"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowHeadersVisible = False

        namaSupplier.Focus()
        ID.Text = ""
        namaSupplier.Text = ""
        namaBarang.Text = ""
        noTransaksi.Text = ""
        tanggal.Text = Today
        jumlahBarang.Text = ""
        harga.Text = ""
        diskon.Text = ""
        status.Text = ""
    End Sub

    Sub tampilNamaSupplier()
        Call Koneksi()
        Dim str As String
        str = "select nama_supplier from tbl_supplier"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read()
                namaSupplier.Items.Add(rd("nama_supplier"))
            Loop
        End If
    End Sub

    Sub tampilNamaBarang()
        Call Koneksi()
        Dim str As String
        str = "select nama_barang from tbl_barang"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read()
                namaBarang.Items.Add(rd("nama_barang"))
            Loop
        End If
    End Sub
    Sub tampilStatus()
        status.Items.Add("Lunas")
        status.Items.Add("Tidak Lunas")
    End Sub

    Private Sub Pembelian_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call tampilNamaBarang()
        Call tampilNamaSupplier()
        Call tampilStatus()
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        If namaSupplier.Text = "" Or namaBarang.Text = "" Or noTransaksi.Text = "" Or jumlahBarang.Text = "" Or harga.Text = "" Or diskon.Text = "" Or status.Text = "" Then
            MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim command As String
            command = "select * from tbl_pembelian where id_pembelian='" & ID.Text & "'"
            cmd = New MySqlCommand(command, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("barang sudah di inputkan, harap input yang lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_pembelian values('" & ID.Text & "','" & namaSupplier.Text & "','" & namaBarang.Text & "','" & noTransaksi.Text & "','" & tanggal.Text & "','" & jumlahBarang.Text & "','" & harga.Text & "','" & diskon.Text & "','" & status.Text & "')"
                cmd = New MySqlCommand(str, conn)
                cmd.ExecuteNonQuery()
                MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Informasi")
                Call KondisiAwal()
            End If
        End If
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call Koneksi()
        Dim edit As String
        edit = "update tbl_pembelian set nama_supplier='" & namaSupplier.Text & "',nama_barang='" & namaBarang.Text & "',no_transaksi='" & noTransaksi.Text & "',tanggal='" & tanggal.Text & "',jumlah_barang='" & jumlahBarang.Text & "',harga='" & harga.Text & "',diskon='" & diskon.Text & "',status='" & status.Text & "'where id_pembelian='" & ID.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_pembelian where id_pembelian='" & ID.Text & "'"
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_pembelian where id_pembelian='" & DataGridView1.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            ID.Focus()
        Else
            ID.Text = rd("id_pembelian")
            namaSupplier.Text = rd.Item("nama_supplier")
            namaBarang.Text = rd.Item("nama_barang")
            noTransaksi.Text = rd.Item("no_transaksi")
            tanggal.Text = rd.Item("tanggal")
            jumlahBarang.Text = rd.Item("jumlah_barang")
            harga.Text = rd.Item("harga")
            diskon.Text = rd.Item("diskon")
            status.Text = rd.Item("status")
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Call KondisiAwal()
    End Sub

    Private Sub batal_Click(sender As Object, e As EventArgs) Handles batal.Click
        Me.Close()
    End Sub
End Class