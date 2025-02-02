'Justin Bell
'RCET3371  
'Spring2025
'https://github.com/ju8t1n203/DartGame

Option Compare Text
Option Explicit On
Option Strict On

Public Class DartGame
    Dim dartCount As Integer
    Dim turnCount As Integer
    Private Sub DartGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub DartGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space And dartCount < 3 Then
            DrawDart()
            e.Handled = True
            dartCount += 1
            DartLabel.Text = $"Dart: {dartCount}"
            'when space is pressed a dart is added to the board
        Else
            InstructionsLabel.Text = "Out of darts, start new turn"
            e.Handled = True
        End If

    End Sub

    Private Sub DrawDart()
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics()
        g.FillEllipse(Brushes.Black, GetRandomNumber(0, 594), GetRandomNumber(0, 339), 10, 10)
        g.Dispose()
        'draws the dart
    End Sub

    Function GetRandomNumber(max%, min%) As Integer
        Dim randomNumber%
        Randomize(DateTime.Now.Millisecond)
        randomNumber = CInt(Math.Floor(Rnd() * (max - min + 1))) + min
        Return randomNumber%
        'creates a random number in a specified range
    End Function

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub NewTurnButton_Click(sender As Object, e As EventArgs) Handles NewTurnButton.Click
        dartCount = 0
        turnCount += 1
        DartLabel.Text = $"Dart: 1"
        TurnLabel.Text = $"Turn: {turnCount}"
        DartBoardPictureBox.Image = Nothing
        InstructionsLabel.Text = "Press space to throw darts"
    End Sub

End Class

