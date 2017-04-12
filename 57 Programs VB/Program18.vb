Public Class Program18
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.Scroll
        Dim converted As Double = 0.0
        Dim result As String = ""
        If ComboBox1.Text = "Celsius" Then
            'convert to f
            converted = (TrackBar1.Value * (9 / 5.0)) + 32
            result = "Celsius value " + TrackBar1.Value.ToString("N2") + " The temperature in Fahrenheit is " + converted.ToString("N2")
        Else
            'convert to c.
            converted = (TrackBar1.Value - 32) * (5 / 9.0)
            result = "Fahrenheit value " + TrackBar1.Value.ToString("N2") + " The temperature in Celsius is " + converted.ToString("N2")
        End If
        LabelConverted.Text = result

    End Sub


End Class