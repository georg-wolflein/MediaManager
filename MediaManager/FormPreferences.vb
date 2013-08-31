Imports System.Globalization
Imports System.Threading
Imports Microsoft.WindowsAPICodePack.Dialogs

Public Class FormPreferences

    Public Enum SaveAction As Short
        SaveAndExit
        SaveOnly
        SaveAndClose
        Cancel
        LetUserChoose
    End Enum

    Private SupportedCultures As String() = {"en-GB", "de"}
    Public FormSaveAction As SaveAction = SaveAction.LetUserChoose

    Sub New(Optional ByVal SaveAction As SaveAction = SaveAction.LetUserChoose)
        InitializeComponent()
        FormSaveAction = SaveAction
    End Sub

    Private Sub FormPreferences_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.ConfigureWindow(Me)
        LoadSettings()
    End Sub

    Private Sub LoadSettings()
        LoadCulture()
        TextBoxMediaDatabaseFileName.Text = My.Settings.MediaDatabaseFile
        CheckBoxShowExitConfirmation.Checked = My.Settings.ShowQuitWarning
        CheckBoxRestoreMainWindow.Checked = My.Settings.LoadLastFormSizes
    End Sub

    Private Sub LoadCulture()
        ComboBoxLanguage.Items.Clear()
        For i As Integer = 0 To SupportedCultures.Length - 1
            Dim Culture As New CultureInfo(SupportedCultures(i))
            ComboBoxLanguage.Items.Add(Culture.NativeName)
            If Culture.Name = Thread.CurrentThread.CurrentUICulture.Name Then ComboBoxLanguage.SelectedIndex = i
        Next
    End Sub

    Private Function GetCultureInfo(ByVal NativeName As String) As CultureInfo
        For Each Culture As CultureInfo In CultureInfo.GetCultures(CultureTypes.AllCultures)
            If Culture.NativeName = NativeName Then
                Return New CultureInfo(Culture.Name)
            End If
        Next
        Return Nothing
    End Function

    Private Sub ButtonMediaDatabaseFileNameBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonMediaDatabaseFileNameBrowse.Click
        Dim Dialog As New OpenFileDialog()
        Dim Result As DialogResult
        With Dialog
            .FileName = TextBoxMediaDatabaseFileName.Text
            .Filter = "Comma-Separated Values (CSV) file (*.csv)|*.csv|All files|*"
            .Multiselect = False
            .CheckFileExists = True
            Result = .ShowDialog()
        End With

        If Result = Windows.Forms.DialogResult.OK Or Result = Windows.Forms.DialogResult.Yes Then
            TextBoxMediaDatabaseFileName.Text = Dialog.FileName
        End If
    End Sub

    Private SaveConfirmation As TaskDialog

    Public Sub ExecuteSaveAction()
        Select Case FormSaveAction
            Case SaveAction.SaveAndExit
                SaveSettings()
                Application.ExitThread()
            Case SaveAction.SaveOnly
                SaveSettings()
            Case SaveAction.SaveAndClose
                SaveSettings()
                Me.Close()
            Case SaveAction.Cancel
            Case SaveAction.LetUserChoose
                ShowExitConfirmation()
        End Select
        FormSaveAction = SaveAction.LetUserChoose
    End Sub

    Private Sub ButtonSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSave.Click
        ExecuteSaveAction()
    End Sub

    Sub ShowExitConfirmation()
        SaveConfirmation = New TaskDialog()
        AddHandler SaveConfirmation.Opened, AddressOf SaveConfirmation_Opened

        Dim SaveAndQuitButton As New TaskDialogCommandLink("SaveAndExit", "Save and exit", "Save and exit the application")
        Dim SaveOnlyButton As New TaskDialogCommandLink("SaveOnly", "Save only", "Save and let the preferences window open")
        Dim SaveAndCloseButton As New TaskDialogCommandLink("SaveAndClose", "Save and close", "Save and close the preferences window")
        Dim CancelButton As New TaskDialogCommandLink("Cancel", "Cancel", "Do not save, do nothing")
        AddHandler SaveAndQuitButton.Click, AddressOf SaveConfirmationButton_Click
        AddHandler SaveOnlyButton.Click, AddressOf SaveConfirmationButton_Click
        AddHandler SaveAndCloseButton.Click, AddressOf SaveConfirmationButton_Click
        AddHandler CancelButton.Click, AddressOf SaveConfirmationButton_Click


        With SaveConfirmation
            .Cancelable = False
            .Caption = Main.GetWindowText("Save Preferences")
            .Text = "How do you want to proceed?"
            .InstructionText = "Most preferences will only come into effect if you quit the application entirely and then reopen it."

            .Controls.Add(SaveAndQuitButton)
            .Controls.Add(SaveOnlyButton)
            .Controls.Add(SaveAndCloseButton)
            .Controls.Add(CancelButton)

            Me.Enabled = False
            .Show()
        End With
    End Sub

    Private Sub SaveConfirmation_Opened(ByVal sender As Object, ByVal e As EventArgs)
        SaveConfirmation.Icon = TaskDialogStandardIcon.Information
    End Sub

    Private Sub SaveConfirmationButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim Button As TaskDialogCommandLink = TryCast(sender, TaskDialogCommandLink)
        SaveConfirmation.Close()
        Me.Enabled = True
        Select Case Button.Name
            Case "SaveAndExit"
                FormSaveAction = SaveAction.SaveAndExit
            Case "SaveOnly"
                FormSaveAction = SaveAction.SaveOnly
            Case "SaveAndClose"
                FormSaveAction = SaveAction.SaveAndClose
            Case "Cancel"
                FormSaveAction = SaveAction.Cancel
        End Select
        ExecuteSaveAction()
    End Sub

    Private Sub SaveSettings()
        My.Settings.Culture = GetCultureInfo(ComboBoxLanguage.Text)
        My.Settings.MediaDatabaseFile = TextBoxMediaDatabaseFileName.Text
        My.Settings.ShowQuitWarning = CheckBoxShowExitConfirmation.Checked
        My.Settings.LoadLastFormSizes = CheckBoxRestoreMainWindow.Checked
    End Sub
End Class