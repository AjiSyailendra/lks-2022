Imports MySql.Data.MySqlClient
Public Class Supplier
    Sub KondisiAwal()
        Call Koneksi()
        da = New MySqlDataAdapter("select nama_supplier as Nama_Supplier,alamat as Alamat,no_tlp as No_Telpon,nama_bank as Nama_Bank,no_rekening as No_Rekeneing from tbl_supplier", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_supplier")
        DataGridView1.DataSource = (ds.Tables("tbl_supplier"))
        DataGridView1.ReadOnly = True

        ID.Hide()
        namaSupplier.Focus()
        namaSupplier.Text = ""
        alamat.Text = ""
        telpon.Text = ""
        namaBank.Text = ""
        noRek.Text = ""
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        Call Koneksi()
        Dim str As String
        str = "insert into tbl_supplier values('" & ID.Text & "','" & namaSupplier.Text & "','" & alamat.Text & "','" & telpon.Text & "','" & namaBank.Text & "','" & noRek.Text & "')"
        cmd = New MySqlCommand(str, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Input", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub edit_Click(sender As Object, e As EventArgs) Handles edit.Click
        Call Koneksi()
        Dim edit As String
        edit = "update tbl_supplier set nama_supplier='" & namaSupplier.Text & "',alamat='" & alamat.Text & "',no_tlp='" & telpon.Text & "',nama_bank='" & namaBank.Text & "',no_rekening='" & noRek.Text & "'where nama_supplier='" & namaSupplier.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_supplier where nama_supplier='" & DataGridView1.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            namaSupplier.Focus()
        Else
            namaSupplier.Text = rd.Item("nama_supplier")
            alamat.Text = rd.Item("alamat")
            telpon.Text = rd.Item("no_tlp")
            namaBank.Text = rd.Item("nama_bank")
            noRek.Text = rd.Item("no_rekening")
            namaSupplier.Focus()
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_supplier where nama_supplier='" & namaSupplier.Text & "'"
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

    Private Sub Supplier_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        namaSupplier.Focus()
        Call KondisiAwal()
    End Sub
End Class