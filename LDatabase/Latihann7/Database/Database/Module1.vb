Imports System.Data.OleDb
Module Module1
    Public con As OleDbConnection ' Membuka database
    Public da As OleDbDataAdapter ' Membuka Table
    Public ds As DataSet ' Membuka field table
    Public dr As OleDbDataReader ' Membuka record
    Public cmd As OleDbCommand ' Melakukan perintah2
    Public str As String
    Public pr As Integer
    '   Memanggil master database/Mdb
    Sub koneksi()
        ' Acces 2010 <
        ' str = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=Database.mdb"
        str = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database.accdb"
        con = New OleDbConnection(str)
        con.Open()
    End Sub
End Module
