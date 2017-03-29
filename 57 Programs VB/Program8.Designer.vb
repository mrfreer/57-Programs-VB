<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program8
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxNumPeople = New System.Windows.Forms.MaskedTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxNumPizzas = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MaskedTextBoxSlices = New System.Windows.Forms.MaskedTextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelResults = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(30, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "How many people?"
        '
        'MaskedTextBoxNumPeople
        '
        Me.MaskedTextBoxNumPeople.Location = New System.Drawing.Point(171, 35)
        Me.MaskedTextBoxNumPeople.Name = "MaskedTextBoxNumPeople"
        Me.MaskedTextBoxNumPeople.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxNumPeople.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(33, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "How many pizzas?"
        '
        'MaskedTextBoxNumPizzas
        '
        Me.MaskedTextBoxNumPizzas.Location = New System.Drawing.Point(171, 83)
        Me.MaskedTextBoxNumPizzas.Name = "MaskedTextBoxNumPizzas"
        Me.MaskedTextBoxNumPizzas.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxNumPizzas.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(33, 124)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "How many slices per pizza?"
        '
        'MaskedTextBoxSlices
        '
        Me.MaskedTextBoxSlices.Location = New System.Drawing.Point(171, 124)
        Me.MaskedTextBoxSlices.Name = "MaskedTextBoxSlices"
        Me.MaskedTextBoxSlices.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxSlices.TabIndex = 5
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(36, 212)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(222, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Calculate "
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelResults
        '
        Me.LabelResults.AutoSize = True
        Me.LabelResults.Location = New System.Drawing.Point(33, 168)
        Me.LabelResults.Name = "LabelResults"
        Me.LabelResults.Size = New System.Drawing.Size(0, 13)
        Me.LabelResults.TabIndex = 7
        '
        'Program8
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(412, 462)
        Me.Controls.Add(Me.LabelResults)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.MaskedTextBoxSlices)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.MaskedTextBoxNumPizzas)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.MaskedTextBoxNumPeople)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Program8"
        Me.Text = "Program8"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents MaskedTextBoxNumPeople As MaskedTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents MaskedTextBoxNumPizzas As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents MaskedTextBoxSlices As MaskedTextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelResults As Label
End Class
