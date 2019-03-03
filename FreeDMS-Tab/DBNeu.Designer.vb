<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DBNeu
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
        Me.lblErgeb = New System.Windows.Forms.Label()
        Me.btnFolderDialog = New System.Windows.Forms.Button()
        Me.lblFolderDialog = New System.Windows.Forms.Label()
        Me.lblPfad = New System.Windows.Forms.Label()
        Me.txtDBName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtNeu = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'lblErgeb
        '
        Me.lblErgeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblErgeb.Location = New System.Drawing.Point(58, 237)
        Me.lblErgeb.Name = "lblErgeb"
        Me.lblErgeb.Size = New System.Drawing.Size(358, 27)
        Me.lblErgeb.TabIndex = 15
        Me.lblErgeb.Text = "Pfad ausgewählt"
        '
        'btnFolderDialog
        '
        Me.btnFolderDialog.Location = New System.Drawing.Point(188, 183)
        Me.btnFolderDialog.Name = "btnFolderDialog"
        Me.btnFolderDialog.Size = New System.Drawing.Size(108, 23)
        Me.btnFolderDialog.TabIndex = 14
        Me.btnFolderDialog.Text = "Odner"
        Me.btnFolderDialog.UseVisualStyleBackColor = True
        '
        'lblFolderDialog
        '
        Me.lblFolderDialog.AutoSize = True
        Me.lblFolderDialog.Location = New System.Drawing.Point(58, 188)
        Me.lblFolderDialog.Name = "lblFolderDialog"
        Me.lblFolderDialog.Size = New System.Drawing.Size(105, 13)
        Me.lblFolderDialog.TabIndex = 13
        Me.lblFolderDialog.Text = "oder hier auswählen:"
        '
        'lblPfad
        '
        Me.lblPfad.AutoSize = True
        Me.lblPfad.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPfad.Location = New System.Drawing.Point(58, 151)
        Me.lblPfad.Name = "lblPfad"
        Me.lblPfad.Size = New System.Drawing.Size(103, 13)
        Me.lblPfad.TabIndex = 12
        Me.lblPfad.Text = "Pfad Anwendung"
        '
        'txtDBName
        '
        Me.txtDBName.Location = New System.Drawing.Point(227, 100)
        Me.txtDBName.Name = "txtDBName"
        Me.txtDBName.Size = New System.Drawing.Size(189, 20)
        Me.txtDBName.TabIndex = 11
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(58, 103)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(145, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Name der neuen Datenbank:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(48, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 16)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Es wird eine neue Datenbank für FreeDMS angelegt:"
        '
        'BtNeu
        '
        Me.BtNeu.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtNeu.Location = New System.Drawing.Point(143, 339)
        Me.BtNeu.Name = "BtNeu"
        Me.BtNeu.Size = New System.Drawing.Size(273, 40)
        Me.BtNeu.TabIndex = 8
        Me.BtNeu.Text = "OK, neue Datenbank anlegen"
        Me.BtNeu.UseVisualStyleBackColor = True
        '
        'DBNeu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(587, 450)
        Me.Controls.Add(Me.lblErgeb)
        Me.Controls.Add(Me.btnFolderDialog)
        Me.Controls.Add(Me.lblFolderDialog)
        Me.Controls.Add(Me.lblPfad)
        Me.Controls.Add(Me.txtDBName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BtNeu)
        Me.Name = "DBNeu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FreeDNS-Tab - Neue Datenbank hinzufügen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblErgeb As Label
    Friend WithEvents btnFolderDialog As Button
    Friend WithEvents lblFolderDialog As Label
    Friend WithEvents lblPfad As Label
    Friend WithEvents txtDBName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents BtNeu As Button
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
End Class
