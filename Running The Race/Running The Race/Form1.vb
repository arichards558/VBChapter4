Public Class Form1

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim dblTime1, dblTime2, dblTime3 As Double

        dblTime1 = txtFinish1.Text
        dblTime2 = txtFinish2.Text
        dblTime3 = txtFinish3.Text

        Try
            If dblTime1 < dblTime2 And dblTime1 < dblTime3 And dblTime2 < dblTime3 Then
                lblFirst.Text = txtRunner1.Text
                lblSecond.Text = txtRunner2.Text
                lblThird.Text = txtRunner3.Text


            End If
        Catch ex As Exception

        End Try



    End Sub
End Class
