<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AnschriftNeu
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
        Me.BtCheck = New System.Windows.Forms.Button()
        Me.BtSave = New System.Windows.Forms.Button()
        Me.BtCancel = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.TableAdapterManager = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager()
        Me.LbErgeb = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
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
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(40, 22)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'IdTextBox
        '
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(116, 19)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(50, 20)
        Me.IdTextBox.TabIndex = 2
        '
        'Name_Label
        '
        Name_Label.AutoSize = True
        Name_Label.Location = New System.Drawing.Point(40, 48)
        Name_Label.Name = "Name_Label"
        Name_Label.Size = New System.Drawing.Size(41, 13)
        Name_Label.TabIndex = 3
        Name_Label.Text = "Name :"
        '
        'Name_TextBox
        '
        Me.Name_TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Name_", True))
        Me.Name_TextBox.Location = New System.Drawing.Point(116, 45)
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(240, 20)
        Me.Name_TextBox.TabIndex = 4
        '
        'ZusatzLabel
        '
        ZusatzLabel.AutoSize = True
        ZusatzLabel.Location = New System.Drawing.Point(40, 74)
        ZusatzLabel.Name = "ZusatzLabel"
        ZusatzLabel.Size = New System.Drawing.Size(42, 13)
        ZusatzLabel.TabIndex = 5
        ZusatzLabel.Text = "Zusatz:"
        '
        'ZusatzTextBox
        '
        Me.ZusatzTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Zusatz", True))
        Me.ZusatzTextBox.Location = New System.Drawing.Point(116, 71)
        Me.ZusatzTextBox.Name = "ZusatzTextBox"
        Me.ZusatzTextBox.Size = New System.Drawing.Size(240, 20)
        Me.ZusatzTextBox.TabIndex = 6
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(185, 103)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 7
        OrtLabel.Text = "Ort:"
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(225, 100)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(131, 20)
        Me.OrtTextBox.TabIndex = 8
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(40, 103)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 9
        PLZLabel.Text = "PLZ:"
        '
        'PLZTextBox
        '
        Me.PLZTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "PLZ", True))
        Me.PLZTextBox.Location = New System.Drawing.Point(116, 100)
        Me.PLZTextBox.Name = "PLZTextBox"
        Me.PLZTextBox.Size = New System.Drawing.Size(50, 20)
        Me.PLZTextBox.TabIndex = 10
        '
        'Anschrift1Label
        '
        Anschrift1Label.AutoSize = True
        Anschrift1Label.Location = New System.Drawing.Point(40, 152)
        Anschrift1Label.Name = "Anschrift1Label"
        Anschrift1Label.Size = New System.Drawing.Size(57, 13)
        Anschrift1Label.TabIndex = 11
        Anschrift1Label.Text = "Anschrift1:"
        '
        'Anschrift1TextBox
        '
        Me.Anschrift1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Anschrift1", True))
        Me.Anschrift1TextBox.Location = New System.Drawing.Point(116, 149)
        Me.Anschrift1TextBox.Name = "Anschrift1TextBox"
        Me.Anschrift1TextBox.Size = New System.Drawing.Size(240, 20)
        Me.Anschrift1TextBox.TabIndex = 12
        '
        'Anschrift2Label
        '
        Anschrift2Label.AutoSize = True
        Anschrift2Label.Location = New System.Drawing.Point(40, 178)
        Anschrift2Label.Name = "Anschrift2Label"
        Anschrift2Label.Size = New System.Drawing.Size(57, 13)
        Anschrift2Label.TabIndex = 13
        Anschrift2Label.Text = "Anschrift2:"
        '
        'Anschrift2TextBox
        '
        Me.Anschrift2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Anschrift2", True))
        Me.Anschrift2TextBox.Location = New System.Drawing.Point(116, 175)
        Me.Anschrift2TextBox.Name = "Anschrift2TextBox"
        Me.Anschrift2TextBox.Size = New System.Drawing.Size(240, 20)
        Me.Anschrift2TextBox.TabIndex = 14
        '
        'LandLabel
        '
        LandLabel.AutoSize = True
        LandLabel.Location = New System.Drawing.Point(175, 129)
        LandLabel.Name = "LandLabel"
        LandLabel.Size = New System.Drawing.Size(34, 13)
        LandLabel.TabIndex = 15
        LandLabel.Text = "Land:"
        '
        'LandTextBox
        '
        Me.LandTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Land", True))
        Me.LandTextBox.Location = New System.Drawing.Point(225, 126)
        Me.LandTextBox.Name = "LandTextBox"
        Me.LandTextBox.Size = New System.Drawing.Size(131, 20)
        Me.LandTextBox.TabIndex = 16
        '
        'Telefon1Label
        '
        Telefon1Label.AutoSize = True
        Telefon1Label.Location = New System.Drawing.Point(40, 230)
        Telefon1Label.Name = "Telefon1Label"
        Telefon1Label.Size = New System.Drawing.Size(52, 13)
        Telefon1Label.TabIndex = 17
        Telefon1Label.Text = "Telefon1:"
        '
        'Telefon1TextBox
        '
        Me.Telefon1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Telefon1", True))
        Me.Telefon1TextBox.Location = New System.Drawing.Point(116, 227)
        Me.Telefon1TextBox.Name = "Telefon1TextBox"
        Me.Telefon1TextBox.Size = New System.Drawing.Size(80, 20)
        Me.Telefon1TextBox.TabIndex = 18
        '
        'Telefon2Label
        '
        Telefon2Label.AutoSize = True
        Telefon2Label.Location = New System.Drawing.Point(211, 231)
        Telefon2Label.Name = "Telefon2Label"
        Telefon2Label.Size = New System.Drawing.Size(52, 13)
        Telefon2Label.TabIndex = 19
        Telefon2Label.Text = "Telefon2:"
        '
        'Telefon2TextBox
        '
        Me.Telefon2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Telefon2", True))
        Me.Telefon2TextBox.Location = New System.Drawing.Point(269, 228)
        Me.Telefon2TextBox.Name = "Telefon2TextBox"
        Me.Telefon2TextBox.Size = New System.Drawing.Size(87, 20)
        Me.Telefon2TextBox.TabIndex = 20
        '
        'MailLabel
        '
        MailLabel.AutoSize = True
        MailLabel.Location = New System.Drawing.Point(40, 257)
        MailLabel.Name = "MailLabel"
        MailLabel.Size = New System.Drawing.Size(29, 13)
        MailLabel.TabIndex = 21
        MailLabel.Text = "Mail:"
        '
        'MailTextBox
        '
        Me.MailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Mail", True))
        Me.MailTextBox.Location = New System.Drawing.Point(116, 254)
        Me.MailTextBox.Name = "MailTextBox"
        Me.MailTextBox.Size = New System.Drawing.Size(240, 20)
        Me.MailTextBox.TabIndex = 22
        '
        'InternetLabel
        '
        InternetLabel.AutoSize = True
        InternetLabel.Location = New System.Drawing.Point(40, 283)
        InternetLabel.Name = "InternetLabel"
        InternetLabel.Size = New System.Drawing.Size(46, 13)
        InternetLabel.TabIndex = 23
        InternetLabel.Text = "Internet:"
        '
        'InternetTextBox
        '
        Me.InternetTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Internet", True))
        Me.InternetTextBox.Location = New System.Drawing.Point(116, 280)
        Me.InternetTextBox.Name = "InternetTextBox"
        Me.InternetTextBox.Size = New System.Drawing.Size(240, 20)
        Me.InternetTextBox.TabIndex = 24
        '
        'BmerkungenLabel
        '
        BmerkungenLabel.AutoSize = True
        BmerkungenLabel.Location = New System.Drawing.Point(40, 309)
        BmerkungenLabel.Name = "BmerkungenLabel"
        BmerkungenLabel.Size = New System.Drawing.Size(70, 13)
        BmerkungenLabel.TabIndex = 25
        BmerkungenLabel.Text = "Bmerkungen:"
        '
        'BmerkungenTextBox
        '
        Me.BmerkungenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Bmerkungen", True))
        Me.BmerkungenTextBox.Location = New System.Drawing.Point(116, 306)
        Me.BmerkungenTextBox.Name = "BmerkungenTextBox"
        Me.BmerkungenTextBox.Size = New System.Drawing.Size(240, 20)
        Me.BmerkungenTextBox.TabIndex = 26
        '
        'BtCheck
        '
        Me.BtCheck.Location = New System.Drawing.Point(377, 43)
        Me.BtCheck.Name = "BtCheck"
        Me.BtCheck.Size = New System.Drawing.Size(75, 23)
        Me.BtCheck.TabIndex = 27
        Me.BtCheck.Text = "Prüfen*)"
        Me.BtCheck.UseVisualStyleBackColor = True
        '
        'BtSave
        '
        Me.BtSave.Location = New System.Drawing.Point(169, 334)
        Me.BtSave.Name = "BtSave"
        Me.BtSave.Size = New System.Drawing.Size(134, 24)
        Me.BtSave.TabIndex = 28
        Me.BtSave.Text = "Speichern und schließen"
        Me.BtSave.UseVisualStyleBackColor = True
        '
        'BtCancel
        '
        Me.BtCancel.Location = New System.Drawing.Point(377, 335)
        Me.BtCancel.Name = "BtCancel"
        Me.BtCancel.Size = New System.Drawing.Size(75, 23)
        Me.BtCancel.TabIndex = 29
        Me.BtCancel.Text = "zurück"
        Me.BtCancel.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(377, 103)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(98, 95)
        Me.ListBox1.TabIndex = 30
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        Me.AnschriftenBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        '_FreeDMS_StartDBDataSet
        '
        Me._FreeDMS_StartDBDataSet.DataSetName = "_FreeDMS_StartDBDataSet"
        Me._FreeDMS_StartDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        Me.TableAdapterManager.AnschriftAltTableAdapter = Nothing
        Me.TableAdapterManager.AnschriftenTableAdapter = Me.AnschriftenTableAdapter
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
        'LbErgeb
        '
        Me.LbErgeb.AutoSize = True
        Me.LbErgeb.Location = New System.Drawing.Point(374, 78)
        Me.LbErgeb.Name = "LbErgeb"
        Me.LbErgeb.Size = New System.Drawing.Size(48, 13)
        Me.LbErgeb.TabIndex = 31
        Me.LbErgeb.Text = "Ergebnis"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(311, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(172, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "*) Groß- Kleinschreibung beachten!"
        '
        'AnschriftNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(495, 370)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.LbErgeb)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.BtCancel)
        Me.Controls.Add(Me.BtSave)
        Me.Controls.Add(Me.BtCheck)
        Me.Controls.Add(IdLabel)
        Me.Controls.Add(Me.IdTextBox)
        Me.Controls.Add(Name_Label)
        Me.Controls.Add(Me.Name_TextBox)
        Me.Controls.Add(ZusatzLabel)
        Me.Controls.Add(Me.ZusatzTextBox)
        Me.Controls.Add(OrtLabel)
        Me.Controls.Add(Me.OrtTextBox)
        Me.Controls.Add(PLZLabel)
        Me.Controls.Add(Me.PLZTextBox)
        Me.Controls.Add(Anschrift1Label)
        Me.Controls.Add(Me.Anschrift1TextBox)
        Me.Controls.Add(Anschrift2Label)
        Me.Controls.Add(Me.Anschrift2TextBox)
        Me.Controls.Add(LandLabel)
        Me.Controls.Add(Me.LandTextBox)
        Me.Controls.Add(Telefon1Label)
        Me.Controls.Add(Me.Telefon1TextBox)
        Me.Controls.Add(Telefon2Label)
        Me.Controls.Add(Me.Telefon2TextBox)
        Me.Controls.Add(MailLabel)
        Me.Controls.Add(Me.MailTextBox)
        Me.Controls.Add(InternetLabel)
        Me.Controls.Add(Me.InternetTextBox)
        Me.Controls.Add(BmerkungenLabel)
        Me.Controls.Add(Me.BmerkungenTextBox)
        Me.Name = "AnschriftNeu"
        Me.Text = "FreeDMS-Tab - Neue Anschrift hinzufügen"
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents TableAdapterManager As _FreeDMS_StartDBDataSetTableAdapters.TableAdapterManager
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
    Friend WithEvents BtCheck As Button
    Friend WithEvents BtSave As Button
    Friend WithEvents BtCancel As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents LbErgeb As Label
    Friend WithEvents Label1 As Label
End Class
