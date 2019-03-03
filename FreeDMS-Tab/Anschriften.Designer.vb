<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Anschriften
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
        Dim MailLabel As System.Windows.Forms.Label
        Dim BmerkungenLabel As System.Windows.Forms.Label
        Dim IdLabel As System.Windows.Forms.Label
        Dim Name_Label As System.Windows.Forms.Label
        Dim ZusatzLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim Anschrift1Label As System.Windows.Forms.Label
        Dim Anschrift2Label As System.Windows.Forms.Label
        Dim LandLabel As System.Windows.Forms.Label
        Dim Telefon1Label As System.Windows.Forms.Label
        Dim Telefon2Label As System.Windows.Forms.Label
        Dim InternetLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Anschriften))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AnschriftenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.AnschriftenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AnschriftenDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.InternetTextBox = New System.Windows.Forms.TextBox()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.ZusatzTextBox = New System.Windows.Forms.TextBox()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.PLZTextBox = New System.Windows.Forms.TextBox()
        Me.Anschrift1TextBox = New System.Windows.Forms.TextBox()
        Me.Anschrift2TextBox = New System.Windows.Forms.TextBox()
        Me.LandTextBox = New System.Windows.Forms.TextBox()
        Me.Telefon1TextBox = New System.Windows.Forms.TextBox()
        Me.Telefon2TextBox = New System.Windows.Forms.TextBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.BmerkungenTextBox = New System.Windows.Forms.TextBox()
        Me.lblBemerk = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        MailLabel = New System.Windows.Forms.Label()
        BmerkungenLabel = New System.Windows.Forms.Label()
        IdLabel = New System.Windows.Forms.Label()
        Name_Label = New System.Windows.Forms.Label()
        ZusatzLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        PLZLabel = New System.Windows.Forms.Label()
        Anschrift1Label = New System.Windows.Forms.Label()
        Anschrift2Label = New System.Windows.Forms.Label()
        LandLabel = New System.Windows.Forms.Label()
        Telefon1Label = New System.Windows.Forms.Label()
        Telefon2Label = New System.Windows.Forms.Label()
        InternetLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AnschriftenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AnschriftenBindingNavigator.SuspendLayout()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(76, 333)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 48
        MailLabel.Text = "Mail:"
        '
        'BmerkungenLabel
        '
        BmerkungenLabel.AutoSize = True
        BmerkungenLabel.Location = New System.Drawing.Point(35, 359)
        BmerkungenLabel.Name = "BmerkungenLabel"
        BmerkungenLabel.Size = New System.Drawing.Size(70, 13)
        BmerkungenLabel.TabIndex = 46
        BmerkungenLabel.Text = "Bmerkungen:"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(87, 31)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 51
        IdLabel.Text = "Nr,:"
        '
        'Name_Label
        '
        Name_Label.AutoSize = True
        Name_Label.Location = New System.Drawing.Point(64, 57)
        Name_Label.Name = "Name_Label"
        Name_Label.Size = New System.Drawing.Size(41, 13)
        Name_Label.TabIndex = 53
        Name_Label.Text = "Name :"
        '
        'ZusatzLabel
        '
        ZusatzLabel.AutoSize = True
        ZusatzLabel.Location = New System.Drawing.Point(63, 83)
        ZusatzLabel.Name = "ZusatzLabel"
        ZusatzLabel.Size = New System.Drawing.Size(42, 13)
        ZusatzLabel.TabIndex = 55
        ZusatzLabel.Text = "Zusatz:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(81, 109)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 57
        OrtLabel.Text = "Ort:"
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(75, 135)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 59
        PLZLabel.Text = "PLZ:"
        '
        'Anschrift1Label
        '
        Anschrift1Label.AutoSize = True
        Anschrift1Label.Location = New System.Drawing.Point(48, 161)
        Anschrift1Label.Name = "Anschrift1Label"
        Anschrift1Label.Size = New System.Drawing.Size(57, 13)
        Anschrift1Label.TabIndex = 61
        Anschrift1Label.Text = "Anschrift1:"
        '
        'Anschrift2Label
        '
        Anschrift2Label.AutoSize = True
        Anschrift2Label.Location = New System.Drawing.Point(48, 187)
        Anschrift2Label.Name = "Anschrift2Label"
        Anschrift2Label.Size = New System.Drawing.Size(57, 13)
        Anschrift2Label.TabIndex = 63
        Anschrift2Label.Text = "Anschrift2:"
        '
        'LandLabel
        '
        LandLabel.AutoSize = True
        LandLabel.Location = New System.Drawing.Point(71, 213)
        LandLabel.Name = "LandLabel"
        LandLabel.Size = New System.Drawing.Size(34, 13)
        LandLabel.TabIndex = 65
        LandLabel.Text = "Land:"
        '
        'Telefon1Label
        '
        Telefon1Label.AutoSize = True
        Telefon1Label.Location = New System.Drawing.Point(53, 239)
        Telefon1Label.Name = "Telefon1Label"
        Telefon1Label.Size = New System.Drawing.Size(52, 13)
        Telefon1Label.TabIndex = 67
        Telefon1Label.Text = "Telefon1:"
        '
        'Telefon2Label
        '
        Telefon2Label.AutoSize = True
        Telefon2Label.Location = New System.Drawing.Point(53, 265)
        Telefon2Label.Name = "Telefon2Label"
        Telefon2Label.Size = New System.Drawing.Size(52, 13)
        Telefon2Label.TabIndex = 69
        Telefon2Label.Text = "Telefon2:"
        '
        'InternetLabel
        '
        InternetLabel.AutoSize = True
        InternetLabel.Location = New System.Drawing.Point(59, 291)
        InternetLabel.Name = "InternetLabel"
        InternetLabel.Size = New System.Drawing.Size(46, 13)
        InternetLabel.TabIndex = 70
        InternetLabel.Text = "Internet:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.5!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.5!))
        Me.TableLayoutPanel1.Controls.Add(Me.AnschriftenBindingNavigator, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AnschriftenDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Button1, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.12639!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.873614!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(800, 466)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'AnschriftenBindingNavigator
        '
        Me.AnschriftenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AnschriftenBindingNavigator.BindingSource = Me.AnschriftenBindingSource
        Me.AnschriftenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AnschriftenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AnschriftenBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.AnschriftenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AnschriftenBindingNavigatorSaveItem})
        Me.AnschriftenBindingNavigator.Location = New System.Drawing.Point(0, 433)
        Me.AnschriftenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AnschriftenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AnschriftenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AnschriftenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AnschriftenBindingNavigator.Name = "AnschriftenBindingNavigator"
        Me.AnschriftenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AnschriftenBindingNavigator.Size = New System.Drawing.Size(287, 25)
        Me.AnschriftenBindingNavigator.TabIndex = 3
        Me.AnschriftenBindingNavigator.Text = "BindingNavigator1"
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
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
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
        'AnschriftenBindingNavigatorSaveItem
        '
        Me.AnschriftenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AnschriftenBindingNavigatorSaveItem.Image = CType(resources.GetObject("AnschriftenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AnschriftenBindingNavigatorSaveItem.Name = "AnschriftenBindingNavigatorSaveItem"
        Me.AnschriftenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.AnschriftenBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'AnschriftenDataGridView
        '
        Me.AnschriftenDataGridView.AutoGenerateColumns = False
        Me.AnschriftenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnschriftenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn4})
        Me.AnschriftenDataGridView.DataSource = Me.AnschriftenBindingSource
        Me.AnschriftenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnschriftenDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.AnschriftenDataGridView.Name = "AnschriftenDataGridView"
        Me.AnschriftenDataGridView.Size = New System.Drawing.Size(382, 427)
        Me.AnschriftenDataGridView.TabIndex = 3
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Name_"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Zusatz"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Zusatz"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "PLZ"
        Me.DataGridViewTextBoxColumn5.HeaderText = "PLZ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Ort"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Ort"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(InternetLabel)
        Me.Panel1.Controls.Add(Me.InternetTextBox)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(Name_Label)
        Me.Panel1.Controls.Add(Me.Name_TextBox)
        Me.Panel1.Controls.Add(ZusatzLabel)
        Me.Panel1.Controls.Add(Me.ZusatzTextBox)
        Me.Panel1.Controls.Add(OrtLabel)
        Me.Panel1.Controls.Add(Me.OrtTextBox)
        Me.Panel1.Controls.Add(PLZLabel)
        Me.Panel1.Controls.Add(Me.PLZTextBox)
        Me.Panel1.Controls.Add(Anschrift1Label)
        Me.Panel1.Controls.Add(Me.Anschrift1TextBox)
        Me.Panel1.Controls.Add(Anschrift2Label)
        Me.Panel1.Controls.Add(Me.Anschrift2TextBox)
        Me.Panel1.Controls.Add(LandLabel)
        Me.Panel1.Controls.Add(Me.LandTextBox)
        Me.Panel1.Controls.Add(Telefon1Label)
        Me.Panel1.Controls.Add(Me.Telefon1TextBox)
        Me.Panel1.Controls.Add(Telefon2Label)
        Me.Panel1.Controls.Add(Me.Telefon2TextBox)
        Me.Panel1.Controls.Add(Me.LinkLabel1)
        Me.Panel1.Controls.Add(MailLabel)
        Me.Panel1.Controls.Add(Me.MailTextBox)
        Me.Panel1.Controls.Add(BmerkungenLabel)
        Me.Panel1.Controls.Add(Me.BmerkungenTextBox)
        Me.Panel1.Controls.Add(Me.lblBemerk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(391, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(406, 427)
        Me.Panel1.TabIndex = 2
        '
        'InternetTextBox
        '
        Me.InternetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Internet", True))
        Me.InternetTextBox.Location = New System.Drawing.Point(111, 288)
        Me.InternetTextBox.Name = "InternetTextBox"
        Me.InternetTextBox.Size = New System.Drawing.Size(245, 20)
        Me.InternetTextBox.TabIndex = 71
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(111, 28)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(62, 20)
        Me.IdTextBox.TabIndex = 52
        '
        'Name_TextBox
        '
        Me.Name_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Name_", True))
        Me.Name_TextBox.Location = New System.Drawing.Point(111, 54)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(245, 20)
        Me.Name_TextBox.TabIndex = 54
        '
        'ZusatzTextBox
        '
        Me.ZusatzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Zusatz", True))
        Me.ZusatzTextBox.Location = New System.Drawing.Point(111, 80)
        Me.ZusatzTextBox.Name = "ZusatzTextBox"
        Me.ZusatzTextBox.Size = New System.Drawing.Size(245, 20)
        Me.ZusatzTextBox.TabIndex = 56
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(111, 106)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(245, 20)
        Me.OrtTextBox.TabIndex = 58
        '
        'PLZTextBox
        '
        Me.PLZTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "PLZ", True))
        Me.PLZTextBox.Location = New System.Drawing.Point(111, 132)
        Me.PLZTextBox.Name = "PLZTextBox"
        Me.PLZTextBox.Size = New System.Drawing.Size(245, 20)
        Me.PLZTextBox.TabIndex = 60
        '
        'Anschrift1TextBox
        '
        Me.Anschrift1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Anschrift1", True))
        Me.Anschrift1TextBox.Location = New System.Drawing.Point(111, 158)
        Me.Anschrift1TextBox.Name = "Anschrift1TextBox"
        Me.Anschrift1TextBox.Size = New System.Drawing.Size(245, 20)
        Me.Anschrift1TextBox.TabIndex = 62
        '
        'Anschrift2TextBox
        '
        Me.Anschrift2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Anschrift2", True))
        Me.Anschrift2TextBox.Location = New System.Drawing.Point(111, 184)
        Me.Anschrift2TextBox.Name = "Anschrift2TextBox"
        Me.Anschrift2TextBox.Size = New System.Drawing.Size(245, 20)
        Me.Anschrift2TextBox.TabIndex = 64
        '
        'LandTextBox
        '
        Me.LandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Land", True))
        Me.LandTextBox.Location = New System.Drawing.Point(111, 210)
        Me.LandTextBox.Name = "LandTextBox"
        Me.LandTextBox.Size = New System.Drawing.Size(245, 20)
        Me.LandTextBox.TabIndex = 66
        '
        'Telefon1TextBox
        '
        Me.Telefon1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Telefon1", True))
        Me.Telefon1TextBox.Location = New System.Drawing.Point(111, 236)
        Me.Telefon1TextBox.Name = "Telefon1TextBox"
        Me.Telefon1TextBox.Size = New System.Drawing.Size(245, 20)
        Me.Telefon1TextBox.TabIndex = 68
        '
        'Telefon2TextBox
        '
        Me.Telefon2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Telefon2", True))
        Me.Telefon2TextBox.Location = New System.Drawing.Point(111, 262)
        Me.Telefon2TextBox.Name = "Telefon2TextBox"
        Me.Telefon2TextBox.Size = New System.Drawing.Size(245, 20)
        Me.Telefon2TextBox.TabIndex = 70
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(112, 311)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(27, 13)
        Me.LinkLabel1.TabIndex = 51
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Link"
        '
        'MailTextBox
        '
        Me.MailTextBox.Location = New System.Drawing.Point(111, 330)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(245, 20)
        Me.MailTextBox.TabIndex = 49
        '
        'BmerkungenTextBox
        '
        Me.BmerkungenTextBox.Location = New System.Drawing.Point(111, 356)
        Me.BmerkungenTextBox.Multiline = True
        Me.BmerkungenTextBox.Name = "BmerkungenTextBox"
        Me.BmerkungenTextBox.Size = New System.Drawing.Size(245, 53)
        Me.BmerkungenTextBox.TabIndex = 47
        '
        'lblBemerk
        '
        Me.lblBemerk.AutoSize = True
        Me.lblBemerk.Location = New System.Drawing.Point(108, 412)
        Me.lblBemerk.Name = "lblBemerk"
        Me.lblBemerk.Size = New System.Drawing.Size(104, 13)
        Me.lblBemerk.TabIndex = 24
        Me.lblBemerk.Text = "(Max. 255 Zeichzen)"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(391, 436)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(81, 27)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Zurück"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Nothing
        Me.TableAdapterManager.AktenTableAdapter = Nothing
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        ' Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Me.AnschriftenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
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
        'Anschriften
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 466)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Anschriften"
        Me.Text = "FreeDMS-TAb - Anschriftenliste"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AnschriftenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AnschriftenBindingNavigator.ResumeLayout(False)
        Me.AnschriftenBindingNavigator.PerformLayout()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents LinkLabel1 As LinkLabel
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents BmerkungenTextBox As TextBox
    Friend WithEvents lblBemerk As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AnschriftenBindingNavigator As BindingNavigator
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
    Friend WithEvents AnschriftenBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AnschriftenDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents InternetTextBox As TextBox
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents Name_TextBox As TextBox
    Friend WithEvents ZusatzTextBox As TextBox
    Friend WithEvents OrtTextBox As TextBox
    Friend WithEvents PLZTextBox As TextBox
    Friend WithEvents Anschrift1TextBox As TextBox
    Friend WithEvents Anschrift2TextBox As TextBox
    Friend WithEvents LandTextBox As TextBox
    Friend WithEvents Telefon1TextBox As TextBox
    Friend WithEvents Telefon2TextBox As TextBox
End Class
