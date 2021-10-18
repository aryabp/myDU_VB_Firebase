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
            MessageBox.Show("Koneksi aman !")
        Catch ex As Exception
            MessageBox.Show("Koneksi Bermasalah !")
        End Try
    End Sub

    Sub Logining(ByVal A As String, ByVal B As String)
        If A.Contains(".") Then
            A = A.Replace(".", "")
        End If
        Dim res = Client.Get("Auth/Login/" & A)
        Dim pon As New DataID()
        pon = res.ResultAs(Of DataID)
        If IsNothing(pon) Then
            MessageBox.Show("Data tidak valid !")
        ElseIf pon.Pass = B Then
            Dim res1 = Client.Get("Auth/Profile/" & ControlChars.Quote & pon.ID & ControlChars.Quote)
            Dim pon1 As New ProfileData()
            pon1 = res1.ResultAs(Of ProfileData)
            Login.Hide()
            Dashboard.ProfileReciever(pon1.Email, pon1.FullName, pon1.NIMorNRP, pon1.ProdiorUnit, pon1.Rank, pon1.Status)
        Else

        End If
    End Sub

End Class
Public Class DataID
    Public Property ID As String
    Public Property Pass As String
End Class
Public Class ProfileData
    Public Property Email As String
    Public Property FullName As String
    Public Property NIMorNRP As String
    Public Property ProdiorUnit As String
    Public Property Rank As String
    Public Property Status As String
End Class