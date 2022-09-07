Public Class Form1
    ' what do you mean "that's not how I want you to do it" ._.
    ' Oh, can I please keep it the neat way I have it :c
    ' Update: I could not
    
    ' btw this is the Combo folder, just the way I would write it.
    Private Sub MathBtn_Click(sender As Object, e As EventArgs) Handles MathBtn.Click
        ' Variables
        ' Set both the numbers to string just in case they aren't Ints, and since VB is weird it might scream at me
        ' saying that you can't set ints to a string like that.
        Dim nbr1 As String = Number1.Text ' Input Number 1
        Dim nbr2 As String = Number2.Text ' Input Number 2, very simple stuff lol
        Dim operation As String = MathType.SelectedItem ' It's the sign of the dropdown box :)

        ' Actual Code (I COULD JUST USE A SWITCH STATEMENT AAAAAAAAAAAAAAAAAAA, unless VB doesn't have that which would be dumb)
        If operation = "+" Then ' Addition
            OutputLabel.Text = nbr1 + nbr2
        ElseIf operation = "-" Then ' Subtraction
            OutputLabel.Text = nbr1 - nbr2
        ElseIf operation = "*" Then ' Multiplication
            OutputLabel.Text = nbr1 * nbr2
        ElseIf operation = "÷" Then ' Division
            OutputLabel.Text = nbr1 / nbr2
        End If
    End Sub
End Class
