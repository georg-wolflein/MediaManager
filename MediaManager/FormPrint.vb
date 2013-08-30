Public Class FormPrint

    Public Data As CsvDatabase
    Private CurrentItemIndex As Integer = 0

    Private InitialConfirmationText As String = ""

    Public Sub New(ByVal Data As CsvDatabase)
        InitializeComponent()
        InitialConfirmationText = LabelConfirmation.Text

        Me.Data = Data
        FillListBox()
        GroupBoxPrintPreview.Select()
    End Sub

#Region "Events"

    Private Sub FormPrint_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.ConfigureWindow(Me)
    End Sub

    Private Sub PictureBoxQrCode_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBoxQrCode.Paint
        ScaleBitmap(PictureBoxQrCode.Image, 2, e)
    End Sub

    Private Sub ButtonPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPrint.Click
        CurrentItemIndex = 0
        Dim Result As DialogResult = PrintDialogMain.ShowDialog()
        If Result = System.Windows.Forms.DialogResult.OK Then
            PrintDocumentMain.PrinterSettings = PrintDialogMain.PrinterSettings
            PrintDocumentMain.Print()
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        End If
    End Sub

    Private Sub ListBoxItems_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBoxItems.SelectedIndexChanged
        LoadItemInfo(ListBoxItems.SelectedIndex)
    End Sub

    Private Sub ButtonPageSetup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonPageSetup.Click
        PageSetupDialogMain.ShowDialog()
        CurrentItemIndex = 0
        PrintPreviewControlMain.InvalidatePreview()
    End Sub
#End Region

    Private Sub FillListBox()
        Dim NameIndex As Integer = Array.IndexOf(Me.Data.Columns, "Name")
        For Each Row As String() In Me.Data.Rows
            ListBoxItems.Items.Add(Row(NameIndex))
        Next
        LabelConfirmation.Text = String.Format(InitialConfirmationText, Me.Data.Rows.Count)
        ListBoxItems.SelectedIndex = 0
    End Sub

    Private Sub LoadItemInfo(ByVal ItemIndex As Integer)
        Dim CurrentItem As String() = Data.Rows(ItemIndex)
        Dim MediaIdIndex As Integer = Array.IndexOf(Data.Columns, "Media ID")
        Dim NameIndex As Integer = Array.IndexOf(Data.Columns, "Name")
        Dim VolumeIndex As Integer = Array.IndexOf(Data.Columns, "Volume")
        Dim VolumeNameIndex As Integer = Array.IndexOf(Data.Columns, "Volume Name")
        Dim NumCdsIndex As Integer = Array.IndexOf(Data.Columns, "Number of CDs")
        Dim ArtistIndex As Integer = Array.IndexOf(Data.Columns, "Artist")
        Dim LocationIndex As Integer = Array.IndexOf(Data.Columns, "Location")
        Dim CommentsIndex As Integer = Array.IndexOf(Data.Columns, "Comments")

        TextBoxItemMediaId.Text = CurrentItem(MediaIdIndex)
        TextBoxItemName.Text = CurrentItem(NameIndex)
        TextBoxItemVolume.Text = CurrentItem(VolumeIndex)
        TextBoxItemVolumeName.Text = CurrentItem(VolumeNameIndex)
        TextBoxItemNumCds.Text = CurrentItem(NumCdsIndex)
        TextBoxItemArtist.Text = CurrentItem(ArtistIndex)
        TextBoxItemLocation.Text = CurrentItem(LocationIndex)
        TextBoxItemComments.Text = CurrentItem(CommentsIndex).Replace(Convert.ToChar(10), vbCrLf)

        PictureBoxQrCode.Image = EncodeQrCode(CurrentItem(MediaIdIndex))
    End Sub

    Private Sub PrintDocumentMain_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles PrintDocumentMain.PrintPage
        ' printable width and height
        Dim PrintWidth As Single
        Dim PrintHeight As Single
        ' x and y starting points
        Dim PrintX As Single
        Dim PrintY As Single

        ' set variables
        With PrintDocumentMain.DefaultPageSettings
            PrintWidth = .PaperSize.Width - .Margins.Left - .Margins.Right
            PrintHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            PrintX = .Margins.Left
            PrintY = .Margins.Top

            ' change width/height when landscape mode
            If .Landscape Then
                Dim TempHeight As Integer = PrintHeight
                PrintHeight = PrintWidth
                PrintWidth = TempHeight
            End If
        End With

        ' print area
        Dim PrintArea As New RectangleF(PrintX, PrintY, PrintWidth, PrintHeight)
        Dim Format As New StringFormat(StringFormatFlags.LineLimit)

        ' settings
        Dim StickerBackWidth As Single = MillimetresToZollOverHundred(6)
        Dim StickerTitleWidth As Single = MillimetresToZollOverHundred(60)
        Dim StickerWidth As Single = StickerBackWidth + StickerTitleWidth
        Dim StickerHeight As Single = MillimetresToZollOverHundred(40)
        ' margins
        Dim StickerNameXMargin As Single = MillimetresToZollOverHundred(5)
        Dim StickerNameYMargin As Single = MillimetresToZollOverHundred(5)
        Dim StickerQrCodeXMargin As Single = MillimetresToZollOverHundred(5)
        Dim StickerQrCodeYMargin As Single = MillimetresToZollOverHundred(12)
        Dim StickerQrCodeScale As Single = 2
        Dim StickerMediaIdXMargin As Single = MillimetresToZollOverHundred(0)
        Dim StickerMediaIdYMargin As Single = MillimetresToZollOverHundred(2)

        ' count how many sticker columns
        Dim NumStickerColumns As Integer = Math.Floor(PrintArea.Width / StickerWidth)
        ' cont how many sticker rows
        Dim NumStickerRows As Integer = Math.Floor(PrintArea.Height / StickerHeight)

        Dim LinePen As New Pen(Color.Black, 2)
        Dim FoldLinePen As New Pen(Color.Black, 1)

        Dim StickerBackFont As New Font("Arial", 7, FontStyle.Regular, GraphicsUnit.Millimeter)
        Dim StickerTitleFont As New Font("Arial", 5, FontStyle.Regular, GraphicsUnit.Millimeter)

        For RowIndex As Integer = 0 To NumStickerRows

            For ColumnIndex As Integer = 0 To NumStickerColumns - 1
                If Not (Data.Rows.Count > CurrentItemIndex) Then
                    GoTo PrintNextPage
                End If

                Dim CurrentItem As String() = Data.Rows(CurrentItemIndex)
                Dim MediaId As String = CurrentItem(Array.IndexOf(Data.Columns, "Media ID"))
                Dim Name As String = CurrentItem(Array.IndexOf(Data.Columns, "Name"))


                '' calculations ''
                ' horizontal
                ' top line
                Dim TopLineYPosition As Single = PrintArea.Y + (StickerHeight * RowIndex)
                ' bottom line
                Dim BottomLineYPosition As Single = TopLineYPosition + StickerHeight

                ' vertical
                ' start line
                Dim StartLineXPosition As Single = PrintArea.X + (StickerWidth * ColumnIndex)
                ' fold line
                Dim FoldLineXPosition As Single = StartLineXPosition + StickerTitleWidth
                ' end line
                Dim EndLineXPosition As Single = StartLineXPosition + StickerWidth

                ' text
                ' media id
                Dim MediaIdXPosition As Single = FoldLineXPosition + StickerMediaIdXMargin
                Dim MediaIdYPosition As Single = TopLineYPosition + StickerMediaIdYMargin
                ' name
                Dim NameXPosition As Single = StartLineXPosition + StickerNameXMargin
                Dim NameYPosition As Single = TopLineYPosition + StickerNameYMargin
                Dim NameMaxWidth As Single = FoldLineXPosition - StartLineXPosition - (StickerNameXMargin * 2)
                ' qr code
                Dim QrCodeXPosition As Single = StartLineXPosition + StickerQrCodeXMargin
                Dim QrCodeYPosition As Single = TopLineYPosition + StickerQrCodeYMargin
                Dim QrCodeScale As Single = StickerQrCodeScale


                ' check if it goes beyond margins
                If BottomLineYPosition > PrintArea.Height - PrintArea.X Then
                    GoTo PrintNextPage
                    Exit Sub
                End If


                '' drawing ''
                ' horizontal
                ' top line
                e.Graphics.DrawLine(LinePen, StartLineXPosition, TopLineYPosition, EndLineXPosition, TopLineYPosition)
                ' bottom line
                e.Graphics.DrawLine(LinePen, StartLineXPosition, BottomLineYPosition, EndLineXPosition, BottomLineYPosition)

                ' vertical
                ' start line
                e.Graphics.DrawLine(LinePen, StartLineXPosition, TopLineYPosition, StartLineXPosition, BottomLineYPosition)
                ' fold line
                e.Graphics.DrawLine(FoldLinePen, FoldLineXPosition, TopLineYPosition, FoldLineXPosition, BottomLineYPosition)
                ' end line
                e.Graphics.DrawLine(LinePen, EndLineXPosition, TopLineYPosition, EndLineXPosition, BottomLineYPosition)

                ' text
                ' media id
                e.Graphics.DrawString(AddNewlines(MediaId), StickerBackFont, Brushes.Black, MediaIdXPosition, MediaIdYPosition)
                ' name
                e.Graphics.DrawString(TrimString(e, Name, StickerTitleFont, NameMaxWidth), StickerTitleFont, Brushes.Black, NameXPosition, NameYPosition)
                ' qr code
                Dim Qr As Image = EncodeQrCode(MediaId)
                ScaleBitmap(Qr, QrCodeScale, e, QrCodeXPosition, QrCodeYPosition)

                CurrentItemIndex += 1
            Next

        Next



PrintNextPage:

        If (Data.Rows.Count > CurrentItemIndex) Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
        End If
    End Sub

    Private Function TrimString(ByVal e As Printing.PrintPageEventArgs, ByVal StringToTrim As String, ByVal Font As Font, ByVal MaxWidth As Single, Optional ByVal TooLongSuffix As String = "...", Optional ByVal ForceTooLongSuffix As Boolean = False) As String
        If StringToTrim.Length = 0 Then
            Return StringToTrim
        End If
        If (e.Graphics.MeasureString(If(ForceTooLongSuffix, StringToTrim & TooLongSuffix, StringToTrim), Font).Width <= MaxWidth) Then
            If ForceTooLongSuffix Then
                Return StringToTrim & TooLongSuffix
            Else
                Return StringToTrim
            End If
        Else
            StringToTrim = Microsoft.VisualBasic.Left(StringToTrim, StringToTrim.Length - 1)
            Return TrimString(e, StringToTrim, Font, MaxWidth, TooLongSuffix, True)
        End If
    End Function

    Private Function AddNewlines(ByVal Text As String)
        Dim NewText As String = ""
        For i As Integer = 0 To Text.Length - 1
            NewText &= Text(i)
            If Not (i = Text.Length - 1) Then NewText &= vbCrLf
        Next
        Return NewText
    End Function

    Private Function ZollToMillimetres(ByVal Zoll As Integer) As Single
        Return Zoll * 26.34
    End Function

    Private Function MillimetresToZoll(ByVal Millimetres As Integer) As Single
        Return Millimetres * 0.037965072133637055
    End Function

    Private Function ZollOverHundredToMillimetres(ByVal Zoll As Integer) As Single
        Return ZollToMillimetres(Zoll / 100)
    End Function

    Private Function MillimetresToZollOverHundred(ByVal Millimetres As Integer) As Single
        Return MillimetresToZoll(Millimetres) * 100
    End Function

    Private Sub TrackBarPrintPreviewZoom_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBarPrintPreviewZoom.Scroll
        If (PrintPreviewControlMain.Zoom <> TrackBarPrintPreviewZoom.Value / 100) Then
            PrintPreviewControlMain.Zoom = TrackBarPrintPreviewZoom.Value / 100
        End If
    End Sub

    Private Sub PrintPreviewControlMain_Validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles PrintPreviewControlMain.Validating
        CurrentItemIndex = 0
    End Sub
End Class