Public Class Form1

    Private Sub Test1_TextChanged(sender As Object, e As EventArgs) Handles Test1.TextChanged
        UpdateNumbers()
    End Sub

    Private Sub UpdateNumbers()

        'If IsNumeric(Test1.Text) Then
        '    Dim x = Integer.Parse(Test1.Text)
        '    x = x + x
        '    Doubled.Text = x
        'Else
        '    Doubled.Text = "NaN"
        'End If
        If IsNumeric(MWages.Text) And IsNumeric(Taxes.Text) Then
            Dim tax = Double.Parse(Taxes.Text)
            If tax > 0 And tax < 100 Then
                tax = 100 - tax
                tax = tax * 0.01
            Else
                tax = 0.28
                Taxes.Text = "28"
            End If
            Doubled.Text = tax
            DiscretionaryIncome.Text = (Integer.Parse(MWages.Text) * tax)
        Else
            DiscretionaryIncome.Text = "NaN"
        End If


    End Sub

    Private Sub MWages_TextChanged(sender As Object, e As EventArgs) Handles MWages.TextChanged
        UpdateNumbers()
    End Sub

    Private Sub Taxes_TextChanged(sender As Object, e As EventArgs) Handles Taxes.TextChanged
        UpdateNumbers()
    End Sub
End Class
