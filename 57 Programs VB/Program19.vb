Public Class Program19
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BMI As Double = (NumericUpDownWeight.Value / (NumericUpDownHeight.Value * NumericUpDownHeight.Value)) * 703
        If BMI < 18.5 Then
            MsgBox("Your BMI is " & BMI.ToString("N2") & " You are underweight.")
        ElseIf BMI > 25 Then
            MsgBox("Your BMI is " & BMI.ToString("N2") & " You are overweight.")
        Else
            MsgBox("Your BMI is " & BMI.ToString("N2") & " You are within the ideal weight.")
        End If
    End Sub
End Class