<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormPrint
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormPrint))
        Me.ListBoxItems = New System.Windows.Forms.ListBox
        Me.LabelConfirmation = New System.Windows.Forms.Label
        Me.GroupBoxItemsToPrint = New System.Windows.Forms.GroupBox
        Me.GroupBoxItemInfo = New System.Windows.Forms.GroupBox
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
        Me.ButtonPrint = New System.Windows.Forms.Button
        Me.ButtonCancel = New System.Windows.Forms.Button
        Me.PrintDialogMain = New System.Windows.Forms.PrintDialog
        Me.PrintPreviewControlMain = New System.Windows.Forms.PrintPreviewControl
        Me.PrintDocumentMain = New System.Drawing.Printing.PrintDocument
        Me.PageSetupDialogMain = New System.Windows.Forms.PageSetupDialog
        Me.GroupBoxPrintPreview = New System.Windows.Forms.GroupBox
        Me.ButtonPageSetup = New System.Windows.Forms.Button
        Me.TrackBarPrintPreviewZoom = New System.Windows.Forms.TrackBar
        Me.GroupBoxItemsToPrint.SuspendLayout()
        Me.GroupBoxItemInfo.SuspendLayout()
        CType(Me.PictureBoxQrCode, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBoxPrintPreview.SuspendLayout()
        CType(Me.TrackBarPrintPreviewZoom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListBoxItems
        '
        Me.ListBoxItems.AccessibleDescription = Nothing
        Me.ListBoxItems.AccessibleName = Nothing
        resources.ApplyResources(Me.ListBoxItems, "ListBoxItems")
        Me.ListBoxItems.BackgroundImage = Nothing
        Me.ListBoxItems.Font = Nothing
        Me.ListBoxItems.FormattingEnabled = True
        Me.ListBoxItems.Name = "ListBoxItems"
        '
        'LabelConfirmation
        '
        Me.LabelConfirmation.AccessibleDescription = Nothing
        Me.LabelConfirmation.AccessibleName = Nothing
        resources.ApplyResources(Me.LabelConfirmation, "LabelConfirmation")
        Me.LabelConfirmation.Font = Nothing
        Me.LabelConfirmation.Name = "LabelConfirmation"
        '
        'GroupBoxItemsToPrint
        '
        Me.GroupBoxItemsToPrint.AccessibleDescription = Nothing
        Me.GroupBoxItemsToPrint.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBoxItemsToPrint, "GroupBoxItemsToPrint")
        Me.GroupBoxItemsToPrint.BackgroundImage = Nothing
        Me.GroupBoxItemsToPrint.Controls.Add(Me.ListBoxItems)
        Me.GroupBoxItemsToPrint.Controls.Add(Me.LabelConfirmation)
        Me.GroupBoxItemsToPrint.Font = Nothing
        Me.GroupBoxItemsToPrint.Name = "GroupBoxItemsToPrint"
        Me.GroupBoxItemsToPrint.TabStop = False
        '
        'GroupBoxItemInfo
        '
        Me.GroupBoxItemInfo.AccessibleDescription = Nothing
        Me.GroupBoxItemInfo.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBoxItemInfo, "GroupBoxItemInfo")
        Me.GroupBoxItemInfo.BackgroundImage = Nothing
        Me.GroupBoxItemInfo.Controls.Add(Me.LabelItemLocation)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemLocation)
        Me.GroupBoxItemInfo.Controls.Add(Me.LabelItemNumCds)
        Me.GroupBoxItemInfo.Controls.Add(Me.PictureBoxQrCode)
        Me.GroupBoxItemInfo.Controls.Add(Me.LabelItemComments)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemComments)
        Me.GroupBoxItemInfo.Controls.Add(Me.LabelItemArtist)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemName)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemNumCds)
        Me.GroupBoxItemInfo.Controls.Add(Me.LabelItemVolume)
        Me.GroupBoxItemInfo.Controls.Add(Me.LabelItemName)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemArtist)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemVolumeName)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemVolume)
        Me.GroupBoxItemInfo.Controls.Add(Me.LabelItemMediaId)
        Me.GroupBoxItemInfo.Controls.Add(Me.TextBoxItemMediaId)
        Me.GroupBoxItemInfo.Font = Nothing
        Me.GroupBoxItemInfo.Name = "GroupBoxItemInfo"
        Me.GroupBoxItemInfo.TabStop = False
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
        Me.TextBoxItemLocation.ReadOnly = True
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
        Me.TextBoxItemComments.ReadOnly = True
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
        Me.TextBoxItemName.ReadOnly = True
        '
        'TextBoxItemNumCds
        '
        Me.TextBoxItemNumCds.AccessibleDescription = Nothing
        Me.TextBoxItemNumCds.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemNumCds, "TextBoxItemNumCds")
        Me.TextBoxItemNumCds.BackgroundImage = Nothing
        Me.TextBoxItemNumCds.Font = Nothing
        Me.TextBoxItemNumCds.Name = "TextBoxItemNumCds"
        Me.TextBoxItemNumCds.ReadOnly = True
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
        Me.TextBoxItemArtist.ReadOnly = True
        '
        'TextBoxItemVolumeName
        '
        Me.TextBoxItemVolumeName.AccessibleDescription = Nothing
        Me.TextBoxItemVolumeName.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemVolumeName, "TextBoxItemVolumeName")
        Me.TextBoxItemVolumeName.BackgroundImage = Nothing
        Me.TextBoxItemVolumeName.Font = Nothing
        Me.TextBoxItemVolumeName.Name = "TextBoxItemVolumeName"
        Me.TextBoxItemVolumeName.ReadOnly = True
        '
        'TextBoxItemVolume
        '
        Me.TextBoxItemVolume.AccessibleDescription = Nothing
        Me.TextBoxItemVolume.AccessibleName = Nothing
        resources.ApplyResources(Me.TextBoxItemVolume, "TextBoxItemVolume")
        Me.TextBoxItemVolume.BackgroundImage = Nothing
        Me.TextBoxItemVolume.Font = Nothing
        Me.TextBoxItemVolume.Name = "TextBoxItemVolume"
        Me.TextBoxItemVolume.ReadOnly = True
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
        'ButtonPrint
        '
        Me.ButtonPrint.AccessibleDescription = Nothing
        Me.ButtonPrint.AccessibleName = Nothing
        resources.ApplyResources(Me.ButtonPrint, "ButtonPrint")
        Me.ButtonPrint.BackgroundImage = Nothing
        Me.ButtonPrint.Font = Nothing
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.UseVisualStyleBackColor = True
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
        'PrintDialogMain
        '
        Me.PrintDialogMain.UseEXDialog = True
        '
        'PrintPreviewControlMain
        '
        Me.PrintPreviewControlMain.AccessibleDescription = Nothing
        Me.PrintPreviewControlMain.AccessibleName = Nothing
        resources.ApplyResources(Me.PrintPreviewControlMain, "PrintPreviewControlMain")
        Me.PrintPreviewControlMain.AutoZoom = False
        Me.PrintPreviewControlMain.BackgroundImage = Nothing
        Me.PrintPreviewControlMain.Document = Me.PrintDocumentMain
        Me.PrintPreviewControlMain.Font = Nothing
        Me.PrintPreviewControlMain.Name = "PrintPreviewControlMain"
        Me.PrintPreviewControlMain.Zoom = 0.27288280581693758
        '
        'PrintDocumentMain
        '
        '
        'PageSetupDialogMain
        '
        Me.PageSetupDialogMain.Document = Me.PrintDocumentMain
        Me.PageSetupDialogMain.EnableMetric = True
        '
        'GroupBoxPrintPreview
        '
        Me.GroupBoxPrintPreview.AccessibleDescription = Nothing
        Me.GroupBoxPrintPreview.AccessibleName = Nothing
        resources.ApplyResources(Me.GroupBoxPrintPreview, "GroupBoxPrintPreview")
        Me.GroupBoxPrintPreview.BackgroundImage = Nothing
        Me.GroupBoxPrintPreview.Controls.Add(Me.ButtonPageSetup)
        Me.GroupBoxPrintPreview.Controls.Add(Me.PrintPreviewControlMain)
        Me.GroupBoxPrintPreview.Controls.Add(Me.ButtonPrint)
        Me.GroupBoxPrintPreview.Controls.Add(Me.ButtonCancel)
        Me.GroupBoxPrintPreview.Controls.Add(Me.TrackBarPrintPreviewZoom)
        Me.GroupBoxPrintPreview.Font = Nothing
        Me.GroupBoxPrintPreview.Name = "GroupBoxPrintPreview"
        Me.GroupBoxPrintPreview.TabStop = False
        '
        'ButtonPageSetup
        '
        Me.ButtonPageSetup.AccessibleDescription = Nothing
        Me.ButtonPageSetup.AccessibleName = Nothing
        resources.ApplyResources(Me.ButtonPageSetup, "ButtonPageSetup")
        Me.ButtonPageSetup.BackgroundImage = Nothing
        Me.ButtonPageSetup.Font = Nothing
        Me.ButtonPageSetup.Name = "ButtonPageSetup"
        Me.ButtonPageSetup.UseVisualStyleBackColor = True
        '
        'TrackBarPrintPreviewZoom
        '
        Me.TrackBarPrintPreviewZoom.AccessibleDescription = Nothing
        Me.TrackBarPrintPreviewZoom.AccessibleName = Nothing
        resources.ApplyResources(Me.TrackBarPrintPreviewZoom, "TrackBarPrintPreviewZoom")
        Me.TrackBarPrintPreviewZoom.BackgroundImage = Nothing
        Me.TrackBarPrintPreviewZoom.Font = Nothing
        Me.TrackBarPrintPreviewZoom.Maximum = 100
        Me.TrackBarPrintPreviewZoom.Minimum = 1
        Me.TrackBarPrintPreviewZoom.Name = "TrackBarPrintPreviewZoom"
        Me.TrackBarPrintPreviewZoom.Value = 27
        '
        'FormPrint
        '
        Me.AcceptButton = Me.ButtonPrint
        Me.AccessibleDescription = Nothing
        Me.AccessibleName = Nothing
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Nothing
        Me.CancelButton = Me.ButtonCancel
        Me.Controls.Add(Me.GroupBoxPrintPreview)
        Me.Controls.Add(Me.GroupBoxItemInfo)
        Me.Controls.Add(Me.GroupBoxItemsToPrint)
        Me.Font = Nothing
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = Nothing
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrint"
        Me.ShowIcon = False
        Me.GroupBoxItemsToPrint.ResumeLayout(False)
        Me.GroupBoxItemsToPrint.PerformLayout()
        Me.GroupBoxItemInfo.ResumeLayout(False)
        Me.GroupBoxItemInfo.PerformLayout()
        CType(Me.PictureBoxQrCode, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBoxPrintPreview.ResumeLayout(False)
        Me.GroupBoxPrintPreview.PerformLayout()
        CType(Me.TrackBarPrintPreviewZoom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ListBoxItems As System.Windows.Forms.ListBox
    Friend WithEvents LabelConfirmation As System.Windows.Forms.Label
    Friend WithEvents GroupBoxItemsToPrint As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBoxItemInfo As System.Windows.Forms.GroupBox
    Friend WithEvents LabelItemMediaId As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemMediaId As System.Windows.Forms.TextBox
    Friend WithEvents ButtonPrint As System.Windows.Forms.Button
    Friend WithEvents ButtonCancel As System.Windows.Forms.Button
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
    Friend WithEvents PictureBoxQrCode As System.Windows.Forms.PictureBox
    Friend WithEvents PrintDialogMain As System.Windows.Forms.PrintDialog
    Friend WithEvents PrintPreviewControlMain As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents PageSetupDialogMain As System.Windows.Forms.PageSetupDialog
    Friend WithEvents GroupBoxPrintPreview As System.Windows.Forms.GroupBox
    Friend WithEvents ButtonPageSetup As System.Windows.Forms.Button
    Friend WithEvents PrintDocumentMain As System.Drawing.Printing.PrintDocument
    Friend WithEvents TrackBarPrintPreviewZoom As System.Windows.Forms.TrackBar
    Friend WithEvents LabelItemLocation As System.Windows.Forms.Label
    Friend WithEvents TextBoxItemLocation As System.Windows.Forms.TextBox
    Friend WithEvents LabelItemNumCds As System.Windows.Forms.Label
End Class
