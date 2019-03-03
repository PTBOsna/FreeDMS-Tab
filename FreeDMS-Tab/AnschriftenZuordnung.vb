Imports System.IO

Imports outlook = Microsoft.Office.Interop.Outlook
Public Class AnschriftenZuordnung
    Private Sub AnschriftenZuordnung_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub AnschriftenDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles AnschriftenDataGridView.CellClick
        Dim rwAnschr = DirectCast(DirectCast(AnschriftenBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.AnschriftenRow)
        If rwAnschr.id <> 0 Then
            DokumenteBindingSource.Filter = "Absender=" & rwAnschr.id.ToString
        End If
        RichTextBox1.Clear()
    End Sub

    Private Sub DokumenteDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DokumenteDataGridView.CellClick
        Dim rwDoc = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
        If Not rwDoc.IsDokNameNull Then
            ShowDoc(rwDoc.DokName)
        End If
        If Not rwDoc.IsInhaltOCRNull Then
            RichTextBox1.Text = rwDoc.InhaltOCR
        Else
            RichTextBox1.Clear()
        End If
    End Sub
    Private Sub ShowDoc(ByVal sDokument As String)
        Dim sAnzeige As String
        sDokument = FreeDMS_Aux.FreeDMS.GrundDaten.ArchivOrdner & sDokument
        If Not File.Exists(sDokument) Then
            WebBrowser1.Navigate("about:blank")
            MsgBox("Die Datei " & sDokument & " konnte nicht gefunden werden." & vbCrLf & "Prüfen Sie ggf. den Pfad.")
            Exit Sub
        End If
        sAnzeige = UCase(Path.GetExtension(sDokument))

        'noch vorhandene Bilder/URL löschen
        WebBrowser1.Navigate("")
        PictureBox1.Image = My.Resources.FreeDMS_Logo
        'Dim sPicLeer As String = My.Resources.app_icon
        Select Case sAnzeige
            Case ".MSG"
                TabControl1.SelectTab(TabPage1)
                Dim oApp As New outlook.Application
                Dim OMItem As outlook.MailItem
                Try
                    OMItem = CType(oApp.CreateItemFromTemplate(sDokument), outlook.MailItem)
                    WebBrowser1.DocumentText = "Gesendet: " & OMItem.SentOn & "<br />" & "Von: " & OMItem.SenderName & "<br />" & "Betreff: " & OMItem.Subject & OMItem.Body
                Catch ex As Exception
                    WebBrowser1.Navigate("")
                    MsgBox(ex.Message)
                Finally
                    oApp = Nothing
                    OMItem = Nothing
                End Try
                PictureBox1.Image = My.Resources.FreeDMS_Logo
                OMItem = Nothing
            Case ".JPG", ".BMP", ".GIF"
                TabControl1.SelectTab(TabPage3)
                PictureBox1.Load(sDokument)
                WebBrowser1.Navigate("about:blank")
            Case ".PDF"
                TabControl1.SelectTab(TabPage1)
                WebBrowser1.Navigate(sDokument)
            Case ".DOC", ".DOCX", ".TXT"
                If File.Exists(sDokument) Then
                    Dim typeWord As Type = Type.GetTypeFromProgID("Word.Application")
                    Dim WordApp As Object = Activator.CreateInstance(typeWord)
                    Dim htmlFormat As Integer = 8
                    Dim Docpath As Object() = {sDokument}
                    Dim HtmPath As Object() = {Application.StartupPath & "\WordDoc.HTML", htmlFormat}
                    Dim WordDocs As Object = typeWord.InvokeMember("Documents", Reflection.BindingFlags.GetProperty, Nothing, WordApp, Nothing)
                    Dim doc As Object = WordDocs.GetType.InvokeMember("Open", Reflection.BindingFlags.InvokeMethod, Nothing, WordDocs, Docpath)
                    doc.GetType.InvokeMember("SaveAs", Reflection.BindingFlags.InvokeMethod, Nothing, doc, HtmPath)
                    WordApp.quit()
                    WebBrowser1.Navigate(HtmPath(0)) '/// load the Word Document in to the webbrowser.
                End If
            Case Else
                TabControl1.SelectTab(0)
                WebBrowser1.Navigate(sDokument)

        End Select

    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Try
            Validate()
            AnschriftenBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(_FreeDMS_StartDBDataSet)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Close()
    End Sub

    Private Sub btEsc_Click(sender As Object, e As EventArgs) Handles btEsc.Click
        If MsgBox("Zurück ohne speichern?", vbOKCancel) = MsgBoxResult.Ok Then Close()
    End Sub
End Class