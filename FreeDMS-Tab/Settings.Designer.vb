<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Settings
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
        Dim NameLabel As System.Windows.Forms.Label
        Dim HostLabel As System.Windows.Forms.Label
        Dim UserLabel As System.Windows.Forms.Label
        Dim PasswordLabel As System.Windows.Forms.Label
        Dim PortLabel As System.Windows.Forms.Label
        Dim SSLLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Settings))
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.BtSaveClose = New System.Windows.Forms.Button()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.CbOutlook = New System.Windows.Forms.CheckBox()
        Me.LbOutlook = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CheckBoxMails = New System.Windows.Forms.CheckBox()
        Me.lblAktDB = New System.Windows.Forms.Label()
        Me.cbEmpfaenger = New System.Windows.Forms.ComboBox()
        Me.AnschriftenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me._FreeDMS_StartDBDataSet = New FreeDMS_Tab._FreeDMS_StartDBDataSet()
        Me.lblEmpfaenger = New System.Windows.Forms.Label()
        Me.lblStartMandant = New System.Windows.Forms.Label()
        Me.cbStartMandant = New System.Windows.Forms.ComboBox()
        Me.MandantBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btScanInput = New System.Windows.Forms.Button()
        Me.btArchiv = New System.Windows.Forms.Button()
        Me.lblAktPfad = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.BindingNavigator1 = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.ProviderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProviderDataBase = New FreeDMS_Tab.ProviderDataBase()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.IdTextBox = New System.Windows.Forms.TextBox()
        Me.NameTextBox = New System.Windows.Forms.TextBox()
        Me.HostTextBox = New System.Windows.Forms.TextBox()
        Me.UserTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.PortTextBox = New System.Windows.Forms.TextBox()
        Me.SSLCheckBox = New System.Windows.Forms.CheckBox()
        Me.ProviderDataGridView = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HostDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MandantTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter()
        Me.AnschriftenTableAdapter = New FreeDMS_Tab._FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.ChkMail = New System.Windows.Forms.Button()
        Me.LbServer = New System.Windows.Forms.Label()
        Me.LbZugang = New System.Windows.Forms.Label()
        Me.SSLTextBox = New System.Windows.Forms.TextBox()
        IdLabel = New System.Windows.Forms.Label()
        NameLabel = New System.Windows.Forms.Label()
        HostLabel = New System.Windows.Forms.Label()
        UserLabel = New System.Windows.Forms.Label()
        PasswordLabel = New System.Windows.Forms.Label()
        PortLabel = New System.Windows.Forms.Label()
        SSLLabel = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ProviderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProviderDataBase, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProviderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdLabel
        '
        IdLabel.AutoSize = True
        IdLabel.Location = New System.Drawing.Point(270, 55)
        IdLabel.Name = "IdLabel"
        IdLabel.Size = New System.Drawing.Size(18, 13)
        IdLabel.TabIndex = 1
        IdLabel.Text = "id:"
        '
        'NameLabel
        '
        NameLabel.AutoSize = True
        NameLabel.Location = New System.Drawing.Point(270, 81)
        NameLabel.Name = "NameLabel"
        NameLabel.Size = New System.Drawing.Size(38, 13)
        NameLabel.TabIndex = 3
        NameLabel.Text = "Name:"
        '
        'HostLabel
        '
        HostLabel.AutoSize = True
        HostLabel.Location = New System.Drawing.Point(270, 107)
        HostLabel.Name = "HostLabel"
        HostLabel.Size = New System.Drawing.Size(32, 13)
        HostLabel.TabIndex = 5
        HostLabel.Text = "Host:"
        '
        'UserLabel
        '
        UserLabel.AutoSize = True
        UserLabel.Location = New System.Drawing.Point(270, 133)
        UserLabel.Name = "UserLabel"
        UserLabel.Size = New System.Drawing.Size(32, 13)
        UserLabel.TabIndex = 7
        UserLabel.Text = "User:"
        '
        'PasswordLabel
        '
        PasswordLabel.AutoSize = True
        PasswordLabel.Location = New System.Drawing.Point(270, 159)
        PasswordLabel.Name = "PasswordLabel"
        PasswordLabel.Size = New System.Drawing.Size(56, 13)
        PasswordLabel.TabIndex = 9
        PasswordLabel.Text = "Password:"
        '
        'PortLabel
        '
        PortLabel.AutoSize = True
        PortLabel.Location = New System.Drawing.Point(270, 185)
        PortLabel.Name = "PortLabel"
        PortLabel.Size = New System.Drawing.Size(29, 13)
        PortLabel.TabIndex = 11
        PortLabel.Text = "Port:"
        '
        'SSLLabel
        '
        SSLLabel.AutoSize = True
        SSLLabel.Location = New System.Drawing.Point(270, 213)
        SSLLabel.Name = "SSLLabel"
        SSLLabel.Size = New System.Drawing.Size(30, 13)
        SSLLabel.TabIndex = 13
        SSLLabel.Text = "SSL:"
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.BtSaveClose, 0, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.TabControl1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.86928!))
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10.13072!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(517, 344)
        Me.TableLayoutPanel1.TabIndex = 3
        '
        'BtSaveClose
        '
        Me.BtSaveClose.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.BtSaveClose.Location = New System.Drawing.Point(189, 315)
        Me.BtSaveClose.Name = "BtSaveClose"
        Me.BtSaveClose.Size = New System.Drawing.Size(138, 23)
        Me.BtSaveClose.TabIndex = 1
        Me.BtSaveClose.Text = "Speichern und Schließen"
        Me.BtSaveClose.UseVisualStyleBackColor = True
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(3, 3)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(511, 303)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.CbOutlook)
        Me.TabPage2.Controls.Add(Me.LbOutlook)
        Me.TabPage2.Controls.Add(Me.Label6)
        Me.TabPage2.Controls.Add(Me.CheckBoxMails)
        Me.TabPage2.Controls.Add(Me.lblAktDB)
        Me.TabPage2.Controls.Add(Me.cbEmpfaenger)
        Me.TabPage2.Controls.Add(Me.lblEmpfaenger)
        Me.TabPage2.Controls.Add(Me.lblStartMandant)
        Me.TabPage2.Controls.Add(Me.cbStartMandant)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(497, 269)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Allg. Einstellungen"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'CbOutlook
        '
        Me.CbOutlook.AutoSize = True
        Me.CbOutlook.Location = New System.Drawing.Point(184, 134)
        Me.CbOutlook.Name = "CbOutlook"
        Me.CbOutlook.Size = New System.Drawing.Size(15, 14)
        Me.CbOutlook.TabIndex = 8
        Me.CbOutlook.UseVisualStyleBackColor = True
        '
        'LbOutlook
        '
        Me.LbOutlook.AutoSize = True
        Me.LbOutlook.Location = New System.Drawing.Point(27, 134)
        Me.LbOutlook.Name = "LbOutlook"
        Me.LbOutlook.Size = New System.Drawing.Size(79, 13)
        Me.LbOutlook.TabIndex = 7
        Me.LbOutlook.Text = "Outlook nutzen"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 114)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(120, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Mails beim Start abrufen"
        '
        'CheckBoxMails
        '
        Me.CheckBoxMails.AutoSize = True
        Me.CheckBoxMails.Location = New System.Drawing.Point(184, 114)
        Me.CheckBoxMails.Name = "CheckBoxMails"
        Me.CheckBoxMails.Size = New System.Drawing.Size(15, 14)
        Me.CheckBoxMails.TabIndex = 5
        Me.CheckBoxMails.UseVisualStyleBackColor = True
        '
        'lblAktDB
        '
        Me.lblAktDB.AutoSize = True
        Me.lblAktDB.Location = New System.Drawing.Point(27, 156)
        Me.lblAktDB.Name = "lblAktDB"
        Me.lblAktDB.Size = New System.Drawing.Size(101, 13)
        Me.lblAktDB.TabIndex = 4
        Me.lblAktDB.Text = "Aktuelle Datenbank"
        '
        'cbEmpfaenger
        '
        Me.cbEmpfaenger.DataSource = Me.AnschriftenBindingSource
        Me.cbEmpfaenger.DisplayMember = "Name_"
        Me.cbEmpfaenger.FormattingEnabled = True
        Me.cbEmpfaenger.Location = New System.Drawing.Point(184, 62)
        Me.cbEmpfaenger.Name = "cbEmpfaenger"
        Me.cbEmpfaenger.Size = New System.Drawing.Size(121, 21)
        Me.cbEmpfaenger.TabIndex = 3
        Me.cbEmpfaenger.ValueMember = "id"
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
        'lblEmpfaenger
        '
        Me.lblEmpfaenger.AutoSize = True
        Me.lblEmpfaenger.Location = New System.Drawing.Point(27, 62)
        Me.lblEmpfaenger.Name = "lblEmpfaenger"
        Me.lblEmpfaenger.Size = New System.Drawing.Size(137, 39)
        Me.lblEmpfaenger.TabIndex = 2
        Me.lblEmpfaenger.Text = "Empfänger" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(wird als Voreinstellung " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "beim ScanInput verwendet)"
        '
        'lblStartMandant
        '
        Me.lblStartMandant.AutoSize = True
        Me.lblStartMandant.Location = New System.Drawing.Point(27, 25)
        Me.lblStartMandant.Name = "lblStartMandant"
        Me.lblStartMandant.Size = New System.Drawing.Size(96, 13)
        Me.lblStartMandant.TabIndex = 1
        Me.lblStartMandant.Text = "Starten mit Bereich"
        '
        'cbStartMandant
        '
        Me.cbStartMandant.DataSource = Me.MandantBindingSource
        Me.cbStartMandant.DisplayMember = "Mandant"
        Me.cbStartMandant.FormattingEnabled = True
        Me.cbStartMandant.Location = New System.Drawing.Point(184, 22)
        Me.cbStartMandant.Name = "cbStartMandant"
        Me.cbStartMandant.Size = New System.Drawing.Size(121, 21)
        Me.cbStartMandant.TabIndex = 0
        Me.cbStartMandant.ValueMember = "id"
        '
        'MandantBindingSource
        '
        Me.MandantBindingSource.DataMember = "Mandant"
        Me.MandantBindingSource.DataSource = Me._FreeDMS_StartDBDataSet
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.Panel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(497, 269)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Pfade"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btScanInput)
        Me.Panel1.Controls.Add(Me.btArchiv)
        Me.Panel1.Controls.Add(Me.lblAktPfad)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.TextBox5)
        Me.Panel1.Controls.Add(Me.TextBox4)
        Me.Panel1.Controls.Add(Me.TextBox2)
        Me.Panel1.Controls.Add(Me.TextBox1)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(3, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(491, 263)
        Me.Panel1.TabIndex = 0
        '
        'btScanInput
        '
        Me.btScanInput.Image = CType(resources.GetObject("btScanInput.Image"), System.Drawing.Image)
        Me.btScanInput.Location = New System.Drawing.Point(415, 75)
        Me.btScanInput.Name = "btScanInput"
        Me.btScanInput.Size = New System.Drawing.Size(58, 23)
        Me.btScanInput.TabIndex = 13
        Me.btScanInput.UseVisualStyleBackColor = True
        '
        'btArchiv
        '
        Me.btArchiv.Image = CType(resources.GetObject("btArchiv.Image"), System.Drawing.Image)
        Me.btArchiv.Location = New System.Drawing.Point(415, 38)
        Me.btArchiv.Name = "btArchiv"
        Me.btArchiv.Size = New System.Drawing.Size(58, 23)
        Me.btArchiv.TabIndex = 13
        Me.btArchiv.UseVisualStyleBackColor = True
        '
        'lblAktPfad
        '
        Me.lblAktPfad.AutoSize = True
        Me.lblAktPfad.Location = New System.Drawing.Point(9, 6)
        Me.lblAktPfad.Name = "lblAktPfad"
        Me.lblAktPfad.Size = New System.Drawing.Size(73, 13)
        Me.lblAktPfad.TabIndex = 12
        Me.lblAktPfad.Text = "Aktueller Pfad"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(92, 26)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Ordner Postarchiv" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in Outlook)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(11, 114)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 26)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Ordner Posteingang" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(in Outlook)"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Ordner Scan-Input"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(11, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(72, 13)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Archiv-Ordner"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(147, 150)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(262, 20)
        Me.TextBox5.TabIndex = 7
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(147, 114)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(262, 20)
        Me.TextBox4.TabIndex = 7
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(147, 77)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(262, 20)
        Me.TextBox2.TabIndex = 7
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(147, 40)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(262, 20)
        Me.TextBox1.TabIndex = 6
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.SSLTextBox)
        Me.TabPage3.Controls.Add(Me.LbZugang)
        Me.TabPage3.Controls.Add(Me.LbServer)
        Me.TabPage3.Controls.Add(Me.ChkMail)
        Me.TabPage3.Controls.Add(Me.BindingNavigator1)
        Me.TabPage3.Controls.Add(IdLabel)
        Me.TabPage3.Controls.Add(Me.IdTextBox)
        Me.TabPage3.Controls.Add(NameLabel)
        Me.TabPage3.Controls.Add(Me.NameTextBox)
        Me.TabPage3.Controls.Add(HostLabel)
        Me.TabPage3.Controls.Add(Me.HostTextBox)
        Me.TabPage3.Controls.Add(UserLabel)
        Me.TabPage3.Controls.Add(Me.UserTextBox)
        Me.TabPage3.Controls.Add(PasswordLabel)
        Me.TabPage3.Controls.Add(Me.PasswordTextBox)
        Me.TabPage3.Controls.Add(PortLabel)
        Me.TabPage3.Controls.Add(Me.PortTextBox)
        Me.TabPage3.Controls.Add(SSLLabel)
        Me.TabPage3.Controls.Add(Me.SSLCheckBox)
        Me.TabPage3.Controls.Add(Me.ProviderDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(503, 277)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Mail-Einstellungen"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.BindingNavigator1.BindingSource = Me.ProviderBindingSource
        Me.BindingNavigator1.CountItem = Me.BindingNavigatorCountItem
        Me.BindingNavigator1.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.BindingNavigator1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem})
        Me.BindingNavigator1.Location = New System.Drawing.Point(3, 3)
        Me.BindingNavigator1.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.BindingNavigator1.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.BindingNavigator1.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.BindingNavigator1.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.BindingNavigatorPositionItem
        Me.BindingNavigator1.Size = New System.Drawing.Size(497, 25)
        Me.BindingNavigator1.TabIndex = 15
        Me.BindingNavigator1.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'ProviderBindingSource
        '
        Me.ProviderBindingSource.DataMember = "Provider"
        Me.ProviderBindingSource.DataSource = Me.ProviderDataBase
        '
        'ProviderDataBase
        '
        Me.ProviderDataBase.DataSetName = "ProviderDataBase"
        Me.ProviderDataBase.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(44, 22)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'IdTextBox
        '
        Me.IdTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.IdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "id", True))
        Me.IdTextBox.Location = New System.Drawing.Point(332, 52)
        Me.IdTextBox.Name = "IdTextBox"
        Me.IdTextBox.ReadOnly = True
        Me.IdTextBox.Size = New System.Drawing.Size(104, 13)
        Me.IdTextBox.TabIndex = 2
        '
        'NameTextBox
        '
        Me.NameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "Name", True))
        Me.NameTextBox.Location = New System.Drawing.Point(332, 78)
        Me.NameTextBox.Name = "NameTextBox"
        Me.NameTextBox.Size = New System.Drawing.Size(158, 20)
        Me.NameTextBox.TabIndex = 4
        '
        'HostTextBox
        '
        Me.HostTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "Host", True))
        Me.HostTextBox.Location = New System.Drawing.Point(332, 104)
        Me.HostTextBox.Name = "HostTextBox"
        Me.HostTextBox.Size = New System.Drawing.Size(158, 20)
        Me.HostTextBox.TabIndex = 6
        '
        'UserTextBox
        '
        Me.UserTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "User", True))
        Me.UserTextBox.Location = New System.Drawing.Point(332, 130)
        Me.UserTextBox.Name = "UserTextBox"
        Me.UserTextBox.Size = New System.Drawing.Size(158, 20)
        Me.UserTextBox.TabIndex = 8
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "Password", True))
        Me.PasswordTextBox.Location = New System.Drawing.Point(332, 156)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.Size = New System.Drawing.Size(158, 20)
        Me.PasswordTextBox.TabIndex = 10
        '
        'PortTextBox
        '
        Me.PortTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "Port", True))
        Me.PortTextBox.Location = New System.Drawing.Point(332, 182)
        Me.PortTextBox.Name = "PortTextBox"
        Me.PortTextBox.Size = New System.Drawing.Size(53, 20)
        Me.PortTextBox.TabIndex = 12
        '
        'SSLCheckBox
        '
        Me.SSLCheckBox.Location = New System.Drawing.Point(332, 208)
        Me.SSLCheckBox.Name = "SSLCheckBox"
        Me.SSLCheckBox.Size = New System.Drawing.Size(21, 24)
        Me.SSLCheckBox.TabIndex = 14
        Me.SSLCheckBox.UseVisualStyleBackColor = True
        '
        'ProviderDataGridView
        '
        Me.ProviderDataGridView.AutoGenerateColumns = False
        Me.ProviderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProviderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.HostDataGridViewTextBoxColumn})
        Me.ProviderDataGridView.DataSource = Me.ProviderBindingSource
        Me.ProviderDataGridView.Location = New System.Drawing.Point(3, 47)
        Me.ProviderDataGridView.Name = "ProviderDataGridView"
        Me.ProviderDataGridView.Size = New System.Drawing.Size(255, 187)
        Me.ProviderDataGridView.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        Me.NameDataGridViewTextBoxColumn.Width = 60
        '
        'HostDataGridViewTextBoxColumn
        '
        Me.HostDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.HostDataGridViewTextBoxColumn.DataPropertyName = "Host"
        Me.HostDataGridViewTextBoxColumn.HeaderText = "Host"
        Me.HostDataGridViewTextBoxColumn.Name = "HostDataGridViewTextBoxColumn"
        '
        'MandantTableAdapter
        '
        Me.MandantTableAdapter.ClearBeforeFill = True
        '
        'AnschriftenTableAdapter
        '
        Me.AnschriftenTableAdapter.ClearBeforeFill = True
        '
        'ChkMail
        '
        Me.ChkMail.Location = New System.Drawing.Point(408, 204)
        Me.ChkMail.Name = "ChkMail"
        Me.ChkMail.Size = New System.Drawing.Size(82, 30)
        Me.ChkMail.TabIndex = 16
        Me.ChkMail.Text = "Test"
        Me.ChkMail.UseVisualStyleBackColor = True
        '
        'LbServer
        '
        Me.LbServer.AutoSize = True
        Me.LbServer.Location = New System.Drawing.Point(270, 238)
        Me.LbServer.Name = "LbServer"
        Me.LbServer.Size = New System.Drawing.Size(38, 13)
        Me.LbServer.TabIndex = 17
        Me.LbServer.Text = "Server"
        '
        'LbZugang
        '
        Me.LbZugang.AutoSize = True
        Me.LbZugang.Location = New System.Drawing.Point(270, 261)
        Me.LbZugang.Name = "LbZugang"
        Me.LbZugang.Size = New System.Drawing.Size(44, 13)
        Me.LbZugang.TabIndex = 18
        Me.LbZugang.Text = "Zugang"
        '
        'SSLTextBox
        '
        Me.SSLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProviderBindingSource, "SSL", True))
        Me.SSLTextBox.Location = New System.Drawing.Point(351, 209)
        Me.SSLTextBox.Name = "SSLTextBox"
        Me.SSLTextBox.Size = New System.Drawing.Size(46, 20)
        Me.SSLTextBox.TabIndex = 20
        '
        'Settings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(517, 344)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Name = "Settings"
        Me.Text = "FreeDMS-Tab - Settings"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.AnschriftenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._FreeDMS_StartDBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MandantBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.BindingNavigator1.PerformLayout()
        CType(Me.ProviderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProviderDataBase, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProviderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents BtSaveClose As Button
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents CbOutlook As CheckBox
    Friend WithEvents LbOutlook As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents CheckBoxMails As CheckBox
    Friend WithEvents lblAktDB As Label
    Friend WithEvents cbEmpfaenger As ComboBox
    Friend WithEvents lblEmpfaenger As Label
    Friend WithEvents lblStartMandant As Label
    Friend WithEvents cbStartMandant As ComboBox
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btScanInput As Button
    Friend WithEvents btArchiv As Button
    Friend WithEvents lblAktPfad As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox5 As TextBox
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents IdTextBox As TextBox
    Friend WithEvents NameTextBox As TextBox
    Friend WithEvents HostTextBox As TextBox
    Friend WithEvents UserTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents PortTextBox As TextBox
    Friend WithEvents SSLCheckBox As CheckBox
    Friend WithEvents ProviderDataGridView As DataGridView
    Friend WithEvents _FreeDMS_StartDBDataSet As _FreeDMS_StartDBDataSet
    Friend WithEvents MandantBindingSource As BindingSource
    Friend WithEvents MandantTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.MandantTableAdapter
    Friend WithEvents AnschriftenBindingSource As BindingSource
    Friend WithEvents AnschriftenTableAdapter As _FreeDMS_StartDBDataSetTableAdapters.AnschriftenTableAdapter
    Friend WithEvents ProviderBindingSource As BindingSource
    Friend WithEvents ProviderDataBase As ProviderDataBase
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents HostDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents ChkMail As Button
    Friend WithEvents LbZugang As Label
    Friend WithEvents LbServer As Label
    Friend WithEvents SSLTextBox As TextBox
End Class
