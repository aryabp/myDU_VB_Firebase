Public Class RegistrasiAdmin
    Dim mail As String
    Dim fullName As String
    Dim nIMorNRP As String
    Dim prodiorUnit As String
    Dim rank As String
    Dim status As String

    Dim Data As String()

    Dim KoneksiRegistrasiAdmin As New KoneksiFirebase()

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
    Private Sub RegistrasiAdmin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        InboxPanel.Hide()
        Dim cek As String()
        If status = "HighAdmin" Then
            RegistrasiAdminButton.Visible = True
        End If
        cek = CStr(KoneksiRegistrasiAdmin.Contacting()).Split("|")
        RankCombo.Items.AddRange(cek(3).Split(","))
        ProdiCombo.Items.AddRange(cek(2).Split(","))
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

    Private Sub RegistrasiUserButton_Click(sender As Object, e As EventArgs) Handles RegistrasiUserButton.Click
        Me.Hide()
        MyBase.Dispose()
        RegistrasiUser.ProfileReciever(mail, fullName, nIMorNRP, prodiorUnit, rank, status)
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

    Private Sub TambahAdmin_Click_1(sender As Object, e As EventArgs) Handles TambahAdmin.Click
        KoneksiRegistrasiAdmin.RegisteringAdmin(SHA256(Email.Text))
    End Sub

    Private Sub Inboxbutton_Click(sender As Object, e As EventArgs) Handles Inboxbutton.Click
        Data = CStr(KoneksiRegistrasiAdmin.CheckInbox("Inbox/""" & SHA256(mail) & """/RegisterAdmin")).Split("\")
        NumericUpDown1.Maximum = CInt(Data(0).Split("|").Length / 5) + 1
        NumericUpDown1.Minimum = 1

        Data1.Text = ""
        Data2.Text = ""
        Data3.Text = ""
        Data4.Text = ""
        Data5.Text = ""

        Data1.Enabled = False
        Data2.Enabled = False
        Data3.Enabled = False
        Data4.Enabled = False
        Data5.Enabled = False

        If Data(1).Split("|").Length > 1 Then
            Data1.Text = Data(1).Split("|")(1) & "'s Register form"
            Data1.Enabled = True
        End If
        If Data(1).Split("|").Length > 2 Then
            Data2.Text = Data(1).Split("|")(2) & "'s Register form"
            Data2.Enabled = True
        End If
        If Data(1).Split("|").Length > 3 Then
            Data3.Text = Data(1).Split("|")(3) & "'s Register form"
            Data3.Enabled = True
        End If
        If Data(1).Split("|").Length > 4 Then
            Data4.Text = Data(1).Split("|")(4) & "'s Register form"
            Data4.Enabled = True
        End If
        If Data(1).Split("|").Length > 5 Then
            Data5.Text = Data(1).Split("|")(5) & "'s Register form"
            Data5.Enabled = True
        End If

        InboxPanel.Show()
    End Sub

    Private Sub NumericUpDown1_ValueChanged(sender As Object, e As EventArgs) Handles NumericUpDown1.ValueChanged
        Data1.Checked = False
        Data2.Checked = False
        Data3.Checked = False
        Data4.Checked = False
        Data5.Checked = False

        Data1.Enabled = False
        Data2.Enabled = False
        Data3.Enabled = False
        Data4.Enabled = False
        Data5.Enabled = False

        Data1.Text = ""
        Data2.Text = ""
        Data3.Text = ""
        Data4.Text = ""
        Data5.Text = ""
        If NumericUpDown1.Value >= 2 Then
            Data = CStr(KoneksiRegistrasiAdmin.CheckInbox("Inbox/""" & SHA256(mail) & """/RegisterAdmin")).Split("\")

            If Data(1).Split("|").Length > NumericUpDown1.Value * 5 - 4 Then
                Data1.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 4) & "'s Register form"
                Data1.Enabled = True
            End If
            If Data(1).Split("|").Length > NumericUpDown1.Value * 5 - 3 Then
                Data2.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 3) & "'s Register form"
                Data2.Enabled = True
            End If
            If Data(1).Split("|").Length > NumericUpDown1.Value * 5 - 2 Then
                Data3.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 2) & "'s Register form"
                Data3.Enabled = True
            End If
            If Data(1).Split("|").Length > NumericUpDown1.Value * 5 - 1 Then
                Data4.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 1) & "'s Register form"
                Data4.Enabled = True
            End If
            If Data(1).Split("|").Length > NumericUpDown1.Value * 5 Then
                Data5.Text = Data(1).Split("|")(NumericUpDown1.Value * 5) & "'s Register form"
                Data5.Enabled = True
            End If
        Else
            If Inboxlabel.Visible = True Then
                Data = CStr(KoneksiRegistrasiAdmin.CheckInbox("Inbox/""" & SHA256(mail) & """/RegisterAdmin")).Split("\")

                If Data(1).Split("|").Length > 1 Then
                    Data1.Text = Data(1).Split("|")(1) & "'s Register form"
                    Data1.Enabled = True
                End If
                If Data(1).Split("|").Length > 2 Then
                    Data2.Text = Data(1).Split("|")(2) & "'s Register form"
                    Data2.Enabled = True
                End If
                If Data(1).Split("|").Length > 3 Then
                    Data3.Text = Data(1).Split("|")(3) & "'s Register form"
                    Data3.Enabled = True
                End If
                If Data(1).Split("|").Length > 4 Then
                    Data4.Text = Data(1).Split("|")(4) & "'s Register form"
                    Data4.Enabled = True
                End If
                If Data(1).Split("|").Length > 5 Then
                    Data5.Text = Data(1).Split("|")(5) & "'s Register form"
                    Data5.Enabled = True
                End If
            End If
        End If
    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        If Data1.Checked Then
            NamaLengkapTextBox.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 4)
            NIMNRPTextBox.Text = Data(2).Split("|")(NumericUpDown1.Value * 5 - 4)
            Email.Text = Data(0).Split("|")(NumericUpDown1.Value * 5 - 4)
            Username.Text = Data(6).Split("|")(NumericUpDown1.Value * 5 - 4)
            Password.Text = Data(3).Split("|")(NumericUpDown1.Value * 5 - 4)
            RankCombo.Text = Data(4).Split("|")(NumericUpDown1.Value * 5 - 4)
            ProdiCombo.Text = Data(5).Split("|")(NumericUpDown1.Value * 5 - 4)
        ElseIf Data2.Checked Then
            NamaLengkapTextBox.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 3)
            NIMNRPTextBox.Text = Data(2).Split("|")(NumericUpDown1.Value * 5 - 3)
            Email.Text = Data(0).Split("|")(NumericUpDown1.Value * 5 - 3)
            Username.Text = Data(6).Split("|")(NumericUpDown1.Value * 5 - 3)
            Password.Text = Data(3).Split("|")(NumericUpDown1.Value * 5 - 3)
            RankCombo.Text = Data(4).Split("|")(NumericUpDown1.Value * 5 - 3)
            ProdiCombo.Text = Data(5).Split("|")(NumericUpDown1.Value * 5 - 3)
        ElseIf Data3.Checked Then
            NamaLengkapTextBox.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 2)
            NIMNRPTextBox.Text = Data(2).Split("|")(NumericUpDown1.Value * 5 - 2)
            Email.Text = Data(0).Split("|")(NumericUpDown1.Value * 5 - 2)
            Username.Text = Data(6).Split("|")(NumericUpDown1.Value * 5 - 2)
            Password.Text = Data(3).Split("|")(NumericUpDown1.Value * 5 - 2)
            RankCombo.Text = Data(4).Split("|")(NumericUpDown1.Value * 5 - 2)
            ProdiCombo.Text = Data(5).Split("|")(NumericUpDown1.Value * 5 - 2)
        ElseIf Data4.Checked Then
            NamaLengkapTextBox.Text = Data(1).Split("|")(NumericUpDown1.Value * 5 - 1)
            NIMNRPTextBox.Text = Data(2).Split("|")(NumericUpDown1.Value * 5 - 1)
            Email.Text = Data(0).Split("|")(NumericUpDown1.Value * 5 - 1)
            Username.Text = Data(6).Split("|")(NumericUpDown1.Value * 5 - 1)
            Password.Text = Data(3).Split("|")(NumericUpDown1.Value * 5 - 1)
            RankCombo.Text = Data(4).Split("|")(NumericUpDown1.Value * 5 - 1)
            ProdiCombo.Text = Data(5).Split("|")(NumericUpDown1.Value * 5 - 1)
        ElseIf Data5.Checked Then
            NamaLengkapTextBox.Text = Data(1).Split("|")(NumericUpDown1.Value * 5)
            NIMNRPTextBox.Text = Data(2).Split("|")(NumericUpDown1.Value * 5)
            Email.Text = Data(0).Split("|")(NumericUpDown1.Value * 5)
            Username.Text = Data(6).Split("|")(NumericUpDown1.Value * 5)
            Password.Text = Data(3).Split("|")(NumericUpDown1.Value * 5)
            RankCombo.Text = Data(4).Split("|")(NumericUpDown1.Value * 5)
            ProdiCombo.Text = Data(5).Split("|")(NumericUpDown1.Value * 5)
        Else
            MessageBox.Show("Choose form for deploy !")
        End If
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Dim sum As Int32 = -1
        Dim fix1 As String
        Dim fix2 As String
        Dim fix3 As String
        Dim fix4 As String
        Dim fix5 As String
        Dim fix6 As String
        Dim fix7 As String

        If Data1.Checked Then
            sum = 4
            Inboxbutton.PerformClick()
        ElseIf Data2.Checked Then
            sum = 3
            Inboxbutton.PerformClick()
        ElseIf Data3.Checked Then
            sum = 3
        ElseIf Data4.Checked Then
            sum = 3
        ElseIf Data5.Checked Then

        Else
            MessageBox.Show("Choose form for delete !")
        End If
        If sum > -1 Then
            Dim liste As New List(Of String)
            liste.AddRange(Data(0).Split("|"))
            liste.RemoveAt(CInt(NumericUpDown1.Value * 5 - sum))
            fix1 = String.Join("|", liste.ToArray())
            liste.Clear()
            liste.AddRange(Data(1).Split("|"))
            liste.RemoveAt(CInt(NumericUpDown1.Value * 5 - sum))
            fix2 = String.Join("|", liste.ToArray())
            liste.Clear()
            liste.AddRange(Data(2).Split("|"))
            liste.RemoveAt(CInt(NumericUpDown1.Value * 5 - sum))
            fix3 = String.Join("|", liste.ToArray())
            liste.Clear()
            liste.AddRange(Data(3).Split("|"))
            liste.RemoveAt(CInt(NumericUpDown1.Value * 5 - sum))
            fix4 = String.Join("|", liste.ToArray())
            liste.Clear()
            liste.AddRange(Data(5).Split("|"))
            liste.RemoveAt(CInt(NumericUpDown1.Value * 5 - sum))
            fix5 = String.Join("|", liste.ToArray())
            liste.Clear()
            liste.AddRange(Data(4).Split("|"))
            liste.RemoveAt(CInt(NumericUpDown1.Value * 5 - sum))
            fix6 = String.Join("|", liste.ToArray())
            liste.Clear()
            liste.AddRange(Data(6).Split("|"))
            liste.RemoveAt(CInt(NumericUpDown1.Value * 5 - sum))
            fix7 = String.Join("|", liste.ToArray())
            KoneksiRegistrasiAdmin.DeleteInbox("Inbox/""" & SHA256(mail) & """/RegisterAdmin", fix1, fix2, fix3, fix4, fix5, fix6, fix7)
            Inboxbutton.PerformClick()
        End If

    End Sub
End Class