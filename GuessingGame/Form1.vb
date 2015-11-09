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
        If guess < MIN Or guess > MAX Then      'invalid guess
            MessageBox.Show("Guess out of range.")
        ElseIf guess = secretNumber Then        'Correct
            Me.lblMessage.Text = "You guessed it!"
            'MessageBox.Show(count)
        Else                                    'too low or too high
            Call GiveHint(secretNumber, guess, Me.lblMessage) 'Add label name here
        End If
    End Sub
    'Determine if firstNum is larger than secondNum and then displays an appropriate message.
    '
    'post: A message has been displayed in a message box.
    '
    Sub GiveHint(ByVal firstNum As Integer, ByVal secondNum As Integer, ByRef lblLabel As Label)
        If firstNum > secondNum Then
            lblLabel.Text = "Too low."
        Else
            lblLabel.Text = "Too high."
        End If
    End Sub
End Class
