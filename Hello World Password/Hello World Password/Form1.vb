Public Class Form1

    Private Sub txtPassword_TextChanged(sender As Object, e As EventArgs) Handles txtPassword.TextChanged
        


    End Sub

    Private Sub btnSign_Click(sender As Object, e As EventArgs) Handles btnSign.Click
        Dim password As String

        Try
            password = CStr("qwerty5908")
            If txtPassword.Text = password Then
                lblError.Text = "Correct"
            Else
                lblError.Text = "Password is incorrect!!!"
            End If

        Catch ex As Exception


        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
