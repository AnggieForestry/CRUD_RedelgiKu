Imports System.Data.Odbc
Public Class Pegawai
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
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call KondisiAwal()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

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
        TextBox3.Enabled = False
        TextBox4.Enabled = False
        TextBox7.Enabled = False
        TextBox8.Enabled = False
        TextBox6.Enabled = False
        TextBox9.Enabled = False
        TextBox10.Enabled = False
        TextBox3.MaxLength = 10
        TextBox4.MaxLength = 100
        TextBox7.MaxLength = 10
        TextBox8.MaxLength = 20
        TextBox6.MaxLength = 20
        TextBox9.MaxLength = 20
        TextBox10.MaxLength = 20
        Button1.Text = "CREATE"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "CLOSE"
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Da = New OdbcDataAdapter("Select * From pegawai", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pegawai")
        DataGridView1.DataSource = Ds.Tables("pegawai")
    End Sub
    Sub FieldAktif()
        TextBox3.Enabled = True
        TextBox4.Enabled = True
        TextBox7.Enabled = True
        TextBox8.Enabled = True
        TextBox6.Enabled = True
        TextBox9.Enabled = True
        TextBox10.Enabled = True
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
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO pegawai VALUES ('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & TextBox6.Text & "','" & TextBox8.Text & "','" & TextBox9.Text & "','" & TextBox10.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim EditData As String = "UPDATE pegawai SET Nama_Pegawai='" & TextBox4.Text & "', Jenis_Kelamin='" & TextBox7.Text & "', Jabatan='" & TextBox6.Text & "',Tgl_Lahir='" & TextBox8.Text & "',Alamat='" & TextBox9.Text & "',No_Telp='" & TextBox10.Text & "' WHERE ID_Pegawai= '" & TextBox3.Text & "'"
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
            Cmd = New OdbcCommand("SELECT * FROM pegawai WHERE nim ='" & TextBox3.Text & "'", Conn)
            Rd = Cmd.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                TextBox4.Text = Rd.Item("Nama_Pegawai")
                TextBox7.Text = Rd.Item("Jenis_Kelamin")
                TextBox8.Text = Rd.Item("Jabatan")
                TextBox6.Text = Rd.Item("Tgl_Lahir")
                TextBox9.Text = Rd.Item("Alamat")
                TextBox10.Text = Rd.Item("No_Telp")
            Else
                MsgBox("Data Tidak Ada")
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox6.Text = "" Or TextBox8.Text = "" Or TextBox9.Text = "" Or TextBox10.Text = "" Then
            MsgBox("Pastikan data yang akan dihapus terisi !")
        Else
            Call Koneksi()
            Dim HapusData As String = "DELETE FROM Pegawai WHERE ID_Pegawai= '" & TextBox3.Text & "'"
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