Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBoxProgram.Text = "1" Then
            Program1.Show()
        ElseIf TextBoxProgram.Text = "2" Then
            Program2.Show()
        ElseIf TextBoxProgram.Text = "4" Then
            Program4.Show()
        ElseIf TextBoxProgram.Text = "5" Then
            Program5.Show()
        Else
            Dim programToMake As String = "Program"
            programToMake += TextBoxProgram.Text
            getallforms(Me, programToMake)
        End If


    End Sub

    Public Sub getallforms(ByVal sender As Object, progName As String)
        Dim Forms As New List(Of Form)()
        Dim formType As Type = Type.GetType("System.Windows.Forms.Form")
        For Each t As Type In sender.GetType().Assembly.GetTypes()
            If UCase(t.BaseType.ToString) = "SYSTEM.WINDOWS.FORMS.FORM" And t.Name = progName Then
                showForm(progName, t)
            End If
        Next
    End Sub

    Public Sub showForm(programToMake As String, formType As Type)
        Dim frmNewForm As Form = Nothing
        'Dim assemblyName As String = System.Reflection.Assembly.GetAssembly()
        frmNewForm = CType(Activator.CreateInstance(formType), Form)
        frmNewForm.Show()
    End Sub
End Class
