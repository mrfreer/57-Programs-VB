Imports Newtonsoft.Json

Public Class Program11

    Dim result As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim webClient As New System.Net.WebClient
        result = webClient.DownloadString("http://api.fixer.io/latest?base=USD")

        Dim obj = JsonConvert.DeserializeObject(result)
        'RichTextBox1.Text = obj("rates").ToString
        Dim newAmount As Double = MaskedTextBox1.Text * CDbl(obj("rates")(ComboBox1.Text))
        RichTextBox1.Text = "You entered $" & MaskedTextBox1.Text & vbCrLf &
            "The exchange rate is currently " & obj("rates")(ComboBox1.Text) _
            & vbCrLf & "The value will be " & newAmount.ToString
        'I wanted to use a class to deserialize the object 
        'but the anonymous access is convenient 
    End Sub
End Class