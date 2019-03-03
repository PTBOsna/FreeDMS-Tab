<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScanInput2
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim MandantLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
        Dim AnlagenLabel As System.Windows.Forms.Label
        Dim AbsenderLabel As System.Windows.Forms.Label
        Dim EmpfaengerLabel As System.Windows.Forms.Label
        Dim DokDatumLabel As System.Windows.Forms.Label
        Dim AufgenommenLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DokNameLabel As System.Windows.Forms.Label
        Dim IstAnlageLabel As System.Windows.Forms.Label
        Dim AnlagenIDLabel As System.Windows.Forms.Label
        Dim BearbVermerkLabel As System.Windows.Forms.Label
        Dim InhaltOCRLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LvDoc = New System.Windows.Forms.ListView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbTyp = New System.Windows.Forms.ComboBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbStatus = New System.Windows.Forms.ComboBox()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAblage = New System.Windows.Forms.ComboBox()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbEmpfaenger = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAbsender = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbVorgang = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAkte = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lboxSaveAtt = New System.Windows.Forms.ListBox()
        Me.AufgenommenTextBox = New System.Windows.Forms.TextBox()
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.AnlagenTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenderTextBox = New System.Windows.Forms.TextBox()
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.DokDatumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.IstAnlageCheckBox = New System.Windows.Forms.CheckBox()
        Me.AnlagenIDTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btWeiterZuordnung = New System.Windows.Forms.Button()
        Me.lbSpeichstatus = New System.Windows.Forms.Label()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAendern = New System.Windows.Forms.TextBox()
        Me.btChangeOrdner = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.FdDatenIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.InhaltOCRTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.VorlagenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.VorlagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.InhaltOCRTextBox1 = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
        AnlagenLabel = New System.Windows.Forms.Label()
        AbsenderLabel = New System.Windows.Forms.Label()
        EmpfaengerLabel = New System.Windows.Forms.Label()
        DokDatumLabel = New System.Windows.Forms.Label()
        AufgenommenLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DokNameLabel = New System.Windows.Forms.Label()
        IstAnlageLabel = New System.Windows.Forms.Label()
        AnlagenIDLabel = New System.Windows.Forms.Label()
        BearbVermerkLabel = New System.Windows.Forms.Label()
        InhaltOCRLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(33, 6)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        IdLabel.Visible = False
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(37, 8)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 2
        MandantLabel.Text = "Bereich:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(37, 34)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(37, 60)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 6
        VorgangLabel.Text = "Vorgang:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(37, 86)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(37, 112)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 10
        BetreffLabel.Text = "Betreff:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(37, 138)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 12
        BetragLabel.Text = "Betrag:"
        '
        'AnlagenLabel
        '
        AnlagenLabel.AutoSize = True
        AnlagenLabel.Location = New System.Drawing.Point(37, 164)
        AnlagenLabel.Name = "AnlagenLabel"
        AnlagenLabel.Size = New System.Drawing.Size(49, 13)
        AnlagenLabel.TabIndex = 14
        AnlagenLabel.Text = "Anlagen:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(37, 190)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(55, 13)
        AbsenderLabel.TabIndex = 16
        AbsenderLabel.Text = "Absender:"
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Location = New System.Drawing.Point(37, 216)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(67, 13)
        EmpfaengerLabel.TabIndex = 18
        EmpfaengerLabel.Text = "Empfaenger:"
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(37, 243)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(64, 13)
        DokDatumLabel.TabIndex = 20
        DokDatumLabel.Text = "Dok Datum:"
        '
        'AufgenommenLabel
        '
        AufgenommenLabel.AutoSize = True
        AufgenommenLabel.Location = New System.Drawing.Point(37, 269)
        AufgenommenLabel.Name = "AufgenommenLabel"
        AufgenommenLabel.Size = New System.Drawing.Size(78, 13)
        AufgenommenLabel.TabIndex = 22
        AufgenommenLabel.Text = "Aufgenommen:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(37, 295)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 26
        KommentarLabel.Text = "Kommentar:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(37, 347)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 30
        AblageLabel.Text = "Ablage:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(37, 373)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(28, 13)
        TypLabel.TabIndex = 32
        TypLabel.Text = "Typ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(37, 399)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 34
        StatusLabel.Text = "Status:"
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Location = New System.Drawing.Point(37, 425)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(61, 13)
        DokNameLabel.TabIndex = 36
        DokNameLabel.Text = "Dok Name:"
        '
        'IstAnlageLabel
        '
        IstAnlageLabel.AutoSize = True
        IstAnlageLabel.Location = New System.Drawing.Point(37, 453)
        IstAnlageLabel.Name = "IstAnlageLabel"
        IstAnlageLabel.Size = New System.Drawing.Size(56, 13)
        IstAnlageLabel.TabIndex = 38
        IstAnlageLabel.Text = "ist Anlage:"
        '
        'AnlagenIDLabel
        '
        AnlagenIDLabel.AutoSize = True
        AnlagenIDLabel.Location = New System.Drawing.Point(37, 481)
        AnlagenIDLabel.Name = "AnlagenIDLabel"
        AnlagenIDLabel.Size = New System.Drawing.Size(63, 13)
        AnlagenIDLabel.TabIndex = 40
        AnlagenIDLabel.Text = "Anlagen ID:"
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Location = New System.Drawing.Point(37, 507)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(80, 13)
        BearbVermerkLabel.TabIndex = 42
        BearbVermerkLabel.Text = "Bearb Vermerk:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 349.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LvDoc, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.89866!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.10134!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1173, 715)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LvDoc
        '
        Me.LvDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvDoc.Location = New System.Drawing.Point(827, 74)
        Me.LvDoc.Name = "LvDoc"
        Me.LvDoc.Size = New System.Drawing.Size(343, 577)
        Me.LvDoc.TabIndex = 0
        Me.LvDoc.UseCompatibleStateImageBehavior = False
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.CbTyp)
        Me.Panel1.Controls.Add(Me.CbStatus)
        Me.Panel1.Controls.Add(Me.CbAblage)
        Me.Panel1.Controls.Add(Me.CbEmpfaenger)
        Me.Panel1.Controls.Add(Me.CbAbsender)
        Me.Panel1.Controls.Add(Me.CbVorgang)
        Me.Panel1.Controls.Add(Me.CbAkte)
        Me.Panel1.Controls.Add(Me.CbMandant)
        Me.Panel1.Controls.Add(Me.lboxSaveAtt)
        Me.Panel1.Controls.Add(Me.AufgenommenTextBox)
        Me.Panel1.Controls.Add(Me.DokDatumTextBox)
        Me.Panel1.Controls.Add(MandantLabel)
        Me.Panel1.Controls.Add(Me.MandantTextBox)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(Me.AkteTextBox)
        Me.Panel1.Controls.Add(VorgangLabel)
        Me.Panel1.Controls.Add(Me.VorgangTextBox)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(Me.DokumentTextBox)
        Me.Panel1.Controls.Add(BetreffLabel)
        Me.Panel1.Controls.Add(Me.BetreffTextBox)
        Me.Panel1.Controls.Add(BetragLabel)
        Me.Panel1.Controls.Add(Me.BetragTextBox)
        Me.Panel1.Controls.Add(AnlagenLabel)
        Me.Panel1.Controls.Add(Me.AnlagenTextBox)
        Me.Panel1.Controls.Add(AbsenderLabel)
        Me.Panel1.Controls.Add(Me.AbsenderTextBox)
        Me.Panel1.Controls.Add(EmpfaengerLabel)
        Me.Panel1.Controls.Add(Me.EmpfaengerTextBox)
        Me.Panel1.Controls.Add(DokDatumLabel)
        Me.Panel1.Controls.Add(Me.DokDatumDateTimePicker)
        Me.Panel1.Controls.Add(AufgenommenLabel)
        Me.Panel1.Controls.Add(KommentarLabel)
        Me.Panel1.Controls.Add(Me.KommentarTextBox)
        Me.Panel1.Controls.Add(AblageLabel)
        Me.Panel1.Controls.Add(Me.AblageTextBox)
        Me.Panel1.Controls.Add(TypLabel)
        Me.Panel1.Controls.Add(Me.TypTextBox)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(Me.StatusTextBox)
        Me.Panel1.Controls.Add(DokNameLabel)
        Me.Panel1.Controls.Add(Me.DokNameTextBox)
        Me.Panel1.Controls.Add(IstAnlageLabel)
        Me.Panel1.Controls.Add(Me.IstAnlageCheckBox)
        Me.Panel1.Controls.Add(AnlagenIDLabel)
        Me.Panel1.Controls.Add(Me.AnlagenIDTextBox)
        Me.Panel1.Controls.Add(BearbVermerkLabel)
        Me.Panel1.Controls.Add(Me.BearbVermerkTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 74)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 577)
        Me.Panel1.TabIndex = 1
        '
        'CbTyp
        '
        Me.CbTyp.BackColor = System.Drawing.Color.Moccasin
        Me.CbTyp.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Typ", True))
        Me.CbTyp.DataSource = Me.TypBindingSource
        Me.CbTyp.DisplayMember = "Typ"
        Me.CbTyp.FormattingEnabled = True
        Me.CbTyp.Location = New System.Drawing.Point(174, 370)
        Me.CbTyp.Name = "CbTyp"
        Me.CbTyp.Size = New System.Drawing.Size(150, 21)
        Me.CbTyp.TabIndex = 277
        Me.CbTyp.ValueMember = "id"
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
        'TypBindingSource
        '
        Me.TypBindingSource.DataMember = "Typ"
        Me.TypBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbStatus
        '
        Me.CbStatus.BackColor = System.Drawing.Color.Moccasin
        Me.CbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Status", True))
        Me.CbStatus.DataSource = Me.StatusBindingSource
        Me.CbStatus.DisplayMember = "Status"
        Me.CbStatus.FormattingEnabled = True
        Me.CbStatus.Location = New System.Drawing.Point(174, 396)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(150, 21)
        Me.CbStatus.TabIndex = 276
        Me.CbStatus.ValueMember = "id"
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAblage
        '
        Me.CbAblage.BackColor = System.Drawing.Color.Moccasin
        Me.CbAblage.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Ablage", True))
        Me.CbAblage.DataSource = Me.AblageBindingSource
        Me.CbAblage.DisplayMember = "Ablage"
        Me.CbAblage.FormattingEnabled = True
        Me.CbAblage.Location = New System.Drawing.Point(174, 343)
        Me.CbAblage.Name = "CbAblage"
        Me.CbAblage.Size = New System.Drawing.Size(150, 21)
        Me.CbAblage.TabIndex = 275
        Me.CbAblage.ValueMember = "Nummer"
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbEmpfaenger
        '
        Me.CbEmpfaenger.BackColor = System.Drawing.Color.Moccasin
        Me.CbEmpfaenger.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.CbEmpfaenger.DataSource = Me.AnschriftenBindingSource1
        Me.CbEmpfaenger.DisplayMember = "Name_"
        Me.CbEmpfaenger.FormattingEnabled = True
        Me.CbEmpfaenger.Location = New System.Drawing.Point(174, 212)
        Me.CbEmpfaenger.Name = "CbEmpfaenger"
        Me.CbEmpfaenger.Size = New System.Drawing.Size(150, 21)
        Me.CbEmpfaenger.TabIndex = 274
        Me.CbEmpfaenger.ValueMember = "id"
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAbsender
        '
        Me.CbAbsender.BackColor = System.Drawing.Color.Moccasin
        Me.CbAbsender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Absender", True))
        Me.CbAbsender.DataSource = Me.AnschriftenBindingSource
        Me.CbAbsender.DisplayMember = "Name_"
        Me.CbAbsender.FormattingEnabled = True
        Me.CbAbsender.Location = New System.Drawing.Point(174, 186)
        Me.CbAbsender.Name = "CbAbsender"
        Me.CbAbsender.Size = New System.Drawing.Size(150, 21)
        Me.CbAbsender.TabIndex = 273
        Me.CbAbsender.ValueMember = "id"
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbVorgang
        '
        Me.CbVorgang.BackColor = System.Drawing.Color.Moccasin
        Me.CbVorgang.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Vorgang", True))
        Me.CbVorgang.DataSource = Me.VorgaengeBindingSource
        Me.CbVorgang.DisplayMember = "Vorgang"
        Me.CbVorgang.FormattingEnabled = True
        Me.CbVorgang.Location = New System.Drawing.Point(165, 56)
        Me.CbVorgang.Name = "CbVorgang"
        Me.CbVorgang.Size = New System.Drawing.Size(159, 21)
        Me.CbVorgang.TabIndex = 272
        Me.CbVorgang.ValueMember = "id"
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAkte
        '
        Me.CbAkte.BackColor = System.Drawing.Color.Moccasin
        Me.CbAkte.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Akte", True))
        Me.CbAkte.DataSource = Me.AktenBindingSource
        Me.CbAkte.DisplayMember = "Akte"
        Me.CbAkte.FormattingEnabled = True
        Me.CbAkte.Location = New System.Drawing.Point(165, 30)
        Me.CbAkte.Name = "CbAkte"
        Me.CbAkte.Size = New System.Drawing.Size(159, 21)
        Me.CbAkte.TabIndex = 271
        Me.CbAkte.ValueMember = "id"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbMandant
        '
        Me.CbMandant.BackColor = System.Drawing.Color.Moccasin
        Me.CbMandant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Mandant", True))
        Me.CbMandant.DataSource = Me.MandantBindingSource
        Me.CbMandant.DisplayMember = "Mandant"
        Me.CbMandant.FormattingEnabled = True
        Me.CbMandant.Location = New System.Drawing.Point(165, 3)
        Me.CbMandant.Name = "CbMandant"
        Me.CbMandant.Size = New System.Drawing.Size(159, 21)
        Me.CbMandant.TabIndex = 270
        Me.CbMandant.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'lboxSaveAtt
        '
        Me.lboxSaveAtt.FormattingEnabled = True
        Me.lboxSaveAtt.Location = New System.Drawing.Point(39, 530)
        Me.lboxSaveAtt.Name = "lboxSaveAtt"
        Me.lboxSaveAtt.Size = New System.Drawing.Size(285, 43)
        Me.lboxSaveAtt.TabIndex = 269
        '
        'AufgenommenTextBox
        '
        Me.AufgenommenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.AufgenommenTextBox.Location = New System.Drawing.Point(125, 266)
        Me.AufgenommenTextBox.Name = "AufgenommenTextBox"
        Me.AufgenommenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AufgenommenTextBox.TabIndex = 50
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(125, 240)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokDatumTextBox.TabIndex = 49
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(125, 5)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.Size = New System.Drawing.Size(31, 20)
        Me.MandantTextBox.TabIndex = 3
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(125, 31)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(31, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(125, 57)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(31, 20)
        Me.VorgangTextBox.TabIndex = 7
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(125, 83)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(125, 109)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BetreffTextBox.TabIndex = 11
        '
        'BetragTextBox
        '
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True))
        Me.BetragTextBox.Location = New System.Drawing.Point(125, 135)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BetragTextBox.TabIndex = 13
        '
        'AnlagenTextBox
        '
        Me.AnlagenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Anlagen", True))
        Me.AnlagenTextBox.Location = New System.Drawing.Point(125, 161)
        Me.AnlagenTextBox.Name = "AnlagenTextBox"
        Me.AnlagenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AnlagenTextBox.TabIndex = 15
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Absender", True))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(125, 187)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.Size = New System.Drawing.Size(31, 20)
        Me.AbsenderTextBox.TabIndex = 17
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(125, 213)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(31, 20)
        Me.EmpfaengerTextBox.TabIndex = 19
        '
        'DokDatumDateTimePicker
        '
        Me.DokDatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DokDatumDateTimePicker.Location = New System.Drawing.Point(236, 239)
        Me.DokDatumDateTimePicker.Name = "DokDatumDateTimePicker"
        Me.DokDatumDateTimePicker.Size = New System.Drawing.Size(89, 20)
        Me.DokDatumDateTimePicker.TabIndex = 21
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(125, 292)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.Size = New System.Drawing.Size(200, 46)
        Me.KommentarTextBox.TabIndex = 27
        '
        'AblageTextBox
        '
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Ablage", True))
        Me.AblageTextBox.Location = New System.Drawing.Point(125, 344)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.Size = New System.Drawing.Size(31, 20)
        Me.AblageTextBox.TabIndex = 31
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(125, 370)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.Size = New System.Drawing.Size(31, 20)
        Me.TypTextBox.TabIndex = 33
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(125, 396)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(31, 20)
        Me.StatusTextBox.TabIndex = 35
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(125, 422)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DokNameTextBox.TabIndex = 37
        '
        'IstAnlageCheckBox
        '
        Me.IstAnlageCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DokumenteBindingSource, "istAnlage", True))
        Me.IstAnlageCheckBox.Location = New System.Drawing.Point(125, 448)
        Me.IstAnlageCheckBox.Name = "IstAnlageCheckBox"
        Me.IstAnlageCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.IstAnlageCheckBox.TabIndex = 39
        Me.IstAnlageCheckBox.Text = "CheckBox1"
        Me.IstAnlageCheckBox.UseVisualStyleBackColor = True
        '
        'AnlagenIDTextBox
        '
        Me.AnlagenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "AnlagenID", True))
        Me.AnlagenIDTextBox.Location = New System.Drawing.Point(125, 478)
        Me.AnlagenIDTextBox.Name = "AnlagenIDTextBox"
        Me.AnlagenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AnlagenIDTextBox.TabIndex = 41
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(125, 504)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BearbVermerkTextBox.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btWeiterZuordnung)
        Me.Panel2.Controls.Add(Me.lbSpeichstatus)
        Me.Panel2.Controls.Add(Me.BtSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 657)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(406, 55)
        Me.Panel2.TabIndex = 2
        '
        'btWeiterZuordnung
        '
        Me.btWeiterZuordnung.Location = New System.Drawing.Point(211, 10)
        Me.btWeiterZuordnung.Name = "btWeiterZuordnung"
        Me.btWeiterZuordnung.Size = New System.Drawing.Size(75, 34)
        Me.btWeiterZuordnung.TabIndex = 55
        Me.btWeiterZuordnung.Text = "Weitere Zuordnung"
        Me.btWeiterZuordnung.UseVisualStyleBackColor = True
        '
        'lbSpeichstatus
        '
        Me.lbSpeichstatus.AutoSize = True
        Me.lbSpeichstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSpeichstatus.Location = New System.Drawing.Point(9, 19)
        Me.lbSpeichstatus.Name = "lbSpeichstatus"
        Me.lbSpeichstatus.Size = New System.Drawing.Size(111, 16)
        Me.lbSpeichstatus.TabIndex = 54
        Me.lbSpeichstatus.Text = "Speicherstatus"
        '
        'BtSave
        '
        Me.BtSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSave.Location = New System.Drawing.Point(292, 6)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(104, 42)
        Me.BtSave.TabIndex = 0
        Me.BtSave.Text = "Übernehmen"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtAendern)
        Me.Panel4.Controls.Add(Me.btChangeOrdner)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(827, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(343, 65)
        Me.Panel4.TabIndex = 62
        '
        'txtAendern
        '
        Me.txtAendern.BackColor = System.Drawing.SystemColors.Control
        Me.txtAendern.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAendern.Location = New System.Drawing.Point(9, 9)
        Me.txtAendern.Multiline = True
        Me.txtAendern.Name = "txtAendern"
        Me.txtAendern.Size = New System.Drawing.Size(247, 38)
        Me.txtAendern.TabIndex = 62
        Me.txtAendern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btChangeOrdner
        '
        Me.btChangeOrdner.Location = New System.Drawing.Point(268, 9)
        Me.btChangeOrdner.Name = "btChangeOrdner"
        Me.btChangeOrdner.Size = New System.Drawing.Size(75, 19)
        Me.btChangeOrdner.TabIndex = 61
        Me.btChangeOrdner.Text = "Ändern"
        Me.btChangeOrdner.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Controls.Add(Me.FdDatenIDTextBox)
        Me.Panel3.Controls.Add(Me.TextBox2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(406, 65)
        Me.Panel3.TabIndex = 63
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(252, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 59
        '
        'FdDatenIDTextBox
        '
        Me.FdDatenIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.FdDatenIDTextBox.Location = New System.Drawing.Point(39, 22)
        Me.FdDatenIDTextBox.Name = "FdDatenIDTextBox"
        Me.FdDatenIDTextBox.ReadOnly = True
        Me.FdDatenIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FdDatenIDTextBox.TabIndex = 58
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(146, 22)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 57
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(415, 74)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(406, 577)
        Me.TabControl1.TabIndex = 64
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(398, 551)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "PDF"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(392, 545)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(398, 551)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Roh-OCR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.InhaltOCRTextBox)
        Me.Panel5.Controls.Add(Me.IdTextBox)
        Me.Panel5.Controls.Add(IdLabel)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(415, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(406, 65)
        Me.Panel5.TabIndex = 65
        '
        'InhaltOCRTextBox
        '
        Me.InhaltOCRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "InhaltOCR", True))
        Me.InhaltOCRTextBox.Location = New System.Drawing.Point(36, 29)
        Me.InhaltOCRTextBox.Multiline = True
        Me.InhaltOCRTextBox.Name = "InhaltOCRTextBox"
        Me.InhaltOCRTextBox.Size = New System.Drawing.Size(297, 29)
        Me.InhaltOCRTextBox.TabIndex = 1
        Me.InhaltOCRTextBox.Visible = False
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(121, 3)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(200, 20)
        Me.IdTextBox.TabIndex = 1
        Me.IdTextBox.Visible = False
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(Me.BtClose)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(827, 657)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(343, 55)
        Me.Panel6.TabIndex = 67
        '
        'BtClose
        '
        Me.BtClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtClose.Location = New System.Drawing.Point(9, 6)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(104, 42)
        Me.BtClose.TabIndex = 66
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList1.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Nothing
        Me.TableAdapterManager.AktenTableAdapter = Nothing
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Nothing
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Nothing
        Me.TableAdapterManager.VorlagenTableAdapter = Me.VorlagenTableAdapter
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'VorlagenTableAdapter
        '
        Me.VorlagenTableAdapter.ClearBeforeFill = True
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'TypTableAdapter
        '
        Me.TypTableAdapter.ClearBeforeFill = True
        '
        'VorlagenBindingSource
        '
        Me.VorlagenBindingSource.DataMember = "Vorlagen"
        Me.VorlagenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'Panel7
        '
        Me.Panel7.AutoScroll = True
        Me.Panel7.Controls.Add(InhaltOCRLabel)
        Me.Panel7.Controls.Add(Me.InhaltOCRTextBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(415, 657)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(406, 55)
        Me.Panel7.TabIndex = 68
        '
        'InhaltOCRLabel
        '
        InhaltOCRLabel.AutoSize = True
        InhaltOCRLabel.Location = New System.Drawing.Point(30, 26)
        InhaltOCRLabel.Name = "InhaltOCRLabel"
        InhaltOCRLabel.Size = New System.Drawing.Size(62, 13)
        InhaltOCRLabel.TabIndex = 0
        InhaltOCRLabel.Text = "Inhalt OCR:"
        '
        'InhaltOCRTextBox1
        '
        Me.InhaltOCRTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "InhaltOCR", True))
        Me.InhaltOCRTextBox1.Location = New System.Drawing.Point(98, 23)
        Me.InhaltOCRTextBox1.Name = "InhaltOCRTextBox1"
        Me.InhaltOCRTextBox1.Size = New System.Drawing.Size(267, 20)
        Me.InhaltOCRTextBox1.TabIndex = 1
        '
        'ScanInput2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 715)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ScanInput2"
        Me.Text = "ScanInput2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.Panel7.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents LvDoc As ListView
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents AnlagenTextBox As TextBox
    Friend WithEvents AbsenderTextBox As TextBox
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents DokDatumDateTimePicker As DateTimePicker
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents TypTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents IstAnlageCheckBox As CheckBox
    Friend WithEvents AnlagenIDTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtSave As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtAendern As TextBox
    Friend WithEvents btChangeOrdner As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents FdDatenIDTextBox As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents lbSpeichstatus As Label
    Friend WithEvents btWeiterZuordnung As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents AufgenommenTextBox As TextBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents lboxSaveAtt As ListBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents CbMandant As ComboBox
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents CbAkte As ComboBox
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents CbVorgang As ComboBox
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents CbAbsender As ComboBox
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents CbEmpfaenger As ComboBox
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
    Friend WithEvents CbAblage As ComboBox
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents CbStatus As ComboBox
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents CbTyp As ComboBox
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents Panel6 As Panel
    Friend WithEvents BtClose As Button
    Friend WithEvents VorlagenBindingSource As BindingSource
    Friend WithEvents VorlagenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter
    Friend WithEvents InhaltOCRTextBox As TextBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents InhaltOCRTextBox1 As TextBox
End Class
