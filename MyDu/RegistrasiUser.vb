﻿Public Class RegistrasiUser
    Dim mail As String
    Dim fullName As String
    Dim nIMorNRP As String
    Dim prodiorUnit As String
    Dim rank As String
    Dim status As String

    Dim KoneksiRegistrasiUser As New KoneksiFirebase()

    Sub ProfileReciever(ByVal A As String, ByVal B As String, ByVal C As String, ByVal D As String, ByVal E As String, ByVal F As String)

        mail = A
        fullName = B
        nIMorNRP = C
        prodiorUnit = D
        rank = E
        status = F

        UserLabel.Text = fullName

        UserLabel.Left = 833 - fullName.Length * 2.5
        UserPhoto.Left = 754 - fullName.Length * 2.5

        Me.Show()
    End Sub
    Private Sub RegistrasiUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim cek As String()
        If status = "HighAdmin" Then
            RegistrasiAdminButton.Visible = True
        End If
        cek = CStr(KoneksiRegistrasiUser.Contacting()).Split("|")
        Guna2ComboBox1.Items.AddRange(cek(3).Split(","))
        Guna2ComboBox2.Items.AddRange(cek(2).Split(","))
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        Me.Hide()
        MyBase.Dispose()
        Dashboard.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub UserProfileButton_Click(sender As Object, e As EventArgs) Handles UserProfileButton.Click
        Me.Hide()
        MyBase.Dispose()
        Profile.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub UploadJadwalButton_Click(sender As Object, e As EventArgs) Handles UploadJadwalButton.Click
        Me.Hide()
        MyBase.Dispose()
        UploadJadwal.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub RegistrasiAdminButton_Click(sender As Object, e As EventArgs) Handles RegistrasiAdminButton.Click
        Me.Hide()
        MyBase.Dispose()
        RegistrasiAdmin.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub CloseControlBox_Click(sender As Object, e As EventArgs) Handles CloseControlBox.Click
        Login.Close()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Hide()
        MyBase.Dispose()
        Login.LogOut()
    End Sub

    Private Sub Windows_exit(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
    Private Function SHA256(ByVal Content As String) As String
        Dim MoLeCuL3 As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MoLeCuL3.ComputeHash(ByteString)

        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")

        Next
        Return FinalString
    End Function
    Private Sub TambahUser_Click(sender As Object, e As EventArgs) Handles TambahUser.Click
        KoneksiRegistrasiUser.RegisteringUser(SHA256(Email.Text))
    End Sub
End Class