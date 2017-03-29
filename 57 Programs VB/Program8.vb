Public Class Program8
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim totalSlices As Integer
        totalSlices = MaskedTextBoxNumPizzas.Text * MaskedTextBoxSlices.Text
        Dim numPerson As Integer = totalSlices / MaskedTextBoxNumPeople.Text
        Dim remainder = totalSlices - (numPerson * MaskedTextBoxNumPeople.Text)
        LabelResults.Text = "Each person gets " & numPerson & " pieces of pizza." & vbNewLine _
            & "There are" & remainder & " leftover pieces."
    End Sub
End Class