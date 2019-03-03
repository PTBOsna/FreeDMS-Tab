Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO
Public Class TestForm
    Dim lvIndex As Int32
    'Testform
    Private Sub TestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Dokumente". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DokumenteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Dokumente)
        DokumenteBindingSource.Filter = "Anlagen>0"
    End Sub

    Private Sub DokumenteBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles DokumenteBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.DokumenteBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)

    End Sub
End Class