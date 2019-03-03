Public Class WiedervorlageListe
    Private Sub WiedervorlageBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles WiedervorlageBindingNavigatorSaveItem.Click, BtClose.Click
        Me.Validate()
        Me.WiedervorlageBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)

    End Sub

    Private Sub WiedervorlageListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        Close()
    End Sub

    Private Sub Wv_datumDateTimePicker_ValueChanged(sender As Object, e As EventArgs) Handles Wv_datumDateTimePicker.ValueChanged
        Wv_datumTextBox.Text = Wv_datumDateTimePicker.Value
    End Sub
End Class