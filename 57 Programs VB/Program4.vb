Public Class Program4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        LabelResult.Text = "Do you " & TextBoxVerb.Text & " your " & TextBoxAdjective.Text & " " & TextBoxNoun.Text & " " & TextBoxAdverb.Text & "?" & vbNewLine &
            "That's hilarious!"
    End Sub
End Class