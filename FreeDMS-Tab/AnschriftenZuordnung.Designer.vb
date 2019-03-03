<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AnschriftenZuordnung
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
        Dim Name_Label As System.Windows.Forms.Label
        Dim ZusatzLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim Anschrift1Label As System.Windows.Forms.Label
        Dim Anschrift2Label As System.Windows.Forms.Label
        Dim LandLabel As System.Windows.Forms.Label
        Dim Telefon1Label As System.Windows.Forms.Label
        Dim Telefon2Label As System.Windows.Forms.Label
        Dim MailLabel As System.Windows.Forms.Label
        Dim InternetLabel As System.Windows.Forms.Label
        Dim BmerkungenLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.DokumenteDataGridView = New System.Windows.Forms.DataGridView()
        Me.AnschriftenDataGridView = New System.Windows.Forms.DataGridView()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.btSave = New System.Windows.Forms.Button()
        Me.btEsc = New System.Windows.Forms.Button()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ZusatzDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OrtDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PLZDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anschrift1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Anschrift2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon1DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefon2DataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.InternetDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BmerkungenDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
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
        Me.MailTextBox = New System.Windows.Forms.TextBox()
        Me.InternetTextBox = New System.Windows.Forms.TextBox()
        Me.BmerkungenTextBox = New System.Windows.Forms.TextBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.AnschriftenDokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DokumentDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BetreffDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Absender = New System.Windows.Forms.DataGridViewComboBoxColumn()
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
        MailLabel = New System.Windows.Forms.Label()
        InternetLabel = New System.Windows.Forms.Label()
        BmerkungenLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenDokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 4
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 47.31544!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 52.68456!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 388.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 371.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.DokumenteDataGridView, 1, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.AnschriftenDataGridView, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 3, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.DokNameTextBox, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.btSave, 3, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.btEsc, 0, 2)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.550186!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 91.44981!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1408, 616)
        Me.TableLayoutPanel1.TabIndex = 2
        '
        'DokumenteDataGridView
        '
        Me.DokumenteDataGridView.AllowUserToAddRows = False
        Me.DokumenteDataGridView.AllowUserToDeleteRows = False
        Me.DokumenteDataGridView.AutoGenerateColumns = False
        Me.DokumenteDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DokumenteDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn1, Me.DokumentDataGridViewTextBoxColumn, Me.BetreffDataGridViewTextBoxColumn, Me.Absender})
        Me.DokumenteDataGridView.DataSource = Me.DokumenteBindingSource
        Me.DokumenteDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DokumenteDataGridView.Location = New System.Drawing.Point(310, 51)
        Me.DokumenteDataGridView.Name = "DokumenteDataGridView"
        Me.DokumenteDataGridView.ReadOnly = True
        Me.DokumenteDataGridView.RowHeadersVisible = False
        Me.DokumenteDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DokumenteDataGridView.Size = New System.Drawing.Size(335, 516)
        Me.DokumenteDataGridView.TabIndex = 1
        '
        'AnschriftenDataGridView
        '
        Me.AnschriftenDataGridView.AllowUserToAddRows = False
        Me.AnschriftenDataGridView.AllowUserToDeleteRows = False
        Me.AnschriftenDataGridView.AutoGenerateColumns = False
        Me.AnschriftenDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AnschriftenDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.ZusatzDataGridViewTextBoxColumn, Me.OrtDataGridViewTextBoxColumn, Me.PLZDataGridViewTextBoxColumn, Me.Anschrift1DataGridViewTextBoxColumn, Me.Anschrift2DataGridViewTextBoxColumn, Me.LandDataGridViewTextBoxColumn, Me.Telefon1DataGridViewTextBoxColumn, Me.Telefon2DataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn, Me.InternetDataGridViewTextBoxColumn, Me.BmerkungenDataGridViewTextBoxColumn})
        Me.AnschriftenDataGridView.DataSource = Me.AnschriftenBindingSource
        Me.AnschriftenDataGridView.Dock = System.Windows.Forms.DockStyle.Fill
        Me.AnschriftenDataGridView.Location = New System.Drawing.Point(3, 51)
        Me.AnschriftenDataGridView.Name = "AnschriftenDataGridView"
        Me.AnschriftenDataGridView.ReadOnly = True
        Me.AnschriftenDataGridView.RowHeadersVisible = False
        Me.AnschriftenDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.AnschriftenDataGridView.Size = New System.Drawing.Size(301, 516)
        Me.AnschriftenDataGridView.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.TabControl1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(651, 51)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(382, 516)
        Me.Panel1.TabIndex = 2
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(382, 516)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TabPage1.Controls.Add(Me.WebBrowser1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(374, 490)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Dokument"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebBrowser1.Location = New System.Drawing.Point(3, 3)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(366, 482)
        Me.WebBrowser1.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(374, 490)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Inhalt OCR"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Location = New System.Drawing.Point(3, 3)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(368, 484)
        Me.RichTextBox1.TabIndex = 0
        Me.RichTextBox1.Text = ""
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.PictureBox1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(374, 490)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Bild"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(IdLabel)
        Me.Panel2.Controls.Add(Me.IdTextBox)
        Me.Panel2.Controls.Add(Name_Label)
        Me.Panel2.Controls.Add(Me.Name_TextBox)
        Me.Panel2.Controls.Add(ZusatzLabel)
        Me.Panel2.Controls.Add(Me.ZusatzTextBox)
        Me.Panel2.Controls.Add(OrtLabel)
        Me.Panel2.Controls.Add(Me.OrtTextBox)
        Me.Panel2.Controls.Add(PLZLabel)
        Me.Panel2.Controls.Add(Me.PLZTextBox)
        Me.Panel2.Controls.Add(Anschrift1Label)
        Me.Panel2.Controls.Add(Me.Anschrift1TextBox)
        Me.Panel2.Controls.Add(Anschrift2Label)
        Me.Panel2.Controls.Add(Me.Anschrift2TextBox)
        Me.Panel2.Controls.Add(LandLabel)
        Me.Panel2.Controls.Add(Me.LandTextBox)
        Me.Panel2.Controls.Add(Telefon1Label)
        Me.Panel2.Controls.Add(Me.Telefon1TextBox)
        Me.Panel2.Controls.Add(Telefon2Label)
        Me.Panel2.Controls.Add(Me.Telefon2TextBox)
        Me.Panel2.Controls.Add(MailLabel)
        Me.Panel2.Controls.Add(Me.MailTextBox)
        Me.Panel2.Controls.Add(InternetLabel)
        Me.Panel2.Controls.Add(Me.InternetTextBox)
        Me.Panel2.Controls.Add(BmerkungenLabel)
        Me.Panel2.Controls.Add(Me.BmerkungenTextBox)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(1039, 51)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(366, 516)
        Me.Panel2.TabIndex = 3
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(651, 3)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.ReadOnly = True
        Me.DokNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokNameTextBox.TabIndex = 5
        '
        'btSave
        '
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Location = New System.Drawing.Point(1039, 573)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(178, 40)
        Me.btSave.TabIndex = 15
        Me.btSave.Text = "Speichern und zurück"
        Me.btSave.UseVisualStyleBackColor = True
        '
        'btEsc
        '
        Me.btEsc.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btEsc.Location = New System.Drawing.Point(3, 573)
        Me.btEsc.Name = "btEsc"
        Me.btEsc.Size = New System.Drawing.Size(145, 40)
        Me.btEsc.TabIndex = 7
        Me.btEsc.Text = "Zurück"
        Me.btEsc.UseVisualStyleBackColor = True
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
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
        'Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Me.AnschriftenTableAdapter
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Nothing
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Nothing
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Nothing
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        Me.IdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name_"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name_"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ZusatzDataGridViewTextBoxColumn
        '
        Me.ZusatzDataGridViewTextBoxColumn.DataPropertyName = "Zusatz"
        Me.ZusatzDataGridViewTextBoxColumn.HeaderText = "Zusatz"
        Me.ZusatzDataGridViewTextBoxColumn.Name = "ZusatzDataGridViewTextBoxColumn"
        Me.ZusatzDataGridViewTextBoxColumn.ReadOnly = True
        '
        'OrtDataGridViewTextBoxColumn
        '
        Me.OrtDataGridViewTextBoxColumn.DataPropertyName = "Ort"
        Me.OrtDataGridViewTextBoxColumn.HeaderText = "Ort"
        Me.OrtDataGridViewTextBoxColumn.Name = "OrtDataGridViewTextBoxColumn"
        Me.OrtDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PLZDataGridViewTextBoxColumn
        '
        Me.PLZDataGridViewTextBoxColumn.DataPropertyName = "PLZ"
        Me.PLZDataGridViewTextBoxColumn.HeaderText = "PLZ"
        Me.PLZDataGridViewTextBoxColumn.Name = "PLZDataGridViewTextBoxColumn"
        Me.PLZDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Anschrift1DataGridViewTextBoxColumn
        '
        Me.Anschrift1DataGridViewTextBoxColumn.DataPropertyName = "Anschrift1"
        Me.Anschrift1DataGridViewTextBoxColumn.HeaderText = "Anschrift1"
        Me.Anschrift1DataGridViewTextBoxColumn.Name = "Anschrift1DataGridViewTextBoxColumn"
        Me.Anschrift1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Anschrift2DataGridViewTextBoxColumn
        '
        Me.Anschrift2DataGridViewTextBoxColumn.DataPropertyName = "Anschrift2"
        Me.Anschrift2DataGridViewTextBoxColumn.HeaderText = "Anschrift2"
        Me.Anschrift2DataGridViewTextBoxColumn.Name = "Anschrift2DataGridViewTextBoxColumn"
        Me.Anschrift2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'LandDataGridViewTextBoxColumn
        '
        Me.LandDataGridViewTextBoxColumn.DataPropertyName = "Land"
        Me.LandDataGridViewTextBoxColumn.HeaderText = "Land"
        Me.LandDataGridViewTextBoxColumn.Name = "LandDataGridViewTextBoxColumn"
        Me.LandDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Telefon1DataGridViewTextBoxColumn
        '
        Me.Telefon1DataGridViewTextBoxColumn.DataPropertyName = "Telefon1"
        Me.Telefon1DataGridViewTextBoxColumn.HeaderText = "Telefon1"
        Me.Telefon1DataGridViewTextBoxColumn.Name = "Telefon1DataGridViewTextBoxColumn"
        Me.Telefon1DataGridViewTextBoxColumn.ReadOnly = True
        '
        'Telefon2DataGridViewTextBoxColumn
        '
        Me.Telefon2DataGridViewTextBoxColumn.DataPropertyName = "Telefon2"
        Me.Telefon2DataGridViewTextBoxColumn.HeaderText = "Telefon2"
        Me.Telefon2DataGridViewTextBoxColumn.Name = "Telefon2DataGridViewTextBoxColumn"
        Me.Telefon2DataGridViewTextBoxColumn.ReadOnly = True
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "Mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "Mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        Me.MailDataGridViewTextBoxColumn.ReadOnly = True
        '
        'InternetDataGridViewTextBoxColumn
        '
        Me.InternetDataGridViewTextBoxColumn.DataPropertyName = "Internet"
        Me.InternetDataGridViewTextBoxColumn.HeaderText = "Internet"
        Me.InternetDataGridViewTextBoxColumn.Name = "InternetDataGridViewTextBoxColumn"
        Me.InternetDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BmerkungenDataGridViewTextBoxColumn
        '
        Me.BmerkungenDataGridViewTextBoxColumn.DataPropertyName = "Bmerkungen"
        Me.BmerkungenDataGridViewTextBoxColumn.HeaderText = "Bmerkungen"
        Me.BmerkungenDataGridViewTextBoxColumn.Name = "BmerkungenDataGridViewTextBoxColumn"
        Me.BmerkungenDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(368, 484)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(49, 77)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 0
        IdLabel.Text = "Nr.:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(125, 74)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(34, 20)
        Me.IdTextBox.TabIndex = 1
        '
        'Name_Label
        '
        Name_Label.AutoSize = True
        Name_Label.Location = New System.Drawing.Point(49, 103)
        Name_Label.Name = "Name_Label"
        Name_Label.Size = New System.Drawing.Size(41, 13)
        Name_Label.TabIndex = 2
        Name_Label.Text = "Name :"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Name_", True))
        Me.Name_TextBox.Location = New System.Drawing.Point(125, 100)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(165, 20)
        Me.Name_TextBox.TabIndex = 3
        '
        'ZusatzLabel
        '
        ZusatzLabel.AutoSize = True
        ZusatzLabel.Location = New System.Drawing.Point(49, 129)
        ZusatzLabel.Name = "ZusatzLabel"
        ZusatzLabel.Size = New System.Drawing.Size(42, 13)
        ZusatzLabel.TabIndex = 4
        ZusatzLabel.Text = "Zusatz:"
        '
        'ZusatzTextBox
        '
        Me.ZusatzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Zusatz", True))
        Me.ZusatzTextBox.Location = New System.Drawing.Point(125, 126)
        Me.ZusatzTextBox.Name = "ZusatzTextBox"
        Me.ZusatzTextBox.Size = New System.Drawing.Size(165, 20)
        Me.ZusatzTextBox.TabIndex = 5
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(49, 155)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 6
        OrtLabel.Text = "Ort:"
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(125, 152)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(165, 20)
        Me.OrtTextBox.TabIndex = 7
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(49, 181)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 8
        PLZLabel.Text = "PLZ:"
        '
        'PLZTextBox
        '
        Me.PLZTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "PLZ", True))
        Me.PLZTextBox.Location = New System.Drawing.Point(125, 178)
        Me.PLZTextBox.Name = "PLZTextBox"
        Me.PLZTextBox.Size = New System.Drawing.Size(165, 20)
        Me.PLZTextBox.TabIndex = 9
        '
        'Anschrift1Label
        '
        Anschrift1Label.AutoSize = True
        Anschrift1Label.Location = New System.Drawing.Point(49, 207)
        Anschrift1Label.Name = "Anschrift1Label"
        Anschrift1Label.Size = New System.Drawing.Size(57, 13)
        Anschrift1Label.TabIndex = 10
        Anschrift1Label.Text = "Anschrift1:"
        '
        'Anschrift1TextBox
        '
        Me.Anschrift1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Anschrift1", True))
        Me.Anschrift1TextBox.Location = New System.Drawing.Point(125, 204)
        Me.Anschrift1TextBox.Name = "Anschrift1TextBox"
        Me.Anschrift1TextBox.Size = New System.Drawing.Size(165, 20)
        Me.Anschrift1TextBox.TabIndex = 11
        '
        'Anschrift2Label
        '
        Anschrift2Label.AutoSize = True
        Anschrift2Label.Location = New System.Drawing.Point(49, 233)
        Anschrift2Label.Name = "Anschrift2Label"
        Anschrift2Label.Size = New System.Drawing.Size(57, 13)
        Anschrift2Label.TabIndex = 12
        Anschrift2Label.Text = "Anschrift2:"
        '
        'Anschrift2TextBox
        '
        Me.Anschrift2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Anschrift2", True))
        Me.Anschrift2TextBox.Location = New System.Drawing.Point(125, 230)
        Me.Anschrift2TextBox.Name = "Anschrift2TextBox"
        Me.Anschrift2TextBox.Size = New System.Drawing.Size(165, 20)
        Me.Anschrift2TextBox.TabIndex = 13
        '
        'LandLabel
        '
        LandLabel.AutoSize = True
        LandLabel.Location = New System.Drawing.Point(49, 259)
        LandLabel.Name = "LandLabel"
        LandLabel.Size = New System.Drawing.Size(34, 13)
        LandLabel.TabIndex = 14
        LandLabel.Text = "Land:"
        '
        'LandTextBox
        '
        Me.LandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Land", True))
        Me.LandTextBox.Location = New System.Drawing.Point(125, 256)
        Me.LandTextBox.Name = "LandTextBox"
        Me.LandTextBox.Size = New System.Drawing.Size(165, 20)
        Me.LandTextBox.TabIndex = 15
        '
        'Telefon1Label
        '
        Telefon1Label.AutoSize = True
        Telefon1Label.Location = New System.Drawing.Point(49, 285)
        Telefon1Label.Name = "Telefon1Label"
        Telefon1Label.Size = New System.Drawing.Size(52, 13)
        Telefon1Label.TabIndex = 16
        Telefon1Label.Text = "Telefon1:"
        '
        'Telefon1TextBox
        '
        Me.Telefon1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Telefon1", True))
        Me.Telefon1TextBox.Location = New System.Drawing.Point(125, 282)
        Me.Telefon1TextBox.Name = "Telefon1TextBox"
        Me.Telefon1TextBox.Size = New System.Drawing.Size(165, 20)
        Me.Telefon1TextBox.TabIndex = 17
        '
        'Telefon2Label
        '
        Telefon2Label.AutoSize = True
        Telefon2Label.Location = New System.Drawing.Point(49, 311)
        Telefon2Label.Name = "Telefon2Label"
        Telefon2Label.Size = New System.Drawing.Size(52, 13)
        Telefon2Label.TabIndex = 18
        Telefon2Label.Text = "Telefon2:"
        '
        'Telefon2TextBox
        '
        Me.Telefon2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Telefon2", True))
        Me.Telefon2TextBox.Location = New System.Drawing.Point(125, 308)
        Me.Telefon2TextBox.Name = "Telefon2TextBox"
        Me.Telefon2TextBox.Size = New System.Drawing.Size(165, 20)
        Me.Telefon2TextBox.TabIndex = 19
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(49, 337)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 20
        MailLabel.Text = "Mail:"
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(125, 334)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(165, 20)
        Me.MailTextBox.TabIndex = 21
        '
        'InternetLabel
        '
        InternetLabel.AutoSize = True
        InternetLabel.Location = New System.Drawing.Point(49, 363)
        InternetLabel.Name = "InternetLabel"
        InternetLabel.Size = New System.Drawing.Size(46, 13)
        InternetLabel.TabIndex = 22
        InternetLabel.Text = "Internet:"
        '
        'InternetTextBox
        '
        Me.InternetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Internet", True))
        Me.InternetTextBox.Location = New System.Drawing.Point(125, 360)
        Me.InternetTextBox.Name = "InternetTextBox"
        Me.InternetTextBox.Size = New System.Drawing.Size(165, 20)
        Me.InternetTextBox.TabIndex = 23
        '
        'BmerkungenLabel
        '
        BmerkungenLabel.AutoSize = True
        BmerkungenLabel.Location = New System.Drawing.Point(49, 389)
        BmerkungenLabel.Name = "BmerkungenLabel"
        BmerkungenLabel.Size = New System.Drawing.Size(70, 13)
        BmerkungenLabel.TabIndex = 24
        BmerkungenLabel.Text = "Bmerkungen:"
        '
        'BmerkungenTextBox
        '
        Me.BmerkungenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Bmerkungen", True))
        Me.BmerkungenTextBox.Location = New System.Drawing.Point(125, 386)
        Me.BmerkungenTextBox.Name = "BmerkungenTextBox"
        Me.BmerkungenTextBox.Size = New System.Drawing.Size(165, 20)
        Me.BmerkungenTextBox.TabIndex = 25
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
        'AnschriftenDokumenteBindingSource
        '
        Me.AnschriftenDokumenteBindingSource.DataMember = "Anschriften_Dokumente"
        Me.AnschriftenDokumenteBindingSource.DataSource = Me.AnschriftenBindingSource
        '
        'IdDataGridViewTextBoxColumn1
        '
        Me.IdDataGridViewTextBoxColumn1.DataPropertyName = "id"
        Me.IdDataGridViewTextBoxColumn1.HeaderText = "id"
        Me.IdDataGridViewTextBoxColumn1.Name = "IdDataGridViewTextBoxColumn1"
        Me.IdDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IdDataGridViewTextBoxColumn1.Visible = False
        '
        'DokumentDataGridViewTextBoxColumn
        '
        Me.DokumentDataGridViewTextBoxColumn.DataPropertyName = "Dokument"
        Me.DokumentDataGridViewTextBoxColumn.HeaderText = "Dokument"
        Me.DokumentDataGridViewTextBoxColumn.Name = "DokumentDataGridViewTextBoxColumn"
        Me.DokumentDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BetreffDataGridViewTextBoxColumn
        '
        Me.BetreffDataGridViewTextBoxColumn.DataPropertyName = "Betreff"
        Me.BetreffDataGridViewTextBoxColumn.HeaderText = "Betreff"
        Me.BetreffDataGridViewTextBoxColumn.Name = "BetreffDataGridViewTextBoxColumn"
        Me.BetreffDataGridViewTextBoxColumn.ReadOnly = True
        '
        'Absender
        '
        Me.Absender.DataPropertyName = "Absender"
        Me.Absender.DataSource = Me.AnschriftenBindingSource
        Me.Absender.DisplayMember = "Name_"
        Me.Absender.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Absender.HeaderText = "Absender"
        Me.Absender.Name = "Absender"
        Me.Absender.ReadOnly = True
        Me.Absender.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Absender.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Absender.ValueMember = "id"
        '
        'AnschriftenZuordnung
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1408, 616)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "AnschriftenZuordnung"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FreeDMS-Tab - Anschriften - Zuordnung"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.DokumenteDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage3.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenDokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents DokumenteDataGridView As DataGridView
    Friend WithEvents AnschriftenDataGridView As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents btSave As Button
    Friend WithEvents btEsc As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ZusatzDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OrtDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PLZDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Anschrift1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Anschrift2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents LandDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefon1DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Telefon2DataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents InternetDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BmerkungenDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents MailTextBox As TextBox
    Friend WithEvents InternetTextBox As TextBox
    Friend WithEvents BmerkungenTextBox As TextBox
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents IdDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DokumentDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents BetreffDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Absender As DataGridViewComboBoxColumn
    Friend WithEvents AnschriftenDokumenteBindingSource As BindingSource
End Class
