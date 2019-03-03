Imports System.Data.OleDb
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Public Class Form1
    Dim dbName As String


    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        Dim dummy As String = ""
        With OpenFileDialog1
            '.Filter = "Access-Dateien (*.mdb)|*.mdb|All files (*.*)|*.*"
            .Filter = "FreeDMS (FreeDMS*.mdb)|FreeDMS*.mdb"
            .InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory
            .FileName = ""
            .ShowDialog()
            If String.IsNullOrEmpty(.FileName) Then Exit Sub
            dbName = .FileName
            ' SelectDB(dbName)
        End With
        LoadAll()
    End Sub


    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Ablage". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AblageTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Ablage)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.wiedervorlage". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.WiedervorlageTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.wiedervorlage)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.notiz". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.NotizTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.notiz)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Vorlagen". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.VorlagenTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Vorlagen)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Status". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.StatusTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Status)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Typ". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.TypTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Typ)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Anlagen". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AnlagenTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Anlagen)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Anschriften". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AnschriftenTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Anschriften)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Dokumente". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.DokumenteTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Dokumente)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Dokumente". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.DokumenteTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Dokumente)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Vorgaenge". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.VorgaengeTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Vorgaenge)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AktenTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Akten)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "FreeDMS_DB_testDataSet.Mandant". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.MandantTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Mandant)



    End Sub

    ''' <summary>
    ''' Tabeladapter füllen
    ''' Wiedervorlage prüfen
    ''' </summary>
    Private Sub LoadAll()
        Dim selDB = New FreeDMS_Aux.FreeDMS.DbHandling
        selDB.LoadDB(dbName)
        MandantTableAdapter.Connection = selDB.con
        DokumenteTableAdapter.Connection = selDB.con

        VorgaengeTableAdapter.Connection = selDB.con
        AktenTableAdapter.Connection = selDB.con
        AnschriftenTableAdapter.Connection = selDB.con
        TypTableAdapter.Connection = selDB.con
        StatusTableAdapter.Connection = selDB.con
        AblageTableAdapter.Connection = selDB.con
        NotizTableAdapter.Connection = selDB.con

        WiedervorlageTableAdapter.Connection = selDB.con
        VorlagenTableAdapter.Connection = selDB.con


        MandantTableAdapter.Fill(FreeDMS_DB_testDataSet.Mandant)
        DokumenteTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Dokumente)

        VorgaengeTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Vorgaenge)
        AktenTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Akten)
        AnschriftenTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Anschriften)
        TypTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Typ)
        StatusTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Status)
        AblageTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Ablage)
        NotizTableAdapter.Fill(FreeDMS_DB_testDataSet.notiz)

        WiedervorlageTableAdapter.Fill(FreeDMS_DB_testDataSet.wiedervorlage)
        VorlagenTableAdapter.Fill(Me.FreeDMS_DB_testDataSet.Vorlagen)
    End Sub
    Private Sub SaveAll()
        Try
            Validate()
            MandantBindingSource.EndEdit()
            DokumenteBindingSource.EndEdit()
            VorgaengeBindingSource.EndEdit()
            AktenBindingSource.EndEdit()
            AnschriftenBindingSource.EndEdit()
            AblageBindingSource.EndEdit()
            TypBindingSource.EndEdit()
            StatusBindingSource.EndEdit()
            NotizBindingSource.EndEdit()
            WiedervorlageBindingSource.EndEdit()
            VorlagenBindingSource.EndEdit()
            AnlagenBindingSource.EndEdit()
            VorlagenBindingSource.EndEdit()
            TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
        Catch ex As Exception
            MsgBox("Fehler beim Speichern! Bitte prüfen!")
        End Try

    End Sub
    Private Sub MandantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MandantBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MandantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Me.Validate()
        Me.AktenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton44_Click(sender As Object, e As EventArgs) Handles ToolStripButton44.Click
        Me.Validate()
        Me.VorlagenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton51_Click(sender As Object, e As EventArgs) Handles ToolStripButton51.Click
        Me.Validate()
        Me.NotizBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton58_Click(sender As Object, e As EventArgs) Handles ToolStripButton58.Click
        Me.Validate()
        Me.WiedervorlageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton23_Click(sender As Object, e As EventArgs) Handles ToolStripButton23.Click
        Me.Validate()
        Me.AnlagenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        Me.Validate()
        Me.VorgaengeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton9_Click(sender As Object, e As EventArgs) Handles ToolStripButton9.Click
        Me.Validate()
        Me.DokumenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton16_Click(sender As Object, e As EventArgs) Handles ToolStripButton16.Click
        Me.Validate()
        Me.AnschriftenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton30_Click(sender As Object, e As EventArgs) Handles ToolStripButton30.Click
        Me.Validate()
        Me.TypBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton37_Click(sender As Object, e As EventArgs) Handles ToolStripButton37.Click
        Me.Validate()
        Me.StatusBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub ToolStripButton65_Click(sender As Object, e As EventArgs) Handles ToolStripButton65.Click
        Me.Validate()
        Me.AblageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FreeDMS_DB_testDataSet)
    End Sub

    Private Sub LoeschWarnung()
        If MessageBox.Show("Beachten Sie bitte, daß das Löschen Auswirkungen auf verknüpfte Datein haben kann." & vbCrLf & "Löschen Sie daher nur, wenn Sie absolut sicher sind, dass es zu keinen Auswirkungen auf andere Dateien kommt!", "FreeDMS-Datenbanken - Achtung!", MessageBoxButtons.OKCancel) = DialogResult.Cancel Then Exit Sub
    End Sub

    Private Sub ToolStripButton39_Click(sender As Object, e As EventArgs) Handles ToolStripButton39.Click
        LoeschWarnung()
    End Sub

    Private Sub ToolStripButton46_Click(sender As Object, e As EventArgs) Handles ToolStripButton46.Click
        LoeschWarnung()
    End Sub

    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Try
            SaveAll()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Close()
    End Sub
End Class
