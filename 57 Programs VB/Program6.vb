Public Class Program6
    Private Sub TextBoxRetire_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBoxRetire.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Dim curAge = Convert.ToInt32(TextBoxCurAge.Text)
            Dim retireAge = Convert.ToInt32(TextBoxRetire.Text)
            Dim yearsLeft = retireAge - curAge
            Dim curYear = Date.Today.Year
            LabelResult.Text = "You have " & yearsLeft & " years left until you can retire." & vbNewLine &
                "It's " & curYear & ", " & " so you can retire in " & (curYear + yearsLeft) & "."
        End If
    End Sub


End Class