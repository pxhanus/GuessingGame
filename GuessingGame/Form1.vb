'Patricia Hanus
'150922
'Guessing Game
'______________________________________________________________________________________________________

Public Class Form1
    Const MIN As Integer = 1
    Const MAX As Integer = 50

    Private Sub btnCheckGuess_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCheckGuess.Click
        Randomize()
        Static secretNumber As Integer = Int((MAX - MIN + 1) * Rnd() + MIN)
        Dim guess As Integer

        guess = Val(Me.txtPlayerGuess.Text)
        If guess = secretNumber Then        'Correct
            MessageBox.Show("You guessed it!")
        ElseIf guess < secretNumber Then    'Too low
            MessageBox.Show("Too low.")
        ElseIf guess > secretNumber Then    'Too high
            MessageBox.Show("Too high.")
        End If
    End Sub
End Class
