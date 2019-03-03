<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotizNeu
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
        Dim ErstelltLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim ErstelltLabel1 As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ErstelltTextBox = New System.Windows.Forms.TextBox()
        Me.NotizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.CbVorgaenge = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErstelltDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.CbDokumente = New System.Windows.Forms.ComboBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAkten = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.NotizTextBox = New System.Windows.Forms.TextBox()
        Me.TitelTextBox = New System.Windows.Forms.TextBox()
        Me.NotizTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.AktenVorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet1 = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.SqlVorgangAkteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SqlVorgangAkteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.sqlVorgangAkteTableAdapter()
        ErstelltLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        ErstelltLabel1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.AktenVorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SqlVorgangAkteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ErstelltLabel
        '
        ErstelltLabel.AutoSize = True
        ErstelltLabel.Location = New System.Drawing.Point(37, 9)
        ErstelltLabel.Name = "ErstelltLabel"
        ErstelltLabel.Size = New System.Drawing.Size(41, 13)
        ErstelltLabel.TabIndex = 8
        ErstelltLabel.Text = "Erstellt:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(18, 85)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 6
        DokumentLabel.Text = "Dokument:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(27, 59)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 4
        VorgangLabel.Text = "Vorgang:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(45, 32)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 2
        AkteLabel.Text = "Akte:"
        '
        'ErstelltLabel1
        '
        ErstelltLabel1.AutoSize = True
        ErstelltLabel1.Location = New System.Drawing.Point(263, 9)
        ErstelltLabel1.Name = "ErstelltLabel1"
        ErstelltLabel1.Size = New System.Drawing.Size(40, 13)
        ErstelltLabel1.TabIndex = 16
        ErstelltLabel1.Text = "erstellt:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 88.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 26.6055!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 73.39449!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(469, 479)
        Me.TableLayoutPanel1.TabIndex = 21
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(ErstelltLabel1)
        Me.Panel1.Controls.Add(Me.ErstelltTextBox)
        Me.Panel1.Controls.Add(Me.CbVorgaenge)
        Me.Panel1.Controls.Add(Me.ErstelltDateTimePicker)
        Me.Panel1.Controls.Add(ErstelltLabel)
        Me.Panel1.Controls.Add(Me.CbDokumente)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(VorgangLabel)
        Me.Panel1.Controls.Add(Me.CbAkten)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(463, 109)
        Me.Panel1.TabIndex = 19
        '
        'ErstelltTextBox
        '
        Me.ErstelltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "erstellt", True))
        Me.ErstelltTextBox.Location = New System.Drawing.Point(309, 6)
        Me.ErstelltTextBox.Name = "ErstelltTextBox"
        Me.ErstelltTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErstelltTextBox.TabIndex = 17
        '
        'NotizBindingSource
        '
        Me.NotizBindingSource.DataMember = "notiz"
        Me.NotizBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CbVorgaenge
        '
        Me.CbVorgaenge.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "vorgang", True))
        Me.CbVorgaenge.DataSource = Me.SqlVorgangAkteBindingSource
        Me.CbVorgaenge.DisplayMember = "Anzeige"
        Me.CbVorgaenge.FormattingEnabled = True
        Me.CbVorgaenge.Location = New System.Drawing.Point(83, 56)
        Me.CbVorgaenge.Name = "CbVorgaenge"
        Me.CbVorgaenge.Size = New System.Drawing.Size(346, 21)
        Me.CbVorgaenge.TabIndex = 15
        Me.CbVorgaenge.ValueMember = "id"
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'ErstelltDateTimePicker
        '
        Me.ErstelltDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "erstellt", True))
        Me.ErstelltDateTimePicker.Location = New System.Drawing.Point(83, 5)
        Me.ErstelltDateTimePicker.Name = "ErstelltDateTimePicker"
        Me.ErstelltDateTimePicker.Size = New System.Drawing.Size(133, 20)
        Me.ErstelltDateTimePicker.TabIndex = 9
        '
        'CbDokumente
        '
        Me.CbDokumente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "dokument", True))
        Me.CbDokumente.DataSource = Me.DokumenteBindingSource
        Me.CbDokumente.DisplayMember = "Dokument"
        Me.CbDokumente.FormattingEnabled = True
        Me.CbDokumente.Location = New System.Drawing.Point(83, 81)
        Me.CbDokumente.Name = "CbDokumente"
        Me.CbDokumente.Size = New System.Drawing.Size(346, 21)
        Me.CbDokumente.TabIndex = 16
        Me.CbDokumente.ValueMember = "id"
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAkten
        '
        Me.CbAkten.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "akte", True))
        Me.CbAkten.DataSource = Me.AktenBindingSource
        Me.CbAkten.DisplayMember = "Akte"
        Me.CbAkten.FormattingEnabled = True
        Me.CbAkten.Location = New System.Drawing.Point(83, 31)
        Me.CbAkten.Name = "CbAkten"
        Me.CbAkten.Size = New System.Drawing.Size(346, 21)
        Me.CbAkten.TabIndex = 14
        Me.CbAkten.ValueMember = "id"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.BtSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 436)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(463, 40)
        Me.Panel2.TabIndex = 20
        '
        'BtSave
        '
        Me.BtSave.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSave.Location = New System.Drawing.Point(134, 7)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(176, 30)
        Me.BtSave.TabIndex = 17
        Me.BtSave.Text = "Ok"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.NotizTextBox)
        Me.Panel3.Controls.Add(Me.TitelTextBox)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 118)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(463, 312)
        Me.Panel3.TabIndex = 21
        '
        'NotizTextBox
        '
        Me.NotizTextBox.BackColor = System.Drawing.Color.Yellow
        Me.NotizTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "notiz", True))
        Me.NotizTextBox.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.NotizTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotizTextBox.Location = New System.Drawing.Point(0, 28)
        Me.NotizTextBox.Multiline = True
        Me.NotizTextBox.Name = "NotizTextBox"
        Me.NotizTextBox.Size = New System.Drawing.Size(463, 284)
        Me.NotizTextBox.TabIndex = 11
        '
        'TitelTextBox
        '
        Me.TitelTextBox.BackColor = System.Drawing.Color.Yellow
        Me.TitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "titel", True))
        Me.TitelTextBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.TitelTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitelTextBox.Location = New System.Drawing.Point(0, 0)
        Me.TitelTextBox.Name = "TitelTextBox"
        Me.TitelTextBox.Size = New System.Drawing.Size(463, 24)
        Me.TitelTextBox.TabIndex = 18
        Me.TitelTextBox.Text = "Titel"
        '
        'NotizTableAdapter
        '
        Me.NotizTableAdapter.ClearBeforeFill = True
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'AktenVorgaengeBindingSource
        '
        Me.AktenVorgaengeBindingSource.DataMember = "Akten_Vorgaenge"
        Me.AktenVorgaengeBindingSource.DataSource = Me.AktenBindingSource
        '
        '_FreeDMS_StartDBDataSet1
        '
        Me._FreeDMS_StartDBDataSet1.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SqlVorgangAkteBindingSource
        '
        Me.SqlVorgangAkteBindingSource.DataMember = "sqlVorgangAkte"
        Me.SqlVorgangAkteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet1
        '
        'SqlVorgangAkteTableAdapter
        '
        Me.SqlVorgangAkteTableAdapter.ClearBeforeFill = True
        '
        'NotizNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(469, 479)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "NotizNeu"
        Me.Text = "FreeDMS-Tab- Neue Notiz"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        CType(Me.AktenVorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SqlVorgangAkteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbVorgaenge As ComboBox
    Friend WithEvents ErstelltDateTimePicker As DateTimePicker
    Friend WithEvents CbDokumente As ComboBox
    Friend WithEvents CbAkten As ComboBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtSave As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents NotizTextBox As TextBox
    Friend WithEvents TitelTextBox As TextBox
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents NotizBindingSource As BindingSource
    Friend WithEvents NotizTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents ErstelltTextBox As TextBox
    Friend WithEvents AktenVorgaengeBindingSource As BindingSource
    Friend WithEvents _FreeDMS_StartDBDataSet1 As _FreeDMS_StartDBDataSet
    Friend WithEvents SqlVorgangAkteBindingSource As BindingSource
    Friend WithEvents SqlVorgangAkteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.sqlVorgangAkteTableAdapter
End Class
