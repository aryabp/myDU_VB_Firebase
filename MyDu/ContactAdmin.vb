Public Class ContactAdmin
    Dim KoneksiContact As New KoneksiFirebase()
    Dim Data As String
    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Me.Hide()
        MyBase.Dispose()
        Login.Show()
    End Sub

    Private Sub Windows_exit(sender As Object, e As EventArgs) Handles Me.Closed
        Login.Close()
    End Sub

    Private Sub ContactAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Data = KoneksiContact.Contacting()
        Dim Dat As String()
        Dat = Data.Split("|")
        Guna2ComboBox1.Items.AddRange(Dat(1).Split(","))
        Guna2ComboBox2.Items.AddRange(Dat(3).Split(","))
        Guna2ComboBox3.Items.AddRange(Dat(2).Split(","))
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        Dim Dat As String()
        Dat = Data.Split("|")
        If Guna2ComboBox1.SelectedIndex > -1 And Guna2ComboBox2.SelectedIndex > -1 And Guna2ComboBox3.SelectedIndex > -1 _
            And Not Guna2TextBox1.Text = "" And Not Guna2TextBox2.Text = "" And Not Guna2TextBox3.Text = "" _
            And Not Guna2TextBox4.Text = "" And Not Guna2TextBox5.Text = "" Then
            KoneksiContact.SendInbox(Dat(0).Split(",")(Guna2ComboBox1.SelectedIndex))
            Me.Hide()
            MyBase.Dispose()
            Login.Show()
        Else
            MessageBox.Show("Fill the data completely !")
        End If
    End Sub
End Class