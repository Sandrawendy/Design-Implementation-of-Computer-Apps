<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCalculate = New System.Windows.Forms.Button()
        Me.txtSubject1 = New System.Windows.Forms.TextBox()
        Me.txtSubject2 = New System.Windows.Forms.TextBox()
        Me.txtSubject3 = New System.Windows.Forms.TextBox()
        Me.txtSubject4 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnCalculate
        '
        Me.btnCalculate.Location = New System.Drawing.Point(347, 321)
        Me.btnCalculate.Name = "btnCalculate"
        Me.btnCalculate.Size = New System.Drawing.Size(90, 33)
        Me.btnCalculate.TabIndex = 0
        Me.btnCalculate.Text = "Calculate"
        Me.btnCalculate.UseVisualStyleBackColor = True
        '
        'txtSubject1
        '
        Me.txtSubject1.Location = New System.Drawing.Point(313, 81)
        Me.txtSubject1.Name = "txtSubject1"
        Me.txtSubject1.Size = New System.Drawing.Size(100, 22)
        Me.txtSubject1.TabIndex = 1
        '
        'txtSubject2
        '
        Me.txtSubject2.Location = New System.Drawing.Point(313, 127)
        Me.txtSubject2.Name = "txtSubject2"
        Me.txtSubject2.Size = New System.Drawing.Size(100, 22)
        Me.txtSubject2.TabIndex = 2
        '
        'txtSubject3
        '
        Me.txtSubject3.Location = New System.Drawing.Point(313, 171)
        Me.txtSubject3.Name = "txtSubject3"
        Me.txtSubject3.Size = New System.Drawing.Size(100, 22)
        Me.txtSubject3.TabIndex = 3
        '
        'txtSubject4
        '
        Me.txtSubject4.Location = New System.Drawing.Point(313, 223)
        Me.txtSubject4.Name = "txtSubject4"
        Me.txtSubject4.Size = New System.Drawing.Size(100, 22)
        Me.txtSubject4.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(219, 87)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(59, 16)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Subject1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(219, 133)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Subject2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(219, 177)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(59, 16)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Subject3"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(219, 229)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 16)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Subject4"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(274, 23)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(163, 16)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Average Grade Calculator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtSubject4)
        Me.Controls.Add(Me.txtSubject3)
        Me.Controls.Add(Me.txtSubject2)
        Me.Controls.Add(Me.txtSubject1)
        Me.Controls.Add(Me.btnCalculate)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCalculate As Button
    Friend WithEvents txtSubject1 As TextBox
    Friend WithEvents txtSubject2 As TextBox
    Friend WithEvents txtSubject3 As TextBox
    Friend WithEvents txtSubject4 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
