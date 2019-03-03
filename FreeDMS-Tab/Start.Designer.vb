<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim AkteLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim AngelegtLabel As System.Windows.Forms.Label
        Dim ArchiviertLabel As System.Windows.Forms.Label
        Dim ArchivLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel1 As System.Windows.Forms.Label
        Dim HinweiseLabel As System.Windows.Forms.Label
        Dim BegonnenLabel As System.Windows.Forms.Label
        Dim BeendetLabel As System.Windows.Forms.Label
        Dim ArchivLabel1 As System.Windows.Forms.Label
        Dim MandantLabel1 As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
        Dim AbsenderLabel As System.Windows.Forms.Label
        Dim EmpfaengerLabel As System.Windows.Forms.Label
        Dim DokDatumLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DokNameLabel As System.Windows.Forms.Label
        Dim BearbVermerkLabel As System.Windows.Forms.Label
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel21 = New System.Windows.Forms.Panel()
        Me.DocNotizDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitelDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotizBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.lbNotizDok = New System.Windows.Forms.Label()
        Me.Panel10 = New System.Windows.Forms.Panel()
        Me.PanelSuche = New System.Windows.Forms.Panel()
        Me.btClear = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btSearcj = New System.Windows.Forms.Button()
        Me.ComboBoxSuche = New System.Windows.Forms.ComboBox()
        Me.TextSuche = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.CbAblageSuche = New System.Windows.Forms.ComboBox()
        Me.AblageBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbTypSuche = New System.Windows.Forms.ComboBox()
        Me.TypBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbStatusSuche = New System.Windows.Forms.ComboBox()
        Me.StatusBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.DokumenteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.LbEingangsKorb = New System.Windows.Forms.Label()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.AnlagenSQLDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AnlagenSQLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LbIstAnlage = New System.Windows.Forms.Label()
        Me.LbAnlagen = New System.Windows.Forms.Label()
        Me.PnlDokButton = New System.Windows.Forms.Panel()
        Me.btDocNotiz = New System.Windows.Forms.Button()
        Me.btShowDoc = New System.Windows.Forms.Button()
        Me.BtWiedervorlage = New System.Windows.Forms.Button()
        Me.BtPrint = New System.Windows.Forms.Button()
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenderTextBox = New System.Windows.Forms.TextBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BeendetTextBox = New System.Windows.Forms.TextBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BegonnenTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox1 = New System.Windows.Forms.TextBox()
        Me.IdTextBox1 = New System.Windows.Forms.TextBox()
        Me.ArchivCheckBox1 = New System.Windows.Forms.CheckBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.HinweiseTextBox = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArchiviertTextBox = New System.Windows.Forms.TextBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AngelegtTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox1 = New System.Windows.Forms.TextBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ArchivCheckBox = New System.Windows.Forms.CheckBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbAz = New System.Windows.Forms.Label()
        Me.lbVorgang = New System.Windows.Forms.Label()
        Me.lbAkte = New System.Windows.Forms.Label()
        Me.lbMandant = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lbAnzahl = New System.Windows.Forms.Label()
        Me.Panel19 = New System.Windows.Forms.Panel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.NotizDataGridView = New System.Windows.Forms.DataGridView()
        Me.erstellt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TitelDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NotizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanelSuchBack = New System.Windows.Forms.Panel()
        Me.PanelSuchErgeb = New System.Windows.Forms.Panel()
        Me.lblSuchErgebnis = New System.Windows.Forms.Label()
        Me.LvScanInput = New System.Windows.Forms.ListView()
        Me.ContextMenuStripInput = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnsehenToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel8 = New System.Windows.Forms.Panel()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WvdatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Wiedervorlage = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WiedervorlageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LblWv = New System.Windows.Forms.Label()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ImageList3 = New System.Windows.Forms.ImageList(Me.components)
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.GroupBoxAnzeige = New System.Windows.Forms.GroupBox()
        Me.RBOrdnerArchiv = New System.Windows.Forms.RadioButton()
        Me.RBAktenArchiv = New System.Windows.Forms.RadioButton()
        Me.RBAlles = New System.Windows.Forms.RadioButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel11 = New System.Windows.Forms.Panel()
        Me.lbStartEinstellung = New System.Windows.Forms.Label()
        Me.btRset = New System.Windows.Forms.Button()
        Me.cbMaxMails = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.lbMailListe = New System.Windows.Forms.Label()
        Me.Panel12 = New System.Windows.Forms.Panel()
        Me.lblStatusMsg = New System.Windows.Forms.Label()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.TxtCounter = New System.Windows.Forms.TextBox()
        Me.HostTextBox1 = New System.Windows.Forms.TextBox()
        Me.ProviderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProviderDataBase = New FreeDMS_Tab.ProviderDataBase()
        Me.UserTextBox1 = New System.Windows.Forms.TextBox()
        Me.lblPostfach = New System.Windows.Forms.Label()
        Me.CbProviderAuswahl = New System.Windows.Forms.ComboBox()
        Me.ProviderBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GVEmails = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripMail = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.KompletteMailNachFreeDMSKopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailAnsehenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MailSpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PanelMailKopf = New System.Windows.Forms.Panel()
        Me.PanelMail = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.PanelMailKopfDetail = New System.Windows.Forms.Panel()
        Me.lblSender = New System.Windows.Forms.Label()
        Me.lblSubject = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.lblTo = New System.Windows.Forms.Label()
        Me.Panel15 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.LVMailInput = New System.Windows.Forms.ListView()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.PanelAtt = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lbAtt = New System.Windows.Forms.ListBox()
        Me.ContextMenuStripAttach = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnsehenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NachScanInputKopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.DokumenteSQLDataGridView = New System.Windows.Forms.DataGridView()
        Me.DokDatumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DokumentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BetreffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MandantDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AkteDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VorgangDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AblageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DokumenteSQLBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel13 = New System.Windows.Forms.Panel()
        Me.Panel14 = New System.Windows.Forms.Panel()
        Me.LbInfo = New System.Windows.Forms.Label()
        Me.LbJournalCount = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeitenansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RückgängigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WiederholenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnschriftenAusDokÜbernehmenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageNachPDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ArchivierteVorgängeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MandantenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AktenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VorgängeOrdnerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokumenteToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator12 = New System.Windows.Forms.ToolStripSeparator()
        Me.AnschriftenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AblageToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DokArtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator9 = New System.Windows.Forms.ToolStripSeparator()
        Me.VorlagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WiedervorlagenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NotizenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InhaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TestFormToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonExit = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton9 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator14 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonScan = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator13 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton12 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonScanInput = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton14 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonMandanten = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonAkten = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonVorgaenge = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDokumente = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator11 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonWv = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonNoteNeu = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonVorlagen = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator15 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonDatSuche = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonSchnellSuche = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator8 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButtonDelDoc = New System.Windows.Forms.ToolStripButton()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BGWRefresh = New System.ComponentModel.BackgroundWorker()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.NotizTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.VorlagenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter()
        Me.WiedervorlageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.wiedervorlageTableAdapter()
        Me.MandantAktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokumenteBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokumenteSQLTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteSQLTableAdapter()
        Me.SqlVorgangAkteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlVorgangAkteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.sqlVorgangAkteTableAdapter()
        Me.VorlagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MandantBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AktenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgaengeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnschriftenBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokumenteBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnlagenSQLTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnlagenSQLTableAdapter()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ContextMenuStripTVOrdner = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AkteAnsehenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuerOrdnerZurAkteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        AkteLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        AngelegtLabel = New System.Windows.Forms.Label()
        ArchiviertLabel = New System.Windows.Forms.Label()
        ArchivLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        BeschreibungLabel1 = New System.Windows.Forms.Label()
        HinweiseLabel = New System.Windows.Forms.Label()
        BegonnenLabel = New System.Windows.Forms.Label()
        BeendetLabel = New System.Windows.Forms.Label()
        ArchivLabel1 = New System.Windows.Forms.Label()
        MandantLabel1 = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
        AbsenderLabel = New System.Windows.Forms.Label()
        EmpfaengerLabel = New System.Windows.Forms.Label()
        DokDatumLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DokNameLabel = New System.Windows.Forms.Label()
        BearbVermerkLabel = New System.Windows.Forms.Label()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel21.SuspendLayout()
        CType(Me.DocNotizDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotizBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel10.SuspendLayout()
        Me.PanelSuche.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.AblageBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.AnlagenSQLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnlagenSQLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDokButton.SuspendLayout()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel19.SuspendLayout()
        CType(Me.NotizDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelSuchBack.SuspendLayout()
        Me.PanelSuchErgeb.SuspendLayout()
        Me.ContextMenuStripInput.SuspendLayout()
        Me.Panel8.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WiedervorlageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.GroupBoxAnzeige.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.Panel11.SuspendLayout()
        Me.Panel12.SuspendLayout()
        CType(Me.ProviderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProviderDataBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProviderBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVEmails, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripMail.SuspendLayout()
        Me.PanelMailKopf.SuspendLayout()
        Me.PanelMail.SuspendLayout()
        Me.PanelMailKopfDetail.SuspendLayout()
        Me.Panel15.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanelAtt.SuspendLayout()
        Me.ContextMenuStripAttach.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.DokumenteSQLDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteSQLBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel14.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.MandantAktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SqlVorgangAkteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripTVOrdner.SuspendLayout()
        Me.SuspendLayout()
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AkteLabel.Location = New System.Drawing.Point(4, 49)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(37, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'BeschreibungLabel
        '
        BeschreibungLabel.AutoSize = True
        BeschreibungLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BeschreibungLabel.Location = New System.Drawing.Point(4, 92)
        BeschreibungLabel.Name = "BeschreibungLabel"
        BeschreibungLabel.Size = New System.Drawing.Size(88, 13)
        BeschreibungLabel.TabIndex = 6
        BeschreibungLabel.Text = "Beschreibung:"
        '
        'AngelegtLabel
        '
        AngelegtLabel.AutoSize = True
        AngelegtLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AngelegtLabel.Location = New System.Drawing.Point(4, 170)
        AngelegtLabel.Name = "AngelegtLabel"
        AngelegtLabel.Size = New System.Drawing.Size(61, 13)
        AngelegtLabel.TabIndex = 8
        AngelegtLabel.Text = "Angelegt:"
        '
        'ArchiviertLabel
        '
        ArchiviertLabel.AutoSize = True
        ArchiviertLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArchiviertLabel.Location = New System.Drawing.Point(4, 209)
        ArchiviertLabel.Name = "ArchiviertLabel"
        ArchiviertLabel.Size = New System.Drawing.Size(65, 13)
        ArchiviertLabel.TabIndex = 10
        ArchiviertLabel.Text = "Archiviert:"
        '
        'ArchivLabel
        '
        ArchivLabel.AutoSize = True
        ArchivLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArchivLabel.Location = New System.Drawing.Point(4, 248)
        ArchivLabel.Name = "ArchivLabel"
        ArchivLabel.Size = New System.Drawing.Size(47, 13)
        ArchivLabel.TabIndex = 12
        ArchivLabel.Text = "Archiv:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VorgangLabel.Location = New System.Drawing.Point(3, 6)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(58, 13)
        VorgangLabel.TabIndex = 4
        VorgangLabel.Text = "Vorgang:"
        '
        'BeschreibungLabel1
        '
        BeschreibungLabel1.AutoSize = True
        BeschreibungLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BeschreibungLabel1.Location = New System.Drawing.Point(3, 49)
        BeschreibungLabel1.Name = "BeschreibungLabel1"
        BeschreibungLabel1.Size = New System.Drawing.Size(88, 13)
        BeschreibungLabel1.TabIndex = 6
        BeschreibungLabel1.Text = "Beschreibung:"
        '
        'HinweiseLabel
        '
        HinweiseLabel.AutoSize = True
        HinweiseLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        HinweiseLabel.Location = New System.Drawing.Point(3, 123)
        HinweiseLabel.Name = "HinweiseLabel"
        HinweiseLabel.Size = New System.Drawing.Size(62, 13)
        HinweiseLabel.TabIndex = 8
        HinweiseLabel.Text = "Hinweise:"
        '
        'BegonnenLabel
        '
        BegonnenLabel.AutoSize = True
        BegonnenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BegonnenLabel.Location = New System.Drawing.Point(3, 170)
        BegonnenLabel.Name = "BegonnenLabel"
        BegonnenLabel.Size = New System.Drawing.Size(68, 13)
        BegonnenLabel.TabIndex = 10
        BegonnenLabel.Text = "Begonnen:"
        '
        'BeendetLabel
        '
        BeendetLabel.AutoSize = True
        BeendetLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BeendetLabel.Location = New System.Drawing.Point(3, 209)
        BeendetLabel.Name = "BeendetLabel"
        BeendetLabel.Size = New System.Drawing.Size(58, 13)
        BeendetLabel.TabIndex = 14
        BeendetLabel.Text = "Beendet:"
        '
        'ArchivLabel1
        '
        ArchivLabel1.AutoSize = True
        ArchivLabel1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ArchivLabel1.Location = New System.Drawing.Point(3, 254)
        ArchivLabel1.Name = "ArchivLabel1"
        ArchivLabel1.Size = New System.Drawing.Size(47, 13)
        ArchivLabel1.TabIndex = 16
        ArchivLabel1.Text = "Archiv:"
        '
        'MandantLabel1
        '
        MandantLabel1.AutoSize = True
        MandantLabel1.Location = New System.Drawing.Point(4, 6)
        MandantLabel1.Name = "MandantLabel1"
        MandantLabel1.Size = New System.Drawing.Size(54, 13)
        MandantLabel1.TabIndex = 14
        MandantLabel1.Text = "Bereich:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(36, 8)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(68, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(55, 31)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(49, 13)
        BetreffLabel.TabIndex = 10
        BetreffLabel.Text = "Betreff:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(56, 62)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(48, 13)
        BetragLabel.TabIndex = 12
        BetragLabel.Text = "Betrag:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(40, 122)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(64, 13)
        AbsenderLabel.TabIndex = 16
        AbsenderLabel.Text = "Absender:"
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Location = New System.Drawing.Point(26, 148)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(78, 13)
        EmpfaengerLabel.TabIndex = 18
        EmpfaengerLabel.Text = "Empfaenger:"
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(30, 175)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(74, 13)
        DokDatumLabel.TabIndex = 20
        DokDatumLabel.Text = "Dok Datum:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(31, 203)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(73, 13)
        KommentarLabel.TabIndex = 26
        KommentarLabel.Text = "Kommentar:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(232, 88)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(50, 13)
        AblageLabel.TabIndex = 30
        AblageLabel.Text = "Ablage:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(250, 62)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(32, 13)
        TypLabel.TabIndex = 32
        TypLabel.Text = "Typ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(57, 88)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(47, 13)
        StatusLabel.TabIndex = 34
        StatusLabel.Text = "Status:"
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Location = New System.Drawing.Point(212, 177)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(70, 13)
        DokNameLabel.TabIndex = 36
        DokNameLabel.Text = "Dok Name:"
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Location = New System.Drawing.Point(9, 255)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(94, 13)
        BearbVermerkLabel.TabIndex = 42
        BearbVermerkLabel.Text = "Bearb Vermerk:"
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(1490, 832)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(1490, 907)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TabControl1.ItemSize = New System.Drawing.Size(123, 32)
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1490, 832)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.TableLayoutPanel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 36)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1482, 792)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dokumente Verwaltung"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.TableLayoutPanel1.ColumnCount = 6
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 175.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 450.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel21, 4, 5)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel10, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.DokumenteDataGridView, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 4, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 4, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel19, 2, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelSuchBack, 5, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TreeView1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel8, 5, 4)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 5, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.LvScanInput, 5, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 8
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 75.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 78.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 70.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 122.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1476, 786)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel21
        '
        Me.Panel21.AutoScroll = True
        Me.Panel21.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel21.Controls.Add(Me.DocNotizDataGridView)
        Me.Panel21.Controls.Add(Me.lbNotizDok)
        Me.Panel21.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel21.Location = New System.Drawing.Point(743, 618)
        Me.Panel21.Name = "Panel21"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel21, 2)
        Me.Panel21.Size = New System.Drawing.Size(444, 144)
        Me.Panel21.TabIndex = 34
        '
        'DocNotizDataGridView
        '
        Me.DocNotizDataGridView.AllowUserToAddRows = False
        Me.DocNotizDataGridView.AutoGenerateColumns = False
        Me.DocNotizDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DocNotizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DocNotizDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.TitelDataGridViewTextBoxColumn1})
        Me.DocNotizDataGridView.DataSource = Me.NotizBindingSource1
        Me.DocNotizDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DocNotizDataGridView.Location = New System.Drawing.Point(0, 26)
        Me.DocNotizDataGridView.MultiSelect = False
        Me.DocNotizDataGridView.Name = "DocNotizDataGridView"
        Me.DocNotizDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DocNotizDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle2
        Me.DocNotizDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DocNotizDataGridView.Size = New System.Drawing.Size(444, 118)
        Me.DocNotizDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "erstellt"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn1.HeaderText = "Vom"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ToolTipText = "Maus-Klick für Details"
        Me.DataGridViewTextBoxColumn1.Width = 56
        '
        'TitelDataGridViewTextBoxColumn1
        '
        Me.TitelDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitelDataGridViewTextBoxColumn1.DataPropertyName = "titel"
        Me.TitelDataGridViewTextBoxColumn1.HeaderText = "Notiz (kurz)"
        Me.TitelDataGridViewTextBoxColumn1.Name = "TitelDataGridViewTextBoxColumn1"
        '
        'NotizBindingSource1
        '
        Me.NotizBindingSource1.DataMember = "notiz"
        Me.NotizBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'lbNotizDok
        '
        Me.lbNotizDok.AutoSize = True
        Me.lbNotizDok.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbNotizDok.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lbNotizDok.Location = New System.Drawing.Point(4, 6)
        Me.lbNotizDok.Name = "lbNotizDok"
        Me.lbNotizDok.Size = New System.Drawing.Size(137, 13)
        Me.lbNotizDok.TabIndex = 0
        Me.lbNotizDok.Text = "Notizen zum Dokument"
        '
        'Panel10
        '
        Me.Panel10.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel10, 4)
        Me.Panel10.Controls.Add(Me.PanelSuche)
        Me.Panel10.Controls.Add(Me.Label6)
        Me.Panel10.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel10.Location = New System.Drawing.Point(178, 3)
        Me.Panel10.Name = "Panel10"
        Me.Panel10.Size = New System.Drawing.Size(1009, 69)
        Me.Panel10.TabIndex = 29
        '
        'PanelSuche
        '
        Me.PanelSuche.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelSuche.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelSuche.Controls.Add(Me.btClear)
        Me.PanelSuche.Controls.Add(Me.GroupBox2)
        Me.PanelSuche.Controls.Add(Me.GroupBox1)
        Me.PanelSuche.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSuche.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuche.Name = "PanelSuche"
        Me.PanelSuche.Size = New System.Drawing.Size(1007, 67)
        Me.PanelSuche.TabIndex = 26
        '
        'btClear
        '
        Me.btClear.Location = New System.Drawing.Point(945, 22)
        Me.btClear.Name = "btClear"
        Me.btClear.Size = New System.Drawing.Size(77, 33)
        Me.btClear.TabIndex = 32
        Me.btClear.Text = "Clear"
        Me.btClear.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btSearcj)
        Me.GroupBox2.Controls.Add(Me.ComboBoxSuche)
        Me.GroupBox2.Controls.Add(Me.TextSuche)
        Me.GroupBox2.Location = New System.Drawing.Point(5, 9)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(422, 51)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Suche in Feldern"
        '
        'btSearcj
        '
        Me.btSearcj.Location = New System.Drawing.Point(320, 10)
        Me.btSearcj.Name = "btSearcj"
        Me.btSearcj.Size = New System.Drawing.Size(77, 33)
        Me.btSearcj.TabIndex = 31
        Me.btSearcj.Text = "Suchen "
        Me.btSearcj.UseVisualStyleBackColor = True
        '
        'ComboBoxSuche
        '
        Me.ComboBoxSuche.FormattingEnabled = True
        Me.ComboBoxSuche.Location = New System.Drawing.Point(151, 17)
        Me.ComboBoxSuche.Name = "ComboBoxSuche"
        Me.ComboBoxSuche.Size = New System.Drawing.Size(163, 21)
        Me.ComboBoxSuche.TabIndex = 36
        '
        'TextSuche
        '
        Me.TextSuche.Location = New System.Drawing.Point(8, 17)
        Me.TextSuche.Name = "TextSuche"
        Me.TextSuche.Size = New System.Drawing.Size(141, 20)
        Me.TextSuche.TabIndex = 35
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.CbAblageSuche)
        Me.GroupBox1.Controls.Add(Me.CbTypSuche)
        Me.GroupBox1.Controls.Add(Me.CbStatusSuche)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Location = New System.Drawing.Point(433, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(506, 50)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Schnellsuche"
        '
        'CbAblageSuche
        '
        Me.CbAblageSuche.DataSource = Me.AblageBindingSource1
        Me.CbAblageSuche.DisplayMember = "Ablage"
        Me.CbAblageSuche.FormattingEnabled = True
        Me.CbAblageSuche.Location = New System.Drawing.Point(388, 19)
        Me.CbAblageSuche.Name = "CbAblageSuche"
        Me.CbAblageSuche.Size = New System.Drawing.Size(108, 21)
        Me.CbAblageSuche.TabIndex = 43
        Me.CbAblageSuche.ValueMember = "Nummer"
        '
        'AblageBindingSource1
        '
        Me.AblageBindingSource1.DataMember = "Ablage"
        Me.AblageBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbTypSuche
        '
        Me.CbTypSuche.DataSource = Me.TypBindingSource1
        Me.CbTypSuche.DisplayMember = "Typ"
        Me.CbTypSuche.FormattingEnabled = True
        Me.CbTypSuche.Location = New System.Drawing.Point(219, 19)
        Me.CbTypSuche.Name = "CbTypSuche"
        Me.CbTypSuche.Size = New System.Drawing.Size(105, 21)
        Me.CbTypSuche.TabIndex = 42
        Me.CbTypSuche.ValueMember = "id"
        '
        'TypBindingSource1
        '
        Me.TypBindingSource1.DataMember = "Typ"
        Me.TypBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbStatusSuche
        '
        Me.CbStatusSuche.DataSource = Me.StatusBindingSource1
        Me.CbStatusSuche.DisplayMember = "Status"
        Me.CbStatusSuche.FormattingEnabled = True
        Me.CbStatusSuche.Location = New System.Drawing.Point(67, 19)
        Me.CbStatusSuche.Name = "CbStatusSuche"
        Me.CbStatusSuche.Size = New System.Drawing.Size(105, 21)
        Me.CbStatusSuche.TabIndex = 41
        Me.CbStatusSuche.ValueMember = "id"
        '
        'StatusBindingSource1
        '
        Me.StatusBindingSource1.DataMember = "Status"
        Me.StatusBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(336, 22)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(46, 13)
        Me.Label9.TabIndex = 40
        Me.Label9.Text = "Ablage"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(185, 22)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 39
        Me.Label8.Text = "Typ"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 13)
        Me.Label7.TabIndex = 38
        Me.Label7.Text = "Status"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(46, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Suchen"
        '
        'DokumenteDataGridView
        '
        Me.DokumenteDataGridView.AllowUserToAddRows = False
        Me.DokumenteDataGridView.AllowUserToDeleteRows = False
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DokumenteDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle3
        Me.DokumenteDataGridView.AutoGenerateColumns = False
        Me.DokumenteDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DokumenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DokumenteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.TableLayoutPanel1.SetColumnSpan(Me.DokumenteDataGridView, 2)
        Me.DokumenteDataGridView.DataSource = Me.DokumenteBindingSource
        Me.DokumenteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DokumenteDataGridView.Location = New System.Drawing.Point(353, 78)
        Me.DokumenteDataGridView.MultiSelect = False
        Me.DokumenteDataGridView.Name = "DokumenteDataGridView"
        Me.DokumenteDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokumenteDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle5
        Me.TableLayoutPanel1.SetRowSpan(Me.DokumenteDataGridView, 3)
        Me.DokumenteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DokumenteDataGridView.Size = New System.Drawing.Size(384, 413)
        Me.DokumenteDataGridView.TabIndex = 36
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn2.HeaderText = "id"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Visible = False
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "DokDatum"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn12.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn12.HeaderText = "Dok.Datum"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.Width = 95
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Dokument"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Dokument"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 89
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Betreff"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Betreff"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'Panel7
        '
        Me.Panel7.BackColor = System.Drawing.Color.Moccasin
        Me.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel7.Controls.Add(Me.LbEingangsKorb)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(1193, 78)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(280, 72)
        Me.Panel7.TabIndex = 35
        '
        'LbEingangsKorb
        '
        Me.LbEingangsKorb.AutoSize = True
        Me.LbEingangsKorb.Location = New System.Drawing.Point(5, 12)
        Me.LbEingangsKorb.Name = "LbEingangsKorb"
        Me.LbEingangsKorb.Size = New System.Drawing.Size(88, 13)
        Me.LbEingangsKorb.TabIndex = 0
        Me.LbEingangsKorb.Text = "Eingangskorb:"
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel5.Controls.Add(Me.AnlagenSQLDataGridView)
        Me.Panel5.Controls.Add(Me.LbIstAnlage)
        Me.Panel5.Controls.Add(Me.LbAnlagen)
        Me.Panel5.Controls.Add(Me.PnlDokButton)
        Me.Panel5.Controls.Add(Me.DokDatumTextBox)
        Me.Panel5.Controls.Add(DokumentLabel)
        Me.Panel5.Controls.Add(Me.DokumentTextBox)
        Me.Panel5.Controls.Add(BetreffLabel)
        Me.Panel5.Controls.Add(Me.BetreffTextBox)
        Me.Panel5.Controls.Add(BetragLabel)
        Me.Panel5.Controls.Add(Me.BetragTextBox)
        Me.Panel5.Controls.Add(AbsenderLabel)
        Me.Panel5.Controls.Add(Me.AbsenderTextBox)
        Me.Panel5.Controls.Add(EmpfaengerLabel)
        Me.Panel5.Controls.Add(Me.EmpfaengerTextBox)
        Me.Panel5.Controls.Add(DokDatumLabel)
        Me.Panel5.Controls.Add(KommentarLabel)
        Me.Panel5.Controls.Add(Me.KommentarTextBox)
        Me.Panel5.Controls.Add(AblageLabel)
        Me.Panel5.Controls.Add(Me.AblageTextBox)
        Me.Panel5.Controls.Add(TypLabel)
        Me.Panel5.Controls.Add(Me.TypTextBox)
        Me.Panel5.Controls.Add(StatusLabel)
        Me.Panel5.Controls.Add(Me.StatusTextBox)
        Me.Panel5.Controls.Add(DokNameLabel)
        Me.Panel5.Controls.Add(Me.DokNameTextBox)
        Me.Panel5.Controls.Add(BearbVermerkLabel)
        Me.Panel5.Controls.Add(Me.BearbVermerkTextBox)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(743, 156)
        Me.Panel5.Name = "Panel5"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel5, 3)
        Me.Panel5.Size = New System.Drawing.Size(444, 456)
        Me.Panel5.TabIndex = 6
        '
        'AnlagenSQLDataGridView
        '
        Me.AnlagenSQLDataGridView.AllowUserToAddRows = False
        Me.AnlagenSQLDataGridView.AllowUserToDeleteRows = False
        Me.AnlagenSQLDataGridView.AutoGenerateColumns = False
        Me.AnlagenSQLDataGridView.BackgroundColor = System.Drawing.SystemColors.Control
        Me.AnlagenSQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnlagenSQLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn14})
        Me.AnlagenSQLDataGridView.DataSource = Me.AnlagenSQLBindingSource
        Me.AnlagenSQLDataGridView.Location = New System.Drawing.Point(34, 328)
        Me.AnlagenSQLDataGridView.Name = "AnlagenSQLDataGridView"
        Me.AnlagenSQLDataGridView.ReadOnly = True
        Me.AnlagenSQLDataGridView.RowHeadersVisible = False
        Me.AnlagenSQLDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AnlagenSQLDataGridView.Size = New System.Drawing.Size(366, 127)
        Me.AnlagenSQLDataGridView.TabIndex = 82
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Dokument"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Dokument"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.ReadOnly = True
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "DokDatum"
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn14.DefaultCellStyle = DataGridViewCellStyle6
        Me.DataGridViewTextBoxColumn14.HeaderText = "DokDatum"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        Me.DataGridViewTextBoxColumn14.Width = 91
        '
        'AnlagenSQLBindingSource
        '
        Me.AnlagenSQLBindingSource.DataMember = "AnlagenSQL"
        Me.AnlagenSQLBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'LbIstAnlage
        '
        Me.LbIstAnlage.AutoSize = True
        Me.LbIstAnlage.Location = New System.Drawing.Point(55, 284)
        Me.LbIstAnlage.Name = "LbIstAnlage"
        Me.LbIstAnlage.Size = New System.Drawing.Size(60, 13)
        Me.LbIstAnlage.TabIndex = 82
        Me.LbIstAnlage.Text = "IstAnlage"
        '
        'LbAnlagen
        '
        Me.LbAnlagen.AutoSize = True
        Me.LbAnlagen.Location = New System.Drawing.Point(36, 307)
        Me.LbAnlagen.Name = "LbAnlagen"
        Me.LbAnlagen.Size = New System.Drawing.Size(65, 13)
        Me.LbAnlagen.TabIndex = 81
        Me.LbAnlagen.Text = "Anlage(n):"
        '
        'PnlDokButton
        '
        Me.PnlDokButton.Controls.Add(Me.btDocNotiz)
        Me.PnlDokButton.Controls.Add(Me.btShowDoc)
        Me.PnlDokButton.Controls.Add(Me.BtWiedervorlage)
        Me.PnlDokButton.Controls.Add(Me.BtPrint)
        Me.PnlDokButton.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnlDokButton.Location = New System.Drawing.Point(0, 455)
        Me.PnlDokButton.Name = "PnlDokButton"
        Me.PnlDokButton.Size = New System.Drawing.Size(425, 55)
        Me.PnlDokButton.TabIndex = 80
        '
        'btDocNotiz
        '
        Me.btDocNotiz.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.btDocNotiz.Location = New System.Drawing.Point(172, 32)
        Me.btDocNotiz.Name = "btDocNotiz"
        Me.btDocNotiz.Size = New System.Drawing.Size(98, 23)
        Me.btDocNotiz.TabIndex = 78
        Me.btDocNotiz.Text = "Neue Notiz"
        Me.btDocNotiz.UseVisualStyleBackColor = True
        '
        'btShowDoc
        '
        Me.btShowDoc.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btShowDoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btShowDoc.Location = New System.Drawing.Point(70, 3)
        Me.btShowDoc.Name = "btShowDoc"
        Me.btShowDoc.Size = New System.Drawing.Size(281, 23)
        Me.btShowDoc.TabIndex = 75
        Me.btShowDoc.Text = "Ansehen/Ändern"
        Me.btShowDoc.UseVisualStyleBackColor = True
        '
        'BtWiedervorlage
        '
        Me.BtWiedervorlage.Location = New System.Drawing.Point(3, 32)
        Me.BtWiedervorlage.Name = "BtWiedervorlage"
        Me.BtWiedervorlage.Size = New System.Drawing.Size(98, 23)
        Me.BtWiedervorlage.TabIndex = 76
        Me.BtWiedervorlage.Text = "Wiedervorlage"
        Me.BtWiedervorlage.UseVisualStyleBackColor = True
        '
        'BtPrint
        '
        Me.BtPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtPrint.Location = New System.Drawing.Point(341, 32)
        Me.BtPrint.Name = "BtPrint"
        Me.BtPrint.Size = New System.Drawing.Size(98, 23)
        Me.BtPrint.TabIndex = 77
        Me.BtPrint.Text = "Drucken"
        Me.BtPrint.UseVisualStyleBackColor = True
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(110, 174)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.ReadOnly = True
        Me.DokDatumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokDatumTextBox.TabIndex = 44
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokumentTextBox.Location = New System.Drawing.Point(110, 5)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.ReadOnly = True
        Me.DokumentTextBox.Size = New System.Drawing.Size(291, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetreffTextBox.Location = New System.Drawing.Point(110, 31)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.ReadOnly = True
        Me.BetreffTextBox.Size = New System.Drawing.Size(291, 20)
        Me.BetreffTextBox.TabIndex = 11
        '
        'BetragTextBox
        '
        Me.BetragTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetragTextBox.Location = New System.Drawing.Point(110, 62)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.ReadOnly = True
        Me.BetragTextBox.Size = New System.Drawing.Size(113, 20)
        Me.BetragTextBox.TabIndex = 13
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Name_", True))
        Me.AbsenderTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(110, 122)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.ReadOnly = True
        Me.AbsenderTextBox.Size = New System.Drawing.Size(291, 20)
        Me.AbsenderTextBox.TabIndex = 17
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource1, "Name_", True))
        Me.EmpfaengerTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(110, 148)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.ReadOnly = True
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(291, 20)
        Me.EmpfaengerTextBox.TabIndex = 19
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KommentarTextBox.Location = New System.Drawing.Point(110, 203)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.ReadOnly = True
        Me.KommentarTextBox.Size = New System.Drawing.Size(291, 46)
        Me.KommentarTextBox.TabIndex = 27
        '
        'AblageTextBox
        '
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Ablage", True))
        Me.AblageTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AblageTextBox.Location = New System.Drawing.Point(287, 85)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.ReadOnly = True
        Me.AblageTextBox.Size = New System.Drawing.Size(113, 20)
        Me.AblageTextBox.TabIndex = 31
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Typ", True))
        Me.TypTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TypTextBox.Location = New System.Drawing.Point(287, 59)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.ReadOnly = True
        Me.TypTextBox.Size = New System.Drawing.Size(113, 20)
        Me.TypTextBox.TabIndex = 33
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Status", True))
        Me.StatusTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StatusTextBox.Location = New System.Drawing.Point(110, 88)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(113, 20)
        Me.StatusTextBox.TabIndex = 35
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokNameTextBox.Location = New System.Drawing.Point(288, 174)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.ReadOnly = True
        Me.DokNameTextBox.Size = New System.Drawing.Size(113, 20)
        Me.DokNameTextBox.TabIndex = 37
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.BearbVermerkTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(109, 255)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.ReadOnly = True
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(291, 20)
        Me.BearbVermerkTextBox.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.BeendetTextBox)
        Me.Panel2.Controls.Add(Me.BegonnenTextBox)
        Me.Panel2.Controls.Add(Me.BeschreibungTextBox1)
        Me.Panel2.Controls.Add(Me.IdTextBox1)
        Me.Panel2.Controls.Add(Me.ArchivCheckBox1)
        Me.Panel2.Controls.Add(ArchivLabel1)
        Me.Panel2.Controls.Add(VorgangLabel)
        Me.Panel2.Controls.Add(BeendetLabel)
        Me.Panel2.Controls.Add(Me.VorgangTextBox)
        Me.Panel2.Controls.Add(BeschreibungLabel1)
        Me.Panel2.Controls.Add(HinweiseLabel)
        Me.Panel2.Controls.Add(BegonnenLabel)
        Me.Panel2.Controls.Add(Me.HinweiseTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(178, 497)
        Me.Panel2.Name = "Panel2"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel2, 3)
        Me.Panel2.Size = New System.Drawing.Size(169, 265)
        Me.Panel2.TabIndex = 3
        '
        'BeendetTextBox
        '
        Me.BeendetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Beendet", True))
        Me.BeendetTextBox.Location = New System.Drawing.Point(3, 225)
        Me.BeendetTextBox.Name = "BeendetTextBox"
        Me.BeendetTextBox.Size = New System.Drawing.Size(154, 20)
        Me.BeendetTextBox.TabIndex = 19
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'BegonnenTextBox
        '
        Me.BegonnenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Begonnen", True))
        Me.BegonnenTextBox.Location = New System.Drawing.Point(3, 186)
        Me.BegonnenTextBox.Name = "BegonnenTextBox"
        Me.BegonnenTextBox.Size = New System.Drawing.Size(154, 20)
        Me.BegonnenTextBox.TabIndex = 18
        '
        'BeschreibungTextBox1
        '
        Me.BeschreibungTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeschreibungTextBox1.Location = New System.Drawing.Point(3, 65)
        Me.BeschreibungTextBox1.Multiline = True
        Me.BeschreibungTextBox1.Name = "BeschreibungTextBox1"
        Me.BeschreibungTextBox1.Size = New System.Drawing.Size(156, 52)
        Me.BeschreibungTextBox1.TabIndex = 7
        '
        'IdTextBox1
        '
        Me.IdTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "id", True))
        Me.IdTextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox1.Location = New System.Drawing.Point(3, 20)
        Me.IdTextBox1.Name = "IdTextBox1"
        Me.IdTextBox1.Size = New System.Drawing.Size(35, 20)
        Me.IdTextBox1.TabIndex = 1
        '
        'ArchivCheckBox1
        '
        Me.ArchivCheckBox1.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.VorgaengeBindingSource, "Archiv", True))
        Me.ArchivCheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivCheckBox1.Location = New System.Drawing.Point(64, 249)
        Me.ArchivCheckBox1.Name = "ArchivCheckBox1"
        Me.ArchivCheckBox1.Size = New System.Drawing.Size(14, 24)
        Me.ArchivCheckBox1.TabIndex = 17
        Me.ArchivCheckBox1.UseVisualStyleBackColor = True
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VorgangTextBox.Location = New System.Drawing.Point(44, 20)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(115, 20)
        Me.VorgangTextBox.TabIndex = 5
        '
        'HinweiseTextBox
        '
        Me.HinweiseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Hinweise", True))
        Me.HinweiseTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HinweiseTextBox.Location = New System.Drawing.Point(3, 140)
        Me.HinweiseTextBox.Name = "HinweiseTextBox"
        Me.HinweiseTextBox.Size = New System.Drawing.Size(154, 20)
        Me.HinweiseTextBox.TabIndex = 9
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.ArchiviertTextBox)
        Me.Panel1.Controls.Add(Me.AngelegtTextBox)
        Me.Panel1.Controls.Add(MandantLabel1)
        Me.Panel1.Controls.Add(Me.MandantTextBox1)
        Me.Panel1.Controls.Add(Me.BeschreibungTextBox)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Me.ArchivCheckBox)
        Me.Panel1.Controls.Add(ArchivLabel)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(ArchiviertLabel)
        Me.Panel1.Controls.Add(Me.AkteTextBox)
        Me.Panel1.Controls.Add(BeschreibungLabel)
        Me.Panel1.Controls.Add(AngelegtLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 497)
        Me.Panel1.Name = "Panel1"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel1, 3)
        Me.Panel1.Size = New System.Drawing.Size(169, 265)
        Me.Panel1.TabIndex = 0
        '
        'ArchiviertTextBox
        '
        Me.ArchiviertTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Archiviert", True))
        Me.ArchiviertTextBox.Location = New System.Drawing.Point(4, 225)
        Me.ArchiviertTextBox.Name = "ArchiviertTextBox"
        Me.ArchiviertTextBox.Size = New System.Drawing.Size(151, 20)
        Me.ArchiviertTextBox.TabIndex = 17
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AngelegtTextBox
        '
        Me.AngelegtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Angelegt", True))
        Me.AngelegtTextBox.Location = New System.Drawing.Point(4, 186)
        Me.AngelegtTextBox.Name = "AngelegtTextBox"
        Me.AngelegtTextBox.Size = New System.Drawing.Size(162, 20)
        Me.AngelegtTextBox.TabIndex = 16
        '
        'MandantTextBox1
        '
        Me.MandantTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MandantBindingSource, "Mandant", True))
        Me.MandantTextBox1.Location = New System.Drawing.Point(4, 20)
        Me.MandantTextBox1.Name = "MandantTextBox1"
        Me.MandantTextBox1.Size = New System.Drawing.Size(162, 20)
        Me.MandantTextBox1.TabIndex = 15
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BeschreibungTextBox.Location = New System.Drawing.Point(4, 108)
        Me.BeschreibungTextBox.Multiline = True
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        Me.BeschreibungTextBox.Size = New System.Drawing.Size(162, 52)
        Me.BeschreibungTextBox.TabIndex = 7
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "id", True))
        Me.IdTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdTextBox.Location = New System.Drawing.Point(4, 65)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(38, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'ArchivCheckBox
        '
        Me.ArchivCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AktenBindingSource, "Archiv", True))
        Me.ArchivCheckBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArchivCheckBox.Location = New System.Drawing.Point(64, 243)
        Me.ArchivCheckBox.Name = "ArchivCheckBox"
        Me.ArchivCheckBox.Size = New System.Drawing.Size(51, 24)
        Me.ArchivCheckBox.TabIndex = 13
        Me.ArchivCheckBox.UseVisualStyleBackColor = True
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Akte", True))
        Me.AkteTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AkteTextBox.Location = New System.Drawing.Point(51, 65)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(115, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.lbAz)
        Me.Panel3.Controls.Add(Me.lbVorgang)
        Me.Panel3.Controls.Add(Me.lbAkte)
        Me.Panel3.Controls.Add(Me.lbMandant)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(743, 78)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(444, 72)
        Me.Panel3.TabIndex = 4
        '
        'lbAz
        '
        Me.lbAz.AutoSize = True
        Me.lbAz.Location = New System.Drawing.Point(9, 50)
        Me.lbAz.Name = "lbAz"
        Me.lbAz.Size = New System.Drawing.Size(84, 13)
        Me.lbAz.TabIndex = 53
        Me.lbAz.Text = "Aktenzeichen"
        '
        'lbVorgang
        '
        Me.lbVorgang.AutoSize = True
        Me.lbVorgang.Location = New System.Drawing.Point(4, 28)
        Me.lbVorgang.Name = "lbVorgang"
        Me.lbVorgang.Size = New System.Drawing.Size(54, 13)
        Me.lbVorgang.TabIndex = 52
        Me.lbVorgang.Text = "Vorgang"
        '
        'lbAkte
        '
        Me.lbAkte.AutoSize = True
        Me.lbAkte.Location = New System.Drawing.Point(4, 15)
        Me.lbAkte.Name = "lbAkte"
        Me.lbAkte.Size = New System.Drawing.Size(33, 13)
        Me.lbAkte.TabIndex = 51
        Me.lbAkte.Text = "Akte"
        '
        'lbMandant
        '
        Me.lbMandant.AutoSize = True
        Me.lbMandant.Location = New System.Drawing.Point(4, 2)
        Me.lbMandant.Name = "lbMandant"
        Me.lbMandant.Size = New System.Drawing.Size(50, 13)
        Me.lbMandant.TabIndex = 50
        Me.lbMandant.Text = "Bereich"
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel6.Controls.Add(Me.ProgressBar1)
        Me.Panel6.Controls.Add(Me.lbAnzahl)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(169, 69)
        Me.Panel6.TabIndex = 7
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(13, 41)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(142, 20)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 7
        '
        'lbAnzahl
        '
        Me.lbAnzahl.AutoSize = True
        Me.lbAnzahl.Location = New System.Drawing.Point(6, 23)
        Me.lbAnzahl.Name = "lbAnzahl"
        Me.lbAnzahl.Size = New System.Drawing.Size(45, 13)
        Me.lbAnzahl.TabIndex = 6
        Me.lbAnzahl.Text = "Anzahl"
        '
        'Panel19
        '
        Me.Panel19.BackColor = System.Drawing.Color.SteelBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel19, 2)
        Me.Panel19.Controls.Add(Me.Label4)
        Me.Panel19.Controls.Add(Me.NotizDataGridView)
        Me.Panel19.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel19.Location = New System.Drawing.Point(353, 497)
        Me.Panel19.Name = "Panel19"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel19, 3)
        Me.Panel19.Size = New System.Drawing.Size(384, 265)
        Me.Panel19.TabIndex = 34
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label4.Location = New System.Drawing.Point(14, 2)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(50, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Notizen"
        '
        'NotizDataGridView
        '
        Me.NotizDataGridView.AllowUserToAddRows = False
        Me.NotizDataGridView.AutoGenerateColumns = False
        Me.NotizDataGridView.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.NotizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotizDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.erstellt, Me.TitelDataGridViewTextBoxColumn})
        Me.NotizDataGridView.DataSource = Me.NotizBindingSource
        Me.NotizDataGridView.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NotizDataGridView.Location = New System.Drawing.Point(0, 21)
        Me.NotizDataGridView.MultiSelect = False
        Me.NotizDataGridView.Name = "NotizDataGridView"
        Me.NotizDataGridView.RowHeadersVisible = False
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotizDataGridView.RowsDefaultCellStyle = DataGridViewCellStyle8
        Me.NotizDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.NotizDataGridView.Size = New System.Drawing.Size(384, 244)
        Me.NotizDataGridView.TabIndex = 26
        '
        'erstellt
        '
        Me.erstellt.DataPropertyName = "erstellt"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.erstellt.DefaultCellStyle = DataGridViewCellStyle7
        Me.erstellt.HeaderText = "Vom"
        Me.erstellt.Name = "erstellt"
        '
        'TitelDataGridViewTextBoxColumn
        '
        Me.TitelDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.TitelDataGridViewTextBoxColumn.DataPropertyName = "titel"
        Me.TitelDataGridViewTextBoxColumn.HeaderText = "Notiz (kurz)"
        Me.TitelDataGridViewTextBoxColumn.Name = "TitelDataGridViewTextBoxColumn"
        '
        'NotizBindingSource
        '
        Me.NotizBindingSource.DataMember = "notiz"
        Me.NotizBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'PanelSuchBack
        '
        Me.PanelSuchBack.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelSuchBack.Controls.Add(Me.PanelSuchErgeb)
        Me.PanelSuchBack.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSuchBack.Location = New System.Drawing.Point(1193, 3)
        Me.PanelSuchBack.Name = "PanelSuchBack"
        Me.PanelSuchBack.Size = New System.Drawing.Size(280, 69)
        Me.PanelSuchBack.TabIndex = 38
        '
        'PanelSuchErgeb
        '
        Me.PanelSuchErgeb.Controls.Add(Me.lblSuchErgebnis)
        Me.PanelSuchErgeb.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelSuchErgeb.Location = New System.Drawing.Point(0, 0)
        Me.PanelSuchErgeb.Name = "PanelSuchErgeb"
        Me.PanelSuchErgeb.Size = New System.Drawing.Size(280, 69)
        Me.PanelSuchErgeb.TabIndex = 35
        '
        'lblSuchErgebnis
        '
        Me.lblSuchErgebnis.AutoSize = True
        Me.lblSuchErgebnis.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSuchErgebnis.Location = New System.Drawing.Point(10, 24)
        Me.lblSuchErgebnis.Name = "lblSuchErgebnis"
        Me.lblSuchErgebnis.Size = New System.Drawing.Size(84, 13)
        Me.lblSuchErgebnis.TabIndex = 34
        Me.lblSuchErgebnis.Text = "Suchergebnis"
        '
        'LvScanInput
        '
        Me.LvScanInput.BackColor = System.Drawing.Color.Moccasin
        Me.LvScanInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LvScanInput.ContextMenuStrip = Me.ContextMenuStripInput
        Me.LvScanInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvScanInput.Location = New System.Drawing.Point(1193, 156)
        Me.LvScanInput.Name = "LvScanInput"
        Me.TableLayoutPanel1.SetRowSpan(Me.LvScanInput, 2)
        Me.LvScanInput.Size = New System.Drawing.Size(280, 335)
        Me.LvScanInput.TabIndex = 36
        Me.LvScanInput.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStripInput
        '
        Me.ContextMenuStripInput.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsehenToolStripMenuItem1, Me.LöschenToolStripMenuItem})
        Me.ContextMenuStripInput.Name = "ContextMenuStripInput"
        Me.ContextMenuStripInput.Size = New System.Drawing.Size(121, 48)
        '
        'AnsehenToolStripMenuItem1
        '
        Me.AnsehenToolStripMenuItem1.Name = "AnsehenToolStripMenuItem1"
        Me.AnsehenToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.AnsehenToolStripMenuItem1.Text = "Ansehen"
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LöschenToolStripMenuItem.Text = "Löschen"
        '
        'Panel8
        '
        Me.Panel8.AutoScroll = True
        Me.Panel8.BackColor = System.Drawing.Color.SteelBlue
        Me.Panel8.Controls.Add(Me.DataGridView1)
        Me.Panel8.Controls.Add(Me.LblWv)
        Me.Panel8.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel8.Location = New System.Drawing.Point(1193, 497)
        Me.Panel8.Name = "Panel8"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel8, 3)
        Me.Panel8.Size = New System.Drawing.Size(280, 265)
        Me.Panel8.TabIndex = 37
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.LightSteelBlue
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.WvdatumDataGridViewTextBoxColumn, Me.Wiedervorlage})
        Me.DataGridView1.DataSource = Me.WiedervorlageBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.DataGridView1.Location = New System.Drawing.Point(0, 32)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        DataGridViewCellStyle10.BackColor = System.Drawing.Color.White
        DataGridViewCellStyle10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Highlight
        Me.DataGridView1.RowsDefaultCellStyle = DataGridViewCellStyle10
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(280, 233)
        Me.DataGridView1.TabIndex = 1
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.Visible = False
        '
        'WvdatumDataGridViewTextBoxColumn
        '
        Me.WvdatumDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.WvdatumDataGridViewTextBoxColumn.DataPropertyName = "wv_datum"
        DataGridViewCellStyle9.Format = "d"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.WvdatumDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle9
        Me.WvdatumDataGridViewTextBoxColumn.HeaderText = "Wv. Datum"
        Me.WvdatumDataGridViewTextBoxColumn.Name = "WvdatumDataGridViewTextBoxColumn"
        Me.WvdatumDataGridViewTextBoxColumn.Width = 95
        '
        'Wiedervorlage
        '
        Me.Wiedervorlage.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Wiedervorlage.DataPropertyName = "wiedervorlage"
        Me.Wiedervorlage.HeaderText = "Wiedervorlage"
        Me.Wiedervorlage.Name = "Wiedervorlage"
        '
        'WiedervorlageBindingSource
        '
        Me.WiedervorlageBindingSource.DataMember = "wiedervorlage"
        Me.WiedervorlageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'LblWv
        '
        Me.LblWv.AutoSize = True
        Me.LblWv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblWv.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.LblWv.Location = New System.Drawing.Point(6, 16)
        Me.LblWv.Name = "LblWv"
        Me.LblWv.Size = New System.Drawing.Size(176, 13)
        Me.LblWv.TabIndex = 0
        Me.LblWv.Text = "Wiedervorlage zum Dokument"
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.TreeView1, 2)
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.ImageIndex = 0
        Me.TreeView1.ImageList = Me.ImageList3
        Me.TreeView1.Location = New System.Drawing.Point(3, 156)
        Me.TreeView1.Name = "TreeView1"
        Me.TableLayoutPanel1.SetRowSpan(Me.TreeView1, 2)
        Me.TreeView1.SelectedImageIndex = 0
        Me.TreeView1.ShowRootLines = False
        Me.TreeView1.Size = New System.Drawing.Size(344, 335)
        Me.TreeView1.TabIndex = 2
        '
        'ImageList3
        '
        Me.ImageList3.ImageStream = CType(resources.GetObject("ImageList3.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList3.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList3.Images.SetKeyName(0, "Ablage2.png")
        Me.ImageList3.Images.SetKeyName(1, "Ablage.png")
        Me.ImageList3.Images.SetKeyName(2, "001038.png")
        Me.ImageList3.Images.SetKeyName(3, "Folder_16x.png")
        Me.ImageList3.Images.SetKeyName(4, "FolderOpen_16x.png")
        '
        'Panel4
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel4, 2)
        Me.Panel4.Controls.Add(Me.GroupBoxAnzeige)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 78)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(344, 72)
        Me.Panel4.TabIndex = 39
        '
        'GroupBoxAnzeige
        '
        Me.GroupBoxAnzeige.BackColor = System.Drawing.Color.LightSteelBlue
        Me.GroupBoxAnzeige.Controls.Add(Me.RBOrdnerArchiv)
        Me.GroupBoxAnzeige.Controls.Add(Me.RBAktenArchiv)
        Me.GroupBoxAnzeige.Controls.Add(Me.RBAlles)
        Me.GroupBoxAnzeige.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBoxAnzeige.Location = New System.Drawing.Point(0, 0)
        Me.GroupBoxAnzeige.Name = "GroupBoxAnzeige"
        Me.GroupBoxAnzeige.Size = New System.Drawing.Size(344, 72)
        Me.GroupBoxAnzeige.TabIndex = 0
        Me.GroupBoxAnzeige.TabStop = False
        Me.GroupBoxAnzeige.Text = "Auswahl Anzeige"
        '
        'RBOrdnerArchiv
        '
        Me.RBOrdnerArchiv.AutoSize = True
        Me.RBOrdnerArchiv.Location = New System.Drawing.Point(220, 33)
        Me.RBOrdnerArchiv.Name = "RBOrdnerArchiv"
        Me.RBOrdnerArchiv.Size = New System.Drawing.Size(103, 17)
        Me.RBOrdnerArchiv.TabIndex = 2
        Me.RBOrdnerArchiv.TabStop = True
        Me.RBOrdnerArchiv.Text = "Archiv Ordner"
        Me.RBOrdnerArchiv.UseVisualStyleBackColor = True
        '
        'RBAktenArchiv
        '
        Me.RBAktenArchiv.AutoSize = True
        Me.RBAktenArchiv.Location = New System.Drawing.Point(98, 33)
        Me.RBAktenArchiv.Name = "RBAktenArchiv"
        Me.RBAktenArchiv.Size = New System.Drawing.Size(98, 17)
        Me.RBAktenArchiv.TabIndex = 1
        Me.RBAktenArchiv.TabStop = True
        Me.RBAktenArchiv.Text = "Archiv Akten"
        Me.RBAktenArchiv.UseVisualStyleBackColor = True
        '
        'RBAlles
        '
        Me.RBAlles.AutoSize = True
        Me.RBAlles.Location = New System.Drawing.Point(3, 33)
        Me.RBAlles.Name = "RBAlles"
        Me.RBAlles.Size = New System.Drawing.Size(64, 17)
        Me.RBAlles.TabIndex = 0
        Me.RBAlles.TabStop = True
        Me.RBAlles.Text = "Aktuell"
        Me.RBAlles.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.TableLayoutPanel2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 36)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1482, 792)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Mail Verwaltung"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 3
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 501.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.Panel11, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel12, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GVEmails, 0, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelMailKopf, 1, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.Panel15, 1, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.LVMailInput, 2, 2)
        Me.TableLayoutPanel2.Controls.Add(Me.PanelAtt, 1, 4)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 5
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 85.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 71.19741!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28.80259!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 154.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1476, 786)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'Panel11
        '
        Me.Panel11.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel11.Controls.Add(Me.lbStartEinstellung)
        Me.Panel11.Controls.Add(Me.btRset)
        Me.Panel11.Controls.Add(Me.cbMaxMails)
        Me.Panel11.Controls.Add(Me.Label1)
        Me.Panel11.Controls.Add(Me.lbMailListe)
        Me.Panel11.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel11.Location = New System.Drawing.Point(3, 3)
        Me.Panel11.Name = "Panel11"
        Me.Panel11.Size = New System.Drawing.Size(384, 59)
        Me.Panel11.TabIndex = 15
        '
        'lbStartEinstellung
        '
        Me.lbStartEinstellung.AutoSize = True
        Me.lbStartEinstellung.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbStartEinstellung.ForeColor = System.Drawing.Color.Firebrick
        Me.lbStartEinstellung.Location = New System.Drawing.Point(16, 8)
        Me.lbStartEinstellung.Name = "lbStartEinstellung"
        Me.lbStartEinstellung.Size = New System.Drawing.Size(95, 13)
        Me.lbStartEinstellung.TabIndex = 23
        Me.lbStartEinstellung.Text = "Starteinstellung"
        '
        'btRset
        '
        Me.btRset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btRset.Location = New System.Drawing.Point(273, 29)
        Me.btRset.Name = "btRset"
        Me.btRset.Size = New System.Drawing.Size(65, 21)
        Me.btRset.TabIndex = 22
        Me.btRset.Text = "Reset"
        Me.btRset.UseVisualStyleBackColor = True
        '
        'cbMaxMails
        '
        Me.cbMaxMails.FormattingEnabled = True
        Me.cbMaxMails.Items.AddRange(New Object() {"5", "10", "20", "50"})
        Me.cbMaxMails.Location = New System.Drawing.Point(213, 30)
        Me.cbMaxMails.Name = "cbMaxMails"
        Me.cbMaxMails.Size = New System.Drawing.Size(49, 21)
        Me.cbMaxMails.TabIndex = 21
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(143, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Max.  Mails"
        '
        'lbMailListe
        '
        Me.lbMailListe.AutoSize = True
        Me.lbMailListe.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbMailListe.Location = New System.Drawing.Point(16, 30)
        Me.lbMailListe.Name = "lbMailListe"
        Me.lbMailListe.Size = New System.Drawing.Size(112, 13)
        Me.lbMailListe.TabIndex = 0
        Me.lbMailListe.Text = "E-Mails auswählen"
        '
        'Panel12
        '
        Me.Panel12.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel12.Controls.Add(Me.lblStatusMsg)
        Me.Panel12.Controls.Add(Me.lblStatus)
        Me.Panel12.Controls.Add(Me.TxtCounter)
        Me.Panel12.Controls.Add(Me.HostTextBox1)
        Me.Panel12.Controls.Add(Me.UserTextBox1)
        Me.Panel12.Controls.Add(Me.lblPostfach)
        Me.Panel12.Controls.Add(Me.CbProviderAuswahl)
        Me.Panel12.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel12.Location = New System.Drawing.Point(3, 68)
        Me.Panel12.Name = "Panel12"
        Me.Panel12.Size = New System.Drawing.Size(384, 79)
        Me.Panel12.TabIndex = 16
        '
        'lblStatusMsg
        '
        Me.lblStatusMsg.AutoSize = True
        Me.lblStatusMsg.Location = New System.Drawing.Point(170, 82)
        Me.lblStatusMsg.Name = "lblStatusMsg"
        Me.lblStatusMsg.Size = New System.Drawing.Size(45, 13)
        Me.lblStatusMsg.TabIndex = 31
        Me.lblStatusMsg.Text = "Label1"
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(47, 82)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(43, 13)
        Me.lblStatus.TabIndex = 29
        Me.lblStatus.Text = "Status"
        '
        'TxtCounter
        '
        Me.TxtCounter.Location = New System.Drawing.Point(110, 79)
        Me.TxtCounter.Name = "TxtCounter"
        Me.TxtCounter.Size = New System.Drawing.Size(54, 20)
        Me.TxtCounter.TabIndex = 30
        '
        'HostTextBox1
        '
        Me.HostTextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.HostTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.HostTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "Host", True))
        Me.HostTextBox1.Location = New System.Drawing.Point(47, 48)
        Me.HostTextBox1.Name = "HostTextBox1"
        Me.HostTextBox1.ReadOnly = True
        Me.HostTextBox1.Size = New System.Drawing.Size(325, 13)
        Me.HostTextBox1.TabIndex = 28
        Me.HostTextBox1.Text = "Provider"
        '
        'ProviderBindingSource
        '
        Me.ProviderBindingSource.DataMember = "Provider"
        Me.ProviderBindingSource.DataSource = Me.ProviderDataBase
        '
        'ProviderDataBase
        '
        Me.ProviderDataBase.DataSetName = "ProviderDataBase"
        Me.ProviderDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTextBox1
        '
        Me.UserTextBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.UserTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.UserTextBox1.Location = New System.Drawing.Point(47, 29)
        Me.UserTextBox1.Name = "UserTextBox1"
        Me.UserTextBox1.ReadOnly = True
        Me.UserTextBox1.Size = New System.Drawing.Size(325, 13)
        Me.UserTextBox1.TabIndex = 27
        Me.UserTextBox1.Text = "User"
        '
        'lblPostfach
        '
        Me.lblPostfach.AutoSize = True
        Me.lblPostfach.Location = New System.Drawing.Point(45, 6)
        Me.lblPostfach.Name = "lblPostfach"
        Me.lblPostfach.Size = New System.Drawing.Size(57, 13)
        Me.lblPostfach.TabIndex = 26
        Me.lblPostfach.Text = "Postfach"
        '
        'CbProviderAuswahl
        '
        Me.CbProviderAuswahl.DataSource = Me.ProviderBindingSource1
        Me.CbProviderAuswahl.DisplayMember = "Name"
        Me.CbProviderAuswahl.FormattingEnabled = True
        Me.CbProviderAuswahl.Location = New System.Drawing.Point(147, 3)
        Me.CbProviderAuswahl.Name = "CbProviderAuswahl"
        Me.CbProviderAuswahl.Size = New System.Drawing.Size(227, 21)
        Me.CbProviderAuswahl.TabIndex = 25
        Me.CbProviderAuswahl.ValueMember = "id"
        '
        'ProviderBindingSource1
        '
        Me.ProviderBindingSource1.DataMember = "Provider"
        Me.ProviderBindingSource1.DataSource = Me.ProviderDataBase
        '
        'GVEmails
        '
        Me.GVEmails.AllowUserToAddRows = False
        Me.GVEmails.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.GVEmails.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GVEmails.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.GVEmails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVEmails.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn3, Me.UID})
        Me.GVEmails.ContextMenuStrip = Me.ContextMenuStripMail
        Me.GVEmails.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GVEmails.Location = New System.Drawing.Point(3, 153)
        Me.GVEmails.MultiSelect = False
        Me.GVEmails.Name = "GVEmails"
        Me.GVEmails.RowHeadersVisible = False
        Me.TableLayoutPanel2.SetRowSpan(Me.GVEmails, 2)
        Me.GVEmails.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GVEmails.Size = New System.Drawing.Size(384, 475)
        Me.GVEmails.TabIndex = 19
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn4.HeaderText = "Anlg."
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.Width = 61
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        DataGridViewCellStyle11.Format = "g"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle11
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vom"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 56
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.DefaultCellStyle = DataGridViewCellStyle12
        Me.DataGridViewTextBoxColumn3.HeaderText = "Betreff"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'UID
        '
        Me.UID.HeaderText = "UID"
        Me.UID.Name = "UID"
        Me.UID.Visible = False
        '
        'ContextMenuStripMail
        '
        Me.ContextMenuStripMail.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.KompletteMailNachFreeDMSKopierenToolStripMenuItem, Me.MailAnsehenToolStripMenuItem, Me.MailSpeichernToolStripMenuItem})
        Me.ContextMenuStripMail.Name = "ContextMenuStripMail"
        Me.ContextMenuStripMail.Size = New System.Drawing.Size(284, 70)
        '
        'KompletteMailNachFreeDMSKopierenToolStripMenuItem
        '
        Me.KompletteMailNachFreeDMSKopierenToolStripMenuItem.Name = "KompletteMailNachFreeDMSKopierenToolStripMenuItem"
        Me.KompletteMailNachFreeDMSKopierenToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.KompletteMailNachFreeDMSKopierenToolStripMenuItem.Text = "Komplette Mail nach FreeDMS kopieren"
        '
        'MailAnsehenToolStripMenuItem
        '
        Me.MailAnsehenToolStripMenuItem.Name = "MailAnsehenToolStripMenuItem"
        Me.MailAnsehenToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.MailAnsehenToolStripMenuItem.Text = "Mail ansehen"
        '
        'MailSpeichernToolStripMenuItem
        '
        Me.MailSpeichernToolStripMenuItem.Name = "MailSpeichernToolStripMenuItem"
        Me.MailSpeichernToolStripMenuItem.Size = New System.Drawing.Size(283, 22)
        Me.MailSpeichernToolStripMenuItem.Text = "Mail speichern unter ..."
        '
        'PanelMailKopf
        '
        Me.PanelMailKopf.Controls.Add(Me.PanelMail)
        Me.PanelMailKopf.Controls.Add(Me.PanelMailKopfDetail)
        Me.PanelMailKopf.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelMailKopf.Location = New System.Drawing.Point(393, 3)
        Me.PanelMailKopf.Name = "PanelMailKopf"
        Me.TableLayoutPanel2.SetRowSpan(Me.PanelMailKopf, 2)
        Me.PanelMailKopf.Size = New System.Drawing.Size(579, 144)
        Me.PanelMailKopf.TabIndex = 20
        '
        'PanelMail
        '
        Me.PanelMail.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelMail.Controls.Add(Me.Label2)
        Me.PanelMail.Location = New System.Drawing.Point(198, 42)
        Me.PanelMail.Name = "PanelMail"
        Me.PanelMail.Size = New System.Drawing.Size(171, 125)
        Me.PanelMail.TabIndex = 24
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(19, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Mail"
        '
        'PanelMailKopfDetail
        '
        Me.PanelMailKopfDetail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PanelMailKopfDetail.Controls.Add(Me.lblSender)
        Me.PanelMailKopfDetail.Controls.Add(Me.lblSubject)
        Me.PanelMailKopfDetail.Controls.Add(Me.lblDate)
        Me.PanelMailKopfDetail.Controls.Add(Me.lblTo)
        Me.PanelMailKopfDetail.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PanelMailKopfDetail.Location = New System.Drawing.Point(23, 36)
        Me.PanelMailKopfDetail.Name = "PanelMailKopfDetail"
        Me.PanelMailKopfDetail.Size = New System.Drawing.Size(157, 102)
        Me.PanelMailKopfDetail.TabIndex = 23
        '
        'lblSender
        '
        Me.lblSender.AutoSize = True
        Me.lblSender.Location = New System.Drawing.Point(43, 38)
        Me.lblSender.Name = "lblSender"
        Me.lblSender.Size = New System.Drawing.Size(52, 13)
        Me.lblSender.TabIndex = 8
        Me.lblSender.Text = "Absender"
        '
        'lblSubject
        '
        Me.lblSubject.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSubject.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSubject.Location = New System.Drawing.Point(42, 113)
        Me.lblSubject.Name = "lblSubject"
        Me.lblSubject.Size = New System.Drawing.Size(73, 57)
        Me.lblSubject.TabIndex = 7
        Me.lblSubject.Text = "Betreff"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(43, 16)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(38, 13)
        Me.lblDate.TabIndex = 6
        Me.lblDate.Text = "Datum"
        '
        'lblTo
        '
        Me.lblTo.AutoSize = True
        Me.lblTo.Location = New System.Drawing.Point(42, 57)
        Me.lblTo.Name = "lblTo"
        Me.lblTo.Size = New System.Drawing.Size(20, 13)
        Me.lblTo.TabIndex = 4
        Me.lblTo.Text = "An"
        '
        'Panel15
        '
        Me.Panel15.Controls.Add(Me.PictureBox1)
        Me.Panel15.Controls.Add(Me.WebBrowser1)
        Me.Panel15.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel15.Location = New System.Drawing.Point(393, 153)
        Me.Panel15.Name = "Panel15"
        Me.TableLayoutPanel2.SetRowSpan(Me.Panel15, 2)
        Me.Panel15.Size = New System.Drawing.Size(579, 475)
        Me.Panel15.TabIndex = 22
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PictureBox1.Location = New System.Drawing.Point(173, 200)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(222, 143)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.PictureBox1.TabIndex = 15
        Me.PictureBox1.TabStop = False
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(143, 15)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(286, 162)
        Me.WebBrowser1.TabIndex = 14
        '
        'LVMailInput
        '
        Me.LVMailInput.BackColor = System.Drawing.Color.MistyRose
        Me.LVMailInput.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LVMailInput.LargeImageList = Me.ImageList1
        Me.LVMailInput.Location = New System.Drawing.Point(978, 153)
        Me.LVMailInput.Name = "LVMailInput"
        Me.TableLayoutPanel2.SetRowSpan(Me.LVMailInput, 2)
        Me.LVMailInput.Size = New System.Drawing.Size(495, 475)
        Me.LVMailInput.SmallImageList = Me.ImageList1
        Me.LVMailInput.TabIndex = 24
        Me.LVMailInput.UseCompatibleStateImageBehavior = False
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "document.png")
        '
        'PanelAtt
        '
        Me.PanelAtt.BackColor = System.Drawing.Color.LightSteelBlue
        Me.PanelAtt.Controls.Add(Me.Label3)
        Me.PanelAtt.Controls.Add(Me.lbAtt)
        Me.PanelAtt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelAtt.Location = New System.Drawing.Point(393, 634)
        Me.PanelAtt.Name = "PanelAtt"
        Me.PanelAtt.Size = New System.Drawing.Size(579, 149)
        Me.PanelAtt.TabIndex = 21
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(71, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(61, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Anlage(n)"
        '
        'lbAtt
        '
        Me.lbAtt.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAtt.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lbAtt.ContextMenuStrip = Me.ContextMenuStripAttach
        Me.lbAtt.FormattingEnabled = True
        Me.lbAtt.Location = New System.Drawing.Point(74, 63)
        Me.lbAtt.Name = "lbAtt"
        Me.lbAtt.Size = New System.Drawing.Size(433, 30)
        Me.lbAtt.TabIndex = 2
        '
        'ContextMenuStripAttach
        '
        Me.ContextMenuStripAttach.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsehenToolStripMenuItem, Me.NachScanInputKopierenToolStripMenuItem, Me.ToolStripMenuItem1})
        Me.ContextMenuStripAttach.Name = "ContextMenuStripAttach"
        Me.ContextMenuStripAttach.Size = New System.Drawing.Size(208, 70)
        '
        'AnsehenToolStripMenuItem
        '
        Me.AnsehenToolStripMenuItem.Name = "AnsehenToolStripMenuItem"
        Me.AnsehenToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.AnsehenToolStripMenuItem.Text = "Ansehen"
        '
        'NachScanInputKopierenToolStripMenuItem
        '
        Me.NachScanInputKopierenToolStripMenuItem.Name = "NachScanInputKopierenToolStripMenuItem"
        Me.NachScanInputKopierenToolStripMenuItem.Size = New System.Drawing.Size(207, 22)
        Me.NachScanInputKopierenToolStripMenuItem.Text = "Nach ScanInput kopieren"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(207, 22)
        Me.ToolStripMenuItem1.Text = "Speichern unter ..."
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.TableLayoutPanel3)
        Me.TabPage3.Location = New System.Drawing.Point(4, 36)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1482, 792)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Journal-Ansicht"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95.79946!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.200542!))
        Me.TableLayoutPanel3.Controls.Add(Me.DokumenteSQLDataGridView, 0, 1)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel13, 0, 2)
        Me.TableLayoutPanel3.Controls.Add(Me.Panel14, 0, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 3
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.581699!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.4183!))
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 117.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1476, 786)
        Me.TableLayoutPanel3.TabIndex = 0
        '
        'DokumenteSQLDataGridView
        '
        Me.DokumenteSQLDataGridView.AllowUserToAddRows = False
        Me.DokumenteSQLDataGridView.AllowUserToOrderColumns = True
        DataGridViewCellStyle13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.DokumenteSQLDataGridView.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle13
        Me.DokumenteSQLDataGridView.AutoGenerateColumns = False
        Me.DokumenteSQLDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DokumenteSQLDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DokDatumDataGridViewTextBoxColumn, Me.DokumentDataGridViewTextBoxColumn, Me.BetreffDataGridViewTextBoxColumn, Me.MandantDataGridViewTextBoxColumn, Me.AkteDataGridViewTextBoxColumn, Me.VorgangDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.AblageDataGridViewTextBoxColumn, Me.StatusDataGridViewTextBoxColumn, Me.ArtDataGridViewTextBoxColumn})
        Me.DokumenteSQLDataGridView.DataSource = Me.DokumenteSQLBindingSource
        Me.DokumenteSQLDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DokumenteSQLDataGridView.Location = New System.Drawing.Point(3, 53)
        Me.DokumenteSQLDataGridView.Name = "DokumenteSQLDataGridView"
        Me.DokumenteSQLDataGridView.RowHeadersVisible = False
        Me.DokumenteSQLDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DokumenteSQLDataGridView.Size = New System.Drawing.Size(1408, 612)
        Me.DokumenteSQLDataGridView.TabIndex = 0
        '
        'DokDatumDataGridViewTextBoxColumn
        '
        Me.DokDatumDataGridViewTextBoxColumn.DataPropertyName = "DokDatum"
        Me.DokDatumDataGridViewTextBoxColumn.HeaderText = "DokDatum"
        Me.DokDatumDataGridViewTextBoxColumn.Name = "DokDatumDataGridViewTextBoxColumn"
        '
        'DokumentDataGridViewTextBoxColumn
        '
        Me.DokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument"
        Me.DokumentDataGridViewTextBoxColumn.HeaderText = "Dokument"
        Me.DokumentDataGridViewTextBoxColumn.Name = "DokumentDataGridViewTextBoxColumn"
        '
        'BetreffDataGridViewTextBoxColumn
        '
        Me.BetreffDataGridViewTextBoxColumn.DataPropertyName = "Betreff"
        Me.BetreffDataGridViewTextBoxColumn.HeaderText = "Betreff"
        Me.BetreffDataGridViewTextBoxColumn.Name = "BetreffDataGridViewTextBoxColumn"
        '
        'MandantDataGridViewTextBoxColumn
        '
        Me.MandantDataGridViewTextBoxColumn.DataPropertyName = "Mandant"
        Me.MandantDataGridViewTextBoxColumn.HeaderText = "Mandant"
        Me.MandantDataGridViewTextBoxColumn.Name = "MandantDataGridViewTextBoxColumn"
        '
        'AkteDataGridViewTextBoxColumn
        '
        Me.AkteDataGridViewTextBoxColumn.DataPropertyName = "Akte"
        Me.AkteDataGridViewTextBoxColumn.HeaderText = "Akte"
        Me.AkteDataGridViewTextBoxColumn.Name = "AkteDataGridViewTextBoxColumn"
        '
        'VorgangDataGridViewTextBoxColumn
        '
        Me.VorgangDataGridViewTextBoxColumn.DataPropertyName = "Vorgang"
        Me.VorgangDataGridViewTextBoxColumn.HeaderText = "Vorgang"
        Me.VorgangDataGridViewTextBoxColumn.Name = "VorgangDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name_"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Absender"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'AblageDataGridViewTextBoxColumn
        '
        Me.AblageDataGridViewTextBoxColumn.DataPropertyName = "Ablage"
        Me.AblageDataGridViewTextBoxColumn.HeaderText = "Ablage"
        Me.AblageDataGridViewTextBoxColumn.Name = "AblageDataGridViewTextBoxColumn"
        '
        'StatusDataGridViewTextBoxColumn
        '
        Me.StatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.StatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.StatusDataGridViewTextBoxColumn.Name = "StatusDataGridViewTextBoxColumn"
        '
        'ArtDataGridViewTextBoxColumn
        '
        Me.ArtDataGridViewTextBoxColumn.DataPropertyName = "Art"
        Me.ArtDataGridViewTextBoxColumn.HeaderText = "Art"
        Me.ArtDataGridViewTextBoxColumn.Name = "ArtDataGridViewTextBoxColumn"
        '
        'DokumenteSQLBindingSource
        '
        Me.DokumenteSQLBindingSource.DataMember = "DokumenteSQL"
        Me.DokumenteSQLBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'Panel13
        '
        Me.Panel13.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel13.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel13.Location = New System.Drawing.Point(3, 671)
        Me.Panel13.Name = "Panel13"
        Me.Panel13.Size = New System.Drawing.Size(1408, 112)
        Me.Panel13.TabIndex = 1
        '
        'Panel14
        '
        Me.Panel14.Controls.Add(Me.LbInfo)
        Me.Panel14.Controls.Add(Me.LbJournalCount)
        Me.Panel14.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel14.Location = New System.Drawing.Point(3, 3)
        Me.Panel14.Name = "Panel14"
        Me.Panel14.Size = New System.Drawing.Size(1408, 44)
        Me.Panel14.TabIndex = 2
        '
        'LbInfo
        '
        Me.LbInfo.AutoSize = True
        Me.LbInfo.Location = New System.Drawing.Point(213, 16)
        Me.LbInfo.Name = "LbInfo"
        Me.LbInfo.Size = New System.Drawing.Size(286, 13)
        Me.LbInfo.TabIndex = 1
        Me.LbInfo.Text = "Doppel-Klick in der Liste öffnet die Detailansicht."
        '
        'LbJournalCount
        '
        Me.LbJournalCount.AutoSize = True
        Me.LbJournalCount.Location = New System.Drawing.Point(3, 16)
        Me.LbJournalCount.Name = "LbJournalCount"
        Me.LbJournalCount.Size = New System.Drawing.Size(113, 13)
        Me.LbJournalCount.TabIndex = 0
        Me.LbJournalCount.Text = "Anzahl Dokumente"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.ListenToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1490, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.ToolStripSeparator2, Me.SpeichernToolStripMenuItem, Me.ToolStripSeparator3, Me.DruckenToolStripMenuItem, Me.SeitenansichtToolStripMenuItem, Me.ToolStripSeparator4, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = CType(resources.GetObject("NeuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NeuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.NeuToolStripMenuItem.Text = "&Neu"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Ö&ffnen"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(165, 6)
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Enabled = False
        Me.SpeichernToolStripMenuItem.Image = CType(resources.GetObject("SpeichernToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpeichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SpeichernToolStripMenuItem.Text = "&Speichern"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(165, 6)
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Enabled = False
        Me.DruckenToolStripMenuItem.Image = CType(resources.GetObject("DruckenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DruckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.DruckenToolStripMenuItem.Text = "&Drucken"
        '
        'SeitenansichtToolStripMenuItem
        '
        Me.SeitenansichtToolStripMenuItem.Enabled = False
        Me.SeitenansichtToolStripMenuItem.Image = CType(resources.GetObject("SeitenansichtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SeitenansichtToolStripMenuItem.Name = "SeitenansichtToolStripMenuItem"
        Me.SeitenansichtToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.SeitenansichtToolStripMenuItem.Text = "&Seitenansicht"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(165, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(168, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RückgängigToolStripMenuItem, Me.WiederholenToolStripMenuItem, Me.ToolStripSeparator5, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.ToolStripSeparator6})
        Me.BearbeitenToolStripMenuItem.Enabled = False
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
        '
        'RückgängigToolStripMenuItem
        '
        Me.RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
        Me.RückgängigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.RückgängigToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.RückgängigToolStripMenuItem.Text = "&Rückgängig"
        '
        'WiederholenToolStripMenuItem
        '
        Me.WiederholenToolStripMenuItem.Name = "WiederholenToolStripMenuItem"
        Me.WiederholenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.WiederholenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.WiederholenToolStripMenuItem.Text = "Wiede&rholen"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(188, 6)
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Image = CType(resources.GetObject("KopierenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.KopierenToolStripMenuItem.Text = "&Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
        '
        'ToolStripSeparator6
        '
        Me.ToolStripSeparator6.Name = "ToolStripSeparator6"
        Me.ToolStripSeparator6.Size = New System.Drawing.Size(188, 6)
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnpassenToolStripMenuItem, Me.OptionenToolStripMenuItem, Me.AnschriftenAusDokÜbernehmenToolStripMenuItem, Me.ImageNachPDFToolStripMenuItem, Me.ArchivierteVorgängeToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "E&xtras"
        '
        'AnpassenToolStripMenuItem
        '
        Me.AnpassenToolStripMenuItem.Enabled = False
        Me.AnpassenToolStripMenuItem.Name = "AnpassenToolStripMenuItem"
        Me.AnpassenToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.AnpassenToolStripMenuItem.Text = "&Anpassen"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingsToolStripMenuItem})
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.OptionenToolStripMenuItem.Text = "&Optionen"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'AnschriftenAusDokÜbernehmenToolStripMenuItem
        '
        Me.AnschriftenAusDokÜbernehmenToolStripMenuItem.Name = "AnschriftenAusDokÜbernehmenToolStripMenuItem"
        Me.AnschriftenAusDokÜbernehmenToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.AnschriftenAusDokÜbernehmenToolStripMenuItem.Text = "Anschriften aus Dok übernehmen"
        '
        'ImageNachPDFToolStripMenuItem
        '
        Me.ImageNachPDFToolStripMenuItem.Name = "ImageNachPDFToolStripMenuItem"
        Me.ImageNachPDFToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.ImageNachPDFToolStripMenuItem.Text = "Image nach PDF"
        '
        'ArchivierteVorgängeToolStripMenuItem
        '
        Me.ArchivierteVorgängeToolStripMenuItem.Name = "ArchivierteVorgängeToolStripMenuItem"
        Me.ArchivierteVorgängeToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.ArchivierteVorgängeToolStripMenuItem.Text = "Archivierte Vorgänge"
        '
        'ListenToolStripMenuItem
        '
        Me.ListenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MandantenToolStripMenuItem, Me.AktenToolStripMenuItem, Me.VorgängeOrdnerToolStripMenuItem, Me.DokumenteToolStripMenuItem1, Me.ToolStripSeparator12, Me.AnschriftenToolStripMenuItem, Me.AblageToolStripMenuItem, Me.DokArtToolStripMenuItem, Me.StatusToolStripMenuItem, Me.ToolStripSeparator9, Me.VorlagenToolStripMenuItem, Me.WiedervorlagenToolStripMenuItem, Me.NotizenToolStripMenuItem})
        Me.ListenToolStripMenuItem.Name = "ListenToolStripMenuItem"
        Me.ListenToolStripMenuItem.Size = New System.Drawing.Size(50, 20)
        Me.ListenToolStripMenuItem.Text = "Listen"
        '
        'MandantenToolStripMenuItem
        '
        Me.MandantenToolStripMenuItem.Name = "MandantenToolStripMenuItem"
        Me.MandantenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.MandantenToolStripMenuItem.Text = "&Mandanten"
        '
        'AktenToolStripMenuItem
        '
        Me.AktenToolStripMenuItem.Name = "AktenToolStripMenuItem"
        Me.AktenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AktenToolStripMenuItem.Text = "&Akten"
        '
        'VorgängeOrdnerToolStripMenuItem
        '
        Me.VorgängeOrdnerToolStripMenuItem.Name = "VorgängeOrdnerToolStripMenuItem"
        Me.VorgängeOrdnerToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.VorgängeOrdnerToolStripMenuItem.Text = "V&orgänge/Ordner"
        '
        'DokumenteToolStripMenuItem1
        '
        Me.DokumenteToolStripMenuItem1.Name = "DokumenteToolStripMenuItem1"
        Me.DokumenteToolStripMenuItem1.Size = New System.Drawing.Size(166, 22)
        Me.DokumenteToolStripMenuItem1.Text = "Dokumente"
        '
        'ToolStripSeparator12
        '
        Me.ToolStripSeparator12.Name = "ToolStripSeparator12"
        Me.ToolStripSeparator12.Size = New System.Drawing.Size(163, 6)
        '
        'AnschriftenToolStripMenuItem
        '
        Me.AnschriftenToolStripMenuItem.Name = "AnschriftenToolStripMenuItem"
        Me.AnschriftenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AnschriftenToolStripMenuItem.Text = "A&nschriften"
        '
        'AblageToolStripMenuItem
        '
        Me.AblageToolStripMenuItem.Name = "AblageToolStripMenuItem"
        Me.AblageToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.AblageToolStripMenuItem.Text = "A&blage"
        '
        'DokArtToolStripMenuItem
        '
        Me.DokArtToolStripMenuItem.Name = "DokArtToolStripMenuItem"
        Me.DokArtToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.DokArtToolStripMenuItem.Text = "&Dok.Art"
        '
        'StatusToolStripMenuItem
        '
        Me.StatusToolStripMenuItem.Name = "StatusToolStripMenuItem"
        Me.StatusToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.StatusToolStripMenuItem.Text = "&Status"
        '
        'ToolStripSeparator9
        '
        Me.ToolStripSeparator9.Name = "ToolStripSeparator9"
        Me.ToolStripSeparator9.Size = New System.Drawing.Size(163, 6)
        '
        'VorlagenToolStripMenuItem
        '
        Me.VorlagenToolStripMenuItem.Name = "VorlagenToolStripMenuItem"
        Me.VorlagenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.VorlagenToolStripMenuItem.Text = "&Vorlagen"
        '
        'WiedervorlagenToolStripMenuItem
        '
        Me.WiedervorlagenToolStripMenuItem.Name = "WiedervorlagenToolStripMenuItem"
        Me.WiedervorlagenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.WiedervorlagenToolStripMenuItem.Text = "Wiedervorlagen"
        '
        'NotizenToolStripMenuItem
        '
        Me.NotizenToolStripMenuItem.Name = "NotizenToolStripMenuItem"
        Me.NotizenToolStripMenuItem.Size = New System.Drawing.Size(166, 22)
        Me.NotizenToolStripMenuItem.Text = "Notizen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InhaltToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SuchenToolStripMenuItem, Me.ToolStripSeparator7, Me.InfoToolStripMenuItem, Me.TestFormToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InhaltToolStripMenuItem
        '
        Me.InhaltToolStripMenuItem.Name = "InhaltToolStripMenuItem"
        Me.InhaltToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.InhaltToolStripMenuItem.Text = "I&nhalt"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.SuchenToolStripMenuItem.Text = "&Suchen"
        '
        'ToolStripSeparator7
        '
        Me.ToolStripSeparator7.Name = "ToolStripSeparator7"
        Me.ToolStripSeparator7.Size = New System.Drawing.Size(120, 6)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.InfoToolStripMenuItem.Text = "Inf&o..."
        '
        'TestFormToolStripMenuItem
        '
        Me.TestFormToolStripMenuItem.Enabled = False
        Me.TestFormToolStripMenuItem.Name = "TestFormToolStripMenuItem"
        Me.TestFormToolStripMenuItem.Size = New System.Drawing.Size(123, 22)
        Me.TestFormToolStripMenuItem.Text = "TestForm"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.AllowDrop = True
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(44, 44)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonExit, Me.ToolStripButton9, Me.ToolStripSeparator14, Me.ToolStripButtonScan, Me.ToolStripSeparator13, Me.ToolStripButton12, Me.ToolStripButtonScanInput, Me.ToolStripButton14, Me.ToolStripSeparator1, Me.ToolStripButtonMandanten, Me.ToolStripButtonAkten, Me.ToolStripButtonVorgaenge, Me.ToolStripButtonDokumente, Me.ToolStripLabel2, Me.ToolStripSeparator11, Me.ToolStripButtonWv, Me.ToolStripButtonNoteNeu, Me.ToolStripButton1, Me.ToolStripButtonVorlagen, Me.ToolStripSeparator15, Me.ToolStripButtonDatSuche, Me.ToolStripButtonSchnellSuche, Me.ToolStripSeparator8, Me.ToolStripButtonDelDoc})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(839, 51)
        Me.ToolStrip1.TabIndex = 7
        '
        'ToolStripButtonExit
        '
        Me.ToolStripButtonExit.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonExit.Image = CType(resources.GetObject("ToolStripButtonExit.Image"), System.Drawing.Image)
        Me.ToolStripButtonExit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonExit.Name = "ToolStripButtonExit"
        Me.ToolStripButtonExit.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonExit.Text = "Programm beenden."
        Me.ToolStripButtonExit.ToolTipText = "FreeDMS beenden"
        '
        'ToolStripButton9
        '
        Me.ToolStripButton9.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton9.Image = CType(resources.GetObject("ToolStripButton9.Image"), System.Drawing.Image)
        Me.ToolStripButton9.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton9.Name = "ToolStripButton9"
        Me.ToolStripButton9.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButton9.Text = "Refresh - Neu laden"
        Me.ToolStripButton9.ToolTipText = "Refresh"
        '
        'ToolStripSeparator14
        '
        Me.ToolStripSeparator14.Name = "ToolStripSeparator14"
        Me.ToolStripSeparator14.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripButtonScan
        '
        Me.ToolStripButtonScan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonScan.Image = CType(resources.GetObject("ToolStripButtonScan.Image"), System.Drawing.Image)
        Me.ToolStripButtonScan.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonScan.Name = "ToolStripButtonScan"
        Me.ToolStripButtonScan.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonScan.Text = "Dokument scannen"
        '
        'ToolStripSeparator13
        '
        Me.ToolStripSeparator13.Name = "ToolStripSeparator13"
        Me.ToolStripSeparator13.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripButton12
        '
        Me.ToolStripButton12.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton12.Enabled = False
        Me.ToolStripButton12.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton12.Name = "ToolStripButton12"
        Me.ToolStripButton12.Size = New System.Drawing.Size(23, 48)
        Me.ToolStripButton12.Text = "ToolStripButton12"
        '
        'ToolStripButtonScanInput
        '
        Me.ToolStripButtonScanInput.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonScanInput.Image = CType(resources.GetObject("ToolStripButtonScanInput.Image"), System.Drawing.Image)
        Me.ToolStripButtonScanInput.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonScanInput.Name = "ToolStripButtonScanInput"
        Me.ToolStripButtonScanInput.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonScanInput.Text = "Dokumente aus Input-Ordner einlesen"
        Me.ToolStripButtonScanInput.ToolTipText = "Dokumente archivieren"
        '
        'ToolStripButton14
        '
        Me.ToolStripButton14.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton14.Image = CType(resources.GetObject("ToolStripButton14.Image"), System.Drawing.Image)
        Me.ToolStripButton14.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton14.Name = "ToolStripButton14"
        Me.ToolStripButton14.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButton14.Text = "ToolStripButton14"
        Me.ToolStripButton14.ToolTipText = "Neuer Datensatz ohne verknüpftes Dokument"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripButtonMandanten
        '
        Me.ToolStripButtonMandanten.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonMandanten.Image = CType(resources.GetObject("ToolStripButtonMandanten.Image"), System.Drawing.Image)
        Me.ToolStripButtonMandanten.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonMandanten.Name = "ToolStripButtonMandanten"
        Me.ToolStripButtonMandanten.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonMandanten.Text = "ToolStripButton3"
        Me.ToolStripButtonMandanten.ToolTipText = "Bereiche/Mandanten anzeigen"
        '
        'ToolStripButtonAkten
        '
        Me.ToolStripButtonAkten.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonAkten.Image = CType(resources.GetObject("ToolStripButtonAkten.Image"), System.Drawing.Image)
        Me.ToolStripButtonAkten.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonAkten.Name = "ToolStripButtonAkten"
        Me.ToolStripButtonAkten.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonAkten.Text = "ToolStripButton5"
        Me.ToolStripButtonAkten.ToolTipText = "Aktenliste anzeigen"
        '
        'ToolStripButtonVorgaenge
        '
        Me.ToolStripButtonVorgaenge.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonVorgaenge.Image = CType(resources.GetObject("ToolStripButtonVorgaenge.Image"), System.Drawing.Image)
        Me.ToolStripButtonVorgaenge.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVorgaenge.Name = "ToolStripButtonVorgaenge"
        Me.ToolStripButtonVorgaenge.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonVorgaenge.Text = "ToolStripButton6"
        Me.ToolStripButtonVorgaenge.ToolTipText = "Ordnerliste anzeigen"
        '
        'ToolStripButtonDokumente
        '
        Me.ToolStripButtonDokumente.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDokumente.Image = CType(resources.GetObject("ToolStripButtonDokumente.Image"), System.Drawing.Image)
        Me.ToolStripButtonDokumente.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDokumente.Name = "ToolStripButtonDokumente"
        Me.ToolStripButtonDokumente.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonDokumente.Text = "ToolStripButton7"
        Me.ToolStripButtonDokumente.ToolTipText = "Dokumentenliste anzeigen"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(0, 48)
        Me.ToolStripLabel2.Text = "Archiv"
        Me.ToolStripLabel2.ToolTipText = "Archiv Vorgänge"
        '
        'ToolStripSeparator11
        '
        Me.ToolStripSeparator11.Name = "ToolStripSeparator11"
        Me.ToolStripSeparator11.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripButtonWv
        '
        Me.ToolStripButtonWv.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonWv.Image = CType(resources.GetObject("ToolStripButtonWv.Image"), System.Drawing.Image)
        Me.ToolStripButtonWv.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonWv.Name = "ToolStripButtonWv"
        Me.ToolStripButtonWv.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonWv.Text = "ToolStripButton2"
        Me.ToolStripButtonWv.ToolTipText = "Wiedervorlage"
        '
        'ToolStripButtonNoteNeu
        '
        Me.ToolStripButtonNoteNeu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonNoteNeu.Image = CType(resources.GetObject("ToolStripButtonNoteNeu.Image"), System.Drawing.Image)
        Me.ToolStripButtonNoteNeu.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonNoteNeu.Name = "ToolStripButtonNoteNeu"
        Me.ToolStripButtonNoteNeu.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonNoteNeu.Text = "Neue Notiz"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButton1.Text = "Name/Anschrift neu"
        '
        'ToolStripButtonVorlagen
        '
        Me.ToolStripButtonVorlagen.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonVorlagen.Image = CType(resources.GetObject("ToolStripButtonVorlagen.Image"), System.Drawing.Image)
        Me.ToolStripButtonVorlagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonVorlagen.Name = "ToolStripButtonVorlagen"
        Me.ToolStripButtonVorlagen.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonVorlagen.Text = "ToolStripButton9"
        Me.ToolStripButtonVorlagen.ToolTipText = "Vorlagen erstellen"
        '
        'ToolStripSeparator15
        '
        Me.ToolStripSeparator15.Name = "ToolStripSeparator15"
        Me.ToolStripSeparator15.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripButtonDatSuche
        '
        Me.ToolStripButtonDatSuche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDatSuche.Image = CType(resources.GetObject("ToolStripButtonDatSuche.Image"), System.Drawing.Image)
        Me.ToolStripButtonDatSuche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDatSuche.Name = "ToolStripButtonDatSuche"
        Me.ToolStripButtonDatSuche.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonDatSuche.Text = "Heute aufgenommen"
        '
        'ToolStripButtonSchnellSuche
        '
        Me.ToolStripButtonSchnellSuche.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonSchnellSuche.Image = CType(resources.GetObject("ToolStripButtonSchnellSuche.Image"), System.Drawing.Image)
        Me.ToolStripButtonSchnellSuche.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonSchnellSuche.Name = "ToolStripButtonSchnellSuche"
        Me.ToolStripButtonSchnellSuche.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonSchnellSuche.Text = "Schnellsuche"
        Me.ToolStripButtonSchnellSuche.ToolTipText = "Schnellsuche"
        '
        'ToolStripSeparator8
        '
        Me.ToolStripSeparator8.Name = "ToolStripSeparator8"
        Me.ToolStripSeparator8.Size = New System.Drawing.Size(6, 51)
        '
        'ToolStripButtonDelDoc
        '
        Me.ToolStripButtonDelDoc.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDelDoc.Image = CType(resources.GetObject("ToolStripButtonDelDoc.Image"), System.Drawing.Image)
        Me.ToolStripButtonDelDoc.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDelDoc.Name = "ToolStripButtonDelDoc"
        Me.ToolStripButtonDelDoc.Size = New System.Drawing.Size(48, 48)
        Me.ToolStripButtonDelDoc.Tag = ""
        Me.ToolStripButtonDelDoc.Text = "ToolStripButton14"
        Me.ToolStripButtonDelDoc.ToolTipText = "Aktuellen Datensatz löschen"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BGWRefresh
        '
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'NotizTableAdapter
        '
        Me.NotizTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'TypTableAdapter
        '
        Me.TypTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'VorlagenTableAdapter
        '
        Me.VorlagenTableAdapter.ClearBeforeFill = True
        '
        'WiedervorlageTableAdapter
        '
        Me.WiedervorlageTableAdapter.ClearBeforeFill = True
        '
        'MandantAktenBindingSource
        '
        Me.MandantAktenBindingSource.DataMember = "Mandant_Akten"
        Me.MandantAktenBindingSource.DataSource = Me.MandantBindingSource
        '
        'DokumenteBindingSource1
        '
        Me.DokumenteBindingSource1.DataMember = "Dokumente"
        Me.DokumenteBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Me.AblageTableAdapter
        Me.TableAdapterManager.AktenTableAdapter = Me.AktenTableAdapter
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Me.AnschriftenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Me.MandantTableAdapter
        Me.TableAdapterManager.notizTableAdapter = Me.NotizTableAdapter
        Me.TableAdapterManager.StatusTableAdapter = Me.StatusTableAdapter
        Me.TableAdapterManager.TypTableAdapter = Me.TypTableAdapter
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Me.VorgaengeTableAdapter
        Me.TableAdapterManager.VorlagenTableAdapter = Me.VorlagenTableAdapter
        Me.TableAdapterManager.wiedervorlageTableAdapter = Me.WiedervorlageTableAdapter
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'TypBindingSource
        '
        Me.TypBindingSource.DataMember = "Typ"
        Me.TypBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'DokumenteSQLTableAdapter
        '
        Me.DokumenteSQLTableAdapter.ClearBeforeFill = True
        '
        'SqlVorgangAkteBindingSource
        '
        Me.SqlVorgangAkteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        Me.SqlVorgangAkteBindingSource.Position = 0
        '
        'SqlVorgangAkteTableAdapter
        '
        Me.SqlVorgangAkteTableAdapter.ClearBeforeFill = True
        '
        'VorlagenBindingSource
        '
        Me.VorlagenBindingSource.DataMember = "Vorlagen"
        Me.VorlagenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'MandantBindingSource1
        '
        Me.MandantBindingSource1.DataMember = "Mandant"
        Me.MandantBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AktenBindingSource1
        '
        Me.AktenBindingSource1.DataMember = "Akten"
        Me.AktenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'VorgaengeBindingSource1
        '
        Me.VorgaengeBindingSource1.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AnschriftenBindingSource2
        '
        Me.AnschriftenBindingSource2.DataMember = "Anschriften"
        Me.AnschriftenBindingSource2.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'DokumenteBindingSource2
        '
        Me.DokumenteBindingSource2.DataMember = "Dokumente"
        Me.DokumenteBindingSource2.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AnlagenSQLTableAdapter
        '
        Me.AnlagenSQLTableAdapter.ClearBeforeFill = True
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'ContextMenuStripTVOrdner
        '
        Me.ContextMenuStripTVOrdner.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AkteAnsehenToolStripMenuItem, Me.NeuerOrdnerZurAkteToolStripMenuItem})
        Me.ContextMenuStripTVOrdner.Name = "ContextMenuStripTVOrdner"
        Me.ContextMenuStripTVOrdner.Size = New System.Drawing.Size(193, 48)
        '
        'AkteAnsehenToolStripMenuItem
        '
        Me.AkteAnsehenToolStripMenuItem.Name = "AkteAnsehenToolStripMenuItem"
        Me.AkteAnsehenToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.AkteAnsehenToolStripMenuItem.Text = "Akte ansehen"
        '
        'NeuerOrdnerZurAkteToolStripMenuItem
        '
        Me.NeuerOrdnerZurAkteToolStripMenuItem.Name = "NeuerOrdnerZurAkteToolStripMenuItem"
        Me.NeuerOrdnerZurAkteToolStripMenuItem.Size = New System.Drawing.Size(192, 22)
        Me.NeuerOrdnerZurAkteToolStripMenuItem.Text = "Neuer Ordner zur Akte"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.CancelButton = Me.btRset
        Me.ClientSize = New System.Drawing.Size(1490, 907)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.Text = "FreeDMS-Tab"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel21.ResumeLayout(False)
        Me.Panel21.PerformLayout()
        CType(Me.DocNotizDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotizBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel10.ResumeLayout(False)
        Me.Panel10.PerformLayout()
        Me.PanelSuche.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.AblageBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.AnlagenSQLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnlagenSQLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDokButton.ResumeLayout(False)
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        Me.Panel19.ResumeLayout(False)
        Me.Panel19.PerformLayout()
        CType(Me.NotizDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelSuchBack.ResumeLayout(False)
        Me.PanelSuchErgeb.ResumeLayout(False)
        Me.PanelSuchErgeb.PerformLayout()
        Me.ContextMenuStripInput.ResumeLayout(False)
        Me.Panel8.ResumeLayout(False)
        Me.Panel8.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WiedervorlageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.GroupBoxAnzeige.ResumeLayout(False)
        Me.GroupBoxAnzeige.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.Panel11.ResumeLayout(False)
        Me.Panel11.PerformLayout()
        Me.Panel12.ResumeLayout(False)
        Me.Panel12.PerformLayout()
        CType(Me.ProviderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProviderDataBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProviderBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVEmails, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripMail.ResumeLayout(False)
        Me.PanelMailKopf.ResumeLayout(False)
        Me.PanelMail.ResumeLayout(False)
        Me.PanelMail.PerformLayout()
        Me.PanelMailKopfDetail.ResumeLayout(False)
        Me.PanelMailKopfDetail.PerformLayout()
        Me.Panel15.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanelAtt.ResumeLayout(False)
        Me.PanelAtt.PerformLayout()
        Me.ContextMenuStripAttach.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TableLayoutPanel3.ResumeLayout(False)
        CType(Me.DokumenteSQLDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteSQLBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel14.ResumeLayout(False)
        Me.Panel14.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.MandantAktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SqlVorgangAkteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripTVOrdner.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As ToolStripContainer
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents DruckenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SeitenansichtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RückgängigToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WiederholenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents AusschneidenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator6 As ToolStripSeparator
    Friend WithEvents ExtrasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnpassenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnschriftenAusDokÜbernehmenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ImageNachPDFToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MandantenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AktenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VorgängeOrdnerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokumenteToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator12 As ToolStripSeparator
    Friend WithEvents AblageToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VorlagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnschriftenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents StatusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DokArtToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WiedervorlagenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NotizenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents InhaltToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator7 As ToolStripSeparator
    Friend WithEvents InfoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents TreeView1 As TreeView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents BeschreibungTextBox As TextBox
    Friend WithEvents ArchivCheckBox As CheckBox
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents IdTextBox1 As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents BeschreibungTextBox1 As TextBox
    Friend WithEvents HinweiseTextBox As TextBox
    Friend WithEvents ArchivCheckBox1 As CheckBox
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButtonExit As ToolStripButton
    Friend WithEvents ToolStripButtonScan As ToolStripButton
    Friend WithEvents ToolStripSeparator13 As ToolStripSeparator
    Friend WithEvents ToolStripButton12 As ToolStripButton
    Friend WithEvents ToolStripButtonScanInput As ToolStripButton
    Friend WithEvents ToolStripButton14 As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripButtonMandanten As ToolStripButton
    Friend WithEvents ToolStripButtonAkten As ToolStripButton
    Friend WithEvents ToolStripButtonVorgaenge As ToolStripButton
    Friend WithEvents ToolStripButtonDokumente As ToolStripButton
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator11 As ToolStripSeparator
    Friend WithEvents ToolStripButtonWv As ToolStripButton
    Friend WithEvents ToolStripButtonNoteNeu As ToolStripButton
    Friend WithEvents ToolStripButtonVorlagen As ToolStripButton
    Friend WithEvents ToolStripSeparator14 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator15 As ToolStripSeparator
    Friend WithEvents ToolStripButton9 As ToolStripButton
    Friend WithEvents ToolStripButtonDatSuche As ToolStripButton
    Friend WithEvents ToolStripButtonSchnellSuche As ToolStripButton
    Friend WithEvents ImageList3 As ImageList
    Friend WithEvents MandantTextBox1 As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents Panel5 As Panel
    Friend WithEvents DokumenteSQLBindingSource As BindingSource
    Friend WithEvents DokumenteSQLTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteSQLTableAdapter
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents AbsenderTextBox As TextBox
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents TypTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents ProviderBindingSource As BindingSource
    Friend WithEvents ProviderDataBase As ProviderDataBase
    Friend WithEvents lbVorgang As Label
    Friend WithEvents lbAkte As Label
    Friend WithEvents lbMandant As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents lbAnzahl As Label
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents PnlDokButton As Panel
    Friend WithEvents btDocNotiz As Button
    Friend WithEvents btShowDoc As Button
    Friend WithEvents BtWiedervorlage As Button
    Friend WithEvents BtPrint As Button
    Friend WithEvents Panel19 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents NotizDataGridView As DataGridView
    Friend WithEvents NotizBindingSource As BindingSource
    Friend WithEvents NotizTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter
    Friend WithEvents Panel21 As Panel
    Friend WithEvents DocNotizDataGridView As DataGridView
    Friend WithEvents lbNotizDok As Label
    Friend WithEvents NotizBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents TitelDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents erstellt As DataGridViewTextBoxColumn
    Friend WithEvents TitelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SqlVorgangAkteBindingSource As BindingSource
    Friend WithEvents SqlVorgangAkteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.sqlVorgangAkteTableAdapter
    Friend WithEvents Panel7 As Panel
    Friend WithEvents LbEingangsKorb As Label
    Friend WithEvents LvScanInput As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents DokumenteDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents Panel8 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents LblWv As Label
    Friend WithEvents WiedervorlageBindingSource As BindingSource
    Friend WithEvents WiedervorlageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.wiedervorlageTableAdapter
    Friend WithEvents WiedervorlageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BGWRefresh As System.ComponentModel.BackgroundWorker
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents VorlagenBindingSource As BindingSource
    Friend WithEvents VorlagenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter
    Friend WithEvents TestFormToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents WvdatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Wiedervorlage As DataGridViewTextBoxColumn
    Friend WithEvents Panel10 As Panel
    Friend WithEvents PanelSuche As Panel
    Friend WithEvents ComboBoxSuche As ComboBox
    Friend WithEvents TextSuche As TextBox
    Friend WithEvents lblSuchErgebnis As Label
    Friend WithEvents btClear As Button
    Friend WithEvents btSearcj As Button
    Friend WithEvents ToolStripButtonDelDoc As ToolStripButton
    Friend WithEvents ToolStripSeparator8 As ToolStripSeparator
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents Panel11 As Panel
    Friend WithEvents lbStartEinstellung As Label
    Friend WithEvents btRset As Button
    Friend WithEvents cbMaxMails As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents lbMailListe As Label
    Friend WithEvents Panel12 As Panel
    Friend WithEvents HostTextBox1 As TextBox
    Friend WithEvents UserTextBox1 As TextBox
    Friend WithEvents lblPostfach As Label
    Friend WithEvents CbProviderAuswahl As ComboBox
    Friend WithEvents ProviderBindingSource1 As BindingSource
    Friend WithEvents lblStatusMsg As Label
    Friend WithEvents lblStatus As Label
    Friend WithEvents TxtCounter As TextBox
    Friend WithEvents GVEmails As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents UID As DataGridViewTextBoxColumn
    Friend WithEvents PanelMailKopf As Panel
    Friend WithEvents PanelMail As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents PanelMailKopfDetail As Panel
    Friend WithEvents lblSender As Label
    Friend WithEvents lblSubject As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents lblTo As Label
    Friend WithEvents PanelAtt As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents lbAtt As ListBox
    Friend WithEvents Panel15 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents LVMailInput As ListView
    Friend WithEvents ContextMenuStripMail As ContextMenuStrip
    Friend WithEvents KompletteMailNachFreeDMSKopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MailAnsehenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MailSpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ContextMenuStripAttach As ContextMenuStrip
    Friend WithEvents AnsehenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NachScanInputKopierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ContextMenuStripInput As ContextMenuStrip
    Friend WithEvents AnsehenToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TableLayoutPanel3 As TableLayoutPanel
    Friend WithEvents DokumenteBindingSource1 As BindingSource
    Friend WithEvents MandantAktenBindingSource As BindingSource
    Friend WithEvents MandantBindingSource1 As BindingSource
    Friend WithEvents AktenBindingSource1 As BindingSource
    Friend WithEvents VorgaengeBindingSource1 As BindingSource
    Friend WithEvents AnschriftenBindingSource2 As BindingSource
    Friend WithEvents TypBindingSource1 As BindingSource
    Friend WithEvents StatusBindingSource1 As BindingSource
    Friend WithEvents AblageBindingSource1 As BindingSource
    Friend WithEvents DokumenteSQLDataGridView As DataGridView
    Friend WithEvents Panel13 As Panel
    Friend WithEvents DokDatumDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DokumentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BetreffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MandantDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AkteDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents VorgangDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AblageDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StatusDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Panel14 As Panel
    Friend WithEvents LbInfo As Label
    Friend WithEvents LbJournalCount As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CbAblageSuche As ComboBox
    Friend WithEvents CbTypSuche As ComboBox
    Friend WithEvents CbStatusSuche As ComboBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents ToolStripSeparator9 As ToolStripSeparator
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents PanelSuchBack As Panel
    Friend WithEvents PanelSuchErgeb As Panel
    Friend WithEvents DokumenteBindingSource2 As BindingSource
    Friend WithEvents lbAz As Label
    Friend WithEvents LbAnlagen As Label
    Friend WithEvents LbIstAnlage As Label
    Friend WithEvents AnlagenSQLBindingSource As BindingSource
    Friend WithEvents AnlagenSQLTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnlagenSQLTableAdapter
    Friend WithEvents AnlagenSQLDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents ArchivierteVorgängeToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Panel4 As Panel
    Friend WithEvents GroupBoxAnzeige As GroupBox
    Friend WithEvents RBOrdnerArchiv As RadioButton
    Friend WithEvents RBAktenArchiv As RadioButton
    Friend WithEvents RBAlles As RadioButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ContextMenuStripTVOrdner As ContextMenuStrip
    Friend WithEvents AkteAnsehenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents NeuerOrdnerZurAkteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendetTextBox As TextBox
    Friend WithEvents BegonnenTextBox As TextBox
    Friend WithEvents ArchiviertTextBox As TextBox
    Friend WithEvents AngelegtTextBox As TextBox
End Class
