Public Class Form1

    Private Sub btnInsult_Click(sender As Object, e As EventArgs) Handles btnInsult.Click
        Dim intAge As Integer
        Try
            intAge = txtAge.Text

            If intAge < 10 Then
                lblInsult.Text = "Can you even read?"
            ElseIf intAge >= 10 And intAge < 14 Then
                lblInsult.Text = "There are no words to express how naive you are."
            ElseIf intAge >= 14 And intAge < 18 Then
                lblInsult.Text = "You have no clue how the real world works."
            ElseIf intAge >= 18 And intAge < 24 Then
                lblInsult.Text = "Arrested for underage drinking, but after 21, its public intoxication and DUI"
            ElseIf intAge >= 24 And intAge < 30 Then
                lblInsult.Text = "Congratulations you had your first kid."
            ElseIf intAge >= 30 And intAge < 40 Then
                lblInsult.Text = "Mid-Life Crisis"
            ElseIf intAge >= 40 And intAge < 60 Then
                lblInsult.Text = "Your parents have probably died by now."
            ElseIf intAge >= 60 Then
                lblInsult.Text = "Retirement funds and the light at the end of the tunnel"

            End If
        Catch ex As Exception
            lblMessage.Text = "Please enter a numeric value"
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtAge.Clear()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
