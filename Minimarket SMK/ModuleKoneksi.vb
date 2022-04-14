Imports MySql.Data.MySqlClient

Module ModuleKoneksi
    Public conn As MySqlConnection
    Public cmd As MySqlCommand
    Public da As MySqlDataAdapter
    Public rd As MySqlDataReader
    Public ds As DataSet

    Sub Koneksi()
        Dim source As String
        source = "server=localhost;user=root;password=;database=minimarketsmk;Ssl mode=none"
        conn = New MySqlConnection(source)
        If conn.State = ConnectionState.Closed Then
            conn.Open()
        End If
    End Sub
End Module
