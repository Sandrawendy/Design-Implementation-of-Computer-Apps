Public Class Form1

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Variables to store marks for each subject
        Dim mark1, mark2, mark3, mark4 As Double

        ' Validate input for subject 1
        If Not Double.TryParse(txtSubject1.Text, mark1) Then
            MessageBox.Show("Invalid input for Subject 1. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSubject1.Focus()
            Return
        End If

        ' Validate input for subject 2
        If Not Double.TryParse(txtSubject2.Text, mark2) Then
            MessageBox.Show("Invalid input for Subject 2. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSubject2.Focus()
            Return
        End If

        ' Validate input for subject 3
        If Not Double.TryParse(txtSubject3.Text, mark3) Then
            MessageBox.Show("Invalid input for Subject 3. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSubject3.Focus()
            Return
        End If

        ' Validate input for subject 4
        If Not Double.TryParse(txtSubject4.Text, mark4) Then
            MessageBox.Show("Invalid input for Subject 4. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtSubject4.Focus()
            Return
        End If

        ' Calculate average mark
        Dim averageMark As Double = (mark1 + mark2 + mark3 + mark4) / 4

        ' Determine grade
        Dim grade As String
        If averageMark >= 75 Then
            grade = "A"
        ElseIf averageMark >= 65 Then
            grade = "B"
        ElseIf averageMark >= 50 Then
            grade = "C"
        Else
            grade = "Fail"
        End If

        ' Display grade in a message box
        MessageBox.Show("Your average mark is " & averageMark.ToString("F2") & ". Your grade is " & grade & ".", "Grade Result", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class

