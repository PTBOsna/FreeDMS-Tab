<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Notiz
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ErstelltLabel1 As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.CbVorgaenge = New System.Windows.Forms.ComboBox()
        Me.NotizBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.SqlVorgangAkteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAkten = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbDokumente = New System.Windows.Forms.ComboBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErstelltTextBox = New System.Windows.Forms.TextBox()
        Me.NotizTextBox = New System.Windows.Forms.TextBox()
        Me.TitelTextBox = New System.Windows.Forms.TextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.NotizTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter()
        Me.SqlVorgangAkteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.sqlVorgangAkteTableAdapter()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        ErstelltLabel1 = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SqlVorgangAkteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ErstelltLabel1
        '
        ErstelltLabel1.AutoSize = True
        ErstelltLabel1.Location = New System.Drawing.Point(53, 12)
        ErstelltLabel1.Name = "ErstelltLabel1"
        ErstelltLabel1.Size = New System.Drawing.Size(41, 13)
        ErstelltLabel1.TabIndex = 30
        ErstelltLabel1.Text = "Erstellt:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(35, 93)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 21
        DokumentLabel.Text = "Dokument:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(62, 43)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 19
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(44, 66)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 20
        VorgangLabel.Text = "Vorgang:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.NotizTextBox, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.TitelTextBox, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 0, 3)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.8481!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.751055!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 65.40084!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 53.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(479, 594)
        Me.TableLayoutPanel1.TabIndex = 33
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CbVorgaenge)
        Me.Panel1.Controls.Add(ErstelltLabel1)
        Me.Panel1.Controls.Add(Me.CbAkten)
        Me.Panel1.Controls.Add(DokumentLabel)
        Me.Panel1.Controls.Add(AkteLabel)
        Me.Panel1.Controls.Add(Me.CbDokumente)
        Me.Panel1.Controls.Add(Me.ErstelltTextBox)
        Me.Panel1.Controls.Add(VorgangLabel)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(473, 144)
        Me.Panel1.TabIndex = 0
        '
        'CbVorgaenge
        '
        Me.CbVorgaenge.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "vorgang", True))
        Me.CbVorgaenge.DataSource = Me.SqlVorgangAkteBindingSource
        Me.CbVorgaenge.DisplayMember = "Anzeige"
        Me.CbVorgaenge.FormattingEnabled = True
        Me.CbVorgaenge.Location = New System.Drawing.Point(100, 63)
        Me.CbVorgaenge.Name = "CbVorgaenge"
        Me.CbVorgaenge.Size = New System.Drawing.Size(236, 21)
        Me.CbVorgaenge.TabIndex = 26
        Me.CbVorgaenge.ValueMember = "id"
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
        'SqlVorgangAkteBindingSource
        '
        Me.SqlVorgangAkteBindingSource.DataMember = "sqlVorgangAkte"
        Me.SqlVorgangAkteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAkten
        '
        Me.CbAkten.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "akte", True))
        Me.CbAkten.DataSource = Me.AktenBindingSource
        Me.CbAkten.DisplayMember = "Akte"
        Me.CbAkten.FormattingEnabled = True
        Me.CbAkten.Location = New System.Drawing.Point(100, 35)
        Me.CbAkten.Name = "CbAkten"
        Me.CbAkten.Size = New System.Drawing.Size(236, 21)
        Me.CbAkten.TabIndex = 25
        Me.CbAkten.ValueMember = "id"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbDokumente
        '
        Me.CbDokumente.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.NotizBindingSource, "dokument", True))
        Me.CbDokumente.DataSource = Me.DokumenteBindingSource
        Me.CbDokumente.DisplayMember = "Dokument"
        Me.CbDokumente.FormattingEnabled = True
        Me.CbDokumente.Location = New System.Drawing.Point(100, 90)
        Me.CbDokumente.Name = "CbDokumente"
        Me.CbDokumente.Size = New System.Drawing.Size(236, 21)
        Me.CbDokumente.TabIndex = 27
        Me.CbDokumente.ValueMember = "id"
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'ErstelltTextBox
        '
        Me.ErstelltTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "erstellt", True))
        Me.ErstelltTextBox.Location = New System.Drawing.Point(100, 9)
        Me.ErstelltTextBox.Name = "ErstelltTextBox"
        Me.ErstelltTextBox.Size = New System.Drawing.Size(100, 20)
        Me.ErstelltTextBox.TabIndex = 31
        '
        'NotizTextBox
        '
        Me.NotizTextBox.BackColor = System.Drawing.Color.Yellow
        Me.NotizTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "notiz", True))
        Me.NotizTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NotizTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NotizTextBox.Location = New System.Drawing.Point(3, 189)
        Me.NotizTextBox.Multiline = True
        Me.NotizTextBox.Name = "NotizTextBox"
        Me.NotizTextBox.Size = New System.Drawing.Size(473, 347)
        Me.NotizTextBox.TabIndex = 24
        '
        'TitelTextBox
        '
        Me.TitelTextBox.BackColor = System.Drawing.Color.Yellow
        Me.TitelTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.NotizBindingSource, "titel", True))
        Me.TitelTextBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TitelTextBox.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TitelTextBox.Location = New System.Drawing.Point(3, 153)
        Me.TitelTextBox.Name = "TitelTextBox"
        Me.TitelTextBox.Size = New System.Drawing.Size(473, 24)
        Me.TitelTextBox.TabIndex = 29
        Me.TitelTextBox.Text = "Titel"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btDelete)
        Me.Panel2.Controls.Add(Me.BtSave)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(3, 542)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(473, 49)
        Me.Panel2.TabIndex = 30
        '
        'btDelete
        '
        Me.btDelete.Location = New System.Drawing.Point(277, 12)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(173, 28)
        Me.btDelete.TabIndex = 29
        Me.btDelete.Text = "Notiz löschen"
        Me.btDelete.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSave.Location = New System.Drawing.Point(9, 12)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(173, 28)
        Me.BtSave.TabIndex = 28
        Me.BtSave.Text = "Zurück"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'NotizTableAdapter
        '
        Me.NotizTableAdapter.ClearBeforeFill = True
        '
        'SqlVorgangAkteTableAdapter
        '
        Me.SqlVorgangAkteTableAdapter.ClearBeforeFill = True
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'Notiz
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(479, 594)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Notiz"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FreeDMS-Tab - Notiz"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NotizBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SqlVorgangAkteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CbVorgaenge As ComboBox
    Friend WithEvents CbAkten As ComboBox
    Friend WithEvents CbDokumente As ComboBox
    Friend WithEvents ErstelltTextBox As TextBox
    Friend WithEvents NotizTextBox As TextBox
    Friend WithEvents TitelTextBox As TextBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btDelete As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents NotizBindingSource As BindingSource
    Friend WithEvents NotizTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.notizTableAdapter
    Friend WithEvents SqlVorgangAkteBindingSource As BindingSource
    Friend WithEvents SqlVorgangAkteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.sqlVorgangAkteTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
End Class
