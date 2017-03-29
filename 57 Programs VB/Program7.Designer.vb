<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program7
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
        Me.LabelResult = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.MaskedTextBoxLength = New System.Windows.Forms.MaskedTextBox()
        Me.MaskedTextBoxWidth = New System.Windows.Forms.MaskedTextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(116, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Length of room in feet?"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(111, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Width of room in feet?"
        '
        'LabelResult
        '
        Me.LabelResult.AutoSize = True
        Me.LabelResult.Location = New System.Drawing.Point(50, 189)
        Me.LabelResult.Name = "LabelResult"
        Me.LabelResult.Size = New System.Drawing.Size(0, 13)
        Me.LabelResult.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(53, 132)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(256, 23)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Calculate Area"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxLength
        '
        Me.MaskedTextBoxLength.BeepOnError = True
        Me.MaskedTextBoxLength.Location = New System.Drawing.Point(200, 45)
        Me.MaskedTextBoxLength.Mask = "000000"
        Me.MaskedTextBoxLength.Name = "MaskedTextBoxLength"
        Me.MaskedTextBoxLength.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxLength.TabIndex = 6
        '
        'MaskedTextBoxWidth
        '
        Me.MaskedTextBoxWidth.Location = New System.Drawing.Point(200, 84)
        Me.MaskedTextBoxWidth.Mask = "000000"
        Me.MaskedTextBoxWidth.Name = "MaskedTextBoxWidth"
        Me.MaskedTextBoxWidth.Size = New System.Drawing.Size(100, 20)
        Me.MaskedTextBoxWidth.TabIndex = 7
        '
        'Program7
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(594, 543)
        Me.Controls.Add(Me.MaskedTextBoxWidth)
        Me.Controls.Add(Me.MaskedTextBoxLength)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.LabelResult)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Program7"
        Me.Text = "Program7"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents LabelResult As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents MaskedTextBoxLength As MaskedTextBox
    Friend WithEvents MaskedTextBoxWidth As MaskedTextBox
End Class
