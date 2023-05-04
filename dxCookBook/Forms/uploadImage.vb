Imports System.IO
Imports System.IO.Compression

Public Class uploadImage
    Private fileType As String



    Sub New()
        InitializeComponent()


        AddHandler lbPicture.LinkClicked, AddressOf lbPicture_LinkClicked
    End Sub



#Region "Buttons"

    Private Sub lbPicture_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Dim openFileDialog As OpenFileDialog = New OpenFileDialog

        ' Open Window
        If openFileDialog.ShowDialog = Windows.Forms.DialogResult.OK Then


            ' Get File Type
            fileType = Path.GetExtension(openFileDialog.FileName)
            Console.WriteLine($"File type: {fileType}")

            ' Set Image to PicterBox
            If fileType = ".jpg" Or fileType = ".png" Or fileType = ".gif" Then


                ' Resize Image
                Dim image As Image = New Bitmap(Image.FromFile(openFileDialog.FileName), New Size(200, 200))


                ' Image to Byte Array
                Dim imageConverter As ImageConverter = New ImageConverter()
                Dim imageBytes As Byte() = CType(imageConverter.ConvertTo(image, GetType(Byte())), Byte())


                ' Byte Array to Unicode String
                Dim imageUnicode As String = System.Text.Encoding.Unicode.GetString(imageBytes)
                Debug.WriteLine("Unicode String Size: " & imageUnicode.Length) ' & vbCrLf & "Image Unicode: " & imageUnicode & vbCrLf)


                ' Unicode String to Bye Array
                Dim byteArray As Byte() = System.Text.Encoding.Unicode.GetBytes(imageUnicode)


                Dim memoryStream As MemoryStream = New MemoryStream(byteArray)
                Dim image2 As Image = Image.FromStream(memoryStream)


                ' Set Image to PicterBox
                Me.pbPicture.Image = image2

            End If

        End If
    End Sub

#End Region



#Region "Method"

    Function imageToByte(ByVal image As Image) As Byte()
        Dim converter As ImageConverter = New ImageConverter()
        Debug.WriteLine("Byte Array: " & converter.ToString)
        Return CType(converter.ConvertTo(image, GetType(Byte())), Byte())
    End Function

    'Function bytesToBase64(ByVal bytes As Byte()) As String
    '    Dim base64String As String = Convert.ToBase64String(bytes, 0, bytes.Length)
    '    Debug.WriteLine("Base64 String: " & base64String)
    '    Return base64String
    'End Function

    'Function base64ToBytes(ByVal base64String As String) As Byte()
    '    Dim imageBytes As Byte() = Convert.FromBase64String(base64String)
    '    Debug.WriteLine("Bytes Array: " & imageBytes.ToString)
    '    Return imageBytes
    'End Function

    Function bytesToImage(ByVal bytes As Byte()) As Bitmap
        Dim returnImage As System.Drawing.Image

        Using ms = New MemoryStream(bytes, 0, bytes.Length)
            returnImage = System.Drawing.Image.FromStream(ms)
        End Using

        Return returnImage
    End Function

    Function bytesToUnicode(ByVal bytes As Byte()) As String
        Dim str As String = System.Text.Encoding.ASCII.GetString(bytes)
        Debug.WriteLine("unicode size: " & str.Length)
        Return str
    End Function

    Private Function unicodeToBytes(ByVal str As String) As Byte()
        'Return System.Text.Encoding.Unicode.GetBytes(str)
        Return System.Text.Encoding.ASCII.GetBytes(str)
    End Function



#End Region

End Class