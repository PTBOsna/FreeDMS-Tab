<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class VorgangNeu
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
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim HinweiseLabel As System.Windows.Forms.Label
        Dim BegonnenLabel As System.Windows.Forms.Label
        Dim ZeitzielLabel As System.Windows.Forms.Label
        Dim BeendetLabel As System.Windows.Forms.Label
        Dim ArchivLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgaengeTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.AktenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.HinweiseTextBox = New System.Windows.Forms.TextBox()
        Me.BegonnenTextBox = New System.Windows.Forms.TextBox()
        Me.ZeitzielTextBox = New System.Windows.Forms.TextBox()
        Me.BeendetTextBox = New System.Windows.Forms.TextBox()
        Me.ArchivLabel1 = New System.Windows.Forms.Label()
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PanlEdit = New System.Windows.Forms.Panel()
        Me.AkteIDTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        HinweiseLabel = New System.Windows.Forms.Label()
        BegonnenLabel = New System.Windows.Forms.Label()
        ZeitzielLabel = New System.Windows.Forms.Label()
        BeendetLabel = New System.Windows.Forms.Label()
        ArchivLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanlEdit.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(89, 33)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(22, 13)
        IdLabel.TabIndex = 2
        IdLabel.Text = "Az:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Location = New System.Drawing.Point(79, 59)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(32, 13)
        AkteLabel.TabIndex = 4
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Location = New System.Drawing.Point(61, 85)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(50, 13)
        VorgangLabel.TabIndex = 6
        VorgangLabel.Text = "Vorgang:"
        '
        'BeschreibungLabel
        '
        BeschreibungLabel.AutoSize = True
        BeschreibungLabel.Location = New System.Drawing.Point(36, 111)
        BeschreibungLabel.Name = "BeschreibungLabel"
        BeschreibungLabel.Size = New System.Drawing.Size(75, 13)
        BeschreibungLabel.TabIndex = 8
        BeschreibungLabel.Text = "Beschreibung:"
        '
        'HinweiseLabel
        '
        HinweiseLabel.AutoSize = True
        HinweiseLabel.Location = New System.Drawing.Point(58, 171)
        HinweiseLabel.Name = "HinweiseLabel"
        HinweiseLabel.Size = New System.Drawing.Size(53, 13)
        HinweiseLabel.TabIndex = 10
        HinweiseLabel.Text = "Hinweise:"
        '
        'BegonnenLabel
        '
        BegonnenLabel.AutoSize = True
        BegonnenLabel.Location = New System.Drawing.Point(52, 239)
        BegonnenLabel.Name = "BegonnenLabel"
        BegonnenLabel.Size = New System.Drawing.Size(59, 13)
        BegonnenLabel.TabIndex = 12
        BegonnenLabel.Text = "Begonnen:"
        '
        'ZeitzielLabel
        '
        ZeitzielLabel.AutoSize = True
        ZeitzielLabel.Location = New System.Drawing.Point(68, 265)
        ZeitzielLabel.Name = "ZeitzielLabel"
        ZeitzielLabel.Size = New System.Drawing.Size(43, 13)
        ZeitzielLabel.TabIndex = 14
        ZeitzielLabel.Text = "Zeitziel:"
        '
        'BeendetLabel
        '
        BeendetLabel.AutoSize = True
        BeendetLabel.Location = New System.Drawing.Point(59, 3)
        BeendetLabel.Name = "BeendetLabel"
        BeendetLabel.Size = New System.Drawing.Size(50, 13)
        BeendetLabel.TabIndex = 16
        BeendetLabel.Text = "Beendet:"
        '
        'ArchivLabel
        '
        ArchivLabel.AutoSize = True
        ArchivLabel.Location = New System.Drawing.Point(66, 23)
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
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(252, 392)
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
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        Me.VorgaengeBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
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
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(117, 30)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(46, 20)
        Me.IdTextBox.TabIndex = 3
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(117, 82)
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(221, 20)
        Me.VorgangTextBox.TabIndex = 7
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Location = New System.Drawing.Point(117, 108)
        Me.BeschreibungTextBox.Multiline = True
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        Me.BeschreibungTextBox.Size = New System.Drawing.Size(221, 54)
        Me.BeschreibungTextBox.TabIndex = 9
        '
        'HinweiseTextBox
        '
        Me.HinweiseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Hinweise", True))
        Me.HinweiseTextBox.Location = New System.Drawing.Point(117, 168)
        Me.HinweiseTextBox.Multiline = True
        Me.HinweiseTextBox.Name = "HinweiseTextBox"
        Me.HinweiseTextBox.Size = New System.Drawing.Size(221, 62)
        Me.HinweiseTextBox.TabIndex = 11
        '
        'BegonnenTextBox
        '
        Me.BegonnenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Begonnen", True))
        Me.BegonnenTextBox.Location = New System.Drawing.Point(117, 236)
        Me.BegonnenTextBox.Name = "BegonnenTextBox"
        Me.BegonnenTextBox.Size = New System.Drawing.Size(221, 20)
        Me.BegonnenTextBox.TabIndex = 13
        '
        'ZeitzielTextBox
        '
        Me.ZeitzielTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Zeitziel", True))
        Me.ZeitzielTextBox.Location = New System.Drawing.Point(117, 262)
        Me.ZeitzielTextBox.Name = "ZeitzielTextBox"
        Me.ZeitzielTextBox.Size = New System.Drawing.Size(221, 20)
        Me.ZeitzielTextBox.TabIndex = 15
        '
        'BeendetTextBox
        '
        Me.BeendetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Beendet", True))
        Me.BeendetTextBox.Location = New System.Drawing.Point(115, 0)
        Me.BeendetTextBox.Name = "BeendetTextBox"
        Me.BeendetTextBox.Size = New System.Drawing.Size(221, 20)
        Me.BeendetTextBox.TabIndex = 17
        '
        'ArchivLabel1
        '
        Me.ArchivLabel1.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Archiv", True))
        Me.ArchivLabel1.Location = New System.Drawing.Point(112, 23)
        Me.ArchivLabel1.Name = "ArchivLabel1"
        Me.ArchivLabel1.Size = New System.Drawing.Size(221, 23)
        Me.ArchivLabel1.TabIndex = 19
        Me.ArchivLabel1.Text = "Label1"
        '
        'AkteTextBox
        '
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(171, 56)
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(167, 20)
        Me.AkteTextBox.TabIndex = 5
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        Me.AktenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'PanlEdit
        '
        Me.PanlEdit.Controls.Add(Me.BeendetTextBox)
        Me.PanlEdit.Controls.Add(Me.ArchivLabel1)
        Me.PanlEdit.Controls.Add(ArchivLabel)
        Me.PanlEdit.Controls.Add(BeendetLabel)
        Me.PanlEdit.Location = New System.Drawing.Point(2, 313)
        Me.PanlEdit.Name = "PanlEdit"
        Me.PanlEdit.Size = New System.Drawing.Size(388, 57)
        Me.PanlEdit.TabIndex = 20
        '
        'AkteIDTextBox
        '
        Me.AkteIDTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Akte", True))
        Me.AkteIDTextBox.Location = New System.Drawing.Point(117, 56)
        Me.AkteIDTextBox.Name = "AkteIDTextBox"
        Me.AkteIDTextBox.Size = New System.Drawing.Size(48, 20)
        Me.AkteIDTextBox.TabIndex = 21
        '
        'VorgangNeu
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(410, 433)
        Me.Controls.Add(Me.AkteIDTextBox)
        Me.Controls.Add(Me.PanlEdit)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(AkteLabel)
        Me.Controls.Add(Me.AkteTextBox)
        Me.Controls.Add(VorgangLabel)
        Me.Controls.Add(Me.VorgangTextBox)
        Me.Controls.Add(BeschreibungLabel)
        Me.Controls.Add(Me.BeschreibungTextBox)
        Me.Controls.Add(HinweiseLabel)
        Me.Controls.Add(Me.HinweiseTextBox)
        Me.Controls.Add(BegonnenLabel)
        Me.Controls.Add(Me.BegonnenTextBox)
        Me.Controls.Add(ZeitzielLabel)
        Me.Controls.Add(Me.ZeitzielTextBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "VorgangNeu"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FreeDMS-Tab - Ordner/Vorgang"
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanlEdit.ResumeLayout(False)
        Me.PanlEdit.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents VorgaengeTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.VorgaengeTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents BeschreibungTextBox As TextBox
    Friend WithEvents HinweiseTextBox As TextBox
    Friend WithEvents BegonnenTextBox As TextBox
    Friend WithEvents ZeitzielTextBox As TextBox
    Friend WithEvents BeendetTextBox As TextBox
    Friend WithEvents ArchivLabel1 As Label
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents AktenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AktenTableAdapter
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents PanlEdit As Panel
    Friend WithEvents AkteIDTextBox As TextBox
End Class
