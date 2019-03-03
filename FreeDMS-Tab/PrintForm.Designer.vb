<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintForm
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
        Dim MandantLabel As System.Windows.Forms.Label
        Dim AkteLabel As System.Windows.Forms.Label
        Dim VorgangLabel As System.Windows.Forms.Label
        Dim BetragLabel As System.Windows.Forms.Label
        Dim AbsenderLabel As System.Windows.Forms.Label
        Dim EmpfaengerLabel As System.Windows.Forms.Label
        Dim DokDatumLabel As System.Windows.Forms.Label
        Dim AufgenommenLabel As System.Windows.Forms.Label
        Dim AblageLabel As System.Windows.Forms.Label
        Dim GeaendertLabel As System.Windows.Forms.Label
        Dim TypLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Dim DokNameLabel As System.Windows.Forms.Label
        Dim BearbVermerkLabel As System.Windows.Forms.Label
        Me.lblAnlage = New System.Windows.Forms.Label()
        Me.txtAz = New System.Windows.Forms.TextBox()
        Me.lbAz = New System.Windows.Forms.Label()
        Me.FdKommentarTextBox = New System.Windows.Forms.TextBox()
        Me.DokumenteBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.MandantTextBox = New System.Windows.Forms.TextBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AkteTextBox = New System.Windows.Forms.TextBox()
        Me.AktenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VorgangTextBox = New System.Windows.Forms.TextBox()
        Me.VorgaengeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokumentTextBox = New System.Windows.Forms.TextBox()
        Me.BetreffTextBox = New System.Windows.Forms.TextBox()
        Me.BetragTextBox = New System.Windows.Forms.TextBox()
        Me.AbsenderTextBox = New System.Windows.Forms.TextBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmpfaengerTextBox = New System.Windows.Forms.TextBox()
        Me.AnschriftenBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokDatumTextBox = New System.Windows.Forms.TextBox()
        Me.AufgenommenTextBox = New System.Windows.Forms.TextBox()
        Me.GeaendertTextBox = New System.Windows.Forms.TextBox()
        Me.AblageTextBox = New System.Windows.Forms.TextBox()
        Me.AblageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TypTextBox = New System.Windows.Forms.TextBox()
        Me.TypBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StatusTextBox = New System.Windows.Forms.TextBox()
        Me.StatusBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DokNameTextBox = New System.Windows.Forms.TextBox()
        Me.BearbVermerkTextBox = New System.Windows.Forms.TextBox()
        Me.btPrint = New System.Windows.Forms.Button()
        MandantLabel = New System.Windows.Forms.Label()
        AkteLabel = New System.Windows.Forms.Label()
        VorgangLabel = New System.Windows.Forms.Label()
        BetragLabel = New System.Windows.Forms.Label()
        AbsenderLabel = New System.Windows.Forms.Label()
        EmpfaengerLabel = New System.Windows.Forms.Label()
        DokDatumLabel = New System.Windows.Forms.Label()
        AufgenommenLabel = New System.Windows.Forms.Label()
        AblageLabel = New System.Windows.Forms.Label()
        GeaendertLabel = New System.Windows.Forms.Label()
        TypLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        DokNameLabel = New System.Windows.Forms.Label()
        BearbVermerkLabel = New System.Windows.Forms.Label()
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MandantLabel
        '
        MandantLabel.AutoSize = True
        MandantLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        MandantLabel.Location = New System.Drawing.Point(11, 122)
        MandantLabel.Name = "MandantLabel"
        MandantLabel.Size = New System.Drawing.Size(60, 13)
        MandantLabel.TabIndex = 138
        MandantLabel.Text = "Mandant:"
        '
        'AkteLabel
        '
        AkteLabel.AutoSize = True
        AkteLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AkteLabel.Location = New System.Drawing.Point(205, 122)
        AkteLabel.Name = "AkteLabel"
        AkteLabel.Size = New System.Drawing.Size(37, 13)
        AkteLabel.TabIndex = 140
        AkteLabel.Text = "Akte:"
        '
        'VorgangLabel
        '
        VorgangLabel.AutoSize = True
        VorgangLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        VorgangLabel.Location = New System.Drawing.Point(422, 122)
        VorgangLabel.Name = "VorgangLabel"
        VorgangLabel.Size = New System.Drawing.Size(58, 13)
        VorgangLabel.TabIndex = 142
        VorgangLabel.Text = "Vorgang:"
        '
        'BetragLabel
        '
        BetragLabel.AutoSize = True
        BetragLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BetragLabel.Location = New System.Drawing.Point(11, 327)
        BetragLabel.Name = "BetragLabel"
        BetragLabel.Size = New System.Drawing.Size(48, 13)
        BetragLabel.TabIndex = 146
        BetragLabel.Text = "Betrag:"
        '
        'AbsenderLabel
        '
        AbsenderLabel.AutoSize = True
        AbsenderLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AbsenderLabel.Location = New System.Drawing.Point(11, 176)
        AbsenderLabel.Name = "AbsenderLabel"
        AbsenderLabel.Size = New System.Drawing.Size(64, 13)
        AbsenderLabel.TabIndex = 148
        AbsenderLabel.Text = "Absender:"
        '
        'EmpfaengerLabel
        '
        EmpfaengerLabel.AutoSize = True
        EmpfaengerLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        EmpfaengerLabel.Location = New System.Drawing.Point(11, 205)
        EmpfaengerLabel.Name = "EmpfaengerLabel"
        EmpfaengerLabel.Size = New System.Drawing.Size(78, 13)
        EmpfaengerLabel.TabIndex = 150
        EmpfaengerLabel.Text = "Empfaenger:"
        '
        'DokDatumLabel
        '
        DokDatumLabel.AutoSize = True
        DokDatumLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DokDatumLabel.Location = New System.Drawing.Point(11, 249)
        DokDatumLabel.Name = "DokDatumLabel"
        DokDatumLabel.Size = New System.Drawing.Size(74, 13)
        DokDatumLabel.TabIndex = 152
        DokDatumLabel.Text = "Dok Datum:"
        '
        'AufgenommenLabel
        '
        AufgenommenLabel.AutoSize = True
        AufgenommenLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AufgenommenLabel.Location = New System.Drawing.Point(205, 249)
        AufgenommenLabel.Name = "AufgenommenLabel"
        AufgenommenLabel.Size = New System.Drawing.Size(90, 13)
        AufgenommenLabel.TabIndex = 154
        AufgenommenLabel.Text = "Aufgenommen:"
        '
        'AblageLabel
        '
        AblageLabel.AutoSize = True
        AblageLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        AblageLabel.Location = New System.Drawing.Point(11, 359)
        AblageLabel.Name = "AblageLabel"
        AblageLabel.Size = New System.Drawing.Size(50, 13)
        AblageLabel.TabIndex = 158
        AblageLabel.Text = "Ablage:"
        '
        'GeaendertLabel
        '
        GeaendertLabel.AutoSize = True
        GeaendertLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        GeaendertLabel.Location = New System.Drawing.Point(422, 249)
        GeaendertLabel.Name = "GeaendertLabel"
        GeaendertLabel.Size = New System.Drawing.Size(63, 13)
        GeaendertLabel.TabIndex = 156
        GeaendertLabel.Text = "Geändert:"
        '
        'TypLabel
        '
        TypLabel.AutoSize = True
        TypLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TypLabel.Location = New System.Drawing.Point(11, 385)
        TypLabel.Name = "TypLabel"
        TypLabel.Size = New System.Drawing.Size(32, 13)
        TypLabel.TabIndex = 160
        TypLabel.Text = "Typ:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        StatusLabel.Location = New System.Drawing.Point(11, 411)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(47, 13)
        StatusLabel.TabIndex = 162
        StatusLabel.Text = "Status:"
        '
        'DokNameLabel
        '
        DokNameLabel.AutoSize = True
        DokNameLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DokNameLabel.Location = New System.Drawing.Point(11, 437)
        DokNameLabel.Name = "DokNameLabel"
        DokNameLabel.Size = New System.Drawing.Size(70, 13)
        DokNameLabel.TabIndex = 164
        DokNameLabel.Text = "Dok Name:"
        '
        'BearbVermerkLabel
        '
        BearbVermerkLabel.AutoSize = True
        BearbVermerkLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        BearbVermerkLabel.Location = New System.Drawing.Point(11, 474)
        BearbVermerkLabel.Name = "BearbVermerkLabel"
        BearbVermerkLabel.Size = New System.Drawing.Size(224, 13)
        BearbVermerkLabel.TabIndex = 166
        BearbVermerkLabel.Text = "Bearb. Vermerk/Kommentar/Mail-Text:"
        '
        'lblAnlage
        '
        Me.lblAnlage.AutoSize = True
        Me.lblAnlage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAnlage.Location = New System.Drawing.Point(422, 291)
        Me.lblAnlage.Name = "lblAnlage"
        Me.lblAnlage.Size = New System.Drawing.Size(53, 13)
        Me.lblAnlage.TabIndex = 171
        Me.lblAnlage.Text = "Anlagen"
        '
        'txtAz
        '
        Me.txtAz.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAz.Location = New System.Drawing.Point(84, 291)
        Me.txtAz.Name = "txtAz"
        Me.txtAz.Size = New System.Drawing.Size(325, 13)
        Me.txtAz.TabIndex = 170
        '
        'lbAz
        '
        Me.lbAz.AutoSize = True
        Me.lbAz.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbAz.Location = New System.Drawing.Point(11, 291)
        Me.lbAz.Name = "lbAz"
        Me.lbAz.Size = New System.Drawing.Size(54, 13)
        Me.lbAz.TabIndex = 169
        Me.lbAz.Text = "Aktenz.:"
        '
        'FdKommentarTextBox
        '
        Me.FdKommentarTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.FdKommentarTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Kommentar", True))
        Me.FdKommentarTextBox.Location = New System.Drawing.Point(14, 516)
        Me.FdKommentarTextBox.Multiline = True
        Me.FdKommentarTextBox.Name = "FdKommentarTextBox"
        Me.FdKommentarTextBox.Size = New System.Drawing.Size(634, 423)
        Me.FdKommentarTextBox.TabIndex = 168
        '
        'DokumenteBindingSource
        '
        Me.DokumenteBindingSource.DataMember = "Dokumente"
        '
        'MandantTextBox
        '
        Me.MandantTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MandantTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MandantBindingSource, "Mandant", True))
        Me.MandantTextBox.Location = New System.Drawing.Point(84, 122)
        Me.MandantTextBox.Name = "MandantTextBox"
        Me.MandantTextBox.Size = New System.Drawing.Size(104, 13)
        Me.MandantTextBox.TabIndex = 139
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        '
        'AkteTextBox
        '
        Me.AkteTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AkteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AktenBindingSource, "Akte", True))
        Me.AkteTextBox.Location = New System.Drawing.Point(243, 122)
        Me.AkteTextBox.Multiline = True
        Me.AkteTextBox.Name = "AkteTextBox"
        Me.AkteTextBox.Size = New System.Drawing.Size(166, 41)
        Me.AkteTextBox.TabIndex = 141
        '
        'AktenBindingSource
        '
        Me.AktenBindingSource.DataMember = "Akten"
        '
        'VorgangTextBox
        '
        Me.VorgangTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.VorgangTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VorgaengeBindingSource, "Vorgang", True))
        Me.VorgangTextBox.Location = New System.Drawing.Point(486, 122)
        Me.VorgangTextBox.Multiline = True
        Me.VorgangTextBox.Name = "VorgangTextBox"
        Me.VorgangTextBox.Size = New System.Drawing.Size(176, 41)
        Me.VorgangTextBox.TabIndex = 143
        '
        'VorgaengeBindingSource
        '
        Me.VorgaengeBindingSource.DataMember = "Vorgaenge"
        '
        'DokumentTextBox
        '
        Me.DokumentTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DokumentTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Dokument", True))
        Me.DokumentTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DokumentTextBox.Location = New System.Drawing.Point(14, 55)
        Me.DokumentTextBox.Name = "DokumentTextBox"
        Me.DokumentTextBox.Size = New System.Drawing.Size(650, 13)
        Me.DokumentTextBox.TabIndex = 144
        '
        'BetreffTextBox
        '
        Me.BetreffTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BetreffTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betreff", True))
        Me.BetreffTextBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BetreffTextBox.Location = New System.Drawing.Point(14, 90)
        Me.BetreffTextBox.Name = "BetreffTextBox"
        Me.BetreffTextBox.Size = New System.Drawing.Size(650, 13)
        Me.BetreffTextBox.TabIndex = 145
        '
        'BetragTextBox
        '
        Me.BetragTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BetragTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Betrag", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "C2"))
        Me.BetragTextBox.Location = New System.Drawing.Point(84, 327)
        Me.BetragTextBox.Name = "BetragTextBox"
        Me.BetragTextBox.Size = New System.Drawing.Size(104, 13)
        Me.BetragTextBox.TabIndex = 147
        '
        'AbsenderTextBox
        '
        Me.AbsenderTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AbsenderTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource, "Name_", True))
        Me.AbsenderTextBox.Location = New System.Drawing.Point(95, 176)
        Me.AbsenderTextBox.Name = "AbsenderTextBox"
        Me.AbsenderTextBox.Size = New System.Drawing.Size(567, 13)
        Me.AbsenderTextBox.TabIndex = 149
        '
        'AnschriftenBindingSource
        '
        Me.AnschriftenBindingSource.DataMember = "Anschriften"
        '
        'EmpfaengerTextBox
        '
        Me.EmpfaengerTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.EmpfaengerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AnschriftenBindingSource1, "Name_", True))
        Me.EmpfaengerTextBox.Location = New System.Drawing.Point(95, 205)
        Me.EmpfaengerTextBox.Name = "EmpfaengerTextBox"
        Me.EmpfaengerTextBox.Size = New System.Drawing.Size(566, 13)
        Me.EmpfaengerTextBox.TabIndex = 151
        '
        'AnschriftenBindingSource1
        '
        Me.AnschriftenBindingSource1.DataMember = "Anschriften"
        '
        'DokDatumTextBox
        '
        Me.DokDatumTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DokDatumTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokDatum", True))
        Me.DokDatumTextBox.Location = New System.Drawing.Point(84, 249)
        Me.DokDatumTextBox.Name = "DokDatumTextBox"
        Me.DokDatumTextBox.Size = New System.Drawing.Size(104, 13)
        Me.DokDatumTextBox.TabIndex = 153
        '
        'AufgenommenTextBox
        '
        Me.AufgenommenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AufgenommenTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Aufgenommen", True))
        Me.AufgenommenTextBox.Location = New System.Drawing.Point(305, 249)
        Me.AufgenommenTextBox.Name = "AufgenommenTextBox"
        Me.AufgenommenTextBox.Size = New System.Drawing.Size(104, 13)
        Me.AufgenommenTextBox.TabIndex = 155
        '
        'GeaendertTextBox
        '
        Me.GeaendertTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GeaendertTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "Geaendert", True))
        Me.GeaendertTextBox.Location = New System.Drawing.Point(491, 249)
        Me.GeaendertTextBox.Name = "GeaendertTextBox"
        Me.GeaendertTextBox.Size = New System.Drawing.Size(171, 13)
        Me.GeaendertTextBox.TabIndex = 157
        '
        'AblageTextBox
        '
        Me.AblageTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.AblageTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.AblageBindingSource, "Ablage", True))
        Me.AblageTextBox.Location = New System.Drawing.Point(84, 359)
        Me.AblageTextBox.Name = "AblageTextBox"
        Me.AblageTextBox.Size = New System.Drawing.Size(104, 13)
        Me.AblageTextBox.TabIndex = 159
        '
        'AblageBindingSource
        '
        Me.AblageBindingSource.DataMember = "Ablage"
        '
        'TypTextBox
        '
        Me.TypTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TypTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TypBindingSource, "Typ", True))
        Me.TypTextBox.Location = New System.Drawing.Point(84, 385)
        Me.TypTextBox.Name = "TypTextBox"
        Me.TypTextBox.Size = New System.Drawing.Size(104, 13)
        Me.TypTextBox.TabIndex = 161
        '
        'TypBindingSource
        '
        Me.TypBindingSource.DataMember = "Typ"
        '
        'StatusTextBox
        '
        Me.StatusTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.StatusTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.StatusBindingSource, "Status", True))
        Me.StatusTextBox.Location = New System.Drawing.Point(84, 411)
        Me.StatusTextBox.Name = "StatusTextBox"
        Me.StatusTextBox.Size = New System.Drawing.Size(104, 13)
        Me.StatusTextBox.TabIndex = 163
        '
        'StatusBindingSource
        '
        Me.StatusBindingSource.DataMember = "Status"
        '
        'DokNameTextBox
        '
        Me.DokNameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.DokNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "DokName", True))
        Me.DokNameTextBox.Location = New System.Drawing.Point(84, 437)
        Me.DokNameTextBox.Name = "DokNameTextBox"
        Me.DokNameTextBox.Size = New System.Drawing.Size(564, 13)
        Me.DokNameTextBox.TabIndex = 165
        '
        'BearbVermerkTextBox
        '
        Me.BearbVermerkTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.BearbVermerkTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.DokumenteBindingSource, "BearbVermerk", True))
        Me.BearbVermerkTextBox.Location = New System.Drawing.Point(14, 490)
        Me.BearbVermerkTextBox.Name = "BearbVermerkTextBox"
        Me.BearbVermerkTextBox.Size = New System.Drawing.Size(634, 13)
        Me.BearbVermerkTextBox.TabIndex = 167
        '
        'btPrint
        '
        Me.btPrint.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.btPrint.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btPrint.Location = New System.Drawing.Point(12, 12)
        Me.btPrint.Name = "btPrint"
        Me.btPrint.Size = New System.Drawing.Size(650, 37)
        Me.btPrint.TabIndex = 137
        Me.btPrint.Tag = "Zum Drucken bitte anklicken!"
        Me.btPrint.Text = "Drucken"
        Me.btPrint.UseVisualStyleBackColor = False
        '
        'PrintForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(669, 951)
        Me.Controls.Add(Me.lblAnlage)
        Me.Controls.Add(Me.txtAz)
        Me.Controls.Add(Me.lbAz)
        Me.Controls.Add(Me.FdKommentarTextBox)
        Me.Controls.Add(MandantLabel)
        Me.Controls.Add(Me.MandantTextBox)
        Me.Controls.Add(AkteLabel)
        Me.Controls.Add(Me.AkteTextBox)
        Me.Controls.Add(VorgangLabel)
        Me.Controls.Add(Me.VorgangTextBox)
        Me.Controls.Add(Me.DokumentTextBox)
        Me.Controls.Add(Me.BetreffTextBox)
        Me.Controls.Add(BetragLabel)
        Me.Controls.Add(Me.BetragTextBox)
        Me.Controls.Add(AbsenderLabel)
        Me.Controls.Add(Me.AbsenderTextBox)
        Me.Controls.Add(EmpfaengerLabel)
        Me.Controls.Add(Me.EmpfaengerTextBox)
        Me.Controls.Add(DokDatumLabel)
        Me.Controls.Add(Me.DokDatumTextBox)
        Me.Controls.Add(AufgenommenLabel)
        Me.Controls.Add(Me.AufgenommenTextBox)
        Me.Controls.Add(AblageLabel)
        Me.Controls.Add(GeaendertLabel)
        Me.Controls.Add(Me.GeaendertTextBox)
        Me.Controls.Add(Me.AblageTextBox)
        Me.Controls.Add(TypLabel)
        Me.Controls.Add(Me.TypTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusTextBox)
        Me.Controls.Add(DokNameLabel)
        Me.Controls.Add(Me.DokNameTextBox)
        Me.Controls.Add(BearbVermerkLabel)
        Me.Controls.Add(Me.BearbVermerkTextBox)
        Me.Controls.Add(Me.btPrint)
        Me.Name = "PrintForm"
        Me.Text = "PrintForm"
        CType(Me.DokumenteBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AktenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VorgaengeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AnschriftenBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AblageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TypBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StatusBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents VorgaengeBindingSource As BindingSource
    Friend WithEvents lblAnlage As Label
    Friend WithEvents txtAz As TextBox
    Friend WithEvents lbAz As Label
    Friend WithEvents FdKommentarTextBox As TextBox
    Friend WithEvents DokumenteBindingSource As BindingSource
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenBindingSource1 As BindingSource
    Friend WithEvents AktenBindingSource As BindingSource
    Friend WithEvents AblageBindingSource As BindingSource
    Friend WithEvents StatusBindingSource As BindingSource
    Friend WithEvents TypBindingSource As BindingSource
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents MandantTextBox As TextBox
    Friend WithEvents AkteTextBox As TextBox
    Friend WithEvents VorgangTextBox As TextBox
    Friend WithEvents DokumentTextBox As TextBox
    Friend WithEvents BetreffTextBox As TextBox
    Friend WithEvents BetragTextBox As TextBox
    Friend WithEvents AbsenderTextBox As TextBox
    Friend WithEvents EmpfaengerTextBox As TextBox
    Friend WithEvents DokDatumTextBox As TextBox
    Friend WithEvents AufgenommenTextBox As TextBox
    Friend WithEvents GeaendertTextBox As TextBox
    Friend WithEvents AblageTextBox As TextBox
    Friend WithEvents TypTextBox As TextBox
    Friend WithEvents StatusTextBox As TextBox
    Friend WithEvents DokNameTextBox As TextBox
    Friend WithEvents BearbVermerkTextBox As TextBox
    Friend WithEvents btPrint As Button
End Class
