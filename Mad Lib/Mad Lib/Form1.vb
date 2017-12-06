Public Class Form1

    Private Sub ListView2_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim strInput As String

        strInput = lstColor.SelectedItem.ToString() & " Dragon is the " & lstEST.SelectedItem.ToString() & " Dragon of all. It has " &
         lstNumber.SelectedItem.ToString() & " " & lstBodyParts.SelectedItem.ToString() & ", and a " & lstAnimals.SelectedItem.ToString() &
         " shaped like a " & lstNoun.SelectedItem.ToString() & ". Dragon also likes to eat " & lstPlural.SelectedItem.ToString() & " cause he is really fat."

        MessageBox.Show(strInput)
    End Sub
End Class
