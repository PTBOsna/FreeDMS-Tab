'Option Strict On
Imports System.Text                                         ' Wegen Encoding
Imports System.IO

Imports outlook = Microsoft.Office.Interop.Outlook
Imports FreeDMS_Aux.FreeDMS.GrundDaten


Public Class DocEdit
    Dim id As Integer
    Dim selDB As New FreeDMS_Aux.FreeDMS.DbHandling
    ' Dim ArchivOrdner As String = ""
    ''' <summary>
    ''' Parameterübergabe mit OpenArgs
    ''' </summary>
    ''' <param name="openArgs"></param>
    Sub New(openArgs As String)
        InitializeComponent()
        id = CInt(openArgs)
    End Sub
    ''' <summary>
    ''' Fomular laden und TableAdapter füllen
    ''' Grundeinstellungen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub EditGrunddaten_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim sDok As String
        DokumenteBindingSource.Filter = "id=" & id
        ' DokumenteSQLBindingSource.Filter = "id=" & id
        Try
            Dim rwDok = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            If Not rwDok.IsAkteNull Then
                AktenBindingSource.Filter = "id=" & rwDok.Akte.ToString
            End If
            If Not rwDok.IsMandantNull Then
                MandantBindingSource.Filter = "id=" & rwDok.Mandant.ToString
            End If
            If Not rwDok.IsVorgangNull Then
                VorgaengeBindingSource.Filter = "id=" & rwDok.Vorgang.ToString
            End If
            If Not rwDok.IsistAnlageNull Then
                If IstAnlageTextBox.Text = "True" Then
                    IstAnlageCheckBox.CheckState = CheckState.Checked
                Else
                    IstAnlageCheckBox.CheckState = CheckState.Unchecked
                End If
            End If
            If Not rwDok.IsDokNameNull Then
                If UCase(Path.GetExtension(rwDok.DokName)) <> ".PDF" Then
                    BtImageToPDF.Visible = True
                Else
                    BtImageToPDF.Visible = False
                End If
            End If
            lbAz.Text = "Az.: " & MandantTextBox.Text & "-" & AkteTextBox.Text & "-" & VorgangTextBox.Text & "/" & id
            If ArchivOrdner = "" Then
                MsgBox("Bitte die Settings überprüfen!")
                Exit Sub
            End If
            If Not ArchivOrdner.EndsWith("\") Then
                ArchivOrdner = ArchivOrdner & "\"
            End If
            Dim myDok = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            ' If myDok.IsDokNameNull Then MsgBox("Fehler")
            If Not myDok.IsDokNameNull Then
                sDok = myDok.DokName
                Me.Text = "FreeDMS - Dokument " & sDok
                ShowDok(sDok)
            Else
                WebBrowser1.Navigate("")
            End If
            If cbAbsender.SelectedIndex < 0 Or cbEmpfaenger.SelectedIndex < 0 Then
                MsgBox("Absender oder Empfänger fehlt! ")
            End If
            Cursor.Current = Cursors.Default
        Catch ex As Exception
            MsgBox("Bitte zunächst ein Dokument aus der Dokumentenliste auswählen!")
            Close()
        End Try
        cbMandant.Text = "Bitte auswählen"
        AktenBindingSource1.Filter = "Mandant=" & cbMandant.SelectedValue.ToString
        cbAkte.Text = "Bitte auswählen"
        VorgaengeBindingSource1.Filter = "Akte=" & cbAkte.SelectedValue.ToString
        cbVorgang.Text = "Bitte auswählen"
    End Sub
    ''' <summary>
    ''' Original Dokument anzeigen
    ''' </summary>
    ''' <param name="sDokument"></param>
    Private Sub ShowDok(ByVal sDokument As String)
        Dim sAnzeige As String
        sDokument = ArchivOrdner & sDokument
        Cursor.Current = Cursors.WaitCursor
        ' Me.ToolStripStatusLabel2.Text = "Fundstelle: " & sDokument
        If Not File.Exists(sDokument) Then
            WebBrowser1.Navigate("")
            MsgBox("Die Datei " & sDokument & " konnte nicht gefunden werden." & vbCrLf & "Prüfen Sie ggf. den Pfad.")

            Exit Sub
        End If
        'sDok = My.Settings.SettingArchivOrdner & TbGrunddatenDataGridView.Rows(TbGrunddatenDataGridView.CurrentRow.Index).Cells(0).Value
        sAnzeige = UCase(Path.GetExtension(sDokument))
        'noch vorhandene Bilder/URL löschen
        WebBrowser1.Navigate("")
        PictureBox1.Image = My.Resources.FreeDMS_Logo
        'Dim sPicLeer As String = My.Resources.app_icon
        Select Case sAnzeige
            Case ".MSG"
                TabControl1.SelectTab(0)
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

                OMItem = Nothing
            Case ".JPG", ".BMP", ".GIF"
                TabControl1.SelectTab(1)
                Dim oStream As New System.IO.FileStream(sDokument, IO.FileMode.Open)
                PictureBox1.Image = New Bitmap(oStream)
                oStream.Close()
                ' PictureBox1.Load(sDokument)
                WebBrowser1.Navigate("")
            Case ".DOC", ".DOCX"
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
            Case ".TXT"
                WebBrowser1.DocumentText = sDokument
            Case Else
                TabControl1.SelectTab(0)
                Me.PictureBox1.Image = My.Resources.FreeDMS_Logo
                If File.Exists(sDokument) Then
                    WebBrowser1.Navigate(sDokument)
                Else
                    WebBrowser1.Navigate("")
                    MsgBox("Dokument " & sDokument & " nicht gefunden." & vbCrLf & "Bitte prüfen!")
                End If

        End Select
        Cursor.Current = Cursors.Default
    End Sub

    ''' <summary>
    ''' Form schließen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btClose.Click
        With Start.currDoc
            If Not String.IsNullOrEmpty(MandantTextBox.Text) Then .Mandant = CInt(MandantTextBox.Text)
            If Not String.IsNullOrEmpty(AkteTextBox.Text) Then .Akte = CInt(AkteTextBox.Text)
            If Not String.IsNullOrEmpty(VorgangTextBox.Text) Then .Vorgang = CInt(VorgangTextBox.Text)
            If id <> 0 Then .Dokument = id
        End With
        Close()
    End Sub
    ''' <summary>
    ''' Änderungen speichern
    ''' Aktuelle Einträge für Anzeige im Hauptformular speichern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Validate()
        DokumenteBindingSource.EndEdit()
        DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)

        With Start.currDoc
            .Mandant = CInt(MandantTextBox.Text)
            .Akte = CInt(AkteTextBox.Text)
            .Vorgang = CInt(VorgangTextBox.Text)
            .Dokument = id
        End With
        Close()
    End Sub

    ''' <summary>
    ''' Dokument mit seiner Anwendung starten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtShow_Click(sender As Object, e As EventArgs) Handles btShow.Click
        Dim crDoc = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
        Dim DokName As String = If(crDoc.IsDokNameNull, "-", ArchivOrdner & crDoc.DokName)
        Try
            Process.Start(DokName)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & DokName)
        End Try
    End Sub

    ''' <summary>
    ''' Aktuellen DokDatum übernehmen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        DokDatumTextBox.Text = DateTimePicker1.Value.ToString
    End Sub
    ''' <summary>
    ''' Aktuelles Aufnahmedatum übernehmen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DateTimePicker2_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker2.ValueChanged
        AufgenommenTextBox.Text = DateTimePicker2.Value.ToString
    End Sub
    ''' <summary>
    ''' Aktuelles Änderungsdatum übernehmen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DateTimePicker3_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker3.ValueChanged
        GeaendertTextBox.Text = DateTimePicker3.Value.ToString
    End Sub

    ''' <summary>
    ''' Mandant übernehmen/ändern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbMandant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMandant.SelectedIndexChanged
        If cbMandant.SelectedIndex >= 0 Then
            AktenBindingSource1.Filter = "Mandant=" & cbMandant.SelectedValue.ToString 'in Vorversion AktenBindingSource1....

            MandantTextBox.Text = cbMandant.SelectedValue.ToString
            txtMandant.Text = cbMandant.Text
        End If

    End Sub
    ''' <summary>
    ''' Akte übernehmen/ändern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbAkte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAkte.SelectedIndexChanged, cbMandant.SelectedIndexChanged
        If cbAkte.SelectedIndex >= 0 Then
            VorgaengeBindingSource1.Filter = "Akte=" & cbAkte.SelectedValue.ToString
            AkteTextBox.Text = cbAkte.SelectedValue.ToString
            txtAkte.Text = cbAkte.Text
        End If

    End Sub
    ''' <summary>
    ''' Vorgang übernehmen/Ändern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbVorgang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVorgang.SelectedIndexChanged, cbAkte.SelectedIndexChanged
        If cbVorgang.SelectedIndex >= 0 Then
            VorgangTextBox.Text = cbVorgang.SelectedValue.ToString
            txtVorgang.Text = cbVorgang.Text
        End If

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) 
        'Dim f As New Anschriften
        'f.AnschriftenBindingSource.DataSource = AnschriftenBindingSource1 '_FreeDMS_StartDBDataSet
        'f.ShowDialog()

    End Sub

    Private Sub cbEmpfaenger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpfaenger.SelectedIndexChanged
        If cbEmpfaenger.SelectedIndex >= 0 Then
            EmpfaengerTextBox.Text = cbEmpfaenger.SelectedValue.ToString
        End If
    End Sub

    Private Sub IstAnlageCheckBox_CheckStateChanged(sender As Object, e As EventArgs) Handles IstAnlageCheckBox.CheckStateChanged
        If IstAnlageCheckBox.Checked Then
            IstAnlageTextBox.Text = "True"
        Else
            IstAnlageTextBox.Text = "False"
        End If
    End Sub

    Private Sub BtImageToPDF_Click(sender As Object, e As EventArgs) Handles BtImageToPDF.Click
        Dim crDoc = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
        Dim openArgs As String = If(crDoc.IsDokNameNull, "-", ArchivOrdner & crDoc.DokName)
        Dim f As New ImageToPDF(openArgs)
        f.ShowDialog()

    End Sub
End Class