Public Class Form1
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked Then
            TextBox1.ForeColor = Color.Green
        Else
            ' Set the default text color if the radio button is not checked
            TextBox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton5.Checked Then
            TextBox1.ForeColor = Color.Blue
        Else
            ' Set the default text color if the radio button is not checked
            TextBox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked Then
            TextBox1.ForeColor = Color.Red

        Else
            ' Set the default text color if the radio button is not checked
            TextBox1.ForeColor = SystemColors.ControlText
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic) ' Change font style to bold
        Else
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular) ' Change font style to regular
        End If
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Bold) ' Change font style to bold
        Else
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular) ' Change font style to regular
        End If
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Italic AndAlso FontStyle.Bold) ' Change font style to bold
        Else
            TextBox1.Font = New Font(TextBox1.Font, FontStyle.Regular) ' Change font style to regular
        End If
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked Then
            ' If checkbox is checked, set the font type to Arial and style to bold and italic
            TextBox1.Font = New Font("Garamond", TextBox1.Font.Size, FontStyle.Bold)
        Else
            ' If checkbox is unchecked, set the font type to the default font and style to regular
            TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton2.Checked Then
            ' If checkbox is checked, set the font type to Arial and style to bold and italic
            TextBox1.Font = New Font("Magneto", TextBox1.Font.Size, FontStyle.Bold)
        Else
            ' If checkbox is unchecked, set the font type to the default font and style to regular
            TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton3.Checked Then
            ' If checkbox is checked, set the font type to Arial and style to bold and italic
            TextBox1.Font = New Font("Tahoma", TextBox1.Font.Size, FontStyle.Bold)
        Else
            ' If checkbox is unchecked, set the font type to the default font and style to regular
            TextBox1.Font = New Font(TextBox1.Font.FontFamily, TextBox1.Font.Size, FontStyle.Regular)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            ' Load and display an image in the PictureBox
            PictureBox1.Image = Image.FromFile("C:\Users\hp\Pictures\Wallpapers4K\Vadim%20Georgiev01.jpg") ' Provide the path to your image file
        Catch ex As Exception
            MessageBox.Show("Error loading image: " & ex.Message)
        End Try
    End Sub


End Class