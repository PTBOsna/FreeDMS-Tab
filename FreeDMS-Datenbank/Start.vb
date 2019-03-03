Imports System.Data.OleDb
Class Start
    Dim dbName As String
    Private dt As New DataTable
    Private da As OleDbDataAdapter
    Private ds As New DataSet
    ' Private bs As New bin

    Private Sub ÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ÖffnenToolStripMenuItem.Click
        Dim dummy As String = ""
        With OpenFileDialog1
            '.Filter = "Access-Dateien (*.mdb)|*.mdb|All files (*.*)|*.*"
            .Filter = "FreeDMS (FreeDMS*.mdb)|FreeDMS*.mdb"
            .InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory
            .FileName = ""
            .ShowDialog()
            If String.IsNullOrEmpty(.FileName) Then Exit Sub
            dbName = .FileName


        End With
    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim ConStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & dbName & ";"
        Dim Con As New OleDbConnection(ConStr)
        'ds.Tables.Add(dt)
        'da = New OleDbDataAdapter("SELECT * FROM Tabelle1", Con)
        'da.Fill(dt)
        'Dim cb As New OleDbCommandBuilder(da)
        'bs.DataSource = dt
        'Me.DataGridView1.DataSource = bs

    End Sub
End Class