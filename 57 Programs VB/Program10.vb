Public Class Program10
    Dim numTextBoxes As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        numTextBoxes = NumericUpDown1.Value
        Dim allTextBoxes(numTextBoxes) As TextBox
        For a As Integer = 0 To numTextBoxes - 1
            Dim tb As New TextBox
            Dim lbl As New Label

            tb.Name = "TextBox" + a.ToString
            lbl.Name = "Label" + a.ToString
            lbl.Text = "Enter Item:"
            tb.Location = New Point(200, 200 + (a * 25))
            lbl.Location = New Point(100, 200 + (a * 25))
            Me.Controls.Add(tb)
            Me.Controls.Add(lbl)
            allTextBoxes(a) = tb
        Next

        Dim btn As New Button
        btn.Location = New Point(200, 200 + (numTextBoxes * 25))
        btn.Text = "Add Orders"
        btn.Name = "AddInfo"
        AddHandler btn.Click, AddressOf addInfo
        Me.Controls.Add(btn)

    End Sub
    Dim totalCost As Double = 0
    Sub addInfo(sender As Object, e As EventArgs)
        totalCost = 0
        Dim value As String = ""
        For Each txtBox As TextBox In Me.Controls.OfType(Of TextBox)()
            value = txtBox.Text

            If value = "Socks" Then
                totalCost += 4.5
            ElseIf value = "Shirt" Then
                totalCost += 10
            ElseIf value = "Pants" Then
                totalCost += 15
            Else
                totalCost += 7
            End If
        Next

        MsgBox("$" + totalCost.ToString("F2") + " is the total cost for " + value + ".")
    End Sub

End Class