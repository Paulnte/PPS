Imports System.IO
Imports System.Text

Public Class FirstStartForm


    Private Sub FirstStartForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub



    Private Sub CB_Click(sender As Object, e As EventArgs) Handles CB.Click

        ChooseDataPath.ShowDialog()
        DataPath.Text = ChooseDataPath.SelectedPath




    End Sub

    Private Sub FB_Click(sender As Object, e As EventArgs) Handles FB.Click
        If Not DataPath.Text = "" Then
            Dim BIP As String = GlobalVariables.DataPath
            Dim BI As FileStream = File.Create(BIP + "\PPSInfo.txt")
            Dim Data As Byte() = New UTF8Encoding(True).GetBytes(DataPath.Text + "\PPSDATA")
            BI.Write(Data, 0, Data.Length)
            BI.Close()
            System.IO.Directory.CreateDirectory(DataPath.Text + "\PPSDATA")
            Me.Close
        Else
            MsgBox("Bitte wähle einen Dateipfad", Title:="PPS")
        End If
    End Sub


End Class