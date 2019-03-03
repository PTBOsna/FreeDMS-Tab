<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AkteEdit
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
        Dim IdLabel As System.Windows.Forms.Label
        Dim MandantLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim AngelegtLabel As System.Windows.Forms.Label
        Dim ArchiviertLabel1 As System.Windows.Forms.Label
        Dim ArchivLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.AngelegtTextBox = New System.Windows.Forms.TextBox()
        Me.lbAnzahlZeichen = New System.Windows.Forms.Label()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.ArchiviertTextBox = New System.Windows.Forms.TextBox()
        Me.ArchivCheckBox = New System.Windows.Forms.CheckBox()
        IdLabel = New System.Windows.Forms.Label()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        AngelegtLabel = New System.Windows.Forms.Label()
        ArchiviertLabel1 = New System.Windows.Forms.Label()
        ArchivLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(117, 23)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Az:"
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Location = New System.Drawing.Point(87, 49)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(52, 13)
        MandantLabel.TabIndex = 4
        MandantLabel.Text = "Mandant:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(107, 75)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 6
        AkteLabel.Text = "Akte:"
        '
        'BeschreibungLabel
        '
        BeschreibungLabel.AutoSize = True
        BeschreibungLabel.Location = New System.Drawing.Point(64, 101)
        BeschreibungLabel.Name = "BeschreibungLabel"
        BeschreibungLabel.Size = New System.Drawing.Size(75, 13)
        BeschreibungLabel.TabIndex = 8
        BeschreibungLabel.Text = "Beschreibung:"
        '
        'AngelegtLabel
        '
        AngelegtLabel.AutoSize = True
        AngelegtLabel.Location = New System.Drawing.Point(87, 190)
        AngelegtLabel.Name = "AngelegtLabel"
        AngelegtLabel.Size = New System.Drawing.Size(52, 13)
        AngelegtLabel.TabIndex = 10
        AngelegtLabel.Text = "Angelegt:"
        '
        'ArchiviertLabel1
        '
        ArchiviertLabel1.AutoSize = True
        ArchiviertLabel1.Location = New System.Drawing.Point(85, 219)
        ArchiviertLabel1.Name = "ArchiviertLabel1"
        ArchiviertLabel1.Size = New System.Drawing.Size(54, 13)
        ArchiviertLabel1.TabIndex = 17
        ArchiviertLabel1.Text = "Archiviert:"
        '
        'ArchivLabel
        '
        ArchivLabel.AutoSize = True
        ArchivLabel.Location = New System.Drawing.Point(99, 247)
        ArchivLabel.Name = "ArchivLabel"
        ArchivLabel.Size = New System.Drawing.Size(40, 13)
        ArchivLabel.TabIndex = 18
        ArchivLabel.Text = "Archiv:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(317, 314)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(146, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(67, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(76, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(67, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Abbrechen"
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(145, 20)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(38, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'MandantTextBox
        '
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MandantBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(145, 46)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.ReadOnly = True
        Me.MandantTextBox.Size = New System.Drawing.Size(200, 20)
        Me.MandantTextBox.TabIndex = 5
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(145, 72)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AkteTextBox.TabIndex = 7
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Location = New System.Drawing.Point(145, 98)
        Me.BeschreibungTextBox.Multiline = True
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        Me.BeschreibungTextBox.Size = New System.Drawing.Size(200, 57)
        Me.BeschreibungTextBox.TabIndex = 9
        '
        'AngelegtTextBox
        '
        Me.AngelegtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Angelegt", True))
        Me.AngelegtTextBox.Location = New System.Drawing.Point(145, 186)
        Me.AngelegtTextBox.Name = "AngelegtTextBox"
        Me.AngelegtTextBox.Size = New System.Drawing.Size(200, 20)
        Me.AngelegtTextBox.TabIndex = 16
        '
        'lbAnzahlZeichen
        '
        Me.lbAnzahlZeichen.AutoSize = True
        Me.lbAnzahlZeichen.Location = New System.Drawing.Point(150, 158)
        Me.lbAnzahlZeichen.Name = "lbAnzahlZeichen"
        Me.lbAnzahlZeichen.Size = New System.Drawing.Size(99, 13)
        Me.lbAnzahlZeichen.TabIndex = 17
        Me.lbAnzahlZeichen.Text = "(Max. 250 Zeichen)"
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
        'ArchiviertTextBox
        '
        Me.ArchiviertTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Archiviert", True))
        Me.ArchiviertTextBox.Location = New System.Drawing.Point(145, 216)
        Me.ArchiviertTextBox.Name = "ArchiviertTextBox"
        Me.ArchiviertTextBox.Size = New System.Drawing.Size(200, 20)
        Me.ArchiviertTextBox.TabIndex = 18
        '
        'ArchivCheckBox
        '
        Me.ArchivCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.AktenBindingSource, "Archiv", True))
        Me.ArchivCheckBox.Location = New System.Drawing.Point(145, 242)
        Me.ArchivCheckBox.Name = "ArchivCheckBox"
        Me.ArchivCheckBox.Size = New System.Drawing.Size(104, 24)
        Me.ArchivCheckBox.TabIndex = 19
        Me.ArchivCheckBox.UseVisualStyleBackColor = True
        '
        'AkteEdit
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(475, 355)
        Me.Controls.Add(ArchivLabel)
        Me.Controls.Add(Me.ArchivCheckBox)
        Me.Controls.Add(ArchiviertLabel1)
        Me.Controls.Add(Me.ArchiviertTextBox)
        Me.Controls.Add(Me.lbAnzahlZeichen)
        Me.Controls.Add(Me.AngelegtTextBox)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(MandantLabel)
        Me.Controls.Add(Me.MandantTextBox)
        Me.Controls.Add(AkteLabel)
        Me.Controls.Add(Me.AkteTextBox)
        Me.Controls.Add(BeschreibungLabel)
        Me.Controls.Add(Me.BeschreibungTextBox)
        Me.Controls.Add(AngelegtLabel)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AkteEdit"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FreeDMS-Tab - Akte ansehen/ändern"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents BeschreibungTextBox As TextBox
    Friend WithEvents AngelegtTextBox As TextBox
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents lbAnzahlZeichen As Label
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents ArchiviertTextBox As TextBox
    Friend WithEvents ArchivCheckBox As CheckBox
End Class
