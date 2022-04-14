Imports MySql.Data.MySqlClient
Public Class Satuan
    Private Sub Satuan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        KondisiAwal()
        id.Hide()
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        da = New MySqlDataAdapter("select id_satuan as ID,nama_satuan as Nama_Satuan,keterangan as Keterangan from tbl_satuan", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_satuan")
        DataGridView1.DataSource = (ds.Tables("tbl_satuan"))
        DataGridView1.ReadOnly = True

        namaSatuan.Focus()
        namaSatuan.Text = ""
        keteranganSatuan.Text = ""
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        Call Koneksi()
        Dim str As String
        str = "insert into tbl_satuan values('" & id.Text & "','" & namaSatuan.Text & "','" & namaSatuan.Text & "')"
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call Koneksi()
        Dim edit As String
        edit = "update tbl_satuan set nama_satuan='" & namaSatuan.Text & "',keterangan='" & namaSatuan.Text & "'where id_satuan='" & id.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_satuan where id_satuan='" & DataGridView1.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            id.Focus()
        Else
            id.Text = rd.Item("id_satuan")
            namaSatuan.Text = rd.Item("nama_satuan")
            keteranganSatuan.Text = rd.Item("keterangan")
            namaSatuan.Focus()
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_satuan where id_satuan='" & id.Text & "'"
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub
End Class