Public Class WorkingWithFilesForm




    Sub FileWriteDemo()

        'OpenMode.Output: creates file, overwrites if exists. destroys old data
        'FileOpen(1, "FileDemo.txt", OpenMode.Output)

        'OpenMode.Append: creates file, adds new data to the file. preserves old data
        FileOpen(1, "FileDemo.txt", OpenMode.Append)

        WriteLine(1, "Knock... Knock...")
        WriteLine(1, "Record #1", "Record #2", "Record 3")
        WriteLine(1, 5, 7, 42)
        'Write(1, "Wake up Neo...")
        'Write(1, "Follow the white rabbit...")

        FileClose(1)

    End Sub

    Private Sub WorkingWithFilesForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        FileWriteDemo()
    End Sub
End Class
