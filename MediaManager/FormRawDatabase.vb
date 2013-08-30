Public Class FormRawDatabase

    Private Sub FormRawDatabase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.ConfigureWindow(Me)
    End Sub

    Private Sub FormRawDatabase_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.VisibleChanged
        TextBoxRawDatabase.Text = IO.File.ReadAllText(My.Settings.MediaDatabaseFile).Replace(Convert.ToChar(10), vbCrLf)
    End Sub
End Class