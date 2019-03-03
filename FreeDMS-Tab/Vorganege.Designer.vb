<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vorganege
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
        Dim AkteLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim AngelegtLabel As System.Windows.Forms.Label
        Dim ArchiviertLabel As System.Windows.Forms.Label
        Dim ArchivLabel As System.Windows.Forms.Label
        Dim HinweiseLabel As System.Windows.Forms.Label
        Dim ZeitzielLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vorganege))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.VorgaengeBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.VorgaengeBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VorgaengeDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ZeitzielDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HinweiseTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lbAnzahlZeichen = New System.Windows.Forms.Label()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.AngelegtDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ArchiviertDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.ArchivCheckBox = New System.Windows.Forms.CheckBox()
        Me.btClose = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.LbAuswahl = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtAlles = New System.Windows.Forms.Button()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.BegonnenTextBox = New System.Windows.Forms.TextBox()
        Me.ZeitzielTextBox = New System.Windows.Forms.TextBox()
        Me.BeendetTextBox = New System.Windows.Forms.TextBox()
        AkteLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        AngelegtLabel = New System.Windows.Forms.Label()
        ArchiviertLabel = New System.Windows.Forms.Label()
        ArchivLabel = New System.Windows.Forms.Label()
        HinweiseLabel = New System.Windows.Forms.Label()
        ZeitzielLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.VorgaengeBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VorgaengeBindingNavigator.SuspendLayout()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.AktenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(70, 24)
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
        AngelegtLabel.Location = New System.Drawing.Point(50, 256)
        AngelegtLabel.Name = "AngelegtLabel"
        AngelegtLabel.Size = New System.Drawing.Size(52, 13)
        AngelegtLabel.TabIndex = 8
        AngelegtLabel.Text = "Angelegt:"
        '
        'ArchiviertLabel
        '
        ArchiviertLabel.AutoSize = True
        ArchiviertLabel.Location = New System.Drawing.Point(55, 308)
        ArchiviertLabel.Name = "ArchiviertLabel"
        ArchiviertLabel.Size = New System.Drawing.Size(47, 13)
        ArchiviertLabel.TabIndex = 10
        ArchiviertLabel.Text = "Beendet"
        '
        'ArchivLabel
        '
        ArchivLabel.AutoSize = True
        ArchivLabel.Location = New System.Drawing.Point(62, 335)
        ArchivLabel.Name = "ArchivLabel"
        ArchivLabel.Size = New System.Drawing.Size(40, 13)
        ArchivLabel.TabIndex = 12
        ArchivLabel.Text = "Archiv:"
        '
        'HinweiseLabel
        '
        HinweiseLabel.AutoSize = True
        HinweiseLabel.Location = New System.Drawing.Point(49, 174)
        HinweiseLabel.Name = "HinweiseLabel"
        HinweiseLabel.Size = New System.Drawing.Size(53, 13)
        HinweiseLabel.TabIndex = 19
        HinweiseLabel.Text = "Hinweise:"
        '
        'ZeitzielLabel
        '
        ZeitzielLabel.AutoSize = True
        ZeitzielLabel.Location = New System.Drawing.Point(59, 282)
        ZeitzielLabel.Name = "ZeitzielLabel"
        ZeitzielLabel.Size = New System.Drawing.Size(43, 13)
        ZeitzielLabel.TabIndex = 20
        ZeitzielLabel.Text = "Zeitziel:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.52096!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.47904!))
        Me.TableLayoutPanel1.Controls.Add(Me.VorgaengeBindingNavigator, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.VorgaengeDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.btClose, 1, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.86487!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13513!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(835, 444)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'VorgaengeBindingNavigator
        '
        Me.VorgaengeBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VorgaengeBindingNavigator.BindingSource = Me.VorgaengeBindingSource
        Me.VorgaengeBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VorgaengeBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VorgaengeBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VorgaengeBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VorgaengeBindingNavigatorSaveItem})
        Me.VorgaengeBindingNavigator.Location = New System.Drawing.Point(0, 403)
        Me.VorgaengeBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VorgaengeBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VorgaengeBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VorgaengeBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VorgaengeBindingNavigator.Name = "VorgaengeBindingNavigator"
        Me.VorgaengeBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VorgaengeBindingNavigator.Size = New System.Drawing.Size(497, 41)
        Me.VorgaengeBindingNavigator.TabIndex = 4
        Me.VorgaengeBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 38)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 38)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 38)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 38)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 38)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 41)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 41)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 38)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 38)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 41)
        '
        'VorgaengeBindingNavigatorSaveItem
        '
        Me.VorgaengeBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VorgaengeBindingNavigatorSaveItem.Image = CType(resources.GetObject("VorgaengeBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VorgaengeBindingNavigatorSaveItem.Name = "VorgaengeBindingNavigatorSaveItem"
        Me.VorgaengeBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 38)
        Me.VorgaengeBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'VorgaengeDataGridView
        '
        Me.VorgaengeDataGridView.AutoGenerateColumns = False
        Me.VorgaengeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VorgaengeDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn6})
        Me.VorgaengeDataGridView.DataSource = Me.VorgaengeBindingSource
        Me.VorgaengeDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.VorgaengeDataGridView.Location = New System.Drawing.Point(3, 43)
        Me.VorgaengeDataGridView.Name = "VorgaengeDataGridView"
        Me.VorgaengeDataGridView.Size = New System.Drawing.Size(491, 357)
        Me.VorgaengeDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Akte"
        Me.DataGridViewTextBoxColumn2.DataSource = Me.AktenBindingSource
        Me.DataGridViewTextBoxColumn2.DisplayMember = "Akte"
        Me.DataGridViewTextBoxColumn2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.DataGridViewTextBoxColumn2.HeaderText = "Akte"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn2.ValueMember = "id"
        Me.DataGridViewTextBoxColumn2.Width = 54
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Az."
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 47
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Vorgang"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Vorgang"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Begonnen"
        DataGridViewCellStyle4.Format = "d"
        DataGridViewCellStyle4.NullValue = Nothing
        Me.DataGridViewTextBoxColumn6.DefaultCellStyle = DataGridViewCellStyle4
        Me.DataGridViewTextBoxColumn6.HeaderText = "Begonnen"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 81
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.BeendetTextBox)
        Me.Panel1.Controls.Add(Me.ZeitzielTextBox)
        Me.Panel1.Controls.Add(Me.BegonnenTextBox)
        Me.Panel1.Controls.Add(ZeitzielLabel)
        Me.Panel1.Controls.Add(Me.ZeitzielDateTimePicker)
        Me.Panel1.Controls.Add(HinweiseLabel)
        Me.Panel1.Controls.Add(Me.HinweiseTextBox)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Me.ComboBox1)
        Me.Panel1.Controls.Add(Me.Label2)
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
        Me.Panel1.Location = New System.Drawing.Point(500, 43)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(332, 357)
        Me.Panel1.TabIndex = 0
        '
        'ZeitzielDateTimePicker
        '
        Me.ZeitzielDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.VorgaengeBindingSource, "Zeitziel", True))
        Me.ZeitzielDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ZeitzielDateTimePicker.Location = New System.Drawing.Point(227, 278)
        Me.ZeitzielDateTimePicker.Name = "ZeitzielDateTimePicker"
        Me.ZeitzielDateTimePicker.Size = New System.Drawing.Size(81, 20)
        Me.ZeitzielDateTimePicker.TabIndex = 21
        '
        'HinweiseTextBox
        '
        Me.HinweiseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Hinweise", True))
        Me.HinweiseTextBox.Location = New System.Drawing.Point(108, 171)
        Me.HinweiseTextBox.Multiline = True
        Me.HinweiseTextBox.Name = "HinweiseTextBox"
        Me.HinweiseTextBox.Size = New System.Drawing.Size(200, 52)
        Me.HinweiseTextBox.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 13)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Vorgang:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(108, 53)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(30, 20)
        Me.IdTextBox.TabIndex = 18
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VorgaengeBindingSource, "Akte", True))
        Me.ComboBox1.DataSource = Me.AktenBindingSource
        Me.ComboBox1.DisplayMember = "Akte"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(108, 21)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(200, 21)
        Me.ComboBox1.TabIndex = 17
        Me.ComboBox1.ValueMember = "id"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(105, 226)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "(250 Zeichen)"
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
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Vorgang", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(150, 53)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(158, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Beschreibung", True))
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
        Me.AngelegtDateTimePicker.Location = New System.Drawing.Point(227, 252)
        Me.AngelegtDateTimePicker.Name = "AngelegtDateTimePicker"
        Me.AngelegtDateTimePicker.Size = New System.Drawing.Size(81, 20)
        Me.AngelegtDateTimePicker.TabIndex = 9
        '
        'ArchiviertDateTimePicker
        '
        Me.ArchiviertDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.ArchiviertDateTimePicker.Location = New System.Drawing.Point(227, 304)
        Me.ArchiviertDateTimePicker.Name = "ArchiviertDateTimePicker"
        Me.ArchiviertDateTimePicker.Size = New System.Drawing.Size(81, 20)
        Me.ArchiviertDateTimePicker.TabIndex = 11
        '
        'ArchivCheckBox
        '
        Me.ArchivCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Archiv", True))
        Me.ArchivCheckBox.Location = New System.Drawing.Point(108, 330)
        Me.ArchivCheckBox.Name = "ArchivCheckBox"
        Me.ArchivCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.ArchivCheckBox.TabIndex = 13
        Me.ArchivCheckBox.UseVisualStyleBackColor = True
        '
        'btClose
        '
        Me.btClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btClose.Location = New System.Drawing.Point(500, 406)
        Me.btClose.Name = "btClose"
        Me.btClose.Size = New System.Drawing.Size(102, 35)
        Me.btClose.TabIndex = 2
        Me.btClose.Text = "Zurück"
        Me.btClose.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.LbAuswahl)
        Me.Panel2.Controls.Add(Me.ComboBox2)
        Me.Panel2.Controls.Add(Me.BtAlles)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(491, 34)
        Me.Panel2.TabIndex = 5
        '
        'LbAuswahl
        '
        Me.LbAuswahl.AutoSize = True
        Me.LbAuswahl.Location = New System.Drawing.Point(211, 8)
        Me.LbAuswahl.Name = "LbAuswahl"
        Me.LbAuswahl.Size = New System.Drawing.Size(92, 13)
        Me.LbAuswahl.TabIndex = 2
        Me.LbAuswahl.Text = "Voränge zur Akte:"
        '
        'ComboBox2
        '
        Me.ComboBox2.DataSource = Me.AktenBindingSource1
        Me.ComboBox2.DisplayMember = "Akte"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(309, 5)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(152, 21)
        Me.ComboBox2.TabIndex = 1
        Me.ComboBox2.ValueMember = "id"
        '
        'AktenBindingSource1
        '
        Me.AktenBindingSource1.DataMember = "Akten"
        Me.AktenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'BtAlles
        '
        Me.BtAlles.Location = New System.Drawing.Point(9, 3)
        Me.BtAlles.Name = "BtAlles"
        Me.BtAlles.Size = New System.Drawing.Size(135, 23)
        Me.BtAlles.TabIndex = 0
        Me.BtAlles.Text = "Alle Vorgänge"
        Me.BtAlles.UseVisualStyleBackColor = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
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
        Me.TableAdapterManager.DokumenteTableAdapter = Nothing
        Me.TableAdapterManager.MandantTableAdapter = Nothing
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Me.VorgaengeTableAdapter
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'BegonnenTextBox
        '
        Me.BegonnenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Begonnen", True))
        Me.BegonnenTextBox.Location = New System.Drawing.Point(108, 253)
        Me.BegonnenTextBox.Name = "BegonnenTextBox"
        Me.BegonnenTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BegonnenTextBox.TabIndex = 22
        '
        'ZeitzielTextBox
        '
        Me.ZeitzielTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Zeitziel", True))
        Me.ZeitzielTextBox.Location = New System.Drawing.Point(108, 278)
        Me.ZeitzielTextBox.Name = "ZeitzielTextBox"
        Me.ZeitzielTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ZeitzielTextBox.TabIndex = 23
        '
        'BeendetTextBox
        '
        Me.BeendetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Beendet", True))
        Me.BeendetTextBox.Location = New System.Drawing.Point(108, 305)
        Me.BeendetTextBox.Name = "BeendetTextBox"
        Me.BeendetTextBox.Size = New System.Drawing.Size(100, 20)
        Me.BeendetTextBox.TabIndex = 24
        '
        'Vorganege
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(835, 444)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Vorganege"
        Me.Text = "FreeDMS-Tab - Vorgänge/Ordner"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.VorgaengeBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VorgaengeBindingNavigator.ResumeLayout(False)
        Me.VorgaengeBindingNavigator.PerformLayout()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.AktenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents lbAnzahlZeichen As Label
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents BeschreibungTextBox As TextBox
    Friend WithEvents AngelegtDateTimePicker As DateTimePicker
    Friend WithEvents ArchiviertDateTimePicker As DateTimePicker
    Friend WithEvents ArchivCheckBox As CheckBox
    Friend WithEvents btClose As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VorgaengeBindingNavigator As BindingNavigator
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
    Friend WithEvents VorgaengeBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VorgaengeDataGridView As DataGridView
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents ZeitzielDateTimePicker As DateTimePicker
    Friend WithEvents HinweiseTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtAlles As Button
    Friend WithEvents LbAuswahl As Label
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents AktenBindingSource1 As BindingSource
    Friend WithEvents BeendetTextBox As TextBox
    Friend WithEvents ZeitzielTextBox As TextBox
    Friend WithEvents BegonnenTextBox As TextBox
End Class
