Private Sub ThisAddIn_Startup(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Startup
    SendEmailtoContacts()
End Sub

Private Sub SendEmailtoContacts()
    Dim subjectEmail As String = Subject.text
    Dim bodyEmail As String = Body.text
    Dim sentContacts As Outlook.MAPIFolder = Me.Application.ActiveExplorer() _
        .Session.GetDefaultFolder(Outlook _
        .OlDefaultFolders.olFolderContacts)
    For Each contact As Outlook.ContactItem In sentContacts.Items()
        If contact.Email1Address.Contains("example.com") Then
            CreateEmailItem(subjectEmail, contact _
            .Email1Address, bodyEmail)
        End If
    Next
End Sub

Private Sub CreateEmailItem(ByVal subjectEmail As String, _
    ByVal toEmail As String, ByVal bodyEmail As String)
    Dim eMail As Outlook.MailItem = Me.Application.CreateItem _
        (Outlook.OlItemType.olMailItem)
    With eMail
        .Subject = subjectEmail
        .To = toEmail
        .Body = bodyEmail
        .Importance = Outlook.OlImportance.olImportanceLow
        .Send()
    End With
End Sub