Public Class Projekte_Ansicht
    Private Sub BackB_Click(sender As Object, e As EventArgs) Handles BackB.Click
        PPSC.Enabled = True
        Me.Close()
    End Sub

    Private Sub Projekte_Ansicht_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        KAF.Text = GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("EA")
        IAF.Text = GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("IA")
        KDF.Text = GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("Ku")
        LTF.Text = GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("LT")
        If Not GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("ZP") = "" Then


            Dim ZeichnungenData() As String = Split(GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("ZP"))
            For Each item In ZeichnungenData
                Zeichnungen.Items.Add(item)
            Next
        End If


        If Not GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("STPP") = "" Then


            Dim ZeichnungenData() As String = Split(GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("STPP"))
            For Each item In ZeichnungenData
                StpDateien.Items.Add(item)
            Next
        End If


        If Not GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("BWZKP") = "" Then


            Dim ZeichnungenData() As String = Split(GlobalVariables.Data.Rows(GlobalVariables.SelectedProjectInt).Item("BWZKP"))
            For Each item In ZeichnungenData
                Werkzeugnise.Items.Add(item)
            Next
        End If
    End Sub

    Private Sub Zeichnungen_DoubleClick(sender As Object, e As EventArgs) Handles Zeichnungen.DoubleClick

        If Not Zeichnungen.SelectedItem = "" Then
            Dim selectedDrawing As String = Zeichnungen.SelectedItem.ToString
            Process.Start("explorer.exe", selectedDrawing)
        End If


    End Sub

    Private Sub StpDateien_DoubleClick(sender As Object, e As EventArgs) Handles StpDateien.DoubleClick
        If Not StpDateien.SelectedItem = "" Then
            Dim selectedDrawing As String = StpDateien.SelectedItem.ToString
            Process.Start("explorer.exe", selectedDrawing)
        End If
    End Sub

    Private Sub Werkzeugnise_DoubleClick(sender As Object, e As EventArgs) Handles Werkzeugnise.DoubleClick
        If Not Werkzeugnise.SelectedItem = "" Then
            Dim selectedDrawing As String = Werkzeugnise.SelectedItem.ToString
            Process.Start("explorer.exe", selectedDrawing)
        End If
    End Sub
End Class