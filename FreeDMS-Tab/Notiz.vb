Option Strict On
Public Class Notiz
    Dim id As String
    Sub New(openArgs As String)
        InitializeComponent()
        id = openArgs
    End Sub
    Private Sub Notiz_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Dokumente". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.DokumenteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Dokumente)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.sqlVorgangAkte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.SqlVorgangAkteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.sqlVorgangAkte)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.sqlVorgangAkte". Sie können sie bei Bedarf verschieben oder entfernen.
        Me.SqlVorgangAkteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.sqlVorgangAkte)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Dokumente". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.DokumenteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Dokumente)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Vorgaenge". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.VorgaengeTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Vorgaenge)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        ''TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.notiz". Sie können sie bei Bedarf verschieben oder entfernen.
        'Me.NotizTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.notiz)
        NotizBindingSource.Filter = "id=" & id
    End Sub

    Private Sub BtDelete_Click(sender As Object, e As EventArgs) Handles btDelete.Click
        DialogResult = CType(vbYes, DialogResult)
        If MessageBox.Show("Notiz wirklich löschen?", "Löschabfrage", MessageBoxButtons.YesNo) = DialogResult.No Then
            Exit Sub
        Else
            DialogResult = CType(vbYes, DialogResult)
            NotizBindingSource.RemoveCurrent()
            'Dim rowCurrent = DirectCast(DirectCast(NotizBindingSource.Current, DataRowView).Row, freeDMS_DB_testDataSet.notizRow)
            'rowCurrent.Delete()
        End If
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        Validate()
        NotizBindingSource.EndEdit()
        NotizTableAdapter.Update(_FreeDMS_StartDBDataSet.notiz)
        Close()

    End Sub
End Class