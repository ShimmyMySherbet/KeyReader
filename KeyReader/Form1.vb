Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        passoff.Start()
    End Sub

    Private Sub passoff_Tick(sender As Object, e As EventArgs) Handles passoff.Tick
        Dim args As New List(Of String)
        For Each arg In Environment.GetCommandLineArgs
            args.Add(arg)
        Next
        args.Remove(args(0))
        If args.Count = 1 Then
            'readfile
            OpenForm.Show()
        Else
            'writefil            
            KeyWriter.Show()
            KeyWriter.BringToFront()
        End If
        passoff.Stop()
        Me.Hide()
    End Sub
End Class
