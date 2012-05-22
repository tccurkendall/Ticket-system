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
        Me.Ticket_id = New System.Windows.Forms.TextBox()
        Me.Body = New System.Windows.Forms.RichTextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Subject = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Ticket_id
        '
        Me.Ticket_id.Location = New System.Drawing.Point(12, 30)
        Me.Ticket_id.Name = "Ticket_id"
        Me.Ticket_id.Size = New System.Drawing.Size(143, 20)
        Me.Ticket_id.TabIndex = 0
        Me.Ticket_id.Text = "Ticket Id"
        '
        'Body
        '
        Me.Body.Location = New System.Drawing.Point(-2, 195)
        Me.Body.Name = "Body"
        Me.Body.Size = New System.Drawing.Size(287, 245)
        Me.Body.TabIndex = 1
        Me.Body.Text = ""
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(14, 65)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(141, 20)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.Text = "Account Name"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(12, 99)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(143, 20)
        Me.TextBox2.TabIndex = 3
        Me.TextBox2.Text = "Company Name"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(10, 133)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(145, 20)
        Me.TextBox3.TabIndex = 4
        Me.TextBox3.Text = "Email address"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(312, 209)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 47)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Email"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(313, 275)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(105, 73)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Fax"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.Location = New System.Drawing.Point(657, 18)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 7
        '
        'Subject
        '
        Me.Subject.Location = New System.Drawing.Point(10, 160)
        Me.Subject.Name = "Subject"
        Me.Subject.Size = New System.Drawing.Size(241, 20)
        Me.Subject.TabIndex = 8
        Me.Subject.Text = "Subject for email"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(902, 482)
        Me.Controls.Add(Me.Subject)
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Body)
        Me.Controls.Add(Me.Ticket_id)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Ticket_id As System.Windows.Forms.TextBox
    Friend WithEvents Body As System.Windows.Forms.RichTextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents Subject As System.Windows.Forms.TextBox

    Private Sub Subject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Subject.TextChanged

    End Sub
End Class
