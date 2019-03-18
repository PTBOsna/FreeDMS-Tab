Option Strict On
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Imports FreeDMS_Aux.FreeDMS.Aux
Imports System.IO
Imports System.Text
Imports outlook = Microsoft.Office.Interop.Outlook
Imports OpenPop.Mime
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports System.ComponentModel

Public Class FolderInput
    Public Class DocumentData
        Public docID As Int32 'Identiefyer = anzahlID + 1
        Public id As Int32
        Public mandant As Int32
        Public akte As Int32
        Public vorgang As Int32
        Public dokument As String
        Public betreff As String
        Public betrag As Decimal
        Public anlagen As String
        Public absender As Int32
        Public empfaenger As Int32
        Public dokDatum As String
        Public aufgenommen As String
        Public geaendert As String
        Public kommentar As String
        Public inhalt As String
        Public ablage As Int32
        Public typ As Int32
        Public status As Int32
        Public dokName As String
        Public istanlage As Boolean
        Public anlagenid As String
        Public bearbeit As String
    End Class
    'Dim DokInhalt As New List(Of DocumentData)
    Dim currDokName As String = "" 'ehemals ttxt. Enthält ScanInput-Pfad und File-Name
    Dim lastID As Integer = CInt((FreeDMS_Aux.FreeDMS.Aux.MaxID(CurrDB))) 'ID des letzten in der DB gespeicherten Datensatzes
    Dim currDokID As Integer = lastID + 1 'ID des aktuellen Datensatzes (i.d.R lastID + 1)
    Dim MailID As Integer 'DokID der Mail, wenn Anlagen gespeichert werden (für Tb. Anlagen)
    Dim DocContent As New DocumentData
    Dim ext As String
    Dim mehrfachFlag As Boolean = False
    Dim speicherFlag As Boolean = False
    Dim sTmp As String
    Dim lastDocName As String
    Dim isAttachment As Boolean = False
    Dim FileContent As String
    Dim FileReadOk As Boolean = False
    Dim newFile As String
    Dim imList As New List(Of Bitmap)
    Dim selAttachments As New List(Of MessagePart)
    Dim tempOCRString As String
    Private Sub FolderInput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Anlagen". Sie können sie bei Bedarf verschieben oder entfernen.
        'selDB für Vorlagen erforderlich, da Funktion  "Dim vorlagen = From p In _FreeDMS_StartDBDataSet.Vorlagen" sonst nicht funktioniert!
        'für die Anlagenverarbeitung ist die DokID erforderlich. Daher selDB ebenfalls für DokumenteTableAdapter erforderlich
        Dim selDB = New FreeDMS_Aux.FreeDMS.DbHandling
        selDB.LoadDB(CurrDB)
        DokumenteTableAdapter.Connection = selDB.con
        VorlagenTableAdapter.Connection = selDB.con
        AnlagenTableAdapter.Connection = selDB.con
        DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)
        VorlagenTableAdapter.Fill(_FreeDMS_StartDBDataSet.Vorlagen)
        AnlagenTableAdapter.Fill(_FreeDMS_StartDBDataSet.Anlagen)


        DokumenteBindingSource.Filter = "id=0"
        txtAendern.Text = "Eingangsordner: " & InputOrdner
        PanelBGW.Visible = False
        WebBrowser1.DocumentText = sHTML
        ''currDokID für DokName ermitteln - wird später hochgezählt
        'currDokID = CInt((FreeDMS_Aux.FreeDMS.Aux.MaxID(CurrDB)))
        LoadLvDok()
        ClearText()
    End Sub
#Region "Vorbereitung"
    Private Sub LoadLvDok()
        Dim locDirInfo As DirectoryInfo = Nothing
        Dim locLtvItem As ListViewItem = Nothing
        Dim ltv As ListView
        Dim okFile As String = ".DOC .MSG .PDF .JPG .JPEG .DOCX .TIF .GIF .TXT .XLS .XLSX .EML .PNG .DOT .PUB .BMP"
        ltv = LvDoc
        ' ltv = lv 'lvScaninput
        With ltv 'ltv
            Try
                .BeginUpdate()
                Dim items As ListView.ListViewItemCollection = .Items

                ' Spalten und Zeilen zurücksetzen
                items.Clear()
                .Columns.Clear()
                .MultiSelect = False
                .View = View.LargeIcon
                ' ImageList zurücksetzen
                ImageList1.Images.Clear()

                ' ImageList zuweisen
                .SmallImageList = ImageList1
                .LargeImageList = ImageList1
                ' Dateien ermitteln
                Try
                    locDirInfo = New DirectoryInfo(InputOrdner)
                Catch ex As Exception
                    MsgBox("Ordner nicht gefunden! Bitte die Settings überprüfen!")
                    Exit Sub
                End Try

                If Not locDirInfo.Exists Then Throw New DirectoryNotFoundException
                ' MsgBox(locDirInfo.GetFiles.Count.ToString)
                For Each locFi As FileInfo In locDirInfo.GetFiles("*.*", SearchOption.TopDirectoryOnly)

                    ' Icon zur ImageList hinzufügen - Key = Dateiendung
                    If Not ImageList1.Images.ContainsKey(locFi.Extension) Then
                        ImageList1.Images.Add(locFi.Extension, Icon.ExtractAssociatedIcon(locFi.FullName))
                    End If
                    If InStr(okFile, UCase(locFi.Extension)) <> 0 Then
                        locLtvItem = New ListViewItem(New String() {locFi.Name,
                                                                    locFi.Length.ToString(),
                                                                    locFi.Extension,
                                                                    locFi.LastAccessTime.ToString}) With {
                            .Tag = locFi, ' Für spätere Verarbeitung der Datei merken
                            .ImageKey = locFi.Extension   ' Icon zuweisen
                            }

                        items.Add(locLtvItem)
                    End If

                Next

            Catch ex As Exception
                ' Throw
            Finally
                .EndUpdate()
                locDirInfo = Nothing
                locLtvItem = Nothing
            End Try
        End With
    End Sub
    Private Sub btChangeOrdner_Click(sender As Object, e As EventArgs) Handles btChangeOrdner.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            InputOrdner = FolderBrowserDialog1.SelectedPath & "\"
            txtAendern.Text = "Auswahlordner: " & InputOrdner
            LoadLvDok()
        End If
    End Sub
#End Region
#Region "Dokauswahl und Vorbereitung"
    Private Sub LvDoc_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LvDoc.MouseClick
        'ClearText()
        'Inhalt auslesen und umbenennen
        If e.Button = MouseButtons.Left Then
            If (LvDoc.SelectedItems.Count = 0) Then Exit Sub
            MailID = currDokID
            FileInhalt(LvDoc.SelectedItems(0).Text())
            BtSave.Enabled = True
        End If
    End Sub
    Private Sub FileInhalt(ByVal lvSelItem As String)
        Try
            LbInBearb.Text = System.IO.Path.GetFileName(lvSelItem)
        Catch ex As Exception
            LbInBearb.Text = lvSelItem
        End Try

        'Vorbereitung
        speicherFlag = False

        lbSpeichstatus.Text = "Noch nicht gespeichert!"
        lbSpeichstatus.ForeColor = Color.Red
        lboxSaveAtt.Enabled = False
        GVAttList.Enabled = False
        sTmp = tempPath & "temp.ocr"
        If File.Exists(sTmp) Then Kill(sTmp)
        ''neuen Datensatz anfügen
        DokumenteBindingSource.AddNew()
        'Vorbelegungen
        CbMandant.SelectedValue = StartMandant
        ClearText()
        CbEmpfaenger.SelectedValue = StEmpfaenger.ToString
        AnlagenTextBox.Text = "0"
        AufgenommenTextBox.Text = Format(Now, "dd.MM.yyyy")
        IstAnlageCheckBox.CheckState = CheckState.Unchecked

        If isAttachment Then
            currDokName = lvSelItem
            BearbVermerkTextBox.Text = "Dokument ist Anlage von Dokument Nr. " & MailID.ToString
            IstAnlageCheckBox.CheckState = CheckState.Checked
            IstAnlageTextBox.Text = "True"
            'isAttachment = False
        Else
            currDokName = InputOrdner & lvSelItem
            GVAttList.Rows.Clear()
        End If
        'Feld DokName füllen
        DokNameTextBox.Text = System.IO.Path.GetFileName(currDokName)
        'Dateityp feststellen
        ext = UCase(System.IO.Path.GetExtension(lvSelItem))
        'Einträge Extrahieren und Zuordnung
        'Auswahl aufheben
        LvDoc.SelectedItems.Clear()
        Select Case ext
            Case ".TXT"
                FileContent = FreeDMS_Aux.FreeDMS.Aux.ReadFile(currDokName)
                RichTextBoxOCR.Text = FileContent
                tempOCRString = FileContent
                InhaltOCRTextBox.Text = FileContent
            Case ".DOC", ".DOCX", ".RTF"
                ' MsgBox("DOC")
                DocHandle(currDokName)

            Case ".MSG"
                'MsgBox("MSG")
                MsgHandle(currDokName)

            Case ".PDF"
                'prüfen ob ocr-Datei vorhanden ist
                Dim tempFile As String = InputOrdner & System.IO.Path.GetFileNameWithoutExtension(currDokName) & ".ocr"
                If File.Exists(tempFile) Then
                    FileContent = FreeDMS_Aux.FreeDMS.Aux.ReadFile(tempFile)
                    tempOCRString = FileContent
                    ' WebBrowser1.Navigate(currDokName)
                    FileReadOk = True
                Else
                    PdfHandle(currDokName)
                End If
                ' MsgBox("PDF")
                'ausführen nur wenn OCR-Programm vorhanden!
                If Not FileReadOk Then
                    MsgBox("Nicht lesbares PDF-Dokument. Keine Umwandlung in Text möglich")
                    tempOCRString = "Nicht lesbares PDF-Dokument. Keine Umwandlung in Text möglich"
                    Exit Sub
                End If

            Case ".EML"
                ' MsgBox("EML")
                EmlHandle(currDokName)

            Case ".JPG", ".JPEG", ".GIF", ".TIF", ".BMP", ".PNG", ".BMP"
                If MsgBox("In PDF umwandeln und Texterkennung durchführen?", vbYesNo, "Bilddatei") = vbNo Then
                    Exit Sub
                Else
                    imList.Clear()
                    tempDokName.Add(currDokName) 'Liste mit CurrDokName um bei Rückkehr in Mother-Form die ursprüngliche Image-Datei zu löschen

                    imList.Add(CType(Image.FromFile(currDokName, True), Bitmap))
                    ' sTmpFile = currDokName
                    ImgHandle(currDokName)

                End If

            Case Else
                If MsgBox("Kein unterstützes Dokument. Speichern aber dennoch möglich!" & vbCrLf & "Weiter oder abbrechen?", vbOKCancel, "Fehler") = vbCancel Then
                    Exit Sub
                End If
        End Select

        AutoZuordnung(tempOCRString)

    End Sub
    Private Sub ImgHandle(ByVal FileName As String)
        Cursor.Current = Cursors.WaitCursor
        ' Dim ocrErgeb(2) As String
        Dim newName As String = InputOrdner & System.IO.Path.GetFileNameWithoutExtension(FileName) & ".PDF"
        Try
            FreeDMS_Aux.FreeDMS.Aux.ConvertImageToPdf(imList, newName)

            currDokName = newName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler bei der PDF-Erstellung")
        End Try
        PanelBGW.Visible = True
        BackgroundWorker1.RunWorkerAsync()

        Cursor.Current = Cursors.Default

    End Sub
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Call RunOCR()
    End Sub
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted

        Dim DelFile As String = System.IO.Path.ChangeExtension(currDokName, ext)
        PanelBGW.Visible = False
        RichTextBoxOCR.Text = tempOCRString
        InhaltOCRTextBox.Text = tempOCRString
        TabControl1.SelectedTab = TabPage2
        'MsgBox(currDokName & "/" & ext)
        MessageBox.Show("Die Originaldatei '" & DelFile & "' bleibt erhalten." & vbCrLf & "Sie können diese ggf. in der Dokumentenliste oder im Input-Ordner löschen.", "FreeDMS-Tab - Hinweis zur Datei!")
    End Sub
    Private Sub RunOCR()
        Dim ocrErgeb(2) As String

        ocrErgeb = FreeDMS_Aux.FreeDMS.Aux.CreateOCR(imList)
        tempOCRString = ocrErgeb(0)

    End Sub
    Private Sub DocHandle(ByVal FileName As String)
        'TODO: PFD nach Text für OCR-Feld einfügen
        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document = Nothing
        Dim outputFilename As String = System.IO.Path.ChangeExtension(FileName, "pdf")
        'Auswerten
        Try
            doc = word.Documents.Open(DirectCast(FileName.ToString, Object))
            doc.Activate()
            'als PDF speichern
            doc.SaveAs2(FileName:=DirectCast(sTmp, Object), FileFormat:=6)
            'als RTF für OCR speichern
            doc.SaveAs2(FileName:=DirectCast(outputFilename, Object), FileFormat:=17)
            doc.Close()
            RichTextBoxOCR.LoadFile(tempPath & "temp.ocr")
            Kill(tempPath & "temp.ocr")
        Catch ex As Exception
            MsgBox("Kein lesbares Dokument!" & vbCrLf & ex.Message)
        End Try

        If Not word Is Nothing Then
                word.Quit()
                word = Nothing
            End If
        WebBrowser1.Navigate(outputFilename)
        InhaltOCRTextBox.Text = RichTextBoxOCR.Text
        tempOCRString = InhaltOCRTextBox.Text
    End Sub
    Private Sub MsgHandle(ByVal Msg As String)
        Dim oApp As New outlook.Application
        Dim OMItem As outlook.MailItem
        Dim GvIndex As Integer = -1
        Try
            OMItem = CType(oApp.CreateItemFromTemplate(Msg), outlook.MailItem)

            If OMItem.BodyFormat = outlook.OlBodyFormat.olFormatPlain Then
                WebBrowser1.DocumentText = OMItem.Body
            Else
                'WebBrowser1.DocumentText = OMItem.HTMLBody
                WebBrowser1.Document.Body.InnerHtml = OMItem.HTMLBody
            End If
            Dim body As String = WebBrowser1.Document.Body.InnerText
            ' MsgBox(body)
            FileContent = "Gesendet: " & OMItem.SentOn & vbCrLf & "Von: " & OMItem.SenderName & vbCrLf & "Betreff: " & OMItem.Subject & vbCrLf & body
            tempOCRString = FileContent
            ' WebBrowser1.DocumentText = tempOCRString
            DokumentTextBox.Text = "EMail von " & OMItem.SenderName.ToString
            BetreffTextBox.Text = OMItem.Subject
            DokDatumTextBox.Text = OMItem.SentOn.ToShortDateString
            If OMItem.Attachments.Count > 0 Then AnlagenTextBox.Text = OMItem.Attachments.Count.ToString
            'Test
            selAttachments.Clear()

            If OMItem.Attachments.Count > 0 Then

                For Each anl As outlook.Attachment In OMItem.Attachments
                    'Anlage temporär speichern
                    Try
                        anl.SaveAsFile(tempPath & "temp_" & anl.FileName)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                    End Try

                    lboxSaveAtt.Items.Add(anl.FileName)
                    GVAttList.Rows.Add()
                    GvIndex = GvIndex + 1
                    AnlagenIDTextBox.Text += OMItem.EntryID & ", " '.MessageId & ", "
                Next
                AnlagenIDTextBox.Text = AnlagenIDTextBox.Text.Substring(0, AnlagenIDTextBox.Text.Length - 2)
            End If
            'end TEst
            If OMItem.Body.Length > 2000 Then
                KommentarTextBox.Text = "Text zu lang, bitte ggf. OCR-Feld prüfen!"
            Else
                KommentarTextBox.Text = OMItem.Body
            End If
            RichTextBoxOCR.Text = tempOCRString
            InhaltOCRTextBox.Text = tempOCRString
        Catch ex As Exception
            WebBrowser1.Navigate("about: blank")
            MsgBox(ex.Message)

        Finally
            oApp = Nothing
            OMItem = Nothing
        End Try
    End Sub
    Private Sub PdfHandle(ByRef Mypdf As String)

        'TODO: mit iTextSharp versuchen: https://developers.itextpdf.com/question/how-read-text-specific-position
        Dim sb = New StringBuilder
        Dim bytes = File.ReadAllBytes(Mypdf)
        Try
            Dim reader = New PdfReader(bytes)
            Dim numberOfPages = reader.NumberOfPages
            Dim currentPageIndex = 1
            Do While (currentPageIndex <= numberOfPages)
                sb.Append(PdfTextExtractor.GetTextFromPage(reader, currentPageIndex))
                currentPageIndex = (currentPageIndex + 1)
            Loop

        Catch exception As Exception
            MsgBox(exception.Message)
        End Try
        If String.IsNullOrEmpty(sb.ToString) Then

            FileReadOk = False
        Else
            tempOCRString = sb.ToString
            FileReadOk = True
        End If
        WebBrowser1.Navigate(Mypdf)
        RichTextBoxOCR.Text = tempOCRString
        InhaltOCRTextBox.Text = tempOCRString
    End Sub
    Public Sub EmlHandle(ByVal MyEml As String)
        Dim file As FileInfo = New FileInfo(MyEml)
        Dim loadedMsg As Message = Message.Load(file)
        Dim msgBody As String = ""
        Dim GvIndex As Integer = -1
        'WebBrowser1.Navigate("")

        Dim body As MessagePart = loadedMsg.FindFirstHtmlVersion()

        If body IsNot Nothing Then
            'FileContent = body.GetBodyAsText()
            msgBody = body.GetBodyAsText()
            ' MsgBox(msgBody)
        Else
            body = loadedMsg.FindFirstPlainTextVersion()
            If body IsNot Nothing Then
                'FileContent = body.GetBodyAsText()
                msgBody = body.GetBodyAsText()
                '  MsgBox(msgBody)
            End If
        End If

        DokumentTextBox.Text = "EMail von " & loadedMsg.Headers.From.DisplayName.ToString
        BetreffTextBox.Text = loadedMsg.Headers.Subject
        DokDatumTextBox.Text = loadedMsg.Headers.DateSent.ToShortDateString
        If msgBody.Length > 2000 Then
            KommentarTextBox.Text = "Text zu lang, bitte ggf. OCR-Feld prüfen!"
        Else
            KommentarTextBox.Text = tempOCRString
        End If
        'Behandlung der Anlagen: Laden in Liste selAttachment und Anzeigen in Textbox
        selAttachments.Clear()
        If loadedMsg.FindAllAttachments.Count > 0 Then

            selAttachments = loadedMsg.FindAllAttachments()
            AnlagenTextBox.Text = loadedMsg.FindAllAttachments.Count.ToString
            'For Each anl In loadedMsg.FindAllAttachments

            'Next

            For Each anl In loadedMsg.FindAllAttachments
                'Anlage temporär speichern
                Try
                    lboxSaveAtt.Items.Add(anl.FileName)
                    GVAttList.Rows.Add()
                    GvIndex = GvIndex + 1
                    GVAttList.Item(0, GvIndex).Value = anl.FileName
                    AnlagenIDTextBox.Text += loadedMsg.Headers.MessageId & ", "
                    WriteToFile(anl.Body, tempPath & "temp_" & anl.FileName)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try
            Next
            AnlagenIDTextBox.Text = AnlagenIDTextBox.Text.Substring(0, AnlagenIDTextBox.Text.Length - 2)
        End If
        'MsgBox(webMsg)
        'WebBrowser1.DocumentText = MyString 'loadedMsg.MessagePart.GetBodyAsText
        WebBrowser1.Document.Body.InnerHtml = msgBody 'WebBrowser1.DocumentText = msgBody.ToString
        tempOCRString = WebBrowser1.Document.Body.InnerText
        RichTextBoxOCR.Text = tempOCRString
        InhaltOCRTextBox.Text = tempOCRString
    End Sub

    Public Sub MailContent(ByVal content As String)
        Dim web As New WebBrowser
        Dim txt As String = ""
        'TextBox7.Text = content
        tempOCRString = ""
        ' TextBox7.Text = ""
        content = System.Text.RegularExpressions.Regex.Replace(content, vbCrLf, "")
        ' MsgBox(content)
        content = System.Text.RegularExpressions.Regex.Replace(content, Chr(9), "")
        'MsgBox(content)
        tempOCRString = System.Text.RegularExpressions.Regex.Replace(content, "<.*?>", "")
        ' TextBox7.Text = System.Text.RegularExpressions.Regex.Replace(content, "<.*?>", "")
    End Sub

    Private Sub AutoZuordnung(ByVal sString As String)
        'TODO:   AutoZuordnung aktivieren
        Dim sWort As String
        Dim sID As String
        Dim i As Integer = 0
        'Zuordnung aus Settings:
        CbEmpfaenger.SelectedValue = CInt(StEmpfaenger)
        CbMandant.SelectedValue = CInt(StartMandant)

        ' MsgBox(VorlagenBindingSource.Count.ToString)

        Dim vorlagen = From p In _FreeDMS_StartDBDataSet.Vorlagen
        ' MsgBox(vorlagen.Count.ToString)
        For Each el In vorlagen

            sWort = el.schluesselwort
            sID = el.id.ToString
            Dim result() As String
            Dim sep As Char = Chr(44)
            result = sWort.Split(sep)
            ''Stichworte mit Function Splitt auswählen - für spätere Version
            For Each s As String In result
                'MyString auf Stichworte überprüfen
                If InStr(sString, s, vbTextCompare) > 0 Then
                    'wenn positiv, zugehörige Details in ensprechende Textboxen eintragen

                    'Dim vorlagenRow As FreeDMS_DB_testDataSet.VorlagenRow
                    'vorlagenRow = FreeDMS_DB_testDataSet.Vorlagen.FindByid(dummy)

                    If (el.Mandant > 0) Then
                        CbMandant.SelectedValue = CInt(el.Mandant)
                        'MandantTextBox.Text = cidnt(el.Mandant)
                        CbMandant.BackColor = Color.GreenYellow
                    End If
                    If (el.akte > 0) Then
                        CbAkte.SelectedValue = CInt(el.akte)
                        'AkteTextBox.Text = el.akte
                        CbAkte.BackColor = Color.GreenYellow
                    End If
                    If (el.vorgang > 0) Then
                        CbVorgang.SelectedValue = CInt(el.vorgang)
                        'VorgangTextBox.Text = el.vorgang
                        CbVorgang.BackColor = Color.GreenYellow
                    End If
                    If (el.autor > 0) Then
                        CbAbsender.SelectedValue = CInt(el.autor)
                        ' AbsenderTextBox.Text = el.autor
                        CbAbsender.BackColor = Color.GreenYellow
                    End If
                    If (el.ablage > 0) Then
                        CbAblage.SelectedValue = CInt(el.ablage)
                        'AblageTextBox.Text = el.ablage
                        CbAblage.BackColor = Color.GreenYellow
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub ClearText()
        For Each c As Control In Panel1.Controls
            If TypeOf c Is TextBox Then
                'oder
                'If c = acTextBox Then
                'MsgBox(c.ToString)
                c.Text = ""
                ' c.BackColor = Color.White
            End If
        Next
        'vorbelegen
        ' Me.cbMandant.Text = "Bitte auswählen"
        'cbMandant.SelectedValue = CInt(StartMandant)
        'MandantTextBox.Text = StartMandant
        CbAkte.Text = "Bitte auswählen"
        CbAblage.Text = "Bitte auswählen"
        CbAbsender.Text = "Bitte auswählen"
        CbStatus.Text = "Bitte auswählen"
        CbTyp.Text = "Bitte auswählen"
        CbVorgang.Text = "Bitte auswählen"
        'cbVorgang.SelectedValue = Nothing
        'MsgBox(cbVorgang.SelectedValue.ToString)
    End Sub
#End Region
#Region "Datensatz bearbeiten"
    Private Sub CbMandant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMandant.SelectedIndexChanged
        If CbMandant.SelectedIndex >= 0 Then
            AktenBindingSource.Filter = "Mandant=" & CbMandant.SelectedValue.ToString
            ' MsgBox(DirectCast(AktenBindingSource.Current, DataRowView).Item("id").ToString)
        End If
    End Sub
    Private Sub CbAkte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAkte.SelectedIndexChanged
        If CbAkte.SelectedIndex >= 0 Then
            VorgaengeBindingSource.Filter = "Akte=" & CbAkte.SelectedValue.ToString
        End If
    End Sub
    Private Sub DateTimePickerDokDatum_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePickerDokDatum.ValueChanged
        DokDatumTextBox.Text = DateTimePickerDokDatum.Value.ToString
    End Sub
    Private Sub BtOCRChange_Click(sender As Object, e As EventArgs) Handles BtOCRChange.Click
        InhaltOCRTextBox.Text = RichTextBoxOCR.Text
    End Sub
#End Region
#Region "Speichern und zurück"

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        SaveDoc()

    End Sub

    Private Sub SaveDoc()
        Dim tempName As String = Nothing
        'Abfrage ob die erforderlichern Felder gefüllt sind
        If CbAkte.SelectedIndex = -1 Then
            MsgFilledField("Akte")
            Exit Sub
        End If

        If CbVorgang.SelectedIndex = -1 Then
            MsgFilledField("Vorgang")
            Exit Sub
        End If
        If String.IsNullOrEmpty(DokumentTextBox.Text) Then
            MsgFilledField("Dokument")
            Exit Sub
        End If

        If CbAbsender.SelectedIndex = -1 Then
            MsgFilledField("Absender")
            Exit Sub
        End If
        If CbAblage.SelectedIndex = -1 Then
            MsgFilledField("Ablage")
            Exit Sub
        End If
        If CbTyp.SelectedIndex = -1 Then
            MsgFilledField("Typ")
            Exit Sub
        End If
        If CbStatus.SelectedIndex = -1 Then
            MsgFilledField("Status")
            Exit Sub
        End If
        If String.IsNullOrEmpty(DokDatumTextBox.Text) Then
            MsgFilledField("Datum Dokument")
            Exit Sub
        End If
        If String.IsNullOrEmpty(InhaltOCRTextBox.Text) Then
            If MsgBox("OCR-Text wurde nicht übernommen, OK?", vbYesNo) = DialogResult.No Then Exit Sub
        End If
        'Wenn Dok mehrfach zugeordnet wird
        'evt. vorhandene .ocr-Datei löschen
        BtSave.Enabled = False
        If mehrfachFlag = False Then
            tempName = currDokName
            'für Testläufe ausschalten
            If File.Exists(InputOrdner & System.IO.Path.GetFileNameWithoutExtension(tempName) & ".ocr") Then
                Kill(InputOrdner & System.IO.Path.GetFileNameWithoutExtension(tempName) & ".ocr")
            End If
        End If
        'Originaldokument umbenennen in DokName
        RenameDokFile(currDokName)
        'Daten für ggf. weitere Zuordnung zwischenspeichern
        'DocContent = Nothing
        FillDokInhalt()
        With Start.currDoc
            .Mandant = CInt(CbMandant.SelectedValue)
            .Akte = CInt(CbAkte.SelectedValue)
            .Vorgang = CInt(CbVorgang.SelectedValue)
            'Prüfen, ob +1 erforderlich
            .Dokument = currDokID
        End With
        'Wenn Attachment, in Tb Anlagen speichern
        If isAttachment = True Then
            Dim anyRow = _FreeDMS_StartDBDataSet.Anlagen.NewAnlagenRow
            anyRow.DokID = MailID
            anyRow.AnlagenID = currDokID
            _FreeDMS_StartDBDataSet.Anlagen.AddAnlagenRow(anyRow)
            isAttachment = False
            'lboxSaveAtt.SelectedItem
        End If
        'InhaltOCRTextBox.Text = tempOCRString
        Try
            Validate()
            DokumenteBindingSource.EndEdit()
            AnlagenBindingSource.EndEdit()
            DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)
            AnlagenTableAdapter.Update(_FreeDMS_StartDBDataSet.Anlagen)
            'erhöhen für dokNr.
        Catch ex As Exception
            MsgBox("Fehler beim Speichern!")
            Exit Sub
        End Try


        currDokID = currDokID + 1
        'Original-Doc umbenennen und im Archivordner speichern
        tempOCRString = Nothing
        RichTextBoxOCR.Clear()
        TabControl1.SelectedTab = TabPage1
        btWeiterZuordnung.Enabled = True

        lbSpeichstatus.Text = "Datensatz gespeichert!"
        lbSpeichstatus.ForeColor = Color.Green
        speicherFlag = True
        lboxSaveAtt.Enabled = True
        GVAttList.Enabled = True
        LoadLvDok()
    End Sub
    Private Sub btWeiterZuordnung_Click(sender As Object, e As EventArgs) Handles btWeiterZuordnung.Click
        Dim dokName() As String
        dokName = Split(lastDocName, "#")
        mehrfachFlag = True
        DokumenteBindingSource.AddNew()
        'For Each el In DokInhalt
        '    If el.docID.ToString.Contains(CStr(currDokID)) Then
        '        With el
        With DocContent
            CbMandant.SelectedValue = .mandant
            CbAkte.SelectedValue = .akte
            CbVorgang.SelectedValue = .vorgang
            DokumentTextBox.Text = .dokument
            BetreffTextBox.Text = .betreff
            BetragTextBox.Text = .betrag.ToString
            AnlagenTextBox.Text = .anlagen
            CbAbsender.SelectedValue = .absender 'AbsenderTextBox.Text = Str(.absender)
            CbEmpfaenger.SelectedValue = .empfaenger
            DokDatumTextBox.Text = .dokDatum.ToString
            AufgenommenTextBox.Text = .aufgenommen
            KommentarTextBox.Text = .kommentar
            tempOCRString = .inhalt
            InhaltOCRTextBox.Text = .inhalt
            CbAblage.SelectedValue = .ablage 'AblageTextBox.Text = Str(.ablage)
            CbTyp.SelectedValue = .typ 'TypTextBox.Text = Str(.typ)
            CbStatus.SelectedValue = .status 'StatusTextBox.Text = Str(.status)
            DokNameTextBox.Text = .dokName
            If .istanlage Then IstAnlageCheckBox.CheckState = CheckState.Checked
            AnlagenIDTextBox.Text = .anlagenid

            If String.IsNullOrEmpty(.bearbeit) Then
                BearbVermerkTextBox.Text = " Siehe auch Az: " & dokName(0) & "/" & (.docID - 1).ToString
            Else
                BearbVermerkTextBox.Text = .bearbeit & vbCrLf & " Siehe auch Az: " & dokName(0) & "/" & (.docID - 1).ToString
            End If

        End With
        'End If
        'Next
        btWeiterZuordnung.Enabled = False
        BtSave.Enabled = True
    End Sub
    Private Sub MsgFilledField(ByVal field As String)
        MsgBox("Feld " & field & " darf nicht leer sein!", vbCritical)
        BtSave.Enabled = True
        btWeiterZuordnung.Visible = True
    End Sub
    Private Sub RenameDokFile(ByVal sDokName As String)
        'Dim dummy As String
        If mehrfachFlag = False Then
            'sBereich = Me.cbAkteNeu.SelectedValue
            ' dummy = Me.TbGrunddatenBindingSource.Count.ToString
            newFile = CbMandant.SelectedValue.ToString & "-" & CbAkte.SelectedValue.ToString & "-" & CbVorgang.SelectedValue.ToString & "#" & currDokID & System.IO.Path.GetExtension(sDokName)
            DokNameTextBox.Text = newFile
            lastDocName = newFile
            Try
                File.Copy(sDokName, ArchivOrdner & newFile, True)
                'FileCopy(My.Settings.SettingScanInputOrdner & Me.ListView1.SelectedItems(index).Text(), My.Settings.SettingArchivOrdner & Me.txtDocID.Text) 'Testlauf
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try
            ' dummy = InputOrdner & sDokName
            'Webbrowser leere
            WebBrowser1.Navigate("about:blank")
            'und Zeit zum "Abschalten" lassen -> sonst Fehler: Datei noch geöffnet
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
            'und das Originaldokument löschen
            Try
                Kill(sDokName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

            'DokNameTextBox.Text = newFile
            MsgBox("Abgelegt unter Az: " & newFile)
        End If
    End Sub
    Private Sub FillDokInhalt()
        If String.IsNullOrEmpty(BetragTextBox.Text) Then BetragTextBox.Text = "0"
        With DocContent
            .docID = currDokID + 1 'DocID muss erhöht werden, da sonst doppeltes Az!
            .mandant = CInt(CbMandant.SelectedValue)
            .akte = CInt(CbAkte.SelectedValue)
            .vorgang = CInt(CbVorgang.SelectedValue)
            .dokument = DokumentTextBox.Text
            .betreff = BetreffTextBox.Text
            .betrag = CDec(BetragTextBox.Text)
            .anlagen = AnlagenTextBox.Text
            .absender = CInt(CbAbsender.SelectedValue)
            .empfaenger = CInt(CbEmpfaenger.SelectedValue)
            .dokDatum = DokDatumTextBox.Text
            .aufgenommen = AufgenommenTextBox.Text
            .kommentar = KommentarTextBox.Text
            .inhalt = InhaltOCRTextBox.Text
            .ablage = CInt(CbAblage.SelectedValue)
            .typ = CInt(CbTyp.SelectedValue)
            .status = CInt(CbStatus.SelectedValue)
            .dokName = DokNameTextBox.Text
            .istanlage = CBool(IstAnlageCheckBox.CheckState)
            .anlagenid = AnlagenIDTextBox.Text
            .bearbeit = BearbVermerkTextBox.Text
        End With
    End Sub
    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        If speicherFlag = False Then DokumenteBindingSource.CancelEdit() 'Abbruch ohne speichern
        Close()
    End Sub

    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim sDokName As String = InputOrdner
        If (LvDoc.SelectedItems.Count = 0) Then Exit Sub
        sDokName += LvDoc.SelectedItems(0).Text()
        Try
            Process.Start(sDokName)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & sDokName)
        End Try
    End Sub

    Private Sub ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem2.Click
        Dim sDokName As String = InputOrdner
        If (LvDoc.SelectedItems.Count = 0) Then Exit Sub
        sDokName += LvDoc.SelectedItems(0).Text()
        Try
            MsgBox(sDokName & " löschen?")
            Kill(sDokName)
            LoadLvDok()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & sDokName)
        End Try
    End Sub

    Private Sub lboxSaveAtt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxSaveAtt.SelectedIndexChanged

        ' MailID = lastID + 1 ' currDokID = MaxID(CurrDB)
        'MsgBox(currDokID.ToString & " - " & currDokName)
        'MsgBox(lboxSaveAtt.SelectedItem.ToString)
        isAttachment = True
        BtSave.Enabled = True
        FileInhalt(tempPath & "temp_" & lboxSaveAtt.SelectedItem.ToString)
        lboxSaveAtt.Enabled = False
        GVAttList.Enabled = False
    End Sub

    Private Sub GVAttList_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVAttList.CellClick
        Dim currIndex As Integer = GVAttList.CurrentRow.Index

        isAttachment = True
        BtSave.Enabled = True
        'MsgBox(GVAttList.Rows(currIndex).Cells(0).Value.ToString)
        FileInhalt(tempPath & "temp_" & GVAttList.Rows(GVAttList.CurrentRow.Index).Cells(0).Value.ToString)
        GVAttList.Rows(currIndex).DefaultCellStyle.Font = New Font(GVAttList.Font, FontStyle.Strikeout)
        GVAttList.Enabled = False
    End Sub

#End Region
End Class