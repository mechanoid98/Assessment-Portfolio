Public Class SplashScreen

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ProgressBar.Increment(2)
        If ProgressBar.Value = 100 Then 'If the progress bar is full, open the login form
            Me.Visible = False
            LoginForm.Visible = True
            Timer1.Enabled = False 'Disable use of the timer
        End If
    End Sub
End Class