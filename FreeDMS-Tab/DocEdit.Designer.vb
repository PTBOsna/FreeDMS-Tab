<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class DocEdit
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
        Dim VorgangLabel3 As System.Windows.Forms.Label
        Dim AkteLabel1 As System.Windows.Forms.Label
        Dim MandantLabel1 As System.Windows.Forms.Label
        Dim IstAnlageLabel1 As System.Windows.Forms.Label
        Dim GeaendertLabel As System.Windows.Forms.Label
        Dim AufgenommenLabel As System.Windows.Forms.Label
        Dim DokDatumLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim MandantLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
        Dim AnlagenLabel As System.Windows.Forms.Label
        Dim AbsenderLabel As System.Windows.Forms.Label
        Dim EmpfaengerLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DokNameLabel As System.Windows.Forms.Label
        Dim AnlagenIDLabel As System.Windows.Forms.Label
        Dim BearbVermerkLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IstAnlageTextBox = New System.Windows.Forms.TextBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenderTextBox = New System.Windows.Forms.TextBox()
        Me.txtVorgang = New System.Windows.Forms.TextBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtAkte = New System.Windows.Forms.TextBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtMandant = New System.Windows.Forms.TextBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbVorgang = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.IstAnlageCheckBox = New System.Windows.Forms.CheckBox()
        Me.DateTimePicker3 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker2 = New System.Windows.Forms.DateTimePicker()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbTyp = New System.Windows.Forms.ComboBox()
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbAblage = New System.Windows.Forms.ComboBox()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbEmpfaenger = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbAkte = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbAbsender = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GeaendertTextBox = New System.Windows.Forms.TextBox()
        Me.AufgenommenTextBox = New System.Windows.Forms.TextBox()
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.AnlagenTextBox = New System.Windows.Forms.TextBox()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.AnlagenIDTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.FdOcrTextBox = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.FdDatenIDTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbAz = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtImageToPDF = New System.Windows.Forms.Button()
        Me.btShow = New System.Windows.Forms.Button()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.KommentarTextBox1 = New System.Windows.Forms.TextBox()
        VorgangLabel3 = New System.Windows.Forms.Label()
        AkteLabel1 = New System.Windows.Forms.Label()
        MandantLabel1 = New System.Windows.Forms.Label()
        IstAnlageLabel1 = New System.Windows.Forms.Label()
        GeaendertLabel = New System.Windows.Forms.Label()
        AufgenommenLabel = New System.Windows.Forms.Label()
        DokDatumLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
        AnlagenLabel = New System.Windows.Forms.Label()
        AbsenderLabel = New System.Windows.Forms.Label()
        EmpfaengerLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DokNameLabel = New System.Windows.Forms.Label()
        AnlagenIDLabel = New System.Windows.Forms.Label()
        BearbVermerkLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'VorgangLabel3
        '
        VorgangLabel3.AutoSize = True
        VorgangLabel3.Location = New System.Drawing.Point(76, 183)
        VorgangLabel3.Name = "VorgangLabel3"
        VorgangLabel3.Size = New System.Drawing.Size(50, 13)
        VorgangLabel3.TabIndex = 63
        VorgangLabel3.Text = "Vorgang:"
        '
        'AkteLabel1
        '
        AkteLabel1.AutoSize = True
        AkteLabel1.Location = New System.Drawing.Point(94, 130)
        AkteLabel1.Name = "AkteLabel1"
        AkteLabel1.Size = New System.Drawing.Size(32, 13)
        AkteLabel1.TabIndex = 62
        AkteLabel1.Text = "Akte:"
        '
        'MandantLabel1
        '
        MandantLabel1.AutoSize = True
        MandantLabel1.Location = New System.Drawing.Point(74, 75)
        MandantLabel1.Name = "MandantLabel1"
        MandantLabel1.Size = New System.Drawing.Size(46, 13)
        MandantLabel1.TabIndex = 61
        MandantLabel1.Text = "Bereich:"
        '
        'IstAnlageLabel1
        '
        IstAnlageLabel1.AutoSize = True
        IstAnlageLabel1.Location = New System.Drawing.Point(184, 566)
        IstAnlageLabel1.Name = "IstAnlageLabel1"
        IstAnlageLabel1.Size = New System.Drawing.Size(56, 13)
        IstAnlageLabel1.TabIndex = 58
        IstAnlageLabel1.Text = "ist Anlage:"
        '
        'GeaendertLabel
        '
        GeaendertLabel.AutoSize = True
        GeaendertLabel.Location = New System.Drawing.Point(56, 379)
        GeaendertLabel.Name = "GeaendertLabel"
        GeaendertLabel.Size = New System.Drawing.Size(60, 13)
        GeaendertLabel.TabIndex = 45
        GeaendertLabel.Text = "Geaendert:"
        '
        'AufgenommenLabel
        '
        AufgenommenLabel.AutoSize = True
        AufgenommenLabel.Location = New System.Drawing.Point(38, 353)
        AufgenommenLabel.Name = "AufgenommenLabel"
        AufgenommenLabel.Size = New System.Drawing.Size(78, 13)
        AufgenommenLabel.TabIndex = 44
        AufgenommenLabel.Text = "Aufgenommen:"
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(52, 328)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(64, 13)
        DokDatumLabel.TabIndex = 43
        DokDatumLabel.Text = "Dok Datum:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(7, 15)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(132, 101)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(54, 13)
        MandantLabel.TabIndex = 2
        MandantLabel.Text = "ändern in:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(127, 210)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(54, 13)
        Label1.TabIndex = 4
        Label1.Text = "ändern in:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(129, 156)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(54, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "ändern in:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(70, 16)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(88, 42)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 10
        BetreffLabel.Text = "Betreff:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(75, 251)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 12
        BetragLabel.Text = "Betrag:"
        '
        'AnlagenLabel
        '
        AnlagenLabel.AutoSize = True
        AnlagenLabel.Location = New System.Drawing.Point(67, 567)
        AnlagenLabel.Name = "AnlagenLabel"
        AnlagenLabel.Size = New System.Drawing.Size(49, 13)
        AnlagenLabel.TabIndex = 14
        AnlagenLabel.Text = "Anlagen:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(61, 277)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(55, 13)
        AbsenderLabel.TabIndex = 16
        AbsenderLabel.Text = "Absender:"
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Location = New System.Drawing.Point(49, 303)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(67, 13)
        EmpfaengerLabel.TabIndex = 18
        EmpfaengerLabel.Text = "Empfaenger:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(53, 407)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 26
        KommentarLabel.Text = "Kommentar:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(73, 459)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 30
        AblageLabel.Text = "Ablage:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(88, 485)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(28, 13)
        TypLabel.TabIndex = 32
        TypLabel.Text = "Typ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(76, 511)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 34
        StatusLabel.Text = "Status:"
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Location = New System.Drawing.Point(55, 537)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(61, 13)
        DokNameLabel.TabIndex = 36
        DokNameLabel.Text = "Dok Name:"
        '
        'AnlagenIDLabel
        '
        AnlagenIDLabel.AutoSize = True
        AnlagenIDLabel.Location = New System.Drawing.Point(53, 593)
        AnlagenIDLabel.Name = "AnlagenIDLabel"
        AnlagenIDLabel.Size = New System.Drawing.Size(63, 13)
        AnlagenIDLabel.TabIndex = 40
        AnlagenIDLabel.Text = "Anlagen ID:"
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Location = New System.Drawing.Point(36, 619)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(80, 13)
        BearbVermerkLabel.TabIndex = 42
        BearbVermerkLabel.Text = "Bearb Vermerk:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.17431!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 564.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.FdDatenIDTextBox, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.785714!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.21429!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 57.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1084, 791)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Moccasin
        Me.Panel1.Controls.Add(Me.IstAnlageTextBox)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.EmpfaengerTextBox)
        Me.Panel1.Controls.Add(Me.AbsenderTextBox)
        Me.Panel1.Controls.Add(Me.txtVorgang)
        Me.Panel1.Controls.Add(Me.txtAkte)
        Me.Panel1.Controls.Add(Me.txtMandant)
        Me.Panel1.Controls.Add(Me.cbVorgang)
        Me.Panel1.Controls.Add(VorgangLabel3)
        Me.Panel1.Controls.Add(Me.VorgangTextBox)
        Me.Panel1.Controls.Add(AkteLabel1)
        Me.Panel1.Controls.Add(Me.AkteTextBox)
        Me.Panel1.Controls.Add(MandantLabel1)
        Me.Panel1.Controls.Add(Me.MandantTextBox)
        Me.Panel1.Controls.Add(IstAnlageLabel1)
        Me.Panel1.Controls.Add(Me.IstAnlageCheckBox)
        Me.Panel1.Controls.Add(Me.DateTimePicker3)
        Me.Panel1.Controls.Add(Me.DateTimePicker2)
        Me.Panel1.Controls.Add(Me.DateTimePicker1)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.cbTyp)
        Me.Panel1.Controls.Add(Me.cbAblage)
        Me.Panel1.Controls.Add(Me.cbEmpfaenger)
        Me.Panel1.Controls.Add(Me.cbAkte)
        Me.Panel1.Controls.Add(Me.cbAbsender)
        Me.Panel1.Controls.Add(Me.cbMandant)
        Me.Panel1.Controls.Add(GeaendertLabel)
        Me.Panel1.Controls.Add(Me.GeaendertTextBox)
        Me.Panel1.Controls.Add(AufgenommenLabel)
        Me.Panel1.Controls.Add(Me.AufgenommenTextBox)
        Me.Panel1.Controls.Add(DokDatumLabel)
        Me.Panel1.Controls.Add(Me.DokDatumTextBox)
        Me.Panel1.Controls.Add(MandantLabel)
        Me.Panel1.Controls.Add(Label1)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(Me.DokumentTextBox)
        Me.Panel1.Controls.Add(BetreffLabel)
        Me.Panel1.Controls.Add(Me.BetreffTextBox)
        Me.Panel1.Controls.Add(BetragLabel)
        Me.Panel1.Controls.Add(Me.BetragTextBox)
        Me.Panel1.Controls.Add(AnlagenLabel)
        Me.Panel1.Controls.Add(Me.AnlagenTextBox)
        Me.Panel1.Controls.Add(AbsenderLabel)
        Me.Panel1.Controls.Add(EmpfaengerLabel)
        Me.Panel1.Controls.Add(KommentarLabel)
        Me.Panel1.Controls.Add(Me.KommentarTextBox)
        Me.Panel1.Controls.Add(AblageLabel)
        Me.Panel1.Controls.Add(TypLabel)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(DokNameLabel)
        Me.Panel1.Controls.Add(Me.DokNameTextBox)
        Me.Panel1.Controls.Add(AnlagenIDLabel)
        Me.Panel1.Controls.Add(Me.AnlagenIDTextBox)
        Me.Panel1.Controls.Add(BearbVermerkLabel)
        Me.Panel1.Controls.Add(Me.BearbVermerkTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 52)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(514, 678)
        Me.Panel1.TabIndex = 0
        '
        'IstAnlageTextBox
        '
        Me.IstAnlageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "istAnlage", True))
        Me.IstAnlageTextBox.Location = New System.Drawing.Point(265, 563)
        Me.IstAnlageTextBox.Name = "IstAnlageTextBox"
        Me.IstAnlageTextBox.ReadOnly = True
        Me.IstAnlageTextBox.Size = New System.Drawing.Size(57, 20)
        Me.IstAnlageTextBox.TabIndex = 71
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(334, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(143, 26)
        Me.Label2.TabIndex = 70
        Me.Label2.Text = "Neue Anschriften bitte zuerst" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "in Anschriftenliste eingeben"
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(122, 299)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(47, 20)
        Me.EmpfaengerTextBox.TabIndex = 69
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Absender", True))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(122, 274)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.Size = New System.Drawing.Size(47, 20)
        Me.AbsenderTextBox.TabIndex = 68
        '
        'txtVorgang
        '
        Me.txtVorgang.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Vorgang", True))
        Me.txtVorgang.Location = New System.Drawing.Point(187, 181)
        Me.txtVorgang.Name = "txtVorgang"
        Me.txtVorgang.Size = New System.Drawing.Size(146, 20)
        Me.txtVorgang.TabIndex = 67
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'txtAkte
        '
        Me.txtAkte.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Akte", True))
        Me.txtAkte.Location = New System.Drawing.Point(186, 127)
        Me.txtAkte.Name = "txtAkte"
        Me.txtAkte.Size = New System.Drawing.Size(146, 20)
        Me.txtAkte.TabIndex = 67
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'txtMandant
        '
        Me.txtMandant.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MandantBindingSource, "Mandant", True))
        Me.txtMandant.Location = New System.Drawing.Point(186, 72)
        Me.txtMandant.Name = "txtMandant"
        Me.txtMandant.Size = New System.Drawing.Size(146, 20)
        Me.txtMandant.TabIndex = 66
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbVorgang
        '
        Me.cbVorgang.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbVorgang.DataSource = Me.VorgaengeBindingSource1
        Me.cbVorgang.DisplayMember = "Vorgang"
        Me.cbVorgang.ForeColor = System.Drawing.Color.DimGray
        Me.cbVorgang.FormattingEnabled = True
        Me.cbVorgang.Location = New System.Drawing.Point(187, 207)
        Me.cbVorgang.Name = "cbVorgang"
        Me.cbVorgang.Size = New System.Drawing.Size(145, 21)
        Me.cbVorgang.TabIndex = 65
        Me.cbVorgang.ValueMember = "id"
        '
        'VorgaengeBindingSource1
        '
        Me.VorgaengeBindingSource1.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(132, 180)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.ReadOnly = True
        Me.VorgangTextBox.Size = New System.Drawing.Size(49, 20)
        Me.VorgangTextBox.TabIndex = 64
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(132, 127)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.ReadOnly = True
        Me.AkteTextBox.Size = New System.Drawing.Size(49, 20)
        Me.AkteTextBox.TabIndex = 63
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(132, 72)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.ReadOnly = True
        Me.MandantTextBox.Size = New System.Drawing.Size(49, 20)
        Me.MandantTextBox.TabIndex = 62
        '
        'IstAnlageCheckBox
        '
        Me.IstAnlageCheckBox.Location = New System.Drawing.Point(246, 561)
        Me.IstAnlageCheckBox.Name = "IstAnlageCheckBox"
        Me.IstAnlageCheckBox.Size = New System.Drawing.Size(24, 24)
        Me.IstAnlageCheckBox.TabIndex = 59
        Me.IstAnlageCheckBox.UseVisualStyleBackColor = True
        '
        'DateTimePicker3
        '
        Me.DateTimePicker3.Location = New System.Drawing.Point(328, 376)
        Me.DateTimePicker3.Name = "DateTimePicker3"
        Me.DateTimePicker3.Size = New System.Drawing.Size(149, 20)
        Me.DateTimePicker3.TabIndex = 57
        '
        'DateTimePicker2
        '
        Me.DateTimePicker2.Location = New System.Drawing.Point(328, 350)
        Me.DateTimePicker2.Name = "DateTimePicker2"
        Me.DateTimePicker2.Size = New System.Drawing.Size(149, 20)
        Me.DateTimePicker2.TabIndex = 56
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(328, 325)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(149, 20)
        Me.DateTimePicker1.TabIndex = 55
        '
        'cbStatus
        '
        Me.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Status", True))
        Me.cbStatus.DataSource = Me.StatusBindingSource
        Me.cbStatus.DisplayMember = "Status"
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(122, 507)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(200, 21)
        Me.cbStatus.TabIndex = 54
        Me.cbStatus.ValueMember = "id"
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbTyp
        '
        Me.cbTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbTyp.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Typ", True))
        Me.cbTyp.DataSource = Me.TypBindingSource
        Me.cbTyp.DisplayMember = "Typ"
        Me.cbTyp.FormattingEnabled = True
        Me.cbTyp.Location = New System.Drawing.Point(122, 482)
        Me.cbTyp.Name = "cbTyp"
        Me.cbTyp.Size = New System.Drawing.Size(200, 21)
        Me.cbTyp.TabIndex = 53
        Me.cbTyp.ValueMember = "id"
        '
        'TypBindingSource
        '
        Me.TypBindingSource.DataMember = "Typ"
        Me.TypBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbAblage
        '
        Me.cbAblage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbAblage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAblage.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Ablage", True))
        Me.cbAblage.DataSource = Me.AblageBindingSource
        Me.cbAblage.DisplayMember = "Ablage"
        Me.cbAblage.FormattingEnabled = True
        Me.cbAblage.Location = New System.Drawing.Point(122, 457)
        Me.cbAblage.Name = "cbAblage"
        Me.cbAblage.Size = New System.Drawing.Size(200, 21)
        Me.cbAblage.TabIndex = 52
        Me.cbAblage.ValueMember = "Nummer"
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbEmpfaenger
        '
        Me.cbEmpfaenger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbEmpfaenger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEmpfaenger.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.cbEmpfaenger.DataSource = Me.AnschriftenBindingSource1
        Me.cbEmpfaenger.DisplayMember = "Name_"
        Me.cbEmpfaenger.FormattingEnabled = True
        Me.cbEmpfaenger.Location = New System.Drawing.Point(176, 300)
        Me.cbEmpfaenger.Name = "cbEmpfaenger"
        Me.cbEmpfaenger.Size = New System.Drawing.Size(146, 21)
        Me.cbEmpfaenger.TabIndex = 51
        Me.cbEmpfaenger.ValueMember = "id"
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbAkte
        '
        Me.cbAkte.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbAkte.DataSource = Me.AktenBindingSource1
        Me.cbAkte.DisplayMember = "Akte"
        Me.cbAkte.ForeColor = System.Drawing.Color.DimGray
        Me.cbAkte.FormattingEnabled = True
        Me.cbAkte.Location = New System.Drawing.Point(187, 153)
        Me.cbAkte.Name = "cbAkte"
        Me.cbAkte.Size = New System.Drawing.Size(145, 21)
        Me.cbAkte.TabIndex = 50
        Me.cbAkte.ValueMember = "id"
        '
        'AktenBindingSource1
        '
        Me.AktenBindingSource1.DataMember = "Akten"
        Me.AktenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbAbsender
        '
        Me.cbAbsender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbAbsender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAbsender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Absender", True))
        Me.cbAbsender.DataSource = Me.AnschriftenBindingSource
        Me.cbAbsender.DisplayMember = "Name_"
        Me.cbAbsender.FormattingEnabled = True
        Me.cbAbsender.Location = New System.Drawing.Point(176, 274)
        Me.cbAbsender.Name = "cbAbsender"
        Me.cbAbsender.Size = New System.Drawing.Size(146, 21)
        Me.cbAbsender.TabIndex = 48
        Me.cbAbsender.ValueMember = "id"
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbMandant
        '
        Me.cbMandant.BackColor = System.Drawing.Color.WhiteSmoke
        Me.cbMandant.DataSource = Me.MandantBindingSource1
        Me.cbMandant.DisplayMember = "Mandant"
        Me.cbMandant.ForeColor = System.Drawing.Color.DimGray
        Me.cbMandant.FormattingEnabled = True
        Me.cbMandant.Location = New System.Drawing.Point(187, 98)
        Me.cbMandant.Name = "cbMandant"
        Me.cbMandant.Size = New System.Drawing.Size(145, 21)
        Me.cbMandant.TabIndex = 47
        Me.cbMandant.ValueMember = "id"
        '
        'MandantBindingSource1
        '
        Me.MandantBindingSource1.DataMember = "Mandant"
        Me.MandantBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'GeaendertTextBox
        '
        Me.GeaendertTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Geaendert", True))
        Me.GeaendertTextBox.Location = New System.Drawing.Point(122, 376)
        Me.GeaendertTextBox.Name = "GeaendertTextBox"
        Me.GeaendertTextBox.Size = New System.Drawing.Size(200, 20)
        Me.GeaendertTextBox.TabIndex = 46
        '
        'AufgenommenTextBox
        '
        Me.AufgenommenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.AufgenommenTextBox.Location = New System.Drawing.Point(122, 350)
        Me.AufgenommenTextBox.Name = "AufgenommenTextBox"
        Me.AufgenommenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AufgenommenTextBox.TabIndex = 45
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(122, 325)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DokDatumTextBox.TabIndex = 44
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokumentTextBox.Location = New System.Drawing.Point(135, 13)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(342, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(135, 39)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(342, 20)
        Me.BetreffTextBox.TabIndex = 11
        '
        'BetragTextBox
        '
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True))
        Me.BetragTextBox.Location = New System.Drawing.Point(122, 248)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(67, 20)
        Me.BetragTextBox.TabIndex = 13
        Me.BetragTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'AnlagenTextBox
        '
        Me.AnlagenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Anlagen", True))
        Me.AnlagenTextBox.Location = New System.Drawing.Point(122, 564)
        Me.AnlagenTextBox.Name = "AnlagenTextBox"
        Me.AnlagenTextBox.Size = New System.Drawing.Size(58, 20)
        Me.AnlagenTextBox.TabIndex = 15
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(122, 404)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.KommentarTextBox.Size = New System.Drawing.Size(355, 46)
        Me.KommentarTextBox.TabIndex = 27
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(122, 534)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DokNameTextBox.TabIndex = 37
        '
        'AnlagenIDTextBox
        '
        Me.AnlagenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "AnlagenID", True))
        Me.AnlagenIDTextBox.Location = New System.Drawing.Point(122, 590)
        Me.AnlagenIDTextBox.Name = "AnlagenIDTextBox"
        Me.AnlagenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AnlagenIDTextBox.TabIndex = 41
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(122, 616)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(355, 20)
        Me.BearbVermerkTextBox.TabIndex = 43
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.btSave)
        Me.FlowLayoutPanel1.Controls.Add(Me.btClose)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(3, 736)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(514, 52)
        Me.FlowLayoutPanel1.TabIndex = 4
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Location = New System.Drawing.Point(3, 3)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(168, 49)
        Me.btSave.TabIndex = 2
        Me.btSave.Text = "Übernehmen und zurück"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Location = New System.Drawing.Point(177, 4)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 46)
        Me.btClose.TabIndex = 3
        Me.btClose.Text = "Zurück"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(523, 52)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(558, 678)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(550, 652)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dokument"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(544, 646)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.FdOcrTextBox)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(550, 652)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OCR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'FdOcrTextBox
        '
        Me.FdOcrTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "InhaltOCR", True))
        Me.FdOcrTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FdOcrTextBox.Location = New System.Drawing.Point(3, 3)
        Me.FdOcrTextBox.Multiline = True
        Me.FdOcrTextBox.Name = "FdOcrTextBox"
        Me.FdOcrTextBox.Size = New System.Drawing.Size(544, 646)
        Me.FdOcrTextBox.TabIndex = 1
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(550, 652)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bild"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(544, 646)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'FdDatenIDTextBox
        '
        Me.FdDatenIDTextBox.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.FdDatenIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.FdDatenIDTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FdDatenIDTextBox.Location = New System.Drawing.Point(702, 18)
        Me.FdDatenIDTextBox.Name = "FdDatenIDTextBox"
        Me.FdDatenIDTextBox.Size = New System.Drawing.Size(200, 13)
        Me.FdDatenIDTextBox.TabIndex = 1
        Me.FdDatenIDTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lbAz)
        Me.Panel2.Controls.Add(Me.IdTextBox)
        Me.Panel2.Controls.Add(IdLabel)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(514, 43)
        Me.Panel2.TabIndex = 7
        '
        'lbAz
        '
        Me.lbAz.AutoSize = True
        Me.lbAz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAz.Location = New System.Drawing.Point(117, 15)
        Me.lbAz.Name = "lbAz"
        Me.lbAz.Size = New System.Drawing.Size(84, 13)
        Me.lbAz.TabIndex = 0
        Me.lbAz.Text = "Aktenzeichen"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(22, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(46, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtImageToPDF)
        Me.Panel3.Controls.Add(Me.btShow)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(523, 736)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(558, 52)
        Me.Panel3.TabIndex = 8
        '
        'BtImageToPDF
        '
        Me.BtImageToPDF.Location = New System.Drawing.Point(28, 16)
        Me.BtImageToPDF.Name = "BtImageToPDF"
        Me.BtImageToPDF.Size = New System.Drawing.Size(135, 23)
        Me.BtImageToPDF.TabIndex = 7
        Me.BtImageToPDF.Text = "Nach PDF konvertieren"
        Me.BtImageToPDF.UseVisualStyleBackColor = True
        '
        'btShow
        '
        Me.btShow.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btShow.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btShow.Location = New System.Drawing.Point(234, 4)
        Me.btShow.Name = "btShow"
        Me.btShow.Size = New System.Drawing.Size(75, 46)
        Me.btShow.TabIndex = 6
        Me.btShow.Text = "Ansehen"
        Me.btShow.UseVisualStyleBackColor = True
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'TypTableAdapter
        '
        Me.TypTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Nothing
        Me.TableAdapterManager.AktenTableAdapter = Nothing
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.Connection = Nothing
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Nothing
        Me.TableAdapterManager.MandantTableAdapter = Nothing
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Nothing
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.KommentarTextBox1)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(550, 652)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Kommentar"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'KommentarTextBox1
        '
        Me.KommentarTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KommentarTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.KommentarTextBox1.Multiline = True
        Me.KommentarTextBox1.Name = "KommentarTextBox1"
        Me.KommentarTextBox1.Size = New System.Drawing.Size(544, 646)
        Me.KommentarTextBox1.TabIndex = 1
        '
        'DocEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1084, 791)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "DocEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FreeDMS-Tab - Dokument Detailanzeige"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtVorgang As TextBox
    Friend WithEvents txtAkte As TextBox
    Friend WithEvents txtMandant As TextBox
    Friend WithEvents cbVorgang As ComboBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents IstAnlageCheckBox As CheckBox
    Friend WithEvents DateTimePicker3 As DateTimePicker
    Friend WithEvents DateTimePicker2 As DateTimePicker
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbTyp As ComboBox
    Friend WithEvents cbAblage As ComboBox
    Friend WithEvents cbEmpfaenger As ComboBox
    Friend WithEvents cbAkte As ComboBox
    Friend WithEvents cbAbsender As ComboBox
    Friend WithEvents cbMandant As ComboBox
    Friend WithEvents GeaendertTextBox As TextBox
    Friend WithEvents AufgenommenTextBox As TextBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents AnlagenTextBox As TextBox
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents AnlagenIDTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents btSave As Button
    Friend WithEvents btClose As Button
    Friend WithEvents FdDatenIDTextBox As TextBox
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents FdOcrTextBox As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents btShow As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents MandantBindingSource1 As BindingSource
    Friend WithEvents AktenBindingSource1 As BindingSource
    Friend WithEvents VorgaengeBindingSource1 As BindingSource
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents AbsenderTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbAz As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IstAnlageTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtImageToPDF As Button
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents KommentarTextBox1 As TextBox
End Class
