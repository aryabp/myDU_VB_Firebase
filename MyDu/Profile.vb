Public Class Profile

    Private Sub DashboardButton_Click(sender As Object, e As EventArgs) Handles DashboardButton.Click
        Me.Hide()
        Dashboard.Show()
    End Sub

    Private Sub UploadJadwalButton_Click(sender As Object, e As EventArgs) Handles UploadJadwalButton.Click
        Me.Hide()
        UploadJadwal.Show()
    End Sub

    Private Sub RegistrasiUserButton_Click(sender As Object, e As EventArgs) Handles RegistrasiUserButton.Click
        Me.Hide()
        RegistrasiUser.Show()
    End Sub

    Private Sub RegistrasiAdminButton_Click(sender As Object, e As EventArgs) Handles RegistrasiAdminButton.Click
        Me.Hide()
        RegistrasiAdmin.Show()
    End Sub

    Private Sub CloseControlBox_Click(sender As Object, e As EventArgs) Handles CloseControlBox.Click
        Login.Close()
    End Sub

End Class