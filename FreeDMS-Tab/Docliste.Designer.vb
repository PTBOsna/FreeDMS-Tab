<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Docliste
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
        Dim GeaendertLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim InhaltOCRLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DokNameLabel As System.Windows.Forms.Label
        Dim IstAnlageLabel As System.Windows.Forms.Label
        Dim AnlagenIDLabel As System.Windows.Forms.Label
        Dim BearbVermerkLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Docliste))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DokumenteBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.DokumenteBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.DokumenteDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ComboBox5 = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbVorgang = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAkte = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
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
        Me.AufgenommenDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.GeaendertDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.InhaltOCRTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.IstAnlageCheckBox = New System.Windows.Forms.CheckBox()
        Me.AnlagenIDTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.StatusTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter()
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
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
        GeaendertLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        InhaltOCRLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DokNameLabel = New System.Windows.Forms.Label()
        IstAnlageLabel = New System.Windows.Forms.Label()
        AnlagenIDLabel = New System.Windows.Forms.Label()
        BearbVermerkLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DokumenteBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DokumenteBindingNavigator.SuspendLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(20, 23)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Az:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(322, 22)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 2
        MandantLabel.Text = "Bereich:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(20, 49)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(322, 49)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 6
        VorgangLabel.Text = "Vorgang:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(20, 86)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(20, 112)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 10
        BetreffLabel.Text = "Betreff:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Location = New System.Drawing.Point(20, 263)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(41, 13)
        BetragLabel.TabIndex = 12
        BetragLabel.Text = "Betrag:"
        '
        'AnlagenLabel
        '
        AnlagenLabel.AutoSize = True
        AnlagenLabel.Location = New System.Drawing.Point(20, 406)
        AnlagenLabel.Name = "AnlagenLabel"
        AnlagenLabel.Size = New System.Drawing.Size(49, 13)
        AnlagenLabel.TabIndex = 14
        AnlagenLabel.Text = "Anlagen:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Location = New System.Drawing.Point(20, 141)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(55, 13)
        AbsenderLabel.TabIndex = 16
        AbsenderLabel.Text = "Absender:"
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Location = New System.Drawing.Point(322, 138)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(67, 13)
        EmpfaengerLabel.TabIndex = 18
        EmpfaengerLabel.Text = "Empfaenger:"
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(322, 329)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(64, 13)
        DokDatumLabel.TabIndex = 20
        DokDatumLabel.Text = "Dok Datum:"
        '
        'AufgenommenLabel
        '
        AufgenommenLabel.AutoSize = True
        AufgenommenLabel.Location = New System.Drawing.Point(20, 355)
        AufgenommenLabel.Name = "AufgenommenLabel"
        AufgenommenLabel.Size = New System.Drawing.Size(78, 13)
        AufgenommenLabel.TabIndex = 22
        AufgenommenLabel.Text = "Aufgenommen:"
        '
        'GeaendertLabel
        '
        GeaendertLabel.AutoSize = True
        GeaendertLabel.Location = New System.Drawing.Point(20, 381)
        GeaendertLabel.Name = "GeaendertLabel"
        GeaendertLabel.Size = New System.Drawing.Size(60, 13)
        GeaendertLabel.TabIndex = 24
        GeaendertLabel.Text = "Geaendert:"
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(20, 181)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 26
        KommentarLabel.Text = "Kommentar:"
        '
        'InhaltOCRLabel
        '
        InhaltOCRLabel.AutoSize = True
        InhaltOCRLabel.Location = New System.Drawing.Point(21, 460)
        InhaltOCRLabel.Name = "InhaltOCRLabel"
        InhaltOCRLabel.Size = New System.Drawing.Size(62, 13)
        InhaltOCRLabel.TabIndex = 28
        InhaltOCRLabel.Text = "Inhalt OCR:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(20, 302)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 30
        AblageLabel.Text = "Ablage:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(20, 328)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(28, 13)
        TypLabel.TabIndex = 32
        TypLabel.Text = "Typ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(322, 302)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(40, 13)
        StatusLabel.TabIndex = 34
        StatusLabel.Text = "Status:"
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Location = New System.Drawing.Point(322, 263)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(61, 13)
        DokNameLabel.TabIndex = 36
        DokNameLabel.Text = "Dok Name:"
        '
        'IstAnlageLabel
        '
        IstAnlageLabel.AutoSize = True
        IstAnlageLabel.Location = New System.Drawing.Point(204, 406)
        IstAnlageLabel.Name = "IstAnlageLabel"
        IstAnlageLabel.Size = New System.Drawing.Size(56, 13)
        IstAnlageLabel.TabIndex = 38
        IstAnlageLabel.Text = "ist Anlage:"
        '
        'AnlagenIDLabel
        '
        AnlagenIDLabel.AutoSize = True
        AnlagenIDLabel.Location = New System.Drawing.Point(322, 404)
        AnlagenIDLabel.Name = "AnlagenIDLabel"
        AnlagenIDLabel.Size = New System.Drawing.Size(63, 13)
        AnlagenIDLabel.TabIndex = 40
        AnlagenIDLabel.Text = "Anlagen ID:"
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Location = New System.Drawing.Point(20, 434)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(80, 13)
        BearbVermerkLabel.TabIndex = 42
        BearbVermerkLabel.Text = "Bearb Vermerk:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.0708!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.9292!))
        Me.TableLayoutPanel1.Controls.Add(Me.DokumenteBindingNavigator, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.DokumenteDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.77147!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.22853!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1130, 687)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'DokumenteBindingNavigator
        '
        Me.DokumenteBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.DokumenteBindingNavigator.BindingSource = Me.DokumenteBindingSource
        Me.DokumenteBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.DokumenteBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.DokumenteBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DokumenteBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.DokumenteBindingNavigatorSaveItem})
        Me.DokumenteBindingNavigator.Location = New System.Drawing.Point(0, 635)
        Me.DokumenteBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.DokumenteBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.DokumenteBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.DokumenteBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.DokumenteBindingNavigator.Name = "DokumenteBindingNavigator"
        Me.DokumenteBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.DokumenteBindingNavigator.Size = New System.Drawing.Size(498, 52)
        Me.DokumenteBindingNavigator.TabIndex = 1
        Me.DokumenteBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 49)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 49)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 49)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 49)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 49)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 52)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 52)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 49)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 49)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 52)
        '
        'DokumenteBindingNavigatorSaveItem
        '
        Me.DokumenteBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DokumenteBindingNavigatorSaveItem.Image = CType(resources.GetObject("DokumenteBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.DokumenteBindingNavigatorSaveItem.Name = "DokumenteBindingNavigatorSaveItem"
        Me.DokumenteBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 49)
        Me.DokumenteBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'DokumenteDataGridView
        '
        Me.DokumenteDataGridView.AutoGenerateColumns = False
        Me.DokumenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DokumenteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.DokumenteDataGridView.DataSource = Me.DokumenteBindingSource
        Me.DokumenteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DokumenteDataGridView.Location = New System.Drawing.Point(3, 71)
        Me.DokumenteDataGridView.Name = "DokumenteDataGridView"
        Me.DokumenteDataGridView.Size = New System.Drawing.Size(492, 561)
        Me.DokumenteDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "DokDatum"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn11.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn11.HeaderText = "Dok. vom:"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        Me.DataGridViewTextBoxColumn11.Width = 81
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nr."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Dokument"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Dokument"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 81
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Betreff"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Betreff"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.ComboBox5)
        Me.Panel1.Controls.Add(Me.ComboBox4)
        Me.Panel1.Controls.Add(Me.ComboBox3)
        Me.Panel1.Controls.Add(Me.ComboBox2)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.CbVorgang)
        Me.Panel1.Controls.Add(Me.CbAkte)
        Me.Panel1.Controls.Add(Me.CbMandant)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Controls.Add(Me.IdTextBox)
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
        Me.Panel1.Controls.Add(Me.AufgenommenDateTimePicker)
        Me.Panel1.Controls.Add(GeaendertLabel)
        Me.Panel1.Controls.Add(Me.GeaendertDateTimePicker)
        Me.Panel1.Controls.Add(KommentarLabel)
        Me.Panel1.Controls.Add(Me.KommentarTextBox)
        Me.Panel1.Controls.Add(InhaltOCRLabel)
        Me.Panel1.Controls.Add(Me.InhaltOCRTextBox)
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
        Me.Panel1.Location = New System.Drawing.Point(501, 71)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(626, 561)
        Me.Panel1.TabIndex = 0
        '
        'ComboBox5
        '
        Me.ComboBox5.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.ComboBox5.DataSource = Me.AnschriftenBindingSource1
        Me.ComboBox5.DisplayMember = "Name_"
        Me.ComboBox5.FormattingEnabled = True
        Me.ComboBox5.Location = New System.Drawing.Point(459, 134)
        Me.ComboBox5.Name = "ComboBox5"
        Me.ComboBox5.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox5.TabIndex = 55
        Me.ComboBox5.ValueMember = "id"
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Absender", True))
        Me.ComboBox4.DataSource = Me.AnschriftenBindingSource
        Me.ComboBox4.DisplayMember = "Name_"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(157, 138)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(151, 21)
        Me.ComboBox4.TabIndex = 54
        Me.ComboBox4.ValueMember = "id"
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Status", True))
        Me.ComboBox3.DataSource = Me.StatusBindingSource
        Me.ComboBox3.DisplayMember = "Status"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(447, 298)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(163, 21)
        Me.ComboBox3.TabIndex = 53
        Me.ComboBox3.ValueMember = "id"
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        Me.StatusBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Typ", True))
        Me.ComboBox2.DataSource = Me.TypBindingSource
        Me.ComboBox2.DisplayMember = "Typ"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(138, 324)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox2.TabIndex = 52
        Me.ComboBox2.ValueMember = "id"
        '
        'TypBindingSource
        '
        Me.TypBindingSource.DataMember = "Typ"
        Me.TypBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Ablage", True))
        Me.ComboBox1.DataSource = Me.AblageBindingSource
        Me.ComboBox1.DisplayMember = "Ablage"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(138, 298)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(170, 21)
        Me.ComboBox1.TabIndex = 51
        Me.ComboBox1.ValueMember = "Nummer"
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbVorgang
        '
        Me.CbVorgang.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Vorgang", True))
        Me.CbVorgang.DataSource = Me.VorgaengeBindingSource
        Me.CbVorgang.DisplayMember = "Vorgang"
        Me.CbVorgang.FormattingEnabled = True
        Me.CbVorgang.Location = New System.Drawing.Point(459, 46)
        Me.CbVorgang.Name = "CbVorgang"
        Me.CbVorgang.Size = New System.Drawing.Size(151, 21)
        Me.CbVorgang.TabIndex = 50
        Me.CbVorgang.ValueMember = "id"
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAkte
        '
        Me.CbAkte.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Akte", True))
        Me.CbAkte.DataSource = Me.AktenBindingSource
        Me.CbAkte.DisplayMember = "Akte"
        Me.CbAkte.FormattingEnabled = True
        Me.CbAkte.Location = New System.Drawing.Point(157, 45)
        Me.CbAkte.Name = "CbAkte"
        Me.CbAkte.Size = New System.Drawing.Size(151, 21)
        Me.CbAkte.TabIndex = 49
        Me.CbAkte.ValueMember = "id"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbMandant
        '
        Me.CbMandant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.DokumenteBindingSource, "Mandant", True))
        Me.CbMandant.DataSource = Me.MandantBindingSource
        Me.CbMandant.DisplayMember = "Mandant"
        Me.CbMandant.FormattingEnabled = True
        Me.CbMandant.Location = New System.Drawing.Point(459, 19)
        Me.CbMandant.Name = "CbMandant"
        Me.CbMandant.Size = New System.Drawing.Size(151, 21)
        Me.CbMandant.TabIndex = 48
        Me.CbMandant.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(108, 20)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(56, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(410, 19)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.Size = New System.Drawing.Size(43, 20)
        Me.MandantTextBox.TabIndex = 3
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(108, 46)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(43, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(410, 46)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(43, 20)
        Me.VorgangTextBox.TabIndex = 7
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(108, 83)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(502, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(108, 109)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(502, 20)
        Me.BetreffTextBox.TabIndex = 11
        '
        'BetragTextBox
        '
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True))
        Me.BetragTextBox.Location = New System.Drawing.Point(108, 260)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(200, 20)
        Me.BetragTextBox.TabIndex = 13
        '
        'AnlagenTextBox
        '
        Me.AnlagenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Anlagen", True))
        Me.AnlagenTextBox.Location = New System.Drawing.Point(108, 403)
        Me.AnlagenTextBox.Name = "AnlagenTextBox"
        Me.AnlagenTextBox.Size = New System.Drawing.Size(56, 20)
        Me.AnlagenTextBox.TabIndex = 15
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Absender", True))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(108, 138)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.Size = New System.Drawing.Size(43, 20)
        Me.AbsenderTextBox.TabIndex = 17
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Empfaenger", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(410, 135)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(43, 20)
        Me.EmpfaengerTextBox.TabIndex = 19
        '
        'DokDatumDateTimePicker
        '
        Me.DokDatumDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumDateTimePicker.Location = New System.Drawing.Point(410, 325)
        Me.DokDatumDateTimePicker.Name = "DokDatumDateTimePicker"
        Me.DokDatumDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.DokDatumDateTimePicker.TabIndex = 21
        '
        'AufgenommenDateTimePicker
        '
        Me.AufgenommenDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.AufgenommenDateTimePicker.Location = New System.Drawing.Point(108, 351)
        Me.AufgenommenDateTimePicker.Name = "AufgenommenDateTimePicker"
        Me.AufgenommenDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.AufgenommenDateTimePicker.TabIndex = 23
        '
        'GeaendertDateTimePicker
        '
        Me.GeaendertDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.DokumenteBindingSource, "Geaendert", True))
        Me.GeaendertDateTimePicker.Location = New System.Drawing.Point(108, 377)
        Me.GeaendertDateTimePicker.Name = "GeaendertDateTimePicker"
        Me.GeaendertDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.GeaendertDateTimePicker.TabIndex = 25
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(108, 178)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.Size = New System.Drawing.Size(502, 76)
        Me.KommentarTextBox.TabIndex = 27
        '
        'InhaltOCRTextBox
        '
        Me.InhaltOCRTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "InhaltOCR", True))
        Me.InhaltOCRTextBox.Location = New System.Drawing.Point(108, 457)
        Me.InhaltOCRTextBox.Multiline = True
        Me.InhaltOCRTextBox.Name = "InhaltOCRTextBox"
        Me.InhaltOCRTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.InhaltOCRTextBox.Size = New System.Drawing.Size(502, 101)
        Me.InhaltOCRTextBox.TabIndex = 29
        '
        'AblageTextBox
        '
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Ablage", True))
        Me.AblageTextBox.Location = New System.Drawing.Point(108, 299)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.Size = New System.Drawing.Size(24, 20)
        Me.AblageTextBox.TabIndex = 31
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(108, 325)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.Size = New System.Drawing.Size(24, 20)
        Me.TypTextBox.TabIndex = 33
        '
        'StatusTextBox
        '
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(410, 299)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(31, 20)
        Me.StatusTextBox.TabIndex = 35
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(410, 260)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(200, 20)
        Me.DokNameTextBox.TabIndex = 37
        '
        'IstAnlageCheckBox
        '
        Me.IstAnlageCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.DokumenteBindingSource, "istAnlage", True))
        Me.IstAnlageCheckBox.Location = New System.Drawing.Point(292, 401)
        Me.IstAnlageCheckBox.Name = "IstAnlageCheckBox"
        Me.IstAnlageCheckBox.Size = New System.Drawing.Size(16, 24)
        Me.IstAnlageCheckBox.TabIndex = 39
        Me.IstAnlageCheckBox.UseVisualStyleBackColor = True
        '
        'AnlagenIDTextBox
        '
        Me.AnlagenIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "AnlagenID", True))
        Me.AnlagenIDTextBox.Location = New System.Drawing.Point(410, 401)
        Me.AnlagenIDTextBox.Name = "AnlagenIDTextBox"
        Me.AnlagenIDTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AnlagenIDTextBox.TabIndex = 41
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(108, 431)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(502, 20)
        Me.BearbVermerkTextBox.TabIndex = 43
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(501, 638)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(626, 46)
        Me.Panel2.TabIndex = 1
        '
        'BtClose
        '
        Me.BtClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtClose.Location = New System.Drawing.Point(8, 9)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(92, 34)
        Me.BtClose.TabIndex = 0
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.TableLayoutPanel1.SetColumnSpan(Me.Panel3, 2)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 3)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1124, 62)
        Me.Panel3.TabIndex = 2
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Me.AblageTableAdapter
        Me.TableAdapterManager.AktenTableAdapter = Me.AktenTableAdapter
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        'Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Me.MandantTableAdapter
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Me.StatusTableAdapter
        Me.TableAdapterManager.TypTableAdapter = Me.TypTableAdapter
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Me.VorgaengeTableAdapter
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
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
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'Docliste
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1130, 687)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Docliste"
        Me.Text = "FreeDMS-Tab - Dokumentenliste"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DokumenteBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DokumenteBindingNavigator.ResumeLayout(False)
        Me.DokumenteBindingNavigator.PerformLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents DokumenteBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents DokumenteBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents DokumenteDataGridView As DataGridView
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
    Friend WithEvents AufgenommenDateTimePicker As DateTimePicker
    Friend WithEvents GeaendertDateTimePicker As DateTimePicker
    Friend WithEvents KommentarTextBox As TextBox
    Friend WithEvents InhaltOCRTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents TypTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents IstAnlageCheckBox As CheckBox
    Friend WithEvents AnlagenIDTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents CbVorgang As ComboBox
    Friend WithEvents CbAkte As ComboBox
    Friend WithEvents CbMandant As ComboBox
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents BtClose As Button
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents StatusTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.StatusTableAdapter
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents ComboBox5 As ComboBox
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
End Class
