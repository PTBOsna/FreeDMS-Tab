Public Class DocStatus
    Private Sub StatusBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles StatusBindingNavigatorSaveItem.Click

        SaveAll()
    End Sub
    Private Sub SaveAll()
        Me.Validate()
        Me.StatusBindingSource.EndEdit()
        StatusTableAdapter.Update(Me._FreeDMS_StartDBDataSet.Status)
    End Sub
    Private Sub DocStatus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '
    End Sub

    Private Sub BemerkungTextBox_TextChanged(sender As Object, e As EventArgs) Handles BemerkungTextBox.TextChanged
        Label1.Text = "Noch " & 255 - Len(BemerkungTextBox.Text) & " Zeichen"
    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        SaveAll()
        Close()
    End Sub
End Class