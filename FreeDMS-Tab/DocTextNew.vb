Option Strict On
Imports FreeDMS_Aux.FreeDMS.GrundDaten
Public Class DocTextNew
    Private Sub DocTextNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        DokumenteBindingSource.AddNew()
        CbMandat.SelectedValue = StartMandant
        CbAbsender.SelectedValue = StEmpfaenger
        CbEmpfaenger.SelectedValue = StEmpfaenger
        DokDatumTextBox.Text = Now.ToString
        AufgenommenTextBox.Text = Now.ToString
        AbsenderTextBox.Text = StEmpfaenger.ToString
        EmpfaengerTextBox.Text = StEmpfaenger.ToString
        MandantBindingSource.Filter = "id=" & StartMandant.ToString
    End Sub

    Private Sub btClose_Click(sender As Object, e As EventArgs) Handles btClose.Click
        If MsgBox("Zurück ohne speichern?", vbYesNo) = MsgBoxResult.No Then Exit Sub
        Close()
    End Sub

    Private Sub btSave_Click(sender As Object, e As EventArgs) Handles btSave.Click
        Validate()
        DokumenteBindingSource.EndEdit()
        DokumenteTableAdapter.Update(_FreeDMS_StartDBDataSet.Dokumente)
        Close()
    End Sub

    Private Sub CbMandat_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbMandat.SelectedIndexChanged
        If CInt(CbMandat.SelectedIndex) >= 0 Then
            AktenBindingSource.Filter = "Mandant=" & CbMandat.SelectedValue.ToString
            ' VorgaengeBindingSource.Filter = "Akte=" & CbAkte.SelectedValue.ToString
        End If
    End Sub

    Private Sub CbAkte_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbAkte.SelectedIndexChanged
        If CInt(CbAkte.SelectedIndex) >= 0 Then
            VorgaengeBindingSource.Filter = "Akte=" & CbAkte.SelectedValue.ToString
        End If
    End Sub
End Class