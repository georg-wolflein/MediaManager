<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormAbout
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormAbout))
        Me.LabelAppCopyright = New System.Windows.Forms.Label
        Me.LabelAppVersion = New System.Windows.Forms.Label
        Me.LabelAppDescription = New System.Windows.Forms.Label
        Me.LabelAppName = New System.Windows.Forms.Label
        Me.ButtonOk = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'LabelAppCopyright
        '
        resources.ApplyResources(Me.LabelAppCopyright, "LabelAppCopyright")
        Me.LabelAppCopyright.Name = "LabelAppCopyright"
        '
        'LabelAppVersion
        '
        resources.ApplyResources(Me.LabelAppVersion, "LabelAppVersion")
        Me.LabelAppVersion.Name = "LabelAppVersion"
        '
        'LabelAppDescription
        '
        resources.ApplyResources(Me.LabelAppDescription, "LabelAppDescription")
        Me.LabelAppDescription.Name = "LabelAppDescription"
        '
        'LabelAppName
        '
        resources.ApplyResources(Me.LabelAppName, "LabelAppName")
        Me.LabelAppName.Name = "LabelAppName"
        '
        'ButtonOk
        '
        resources.ApplyResources(Me.ButtonOk, "ButtonOk")
        Me.ButtonOk.Name = "ButtonOk"
        Me.ButtonOk.UseVisualStyleBackColor = True
        '
        'FormAbout
        '
        Me.AcceptButton = Me.ButtonOk
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ControlBox = False
        Me.Controls.Add(Me.ButtonOk)
        Me.Controls.Add(Me.LabelAppCopyright)
        Me.Controls.Add(Me.LabelAppVersion)
        Me.Controls.Add(Me.LabelAppDescription)
        Me.Controls.Add(Me.LabelAppName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "FormAbout"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelAppCopyright As System.Windows.Forms.Label
    Friend WithEvents LabelAppVersion As System.Windows.Forms.Label
    Friend WithEvents LabelAppDescription As System.Windows.Forms.Label
    Friend WithEvents LabelAppName As System.Windows.Forms.Label
    Friend WithEvents ButtonOk As System.Windows.Forms.Button
End Class
