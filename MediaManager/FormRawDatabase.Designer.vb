<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRawDatabase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRawDatabase))
        Me.TextBoxRawDatabase = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'TextBoxRawDatabase
        '
        Me.TextBoxRawDatabase.AccessibleDescription = Nothing
        Me.TextBoxRawDatabase.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxRawDatabase, "TextBoxRawDatabase")
        Me.TextBoxRawDatabase.BackgroundImage = Nothing
        Me.TextBoxRawDatabase.Name = "TextBoxRawDatabase"
        Me.TextBoxRawDatabase.ReadOnly = True
        '
        'FormRawDatabase
        '
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.Controls.Add(Me.TextBoxRawDatabase)
        Me.Font = Nothing
        Me.Icon = Nothing
        Me.Name = "FormRawDatabase"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBoxRawDatabase As System.Windows.Forms.TextBox
End Class
