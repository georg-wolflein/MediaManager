<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormEditItem
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormEditItem))
        Me.LabelItemLocation = New System.Windows.Forms.Label
        Me.TextBoxItemLocation = New System.Windows.Forms.TextBox
        Me.LabelItemNumCds = New System.Windows.Forms.Label
        Me.PictureBoxQrCode = New System.Windows.Forms.PictureBox
        Me.LabelItemComments = New System.Windows.Forms.Label
        Me.TextBoxItemComments = New System.Windows.Forms.TextBox
        Me.LabelItemArtist = New System.Windows.Forms.Label
        Me.TextBoxItemName = New System.Windows.Forms.TextBox
        Me.TextBoxItemNumCds = New System.Windows.Forms.TextBox
        Me.LabelItemVolume = New System.Windows.Forms.Label
        Me.LabelItemName = New System.Windows.Forms.Label
        Me.TextBoxItemArtist = New System.Windows.Forms.TextBox
        Me.TextBoxItemVolumeName = New System.Windows.Forms.TextBox
        Me.TextBoxItemVolume = New System.Windows.Forms.TextBox
        Me.LabelItemMediaId = New System.Windows.Forms.Label
        Me.TextBoxItemMediaId = New System.Windows.Forms.TextBox
        Me.ButtonSaveAndExit = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        CType(Me.PictureBoxQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelItemLocation
        '
        Me.LabelItemLocation.AccessibleDescription = Nothing
        Me.LabelItemLocation.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelItemLocation, "LabelItemLocation")
        Me.LabelItemLocation.Font = Nothing
        Me.LabelItemLocation.Name = "LabelItemLocation"
        '
        'TextBoxItemLocation
        '
        Me.TextBoxItemLocation.AccessibleDescription = Nothing
        Me.TextBoxItemLocation.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemLocation, "TextBoxItemLocation")
        Me.TextBoxItemLocation.BackgroundImage = Nothing
        Me.TextBoxItemLocation.Font = Nothing
        Me.TextBoxItemLocation.Name = "TextBoxItemLocation"
        '
        'LabelItemNumCds
        '
        Me.LabelItemNumCds.AccessibleDescription = Nothing
        Me.LabelItemNumCds.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelItemNumCds, "LabelItemNumCds")
        Me.LabelItemNumCds.Font = Nothing
        Me.LabelItemNumCds.Name = "LabelItemNumCds"
        '
        'PictureBoxQrCode
        '
        Me.PictureBoxQrCode.AccessibleDescription = Nothing
        Me.PictureBoxQrCode.AccessibleName = Nothing
        resources.ApplyResources(Me.PictureBoxQrCode, "PictureBoxQrCode")
        Me.PictureBoxQrCode.BackgroundImage = Nothing
        Me.PictureBoxQrCode.Font = Nothing
        Me.PictureBoxQrCode.ImageLocation = Nothing
        Me.PictureBoxQrCode.Name = "PictureBoxQrCode"
        Me.PictureBoxQrCode.TabStop = False
        '
        'LabelItemComments
        '
        Me.LabelItemComments.AccessibleDescription = Nothing
        Me.LabelItemComments.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelItemComments, "LabelItemComments")
        Me.LabelItemComments.Font = Nothing
        Me.LabelItemComments.Name = "LabelItemComments"
        '
        'TextBoxItemComments
        '
        Me.TextBoxItemComments.AccessibleDescription = Nothing
        Me.TextBoxItemComments.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemComments, "TextBoxItemComments")
        Me.TextBoxItemComments.BackgroundImage = Nothing
        Me.TextBoxItemComments.Font = Nothing
        Me.TextBoxItemComments.Name = "TextBoxItemComments"
        '
        'LabelItemArtist
        '
        Me.LabelItemArtist.AccessibleDescription = Nothing
        Me.LabelItemArtist.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelItemArtist, "LabelItemArtist")
        Me.LabelItemArtist.Font = Nothing
        Me.LabelItemArtist.Name = "LabelItemArtist"
        '
        'TextBoxItemName
        '
        Me.TextBoxItemName.AccessibleDescription = Nothing
        Me.TextBoxItemName.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemName, "TextBoxItemName")
        Me.TextBoxItemName.BackgroundImage = Nothing
        Me.TextBoxItemName.Font = Nothing
        Me.TextBoxItemName.Name = "TextBoxItemName"
        '
        'TextBoxItemNumCds
        '
        Me.TextBoxItemNumCds.AccessibleDescription = Nothing
        Me.TextBoxItemNumCds.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemNumCds, "TextBoxItemNumCds")
        Me.TextBoxItemNumCds.BackgroundImage = Nothing
        Me.TextBoxItemNumCds.Font = Nothing
        Me.TextBoxItemNumCds.Name = "TextBoxItemNumCds"
        '
        'LabelItemVolume
        '
        Me.LabelItemVolume.AccessibleDescription = Nothing
        Me.LabelItemVolume.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelItemVolume, "LabelItemVolume")
        Me.LabelItemVolume.Font = Nothing
        Me.LabelItemVolume.Name = "LabelItemVolume"
        '
        'LabelItemName
        '
        Me.LabelItemName.AccessibleDescription = Nothing
        Me.LabelItemName.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelItemName, "LabelItemName")
        Me.LabelItemName.Font = Nothing
        Me.LabelItemName.Name = "LabelItemName"
        '
        'TextBoxItemArtist
        '
        Me.TextBoxItemArtist.AccessibleDescription = Nothing
        Me.TextBoxItemArtist.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemArtist, "TextBoxItemArtist")
        Me.TextBoxItemArtist.BackgroundImage = Nothing
        Me.TextBoxItemArtist.Font = Nothing
        Me.TextBoxItemArtist.Name = "TextBoxItemArtist"
        '
        'TextBoxItemVolumeName
        '
        Me.TextBoxItemVolumeName.AccessibleDescription = Nothing
        Me.TextBoxItemVolumeName.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemVolumeName, "TextBoxItemVolumeName")
        Me.TextBoxItemVolumeName.BackgroundImage = Nothing
        Me.TextBoxItemVolumeName.Font = Nothing
        Me.TextBoxItemVolumeName.Name = "TextBoxItemVolumeName"
        '
        'TextBoxItemVolume
        '
        Me.TextBoxItemVolume.AccessibleDescription = Nothing
        Me.TextBoxItemVolume.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemVolume, "TextBoxItemVolume")
        Me.TextBoxItemVolume.BackgroundImage = Nothing
        Me.TextBoxItemVolume.Font = Nothing
        Me.TextBoxItemVolume.Name = "TextBoxItemVolume"
        '
        'LabelItemMediaId
        '
        Me.LabelItemMediaId.AccessibleDescription = Nothing
        Me.LabelItemMediaId.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelItemMediaId, "LabelItemMediaId")
        Me.LabelItemMediaId.Font = Nothing
        Me.LabelItemMediaId.Name = "LabelItemMediaId"
        '
        'TextBoxItemMediaId
        '
        Me.TextBoxItemMediaId.AccessibleDescription = Nothing
        Me.TextBoxItemMediaId.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemMediaId, "TextBoxItemMediaId")
        Me.TextBoxItemMediaId.BackgroundImage = Nothing
        Me.TextBoxItemMediaId.Font = Nothing
        Me.TextBoxItemMediaId.Name = "TextBoxItemMediaId"
        Me.TextBoxItemMediaId.ReadOnly = True
        '
        'ButtonSaveAndExit
        '
        Me.ButtonSaveAndExit.AccessibleDescription = Nothing
        Me.ButtonSaveAndExit.AccessibleName = Nothing
        resources.ApplyResources(Me.ButtonSaveAndExit, "ButtonSaveAndExit")
        Me.ButtonSaveAndExit.BackgroundImage = Nothing
        Me.ButtonSaveAndExit.Font = Nothing
        Me.ButtonSaveAndExit.Name = "ButtonSaveAndExit"
        Me.ButtonSaveAndExit.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.AccessibleDescription = Nothing
        Me.ButtonCancel.AccessibleName = Nothing
        resources.ApplyResources(Me.ButtonCancel, "ButtonCancel")
        Me.ButtonCancel.BackgroundImage = Nothing
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.ButtonCancel.Font = Nothing
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'FormEditItem
        '
        Me.AcceptButton = Me.ButtonSaveAndExit
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.ButtonCancel
        Me.Controls.Add(Me.ButtonCancel)
        Me.Controls.Add(Me.ButtonSaveAndExit)
        Me.Controls.Add(Me.LabelItemLocation)
        Me.Controls.Add(Me.TextBoxItemLocation)
        Me.Controls.Add(Me.PictureBoxQrCode)
        Me.Controls.Add(Me.LabelItemNumCds)
        Me.Controls.Add(Me.TextBoxItemMediaId)
        Me.Controls.Add(Me.LabelItemMediaId)
        Me.Controls.Add(Me.LabelItemComments)
        Me.Controls.Add(Me.TextBoxItemVolume)
        Me.Controls.Add(Me.TextBoxItemComments)
        Me.Controls.Add(Me.TextBoxItemVolumeName)
        Me.Controls.Add(Me.LabelItemArtist)
        Me.Controls.Add(Me.TextBoxItemArtist)
        Me.Controls.Add(Me.TextBoxItemName)
        Me.Controls.Add(Me.LabelItemName)
        Me.Controls.Add(Me.TextBoxItemNumCds)
        Me.Controls.Add(Me.LabelItemVolume)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormEditItem"
        CType(Me.PictureBoxQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelItemLocation As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemLocation As System.Windows.Forms.TextBox
    Friend WithEvents LabelItemNumCds As System.Windows.Forms.Label
    Friend WithEvents PictureBoxQrCode As System.Windows.Forms.PictureBox
    Friend WithEvents LabelItemComments As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemComments As System.Windows.Forms.TextBox
    Friend WithEvents LabelItemArtist As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemNumCds As System.Windows.Forms.TextBox
    Friend WithEvents LabelItemVolume As System.Windows.Forms.Label
    Friend WithEvents LabelItemName As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemArtist As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemVolumeName As System.Windows.Forms.TextBox
    Friend WithEvents TextBoxItemVolume As System.Windows.Forms.TextBox
    Friend WithEvents LabelItemMediaId As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemMediaId As System.Windows.Forms.TextBox
    Friend WithEvents ButtonSaveAndExit As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
End Class
