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
        Me.TabControlMain.Controls.Add(Me.TabPageGeneral)
        Me.TabControlMain.Controls.Add(Me.TabPageDisplay)
        resources.ApplyResources(Me.TabControlMain, "TabControlMain")
        Me.TabControlMain.Name = "TabControlMain"
        Me.TabControlMain.SelectedIndex = 0
        '
        'TabPageGeneral
        '
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxWarnings)
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxMediaDatabase)
        Me.TabPageGeneral.Controls.Add(Me.GroupBoxLanguage)
        resources.ApplyResources(Me.TabPageGeneral, "TabPageGeneral")
        Me.TabPageGeneral.Name = "TabPageGeneral"
        Me.TabPageGeneral.UseVisualStyleBackColor = True
        '
        'GroupBoxWarnings
        '
        Me.GroupBoxWarnings.Controls.Add(Me.CheckBoxShowExitConfirmation)
        resources.ApplyResources(Me.GroupBoxWarnings, "GroupBoxWarnings")
        Me.GroupBoxWarnings.Name = "GroupBoxWarnings"
        Me.GroupBoxWarnings.TabStop = False
        '
        'CheckBoxShowExitConfirmation
        '
        resources.ApplyResources(Me.CheckBoxShowExitConfirmation, "CheckBoxShowExitConfirmation")
        Me.CheckBoxShowExitConfirmation.Name = "CheckBoxShowExitConfirmation"
        Me.CheckBoxShowExitConfirmation.UseVisualStyleBackColor = True
        '
        'GroupBoxMediaDatabase
        '
        Me.GroupBoxMediaDatabase.Controls.Add(Me.ButtonMediaDatabaseFileNameBrowse)
        Me.GroupBoxMediaDatabase.Controls.Add(Me.LabelMediaDatabaseFileName)
        Me.GroupBoxMediaDatabase.Controls.Add(Me.TextBoxMediaDatabaseFileName)
        resources.ApplyResources(Me.GroupBoxMediaDatabase, "GroupBoxMediaDatabase")
        Me.GroupBoxMediaDatabase.Name = "GroupBoxMediaDatabase"
        Me.GroupBoxMediaDatabase.TabStop = False
        '
        'ButtonMediaDatabaseFileNameBrowse
        '
        resources.ApplyResources(Me.ButtonMediaDatabaseFileNameBrowse, "ButtonMediaDatabaseFileNameBrowse")
        Me.ButtonMediaDatabaseFileNameBrowse.Name = "ButtonMediaDatabaseFileNameBrowse"
        Me.ButtonMediaDatabaseFileNameBrowse.UseVisualStyleBackColor = True
        '
        'LabelMediaDatabaseFileName
        '
        resources.ApplyResources(Me.LabelMediaDatabaseFileName, "LabelMediaDatabaseFileName")
        Me.LabelMediaDatabaseFileName.Name = "LabelMediaDatabaseFileName"
        '
        'TextBoxMediaDatabaseFileName
        '
        resources.ApplyResources(Me.TextBoxMediaDatabaseFileName, "TextBoxMediaDatabaseFileName")
        Me.TextBoxMediaDatabaseFileName.Name = "TextBoxMediaDatabaseFileName"
        '
        'GroupBoxLanguage
        '
        Me.GroupBoxLanguage.Controls.Add(Me.ComboBoxLanguage)
        Me.GroupBoxLanguage.Controls.Add(Me.LabelLanguage)
        resources.ApplyResources(Me.GroupBoxLanguage, "GroupBoxLanguage")
        Me.GroupBoxLanguage.Name = "GroupBoxLanguage"
        Me.GroupBoxLanguage.TabStop = False
        '
        'ComboBoxLanguage
        '
        Me.ComboBoxLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBoxLanguage.FormattingEnabled = True
        resources.ApplyResources(Me.ComboBoxLanguage, "ComboBoxLanguage")
        Me.ComboBoxLanguage.Name = "ComboBoxLanguage"
        '
        'LabelLanguage
        '
        resources.ApplyResources(Me.LabelLanguage, "LabelLanguage")
        Me.LabelLanguage.Name = "LabelLanguage"
        '
        'TabPageDisplay
        '
        Me.TabPageDisplay.Controls.Add(Me.GroupBoxMainWindow)
        resources.ApplyResources(Me.TabPageDisplay, "TabPageDisplay")
        Me.TabPageDisplay.Name = "TabPageDisplay"
        Me.TabPageDisplay.UseVisualStyleBackColor = True
        '
        'GroupBoxMainWindow
        '
        Me.GroupBoxMainWindow.Controls.Add(Me.CheckBoxRestoreMainWindow)
        resources.ApplyResources(Me.GroupBoxMainWindow, "GroupBoxMainWindow")
        Me.GroupBoxMainWindow.Name = "GroupBoxMainWindow"
        Me.GroupBoxMainWindow.TabStop = False
        '
        'CheckBoxRestoreMainWindow
        '
        resources.ApplyResources(Me.CheckBoxRestoreMainWindow, "CheckBoxRestoreMainWindow")
        Me.CheckBoxRestoreMainWindow.Name = "CheckBoxRestoreMainWindow"
        Me.CheckBoxRestoreMainWindow.UseVisualStyleBackColor = True
        '
        'ButtonSave
        '
        resources.ApplyResources(Me.ButtonSave, "ButtonSave")
        Me.ButtonSave.Name = "ButtonSave"
        Me.ButtonSave.UseVisualStyleBackColor = True
        '
        'FormPreferences
        '
        Me.AcceptButton = Me.ButtonSave
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TabControlMain)
        Me.Controls.Add(Me.ButtonSave)
        Me.Name = "FormPreferences"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
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
