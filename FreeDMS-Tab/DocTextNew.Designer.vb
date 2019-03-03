<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocTextNew
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
        Dim MandantLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
        Dim DokDatumLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim BearbVermerkLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CbEmpfaenger = New System.Windows.Forms.ComboBox()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.CbAbsender = New System.Windows.Forms.ComboBox()
        Me.AufgenommenTextBox = New System.Windows.Forms.TextBox()
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenderTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox6 = New System.Windows.Forms.ComboBox()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.CbVorgang = New System.Windows.Forms.ComboBox()
        Me.CbAkte = New System.Windows.Forms.ComboBox()
        Me.CbMandat = New System.Windows.Forms.ComboBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btClose = New System.Windows.Forms.Button()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
        DokDatumLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        BearbVermerkLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(38, 13)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 2
        MandantLabel.Text = "Bereich:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(52, 37)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(34, 63)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 6
        VorgangLabel.Text = "Vorgang:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(25, 121)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(43, 147)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 10
        BetreffLabel.Text = "Betreff:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(43, 173)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 12
        BetragLabel.Text = "Betrag:"
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(20, 208)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(64, 13)
        DokDatumLabel.TabIndex = 20
        DokDatumLabel.Text = "Dok Datum:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(296, 48)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 26)
        KommentarLabel.TabIndex = 26
        KommentarLabel.Text = "Text/" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Kommentar:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(565, 311)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 30
        AblageLabel.Text = "Ablage:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(56, 308)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(28, 13)
        TypLabel.TabIndex = 32
        TypLabel.Text = "Typ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(308, 307)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 34
        StatusLabel.Text = "Status:"
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Location = New System.Drawing.Point(4, 356)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(80, 13)
        BearbVermerkLabel.TabIndex = 42
        BearbVermerkLabel.Text = "Bearb Vermerk:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btSave, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btClose, 1, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.142857!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 92.85714!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(868, 492)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel1, 2)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.CbEmpfaenger)
        Me.Panel1.Controls.Add(Me.CbAbsender)
        Me.Panel1.Controls.Add(Me.AufgenommenTextBox)
        Me.Panel1.Controls.Add(Me.EmpfaengerTextBox)
        Me.Panel1.Controls.Add(Me.AbsenderTextBox)
        Me.Panel1.Controls.Add(Me.ComboBox6)
        Me.Panel1.Controls.Add(Me.ComboBox5)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.CbVorgang)
        Me.Panel1.Controls.Add(Me.CbAkte)
        Me.Panel1.Controls.Add(Me.CbMandat)
        Me.Panel1.Controls.Add(MandantLabel)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(VorgangLabel)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(Me.DokumentTextBox)
        Me.Panel1.Controls.Add(BetreffLabel)
        Me.Panel1.Controls.Add(Me.BetreffTextBox)
        Me.Panel1.Controls.Add(BetragLabel)
        Me.Panel1.Controls.Add(Me.BetragTextBox)
        Me.Panel1.Controls.Add(DokDatumLabel)
        Me.Panel1.Controls.Add(Me.DokDatumTextBox)
        Me.Panel1.Controls.Add(KommentarLabel)
        Me.Panel1.Controls.Add(Me.KommentarTextBox)
        Me.Panel1.Controls.Add(AblageLabel)
        Me.Panel1.Controls.Add(TypLabel)
        Me.Panel1.Controls.Add(StatusLabel)
        Me.Panel1.Controls.Add(BearbVermerkLabel)
        Me.Panel1.Controls.Add(Me.BearbVermerkTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 33)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(862, 394)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(323, 245)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(22, 13)
        Me.Label2.TabIndex = 56
        Me.Label2.Text = "für:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 245)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 13)
        Me.Label1.TabIndex = 55
        Me.Label1.Text = "Erstellt von:"
        '
        'CbEmpfaenger
        '
        Me.CbEmpfaenger.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.CbEmpfaenger.DataSource = Me.AnschriftenBindingSource1
        Me.CbEmpfaenger.DisplayMember = "Name_"
        Me.CbEmpfaenger.FormattingEnabled = True
        Me.CbEmpfaenger.Location = New System.Drawing.Point(367, 242)
        Me.CbEmpfaenger.Name = "CbEmpfaenger"
        Me.CbEmpfaenger.Size = New System.Drawing.Size(166, 21)
        Me.CbEmpfaenger.TabIndex = 54
        Me.CbEmpfaenger.ValueMember = "id"
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CbAbsender
        '
        Me.CbAbsender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Absender", True))
        Me.CbAbsender.DataSource = Me.AnschriftenBindingSource
        Me.CbAbsender.DisplayMember = "Name_"
        Me.CbAbsender.FormattingEnabled = True
        Me.CbAbsender.Location = New System.Drawing.Point(106, 242)
        Me.CbAbsender.Name = "CbAbsender"
        Me.CbAbsender.Size = New System.Drawing.Size(166, 21)
        Me.CbAbsender.TabIndex = 53
        Me.CbAbsender.ValueMember = "id"
        '
        'AufgenommenTextBox
        '
        Me.AufgenommenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.AufgenommenTextBox.Location = New System.Drawing.Point(462, 10)
        Me.AufgenommenTextBox.Name = "AufgenommenTextBox"
        Me.AufgenommenTextBox.Size = New System.Drawing.Size(40, 20)
        Me.AufgenommenTextBox.TabIndex = 52
        Me.AufgenommenTextBox.Visible = False
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(416, 10)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(40, 20)
        Me.EmpfaengerTextBox.TabIndex = 51
        Me.EmpfaengerTextBox.Visible = False
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Absender", True))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(366, 10)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.Size = New System.Drawing.Size(44, 20)
        Me.AbsenderTextBox.TabIndex = 50
        Me.AbsenderTextBox.Visible = False
        '
        'ComboBox6
        '
        Me.ComboBox6.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Ablage", True))
        Me.ComboBox6.DataSource = Me.AblageBindingSource
        Me.ComboBox6.DisplayMember = "Ablage"
        Me.ComboBox6.FormattingEnabled = True
        Me.ComboBox6.Location = New System.Drawing.Point(630, 304)
        Me.ComboBox6.Name = "ComboBox6"
        Me.ComboBox6.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox6.TabIndex = 49
        Me.ComboBox6.ValueMember = "Nummer"
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Status", True))
        Me.ComboBox5.DataSource = Me.StatusBindingSource
        Me.ComboBox5.DisplayMember = "Status"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(367, 304)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox5.TabIndex = 48
        Me.ComboBox5.ValueMember = "id"
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Typ", True))
        Me.ComboBox4.DataSource = Me.TypBindingSource
        Me.ComboBox4.DisplayMember = "Typ"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(106, 304)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox4.TabIndex = 47
        Me.ComboBox4.ValueMember = "id"
        '
        'CbVorgang
        '
        Me.CbVorgang.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Vorgang", True))
        Me.CbVorgang.DataSource = Me.VorgaengeBindingSource
        Me.CbVorgang.DisplayMember = "Vorgang"
        Me.CbVorgang.FormattingEnabled = True
        Me.CbVorgang.Location = New System.Drawing.Point(106, 63)
        Me.CbVorgang.Name = "CbVorgang"
        Me.CbVorgang.Size = New System.Drawing.Size(166, 21)
        Me.CbVorgang.TabIndex = 46
        Me.CbVorgang.ValueMember = "id"
        '
        'CbAkte
        '
        Me.CbAkte.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Akte", True))
        Me.CbAkte.DataSource = Me.AktenBindingSource
        Me.CbAkte.DisplayMember = "Akte"
        Me.CbAkte.FormattingEnabled = True
        Me.CbAkte.Location = New System.Drawing.Point(106, 37)
        Me.CbAkte.Name = "CbAkte"
        Me.CbAkte.Size = New System.Drawing.Size(166, 21)
        Me.CbAkte.TabIndex = 45
        Me.CbAkte.ValueMember = "id"
        '
        'CbMandat
        '
        Me.CbMandat.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Mandant", True))
        Me.CbMandat.DataSource = Me.MandantBindingSource
        Me.CbMandat.DisplayMember = "Mandant"
        Me.CbMandat.FormattingEnabled = True
        Me.CbMandat.Location = New System.Drawing.Point(106, 10)
        Me.CbMandat.Name = "CbMandat"
        Me.CbMandat.Size = New System.Drawing.Size(166, 21)
        Me.CbMandat.TabIndex = 44
        Me.CbMandat.ValueMember = "id"
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(106, 118)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(166, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(106, 144)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(166, 20)
        Me.BetreffTextBox.TabIndex = 11
        '
        'BetragTextBox
        '
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True))
        Me.BetragTextBox.Location = New System.Drawing.Point(106, 170)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(166, 20)
        Me.BetragTextBox.TabIndex = 13
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(106, 205)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(166, 20)
        Me.DokDatumTextBox.TabIndex = 21
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(367, 48)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.Size = New System.Drawing.Size(429, 177)
        Me.KommentarTextBox.TabIndex = 27
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(106, 353)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(690, 20)
        Me.BearbVermerkTextBox.TabIndex = 43
        '
        'btSave
        '
        Me.btSave.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btSave.Location = New System.Drawing.Point(147, 440)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(140, 42)
        Me.btSave.TabIndex = 4
        Me.btSave.Text = "Speichern und zurück"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btClose.Location = New System.Drawing.Point(581, 440)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(140, 42)
        Me.btClose.TabIndex = 5
        Me.btClose.Text = "Zurück"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'TypTableAdapter
        '
        Me.TypTableAdapter.ClearBeforeFill = True
        '
        'StatusTableAdapter
        '
        Me.StatusTableAdapter.ClearBeforeFill = True
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
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
        'DocTextNew
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 492)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "DocTextNew"
        Me.Text = "FreeDMS-Tab - Texteintrag ohne Dokument"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox6 As ComboBox
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents CbVorgang As ComboBox
    Friend WithEvents CbAkte As ComboBox
    Friend WithEvents CbMandat As ComboBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents btSave As Button
    Friend WithEvents btClose As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents AufgenommenTextBox As TextBox
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents AbsenderTextBox As TextBox
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents CbEmpfaenger As ComboBox
    Friend WithEvents CbAbsender As ComboBox
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
End Class
