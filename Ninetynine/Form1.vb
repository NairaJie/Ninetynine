Imports MySql.Data.MySqlClient
Public Class Form1
    Dim strkon As String = "server=localhost;uid=root;database=dbpegawai07"
    Dim kon As New MySqlConnection(strkon)
    Dim perintah As New MySqlCommand
    Dim cek As MySqlDataReader
    Dim mda As New MySqlDataAdapter
    Dim ds As New DataSet
    Dim jenkel As String

    Sub tidakaktif()
        txtid.Enabled = False
        txtnama.Enabled = False
        rbl.Enabled = False
        rbp.Enabled = False
        txtlahir.Enabled = False
        dtplahir.Enabled = False
        txtnohp.Enabled = False
        txtalamat.Enabled = False

        txtid.BackColor = Color.LightBlue
        txtnama.BackColor = Color.LightBlue
        rbl.BackColor = Color.LightBlue
        rbp.BackColor = Color.LightBlue
        txtlahir.BackColor = Color.LightBlue
        dtplahir.BackColor = Color.LightBlue
        txtnohp.BackColor = Color.LightBlue
        txtalamat.BackColor = Color.LightBlue

        cmdsimpan.Enabled = False
        cmdbatal.Enabled = False
        cmdhapus.Enabled = False
        cmdupdate.Enabled = False

    End Sub


    Sub aktif()
        txtid.Enabled = True
        txtnama.Enabled = True
        rbl.Enabled = True
        rbp.Enabled = True
        txtlahir.Enabled = True
        dtplahir.Enabled = True
        txtnohp.Enabled = True
        txtalamat.Enabled = True

        txtid.BackColor = Color.White
        txtnama.BackColor = Color.White
        rbl.BackColor = Color.White
        rbp.BackColor = Color.White
        txtlahir.BackColor = Color.White
        dtplahir.BackColor = Color.White
        txtnohp.BackColor = Color.White
        txtalamat.BackColor = Color.White

        cmdsimpan.Enabled = True
        cmdbatal.Enabled = True
        cmdhapus.Enabled = True
        cmdupdate.Enabled = True
    End Sub

    Sub bersih()
        txtid.Text = ""
        txtnama.Text = ""
        txtlahir.Text = ""
        txtnohp.Text = ""
        txtalamat.Text = ""
    End Sub

    Sub tampil()
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "select * from karyawan07"
        mda.SelectCommand = perintah
        ds.Tables.Clear()
        mda.Fill(ds, "karyawan07")
        Dgtampil.DataSource = ds.Tables("karyawan07")
        kon.Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        tidakaktif()
        bersih()
        tampil()
    End Sub

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "SELECT * from karyawan07 where id='" & txtid.Text & "'"
        cek = perintah.ExecuteReader
        cek.Read()
        If cek.HasRows Then
            txtnama.Text = cek.Item("Nama")
            jenkel = cek.Item("JenisKelamin")
            If jenkel = "L" Then
                rbl.Checked = True
            Else
                rbp.Checked = True
            End If
            txtlahir.Text = cek.Item("TempatLahir")
            dtplahir.Value = cek.Item("TanggalLahir")
            txtnohp.Text = cek.Item("NoHP")
            txtalamat.Text = cek.Item("alamat")
        End If
        kon.Close()
    End Sub

    Private Sub cmdtambah_Click(sender As Object, e As EventArgs) Handles cmdtambah.Click
        aktif()
        txtid.Focus()
        cmdtambah.Enabled = False
    End Sub

    Private Sub cmdsimpan_Click(sender As Object, e As EventArgs) Handles cmdsimpan.Click
        If rbl.Checked = True Then
            jenkel = "Laki-Laki"
        Else
            jenkel = "Perempuan"
        End If
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "insert into karyawan07 values " &
        " ('" & txtid.Text & "','" & txtnama.Text & "', " &
        " '" & jenkel & "','" & txtlahir.Text & "', " &
        " '" & Format(dtplahir.Value, "yyyy-MM-dd") & "','" & txtnohp.Text &
        "','" & txtalamat.Text & "')"
        perintah.ExecuteNonQuery()
        kon.Close()
        MsgBox("data berhasil disimpan", MsgBoxStyle.Information, "Pesan")
        tampil()
        bersih()
        tidakaktif()
        cmdtambah.Enabled = True

    End Sub

    Private Sub cmdbatal_Click(sender As Object, e As EventArgs) Handles cmdbatal.Click
        tidakaktif()
        bersih()
        cmdtambah.Enabled = True
    End Sub

    Private Sub cmdhapus_Click(sender As Object, e As EventArgs) Handles cmdhapus.Click
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "delete from karyawan where idkaryawan='" & txtid.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()

    End Sub

    Private Sub cmdupdate_Click(sender As Object, e As EventArgs) Handles cmdupdate.Click
        If rbl.Checked = True Then
            jenkel = "Laki-Laki"
        Else
            jenkel = "Perempuan"
        End If
        kon.Open()
        perintah.Connection = kon
        perintah.CommandType = CommandType.Text
        perintah.CommandText = "update karyawan07 set Nama ='" & txtnama.Text & "', " &
        " JenisKelamin ='" & jenkel & "', TempatLahir='" & txtlahir.Text & "', " &
        " TanggalLahir ='" & Format(dtplahir.Value, "yyyy-MM-dd") & "', NoHP ='" & txtnohp.Text & "', " &
        " alamat ='" & txtalamat.Text & "' where id ='" & txtid.Text & "'"
        perintah.ExecuteNonQuery()
        kon.Close()
        tampil()
        bersih()
        tidakaktif()
    End Sub

    Private Sub cmdkeluar_Click(sender As Object, e As EventArgs) Handles cmdkeluar.Click
        End
    End Sub
End Class
