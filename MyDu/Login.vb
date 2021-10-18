Public Class Login
    Public Property Status As String
    Public Property Username As String

    Dim KoneksiLogin As New KoneksiFirebase()

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        If Guna2TextBox1.UseSystemPasswordChar = True Then
            Guna2TextBox1.UseSystemPasswordChar = False
        Else
            Guna2TextBox1.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Guna2TextBox2.Text = ""

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click

        KoneksiLogin.Main()
        KoneksiLogin.Logining(Guna2TextBox2.Text, Guna2TextBox1.Text)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        KoneksiLogin.Contacting()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        ResetPassword.Show()
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub LogOut()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Me.Show()
    End Sub
End Class