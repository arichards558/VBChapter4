Public Class Form1

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim intNumeral As Integer
        Try
            intNumeral = CInt(txtInteger.Text)
            Select Case intNumeral
                Case Is = 1
                    lblRoman.Text = "I"
                Case Is = 2
                    lblRoman.Text = "II"
                Case Is = 3
                    lblRoman.Text = "III"
                Case Is = 4
                    lblRoman.Text = "IV"
                Case Is = 5
                    lblRoman.Text = "V"
                Case Is = 6
                    lblRoman.Text = "VI"
                Case Is = 7
                    lblRoman.Text = "VII"
                Case Is = 8
                    lblRoman.Text = "VIII"
                Case Is = 9
                    lblRoman.Text = "IX"
                Case Is = 10
                    lblRoman.Text = "X"
            End Select

            If (intNumeral > 10 Or intNumeral < 1) Then
                lblRoman.Text = "Conversion is not available"
            End If
        Catch Ex As Exception
            lblRoman.Text = "All entries must be numeric Values"
        End Try
    End Sub
End Class
