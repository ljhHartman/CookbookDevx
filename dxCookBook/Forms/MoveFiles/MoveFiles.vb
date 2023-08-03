Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors

Public Class MoveFiles

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim code As String = XtraInputBox.Show("Copy files to Relationcode:", "Message", MessageBoxButtons.OK)
        Dim source As String = $"L:\BMS\BML\SSL\Application\SHS\bijlagen\{code}\"
        Dim destination As String = $"L:\BMS\BML\SSL\Application\SHS\bijlagen\{0}\"

        ' Create new fodler
        If Not (Directory.Exists(destination)) Then Directory.CreateDirectory(destination)

        ' Iterate Source Folder
        For Each file As String In Directory.GetFiles(source)
            Dim fileName As String = IO.Path.GetFileName(file)
            Try
                ' Copy/Paste file to destination filder
                My.Computer.FileSystem.CopyFile(source + fileName, destination + fileName)
            Catch ex As IOException
                Console.WriteLine($"[INFO] - File {fileName} is already in this folder")
            End Try
        Next
    End Sub




End Class