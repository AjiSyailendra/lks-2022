Imports MySql.Data.MySqlClient

Public Class kategori
    Private Sub kategori_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        da = New MySqlDataAdapter("select id_kategori as ID,nama_kategori as Nama_kategori,keterangan as Keterangan from tbl_kategori", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_kategori")
        DataGridView1.DataSource = (ds.Tables("tbl_kategori"))
        DataGridView1.ReadOnly = True


        id.Hide()
        namaKategori.Focus()
        namaKategori.Text = ""
        keteranganKategori.Text = ""
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        Call Koneksi()
        Dim str As String
        str = "insert into tbl_kategori values('" & id.Text & "','" & namaKategori.Text & "','" & keteranganKategori.Text & "')"
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call Koneksi()
        Dim edit As String
        edit = "update tbl_kategori set nama_kategori='" & namaKategori.Text & "',keterangan='" & keteranganKategori.Text & "'where id_kategori='" & id.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_kategori where id_kategori='" & DataGridView1.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            namaKategori.Focus()
        Else
            id.Text = rd.Item("id_kategori")
            namaKategori.Text = rd.Item("nama_kategori")
            keteranganKategori.Text = rd.Item("keterangan")
            namaKategori.Focus()
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_kategori where id_kategori='" & id.Text & "'"
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class