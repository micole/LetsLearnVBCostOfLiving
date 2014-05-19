Public Class Form1

    Private Sub Test1_TextChanged(sender As Object, e As EventArgs) Handles Test1.TextChanged
        UpdateNumbers()
    End Sub

    Private Sub UpdateNumbers()
        Dim x = Integer.Parse(Test1.Text)
        x = x + x
        Doubled.Text = x

    End Sub
End Class
