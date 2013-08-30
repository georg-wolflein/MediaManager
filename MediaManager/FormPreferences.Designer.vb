<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPreferences
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPreferences))
        Me.TabControlMain = New System.Windows.Forms.TabControl
        Me.TabPageGeneral = New System.Windows.Forms.TabPage
        Me.GroupBoxWarnings = New System.Windows.Forms.GroupBox
        Me.CheckBoxShowExitConfirmation = New System.Windows.Forms.CheckBox
        Me.GroupBoxMediaDatabase = New System.Windows.Forms.GroupBox
        Me.ButtonMediaDatabaseFileNameBrowse = New System.Windows.Forms.Button
        Me.LabelMediaDatabaseFileName = New System.Windows.Forms.Label
        Me.TextBoxMediaDatabaseFileName = New System.Windows.Forms.TextBox
        Me.GroupBoxLanguage = New System.Windows.Forms.GroupBox
        Me.ComboBoxLanguage = New System.Windows.Forms.ComboBox
        Me.LabelLanguage = New System.Windows.Forms.Label
        Me.TabPageDisplay = New System.Windows.Forms.TabPage
        Me.GroupBoxMainWindow = New System.Windows.Forms.GroupBox
        Me.CheckBoxRestoreMainWindow = New System.Windows.Forms.CheckBox
        Me.ButtonSave = New System.Windows.Forms.Button
        Me.TabControlMain.SuspendLayout()
        Me.TabPageGeneral.SuspendLayout()
        Me.GroupBoxWarnings.SuspendLayout()
        Me.GroupBoxMediaDatabase.SuspendLayout()
        Me.GroupBoxLanguage.SuspendLayout()
        Me.TabPageDisplay.SuspendLayout()
        Me.GroupBoxMainWindow.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControlMain
        '
        Me.TabControlMain.AccessibleDescription = Nothing
        Me.TabControlMain.AccessibleName = Nothing
        resources.ApplyResources(Me.TabControlMain, "TabControlMain")
        Me.TabControlMain.BackgroundImage = Nothing
        Me.TabControlMain.Controls.Add(Me.TabPageGeneral)
        Me.TabControlMain.Controls.Add(Me.TabPageDisplay)
        Me.TabControlMain.Font = Nothing
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.AccessibleDescription = Nothing
        Me.TabPageGeneral.AccessibleName = Nothing
        resources.ApplyResources(Me.TabPageGeneral, "TabPageGeneral")
        Me.TabPageGeneral.BackgroundImage = Nothing
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxWarnings)
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxMediaDatabase)
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxLanguage)
        Me.TabPageGeneral.Font = Nothing
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'GroupBoxWarnings
        '
        Me.GroupBoxWarnings.AccessibleDescription = Nothing
        Me.GroupBoxWarnings.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBoxWarnings, "GroupBoxWarnings")
        Me.GroupBoxWarnings.BackgroundImage = Nothing
        Me.GroupBoxWarnings.Controls.Add(Me.CheckBoxShowExitConfirmation)
        Me.GroupBoxWarnings.Font = Nothing
        Me.GroupBoxWarnings.Name = "GroupBoxWarnings"
        Me.GroupBoxWarnings.TabStop = False
        '
        'CheckBoxShowExitConfirmation
        '
        Me.CheckBoxShowExitConfirmation.AccessibleDescription = Nothing
        Me.CheckBoxShowExitConfirmation.AccessibleName = Nothing
        resources.ApplyResources(Me.CheckBoxShowExitConfirmation, "CheckBoxShowExitConfirmation")
        Me.CheckBoxShowExitConfirmation.BackgroundImage = Nothing
        Me.CheckBoxShowExitConfirmation.Font = Nothing
        Me.CheckBoxShowExitConfirmation.Name = "CheckBoxShowExitConfirmation"
        Me.CheckBoxShowExitConfirmation.UseVisualStyleBackColor = True
        '
        'GroupBoxMediaDatabase
        '
        Me.GroupBoxMediaDatabase.AccessibleDescription = Nothing
        Me.GroupBoxMediaDatabase.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBoxMediaDatabase, "GroupBoxMediaDatabase")
        Me.GroupBoxMediaDatabase.BackgroundImage = Nothing
        Me.GroupBoxMediaDatabase.Controls.Add(Me.ButtonMediaDatabaseFileNameBrowse)
        Me.GroupBoxMediaDatabase.Controls.Add(Me.LabelMediaDatabaseFileName)
        Me.GroupBoxMediaDatabase.Controls.Add(Me.TextBoxMediaDatabaseFileName)
        Me.GroupBoxMediaDatabase.Font = Nothing
        Me.GroupBoxMediaDatabase.Name = "GroupBoxMediaDatabase"
        Me.GroupBoxMediaDatabase.TabStop = False
        '
        'ButtonMediaDatabaseFileNameBrowse
        '
        Me.ButtonMediaDatabaseFileNameBrowse.AccessibleDescription = Nothing
        Me.ButtonMediaDatabaseFileNameBrowse.AccessibleName = Nothing
        resources.ApplyResources(Me.ButtonMediaDatabaseFileNameBrowse, "ButtonMediaDatabaseFileNameBrowse")
        Me.ButtonMediaDatabaseFileNameBrowse.BackgroundImage = Nothing
        Me.ButtonMediaDatabaseFileNameBrowse.Font = Nothing
        Me.ButtonMediaDatabaseFileNameBrowse.Name = "ButtonMediaDatabaseFileNameBrowse"
        Me.ButtonMediaDatabaseFileNameBrowse.UseVisualStyleBackColor = True
        '
        'LabelMediaDatabaseFileName
        '
        Me.LabelMediaDatabaseFileName.AccessibleDescription = Nothing
        Me.LabelMediaDatabaseFileName.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelMediaDatabaseFileName, "LabelMediaDatabaseFileName")
        Me.LabelMediaDatabaseFileName.Font = Nothing
        Me.LabelMediaDatabaseFileName.Name = "LabelMediaDatabaseFileName"
        '
        'TextBoxMediaDatabaseFileName
        '
        Me.TextBoxMediaDatabaseFileName.AccessibleDescription = Nothing
        Me.TextBoxMediaDatabaseFileName.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxMediaDatabaseFileName, "TextBoxMediaDatabaseFileName")
        Me.TextBoxMediaDatabaseFileName.BackgroundImage = Nothing
        Me.TextBoxMediaDatabaseFileName.Font = Nothing
        Me.TextBoxMediaDatabaseFileName.Name = "TextBoxMediaDatabaseFileName"
        '
        'GroupBoxLanguage
        '
        Me.GroupBoxLanguage.AccessibleDescription = Nothing
        Me.GroupBoxLanguage.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBoxLanguage, "GroupBoxLanguage")
        Me.GroupBoxLanguage.BackgroundImage = Nothing
        Me.GroupBoxLanguage.Controls.Add(Me.ComboBoxLanguage)
        Me.GroupBoxLanguage.Controls.Add(Me.LabelLanguage)
        Me.GroupBoxLanguage.Font = Nothing
        Me.GroupBoxLanguage.Name = "GroupBoxLanguage"
        Me.GroupBoxLanguage.TabStop = False
        '
        'ComboBoxLanguage
        '
        Me.ComboBoxLanguage.AccessibleDescription = Nothing
        Me.ComboBoxLanguage.AccessibleName = Nothing
        resources.ApplyResources(Me.ComboBoxLanguage, "ComboBoxLanguage")
        Me.ComboBoxLanguage.BackgroundImage = Nothing
        Me.ComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLanguage.Font = Nothing
        Me.ComboBoxLanguage.FormattingEnabled = True
        Me.ComboBoxLanguage.Name = "ComboBoxLanguage"
        '
        'LabelLanguage
        '
        Me.LabelLanguage.AccessibleDescription = Nothing
        Me.LabelLanguage.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelLanguage, "LabelLanguage")
        Me.LabelLanguage.Font = Nothing
        Me.LabelLanguage.Name = "LabelLanguage"
        '
        'TabPageDisplay
        '
        Me.TabPageDisplay.AccessibleDescription = Nothing
        Me.TabPageDisplay.AccessibleName = Nothing
        resources.ApplyResources(Me.TabPageDisplay, "TabPageDisplay")
        Me.TabPageDisplay.BackgroundImage = Nothing
        Me.TabPageDisplay.Controls.Add(Me.GroupBoxMainWindow)
        Me.TabPageDisplay.Font = Nothing
        Me.TabPageDisplay.Name = "TabPageDisplay"
        Me.TabPageDisplay.UseVisualStyleBackColor = True
        '
        'GroupBoxMainWindow
        '
        Me.GroupBoxMainWindow.AccessibleDescription = Nothing
        Me.GroupBoxMainWindow.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBoxMainWindow, "GroupBoxMainWindow")
        Me.GroupBoxMainWindow.BackgroundImage = Nothing
        Me.GroupBoxMainWindow.Controls.Add(Me.CheckBoxRestoreMainWindow)
        Me.GroupBoxMainWindow.Font = Nothing
        Me.GroupBoxMainWindow.Name = "GroupBoxMainWindow"
        Me.GroupBoxMainWindow.TabStop = False
        '
        'CheckBoxRestoreMainWindow
        '
        Me.CheckBoxRestoreMainWindow.AccessibleDescription = Nothing
        Me.CheckBoxRestoreMainWindow.AccessibleName = Nothing
        resources.ApplyResources(Me.CheckBoxRestoreMainWindow, "CheckBoxRestoreMainWindow")
        Me.CheckBoxRestoreMainWindow.BackgroundImage = Nothing
        Me.CheckBoxRestoreMainWindow.Font = Nothing
        Me.CheckBoxRestoreMainWindow.Name = "CheckBoxRestoreMainWindow"
        Me.CheckBoxRestoreMainWindow.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        Me.ButtonSave.AccessibleDescription = Nothing
        Me.ButtonSave.AccessibleName = Nothing
        resources.ApplyResources(Me.ButtonSave, "ButtonSave")
        Me.ButtonSave.BackgroundImage = Nothing
        Me.ButtonSave.Font = Nothing
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'FormPreferences
        '
        Me.AcceptButton = Me.ButtonSave
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.ButtonSave)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "FormPreferences"
        Me.TabControlMain.ResumeLayout(False)
        Me.TabPageGeneral.ResumeLayout(False)
        Me.GroupBoxWarnings.ResumeLayout(False)
        Me.GroupBoxWarnings.PerformLayout()
        Me.GroupBoxMediaDatabase.ResumeLayout(False)
        Me.GroupBoxMediaDatabase.PerformLayout()
        Me.GroupBoxLanguage.ResumeLayout(False)
        Me.GroupBoxLanguage.PerformLayout()
        Me.TabPageDisplay.ResumeLayout(False)
        Me.GroupBoxMainWindow.ResumeLayout(False)
        Me.GroupBoxMainWindow.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControlMain As System.Windows.Forms.TabControl
    Friend WithEvents TabPageGeneral As System.Windows.Forms.TabPage
    Friend WithEvents ButtonSave As System.Windows.Forms.Button
    Friend WithEvents GroupBoxLanguage As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBoxLanguage As System.Windows.Forms.ComboBox
    Friend WithEvents LabelLanguage As System.Windows.Forms.Label
    Friend WithEvents TabPageDisplay As System.Windows.Forms.TabPage
    Friend WithEvents GroupBoxMainWindow As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxRestoreMainWindow As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBoxMediaDatabase As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonMediaDatabaseFileNameBrowse As System.Windows.Forms.Button
    Friend WithEvents LabelMediaDatabaseFileName As System.Windows.Forms.Label
    Friend WithEvents TextBoxMediaDatabaseFileName As System.Windows.Forms.TextBox
    Friend WithEvents GroupBoxWarnings As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxShowExitConfirmation As System.Windows.Forms.CheckBox
End Class
