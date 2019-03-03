
Option Strict On
Imports System.IO
Imports System.ComponentModel
Imports FreeDMS_Aux.FreeDMS.GrundDaten

Class ImageToPDF
    Dim FileList As New List(Of String)
    Dim newNameList As New List(Of NewContent)
    Dim imgList As New List(Of Bitmap)
    Dim textList As New List(Of String)
    Dim tempTxt As String
    'Dim viewTxt As String
    Dim doOCR As Boolean = False
    Dim QuelleLoeschen As Boolean = False
    Dim myFileName As String
    'Dim dataPath As String = FreeDMS_Aux.FreeDMS.GrundDaten.sAppPath & "tessdata" '  "D:\Users\peter\Documents\Visual Studio 2017\Projekte\Scanner
    Class NewContent
        Public oldDokName As String
        Public newDokName As String
        Public newOCR As String
        Public confidence As Single
    End Class
    Sub New(openArgs As String)
        InitializeComponent()
        myFileName = openArgs
    End Sub
    ''' <summary>
    ''' Form starten, 
    ''' ListView füllen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim selDB = New FreeDMS_Aux.FreeDMS.DbHandling
        selDB.LoadDB(CurrDB)
        DokumenteTableAdapter.Connection = selDB.con
        DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)

        If myFileName = "#" Then
            Panel4.Visible = True
        Else
            Panel4.Visible = False
            ListBox1.Items.Add(myFileName)
            FileList.Add(myFileName)
        End If
        DokumenteBindingSource.Filter = "id=0"
        Panel2.Visible = False
        RichTextBox1.Visible = False
        PictureBox1.Visible = False
        PictureBox1.Dock = DockStyle.Fill

    End Sub
    ''' <summary>
    ''' FileDialog zur Dateiauswahl
    ''' Enthält Filter und das StartDir wird übergeben.
    ''' Ergebnis ist eine Liste von Files (FileList) zur weiteren Verarbeitung
    ''' </summary>
    ''' <param name="initDir"></param>
    Private Sub LoadFileDiolog(ByRef initDir As String)
        ListBox1.Items.Clear()
        FileList.Clear()
        newNameList.Clear()
        RichTextBox1.Clear()
        RichTextBox1.Dock = DockStyle.Fill
        tempTxt = Nothing
        With OpenFileDialog1
            .InitialDirectory = initDir
            .Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;*.TIF)|*.BMP;*.JPG;*.GIF;*.PNG;*.TIF|All files (*.*)|*.*"
            .FileName = Nothing
            .Multiselect = True
        End With
        If OpenFileDialog1.ShowDialog() = vbOK Then
            For Each el In OpenFileDialog1.FileNames
                FileList.Add(el)
                ListBox1.Items.Add(el)

            Next
        End If
        'For Each fl In FileList
        '    MsgBox(fl)
        'Next
    End Sub
    ''' <summary>
    ''' Auswahl Erzeugung PDF mit Texterkennung
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtPDF_OCR.Click
        textList.Clear()
        ShowMsg()
        doOCR = True
        BackgroundWorker1.RunWorkerAsync()
    End Sub
    ''' <summary>
    ''' Start des Backgroundworkers
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BackgroundWorker1_DoWork(sender As Object, e As DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Call DoImageToFile()
    End Sub
    ''' <summary>
    ''' Backgroundworker Änderungen (Meldung, das gearbeitet wird)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        lblWork.Text = "Verarbeitet wird Datei " & CInt(FileList.Count * e.ProgressPercentage / 100).ToString & " von " & FileList.Count.ToString
        ProgressBar2.Value = e.ProgressPercentage
    End Sub
    ''' <summary>
    ''' Backgroundworker beendet
    ''' Ergebnisse werden angezeigt
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        HideMsg()
        PictureBox1.Visible = False
        RichTextBox1.Visible = True
        RichTextBox1.Dock = DockStyle.Fill
        If doOCR Then
            For Each file In newNameList
                LbErgeb.Items.Add(file.newDokName & " - " & CStr(file.confidence * 100) & " % - " & file.newOCR.Substring(0, 50) & "...")
                'letztes OCR-Ergebnis anzeigen
                RichTextBox1.Text = textList(0)
            Next
        Else
            For Each file In newNameList
                LbErgeb.Items.Add(file.oldDokName & " -> " & file.newDokName)
            Next
        End If


    End Sub
    ''' <summary>
    ''' In Arbeit-Anzeige des Backgroundworkers
    ''' </summary>
    Private Sub ShowMsg()
        Panel2.Visible = True
    End Sub
    ''' <summary>
    ''' Arbeit beendet Anzeige des Beckgroundworkers
    ''' </summary>
    Private Sub HideMsg()
        Panel2.Visible = False
        'RichTextBox1.Text = tempTxt
    End Sub
    ''' <summary>
    ''' Aufruf ConvertImageToPDF und CrateOCR aus Klasse FreeDMS_Aux AUX
    ''' Input ist die FileList
    ''' Ergebnisdarstellung im Form
    ''' </summary>
    Private Sub DoImageToFile()
        Dim conf As String = Nothing 'Qualität der Texterkennung aus GetMeanConfidenz
        Dim ocrErgeb(2) As String
        Dim i As Integer = 1
        Dim tmpImg As Bitmap
        tempTxt = Nothing
        'doc's als Bitmap in Liste speichern
        'Standard ist ein Image in der ImgList, nur bei Multipage-Image entsprechend mehr
        For Each file In FileList

            Dim perc As Double = (100 / FileList.Count) * i
            BackgroundWorker1.ReportProgress(CInt(perc))
            'Prüfen, ob in DB vorhanden
            DokumenteBindingSource.Filter = "DokName like '" & Path.GetFileName(file) & "'"
            If DokumenteBindingSource.Count = 0 Then
                If MsgBox(Path.GetFileName(file) & " ist nicht in der FreeDMS-Ex Datenbank enthalten!" & vbCrLf & "Weiter (ja) oder überspringen (nein)?", vbYesNo) = vbNo Then
                    GoTo Label
                End If
            End If
            'und testen, ob Multipage-Image
            'später einfügen!
            tmpImg = CType(Image.FromFile(file, True), Bitmap)
            If tmpImg.GetFrameCount(Imaging.FrameDimension.Page) > 1 Then
                ' Image-Zerlegung aufrufen
                'eine weitere imgList für multipage-Images erstellen
                'MultipageImgList.add()
            End If
            imgList.Add(tmpImg)
            'PDF erzeugen	
            'ConvertImageToPdf erwartet ImgList als Eingabe
            FreeDMS_Aux.FreeDMS.Aux.ConvertImageToPdf(imgList, FreeDMS_Aux.FreeDMS.GrundDaten.ArchivOrdner & Path.GetFileNameWithoutExtension(file) & ".PDF")
            'Abfrege, ob OCR -> CreateOCR erwartet List of Bitmap als eingabe
            If doOCR Then ocrErgeb = FreeDMS_Aux.FreeDMS.Aux.CreateOCR(imgList)
            'OCR-Text
            tempTxt = ocrErgeb(0)
            'Confidence
            conf = ocrErgeb(1)
            textList.Add(tempTxt)
            ChangeDokument(Path.GetFileName(file), tempTxt, CSng(conf))

Label:
            i = i + 1
            'imgList zurücksetzen, da sonst die Images pro File addiert werden! Eregbnis: PDF enthält die Seiten aller ausgewählter Files!
            imgList.Clear()
            'RichTextBox1.Text = tempTxt
            tempTxt = Nothing
        Next

        ' doOCR = False
    End Sub

    ''' <summary>
    ''' Aufruf FileDialog mit Dir-Vorwahl Archiv
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtArchiv_Click(sender As Object, e As EventArgs) Handles BtArchiv.Click
        LoadFileDiolog(FreeDMS_Aux.FreeDMS.GrundDaten.ArchivOrdner)
        PictureBox1.Image = Nothing
        imgList.Clear()
        LbErgeb.Items.Clear()
    End Sub
    ''' <summary>
    ''' Aufruf FileDialog mit Dir-Vorwahl Dokumenten-Ordner
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtAlles_Click(sender As Object, e As EventArgs) Handles BtAlles.Click
        LoadFileDiolog(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments))
        PictureBox1.Image = Nothing
        LbErgeb.Items.Clear()
    End Sub
    ''' <summary>
    ''' Listbox zur Prüfung, ob ausgewählte Dateien ok sind
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        RichTextBox1.Visible = False
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Visible = True
        ' MessageBox.Show(ListBox1.SelectedItem.ToString)
        'Image als Stream laden, damit es für weitere Verarbeitung (löschen) freigegeben wird
        Try
            Dim oStream As New System.IO.FileStream(ListBox1.SelectedItem.ToString, IO.FileMode.Open)
            PictureBox1.Image = New Bitmap(oStream)
            oStream.Close()
        Catch ex As Exception
            MsgBox("Ungültiges Dateiformat!" & vbCrLf & ex.Message)
            Exit Sub
        End Try

        ' PictureBox1.Load(ListBox1.SelectedItem.ToString)
        ' MsgBox(Path.GetFileName(ListBox1.SelectedItem.ToString))
        'MsgBox(Path.GetFileName(ListBox1.SelectedItem.ToString))
        DokumenteBindingSource.Filter = "DokName='" & Path.GetFileName(ListBox1.SelectedItem.ToString) & "'"
        If DokumenteBindingSource.Count = 0 Then
            If MessageBox.Show("Kein zugehöriges Dokument in FreeDMS-Ex gefunden!" & vbCrLf & "Datei löschen?", "FreeDMS - Dateifehler!", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Try
                    Kill(ListBox1.SelectedItem.ToString)
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try

            End If
        End If
    End Sub
    ''' <summary>
    ''' Aufruf Dokument nach PDF ohne Texterkennung (OCR)
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtToPDF_Click(sender As Object, e As EventArgs) Handles BtToPDF.Click
        doOCR = False
        ShowMsg()
        ' RichTextBox1.Clear()
        BackgroundWorker1.RunWorkerAsync()

    End Sub
    ''' <summary>
    ''' Änderungen (OCR-Text und neuer DokName) in DokumentBindingSource einfügen
    ''' und  Liste newNameList füllen
    ''' </summary>
    ''' <param name="DokName"></param>
    ''' <param name="ocr"></param>
    ''' <param name="conf"></param>
    Private Sub ChangeDokument(ByVal DokName As String, ocr As String, conf As Single)
        DokumenteBindingSource.Filter = "DokName like '" & Path.GetFileName(DokName) & "'"
        If DokumenteBindingSource.Count = 0 Then
            Exit Sub
        End If
        Dim rwDok = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
        Dim nDokName As String = Path.GetFileNameWithoutExtension(DokName) & ".PDF"
        rwDok.DokName = nDokName
        rwDok.InhaltOCR = ocr
        rwDok.Geaendert = Now
        Dim tempCount As New NewContent
        With tempCount
            .oldDokName = DokName
            .newDokName = nDokName
            .newOCR = ocr
            .confidence = conf
        End With
        rwDok.BearbVermerk = "Mittlere Genauigkeit (Confidence) der Texterkennung ist " & CStr(conf * 100) & " %"
        newNameList.Add(tempCount)
    End Sub
    ''' <summary>
    ''' Zurück ohne speichern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles BtCancel.Click
        If MsgBox("Zurück ohne Speichern?") = vbOK Then
            Close()
        Else
            Exit Sub
        End If
    End Sub
    ''' <summary>
    ''' Zurück und speichern der Änderungen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        Validate()
        DokumenteBindingSource.EndEdit()
        DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)
        MsgBox("Dokument(e) wurde(n) in das PDF-Format konvertiert." & vbCrLf & "Änderungen werden nach Aktualisierung wirksam.")
        Close()
    End Sub
    ''' <summary>
    ''' Abfrage, ob die Quelldatei nach Umwandlung in PDF gelöscht werden soll
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.CheckState = CheckState.Checked Then
            QuelleLoeschen = True
        Else
            QuelleLoeschen = False
        End If
    End Sub

    Private Sub LbErgeb_SelectedIndexChanged(sender As Object, e As EventArgs) Handles LbErgeb.SelectedIndexChanged
        RichTextBox1.Text = textList(LbErgeb.SelectedIndex)
    End Sub
End Class