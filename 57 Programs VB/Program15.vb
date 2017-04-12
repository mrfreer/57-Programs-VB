Imports System.Security.Cryptography
Imports System.Text

Public Class Program15
    Public Function CreateRandomSalt() As String
        'the following is the string that will hold the salt charachters
        Dim mix As String = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789!@#$%^&*()_+=][}{<>"
        Dim salt As String = ""
        Dim rnd As New Random
        Dim sb As New StringBuilder
        For i As Integer = 1 To 100 'Length of the salt
            Dim x As Integer = rnd.Next(0, mix.Length - 1)
            salt &= (mix.Substring(x, 1))
        Next
        Return salt
    End Function

    Public Function Hash512(password As String, salt As String) As String
        Dim convertedToBytes As Byte() = Encoding.UTF8.GetBytes(password & salt)
        Dim hashType As HashAlgorithm = New SHA512Managed()
        Dim hashBytes As Byte() = hashType.ComputeHash(convertedToBytes)
        Dim hashedResult As String = Convert.ToBase64String(hashBytes)
        Return hashedResult
    End Function
    ' Taken from: http://www.visual-basic-tutorials.com/hasing-password-with-salt-in-visual-basic.htm#sthash.A55TFrjT.dpuf



    Dim password As String = "12345"
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim hashedPW As String = Hash512(password, CreateRandomSalt)
        Dim userInput As String = Hash512(MaskedTextBox1.Text, CreateRandomSalt)
        If hashedPW = userInput Then
            MsgBox("Welcome buddy!")
        Else
            MsgBox("Wrong password!")
        End If
    End Sub
End Class