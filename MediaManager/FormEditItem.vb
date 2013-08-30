Public Class FormEditItem

    Public Enum EditAction As Short
        Add
        Edit
    End Enum

    Public Id As Integer
    Public Action As EditAction = EditAction.Edit
    Public ItemInfo As String()

    Public Sub New(ByVal Id As Integer, Optional ByVal Action As EditAction = EditAction.Edit)
        InitializeComponent()
        Me.Id = Id
        Me.Action = Action
    End Sub

    Private Sub FormEditItem_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If Action = EditAction.Edit Then
            Main.ConfigureWindow(Me, "Edit Item")
            LoadData()
        ElseIf Action = EditAction.Add Then
            Main.ConfigureWindow(Me, "Add Item")
        End If
        TextBoxItemName.Focus()
    End Sub

    Private Sub LoadData()
        Dim CurrentItem As String() = FormMain.Media.Rows(FormMain.GetRowIndexById(Id))
        Dim MediaIdIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Media ID")
        Dim NameIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Name")
        Dim VolumeIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Volume")
        Dim VolumeNameIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Volume Name")
        Dim NumCdsIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Number of CDs")
        Dim ArtistIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Artist")
        Dim LocationIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Location")
        Dim CommentsIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Comments")

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

    Private Sub SaveData()
        If Action = EditAction.Add Then
            Dim Blank As String() = {Id, "", "", "", "", "", "", ""}
            If Action = EditAction.Add Then FormMain.Media.Rows.Add(Blank)
        End If


        Dim CurrentIndex As Integer = FormMain.GetRowIndexById(Id)
        Dim MediaIdIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Media ID")
        Dim NameIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Name")
        Dim VolumeIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Volume")
        Dim VolumeNameIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Volume Name")
        Dim NumCdsIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Number of CDs")
        Dim ArtistIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Artist")
        Dim LocationIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Location")
        Dim CommentsIndex As Integer = Array.IndexOf(FormMain.Media.Columns, "Comments")

        FormMain.Media.Rows(CurrentIndex)(MediaIdIndex) = TextBoxItemMediaId.Text
        FormMain.Media.Rows(CurrentIndex)(NameIndex) = TextBoxItemName.Text
        FormMain.Media.Rows(CurrentIndex)(VolumeIndex) = TextBoxItemVolume.Text
        FormMain.Media.Rows(CurrentIndex)(VolumeNameIndex) = TextBoxItemVolumeName.Text
        FormMain.Media.Rows(CurrentIndex)(NumCdsIndex) = TextBoxItemNumCds.Text
        FormMain.Media.Rows(CurrentIndex)(ArtistIndex) = TextBoxItemArtist.Text
        FormMain.Media.Rows(CurrentIndex)(LocationIndex) = TextBoxItemLocation.Text
        FormMain.Media.Rows(CurrentIndex)(CommentsIndex) = TextBoxItemComments.Text.Replace(vbCrLf, Convert.ToChar(10))
    End Sub

    Private Sub PictureBoxQrCode_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles PictureBoxQrCode.Paint
        ScaleBitmap(PictureBoxQrCode.Image, 2, e)
    End Sub

    Private Sub ButtonSaveAndExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonSaveAndExit.Click
        SaveData()
        Me.Close()
    End Sub
End Class