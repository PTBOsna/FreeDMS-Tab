Public Class NotizListe
    Private Sub NotizListe_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '

    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        ErstelltDateTimePicker.Value = Now
        If String.IsNullOrEmpty(CbAkten.Text) Then CbAkten.SelectedValue = 0
        If String.IsNullOrEmpty(CbVorgaenge.Text) Then CbVorgaenge.SelectedValue = 0
        If String.IsNullOrEmpty(CbDokumente.Text) Then CbDokumente.SelectedValue = 0
        Me.Validate()
        Me.NotizBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(_FreeDMS_StartDBDataSet)
        Close()
    End Sub
End Class