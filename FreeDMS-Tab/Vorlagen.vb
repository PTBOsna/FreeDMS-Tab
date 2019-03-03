Public Class Vorlagen


    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO:   Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Ablage". Sie können sie bei Bedarf verschieben oder entfernen.
        '        Me.AblageTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Ablage)
        'TODO:   Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Anschriften". Sie können sie bei Bedarf verschieben oder entfernen.
        '        Me.AnschriftenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Anschriften)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Vorgaenge". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.VorgaengeTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorgaenge)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Mandant". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.MandantTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Mandant)


    End Sub

    Private Sub VorlagenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VorlagenBindingNavigatorSaveItem.Click
        SaveAll()

    End Sub

    Private Sub VorgangTextBox_TextChanged(sender As Object, e As EventArgs) Handles VorgangTextBox.TextChanged
        If String.IsNullOrEmpty(VorgangTextBox.Text) Then Exit Sub
        Dim vorgID As String = VorgangTextBox.Text
        TxtVorgang.DataBindings.Clear()
        VorgaengeBindingSource.Filter = "id = " & VorgangTextBox.Text
        TxtVorgang.DataBindings.Add("Text", VorgaengeBindingSource, "Vorgang", True)
    End Sub

    Private Sub AkteTextBox_TextChanged(sender As Object, e As EventArgs) Handles AkteTextBox.TextChanged
        If String.IsNullOrEmpty(AkteTextBox.Text) Then Exit Sub
        VorgaengeBindingSource1.Filter = "Akte=" & AkteTextBox.Text
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAkte.SelectedIndexChanged
        If CbAkte.SelectedIndex < 0 Then Exit Sub
        AkteTextBox.Text = CbAkte.SelectedValue
    End Sub

    Private Sub SchluesselwortTextBox_TextChanged(sender As Object, e As EventArgs) Handles SchluesselwortTextBox.TextChanged
        lblCount1.Text = "(noch " & 250 - Len(SchluesselwortTextBox.Text) & " Zeichen)"
    End Sub

    Private Sub KurzbeschreibungTextBox_TextChanged(sender As Object, e As EventArgs) Handles KurzbeschreibungTextBox.TextChanged
        lblCount2.Text = "(noch " & 250 - Len(KurzbeschreibungTextBox.Text) & " Zeichen)"
    End Sub

    Private Sub CbVorgangNeu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbVorgangNeu.SelectedIndexChanged
        If CbVorgangNeu.SelectedIndex >= 0 Then
            VorgangTextBox.Text = CbVorgangNeu.SelectedValue.ToString
        End If
    End Sub
    Private Sub SaveAll()
        Me.Validate()
        Me.VorlagenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        SaveAll()
        Close()
    End Sub
End Class