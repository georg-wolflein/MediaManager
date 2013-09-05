<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSplashScreen
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
        Me.LabelAppName = New System.Windows.Forms.Label
        Me.LabelAppDescription = New System.Windows.Forms.Label
        Me.LabelAppVersion = New System.Windows.Forms.Label
        Me.LabelAppCopyright = New System.Windows.Forms.Label
        Me.LabelProgress = New System.Windows.Forms.Label
        Me.ProgressBarProgress = New System.Windows.Forms.ProgressBar
        Me.SuspendLayout()
        '
        'LabelAppName
        '
        Me.LabelAppName.AutoSize = True
        Me.LabelAppName.Font = New System.Drawing.Font("Microsoft Sans Serif", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppName.Location = New System.Drawing.Point(1, 9)
        Me.LabelAppName.Name = "LabelAppName"
        Me.LabelAppName.Size = New System.Drawing.Size(280, 39)
        Me.LabelAppName.TabIndex = 0
        Me.LabelAppName.Text = "ApplicationName"
        '
        'LabelAppDescription
        '
        Me.LabelAppDescription.AutoSize = True
        Me.LabelAppDescription.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelAppDescription.Location = New System.Drawing.Point(5, 48)
        Me.LabelAppDescription.Name = "LabelAppDescription"
        Me.LabelAppDescription.Size = New System.Drawing.Size(143, 16)
        Me.LabelAppDescription.TabIndex = 1
        Me.LabelAppDescription.Text = "ApplicationDescription"
        '
        'LabelAppVersion
        '
        Me.LabelAppVersion.AutoSize = True
        Me.LabelAppVersion.Location = New System.Drawing.Point(5, 79)
        Me.LabelAppVersion.Name = "LabelAppVersion"
        Me.LabelAppVersion.Size = New System.Drawing.Size(94, 13)
        Me.LabelAppVersion.TabIndex = 2
        Me.LabelAppVersion.Text = "ApplicationVersion"
        '
        'LabelAppCopyright
        '
        Me.LabelAppCopyright.AutoSize = True
        Me.LabelAppCopyright.Location = New System.Drawing.Point(5, 92)
        Me.LabelAppCopyright.Name = "LabelAppCopyright"
        Me.LabelAppCopyright.Size = New System.Drawing.Size(103, 13)
        Me.LabelAppCopyright.TabIndex = 3
        Me.LabelAppCopyright.Text = "ApplicationCopyright"
        '
        'LabelProgress
        '
        Me.LabelProgress.AutoSize = True
        Me.LabelProgress.Location = New System.Drawing.Point(5, 140)
        Me.LabelProgress.Name = "LabelProgress"
        Me.LabelProgress.Size = New System.Drawing.Size(54, 13)
        Me.LabelProgress.TabIndex = 4
        Me.LabelProgress.Text = "Loading..."
        '
        'ProgressBarProgress
        '
        Me.ProgressBarProgress.Location = New System.Drawing.Point(8, 156)
        Me.ProgressBarProgress.Name = "ProgressBarProgress"
        Me.ProgressBarProgress.Size = New System.Drawing.Size(360, 17)
        Me.ProgressBarProgress.Style = System.Windows.Forms.ProgressBarStyle.Continuous
        Me.ProgressBarProgress.TabIndex = 5
        '
        'FormSplashScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightBlue
        Me.ClientSize = New System.Drawing.Size(375, 185)
        Me.ControlBox = False
        Me.Controls.Add(Me.ProgressBarProgress)
        Me.Controls.Add(Me.LabelProgress)
        Me.Controls.Add(Me.LabelAppCopyright)
        Me.Controls.Add(Me.LabelAppVersion)
        Me.Controls.Add(Me.LabelAppDescription)
        Me.Controls.Add(Me.LabelAppName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormSplashScreen"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "FormSplashScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelAppName As System.Windows.Forms.Label
    Friend WithEvents LabelAppDescription As System.Windows.Forms.Label
    Friend WithEvents LabelAppVersion As System.Windows.Forms.Label
    Friend WithEvents LabelAppCopyright As System.Windows.Forms.Label
    Public WithEvents LabelProgress As System.Windows.Forms.Label
    Public WithEvents ProgressBarProgress As System.Windows.Forms.ProgressBar
End Class
