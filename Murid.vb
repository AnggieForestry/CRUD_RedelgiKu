Imports System.Data.Odbc
Public Class murid
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

    Sub KondisiAwal()
        Call Koneksi()
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox6.Text = ""
        TextBox9.Text = ""
        TextBox10.Text = ""
        TextBox13.Text = ""
        TextBox12.Text = ""
        TextBox3.MaxLength = 10
        TextBox4.MaxLength = 10
        TextBox7.MaxLength = 20
        TextBox8.MaxLength = 1
        TextBox6.MaxLength = 20
        TextBox9.MaxLength = 20
        TextBox10.MaxLength = 10
        TextBox13.MaxLength = 30
        TextBox12.MaxLength = 20
        Button1.Text = "CREATE"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "CLOSE"
        Da = New OdbcDataAdapter("Select * From murid", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "murid")
        DataGridView1.DataSource = Ds.Tables("murid")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox13.Text = "" Or TextBox12.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO murid VALUES ('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "','" & TextBox13.Text & "','" & TextBox12.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox13.Text = "" Or TextBox12.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim EditData As String = "UPDATE murid SET ID_Mapel='" & TextBox4.Text & "',Nama_Murid='" & TextBox6.Text & "', Jenis_Kelamin='" & TextBox8.Text & "',Tgl_Lahir='" & TextBox12.Text & "',Alamat='" & TextBox9.Text & "',Kelas='" & TextBox10.Text & "',Jurusan'" & TextBox13.Text & "',No_Telp='" & TextBox7.Text & "' WHERE ID_Murid= '" & TextBox3.Text & "'"
            Cmd = New OdbcCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub


    'JANGAN DULU MAKE INI
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox1.KeyPress
        If e.KeyChar = Chr(13) Then
            Call Koneksi()
            Cmd = New OdbcCommand("SELECT * FROM murid WHERE ID_Murid ='" & TextBox3.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox4.Text = Rd.Item("ID_Mapel")
                TextBox6.Text = Rd.Item("Nama_Murid")
                TextBox12.Text = Rd.Item("Tgl_Lahir")
                TextBox8.Text = Rd.Item("Jenis_Kelamin")
                TextBox9.Text = Rd.Item("Alamat")
                TextBox10.Text = Rd.Item("Kelas")
                TextBox13.Text = Rd.Item("Jurusan")
                TextBox7.Text = Rd.Item("No_Telp")
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Or TextBox13.Text = "" Or TextBox12.Text = "" Then
            MsgBox("Pastikan data yang akan dihapus terisi !")
        Else
            Call Koneksi()
            Dim HapusData As String = "DELETE FROM murid WHERE ID_Murid= '" & TextBox3.Text & "'"
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