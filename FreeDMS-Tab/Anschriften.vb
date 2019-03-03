Public Class Anschriften
    Private Sub AnschriftenBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles AnschriftenBindingNavigatorSaveItem.Click
        SaveAll()
    End Sub

    Private Sub Anschriften_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub
    Private Sub BmerkungenTextBox_TextChanged_1(sender As Object, e As EventArgs) Handles BmerkungenTextBox.TextChanged
        lblBemerk.Text = "(Noch " & 255 - Len(BmerkungenTextBox.Text) & " Zeichen)"
    End Sub

    ''' <summary>
    ''' Link der Internetadresse aus Internet-TextBox erstellen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub InternetTextBox_TextChanged(sender As Object, e As EventArgs) Handles InternetTextBox.TextChanged
        LinkLabel1.Text = InternetTextBox.Text
    End Sub
    ''' <summary>
    ''' ufruf/Anzeige der ggf. vorhandenen Intnetadresse
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Try
            System.Diagnostics.Process.Start(InternetTextBox.Text)
        Catch ex As Exception
            MsgBox("Keine gültige Internetadresse!")
        End Try

    End Sub
    Private Sub SaveAll()
        Me.Validate()
        Me.AnschriftenBindingSource.EndEdit()
        AnschriftenTableAdapter.Update(_FreeDMS_StartDBDataSet.Anschriften)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveAll()
        Close()
    End Sub
End Class