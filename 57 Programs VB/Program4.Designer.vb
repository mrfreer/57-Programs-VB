<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program4
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.TextBoxNoun = New System.Windows.Forms.TextBox()
        Me.TextBoxVerb = New System.Windows.Forms.TextBox()
        Me.TextBoxAdjective = New System.Windows.Forms.TextBox()
        Me.TextBoxAdverb = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(101, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter a noun:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(101, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Enter a verb:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 114)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Enter an adjective:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(101, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(86, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Enter an adverb:"
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(101, 187)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(0, 13)
        Me.LabelResult.TabIndex = 4
        '
        'TextBoxNoun
        '
        Me.TextBoxNoun.Location = New System.Drawing.Point(204, 50)
        Me.TextBoxNoun.Name = "TextBoxNoun"
        Me.TextBoxNoun.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxNoun.TabIndex = 5
        '
        'TextBoxVerb
        '
        Me.TextBoxVerb.Location = New System.Drawing.Point(204, 78)
        Me.TextBoxVerb.Name = "TextBoxVerb"
        Me.TextBoxVerb.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxVerb.TabIndex = 6
        '
        'TextBoxAdjective
        '
        Me.TextBoxAdjective.Location = New System.Drawing.Point(204, 111)
        Me.TextBoxAdjective.Name = "TextBoxAdjective"
        Me.TextBoxAdjective.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAdjective.TabIndex = 7
        '
        'TextBoxAdverb
        '
        Me.TextBoxAdverb.Location = New System.Drawing.Point(204, 145)
        Me.TextBoxAdverb.Name = "TextBoxAdverb"
        Me.TextBoxAdverb.Size = New System.Drawing.Size(100, 20)
        Me.TextBoxAdverb.TabIndex = 8
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(104, 223)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Make Adlib"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Program4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(457, 487)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBoxAdverb)
        Me.Controls.Add(Me.TextBoxAdjective)
        Me.Controls.Add(Me.TextBoxVerb)
        Me.Controls.Add(Me.TextBoxNoun)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Program4"
        Me.Text = "Program4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents TextBoxNoun As TextBox
    Friend WithEvents TextBoxVerb As TextBox
    Friend WithEvents TextBoxAdjective As TextBox
    Friend WithEvents TextBoxAdverb As TextBox
    Friend WithEvents Button1 As Button
End Class
