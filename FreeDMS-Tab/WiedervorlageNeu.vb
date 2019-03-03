Public Class WiedervorlageNeu
    Dim id As String
    Dim oa() As String
    Sub New(openArgs As String)
        InitializeComponent()
        oa = Split(openArgs, ";")
        id = oa(0)
    End Sub
    Private Sub WiedervorlageNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Vorgaenge". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.VorgaengeTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorgaenge)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Mandant". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.MandantTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Mandant)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Dokumente". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.DokumenteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Dokumente)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.wiedervorlage". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.WiedervorlageTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.wiedervorlage)
        If oa(1) = "j" Then
            WiedervorlageBindingSource.AddNew()
            DokumenteBindingSource.Filter = "id=" & id
            Dim rwDokument = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            CbAkte.SelectedValue = rwDokument.Akte
            CbMandant.SelectedValue = rwDokument.Mandant
            CbVorgang.SelectedValue = rwDokument.Vorgang
        Else
            WiedervorlageBindingSource.Filter = "id=" & id

        End If
        'CbMandant.DropDownStyle = ComboBoxStyle.DropDownList
        'CbAkte.DropDownStyle = ComboBoxStyle.DropDownList
        'CbVorgang.DropDownStyle = ComboBoxStyle.DropDownList
        'CbDokument.DropDownStyle = ComboBoxStyle.DropDownList
    End Sub

    Private Sub WiedervorlageTextBox_TextChanged(sender As Object, e As EventArgs) Handles TxtNotiz.TextChanged
        lbAnzahlZeichen.Text = "noch " & 250 - Len(TxtNotiz.Text) & " Zeichen)"
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        Wv_datumTextBox.Text = DateTimePicker1.Value
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        If String.IsNullOrEmpty(Wv_datumTextBox.Text) Then
            MsgBox("Bitte in Wiedervorlagedatum eingeben!")
            Exit Sub
        End If
        Me.Validate()
        Me.WiedervorlageBindingSource.EndEdit()
        WiedervorlageTableAdapter.Update(_FreeDMS_StartDBDataSet.wiedervorlage)
        Close()
    End Sub

    Private Sub BtClear_Click(sender As Object, e As EventArgs) Handles BtClear.Click
        DialogResult = CType(vbYes, DialogResult)
        If MessageBox.Show("Wiedervorlage wirklich löschen?", "Löschabfrage", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        Else
            DialogResult = CType(vbYes, DialogResult)
            WiedervorlageBindingSource.RemoveCurrent()
            'Dim rowCurrent = DirectCast(DirectCast(NotizBindingSource.Current, DataRowView).Row, freeDMS_DB_testDataSet.notizRow)
            'rowCurrent.Delete()
        End If
    End Sub
End Class