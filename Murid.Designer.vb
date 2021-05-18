<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class murid
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Murid))
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox11 = New System.Windows.Forms.TextBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.TextBox7 = New System.Windows.Forms.TextBox()
        Me.TextBox8 = New System.Windows.Forms.TextBox()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.TextBox10 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox12 = New System.Windows.Forms.TextBox()
        Me.TextBox13 = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button4.Location = New System.Drawing.Point(542, 203)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(83, 29)
        Me.Button4.TabIndex = 32
        Me.Button4.Text = "DELETE"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button3.Location = New System.Drawing.Point(431, 203)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(83, 29)
        Me.Button3.TabIndex = 31
        Me.Button3.Text = "UPDATE"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button2.Location = New System.Drawing.Point(327, 203)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(83, 29)
        Me.Button2.TabIndex = 29
        Me.Button2.Text = "READ"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(217, 203)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(83, 29)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "CREATE"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.Salmon
        Me.Label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label8.Font = New System.Drawing.Font("Script MT Bold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(333, 46)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(110, 26)
        Me.Label8.TabIndex = 0
        Me.Label8.Text = "Data Murid"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label7.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label7.Location = New System.Drawing.Point(161, 131)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(86, 19)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Nama Murid"
        '
        'Label6
        '
        Me.Label6.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label6.Location = New System.Drawing.Point(479, 106)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 19)
        Me.Label6.TabIndex = 38
        Me.Label6.Text = "Alamat"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label5.Location = New System.Drawing.Point(479, 83)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 19)
        Me.Label5.TabIndex = 37
        Me.Label5.Text = "Jenis Kelamin"
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label4.Location = New System.Drawing.Point(161, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 19)
        Me.Label4.TabIndex = 36
        Me.Label4.Text = "No Telp"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label3.Location = New System.Drawing.Point(479, 129)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 19)
        Me.Label3.TabIndex = 35
        Me.Label3.Text = "Kelas"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label2.Location = New System.Drawing.Point(161, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 19)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "ID_Mapel"
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Location = New System.Drawing.Point(161, 84)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "ID Murid"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(19, 239)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 51
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(763, 162)
        Me.DataGridView1.TabIndex = 30
        '
        'TextBox5
        '
        Me.TextBox5.BackColor = System.Drawing.Color.Bisque
        Me.TextBox5.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox5.Font = New System.Drawing.Font("Gabriola", 13.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox5.Location = New System.Drawing.Point(49, 0)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(88, 38)
        Me.TextBox5.TabIndex = 40
        Me.TextBox5.Text = "RedelgiKu"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Bisque
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(13, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 42
        Me.PictureBox1.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.Bisque
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(800, 38)
        Me.TextBox1.TabIndex = 41
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.Bisque
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 6.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox2.Location = New System.Drawing.Point(328, 426)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(155, 12)
        Me.TextBox2.TabIndex = 44
        Me.TextBox2.Text = "Created by Group 7 - B 2020"
        '
        'TextBox11
        '
        Me.TextBox11.BackColor = System.Drawing.Color.Bisque
        Me.TextBox11.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox11.Font = New System.Drawing.Font("Microsoft Sans Serif", 19.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox11.Location = New System.Drawing.Point(0, 412)
        Me.TextBox11.Name = "TextBox11"
        Me.TextBox11.Size = New System.Drawing.Size(801, 38)
        Me.TextBox11.TabIndex = 43
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(13, 74)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(138, 129)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 45
        Me.PictureBox2.TabStop = False
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(284, 82)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(189, 22)
        Me.TextBox3.TabIndex = 46
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(284, 105)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(189, 22)
        Me.TextBox4.TabIndex = 46
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(284, 128)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(189, 22)
        Me.TextBox6.TabIndex = 46
        '
        'TextBox7
        '
        Me.TextBox7.Location = New System.Drawing.Point(284, 174)
        Me.TextBox7.Name = "TextBox7"
        Me.TextBox7.Size = New System.Drawing.Size(488, 22)
        Me.TextBox7.TabIndex = 46
        '
        'TextBox8
        '
        Me.TextBox8.Location = New System.Drawing.Point(583, 82)
        Me.TextBox8.Name = "TextBox8"
        Me.TextBox8.Size = New System.Drawing.Size(189, 22)
        Me.TextBox8.TabIndex = 46
        '
        'TextBox9
        '
        Me.TextBox9.Location = New System.Drawing.Point(583, 105)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(189, 22)
        Me.TextBox9.TabIndex = 46
        '
        'TextBox10
        '
        Me.TextBox10.Location = New System.Drawing.Point(583, 128)
        Me.TextBox10.Name = "TextBox10"
        Me.TextBox10.Size = New System.Drawing.Size(189, 22)
        Me.TextBox10.TabIndex = 46
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label9.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label9.Location = New System.Drawing.Point(161, 154)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 19)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Tanggal Lahir"
        '
        'Label10
        '
        Me.Label10.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label10.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label10.Location = New System.Drawing.Point(479, 152)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(98, 19)
        Me.Label10.TabIndex = 35
        Me.Label10.Text = "Jurusan"
        '
        'TextBox12
        '
        Me.TextBox12.Location = New System.Drawing.Point(284, 151)
        Me.TextBox12.Name = "TextBox12"
        Me.TextBox12.Size = New System.Drawing.Size(189, 22)
        Me.TextBox12.TabIndex = 46
        '
        'TextBox13
        '
        Me.TextBox13.Location = New System.Drawing.Point(583, 151)
        Me.TextBox13.Name = "TextBox13"
        Me.TextBox13.Size = New System.Drawing.Size(189, 22)
        Me.TextBox13.TabIndex = 46
        '
        'Murid
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.TextBox13)
        Me.Controls.Add(Me.TextBox10)
        Me.Controls.Add(Me.TextBox8)
        Me.Controls.Add(Me.TextBox7)
        Me.Controls.Add(Me.TextBox12)
        Me.Controls.Add(Me.TextBox6)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox11)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Murid"
        Me.Text = "Form4"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox11 As TextBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox6 As TextBox
    Friend WithEvents TextBox7 As TextBox
    Friend WithEvents TextBox8 As TextBox
    Friend WithEvents TextBox9 As TextBox
    Friend WithEvents TextBox10 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents TextBox12 As TextBox
    Friend WithEvents TextBox13 As TextBox
End Class
