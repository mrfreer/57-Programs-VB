Public Class Program17
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim BAC As Double = 0
        If RadioButtonMale.Checked Then
            'male
            BAC = (NumericUpDownAlcohol.Value * 5.14 / NumericUpDownWeight.Value * 0.73) - 0.015 * NumericUpDownHours.Value
        Else
            BAC = (NumericUpDownAlcohol.Value * 5.14 / NumericUpDownWeight.Value * 0.66) - 0.015 * NumericUpDownHours.Value
        End If
        If BAC >= 0.08 Then

            MsgBox("Your BAC is " & BAC & " it is not legal for you to drive.")
        Else
            If BAC < 0 Then
                BAC = 0
            End If
            MsgBox("Your BAC is " & BAC & " it is legal for you to drive.")
        End If

    End Sub
End Class