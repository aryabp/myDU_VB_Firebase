Public Class UploadJadwal
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

        Label2.Text = fullName

        Label2.Left = 833 - fullName.Length * 2.5
        Guna2ImageButton2.Left = 754 - fullName.Length * 2.5

        Me.Show()
    End Sub

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        Me.Hide()
        Me.Close()
        Dashboard.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
    End Sub

    Private Sub UserProfileButton_Click(sender As Object, e As EventArgs) Handles UserProfileButton.Click
        Me.Hide()
        Me.Close()
        Profile.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
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

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Login.Close()
    End Sub

    Private Sub Guna2Button7_Click(sender As Object, e As EventArgs) Handles Guna2Button7.Click
        Me.Hide()
        Me.Close()
        Login.LogOut()
    End Sub

    Private Sub Guna2ImageButton2_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton2.Click

    End Sub
End Class