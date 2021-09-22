Public Class UploadJadwal

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub UserProfileButton_Click(sender As Object, e As EventArgs) Handles UserProfileButton.Click
        Me.Hide()
        Profile.Show()
    End Sub

    Private Sub RegistrasiUserButton_Click(sender As Object, e As EventArgs) Handles RegistrasiUserButton.Click
        Me.Hide()
        RegistrasiUser.Show()
    End Sub

    Private Sub RegistrasiAdminButton_Click(sender As Object, e As EventArgs) Handles RegistrasiAdminButton.Click
        Me.Hide()
        RegistrasiAdmin.Show()
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        Login.Close()
    End Sub
End Class