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

    Sub Contacting()
        Try
            Main()
            Dim res = Client.Get("Auth")
            Dim pon As New Auth()
            pon = res.ResultAs(Of Auth)

            Dim jabatan As String() = pon.DaftarJabatan.Split(",")
            Dim prodiorSatuan As String() = pon.DaftarProdiorSatuan.Split(",")
            Dim admin As String() = pon.DaftarAdmin.Split(",")

            ContactAdmin.Guna2ComboBox1.Items.AddRange(admin)
            ContactAdmin.Guna2ComboBox2.Items.AddRange(prodiorSatuan)
            ContactAdmin.Guna2ComboBox3.Items.AddRange(jabatan)

            ContactAdmin.Show()
        Catch ex As Exception
            MessageBox.Show("Koneksi Bermasalah !")
        End Try

    End Sub

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
        MessageBox.Show(data(0))
        MessageBox.Show(data(1))
        MessageBox.Show(data(2))
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
End Class