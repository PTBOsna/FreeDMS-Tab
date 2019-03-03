Option Strict On
Imports Saraff.Twain
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Imports System.IO
Imports System.Text
Imports outlook = Microsoft.Office.Interop.Outlook
Imports OpenPop.Mime
Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.parser
Imports System.ComponentModel
Public Class ScanToDoc2
    Friend WithEvents _twain32 As New Twain32
    'Variablen für den Data-Teil
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
    ''Dim DokList As New Dictionary(Of String, List(Of DocumentData))
    'Dim currDokName As String = "" 'ehemals ttxt. Enthält ScanInput-Pfad und File-Name
    Dim mehrfachFlag As Boolean = False
    Dim speicherFlag As Boolean = False
    Dim newFile As String
    Dim anzahlDS As Integer = 0
    Dim FileContent As String
    Dim lastDocName As String
    Dim imList As New List(Of Bitmap)
    Dim imgCounter As Integer = 0
    Dim tempText As String
    Dim flagOCR As Boolean = False

    Private Sub ScanToDoc2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim i As Integer = 0
        'selDB für Vorlagen erforderlich, da Funktion  "Dim vorlagen = From p In _FreeDMS_StartDBDataSet.Vorlagen" sonst nicht funktioniert!
        Dim selDB = New FreeDMS_Aux.FreeDMS.DbHandling
        selDB.LoadDB(CurrDB)
        VorlagenTableAdapter.Connection = selDB.con
        VorlagenTableAdapter.Fill(_FreeDMS_StartDBDataSet.Vorlagen)

        PnlDaten.Visible = False
        Panel2.Visible = False
        Panel2.Dock = DockStyle.Fill

        Panel3.Visible = False

        BtPDF.Enabled = False
        BtPDF_OCR.Enabled = False
        lbCountPages.Visible = False
        DokumenteBindingSource.Filter = "id=0"

        'AnschriftenBindingSource1.Filter = "id=0"

        Try
            _twain32.OpenDSM()
            'Fill list of data sorces
            Me.dataSourcesToolStripComboBox.Items.Clear()
            For i = 0 To Me._twain32.SourcesCount - 1 Step 1
                Me.dataSourcesToolStripComboBox.Items.Add(Me._twain32.GetSourceProductName(i))
            Next
            If Me._twain32.SourcesCount > 0 Then
                Me.dataSourcesToolStripComboBox.SelectedIndex = Me._twain32.SourceIndex
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
#Region "Scannen"
    'Scan-Dialog aufrufen
    ''' <summary>
    ''' Scan-Dialog aufrufen
    ''' Dokument wenn vorhanden um Zähler erhöhen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btScan.Click
        BtPDF.Enabled = False
        BtPDF_OCR.Enabled = False
        Panel2.Visible = False

        RichTextBox1.Clear()
        If Not Me.PictureBox1.Image Is Nothing Then
            Me.PictureBox1.Image.Dispose()
            Me.PictureBox1.Image = Nothing
        End If
        imList.Clear()

        GetFiles()
    End Sub
    ''' <summary>
    ''' Twain Aufruf
    ''' </summary>
    Private Sub GetFiles()
        Try
            Me._twain32.Acquire()
        Catch ex As Exception
            MessageBox.Show(ex.Message, ex.GetType().Name, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub
    ''' <summary>
    ''' Scann beendet
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AcquireCompletedEventHandler(ByVal sender As Object, ByVal e As EventArgs) Handles _twain32.AcquireCompleted
        'Abfrage, ob weiter/Rückseite oder Scan beendet
        Dim oa As String = _twain32.ImageCount.ToString
        Dim f As New ScanErgebnis(oa)
        Dim i As Integer = 0

        'Zunächst ImageList mit erstrem Erbegnis des Scanns füllen
        'If flagScanPlus = False Then

        If (_twain32.ImageCount > 0) Then
            Do While (i <= (_twain32.ImageCount - 1))
                Dim bmp As New Bitmap(_twain32.GetImage(i))
                imList.Add(bmp)
                i += 1
            Loop
        End If

        f.ShowDialog()
        'ggf. weitere Seiten scannen
        If f.DialogResult = vbOK Then 'weitere Seiten
            GetFiles()
        End If
        _SetImage()
        'und jetzt neues Dokumente erstellen
        anzahlDS = FreeDMS_Aux.FreeDMS.Aux.MaxID(CurrDB)
        DokumenteBindingSource.AddNew()

    End Sub
    ''' <summary>
    ''' OCR durchführen 
    ''' </summary>
    Private Sub RunOCR()
        'Dim newFile As String = "H:\test\ScanToDoc.PDF"
        Dim ocrErgeb(2) As String
        'FreeDMS_Namespace.FreeDMS.Aux.ConvertImageToPdf(imList, FreeDMS_Namespace.FreeDMS.GrundDaten.ArchivOrdner & newFile)
        'Abfrege, ob OCR -> CreateOCR erwartet List of Bitmap als eingabe
        If flagOCR Then ocrErgeb = FreeDMS_Aux.FreeDMS.Aux.CreateOCR(imList)
        'OCR-Text
        tempText = ocrErgeb(0)
        'conf = ocrErgeb(1)
    End Sub
    ''' <summary>
    ''' Scann-Ergebmos anzeigen
    ''' Vorbereitung für weitere Verarbeitung
    ''' </summary>
    Private Sub _SetImage()
        Dim pages As Integer = imList.Count
        Panel2.Dock = DockStyle.Fill
        Panel2.Visible = True
        lbCountPages.ForeColor = Color.Black
        lbCountPages.Text = "Gescannt: " & pages & " Seite(n)"
        If imList.Count > 0 Then
            imgCounter = 0
            btBack.Enabled = False
            btFor.Enabled = True
            lbPage.Text = 1 & "/" & imList.Count.ToString
            Me.PictureBox1.Image = imList(0)
        Else
            If Not Me.PictureBox1.Image Is Nothing Then
                Me.PictureBox1.Image.Dispose()
            End If
            Me.PictureBox1.Image = imList(0)
        End If
        BtPDF.Enabled = True
        BtPDF_OCR.Enabled = True
        PnlDaten.Visible = True
        Cursor.Current = Cursors.Default
        ClearText()
    End Sub
    ''' <summary>
    ''' Form schließen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Clear()
        Me.Close()
    End Sub
    ''' <summary>
    ''' Form schließen per FormMenü (Kreuz)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ScanToDoc2_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Clear()
    End Sub
    ''' <summary>
    ''' Twain zurücksetzen
    ''' </summary>
    Private Sub Clear()
        _twain32.CloseDSM()
        _twain32.CloseDataSource()
        _twain32.Dispose()
    End Sub
    ''' <summary>
    ''' Navigation Vorschau, vor
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btFor_Click(sender As Object, e As EventArgs) Handles btFor.Click
        imgCounter += 1
        checkCounter(imgCounter)
    End Sub
    ''' <summary>
    ''' Navigation Vorschau zurück
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btBack_Click(sender As Object, e As EventArgs) Handles btBack.Click
        imgCounter -= 1
        checkCounter(imgCounter)
    End Sub
    ''' <summary>
    ''' Zähler für Navigation setzen
    ''' </summary>
    ''' <param name="i"></param>
    Private Sub checkCounter(ByVal i As Integer)
        Select Case i
            Case = imList.Count
                btFor.Enabled = False
                btBack.Enabled = True
            Case = 1
                btFor.Enabled = True
                btBack.Enabled = False
            Case Else
                btBack.Enabled = True
                btFor.Enabled = True
        End Select
        lbPage.Text = i.ToString & "/" & imList.Count.ToString
        Me.PictureBox1.Image = imList(i - 1)
    End Sub
    ''' <summary>
    ''' Aufruf für OCR-Durchführung
    ''' Start mit Backgroundworker
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtPDF_OCR_Click(sender As Object, e As EventArgs) Handles BtPDF_OCR.Click
        flagOCR = True
        ' PnlDaten.Visible = True
        Panel3.Visible = True
        BtPDF.Enabled = False
        BackgroundWorker1.RunWorkerAsync()
        'CreateDoc()

        ' btSave.Visible = True
    End Sub
    ''' <summary>
    ''' Start PDF ohne Texterkennung übernehmen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtPDF_Click(sender As Object, e As EventArgs) Handles BtPDF.Click

        'If flagOCR Then FileInhalt()
        flagOCR = False
        'PnlDaten.Visible = True
        SaveDoc()
    End Sub
    ''' <summary>
    ''' Backgroundworker start OCR 
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Call RunOCR()
    End Sub
    ''' <summary>
    ''' Backgroundworker beendet
    ''' Anzeige der Ergebnisse
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        Panel3.Visible = False
        BtPDF.Enabled = True
        RichTextBox1.Text = tempText

        FileInhalt()
        TabControl1.SelectedTab = TabPage2
    End Sub
#End Region
#Region "Datensatz füllen"

    ''' <summary>
    ''' Vorbereitung Datensatz aufnehmen
    ''' </summary>
    Private Sub FileInhalt()

        'Vorbereitung
        speicherFlag = False
        mehrfachFlag = False
        btWeiterZuordnung.Enabled = False
        lbSpeichstatus.Text = "Noch nicht gespeichert!"
        lbSpeichstatus.ForeColor = Color.Red

        FdAufgenommenTextBox.Text = Now.ToString

        AutoZuordnung(tempText)

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
        EmpfaengerTextBox.Text = StEmpfaenger.ToString
        cbMandant.SelectedValue = CInt(StartMandant)
        MandantTextBox.Text = StartMandant.ToString
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

                    'Dim vorlagenRow As FreeDMS_DB_testDataSet.VorlagenRow
                    'vorlagenRow = FreeDMS_DB_testDataSet.Vorlagen.FindByid(dummy)

                    If Not IsDBNull(el.Mandant) Then
                        cbMandant.SelectedValue = CInt(el.Mandant)
                        ' txtMandant.Text = CStr(vorlagenRow.Mandant)
                        cbMandant.BackColor = Color.GreenYellow
                    End If
                    If Not IsDBNull(el.akte) Then
                        cbAkteNeu.SelectedValue = CInt(el.akte)
                        'txtAkte.Text = CStr(vorlagenRow.akte)
                        cbAkteNeu.BackColor = Color.GreenYellow
                    End If
                    If Not IsDBNull(el.vorgang) Then
                        cbVorgang.SelectedValue = CInt(el.vorgang)
                        'txtVorgang.Text = CStr(vorlagenRow.vorgang)
                        cbVorgang.BackColor = Color.GreenYellow
                    End If
                    If Not IsDBNull(el.autor) Then
                        ComboBoxNamen.SelectedValue = CInt(el.autor)
                        'txtAutorID.Text = CStr(vorlagenRow.autor)
                        'txtAutorID.BackColor = Color.GreenYellow
                    End If
                    If Not IsDBNull(el.ablage) Then
                        cbAblage.SelectedValue = CInt(el.ablage)
                        'txtFundstelle.Text = CStr(vorlagenRow.ablage)
                        cbAblage.BackColor = Color.GreenYellow
                    End If
                End If
            Next
        Next
    End Sub
    ''' <summary>
    ''' Felder leeren und voreinstellen
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
    ''' <summary>
    ''' Feld Mandant aus Cobmbobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbMandant_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbMandant.SelectedIndexChanged
        If cbMandant.SelectedIndex >= 0 Then
            AktenBindingSource.Filter = "Mandant=" & cbMandant.SelectedValue.ToString
            MandantTextBox.Text = cbMandant.SelectedValue.ToString
        End If
    End Sub
    ''' <summary>
    ''' Feld Akte aus ComboBox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbAkteNeu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAkteNeu.SelectedIndexChanged
        If cbAkteNeu.SelectedIndex >= 0 Then
            VorgaengeBindingSource.Filter = "Akte=" & cbAkteNeu.SelectedValue.ToString
            'VorgaengeBindingSource.Filter = "Akte=" & cbAkteNeu.SelectedValue.ToString
            AkteTextBox.Text = cbAkteNeu.SelectedValue.ToString
        End If
    End Sub
    ''' <summary>
    ''' Feld Vorgang aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbVorgang_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbVorgang.SelectedIndexChanged
        If cbVorgang.SelectedIndex >= 0 Then
            VorgangTextBox.Text = cbVorgang.SelectedValue.ToString
        End If
    End Sub
    ''' <summary>
    ''' Feld Ablage aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbAblage_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAblage.SelectedIndexChanged
        If cbAblage.SelectedIndex >= 0 Then
            AblageTextBox.Text = cbAblage.SelectedValue.ToString
        End If

    End Sub
    ''' <summary>
    ''' Feld Typ aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbTyp_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTyp.SelectedIndexChanged
        If cbTyp.SelectedIndex >= 0 Then
            TypTextBox.Text = cbTyp.SelectedValue.ToString
        End If

    End Sub
    ''' <summary>
    ''' Feld Status aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbStatus_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbStatus.SelectedIndexChanged
        If cbStatus.SelectedIndex >= 0 Then
            StatusTextBox.Text = cbStatus.SelectedValue.ToString
        End If
    End Sub
    ''' <summary>
    ''' Feld Absender aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ComboBoxNamen_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxNamen.SelectedIndexChanged
        If ComboBoxNamen.SelectedIndex >= 0 Then
            AbsenderTextBox.Text = ComboBoxNamen.SelectedValue.ToString
        End If
    End Sub
    ''' <summary>
    ''' Feld Empfänger aus Combobox füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbEmpfaenger_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbEmpfaenger.SelectedIndexChanged
        If cbEmpfaenger.SelectedIndex >= 0 Then
            EmpfaengerTextBox.Text = cbEmpfaenger.SelectedValue.ToString
        End If
    End Sub
    ''' <summary>
    ''' Speichern mit vorheriger Abfrage ob relevante Felder gefüllt sind
    ''' </summary>
    Private Sub SaveDoc()

        Dim tempName As String = Nothing
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
        If String.IsNullOrEmpty(InhaltOCRTextBox.Text) Then
            If MsgBox("OCR-Text wurde nicht übernommen, OK?", vbYesNo) = DialogResult.No Then Exit Sub
        End If
        If String.IsNullOrEmpty(FdAufgenommenTextBox.Text) Then
            FdAufgenommenTextBox.Text = Now.ToString
        End If
        If mehrfachFlag = False Then
            'RenameDokFile(currDokName)
            newFile = CStr(cbMandant.SelectedValue) & "-" & CStr(cbAkteNeu.SelectedValue) & "-" & CStr(cbVorgang.SelectedValue) & "#" & anzahlDS & ".PDF"
            DokNameTextBox.Text = newFile
            'pdf erstellen
            FreeDMS_Aux.FreeDMS.Aux.ConvertImageToPdf(imList, FreeDMS_Aux.FreeDMS.GrundDaten.ArchivOrdner & newFile)
            'If File.Exists(inputOrdner & System.IO.Path.GetFileNameWithoutExtension(tempName) & ".ocr") Then
            '    Kill(inputOrdner & System.IO.Path.GetFileNameWithoutExtension(tempName) & ".ocr")
            'End If
        End If
        FillDokInhalt()
        With Start.currDoc
            .Mandant = CInt(MandantTextBox.Text)
            .Akte = CInt(AkteTextBox.Text)
            .Vorgang = CInt(VorgangTextBox.Text)
            .Dokument = anzahlDS + 1
        End With
        Validate()
        DokumenteBindingSource.EndEdit()
        DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)
        btWeiterZuordnung.Enabled = True
        BtPDF.Enabled = False
        lbSpeichstatus.Text = "Datensatz gespeichert!"
        lbSpeichstatus.ForeColor = Color.Green
        speicherFlag = True
    End Sub

    ''' <summary>
    ''' Klasse DokumentData füllen
    ''' Ist für ggf. weitere Zuordnung  erforderlich
    ''' </summary>
    Private Sub FillDokInhalt()
        If String.IsNullOrEmpty(BetragTextBox.Text) Then BetragTextBox.Text = "0"
        DokInhalt.Add(New DocumentData With
                      {.docID = anzahlDS + 1,
                        .mandant = CInt(cbMandant.SelectedValue),
                        .akte = CInt(cbAkteNeu.SelectedValue),
                        .vorgang = CInt(cbVorgang.SelectedValue),
                        .dokument = DokumentTextBox.Text,
                        .betreff = BetreffTextBox.Text,
                        .betrag = CDec(BetragTextBox.Text),
                        .anlagen = AnlagenTextBox.Text,
                        .absender = CInt(ComboBoxNamen.SelectedValue),
                        .empfaenger = CInt(cbEmpfaenger.SelectedValue),
                        .dokDatum = CDate(DokDatumTextBox.Text),
                        .aufgenommen = CDate(FdAufgenommenTextBox.Text),
                        .kommentar = KommentarTextBox.Text,
                        .inhalt = RichTextBox1.Text,
                        .ablage = CInt(cbAblage.SelectedValue),
                        .typ = CInt(cbTyp.SelectedValue),
                        .status = CInt(cbStatus.SelectedValue),
                        .dokName = DokNameTextBox.Text,
                        .istanlage = CBool(IstAnlageCheckBox.CheckState),
                        .anlagenid = AnlagenIDTextBox.Text,
                        .bearbeit = FdBearbeitungsVermerkTextBox.Text})
    End Sub
    ''' <summary>
    ''' Weitere Zuordnung ausläsen
    ''' Datem werdem in einem weiteren Datensatz gespeichert,
    ''' das Dokument mit DokName bleibt gleich
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btWeiterZuordnung_Click(sender As Object, e As EventArgs) Handles btWeiterZuordnung.Click
        mehrfachFlag = True
        Dim splitDocName() As String
        DokumenteBindingSource.AddNew()
        For Each el In DokInhalt
            If el.docID.ToString.Contains(CStr(anzahlDS + 1)) Then
                With el
                    'da Checkboxen nicht geändert wurden, kein ChangeIndex-Ereignis -> TextBoxen müssen geladen werden
                    cbMandant.SelectedValue = .mandant
                    MandantTextBox.Text = .mandant.ToString
                    cbAkteNeu.SelectedValue = .akte
                    AkteTextBox.Text = .akte.ToString
                    cbVorgang.SelectedValue = .vorgang
                    VorgangTextBox.Text = .vorgang.ToString
                    DokumentTextBox.Text = .dokument
                    BetreffTextBox.Text = .betreff
                    BetragTextBox.Text = .betrag.ToString
                    AnlagenTextBox.Text = .anlagen
                    ComboBoxNamen.SelectedValue = .absender '
                    AbsenderTextBox.Text = Str(.absender)
                    cbEmpfaenger.SelectedValue = .empfaenger
                    EmpfaengerTextBox.Text = .empfaenger.ToString
                    DokDatumTextBox.Text = .dokDatum.ToString
                    FdAufgenommenTextBox.Text = .aufgenommen.ToString
                    KommentarTextBox.Text = .kommentar
                    InhaltOCRTextBox.Text = .inhalt
                    cbAblage.SelectedValue = .ablage '
                    AblageTextBox.Text = Str(.ablage)
                    cbTyp.SelectedValue = .typ '
                    TypTextBox.Text = Str(.typ)
                    cbStatus.SelectedValue = .status '
                    StatusTextBox.Text = Str(.status)
                    DokNameTextBox.Text = .dokName
                    splitDocName = Split(.dokName, "#")
                    If .istanlage Then IstAnlageCheckBox.CheckState = CheckState.Checked
                    AnlagenIDTextBox.Text = .anlagenid

                    If String.IsNullOrEmpty(el.bearbeit) Then
                        FdBearbeitungsVermerkTextBox.Text = " Siehe auch Az: " & splitDocName(0) & "/" & splitDocName(1)
                    Else
                        FdBearbeitungsVermerkTextBox.Text = el.bearbeit & vbCrLf & " Siehe auch Az: " & splitDocName(0) & "/" & splitDocName(1)
                    End If

                End With
            End If
        Next
        BtPDF.Enabled = True
        btWeiterZuordnung.Enabled = False
        'If MsgBox("Weitere Zuordnung ok?", vbYesNo) = MsgBoxResult.No Then Exit Sub
        'SaveDoc()
    End Sub

    ''' <summary>
    ''' Fehleranzeige von SaveDoc
    ''' </summary>
    ''' <param name="field"></param>
    Private Sub MsgFilledField(ByVal field As String)
        MsgBox("Feld " & field & " darf nicht leer sein!", vbCritical)
        ' btSave.Enabled = True
        btWeiterZuordnung.Visible = True
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        InhaltOCRTextBox.Text = RichTextBox1.Text
    End Sub

#End Region
End Class