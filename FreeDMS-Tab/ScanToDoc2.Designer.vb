<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ScanToDoc2
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
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btWeiterZuordnung = New System.Windows.Forms.Button()
        Me.lbSpeichstatus = New System.Windows.Forms.Label()
        Me.btClose = New System.Windows.Forms.Button()
        Me.btScan = New System.Windows.Forms.Button()
        Me.BtPDF_OCR = New System.Windows.Forms.Button()
        Me.BtPDF = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.dataSourcesToolStripComboBox = New System.Windows.Forms.ComboBox()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lbPage = New System.Windows.Forms.Label()
        Me.btFor = New System.Windows.Forms.Button()
        Me.btBack = New System.Windows.Forms.Button()
        Me.lbCountPages = New System.Windows.Forms.Label()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.InhaltOCRTextBox = New System.Windows.Forms.TextBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.PnlDaten = New System.Windows.Forms.Panel()
        Me.cbEmpfaenger = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.lboxSaveAtt = New System.Windows.Forms.ListBox()
        Me.AnlagenTextBox = New System.Windows.Forms.TextBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.cbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbVorgang = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbAkteNeu = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbAblage = New System.Windows.Forms.ComboBox()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
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
        Me.IstAnlageCheckBox = New System.Windows.Forms.CheckBox()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.VorlagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorlagenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter()
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
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel5.SuspendLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PnlDaten.SuspendLayout()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AnlagenLabel1
        '
        AnlagenLabel1.AutoSize = True
        AnlagenLabel1.Location = New System.Drawing.Point(52, 469)
        AnlagenLabel1.Name = "AnlagenLabel1"
        AnlagenLabel1.Size = New System.Drawing.Size(49, 13)
        AnlagenLabel1.TabIndex = 311
        AnlagenLabel1.Text = "Anlagen:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(51, 131)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 309
        VorgangLabel.Text = "Vorgang:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(69, 105)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 306
        AkteLabel.Text = "Akte:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(49, 23)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 304
        MandantLabel.Text = "Bereich:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(60, 248)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 298
        BetragLabel.Text = "Betrag:"
        '
        'FdAufgenommenLabel
        '
        FdAufgenommenLabel.AutoSize = True
        FdAufgenommenLabel.Location = New System.Drawing.Point(23, 440)
        FdAufgenommenLabel.Name = "FdAufgenommenLabel"
        FdAufgenommenLabel.Size = New System.Drawing.Size(78, 13)
        FdAufgenommenLabel.TabIndex = 295
        FdAufgenommenLabel.Text = "Aufgenommen:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(46, 159)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(55, 13)
        AbsenderLabel.TabIndex = 273
        AbsenderLabel.Text = "Absender:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(60, 76)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 271
        BetreffLabel.Text = "Betreff:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(42, 50)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 269
        DokumentLabel.Text = "Dokument:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(38, 185)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 279
        KommentarLabel.Text = "Kommentar:"
        '
        'FdErstelltLabel
        '
        FdErstelltLabel.AutoSize = True
        FdErstelltLabel.Location = New System.Drawing.Point(11, 355)
        FdErstelltLabel.Name = "FdErstelltLabel"
        FdErstelltLabel.Size = New System.Drawing.Size(90, 13)
        FdErstelltLabel.TabIndex = 284
        FdErstelltLabel.Text = "Datum Dokument"
        '
        'FdFundstelleLabel
        '
        FdFundstelleLabel.AutoSize = True
        FdFundstelleLabel.Location = New System.Drawing.Point(58, 271)
        FdFundstelleLabel.Name = "FdFundstelleLabel"
        FdFundstelleLabel.Size = New System.Drawing.Size(43, 13)
        FdFundstelleLabel.TabIndex = 286
        FdFundstelleLabel.Text = "Ablage:"
        '
        'FdTypLabel
        '
        FdTypLabel.AutoSize = True
        FdTypLabel.Location = New System.Drawing.Point(47, 297)
        FdTypLabel.Name = "FdTypLabel"
        FdTypLabel.Size = New System.Drawing.Size(54, 13)
        FdTypLabel.TabIndex = 287
        FdTypLabel.Text = "Dok.-Typ:"
        '
        'FdGdStatusLabel
        '
        FdGdStatusLabel.AutoSize = True
        FdGdStatusLabel.Location = New System.Drawing.Point(61, 326)
        FdGdStatusLabel.Name = "FdGdStatusLabel"
        FdGdStatusLabel.Size = New System.Drawing.Size(40, 13)
        FdGdStatusLabel.TabIndex = 288
        FdGdStatusLabel.Text = "Status:"
        '
        'FdEmpfaengerLabel
        '
        FdEmpfaengerLabel.AutoSize = True
        FdEmpfaengerLabel.Location = New System.Drawing.Point(34, 384)
        FdEmpfaengerLabel.Name = "FdEmpfaengerLabel"
        FdEmpfaengerLabel.Size = New System.Drawing.Size(67, 13)
        FdEmpfaengerLabel.TabIndex = 289
        FdEmpfaengerLabel.Text = "Empfaenger:"
        '
        'FdBearbeitungsVermerkLabel
        '
        FdBearbeitungsVermerkLabel.AutoSize = True
        FdBearbeitungsVermerkLabel.Location = New System.Drawing.Point(18, 410)
        FdBearbeitungsVermerkLabel.Name = "FdBearbeitungsVermerkLabel"
        FdBearbeitungsVermerkLabel.Size = New System.Drawing.Size(83, 13)
        FdBearbeitungsVermerkLabel.TabIndex = 290
        FdBearbeitungsVermerkLabel.Text = "Bearb.-Vermerk:"
        '
        'AnlagenIDLabel
        '
        AnlagenIDLabel.AutoSize = True
        AnlagenIDLabel.Location = New System.Drawing.Point(38, 497)
        AnlagenIDLabel.Name = "AnlagenIDLabel"
        AnlagenIDLabel.Size = New System.Drawing.Size(63, 13)
        AnlagenIDLabel.TabIndex = 282
        AnlagenIDLabel.Text = "Anlagen ID:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(96, 619)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 314
        IdLabel.Text = "id:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 527.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 434.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.PnlDaten, 2, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 590.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1224, 853)
        Me.TableLayoutPanel1.TabIndex = 12
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.Transparent
        Me.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel3.Controls.Add(Me.ProgressBar1)
        Me.Panel3.Controls.Add(Me.Label1)
        Me.Panel3.Location = New System.Drawing.Point(793, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(428, 34)
        Me.Panel3.TabIndex = 2
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(165, 5)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(237, 21)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Texterkennung läuft..."
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.btWeiterZuordnung)
        Me.Panel1.Controls.Add(Me.lbSpeichstatus)
        Me.Panel1.Controls.Add(Me.btClose)
        Me.Panel1.Controls.Add(Me.btScan)
        Me.Panel1.Controls.Add(Me.BtPDF_OCR)
        Me.Panel1.Controls.Add(Me.BtPDF)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(257, 807)
        Me.Panel1.TabIndex = 8
        '
        'btWeiterZuordnung
        '
        Me.btWeiterZuordnung.Location = New System.Drawing.Point(39, 236)
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
        Me.lbSpeichstatus.Location = New System.Drawing.Point(18, 532)
        Me.lbSpeichstatus.Name = "lbSpeichstatus"
        Me.lbSpeichstatus.Size = New System.Drawing.Size(111, 16)
        Me.lbSpeichstatus.TabIndex = 54
        Me.lbSpeichstatus.Text = "Speicherstatus"
        '
        'btClose
        '
        Me.btClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btClose.Location = New System.Drawing.Point(39, 594)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 7
        Me.btClose.Text = "Zurück"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'btScan
        '
        Me.btScan.Location = New System.Drawing.Point(29, 7)
        Me.btScan.Name = "btScan"
        Me.btScan.Size = New System.Drawing.Size(100, 32)
        Me.btScan.TabIndex = 5
        Me.btScan.Text = "Scan"
        Me.btScan.UseVisualStyleBackColor = True
        '
        'BtPDF_OCR
        '
        Me.BtPDF_OCR.Location = New System.Drawing.Point(8, 75)
        Me.BtPDF_OCR.Name = "BtPDF_OCR"
        Me.BtPDF_OCR.Size = New System.Drawing.Size(141, 50)
        Me.BtPDF_OCR.TabIndex = 6
        Me.BtPDF_OCR.Text = "Texterkennung (OCR)"
        Me.BtPDF_OCR.UseVisualStyleBackColor = True
        '
        'BtPDF
        '
        Me.BtPDF.Location = New System.Drawing.Point(8, 139)
        Me.BtPDF.Name = "BtPDF"
        Me.BtPDF.Size = New System.Drawing.Size(141, 50)
        Me.BtPDF.TabIndex = 6
        Me.BtPDF.Text = "Übernehmen"
        Me.BtPDF.UseVisualStyleBackColor = True
        '
        'Panel4
        '
        Me.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel4.Controls.Add(Me.dataSourcesToolStripComboBox)
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(160, 30)
        Me.Panel4.TabIndex = 11
        '
        'dataSourcesToolStripComboBox
        '
        Me.dataSourcesToolStripComboBox.FormattingEnabled = True
        Me.dataSourcesToolStripComboBox.Location = New System.Drawing.Point(-1, 5)
        Me.dataSourcesToolStripComboBox.Name = "dataSourcesToolStripComboBox"
        Me.dataSourcesToolStripComboBox.Size = New System.Drawing.Size(160, 21)
        Me.dataSourcesToolStripComboBox.TabIndex = 8
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(266, 3)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(521, 34)
        Me.Panel6.TabIndex = 13
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.lbPage)
        Me.Panel2.Controls.Add(Me.btFor)
        Me.Panel2.Controls.Add(Me.btBack)
        Me.Panel2.Controls.Add(Me.lbCountPages)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(521, 34)
        Me.Panel2.TabIndex = 10
        '
        'lbPage
        '
        Me.lbPage.AutoSize = True
        Me.lbPage.Location = New System.Drawing.Point(276, 11)
        Me.lbPage.Name = "lbPage"
        Me.lbPage.Size = New System.Drawing.Size(24, 13)
        Me.lbPage.TabIndex = 4
        Me.lbPage.Text = "0/0"
        '
        'btFor
        '
        Me.btFor.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btFor.Location = New System.Drawing.Point(323, 5)
        Me.btFor.Name = "btFor"
        Me.btFor.Size = New System.Drawing.Size(34, 23)
        Me.btFor.TabIndex = 3
        Me.btFor.Text = ">"
        Me.btFor.UseVisualStyleBackColor = True
        '
        'btBack
        '
        Me.btBack.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btBack.Location = New System.Drawing.Point(216, 5)
        Me.btBack.Name = "btBack"
        Me.btBack.Size = New System.Drawing.Size(34, 23)
        Me.btBack.TabIndex = 2
        Me.btBack.Text = "<"
        Me.btBack.UseVisualStyleBackColor = True
        '
        'lbCountPages
        '
        Me.lbCountPages.AutoSize = True
        Me.lbCountPages.Location = New System.Drawing.Point(14, 11)
        Me.lbCountPages.Name = "lbCountPages"
        Me.lbCountPages.Size = New System.Drawing.Size(128, 13)
        Me.lbCountPages.TabIndex = 0
        Me.lbCountPages.Text = "Anzahl gescannter Seiten"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(266, 43)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(521, 807)
        Me.TabControl1.TabIndex = 14
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.PictureBox1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(513, 781)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dokument"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(507, 775)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(513, 781)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "OCR-Text"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(507, 775)
        Me.RichTextBox1.TabIndex = 12
        Me.RichTextBox1.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.Panel5)
        Me.TabPage3.Controls.Add(Me.InhaltOCRTextBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(513, 781)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "OCR Übernehmen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel5.Controls.Add(Me.Label2)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel5.Location = New System.Drawing.Point(3, 3)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(507, 68)
        Me.Panel5.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark
        Me.Label2.Location = New System.Drawing.Point(8, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(239, 26)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Dieser Text wird übernommen. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Sie können ggf. Änderungen vornehmen."
        '
        'InhaltOCRTextBox
        '
        Me.InhaltOCRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "InhaltOCR", True))
        Me.InhaltOCRTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.InhaltOCRTextBox.Location = New System.Drawing.Point(3, 77)
        Me.InhaltOCRTextBox.Multiline = True
        Me.InhaltOCRTextBox.Name = "InhaltOCRTextBox"
        Me.InhaltOCRTextBox.Size = New System.Drawing.Size(507, 701)
        Me.InhaltOCRTextBox.TabIndex = 1
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
        'PnlDaten
        '
        Me.PnlDaten.AutoScroll = True
        Me.PnlDaten.Controls.Add(Me.cbEmpfaenger)
        Me.PnlDaten.Controls.Add(Me.DokNameTextBox)
        Me.PnlDaten.Controls.Add(IdLabel)
        Me.PnlDaten.Controls.Add(Me.IdTextBox)
        Me.PnlDaten.Controls.Add(Me.lboxSaveAtt)
        Me.PnlDaten.Controls.Add(AnlagenLabel1)
        Me.PnlDaten.Controls.Add(Me.AnlagenTextBox)
        Me.PnlDaten.Controls.Add(VorgangLabel)
        Me.PnlDaten.Controls.Add(Me.VorgangTextBox)
        Me.PnlDaten.Controls.Add(AkteLabel)
        Me.PnlDaten.Controls.Add(Me.AkteTextBox)
        Me.PnlDaten.Controls.Add(MandantLabel)
        Me.PnlDaten.Controls.Add(Me.MandantTextBox)
        Me.PnlDaten.Controls.Add(Me.cbMandant)
        Me.PnlDaten.Controls.Add(Me.cbVorgang)
        Me.PnlDaten.Controls.Add(Me.cbAkteNeu)
        Me.PnlDaten.Controls.Add(Me.cbAblage)
        Me.PnlDaten.Controls.Add(Me.DokDatumTextBox)
        Me.PnlDaten.Controls.Add(BetragLabel)
        Me.PnlDaten.Controls.Add(Me.BetragTextBox)
        Me.PnlDaten.Controls.Add(FdAufgenommenLabel)
        Me.PnlDaten.Controls.Add(AbsenderLabel)
        Me.PnlDaten.Controls.Add(BetreffLabel)
        Me.PnlDaten.Controls.Add(Me.EmpfaengerTextBox)
        Me.PnlDaten.Controls.Add(Me.StatusTextBox)
        Me.PnlDaten.Controls.Add(Me.TypTextBox)
        Me.PnlDaten.Controls.Add(Me.AblageTextBox)
        Me.PnlDaten.Controls.Add(Me.AbsenderTextBox)
        Me.PnlDaten.Controls.Add(DokumentLabel)
        Me.PnlDaten.Controls.Add(KommentarLabel)
        Me.PnlDaten.Controls.Add(Me.BetreffTextBox)
        Me.PnlDaten.Controls.Add(Me.KommentarTextBox)
        Me.PnlDaten.Controls.Add(Me.FdAufgenommenTextBox)
        Me.PnlDaten.Controls.Add(Me.DokumentTextBox)
        Me.PnlDaten.Controls.Add(Me.ComboBoxNamen)
        Me.PnlDaten.Controls.Add(Me.cbStatus)
        Me.PnlDaten.Controls.Add(Me.cbTyp)
        Me.PnlDaten.Controls.Add(FdErstelltLabel)
        Me.PnlDaten.Controls.Add(Me.FdErstelltDateTimePicker)
        Me.PnlDaten.Controls.Add(FdFundstelleLabel)
        Me.PnlDaten.Controls.Add(FdTypLabel)
        Me.PnlDaten.Controls.Add(FdGdStatusLabel)
        Me.PnlDaten.Controls.Add(FdEmpfaengerLabel)
        Me.PnlDaten.Controls.Add(FdBearbeitungsVermerkLabel)
        Me.PnlDaten.Controls.Add(Me.FdBearbeitungsVermerkTextBox)
        Me.PnlDaten.Controls.Add(AnlagenIDLabel)
        Me.PnlDaten.Controls.Add(Me.AnlagenIDTextBox)
        Me.PnlDaten.Controls.Add(Me.IstAnlageCheckBox)
        Me.PnlDaten.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PnlDaten.Location = New System.Drawing.Point(793, 43)
        Me.PnlDaten.Name = "PnlDaten"
        Me.PnlDaten.Size = New System.Drawing.Size(428, 807)
        Me.PnlDaten.TabIndex = 15
        '
        'cbEmpfaenger
        '
        Me.cbEmpfaenger.DataSource = Me.AnschriftenBindingSource1
        Me.cbEmpfaenger.DisplayMember = "Name_"
        Me.cbEmpfaenger.FormattingEnabled = True
        Me.cbEmpfaenger.Location = New System.Drawing.Point(166, 383)
        Me.cbEmpfaenger.Name = "cbEmpfaenger"
        Me.cbEmpfaenger.Size = New System.Drawing.Size(151, 21)
        Me.cbEmpfaenger.TabIndex = 317
        Me.cbEmpfaenger.ValueMember = "id"
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(41, 590)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(188, 20)
        Me.DokNameTextBox.TabIndex = 316
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(120, 616)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.IdTextBox.TabIndex = 315
        '
        'lboxSaveAtt
        '
        Me.lboxSaveAtt.FormattingEnabled = True
        Me.lboxSaveAtt.Location = New System.Drawing.Point(41, 520)
        Me.lboxSaveAtt.Name = "lboxSaveAtt"
        Me.lboxSaveAtt.Size = New System.Drawing.Size(301, 43)
        Me.lboxSaveAtt.TabIndex = 313
        '
        'AnlagenTextBox
        '
        Me.AnlagenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Anlagen", True))
        Me.AnlagenTextBox.Location = New System.Drawing.Point(129, 466)
        Me.AnlagenTextBox.Name = "AnlagenTextBox"
        Me.AnlagenTextBox.Size = New System.Drawing.Size(62, 20)
        Me.AnlagenTextBox.TabIndex = 312
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(129, 128)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.ReadOnly = True
        Me.VorgangTextBox.Size = New System.Drawing.Size(33, 20)
        Me.VorgangTextBox.TabIndex = 310
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(129, 102)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.ReadOnly = True
        Me.AkteTextBox.Size = New System.Drawing.Size(33, 20)
        Me.AkteTextBox.TabIndex = 308
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(129, 20)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.Size = New System.Drawing.Size(33, 20)
        Me.MandantTextBox.TabIndex = 307
        '
        'cbMandant
        '
        Me.cbMandant.BackColor = System.Drawing.Color.Moccasin
        Me.cbMandant.DataSource = Me.MandantBindingSource
        Me.cbMandant.DisplayMember = "Mandant"
        Me.cbMandant.FormattingEnabled = True
        Me.cbMandant.Location = New System.Drawing.Point(173, 20)
        Me.cbMandant.Name = "cbMandant"
        Me.cbMandant.Size = New System.Drawing.Size(144, 21)
        Me.cbMandant.TabIndex = 305
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
        Me.cbVorgang.Location = New System.Drawing.Point(173, 130)
        Me.cbVorgang.Name = "cbVorgang"
        Me.cbVorgang.Size = New System.Drawing.Size(144, 21)
        Me.cbVorgang.TabIndex = 303
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
        Me.cbAkteNeu.DataSource = Me.AktenBindingSource
        Me.cbAkteNeu.DisplayMember = "Akte"
        Me.cbAkteNeu.FormattingEnabled = True
        Me.cbAkteNeu.Location = New System.Drawing.Point(173, 101)
        Me.cbAkteNeu.Name = "cbAkteNeu"
        Me.cbAkteNeu.Size = New System.Drawing.Size(144, 21)
        Me.cbAkteNeu.TabIndex = 302
        Me.cbAkteNeu.ValueMember = "id"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'cbAblage
        '
        Me.cbAblage.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbAblage.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAblage.BackColor = System.Drawing.Color.Moccasin
        Me.cbAblage.DataSource = Me.AblageBindingSource
        Me.cbAblage.DisplayMember = "Ablage"
        Me.cbAblage.FormattingEnabled = True
        Me.cbAblage.Location = New System.Drawing.Point(166, 271)
        Me.cbAblage.Name = "cbAblage"
        Me.cbAblage.Size = New System.Drawing.Size(151, 21)
        Me.cbAblage.TabIndex = 301
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
        Me.DokDatumTextBox.Location = New System.Drawing.Point(129, 355)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokDatumTextBox.TabIndex = 300
        '
        'BetragTextBox
        '
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True))
        Me.BetragTextBox.Location = New System.Drawing.Point(129, 245)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(70, 20)
        Me.BetragTextBox.TabIndex = 299
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(127, 382)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.ReadOnly = True
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(33, 20)
        Me.EmpfaengerTextBox.TabIndex = 278
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(129, 328)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.ReadOnly = True
        Me.StatusTextBox.Size = New System.Drawing.Size(33, 20)
        Me.StatusTextBox.TabIndex = 277
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(129, 302)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.ReadOnly = True
        Me.TypTextBox.Size = New System.Drawing.Size(33, 20)
        Me.TypTextBox.TabIndex = 274
        '
        'AblageTextBox
        '
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Ablage", True))
        Me.AblageTextBox.Location = New System.Drawing.Point(129, 272)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.ReadOnly = True
        Me.AblageTextBox.Size = New System.Drawing.Size(33, 20)
        Me.AblageTextBox.TabIndex = 276
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Absender", True))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(129, 156)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.ReadOnly = True
        Me.AbsenderTextBox.Size = New System.Drawing.Size(33, 20)
        Me.AbsenderTextBox.TabIndex = 275
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(129, 73)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(188, 20)
        Me.BetreffTextBox.TabIndex = 272
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(129, 182)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.Size = New System.Drawing.Size(189, 57)
        Me.KommentarTextBox.TabIndex = 280
        '
        'FdAufgenommenTextBox
        '
        Me.FdAufgenommenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.FdAufgenommenTextBox.Location = New System.Drawing.Point(129, 437)
        Me.FdAufgenommenTextBox.Name = "FdAufgenommenTextBox"
        Me.FdAufgenommenTextBox.Size = New System.Drawing.Size(188, 20)
        Me.FdAufgenommenTextBox.TabIndex = 296
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.BackColor = System.Drawing.Color.Moccasin
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(129, 47)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(188, 20)
        Me.DokumentTextBox.TabIndex = 270
        '
        'ComboBoxNamen
        '
        Me.ComboBoxNamen.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.ComboBoxNamen.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.ComboBoxNamen.BackColor = System.Drawing.Color.Moccasin
        Me.ComboBoxNamen.DataSource = Me.AnschriftenBindingSource
        Me.ComboBoxNamen.DisplayMember = "Name_"
        Me.ComboBoxNamen.FormattingEnabled = True
        Me.ComboBoxNamen.Location = New System.Drawing.Point(173, 156)
        Me.ComboBoxNamen.Name = "ComboBoxNamen"
        Me.ComboBoxNamen.Size = New System.Drawing.Size(144, 21)
        Me.ComboBoxNamen.TabIndex = 294
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
        Me.cbStatus.Location = New System.Drawing.Point(166, 328)
        Me.cbStatus.Name = "cbStatus"
        Me.cbStatus.Size = New System.Drawing.Size(151, 21)
        Me.cbStatus.TabIndex = 293
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
        Me.cbTyp.Location = New System.Drawing.Point(166, 301)
        Me.cbTyp.Name = "cbTyp"
        Me.cbTyp.Size = New System.Drawing.Size(151, 21)
        Me.cbTyp.TabIndex = 292
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
        Me.FdErstelltDateTimePicker.Location = New System.Drawing.Point(235, 355)
        Me.FdErstelltDateTimePicker.Name = "FdErstelltDateTimePicker"
        Me.FdErstelltDateTimePicker.Size = New System.Drawing.Size(83, 20)
        Me.FdErstelltDateTimePicker.TabIndex = 285
        '
        'FdBearbeitungsVermerkTextBox
        '
        Me.FdBearbeitungsVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.FdBearbeitungsVermerkTextBox.Location = New System.Drawing.Point(129, 410)
        Me.FdBearbeitungsVermerkTextBox.Name = "FdBearbeitungsVermerkTextBox"
        Me.FdBearbeitungsVermerkTextBox.Size = New System.Drawing.Size(188, 20)
        Me.FdBearbeitungsVermerkTextBox.TabIndex = 291
        '
        'AnlagenIDTextBox
        '
        Me.AnlagenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "AnlagenID", True))
        Me.AnlagenIDTextBox.Location = New System.Drawing.Point(129, 494)
        Me.AnlagenIDTextBox.Name = "AnlagenIDTextBox"
        Me.AnlagenIDTextBox.Size = New System.Drawing.Size(121, 20)
        Me.AnlagenIDTextBox.TabIndex = 283
        '
        'IstAnlageCheckBox
        '
        Me.IstAnlageCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "istAnlage", True))
        Me.IstAnlageCheckBox.Location = New System.Drawing.Point(237, 464)
        Me.IstAnlageCheckBox.Name = "IstAnlageCheckBox"
        Me.IstAnlageCheckBox.Size = New System.Drawing.Size(81, 24)
        Me.IstAnlageCheckBox.TabIndex = 281
        Me.IstAnlageCheckBox.Text = "ist Anlage"
        Me.IstAnlageCheckBox.UseVisualStyleBackColor = True
        '
        'BackgroundWorker1
        '
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
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
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Me.AblageTableAdapter
        Me.TableAdapterManager.AktenTableAdapter = Nothing
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Me.AnschriftenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Me.MandantTableAdapter
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Me.StatusTableAdapter
        Me.TableAdapterManager.TypTableAdapter = Me.TypTableAdapter
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Nothing
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
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
        'ScanToDoc2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btClose
        Me.ClientSize = New System.Drawing.Size(1224, 853)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ScanToDoc2"
        Me.Text = "ScanToDoc2"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel5.PerformLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PnlDaten.ResumeLayout(False)
        Me.PnlDaten.PerformLayout()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btWeiterZuordnung As Button
    Friend WithEvents lbSpeichstatus As Label
    Friend WithEvents btClose As Button
    Friend WithEvents btScan As Button
    Friend WithEvents BtPDF_OCR As Button
    Friend WithEvents BtPDF As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents dataSourcesToolStripComboBox As ComboBox
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lbPage As Label
    Friend WithEvents btFor As Button
    Friend WithEvents btBack As Button
    Friend WithEvents lbCountPages As Label
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PnlDaten As Panel
    Friend WithEvents lboxSaveAtt As ListBox
    Friend WithEvents AnlagenTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents cbMandant As ComboBox
    Friend WithEvents cbVorgang As ComboBox
    Friend WithEvents cbAkteNeu As ComboBox
    Friend WithEvents cbAblage As ComboBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
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
    Friend WithEvents IstAnlageCheckBox As CheckBox
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents InhaltOCRTextBox As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents VorlagenBindingSource As BindingSource
    Friend WithEvents VorlagenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter
    Friend WithEvents cbEmpfaenger As ComboBox
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
End Class
