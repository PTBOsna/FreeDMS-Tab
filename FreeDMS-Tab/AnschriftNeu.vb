Public Class AnschriftNeu


    Private Sub AnschriftNeu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ListBox1.Visible = False
        LbErgeb.Visible = False
        AnschriftenBindingSource.AddNew()
    End Sub

    Private Sub BtSave_Click(sender As Object, e As EventArgs) Handles BtSave.Click
        Me.Validate()
        Me.AnschriftenBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me._FreeDMS_StartDBDataSet)
        Close()
    End Sub

    Private Sub BtCheck_Click(sender As Object, e As EventArgs) Handles BtCheck.Click
        Dim MyName = From p In _FreeDMS_StartDBDataSet.Anschriften Where p.Name_.Contains(Name_TextBox.Text) Select p
        If MyName.Count > 0 Then
            ListBox1.Visible = True
            LbErgeb.Visible = True
            LbErgeb.Text = "Vorhanden:"
            ListBox1.Items.Clear()
        Else
            ListBox1.Visible = False
            LbErgeb.Text = "Nichts gefunden"
            LbErgeb.Visible = True

        End If
        ' MsgBox(MyName.Count.ToString)
        For Each eintrag In MyName
            ListBox1.Items.Add(eintrag.Name_)

        Next

    End Sub

    Private Sub BtCancel_Click(sender As Object, e As EventArgs) Handles BtCancel.Click
        If MessageBox.Show("Zurück ohne speichern?", "Speichern?", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            Close()
        End If

    End Sub
End Class