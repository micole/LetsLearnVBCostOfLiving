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
        Me.SuspendLayout()
        '
        'Test1
        '
        Me.Test1.Location = New System.Drawing.Point(12, 81)
        Me.Test1.Name = "Test1"
        Me.Test1.Size = New System.Drawing.Size(100, 20)
        Me.Test1.TabIndex = 0
        '
        'Doubled
        '
        Me.Doubled.Location = New System.Drawing.Point(157, 81)
        Me.Doubled.Name = "Doubled"
        Me.Doubled.Size = New System.Drawing.Size(100, 20)
        Me.Doubled.TabIndex = 1
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(284, 262)
        Me.Controls.Add(Me.Doubled)
        Me.Controls.Add(Me.Test1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Test1 As System.Windows.Forms.TextBox
    Friend WithEvents Doubled As System.Windows.Forms.TextBox

End Class
