Public Class Program9
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim area As Double = MaskedTextBox1.Text * MaskedTextBox2.Text
        Dim gallons As Integer = Math.Ceiling(area / 350)
        LabelResult.Text = "The area is " & area & " and " & gallons & " gallons are needed."
    End Sub
End Class