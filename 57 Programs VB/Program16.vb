Public Class Program16
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If NumericUpDown1.Value > 15 Then
            MsgBox("You are old enough to legally drive.")
        Else
            MsgBox("You are not old enough to legally drive.")
        End If
    End Sub
End Class