<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program6
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxCurAge = New System.Windows.Forms.TextBox()
        Me.TextBoxRetire = New System.Windows.Forms.TextBox()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 13)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What is your current age?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 41)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(178, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "At what age would you like to retire?"
        '
        'TextBoxCurAge
        '
        Me.TextBoxCurAge.Location = New System.Drawing.Point(217, 5)
        Me.TextBoxCurAge.Name = "TextBoxCurAge"
        Me.TextBoxCurAge.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCurAge.TabIndex = 2
        '
        'TextBoxRetire
        '
        Me.TextBoxRetire.AcceptsReturn = True
        Me.TextBoxRetire.Location = New System.Drawing.Point(217, 33)
        Me.TextBoxRetire.Name = "TextBoxRetire"
        Me.TextBoxRetire.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRetire.TabIndex = 3
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(13, 86)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(0, 13)
        Me.LabelResult.TabIndex = 4
        '
        'Program6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(399, 461)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.TextBoxRetire)
        Me.Controls.Add(Me.TextBoxCurAge)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Program6"
        Me.Text = "Retirement Calculator"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxCurAge As TextBox
    Friend WithEvents TextBoxRetire As TextBox
    Friend WithEvents LabelResult As Label
End Class
