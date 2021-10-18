Public Class Dashboard
    Dim mail As String
    Dim fullName As String
    Dim nIMorNRP As String
    Dim prodiorUnit As String
    Dim rank As String
    Dim status As String

    Sub ProfileReciever(ByVal A As String, ByVal B As String, ByVal C As String, ByVal D As String, ByVal E As String, ByVal F As String)

        mail = A
        fullName = B
        nIMorNRP = C
        prodiorUnit = D
        rank = E
        status = F

        UserNama.Text = fullName

        UserNama.Left = 833 - fullName.Length * 2.5
        UserPhoto.Left = 754 - fullName.Length * 2.5

        Me.Show()
    End Sub

    Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
    Private Sub UserProfileButton_Click(sender As Object, e As EventArgs) Handles UserProfileButton.Click
        Me.Hide()
        Me.Close()
        Profile.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub UploadJadwalButton_Click(sender As Object, e As EventArgs) Handles UploadJadwalButton.Click
        Me.Hide()
        Me.Close()
        UploadJadwal.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub RegistrasiUserButton_Click(sender As Object, e As EventArgs) Handles RegistrasiUserButton.Click
        Me.Hide()
        Me.Close()
        RegistrasiUser.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub RegistrasiAdminButton_Click(sender As Object, e As EventArgs) Handles RegistrasiAdminButton.Click
        Me.Hide()
        Me.Close()
        RegistrasiAdmin.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub CloseControlBox_Click(sender As Object, e As EventArgs) Handles CloseControlBox.Click
        Login.Close()
    End Sub

    Private Sub LogoutButton_Click(sender As Object, e As EventArgs) Handles LogoutButton.Click
        Me.Hide()
        Me.Close()
        Login.LogOut()
    End Sub

    Private Sub UserNama_Click(sender As Object, e As EventArgs) Handles UserNama.Click

    End Sub

    Private Sub UserPhoto_Click(sender As Object, e As EventArgs) Handles UserPhoto.Click

    End Sub
End Class