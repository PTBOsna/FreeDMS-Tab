Option Strict On
Imports System.ComponentModel
Imports System.IO
Imports System.Windows.Forms
Imports FreeDMS_Aux.FreeDMS.Aux
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Imports OpenPop.Pop3
Imports OpenPop.Mime
Imports System.Text.RegularExpressions
Imports Message = OpenPop.Mime.Message
''' <summary>
''' Klasse Hauptseite
''' </summary>
Public Class Start
    Public hnDB As New FreeDMS_Aux.FreeDMS.DbHandling
    Public myAux As New FreeDMS_Aux.FreeDMS.Aux
    Public lblClose As Boolean = False
    Private xmlProvider As String = System.AppDomain.CurrentDomain.BaseDirectory & "Daten\provider.xml"
    Dim tempPath As String = My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\"
    Public gd As New FreeDMS_Aux.FreeDMS.GrundDaten
    Public Shared currDoc As New DocData
    Dim todaySuche As Boolean = False
    Dim offenSuche As Boolean = False
    Dim FlagAkteArchiv As Boolean = False
    Dim flagOrdnerArchiv As Boolean = False

    ''' <summary>
    ''' DocDate zum Zwischenspeichern der aktuellen Werte Mandant, Akte, Vorgang und Dokument
    ''' </summary>
    Class DocData
        Public Mandant As Integer
        Public Akte As Integer
        Public Vorgang As Integer
        Public Dokument As Integer
        Public DokName As String
    End Class

    'Dim MailInputOrdner As String = MailInputOrdner
    Dim allMessages As New List(Of Message)()
    Dim selAttachments As New List(Of MessagePart)
    Dim host As String
    Dim user As String
    Dim password As String
    Dim port As Integer
    Dim ssl As Boolean


    Public Property SelAttachments1 As List(Of MessagePart)
        Get
            Return selAttachments
        End Get
        Set(value As List(Of MessagePart))
            selAttachments = value
        End Set
    End Property
#Region "Start"
    ''' <summary>
    ''' Form Start
    ''' Hauptformular laden
    ''' Vorbereiten und Prüfen der Settings
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Vorbereitung
        Cursor.Current = Cursors.WaitCursor
        'testen ob Access installiert ist 
        If Not myAux.CheckForSoftwareInstallation("access") = True Then
            Me.TopMost = True
            Dim f As New MsgAccess
            f.ShowDialog()
            ' MsgBox("Microsoft Access ist nicht installiert!" & vbCrLf & "Wenn nicht vorhanden, bitte die kostenlose Runtime" & vbCrLf & "https://www.microsoft.com/de-de/download/details.aspx?id=4438" & vbCrLf & "installieren und FreeDMS neu starten!")
            End
        End If

        'Vorbereiten für Datei
        'Aufräumen
        For Each a As String In IO.Directory.GetFiles(tempPath)
            Try
                File.Delete(a)
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Next

        'Auf Ini-Datei Prüfen - Erforderlich, sonst Programmabbruch!
        If Not File.Exists(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\FreeDMS.ini") Then
            Me.TopMost = True
            MessageBox.Show("INI-Datei fehlt oder Fehlerhaft!", "Programm wird abgebrochen!")
            End
        End If

        'Aktuell DMSNamen aus der INI-Datei holen
        gd.TxtReader()
        'und xml-Settings auslesen
        gd.XMLReader()
        'und die Settings überprüfen

        gd.ChkSettings()
        Me.Text = "FreeDMS - Aktuelle DB: " & CurrDB
        'Setting laden:
        Dim myDB As String = Path.GetFileNameWithoutExtension(CurrDB)
        If Not My.Computer.FileSystem.FileExists(System.AppDomain.CurrentDomain.BaseDirectory & "Daten\" & myDB & ".xml") Then
            gd.XMLWriter()
        End If

        If File.Exists(xmlProvider) Then
            ProviderDataBase.ReadXml(xmlProvider)
        End If
        ProviderBindingSource.Filter = "id=1"
        For Each el In ProviderDataBase.Provider
            If el.id = -1 Then   'Voreinstellung erforderlich
                'TODO:           nach Mail - Algorihtmen auskommentieren
                host = el.Host
                user = el.User
                port = el.Port
                password = el.Password
                ssl = el.SSL
            End If
        Next
        RBAlles.Select()
        AnlagenSQLDataGridView.Visible = False
        LbAnlagen.Visible = False
        LbIstAnlage.Visible = False
        LbIstAnlage.Text = "Dokument ist Anlage (siehe Bearbeitungsvermerk)."
        'Voreinstellungen Mail
        PanelMailKopfDetail.Dock = DockStyle.Fill
        PanelMailKopfDetail.Visible = False
        PanelAtt.Visible = False
        PanelMail.Dock = DockStyle.Fill
        PanelMail.Visible = True
        PnlDokButton.Visible = True
        TxtCounter.Visible = False
        WebBrowser1.Dock = DockStyle.Fill
        WebBrowser1.Visible = False
        PictureBox1.Dock = DockStyle.Fill
        PictureBox1.Image = My.Resources.FreeDMS_Logo
        cbMaxMails.SelectedIndex = 2
        lblStatusMsg.Visible = False
        If mailAbrufStart = True Then
            UserTextBox1.Text = user
            HostTextBox1.Text = host
            TxtCounter.Visible = True
            Read_Emails()
        End If

        'allgemeine Voreinstellungen
        With ComboBoxSuche
            .Items.Add("in allen Feldern (ohne OCR)")
            .Items.Add("im Kommentar")
            .Items.Add("im Dokument (OCR)")
            .Items.Add("in Datum erstellt/Datum Dokument")
            .Items.Add("nach Dokument-Nummer")
            .SelectedIndex = 0
        End With
        'PanelSuche.Dock = DockStyle.Fill
        PanelSuche.Visible = False
        PanelSuchErgeb.Visible = False
        'PanelStartSuche.Visible = True
        'PanelStartSuche.Dock = DockStyle.Fill
        'Voreinstellungen Journal
        Dim maxWidth As Integer = DokumenteSQLDataGridView.Width
        With DokumenteSQLDataGridView
            .Columns(0).Width = CInt(maxWidth * 0.05)
            .Columns(1).AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            '.Columns(1).Width = CInt(maxWidth * 0.2)
            .Columns(2).Width = CInt(maxWidth * 0.155)
            .Columns(3).Width = CInt(maxWidth * 0.075)
            .Columns(4).Width = CInt(maxWidth * 0.075)
            .Columns(5).Width = CInt(maxWidth * 0.1)
            .Columns(6).Width = CInt(maxWidth * 0.1)
            .Columns(7).Width = CInt(maxWidth * 0.075)
            .Columns(8).Width = CInt(maxWidth * 0.075)
            .Columns(9).Width = CInt(maxWidth * 0.075)
        End With

        LblWv.Text = "Wiedervorlage(n)" & vbCrLf & "Heute ist der " & Format(Now, "dd. MMMM yyyy")
        ProgressBar1.Visible = False
        currDoc.Mandant = CInt(StartMandant)
        NotizBindingSource1.Filter = "id=0"
        LoadAll()
        LoadLvDok(LvScanInput)
        LoadLvDok(LVMailInput)
        FillTreeView()
        FindTreeNode(StartMandant)
        ''Beim Start kein Dokument anzeigen
        'DokumenteBindingSource.Filter = "id=0"
        Me.WindowState = FormWindowState.Maximized
    End Sub
    ''' <summary>
    ''' Tabeladapter füllen
    ''' Wiedervorlage prüfen
    ''' </summary>
    Private Sub LoadAll()
        Dim selDB = New FreeDMS_Aux.FreeDMS.DbHandling
        selDB.LoadDB(CurrDB)
        MandantTableAdapter.Connection = selDB.con
        DokumenteTableAdapter.Connection = selDB.con
        DokumenteSQLTableAdapter.Connection = selDB.con
        VorgaengeTableAdapter.Connection = selDB.con
        AktenTableAdapter.Connection = selDB.con
        AnschriftenTableAdapter.Connection = selDB.con
        TypTableAdapter.Connection = selDB.con
        StatusTableAdapter.Connection = selDB.con
        AblageTableAdapter.Connection = selDB.con
        NotizTableAdapter.Connection = selDB.con
        SqlVorgangAkteTableAdapter.Connection = selDB.con
        WiedervorlageTableAdapter.Connection = selDB.con
        VorlagenTableAdapter.Connection = selDB.con
        AnlagenSQLTableAdapter.Connection = selDB.con

        MandantTableAdapter.Fill(_FreeDMS_StartDBDataSet.Mandant)
        DokumenteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Dokumente)
        DokumenteSQLTableAdapter.Fill(_FreeDMS_StartDBDataSet.DokumenteSQL)
        VorgaengeTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorgaenge)
        AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        AnschriftenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Anschriften)
        TypTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Typ)
        StatusTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Status)
        AblageTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Ablage)
        NotizTableAdapter.Fill(_FreeDMS_StartDBDataSet.notiz)
        SqlVorgangAkteTableAdapter.Fill(_FreeDMS_StartDBDataSet.sqlVorgangAkte)
        WiedervorlageTableAdapter.Fill(_FreeDMS_StartDBDataSet.wiedervorlage)
        VorlagenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorlagen)
        AnlagenSQLTableAdapter.Fill(_FreeDMS_StartDBDataSet.AnlagenSQL)
        AnlagenSQLBindingSource.Filter = "id=0"

        'WiedevorlageDG markieren
        'Dim wv() As String '= Nothing
        For i As Integer = 0 To DataGridView1.Rows.Count - 1
            With DataGridView1
                Dim wvDate As String = .Rows(i).Cells(1).Value.ToString
                ' MsgBox(wvDate)
                Dim wv() As String = Split(wvDate)
                ' wv = String.Format("{0:M/dd/yyyy}", .Rows(i).Cells(1).Value.ToString)
                'MsgBox(Now.ToShortDateString & "-" & wv(0))
                If CDate(wv(0)) <= Now Then
                    .Rows(i).DefaultCellStyle.BackColor = Color.Red
                    .Rows(i).DefaultCellStyle.SelectionBackColor = Color.Red
                Else
                    .Rows(i).DefaultCellStyle.BackColor = Color.White
                End If
            End With
        Next

        'Dim wvDate As Date = Now
        'Dim filter As String = " wv_datum < " & String.Format("#{0:M/dd/yyyy}#", wvDate.AddDays(1))
        ''MsgBox(Filter)
        ''Dim Filter As String = "wv_datum >= " & String.Format("#{0:M/dd/yyyy}#", Now) & " AND wv_datum < " & String.Format("#{0:M/dd/yyyy}#", wvDate.AddDays(1))
        ''MsgBox(Filter)
        'WiedervorlageBindingSource.Filter = Filter
        'If WiedervorlageBindingSource.Count > 0 Then
        '    Panel8.BackColor = Color.DarkRed
        'End If
        SetCurrDoc()
    End Sub
    ''' <summary>
    ''' Alle BindingSources beenden und Update der TableAdapter
    ''' </summary>
    Private Sub SaveAll()
        Try
            Validate()
            MandantBindingSource.EndEdit()
            DokumenteBindingSource.EndEdit()
            VorgaengeBindingSource.EndEdit()
            AktenBindingSource.EndEdit()
            AnschriftenBindingSource.EndEdit()
            AblageBindingSource.EndEdit()
            TypBindingSource.EndEdit()
            StatusBindingSource.EndEdit()
            NotizBindingSource.EndEdit()
            WiedervorlageBindingSource.EndEdit()
            VorlagenBindingSource.EndEdit()
            AnlagenSQLBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Catch ex As Exception
            MsgBox("Fehler beim Speichern! Bitte prüfen!")
        End Try

    End Sub
    ''' <summary>
    ''' DataGridViews auf letzze Zeile setzen
    ''' </summary>
    Private Sub SetLastDGVRow()
        'DGVs auf letzte Zeile fokussieren
        Dim row As Integer = DokumenteSQLBindingSource.Count - 1
        If DokumenteSQLDataGridView.Rows.Count > 1 Then
            DokumenteSQLDataGridView.FirstDisplayedScrollingRowIndex = row
            DokumenteSQLDataGridView.CurrentCell = DokumenteSQLDataGridView.Rows(row).Cells(0)
            DokumenteSQLDataGridView.Rows(row).Selected = True
        End If
        'Löst Fehler aus, kann aber entfallen, da in Journalansicht keine Rücksetzung erforderlich ist
        'Dim row2 As Integer = DokumenteBindingSource.Count - 1
        'If row2 > 0 Then
        '    DokumenteDataGridView.FirstDisplayedScrollingRowIndex = row2
        '    DokumenteDataGridView.CurrentCell = DokumenteDataGridView.Rows(row2).Cells(1)
        '    DokumenteDataGridView.Rows(row2).Selected = True
        'End If
    End Sub
    ''' <summary>
    ''' Seitenauswahl per Tab
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        SetLastDGVRow()
        LbJournalCount.Text = "Es sind " & DokumenteSQLBindingSource.Count.ToString & " Einträge vorhanden."
        If Not TabControl1.SelectedTab Is TabPage1 Then
            ToolStripButtonDelDoc.Enabled = False
            ToolStripButtonDatSuche.Enabled = False
            ToolStripButtonSchnellSuche.Enabled = False
        Else
            ToolStripButtonDelDoc.Enabled = True
            ToolStripButtonDatSuche.Enabled = True
            ToolStripButtonSchnellSuche.Enabled = True
        End If
    End Sub
    ''' <summary>
    ''' Das mit lv festgelegte ListView füllen
    ''' </summary>
    ''' <param name="lv"></param>
    Private Sub LoadLvDok(ByRef lv As ListView)
        Dim locDirInfo As DirectoryInfo = Nothing
        Dim locLtvItem As ListViewItem = Nothing
        'Dim ltv As ListView
        Dim okFile As String = ".DOC .MSG .PDF .JPG .JPEG .DOCX .TIF .GIF .TXT .XLS .XLSX .EML .PNG .DOT .PUB .BMP"
        Dim AnzahlFiles As Integer = 0
        'ltv = lvDoc
        ' ltv = lv 'lvScaninput
        With lv 'ltv
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
                        AnzahlFiles = AnzahlFiles + 1
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
        If AnzahlFiles = 0 Then
            LbEingangsKorb.Text = "Der Eingangskorb ist leer."
        Else
            LbEingangsKorb.Text = "Eingangskorb (" & InputOrdner & ") mit " & AnzahlFiles & " Eingängen"
        End If
    End Sub
    ''' <summary>
    ''' Bedingungen zum Füllen des TreeViews
    ''' Alles Anzeigen, archivierte Akten oder - Ordner anzeigen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub RBAkten_CheckedChanged(sender As Object, e As EventArgs) Handles RBAktenArchiv.CheckedChanged, RBAlles.CheckedChanged, RBOrdnerArchiv.CheckedChanged
        Dim result As String = Nothing
        If RBAlles.Checked Then
            flagOrdnerArchiv = False
            FlagAkteArchiv = False
        End If
        If RBAktenArchiv.Checked Then
            FlagAkteArchiv = True
            flagOrdnerArchiv = False
        End If
        If RBOrdnerArchiv.Checked Then
            flagOrdnerArchiv = True
            FlagAkteArchiv = False
        End If
        FillTreeView()
    End Sub

    ''' <summary>
    ''' TreeView Mandant-Akte-Vorgang füllen
    ''' </summary>
    Private Sub FillTreeView()
        TreeView1.Nodes.Clear()
        Dim topNode As New TreeNode("Bereiche")
        TreeView1.Nodes.Add(topNode)
        topNode.Tag = "r;0"
        ' TreeView1.Font = New Font("Arial", 10, FontStyle.Bold)
        ' topNode.NodeFont = New Font(FontFamily.GenericSansSerif, FontStyle.Bold)
        ' Add topNode to the TreeView.
        ' TreeView1.Nodes.Add(topNode)
        Dim NodeMandant As TreeNode
        Dim NodeAkte As TreeNode
        Dim NodeVorgang As TreeNode
        NodeMandant = New TreeNode()
        ' NodeMandant.Tag = "Alles"
        NodeAkte = New TreeNode()
        NodeVorgang = New TreeNode

        Dim mandanten = From p In _FreeDMS_StartDBDataSet.Mandant
        'NodeMandant.ImageIndex = 0
        For Each myMandant In mandanten

            NodeMandant = New TreeNode(myMandant.id & " " & myMandant.Mandant, 0, 1) With {
                .Name = myMandant.id.ToString
            }
            topNode.NodeFont = New Font("Arial", 10, FontStyle.Bold)
            topNode.Nodes.Add(NodeMandant) 'TreeView1.Nodes.Add(NodeMandant)
            NodeMandant.Tag = "m;" & myMandant.id
            NodeMandant.Collapse()
            ''----für SubNode Akte

            Dim akten = From p In _FreeDMS_StartDBDataSet.Akten Where p.Mandant = CDbl(myMandant.id) And p.Archiv = FlagAkteArchiv
            For Each myAkte In akten
                NodeAkte = New TreeNode(myAkte.id & " " & myAkte.Akte, 2, 2) With {
                    .Name = myAkte.id.ToString
                }
                NodeMandant.Nodes.Add(NodeAkte)
                NodeAkte.Tag = "a;" & myAkte.id
                NodeAkte.Collapse()
                '--- Subnote Vorgang
                Dim vorgang = From p In _FreeDMS_StartDBDataSet.Vorgaenge Where p.Akte = CDbl(myAkte.id) And p.Archiv = flagOrdnerArchiv
                'MsgBox("Vorgänge: " & vorgang.Count.ToString)
                For Each myVorgang In vorgang
                    NodeVorgang = New TreeNode(myVorgang.id & " " & myVorgang.Vorgang, 3, 4) With {
                        .Name = myVorgang.id.ToString
                    }
                    NodeAkte.Nodes.Add(NodeVorgang)
                    NodeVorgang.NodeFont = New Font("Arial", 10, FontStyle.Regular)
                    NodeVorgang.Tag = "v;" & myVorgang.id
                    NodeVorgang.Collapse()
                Next
                'Next
            Next
        Next
        topNode.Expand()

    End Sub
#End Region
#Region "Handling"
    ''' <summary>
    ''' Die mit TreeView ausgewälten Daten anzeigen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub TreeView1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles TreeView1.AfterSelect
        Dim sItem(2) As String
        Dim lbVorhanden As Boolean = True
        sItem = Split(TreeView1.SelectedNode.Tag.ToString, ";")
        TreeView1.SelectedNode.Expand()
        'MsgBox(TreeView1.SelectedNode.Name)
        Select Case sItem(0)
            Case "r" 'Alles (Root)
                Me.DokumenteBindingSource.Filter = "ID > 0"
                GetMandantAkteVorgang()

            Case "m" 'Mandante
                Me.DokumenteBindingSource.Filter = "Mandant=" & sItem(1)

                If DokumenteBindingSource.Count > 0 Then

                    GetMandantAkteVorgang()
                Else
                    lbVorhanden = False
                End If

            Case "a" 'Akte
                Me.DokumenteBindingSource.Filter = "Akte=" & sItem(1)
                If DokumenteBindingSource.Count > 0 Then
                    GetMandantAkteVorgang()

                Else
                    lbVorhanden = False
                End If

            Case "v" 'Vorgang
                Me.DokumenteBindingSource.Filter = "Vorgang=" & sItem(1)
                If DokumenteBindingSource.Count > 0 Then

                    GetMandantAkteVorgang()
                Else
                    lbVorhanden = False
                End If

                If lbVorhanden = False Then
                    MsgBox("Kein Vorgang Vorhanden!")
                End If

        End Select
        SetLastDGVRow()
    End Sub
    Private Sub TreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles TreeView1.MouseDown
        Dim sItem(2) As String
        Dim temp As New TreeNode
        temp = TreeView1.SelectedNode
        If temp Is Nothing Then
            Exit Sub
        End If
        ' Rechtsklick?
        If e.Button = Windows.Forms.MouseButtons.Right Then
            ' Eintrag ermitteln ...
            sItem = Split(temp.Tag.ToString, ";")
            If sItem(0) = "a" Then
                ' MsgBox("Neuen Vorgang anlegen zu " & TreeView1.SelectedNode.Tag.ToString)
                ContextMenuStripTVOrdner.Show(TreeView1, e.X, e.Y)
            End If
        End If
    End Sub

    ''' <summary>
    ''' Syncronisation von Mandant-Akte-Vorgang
    ''' </summary>
    Private Sub GetMandantAkteVorgang()
        Dim txtMandant As String = Nothing
        Dim txtAkte As String = Nothing
        Dim txtVorgang As String = Nothing
        Dim az As String = Nothing

        Try
            Dim rwDokument = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            lbAnzahl.Text = "Enthält " & DokumenteBindingSource.Count & " Dokumente"
            If rwDokument.id > 0 Then
                MandantBindingSource.Filter = "id=" & rwDokument.Mandant
                AktenBindingSource.Filter = "id=" & rwDokument.Akte
                VorgaengeBindingSource.Filter = "id=" & rwDokument.Vorgang
                az = rwDokument.Mandant & "-" & rwDokument.Akte & "-" & rwDokument.Vorgang & "/" & rwDokument.id
            End If
            'Mandat auslesen
            Dim rwMandant = DirectCast(DirectCast(MandantBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.MandantRow)
            If Not rwMandant.IsMandantNull Then
                txtMandant = rwMandant.Mandant
            End If
            'Akte auslesen
            Dim rwAkten = DirectCast(DirectCast(AktenBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.AktenRow)
            If Not rwAkten.IsAkteNull Then
                txtAkte = rwAkten.Akte
            End If
            'Vorgang auslesen
            Dim rwVorgang = DirectCast(DirectCast(VorgaengeBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.VorgaengeRow)
            If Not rwVorgang.IsVorgangNull Then
                txtVorgang = rwVorgang.Vorgang
            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        lbMandant.Text = txtMandant
        lbAkte.Text = txtAkte
        lbVorgang.Text = txtVorgang
        lbAz.Text = "Aktenzeichen " & az
    End Sub
    ''' <summary>
    ''' Festlegen des Starpunktes für TreeView
    ''' Ermitteln des aktuellen Knotens im TreeView
    ''' </summary>
    ''' <param name="az"></param>
    Private Sub FindTreeNode(ByVal az As String)
        Dim tn = TreeView1.Nodes.Find(az, True)

        If Not tn.Count = 1 Then
            Return
        End If
        TreeView1.SelectedNode = tn(0)
        TreeView1.Select()
    End Sub
    ''' <summary>
    ''' DataGridView Dokumente auf aktuelles Dok setzen
    ''' </summary>
    Private Sub SetCurrDoc()
        FindTreeNode(currDoc.Vorgang.ToString)
        Try
            For i = 0 To DokumenteDataGridView.Rows.Count - 1
                If CInt(DokumenteDataGridView.Rows(i).Cells(0).Value) = currDoc.Dokument Then

                    DokumenteDataGridView.Rows(i).Selected = True
                    DokumenteDataGridView.Refresh()
                End If
            Next
        Catch ex As Exception

        End Try

        DokShow()
    End Sub
    ''' <summary>
    ''' DB auswählen
    ''' wird aus Menü Datei - Öffnen aufgerufen
    ''' </summary>
    ''' <param name="dbName"></param>
    Private Sub SelectDB(ByVal dbName As String)
        Dim selDB As New FreeDMS_Aux.FreeDMS.DbHandling With {
            .dbName = dbName}
    End Sub
    ''' <summary>
    ''' Aufruf Detailansicht Dokumente aus DokumenteDataGridView
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub DokumenteDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DokumenteDataGridView.CellClick
        DokShow()
    End Sub
    Private Sub DokumenteDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DokumenteDataGridView.CellDoubleClick
        DocEdit(DirectCast(DokumenteBindingSource.Current, DataRowView).Item("id").ToString)
    End Sub

    Private Sub DokShow()
        AblageTextBox.Text = Nothing
        TypTextBox.Text = Nothing
        StatusTextBox.Text = Nothing
        AnlagenSQLDataGridView.Visible = False
        LbAnlagen.Visible = True
        Try
            If DokumenteBindingSource.Current Is Nothing Then Exit Sub
            Dim rwDokument = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            GetMandantAkteVorgang()
            'MsgBox(rwDokument.Typ & ", " & rwDokument.Status & ", " & rwDokument.Ablage)
            With currDoc
                .Mandant = rwDokument.Mandant
                .Akte = rwDokument.Akte
                .Vorgang = rwDokument.Vorgang
                .Dokument = rwDokument.id
                If (Not rwDokument.IsDokNameNull) OrElse (Not rwDokument.Anlagen = Nothing) Then
                    .DokName = rwDokument.DokName
                End If
            End With
            If rwDokument.Anlagen > 0 Then
                ' MsgBox(rwDokument.Anlagen.ToString)
                AnlagenSQLBindingSource.Filter = "Dokid=" & rwDokument.id
                If AnlagenSQLBindingSource.Count > 0 Then
                    AnlagenSQLDataGridView.Visible = True
                    LbAnlagen.Text = "Anlage(n)"
                Else
                    AnlagenSQLDataGridView.Visible = False
                    LbAnlagen.Text = "Anlage nicht zugeordnet (stammt aus früherer FreeDMS-Version)!"
                End If
            Else
                AnlagenSQLDataGridView.Visible = False
                LbAnlagen.Text = "keine Anlage(n)"
            End If
            If Not rwDokument.IsistAnlageNull Then
                If rwDokument.istAnlage = True Then
                    LbIstAnlage.Visible = True

                Else
                    LbIstAnlage.Visible = False
                End If
            End If
            If Not rwDokument.IsAbsenderNull Then
                AnschriftenBindingSource.Filter = "id=" & rwDokument.Absender
            Else
                AbsenderTextBox.Text = ""
            End If
            If Not rwDokument.IsEmpfaengerNull Then
                AnschriftenBindingSource1.Filter = "id=" & rwDokument.Empfaenger
            Else
                EmpfaengerTextBox.Text = ""
            End If
            If Not rwDokument.IsBetragNull Then
                BetragTextBox.Text = rwDokument.Betrag.ToString("C")
            Else
                BetragTextBox.Text = Nothing
            End If
            Dim status = From p In _FreeDMS_StartDBDataSet.Status Where p.id = CInt(rwDokument.Status) Select p
            If status.Count > 0 Then
                For Each eintrag In status
                    StatusTextBox.Text = eintrag.Status
                Next
            Else
                StatusTextBox.Text = "Nicht zugeordnet"
            End If
            Dim typ = From p In _FreeDMS_StartDBDataSet.Typ Where p.id = CInt(rwDokument.Typ) Select p
            If typ.Count > 0 Then
                For Each eintrag In typ
                    TypTextBox.Text = eintrag.Typ
                Next
            Else
                TypTextBox.Text = "Nicht zugeordnet"
            End If
            Dim ablage = From p In _FreeDMS_StartDBDataSet.Ablage Where p.Nummer = CInt(rwDokument.Ablage) Select p
            If ablage.Count > 0 Then
                For Each eintrag In ablage
                    AblageTextBox.Text = eintrag.Ablage
                Next
            Else
                AblageTextBox.Text = "Nicht zugeordnet"
            End If


            NotizBindingSource1.Filter = "dokument=" & currDoc.Dokument
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
    ''' <summary>
    ''' DateiDialog zu Datenbank-Auswahl
    ''' Voreingestellt ist der Bestandteil "FreeDMS" und die Dateiendung "mdb"
    ''' </summary>
    Private Sub DBAuswahl()
        Dim dummy As String = ""
        With OpenFileDialog1
            '.Filter = "Access-Dateien (*.mdb)|*.mdb|All files (*.*)|*.*"
            .Filter = "FreeDMS (FreeDMS*.mdb)|FreeDMS*.mdb"
            .InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory
            .FileName = ""
            .ShowDialog()
            If String.IsNullOrEmpty(.FileName) Then Exit Sub
            CurrDB = .FileName
            'prüfen of entsprechende xml-Datei existiert 

            gd.TxtWriter()
            'und die lastDb xml auslesen
            gd.XMLReader()

        End With
    End Sub
#End Region
#Region "Buttons"
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click, ToolStripButtonExit.Click
        lblClose = True
        SaveAll()
        Application.Exit()
        ' Close()
    End Sub
    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        DBAuswahl()
        Cursor.Current = Cursors.WaitCursor
        SelectDB(CurrDB)
        hnDB.dbName = CurrDB
        Me.Text = "FreeDMS-3 - Start - " & CurrDB
        LoadAll()
        LoadLvDok(LvScanInput)
        LoadLvDok(LVMailInput)
        FillTreeView()
        FindTreeNode(StartMandant)
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub MandantenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MandantenToolStripMenuItem.Click, ToolStripButtonMandanten.Click
        Dim f As New Mandanten
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()

    End Sub
    Private Sub AktenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AktenToolStripMenuItem.Click, ToolStripButtonAkten.Click
        Dim f As New Akten
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub VorgängeOrdnerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VorgängeOrdnerToolStripMenuItem.Click, ToolStripButtonVorgaenge.Click
        Dim f As New Vorganege
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub DokumenteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DokumenteToolStripMenuItem1.Click, ToolStripButtonDokumente.Click
        Dim f As New Docliste
        ' f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.StatusBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.TypBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Dim f As New Settings
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub AblageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AblageToolStripMenuItem.Click
        Dim f As New Ablage
        f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        'If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub NotizenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NotizenToolStripMenuItem.Click
        Dim f As New NotizListe
        f.NotizBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        'If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub NotizDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles NotizDataGridView.CellDoubleClick
        Dim openArgs As String
        Dim dr As DialogResult
        Try
            openArgs = DirectCast(DirectCast(NotizBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.notizRow).id.ToString
            Dim f As New Notiz(openArgs)
            f.NotizBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.SqlVorgangAkteBindingSource.DataSource = _FreeDMS_StartDBDataSet
            dr = f.ShowDialog()
            ' dr = f.ShowDialog()

            'dr = f.ShowDialog()
            'If dr = DialogResult.Yes Then
            '    NotizBindingSource.RemoveCurrent()
            'End If
            'DataChanged()
            If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DocNotizDataGridView_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DocNotizDataGridView.CellDoubleClick
        Dim openArgs As String

        Try
            openArgs = DirectCast(DirectCast(NotizBindingSource1.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.notizRow).id.ToString
            Dim f As New Notiz(openArgs)
            f.NotizBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.CbAkten.Enabled = False
            f.CbVorgaenge.Enabled = False
            f.CbDokumente.DropDownStyle = ComboBoxStyle.DropDownList
            f.ShowDialog()

            'If dr = DialogResult.Yes Then NotizBindingSource.RemoveCurrent()
            If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButtonNoteNeu_Click(sender As Object, e As EventArgs) Handles ToolStripButtonNoteNeu.Click
        Dim openArgs As Integer = 0
        Dim f As New NotizNeu(openArgs.ToString)
        f.NotizBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.SqlVorgangAkteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        'If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub BtDocNotiz_Click(sender As Object, e As EventArgs) Handles btDocNotiz.Click
        Dim openArgs As String
        openArgs = currDoc.Dokument.ToString
        If Not CInt(openArgs) <> 0 Then
            MsgBox("Bitte zunächst ein Dokumente in der Dokumentenliste auswählen!")
            Exit Sub
        End If
        Dim f As New NotizNeu(openArgs)
        f.NotizBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.CbAkten.Enabled = False
        f.CbVorgaenge.Enabled = False
        f.CbDokumente.DropDownStyle = ComboBoxStyle.DropDownList
        f.ShowDialog()
        'If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub
    ''' <summary>
    ''' Neue Wiedervorlage erstellen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtWiedervorlage_Click(sender As Object, e As EventArgs) Handles BtWiedervorlage.Click
        Dim openArgs As String
        openArgs = currDoc.Dokument.ToString & ";j" 'j = neue Wiedervorlage
        If Not CInt(currDoc.Dokument) <> 0 Then
            MsgBox("Bitte zunächst ein Dokumente in der Dokumentenliste auswählen!")
            Exit Sub
        End If
        Dim f As New WiedervorlageNeu(openArgs)
        f.WiedervorlageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.BtClear.Visible = False

        f.ShowDialog()
        'If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub

    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Dim openArgs As String = DirectCast(DirectCast(WiedervorlageBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.wiedervorlageRow).id.ToString & ";n" 'n = keine neue Wiedervorlage
        '  MsgBox("ID: " & openArgs & vbCrLf & "Datei: " & CurrDB)
        Try
            Dim f As New WiedervorlageNeu(openArgs)
            f.WiedervorlageBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet

            f.ShowDialog()
            'If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub WiedervorlagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WiedervorlagenToolStripMenuItem.Click, ToolStripButtonWv.Click
        Dim f As New WiedervorlageListe
        Try
            f.WiedervorlageBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet

            f.ShowDialog()
            'If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripButtonScanInput_Click(sender As Object, e As EventArgs) Handles ToolStripButtonScanInput.Click
        Dim f As New FolderInput
        Try
            'f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.AnschriftenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
            f.TypBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.StatusBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
            'f.VorlagenBindingSource.DataSource = _FreeDMS_StartDBDataSet
            f.ShowDialog()
            'Da neuer Datensatz hinzugefügt wurde, aktualisieren
            UpdateAll()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub VorlagenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VorlagenToolStripMenuItem.Click, ToolStripButtonVorlagen.Click
        Dim f As New Vorlagen
        f.VorlagenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantAktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AktenVorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub
    Private Sub BtShowDoc_Click(sender As Object, e As EventArgs) Handles btShowDoc.Click
        DocEdit(currDoc.Dokument.ToString)
    End Sub
    'Private Sub AnlagenDataGridView_DoubleClick(sender As Object, e As EventArgs) Handles AnlagenDataGridView.CellDoubleClick
    '    '  
    'End Sub
    Private Sub AnlagenSQLDataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles AnlagenSQLDataGridView.CellClick

        DocEdit(DirectCast(AnlagenSQLBindingSource.Current, DataRowView).Item("id").ToString)
    End Sub
    Private Sub DocEdit(ByVal openArgs As String)
        Dim f As New DocEdit(openArgs)
        Cursor.Current = Cursors.WaitCursor
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.StatusBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.TypBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
        Cursor.Current = Cursors.Default
    End Sub
    Private Sub DokumenteSQLDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DokumenteSQLDataGridView.CellDoubleClick
        DocEdit(DirectCast(DokumenteSQLBindingSource.Current, DataRowView).Item("id").ToString)

    End Sub
    Private Sub ToolStripButtonScan_Click(sender As Object, e As EventArgs) Handles ToolStripButtonScan.Click

        Dim f As New ScanToDoc2()
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.StatusBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.TypBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()

    End Sub
    Private Sub ArchivierteVorgängeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ArchivierteVorgängeToolStripMenuItem.Click
        Dim f As New VorgaengeArchiv
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then Update()
    End Sub
    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        UpdateAll()
    End Sub
    Private Sub UpdateAll()
        If Not DokumenteBindingSource.Current Is Nothing OrElse DokumenteBindingSource.Count > 0 Then
            Dim rwAkten = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            With currDoc
                .Mandant = CInt(rwAkten.Mandant)
                .Akte = CInt(rwAkten.Akte)
                .Vorgang = CInt(rwAkten.Vorgang)
                .Dokument = rwAkten.id
            End With
            DokumenteDataGridView.DataSource = Nothing

            ' Else
            'MsgBox("Bitte zunächst einen Vorgang auswählen!")
        End If
        StartRefresh()
    End Sub
    Public Sub StartRefresh()
        'SetCurrDoc()

        BGWRefresh.RunWorkerAsync()
        ProgressBar1.Visible = True
    End Sub

    Private Sub BGWRefresh_DoWork(sender As Object, e As DoWorkEventArgs) Handles BGWRefresh.DoWork
        SaveAll()
        LoadAll()

    End Sub

    Private Sub BGWRefresh_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles BGWRefresh.RunWorkerCompleted
        ProgressBar1.Visible = False
        LoadLvDok(LvScanInput)

        DokumenteDataGridView.DataSource = DokumenteBindingSource
        FillTreeView()
        SetCurrDoc()

    End Sub

    Private Sub TestFormToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TestFormToolStripMenuItem.Click
        Dim f As New TestForm
        f.ShowDialog()
    End Sub

    Private Sub AnschriftenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnschriftenToolStripMenuItem.Click
        Dim f As New Anschriften
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
        If _FreeDMS_StartDBDataSet.HasChanges Then SaveAll()
    End Sub
    Private Sub DokArtToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DokArtToolStripMenuItem.Click
        Dim f As New DocTyp
        f.TypBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub
    Private Sub StatusToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatusToolStripMenuItem.Click
        Dim f As New DocStatus
        f.StatusBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub
    Private Sub AnschriftenAusDokÜbernehmenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnschriftenAusDokÜbernehmenToolStripMenuItem.Click
        Dim f As New AnschriftenZuordnung
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub
    Private Sub ToolStripButton14_Click(sender As Object, e As EventArgs) Handles ToolStripButton14.Click
        Dim f As New DocTextNew
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.StatusBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.TypBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub
    Private Sub BtPrint_Click(sender As Object, e As EventArgs) Handles BtPrint.Click
        Dim openArgs As String = currDoc.Dokument.ToString
        Dim f As New PrintForm(openArgs)
        f.DokumenteBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AnschriftenBindingSource1.DataSource = _FreeDMS_StartDBDataSet
        f.AblageBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.StatusBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.TypBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim f As New AnschriftNeu
        f.AnschriftenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub
    Private Sub AkteAnsehenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AkteAnsehenToolStripMenuItem.Click
        Dim selVal(2) As String
        selVal = Split(TreeView1.SelectedNode.Tag.ToString, ";")
        Dim openArgs As String = selVal(1)
        Dim f As New AkteEdit(openArgs)
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.MandantBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.ShowDialog()
    End Sub
    Private Sub NeuerOrdnerZurAkteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuerOrdnerZurAkteToolStripMenuItem.Click
        Dim selVal(2) As String
        selVal = Split(TreeView1.SelectedNode.Tag.ToString, ";")
        Dim openArgs As String = selVal(1)
        Dim f As New VorgangNeu(openArgs)
        f.VorgaengeBindingSource.DataSource = _FreeDMS_StartDBDataSet
        f.AktenBindingSource.DataSource = _FreeDMS_StartDBDataSet

        f.ShowDialog()
    End Sub


    ''' <summary>
    ''' Testen, ob  die Tabellen "Akten", "Vorgänge" oder "Dokumente" Verweise auf den zu löschenden Eintrag enthalten. 
    ''' Die ID der Verknüpfung ist einzugeben. Eintrag 0 überspringt die Tabelle. Es wird nur ein Wert zurückgegeben!
    ''' Zum Beispiel testet ChkTbl(21,0,0) ob in der TAbelle "Akten" Verweise auf Mandanten mit der ID 21 enthalten. Wenn ja, kann der Mandant
    ''' 21 nicht gelöscht werden, ohne dass Verweise in "Akten" leer laufen (Referentielle Integrität)
    ''' </summary>
    ''' <param name="mandant"></param>
    ''' <param name="akte"></param>
    ''' <param name="vorgang"></param>
    ''' <returns></returns>
    Public Function ChkTbl(ByVal mandant As Integer, ByVal akte As Integer, ByVal vorgang As Integer) As Integer
        Dim erg As Integer = 0
        ' Dim buch = From p In Literatur_DataSet.Buch Where p.ID >= CInt(BuchID) Select p
        If mandant <> 0 Then
            Dim chec = From p In _FreeDMS_StartDBDataSet.Akten Where p.Mandant = mandant
            erg = chec.Count

        End If
        If akte <> 0 Then
            Dim chec = From p In _FreeDMS_StartDBDataSet.Vorgaenge Where p.Akte = akte
            erg = chec.Count
        End If

        If vorgang <> 0 Then
            Dim chec = From p In _FreeDMS_StartDBDataSet.Dokumente Where p.Vorgang = vorgang
            erg = chec.Count
        End If
        Return erg
    End Function

    Private Sub NeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NeuToolStripMenuItem.Click
        Dim f As New DBNeu
        f.ShowDialog()

    End Sub
    Private Sub ImageNachPDFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImageNachPDFToolStripMenuItem.Click
        Dim openArgs As String = "#" 'Damit ImageToPDF im Modus mit OpenFileDialog öffnet
        Dim f As New ImageToPDF(openArgs)

        f.ShowDialog()
    End Sub
    ''' <summary>
    ''' Dokument in Listview ScanInput mit zugehöriger Anwendung öffnen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LvScaninput_DoubleClick(sender As Object, e As EventArgs) Handles AnsehenToolStripMenuItem1.Click
        Dim sDokName As String = InputOrdner
        If (LvScanInput.SelectedItems.Count = 0) Then Exit Sub
        sDokName += LvScanInput.SelectedItems(0).Text()
        Try
            Process.Start(sDokName)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & sDokName)
        End Try
    End Sub

    ''' <summary>
    ''' Dokument in ListView ScanInput löschen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LöschenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LöschenToolStripMenuItem.Click
        Dim sDokName As String = InputOrdner
        If (LvScanInput.SelectedItems.Count = 0) Then Exit Sub
        sDokName += LvScanInput.SelectedItems(0).Text()
        Try
            MsgBox(sDokName & " löschen?")
            Kill(sDokName)
            LoadLvDok(LvScanInput)
        Catch ex As Exception
            MsgBox(ex.Message & vbCrLf & sDokName)
        End Try
    End Sub

    Private Sub Start_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        Application.Exit()
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        Dim f As New AboutBox1
        f.Show()
    End Sub

    Private Sub InhaltToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InhaltToolStripMenuItem.Click
        MsgBox(sAppPath & "FreeDMS-Help.chm")
        Process.Start(sAppPath & "FreeDMS-Help.chm")
    End Sub
#End Region
#Region "Suche"
    Private Sub ToolStripButtonSchnellSuche_Click(sender As Object, e As EventArgs) Handles ToolStripButtonSchnellSuche.Click
        PanelSuche.Visible = True
        PanelSuchErgeb.Visible = True

        TreeView1.Enabled = False
    End Sub
    ''' <summary>
    ''' Schnellsuche zurücksetzen - Aufruf
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles btClear.Click
        PanelSuche.Visible = False
        PanelSuchErgeb.Visible = False
        'PanelStartSuche.Dock = DockStyle.Fill
        'PanelStartSuche.Visible = True
        TreeView1.Enabled = True
        ClearSearch()
    End Sub
    ''' <summary>
    ''' Schnellsuche zurücksetzen
    ''' </summary>
    Private Sub ClearSearch()
        DokumenteBindingSource.Filter = "id<0"
        DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)
        TextSuche.Text = ""
        lblSuchErgebnis.Visible = False
    End Sub
    ''' <summary>
    ''' Flags für Schnellsuche einstellen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtSearcj_Click(sender As Object, e As EventArgs) Handles btSearcj.Click
        todaySuche = False
        offenSuche = False
        SucheLos()
    End Sub
    ''' <summary>
    ''' Schnellsuche durchführen
    ''' </summary>
    Private Sub SucheLos()
        Cursor.Current = Cursors.WaitCursor
        Dim sInput, sFilter As String
        Dim sIndex As Integer

        sInput = TextSuche.Text

        DokumenteBindingSource.RemoveFilter()
        sIndex = ComboBoxSuche.SelectedIndex + 1
        If todaySuche = True Then
            sIndex = 6
            sInput = Now.ToString("dd.MM.yyyy")
            todaySuche = False
        End If
        If offenSuche = True Then
            sIndex = 8
        End If
        Select Case sIndex

            Case 1
                sFilter = "Dokument like '%" & sInput & "%' OR Betreff like '%" & sInput & "%' OR Kommentar like '%" & sInput & "%'"
                ' MsgBox(sFilter)
                DokumenteBindingSource.Filter = sFilter

            Case 2
                DokumenteBindingSource.Filter = "Kommentar Like '%" & sInput & "%'"
            Case 3
                DokumenteBindingSource.Filter = "inhaltOCR like '%" & sInput & "%'"
            Case 4
                Dim dummy As Date

                If Not Date.TryParse(sInput, dummy) Then
                    MsgBox("Falsches Datumsformat. Bitte Datum als ""dd.mm.jjjj"" eingeben")
                End If
                ' dummy = Format(sInput, "MM/dd/yyyy")
                DokumenteBindingSource.Filter = "DokDatum >=" & String.Format("#{0:M/dd/yyyy}#", dummy)
            Case 5
                DokumenteBindingSource.Filter = "id=" & sInput
            Case 6
                Dim dummy As Date

                If Not Date.TryParse(sInput, dummy) Then
                    MsgBox("Falsches Datumsformat. Bitte Datum als ""dd.mm.jjjj"" eingeben")
                End If
                ' dummy = Format(sInput, "MM/dd/yyyy")
                DokumenteBindingSource.Filter = "Aufgenommen >=" & String.Format("#{0:M/dd/yyyy}#", dummy)
            Case 7

                DokumenteBindingSource.Filter = "Status = 2"
        End Select
        ' Me.dokumentebindingsource.Filter = "fdOCR like '%" & Me.TextBox1.Text & "%'"
        DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)
        DisplayErgebnis(CInt(DokumenteBindingSource.Count), "Es")
        Cursor.Current = Cursors.Default
    End Sub


    Private Sub CbStatusSuche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbStatusSuche.SelectedIndexChanged
        If CbStatusSuche.SelectedIndex >= 0 Then
            DokumenteBindingSource.RemoveFilter()
            DokumenteBindingSource.Filter = "Status=" & CbStatusSuche.SelectedValue.ToString
            ' DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)
            DisplayErgebnis(CInt(DokumenteBindingSource.Count), "Es")
        End If
    End Sub
    Private Sub CbTypSuche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbTypSuche.SelectedIndexChanged
        If CbTypSuche.SelectedIndex >= 0 Then
            DokumenteBindingSource.RemoveFilter()
            DokumenteBindingSource.Filter = "Typ=" & CbTypSuche.SelectedValue.ToString
            ' DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)
            DisplayErgebnis(CInt(DokumenteBindingSource.Count), "Es")
        End If
    End Sub

    Private Sub CbAblageSuche_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAblageSuche.SelectedIndexChanged
        If CbAblageSuche.SelectedIndex >= 0 Then
            DokumenteBindingSource.RemoveFilter()
            DokumenteBindingSource.Filter = "Ablage=" & CbAblageSuche.SelectedValue.ToString
            ' DokumenteTableAdapter.Fill(_FreeDMS_StartDBDataSet.Dokumente)
            DisplayErgebnis(CInt(DokumenteBindingSource.Count), "Es")
        End If
    End Sub
    ''' <summary>
    ''' Ergebnis der Schnellsuche anzeigen
    ''' </summary>
    ''' <param name="iErgebnis"></param>
    ''' <param name="Text"></param>
    Private Sub DisplayErgebnis(ByVal iErgebnis As Integer, Text As String)
        lblSuchErgebnis.Visible = True
        If iErgebnis = 0 Then
            lblSuchErgebnis.Text = "Es wurden keine Dokumente gefunden"
        Else
            lblSuchErgebnis.Text = Text & " wurden " & iErgebnis & " Dokumente gefunden"
        End If
    End Sub
    ''' <summary>
    ''' Suche heute vorbereiten
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDatSuche.Click
        PanelSuche.Visible = True
        PanelSuchErgeb.Visible = True
        todaySuche = True
        offenSuche = False
        SucheLos()
        btClear.Enabled = True
    End Sub

    Private Sub ToolStripButtonDelDoc_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDelDoc.Click

        Dim delDok As String
        '  WebBrowser1.Navigate("")

        Dim currRow = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
        'aktuelle Daten in CurrDoc einlesen
        With currDoc
            .Mandant = currRow.Mandant
            .Akte = currRow.Akte
            .Vorgang = currRow.Vorgang
        End With
        Try
            If Not currRow.IsDokNameNull Then 'IsDBNull(DokumenteBindingSource.Current("DokName")) Then ' 
                delDok = currRow.DokName
            Else
                delDok = ""
            End If
        Catch ex As Exception
            MsgBox("Es ist ein Fehler aufgetreten: " & vbCrLf & ex.Message)
            Exit Sub
        End Try

        If MsgBox("Wollen sie wirklich den ausgwählten Datensatz Löschen?", vbYesNo) = vbYes Then
            DokumenteBindingSource.RemoveCurrent()
        End If
        If Not String.IsNullOrWhiteSpace(delDok) Then
            If MsgBox("Soll auch das Dokument entfernt werden?", vbYesNo) = vbYes Then
                If FreeDMS_Aux.FreeDMS.Aux.IsFileInUse(ArchivOrdner & delDok) Then
                    MsgBox("Bitte Datei erst schließen!")
                    Exit Sub
                End If
                Try
                    Kill(ArchivOrdner & delDok)
                Catch ex As Exception
                    MsgBox("Dokument " & delDok & " konnte nicht gefunden werden!" & vbCrLf & "Ggf. manuell entfernen!" & vbCrLf & ex.Message)
                End Try

            End If
        End If
        DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)
        LoadAll()
        SetCurrDoc() 'DataGridVews mit Daten aus CurrDoc auwählen
    End Sub



#End Region
#Region "Mail"
    Private Sub CbProviderAuswahl_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbProviderAuswahl.SelectedIndexChanged
        If lblClose Then Exit Sub
        PanelMail.Visible = True
        For Each el In ProviderDataBase.Provider
            If el.id = CInt(CbProviderAuswahl.SelectedValue) Then   'Voreinstellung erforderlich
                host = el.Host
                user = el.User
                port = el.Port
                password = el.Password
                ssl = el.SSL
            End If
        Next
        UserTextBox1.Text = user
        HostTextBox1.Text = host
        TxtCounter.Visible = True
        Read_Emails()
    End Sub
    Private Sub Read_Emails()
        Cursor.Current = Cursors.WaitCursor
        GVEmails.Rows.Clear()
        allMessages.Clear()
        SelAttachments1.Clear()
        '  Me.Cursor = Cursors.WaitCursor
        Dim CurrPath As String = sAppPath & user & "-uids.txt"
        Dim seenUids As List(Of String) = TXT2ListOfString(CurrPath)
        Dim usedPath As String = sAppPath & user & "-useduids.txt"
        Dim usedUids As List(Of String) = TXT2ListOfString(usedPath)
        Dim pop3Client As Pop3Client
        pop3Client = New Pop3Client()
        Try
            pop3Client.Connect(host, port, ssl)
        Catch ex As Exception
            MsgBox(ex.Message, vbSystemModal)
            'MessageBox.Show(ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.None, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification, False)
            Exit Sub
        End Try

        If pop3Client.Connected = False Then
            TxtCounter.BackColor = Color.Red
        Else
            TxtCounter.BackColor = Color.LightGreen
            Try
                pop3Client.Authenticate(user, password, AuthenticationMethod.UsernameAndPassword)
            Catch ex As Exception
                MsgBox(ex.Message)
                Exit Sub
            End Try

            ' If ChbReset.Checked = True Then pop3Client.Reset()
            lblStatusMsg.Visible = True
            lblStatusMsg.Text = "Mails werden geladen...."
            Dim count As Integer = pop3Client.GetMessageCount()
            '  MsgBox(count)
            Dim startCount As Integer = 1
            ' MsgBox(cbMaxMails.SelectedItem.ToString()) ' & "Value " & cbMaxMails.SelectedValue.ToString) ' & " Index " & cbMaxMails.SelectedIndex.ToString)
            If count >= CInt(cbMaxMails.SelectedItem) Then startCount = count - CInt(cbMaxMails.SelectedItem) + 1 Else startCount = 1
            lblStatusMsg.Text = "Es wurden die neuesten " & CInt(cbMaxMails.SelectedItem) & " von " & count & " Mails abgerufen."

            'MsgBox(count & " - " & cbMaxMails.SelectedItem.ToString)
            Dim uids As List(Of String) = pop3Client.GetMessageUids()
            TxtCounter.Text = count.ToString
            TxtCounter.Update()
            Dim Email(4) As String, GvIndex As Integer = -1, message As Message
            For i As Integer = count To startCount Step -1
                Try
                    TxtCounter.Text = GvIndex + 2 & "/" & count
                    TxtCounter.Update()
                    Dim currentUidOnServer As String = uids(i - 1)
                    allMessages.Add(pop3Client.GetMessage(i))
                    message = pop3Client.GetMessage(i)

                    Email(4) = pop3Client.GetMessageUid(i)
                    'Email(8) = message.Headers.MessageId
                    Email(2) = message.Headers.Subject
                    Email(1) = message.Headers.DateSent.ToString

                    Dim attachments As List(Of MessagePart) = message.FindAllAttachments()
                    attachments = message.FindAllAttachments()
                    If attachments.Count = 0 Then
                        Email(3) = ""
                    Else
                        Email(3) = "ja"
                    End If

                    GVEmails.Rows.Add()
                    GvIndex = GvIndex + 1
                    If Not seenUids.Contains(Email(4)) Then
                        GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Bold) 'ForeColor = Color.Red
                    Else
                        GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Regular)
                    End If

                    'Schon übernommenen Mails kennzeichnen
                    If usedUids.Contains(Email(4)) Then
                        GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Strikeout) 'ForeColor = Color.Red
                    Else
                        ' GVEmails.Rows(GvIndex).DefaultCellStyle.Font = New Font(GVEmails.Font, FontStyle.Regular)
                    End If
                    'Liste bereinigen

                    GVEmails.Item(0, GvIndex).Value = Email(3) 'Anlagen
                    GVEmails.Item(1, GvIndex).Value = Email(1) 'Datum 
                    GVEmails.Item(2, GvIndex).Value = Email(2) 'Betreff
                    GVEmails.Item(3, GvIndex).Value = Email(4) 'uid
                Catch ex As Exception
                    MsgBox(ex.Message)
                End Try


            Next
            For Each id In usedUids
                If Not seenUids.Contains(id) Then
                    ' MsgBox("löschen") 'usedUid löschen
                    usedUids.Remove(id)
                    Exit For
                End If
            Next
            ListOfString2TXT(usedPath, usedUids)
            ListOfString2TXT(CurrPath, uids)
            pop3Client.Disconnect()
        End If
        Cursor = Cursors.Default

    End Sub
    ''' <summary>
    ''' Mailtext in ListOfString laden
    ''' </summary>
    ''' <param name="FullPath"></param>
    ''' <returns>lst</returns>
    Public Function TXT2ListOfString(ByVal FullPath As String) As List(Of String)
        Dim lst As New List(Of String)
        If IO.File.Exists(FullPath) Then lst.AddRange(IO.File.ReadAllLines(FullPath, System.Text.Encoding.Default))
        Return lst
    End Function
    ''' <summary>
    ''' List of String zu MailText
    ''' </summary>
    ''' <param name="FullPath"></param>
    ''' <param name="lst"></param>
    ''' <returns>True</returns>
    Public Function ListOfString2TXT(ByVal FullPath As String, ByVal lst As List(Of String)) As Boolean
        Dim f As New IO.FileInfo(FullPath)
        If f.Directory.Exists = True Then
            IO.File.WriteAllLines(FullPath, lst.ToArray, System.Text.Encoding.Default)
            Return True
        End If
        Return False
    End Function

    Private Sub GVEmails_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GVEmails.CellClick
        ' MsgBox(DGV.CurrentCell.RowIndex.ToString)
        Dim tmpTo As String = ""
        PanelMail.Visible = False
        PanelMailKopfDetail.Visible = True
        PanelAtt.Visible = False
        PictureBox1.Visible = False
        WebBrowser1.Visible = True
        lbAtt.Items.Clear()
        Dim ix As Integer = GVEmails.CurrentCell.RowIndex
        With allMessages.Item(ix)

            lblDate.Text = .Headers.DateSent.ToString
            lblSender.Text = .Headers.From.DisplayName.ToString
            ' lblTo.Text = .Headers.To.ToString
            If .Headers.To.Count > 0 Then
                tmpTo = tmpTo & "An: " '& vbCrLf
                For Each tomailaddress As OpenPop.Mime.Header.RfcMailAddress In .Headers.To
                    tmpTo = tmpTo & tomailaddress.Address & vbCrLf
                Next
            End If
            If .Headers.Cc.Count > 0 Then
                tmpTo = tmpTo & "CC: " '& vbCrLf
                For Each ccmailaddress As OpenPop.Mime.Header.RfcMailAddress In .Headers.Cc
                    tmpTo = tmpTo & ccmailaddress.Address & vbCrLf
                Next
            End If
            If .Headers.Bcc.Count > 0 Then
                tmpTo = tmpTo & "BCC: " '& vbCrLf
                For Each bccmailaddress As OpenPop.Mime.Header.RfcMailAddress In .Headers.Bcc
                    tmpTo = tmpTo & bccmailaddress.Address & vbCrLf
                Next
            End If
            lblTo.Text = tmpTo
            lblSubject.Text = .Headers.Subject.ToString
            Dim body As MessagePart = .FindFirstHtmlVersion()
            If body IsNot Nothing Then
                WebBrowser1.DocumentText = body.GetBodyAsText()
            Else
                body = .FindFirstPlainTextVersion()
                If body IsNot Nothing Then
                    WebBrowser1.DocumentText = body.GetBodyAsText()
                End If
            End If
        End With
        ' MsgBox(allMessages.Item(ix).Headers.Subject)
        SelAttachments1 = allMessages.Item(ix).FindAllAttachments()
        If SelAttachments1.Count > 0 Then
            PanelAtt.Visible = True

            For Each at In SelAttachments1
                lbAtt.Items.Add(at.FileName)
            Next
        Else
            PanelAtt.Visible = False
        End If
    End Sub

    Private Sub KompletteMailNachFreeDMSKopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KompletteMailNachFreeDMSKopierenToolStripMenuItem.Click
        MoveMail()
    End Sub
    ''' <summary>
    ''' Mail in den Input-Ordner verschieben
    ''' ListView ScanInput und ScanInputSave aktualisieren
    ''' </summary>
    Private Sub MoveMail()
        Dim ix As Integer = GVEmails.CurrentCell.RowIndex
        Dim xUID = GVEmails.Rows(GVEmails.CurrentRow.Index).Cells(3).Value.ToString 'UID der gespeicherten Mail
        ' Dim myFileNameUID As String = DelChr(allMessages.Item(ix).MessagePart)
        Dim myFileName As String = DelChr(allMessages.Item(ix).Headers.Subject.ToString)
        If System.IO.File.Exists(InputOrdner & myFileName & ".eml") Then
            If MessageBox.Show("Weiter (ja oder nein)", "Mail ist bereits im Eingangsordner vorhanden!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
        End If
        ' MsgBox(allMessages.Item(ix).Headers.Subject.ToString & vbCrLf & myFileName)
        Dim File As FileInfo = New FileInfo(InputOrdner & myFileName & ".eml")
        allMessages.Item(ix).Save(File)
        LoadLvDok(LvScanInput)
        LoadLvDok(LVMailInput)
        MessageBox.Show("Mail '" & myFileName & "' wurde in den Ordner " & InputOrdner & "kopiert.", "Free-DMS - Mail")
        ' LoadLvDok(lvScanInputSave)
        ''Als gespeichert kennzeichnen
        Dim usedPath As String = sAppPath & user & "-useduids.txt"
        Dim usedUids As List(Of String) = TXT2ListOfString(usedPath)
        Dim id As Integer
        id = usedUids.IndexOf(xUID)
        usedUids.Add(xUID)
        ListOfString2TXT(usedPath, usedUids)

    End Sub
    ''' <summary>
    ''' Hilfsfunktion umd unerlaubte Zeichen aus Dateinamen zu entfernen
    ''' </summary>
    ''' <param name="strSource"></param>
    ''' <returns>strTmp -> bereinigter Dateiname</returns>
    Function DelChr(strSource As String) As String
        Dim i As Integer
        Dim strTmp As String = ""

        If String.IsNullOrEmpty(strSource) Then
            Return strTmp
        End If
        For i = 1 To Len(strSource)
            Select Case Asc(Mid(strSource, i, 1))
                Case 48 To 57, 65 To 90, 97 To 122, 32
                    strTmp = strTmp & Mid(strSource, i, 1)
            End Select
        Next i
        Return strTmp
    End Function

    Private Sub MailAnsehenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailAnsehenToolStripMenuItem.Click

        Dim ix As Integer = GVEmails.CurrentCell.RowIndex
        Dim File As FileInfo = New FileInfo(tempPath & "temp.eml")
        allMessages.Item(ix).Save(File)
        Process.Start(tempPath & "temp.eml")
    End Sub

    ''' <summary>
    ''' FileDialog um Mails außerhalb von FreeDMS zu speichern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub MailSpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MailSpeichernToolStripMenuItem.Click
        Dim save As New SaveFileDialog
        Dim ix As Integer = GVEmails.CurrentCell.RowIndex

        With save
            .Title = "Mail Speichern"
            .InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            .Filter = "Mail|*.eml"
            .ShowDialog()
            If .FileName <> "" Then
                Dim File As FileInfo = New FileInfo(.FileName)
                allMessages.Item(ix).Save(File)
            End If
        End With
    End Sub

    ''' <summary>
    ''' Aufruf von Anlagen anzeigen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AnsehenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnsehenToolStripMenuItem.Click
        ShowAttachment()
    End Sub
    ''' <summary>
    ''' Anlagen anzeigen
    ''' </summary>
    Private Sub ShowAttachment()

        'TODO: Aufräumen beim Prpgramm schließen -> file.delete( Pfad\##*.*)
        '  ShowAttachment()
        Dim ix As Integer = lbAtt.SelectedIndex()
        If ix < 0 Then
            MsgBox("Bitte zunächst eine Anlage auswählen")
            Exit Sub
        End If
        Dim AttName As String = SelAttachments1(ix).FileName

        ' MsgBox(selAttachments(ix).Body.ToString)
        If WriteToFile(SelAttachments1(ix).Body, tempPath & AttName) Then
            Process.Start(tempPath & AttName)
        End If

    End Sub


    'Private Function WriteToFile(ByVal Source As Byte(), ByVal Filename As String) As Boolean
    '    Try
    '        My.Computer.FileSystem.WriteAllBytes(Filename, Source, False)
    '        If IO.File.Exists(Filename) Then
    '            Return True
    '        Else : Return False
    '        End If
    '    Catch ex As IO.IOException
    '        MessageBox.Show(ex.Message.ToString(), "IOException")
    '    Catch ex As Exception
    '        MessageBox.Show(ex.Message.ToString(), "Exception")
    '    End Try
    '    Return False
    'End Function
    ''' <summary>
    ''' Kopieren der Mail in den ScanInput-Ordner
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NachScanInputKopierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NachScanInputKopierenToolStripMenuItem.Click
        SaveAtt()
    End Sub
    Private Sub SaveAtt()
        Dim saveAtt As New SaveFileDialog
        Dim ix As Integer = lbAtt.SelectedIndex()
        If ix < 0 Then
            MsgBox("Bitte zunächst eine Anlage auswählen")
            Exit Sub
        End If
        Dim AttName As String = SelAttachments1(ix).FileName
        If System.IO.File.Exists(InputOrdner & AttName) Then
            If MessageBox.Show("Weiter (ja oder nein)", "Mail ist bereits im Eingangsordner vorhanden!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = vbNo Then Exit Sub
        End If
        Dim xUID = GVEmails.Rows(GVEmails.CurrentRow.Index).Cells(3).Value.ToString
        If Not WriteToFile(SelAttachments1(ix).Body, InputOrdner & AttName) Then
            MsgBox("Fehler beim Speichern!")
            Exit Sub
        End If
        LoadLvDok(LvScanInput)
        LoadLvDok(LVMailInput)
        MessageBox.Show("Anlage '" & AttName & "' gespeichert", "FreeDMS-Fx Mail-Anlagen")
        ''Als gespeichert kennzeichnen
        Dim usedPath As String = sAppPath & user & "-useduids.txt"
        Dim usedUids As List(Of String) = TXT2ListOfString(usedPath)
        'Dim id As Integer
        'id = usedUids.IndexOf(xUID)
        usedUids.Add(xUID)
        ListOfString2TXT(usedPath, usedUids)
    End Sub

    ''' <summary>
    ''' SaveFileDialog um Anhänge außerhalb von FreeDMS zu speichern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub ToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ToolStripMenuItem1.Click
        Dim saveAtt As New SaveFileDialog
        Dim ix As Integer = lbAtt.SelectedIndex()
        If ix < 0 Then
            MsgBox("Bitte zunächst eine Anlage auswählen")
            Exit Sub
        End If


        Dim AttName As String = SelAttachments1(ix).FileName
        With saveAtt
            .Title = "Anlage Speichern"

            ' .Filter = AttName
            .FileName = AttName
            .ShowDialog()

            If .FileName <> "" Then
                If WriteToFile(SelAttachments1(ix).Body, .FileName) Then

                End If

            End If
        End With
        ' MsgBox(selAttachments(ix).Body.ToString)
    End Sub






#End Region

End Class