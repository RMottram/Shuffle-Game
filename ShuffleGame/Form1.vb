Public Class HelpScreen

    Private Sub btnGame_Click(sender As Object, e As EventArgs) Handles btnGame.Click

        'button that sends user back to the game and closes the help screen 
        ShuffleGame.Show()
        Me.Hide()

    End Sub
End Class