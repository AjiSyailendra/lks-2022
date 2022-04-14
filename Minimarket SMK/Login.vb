Imports MySql.Data.MySqlClient

Public Class Login
    Sub Admin()
        Form1.LoginToolStripMenuItem.Enabled = False
        Form1.LogutToolStripMenuItem.Enabled = True
        Form1.KeluarToolStripMenuItem.Enabled = True
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = True
        Form1.KategoriToolStripMenuItem.Enabled = True
        Form1.SatuanToolStripMenuItem.Enabled = True
        Form1.BarangToolStripMenuItem.Enabled = True
        Form1.PembelianToolStripMenuItem.Enabled = True
        Form1.PembelianToolStripMenuItem1.Enabled = True
        Form1.SupplierToolStripMenuItem.Enabled = True
        Form1.UserToolStripMenuItem.Enabled = True
    End Sub

    Sub AksesOperator()
        Form1.LoginToolStripMenuItem.Enabled = False
        Form1.LogutToolStripMenuItem.Enabled = True
        Form1.KeluarToolStripMenuItem.Enabled = True
        Form1.MasterToolStripMenuItem.Enabled = True
        Form1.TransaksiToolStripMenuItem.Enabled = True
        Form1.LaporanToolStripMenuItem.Enabled = True
        Form1.KategoriToolStripMenuItem.Enabled = False
        Form1.SatuanToolStripMenuItem.Enabled = False
        Form1.BarangToolStripMenuItem.Enabled = False
        Form1.PembelianToolStripMenuItem.Enabled = True
        Form1.PembelianToolStripMenuItem1.Enabled = True
        Form1.SupplierToolStripMenuItem.Enabled = True
        Form1.UserToolStripMenuItem.Enabled = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username atau Password Wajib di Isi!", MsgBoxStyle.Information, "Informasi")
        Else
            Call Koneksi()
            Dim str As String
            str = "select * from tbl_user where nama_user='" & TextBox1.Text & "'and password='" & TextBox2.Text & "'"
            cmd = New MySqlCommand(str, conn)
            rd = cmd.ExecuteReader
            rd.Read()
            If rd.HasRows Then
                MsgBox("Anda Berhasil Login", MsgBoxStyle.Information, "Informasi")
                Form1.SNama.Text = rd!nama_user
                Form1.SLevel.Text = rd!level
                Form1.SStatus.Text = rd!status

                If Form1.SLevel.Text = "admin" Then
                    Call Admin()
                ElseIf Form1.SLevel.Text = "operator" Then
                    Call AksesOperator()
                End If

                Me.Close()
            Else
                MsgBox("Username atau Password Salah", MsgBoxStyle.Information, "Informasi")
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Focus()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox2.PasswordChar = "*"
    End Sub
End Class