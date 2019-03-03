Option Strict On
Imports System.IO
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Imports FreeDMS_Aux.FreeDMS.Aux
Public Class DBNeu
    Dim neuDBPath As String = ""
    Dim neuDB As String = ""
    Dim gd As New FreeDMS_Aux.FreeDMS.GrundDaten

    Private Sub DBNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblPfad.Visible = False
        lblFolderDialog.Visible = False
        lblErgeb.Visible = False
    End Sub

    Private Sub BtNeu_Click(sender As Object, e As EventArgs) Handles BtNeu.Click
        If MsgBox("Die neue Datenbank '" & neuDB & "' wird im Verzeichnis: " & neuDBPath & " angelegt.", vbYesNo) = vbNo Then Exit Sub
        If Not File.Exists(sAppPath & "FreeDMS-template.mdb") Then
            MsgBox("Bitte prüfen, ob die Datei 'FreeDMS-template.mdb' in Installationsverzeichnis vorhanden ist! ")
            Exit Sub
        End If
        If Directory.Exists(neuDBPath) Then
            FileCopy(sAppPath & "FreeDMS-template.mdb", neuDBPath & neuDB & ".mdb")
        Else
            MsgBox("Fehler! Bitte den neuen Pfad prüfen.")
        End If
        If File.Exists(neuDBPath & neuDB & ".mdb") Then
            MsgBox("Die neue Datenbank wurde installiert und kann verwendet werden" & vbCrLf & "Bitte passen Sie die Settings (Optionen) an." & vbCrLf & "Die Listen sind Vorbelegt und können nach Ihren Wünschen geändert werden. Sie dürfen aber nicht leer sein!!")
            ' als aktuelle DB eintragen und xml schreiben
            CurrDB = neuDBPath & neuDB & ".mdb"
            'freeDMSName = neuDBPath
            gd.TxtWriter()
            gd.XMLWriter()
            Me.Close()
        Else
            MsgBox("Fehler bei der Installation. Bitte versuchen Sie es noch einmal.")
            Exit Sub
        End If
    End Sub

    Private Sub btnFolderDialog_Click(sender As Object, e As EventArgs) Handles btnFolderDialog.Click
        lblPfad.Visible = False
        With FolderBrowserDialog1
            .ShowNewFolderButton = True
            If .ShowDialog = DialogResult.OK Then
                lblErgeb.Visible = True
                lblErgeb.Text = "Datenbank anlegen als: " & .SelectedPath & "\" & neuDB
                lblFolderDialog.Visible = True
                neuDBPath = .SelectedPath & "\"
            End If

        End With
    End Sub

    Private Sub txtDBName_TextChanged(sender As Object, e As EventArgs) Handles txtDBName.TextChanged
        lblPfad.Visible = True
        neuDB = "FreeDMS-" & txtDBName.Text
        lblPfad.Text = "Datenank '" & neuDB & "' im aktuellen Verzeichnis '" & sAppPath & "' anlegen?"
        neuDBPath = sAppPath
    End Sub
End Class