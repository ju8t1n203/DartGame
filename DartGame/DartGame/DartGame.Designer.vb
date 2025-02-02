<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DartGame
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
        Me.NewTurnButton = New System.Windows.Forms.Button()
        Me.ViewSummaryButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NewTurnButton
        '
        Me.NewTurnButton.Location = New System.Drawing.Point(12, 384)
        Me.NewTurnButton.Name = "NewTurnButton"
        Me.NewTurnButton.Size = New System.Drawing.Size(131, 54)
        Me.NewTurnButton.TabIndex = 0
        Me.NewTurnButton.Text = "&New Turn"
        Me.NewTurnButton.UseVisualStyleBackColor = True
        '
        'ViewSummaryButton
        '
        Me.ViewSummaryButton.Location = New System.Drawing.Point(149, 384)
        Me.ViewSummaryButton.Name = "ViewSummaryButton"
        Me.ViewSummaryButton.Size = New System.Drawing.Size(131, 54)
        Me.ViewSummaryButton.TabIndex = 0
        Me.ViewSummaryButton.Text = "View &Summary"
        Me.ViewSummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(286, 384)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(131, 54)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DartGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ViewSummaryButton)
        Me.Controls.Add(Me.NewTurnButton)
        Me.Name = "DartGame"
        Me.Text = "Darts"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents NewTurnButton As Button
    Friend WithEvents ViewSummaryButton As Button
    Friend WithEvents ExitButton As Button
End Class
