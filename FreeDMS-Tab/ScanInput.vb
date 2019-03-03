Imports FreeDMS_Aux.FreeDMS.GrundDaten
Imports System.IO
Imports System.Text
Imports outlook = Microsoft.Office.Interop.Outlook
Imports OpenPop.Mime
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
'Imports System.Text.RegularExpressions

''Imports Microsoft.Office.Interop.Word
Imports Message = OpenPop.Mime.Message
''' <summary>
''' ScanInpupt
''' Formular zum Einlesen der Dokument in das System
''' </summary>
Public Class Scaninput
    ''' <summary>
    ''' Datenfelder
    ''' </summary>
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
        Public dokDatum As Date
        Public aufgenommen As Date
        Public geaendert As Date
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
    'Liste mit eindeutigem Namen als Key (String) und dem Documents-Inhalt. Als Key bei EML-Mails evt. MailID nutzen

    Dim DokInhalt As New List(Of DocumentData)
    'Dim DokList As New Dictionary(Of String, List(Of DocumentData))
    Dim currDokName As String = "" 'ehemals ttxt. Enthält ScanInput-Pfad und File-Name
    Dim ext As String
    Dim mehrfachFlag As Boolean = False
    Dim speicherFlag As Boolean = False
    'Dim sDokName As String

    Dim sTmp, sTmpFile As String 'Filenamen
    Dim newFile As String
    Dim anzahlDS As Integer = 0
    Dim FileContent As String
    Dim isAttachment As Boolean = False
    Dim FileReadOk As Boolean = False
    Dim lastDocName As String
    Dim selAttachments As New List(Of MessagePart)
    Dim imList As New List(Of Bitmap)

    ''' <summary>
    ''' Form laden und Tableadapter füllen
    ''' Voreinstellungen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Scaninput_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Dim selDB As New FreeDMS_Aux.FreeDMS.DbHandling
        'selDB.LoadDB(CurrDB)
        'AblageTableAdapter.Connection = selDB.con
        'DokumenteTableAdapter.Connection = selDB.con
        '' VorgaengeTableAdapter.Connection = selDB.con
        ''AktenTableAdapter.Connection = selDB.con
        '' MandantTableAdapter.Connection = selDB.con
        'AnschriftenTableAdapter.Connection = selDB.con
        'StatusTableAdapter.Connection = selDB.con
        'TypTableAdapter.Connection = selDB.con
        'VorlagenTableAdapter.Connection = selDB.con

        'AblageTableAdapter.Fill(_FreeDMS_StartDBDataSet.Ablage)
        ''VorgaengeTableAdapter.Fill(_FreeDMS_StartDBDataSet.Vorgaenge)
        ''AktenTableAdapter.Fill(_FreeDMS_StartDBDataSet.Akten)
        '' MandantTableAdapter.Fill(_FreeDMS_StartDBDataSet.Mandant)
        'DokumenteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Dokumente)
        'StatusTableAdapter.Fill(_FreeDMS_StartDBDataSet.Status)
        'TypTableAdapter.Fill(_FreeDMS_StartDBDataSet.Typ)
        '' AblageTableAdapter.Fill(_FreeDMS_StartDBDataSet.Ablage)
        'AnschriftenTableAdapter.Fill(_FreeDMS_StartDBDataSet.Anschriften)
        'VorlagenTableAdapter.Fill(_FreeDMS_StartDBDataSet.Vorlagen)

        tempDokName.Clear()
        ClearText()
        txtAendern.Text = "Eingangsordner: " & InputOrdner
        'mehrfachFlag = False
        LoadLvDok()
        'btWeiterZuordnung.Enabled = False
        FdErstelltDateTimePicker.Value = Now()
        'AnlagenTextBox.Text = "0"
        'Me.DokDatumTextBox.Text = Now()
        Me.FdAufgenommenTextBox.Text = Now()
        'countData()
        TextBox1.Text = anzahlDS.ToString
        ''countData()
    End Sub
    ''' <summary>
    ''' Einlesen der Dokument aus Ordner ScanInput
    ''' Festlegen der lesbaren Dokumente
    ''' Enddung OCR sollte nicht enthalten sein, damit die OCR-Daten nicht versehentlich als Dokument eingelesen werden
    ''' </summary>
    Private Sub LoadLvDok()
        Dim locDirInfo As DirectoryInfo = Nothing
        Dim locLtvItem As ListViewItem = Nothing
        Dim ltv As ListView
        Dim okFile As String = ".DOC .MSG .PDF .JPG .JPEG .DOCX .TIF .GIF .TXT .XLS .XLSX .EML .PNG .DOT .PUB .BMP"
        ltv = lvDoc
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
    ''' <summary>
    ''' Datei-Auswahl in ListView 
    ''' Aufruf Datei auslesen und Datensatz erstellen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LvDoc_Click(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lvDoc.MouseClick
        ClearText()
        'Inhalt auslesen und umbenennen
        If e.Button = MouseButtons.Left Then
            If (lvDoc.SelectedItems.Count = 0) Then Exit Sub

            FileInhalt(lvDoc.SelectedItems(0).Text())
            btSave.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Daten aus gewählter Datei in das System einlesen
    ''' Je nach Endudng erfolgt Aufruf der speziellen Lese-Routinen
    ''' </summary>
    ''' <param name="lvSelItem"></param>
    Private Sub FileInhalt(ByVal lvSelItem As String)
        'Vorbereitung
        speicherFlag = False
        mehrfachFlag = False
        btWeiterZuordnung.Enabled = False
        lbSpeichstatus.Text = "Noch nicht gespeichert!"
        lbSpeichstatus.ForeColor = Color.Red
        TextBox1.Text = anzahlDS.ToString
        WebBrowser2.Navigate("about: blank")

        'Threading.Thread.Sleep(2000)
        'WebBrowser2.DocumentText = "Hallo World"
        sTmp = tempPath & "temp.ocr"
        'sTmpPDF = tempPath & "temp.pdf"

        If File.Exists(sTmp) Then Kill(sTmp)
        'If File.Exists(sTmpPDF) Then Kill(sTmpPDF)
        ''neuen Datensatz anfügen
        DokumenteBindingSource.AddNew()
        FdAufgenommenTextBox.Text = Now.ToString

        anzahlDS = (FreeDMS_Aux.FreeDMS.Aux.CountData(CurrDB) + 1).ToString
        '  sDokName =lvSelItem
        ' index = Me.lvScanInputSave.SelectedItems(0).Index
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
        'Auswahl aufheben
        lvDoc.SelectedItems.Clear()
        Select Case ext
            Case ".TXT"
                FileContent = FreeDMS_Aux.FreeDMS.Aux.ReadFile(currDokName)
                RichTextBox1.Text = FileContent
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
                    RichTextBox1.Text = FileContent
                    WebBrowser2.Navigate(currDokName)
                    FileReadOk = True
                Else
                    PdfHandle(currDokName)
                End If
                ' MsgBox("PDF")
                'ausführen nur wenn OCR-Programm vorhanden!
                'MsgBox(FlagPdfToText.ToString)
                If Not FileReadOk Then
                    MsgBox("Nicht lesbares PDF-Dokument. Keine Umwandlung in Text möglich")
                    RichTextBox1.Text = "Nicht lesbares PDF-Dokument. Keine Umwandlung in Text möglich"
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
                    sTmpFile = currDokName
                    ImgHandle(currDokName)
                    imList.Clear()
                End If

            Case Else
                If MsgBox("Kein unterstützes Dokument. Speichern aber dennoch möglich!" & vbCrLf & "Weiter oder abbrechen?", vbOKCancel, "Fehler") = vbCancel Then
                    Exit Sub
                End If

        End Select
        'TODO: Autozuordnung in den "Handle-Subs" einfügen
        AutoZuordnung(RichTextBox1.Text)
    End Sub
    ''' <summary>
    ''' Verarbeitung von Image-Datein 
    ''' </summary>
    ''' <param name="FileName"></param>
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
            RichTextBox1.Text = ocrErgeb(0)
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
            'TODO: handle exception
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
        '  FileContent = FreeDMS_Aux.FreeDMS.Aux.ReadFile(sTmp)
        FileContent = FreeDMS_Aux.FreeDMS.Aux.ReadFile(sTmp)
        WebBrowser2.Navigate(outputFilename)
        RichTextBox1.Text = FileContent

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
            RichTextBox1.Text = FileContent
            WebBrowser2.DocumentText = OMItem.Body.ToString
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
            WebBrowser2.Navigate("about: blank")
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
            RichTextBox1.Text = sb.ToString
            FileReadOk = True
        End If
        WebBrowser2.Navigate(Mypdf)
    End Sub
    ''' <summary>
    ''' Auslesen EML (Mail aus FreeeDMS)
    ''' </summary>
    ''' <param name="MyEml"></param>
    Public Sub EmlHandle(ByVal MyEml As String)
        Dim file As FileInfo = New FileInfo(MyEml)
        Dim loadedMsg As Message = Message.Load(file)
        Dim msgBody As String = ""
        'WebBrowser2.Navigate("")

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
        ' MsgBox(DirectCast(WebBrowser2.DocumentText, String))
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
            KommentarTextBox.Text = RichTextBox1.Text
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
        'WebBrowser2.DocumentText = MyString 'loadedMsg.MessagePart.GetBodyAsText
        WebBrowser2.DocumentText = msgBody.ToString
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
        RichTextBox1.Text = ""
        ' TextBox7.Text = ""
        content = System.Text.RegularExpressions.Regex.Replace(content, vbCrLf, "")
        ' MsgBox(content)
        content = System.Text.RegularExpressions.Regex.Replace(content, Chr(9), "")
        'MsgBox(content)
        RichTextBox1.Text = System.Text.RegularExpressions.Regex.Replace(content, "<.*?>", "")
        ' TextBox7.Text = System.Text.RegularExpressions.Regex.Replace(content, "<.*?>", "")
    End Sub
    ''' <summary>
    ''' Aufruf Speichern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        'Füllen der Fileliste, mit Dateinamen, die nach Schließen von ScanInput gelöscht werden sollen

        SaveDoc()
    End Sub
    ''' <summary>
    ''' Aufruf zweite Zuordnung des gewählten Dokuments
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtWeiterZuordnung_Click(sender As Object, e As EventArgs) Handles btWeiterZuordnung.Click
        btSave.Enabled = True
        mehrfachFlag = True
        SaveDoc()
        MsgBox("Weiter Zuordnung unter Az:" & lastDocName & " erfolgt.")
        mehrfachFlag = False
        btWeiterZuordnung.Enabled = False

    End Sub

    ''' <summary>
    ''' Speichern mit vorheriger Abfrage ob relevante Felder gefüllt sind
    ''' </summary>
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
        btSave.Enabled = False
        If mehrfachFlag = False Then
            tempName = currDokName
            RenameDokFile(currDokName)
            If File.Exists(InputOrdner & System.IO.Path.GetFileNameWithoutExtension(tempName) & ".ocr") Then
                Kill(InputOrdner & System.IO.Path.GetFileNameWithoutExtension(tempName) & ".ocr")
            End If
        End If
        FillDokInhalt()
        If DokInhalt.Count > 0 Then

            'Dim NewRow As _FreeDMS_StartDBDataSet.DokumenteRow
            'NewRow = _FreeDMS_StartDBDataSet.Dokumente.NewDokumenteRow()

            'For Each el In DokInhalt
            '    If el.docID.ToString.Contains(anzahlDS + 1) Then
            '        With NewRow
            '            .Mandant = el.mandant
            '            .Akte = el.akte
            '            .Vorgang = el.vorgang
            '            .Dokument = el.dokument
            '            .Betreff = el.betreff
            '            .Betrag = el.betrag
            '            .Anlagen = el.anlagen
            '            .Absender = el.absender
            '            .Empfaenger = el.empfaenger
            '            .DokDatum = el.dokDatum
            '            .Aufgenommen = el.aufgenommen
            '            .Kommentar = el.kommentar
            '            .InhaltOCR = el.inhalt
            '            .Ablage = el.ablage
            '            .Typ = el.typ
            '            .Status = el.status
            '            .DokName = el.dokName
            '            .istAnlage = el.istanlage
            '            .AnlagenID = el.anlagenid
            '            If mehrfachFlag Then
            '                If String.IsNullOrEmpty(el.bearbeit) Then
            '                    .BearbVermerk = " Siehe auch " & lastDocName
            '                Else
            '                    .BearbVermerk = el.bearbeit & vbCrLf & " Siehe auch " & lastDocName
            '                End If
            '            Else
            '                .BearbVermerk = el.bearbeit
            '            End If
            '        End With
            '    End If
            'Next
            Try
                '_FreeDMS_StartDBDataSet.Dokumente.AddDokumenteRow(NewRow)
                Validate()
                DokumenteBindingSource.EndEdit()
                DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)
                If _FreeDMS_StartDBDataSet.HasChanges Then MsgBox("gespeichert")
                'TableAdapterManager.UpdateAll(_FreeDMS_StartDBDataSet)
                btWeiterZuordnung.Enabled = True
                lbSpeichstatus.Text = "Datensatz gespeichert!"
                lbSpeichstatus.ForeColor = Color.Green

            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            With Start.currDoc
                .Mandant = CInt(MandantTextBox.Text)
                .Akte = CInt(AkteTextBox.Text)
                .Vorgang = CInt(VorgangTextBox.Text)
                ' .Dokument = CInt(doki)
            End With
        End If
    End Sub
    ''' <summary>
    ''' Fehleranzeige von SaveDoc
    ''' </summary>
    ''' <param name="field"></param>
    Private Sub MsgFilledField(ByVal field As String)
        MsgBox("Feld " & field & " darf nicht leer sein!", vbCritical)
        btSave.Enabled = True
        btWeiterZuordnung.Visible = True
    End Sub

    ''' <summary>
    ''' Umbenennen des Dokument in Form Mandatn-Akte-Vorgang#DokNummer.Endung
    ''' Erwartet bisherigen DokNamen
    ''' </summary>
    ''' <param name="sDokName"></param>
    Private Sub RenameDokFile(ByVal sDokName As String)
        'Dim dummy As String
        If mehrfachFlag = False Then
            'sBereich = Me.cbAkteNeu.SelectedValue
            ' dummy = Me.TbGrunddatenBindingSource.Count.ToString
            newFile = cbMandant.SelectedValue & "-" & cbAkteNeu.SelectedValue & "-" & cbVorgang.SelectedValue & "#" & anzahlDS & System.IO.Path.GetExtension(sDokName)
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
            WebBrowser2.Navigate("about:blank")
            'und Zeit zum "Abschalten" lassen -> sonst Fehler: Datei noch geöffnet
            System.Windows.Forms.Application.DoEvents()
            System.Threading.Thread.Sleep(1000)
            'und das Originaldokument löschen
            Try
                Kill(sDokName)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
            LoadLvDok()
            DokNameTextBox.Text = newFile
            MsgBox("Abgelegt unter Az: " & newFile)
        End If
    End Sub

    ''' <summary>
    ''' Klasse DokumentData füllen
    ''' Ist für ggf. weitere Zuordnung  erforderlich
    ''' </summary>
    Private Sub FillDokInhalt()
        anzahlDS = FreeDMS_Aux.FreeDMS.Aux.CountData(CurrDB)

        If String.IsNullOrEmpty(BetragTextBox.Text) Then BetragTextBox.Text = "0"
        DokInhalt.Add(New DocumentData With
                      {.docID = anzahlDS + 1,
                        .mandant = cbMandant.SelectedValue,
                        .akte = cbAkteNeu.SelectedValue,
                        .vorgang = cbVorgang.SelectedValue,
                        .dokument = DokumentTextBox.Text,
                        .betreff = BetreffTextBox.Text,
                        .betrag = CDec(BetragTextBox.Text),
                        .anlagen = AnlagenTextBox.Text,
                        .absender = ComboBoxNamen.SelectedValue,
                        .empfaenger = cbEmpfaenger.SelectedValue,
                        .dokDatum = DokDatumTextBox.Text,
                        .aufgenommen = FdAufgenommenTextBox.Text,
                        .kommentar = KommentarTextBox.Text,
                        .inhalt = RichTextBox1.Text,
                        .ablage = cbAblage.SelectedValue,
                        .typ = cbTyp.SelectedValue,
                        .status = cbStatus.SelectedValue,
                        .dokName = DokNameTextBox.Text,
                        .istanlage = IstAnlageCheckBox.CheckState,
                        .anlagenid = AnlagenIDTextBox.Text,
                        .bearbeit = FdBearbeitungsVermerkTextBox.Text})

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
    ''' <summary>
    ''' Mail-Anlagen anzeigen und ggf. separat speichern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LboxSaveAtt_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lboxSaveAtt.SelectedIndexChanged
        Dim ix As Integer = lboxSaveAtt.SelectedIndex()
        If ix < 0 Then
            MsgBox("Bitte zunächst eine Anlage auswählen")
            Exit Sub
        End If
        btSave.Enabled = True
        Dim AttName As String = selAttachments(ix).FileName
        isAttachment = True
        ''speichern der Mail in Liste
        FillDokInhalt()
        ClearText()
        If DokInhalt.Count > 0 Then
            For Each el In DokInhalt
                If el.docID.ToString.Contains(anzahlDS + 1) Then
                    'MsgBox(el.betreff)
                    FdBearbeitungsVermerkTextBox.Text = "Anlage " & ix + 1 & " zu " & el.dokName

                End If
            Next
        End If
        'Vorausfüllen der Textfelder:
        Dim temp As String = DokumentTextBox.Text
        IstAnlageCheckBox.Checked = True
        ' MsgBox(selAttachments(ix).Body.ToString)
        If WriteToFile(selAttachments(ix).Body, tempPath & AttName) Then
            '  Process.Start(tempPath & AttName)
            FileInhalt(tempPath & AttName)
        End If
    End Sub

    ''' <summary>
    ''' Inhalt Anlage als Text speichern und mit Sub FileInhalt in das System einspeisen
    ''' </summary>
    ''' <param name="Source"></param>
    ''' <param name="Filename"></param>
    ''' <returns>Boolean</returns>
    Private Function WriteToFile(ByVal Source As Byte(), ByVal Filename As String) As Boolean
        Try
            My.Computer.FileSystem.WriteAllBytes(Filename, Source, False)
            If System.IO.File.Exists(Filename) Then
                Return True
            Else : Return False
            End If
        Catch ex As System.IO.IOException
            MessageBox.Show(ex.Message.ToString(), "IOException")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Exception")
        End Try
        Return False
    End Function
    ''' <summary>
    ''' Textboxen leeren
    ''' und CoboBoxen vorbelegen
    ''' </summary>
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
        cbMandant.SelectedValue = CInt(StartMandant)
        MandantTextBox.Text = StartMandant
        cbAkteNeu.Text = "Bitte auswählen"
        cbAblage.Text = "Bitte auswählen"
        ComboBoxNamen.Text = "Bitte auswählen"
        cbStatus.Text = "Bitte auswählen"
        cbTyp.Text = "Bitte auswählen"
        cbVorgang.Text = "Bitte auswählen"
        'cbVorgang.SelectedValue = Nothing
        'MsgBox(cbVorgang.SelectedValue.ToString)
    End Sub
    ''' <summary>
    ''' DokDateum Textbox mit DateTimePicker füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub FdErstelltDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles FdErstelltDateTimePicker.ValueChanged
        DokDatumTextBox.Text = FdErstelltDateTimePicker.Value.ToShortDateString
    End Sub

    Private Sub CbMandant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMandant.SelectedIndexChanged
        MandantTextBox.Text = cbMandant.SelectedValue.ToString
    End Sub
    ''' <summary>
    ''' Feld Akte aus ComboBox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbAkteNeu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAkteNeu.SelectedIndexChanged
        VorgaengeBindingSource.Filter = "Akte=" & cbAkteNeu.SelectedValue.ToString
        AkteTextBox.Text = cbAkteNeu.SelectedValue.ToString
    End Sub
    ''' <summary>
    ''' Feld Vorgang aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbVorgang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVorgang.SelectedIndexChanged
        VorgangTextBox.Text = cbVorgang.SelectedValue.ToString
    End Sub
    ''' <summary>
    ''' Feld Ablage aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbAblage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAblage.SelectedIndexChanged
        AblageTextBox.Text = cbAblage.SelectedValue.ToString
    End Sub
    ''' <summary>
    ''' Feld Typ aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbTyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTyp.SelectedIndexChanged
        Try
            TypTextBox.Text = cbTyp.SelectedValue.ToString
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' Feld Status aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        StatusTextBox.Text = cbStatus.SelectedValue.ToString
    End Sub
    ''' <summary>
    ''' Feld Empfänger aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbEmpfaenger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpfaenger.SelectedIndexChanged
        EmpfaengerTextBox.Text = cbEmpfaenger.SelectedValue.ToString
    End Sub
    ''' <summary>
    ''' Formular schließen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Close()

        'Dim pc As System.Diagnostics.Process

        'For Each pc In System.Diagnostics.Process.GetProcesses()
        '    ListBox1.Items.Add(pc.ProcessName)
        'Next

    End Sub
    ''' <summary>
    ''' Feld Absender aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBoxNamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNamen.SelectedIndexChanged
        AbsenderTextBox.Text = ComboBoxNamen.SelectedValue.ToString
    End Sub
    ''' <summary>
    ''' Eintrag in ListView mit zugehöriger App starten (ansehen)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AnsehenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnsehenToolStripMenuItem.Click
        Dim sDokName As String = InputOrdner
        If (lvDoc.SelectedItems.Count = 0) Then Exit Sub
        sDokName += lvDoc.SelectedItems(0).Text()
        Try
            Process.Start(sDokName)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & sDokName)
        End Try
    End Sub
    ''' <summary>
    ''' Eintrag aus ListView löschen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LöschenToolStripMenuItem.Click
        Dim sDokName As String = InputOrdner
        If (lvDoc.SelectedItems.Count = 0) Then Exit Sub
        sDokName += lvDoc.SelectedItems(0).Text()
        Try
            MsgBox(sDokName & " löschen?")
            Kill(sDokName)
            LoadLvDok()
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & sDokName)
        End Try
    End Sub


    ''' <summary>
    ''' Autozurodung durchführen
    ''' Halbautomatische Zuordnung entsprechen der Inhalte von "Vorlagen"
    ''' </summary>
    ''' <param name="sString"></param>
    Private Sub AutoZuordnung(ByVal sString As String)
        Dim sWort As String
        Dim sID As String
        'Zuordnung aus Settings:
        cbEmpfaenger.SelectedValue = CInt(StEmpfaenger)
        cbMandant.SelectedValue = CInt(StartMandant)


        Dim vorlage = From p In _FreeDMS_StartDBDataSet.Vorlagen
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

                    'Dim vorlagenRow As _FreeDMS_StartDBDataSet.VorlagenRow
                    'vorlagenRow = _FreeDMS_StartDBDataSet.Vorlagen.FindByid(dummy)

                    If (el.Mandant > 0) Then
                        cbMandant.SelectedValue = CInt(el.Mandant)
                        MandantTextBox.Text = el.Mandant
                        cbMandant.BackColor = Color.GreenYellow
                    End If
                    If (el.akte > 0) Then
                        cbAkteNeu.SelectedValue = CInt(el.akte)
                        AkteTextBox.Text = el.akte
                        cbAkteNeu.BackColor = Color.GreenYellow
                    End If
                    If (el.vorgang > 0) Then
                        cbVorgang.SelectedValue = CInt(el.vorgang)
                        VorgangTextBox.Text = el.vorgang
                        cbVorgang.BackColor = Color.GreenYellow
                    End If
                    If (el.autor > 0) Then
                        ComboBoxNamen.SelectedValue = CInt(el.autor)
                        AbsenderTextBox.Text = el.autor
                        ComboBoxNamen.BackColor = Color.GreenYellow
                    End If
                    If (el.ablage > 0) Then
                        cbAblage.SelectedValue = CInt(el.ablage)
                        AblageTextBox.Text = el.ablage
                        cbAblage.BackColor = Color.GreenYellow
                    End If
                End If
            Next
        Next
    End Sub


End Class