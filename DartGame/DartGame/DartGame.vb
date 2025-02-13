﻿'Justin Bell
'RCET3371  
'Spring2025
'https://github.com/ju8t1n203/DartGame

Option Compare Text
Option Explicit On
Option Strict On
Imports System.IO
Public Class DartGame
    Dim dartCount As Integer
    Dim turnCount As Integer = 1
    Dim filePath As String = IO.Path.Combine(Application.StartupPath, "..\..\..\Summary.txt")

    Private Sub DartGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    'dart stuff----------------
    Private Sub DartGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        'when space is pressed a dart is added to the board
        If e.KeyCode = Keys.Space And dartCount < 3 Then
            DrawDart()
            e.Handled = True
            dartCount += 1
            DartLabel.Text = $"Dart: {dartCount}"
            TurnLabel.Text = $"Turn: {turnCount}"
            'stops adding darts to the board
            If dartCount = 3 Then
                InstructionsLabel.Text = "Out of darts, start new turn"
                NewTurnButton.Enabled = True
                e.Handled = True
            End If
            'ensures no glitches happen from an excess of keystrokes
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub DrawDart()
        'draws the dart
        Dim xPosition As Integer = GetRandomNumber(0, 594)
        Dim yPosition As Integer = GetRandomNumber(0, 339)
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics()
        g.FillEllipse(Brushes.Black, xPosition, yPosition, 10, 10)
        g.Dispose()
        'saves the dart
        Dim line As String = String.Format("Turn: {0}    Dart: {1}    X Coordinate: {2}    Y Coordinate: {3}", turnCount, dartCount + 1, xPosition, yPosition)
        File.AppendAllText(filePath, line & vbTab & Environment.NewLine)

    End Sub

    Function GetRandomNumber(max%, min%) As Integer
        Dim randomNumber%
        Randomize(DateTime.Now.Millisecond)
        randomNumber = CInt(Math.Floor(Rnd() * (max - min + 1))) + min
        Return randomNumber%
        'creates a random number in a specified range
    End Function

    'buttons-------------------
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        'clears the the summary file
        If File.Exists(filePath) Then
            File.WriteAllText(filePath, String.Empty)
        End If

        Me.Close()
    End Sub

    Private Sub NewTurnButton_Click(sender As Object, e As EventArgs) Handles NewTurnButton.Click
        dartCount = 0
        turnCount += 1
        DartLabel.Text = $"Dart: 1"
        TurnLabel.Text = $"Turn: {turnCount}"
        DartBoardPictureBox.Image = Nothing
        InstructionsLabel.Text = "Press space to throw darts"
        NewTurnButton.Enabled = False
    End Sub

    Private Sub ViewSummaryButton_Click(sender As Object, e As EventArgs) Handles ViewSummaryButton.Click
        If File.Exists(filePath) Then
            Dim summaryText As String = File.ReadAllText(filePath)
            MessageBox.Show(summaryText, "Summary", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Summary file not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

End Class