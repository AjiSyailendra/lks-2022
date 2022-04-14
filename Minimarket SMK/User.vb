Imports MySql.Data.MySqlClient

Public Class User
    Private Sub User_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
        Call TampilLevel()
        Call TampilAktif()
    End Sub

    Sub TampilLevel()
        Call Koneksi()
        Dim str As String
        str = "select level from tbl_level"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read()
                level.Items.Add(rd("level"))
            Loop
        End If
    End Sub

    Sub TampilAktif()
        Call Koneksi()
        Dim str As String
        str = "select status from tbl_status"
        cmd = New MySqlCommand(str, conn)
        rd = cmd.ExecuteReader
        If rd.HasRows Then
            Do While rd.Read()
                status.Items.Add(rd("status"))
            Loop
        End If
    End Sub

    Sub KondisiAwal()
        Call Koneksi()
        da = New MySqlDataAdapter("select nama_user as Nama_User,password as Password,status as Status,level as Level from tbl_user", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tbl_user")
        DataGridView1.DataSource = (ds.Tables("tbl_user"))
        DataGridView1.ReadOnly = True
        DataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill
        DataGridView1.RowHeadersVisible = False

        ID.Hide()
        namaUser.Focus()
        namaUser.Text = ""
        password.Text = ""
        status.Text = ""
        level.Text = ""
    End Sub

    Private Sub input_Click(sender As Object, e As EventArgs) Handles input.Click
        If namaUser.Text = "" Or password.Text = "" Or status.Text = "" Or level.Text = "" Then
            MsgBox("Harap Isi Semua!", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim command As String
            command = "select * from tbl_user where nama_user='" & namaUser.Text & "'"
            cmd = New MySqlCommand(command, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Username yang anda isi sudah diinput, harap input dengan nama lain!", MsgBoxStyle.Information, "Informasi")
            Else
                Call Koneksi()
                Dim str As String
                str = "insert into tbl_user values('" & ID.Text & "','" & namaUser.Text & "','" & password.Text & "','" & status.Text & "','" & level.Text & "')"
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
        edit = "update tbl_user set nama_user='" & namaUser.Text & "',password='" & password.Text & "',status='" & status.Text & "',level='" & level.Text & "'where nama_user='" & namaUser.Text & "'"
        cmd = New MySqlCommand(edit, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Update", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_DoubleClick(sender As Object, e As EventArgs) Handles DataGridView1.DoubleClick
        Call Koneksi()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        cmd = New MySqlCommand("select * from tbl_user where nama_user='" & DataGridView1.Item(0, i).Value & "'", conn)
        rd = cmd.ExecuteReader
        rd.Read()
        If Not rd.HasRows Then
            namaUser.Focus()
        Else
            namaUser.Text = rd.Item("nama_user")
            password.Text = rd.Item("password")
            status.Text = rd.Item("status")
            level.Text = rd.Item("level")
            namaUser.Focus()
        End If
    End Sub

    Private Sub hapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        Call Koneksi()
        Dim hapus As String
        hapus = "delete from tbl_user where nama_user='" & namaUser.Text & "'"
        cmd = New MySqlCommand(hapus, conn)
        cmd.ExecuteNonQuery()
        MsgBox("Data Berhasil di Hapus", MsgBoxStyle.Information, "Informasi")
        Call KondisiAwal()
    End Sub

    Private Sub keluar_Click(sender As Object, e As EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

    Private Sub kosongkan_Click(sender As Object, e As EventArgs) Handles kosongkan.Click
        Call KondisiAwal()
    End Sub
End Class