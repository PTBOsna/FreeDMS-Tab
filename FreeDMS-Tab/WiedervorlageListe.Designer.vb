<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiedervorlageListe
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
        Dim Wv_datumLabel As System.Windows.Forms.Label
        Dim WiedervorlageLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WiedervorlageListe))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.WiedervorlageBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.WiedervorlageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.WiedervorlageBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.WiedervorlageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbDokument = New System.Windows.Forms.ComboBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbVorgang = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAkte = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.Wv_datumDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.WiedervorlageTextBox = New System.Windows.Forms.TextBox()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.WiedervorlageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.wiedervorlageTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.Wv_datumTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        Wv_datumLabel = New System.Windows.Forms.Label()
        WiedervorlageLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.WiedervorlageBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.WiedervorlageBindingNavigator.SuspendLayout()
        CType(Me.WiedervorlageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WiedervorlageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(30, 35)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Nr.;"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Enabled = False
        MandantLabel.Location = New System.Drawing.Point(30, 69)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 2
        MandantLabel.Text = "Bereich:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Enabled = False
        AkteLabel.Location = New System.Drawing.Point(30, 95)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Enabled = False
        VorgangLabel.Location = New System.Drawing.Point(30, 121)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 6
        VorgangLabel.Text = "Vorgang:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Enabled = False
        DokumentLabel.Location = New System.Drawing.Point(30, 147)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 8
        DokumentLabel.Text = "Dokument:"
        '
        'Wv_datumLabel
        '
        Wv_datumLabel.AutoSize = True
        Wv_datumLabel.Location = New System.Drawing.Point(30, 221)
        Wv_datumLabel.Name = "Wv_datumLabel"
        Wv_datumLabel.Size = New System.Drawing.Size(101, 13)
        Wv_datumLabel.TabIndex = 10
        Wv_datumLabel.Text = "Wiedervorlage zum:"
        '
        'WiedervorlageLabel
        '
        WiedervorlageLabel.AutoSize = True
        WiedervorlageLabel.Location = New System.Drawing.Point(30, 246)
        WiedervorlageLabel.Name = "WiedervorlageLabel"
        WiedervorlageLabel.Size = New System.Drawing.Size(79, 13)
        WiedervorlageLabel.TabIndex = 12
        WiedervorlageLabel.Text = "Wiedervorlage:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.WiedervorlageBindingNavigator, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.WiedervorlageDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtClose, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 90.18691!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.813084!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 428)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'WiedervorlageBindingNavigator
        '
        Me.WiedervorlageBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.WiedervorlageBindingNavigator.BindingSource = Me.WiedervorlageBindingSource
        Me.WiedervorlageBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.WiedervorlageBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.WiedervorlageBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.WiedervorlageBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.WiedervorlageBindingNavigatorSaveItem})
        Me.WiedervorlageBindingNavigator.Location = New System.Drawing.Point(0, 385)
        Me.WiedervorlageBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.WiedervorlageBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.WiedervorlageBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.WiedervorlageBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.WiedervorlageBindingNavigator.Name = "WiedervorlageBindingNavigator"
        Me.WiedervorlageBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.WiedervorlageBindingNavigator.Size = New System.Drawing.Size(287, 25)
        Me.WiedervorlageBindingNavigator.TabIndex = 1
        Me.WiedervorlageBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Enabled = False
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'WiedervorlageBindingSource
        '
        Me.WiedervorlageBindingSource.DataMember = "wiedervorlage"
        Me.WiedervorlageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'WiedervorlageBindingNavigatorSaveItem
        '
        Me.WiedervorlageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.WiedervorlageBindingNavigatorSaveItem.Image = CType(resources.GetObject("WiedervorlageBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.WiedervorlageBindingNavigatorSaveItem.Name = "WiedervorlageBindingNavigatorSaveItem"
        Me.WiedervorlageBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.WiedervorlageBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'WiedervorlageDataGridView
        '
        Me.WiedervorlageDataGridView.AutoGenerateColumns = False
        Me.WiedervorlageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.WiedervorlageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7})
        Me.WiedervorlageDataGridView.DataSource = Me.WiedervorlageBindingSource
        Me.WiedervorlageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WiedervorlageDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.WiedervorlageDataGridView.Name = "WiedervorlageDataGridView"
        Me.WiedervorlageDataGridView.Size = New System.Drawing.Size(394, 379)
        Me.WiedervorlageDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "wv_datum"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn6.HeaderText = "Wv. am:"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 72
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "wiedervorlage"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Wiedervorlage"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Wv_datumTextBox)
        Me.Panel1.Controls.Add(Me.CbMandant)
        Me.Panel1.Controls.Add(Me.CbDokument)
        Me.Panel1.Controls.Add(Me.CbVorgang)
        Me.Panel1.Controls.Add(Me.CbAkte)
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
        Me.Panel1.Controls.Add(Wv_datumLabel)
        Me.Panel1.Controls.Add(Me.Wv_datumDateTimePicker)
        Me.Panel1.Controls.Add(WiedervorlageLabel)
        Me.Panel1.Controls.Add(Me.WiedervorlageTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(403, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 379)
        Me.Panel1.TabIndex = 0
        '
        'CbMandant
        '
        Me.CbMandant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "mandant", True))
        Me.CbMandant.DataSource = Me.MandantBindingSource
        Me.CbMandant.DisplayMember = "Mandant"
        Me.CbMandant.Enabled = False
        Me.CbMandant.FormattingEnabled = True
        Me.CbMandant.Location = New System.Drawing.Point(158, 66)
        Me.CbMandant.Name = "CbMandant"
        Me.CbMandant.Size = New System.Drawing.Size(154, 21)
        Me.CbMandant.TabIndex = 14
        Me.CbMandant.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbDokument
        '
        Me.CbDokument.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "dokument", True))
        Me.CbDokument.DataSource = Me.DokumenteBindingSource
        Me.CbDokument.DisplayMember = "Dokument"
        Me.CbDokument.Enabled = False
        Me.CbDokument.FormattingEnabled = True
        Me.CbDokument.Location = New System.Drawing.Point(79, 170)
        Me.CbDokument.Name = "CbDokument"
        Me.CbDokument.Size = New System.Drawing.Size(233, 21)
        Me.CbDokument.TabIndex = 14
        Me.CbDokument.ValueMember = "id"
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbVorgang
        '
        Me.CbVorgang.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "vorgang", True))
        Me.CbVorgang.DataSource = Me.VorgaengeBindingSource
        Me.CbVorgang.DisplayMember = "Vorgang"
        Me.CbVorgang.Enabled = False
        Me.CbVorgang.FormattingEnabled = True
        Me.CbVorgang.Location = New System.Drawing.Point(158, 117)
        Me.CbVorgang.Name = "CbVorgang"
        Me.CbVorgang.Size = New System.Drawing.Size(154, 21)
        Me.CbVorgang.TabIndex = 14
        Me.CbVorgang.ValueMember = "id"
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAkte
        '
        Me.CbAkte.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "akte", True))
        Me.CbAkte.DataSource = Me.AktenBindingSource
        Me.CbAkte.DisplayMember = "Akte"
        Me.CbAkte.Enabled = False
        Me.CbAkte.FormattingEnabled = True
        Me.CbAkte.Location = New System.Drawing.Point(158, 92)
        Me.CbAkte.Name = "CbAkte"
        Me.CbAkte.Size = New System.Drawing.Size(154, 21)
        Me.CbAkte.TabIndex = 14
        Me.CbAkte.ValueMember = "id"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(112, 32)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(40, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "mandant", True))
        Me.MandantTextBox.Enabled = False
        Me.MandantTextBox.Location = New System.Drawing.Point(112, 66)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.Size = New System.Drawing.Size(40, 20)
        Me.MandantTextBox.TabIndex = 3
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "akte", True))
        Me.AkteTextBox.Enabled = False
        Me.AkteTextBox.Location = New System.Drawing.Point(112, 92)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(40, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "vorgang", True))
        Me.VorgangTextBox.Enabled = False
        Me.VorgangTextBox.Location = New System.Drawing.Point(112, 118)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(40, 20)
        Me.VorgangTextBox.TabIndex = 7
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "dokument", True))
        Me.DokumentTextBox.Enabled = False
        Me.DokumentTextBox.Location = New System.Drawing.Point(33, 171)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(40, 20)
        Me.DokumentTextBox.TabIndex = 9
        '
        'Wv_datumDateTimePicker
        '
        Me.Wv_datumDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.Wv_datumDateTimePicker.Location = New System.Drawing.Point(231, 218)
        Me.Wv_datumDateTimePicker.Name = "Wv_datumDateTimePicker"
        Me.Wv_datumDateTimePicker.Size = New System.Drawing.Size(81, 20)
        Me.Wv_datumDateTimePicker.TabIndex = 11
        '
        'WiedervorlageTextBox
        '
        Me.WiedervorlageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "wiedervorlage", True))
        Me.WiedervorlageTextBox.Location = New System.Drawing.Point(33, 262)
        Me.WiedervorlageTextBox.Name = "WiedervorlageTextBox"
        Me.WiedervorlageTextBox.Size = New System.Drawing.Size(279, 20)
        Me.WiedervorlageTextBox.TabIndex = 13
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(403, 388)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(128, 28)
        Me.BtClose.TabIndex = 2
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'WiedervorlageTableAdapter
        '
        Me.WiedervorlageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Nothing
        Me.TableAdapterManager.AktenTableAdapter = Me.AktenTableAdapter
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Me.MandantTableAdapter
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Me.VorgaengeTableAdapter
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Me.WiedervorlageTableAdapter
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
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
        'Wv_datumTextBox
        '
        Me.Wv_datumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "wv_datum", True))
        Me.Wv_datumTextBox.Location = New System.Drawing.Point(137, 218)
        Me.Wv_datumTextBox.Name = "Wv_datumTextBox"
        Me.Wv_datumTextBox.Size = New System.Drawing.Size(88, 20)
        Me.Wv_datumTextBox.TabIndex = 19
        '
        'WiedervorlageListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 428)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "WiedervorlageListe"
        Me.Text = "FreeDMS-Tab - Liste Wiedervorlagen"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.WiedervorlageBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.WiedervorlageBindingNavigator.ResumeLayout(False)
        Me.WiedervorlageBindingNavigator.PerformLayout()
        CType(Me.WiedervorlageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WiedervorlageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents WiedervorlageBindingSource As BindingSource
    Friend WithEvents WiedervorlageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.wiedervorlageTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents WiedervorlageBindingNavigator As BindingNavigator
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
    Friend WithEvents WiedervorlageBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents WiedervorlageDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents Wv_datumDateTimePicker As DateTimePicker
    Friend WithEvents WiedervorlageTextBox As TextBox
    Friend WithEvents CbMandant As ComboBox
    Friend WithEvents CbDokument As ComboBox
    Friend WithEvents CbVorgang As ComboBox
    Friend WithEvents CbAkte As ComboBox
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents BtClose As Button
    Friend WithEvents Wv_datumTextBox As TextBox
End Class
