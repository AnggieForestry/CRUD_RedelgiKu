Imports System.Data.Odbc
Public Class Nilai
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
        TextBox3.MaxLength = 10
        TextBox4.MaxLength = 10
        TextBox7.MaxLength = 3
        TextBox8.MaxLength = 3
        TextBox6.MaxLength = 3
        Button1.Text = "CREATE"
        Button2.Text = "UPDATE"
        Button3.Text = "DELETE"
        Button4.Text = "CLOSE"
        Da = New OdbcDataAdapter("Select * From nilai", Conn)
        Ds = New DataSet
        Da.Fill(Ds, "nilai")
        DataGridView1.DataSource = Ds.Tables("nilai")
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim InputData As String = "INSERT INTO nilai VALUES ('" & TextBox3.Text & "','" & TextBox4.Text & "','" & TextBox7.Text & "','" & TextBox8.Text & "','" & TextBox6.Text & "')"
            Cmd = New OdbcCommand(InputData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Pastikan semua Field terisi !")
        Else
            Call Koneksi()
            Dim EditData As String = "UPDATE nilai SET Latihan='" & TextBox7.Text & "', Quiz='" & TextBox8.Text & "', TO='" & TextBox6.Text & "' WHERE ID_Murid= '" & TextBox3.Text & "', ID_Mapel= '" & TextBox4.Text & "' "
            Cmd = New OdbcCommand(EditData, Conn)
            Cmd.ExecuteNonQuery()
            MsgBox("Input Data Berhasil")
            Call KondisiAwal()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If TextBox3.Text = "" Or TextBox4.Text = "" Or TextBox7.Text = "" Or TextBox8.Text = "" Or TextBox6.Text = "" Then
            MsgBox("Pastikan data yang akan dihapus terisi !")
        Else
            Call Koneksi()
            Dim HapusData As String = "DELETE FROM nilai WHERE ID_Murid = '" & TextBox3.Text & "' AND ID_Mapel = '" & TextBox4.Text & "'"
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