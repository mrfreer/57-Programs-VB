Public Class Program12
    Public Function calcInterest() As Double
        Dim total As Double = (CDbl(MaskedTextBox1.Text) * (TrackBarInterest.Value / 100) * TrackBarYears.Value) + MaskedTextBox1.Text
        Return total
    End Function

    Private Sub TrackBarInterest_Scroll_1(sender As Object, e As EventArgs) Handles TrackBarInterest.Scroll
        LabelResult.Text = "$" & calcInterest().ToString & " After " & TrackBarYears.Value.ToString & " years " & " at " & TrackBarInterest.Value.ToString & "% interest."
    End Sub

    Private Sub TrackBarYears_Scroll_1(sender As Object, e As EventArgs) Handles TrackBarYears.Scroll
        LabelResult.Text = "$" & calcInterest().ToString & " After " & TrackBarYears.Value.ToString & " years " & " at " & TrackBarInterest.Value.ToString & "% interest."
    End Sub
End Class