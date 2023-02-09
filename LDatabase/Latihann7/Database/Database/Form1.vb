Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        tampil_data()
    End Sub
    Private Sub tampil_data()
        da = New OleDbDataAdapter("Select * From barang", con)
        ds = New DataSet
        da.Fill(ds, "barang")
        DataGridView1.DataSource = ds
        DataGridView1.DataMember = "barang"
        If ds.Tables("barang").Rows.Count <> 0 Then
            Tkodebrg.Text = ds.Tables("barang").Rows(pr)("kodebrg")
            Tnamabrg.Text = ds.Tables("barang").Rows(pr)("namabrg")
            Tharga.Text = ds.Tables("barang").Rows(pr)("harga")
            Tstock.Text = ds.Tables("barang").Rows(pr)("stock")
        End If
    End Sub
    ' Tombol awal dan akhir
    Private Sub awal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles awal.Click
        pr = 0
        tampil_data()
    End Sub

    Private Sub sebelum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sebelum.Click
        If pr = 0 Then
            MsgBox("Record data sudah paling awal")
        Else
            pr -= 1
            tampil_data()
        End If
    End Sub

    Private Sub sesudah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles sesudah.Click
        If pr = ds.Tables("barang").Rows.Count - 1 Then
            MsgBox("Record data sudah paling akhir")
        Else
            pr += 1
            tampil_data()
        End If
    End Sub

    Private Sub akhir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles akhir.Click
        pr = ds.Tables("barang").Rows.Count - 1
        tampil_data()
    End Sub
    ' Menambah Record
    Private Sub add_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles add.Click
        If add.Text = "Add" Then
            add.Text = "Save"
            bersih_form()
        Else
            ' Memanggil Sub simpan_data()
            simpan_data()
        End If
    End Sub
    Sub bersih_form()
        Tkodebrg.Text = ""
        Tnamabrg.Text = ""
        Tharga.Text = ""
        Tstock.Text = ""
    End Sub
    Private Sub simpan_data()
        If Tkodebrg.Text = "" Or Tnamabrg.Text = "" Or Tharga.Text = "" Or Tstock.Text = "" Then
            MsgBox("Data masih ada yang kosong")
        Else
            pr = 0
            Dim simpan As String = "Insert into barang(kodebrg, namabrg, harga, stock) Values('" & Tkodebrg.Text & "', '" & Tnamabrg.Text & "', '" & Val(Tharga.Text) & "', '" & Val(Tstock.Text) & "')"
            cmd = New OleDbCommand(simpan, con)
            cmd.ExecuteNonQuery()
            pr = ds.Tables("barang").Rows.Count
            tampil_data()
            add.Text = "Add"
        End If
    End Sub

    Private Sub cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cancel.Click
        pr = 0
        tampil_data()
        add.Text = "Add"
    End Sub

    Private Sub keluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles keluar.Click
        Me.Close()
    End Sub

    Private Sub edit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles edit.Click
        If edit.Text = "Edit" Then
            edit.Text = "Save"
        Else
            edit.Text = "Edit"
            Dim edit_data As String = "Update barang set namabrg = '" & Tnamabrg.Text & "', harga = '" & Tharga.Text & "', stock = '" & Tstock.Text & "', Where kodebrg = '" & Tkodebrg.Text & "'"
            cmd = New OleDbCommand(edit_data, con)
            cmd.ExecuteNonQuery()
            Call tampil_data()
        End If
    End Sub
End Class