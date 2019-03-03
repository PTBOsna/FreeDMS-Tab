Option Strict On
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Imports System.IO
Imports System.Text
Imports outlook = Microsoft.Office.Interop.Outlook
Imports OpenPop.Mime
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Public Class ScanInput2
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

    Dim DokInhalt As New List(Of DocumentData)
    Dim currDokName As String = "" 'ehemals ttxt. Enthält ScanInput-Pfad und File-Name
    Dim ext As String
    Dim mehrfachFlag As Boolean = False
    Dim speicherFlag As Boolean = False
    Dim anzahlDS As Integer = 0
    Dim sTmp As String
    Dim lastDocName As String
    Dim isAttachment As Boolean = False
    Dim FileContent As String
    Dim FileReadOk As Boolean = False
    Dim newFile As String
    Dim imList As New List(Of Bitmap)
    Dim selAttachments As New List(Of MessagePart)
    Dim tempOCRString As String

#Region "Start"
    Private Sub ScanInput2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim selDB = New FreeDMS_Aux.FreeDMS.DbHandling
        'selDB.LoadDB(CurrDB)
        'DokumenteTableAdapter.Connection = selDB.con
        'DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)
        tempDokName.Clear()
        DokumenteBindingSource.Filter = "id=0"  ' ClearText()
        txtAendern.Text = "Eingangsordner: " & InputOrdner


        'AnzahlDS für DokName ermitteln - wird später hochgezählt
        anzahlDS = CInt((FreeDMS_Aux.FreeDMS.Aux.MaxID(CurrDB) + 1))
        LoadLvDok()
        '  WebBrowser1.Navigate("about:blank")
        WebBrowser1.DocumentText = sHTML
    End Sub
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
    Private Sub LvDoc_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles LvDoc.MouseClick
        ClearText()
        'Inhalt auslesen und umbenennen
        If e.Button = MouseButtons.Left Then
            If (LvDoc.SelectedItems.Count = 0) Then Exit Sub

            FileInhalt(LvDoc.SelectedItems(0).Text())
            BtSave.Enabled = True
        End If
    End Sub
#End Region
#Region "Verarbeitung"
    Private Sub FileInhalt(ByVal lvSelItem As String)
        'Vorbereitung
        speicherFlag = False
        '  mehrfachFlag = False
        btWeiterZuordnung.Enabled = False
        lbSpeichstatus.Text = "Noch nicht gespeichert!"
        lbSpeichstatus.ForeColor = Color.Red
        TextBox1.Text = anzahlDS.ToString
        WebBrowser1.Navigate("about: blank")
        'InhaltOCRTextBox-File ggf. löschen
        sTmp = tempPath & "temp.ocr"
        If File.Exists(sTmp) Then Kill(sTmp)
        ''neuen Datensatz anfügen
        DokumenteBindingSource.AddNew()
        'Vorbelegungen
        CbMandant.SelectedValue = StartMandant
        CbEmpfaenger.SelectedValue = StEmpfaenger
        EmpfaengerTextBox.Text = StEmpfaenger.ToString
        AufgenommenTextBox.Text = Format(Now, "dd.MM.yyyy")
        IstAnlageCheckBox.CheckState = CheckState.Unchecked
        ' tempOCRString = "Hier kommt der Text hinein"
        ''AnzahlDS für DokName ermitteln
        'anzahlDS = CInt((FreeDMS_Aux.FreeDMS.Aux.MaxID(CurrDB) + 1))

        If isAttachment Then
            currDokName = lvSelItem
            isAttachment = False
        Else
            currDokName = InputOrdner & lvSelItem
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
                tempOCRString = FileContent
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
                    WebBrowser1.Navigate(currDokName)
                    FileReadOk = True
                Else
                    PdfHandle(currDokName)
                End If
                ' MsgBox("PDF")
                'ausführen nur wenn OCR-Programm vorhanden!
                'MsgBox(FlagPdfToText.ToString)
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
                    'Dim newDokName As String = System.IO.Path.GetFileNameWithoutExtension(currDokName) & ".PDF"
                    'My.Computer.FileSystem.RenameFile(currDokName, newDokName)
                    imList.Add(CType(Image.FromFile(currDokName, True), Bitmap))
                    ' sTmpFile = currDokName
                    ImgHandle(currDokName)
                    imList.Clear()
                End If

            Case Else
                If MsgBox("Kein unterstützes Dokument. Speichern aber dennoch möglich!" & vbCrLf & "Weiter oder abbrechen?", vbOKCancel, "Fehler") = vbCancel Then
                    Exit Sub
                End If

        End Select
        'TODO: Autozuordnung in den "Handle-Subs" einfügen
        ' TempOCR.Text = tempOCRString
        AutoZuordnung(tempOCRString)
    End Sub
    Private Sub ImgHandle(ByVal FileName As String)
        Cursor.Current = Cursors.WaitCursor
        Dim ocrErgeb(2) As String

        Dim newName As String = InputOrdner & System.IO.Path.GetFileNameWithoutExtension(FileName) & ".PDF"
        Try
            FreeDMS_Aux.FreeDMS.Aux.ConvertImageToPdf(imList, newName)

            currDokName = newName
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Fehler bei der PDF-Erstellung")
        End Try

        Try
            ocrErgeb = FreeDMS_Aux.FreeDMS.Aux.CreateOCR(imList)
            ' MsgBox(ocrErgeb(0))
            ' TempOCR.Text = ocrErgeb(0)
            tempOCRString = ocrErgeb(0)
            TabControl1.SelectedTab = TabPage2

        Catch ex As Exception
            MsgBox(ex.Message, , "Fehler bei der OCR-Erstellung")
        End Try

        Cursor.Current = Cursors.Default

    End Sub

    ''' <summary>
    ''' Auslesen DOK, DOKX und RTF
    ''' </summary>
    ''' <param name="FileName"></param>
    Private Sub DocHandle(ByVal FileName As String)
        'TODO: PFD nach Text für OCR-Feld einfügen
        Dim word As New Microsoft.Office.Interop.Word.Application
        Dim doc As Microsoft.Office.Interop.Word.Document = Nothing
        Dim outputFilename As String = ""
        'Auswerten
        Try

            doc = word.Documents.Open(DirectCast(FileName.ToString, Object))
            doc.Activate()
            doc.SaveAs2(FileName:=DirectCast(sTmp, Object), FileFormat:=2)
            '  doc.Close()
            'Inhalt für OCR auslesen


        Catch ex As Exception
            MsgBox("Kein lesbares Dokument!")
        End Try
        'für Anzeige im Browser nach pdf konvertieren
        File.Copy(FileName, tempPath & System.IO.Path.GetFileName(FileName), True)
        Try
            'wordDocument = wordApplication.Documents.Open(FileName.ToString)
            outputFilename = System.IO.Path.ChangeExtension(FileName, "pdf")

            If Not doc Is Nothing Then
                doc.ExportAsFixedFormat(outputFilename, Microsoft.Office.Interop.Word.WdExportFormat.wdExportFormatPDF, False, Microsoft.Office.Interop.Word.WdExportOptimizeFor.wdExportOptimizeForOnScreen, Microsoft.Office.Interop.Word.WdExportRange.wdExportAllDocument, 0, 0, Microsoft.Office.Interop.Word.WdExportItem.wdExportDocumentContent, True, True, Microsoft.Office.Interop.Word.WdExportCreateBookmarks.wdExportCreateNoBookmarks, True, True, False)
            End If
        Catch ex As Exception

            MsgBox(ex.Message)
        Finally
            If Not doc Is Nothing Then
                doc.Close(False)
                doc = Nothing
            End If

            If Not word Is Nothing Then
                word.Quit()
                word = Nothing
            End If
        End Try
        '  FileContent = FreeDMS_Namespace.FreeDMS.Aux.ReadFile(sTmp)
        FileContent = FreeDMS_Aux.FreeDMS.Aux.ReadFile(sTmp)
        WebBrowser1.Navigate(outputFilename)
        tempOCRString = FileContent

    End Sub
    ''' <summary>
    ''' Auslesen MSG (Outlook)
    ''' </summary>
    ''' <param name="Msg"></param>
    Private Sub MsgHandle(ByVal Msg As String)
        Dim oApp As New outlook.Application
        Dim OMItem As outlook.MailItem
        Try
            OMItem = CType(oApp.CreateItemFromTemplate(Msg), outlook.MailItem)
            FileContent = "Gesendet: " & OMItem.SentOn & vbCrLf & "Von: " & OMItem.SenderName & vbCrLf & "Betreff: " & OMItem.Subject & OMItem.Body
            tempOCRString = FileContent
            WebBrowser1.DocumentText = OMItem.Body.ToString
            DokumentTextBox.Text = "EMail von " & OMItem.SenderName.ToString
            BetreffTextBox.Text = OMItem.Subject
            DokDatumTextBox.Text = OMItem.SentOn.ToShortDateString
            If OMItem.Attachments.Count > 0 Then AnlagenIDTextBox.Text = OMItem.Attachments.Count.ToString
            If OMItem.Body.Length > 2000 Then
                KommentarTextBox.Text = "Text zu lang, bitte ggf. OCR-Feld prüfen!"
            Else
                KommentarTextBox.Text = OMItem.Body
            End If

        Catch ex As Exception
            WebBrowser1.Navigate("about: blank")
            MsgBox(ex.Message)

        Finally
            oApp = Nothing
            OMItem = Nothing
        End Try
    End Sub
    ''' <summary>
    ''' Auselesen PDF
    ''' </summary>
    ''' <param name="Mypdf"></param>
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
    End Sub
    ''' <summary>
    ''' Auslesen EML (Mail aus FreeeDMS)
    ''' </summary>
    ''' <param name="MyEml"></param>
    Public Sub EmlHandle(ByVal MyEml As String)
        Dim file As FileInfo = New FileInfo(MyEml)
        Dim loadedMsg As Message = Message.Load(file)
        Dim msgBody As String = ""
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
        'Steuerzeichen und HTML-Tags aus Msg entfernen
        MailContent(msgBody)
        ' MsgBox(DirectCast(WebBrowser1.DocumentText, String))
        FileContent = msgBody
        'MsgBox(loadedMsg.Headers.Subject.ToString)
        'Dim webMsg As String = "<html><body>" & "Gesendet: " & msgBody & "</body></html>" '& loadedMsg.Headers.DateSent & "<br />" & body & "</body></html>"
        'MyString = "Gesendet: " & loadedMsg.Headers.DateSent & "<br />" & "Von: " & loadedMsg.Headers.From.DisplayName.ToString & "<br />" & "Betreff: " & loadedMsg.Headers.Subject ' & loadedMsg.MessagePart.GetBodyAsText
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
            For Each anl In loadedMsg.FindAllAttachments
                lboxSaveAtt.Items.Add(anl.FileName)
                AnlagenIDTextBox.Text += loadedMsg.Headers.MessageId & ", "
            Next
            AnlagenIDTextBox.Text = AnlagenIDTextBox.Text.Substring(0, AnlagenIDTextBox.Text.Length - 2)
        End If
        'MsgBox(webMsg)
        'WebBrowser1.DocumentText = MyString 'loadedMsg.MessagePart.GetBodyAsText
        WebBrowser1.DocumentText = msgBody.ToString
    End Sub

    ''' <summary>
    ''' Inhalt von EML-Content (Mail-Body) auslesen
    ''' Erwartet Mail-Body als Übergabe
    ''' </summary>
    ''' <param name="content"></param>
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
    'TODO: ClearText kann entfallen -> Prüfen!
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
        'cbAkteNeu.Text = "Bitte auswählen"
        'cbAblage.Text = "Bitte auswählen"
        'ComboBoxNamen.Text = "Bitte auswählen"
        'cbStatus.Text = "Bitte auswählen"
        'cbTyp.Text = "Bitte auswählen"
        'cbVorgang.Text = "Bitte auswählen"
        'cbVorgang.SelectedValue = Nothing
        'MsgBox(cbVorgang.SelectedValue.ToString)
    End Sub
    Private Sub AutoZuordnung(ByVal sString As String)
        'TODO:   AutoZuordnung aktivieren
        Dim sWort As String
        Dim sID As String
        Dim i As Integer = 0
        'Zuordnung aus Settings:
        CbEmpfaenger.SelectedValue = CInt(StEmpfaenger)
        CbMandant.SelectedValue = CInt(StartMandant)


        Dim vorlage = From p In _FreeDMS_StartDBDataSet.Vorlagen
        ' MsgBox(vorlage.Count.ToString)
        For Each el In vorlage

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
#End Region
#Region "Zuordnung"

    Private Sub DokDatumDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles DokDatumDateTimePicker.ValueChanged
        DokDatumTextBox.Text = DokDatumDateTimePicker.Value.ToString
    End Sub
    Private Sub CbMandant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMandant.SelectedIndexChanged
        If CbMandant.SelectedIndex >= 0 Then
            AktenBindingSource.Filter = "Mandant=" & CbMandant.SelectedValue.ToString
            MandantTextBox.Text = CbMandant.SelectedValue.ToString
        End If
    End Sub
    Private Sub CbAkte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAkte.SelectedIndexChanged
        If CbAkte.SelectedIndex >= 0 Then
            VorgaengeBindingSource.Filter = "Akte=" & CbAkte.SelectedValue.ToString
            AkteTextBox.Text = CbAkte.SelectedValue.ToString
        End If
    End Sub
    Private Sub CbVorgang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVorgang.SelectedIndexChanged
        If CbVorgang.SelectedIndex >= 0 Then
            VorgangTextBox.Text = CbAkte.SelectedValue.ToString
        End If
    End Sub
    Private Sub CbAbsender_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAbsender.SelectedIndexChanged
        If CbAbsender.SelectedIndex >= 0 Then
            AbsenderTextBox.Text = CbAbsender.SelectedValue.ToString
        End If
    End Sub
    Private Sub CbAblage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAblage.SelectedIndexChanged
        If CbAblage.SelectedIndex >= 0 Then
            AblageTextBox.Text = CbAblage.SelectedValue.ToString
        End If
    End Sub
    Private Sub CbTyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTyp.SelectedIndexChanged
        If CbTyp.SelectedIndex >= 0 Then
            TypTextBox.Text = CbTyp.SelectedValue.ToString
        End If
    End Sub
    Private Sub CbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbStatus.SelectedIndexChanged
        If CbStatus.SelectedIndex >= 0 Then
            StatusTextBox.Text = CbStatus.SelectedValue.ToString
        End If
    End Sub

#End Region
#Region "Speichern und zurück"
    Private Sub SaveDoc()
        Dim tempName As String
        If String.IsNullOrEmpty(AkteTextBox.Text) Then
            MsgFilledField("Akte")
            Exit Sub
        End If
        If String.IsNullOrEmpty(VorgangTextBox.Text) Then
            MsgFilledField("Vorgang")
            Exit Sub
        End If
        If String.IsNullOrEmpty(DokumentTextBox.Text) Then
            MsgFilledField("Dokument")
            Exit Sub
        End If

        If String.IsNullOrEmpty(AbsenderTextBox.Text) Then
            MsgFilledField("Absender")
            Exit Sub
        End If
        If String.IsNullOrEmpty(AblageTextBox.Text) Then
            MsgFilledField("Ablage")
            Exit Sub
        End If
        If String.IsNullOrEmpty(TypTextBox.Text) Then
            MsgFilledField("Typ")
            Exit Sub
        End If
        If String.IsNullOrEmpty(StatusTextBox.Text) Then
            MsgFilledField("Status")
            Exit Sub
        End If
        If String.IsNullOrEmpty(DokDatumTextBox.Text) Then
            MsgFilledField("Datum Dokument")
            Exit Sub
        End If
        If String.IsNullOrEmpty(tempOCRString) Then
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


        RenameDokFile(currDokName)
        'Daten für ggf. weitere Zuordnung zwischenspeichern
        FillDokInhalt()
        With Start.currDoc
            .Mandant = CInt(MandantTextBox.Text)
            .Akte = CInt(AkteTextBox.Text)
            .Vorgang = CInt(VorgangTextBox.Text)
            .Dokument = anzahlDS + 1
        End With

        InhaltOCRTextBox.Text = tempOCRString
        Try
            Validate()
            DokumenteBindingSource.EndEdit()
            DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)
            'erhöhen für dokNr.
            anzahlDS = anzahlDS + 1
        Catch ex As Exception
            MsgBox("Fehler beim Speichern!")
            Exit Sub
        End Try

        'Original-Doc umbenennen und im Archivordner speichern
        tempOCRString = Nothing
        ' TempOCR.Text = Nothing
        btWeiterZuordnung.Enabled = True

        lbSpeichstatus.Text = "Datensatz gespeichert!"
        lbSpeichstatus.ForeColor = Color.Green
        speicherFlag = True
        LoadLvDok()
    End Sub
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        SaveDoc()
    End Sub
    Private Sub BtWeiterZuordnung_Click(sender As Object, e As EventArgs) Handles btWeiterZuordnung.Click
        Dim dokName() As String
        dokName = Split(lastDocName, "#")
        mehrfachFlag = True
        DokumenteBindingSource.AddNew()
        For Each el In DokInhalt
            If el.docID.ToString.Contains(CStr(anzahlDS)) Then
                With el
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
                    CbAblage.SelectedValue = .ablage 'AblageTextBox.Text = Str(.ablage)
                    CbTyp.SelectedValue = .typ 'TypTextBox.Text = Str(.typ)
                    CbStatus.SelectedValue = .status 'StatusTextBox.Text = Str(.status)
                    DokNameTextBox.Text = .dokName
                    If .istanlage Then IstAnlageCheckBox.CheckState = CheckState.Checked
                    AnlagenIDTextBox.Text = .anlagenid

                    If String.IsNullOrEmpty(el.bearbeit) Then
                        BearbVermerkTextBox.Text = " Siehe auch Az: " & dokName(0) & "/" & el.docID.ToString
                    Else
                        BearbVermerkTextBox.Text = el.bearbeit & vbCrLf & " Siehe auch Az: " & dokName(0) & "/" & el.docID.ToString
                    End If

                End With
            End If
        Next
        btWeiterZuordnung.Enabled = False
        BtSave.Enabled = True
    End Sub
    Private Sub FillDokInhalt()
        'anzahlDS = FreeDMS_Aux.FreeDMS.Aux.MaxID(CurrDB)

        If String.IsNullOrEmpty(BetragTextBox.Text) Then BetragTextBox.Text = "0"
        DokInhalt.Add(New DocumentData With
                      {.docID = anzahlDS + 1,
                        .mandant = CInt(CbMandant.SelectedValue),
                        .akte = CInt(CbAkte.SelectedValue),
                        .vorgang = CInt(CbVorgang.SelectedValue),
                        .dokument = DokumentTextBox.Text,
                        .betreff = BetreffTextBox.Text,
                        .betrag = CDec(BetragTextBox.Text),
                        .anlagen = AnlagenTextBox.Text,
                        .absender = CInt(CbAbsender.SelectedValue),
                        .empfaenger = CInt(CbEmpfaenger.SelectedValue),
                        .dokDatum = DokDatumTextBox.Text,
                        .aufgenommen = AufgenommenTextBox.Text,
                        .kommentar = KommentarTextBox.Text,
                        .inhalt = tempOCRString,
                        .ablage = CInt(CbAblage.SelectedValue),
                        .typ = CInt(CbTyp.SelectedValue),
                        .status = CInt(CbStatus.SelectedValue),
                        .dokName = DokNameTextBox.Text,
                        .istanlage = CBool(IstAnlageCheckBox.CheckState),
                        .anlagenid = AnlagenIDTextBox.Text,
                        .bearbeit = BearbVermerkTextBox.Text})

        ''nur zum TEsten
        'For Each el In DokInhalt
        '    With ListBox1.Items
        '        .Add(el.docID)
        '        .Add(el.akte)
        '        .Add(el.ablage)
        '        .Add(el.absender)
        '        .Add(el.aufgenommen)
        '        .Add(el.betreff)
        '        .Add(el.dokDatum)
        '        .Add(el.mandant)
        '        .Add(el.vorgang)
        '        .Add("_________________________________________")
        '    End With

        ' Next


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
            newFile = CbMandant.SelectedValue.ToString & "-" & CbAkte.SelectedValue.ToString & "-" & CbVorgang.SelectedValue.ToString & "#" & anzahlDS & System.IO.Path.GetExtension(sDokName)
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
    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        If speicherFlag = False Then
            If Not MsgBox("Zurück ohne Dokumentenübernahme?") = MsgBoxResult.Ok Then Exit Sub
        End If
        Close()
    End Sub

    Private Sub TempOCR_TextChanged(sender As Object, e As EventArgs)
        If mehrfachFlag = False Then
            ' tempOCRString = TempOCR.Text
        End If
    End Sub







#End Region
End Class