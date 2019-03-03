Option Strict On
Public Class NotizNeu
    Dim id As Integer
    Sub New(openArgs As String)
        InitializeComponent()
        id = CInt(openArgs)
    End Sub
    ''' <summary>
    ''' Form NoteNew aufrufen, TableAdapter füllen
    ''' Voreinstellungen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NoteNew_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: Diese Codezeile lädt Daten in die Tabelle "_FreeDMS_StartDBDataSet1.sqlVorgangAkte". Sie können sie bei Bedarf verschieben oder entfernen.
        ' Me.SqlVorgangAkteTableAdapter.Fill(Me._FreeDMS_StartDBDataSet1.sqlVorgangAkte)

        Me.Text += Format(Now, "dd. MMMM yyyy")
        AktenBindingSource.Sort = "Akte"
        VorgaengeBindingSource.Sort = "Vorgang"
        DokumenteBindingSource.Sort = "Dokument"
        NotizBindingSource.AddNew()
        If id > 0 Then
            CbAkten.Enabled = False
            CbVorgaenge.Enabled = False
            DokumenteBindingSource.Filter = "id=" & id.ToString
            Dim rwDok = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow)
            If Not rwDok.IsDokNameNull Then

                TitelTextBox.Text = rwDok.Dokument & " (" & rwDok.DokName & ") "
            End If

            CbDokumente.SelectedValue = id

        End If
        ErstelltTextBox.Text = Now.ToString
        ErstelltDateTimePicker.Value = Now

    End Sub
    ''' <summary>
    ''' Datensatz prüffen und speichern
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub NotizBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        If String.IsNullOrEmpty(CbAkten.Text) Then CbAkten.SelectedValue = 0
        If String.IsNullOrEmpty(CbVorgaenge.Text) Then CbVorgaenge.SelectedValue = 0
        If String.IsNullOrEmpty(CbDokumente.Text) Then CbDokumente.SelectedValue = 0
        Me.Validate()
        Me.NotizBindingSource.EndEdit()
        NotizTableAdapter.Update(_FreeDMS_StartDBDataSet.notiz)
        Close()
    End Sub

End Class