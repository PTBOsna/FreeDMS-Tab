<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.ToolStripContainer1 = New System.Windows.Forms.ToolStripContainer()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernunterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DruckenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeitenansichtToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RückgängigToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WiederholenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KopierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EinfügenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.AlleauswählenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtrasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnpassenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OptionenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HilfeToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InhaltToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SuchenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.toolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.InfoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NeuToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ÖffnenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.SpeichernToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DruckenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator6 = New System.Windows.Forms.ToolStripSeparator()
        Me.AusschneidenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.KopierenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EinfügenToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.toolStripSeparator7 = New System.Windows.Forms.ToolStripSeparator()
        Me.HilfeToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolStripContainer1.ContentPanel.SuspendLayout()
        Me.ToolStripContainer1.TopToolStripPanel.SuspendLayout()
        Me.ToolStripContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStripContainer1
        '
        '
        'ToolStripContainer1.ContentPanel
        '
        Me.ToolStripContainer1.ContentPanel.Controls.Add(Me.TabControl1)
        Me.ToolStripContainer1.ContentPanel.Size = New System.Drawing.Size(917, 445)
        Me.ToolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ToolStripContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStripContainer1.Name = "ToolStripContainer1"
        Me.ToolStripContainer1.Size = New System.Drawing.Size(917, 494)
        Me.ToolStripContainer1.TabIndex = 0
        Me.ToolStripContainer1.Text = "ToolStripContainer1"
        '
        'ToolStripContainer1.TopToolStripPanel
        '
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.MenuStrip1)
        Me.ToolStripContainer1.TopToolStripPanel.Controls.Add(Me.ToolStrip1)
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.BearbeitenToolStripMenuItem, Me.ExtrasToolStripMenuItem, Me.HilfeToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(917, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripMenuItem, Me.ÖffnenToolStripMenuItem, Me.toolStripSeparator, Me.SpeichernToolStripMenuItem, Me.SpeichernunterToolStripMenuItem, Me.toolStripSeparator1, Me.DruckenToolStripMenuItem, Me.SeitenansichtToolStripMenuItem, Me.toolStripSeparator2, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "&Datei"
        '
        'NeuToolStripMenuItem
        '
        Me.NeuToolStripMenuItem.Image = CType(resources.GetObject("NeuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NeuToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripMenuItem.Name = "NeuToolStripMenuItem"
        Me.NeuToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.N), System.Windows.Forms.Keys)
        Me.NeuToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.NeuToolStripMenuItem.Text = "&Neu"
        '
        'ÖffnenToolStripMenuItem
        '
        Me.ÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripMenuItem.Name = "ÖffnenToolStripMenuItem"
        Me.ÖffnenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.ÖffnenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ÖffnenToolStripMenuItem.Text = "Ö&ffnen"
        '
        'toolStripSeparator
        '
        Me.toolStripSeparator.Name = "toolStripSeparator"
        Me.toolStripSeparator.Size = New System.Drawing.Size(177, 6)
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Image = CType(resources.GetObject("SpeichernToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpeichernToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.S), System.Windows.Forms.Keys)
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SpeichernToolStripMenuItem.Text = "&Speichern"
        '
        'SpeichernunterToolStripMenuItem
        '
        Me.SpeichernunterToolStripMenuItem.Name = "SpeichernunterToolStripMenuItem"
        Me.SpeichernunterToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SpeichernunterToolStripMenuItem.Text = "Speichern &unter"
        '
        'toolStripSeparator1
        '
        Me.toolStripSeparator1.Name = "toolStripSeparator1"
        Me.toolStripSeparator1.Size = New System.Drawing.Size(177, 6)
        '
        'DruckenToolStripMenuItem
        '
        Me.DruckenToolStripMenuItem.Image = CType(resources.GetObject("DruckenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DruckenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripMenuItem.Name = "DruckenToolStripMenuItem"
        Me.DruckenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.DruckenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DruckenToolStripMenuItem.Text = "&Drucken"
        '
        'SeitenansichtToolStripMenuItem
        '
        Me.SeitenansichtToolStripMenuItem.Image = CType(resources.GetObject("SeitenansichtToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SeitenansichtToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SeitenansichtToolStripMenuItem.Name = "SeitenansichtToolStripMenuItem"
        Me.SeitenansichtToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SeitenansichtToolStripMenuItem.Text = "&Seitenansicht"
        '
        'toolStripSeparator2
        '
        Me.toolStripSeparator2.Name = "toolStripSeparator2"
        Me.toolStripSeparator2.Size = New System.Drawing.Size(177, 6)
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BeendenToolStripMenuItem.Text = "&Beenden"
        '
        'BearbeitenToolStripMenuItem
        '
        Me.BearbeitenToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RückgängigToolStripMenuItem, Me.WiederholenToolStripMenuItem, Me.toolStripSeparator3, Me.AusschneidenToolStripMenuItem, Me.KopierenToolStripMenuItem, Me.EinfügenToolStripMenuItem, Me.toolStripSeparator4, Me.AlleauswählenToolStripMenuItem})
        Me.BearbeitenToolStripMenuItem.Name = "BearbeitenToolStripMenuItem"
        Me.BearbeitenToolStripMenuItem.Size = New System.Drawing.Size(75, 20)
        Me.BearbeitenToolStripMenuItem.Text = "&Bearbeiten"
        '
        'RückgängigToolStripMenuItem
        '
        Me.RückgängigToolStripMenuItem.Name = "RückgängigToolStripMenuItem"
        Me.RückgängigToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Z), System.Windows.Forms.Keys)
        Me.RückgängigToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.RückgängigToolStripMenuItem.Text = "&Rückgängig"
        '
        'WiederholenToolStripMenuItem
        '
        Me.WiederholenToolStripMenuItem.Name = "WiederholenToolStripMenuItem"
        Me.WiederholenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.Y), System.Windows.Forms.Keys)
        Me.WiederholenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.WiederholenToolStripMenuItem.Text = "Wiede&rholen"
        '
        'toolStripSeparator3
        '
        Me.toolStripSeparator3.Name = "toolStripSeparator3"
        Me.toolStripSeparator3.Size = New System.Drawing.Size(6, 6)
        '
        'AusschneidenToolStripMenuItem
        '
        Me.AusschneidenToolStripMenuItem.Image = CType(resources.GetObject("AusschneidenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripMenuItem.Name = "AusschneidenToolStripMenuItem"
        Me.AusschneidenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.X), System.Windows.Forms.Keys)
        Me.AusschneidenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.AusschneidenToolStripMenuItem.Text = "&Ausschneiden"
        '
        'KopierenToolStripMenuItem
        '
        Me.KopierenToolStripMenuItem.Image = CType(resources.GetObject("KopierenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.KopierenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripMenuItem.Name = "KopierenToolStripMenuItem"
        Me.KopierenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.C), System.Windows.Forms.Keys)
        Me.KopierenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.KopierenToolStripMenuItem.Text = "&Kopieren"
        '
        'EinfügenToolStripMenuItem
        '
        Me.EinfügenToolStripMenuItem.Image = CType(resources.GetObject("EinfügenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.EinfügenToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripMenuItem.Name = "EinfügenToolStripMenuItem"
        Me.EinfügenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.V), System.Windows.Forms.Keys)
        Me.EinfügenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.EinfügenToolStripMenuItem.Text = "&Einfügen"
        '
        'toolStripSeparator4
        '
        Me.toolStripSeparator4.Name = "toolStripSeparator4"
        Me.toolStripSeparator4.Size = New System.Drawing.Size(6, 6)
        '
        'AlleauswählenToolStripMenuItem
        '
        Me.AlleauswählenToolStripMenuItem.Name = "AlleauswählenToolStripMenuItem"
        Me.AlleauswählenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.AlleauswählenToolStripMenuItem.Text = "&Alle auswählen"
        '
        'ExtrasToolStripMenuItem
        '
        Me.ExtrasToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AnpassenToolStripMenuItem, Me.OptionenToolStripMenuItem})
        Me.ExtrasToolStripMenuItem.Name = "ExtrasToolStripMenuItem"
        Me.ExtrasToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.ExtrasToolStripMenuItem.Text = "E&xtras"
        '
        'AnpassenToolStripMenuItem
        '
        Me.AnpassenToolStripMenuItem.Name = "AnpassenToolStripMenuItem"
        Me.AnpassenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.AnpassenToolStripMenuItem.Text = "&Anpassen"
        '
        'OptionenToolStripMenuItem
        '
        Me.OptionenToolStripMenuItem.Name = "OptionenToolStripMenuItem"
        Me.OptionenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.OptionenToolStripMenuItem.Text = "&Optionen"
        '
        'HilfeToolStripMenuItem
        '
        Me.HilfeToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InhaltToolStripMenuItem, Me.IndexToolStripMenuItem, Me.SuchenToolStripMenuItem, Me.toolStripSeparator5, Me.InfoToolStripMenuItem})
        Me.HilfeToolStripMenuItem.Name = "HilfeToolStripMenuItem"
        Me.HilfeToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.HilfeToolStripMenuItem.Text = "&Hilfe"
        '
        'InhaltToolStripMenuItem
        '
        Me.InhaltToolStripMenuItem.Name = "InhaltToolStripMenuItem"
        Me.InhaltToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.InhaltToolStripMenuItem.Text = "I&nhalt"
        '
        'IndexToolStripMenuItem
        '
        Me.IndexToolStripMenuItem.Name = "IndexToolStripMenuItem"
        Me.IndexToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.IndexToolStripMenuItem.Text = "&Index"
        '
        'SuchenToolStripMenuItem
        '
        Me.SuchenToolStripMenuItem.Name = "SuchenToolStripMenuItem"
        Me.SuchenToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.SuchenToolStripMenuItem.Text = "&Suchen"
        '
        'toolStripSeparator5
        '
        Me.toolStripSeparator5.Name = "toolStripSeparator5"
        Me.toolStripSeparator5.Size = New System.Drawing.Size(6, 6)
        '
        'InfoToolStripMenuItem
        '
        Me.InfoToolStripMenuItem.Name = "InfoToolStripMenuItem"
        Me.InfoToolStripMenuItem.Size = New System.Drawing.Size(32, 19)
        Me.InfoToolStripMenuItem.Text = "Inf&o..."
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NeuToolStripButton, Me.ÖffnenToolStripButton, Me.SpeichernToolStripButton, Me.DruckenToolStripButton, Me.toolStripSeparator6, Me.AusschneidenToolStripButton, Me.KopierenToolStripButton, Me.EinfügenToolStripButton, Me.toolStripSeparator7, Me.HilfeToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(208, 25)
        Me.ToolStrip1.TabIndex = 1
        '
        'NeuToolStripButton
        '
        Me.NeuToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NeuToolStripButton.Image = CType(resources.GetObject("NeuToolStripButton.Image"), System.Drawing.Image)
        Me.NeuToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NeuToolStripButton.Name = "NeuToolStripButton"
        Me.NeuToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NeuToolStripButton.Text = "&Neu"
        '
        'ÖffnenToolStripButton
        '
        Me.ÖffnenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ÖffnenToolStripButton.Image = CType(resources.GetObject("ÖffnenToolStripButton.Image"), System.Drawing.Image)
        Me.ÖffnenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ÖffnenToolStripButton.Name = "ÖffnenToolStripButton"
        Me.ÖffnenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.ÖffnenToolStripButton.Text = "Ö&ffnen"
        '
        'SpeichernToolStripButton
        '
        Me.SpeichernToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SpeichernToolStripButton.Image = CType(resources.GetObject("SpeichernToolStripButton.Image"), System.Drawing.Image)
        Me.SpeichernToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SpeichernToolStripButton.Name = "SpeichernToolStripButton"
        Me.SpeichernToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SpeichernToolStripButton.Text = "&Speichern"
        '
        'DruckenToolStripButton
        '
        Me.DruckenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DruckenToolStripButton.Image = CType(resources.GetObject("DruckenToolStripButton.Image"), System.Drawing.Image)
        Me.DruckenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DruckenToolStripButton.Name = "DruckenToolStripButton"
        Me.DruckenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.DruckenToolStripButton.Text = "&Drucken"
        '
        'toolStripSeparator6
        '
        Me.toolStripSeparator6.Name = "toolStripSeparator6"
        Me.toolStripSeparator6.Size = New System.Drawing.Size(6, 25)
        '
        'AusschneidenToolStripButton
        '
        Me.AusschneidenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AusschneidenToolStripButton.Image = CType(resources.GetObject("AusschneidenToolStripButton.Image"), System.Drawing.Image)
        Me.AusschneidenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AusschneidenToolStripButton.Name = "AusschneidenToolStripButton"
        Me.AusschneidenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.AusschneidenToolStripButton.Text = "&Ausschneiden"
        '
        'KopierenToolStripButton
        '
        Me.KopierenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.KopierenToolStripButton.Image = CType(resources.GetObject("KopierenToolStripButton.Image"), System.Drawing.Image)
        Me.KopierenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.KopierenToolStripButton.Name = "KopierenToolStripButton"
        Me.KopierenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.KopierenToolStripButton.Text = "&Kopieren"
        '
        'EinfügenToolStripButton
        '
        Me.EinfügenToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EinfügenToolStripButton.Image = CType(resources.GetObject("EinfügenToolStripButton.Image"), System.Drawing.Image)
        Me.EinfügenToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.EinfügenToolStripButton.Name = "EinfügenToolStripButton"
        Me.EinfügenToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.EinfügenToolStripButton.Text = "&Einfügen"
        '
        'toolStripSeparator7
        '
        Me.toolStripSeparator7.Name = "toolStripSeparator7"
        Me.toolStripSeparator7.Size = New System.Drawing.Size(6, 25)
        '
        'HilfeToolStripButton
        '
        Me.HilfeToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.HilfeToolStripButton.Image = CType(resources.GetObject("HilfeToolStripButton.Image"), System.Drawing.Image)
        Me.HilfeToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.HilfeToolStripButton.Name = "HilfeToolStripButton"
        Me.HilfeToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.HilfeToolStripButton.Text = "Hi&lfe"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(917, 445)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(909, 419)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(192, 74)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Start
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(917, 494)
        Me.Controls.Add(Me.ToolStripContainer1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Start"
        Me.Text = "Start"
        Me.ToolStripContainer1.ContentPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.ResumeLayout(False)
        Me.ToolStripContainer1.TopToolStripPanel.PerformLayout()
        Me.ToolStripContainer1.ResumeLayout(False)
        Me.ToolStripContainer1.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStripContainer1 As Windows.Forms.ToolStripContainer
    Friend WithEvents TabControl1 As Windows.Forms.TabControl
    Friend WithEvents TabPage1 As Windows.Forms.TabPage
    Friend WithEvents TabPage2 As Windows.Forms.TabPage
    Friend WithEvents MenuStrip1 As Windows.Forms.MenuStrip
    Friend WithEvents DateiToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents NeuToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ÖffnenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator As Windows.Forms.ToolStripSeparator
    Friend WithEvents SpeichernToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SpeichernunterToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator1 As Windows.Forms.ToolStripSeparator
    Friend WithEvents DruckenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SeitenansichtToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator2 As Windows.Forms.ToolStripSeparator
    Friend WithEvents BeendenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents BearbeitenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents RückgängigToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents WiederholenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator3 As Windows.Forms.ToolStripSeparator
    Friend WithEvents AusschneidenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents KopierenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents EinfügenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator4 As Windows.Forms.ToolStripSeparator
    Friend WithEvents AlleauswählenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExtrasToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents AnpassenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents OptionenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents HilfeToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents InhaltToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents SuchenToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents toolStripSeparator5 As Windows.Forms.ToolStripSeparator
    Friend WithEvents InfoToolStripMenuItem As Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStrip1 As Windows.Forms.ToolStrip
    Friend WithEvents NeuToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents ÖffnenToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents SpeichernToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents DruckenToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator6 As Windows.Forms.ToolStripSeparator
    Friend WithEvents AusschneidenToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents KopierenToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents EinfügenToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents toolStripSeparator7 As Windows.Forms.ToolStripSeparator
    Friend WithEvents HilfeToolStripButton As Windows.Forms.ToolStripButton
    Friend WithEvents OpenFileDialog1 As Windows.Forms.OpenFileDialog
End Class
