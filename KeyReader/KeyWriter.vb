Imports System.Security.Cryptography
Imports System.Text
Imports System.IO
Public Class KeyWriter
    Private TripleDes As New TripleDESCryptoServiceProvider
    Private Sub BtnCreate_Click(sender As Object, e As EventArgs) Handles BtnCreate.Click
        If CBEncrypt.Checked Then
            If TxtPass.Text = TxtpassResubmittion.Text Then

                If Not TxtKey.Text = "" Then
                    createkey()
                Else
                    ErrorPMain.SetError(TxtKey, "No key specified")
                    ErrorPMain.Tag = "key"
                    MessageBox.Show(Me, "No key specified.", "No key", MessageBoxButtons.OK, MessageBoxIcon.Error)

                End If


            Else
                ErrorPMain.SetError(TxtpassResubmittion, "Passwords do not match")
                ErrorPMain.Tag = "pass"
                MessageBox.Show(Me, "Passwords do not match", "Password Miss Match", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If

        Else
            If Not TxtKey.Text = "" Then
                createkey()
            Else
                ErrorPMain.SetError(TxtKey, "No key specified")
                ErrorPMain.Tag = "key"
                MessageBox.Show(Me, "No key specified.", "No key", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
    End Sub
    Public Sub createkey()

        Dim resbytes As String
        If CBEncrypt.Checked Then
            Dim str As String = "encrypted//" & TxtKey.Text
            resbytes = AES_Encrypt(str, TxtPass.Text)
        Else
            Dim str As String = "plaintext//" & TxtKey.Text
            resbytes = AES_Encrypt(str, "!NO!BASE!KEY")
        End If
        Dim ByteArray() As Byte = System.Text.ASCIIEncoding.BigEndianUnicode.GetBytes(resbytes)
        Dim res As DialogResult = SaveKeyDialog.ShowDialog()
        If res = DialogResult.OK Then
            IO.File.WriteAllBytes(SaveKeyDialog.FileName, ByteArray)
            Closer.Start()
        End If
    End Sub
    Public Sub onclose() Handles MyBase.Closed
        Try
            End
        Catch ex As Exception

        End Try
    End Sub

    Private Function TruncateHash(
    ByVal key As String,
    ByVal length As Integer) As Byte()

        Dim sha1 As New SHA1CryptoServiceProvider

        ' Hash the key.
        Dim keyBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(key)
        Dim hash() As Byte = sha1.ComputeHash(keyBytes)

        ' Truncate or pad the hash.
        ReDim Preserve hash(length - 1)
        Return hash
    End Function

    'Sub New(ByVal key As String)
    '    key = TxtKey.Text
    '    ' Initialize the crypto provider.
    '    TripleDes.Key = TruncateHash(key, TripleDes.KeySize \ 8)
    '    TripleDes.IV = TruncateHash("", TripleDes.BlockSize \ 8)
    'End Sub

    Public Function EncryptData(
    ByVal plaintext As String) As Byte()

        ' Convert the plaintext string to a byte array.
        Dim plaintextBytes() As Byte =
            System.Text.Encoding.Unicode.GetBytes(plaintext)

        ' Create the stream.
        Dim ms As New System.IO.MemoryStream
        ' Create the encoder to write to the stream.
        Dim encStream As New CryptoStream(ms,
            TripleDes.CreateEncryptor(),
            System.Security.Cryptography.CryptoStreamMode.Write)

        ' Use the crypto stream to write the byte array to the stream.
        encStream.Write(plaintextBytes, 0, plaintextBytes.Length)
        encStream.FlushFinalBlock()

        ' Convert the encrypted stream to a printable string.
        Return ms.ToArray
    End Function


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

    Private Sub Closer_Tick(sender As Object, e As EventArgs) Handles Closer.Tick
        End
    End Sub

    Private Sub CBEncrypt_CheckedChanged(sender As Object, e As EventArgs) Handles CBEncrypt.CheckedChanged
        If CBEncrypt.Checked Then
            PbEnc.Image = My.Resources.Locked
        Else
            PbEnc.Image = My.Resources.Key
        End If
    End Sub

    Private Sub TxtPass_TextChanged(sender As Object, e As EventArgs) Handles TxtPass.TextChanged
        If ErrorPMain.Tag = "pass" Then
            ErrorPMain.Clear()
            ErrorPMain.Tag = ""
        End If
    End Sub

    Private Sub TxtpassResubmittion_TextChanged(sender As Object, e As EventArgs) Handles TxtpassResubmittion.TextChanged
        If ErrorPMain.Tag = "pass" Then
            ErrorPMain.Clear()
            ErrorPMain.Tag = ""
        End If
    End Sub

    Private Sub TxtKey_TextChanged(sender As Object, e As EventArgs) Handles TxtKey.TextChanged
        If ErrorPMain.Tag = "key" Then
            ErrorPMain.Clear()
            ErrorPMain.Tag = ""
        End If
    End Sub

    Private Sub BtnToggleKey_Click(sender As Object, e As EventArgs) Handles BtnToggleKey.Click
        If BtnToggleKey.Text = "Show Key" Then
            TxtKey.PasswordChar = ""
            BtnToggleKey.Text = "Hide Key"
        Else
            TxtKey.PasswordChar = "*"
            BtnToggleKey.Text = "Show Key"
        End If
    End Sub
End Class