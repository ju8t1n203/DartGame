'Justin Bell
'RCET3371  
'Spring2025
'https://github.com/ju8t1n203/DartGame

Option Compare Text
Option Explicit On
Option Strict On

Public Class DartGame
    Private Sub DartGame_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.KeyPreview = True
    End Sub

    Private Sub DartGame_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Space Then
            DrawDart()
            e.Handled = True
        End If
        'when space is pressed a dart is added to the board
    End Sub

    Private Sub DrawDart()
        Dim g As Graphics = DartBoardPictureBox.CreateGraphics()
        g.FillEllipse(Brushes.Black, GetRandomNumber(0, 599), GetRandomNumber(0, 344), 10, 10)
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
End Class

