Option Strict On
Public Class Ablage
    ''' <summary>
    ''' Speichern und Abfrage wegen ID
    ''' Hier ist im Gegensatz zu allen anderen Tabellen die ID keine AutoIncriment!
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub AblageBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AblageBindingNavigatorSaveItem.Click
        SaveAll()
    End Sub

    Private Sub SaveAll()
        If String.IsNullOrEmpty(NummerTextBox.Text) Then
            MsgBox("Bitte eine (eindeutige) Ablage-Nummer eingeben")
            Exit Sub
        End If
        Me.Validate()
        Me.AblageBindingSource.EndEdit()
        AblageTableAdapter.Update(_FreeDMS_StartDBDataSet.Ablage)
    End Sub
    ''' <summary>
    ''' Formular load
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Ablage_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    ''' <summary>
    ''' Fomrular Close
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub BtClose_Click(sender As Object, e As EventArgs) Handles BtClose.Click
        SaveAll()
        Close()
    End Sub

    Private Sub HinweiseTextBox_TextChanged(sender As Object, e As EventArgs)
        LbAnzahlZeichen.Text = "noch " & 255 - Len(HinweiseTextBox.Text) & " Zeichen)"
    End Sub


End Class