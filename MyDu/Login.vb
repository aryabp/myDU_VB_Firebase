Imports System.Media
Imports CoreAudio

Public Class Login
    Public Property Status As String
    Public Property Username As String

    Dim KoneksiLogin As New KoneksiFirebase()

    Dim Suara As New SoundPlayer(My.Resources.Mars_TNI__Ciptaan__Addie_MS___320_kbps_)
    Dim DevEnum As New MMDeviceEnumerator()
    Dim device As MMDevice = DevEnum.GetDefaultAudioEndpoint(EDataFlow.eRender, ERole.eMultimedia)

    'Dim lagu As String = My.Resources.Mars_TNI__Ciptaan__Addie_MS___320_kbps_

    Private Sub Guna2CircleButton2_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton2.Click
        If Guna2TextBox1.UseSystemPasswordChar = True Then
            Guna2TextBox1.UseSystemPasswordChar = False
        Else
            Guna2TextBox1.UseSystemPasswordChar = True
        End If

    End Sub

    Private Sub Guna2CircleButton1_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton1.Click
        Guna2TextBox2.Text = ""

    End Sub

    Private Sub Guna2Button1_Click(sender As Object, e As EventArgs) Handles Guna2Button1.Click
        KoneksiLogin.Logining(Guna2TextBox2.Text, Guna2TextBox1.Text)
    End Sub

    Private Sub Guna2Button2_Click(sender As Object, e As EventArgs) Handles Guna2Button2.Click
        Me.Hide()
        KoneksiLogin.Contacting()
    End Sub

    Private Sub Guna2Button4_Click(sender As Object, e As EventArgs) Handles Guna2Button4.Click
        Me.Hide()
        ResetPassword.Show()
    End Sub


    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        TrackBar1.Maximum() = 100
        TrackBar1.Value() = 20
        device.AudioEndpointVolume.MasterVolumeLevelScalar = TrackBar1.Value / 100.0F
        Suara.PlayLooping()
    End Sub

    Sub LogOut()
        Guna2TextBox1.Text = ""
        Guna2TextBox2.Text = ""
        Me.Show()
    End Sub

    Private Sub Guna2CircleButton3_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton3.Click
        If Guna2CircleButton3.Visible = True Then
            Guna2CircleButton3.Hide()
            Guna2CircleButton4.Show()
            device.AudioEndpointVolume.MasterVolumeLevelScalar = 0 / 100.0F
        End If
    End Sub

    Private Sub Guna2CircleButton4_Click(sender As Object, e As EventArgs) Handles Guna2CircleButton4.Click
        If Guna2CircleButton4.Visible = True Then
            Guna2CircleButton4.Hide()
            Guna2CircleButton3.Show()
            device.AudioEndpointVolume.MasterVolumeLevelScalar = TrackBar1.Value / 100.0F
        End If
    End Sub

    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        device.AudioEndpointVolume.MasterVolumeLevelScalar = TrackBar1.Value / 100.0F
    End Sub
End Class