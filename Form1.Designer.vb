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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.subject = New System.Windows.Forms.TextBox()
        Me.Email_address = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 137)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Send Email"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'subject
        '
        Me.subject.Location = New System.Drawing.Point(10, 69)
        Me.subject.Name = "subject"
        Me.subject.Size = New System.Drawing.Size(76, 20)
        Me.subject.TabIndex = 1
        '
        'Email_address
        '
        Me.Email_address.Location = New System.Drawing.Point(8, 45)
        Me.Email_address.Name = "Email_address"
        Me.Email_address.Size = New System.Drawing.Size(78, 20)
        Me.Email_address.TabIndex = 2
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(574, 382)
        Me.Controls.Add(Me.Email_address)
        Me.Controls.Add(Me.subject)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents subject As System.Windows.Forms.TextBox
    Friend WithEvents Email_address As System.Windows.Forms.TextBox

End Class
