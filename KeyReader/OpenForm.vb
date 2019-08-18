Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class OpenForm
    Dim RenderPoint As New Point(0, 0)
    Dim HidePoint As New Point(-100, -100)
    Private Sub OpenForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Size = New Size(343, 164)
        UnlockedPanel.Location = RenderPoint
        Dim args As New List(Of String)
        For Each arg In Environment.GetCommandLineArgs
            args.Add(arg)
        Next
        args.Remove(args(0))
        If IO.File.Exists(args(0)) Then
            Console.WriteLine("FOUND FILE!")
        Else
            Console.WriteLine("Invalid file")
        End If
        Dim Info As FileInfo = New FileInfo(args(0))
        Me.Text = Info.Name
        Console.WriteLine("Reading bytes")
        Dim bytes() As Byte = IO.File.ReadAllBytes(args(0))
        Console.WriteLine("attempting decode")
        Dim dattext As String = System.Text.ASCIIEncoding.BigEndianUnicode.GetString(bytes)
        Dim Retstr As String = AES_Decrypt(dattext, "!NO!BASE!KEY")
        Dim asstring As String = Retstr
        Console.WriteLine("As Plain text: {0}", asstring)

        If asstring = Nothing Then
            Console.WriteLine("is nothing")
            UnlockedPanel.Hide()
            LockedPanel.Show()
            LockedPanel.Location = RenderPoint
        Else
            If asstring.StartsWith("plaintext//") Then
                Console.WriteLine("Key is plain text, writing")
                Dim key As String = asstring.Remove(0, 11)
                PbUnlocked.Image = My.Resources.Key
                txtAsPlainText.Text = key
                UnlockedPanel.Show()
                UnlockedPanel.Location = RenderPoint
            Else
                UnlockedPanel.Hide()
                LockedPanel.Show()
                LockedPanel.Location = RenderPoint
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        My.Computer.Clipboard.SetText(txtAsPlainText.Text)
    End Sub
    Public Function AES_Encrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim encrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESEncrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateEncryptor
            Dim Buffer As Byte() = System.Text.ASCIIEncoding.ASCII.GetBytes(input)
            encrypted = Convert.ToBase64String(DESEncrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return encrypted
        Catch ex As Exception
        End Try
    End Function

    Public Function AES_Decrypt(ByVal input As String, ByVal pass As String) As String
        Dim AES As New System.Security.Cryptography.RijndaelManaged
        Dim Hash_AES As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim decrypted As String = ""
        Try
            Dim hash(31) As Byte
            Dim temp As Byte() = Hash_AES.ComputeHash(System.Text.ASCIIEncoding.ASCII.GetBytes(pass))
            Array.Copy(temp, 0, hash, 0, 16)
            Array.Copy(temp, 0, hash, 15, 16)
            AES.Key = hash
            AES.Mode = Security.Cryptography.CipherMode.ECB
            Dim DESDecrypter As System.Security.Cryptography.ICryptoTransform = AES.CreateDecryptor
            Dim Buffer As Byte() = Convert.FromBase64String(input)
            decrypted = System.Text.ASCIIEncoding.ASCII.GetString(DESDecrypter.TransformFinalBlock(Buffer, 0, Buffer.Length))
            Return decrypted
        Catch ex As Exception
        End Try
    End Function

    Private Sub DecryptWithKey()
        'decryp[t
        Dim args As New List(Of String)
        For Each arg In Environment.GetCommandLineArgs
            args.Add(arg)
        Next
        args.Remove(args(0))
        If IO.File.Exists(args(0)) Then
            Console.WriteLine("FOUND FILE!")
        Else
            Console.WriteLine("Invalid file")
        End If
        Console.WriteLine("Reading bytes")
        Dim bytes() As Byte = IO.File.ReadAllBytes(args(0))
        Console.WriteLine("attempting decode")
        Dim dattext As String = System.Text.ASCIIEncoding.BigEndianUnicode.GetString(bytes)
        Dim Retstr As String = AES_Decrypt(dattext, (TxtEntryPass.Text.Replace(vbNewLine, "")))
        Dim asstring As String = Retstr
        Console.WriteLine("As Plain text: {0}", asstring)
        If asstring = Nothing Then
            Console.WriteLine("is nothing")
            MessageBox.Show("Password is incorrect or the file is damaged.")
            TxtEntryPass.Text = ""
        Else
            If asstring.StartsWith("encrypted//") Then
                Console.WriteLine("Key decrypted, writing")
                Dim key As String = asstring.Remove(0, 11)
                LockedPanel.Hide()
                LockedPanel.Location = HidePoint
                txtAsPlainText.Text = key
                UnlockedPanel.Show()
                UnlockedPanel.Location = RenderPoint
            Else
                MessageBox.Show("Password is incorrect or the file is damaged.")
                TxtEntryPass.Text = ""
            End If

        End If


    End Sub
    Sub onclose() Handles MyBase.Closing
        End
    End Sub

    Private Sub TxtEntryPass_TextChanged(sender As Object, e As EventArgs) Handles TxtEntryPass.TextChanged
        If TxtEntryPass.Text.Contains(vbNewLine) Then
            DecryptWithKey()
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles BtnCopyKey.Click
        My.Computer.Clipboard.SetText(txtAsPlainText.Text)
        BtnCopyKey.Text = "Copied!"
        CopyTick.Start()
    End Sub

    Private Sub LblShowPass_Click(sender As Object, e As EventArgs) Handles LblShowPass.Click
        PBHidePass.Hide()
        LblShowPass.Hide()
    End Sub

    Private Sub txtAsPlainText_TextChanged(sender As Object, e As EventArgs) Handles txtAsPlainText.DoubleClick
        PBHidePass.Show()
        LblShowPass.Show()
    End Sub

    Private Sub CopyTick_Tick(sender As Object, e As EventArgs) Handles CopyTick.Tick
        BtnCopyKey.Text = "Copy to Clipboard"
        CopyTick.Stop()
    End Sub
End Class