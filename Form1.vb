Imports System.Net.Mail

Public Class Form1
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim mail As New MailMessage
        mail.Subject = subject.Text
        mail.To.Add(Email_address.Text)
        mail.From("trahern.curkendall@gmail.com")
    End Sub

    Private Sub subject_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles subject.TextChanged

    End Sub
End Class
