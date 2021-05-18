Imports System.Data.Odbc
Public Class Mapel
    Dim Conn As OdbcConnection
    Dim Cmd As OdbcCommand
    Dim Ds As DataSet
    Dim Da As OdbcDataAdapter
    Dim Rd As OdbcDataReader
    Dim MyDB As String
    Sub Koneksi()
        MyDB = "Driver={MySQL ODBC 3.51 Driver};Database=redelgiku2;Server=localhost;uid=root"
        Conn = New OdbcConnection(MyDB)
        If Conn.State = ConnectionState.Closed Then Conn.Open()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
    Sub KondisiAwal()
        Call Koneksi()
        TextBox2.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox9.Text = ""
        TextBox2.Enabled = False
        TextBox4.Enabled = False
        TextBox7.Enabled = False
        TextBox9.Enabled = False
        TextBox2.MaxLength = 8
        TextBox4.MaxLength = 8
        TextBox7.MaxLength = 20
        TextBox9.MaxLength = 20
        Button1.Text = "CREATE"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "CLOSE"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Da = New OdbcDataAdapter("Select * From mapel", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "mapel")
        DataGridView1.DataSource = Ds.Tables("mapel")
    End Sub
    Sub FieldAktif()
        TextBox2.Enabled = True
        TextBox4.Enabled = True
        TextBox7.Enabled = True
        TextBox9.Enabled = True
        TextBox1.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "CREATE" Then
            Button1.Text = "CREATE"
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Text = "CLOSE"
            Call FieldAktif()
        End If
        If TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO mapel VALUES ('" & TextBox9.Text & "','" & TextBox7.Text & "','" & TextBox4.Text & "','" & TextBox2.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim EditData As String = "UPDATE mapel SET ID_Pegawai='" & TextBox4.Text & "', Nama_Mapel='" & TextBox7.Text & "', Nama_Ruangan='" & TextBox9.Text & "' WHERE ID_Mapel= '" & TextBox2.Text & "'"
            Cmd = New OdbcCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub


    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox2.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox9.Text = "" Then
            MsgBox("Pastikan data yang akan dihapus terisi !")
        Else
            Call Koneksi()
            Dim HapusData As String = "DELETE FROM mapel WHERE ID_Mapel= '" & TextBox2.Text & "'"
            Cmd = New OdbcCommand(HapusData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Hapus Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If Button4.Text = "CLOSE" Then
            End
        Else
            Call KondisiAwal()
        End If
        End
    End Sub
End Class