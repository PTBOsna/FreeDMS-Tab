<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Scaninput
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
        Dim AnlagenLabel1 As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim MandantLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
        Dim FdAufgenommenLabel As System.Windows.Forms.Label
        Dim AbsenderLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim FdErstelltLabel As System.Windows.Forms.Label
        Dim FdFundstelleLabel As System.Windows.Forms.Label
        Dim FdTypLabel As System.Windows.Forms.Label
        Dim FdGdStatusLabel As System.Windows.Forms.Label
        Dim FdEmpfaengerLabel As System.Windows.Forms.Label
        Dim FdBearbeitungsVermerkLabel As System.Windows.Forms.Label
        Dim AnlagenIDLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser2 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.cbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbVorgang = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbAkteNeu = New System.Windows.Forms.ComboBox()
        Me.MandantAktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lboxSaveAtt = New System.Windows.Forms.ListBox()
        Me.AnlagenTextBox = New System.Windows.Forms.TextBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.cbAblage = New System.Windows.Forms.ComboBox()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.cbEmpfaenger = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenderTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.FdAufgenommenTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBoxNamen = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbStatus = New System.Windows.Forms.ComboBox()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbTyp = New System.Windows.Forms.ComboBox()
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FdErstelltDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.FdBearbeitungsVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.AnlagenIDTextBox = New System.Windows.Forms.TextBox()
        Me.lbSpeichstatus = New System.Windows.Forms.Label()
        Me.IstAnlageCheckBox = New System.Windows.Forms.CheckBox()
        Me.lvDoc = New System.Windows.Forms.ListView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btWeiterZuordnung = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.FdDatenIDTextBox = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.txtAendern = New System.Windows.Forms.TextBox()
        Me.btChangeOrdner = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.VorlagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorlagenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.ImageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.ContextMenuStripLvDokumente = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.AnsehenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LöschenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        AnlagenLabel1 = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
        FdAufgenommenLabel = New System.Windows.Forms.Label()
        AbsenderLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        FdErstelltLabel = New System.Windows.Forms.Label()
        FdFundstelleLabel = New System.Windows.Forms.Label()
        FdTypLabel = New System.Windows.Forms.Label()
        FdGdStatusLabel = New System.Windows.Forms.Label()
        FdEmpfaengerLabel = New System.Windows.Forms.Label()
        FdBearbeitungsVermerkLabel = New System.Windows.Forms.Label()
        AnlagenIDLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantAktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripLvDokumente.SuspendLayout()
        Me.SuspendLayout()
        '
        'AnlagenLabel1
        '
        AnlagenLabel1.AutoSize = True
        AnlagenLabel1.Location = New System.Drawing.Point(69, 478)
        AnlagenLabel1.Name = "AnlagenLabel1"
        AnlagenLabel1.Size = New System.Drawing.Size(49, 13)
        AnlagenLabel1.TabIndex = 266
        AnlagenLabel1.Text = "Anlagen:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(68, 140)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 265
        VorgangLabel.Text = "Vorgang:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(86, 114)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 264
        AkteLabel.Text = "Akte:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(72, 32)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 263
        MandantLabel.Text = "Bereich:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(77, 257)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 255
        BetragLabel.Text = "Betrag:"
        '
        'FdAufgenommenLabel
        '
        FdAufgenommenLabel.AutoSize = True
        FdAufgenommenLabel.Location = New System.Drawing.Point(40, 449)
        FdAufgenommenLabel.Name = "FdAufgenommenLabel"
        FdAufgenommenLabel.Size = New System.Drawing.Size(78, 13)
        FdAufgenommenLabel.TabIndex = 251
        FdAufgenommenLabel.Text = "Aufgenommen:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(63, 168)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(55, 13)
        AbsenderLabel.TabIndex = 8
        AbsenderLabel.Text = "Absender:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(77, 85)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 6
        BetreffLabel.Text = "Betreff:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(59, 59)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 4
        DokumentLabel.Text = "Dokument:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(55, 194)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 14
        KommentarLabel.Text = "Kommentar:"
        '
        'FdErstelltLabel
        '
        FdErstelltLabel.AutoSize = True
        FdErstelltLabel.Location = New System.Drawing.Point(28, 364)
        FdErstelltLabel.Name = "FdErstelltLabel"
        FdErstelltLabel.Size = New System.Drawing.Size(90, 13)
        FdErstelltLabel.TabIndex = 229
        FdErstelltLabel.Text = "Datum Dokument"
        '
        'FdFundstelleLabel
        '
        FdFundstelleLabel.AutoSize = True
        FdFundstelleLabel.Location = New System.Drawing.Point(75, 280)
        FdFundstelleLabel.Name = "FdFundstelleLabel"
        FdFundstelleLabel.Size = New System.Drawing.Size(43, 13)
        FdFundstelleLabel.TabIndex = 231
        FdFundstelleLabel.Text = "Ablage:"
        '
        'FdTypLabel
        '
        FdTypLabel.AutoSize = True
        FdTypLabel.Location = New System.Drawing.Point(64, 306)
        FdTypLabel.Name = "FdTypLabel"
        FdTypLabel.Size = New System.Drawing.Size(54, 13)
        FdTypLabel.TabIndex = 232
        FdTypLabel.Text = "Dok.-Typ:"
        '
        'FdGdStatusLabel
        '
        FdGdStatusLabel.AutoSize = True
        FdGdStatusLabel.Location = New System.Drawing.Point(78, 335)
        FdGdStatusLabel.Name = "FdGdStatusLabel"
        FdGdStatusLabel.Size = New System.Drawing.Size(40, 13)
        FdGdStatusLabel.TabIndex = 237
        FdGdStatusLabel.Text = "Status:"
        '
        'FdEmpfaengerLabel
        '
        FdEmpfaengerLabel.AutoSize = True
        FdEmpfaengerLabel.Location = New System.Drawing.Point(51, 393)
        FdEmpfaengerLabel.Name = "FdEmpfaengerLabel"
        FdEmpfaengerLabel.Size = New System.Drawing.Size(67, 13)
        FdEmpfaengerLabel.TabIndex = 238
        FdEmpfaengerLabel.Text = "Empfaenger:"
        '
        'FdBearbeitungsVermerkLabel
        '
        FdBearbeitungsVermerkLabel.AutoSize = True
        FdBearbeitungsVermerkLabel.Location = New System.Drawing.Point(35, 419)
        FdBearbeitungsVermerkLabel.Name = "FdBearbeitungsVermerkLabel"
        FdBearbeitungsVermerkLabel.Size = New System.Drawing.Size(83, 13)
        FdBearbeitungsVermerkLabel.TabIndex = 240
        FdBearbeitungsVermerkLabel.Text = "Bearb.-Vermerk:"
        '
        'AnlagenIDLabel
        '
        AnlagenIDLabel.AutoSize = True
        AnlagenIDLabel.Location = New System.Drawing.Point(55, 506)
        AnlagenIDLabel.Name = "AnlagenIDLabel"
        AnlagenIDLabel.Size = New System.Drawing.Size(63, 13)
        AnlagenIDLabel.TabIndex = 40
        AnlagenIDLabel.Text = "Anlagen ID:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(43, 15)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 350.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.lvDoc, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btClose, 2, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.67742!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.32258!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 8.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1135, 659)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(389, 61)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(380, 542)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.WebBrowser2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(372, 516)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dokument"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser2
        '
        Me.WebBrowser2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser2.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser2.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser2.Name = "WebBrowser2"
        Me.WebBrowser2.Size = New System.Drawing.Size(366, 510)
        Me.WebBrowser2.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(372, 516)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OCR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "InhaltOCR", True))
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(366, 510)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
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
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.cbMandant)
        Me.Panel1.Controls.Add(Me.cbVorgang)
        Me.Panel1.Controls.Add(Me.cbAkteNeu)
        Me.Panel1.Controls.Add(Me.lboxSaveAtt)
        Me.Panel1.Controls.Add(AnlagenLabel1)
        Me.Panel1.Controls.Add(Me.AnlagenTextBox)
        Me.Panel1.Controls.Add(VorgangLabel)
        Me.Panel1.Controls.Add(Me.VorgangTextBox)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(Me.AkteTextBox)
        Me.Panel1.Controls.Add(MandantLabel)
        Me.Panel1.Controls.Add(Me.MandantTextBox)
        Me.Panel1.Controls.Add(Me.cbAblage)
        Me.Panel1.Controls.Add(Me.DokDatumTextBox)
        Me.Panel1.Controls.Add(BetragLabel)
        Me.Panel1.Controls.Add(Me.BetragTextBox)
        Me.Panel1.Controls.Add(Me.cbEmpfaenger)
        Me.Panel1.Controls.Add(FdAufgenommenLabel)
        Me.Panel1.Controls.Add(AbsenderLabel)
        Me.Panel1.Controls.Add(BetreffLabel)
        Me.Panel1.Controls.Add(Me.EmpfaengerTextBox)
        Me.Panel1.Controls.Add(Me.StatusTextBox)
        Me.Panel1.Controls.Add(Me.TypTextBox)
        Me.Panel1.Controls.Add(Me.AblageTextBox)
        Me.Panel1.Controls.Add(Me.AbsenderTextBox)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(KommentarLabel)
        Me.Panel1.Controls.Add(Me.BetreffTextBox)
        Me.Panel1.Controls.Add(Me.KommentarTextBox)
        Me.Panel1.Controls.Add(Me.FdAufgenommenTextBox)
        Me.Panel1.Controls.Add(Me.DokumentTextBox)
        Me.Panel1.Controls.Add(Me.ComboBoxNamen)
        Me.Panel1.Controls.Add(Me.cbStatus)
        Me.Panel1.Controls.Add(Me.cbTyp)
        Me.Panel1.Controls.Add(FdErstelltLabel)
        Me.Panel1.Controls.Add(Me.FdErstelltDateTimePicker)
        Me.Panel1.Controls.Add(FdFundstelleLabel)
        Me.Panel1.Controls.Add(FdTypLabel)
        Me.Panel1.Controls.Add(FdGdStatusLabel)
        Me.Panel1.Controls.Add(FdEmpfaengerLabel)
        Me.Panel1.Controls.Add(FdBearbeitungsVermerkLabel)
        Me.Panel1.Controls.Add(Me.FdBearbeitungsVermerkTextBox)
        Me.Panel1.Controls.Add(AnlagenIDLabel)
        Me.Panel1.Controls.Add(Me.AnlagenIDTextBox)
        Me.Panel1.Controls.Add(Me.lbSpeichstatus)
        Me.Panel1.Controls.Add(Me.IstAnlageCheckBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 61)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(380, 542)
        Me.Panel1.TabIndex = 1
        '
        'cbMandant
        '
        Me.cbMandant.BackColor = System.Drawing.Color.Moccasin
        Me.cbMandant.DataSource = Me.MandantBindingSource
        Me.cbMandant.DisplayMember = "Mandant"
        Me.cbMandant.FormattingEnabled = True
        Me.cbMandant.Location = New System.Drawing.Point(190, 29)
        Me.cbMandant.Name = "cbMandant"
        Me.cbMandant.Size = New System.Drawing.Size(144, 21)
        Me.cbMandant.TabIndex = 271
        Me.cbMandant.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbVorgang
        '
        Me.cbVorgang.BackColor = System.Drawing.Color.Moccasin
        Me.cbVorgang.DataSource = Me.VorgaengeBindingSource
        Me.cbVorgang.DisplayMember = "Vorgang"
        Me.cbVorgang.FormattingEnabled = True
        Me.cbVorgang.Location = New System.Drawing.Point(190, 139)
        Me.cbVorgang.Name = "cbVorgang"
        Me.cbVorgang.Size = New System.Drawing.Size(144, 21)
        Me.cbVorgang.TabIndex = 270
        Me.cbVorgang.ValueMember = "id"
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbAkteNeu
        '
        Me.cbAkteNeu.BackColor = System.Drawing.Color.Moccasin
        Me.cbAkteNeu.DataSource = Me.MandantAktenBindingSource
        Me.cbAkteNeu.DisplayMember = "Akte"
        Me.cbAkteNeu.FormattingEnabled = True
        Me.cbAkteNeu.Location = New System.Drawing.Point(190, 110)
        Me.cbAkteNeu.Name = "cbAkteNeu"
        Me.cbAkteNeu.Size = New System.Drawing.Size(144, 21)
        Me.cbAkteNeu.TabIndex = 269
        Me.cbAkteNeu.ValueMember = "id"
        '
        'MandantAktenBindingSource
        '
        Me.MandantAktenBindingSource.DataMember = "Mandant_Akten"
        Me.MandantAktenBindingSource.DataSource = Me.MandantBindingSource
        '
        'lboxSaveAtt
        '
        Me.lboxSaveAtt.FormattingEnabled = True
        Me.lboxSaveAtt.Location = New System.Drawing.Point(58, 529)
        Me.lboxSaveAtt.Name = "lboxSaveAtt"
        Me.lboxSaveAtt.Size = New System.Drawing.Size(301, 43)
        Me.lboxSaveAtt.TabIndex = 268
        '
        'AnlagenTextBox
        '
        Me.AnlagenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Anlagen", True))
        Me.AnlagenTextBox.Location = New System.Drawing.Point(146, 475)
        Me.AnlagenTextBox.Name = "AnlagenTextBox"
        Me.AnlagenTextBox.Size = New System.Drawing.Size(62, 20)
        Me.AnlagenTextBox.TabIndex = 267
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(146, 137)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.ReadOnly = True
        Me.VorgangTextBox.Size = New System.Drawing.Size(33, 20)
        Me.VorgangTextBox.TabIndex = 266
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(146, 111)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.ReadOnly = True
        Me.AkteTextBox.Size = New System.Drawing.Size(33, 20)
        Me.AkteTextBox.TabIndex = 265
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(146, 29)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.Size = New System.Drawing.Size(33, 20)
        Me.MandantTextBox.TabIndex = 264
        '
        'cbAblage
        '
        Me.cbAblage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbAblage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAblage.BackColor = System.Drawing.Color.Moccasin
        Me.cbAblage.DataSource = Me.AblageBindingSource
        Me.cbAblage.DisplayMember = "Ablage"
        Me.cbAblage.FormattingEnabled = True
        Me.cbAblage.Location = New System.Drawing.Point(183, 280)
        Me.cbAblage.Name = "cbAblage"
        Me.cbAblage.Size = New System.Drawing.Size(151, 21)
        Me.cbAblage.TabIndex = 259
        Me.cbAblage.ValueMember = "Nummer"
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(146, 364)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokDatumTextBox.TabIndex = 258
        '
        'BetragTextBox
        '
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True))
        Me.BetragTextBox.Location = New System.Drawing.Point(146, 254)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(70, 20)
        Me.BetragTextBox.TabIndex = 256
        '
        'cbEmpfaenger
        '
        Me.cbEmpfaenger.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbEmpfaenger.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEmpfaenger.DataSource = Me.AnschriftenBindingSource1
        Me.cbEmpfaenger.DisplayMember = "Name_"
        Me.cbEmpfaenger.FormattingEnabled = True
        Me.cbEmpfaenger.Location = New System.Drawing.Point(183, 391)
        Me.cbEmpfaenger.Name = "cbEmpfaenger"
        Me.cbEmpfaenger.Size = New System.Drawing.Size(151, 21)
        Me.cbEmpfaenger.TabIndex = 255
        Me.cbEmpfaenger.ValueMember = "id"
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(144, 391)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.ReadOnly = True
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(33, 20)
        Me.EmpfaengerTextBox.TabIndex = 9
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(146, 337)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(33, 20)
        Me.StatusTextBox.TabIndex = 9
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(146, 311)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.ReadOnly = True
        Me.TypTextBox.Size = New System.Drawing.Size(33, 20)
        Me.TypTextBox.TabIndex = 9
        '
        'AblageTextBox
        '
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Ablage", True))
        Me.AblageTextBox.Location = New System.Drawing.Point(146, 281)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.ReadOnly = True
        Me.AblageTextBox.Size = New System.Drawing.Size(33, 20)
        Me.AblageTextBox.TabIndex = 9
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.Location = New System.Drawing.Point(146, 165)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.ReadOnly = True
        Me.AbsenderTextBox.Size = New System.Drawing.Size(33, 20)
        Me.AbsenderTextBox.TabIndex = 9
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(146, 82)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(188, 20)
        Me.BetreffTextBox.TabIndex = 7
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(146, 191)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.Size = New System.Drawing.Size(189, 57)
        Me.KommentarTextBox.TabIndex = 15
        '
        'FdAufgenommenTextBox
        '
        Me.FdAufgenommenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.FdAufgenommenTextBox.Location = New System.Drawing.Point(146, 446)
        Me.FdAufgenommenTextBox.Name = "FdAufgenommenTextBox"
        Me.FdAufgenommenTextBox.Size = New System.Drawing.Size(188, 20)
        Me.FdAufgenommenTextBox.TabIndex = 252
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(146, 56)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(188, 20)
        Me.DokumentTextBox.TabIndex = 5
        '
        'ComboBoxNamen
        '
        Me.ComboBoxNamen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxNamen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNamen.BackColor = System.Drawing.Color.Moccasin
        Me.ComboBoxNamen.DataSource = Me.AnschriftenBindingSource
        Me.ComboBoxNamen.DisplayMember = "Name_"
        Me.ComboBoxNamen.FormattingEnabled = True
        Me.ComboBoxNamen.Location = New System.Drawing.Point(190, 165)
        Me.ComboBoxNamen.Name = "ComboBoxNamen"
        Me.ComboBoxNamen.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxNamen.TabIndex = 249
        Me.ComboBoxNamen.ValueMember = "id"
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbStatus
        '
        Me.cbStatus.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbStatus.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbStatus.BackColor = System.Drawing.Color.Moccasin
        Me.cbStatus.DataSource = Me.StatusBindingSource
        Me.cbStatus.DisplayMember = "Status"
        Me.cbStatus.FormattingEnabled = True
        Me.cbStatus.Location = New System.Drawing.Point(183, 337)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(151, 21)
        Me.cbStatus.TabIndex = 248
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
        Me.cbTyp.BackColor = System.Drawing.Color.Moccasin
        Me.cbTyp.DataSource = Me.TypBindingSource
        Me.cbTyp.DisplayMember = "Typ"
        Me.cbTyp.FormattingEnabled = True
        Me.cbTyp.Location = New System.Drawing.Point(183, 310)
        Me.cbTyp.Name = "cbTyp"
        Me.cbTyp.Size = New System.Drawing.Size(151, 21)
        Me.cbTyp.TabIndex = 247
        Me.cbTyp.ValueMember = "id"
        '
        'TypBindingSource
        '
        Me.TypBindingSource.DataMember = "Typ"
        Me.TypBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'FdErstelltDateTimePicker
        '
        Me.FdErstelltDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.FdErstelltDateTimePicker.Location = New System.Drawing.Point(252, 364)
        Me.FdErstelltDateTimePicker.Name = "FdErstelltDateTimePicker"
        Me.FdErstelltDateTimePicker.Size = New System.Drawing.Size(83, 20)
        Me.FdErstelltDateTimePicker.TabIndex = 230
        '
        'FdBearbeitungsVermerkTextBox
        '
        Me.FdBearbeitungsVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.FdBearbeitungsVermerkTextBox.Location = New System.Drawing.Point(146, 419)
        Me.FdBearbeitungsVermerkTextBox.Name = "FdBearbeitungsVermerkTextBox"
        Me.FdBearbeitungsVermerkTextBox.Size = New System.Drawing.Size(188, 20)
        Me.FdBearbeitungsVermerkTextBox.TabIndex = 241
        '
        'AnlagenIDTextBox
        '
        Me.AnlagenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "AnlagenID", True))
        Me.AnlagenIDTextBox.Location = New System.Drawing.Point(146, 503)
        Me.AnlagenIDTextBox.Name = "AnlagenIDTextBox"
        Me.AnlagenIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AnlagenIDTextBox.TabIndex = 41
        '
        'lbSpeichstatus
        '
        Me.lbSpeichstatus.AutoSize = True
        Me.lbSpeichstatus.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbSpeichstatus.Location = New System.Drawing.Point(156, 575)
        Me.lbSpeichstatus.Name = "lbSpeichstatus"
        Me.lbSpeichstatus.Size = New System.Drawing.Size(111, 16)
        Me.lbSpeichstatus.TabIndex = 53
        Me.lbSpeichstatus.Text = "Speicherstatus"
        '
        'IstAnlageCheckBox
        '
        Me.IstAnlageCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "istAnlage", True))
        Me.IstAnlageCheckBox.Location = New System.Drawing.Point(254, 473)
        Me.IstAnlageCheckBox.Name = "IstAnlageCheckBox"
        Me.IstAnlageCheckBox.Size = New System.Drawing.Size(81, 24)
        Me.IstAnlageCheckBox.TabIndex = 39
        Me.IstAnlageCheckBox.Text = "ist Anlage"
        Me.IstAnlageCheckBox.UseVisualStyleBackColor = True
        '
        'lvDoc
        '
        Me.lvDoc.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lvDoc.Location = New System.Drawing.Point(775, 61)
        Me.lvDoc.Name = "lvDoc"
        Me.lvDoc.Size = New System.Drawing.Size(344, 542)
        Me.lvDoc.TabIndex = 50
        Me.lvDoc.UseCompatibleStateImageBehavior = False
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btSave)
        Me.Panel2.Controls.Add(Me.btWeiterZuordnung)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 609)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(380, 38)
        Me.Panel2.TabIndex = 52
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSave.Location = New System.Drawing.Point(216, 2)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(75, 34)
        Me.btSave.TabIndex = 49
        Me.btSave.Text = "übernehmen"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btWeiterZuordnung
        '
        Me.btWeiterZuordnung.Location = New System.Drawing.Point(116, 0)
        Me.btWeiterZuordnung.Name = "btWeiterZuordnung"
        Me.btWeiterZuordnung.Size = New System.Drawing.Size(75, 34)
        Me.btWeiterZuordnung.TabIndex = 51
        Me.btWeiterZuordnung.Text = "Weitere Zuordnung"
        Me.btWeiterZuordnung.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.AutoScroll = True
        Me.Panel3.Controls.Add(Me.DokNameTextBox)
        Me.Panel3.Controls.Add(Me.FdDatenIDTextBox)
        Me.Panel3.Controls.Add(Me.TextBox1)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(380, 52)
        Me.Panel3.TabIndex = 58
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(222, 9)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokNameTextBox.TabIndex = 56
        '
        'FdDatenIDTextBox
        '
        Me.FdDatenIDTextBox.BackColor = System.Drawing.SystemColors.Control
        Me.FdDatenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "id", True))
        Me.FdDatenIDTextBox.Location = New System.Drawing.Point(9, 9)
        Me.FdDatenIDTextBox.Name = "FdDatenIDTextBox"
        Me.FdDatenIDTextBox.ReadOnly = True
        Me.FdDatenIDTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FdDatenIDTextBox.TabIndex = 55
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Control
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(116, 9)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 54
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.txtAendern)
        Me.Panel4.Controls.Add(Me.btChangeOrdner)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Location = New System.Drawing.Point(775, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(344, 52)
        Me.Panel4.TabIndex = 61
        '
        'txtAendern
        '
        Me.txtAendern.BackColor = System.Drawing.SystemColors.Control
        Me.txtAendern.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAendern.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAendern.Location = New System.Drawing.Point(3, 9)
        Me.txtAendern.Multiline = True
        Me.txtAendern.Name = "txtAendern"
        Me.txtAendern.Size = New System.Drawing.Size(247, 38)
        Me.txtAendern.TabIndex = 62
        Me.txtAendern.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btChangeOrdner
        '
        Me.btChangeOrdner.Location = New System.Drawing.Point(256, 6)
        Me.btChangeOrdner.Name = "btChangeOrdner"
        Me.btChangeOrdner.Size = New System.Drawing.Size(75, 19)
        Me.btChangeOrdner.TabIndex = 61
        Me.btChangeOrdner.Text = "Ändern"
        Me.btChangeOrdner.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.AutoScroll = True
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(1125, 61)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(7, 542)
        Me.Panel5.TabIndex = 62
        '
        'Panel6
        '
        Me.Panel6.AutoScroll = True
        Me.Panel6.Controls.Add(IdLabel)
        Me.Panel6.Controls.Add(Me.IdTextBox)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(389, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(380, 52)
        Me.Panel6.TabIndex = 63
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(67, 12)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'btClose
        '
        Me.btClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btClose.Location = New System.Drawing.Point(909, 611)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 34)
        Me.btClose.TabIndex = 53
        Me.btClose.Text = "Schließen"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
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
        'VorlagenBindingSource
        '
        Me.VorlagenBindingSource.DataMember = "Vorlagen"
        Me.VorlagenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'VorlagenTableAdapter
        '
        Me.VorlagenTableAdapter.ClearBeforeFill = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'TypTableAdapter
        '
        Me.TypTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'ImageList2
        '
        Me.ImageList2.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImageList2.ImageSize = New System.Drawing.Size(16, 16)
        Me.ImageList2.TransparentColor = System.Drawing.Color.Transparent
        '
        'ContextMenuStripLvDokumente
        '
        Me.ContextMenuStripLvDokumente.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnsehenToolStripMenuItem, Me.LöschenToolStripMenuItem})
        Me.ContextMenuStripLvDokumente.Name = "ContextMenuStripLvDokumente"
        Me.ContextMenuStripLvDokumente.Size = New System.Drawing.Size(121, 48)
        '
        'AnsehenToolStripMenuItem
        '
        Me.AnsehenToolStripMenuItem.Name = "AnsehenToolStripMenuItem"
        Me.AnsehenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.AnsehenToolStripMenuItem.Text = "Ansehen"
        '
        'LöschenToolStripMenuItem
        '
        Me.LöschenToolStripMenuItem.Name = "LöschenToolStripMenuItem"
        Me.LöschenToolStripMenuItem.Size = New System.Drawing.Size(120, 22)
        Me.LöschenToolStripMenuItem.Text = "Löschen"
        '
        'Scaninput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1135, 659)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Scaninput"
        Me.Text = "ScanInput"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantAktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripLvDokumente.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser2 As WebBrowser
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lboxSaveAtt As ListBox
    Friend WithEvents AnlagenTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents cbAblage As ComboBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents cbEmpfaenger As ComboBox
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents TypTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents AbsenderTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents FdAufgenommenTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents ComboBoxNamen As ComboBox
    Friend WithEvents cbStatus As ComboBox
    Friend WithEvents cbTyp As ComboBox
    Friend WithEvents FdErstelltDateTimePicker As DateTimePicker
    Friend WithEvents FdBearbeitungsVermerkTextBox As TextBox
    Friend WithEvents AnlagenIDTextBox As TextBox
    Friend WithEvents lbSpeichstatus As Label
    Friend WithEvents IstAnlageCheckBox As CheckBox
    Friend WithEvents lvDoc As ListView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btSave As Button
    Friend WithEvents btWeiterZuordnung As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents FdDatenIDTextBox As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents txtAendern As TextBox
    Friend WithEvents btChangeOrdner As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel6 As Panel
    Friend WithEvents btClose As Button
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents VorlagenBindingSource As BindingSource
    Friend WithEvents VorlagenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents MandantAktenBindingSource As BindingSource
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents cbMandant As ComboBox
    Friend WithEvents cbVorgang As ComboBox
    Friend WithEvents cbAkteNeu As ComboBox
    Friend WithEvents ImageList2 As ImageList
    Friend WithEvents ContextMenuStripLvDokumente As ContextMenuStrip
    Friend WithEvents AnsehenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LöschenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdTextBox As TextBox
End Class
