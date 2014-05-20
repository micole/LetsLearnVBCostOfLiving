<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.Test1 = New System.Windows.Forms.TextBox()
        Me.Doubled = New System.Windows.Forms.TextBox()
        Me.LWages = New System.Windows.Forms.Label()
        Me.LTaxes = New System.Windows.Forms.Label()
        Me.MWages = New System.Windows.Forms.TextBox()
        Me.Taxes = New System.Windows.Forms.TextBox()
        Me.LDiscretionary = New System.Windows.Forms.Label()
        Me.DiscretionaryIncome = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Test1
        '
        Me.Test1.Location = New System.Drawing.Point(238, 43)
        Me.Test1.Name = "Test1"
        Me.Test1.Size = New System.Drawing.Size(100, 20)
        Me.Test1.TabIndex = 0
        '
        'Doubled
        '
        Me.Doubled.Location = New System.Drawing.Point(389, 81)
        Me.Doubled.Name = "Doubled"
        Me.Doubled.Size = New System.Drawing.Size(100, 20)
        Me.Doubled.TabIndex = 1
        '
        'LWages
        '
        Me.LWages.AutoSize = True
        Me.LWages.Location = New System.Drawing.Point(82, 88)
        Me.LWages.Name = "LWages"
        Me.LWages.Size = New System.Drawing.Size(84, 13)
        Me.LWages.TabIndex = 2
        Me.LWages.Text = "Monthly Wages:"
        '
        'LTaxes
        '
        Me.LTaxes.AutoSize = True
        Me.LTaxes.Location = New System.Drawing.Point(60, 118)
        Me.LTaxes.Name = "LTaxes"
        Me.LTaxes.Size = New System.Drawing.Size(106, 13)
        Me.LTaxes.TabIndex = 3
        Me.LTaxes.Text = "Taxes (28% normally)"
        '
        'MWages
        '
        Me.MWages.Location = New System.Drawing.Point(172, 85)
        Me.MWages.Name = "MWages"
        Me.MWages.Size = New System.Drawing.Size(100, 20)
        Me.MWages.TabIndex = 4
        '
        'Taxes
        '
        Me.Taxes.Location = New System.Drawing.Point(172, 115)
        Me.Taxes.Name = "Taxes"
        Me.Taxes.Size = New System.Drawing.Size(100, 20)
        Me.Taxes.TabIndex = 5
        '
        'LDiscretionary
        '
        Me.LDiscretionary.AutoSize = True
        Me.LDiscretionary.Location = New System.Drawing.Point(17, 622)
        Me.LDiscretionary.Name = "LDiscretionary"
        Me.LDiscretionary.Size = New System.Drawing.Size(149, 13)
        Me.LDiscretionary.TabIndex = 6
        Me.LDiscretionary.Text = "Monthly Discretionary Income:"
        '
        'DiscretionaryIncome
        '
        Me.DiscretionaryIncome.Location = New System.Drawing.Point(172, 619)
        Me.DiscretionaryIncome.Name = "DiscretionaryIncome"
        Me.DiscretionaryIncome.Size = New System.Drawing.Size(100, 20)
        Me.DiscretionaryIncome.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(501, 705)
        Me.Controls.Add(Me.DiscretionaryIncome)
        Me.Controls.Add(Me.LDiscretionary)
        Me.Controls.Add(Me.Taxes)
        Me.Controls.Add(Me.MWages)
        Me.Controls.Add(Me.LTaxes)
        Me.Controls.Add(Me.LWages)
        Me.Controls.Add(Me.Doubled)
        Me.Controls.Add(Me.Test1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Test1 As System.Windows.Forms.TextBox
    Friend WithEvents Doubled As System.Windows.Forms.TextBox
    Friend WithEvents LWages As System.Windows.Forms.Label
    Friend WithEvents LTaxes As System.Windows.Forms.Label
    Friend WithEvents MWages As System.Windows.Forms.TextBox
    Friend WithEvents Taxes As System.Windows.Forms.TextBox
    Friend WithEvents LDiscretionary As System.Windows.Forms.Label
    Friend WithEvents DiscretionaryIncome As System.Windows.Forms.TextBox

End Class
