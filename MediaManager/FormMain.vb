Imports System.IO
Imports System.Threading
Imports System.Globalization
Imports Microsoft.WindowsAPICodePack.Dialogs
Imports Gma.QrCodeNet.Encoding
Imports Gma.QrCodeNet.Encoding.Windows.Render

Public Class FormMain

    Public Media As CsvDatabase

    Private ExitConfirmation As TaskDialog
    Private FormClosingArgs As FormClosingEventArgs
    Private InitiatedExit As Boolean = False

    Private InitialTotalItemsText As String = ""
    Private InitialLastUpdatedText As String = ""

    Sub New()
        Thread.CurrentThread.CurrentUICulture = My.Settings.Culture
        InitializeComponent()

        InitialTotalItemsText = Me.ToolStripStatusLabelTotalItems.Text
        InitialLastUpdatedText = Me.ToolStripStatusLabelLastUpdated.Text
    End Sub

    Private Sub FormMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.ConfigureWindow(Me, , True)
        ToolStripStatusLabelVersion.Text = Main.ApplicationName & " - " & Main.ApplicationVersion
        GroupBoxFind.Dock = My.Settings.FindDockStyle
        GroupBoxFind.Hide()
        If My.Settings.LoadLastFormSizes Then LoadFormSettings()

        If File.Exists(My.Settings.MediaDatabaseFile) Then
            RefreshDatabase()
            FillFindFields()
        Else
            TaskDialog.Show("", "The media database file at """ & My.Settings.MediaDatabaseFile & """ was not found. After clicking OK, the preferences will show up, where you should specify a valid path.", Main.GetWindowText("Database Not Found"))
            FormPreferences.ShowDialog()
        End If
    End Sub

    Private Sub FormMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SaveFormSettings()
        If Not InitiatedExit Then
            FormClosingArgs = e
            If Not My.Settings.ShowQuitWarning Then
                Quit()
            Else
                ExitConfirmation = New TaskDialog()

                Dim ExitConfirmationYesButton As New TaskDialogCommandLink("Yes", "Yes, quit")
                Dim ExitConfirmationNoButton As New TaskDialogCommandLink("No", "No, I still want to do something!")
                AddHandler ExitConfirmation.Opened, AddressOf ExitConfirmation_Opened
                AddHandler ExitConfirmationYesButton.Click, AddressOf ExitConfirmationButton_Click
                AddHandler ExitConfirmationNoButton.Click, AddressOf ExitConfirmationButton_Click

                With ExitConfirmation
                    .Caption = Main.GetWindowText("Exit")
                    .InstructionText = "Are you sure you want to quit?"

                    .Controls.Add(ExitConfirmationYesButton)
                    .Controls.Add(ExitConfirmationNoButton)

                    '.FooterCheckBoxChecked = False
                    '.FooterCheckBoxText = "Don't ask again"

                    .Cancelable = False
                End With

                Me.Enabled = False
                Dim Result As TaskDialogResult = ExitConfirmation.Show()
            End If
        End If
    End Sub

    Private Sub SaveFormSettings()
        With My.Settings
            .FormMainSize = Me.Size
            .FormMainStartPoint = New Point(Me.Left, Me.Top)
            .FormMainWindowState = Me.WindowState
        End With
    End Sub

    Private Sub LoadFormSettings()
        With My.Settings
            Me.Size = .FormMainSize
            Me.Left = .FormMainStartPoint.X
            Me.Top = .FormMainStartPoint.Y
            Me.WindowState = .FormMainWindowState
        End With
    End Sub

    Private Sub ExitConfirmation_Opened(ByVal sender As Object, ByVal e As EventArgs)
        ExitConfirmation.Icon = TaskDialogStandardIcon.Warning
    End Sub

    Private Sub ExitConfirmationButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As TaskDialogCommandLink = TryCast(sender, TaskDialogCommandLink)
        Select Case Button.Name
            Case "Yes"
                InitiatedExit = True
                'If (ExitConfirmation.FooterCheckBoxChecked = True) Then My.Settings.ShowQuitWarning = False
                Quit()
            Case "No"
                ExitConfirmation.Close()
                FormClosingArgs.Cancel = True
                Me.Show()
                Me.Enabled = True
        End Select
    End Sub

#Region "Database"

    Private Sub RefreshDatabase()
        Media = New CsvDatabase(My.Settings.MediaDatabaseFile)
        FillData()
    End Sub

    Private Sub FillData()
        ' remove everything
        DataGridViewMedia.Rows.Clear()
        DataGridViewMedia.Columns.Clear()

        ' create columns
        For Each Column As String In Media.Columns
            DataGridViewMedia.Columns.Add(Column, Column)
        Next
        ' create rows
        For Each Row As String() In Media.Rows
            DataGridViewMedia.Rows.Add(Row)
        Next

        ' resize columns
        For Each Column As DataGridViewColumn In DataGridViewMedia.Columns
            If Column.HeaderText = "ID" Then Column.Width = 30
            If Column.HeaderText = "Name" Then Column.Width = 500
        Next

        ' updated
        ToolStripStatusLabelLastUpdated.Text = String.Format(InitialLastUpdatedText, Now.ToLongTimeString)
        UpdateTotalItems()
    End Sub

    Private Sub UpdateTotalItems()
        ToolStripStatusLabelTotalItems.Text = String.Format(InitialTotalItemsText, DataGridViewMedia.Rows.Count)
    End Sub

    Private Sub FillFindFields()
        ComboBoxField.Items.Clear()
        ComboBoxField.Items.Add(My.Settings.FindFieldAllPlaceholder)
        For Each Column As String In Media.Columns
            ComboBoxField.Items.Add(Column)
        Next
        ComboBoxField.SelectedIndex = 0
    End Sub
#End Region

#Region "ToolStrip"

    Private Sub QuitToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles QuitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub MediaDatabaseInExcelToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MediaDatabaseInExcelToolStripMenuItem.Click
        Try
            Dim Word As New Process
            Word.StartInfo = New ProcessStartInfo("excel", """" & My.Settings.MediaDatabaseFile & """")
            Word.Start()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PrintSelectedItemsToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintSelectedItemsToolStripMenuItem.Click
        Dim PrintForm As FormPrint = New FormPrint(GetSelectedRows())
        PrintForm.ShowDialog()
    End Sub

    Private Sub SaveDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveDatabaseToolStripMenuItem.Click
        Media.Write(My.Settings.MediaDatabaseFile)
    End Sub

    Private Sub RefreshDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RefreshDatabaseToolStripMenuItem.Click
        RefreshDatabase()
    End Sub

    Private Sub ViewRawDatabaseToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ViewRawDatabaseToolStripMenuItem.Click
        FormRawDatabase.Show()
    End Sub

    Private Sub FindToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FindToolStripMenuItem.Click
        GroupBoxFind.Visible = Not GroupBoxFind.Visible
        TextBoxFind.SelectAll()
        TextBoxFind.Focus()
    End Sub

    Private Sub EditSelectedItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditSelectedItemToolStripMenuItem.Click
        EditSelectedItem()
    End Sub

    Private Sub AddItemToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddItemToolStripMenuItem.Click
        AddItem()
    End Sub

    Private Sub PreferencesToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PreferencesToolStripMenuItem.Click
        FormPreferences.ShowDialog()
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        FormAbout.ShowDialog()
    End Sub
#End Region

    Public Function GetSelectedRows() As CsvDatabase
        Dim SelectedRows As New List(Of String())
        For Each Row As DataGridViewRow In DataGridViewMedia.Rows
            If Row.Selected Then
                Dim Cells As New List(Of String)
                For Each Cell As DataGridViewCell In Row.Cells
                    Cells.Add(Cell.Value)
                Next
                SelectedRows.Add(Cells.ToArray())
            End If
        Next
        Dim Database As New CsvDatabase()
        Dim Full As New List(Of String())
        Full.Add(Media.Columns)
        Full.AddRange(SelectedRows)
        Database.Full = Full
        Database.Update(False)
        Return Database
    End Function

    Public Sub Quit()
        Application.Exit()
    End Sub

    Private Sub ButtonFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFind.Click
        Find(TextBoxFind.Text)
    End Sub

    Private Sub Find(ByVal SearchString As String)
        If SearchString = "*" Or SearchString = "" Then
            TextBoxFind.Text = SearchString
            TextBoxFind.Focus()
            TextBoxFind.SelectAll()
            FillData()
            Exit Sub
        End If
        DataGridViewMedia.Rows.Clear()
        Dim ColumnIndex As Integer = 0
        If SearchString = My.Settings.FindFieldAllPlaceholder Then
            ColumnIndex = -1
        Else
            ColumnIndex = Array.IndexOf(Media.Columns, ComboBoxField.Text)
        End If

        For Each Row As String() In Media.Rows
            Dim FoundSearchStringInCurrentRow As Boolean = False
            If ColumnIndex = -1 Then
                For Each Item As String In Row
                    If Item.Contains(SearchString) Then
                        FoundSearchStringInCurrentRow = True
                        Exit For
                    End If
                Next
            Else
                If Row(ColumnIndex).Contains(SearchString) Then FoundSearchStringInCurrentRow = True
            End If
            If FoundSearchStringInCurrentRow Then DataGridViewMedia.Rows.Add(Row)
        Next
        GroupBoxFind.Visible = True
        TextBoxFind.Text = SearchString
        TextBoxFind.SelectAll()
        TextBoxFind.Focus()
        UpdateTotalItems()
    End Sub

    Private Sub ButtonFindHide_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFindHide.Click
        GroupBoxFind.Hide()
    End Sub

    Private Sub ButtonFindClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonFindClear.Click
        Find("*")
    End Sub

    Private Sub DataGridViewMedia_CellDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridViewMedia.CellDoubleClick
        EditSelectedItem()
    End Sub

    Private Sub EditSelectedItem()
        Dim SelectedIndexBefore As Integer = DataGridViewMedia.SelectedRows(0).Index
        Dim EditForm As New FormEditItem(DataGridViewMedia.SelectedRows(0).Cells(0).Value, FormEditItem.EditAction.Edit)
        EditForm.ShowDialog()
        FillData()
        Try
            DataGridViewMedia.Rows(0).Selected = False
            DataGridViewMedia.Rows(SelectedIndexBefore).Selected = True
        Catch ex As Exception
        End Try
    End Sub

    Private Sub AddItem()
        Dim AddForm As New FormEditItem(GetHighestMediaId() + 1, FormEditItem.EditAction.Add)
        AddForm.ShowDialog()
        FillData()
    End Sub

    Public Function GetRowIndexById(ByVal Id As Integer) As Integer
        Dim IdColumnIndex As Integer = 0
        For i As Integer = 0 To Media.Rows.Count
            If Media.Rows(i)(IdColumnIndex) = Id Then
                Return i
            End If
        Next
        Return -1
    End Function

    Public Function GetHighestMediaId() As Integer
        Dim CurrentHighest As Integer = -1
        For Each Row As String() In Media.Rows
            If Row(0) > CurrentHighest Then CurrentHighest = Row(0)
        Next
        Return CurrentHighest
    End Function

    Private Sub DeleteSelectedToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteSelectedItemsToolStripMenuItem.Click
        For Each Row As DataGridViewRow In DataGridViewMedia.SelectedRows
            Media.Rows.RemoveAt(Row.Index)
        Next
        FillData()
    End Sub
End Class

Public Module MainInfo

    Public Main As New Main.Main("MediaManager", "0.0.1.3", "Beta", "CD organization made easy", 2013, "Georg Wölflein")

    Public Function EncodeQrCode(ByVal Text As String) As Image
        Dim Encoder As New QrEncoder(ErrorCorrectionLevel.M)
        Dim Code As New QrCode()
        Encoder.TryEncode(Text, Code)
        Dim Renderer As New GraphicsRenderer(New FixedModuleSize(2, QuietZoneModules.Two), Brushes.Black, Brushes.White)
        Dim Stream As New MemoryStream()
        Renderer.WriteToStream(Code.Matrix, Imaging.ImageFormat.Bmp, Stream)
        Return Image.FromStream(Stream)
    End Function

    Public Sub ScaleBitmap(ByVal Picture As Bitmap, ByVal ScaleFactor As Single, ByVal e As PaintEventArgs)
        For Y As Integer = 0 To Picture.Height - 1
            For X As Integer = 0 To Picture.Width - 1
                Dim PixelColor As Color = Picture.GetPixel(X, Y)
                e.Graphics.FillRectangle(New SolidBrush(PixelColor), New RectangleF(X * ScaleFactor, Y * ScaleFactor, ScaleFactor, ScaleFactor))
            Next
        Next
    End Sub

    Public Sub ScaleBitmap(ByVal Picture As Bitmap, ByVal ScaleFactor As Single, ByVal e As Printing.PrintPageEventArgs, Optional ByVal XPos As Single = 0, Optional ByVal YPos As Single = 0)
        For Y As Integer = 0 To Picture.Height - 1
            For X As Integer = 0 To Picture.Width - 1
                Dim PixelColor As Color = Picture.GetPixel(X, Y)
                e.Graphics.FillRectangle(New SolidBrush(PixelColor), New RectangleF(X * ScaleFactor + XPos, Y * ScaleFactor + YPos, ScaleFactor, ScaleFactor))
            Next
        Next
    End Sub
End Module
