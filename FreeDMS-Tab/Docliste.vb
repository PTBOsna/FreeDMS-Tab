Public Class Docliste
    Private Sub DokumenteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DokumenteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DokumenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)

    End Sub

    Private Sub Docliste_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        Me.Validate()
        Me.DokumenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Close()
    End Sub
End Class