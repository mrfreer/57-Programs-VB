Public Class Program14
    Dim list As New List(Of Double)
    Private Sub Program14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim r As New Random(5)
        For i As Integer = 0 To 49
            list.Add(r.NextDouble() * 15)
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim total As Double = (MaskedTextBox1.Text) * (1 + list.Item(ComboBox1.SelectedIndex) / 100)
        LabelResult.Text = "Total cost $" & total.ToString("N2") & " based on taxes of " &
            list.Item(ComboBox1.SelectedIndex).ToString("N2") & " %"
    End Sub
End Class