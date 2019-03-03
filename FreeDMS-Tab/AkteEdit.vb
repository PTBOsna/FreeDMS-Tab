Imports System.Windows.Forms

Public Class AkteEdit
    Dim id As String = Nothing
    Sub New(openArgs As String)
        InitializeComponent()
        id = openArgs
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Validate()
        Me.AktenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub AkteEdit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Mandant". Sie können sie bei Bedarf verschieben oder entfernen.
        ' Me.MandantTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Mandant)
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        ' Me.AktenTableAdapter.Fill(Me._FreeDMS_StartDBDataSet.Akten)
        AktenBindingSource.Filter = "id=" & id
        Dim rwAkten = DirectCast(DirectCast(AktenBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.AktenRow)
        If rwAkten.id <> 0 Then
            MandantBindingSource.Filter = "id=" & rwAkten.Mandant.ToString
        End If


    End Sub
    Private Sub BeschreibungTextBox_TextChanged(sender As Object, e As EventArgs) Handles BeschreibungTextBox.TextChanged
        lbAnzahlZeichen.Text = "(noch " & 250 - Len(BeschreibungTextBox.Text) & " Zeichen)"
    End Sub
End Class
