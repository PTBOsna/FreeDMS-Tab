<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ImageToPDF
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
        Dim DokDatumLabel As System.Windows.Forms.Label
        Dim DokNameLabel As System.Windows.Forms.Label
        Dim BetreffLabel As System.Windows.Forms.Label
        Dim DokumentLabel As System.Windows.Forms.Label
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.lblWork = New System.Windows.Forms.Label()
        Me.ProgressBar2 = New System.Windows.Forms.ProgressBar()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.BtArchiv = New System.Windows.Forms.Button()
        Me.BtAlles = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BtToPDF = New System.Windows.Forms.Button()
        Me.BtPDF_OCR = New System.Windows.Forms.Button()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.LbErgeb = New System.Windows.Forms.ListBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.DokumenteTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        DokDatumLabel = New System.Windows.Forms.Label()
        DokNameLabel = New System.Windows.Forms.Label()
        BetreffLabel = New System.Windows.Forms.Label()
        DokumentLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel7.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Location = New System.Drawing.Point(268, 105)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(64, 13)
        DokDatumLabel.TabIndex = 6
        DokDatumLabel.Text = "Dok Datum:"
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Location = New System.Drawing.Point(272, 17)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(61, 13)
        DokNameLabel.TabIndex = 0
        DokNameLabel.Text = "Dok Name:"
        '
        'BetreffLabel
        '
        BetreffLabel.AutoSize = True
        BetreffLabel.Location = New System.Drawing.Point(291, 69)
        BetreffLabel.Name = "BetreffLabel"
        BetreffLabel.Size = New System.Drawing.Size(41, 13)
        BetreffLabel.TabIndex = 4
        BetreffLabel.Text = "Betreff:"
        '
        'DokumentLabel
        '
        DokumentLabel.AutoSize = True
        DokumentLabel.Location = New System.Drawing.Point(274, 43)
        DokumentLabel.Name = "DokumentLabel"
        DokumentLabel.Size = New System.Drawing.Size(59, 13)
        DokumentLabel.TabIndex = 2
        DokumentLabel.Text = "Dokument:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.43011!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.56989!))
        Me.TableLayoutPanel1.Controls.Add(Me.Panel2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel4, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel5, 0, 3)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel6, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel3, 0, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.Panel7, 1, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 4
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 93.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 56.17021!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 43.82979!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1001, 589)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.lblWork)
        Me.Panel2.Controls.Add(Me.ProgressBar2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.ProgressBar1)
        Me.Panel2.Location = New System.Drawing.Point(607, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(362, 87)
        Me.Panel2.TabIndex = 1
        '
        'lblWork
        '
        Me.lblWork.AutoSize = True
        Me.lblWork.Location = New System.Drawing.Point(11, 23)
        Me.lblWork.Name = "lblWork"
        Me.lblWork.Size = New System.Drawing.Size(46, 13)
        Me.lblWork.TabIndex = 3
        Me.lblWork.Text = "In Arbeit"
        '
        'ProgressBar2
        '
        Me.ProgressBar2.ForeColor = System.Drawing.Color.SteelBlue
        Me.ProgressBar2.Location = New System.Drawing.Point(14, 39)
        Me.ProgressBar2.Name = "ProgressBar2"
        Me.ProgressBar2.Size = New System.Drawing.Size(341, 16)
        Me.ProgressBar2.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBar2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Text wird extrahiert..."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(14, 61)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(341, 21)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 0
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.CheckBox1)
        Me.Panel4.Controls.Add(Me.BtArchiv)
        Me.Panel4.Controls.Add(Me.BtAlles)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel4.Location = New System.Drawing.Point(3, 3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(598, 87)
        Me.Panel4.TabIndex = 8
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(152, 63)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(248, 17)
        Me.CheckBox1.TabIndex = 2
        Me.CheckBox1.Text = "QuellDatei nach Umwandlung löschen?"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'BtArchiv
        '
        Me.BtArchiv.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtArchiv.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtArchiv.Location = New System.Drawing.Point(371, 16)
        Me.BtArchiv.Name = "BtArchiv"
        Me.BtArchiv.Size = New System.Drawing.Size(147, 41)
        Me.BtArchiv.TabIndex = 1
        Me.BtArchiv.Text = "Archivordner"
        Me.BtArchiv.UseVisualStyleBackColor = True
        '
        'BtAlles
        '
        Me.BtAlles.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtAlles.Location = New System.Drawing.Point(41, 16)
        Me.BtAlles.Name = "BtAlles"
        Me.BtAlles.Size = New System.Drawing.Size(147, 41)
        Me.BtAlles.TabIndex = 0
        Me.BtAlles.Text = "Alle Ordner"
        Me.BtAlles.UseVisualStyleBackColor = True
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.BtCancel)
        Me.Panel5.Controls.Add(Me.BtSave)
        Me.Panel5.Controls.Add(Me.BtToPDF)
        Me.Panel5.Controls.Add(Me.BtPDF_OCR)
        Me.Panel5.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel5.Location = New System.Drawing.Point(3, 541)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(598, 45)
        Me.Panel5.TabIndex = 10
        '
        'BtCancel
        '
        Me.BtCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.BtCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtCancel.Location = New System.Drawing.Point(488, 3)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(102, 40)
        Me.BtCancel.TabIndex = 7
        Me.BtCancel.Text = "Zurück"
        Me.BtCancel.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtSave.Location = New System.Drawing.Point(379, 3)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(102, 40)
        Me.BtSave.TabIndex = 6
        Me.BtSave.Text = "Speichern und zurück"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'BtToPDF
        '
        Me.BtToPDF.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtToPDF.Location = New System.Drawing.Point(117, 2)
        Me.BtToPDF.Name = "BtToPDF"
        Me.BtToPDF.Size = New System.Drawing.Size(102, 40)
        Me.BtToPDF.TabIndex = 5
        Me.BtToPDF.Text = "PDF"
        Me.BtToPDF.UseVisualStyleBackColor = True
        '
        'BtPDF_OCR
        '
        Me.BtPDF_OCR.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtPDF_OCR.Location = New System.Drawing.Point(9, 2)
        Me.BtPDF_OCR.Name = "BtPDF_OCR"
        Me.BtPDF_OCR.Size = New System.Drawing.Size(102, 40)
        Me.BtPDF_OCR.TabIndex = 4
        Me.BtPDF_OCR.Text = "PDF und OCR"
        Me.BtPDF_OCR.UseVisualStyleBackColor = True
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.ListBox1)
        Me.Panel6.Controls.Add(Me.DokNameTextBox)
        Me.Panel6.Controls.Add(DokDatumLabel)
        Me.Panel6.Controls.Add(DokNameLabel)
        Me.Panel6.Controls.Add(Me.DokDatumTextBox)
        Me.Panel6.Controls.Add(Me.BetreffTextBox)
        Me.Panel6.Controls.Add(BetreffLabel)
        Me.Panel6.Controls.Add(Me.DokumentTextBox)
        Me.Panel6.Controls.Add(DokumentLabel)
        Me.Panel6.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel6.Location = New System.Drawing.Point(3, 96)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(598, 244)
        Me.Panel6.TabIndex = 11
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Left
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(0, 0)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(263, 244)
        Me.ListBox1.TabIndex = 7
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(339, 14)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.DokNameTextBox.TabIndex = 1
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        Me.DokumenteBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(338, 102)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(128, 20)
        Me.DokDatumTextBox.TabIndex = 7
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Location = New System.Drawing.Point(338, 66)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(209, 20)
        Me.BetreffTextBox.TabIndex = 5
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Location = New System.Drawing.Point(339, 40)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(209, 20)
        Me.DokumentTextBox.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Panel1)
        Me.Panel3.Controls.Add(Me.LbErgeb)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(3, 346)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(598, 189)
        Me.Panel3.TabIndex = 6
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(598, 51)
        Me.Panel1.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(207, 13)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Neuer DokName und Inhalt (Auszug) OCR"
        '
        'LbErgeb
        '
        Me.LbErgeb.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.LbErgeb.FormattingEnabled = True
        Me.LbErgeb.Location = New System.Drawing.Point(0, 55)
        Me.LbErgeb.Name = "LbErgeb"
        Me.LbErgeb.Size = New System.Drawing.Size(598, 134)
        Me.LbErgeb.TabIndex = 8
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.RichTextBox1)
        Me.Panel7.Controls.Add(Me.PictureBox1)
        Me.Panel7.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel7.Location = New System.Drawing.Point(607, 96)
        Me.Panel7.Name = "Panel7"
        Me.TableLayoutPanel1.SetRowSpan(Me.Panel7, 2)
        Me.Panel7.Size = New System.Drawing.Size(391, 439)
        Me.Panel7.TabIndex = 12
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(79, 248)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(186, 179)
        Me.RichTextBox1.TabIndex = 10
        Me.RichTextBox1.Text = ""
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(14, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(177, 224)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 9
        Me.PictureBox1.TabStop = False
        '
        'DokumenteTableAdapter
        '
        Me.DokumenteTableAdapter.ClearBeforeFill = True
        '
        'BackgroundWorker1
        '
        Me.BackgroundWorker1.WorkerReportsProgress = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'ImageToPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1001, 589)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "ImageToPDF"
        Me.Text = "ImageToPDF"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel5.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel7.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents lblWork As Label
    Friend WithEvents ProgressBar2 As ProgressBar
    Friend WithEvents Label1 As Label
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents Panel4 As Panel
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents BtArchiv As Button
    Friend WithEvents BtAlles As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents BtCancel As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents BtToPDF As Button
    Friend WithEvents BtPDF_OCR As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents LbErgeb As ListBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents DokumenteTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.DokumenteTableAdapter
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
