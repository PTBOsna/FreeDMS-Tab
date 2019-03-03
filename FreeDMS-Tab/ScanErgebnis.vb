Imports System.Windows.Forms

Public Class ScanErgebnis
    Dim oa As String
    Sub New(openArgs As String)
        InitializeComponent()
        oa = CInt(openArgs)
    End Sub
    Private Sub ScanErgebnis_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblScanErgebnis.Text = "Es wurden " & oa & " Seiten gescannt."
        lbScanMsg.Text = "Weitere Seiten oder Rückseite scannen? "
    End Sub
    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

End Class
