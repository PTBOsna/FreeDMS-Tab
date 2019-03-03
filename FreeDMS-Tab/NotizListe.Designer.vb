<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotizListe
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotizListe))
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim ErstelltLabel As System.Windows.Forms.Label
        Dim NotizLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.NotizBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
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
        Me.NotizBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TitelTextBox = New System.Windows.Forms.TextBox()
        Me.CbDokumente = New System.Windows.Forms.ComboBox()
        Me.CbVorgaenge = New System.Windows.Forms.ComboBox()
        Me.CbAkten = New System.Windows.Forms.ComboBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.ErstelltDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.NotizTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.NotizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.NotizTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.NotizDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        ErstelltLabel = New System.Windows.Forms.Label()
        NotizLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.NotizBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.NotizBindingNavigator.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NotizDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.NotizDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NotizBindingNavigator, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.8481!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.1519!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 450)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'NotizBindingNavigator
        '
        Me.NotizBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.NotizBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.NotizBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.NotizBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.NotizBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.NotizBindingNavigatorSaveItem})
        Me.NotizBindingNavigator.Location = New System.Drawing.Point(0, 395)
        Me.NotizBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.NotizBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.NotizBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.NotizBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.NotizBindingNavigator.Name = "NotizBindingNavigator"
        Me.NotizBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.NotizBindingNavigator.Size = New System.Drawing.Size(287, 25)
        Me.NotizBindingNavigator.TabIndex = 1
        Me.NotizBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
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
        'NotizBindingNavigatorSaveItem
        '
        Me.NotizBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NotizBindingNavigatorSaveItem.Image = CType(resources.GetObject("NotizBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.NotizBindingNavigatorSaveItem.Name = "NotizBindingNavigatorSaveItem"
        Me.NotizBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.NotizBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.Yellow
        Me.Panel1.Controls.Add(Me.TitelTextBox)
        Me.Panel1.Controls.Add(Me.CbDokumente)
        Me.Panel1.Controls.Add(Me.CbVorgaenge)
        Me.Panel1.Controls.Add(Me.CbAkten)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(Me.AkteTextBox)
        Me.Panel1.Controls.Add(VorgangLabel)
        Me.Panel1.Controls.Add(Me.VorgangTextBox)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(Me.DokumentTextBox)
        Me.Panel1.Controls.Add(ErstelltLabel)
        Me.Panel1.Controls.Add(Me.ErstelltDateTimePicker)
        Me.Panel1.Controls.Add(NotizLabel)
        Me.Panel1.Controls.Add(Me.NotizTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(403, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(394, 389)
        Me.Panel1.TabIndex = 0
        '
        'TitelTextBox
        '
        Me.TitelTextBox.BackColor = System.Drawing.Color.Yellow
        Me.TitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "titel", True))
        Me.TitelTextBox.Location = New System.Drawing.Point(11, 115)
        Me.TitelTextBox.Name = "TitelTextBox"
        Me.TitelTextBox.Size = New System.Drawing.Size(374, 20)
        Me.TitelTextBox.TabIndex = 15
        '
        'CbDokumente
        '
        Me.CbDokumente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "dokument", True))
        Me.CbDokumente.DataSource = Me.DokumenteBindingSource
        Me.CbDokumente.DisplayMember = "Dokument"
        Me.CbDokumente.FormattingEnabled = True
        Me.CbDokumente.Location = New System.Drawing.Point(123, 62)
        Me.CbDokumente.Name = "CbDokumente"
        Me.CbDokumente.Size = New System.Drawing.Size(262, 21)
        Me.CbDokumente.TabIndex = 14
        Me.CbDokumente.ValueMember = "id"
        '
        'CbVorgaenge
        '
        Me.CbVorgaenge.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "vorgang", True))
        Me.CbVorgaenge.DataSource = Me.VorgaengeBindingSource
        Me.CbVorgaenge.DisplayMember = "Vorgang"
        Me.CbVorgaenge.FormattingEnabled = True
        Me.CbVorgaenge.Location = New System.Drawing.Point(123, 35)
        Me.CbVorgaenge.Name = "CbVorgaenge"
        Me.CbVorgaenge.Size = New System.Drawing.Size(262, 21)
        Me.CbVorgaenge.TabIndex = 14
        Me.CbVorgaenge.ValueMember = "id"
        '
        'CbAkten
        '
        Me.CbAkten.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "akte", True))
        Me.CbAkten.DataSource = Me.AktenBindingSource
        Me.CbAkten.DisplayMember = "Akte"
        Me.CbAkten.FormattingEnabled = True
        Me.CbAkten.Location = New System.Drawing.Point(123, 9)
        Me.CbAkten.Name = "CbAkten"
        Me.CbAkten.Size = New System.Drawing.Size(262, 21)
        Me.CbAkten.TabIndex = 14
        Me.CbAkten.ValueMember = "id"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(8, 13)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 2
        AkteLabel.Text = "Akte:"
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(71, 10)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(31, 20)
        Me.AkteTextBox.TabIndex = 3
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(8, 39)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 4
        VorgangLabel.Text = "Vorgang:"
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(71, 36)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(31, 20)
        Me.VorgangTextBox.TabIndex = 5
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(8, 65)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 6
        DokumentLabel.Text = "Dokument:"
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(71, 62)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(31, 20)
        Me.DokumentTextBox.TabIndex = 7
        '
        'ErstelltLabel
        '
        ErstelltLabel.AutoSize = True
        ErstelltLabel.Location = New System.Drawing.Point(8, 92)
        ErstelltLabel.Name = "ErstelltLabel"
        ErstelltLabel.Size = New System.Drawing.Size(41, 13)
        ErstelltLabel.TabIndex = 8
        ErstelltLabel.Text = "Erstellt:"
        '
        'ErstelltDateTimePicker
        '
        Me.ErstelltDateTimePicker.Location = New System.Drawing.Point(71, 88)
        Me.ErstelltDateTimePicker.Name = "ErstelltDateTimePicker"
        Me.ErstelltDateTimePicker.Size = New System.Drawing.Size(200, 20)
        Me.ErstelltDateTimePicker.TabIndex = 9
        '
        'NotizLabel
        '
        NotizLabel.AutoSize = True
        NotizLabel.Location = New System.Drawing.Point(8, 141)
        NotizLabel.Name = "NotizLabel"
        NotizLabel.Size = New System.Drawing.Size(0, 13)
        NotizLabel.TabIndex = 10
        '
        'NotizTextBox
        '
        Me.NotizTextBox.BackColor = System.Drawing.Color.Yellow
        Me.NotizTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "notiz", True))
        Me.NotizTextBox.Location = New System.Drawing.Point(11, 141)
        Me.NotizTextBox.Multiline = True
        Me.NotizTextBox.Name = "NotizTextBox"
        Me.NotizTextBox.Size = New System.Drawing.Size(374, 196)
        Me.NotizTextBox.TabIndex = 11
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(403, 398)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(394, 49)
        Me.Panel2.TabIndex = 2
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(106, 6)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(89, 34)
        Me.BtClose.TabIndex = 2
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'NotizBindingSource
        '
        Me.NotizBindingSource.DataMember = "notiz"
        Me.NotizBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'NotizTableAdapter
        '
        Me.NotizTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Nothing
        Me.TableAdapterManager.AktenTableAdapter = Me.AktenTableAdapter
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        'Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Nothing
        Me.TableAdapterManager.notizTableAdapter = Me.NotizTableAdapter
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Me.VorgaengeTableAdapter
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'NotizDataGridView
        '
        Me.NotizDataGridView.AutoGenerateColumns = False
        Me.NotizDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.NotizDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6})
        Me.NotizDataGridView.DataSource = Me.NotizBindingSource
        Me.NotizDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotizDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.NotizDataGridView.Name = "NotizDataGridView"
        Me.NotizDataGridView.Size = New System.Drawing.Size(394, 389)
        Me.NotizDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "erstellt"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Notiz vom"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "titel"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Notiz"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'NotizListe
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "NotizListe"
        Me.Text = "NotizListe"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.NotizBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.NotizBindingNavigator.ResumeLayout(False)
        Me.NotizBindingNavigator.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NotizDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents NotizBindingNavigator As BindingNavigator
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
    Friend WithEvents NotizBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TitelTextBox As TextBox
    Friend WithEvents CbDokumente As ComboBox
    Friend WithEvents CbVorgaenge As ComboBox
    Friend WithEvents CbAkten As ComboBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents ErstelltDateTimePicker As DateTimePicker
    Friend WithEvents NotizTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtClose As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents NotizBindingSource As BindingSource
    Friend WithEvents NotizTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NotizDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents DokumenteBindingSource As BindingSource
End Class
