Imports System.Net.Mail

Public Class ResetPassword

    Dim ContactFirebase As New KoneksiFirebase()
    Dim ID As String
    Dim veriCode As String

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Hide()
        MyBase.Dispose()
        Login.Show()
    End Sub

    Private Sub Windows_exit(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub

    Private Sub Guna2GradientButton1_Click(sender As Object, e As EventArgs) Handles Guna2GradientButton1.Click
        ID = ContactFirebase.Validating(Guna2TextBox1.Text)
        If ID = "" Then

        Else
            Try
                Dim Rand As New Random()
                Dim fixrandomNumber As String = String.Format("{0:#######}", Rand.Next(10000, 1000000))

                Dim Smtp_Server As New SmtpClient("smtp.gmail.com", 587)
                Dim e_mail As New MailMessage("servermydu@gmail.com", Guna2TextBox1.Text)

                Smtp_Server.UseDefaultCredentials = True
                Smtp_Server.EnableSsl = True
                Smtp_Server.Credentials = New Net.NetworkCredential("servermydu@gmail.com", "27mei2003")

                e_mail.Subject = "Verification Code Notification"
                e_mail.IsBodyHtml = False
                e_mail.Body = "Hello, " & vbNewLine & "This your verification Code : " & fixrandomNumber & vbNewLine & "Use the Code Immediately and don't share the code to anyone else !"
                Try
                    Smtp_Server.Send(e_mail)
                    MessageBox.Show("Your verification code has been sent to your e-mail")
                    veriCode = fixrandomNumber
                    Guna2TextBox2.Show()
                    Guna2TextBox3.Show()
                    Guna2Button1.Show()
                    Guna2GradientButton1.Hide()
                    Label1.Text = "Code"
                    Guna2TextBox1.Text = ""
                    Guna2TextBox1.PlaceholderText = "enter verification code"
                Catch error_t As Exception
                    MessageBox.Show(error_t.ToString)
                End Try
            Catch error_t As Exception
                MessageBox.Show(error_t.ToString)
            End Try
        End If
    End Sub
    Private Sub ResetPassword_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Guna2TextBox2.Hide()
        Guna2TextBox3.Hide()
        Guna2Button1.Hide()
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Guna2TextBox1.Text = veriCode And Guna2TextBox2.Text = Guna2TextBox3.Text Then
            ContactFirebase.ResetPassword(ID & "," & Guna2TextBox2.Text)
        ElseIf Not Guna2TextBox1.Text = veriCode Then
            MessageBox.Show(" Your verification code is wrong !")
        ElseIf Not Guna2TextBox2.Text = Guna2TextBox3.Text Then
            MessageBox.Show(" Your password confirmation doesn,t match !")
        Else

        End If
    End Sub
End Class