Public Class FormAbout

    Private Sub FormAbout_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Main.ConfigureWindow(Me)
        UpdateData()
    End Sub

    Public Sub UpdateData()
        Try
            Dim OriginalApplicationName As String = "{0}"
            Dim OriginalApplicationDescription As String = "{0}"
            Dim OriginalApplicationCopyright As String = "{0}"
            Dim OriginalApplicationVersion As String = "Version: {0}"

            LabelAppName.Text = String.Format(OriginalApplicationName, Main.ApplicationName)
            LabelAppDescription.Text = String.Format(OriginalApplicationDescription, Main.ApplicationDescription)
            LabelAppCopyright.Text = String.Format(OriginalApplicationCopyright, Main.ApplicationCopyrightText)
            LabelAppVersion.Text = String.Format(OriginalApplicationVersion, Main.ApplicationVersion)
        Catch Ex As Exception

        End Try
    End Sub

    Private Sub ButtonOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonOk.Click
        Me.Close()
    End Sub

    Private Sub LinkLabelGitHub_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelGitHub.LinkClicked
        Process.Start("https://github.com/georgw777/MediaManager")
    End Sub

    Private Sub LinkLabelGitHubGeorg_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabelGitHubGeorg.LinkClicked
        Process.Start("https://github.com/georgw777/")
    End Sub
End Class