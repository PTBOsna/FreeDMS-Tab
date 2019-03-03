Option Strict On
Imports Microsoft.Win32
Imports System.ComponentModel
Imports System.IO
Imports System.Data.OleDb
Imports System.Configuration
Imports Tesseract
Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.Drawing.Imaging
'Imports iTextSharp.text.pdf

Namespace FreeDMS
    ''' <summary>
    ''' Übergreifende Variablen
    ''' </summary>
    Public Class GrundDaten
        'DB-Standort
        Public Shared CurrDB As String
        'Public Shared currDB As String 'Name ohne Endungen und Pfad
        Public Shared sAppPath As String = System.AppDomain.CurrentDomain.BaseDirectory & "Daten\"
        'Verwaltungsordner
        Public Shared ArchivOrdner As String
        Public Shared InputOrdner As String
        Public Shared MailInputOrdner As String
        Public Shared FlagArchivOrdner As Boolean
        Public Shared FlagInputOrdner As Boolean
        Public Shared SettingOutlookArchiv As String
        Public Shared FlagMailInputOrdner As Boolean
        Public Shared tempPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\"
        'Settings
        Public Shared StartMandant As String
        Public Shared FlagStartMandant As Boolean
        Public Shared FlagAppPath As Boolean
        Public Shared StEmpfaenger As String
        Public Shared FlagStEmpfaenger As Boolean

        Public Shared FlagOutlook As Boolean = False
        ' Public Shared PdfToText As String = "" ' PdfToText
        ' Public Shared FlagPdfToText As Boolean = False
        'Public Shared StartMailAccount As Integer

        Public Shared mailAbrufStart As Boolean = False
        Dim OutlookNutzen As String = "nein"
        Dim MailAbruf As String = "nein"
        'Hilfsvariablen
        Public Shared tempDokName As New List(Of String) 'Wegen Problemen im Form ScanInput beim löschen von Files die noch aktiv sind
        Public Const sHTML As String = "<style>h2 {margin-top:15%;text-align:center;	color:gray;}img {display:block;	margin-left:auto;	margin-right:auto;	}body {    background-color: lightblue;}</style><h2>FreeDMS - Das freie Dokumenten-Management-System</h1>"
        'Public Shared currDB As String

        'Public gd As GrundDaten
        ''' <summary>
        ''' Datembank.xml-Wreiter
        ''' Schreibt datenbankrelevante Parameter in dbName.xml
        ''' </summary>
        Public Sub XMLWriter()
            'Dim gd As GrundDaten
            ' Auswahl einer Kodierungsart für die Zeichenablage 
            Dim enc As New System.Text.UTF8Encoding
            Dim myDB As String = Path.GetFileNameWithoutExtension(CurrDB)
            ' XmlTextWriter-Objekt für unsere Ausgabedatei erzeugen: 
            Dim XMLobj As System.Xml.XmlTextWriter _
              = New System.Xml.XmlTextWriter(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\" & myDB & ".xml", enc)

            With XMLobj
                If mailAbrufStart = True Then MailAbruf = "ja" Else MailAbruf = "nein"
                If FlagOutlook = True Then OutlookNutzen = "ja" Else OutlookNutzen = "nein"
                ' Formatierung: 4er-Einzüge verwenden 
                .Formatting = System.Xml.Formatting.Indented
                .Indentation = 4

                ' Dann fangen wir mal an: 
                .WriteStartDocument()

                ' Beginn eines Elements "Personen". Darin werden wir mehrere 
                ' Elemente "Person" unterbringen. 
                .WriteStartElement("settings")

                .WriteStartElement("setting") ' <Person 
                .WriteAttributeString("ArchivOrdner", ArchivOrdner)
                .WriteAttributeString("ScanInputOrdner", InputOrdner)
                .WriteAttributeString("OutlookNutzen", OutlookNutzen)
                .WriteAttributeString("OutlookPost", MailInputOrdner)
                .WriteAttributeString("OutlookArchiv", SettingOutlookArchiv)
                .WriteAttributeString("Mandant", StartMandant)
                .WriteAttributeString("Empfaenger", StEmpfaenger)
                .WriteAttributeString("OpenMailStart", MailAbruf)
                ' .WriteAttributeString("pdfToText", PdfToText)

                .WriteEndElement() ' Person /> 


                .WriteEndElement() ' </Personen> 

                ' ... und schließen das XML-Dokument (und die Datei) 
                .Close() ' Document 

            End With

        End Sub
        ''' <summary>
        ''' List die mit xmlWriter geschriebenen Daten aus und überträgt sie ggf. in die Settings
        ''' </summary>
        Public Sub XMLReader()
            Dim myPath As String = System.AppDomain.CurrentDomain.BaseDirectory 'Path.GetDirectoryName(CurrDB) & "\" 'CurrDB ist Pfad einschließlich '\Daten\
            Dim MyDB As String = Path.GetFileNameWithoutExtension(CurrDB)
            'MsgBox(MyDB & vbCrLf & CurrDB & vbCrLf & Path.GetDirectoryName(CurrDB))
            'prüfen, ob im Ordner der Aktuellen DB (CurrDB) die xml-Datei vohanden ist, wenn nicht prüfen ob sie im Anwendungs-Verzeichnis ist. Sonst neu erstellen
            If Not File.Exists(myPath & MyDB & ".xml") Then

                If Not File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\" & MyDB & ".xml") Then
                    If MsgBox("Die Datei '" & MyDB & ".xml ist nicht vorhanden!" & vbCrLf & "Erstellen lassen (ok) oder zurück (cancel)?" & vbCrLf & "Wenn OK, bitte anschließend die Settings überprüfen!", vbOKCancel) = MsgBoxResult.Cancel Then
                        Exit Sub
                    Else
                        XMLWriter()
                    End If
                End If
                myPath = System.AppDomain.CurrentDomain.BaseDirectory & "Daten\"
            End If
            Dim XMLReader As System.Xml.XmlReader = New System.Xml.XmlTextReader(myPath & MyDB & ".xml")

            ' Es folgt das Auslesen der XML-Datei 
            With XMLReader

                Do While .Read ' Es sind noch Daten vorhanden 

                    ' Welche Art von Daten liegt an? 
                    Select Case .NodeType ' Ein Element 
                        Case System.Xml.XmlNodeType.Element
                            If .AttributeCount > 0 Then
                                ' Es sind noch weitere Attribute vorhanden 
                                While .MoveToNextAttribute ' nächstes 
                                    Select Case .Name
                                        Case "ArchivOrdner"
                                            ArchivOrdner = .Value

                                        Case "ScanInputOrdner"
                                            InputOrdner = .Value
                                        'Case "OCRProgramm"
                                        '    PdfToText = .Value
                                        Case "OutlookPost"
                                            MailInputOrdner = .Value
                                        Case "OutlookNutzen"
                                            OutlookNutzen = .Value
                                      '  MsgBox(.Value)
                                        Case "OutlookArchiv"
                                            SettingOutlookArchiv = .Value
                                        Case "Mandant"
                                            StartMandant = .Value
                                        Case "Empfaenger"
                                            StEmpfaenger = .Value
                                        Case "OpenMailStart"
                                            MailAbruf = .Value
                                    End Select

                                End While

                            End If

                    End Select

                Loop  ' Weiter nach Daten schauen 

                .Close()  ' XMLTextReader schließen 
                If MailAbruf = "ja" Then mailAbrufStart = True Else mailAbrufStart = False
                If OutlookNutzen = "ja" Then FlagOutlook = True Else FlagOutlook = False
                'MsgBox(ArchivOrdner & vbCrLf & PdfToText & vbCrLf & SettingOutlookArchiv & vbCrLf & MailInputOrdner & vbCrLf & currDB)
            End With
        End Sub
        ''' <summary>
        ''' Liest die FreeDMS.ini mit dem aktuellen DB-Namen
        ''' Wird in CurrDB gespeichert
        ''' </summary>
        Public Sub TxtReader()
            Dim objStreamReader As StreamReader
            Dim strLine As String
            Dim sText As String = ""
            'Dim zeile() As String
            'Dim gd As GrundDaten
            'Pass the file path and the file name to the StreamReader constructor.
            If File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\FreeDMS.ini") Then
                objStreamReader = New StreamReader(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\FreeDMS.ini")
                ' MsgBox(System.AppDomain.CurrentDomain.BaseDirectory & "FreeDMS.ini")
                'Read the first line of text.
                strLine = objStreamReader.ReadLine

                'Continue to read until you reach the end of the file.
                Do While Not strLine Is Nothing

                    'Write the line to the Console window.
                    'Console.WriteLine(strLine)
                    sText += strLine
                    'Read the next line.
                    strLine = objStreamReader.ReadLine

                Loop

                'Close the file.
                objStreamReader.Close()
                CurrDB = sText
                '  MsgBox(currDB)
            Else
                'Wenn ini nicht vorhanden, Programm abbrechen
                MsgBox("Die Datei FreeDMS.ini wurde nicht gefunden oder ist Fehlerhaft. Bitte prüfen")

                'Für ersten Aufruf, wenn noch keine currDB in der ini eingetragen wurde:
            End If
            If String.IsNullOrEmpty(sText) Then
                CurrDB = sAppPath & "FreeDMS-StartDB.mdb"

                Exit Sub
            End If

        End Sub
        ''' <summary>
        ''' Schreibt den aktuellen DB-Namen (CurrDB) in die FreeDMS.ini
        ''' </summary>
        Public Sub TxtWriter()
            ' Dim gd As GrundDaten
            Dim objStreamWriter As StreamWriter
            'Pass the file path and the file name to the StreamWriter constructor.
            objStreamWriter = New StreamWriter(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\FreeDMS.ini")

            'Write a line of text.
            objStreamWriter.WriteLine(CurrDB)

            'Write a second line of text.
            ' objStreamWriter.WriteLine("From the StreamWriter class")

            'Close the file.
            objStreamWriter.Close()

        End Sub
        ''' <summary>
        ''' Überprüfen der Settings und Eintrag in die entsprechenden globalen Variablen
        ''' </summary>
        Public Sub ChkSettings()

            If Not String.IsNullOrEmpty(MailInputOrdner) Then FlagMailInputOrdner = True
            If Not sAppPath.EndsWith("\") Then sAppPath = sAppPath & "\"
            If Not Directory.Exists(ArchivOrdner) Or Not Directory.Exists(InputOrdner) Then
                MsgBox("Die angegebenen Pfade existieren nicht." & vbCrLf & "Archiv und Inputordner werden zunächst unter '" & sAppPath & "ScanInput' und ...'Archiv\' eingerichtet." & vbCrLf & "Sie können diese unter 'SETTINGS' ändern.", vbSystemModal)
                Directory.CreateDirectory(sAppPath & "Archiv\")
                ArchivOrdner = sAppPath & "Archiv\"
                ArchivOrdner = ArchivOrdner
                Directory.CreateDirectory(sAppPath & "ScanInput\")
                InputOrdner = sAppPath & "ScanInput\"
                InputOrdner = InputOrdner
            ElseIf Not Directory.Exists(InputOrdner) Then
                MsgBox("Der angegebene Pfad existiert nicht." & vbCrLf & "Der  InputOrdner wird zunächst unter '" & sAppPath & "ScanInput' eingerichtet." & vbCrLf & "Sie können dies unter 'SETTINGS' ändern.")
                Directory.CreateDirectory(sAppPath & "ScanInput\")
                InputOrdner = sAppPath & "ScanInput\"
                InputOrdner = InputOrdner
            ElseIf Not Directory.Exists(ArchivOrdner) Then
                MsgBox("Der angegebene Pfad existiert nicht." & vbCrLf & "Der  ArchivOrdner wird zunächst unter '" & sAppPath & "Archiv' eingerichtet." & vbCrLf & "Sie können dies unter 'SETTINGS' ändern.")
                Directory.CreateDirectory(sAppPath & "Archiv\")
                ArchivOrdner = sAppPath & "Archiv\"
                ArchivOrdner = ArchivOrdner
            End If
            If Not ArchivOrdner.EndsWith("\") Then
                ArchivOrdner = ArchivOrdner & "\"
            End If
            If Not InputOrdner.EndsWith("\") Then
                InputOrdner = InputOrdner & "\"
            End If
            If String.IsNullOrEmpty(StEmpfaenger) Then
                StEmpfaenger = "0"
            End If
            If String.IsNullOrEmpty(StartMandant) Then
                StartMandant = "0"
            End If

            If MailAbruf.Contains("ja") Then mailAbrufStart = True
        End Sub
    End Class
    ''' <summary>
    ''' Hilfsfunktionen und -Sub's
    ''' </summary>
    Public Class Aux
        ' CheckForSoftwareInstallation()


        Public Function CheckForSoftwareInstallation(ByVal name As String) As Boolean
            '-- Get all software names installed by Windows Installer --
            Dim softwareList As List(Of String) = New List(Of String)
            Dim products As RegistryKey = Registry.LocalMachine.OpenSubKey("SOFTWARE\Classes\Installer\Products")
            For Each keyName As String In products.GetSubKeyNames
                For Each valueName As String In products.OpenSubKey(keyName).GetValueNames
                    If (valueName = "ProductName") Then
                        Dim entry As String = products.OpenSubKey(keyName).GetValue("ProductName").ToString
                        If (Not (entry) Is Nothing) Then
                            softwareList.Add(UCase(entry))
                        End If

                    End If

                Next
            Next
            'Dim ergeb As String = ""
            'For Each el In softwareList
            '    If el.Contains("Microsoft") Then ergeb = ergeb & el & vbCrLf
            'Next
            'MsgBox(ergeb)
            '-- check if searched software is included --
            Dim found As Boolean = False
            For Each sName As String In softwareList
                If sName.Contains(UCase(name)) Then
                    found = True
                End If

            Next
            Return found
        End Function
        Public Shared Function WriteToFile(ByVal Source As Byte(), ByVal Filename As String) As Boolean
            My.Computer.FileSystem.WriteAllBytes(Filename, Source, False)
            If System.IO.File.Exists(Filename) Then
                Return True
            Else : Return False
            End If

            Return False
        End Function
        ''' <summary>
        ''' Prüfen, ob File geöffnet
        ''' </summary>
        ''' <param name="fullFilePath"></param>
        ''' <returns></returns>
        Public Shared Function IsFileInUse(ByVal fullFilePath As String) As Boolean
            ' Gibt zurück, ob die übergebene Datei momentan exklusiv zu haben ist.
            ' Prüft, ob die angegeben Datei aktuell durch eine
            ' andere Anwendung in Benutzung ist
            Dim ff As Integer = FreeFile()

            If System.IO.File.Exists(fullFilePath) Then

                Try
                    ' Versuchen, die Datei mit *exklusiven* Lese- und
                    ' Schreibrechten zu öffnen
                    FileOpen(ff, fullFilePath, OpenMode.Binary,
                                               OpenAccess.ReadWrite,
                                               OpenShare.LockReadWrite)

                Catch

                    ' Ist ein Fehler aufgetreten, so wird nach außen hin generell
                    ' davon ausgegangen, dass die Datei in Benutzung ist (obwohl
                    ' auch andere Ursachen, etwa Rechteprobleme, möglich sind).
                    IsFileInUse = True

                Finally

                    ' Die eventuell geöffnete Datei schließen
                    FileClose(ff)

                End Try

            End If
            Return IsFileInUse
        End Function
        Public Shared Sub CheckProcess(ByVal myProcess As String)
            For Each proz In System.Diagnostics.Process.GetProcessesByName(myProcess)
                proz.Kill()
            Next
            'Dim p As System.Diagnostics.Process
            'Dim pp As System.Diagnostics.Process()
            '' --- Prozesse dieses Namens ermitteln
            'pp = Process.GetProcesses()
            'For Each p In pp

            '    If p.ProcessName.Contains(myProcess) Then
            '        MsgBox(p.ProcessName)
            '        If Not p.Responding Then
            '            MsgBox("Prozess hängt " & p.ProcessName & " und wird beendet...")
            '            ' --- Keine Reaktion -> gewaltsames Ende
            '            p.Kill()
            '            MsgBox(" Prozess wurde gewaltsam beendet!")
            '        End If
            '    End If
            'Next
        End Sub
        ''' <summary>
        ''' Text aus Image (OCR)
        ''' Nutzt Tesseract. Erforderlich der dataPath mit Speicherort des Ordners tessdata mit den OCR-Dateeien
        ''' </summary>
        ''' <param name="imgList"></param>
        ''' <returns>ergeb=Array mit OCR-Text und Confidence</returns>
        Public Shared Function CreateOCR(ByVal imgList As List(Of System.Drawing.Bitmap)) As String()
            Dim dataPath = FreeDMS_Aux.FreeDMS.GrundDaten.sAppPath & "tessdata" ' "D:\Users\peter\Documents\Visual Studio 2017\Projekte\Scanner\Scanner\bin\Debug\tessdata"
            Dim tempTxt As String = Nothing
            Dim OCR_Text As String = Nothing
            Dim conf As Single = 0
            Dim ergeb(2) As String

            Dim i As Integer = 1
            Using tEngine = New TesseractEngine(dataPath, "deu", EngineMode.[Default])
                'For Each file In FileList
                Try
                    For Each img In imgList
                        ''creating the tesseract OCR engine with English as the language
                        'Using img = Pix.LoadFromFile(file)
                        '    Dim image = New System.Drawing.Bitmap(file)
                        ' Load of the image file from the Pix object which is a wrapper for Leptonica PIX structure
                        Using page = tEngine.Process(img) 'tEngine.Process(img)
                            'process the specified image
                            tempTxt = page.GetText()
                            'Gets the image's content as plain text.
                            'Get's the mean confidence that as a percentage of the recognized text.
                            conf = page.GetMeanConfidence()
                            OCR_Text += "Seite " & i & " (Genauigkeit: " & conf & ") " & vbCrLf & "___________________________" & vbCrLf & tempTxt
                            i = i + 1
                        End Using
                    Next
                    'End Using
                    ' RichTextBox1.Text = tempTxt
                Catch ex As Exception
                    MsgBox("Fehler bei der Texterkennung: " + ex.Message)
                End Try
                ' Next
                ergeb(0) = OCR_Text
                ergeb(1) = conf.ToString
            End Using
            Return ergeb
            'RichTextBox1.SaveFile(inputOrdner & DocName & ".ocr", RichTextBoxStreamType.PlainText)

        End Function
        ''' <summary>
        ''' Convertiert Image nach PDF
        ''' Es muss eine list(of Bitmap) als scrImgList übergeben werden.
        ''' Als Ergebnis wird ein (Multipage)PDF erzeugt und unter destFilname gespeichert
        ''' destFileName muss Pfad und Name enthalten
        ''' </summary>
        ''' <param name="srcImgList"></param>
        ''' <param name="dstFilename"></param>
        ''' <returns></returns>

        Public Shared Function ConvertImageToPdf(ByVal srcImgList As List(Of System.Drawing.Bitmap), ByVal dstFilename As String) As Boolean
            Dim pgSize As iTextSharp.text.Rectangle = Nothing
            'Da Seiten in srcImgList immer das gleiche Format haben, kann pgSize vor Durchlauf ermittelt werden.
            pgSize = New iTextSharp.text.Rectangle(0, 0, srcImgList(0).Width, srcImgList(0).Height)
            Dim doc = New iTextSharp.text.Document(pgSize, 0, 0, 0, 0)
            Using PdfWriter.GetInstance(doc, New System.IO.FileStream(dstFilename, System.IO.FileMode.Create))

                doc.Open()
                For Each srcImage In srcImgList

                    Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(srcImage, System.Drawing.Imaging.ImageFormat.Bmp)

                    'Dim ms = New MemoryStream
                    Try
                        ' iTextSharp.text.pdf.PdfWriter.GetInstance(document, ms).SetFullCompression()

                        'Dim image = iTextSharp.text.Image.GetInstance(img)

                        doc.NewPage()
                        doc.Add(img)
                        'File.WriteAllBytes(dstFilename, ms.ToArray)
                        'If toKill Then Kill(srcFilename)
                    Catch ex As Exception
                        MsgBox(ex.Message)
                        Return False
                    End Try
                Next
                doc.Close()
            End Using
            'Dim pageSize As iTextSharp.text.Rectangle = Nothing
            'Dim document = New iTextSharp.text.Document(pageSize, 0, 0, 0, 0)
            'For Each srcImage In srcImgList
            '    'Dim img = New System.Drawing.Bitmap(srcImage)
            '    Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(srcImage, System.Drawing.Imaging.ImageFormat.Jpeg)
            '    pageSize = New iTextSharp.text.Rectangle(0, 0, srcImage.Width, srcImage.Height)
            '    Dim ms = New MemoryStream
            '    Try
            '        iTextSharp.text.pdf.PdfWriter.GetInstance(document, ms).SetFullCompression()
            '        document.Open()
            '        Dim image = iTextSharp.text.Image.GetInstance(img)
            '        document.Add(image)
            '        File.WriteAllBytes(dstFilename, ms.ToArray)
            '        'If toKill Then Kill(srcFilename)
            '    Catch ex As Exception
            '        MsgBox(ex.Message)
            '        Return False
            '    End Try
            'Next
            'document.Close()
            Return True
        End Function


        ''' <summary>
        ''' Erwartet aktuellen DB-Namen und gibt die Max ID von Dokumente zurück
        ''' </summary>
        ''' <param name="actDB"></param>
        ''' <returns></returns>
        Public Shared Function MaxID(ByVal actDB As String) As Int32
            ' Dim ConnectionString As String = My.Settings.freeDMS_DBConnectionString
            Dim ergeb As String = Nothing
            Dim Con As Object = New OleDb.OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source='" & actDB & "'")
            Dim cmd As OleDbCommand = NewMethod()
            cmd.Connection = DirectCast(Con, OleDbConnection)
            cmd.Connection.Open()

            cmd.CommandText = "SELECT max(id) FROM Dokumente"
            ergeb = cmd.ExecuteScalar().ToString
            'MsgBox(ergeb)
            If (cmd.ExecuteScalar() Is Nothing) Or (String.IsNullOrEmpty(cmd.ExecuteScalar().ToString)) Then
                Return 0
            Else
                Return Convert.ToInt32(cmd.ExecuteScalar())
            End If
            cmd.Connection.Close()
        End Function
        ''' <summary>
        ''' Legt cmd als neuen OleDbCommand fest
        ''' </summary>
        ''' <returns>cmd</returns>
        Private Shared Function NewMethod() As OleDbCommand
            Dim cmd As New OleDbCommand
            Return cmd
        End Function
        ''' <summary>
        ''' Textfile lesen
        ''' Erwartet DokNmae mit Pfad
        ''' </summary>
        ''' <param name="sDok"></param>
        ''' <returns>s als String</returns>
        Public Shared Function ReadFile(ByVal sDok As String) As String
            Dim iFr As Integer
            Dim s As String
            Try
                iFr = FreeFile()
                FileOpen(iFr, sDok, OpenMode.Binary)
                s = Space(CInt(FileLen(sDok)))
                FileGet(iFr, s)
                FileClose(iFr)
                ReadFile = s
                Return (s)
            Catch ex As Exception
                MsgBox("Fehler beim lesen der Datei")
                Return Nothing
            End Try
        End Function


    End Class
    ''' <summary>
    ''' Variablen, Funktionen und Sub's für das DB-Handling
    ''' </summary>
    Public Class DbHandling
        Public con As New OleDbConnection
        Public dbName As String
        ''' <summary>
        ''' DB laden
        ''' vollständiger Dateiname als Input erwartet
        ''' </summary>
        ''' <param name="sName"></param>
        Public Sub LoadDB(ByVal sName As String)
            ' MsgBox(sName)
            If File.Exists(sName) Then
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & sName & "'"
                'Provider=Microsoft.Jet.OLEDB.4.0;Data Source=H:\Access\freeDMS_DB_test.mdb
                Exit Sub

            ElseIf Not File.Exists(FreeDMS_Aux.FreeDMS.GrundDaten.sAppPath & Path.GetFileName(sName)) Then
                con.ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source='" & sName & "'"
                Exit Sub
            End If
            MsgBox("Datei " & sName & " nicht gefunden!",, "Bitte prüfen!")
        End Sub

    End Class

End Namespace

