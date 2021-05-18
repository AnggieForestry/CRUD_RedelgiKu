Imports System.Data.Odbc
Public Class pilihmapel
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


    Sub KondisiAwal()
        Call Koneksi()
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox3.MaxLength = 10
        TextBox4.MaxLength = 10
        Button1.Text = "CREATE"
        Button3.Text = "DELETE"
        Button4.Text = "CLOSE"
        Button1.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
        Da = New OdbcDataAdapter("Select * From pilihmapel", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "pilihmapel")
        DataGridView1.DataSource = Ds.Tables("pilihmapel")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO pilihmapel VALUES ('" & TextBox4.Text & "','" & TextBox3.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Then
            MsgBox("Pastikan data yang akan dihapus terisi !")
        Else
            Call Koneksi()
            Dim HapusData As String = "DELETE FROM pilihmapel WHERE ID_Murid= '" & TextBox3.Text & "' AND ID_Mapel= '" & TextBox4.Text & "'"
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