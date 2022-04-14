Imports MySql.Data.MySqlClient

Public Class Barang
    Sub TampilComboBoxKategori()
        Call Koneksi()
        Dim str As String
        str = "select nama_kategori from tbl_kategori"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read
                kategori.Items.Add(rd.Item("nama_kategori"))
            Loop
        End If
    End Sub

    Sub TampilComboBoxSatuan()
        Call Koneksi()
        Dim str As String
        str = "select nama_satuan from tbl_satuan"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read = True
                satuan.Items.Add(rd.Item("nama_satuan"))
            Loop
        End If

    End Sub
    Private Sub Barang_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call TampilComboBoxKategori()
        Call TampilComboBoxSatuan()
        Call KondisiAwal()
        id.Hide()
    End Sub
    Sub KondisiAwal()
        Call Koneksi()
        da = New MySqlDataAdapter("select kode_barang as Kode_Barang,nama_barang as Nama_Barang,nama_kategori as Kategori,nama_satuan as Satuan,harga_beli as Harga_Beli,harga_jual as Harga_Jual from tbl_barang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_barang")
        DataGridView1.DataSource = (ds.Tables("tbl_barang"))
        DataGridView1.ReadOnly = True

        kodeBarang.Focus()
        kodeBarang.Text = ""
        namaBarang.Text = ""
        kategori.Text = ""
        satuan.Text = ""
        hargaBeli.Text = ""
        hargaJual.Text = ""
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        Call Koneksi()
        Dim str As String
        str = "insert into tbl_barang values('" & id.Text & "','" & kodeBarang.Text & "','" & namaBarang.Text & "','" & kategori.Text & "','" & satuan.Text & "','" & hargaBeli.Text & "','" & hargaJual.Text & "')"
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call Koneksi()
        Dim edit As String
        edit = "update tbl_barang set nama_barang='" & namaBarang.Text & "',nama_kategori='" & kategori.Text & "',nama_satuan='" & satuan.Text & "',harga_beli='" & hargaBeli.Text & "',harga_jual='" & hargaJual.Text & "'where kode_barang='" & kodeBarang.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_barang where kode_barang='" & DataGridView1.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            kodeBarang.Focus()
        Else
            kodeBarang.Text = rd.Item("kode_barang")
            namaBarang.Text = rd.Item("nama_barang")
            kategori.Text = rd.Item("nama_kategori")
            satuan.Text = rd.Item("nama_satuan")
            hargaBeli.Text = rd.Item("harga_beli")
            hargaJual.Text = rd.Item("harga_jual")
            namaBarang.Focus()
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_barang where kode_barang='" & kodeBarang.Text & "'"
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class