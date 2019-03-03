Option Strict On
Imports FreeDMS_Aux.FreeDMS.DbHandling
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Imports OpenPop.Pop3
Public Class Settings
    Dim xmlProvider As String = My.Application.Info.DirectoryPath & "\daten\provider.xml"
    ''' <summary>
    ''' Form laden und TableAdapter füllen
    ''' Maildaten (Provider, Name usw) laden aus
    ''' Aktuelle Datenbank laden
    ''' Voreinstellungen für Dateipfade laden/ändern
    ''' Voreinstellungen Mandant, Absender laden/ändern
    ''' Voreinstellung ob Outlook als Mail mit verwendet wird
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Settings_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        CheckBoxMails.Checked = mailAbrufStart

        If MandantBindingSource.Count <= 0 Then StartMandant = "1"
        If AnschriftenBindingSource.Count <= 0 Then StEmpfaenger = "1"
        lblAktPfad.Text = Application.StartupPath
        lblAktDB.Text = "Aktuelle Datenbank: " & vbCrLf & CurrDB 'My.Settings.LastDB
        TextBox1.Text = ArchivOrdner
        TextBox2.Text = InputOrdner
        If FlagOutlook = True Then
            CbOutlook.CheckState = CheckState.Checked
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox4.Text = MailInputOrdner
            TextBox5.Text = SettingOutlookArchiv
        Else
            CbOutlook.CheckState = CheckState.Unchecked
            TextBox4.Enabled = False
            TextBox5.Enabled = False
        End If

        If String.IsNullOrEmpty(StartMandant) Then
            cbStartMandant.Text = "Bitte auswählen"
        Else
            cbStartMandant.SelectedValue = CInt(StartMandant)
        End If
        If String.IsNullOrEmpty(StEmpfaenger) Then
            cbEmpfaenger.Text = "Bitte auswählen"
        Else
            cbEmpfaenger.SelectedValue = CInt(StEmpfaenger)
        End If
        LoadProvider()
    End Sub
    ''' <summary>
    ''' Providerdaten auslesen aus xml
    ''' </summary>
    Private Sub LoadProvider()
        If My.Computer.FileSystem.FileExists(xmlProvider) Then

            ProviderDataBase.ReadXml(xmlProvider)
        End If
    End Sub

    ''' <summary>
    ''' Änderungen speichern und Form schließen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtSaveClose.Click
        Dim myGD As New FreeDMS_Aux.FreeDMS.GrundDaten

        Dim dummy As Int16
        If checkOrdner(Label1.Text, TextBox1.Text) = True Then
            ArchivOrdner = TextBox1.Text
        Else
            Exit Sub
        End If
        If checkOrdner(Label2.Text, TextBox2.Text) = True Then
            InputOrdner = TextBox2.Text
        Else
            Exit Sub
        End If

        'Maildaten sichern
        Validate()
        ProviderBindingSource.EndEdit()
        ProviderDataBase.WriteXml(xmlProvider)
        'Weitere Einstellungen sichern
        mailAbrufStart = CBool(CheckBoxMails.CheckState)
        MailInputOrdner = TextBox4.Text
        SettingOutlookArchiv = TextBox5.Text
        StartMandant = If(IsNothing(cbStartMandant.SelectedValue), "1", cbStartMandant.SelectedValue.ToString)
        StEmpfaenger = If(IsNothing(cbEmpfaenger.SelectedValue), "1", cbEmpfaenger.SelectedValue.ToString)
        If CbOutlook.CheckState = CheckState.Checked Then
            FlagOutlook = True
        Else
            FlagOutlook = False
        End If
        myGD.ChkSettings()
        dummy = CShort(MsgBox("Änderungen wurden gespeichert und sind nach Neustart verfügbar!", vbOKCancel))
        If dummy = vbOK Then
            myGD.XMLWriter()
            Close()
        End If
    End Sub

    ''' <summary>
    ''' Eingestelle Ordner prüfen
    ''' </summary>
    ''' <param name="setting"></param>
    ''' <param name="ordner"></param>
    ''' <returns></returns>
    Private Function CheckOrdner(setting As String, ordner As String) As Boolean
        Dim erg As String = CType(vbYes, String)
        If System.IO.Directory.Exists(ordner) Then
            CheckOrdner = True
        Else
            erg = CType(MsgBox("Ordner " & setting & " existiert nicht! Bitte erstellen?", CType(vbOK, MsgBoxStyle), "Kein Ordner vorhanden"), String)
            CheckOrdner = False
        End If

        Return CheckOrdner
    End Function
    ''' <summary>
    ''' FolderDialog für Archiv-Ordner wählen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtArchiv_Click(sender As Object, e As EventArgs) Handles btArchiv.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox1.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    ''' <summary>
    ''' FolderDialog für ScanInput-Ornder wählen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtScanInput_Click(sender As Object, e As EventArgs) Handles btScanInput.Click
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            TextBox2.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub
    ''' <summary>
    ''' Outlook Eingangs und Archiv-Ordner (in Outlook!!) festlegen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub CbOutlook_CheckedChanged(sender As Object, e As EventArgs) Handles CbOutlook.CheckedChanged

        If CbOutlook.CheckState = CheckState.Checked Then
            TextBox4.Enabled = True
            TextBox5.Enabled = True
            TextBox4.Text = MailInputOrdner
            TextBox5.Text = SettingOutlookArchiv
        Else
            'CbOutlook.CheckState = CheckState.Unchecked
            TextBox4.Enabled = False
            TextBox5.Enabled = False
        End If
    End Sub

    Private Sub ChkMail_Click(sender As Object, e As EventArgs) Handles ChkMail.Click
        Dim ssl As Boolean = True
        Dim pop3Client As Pop3Client
        pop3Client = New Pop3Client()
        If SSLCheckBox.CheckState = CheckState.Unchecked Then ssl = False
        Try
            pop3Client.Connect(HostTextBox.Text, CInt(PortTextBox.Text), ssl)
            LbServer.Text = "Verinbung zum Server ok!"
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
        Try
            pop3Client.Authenticate(UserTextBox.Text, PasswordTextBox.Text, AuthenticationMethod.UsernameAndPassword)
            LbZugang.Text = "Zugangsdaten ok!"
        Catch ex As Exception
            MsgBox(ex.Message)
            Exit Sub
        End Try
    End Sub

    Private Sub ProviderDataGridView_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles ProviderDataGridView.CellClick
        If SSLTextBox.Text = "True" Then SSLCheckBox.CheckState = CheckState.Checked Else SSLCheckBox.CheckState = CheckState.Unchecked

        LbServer.Text = "Server"
        LbZugang.Text = "Zugangsdaten"
    End Sub

    Private Sub SSLCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles SSLCheckBox.CheckedChanged
        If SSLCheckBox.CheckState = CheckState.Checked Then SSLTextBox.Text = "true" Else SSLTextBox.Text = "false"
    End Sub
End Class