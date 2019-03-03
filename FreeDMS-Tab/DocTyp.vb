Public Class DocTyp
    Private Sub TypBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TypBindingNavigatorSaveItem.Click
        SaveAll()

    End Sub
    Private Sub SaveAll()
        Me.Validate()
        Me.TypBindingSource.EndEdit()
        TypTableAdapter.Update(_FreeDMS_StartDBDataSet.Typ)
    End Sub
    Private Sub DocTyp_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub KommentarTextBox_TextChanged(sender As Object, e As EventArgs) Handles KommentarTextBox.TextChanged
        Label1.Text = "Noch " & 255 - Len(KommentarTextBox.Text) & " Zeichen"
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        SaveAll()
        Close()
    End Sub
End Class