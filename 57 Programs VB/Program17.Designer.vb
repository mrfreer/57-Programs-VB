<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Program17
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
        Me.NumericUpDownAlcohol = New System.Windows.Forms.NumericUpDown()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.NumericUpDownWeight = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NumericUpDownHours = New System.Windows.Forms.NumericUpDown()
        Me.RadioButtonMale = New System.Windows.Forms.RadioButton()
        Me.RadioButtonFemale = New System.Windows.Forms.RadioButton()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDownAlcohol, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDownHours, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NumericUpDownAlcohol
        '
        Me.NumericUpDownAlcohol.Location = New System.Drawing.Point(408, 58)
        Me.NumericUpDownAlcohol.Name = "NumericUpDownAlcohol"
        Me.NumericUpDownAlcohol.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownAlcohol.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(233, 60)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(146, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Alcohol consumed in ounces:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(236, 101)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Body weight in pounds:"
        '
        'NumericUpDownWeight
        '
        Me.NumericUpDownWeight.Location = New System.Drawing.Point(408, 99)
        Me.NumericUpDownWeight.Maximum = New Decimal(New Integer() {1000, 0, 0, 0})
        Me.NumericUpDownWeight.Name = "NumericUpDownWeight"
        Me.NumericUpDownWeight.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownWeight.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(239, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(161, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Number of hours since last drink:"
        '
        'NumericUpDownHours
        '
        Me.NumericUpDownHours.Location = New System.Drawing.Point(408, 150)
        Me.NumericUpDownHours.Name = "NumericUpDownHours"
        Me.NumericUpDownHours.Size = New System.Drawing.Size(120, 20)
        Me.NumericUpDownHours.TabIndex = 5
        '
        'RadioButtonMale
        '
        Me.RadioButtonMale.AutoSize = True
        Me.RadioButtonMale.Location = New System.Drawing.Point(242, 211)
        Me.RadioButtonMale.Name = "RadioButtonMale"
        Me.RadioButtonMale.Size = New System.Drawing.Size(48, 17)
        Me.RadioButtonMale.TabIndex = 6
        Me.RadioButtonMale.TabStop = True
        Me.RadioButtonMale.Text = "Male"
        Me.RadioButtonMale.UseVisualStyleBackColor = True
        '
        'RadioButtonFemale
        '
        Me.RadioButtonFemale.AutoSize = True
        Me.RadioButtonFemale.Location = New System.Drawing.Point(242, 235)
        Me.RadioButtonFemale.Name = "RadioButtonFemale"
        Me.RadioButtonFemale.Size = New System.Drawing.Size(59, 17)
        Me.RadioButtonFemale.TabIndex = 7
        Me.RadioButtonFemale.TabStop = True
        Me.RadioButtonFemale.Text = "Female"
        Me.RadioButtonFemale.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(242, 293)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(286, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Calculate BAC"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Program17
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(726, 503)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.RadioButtonFemale)
        Me.Controls.Add(Me.RadioButtonMale)
        Me.Controls.Add(Me.NumericUpDownHours)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDownWeight)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.NumericUpDownAlcohol)
        Me.Name = "Program17"
        Me.Text = "Program17"
        CType(Me.NumericUpDownAlcohol, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDownHours, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NumericUpDownAlcohol As NumericUpDown
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents NumericUpDownWeight As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents NumericUpDownHours As NumericUpDown
    Friend WithEvents RadioButtonMale As RadioButton
    Friend WithEvents RadioButtonFemale As RadioButton
    Friend WithEvents Button1 As Button
End Class
