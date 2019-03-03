<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ablage
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
        Dim NummerLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim HinweiseLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ablage))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AblageBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
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
        Me.AblageBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.AblageDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbAnzahlZeichen = New System.Windows.Forms.Label()
        Me.NummerTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.HinweiseTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtClose = New System.Windows.Forms.Button()
        Me.AblageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        NummerLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        HinweiseLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AblageBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AblageBindingNavigator.SuspendLayout()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'NummerLabel
        '
        NummerLabel.AutoSize = True
        NummerLabel.Location = New System.Drawing.Point(16, 59)
        NummerLabel.Name = "NummerLabel"
        NummerLabel.Size = New System.Drawing.Size(49, 13)
        NummerLabel.TabIndex = 0
        NummerLabel.Text = "Nummer:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Location = New System.Drawing.Point(16, 85)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(43, 13)
        AblageLabel.TabIndex = 2
        AblageLabel.Text = "Ablage:"
        '
        'HinweiseLabel
        '
        HinweiseLabel.AutoSize = True
        HinweiseLabel.Location = New System.Drawing.Point(16, 111)
        HinweiseLabel.Name = "HinweiseLabel"
        HinweiseLabel.Size = New System.Drawing.Size(53, 13)
        HinweiseLabel.TabIndex = 4
        HinweiseLabel.Text = "Hinweise:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.16053!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.83947!))
        Me.TableLayoutPanel1.Controls.Add(Me.AblageBindingNavigator, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AblageDataGridView, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.29787!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.70213!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(607, 379)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'AblageBindingNavigator
        '
        Me.AblageBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.AblageBindingNavigator.BindingSource = Me.AblageBindingSource
        Me.AblageBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.AblageBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.AblageBindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AblageBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.AblageBindingNavigatorSaveItem})
        Me.AblageBindingNavigator.Location = New System.Drawing.Point(0, 334)
        Me.AblageBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.AblageBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.AblageBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.AblageBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.AblageBindingNavigator.Name = "AblageBindingNavigator"
        Me.AblageBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.AblageBindingNavigator.Size = New System.Drawing.Size(292, 45)
        Me.AblageBindingNavigator.TabIndex = 2
        Me.AblageBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 42)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        Me.AblageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 42)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 42)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 42)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 42)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 45)
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
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 45)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 42)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 42)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 45)
        '
        'AblageBindingNavigatorSaveItem
        '
        Me.AblageBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AblageBindingNavigatorSaveItem.Image = CType(resources.GetObject("AblageBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.AblageBindingNavigatorSaveItem.Name = "AblageBindingNavigatorSaveItem"
        Me.AblageBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 42)
        Me.AblageBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'AblageDataGridView
        '
        Me.AblageDataGridView.AutoGenerateColumns = False
        Me.AblageDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AblageDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.AblageDataGridView.DataSource = Me.AblageBindingSource
        Me.AblageDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AblageDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.AblageDataGridView.Name = "AblageDataGridView"
        Me.AblageDataGridView.Size = New System.Drawing.Size(286, 328)
        Me.AblageDataGridView.TabIndex = 2
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Nummer"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Nummer"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 71
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Ablage"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Ablage"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.lbAnzahlZeichen)
        Me.Panel1.Controls.Add(NummerLabel)
        Me.Panel1.Controls.Add(Me.NummerTextBox)
        Me.Panel1.Controls.Add(AblageLabel)
        Me.Panel1.Controls.Add(Me.AblageTextBox)
        Me.Panel1.Controls.Add(HinweiseLabel)
        Me.Panel1.Controls.Add(Me.HinweiseTextBox)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(295, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(309, 328)
        Me.Panel1.TabIndex = 0
        '
        'lbAnzahlZeichen
        '
        Me.lbAnzahlZeichen.AutoSize = True
        Me.lbAnzahlZeichen.Location = New System.Drawing.Point(72, 176)
        Me.lbAnzahlZeichen.Name = "lbAnzahlZeichen"
        Me.lbAnzahlZeichen.Size = New System.Drawing.Size(73, 13)
        Me.lbAnzahlZeichen.TabIndex = 7
        Me.lbAnzahlZeichen.Text = "(250 Zeichen)"
        '
        'NummerTextBox
        '
        Me.NummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AblageBindingSource, "Nummer", True))
        Me.NummerTextBox.Location = New System.Drawing.Point(75, 56)
        Me.NummerTextBox.Name = "NummerTextBox"
        Me.NummerTextBox.Size = New System.Drawing.Size(35, 20)
        Me.NummerTextBox.TabIndex = 1
        '
        'AblageTextBox
        '
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AblageBindingSource, "Ablage", True))
        Me.AblageTextBox.Location = New System.Drawing.Point(75, 82)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.Size = New System.Drawing.Size(198, 20)
        Me.AblageTextBox.TabIndex = 3
        '
        'HinweiseTextBox
        '
        Me.HinweiseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AblageBindingSource, "Hinweise", True))
        Me.HinweiseTextBox.Location = New System.Drawing.Point(75, 108)
        Me.HinweiseTextBox.Multiline = True
        Me.HinweiseTextBox.Name = "HinweiseTextBox"
        Me.HinweiseTextBox.Size = New System.Drawing.Size(198, 65)
        Me.HinweiseTextBox.TabIndex = 5
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtClose)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(295, 337)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(309, 39)
        Me.Panel2.TabIndex = 1
        '
        'BtClose
        '
        Me.BtClose.Location = New System.Drawing.Point(112, 6)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(75, 23)
        Me.BtClose.TabIndex = 0
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'AblageTableAdapter
        '
        Me.AblageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Me.AblageTableAdapter
        Me.TableAdapterManager.AktenTableAdapter = Nothing
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
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
        'Ablage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(607, 379)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Ablage"
        Me.Text = "FreeDNS-Tab - Ablage"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.AblageBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AblageBindingNavigator.ResumeLayout(False)
        Me.AblageBindingNavigator.PerformLayout()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtClose As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents AblageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AblageTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents AblageBindingNavigator As BindingNavigator
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
    Friend WithEvents AblageBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents AblageDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents lbAnzahlZeichen As Label
    Friend WithEvents NummerTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents HinweiseTextBox As TextBox
End Class
