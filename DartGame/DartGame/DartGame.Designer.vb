﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
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
        Me.StatsGroupBox = New System.Windows.Forms.GroupBox()
        Me.TurnLabel = New System.Windows.Forms.Label()
        Me.DartLabel = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.InstructionsLabel = New System.Windows.Forms.Label()
        Me.StatsGroupBox.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NewTurnButton
        '
        Me.NewTurnButton.Location = New System.Drawing.Point(210, 389)
        Me.NewTurnButton.Name = "NewTurnButton"
        Me.NewTurnButton.Size = New System.Drawing.Size(131, 54)
        Me.NewTurnButton.TabIndex = 0
        Me.NewTurnButton.Text = "&New Turn"
        Me.NewTurnButton.UseVisualStyleBackColor = True
        '
        'ViewSummaryButton
        '
        Me.ViewSummaryButton.Location = New System.Drawing.Point(347, 389)
        Me.ViewSummaryButton.Name = "ViewSummaryButton"
        Me.ViewSummaryButton.Size = New System.Drawing.Size(131, 54)
        Me.ViewSummaryButton.TabIndex = 0
        Me.ViewSummaryButton.Text = "View &Summary"
        Me.ViewSummaryButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(484, 389)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(131, 54)
        Me.ExitButton.TabIndex = 0
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'StatsGroupBox
        '
        Me.StatsGroupBox.Controls.Add(Me.DartLabel)
        Me.StatsGroupBox.Controls.Add(Me.TurnLabel)
        Me.StatsGroupBox.Location = New System.Drawing.Point(12, 387)
        Me.StatsGroupBox.Name = "StatsGroupBox"
        Me.StatsGroupBox.Size = New System.Drawing.Size(193, 51)
        Me.StatsGroupBox.TabIndex = 1
        Me.StatsGroupBox.TabStop = False
        Me.StatsGroupBox.Text = "Stats"
        '
        'TurnLabel
        '
        Me.TurnLabel.AutoSize = True
        Me.TurnLabel.Location = New System.Drawing.Point(7, 23)
        Me.TurnLabel.Name = "TurnLabel"
        Me.TurnLabel.Size = New System.Drawing.Size(32, 13)
        Me.TurnLabel.TabIndex = 2
        Me.TurnLabel.Text = "Turn:"
        '
        'DartLabel
        '
        Me.DartLabel.AutoSize = True
        Me.DartLabel.Location = New System.Drawing.Point(97, 23)
        Me.DartLabel.Name = "DartLabel"
        Me.DartLabel.Size = New System.Drawing.Size(30, 13)
        Me.DartLabel.TabIndex = 2
        Me.DartLabel.Text = "Dart:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Location = New System.Drawing.Point(12, 26)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(599, 344)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'InstructionsLabel
        '
        Me.InstructionsLabel.AutoSize = True
        Me.InstructionsLabel.Location = New System.Drawing.Point(244, 7)
        Me.InstructionsLabel.Name = "InstructionsLabel"
        Me.InstructionsLabel.Size = New System.Drawing.Size(132, 13)
        Me.InstructionsLabel.TabIndex = 3
        Me.InstructionsLabel.Text = "Press space to throw darts"
        '
        'DartGame
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(623, 450)
        Me.Controls.Add(Me.InstructionsLabel)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.StatsGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.ViewSummaryButton)
        Me.Controls.Add(Me.NewTurnButton)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "DartGame"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Darts"
        Me.StatsGroupBox.ResumeLayout(False)
        Me.StatsGroupBox.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NewTurnButton As Button
    Friend WithEvents ViewSummaryButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents StatsGroupBox As GroupBox
    Friend WithEvents TurnLabel As Label
    Friend WithEvents DartLabel As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents InstructionsLabel As Label
End Class
