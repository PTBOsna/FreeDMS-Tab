Option Strict On
Imports Microsoft.VisualBasic.PowerPacks.Printing
Imports System.Drawing.Printing
Public Class PrintForm
    Dim id As String
    ''' <summary>
    ''' OpenArgs
    ''' </summary>
    ''' <param name="openArgs"></param>
    Sub New(openArgs As String)
        InitializeComponent()
        id = openArgs
    End Sub
    ''' <summary>
    ''' Form Load mit TableAdapter Connection und Fill
    ''' sowie Voreinstellungen
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Drucken_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim nAnlagen As String = Nothing
        Dim isAnlage As Boolean = False

        'Druck-Button einstellen:
        With btPrint
            .Text = "Drucken"
            .TextAlign = ContentAlignment.BottomCenter
            .BackColor = SystemColors.ButtonFace
        End With


        'Formular einrichten:
        btPrint.Font = New Font(Font, FontStyle.Bold)
        btPrint.Text = "Drucken"
        btPrint.Focus()
        ' MsgBox(DokumenteBindingSource.Current("Absender"))
        DokumenteBindingSource.Filter = "id=" & id
        'Vorbelegen:
        Dim mandant = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Mandant.ToString
        Dim akte = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Akte.ToString
        Dim vorgang = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Vorgang.ToString
        MandantBindingSource.Filter = "id=" & mandant
        AktenBindingSource.Filter = "id=" & akte
        VorgaengeBindingSource.Filter = "id=" & vorgang
        StatusBindingSource.Filter = "id=" & DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Status.ToString
        TypBindingSource.Filter = "id=" & DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Typ.ToString
        AblageBindingSource.Filter = "Nummer=" & DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Ablage.ToString
        DokNameTextBox.Text = FreeDMS_Aux.FreeDMS.GrundDaten.ArchivOrdner & DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).DokName.ToString
        Dim absender = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Absender.ToString
        If Not String.IsNullOrEmpty(absender) Then
            AnschriftenBindingSource.Filter = "id=" & absender
        Else
            AbsenderTextBox.Text = "Kein Eintrag"
        End If
        Dim empfaenger = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Empfaenger.ToString
        If Not IsDBNull(empfaenger) Then
            AnschriftenBindingSource1.Filter = "id=" & empfaenger
        Else
            EmpfaengerTextBox.Text = "Kein Eintrag"
        End If
        Dim anlagen = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).Anlagen.ToString
        If Not IsDBNull(anlagen) Then
            nAnlagen = anlagen
        Else
            nAnlagen = "keine"
        End If


        isAnlage = DirectCast(DirectCast(DokumenteBindingSource.Current, DataRowView).Row, _FreeDMS_StartDBDataSet.DokumenteRow).istAnlage
        txtAz.Text = mandant & "-" & akte & "-" & vorgang & "/" & id

        If nAnlagen = "keine" Then
            lblAnlage.Visible = False

        Else
            lblAnlage.Visible = True
            lblAnlage.Text = "Dokument enthält " & nAnlagen & " Anlagen"
        End If
        If isAnlage = True Then
            lblAnlage.Visible = True
            lblAnlage.Text = "Dokument ist Anlage"
        Else
            lblAnlage.Visible = False
        End If
    End Sub
    ''' <summary>
    ''' Auslösen des Druckereignisses
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btPrint.Click
        'Dim frmCollection As FormCollection = Application.OpenForms
        'If frmCollection.OfType(Of Compatibility.VB6.Printer).Then Then
        '    frmCollection.Item("printForm").Activate()

        'End If
        With btPrint
            .Text = Now & " - " & txtAz.Text '"Druckdatum: " & Now
            .TextAlign = ContentAlignment.MiddleLeft
            .BackColor = Color.White

        End With
        Me.Refresh()
        FormPrint()
        Close()
    End Sub
    ''' <summary>
    ''' Druckereignis
    ''' </summary>
    Private Sub FormPrint()
        Dim pf As New PowerPacks.Printing.PrintForm With {
            .Form = Me 'z.B. deine aktive Form
            }
        ' pf.PrintAction = Printing.PrintAction.PrintToPreview 'hier z.B. die Seitenansicht
        '
        Dim page = pf.PrinterSettings.DefaultPageSettings

        page.Landscape = False 'Querformat (False = Hochformat)
        '
        'Seitenränder anpassen

        Dim r As Integer = CInt(((page.PaperSize.Width * 0.96) - Me.Width) / 2)
        page.Margins.Top = 30
        'page.Margins.Bottom = x
        ' MsgBox(r.ToString)

        page.Margins.Right = 10
        page.Margins.Left = r
        'btPrint.Text = Now & " - " & id & "-" & DokumenteBindingSource.Current("DokName")
        'btPrint.Font = New Font(Font, FontStyle.Regular)
        pf.Print()
        'btPrint.Font = New Font(Font, FontStyle.Bold)
        'btPrint.Text = "Drucken"
    End Sub

End Class