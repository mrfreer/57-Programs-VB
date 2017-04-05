Public Class Program13
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim amt As Double = TextBoxPrincipal.Text * (1 + (TextBoxRate.Text / 100) / TextBoxCompounded.Text) ^ (TextBoxCompounded.Text * TextBoxTime.Text)
        LabelResult.Text = "$" & amt.ToString("F2")
    End Sub
End Class