<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program13
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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBoxPrincipal = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxRate = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBoxTime = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxCompounded = New System.Windows.Forms.TextBox()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(93, 216)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBoxPrincipal
        '
        Me.TextBoxPrincipal.Location = New System.Drawing.Point(142, 31)
        Me.TextBoxPrincipal.Name = "TextBoxPrincipal"
        Me.TextBoxPrincipal.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxPrincipal.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Principal ($):"
        '
        'TextBoxRate
        '
        Me.TextBoxRate.Location = New System.Drawing.Point(142, 58)
        Me.TextBoxRate.Name = "TextBoxRate"
        Me.TextBoxRate.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxRate.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Rate (percent):"
        '
        'TextBoxTime
        '
        Me.TextBoxTime.Location = New System.Drawing.Point(142, 85)
        Me.TextBoxTime.Name = "TextBoxTime"
        Me.TextBoxTime.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxTime.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(16, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(67, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Time (years):"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 108)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Compounded per year:"
        '
        'TextBoxCompounded
        '
        Me.TextBoxCompounded.Location = New System.Drawing.Point(142, 112)
        Me.TextBoxCompounded.Name = "TextBoxCompounded"
        Me.TextBoxCompounded.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxCompounded.TabIndex = 8
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(19, 159)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(13, 13)
        Me.LabelResult.TabIndex = 9
        Me.LabelResult.Text = "$"
        '
        'Program13
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(336, 261)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.TextBoxCompounded)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TextBoxTime)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxRate)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxPrincipal)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Program13"
        Me.Text = "Program13"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBoxPrincipal As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxRate As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBoxTime As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxCompounded As TextBox
    Friend WithEvents LabelResult As Label
End Class
