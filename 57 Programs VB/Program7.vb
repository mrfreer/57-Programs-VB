Public Class Program7
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim area As Integer = MaskedTextBoxLength.Text * MaskedTextBoxWidth.Text
        Dim areaM As Double = area * 0.092903
        LabelResult.Text = "The area is " & area & " square feet" & vbNewLine & "The area is " & areaM & " square meters"
    End Sub
End Class