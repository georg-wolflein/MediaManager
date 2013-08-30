Imports Microsoft.VisualBasic.FileIO
Imports System.IO

Public Class CsvDatabase

    Public FileName As String
    Public Full As List(Of String())
    Public Columns As String()
    Public Rows As List(Of String())

    Public Sub New()

    End Sub

    Public Sub New(ByVal FileName As String)
        Me.New()
        Me.FileName = FileName
        Update()
    End Sub

    Public Sub Update(Optional ByVal ReadAgain As Boolean = True)
        If ReadAgain Then Me.Full = Read(Me.FileName)
        Try
            If Me.Full.Count > 0 Then
                Me.Columns = Me.Full(0)
                Me.Rows = Me.Full
                Me.Rows.RemoveAt(0)
            End If
        Catch ex As Exception
            Debug.Write("Failed to update CSV")
        End Try
    End Sub

    Public Function Read(ByVal FileName As String) As List(Of String())
        Dim DatabaseContents As New List(Of String())
        Using Reader As New TextFieldParser(FileName)
            Reader.TextFieldType = FileIO.FieldType.Delimited
            Reader.SetDelimiters(",")

            Dim CurrentRow As String()
            While Not Reader.EndOfData
                Try
                    CurrentRow = Reader.ReadFields()
                    DatabaseContents.Add(CurrentRow)
                Catch ex As MalformedLineException
                    'MsgBox("Line " & ex.Message & " is not valid and will be skipped.")
                End Try
            End While
        End Using
        Return DatabaseContents
    End Function

    Public Sub Write(ByVal FileName As String)
        Dim Stream As New FileStream(FileName, FileMode.Create)
        Dim Writer As StreamWriter = New StreamWriter(Stream)
        Writer.WriteLine(GenerateCsvCode())
        Writer.Close()
        Stream.Close()
    End Sub

    Public Function GenerateCsvCode() As String
        Dim CsvCode As String = ""
        For i As Integer = 0 To Me.Columns.Length - 1
            CsvCode &= CleanElementToCsv(Me.Columns(i))
            If Not (i = Me.Columns.Length - 1) Then CsvCode &= ","
        Next
        CsvCode &= Convert.ToChar(10)
        For Each Line As String() In Me.Rows
            For i As Integer = 0 To Line.Length - 1
                CsvCode &= CleanElementToCsv(Line(i))
                If Not (i = Line.Length - 1) Then CsvCode &= ","
            Next
            CsvCode &= Convert.ToChar(10)
        Next
        Return CsvCode
    End Function

    Private Function CleanElementToCsv(ByVal Content As String) As String
        Content.Replace("""", """""")
        If Content.Contains(",") Or Content.Contains(vbCrLf) Or Content.Contains(Convert.ToChar(10)) Then
            Content = """" & Content & """"
        End If
        Return Content
    End Function
End Class
