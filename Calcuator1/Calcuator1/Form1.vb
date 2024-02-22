Public Class Form1
    Private NumberOneInteger, NumberTwoInteger As Integer
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim SumInteger As Integer
        'Convert values from TextBox controls to numeric types
        NumberOneInteger = Integer.Parse(Number1TextBox.Text,
        Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        SumInteger = NumberOneInteger + NumberTwoInteger
        ResultsTextBox.Text = SumInteger.ToString("N0")
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim SubtractInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text,
        Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        SubtractInteger = NumberOneInteger - NumberTwoInteger
        ResultsTextBox.Text = SubtractInteger.ToString("N0")
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim MultiplyInteger As Integer
        NumberOneInteger = Integer.Parse(Number1TextBox.Text,
        Globalization.NumberStyles.Number)
        NumberTwoInteger = Integer.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        MultiplyInteger = NumberOneInteger * NumberTwoInteger
        ResultsTextBox.Text = MultiplyInteger.ToString("N0")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim DivisionInteger As Double
        NumberOneInteger = Double.Parse(Number1TextBox.Text,
        Globalization.NumberStyles.Number)
        NumberTwoInteger = Double.Parse(Number2TextBox.Text,
        Globalization.NumberStyles.Number)
        DivisionInteger = NumberOneInteger / NumberTwoInteger
        ResultsTextBox.Text = DivisionInteger.ToString("NO")
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Number1TextBox.Clear()
        Number2TextBox.Clear()
        ResultsTextBox.Text = String.Empty
        'Set the focus to the first text box control
        Number1TextBox.Focus()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles Number1TextBox.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles Number2TextBox.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles ResultsTextBox.TextChanged

    End Sub
End Class
