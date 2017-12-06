Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles chkSpinach.CheckedChanged

    End Sub

    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        Dim dblBurger As Double = 5.99
        Dim dblTomato As Double = 0.5
        Dim dblFries As Double = 3.99
        Dim Total As Double

        If radBigButt.Checked = True Then
            lblResult.Text = "You like big butts and you cannot lie"
        ElseIf radBYOB.Checked = True Then
            lblResult.Text = "You get to build your own on this one"
        ElseIf radCCCC.Checked = True Then
            lblResult.Text = "Crispy Chicken Cheese Curd"

        End If
    End Sub
End Class
