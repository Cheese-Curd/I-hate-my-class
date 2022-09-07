Public Class Form1
    Private Sub MathBtn_Click(sender As Object, e As EventArgs) Handles MathBtn.Click
        ' 9/7/22 - "Learned how to do comments and if statements" bruh

        ' Variables, this still hurts
        Dim nmbr1 As Single
        Dim nmbr2 As Single
        Dim answer As Double ' this is an unneeded variable! why do you teach like this!
        nmbr1 = Number1.Text ' painfully setting variables, why do you teach like this.
        nmbr2 = Number2.Text

        ' Everthing passed this line (in the function) is from 9/7/22

        If MathType.Text = "+" Then
            answer = nmbr1 + nmbr2
        ElseIf MathType.Text = "-" Then
            answer = nmbr1 - nmbr2
        ElseIf MathType.Text = "*" Then
            answer = nmbr1 * nmbr2
        ElseIf MathType.Text = "÷" Then
            answer = nmbr1 / nmbr2
        End If

        OutputLabel.Text = answer
    End Sub
End Class