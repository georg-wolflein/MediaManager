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
        Me.ListBoxItems.FormattingEnabled = True
        resources.ApplyResources(Me.ListBoxItems, "ListBoxItems")
        Me.ListBoxItems.Name = "ListBoxItems"
        '
        'LabelConfirmation
        '
        resources.ApplyResources(Me.LabelConfirmation, "LabelConfirmation")
        Me.LabelConfirmation.Name = "LabelConfirmation"
        '
        'GroupBoxItemsToPrint
        '
        Me.GroupBoxItemsToPrint.Controls.Add(Me.ListBoxItems)
        Me.GroupBoxItemsToPrint.Controls.Add(Me.LabelConfirmation)
        resources.ApplyResources(Me.GroupBoxItemsToPrint, "GroupBoxItemsToPrint")
        Me.GroupBoxItemsToPrint.Name = "GroupBoxItemsToPrint"
        Me.GroupBoxItemsToPrint.TabStop = False
        '
        'GroupBoxItemInfo
        '
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
        resources.ApplyResources(Me.GroupBoxItemInfo, "GroupBoxItemInfo")
        Me.GroupBoxItemInfo.Name = "GroupBoxItemInfo"
        Me.GroupBoxItemInfo.TabStop = False
        '
        'LabelItemLocation
        '
        resources.ApplyResources(Me.LabelItemLocation, "LabelItemLocation")
        Me.LabelItemLocation.Name = "LabelItemLocation"
        '
        'TextBoxItemLocation
        '
        resources.ApplyResources(Me.TextBoxItemLocation, "TextBoxItemLocation")
        Me.TextBoxItemLocation.Name = "TextBoxItemLocation"
        Me.TextBoxItemLocation.ReadOnly = True
        '
        'LabelItemNumCds
        '
        resources.ApplyResources(Me.LabelItemNumCds, "LabelItemNumCds")
        Me.LabelItemNumCds.Name = "LabelItemNumCds"
        '
        'PictureBoxQrCode
        '
        resources.ApplyResources(Me.PictureBoxQrCode, "PictureBoxQrCode")
        Me.PictureBoxQrCode.Name = "PictureBoxQrCode"
        Me.PictureBoxQrCode.TabStop = False
        '
        'LabelItemComments
        '
        resources.ApplyResources(Me.LabelItemComments, "LabelItemComments")
        Me.LabelItemComments.Name = "LabelItemComments"
        '
        'TextBoxItemComments
        '
        resources.ApplyResources(Me.TextBoxItemComments, "TextBoxItemComments")
        Me.TextBoxItemComments.Name = "TextBoxItemComments"
        Me.TextBoxItemComments.ReadOnly = True
        '
        'LabelItemArtist
        '
        resources.ApplyResources(Me.LabelItemArtist, "LabelItemArtist")
        Me.LabelItemArtist.Name = "LabelItemArtist"
        '
        'TextBoxItemName
        '
        resources.ApplyResources(Me.TextBoxItemName, "TextBoxItemName")
        Me.TextBoxItemName.Name = "TextBoxItemName"
        Me.TextBoxItemName.ReadOnly = True
        '
        'TextBoxItemNumCds
        '
        resources.ApplyResources(Me.TextBoxItemNumCds, "TextBoxItemNumCds")
        Me.TextBoxItemNumCds.Name = "TextBoxItemNumCds"
        Me.TextBoxItemNumCds.ReadOnly = True
        '
        'LabelItemVolume
        '
        resources.ApplyResources(Me.LabelItemVolume, "LabelItemVolume")
        Me.LabelItemVolume.Name = "LabelItemVolume"
        '
        'LabelItemName
        '
        resources.ApplyResources(Me.LabelItemName, "LabelItemName")
        Me.LabelItemName.Name = "LabelItemName"
        '
        'TextBoxItemArtist
        '
        resources.ApplyResources(Me.TextBoxItemArtist, "TextBoxItemArtist")
        Me.TextBoxItemArtist.Name = "TextBoxItemArtist"
        Me.TextBoxItemArtist.ReadOnly = True
        '
        'TextBoxItemVolumeName
        '
        resources.ApplyResources(Me.TextBoxItemVolumeName, "TextBoxItemVolumeName")
        Me.TextBoxItemVolumeName.Name = "TextBoxItemVolumeName"
        Me.TextBoxItemVolumeName.ReadOnly = True
        '
        'TextBoxItemVolume
        '
        resources.ApplyResources(Me.TextBoxItemVolume, "TextBoxItemVolume")
        Me.TextBoxItemVolume.Name = "TextBoxItemVolume"
        Me.TextBoxItemVolume.ReadOnly = True
        '
        'LabelItemMediaId
        '
        resources.ApplyResources(Me.LabelItemMediaId, "LabelItemMediaId")
        Me.LabelItemMediaId.Name = "LabelItemMediaId"
        '
        'TextBoxItemMediaId
        '
        resources.ApplyResources(Me.TextBoxItemMediaId, "TextBoxItemMediaId")
        Me.TextBoxItemMediaId.Name = "TextBoxItemMediaId"
        Me.TextBoxItemMediaId.ReadOnly = True
        '
        'ButtonPrint
        '
        resources.ApplyResources(Me.ButtonPrint, "ButtonPrint")
        Me.ButtonPrint.Name = "ButtonPrint"
        Me.ButtonPrint.UseVisualStyleBackColor = True
        '
        'ButtonCancel
        '
        Me.ButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        resources.ApplyResources(Me.ButtonCancel, "ButtonCancel")
        Me.ButtonCancel.Name = "ButtonCancel"
        Me.ButtonCancel.UseVisualStyleBackColor = True
        '
        'PrintDialogMain
        '
        Me.PrintDialogMain.UseEXDialog = True
        '
        'PrintPreviewControlMain
        '
        Me.PrintPreviewControlMain.AutoZoom = False
        Me.PrintPreviewControlMain.Document = Me.PrintDocumentMain
        resources.ApplyResources(Me.PrintPreviewControlMain, "PrintPreviewControlMain")
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
        Me.GroupBoxPrintPreview.Controls.Add(Me.ButtonPageSetup)
        Me.GroupBoxPrintPreview.Controls.Add(Me.PrintPreviewControlMain)
        Me.GroupBoxPrintPreview.Controls.Add(Me.ButtonPrint)
        Me.GroupBoxPrintPreview.Controls.Add(Me.ButtonCancel)
        Me.GroupBoxPrintPreview.Controls.Add(Me.TrackBarPrintPreviewZoom)
        resources.ApplyResources(Me.GroupBoxPrintPreview, "GroupBoxPrintPreview")
        Me.GroupBoxPrintPreview.Name = "GroupBoxPrintPreview"
        Me.GroupBoxPrintPreview.TabStop = False
        '
        'ButtonPageSetup
        '
        resources.ApplyResources(Me.ButtonPageSetup, "ButtonPageSetup")
        Me.ButtonPageSetup.Name = "ButtonPageSetup"
        Me.ButtonPageSetup.UseVisualStyleBackColor = True
        '
        'TrackBarPrintPreviewZoom
        '
        resources.ApplyResources(Me.TrackBarPrintPreviewZoom, "TrackBarPrintPreviewZoom")
        Me.TrackBarPrintPreviewZoom.Maximum = 100
        Me.TrackBarPrintPreviewZoom.Minimum = 1
        Me.TrackBarPrintPreviewZoom.Name = "TrackBarPrintPreviewZoom"
        Me.TrackBarPrintPreviewZoom.Value = 27
        '
        'FormPrint
        '
        Me.AcceptButton = Me.ButtonPrint
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.ButtonCancel
        Me.Controls.Add(Me.GroupBoxPrintPreview)
        Me.Controls.Add(Me.GroupBoxItemInfo)
        Me.Controls.Add(Me.GroupBoxItemsToPrint)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FormPrint"
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
