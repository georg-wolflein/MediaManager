Public Class FormSplashScreen

    Public Progress As String = "Loading..."

    Private Sub FormSplashScreen_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
End Class