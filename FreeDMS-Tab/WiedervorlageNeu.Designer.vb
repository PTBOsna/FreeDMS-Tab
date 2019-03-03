<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class WiedervorlageNeu
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
        Dim WiedervorlageLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim MandantLabel As System.Windows.Forms.Label
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.WiedervorlageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.WiedervorlageTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.wiedervorlageTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.lbAnzahlZeichen = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Wv_datumTextBox = New System.Windows.Forms.TextBox()
        Me.TxtNotiz = New System.Windows.Forms.TextBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbDokument = New System.Windows.Forms.ComboBox()
        Me.CbMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbAkte = New System.Windows.Forms.ComboBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CbVorgang = New System.Windows.Forms.ComboBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BtClose = New System.Windows.Forms.Button()
        Me.BtClear = New System.Windows.Forms.Button()
        IdLabel = New System.Windows.Forms.Label()
        WiedervorlageLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WiedervorlageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(84, 38)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(24, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "Nr.:"
        '
        'WiedervorlageLabel
        '
        WiedervorlageLabel.AutoSize = True
        WiedervorlageLabel.Location = New System.Drawing.Point(29, 193)
        WiedervorlageLabel.Name = "WiedervorlageLabel"
        WiedervorlageLabel.Size = New System.Drawing.Size(79, 13)
        WiedervorlageLabel.TabIndex = 13
        WiedervorlageLabel.Text = "Wiedervorlage:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(76, 133)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 20
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(58, 159)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 22
        VorgangLabel.Text = "Vorgang:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(49, 75)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 24
        DokumentLabel.Text = "Dokument:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(74, 225)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(34, 13)
        Label1.TabIndex = 27
        Label1.Text = "Notiz:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(62, 107)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(46, 13)
        MandantLabel.TabIndex = 29
        MandantLabel.Text = "Bereich:"
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'WiedervorlageBindingSource
        '
        Me.WiedervorlageBindingSource.DataMember = "wiedervorlage"
        Me.WiedervorlageBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'WiedervorlageTableAdapter
        '
        Me.WiedervorlageTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AblageTableAdapter = Nothing
        Me.TableAdapterManager.AktenTableAdapter = Me.AktenTableAdapter
        Me.TableAdapterManager.AnlagenTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.DokArtTableAdapter = Nothing
        Me.TableAdapterManager.DokumenteTableAdapter = Me.DokumenteTableAdapter
        Me.TableAdapterManager.MandantTableAdapter = Me.MandantTableAdapter
        Me.TableAdapterManager.notizTableAdapter = Nothing
        Me.TableAdapterManager.StatusTableAdapter = Nothing
        Me.TableAdapterManager.TypTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        Me.TableAdapterManager.VorgaengeTableAdapter = Me.VorgaengeTableAdapter
        Me.TableAdapterManager.VorlagenTableAdapter = Nothing
        Me.TableAdapterManager.wiedervorlageTableAdapter = Me.WiedervorlageTableAdapter
        '
        'AktenTableAdapter
        '
        Me.AktenTableAdapter.ClearBeforeFill = True
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'VorgaengeTableAdapter
        '
        Me.VorgaengeTableAdapter.ClearBeforeFill = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(128, 35)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(63, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'lbAnzahlZeichen
        '
        Me.lbAnzahlZeichen.AutoSize = True
        Me.lbAnzahlZeichen.Location = New System.Drawing.Point(125, 298)
        Me.lbAnzahlZeichen.Name = "lbAnzahlZeichen"
        Me.lbAnzahlZeichen.Size = New System.Drawing.Size(73, 13)
        Me.lbAnzahlZeichen.TabIndex = 16
        Me.lbAnzahlZeichen.Text = "(250 Zeichen)"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(211, 190)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(117, 20)
        Me.DateTimePicker1.TabIndex = 35
        '
        'Wv_datumTextBox
        '
        Me.Wv_datumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "wv_datum", True))
        Me.Wv_datumTextBox.Location = New System.Drawing.Point(128, 190)
        Me.Wv_datumTextBox.Name = "Wv_datumTextBox"
        Me.Wv_datumTextBox.Size = New System.Drawing.Size(77, 20)
        Me.Wv_datumTextBox.TabIndex = 34
        '
        'TxtNotiz
        '
        Me.TxtNotiz.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.WiedervorlageBindingSource, "wiedervorlage", True))
        Me.TxtNotiz.Location = New System.Drawing.Point(128, 222)
        Me.TxtNotiz.Multiline = True
        Me.TxtNotiz.Name = "TxtNotiz"
        Me.TxtNotiz.Size = New System.Drawing.Size(200, 64)
        Me.TxtNotiz.TabIndex = 28
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbDokument
        '
        Me.CbDokument.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "dokument", True))
        Me.CbDokument.DataSource = Me.DokumenteBindingSource
        Me.CbDokument.DisplayMember = "Dokument"
        Me.CbDokument.FormattingEnabled = True
        Me.CbDokument.Location = New System.Drawing.Point(128, 72)
        Me.CbDokument.Name = "CbDokument"
        Me.CbDokument.Size = New System.Drawing.Size(200, 21)
        Me.CbDokument.TabIndex = 36
        Me.CbDokument.ValueMember = "id"
        '
        'CbMandant
        '
        Me.CbMandant.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "mandant", True))
        Me.CbMandant.DataSource = Me.MandantBindingSource
        Me.CbMandant.DisplayMember = "Mandant"
        Me.CbMandant.FormattingEnabled = True
        Me.CbMandant.Location = New System.Drawing.Point(128, 104)
        Me.CbMandant.Name = "CbMandant"
        Me.CbMandant.Size = New System.Drawing.Size(200, 21)
        Me.CbMandant.TabIndex = 37
        Me.CbMandant.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbAkte
        '
        Me.CbAkte.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "akte", True))
        Me.CbAkte.DataSource = Me.AktenBindingSource
        Me.CbAkte.DisplayMember = "Akte"
        Me.CbAkte.FormattingEnabled = True
        Me.CbAkte.Location = New System.Drawing.Point(128, 130)
        Me.CbAkte.Name = "CbAkte"
        Me.CbAkte.Size = New System.Drawing.Size(200, 21)
        Me.CbAkte.TabIndex = 38
        Me.CbAkte.ValueMember = "id"
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'CbVorgang
        '
        Me.CbVorgang.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.WiedervorlageBindingSource, "vorgang", True))
        Me.CbVorgang.DataSource = Me.VorgaengeBindingSource
        Me.CbVorgang.DisplayMember = "Vorgang"
        Me.CbVorgang.FormattingEnabled = True
        Me.CbVorgang.Location = New System.Drawing.Point(128, 156)
        Me.CbVorgang.Name = "CbVorgang"
        Me.CbVorgang.Size = New System.Drawing.Size(200, 21)
        Me.CbVorgang.TabIndex = 39
        Me.CbVorgang.ValueMember = "id"
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'BtClose
        '
        Me.BtClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtClose.Location = New System.Drawing.Point(128, 339)
        Me.BtClose.Name = "BtClose"
        Me.BtClose.Size = New System.Drawing.Size(75, 23)
        Me.BtClose.TabIndex = 40
        Me.BtClose.Text = "Zurück"
        Me.BtClose.UseVisualStyleBackColor = True
        '
        'BtClear
        '
        Me.BtClear.Location = New System.Drawing.Point(253, 339)
        Me.BtClear.Name = "BtClear"
        Me.BtClear.Size = New System.Drawing.Size(75, 23)
        Me.BtClear.TabIndex = 41
        Me.BtClear.Text = "Löschen"
        Me.BtClear.UseVisualStyleBackColor = True
        '
        'WiedervorlageNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(436, 374)
        Me.Controls.Add(Me.BtClear)
        Me.Controls.Add(Me.BtClose)
        Me.Controls.Add(Me.CbVorgang)
        Me.Controls.Add(Me.CbAkte)
        Me.Controls.Add(Me.CbMandant)
        Me.Controls.Add(Me.CbDokument)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Wv_datumTextBox)
        Me.Controls.Add(AkteLabel)
        Me.Controls.Add(VorgangLabel)
        Me.Controls.Add(DokumentLabel)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.TxtNotiz)
        Me.Controls.Add(MandantLabel)
        Me.Controls.Add(Me.lbAnzahlZeichen)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(WiedervorlageLabel)
        Me.Name = "WiedervorlageNeu"
        Me.Text = "FewwSMS-Tab - Neue Wiedervorlage"
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WiedervorlageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents WiedervorlageBindingSource As BindingSource
    Friend WithEvents WiedervorlageTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.wiedervorlageTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents lbAnzahlZeichen As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Wv_datumTextBox As TextBox
    Friend WithEvents TxtNotiz As TextBox
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents CbDokument As ComboBox
    Friend WithEvents CbMandant As ComboBox
    Friend WithEvents CbAkte As ComboBox
    Friend WithEvents CbVorgang As ComboBox
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents BtClose As Button
    Friend WithEvents BtClear As Button
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents VorgaengeBindingSource As BindingSource
End Class
