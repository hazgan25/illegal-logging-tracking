Imports MySql.Data.MySqlClient
Public Class Form1
    ''change textbox being passwod char
    Private Sub InitialzeMyControl()
        TextBox1.Text = ""
        TextBox2.PasswordChar = "*"
        TextBox2.MaxLength = 14
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox2.UseSystemPasswordChar = True
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If MsgBox("Anda Yakin Ingin Keluar?", MsgBoxStyle.Question Or MsgBoxStyle.YesNo) <> Windows.Forms.DialogResult.Yes Then
        Else
            Me.Close()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim koneksi As MySqlConnection
        koneksi = New MySqlConnection
        koneksi.ConnectionString = "server=localhost; user id=root; password= kadalhijau; database=mplug"
        Try
            koneksi.Open()
        Catch ex As Exception
            MsgBox("Database Gagal! Coba Aktifkan MySQL dan Apache di Xampp.")
        End Try
        Dim adapter As New MySqlDataAdapter
        Dim data = "SELECT * FROM admin WHERE username='" + TextBox1.Text + "' AND password='" + TextBox2.Text + "'"
        Dim command As New MySqlCommand
        command.Connection = koneksi
        command.CommandText = data
        adapter.SelectCommand = command
        Dim dataMasuk As MySqlDataReader
        dataMasuk = command.ExecuteReader()
        If dataMasuk.HasRows = 0 Then
            MsgBox("Login Gagal! Silahkan Coba Lagi. ",
                   MsgBoxStyle.Exclamation, "Login Error")
        Else
            MsgBox("Login berhasil, Selamat datang " & TextBox1.Text & "!", MsgBoxStyle.Information, "Login Berhasil")
            Form2.Show()
            Me.Hide()
            Me.Close()
        End If
    End Sub
End Class
