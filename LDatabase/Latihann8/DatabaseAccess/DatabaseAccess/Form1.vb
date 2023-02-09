Imports System.Data.OleDb
Public Class Form1
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As DataSet
    Dim lokasi As String
    Dim cmd As OleDbCommand
    Sub koneksi()
        lokasi = "Provider = Microsoft.ACE.OLEDB.12.0; Data Source = dbbarang.accdb"
        conn = New OleDbConnection(lokasi)
        If conn.State = ConnectionState.Closed Then conn.Open()
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call MunculData()
        Call Kosongkan()
    End Sub
    Sub MunculData()
        Call koneksi()
        da = New OleDbDataAdapter("Select * From tblbarang", conn)
        ds = New DataSet
        ds.Clear()
        da.Fill(ds, "tblbarang")
        DataGridView1.DataSource = (ds.Tables("tblbarang"))
    End Sub
    Sub Kosongkan()
        Tkodebarang.Text = ""
        Tnamabarang.Text = ""
        Tjumlahbarang.Text = ""
        Thargabarang.Text = ""
        Tsatuanbarang.Text = ""
    End Sub
    Private Sub Bsimpan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bsimpan.Click
        If Tkodebarang.Text = "" Or Tnamabarang.Text = "" Or Tjumlahbarang.Text = "" Or Thargabarang.Text = "" Or Tsatuanbarang.Text = "" Then
            MsgBox("Data Harus Terisi Semua")
        Else
            Call koneksi()
            Dim SimpanData As String = "Insert into tblbarang values ('" & Tkodebarang.Text & "' , '" & Tnamabarang.Text & "' , '" & Tjumlahbarang.Text & "' , '" & Thargabarang.Text & "' , '" & Tsatuanbarang.Text & "')"
            cmd = New OleDbCommand(SimpanData, conn)
            cmd.ExecuteNonQuery()
            MsgBox("Data Tersimpan")
        End If
    End Sub

    Private Sub Bkeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bkeluar.Click
        Me.Close()
    End Sub
End Class
