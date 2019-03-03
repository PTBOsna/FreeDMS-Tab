Public Class Mandanten
    Private Sub Mandanten_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'MandantTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Mandant)


    End Sub

    Private Sub BtnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Validate()
        Me.MandantBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Close()
    End Sub

    Private Sub MandantBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles MandantBindingNavigatorSaveItem.Click
        'Me.Validate()
        'Me.MandantBindingSource.EndEdit()
        'Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)

    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        Dim rw = DirectCast(DirectCast(MandantBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.MandantRow)

        If Start.ChkTbl(rw.id, 0, 0) > 0 Then
            MsgBox("Achtung, zu diesem Mandanten sind Akten vorhanden!" & vbCrLf & "Bitte zunächst die entsprechenden Akten löschen oder  verschieben!")
            Exit Sub
        Else
            If MsgBox("Mandat wirklich löschen?", vbYesNo) = DialogResult.Yes Then
                MandantBindingSource.RemoveCurrent()
            End If
        End If
    End Sub
End Class