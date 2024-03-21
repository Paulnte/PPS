Imports System.Security.Cryptography.X509Certificates
Imports Microsoft.VisualBasic.FileIO
Imports Windows.Media.Playback
Imports Windows.System.Profile

Public Class AddProjectWindow
    Private Sub CloseB_Click(sender As Object, e As EventArgs) Handles CloseB.Click
        PPSC.Enabled = True
        Me.Close()




    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click


        Dim ZS As String = ""
        Dim STPS As String = ""
        Dim BWZKS = ""

        If IAC.Text = "" Or KC.Text = "" Or KAC.Text = "" Then
            MsgBox("Bitte gebe alle Daten an", Title:="PPS")
        Else

            If Not ZeichnungenPfad.Text = "" Then

                System.IO.Directory.CreateDirectory(GlobalVariables.UsersDataPath + "\" + IAC.Text)
                System.IO.Directory.CreateDirectory(GlobalVariables.UsersDataPath + "\" + IAC.Text + "\Zeichnungen")
                Dim ZDP() As String = Split(ZeichnungenPfad.Text)
                For Each item In ZDP
                    If Not item = "" Then
                        Dim SSI() As String = Split(item, "\", -1)


                        FileSystem.CopyFile(item, GlobalVariables.UsersDataPath + "\" + IAC.Text + "\Zeichnungen" + "\" + SSI.Last)
                        ZS += GlobalVariables.UsersDataPath + "\" + IAC.Text + "\Zeichnungen" + "\" + SSI.Last + " "
                    End If

                Next

            End If



            If Not stpP.Text = "" Then
                If System.IO.Directory.Exists(GlobalVariables.UsersDataPath + "\" + IAC.Text) = False Then
                    System.IO.Directory.CreateDirectory(GlobalVariables.UsersDataPath + "\" + IAC.Text)
                End If

                System.IO.Directory.CreateDirectory(GlobalVariables.UsersDataPath + "\" + IAC.Text + "\stpDateien")
                Dim ZDP() As String = Split(stpP.Text)
                For Each item In ZDP
                    If Not item = "" Then
                        Dim SSI() As String = Split(item, "\", -1)


                        FileSystem.CopyFile(item, GlobalVariables.UsersDataPath + "\" + IAC.Text + "\stpDateien" + "\" + SSI.Last)
                        STPS += GlobalVariables.UsersDataPath + "\" + IAC.Text + "\stpDateien" + "\" + SSI.Last + " "
                    End If

                Next

            End If



            If Not BWZKP.Text = "" Then
                If System.IO.Directory.Exists(GlobalVariables.UsersDataPath + "\" + IAC.Text) = False Then
                    System.IO.Directory.CreateDirectory(GlobalVariables.UsersDataPath + "\" + IAC.Text)
                End If

                System.IO.Directory.CreateDirectory(GlobalVariables.UsersDataPath + "\" + IAC.Text + "\Sonstiges")
                Dim ZDP() As String = Split(BWZKP.Text)
                For Each item In ZDP
                    If Not item = "" Then
                        Dim SSI() As String = Split(item, "\", -1)


                        FileSystem.CopyFile(item, GlobalVariables.UsersDataPath + "\" + IAC.Text + "\Sonstiges" + "\" + SSI.Last)
                        BWZKS += GlobalVariables.UsersDataPath + "\" + IAC.Text + "\Sonstiges" + "\" + SSI.Last + " "
                    End If

                Next

            End If





            GlobalVariables.row = GlobalVariables.Data.NewRow()
            GlobalVariables.row("Ku") = KC.Text
            GlobalVariables.row("IA") = IAC.Text
            GlobalVariables.row("EA") = KAC.Text
            GlobalVariables.row("LT") = DP.Value.Date
            GlobalVariables.row("ZP") = ZS
            GlobalVariables.row("STPP") = STPS
            GlobalVariables.row("BWZKP") = BWZKS
            GlobalVariables.Data.Rows.Add(GlobalVariables.row)



            GlobalVariables.Data.WriteXml(GlobalVariables.DataPath + "\Data.xml", XmlWriteMode.WriteSchema)


            PPSC.OA.Items.Add(IAC.Text)


            PPSC.Enabled = True
            Me.Close()

        End If







    End Sub

    Private Sub AddProjectWindow_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub IAC_TextChanged(sender As Object, e As EventArgs) Handles IAC.TextChanged

    End Sub

    Private Sub ChosseZButton_Click(sender As Object, e As EventArgs) Handles ChosseZButton.Click
        ZFD.ShowDialog()

        For Each Item In ZFD.FileNames.ToArray

            ZeichnungenPfad.Text += Item + " "



        Next


    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        ZeichnungenPfad.Text = ""
    End Sub

    Private Sub ZSTP_Click(sender As Object, e As EventArgs) Handles ZSTP.Click
        stpP.Text = ""
    End Sub



    Private Sub stpB_Click(sender As Object, e As EventArgs) Handles stpB.Click
        stpDialog.ShowDialog()

        For Each Item In stpDialog.FileNames.ToArray

            stpP.Text += Item + " "


        Next
    End Sub

    Private Sub BWZKB_Click(sender As Object, e As EventArgs) Handles BWZKB.Click
        BWZKDialog.ShowDialog()

        For Each Item In BWZKDialog.FileNames.ToArray

            BWZKP.Text += Item + " "



        Next
    End Sub

    Private Sub WZKZ_Click(sender As Object, e As EventArgs) Handles WZKZ.Click
        BWZKP.Text = ""
    End Sub
End Class