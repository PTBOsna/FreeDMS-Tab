<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FolderInput
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim IdLabel As System.Windows.Forms.Label
        Dim MandantLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
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
        Dim AnlagenLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.LvDoc = New System.Windows.Forms.ListView()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.AnlagenTextBox = New System.Windows.Forms.TextBox()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.IstAnlageTextBox = New System.Windows.Forms.TextBox()
        Me.CbEmpfaenger = New System.Windows.Forms.ComboBox()
        Me.CbAbsender = New System.Windows.Forms.ComboBox()
        Me.CbStatus = New System.Windows.Forms.ComboBox()
        Me.CbTyp = New System.Windows.Forms.ComboBox()
        Me.CbAblage = New System.Windows.Forms.ComboBox()
        Me.DateTimePickerDokDatum = New System.Windows.Forms.DateTimePicker()
        Me.CbVorgang = New System.Windows.Forms.ComboBox()
        Me.GVAttList = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CbAkte = New System.Windows.Forms.ComboBox()
        Me.InhaltOCRTextBox = New System.Windows.Forms.TextBox()
        Me.lbSpeichstatus = New System.Windows.Forms.Label()
        Me.CbMandant = New System.Windows.Forms.ComboBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.AufgenommenTextBox = New System.Windows.Forms.TextBox()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.IstAnlageCheckBox = New System.Windows.Forms.CheckBox()
        Me.AnlagenIDTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btWeiterZuordnung = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.lboxSaveAtt = New System.Windows.Forms.ListBox()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.BtOCRChange = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.RichTextBoxOCR = New System.Windows.Forms.RichTextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.LbInBearb = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.PanelBGW = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.txtAendern = New System.Windows.Forms.TextBox()
        Me.btChangeOrdner = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.AnlagenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnlagenTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.VorlagenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.VorlagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnlagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        IdLabel = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
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
        AnlagenLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GVAttList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.PanelBGW.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnlagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(292, 25)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(25, 9)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(52, 13)
        MandantLabel.TabIndex = 2
        MandantLabel.Text = "Mandant:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(25, 35)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(25, 61)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 6
        VorgangLabel.Text = "Vorgang:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(25, 87)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(25, 113)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 10
        BetreffLabel.Text = "Betreff:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(25, 139)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 12
        BetragLabel.Text = "Betrag:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(25, 165)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(55, 13)
        AbsenderLabel.TabIndex = 16
        AbsenderLabel.Text = "Absender:"
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Location = New System.Drawing.Point(25, 191)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(67, 13)
        EmpfaengerLabel.TabIndex = 18
        EmpfaengerLabel.Text = "Empfaenger:"
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(25, 217)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(64, 13)
        DokDatumLabel.TabIndex = 20
        DokDatumLabel.Text = "Dok Datum:"
        '
        'AufgenommenLabel
        '
        AufgenommenLabel.AutoSize = True
        AufgenommenLabel.Location = New System.Drawing.Point(25, 243)
        AufgenommenLabel.Name = "AufgenommenLabel"
        AufgenommenLabel.Size = New System.Drawing.Size(78, 13)
        AufgenommenLabel.TabIndex = 22
        AufgenommenLabel.Text = "Aufgenommen:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(25, 269)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 26
        KommentarLabel.Text = "Kommentar:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(25, 326)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 30
        AblageLabel.Text = "Ablage:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(25, 352)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(28, 13)
        TypLabel.TabIndex = 32
        TypLabel.Text = "Typ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(25, 378)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 34
        StatusLabel.Text = "Status:"
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Location = New System.Drawing.Point(25, 404)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(61, 13)
        DokNameLabel.TabIndex = 36
        DokNameLabel.Text = "Dok Name:"
        '
        'IstAnlageLabel
        '
        IstAnlageLabel.AutoSize = True
        IstAnlageLabel.Location = New System.Drawing.Point(25, 485)
        IstAnlageLabel.Name = "IstAnlageLabel"
        IstAnlageLabel.Size = New System.Drawing.Size(56, 13)
        IstAnlageLabel.TabIndex = 38
        IstAnlageLabel.Text = "ist Anlage:"
        '
        'AnlagenIDLabel
        '
        AnlagenIDLabel.AutoSize = True
        AnlagenIDLabel.Location = New System.Drawing.Point(25, 513)
        AnlagenIDLabel.Name = "AnlagenIDLabel"
        AnlagenIDLabel.Size = New System.Drawing.Size(63, 13)
        AnlagenIDLabel.TabIndex = 40
        AnlagenIDLabel.Text = "Anlagen ID:"
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Location = New System.Drawing.Point(25, 432)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(80, 13)
        BearbVermerkLabel.TabIndex = 42
        BearbVermerkLabel.Text = "Bearb Vermerk:"
        '
        'InhaltOCRLabel
        '
        InhaltOCRLabel.AutoSize = True
        InhaltOCRLabel.Location = New System.Drawing.Point(25, 458)
        InhaltOCRLabel.Name = "InhaltOCRLabel"
        InhaltOCRLabel.Size = New System.Drawing.Size(62, 13)
        InhaltOCRLabel.TabIndex = 49
        InhaltOCRLabel.Text = "Inhalt OCR:"
        '
        'AnlagenLabel
        '
        AnlagenLabel.AutoSize = True
        AnlagenLabel.Location = New System.Drawing.Point(204, 485)
        AnlagenLabel.Name = "AnlagenLabel"
        AnlagenLabel.Size = New System.Drawing.Size(49, 13)
        AnlagenLabel.TabIndex = 58
        AnlagenLabel.Text = "Anlagen:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.10592!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 53.89408!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 340.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.LvDoc, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PanelBGW, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.079268!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.92073!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1118, 753)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'LvDoc
        '
        Me.LvDoc.ContextMenuStrip = Me.ContextMenuStrip1
        Me.LvDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LvDoc.Location = New System.Drawing.Point(780, 59)
        Me.LvDoc.Name = "LvDoc"
        Me.LvDoc.Size = New System.Drawing.Size(335, 639)
        Me.LvDoc.TabIndex = 0
        Me.LvDoc.UseCompatibleStateImageBehavior = False
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem1, Me.ToolStripMenuItem2})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(121, 48)
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem1.Text = "Ansehen"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(120, 22)
        Me.ToolStripMenuItem2.Text = "Löschen"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(AnlagenLabel)
        Me.Panel1.Controls.Add(Me.AnlagenTextBox)
        Me.Panel1.Controls.Add(Me.IstAnlageTextBox)
        Me.Panel1.Controls.Add(Me.CbEmpfaenger)
        Me.Panel1.Controls.Add(Me.CbAbsender)
        Me.Panel1.Controls.Add(Me.CbStatus)
        Me.Panel1.Controls.Add(Me.CbTyp)
        Me.Panel1.Controls.Add(Me.CbAblage)
        Me.Panel1.Controls.Add(Me.DateTimePickerDokDatum)
        Me.Panel1.Controls.Add(Me.CbVorgang)
        Me.Panel1.Controls.Add(Me.GVAttList)
        Me.Panel1.Controls.Add(Me.CbAkte)
        Me.Panel1.Controls.Add(InhaltOCRLabel)
        Me.Panel1.Controls.Add(Me.InhaltOCRTextBox)
        Me.Panel1.Controls.Add(Me.lbSpeichstatus)
        Me.Panel1.Controls.Add(Me.CbMandant)
        Me.Panel1.Controls.Add(MandantLabel)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(VorgangLabel)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(Me.DokumentTextBox)
        Me.Panel1.Controls.Add(BetreffLabel)
        Me.Panel1.Controls.Add(Me.BetreffTextBox)
        Me.Panel1.Controls.Add(BetragLabel)
        Me.Panel1.Controls.Add(Me.BetragTextBox)
        Me.Panel1.Controls.Add(AbsenderLabel)
        Me.Panel1.Controls.Add(EmpfaengerLabel)
        Me.Panel1.Controls.Add(DokDatumLabel)
        Me.Panel1.Controls.Add(Me.DokDatumTextBox)
        Me.Panel1.Controls.Add(AufgenommenLabel)
        Me.Panel1.Controls.Add(Me.AufgenommenTextBox)
        Me.Panel1.Controls.Add(KommentarLabel)
        Me.Panel1.Controls.Add(Me.KommentarTextBox)
        Me.Panel1.Controls.Add(AblageLabel)
        Me.Panel1.Controls.Add(TypLabel)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(DokNameLabel)
        Me.Panel1.Controls.Add(Me.DokNameTextBox)
        Me.Panel1.Controls.Add(IstAnlageLabel)
        Me.Panel1.Controls.Add(Me.IstAnlageCheckBox)
        Me.Panel1.Controls.Add(AnlagenIDLabel)
        Me.Panel1.Controls.Add(Me.AnlagenIDTextBox)
        Me.Panel1.Controls.Add(BearbVermerkLabel)
        Me.Panel1.Controls.Add(Me.BearbVermerkTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 59)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(352, 639)
        Me.Panel1.TabIndex = 1
        '
        'AnlagenTextBox
        '
        Me.AnlagenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Anlagen", True))
        Me.AnlagenTextBox.Location = New System.Drawing.Point(259, 482)
        Me.AnlagenTextBox.Name = "AnlagenTextBox"
        Me.AnlagenTextBox.Size = New System.Drawing.Size(54, 20)
        Me.AnlagenTextBox.TabIndex = 59
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'IstAnlageTextBox
        '
        Me.IstAnlageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "istAnlage", True))
        Me.IstAnlageTextBox.Location = New System.Drawing.Point(139, 482)
        Me.IstAnlageTextBox.Name = "IstAnlageTextBox"
        Me.IstAnlageTextBox.ReadOnly = True
        Me.IstAnlageTextBox.Size = New System.Drawing.Size(58, 20)
        Me.IstAnlageTextBox.TabIndex = 57
        '
        'CbEmpfaenger
        '
        Me.CbEmpfaenger.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.CbEmpfaenger.DataSource = Me.AnschriftenBindingSource1
        Me.CbEmpfaenger.DisplayMember = "Name_"
        Me.CbEmpfaenger.FormattingEnabled = True
        Me.CbEmpfaenger.Location = New System.Drawing.Point(113, 188)
        Me.CbEmpfaenger.Name = "CbEmpfaenger"
        Me.CbEmpfaenger.Size = New System.Drawing.Size(200, 21)
        Me.CbEmpfaenger.TabIndex = 58
        Me.CbEmpfaenger.ValueMember = "id"
        '
        'CbAbsender
        '
        Me.CbAbsender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbAbsender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbAbsender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Absender", True))
        Me.CbAbsender.DataSource = Me.AnschriftenBindingSource
        Me.CbAbsender.DisplayMember = "Name_"
        Me.CbAbsender.FormattingEnabled = True
        Me.CbAbsender.Location = New System.Drawing.Point(113, 162)
        Me.CbAbsender.Name = "CbAbsender"
        Me.CbAbsender.Size = New System.Drawing.Size(200, 21)
        Me.CbAbsender.TabIndex = 57
        Me.CbAbsender.ValueMember = "id"
        '
        'CbStatus
        '
        Me.CbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbStatus.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Status", True))
        Me.CbStatus.DataSource = Me.StatusBindingSource
        Me.CbStatus.DisplayMember = "Status"
        Me.CbStatus.FormattingEnabled = True
        Me.CbStatus.Location = New System.Drawing.Point(113, 374)
        Me.CbStatus.Name = "CbStatus"
        Me.CbStatus.Size = New System.Drawing.Size(200, 21)
        Me.CbStatus.TabIndex = 56
        Me.CbStatus.ValueMember = "id"
        '
        'CbTyp
        '
        Me.CbTyp.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbTyp.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbTyp.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Typ", True))
        Me.CbTyp.DataSource = Me.TypBindingSource
        Me.CbTyp.DisplayMember = "Typ"
        Me.CbTyp.FormattingEnabled = True
        Me.CbTyp.Location = New System.Drawing.Point(113, 348)
        Me.CbTyp.Name = "CbTyp"
        Me.CbTyp.Size = New System.Drawing.Size(200, 21)
        Me.CbTyp.TabIndex = 55
        Me.CbTyp.ValueMember = "id"
        '
        'CbAblage
        '
        Me.CbAblage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.CbAblage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CbAblage.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Ablage", True))
        Me.CbAblage.DataSource = Me.AblageBindingSource
        Me.CbAblage.DisplayMember = "Ablage"
        Me.CbAblage.FormattingEnabled = True
        Me.CbAblage.Location = New System.Drawing.Point(113, 322)
        Me.CbAblage.Name = "CbAblage"
        Me.CbAblage.Size = New System.Drawing.Size(200, 21)
        Me.CbAblage.TabIndex = 54
        Me.CbAblage.ValueMember = "Nummer"
        '
        'DateTimePickerDokDatum
        '
        Me.DateTimePickerDokDatum.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePickerDokDatum.Location = New System.Drawing.Point(226, 214)
        Me.DateTimePickerDokDatum.Name = "DateTimePickerDokDatum"
        Me.DateTimePickerDokDatum.Size = New System.Drawing.Size(87, 20)
        Me.DateTimePickerDokDatum.TabIndex = 53
        '
        'CbVorgang
        '
        Me.CbVorgang.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Vorgang", True))
        Me.CbVorgang.DataSource = Me.VorgaengeBindingSource
        Me.CbVorgang.DisplayMember = "Vorgang"
        Me.CbVorgang.FormattingEnabled = True
        Me.CbVorgang.Location = New System.Drawing.Point(113, 57)
        Me.CbVorgang.Name = "CbVorgang"
        Me.CbVorgang.Size = New System.Drawing.Size(200, 21)
        Me.CbVorgang.TabIndex = 52
        Me.CbVorgang.ValueMember = "id"
        '
        'GVAttList
        '
        Me.GVAttList.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GVAttList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GVAttList.ColumnHeadersVisible = False
        Me.GVAttList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.GVAttList.Location = New System.Drawing.Point(28, 536)
        Me.GVAttList.Name = "GVAttList"
        Me.GVAttList.RowHeadersVisible = False
        Me.GVAttList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.GVAttList.Size = New System.Drawing.Size(285, 70)
        Me.GVAttList.TabIndex = 9
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column1.HeaderText = "Column1"
        Me.Column1.Name = "Column1"
        '
        'CbAkte
        '
        Me.CbAkte.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Akte", True))
        Me.CbAkte.DataSource = Me.AktenBindingSource
        Me.CbAkte.DisplayMember = "Akte"
        Me.CbAkte.FormattingEnabled = True
        Me.CbAkte.Location = New System.Drawing.Point(113, 31)
        Me.CbAkte.Name = "CbAkte"
        Me.CbAkte.Size = New System.Drawing.Size(200, 21)
        Me.CbAkte.TabIndex = 51
        Me.CbAkte.ValueMember = "id"
        '
        'InhaltOCRTextBox
        '
        Me.InhaltOCRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "InhaltOCR", True))
        Me.InhaltOCRTextBox.Location = New System.Drawing.Point(113, 455)
        Me.InhaltOCRTextBox.Name = "InhaltOCRTextBox"
        Me.InhaltOCRTextBox.Size = New System.Drawing.Size(200, 20)
        Me.InhaltOCRTextBox.TabIndex = 50
        '
        'lbSpeichstatus
        '
        Me.lbSpeichstatus.AutoSize = True
        Me.lbSpeichstatus.Location = New System.Drawing.Point(25, 619)
        Me.lbSpeichstatus.Name = "lbSpeichstatus"
        Me.lbSpeichstatus.Size = New System.Drawing.Size(77, 13)
        Me.lbSpeichstatus.TabIndex = 49
        Me.lbSpeichstatus.Text = "Speicherstatus"
        '
        'CbMandant
        '
        Me.CbMandant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Mandant", True))
        Me.CbMandant.DataSource = Me.MandantBindingSource
        Me.CbMandant.DisplayMember = "Mandant"
        Me.CbMandant.FormattingEnabled = True
        Me.CbMandant.Location = New System.Drawing.Point(113, 6)
        Me.CbMandant.Name = "CbMandant"
        Me.CbMandant.Size = New System.Drawing.Size(200, 21)
        Me.CbMandant.TabIndex = 48
        Me.CbMandant.ValueMember = "id"
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(113, 84)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(113, 110)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BetreffTextBox.TabIndex = 11
        '
        'BetragTextBox
        '
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True))
        Me.BetragTextBox.Location = New System.Drawing.Point(113, 136)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BetragTextBox.TabIndex = 13
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(113, 214)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokDatumTextBox.TabIndex = 21
        '
        'AufgenommenTextBox
        '
        Me.AufgenommenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.AufgenommenTextBox.Location = New System.Drawing.Point(113, 240)
        Me.AufgenommenTextBox.Name = "AufgenommenTextBox"
        Me.AufgenommenTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AufgenommenTextBox.TabIndex = 23
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(113, 266)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.Size = New System.Drawing.Size(200, 50)
        Me.KommentarTextBox.TabIndex = 27
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(113, 401)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DokNameTextBox.TabIndex = 37
        '
        'IstAnlageCheckBox
        '
        Me.IstAnlageCheckBox.Location = New System.Drawing.Point(113, 480)
        Me.IstAnlageCheckBox.Name = "IstAnlageCheckBox"
        Me.IstAnlageCheckBox.Size = New System.Drawing.Size(45, 24)
        Me.IstAnlageCheckBox.TabIndex = 39
        Me.IstAnlageCheckBox.UseVisualStyleBackColor = True
        '
        'AnlagenIDTextBox
        '
        Me.AnlagenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "AnlagenID", True))
        Me.AnlagenIDTextBox.Location = New System.Drawing.Point(113, 510)
        Me.AnlagenIDTextBox.Name = "AnlagenIDTextBox"
        Me.AnlagenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AnlagenIDTextBox.TabIndex = 41
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(113, 429)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BearbVermerkTextBox.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.AutoScroll = True
        Me.Panel2.Controls.Add(Me.btWeiterZuordnung)
        Me.Panel2.Controls.Add(Me.BtSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 704)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(352, 46)
        Me.Panel2.TabIndex = 3
        '
        'btWeiterZuordnung
        '
        Me.btWeiterZuordnung.Location = New System.Drawing.Point(139, 6)
        Me.btWeiterZuordnung.Name = "btWeiterZuordnung"
        Me.btWeiterZuordnung.Size = New System.Drawing.Size(75, 34)
        Me.btWeiterZuordnung.TabIndex = 56
        Me.btWeiterZuordnung.Text = "Weitere Zuordnung"
        Me.btWeiterZuordnung.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(226, 5)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(101, 37)
        Me.BtSave.TabIndex = 2
        Me.BtSave.Text = "Übernehmen"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.BtClose)
        Me.Panel3.Controls.Add(Me.lboxSaveAtt)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(780, 704)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(335, 46)
        Me.Panel3.TabIndex = 4
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(24, 11)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(75, 23)
        Me.BtClose.TabIndex = 0
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'lboxSaveAtt
        '
        Me.lboxSaveAtt.FormattingEnabled = True
        Me.lboxSaveAtt.Location = New System.Drawing.Point(128, 11)
        Me.lboxSaveAtt.Name = "lboxSaveAtt"
        Me.lboxSaveAtt.Size = New System.Drawing.Size(138, 17)
        Me.lboxSaveAtt.TabIndex = 270
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(361, 59)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(413, 639)
        Me.TabControl1.TabIndex = 5
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(405, 613)
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
        Me.WebBrowser1.Size = New System.Drawing.Size(399, 607)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TabPage2.Controls.Add(Me.BtOCRChange)
        Me.TabPage2.Controls.Add(Me.Label2)
        Me.TabPage2.Controls.Add(Me.RichTextBoxOCR)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(405, 613)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OCR Ändern"
        '
        'BtOCRChange
        '
        Me.BtOCRChange.Location = New System.Drawing.Point(282, 17)
        Me.BtOCRChange.Name = "BtOCRChange"
        Me.BtOCRChange.Size = New System.Drawing.Size(75, 23)
        Me.BtOCRChange.TabIndex = 2
        Me.BtOCRChange.Text = "Ändern"
        Me.BtOCRChange.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(17, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 26)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Dieser Text wird übernommen. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sie können ggf. Änderungen vornehmen."
        '
        'RichTextBoxOCR
        '
        Me.RichTextBoxOCR.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.RichTextBoxOCR.Location = New System.Drawing.Point(3, 99)
        Me.RichTextBoxOCR.Name = "RichTextBoxOCR"
        Me.RichTextBoxOCR.Size = New System.Drawing.Size(399, 511)
        Me.RichTextBoxOCR.TabIndex = 0
        Me.RichTextBoxOCR.Text = ""
        '
        'Panel4
        '
        Me.Panel4.AutoScroll = True
        Me.Panel4.Controls.Add(Me.LbInBearb)
        Me.Panel4.Controls.Add(Me.IdTextBox)
        Me.Panel4.Controls.Add(IdLabel)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(352, 50)
        Me.Panel4.TabIndex = 6
        '
        'LbInBearb
        '
        Me.LbInBearb.AutoSize = True
        Me.LbInBearb.Location = New System.Drawing.Point(16, 17)
        Me.LbInBearb.Name = "LbInBearb"
        Me.LbInBearb.Size = New System.Drawing.Size(79, 13)
        Me.LbInBearb.TabIndex = 2
        Me.LbInBearb.Text = "In Bearbeitung:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(316, 22)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(33, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'PanelBGW
        '
        Me.PanelBGW.Controls.Add(Me.Label1)
        Me.PanelBGW.Controls.Add(Me.ProgressBar1)
        Me.PanelBGW.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PanelBGW.Location = New System.Drawing.Point(361, 3)
        Me.PanelBGW.Name = "PanelBGW"
        Me.PanelBGW.Size = New System.Drawing.Size(413, 50)
        Me.PanelBGW.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(17, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Texterkennung läuft..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(142, 10)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(265, 19)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 0
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.txtAendern)
        Me.Panel5.Controls.Add(Me.btChangeOrdner)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(780, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(335, 50)
        Me.Panel5.TabIndex = 8
        '
        'txtAendern
        '
        Me.txtAendern.BackColor = System.Drawing.SystemColors.Control
        Me.txtAendern.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAendern.Location = New System.Drawing.Point(2, 4)
        Me.txtAendern.Multiline = True
        Me.txtAendern.Name = "txtAendern"
        Me.txtAendern.Size = New System.Drawing.Size(247, 38)
        Me.txtAendern.TabIndex = 64
        Me.txtAendern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btChangeOrdner
        '
        Me.btChangeOrdner.Location = New System.Drawing.Point(255, 12)
        Me.btChangeOrdner.Name = "btChangeOrdner"
        Me.btChangeOrdner.Size = New System.Drawing.Size(75, 19)
        Me.btChangeOrdner.TabIndex = 63
        Me.btChangeOrdner.Text = "Ändern"
        Me.btChangeOrdner.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(361, 704)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(413, 46)
        Me.Panel6.TabIndex = 9
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
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'AnlagenTableAdapter
        '
        Me.AnlagenTableAdapter.ClearBeforeFill = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'VorlagenTableAdapter
        '
        Me.VorlagenTableAdapter.ClearBeforeFill = True
        '
        'TypTableAdapter
        '
        Me.TypTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'BackgroundWorker1
        '
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
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
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
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
        'VorlagenBindingSource
        '
        Me.VorlagenBindingSource.DataMember = "Vorlagen"
        Me.VorlagenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AnlagenBindingSource
        '
        Me.AnlagenBindingSource.DataMember = "Anlagen"
        Me.AnlagenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'FolderInput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1118, 753)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "FolderInput"
        Me.Text = "FreeDMS-Tab - Übernahme Dokumente"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GVAttList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.PanelBGW.ResumeLayout(False)
        Me.PanelBGW.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnlagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents AufgenommenTextBox As TextBox
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents IstAnlageCheckBox As CheckBox
    Friend WithEvents AnlagenIDTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtSave As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents BtClose As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CbMandant As ComboBox
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents Panel4 As Panel
    Friend WithEvents lbSpeichstatus As Label
    Friend WithEvents InhaltOCRTextBox As TextBox
    Friend WithEvents RichTextBoxOCR As RichTextBox
    Friend WithEvents CbAkte As ComboBox
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents CbVorgang As ComboBox
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents DateTimePickerDokDatum As DateTimePicker
    Friend WithEvents CbAblage As ComboBox
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents CbTyp As ComboBox
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents CbStatus As ComboBox
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents CbEmpfaenger As ComboBox
    Friend WithEvents CbAbsender As ComboBox
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents BtOCRChange As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents btWeiterZuordnung As Button
    Friend WithEvents VorlagenBindingSource As BindingSource
    Friend WithEvents VorlagenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter
    Friend WithEvents lboxSaveAtt As ListBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents PanelBGW As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel5 As Panel
    Friend WithEvents txtAendern As TextBox
    Friend WithEvents btChangeOrdner As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents AnlagenBindingSource As BindingSource
    Friend WithEvents AnlagenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnlagenTableAdapter
    Friend WithEvents LbInBearb As Label
    Friend WithEvents IstAnlageTextBox As TextBox
    Friend WithEvents GVAttList As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents AnlagenTextBox As TextBox
    Friend WithEvents Panel6 As Panel
End Class
