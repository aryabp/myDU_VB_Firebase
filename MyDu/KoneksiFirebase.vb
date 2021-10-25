Imports FireSharp.Config
Imports FireSharp.Response
Imports FireSharp.Interfaces

Public Class KoneksiFirebase

    Private fcon As New FirebaseConfig() With
        {
            .AuthSecret = "hAprYvfDrJCOBzpXppxoSYHJEnL0UeOOW9VH8YAx",
            .BasePath = "https://piketunhan-default-rtdb.asia-southeast1.firebasedatabase.app/"
        }
    Private Client As IFirebaseClient

    Sub Main()
        Try
            Client = New FireSharp.FirebaseClient(fcon)
        Catch ex As Exception

        End Try
    End Sub

    Sub Logining(ByVal A As String, ByVal B As String)
        Try
            Main()
            If A.Contains(".") Then
                A = A.Replace(".", "")
            End If
            Dim res = Client.Get("Auth/Login/" & A)
            Dim pon As New DataID()
            pon = res.ResultAs(Of DataID)
            If A = "" Or B = "" Or IsNothing(pon) Then
                MessageBox.Show("Data tidak valid !")
            ElseIf pon.Pass = B Then
                Dim res1 = Client.Get("Auth/Profile/" & ControlChars.Quote & pon.ID & ControlChars.Quote)
                Dim pon1 As New ProfileData()
                pon1 = res1.ResultAs(Of ProfileData)
                Login.Hide()
                Dashboard.ProfileReciever(pon1.Email, pon1.FullName, pon1.NIMorNRP, pon1.ProdiorUnit, pon1.Rank, pon1.Status)
            Else
                MessageBox.Show("Sudah Mengisi Data Anda Dengan Benar ?")
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Bermasalah !")
        End Try
    End Sub

    Function Contacting()
        Try
            Main()
            Dim res = Client.Get("Auth/Daftar")
            Dim pon As New Auth()
            pon = res.ResultAs(Of Auth)

            Return (pon.AdminID & "|" & pon.DaftarAdmin & "|" & pon.DaftarJabatan & "|" & pon.DaftarProdiorSatuan)
        Catch ex As Exception
            MessageBox.Show("Koneksi Bermasalah !")
            Return ""
        End Try

    End Function

    Function Validating(ByVal A As String)
        Try
            Main()
            If A.Contains(".") Then
                A = A.Replace(".", "")
            ElseIf Not A.Contains("@") And Not A.Contains(".") Then
                MessageBox.Show("Isilah E-mail dengan Benar !")
                Return ""
            Else
                MessageBox.Show("Isilah E-mail dengan Benar !")
                Return ""
            End If

            Dim res = Client.Get("Auth/Login/" & A)
            Dim pon As New DataID()
            pon = res.ResultAs(Of DataID)
            If IsNothing(pon) Then
                MessageBox.Show("Email Tidak Valid !")
                Return ""
            Else
                Return pon.Username & "," & A & "," & pon.ID
            End If
            Return ""
        Catch ex As Exception
            MessageBox.Show("Koneksi Bermasalah !")
            Return ""
        End Try
        Return ""
    End Function

    Sub ResetPassword(ByVal A As String)
        Dim data As String() = A.Split(",")
        Try
            Main()
            Dim ganti As New DataID() With {
                .ID = data(2),
                .Username = data(0),
                .Pass = data(3)}

            Dim res1 = Client.SetAsync("Auth/Login/" & data(0), ganti)
            Dim res2 = Client.SetAsync("Auth/Login/" & data(1), ganti)
            MessageBox.Show("Password Berhasil Diperbarui")
        Catch ex As Exception
            MessageBox.Show("Koneksi Anda Bermasalah !")
        End Try
    End Sub

    Sub SendInbox(ByVal A As String)
        Try
            Main()
            If ContactAdmin.Guna2ComboBox4.Text = "Admin" Then
                Dim res1 = Client.Get("Inbox/""" & A & """/RegisterAdmin")
                Dim pon1 As New DataInbox()
                pon1 = res1.ResultAs(Of DataInbox)

                Dim res As New DataInbox With {
                .Email = pon1.Email & "|" & ContactAdmin.Guna2TextBox3.Text,
                .FullName = pon1.FullName & "|" & ContactAdmin.Guna2TextBox1.Text,
                .NIMorNRP = pon1.NIMorNRP & "|" & ContactAdmin.Guna2TextBox2.Text,
                .ProdiorUnit = pon1.ProdiorUnit & "|" & ContactAdmin.Guna2ComboBox2.Text,
                .Rank = pon1.Rank & "|" & ContactAdmin.Guna2ComboBox3.Text,
                .Username = pon1.Username & "|" & ContactAdmin.Guna2TextBox5.Text,
                .Pass = pon1.Pass & "|" & ContactAdmin.Guna2TextBox4.Text}
                Dim pon = Client.Set("Inbox/""" & A & """/RegisterAdmin", res)
            Else
                Dim res1 = Client.Get("Inbox/""" & A & """/RegisterUser")
                Dim pon1 As New DataInbox()
                pon1 = res1.ResultAs(Of DataInbox)

                Dim res As New DataInbox With {
                .Email = pon1.Email & "|" & ContactAdmin.Guna2TextBox3.Text,
                .FullName = pon1.FullName & "|" & ContactAdmin.Guna2TextBox1.Text,
                .NIMorNRP = pon1.NIMorNRP & "|" & ContactAdmin.Guna2TextBox2.Text,
                .ProdiorUnit = pon1.ProdiorUnit & "|" & ContactAdmin.Guna2ComboBox2.Text,
                .Rank = pon1.Rank & "|" & ContactAdmin.Guna2ComboBox3.Text,
                .Username = pon1.Username & "|" & ContactAdmin.Guna2TextBox5.Text,
                .Pass = pon1.Pass & "|" & ContactAdmin.Guna2TextBox4.Text}
                Dim pon = Client.Set("Inbox/""" & A & """/RegisterUser", res)
            End If
            MessageBox.Show("Your register form has been sent.")
        Catch ex As Exception
            MessageBox.Show("Koneksi Anda Bermasalah !")
        End Try
    End Sub

    Sub RegisteringAdmin(ByVal A As String)
        Try
            Main()
            Dim res0 = Client.Get("Auth/Login/" & RegistrasiAdmin.Username.Text)
            Dim pon0 As New DataID()
            pon0 = res0.ResultAs(Of DataID)
            If (IsNothing(pon0)) Then
                Dim res As New DataID With {
                    .ID = A,
                    .Pass = RegistrasiAdmin.Password.Text,
                    .Username = RegistrasiAdmin.Username.Text}
                Dim pon = Client.Set("Auth/Login/" & RegistrasiAdmin.Username.Text, res)
                Dim pon1 = Client.Set("Auth/Login/" & RegistrasiAdmin.Email.Text.Replace(".", ""), res)

                Dim res1 As New ProfileData With {
                    .Email = RegistrasiAdmin.Email.Text,
                    .FullName = RegistrasiAdmin.NamaLengkapTextBox.Text,
                    .NIMorNRP = RegistrasiAdmin.NIMNRPTextBox.Text,
                    .ProdiorUnit = RegistrasiAdmin.Guna2ComboBox1.Text,
                    .Rank = RegistrasiAdmin.Guna2ComboBox2.Text,
                    .Status = "Admin",
                    .Username = RegistrasiAdmin.Username.Text}
                Dim pon2 = Client.Set("Auth/Profile/""" & A & """", res1)

                Dim res2 As New DataInbox With {
                    .Email = "",
                    .FullName = "",
                    .NIMorNRP = "",
                    .ProdiorUnit = "",
                    .Rank = "",
                    .Pass = "",
                    .Username = ""}
                Dim pon3 = Client.Set("Inbox/""" & A & """/RegisterUser", res2)

                Dim pon4 = Client.Get("Auth/Daftar")
                Dim res3 As New Auth()
                res3 = pon4.ResultAs(Of Auth)

                Dim res4 As New Auth With {
                    .AdminID = res3.AdminID & "," & A,
                    .DaftarAdmin = res3.DaftarAdmin & "," & String.Format("{0} ({1} {2} {3})", RegistrasiAdmin.NamaLengkapTextBox.Text, "Admin", RegistrasiAdmin.Guna2ComboBox2.Text, RegistrasiAdmin.Guna2ComboBox1.Text),
                    .DaftarJabatan = res3.DaftarJabatan,
                    .DaftarProdiorSatuan = res3.DaftarProdiorSatuan}
                Dim pon5 = Client.Set("Auth/Daftar", res4)
                MessageBox.Show(RegistrasiAdmin.NamaLengkapTextBox.Text & "'s Account has been Registered !")
            Else
                MessageBox.Show("Username has been taken !")
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Anda Bermasalah")
        End Try
    End Sub

    Sub RegisteringUser(ByVal A As String)
        Try
            Main()
            Dim res0 = Client.Get("Auth/Login/" & RegistrasiUser.Username.Text)
            Dim pon0 As New DataID()
            pon0 = res0.ResultAs(Of DataID)
            If (IsNothing(pon0)) Then
                Dim res As New DataID With {
                    .ID = A,
                    .Pass = RegistrasiUser.Password.Text,
                    .Username = RegistrasiUser.Username.Text}
                Dim pon = Client.Set("Auth/Login/" & RegistrasiUser.Username.Text, res)
                Dim pon1 = Client.Set("Auth/Login/" & RegistrasiUser.Email.Text.Replace(".", ""), res)

                Dim res1 As New ProfileData With {
                    .Email = RegistrasiUser.Email.Text,
                    .FullName = RegistrasiUser.NamaLengkapTextBox.Text,
                    .NIMorNRP = RegistrasiUser.NIMNRPTextBox.Text,
                    .ProdiorUnit = RegistrasiUser.Guna2ComboBox1.Text,
                    .Rank = RegistrasiUser.Guna2ComboBox2.Text,
                    .Status = "Admin",
                    .Username = RegistrasiUser.Username.Text}
                Dim pon2 = Client.Set("Auth/Profile/""" & A & """", res1)

                MessageBox.Show(RegistrasiUser.NamaLengkapTextBox.Text & "'s Account has been Registered !")
            Else
                MessageBox.Show("Username has been taken !")
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi Anda Bermasalah")
        End Try
    End Sub
End Class
Public Class DataID
    Public Property ID As String
    Public Property Pass As String
    Public Property Username As String
End Class
Public Class ProfileData
    Public Property Email As String
    Public Property FullName As String
    Public Property NIMorNRP As String
    Public Property ProdiorUnit As String
    Public Property Rank As String
    Public Property Status As String
    Public Property Username As String
End Class
Public Class Auth
    Public Property DaftarJabatan As String
    Public Property DaftarProdiorSatuan As String
    Public Property DaftarAdmin As String
    Public Property AdminID As String
End Class
Public Class DataInbox
    Inherits ProfileData
    Public Property Pass As String
End Class