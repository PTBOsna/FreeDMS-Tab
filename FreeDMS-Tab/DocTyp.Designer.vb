<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DocTyp
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim IdLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim KommentarLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DocTyp))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtSave = New System.Windows.Forms.Button()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.TypBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TypDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.KommentarTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.TypBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IdLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        KommentarLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TypBindingNavigator.SuspendLayout()
        CType(Me.TypDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.TypBindingNavigator, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TypDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 86.99187!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13.00813!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(545, 369)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(IdLabel)
        Me.Panel1.Controls.Add(Me.IdTextBox)
        Me.Panel1.Controls.Add(TypLabel)
        Me.Panel1.Controls.Add(Me.TypTextBox)
        Me.Panel1.Controls.Add(KommentarLabel)
        Me.Panel1.Controls.Add(Me.KommentarTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(275, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(267, 314)
        Me.Panel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(275, 323)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(267, 43)
        Me.Panel2.TabIndex = 1
        '
        'BtSave
        '
        Me.BtSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSave.Location = New System.Drawing.Point(3, 11)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(75, 23)
        Me.BtSave.TabIndex = 0
        Me.BtSave.Text = "Zurück"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TypBindingSource
        '
        Me.TypBindingSource.DataMember = "Typ"
        Me.TypBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'TypTableAdapter
        '
        Me.TypTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Nothing
        Me.TableAdapterManager.AktenTableAdapter = Nothing
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        'Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Nothing
        Me.TableAdapterManager.MandantTableAdapter = Nothing
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Me.TypTableAdapter
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Nothing
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'TypBindingNavigator
        '
        Me.TypBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TypBindingNavigator.BindingSource = Me.TypBindingSource
        Me.TypBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TypBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TypBindingNavigator.Dock = System.Windows.Forms.DockStyle.None
        Me.TypBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TypBindingNavigatorSaveItem})
        Me.TypBindingNavigator.Location = New System.Drawing.Point(0, 320)
        Me.TypBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TypBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TypBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TypBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TypBindingNavigator.Name = "TypBindingNavigator"
        Me.TypBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TypBindingNavigator.Size = New System.Drawing.Size(272, 25)
        Me.TypBindingNavigator.TabIndex = 1
        Me.TypBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TypDataGridView
        '
        Me.TypDataGridView.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.TypDataGridView.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.TypDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TypDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.TypDataGridView.DataSource = Me.TypBindingSource
        Me.TypDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TypDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.TypDataGridView.Name = "TypDataGridView"
        Me.TypDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.TypDataGridView.Size = New System.Drawing.Size(266, 314)
        Me.TypDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Typ"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Dokumententyp"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(21, 36)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TypBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(47, 33)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(31, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Location = New System.Drawing.Point(21, 69)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(85, 13)
        TypLabel.TabIndex = 2
        TypLabel.Text = "Dokumententyp:"
        '
        'TypTextBox
        '
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TypBindingSource, "Typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(24, 85)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.Size = New System.Drawing.Size(195, 20)
        Me.TypTextBox.TabIndex = 3
        '
        'KommentarLabel
        '
        KommentarLabel.AutoSize = True
        KommentarLabel.Location = New System.Drawing.Point(21, 123)
        KommentarLabel.Name = "KommentarLabel"
        KommentarLabel.Size = New System.Drawing.Size(63, 13)
        KommentarLabel.TabIndex = 4
        KommentarLabel.Text = "Kommentar:"
        '
        'KommentarTextBox
        '
        Me.KommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TypBindingSource, "Kommentar", True))
        Me.KommentarTextBox.Location = New System.Drawing.Point(24, 139)
        Me.KommentarTextBox.Multiline = True
        Me.KommentarTextBox.Name = "KommentarTextBox"
        Me.KommentarTextBox.Size = New System.Drawing.Size(195, 67)
        Me.KommentarTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(28, 209)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(93, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Max. 255 Zeichen"
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 20)
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
        'TypBindingNavigatorSaveItem
        '
        Me.TypBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TypBindingNavigatorSaveItem.Image = CType(resources.GetObject("TypBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TypBindingNavigatorSaveItem.Name = "TypBindingNavigatorSaveItem"
        Me.TypBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 20)
        Me.TypBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'DocTyp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(545, 369)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "DocTyp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FreeDMS-Tab - Liste Dokumententyp"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TypBindingNavigator.ResumeLayout(False)
        Me.TypBindingNavigator.PerformLayout()
        CType(Me.TypDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtSave As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents TypTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.TypTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TypBindingNavigator As BindingNavigator
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
    Friend WithEvents TypBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents TypDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents TypTextBox As TextBox
    Friend WithEvents KommentarTextBox As TextBox
End Class
