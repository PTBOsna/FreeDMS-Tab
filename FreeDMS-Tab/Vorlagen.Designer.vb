<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Vorlagen
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
        Dim AutorLabel As System.Windows.Forms.Label
        Dim EmpfaengerLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim KurzbeschreibungLabel As System.Windows.Forms.Label
        Dim SchluesselwortLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Vorlagen))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.VorlagenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter()
        Me.VorlagenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorlagenBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VorlagenBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VorlagenDataGridView = New System.Windows.Forms.DataGridView()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.SchluesselwortTextBox = New System.Windows.Forms.TextBox()
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.AutorTextBox = New System.Windows.Forms.TextBox()
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.KurzbeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.CbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAkte = New System.Windows.Forms.ComboBox()
        Me.MandantAktenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MandantAktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbVorgangNeu = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AktenVorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TxtVorgang = New System.Windows.Forms.TextBox()
        Me.LbAendern = New System.Windows.Forms.Label()
        Me.CbAbsender = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbEmpaenger = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAblage = New System.Windows.Forms.ComboBox()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.lblCount1 = New System.Windows.Forms.Label()
        Me.lblCount2 = New System.Windows.Forms.Label()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        IdLabel = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        AutorLabel = New System.Windows.Forms.Label()
        EmpfaengerLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        KurzbeschreibungLabel = New System.Windows.Forms.Label()
        SchluesselwortLabel = New System.Windows.Forms.Label()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorlagenBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VorlagenBindingNavigator.SuspendLayout()
        CType(Me.VorlagenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantAktenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantAktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenVorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(344, 8)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(21, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Nr:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(344, 123)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(52, 13)
        MandantLabel.TabIndex = 6
        MandantLabel.Text = "Mandant:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(344, 149)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 8
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(344, 175)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 10
        VorgangLabel.Text = "Vorgang:"
        '
        'AutorLabel
        '
        AutorLabel.AutoSize = True
        AutorLabel.Location = New System.Drawing.Point(344, 244)
        AutorLabel.Name = "AutorLabel"
        AutorLabel.Size = New System.Drawing.Size(55, 13)
        AutorLabel.TabIndex = 12
        AutorLabel.Text = "Absender:"
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Location = New System.Drawing.Point(344, 270)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(61, 13)
        EmpfaengerLabel.TabIndex = 14
        EmpfaengerLabel.Text = "Empfänger:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(344, 296)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 16
        AblageLabel.Text = "Ablage:"
        '
        'KurzbeschreibungLabel
        '
        KurzbeschreibungLabel.AutoSize = True
        KurzbeschreibungLabel.Location = New System.Drawing.Point(344, 322)
        KurzbeschreibungLabel.Name = "KurzbeschreibungLabel"
        KurzbeschreibungLabel.Size = New System.Drawing.Size(95, 13)
        KurzbeschreibungLabel.TabIndex = 18
        KurzbeschreibungLabel.Text = "Kurzbeschreibung:"
        '
        'SchluesselwortLabel
        '
        SchluesselwortLabel.AutoSize = True
        SchluesselwortLabel.Location = New System.Drawing.Point(324, 54)
        SchluesselwortLabel.Name = "SchluesselwortLabel"
        SchluesselwortLabel.Size = New System.Drawing.Size(117, 26)
        SchluesselwortLabel.TabIndex = 28
        SchluesselwortLabel.Text = "Schluesselworte" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "durch Komma getrennt:"
        SchluesselwortLabel.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.DokumenteTableAdapter = Nothing
        Me.TableAdapterManager.MandantTableAdapter = Me.MandantTableAdapter
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Me.VorgaengeTableAdapter
        Me.TableAdapterManager.VorlagenTableAdapter = Me.VorlagenTableAdapter
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
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
        'VorlagenBindingSource
        '
        Me.VorlagenBindingSource.DataMember = "Vorlagen"
        Me.VorlagenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'VorlagenBindingNavigator
        '
        Me.VorlagenBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VorlagenBindingNavigator.BindingSource = Me.VorlagenBindingSource
        Me.VorlagenBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VorlagenBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VorlagenBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VorlagenBindingNavigatorSaveItem})
        Me.VorlagenBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VorlagenBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VorlagenBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VorlagenBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VorlagenBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VorlagenBindingNavigator.Name = "VorlagenBindingNavigator"
        Me.VorlagenBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VorlagenBindingNavigator.Size = New System.Drawing.Size(710, 25)
        Me.VorlagenBindingNavigator.TabIndex = 0
        Me.VorlagenBindingNavigator.Text = "BindingNavigator1"
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
        'VorlagenBindingNavigatorSaveItem
        '
        Me.VorlagenBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VorlagenBindingNavigatorSaveItem.Image = CType(resources.GetObject("VorlagenBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VorlagenBindingNavigatorSaveItem.Name = "VorlagenBindingNavigatorSaveItem"
        Me.VorlagenBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.VorlagenBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'VorlagenDataGridView
        '
        Me.VorlagenDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.VorlagenDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.VorlagenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.VorlagenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn2})
        Me.VorlagenDataGridView.DataSource = Me.VorlagenBindingSource
        Me.VorlagenDataGridView.Location = New System.Drawing.Point(12, 40)
        Me.VorlagenDataGridView.Name = "VorlagenDataGridView"
        Me.VorlagenDataGridView.Size = New System.Drawing.Size(300, 321)
        Me.VorlagenDataGridView.TabIndex = 1
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(444, 5)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(43, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'SchluesselwortTextBox
        '
        Me.SchluesselwortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "schluesselwort", True))
        Me.SchluesselwortTextBox.Location = New System.Drawing.Point(444, 54)
        Me.SchluesselwortTextBox.Multiline = True
        Me.SchluesselwortTextBox.Name = "SchluesselwortTextBox"
        Me.SchluesselwortTextBox.Size = New System.Drawing.Size(172, 44)
        Me.SchluesselwortTextBox.TabIndex = 5
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(583, 120)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.Size = New System.Drawing.Size(33, 20)
        Me.MandantTextBox.TabIndex = 7
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(583, 146)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(33, 20)
        Me.AkteTextBox.TabIndex = 9
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(583, 172)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(33, 20)
        Me.VorgangTextBox.TabIndex = 11
        '
        'AutorTextBox
        '
        Me.AutorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "autor", True))
        Me.AutorTextBox.Location = New System.Drawing.Point(583, 241)
        Me.AutorTextBox.Name = "AutorTextBox"
        Me.AutorTextBox.Size = New System.Drawing.Size(36, 20)
        Me.AutorTextBox.TabIndex = 13
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "empfaenger", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(583, 267)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(36, 20)
        Me.EmpfaengerTextBox.TabIndex = 15
        '
        'AblageTextBox
        '
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "ablage", True))
        Me.AblageTextBox.Location = New System.Drawing.Point(583, 293)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.Size = New System.Drawing.Size(36, 20)
        Me.AblageTextBox.TabIndex = 17
        '
        'KurzbeschreibungTextBox
        '
        Me.KurzbeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorlagenBindingSource, "kurzbeschreibung", True))
        Me.KurzbeschreibungTextBox.Location = New System.Drawing.Point(444, 319)
        Me.KurzbeschreibungTextBox.Multiline = True
        Me.KurzbeschreibungTextBox.Name = "KurzbeschreibungTextBox"
        Me.KurzbeschreibungTextBox.Size = New System.Drawing.Size(175, 48)
        Me.KurzbeschreibungTextBox.TabIndex = 19
        '
        'CbMandant
        '
        Me.CbMandant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VorlagenBindingSource, "Mandant", True))
        Me.CbMandant.DataSource = Me.MandantBindingSource
        Me.CbMandant.DisplayMember = "Mandant"
        Me.CbMandant.FormattingEnabled = True
        Me.CbMandant.Location = New System.Drawing.Point(444, 120)
        Me.CbMandant.Name = "CbMandant"
        Me.CbMandant.Size = New System.Drawing.Size(121, 21)
        Me.CbMandant.TabIndex = 20
        Me.CbMandant.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAkte
        '
        Me.CbAkte.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VorlagenBindingSource, "akte", True))
        Me.CbAkte.DataSource = Me.MandantAktenBindingSource1
        Me.CbAkte.DisplayMember = "Akte"
        Me.CbAkte.FormattingEnabled = True
        Me.CbAkte.Location = New System.Drawing.Point(444, 146)
        Me.CbAkte.Name = "CbAkte"
        Me.CbAkte.Size = New System.Drawing.Size(121, 21)
        Me.CbAkte.TabIndex = 21
        Me.CbAkte.ValueMember = "id"
        '
        'MandantAktenBindingSource1
        '
        Me.MandantAktenBindingSource1.DataMember = "Mandant_Akten"
        Me.MandantAktenBindingSource1.DataSource = Me.MandantBindingSource
        '
        'MandantAktenBindingSource
        '
        Me.MandantAktenBindingSource.DataMember = "Mandant_Akten"
        Me.MandantAktenBindingSource.DataSource = Me.MandantBindingSource
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbVorgangNeu
        '
        Me.CbVorgangNeu.DataSource = Me.VorgaengeBindingSource1
        Me.CbVorgangNeu.DisplayMember = "Vorgang"
        Me.CbVorgangNeu.FormattingEnabled = True
        Me.CbVorgangNeu.Location = New System.Drawing.Point(444, 198)
        Me.CbVorgangNeu.Name = "CbVorgangNeu"
        Me.CbVorgangNeu.Size = New System.Drawing.Size(121, 21)
        Me.CbVorgangNeu.TabIndex = 22
        Me.CbVorgangNeu.ValueMember = "id"
        '
        'VorgaengeBindingSource1
        '
        Me.VorgaengeBindingSource1.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AktenVorgaengeBindingSource
        '
        Me.AktenVorgaengeBindingSource.DataMember = "Akten_Vorgaenge"
        Me.AktenVorgaengeBindingSource.DataSource = Me.AktenBindingSource
        '
        'TxtVorgang
        '
        Me.TxtVorgang.Location = New System.Drawing.Point(444, 172)
        Me.TxtVorgang.Name = "TxtVorgang"
        Me.TxtVorgang.Size = New System.Drawing.Size(121, 20)
        Me.TxtVorgang.TabIndex = 23
        '
        'LbAendern
        '
        Me.LbAendern.AutoSize = True
        Me.LbAendern.Location = New System.Drawing.Point(344, 201)
        Me.LbAendern.Name = "LbAendern"
        Me.LbAendern.Size = New System.Drawing.Size(97, 13)
        Me.LbAendern.TabIndex = 24
        Me.LbAendern.Text = "Vorgang ändern in:"
        '
        'CbAbsender
        '
        Me.CbAbsender.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VorlagenBindingSource, "autor", True))
        Me.CbAbsender.DataSource = Me.AnschriftenBindingSource
        Me.CbAbsender.DisplayMember = "Name_"
        Me.CbAbsender.FormattingEnabled = True
        Me.CbAbsender.Location = New System.Drawing.Point(444, 241)
        Me.CbAbsender.Name = "CbAbsender"
        Me.CbAbsender.Size = New System.Drawing.Size(121, 21)
        Me.CbAbsender.TabIndex = 25
        Me.CbAbsender.ValueMember = "id"
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbEmpaenger
        '
        Me.CbEmpaenger.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VorlagenBindingSource, "empfaenger", True))
        Me.CbEmpaenger.DataSource = Me.AnschriftenBindingSource1
        Me.CbEmpaenger.DisplayMember = "Name_"
        Me.CbEmpaenger.FormattingEnabled = True
        Me.CbEmpaenger.Location = New System.Drawing.Point(444, 267)
        Me.CbEmpaenger.Name = "CbEmpaenger"
        Me.CbEmpaenger.Size = New System.Drawing.Size(121, 21)
        Me.CbEmpaenger.TabIndex = 26
        Me.CbEmpaenger.ValueMember = "id"
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        Me.AnschriftenBindingSource1.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAblage
        '
        Me.CbAblage.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.VorlagenBindingSource, "ablage", True))
        Me.CbAblage.DataSource = Me.AblageBindingSource
        Me.CbAblage.DisplayMember = "Ablage"
        Me.CbAblage.FormattingEnabled = True
        Me.CbAblage.Location = New System.Drawing.Point(444, 292)
        Me.CbAblage.Name = "CbAblage"
        Me.CbAblage.Size = New System.Drawing.Size(121, 21)
        Me.CbAblage.TabIndex = 27
        Me.CbAblage.ValueMember = "Nummer"
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'lblCount1
        '
        Me.lblCount1.AutoSize = True
        Me.lblCount1.Location = New System.Drawing.Point(441, 101)
        Me.lblCount1.Name = "lblCount1"
        Me.lblCount1.Size = New System.Drawing.Size(99, 13)
        Me.lblCount1.TabIndex = 29
        Me.lblCount1.Text = "(Max. 250 Zeichen)"
        '
        'lblCount2
        '
        Me.lblCount2.AutoSize = True
        Me.lblCount2.Location = New System.Drawing.Point(441, 370)
        Me.lblCount2.Name = "lblCount2"
        Me.lblCount2.Size = New System.Drawing.Size(99, 13)
        Me.lblCount2.TabIndex = 31
        Me.lblCount2.Text = "(Max. 250 Zeichen)"
        '
        'BtClose
        '
        Me.BtClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtClose.Location = New System.Drawing.Point(256, 410)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(165, 28)
        Me.BtClose.TabIndex = 32
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "vorgang"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Vorgang"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 79
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "schluesselwort"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Schlüsselwort(e)"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Vorlagen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(710, 450)
        Me.Controls.Add(Me.BtClose)
        Me.Controls.Add(Me.lblCount2)
        Me.Controls.Add(Me.lblCount1)
        Me.Controls.Add(SchluesselwortLabel)
        Me.Controls.Add(Me.CbAblage)
        Me.Controls.Add(Me.CbEmpaenger)
        Me.Controls.Add(Me.CbAbsender)
        Me.Controls.Add(Me.LbAendern)
        Me.Controls.Add(Me.TxtVorgang)
        Me.Controls.Add(Me.CbVorgangNeu)
        Me.Controls.Add(Me.CbAkte)
        Me.Controls.Add(Me.CbMandant)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Me.SchluesselwortTextBox)
        Me.Controls.Add(MandantLabel)
        Me.Controls.Add(Me.MandantTextBox)
        Me.Controls.Add(AkteLabel)
        Me.Controls.Add(Me.AkteTextBox)
        Me.Controls.Add(VorgangLabel)
        Me.Controls.Add(Me.VorgangTextBox)
        Me.Controls.Add(AutorLabel)
        Me.Controls.Add(Me.AutorTextBox)
        Me.Controls.Add(EmpfaengerLabel)
        Me.Controls.Add(Me.EmpfaengerTextBox)
        Me.Controls.Add(AblageLabel)
        Me.Controls.Add(Me.AblageTextBox)
        Me.Controls.Add(KurzbeschreibungLabel)
        Me.Controls.Add(Me.KurzbeschreibungTextBox)
        Me.Controls.Add(Me.VorlagenDataGridView)
        Me.Controls.Add(Me.VorlagenBindingNavigator)
        Me.Name = "Vorlagen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FreeDMS-Tab - Vorlagen"
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorlagenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorlagenBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VorlagenBindingNavigator.ResumeLayout(False)
        Me.VorlagenBindingNavigator.PerformLayout()
        CType(Me.VorlagenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantAktenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantAktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenVorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents VorlagenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorlagenTableAdapter
    Friend WithEvents VorlagenBindingSource As BindingSource
    Friend WithEvents VorlagenBindingNavigator As BindingNavigator
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
    Friend WithEvents VorlagenBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VorlagenDataGridView As DataGridView
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents SchluesselwortTextBox As TextBox
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents AutorTextBox As TextBox
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents KurzbeschreibungTextBox As TextBox
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents CbMandant As ComboBox
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents CbAkte As ComboBox
    Friend WithEvents MandantAktenBindingSource As BindingSource
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents MandantAktenBindingSource1 As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents CbVorgangNeu As ComboBox
    Friend WithEvents AktenVorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents TxtVorgang As TextBox
    Friend WithEvents VorgaengeBindingSource1 As BindingSource
    Friend WithEvents LbAendern As Label
    Friend WithEvents CbAbsender As ComboBox
    Friend WithEvents CbEmpaenger As ComboBox
    Friend WithEvents CbAblage As ComboBox
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents lblCount1 As Label
    Friend WithEvents lblCount2 As Label
    Friend WithEvents BtClose As Button
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
End Class
