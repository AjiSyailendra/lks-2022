Public Class Form1
    Sub KondisiAwal()
        LoginToolStripMenuItem.Enabled = True
        LogutToolStripMenuItem.Enabled = False
        KeluarToolStripMenuItem.Enabled = True
        MasterToolStripMenuItem.Enabled = False
        TransaksiToolStripMenuItem.Enabled = False
        LaporanToolStripMenuItem.Enabled = False
        KategoriToolStripMenuItem.Enabled = False
        SatuanToolStripMenuItem.Enabled = False
        BarangToolStripMenuItem.Enabled = False
        PembelianToolStripMenuItem.Enabled = False
        PembelianToolStripMenuItem1.Enabled = False
        SupplierToolStripMenuItem.Enabled = False
        UserToolStripMenuItem.Enabled = False
        SNama.Text = ""
        SLevel.Text = ""
        SStatus.Text = ""
    End Sub
    Private Sub KeluarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KeluarToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub LoginToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoginToolStripMenuItem.Click
        Login.ShowDialog()
    End Sub

    Private Sub LogutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogutToolStripMenuItem.Click
        Call KondisiAwal()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        Login.ShowDialog()
    End Sub

    Private Sub KategoriToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KategoriToolStripMenuItem.Click
        kategori.Show()
    End Sub

    Private Sub SatuanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SatuanToolStripMenuItem.Click
        Satuan.Show()
    End Sub

    Private Sub BarangToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem.Click
        Barang.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SupplierToolStripMenuItem.Click
        Supplier.Show()
    End Sub

    Private Sub UserToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UserToolStripMenuItem.Click
        User.Show()
    End Sub

    Private Sub BarangToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles BarangToolStripMenuItem1.Click
        Barang.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem1.Click
        Pembelian.Show()
    End Sub

    Private Sub PembelianToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PembelianToolStripMenuItem.Click
        Pembelian.Show()
    End Sub

    Private Sub LaporanToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LaporanToolStripMenuItem.Click
        Laporan.Show()
    End Sub
End Class
