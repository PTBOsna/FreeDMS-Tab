Public Class Vorganege
    Private Sub VorgaengeBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles VorgaengeBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.VorgaengeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)

    End Sub

    Private Sub Vorganege_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        'VorgaengeTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorgaenge)
        ComboBox2.Text = "Bitte auswählen"
    End Sub

    Private Sub BeschreibungTextBox_TextChanged(sender As Object, e As EventArgs) Handles BeschreibungTextBox.TextChanged
        lbAnzahlZeichen.Text = "noch " & 250 - Len(BeschreibungTextBox.Text) & " Zeichen)"
    End Sub

    Private Sub HinweiseTextBox_TextChanged(sender As Object, e As EventArgs) Handles HinweiseTextBox.TextChanged
        Label2.Text = "noch " & 250 - Len(BeschreibungTextBox.Text) & " Zeichen)"
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Validate()
        Me.VorgaengeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Close()
    End Sub

    Private Sub BtAlles_Click(sender As Object, e As EventArgs) Handles BtAlles.Click
        VorgaengeBindingSource.Filter = "id<>0"
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        If ComboBox2.SelectedIndex >= 0 Then
            VorgaengeBindingSource.Filter = "Akte=" & ComboBox2.SelectedValue.ToString
        End If
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim rwVorg = DirectCast(DirectCast(VorgaengeBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.VorgaengeRow)

        If Start.ChkTbl(0, 0, rwVorg.id) > 0 Then
            MsgBox("Achtung, Der Ordner ist nicht leer!" & vbCrLf & "Bitte zunächst die entsprechenden Dokumente löschen oder in einen anderen Ordner verschieben!")
            Exit Sub
        Else
            If MsgBox("Vorgang wirklich löschen?", vbYesNo) = DialogResult.Yes Then
                VorgaengeBindingSource.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub AngelegtDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles AngelegtDateTimePicker.ValueChanged
        BegonnenTextBox.Text = AngelegtDateTimePicker.Value.ToShortDateString
    End Sub

    Private Sub ZeitzielDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ZeitzielDateTimePicker.ValueChanged
        ZeitzielTextBox.Text = ZeitzielDateTimePicker.Value.ToShortDateString
    End Sub

    Private Sub ArchiviertDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ArchiviertDateTimePicker.ValueChanged
        BeendetTextBox.Text = ArchiviertDateTimePicker.Value.ToShortDateString
    End Sub
End Class