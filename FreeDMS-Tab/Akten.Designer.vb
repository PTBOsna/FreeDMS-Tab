<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Akten
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
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim AngelegtLabel As System.Windows.Forms.Label
        Dim ArchiviertLabel As System.Windows.Forms.Label
        Dim ArchivLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Akten))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AktenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.AktenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lbAnzahlZeichen = New System.Windows.Forms.Label()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.AngelegtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ArchiviertDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ArchivCheckBox = New System.Windows.Forms.CheckBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.AktenDataGridView = New System.Windows.Forms.DataGridView()
        Me.Mandant = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.AngelegtTextBox = New System.Windows.Forms.TextBox()
        Me.ArchiviertTextBox = New System.Windows.Forms.TextBox()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        AngelegtLabel = New System.Windows.Forms.Label()
        ArchiviertLabel = New System.Windows.Forms.Label()
        ArchivLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AktenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AktenBindingNavigator.SuspendLayout()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(27, 25)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 15
        MandantLabel.Text = "Bereich:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(27, 56)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'BeschreibungLabel
        '
        BeschreibungLabel.AutoSize = True
        BeschreibungLabel.Location = New System.Drawing.Point(27, 82)
        BeschreibungLabel.Name = "BeschreibungLabel"
        BeschreibungLabel.Size = New System.Drawing.Size(75, 13)
        BeschreibungLabel.TabIndex = 6
        BeschreibungLabel.Text = "Beschreibung:"
        '
        'AngelegtLabel
        '
        AngelegtLabel.AutoSize = True
        AngelegtLabel.Location = New System.Drawing.Point(27, 178)
        AngelegtLabel.Name = "AngelegtLabel"
        AngelegtLabel.Size = New System.Drawing.Size(52, 13)
        AngelegtLabel.TabIndex = 8
        AngelegtLabel.Text = "Angelegt:"
        '
        'ArchiviertLabel
        '
        ArchiviertLabel.AutoSize = True
        ArchiviertLabel.Location = New System.Drawing.Point(27, 251)
        ArchiviertLabel.Name = "ArchiviertLabel"
        ArchiviertLabel.Size = New System.Drawing.Size(54, 13)
        ArchiviertLabel.TabIndex = 10
        ArchiviertLabel.Text = "Archiviert:"
        '
        'ArchivLabel
        '
        ArchivLabel.AutoSize = True
        ArchivLabel.Location = New System.Drawing.Point(27, 222)
        ArchivLabel.Name = "ArchivLabel"
        ArchivLabel.Size = New System.Drawing.Size(40, 13)
        ArchivLabel.TabIndex = 12
        ArchivLabel.Text = "Archiv:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AktenBindingNavigator, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btClose, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AktenDataGridView, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 87.30159!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.69841!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(698, 390)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'AktenBindingNavigator
        '
        Me.AktenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AktenBindingNavigator.BindingSource = Me.AktenBindingSource
        Me.AktenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AktenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AktenBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AktenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AktenBindingNavigatorSaveItem})
        Me.AktenBindingNavigator.Location = New System.Drawing.Point(0, 340)
        Me.AktenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AktenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AktenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AktenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AktenBindingNavigator.Name = "AktenBindingNavigator"
        Me.AktenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AktenBindingNavigator.Size = New System.Drawing.Size(349, 50)
        Me.AktenBindingNavigator.TabIndex = 3
        Me.AktenBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 47)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 50)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 50)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 47)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 50)
        '
        'AktenBindingNavigatorSaveItem
        '
        Me.AktenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AktenBindingNavigatorSaveItem.Image = CType(resources.GetObject("AktenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AktenBindingNavigatorSaveItem.Name = "AktenBindingNavigatorSaveItem"
        Me.AktenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 47)
        Me.AktenBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.ArchiviertTextBox)
        Me.Panel1.Controls.Add(Me.AngelegtTextBox)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(MandantLabel)
        Me.Panel1.Controls.Add(Me.lbAnzahlZeichen)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(Me.AkteTextBox)
        Me.Panel1.Controls.Add(BeschreibungLabel)
        Me.Panel1.Controls.Add(Me.BeschreibungTextBox)
        Me.Panel1.Controls.Add(AngelegtLabel)
        Me.Panel1.Controls.Add(Me.AngelegtDateTimePicker)
        Me.Panel1.Controls.Add(ArchiviertLabel)
        Me.Panel1.Controls.Add(Me.ArchiviertDateTimePicker)
        Me.Panel1.Controls.Add(ArchivLabel)
        Me.Panel1.Controls.Add(Me.ArchivCheckBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(352, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(343, 334)
        Me.Panel1.TabIndex = 0
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(108, 53)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(30, 20)
        Me.IdTextBox.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.AktenBindingSource, "Mandant", True))
        Me.ComboBox1.DataSource = Me.MandantBindingSource
        Me.ComboBox1.DisplayMember = "Mandant"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'lbAnzahlZeichen
        '
        Me.lbAnzahlZeichen.AutoSize = True
        Me.lbAnzahlZeichen.Location = New System.Drawing.Point(105, 142)
        Me.lbAnzahlZeichen.Name = "lbAnzahlZeichen"
        Me.lbAnzahlZeichen.Size = New System.Drawing.Size(73, 13)
        Me.lbAnzahlZeichen.TabIndex = 15
        Me.lbAnzahlZeichen.Text = "(250 Zeichen)"
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(150, 53)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(158, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Location = New System.Drawing.Point(108, 79)
        Me.BeschreibungTextBox.MaxLength = 250
        Me.BeschreibungTextBox.Multiline = True
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        Me.BeschreibungTextBox.Size = New System.Drawing.Size(200, 60)
        Me.BeschreibungTextBox.TabIndex = 7
        '
        'AngelegtDateTimePicker
        '
        Me.AngelegtDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.AngelegtDateTimePicker.Location = New System.Drawing.Point(234, 178)
        Me.AngelegtDateTimePicker.Name = "AngelegtDateTimePicker"
        Me.AngelegtDateTimePicker.Size = New System.Drawing.Size(74, 20)
        Me.AngelegtDateTimePicker.TabIndex = 9
        '
        'ArchiviertDateTimePicker
        '
        Me.ArchiviertDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ArchiviertDateTimePicker.Location = New System.Drawing.Point(234, 248)
        Me.ArchiviertDateTimePicker.Name = "ArchiviertDateTimePicker"
        Me.ArchiviertDateTimePicker.Size = New System.Drawing.Size(74, 20)
        Me.ArchiviertDateTimePicker.TabIndex = 11
        '
        'ArchivCheckBox
        '
        Me.ArchivCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Archiv", True))
        Me.ArchivCheckBox.Location = New System.Drawing.Point(108, 217)
        Me.ArchivCheckBox.Name = "ArchivCheckBox"
        Me.ArchivCheckBox.Size = New System.Drawing.Size(60, 24)
        Me.ArchivCheckBox.TabIndex = 13
        Me.ArchivCheckBox.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Location = New System.Drawing.Point(352, 343)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(75, 23)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "Zurück"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'AktenDataGridView
        '
        Me.AktenDataGridView.AutoGenerateColumns = False
        Me.AktenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AktenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Mandant, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5})
        Me.AktenDataGridView.DataSource = Me.AktenBindingSource
        Me.AktenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AktenDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.AktenDataGridView.Name = "AktenDataGridView"
        Me.AktenDataGridView.Size = New System.Drawing.Size(343, 334)
        Me.AktenDataGridView.TabIndex = 2
        '
        'Mandant
        '
        Me.Mandant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.Mandant.DataPropertyName = "Mandant"
        Me.Mandant.HeaderText = "Bereich"
        Me.Mandant.Name = "Mandant"
        Me.Mandant.Width = 68
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Akte"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Akte"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Angelegt"
        DataGridViewCellStyle2.Format = "d"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewTextBoxColumn5.HeaderText = "Angelegt"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 74
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
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
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'AngelegtTextBox
        '
        Me.AngelegtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Angelegt", True))
        Me.AngelegtTextBox.Location = New System.Drawing.Point(108, 175)
        Me.AngelegtTextBox.Name = "AngelegtTextBox"
        Me.AngelegtTextBox.Size = New System.Drawing.Size(100, 20)
        Me.AngelegtTextBox.TabIndex = 19
        '
        'ArchiviertTextBox
        '
        Me.ArchiviertTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Archiviert", True))
        Me.ArchiviertTextBox.Location = New System.Drawing.Point(108, 248)
        Me.ArchiviertTextBox.Name = "ArchiviertTextBox"
        Me.ArchiviertTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ArchiviertTextBox.TabIndex = 20
        '
        'Akten
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(698, 390)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Akten"
        Me.Text = "FreeDMS-Tab - Akten"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AktenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AktenBindingNavigator.ResumeLayout(False)
        Me.AktenBindingNavigator.PerformLayout()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lbAnzahlZeichen As Label
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents BeschreibungTextBox As TextBox
    Friend WithEvents AngelegtDateTimePicker As DateTimePicker
    Friend WithEvents ArchiviertDateTimePicker As DateTimePicker
    Friend WithEvents ArchivCheckBox As CheckBox
    Friend WithEvents btClose As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AktenBindingNavigator As BindingNavigator
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
    Friend WithEvents AktenBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AktenDataGridView As DataGridView
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Mandant As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents ArchiviertTextBox As TextBox
    Friend WithEvents AngelegtTextBox As TextBox
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
End Class
