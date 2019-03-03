Imports System.Windows.Forms

Public Class VorgangNeu
    Dim id As String = Nothing
    Sub New(openArgs As String)
        InitializeComponent()
        id = openArgs
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Validate()
        Me.VorgaengeBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub


    Private Sub VorgangNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet.Akten". Sie können sie bei Bedarf verschieben oder entfernen.
        VorgaengeBindingSource.AddNew()
        AktenBindingSource.Filter = "id=" & id
        AkteIDTextBox.Text = id
        BegonnenTextBox.Text = Now.ToShortDateString

        If id <> "#" Then
            PanlEdit.Visible = False
            AktenBindingSource.Filter = "id=" & id

        End If
    End Sub
End Class
