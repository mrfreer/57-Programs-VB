<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program1
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
        Me.TextBoxName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.LabelResponse = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TextBoxName
        '
        Me.TextBoxName.Location = New System.Drawing.Point(202, 61)
        Me.TextBoxName.Name = "TextBoxName"
        Me.TextBoxName.Size = New System.Drawing.Size(138, 20)
        Me.TextBoxName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(87, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "What is your name?"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(202, 122)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Click Here"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'LabelResponse
        '
        Me.LabelResponse.AutoSize = True
        Me.LabelResponse.Location = New System.Drawing.Point(199, 92)
        Me.LabelResponse.Name = "LabelResponse"
        Me.LabelResponse.Size = New System.Drawing.Size(0, 13)
        Me.LabelResponse.TabIndex = 3
        '
        'Program1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 491)
        Me.Controls.Add(Me.LabelResponse)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TextBoxName)
        Me.Name = "Program1"
        Me.Text = "Hello World"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBoxName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents LabelResponse As Label
End Class
