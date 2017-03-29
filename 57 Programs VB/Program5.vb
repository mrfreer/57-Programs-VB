Public Class Program5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num1 As Integer = Convert.ToInt32(TextBox1.Text)
        Dim num2 As Integer = Convert.ToInt32(TextBox2.Text)
        Dim add As Integer = num1 + num2
        Dim subtract As Integer = num1 - num2
        Dim multiply As Integer = num1 * num2
        Dim divide As Integer = num1 / num2
        LabelResult.Text = num1 & " + " & num2 & " = " & add & vbNewLine & num1 & " - " & num2 & " = " & subtract & vbNewLine _
            & num1 & " * " & num2 & " = " & multiply & vbNewLine & num1 & " / " & num2 & " = " & divide
    End Sub
End Class