Public Class ResetPassword

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Hide()
        MyBase.Dispose()
        Login.Show()
    End Sub

    Private Sub Windows_exit(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub
End Class