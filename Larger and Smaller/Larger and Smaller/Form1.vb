Public Class Form1

    Private Sub btnCompare_Click(sender As Object, e As EventArgs) Handles btnCompare.Click
        Dim dblValue1, dblValue2 As Double

        Try
            dblValue1 = CDbl(txtValueA.Text)
            dblValue2 = CDbl(txtValueB.Text)

            If (dblValue1 > dblValue2) Then
                lblAnswer.Text = "Value A is greater than Value B!"
            Else
                lblAnswer.Text = "Value A is less than Value B!"
            End If
            If (dblValue1 = dblValue2) Then
                lblAnswer.Text = "Value A is equal to Value B!"
            End If
        Catch ex As Exception
            lblAnswer.Text = "Values must be numeric!!!"
        End Try
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
