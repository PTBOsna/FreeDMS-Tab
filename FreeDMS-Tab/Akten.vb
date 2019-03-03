Public Class Akten
    Private Sub AktenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AktenBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.AktenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)

    End Sub

    Private Sub Akten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Mandant". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.MandantTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Mandant)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)

    End Sub

    Private Sub BeschreibungTextBox_TextChanged(sender As Object, e As EventArgs) Handles BeschreibungTextBox.TextChanged
        lbAnzahlZeichen.Text = "noch " & 250 - Len(BeschreibungTextBox.Text) & " Zeichen)"
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        Me.Validate()
        Me.AktenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Close()
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim rw = DirectCast(DirectCast(AktenBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.AktenRow)

        If Start.ChkTbl(0, rw.id, 0) > 0 Then
            MsgBox("Achtung, Die Akte enthälte Vorgänge/Ordner!" & vbCrLf & "Bitte zunächst die entsprechenden Vorgänge/Ordner löschen oder verschieben!")
            Exit Sub
        Else
            If MsgBox("Akte wirklich löschen?", vbYesNo) = DialogResult.Yes Then
                AktenBindingSource.RemoveCurrent()
            End If
        End If
    End Sub

    Private Sub AngelegtDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles AngelegtDateTimePicker.ValueChanged
        AngelegtTextBox.Text = AngelegtDateTimePicker.Value.ToShortDateString
    End Sub

    Private Sub ArchiviertDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles ArchiviertDateTimePicker.ValueChanged
        ArchiviertTextBox.Text = ArchiviertDateTimePicker.Value.ToShortDateString
    End Sub
End Class