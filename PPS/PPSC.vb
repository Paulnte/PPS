Imports Microsoft.VisualBasic.Logging

Public Class PPSC


    Private Sub AddB_Click(sender As Object, e As EventArgs) Handles AddB.Click

        Me.Enabled = False
        AddProjectWindow.Show()


    End Sub

    Private Sub OA_SelectedIndexChanged(sender As Object, e As EventArgs) Handles OA.SelectedIndexChanged

        'GlobalVariables.SelectedProjectInt = OA.SelectedIndex
        'GlobalVariables.SelectedProject = OA.SelectedItem.ToString()
        'Projekte_Ansicht.Show()
        'Me.Enabled = False



    End Sub

    Private Sub PPSC_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        If System.IO.File.Exists(GlobalVariables.DataPath + "\Data.xml") Then

            GlobalVariables.Data.ReadXml(GlobalVariables.DataPath + "\Data.xml")
            Dim Counter As Int128 = 0
            For Each row In GlobalVariables.Data.Rows
                OA.Items.Add(GlobalVariables.Data.Rows(Counter).Item("IA"))
                Counter += 1
            Next

        Else
            'realisiert die DatenStruktur
            GlobalVariables.column = New DataColumn With {
            .DataType = System.Type.GetType("System.String"),
            .ColumnName = "Ku",
            .ReadOnly = False,
            .Unique = False
        }
            GlobalVariables.Data.Columns.Add(GlobalVariables.column)

            GlobalVariables.column = New DataColumn With {
                .DataType = System.Type.GetType("System.String"),
                .ColumnName = "IA",
                .ReadOnly = False,
                .Unique = False
            }
            GlobalVariables.Data.Columns.Add(GlobalVariables.column)
            GlobalVariables.column = New DataColumn With {
                .DataType = System.Type.GetType("System.String"),
                .ColumnName = "EA",
                .ReadOnly = False,
                .Unique = False
            }
            GlobalVariables.Data.Columns.Add(GlobalVariables.column)
            GlobalVariables.column = New DataColumn With {
                .DataType = System.Type.GetType("System.String"),
                .ColumnName = "LT",
                .ReadOnly = False,
                .Unique = False
            }
            GlobalVariables.Data.Columns.Add(GlobalVariables.column)

            GlobalVariables.column = New DataColumn With {
                .DataType = System.Type.GetType("System.String"),
                .ColumnName = "ZP",
                .ReadOnly = False,
                .Unique = False
            }
            GlobalVariables.Data.Columns.Add(GlobalVariables.column)
            GlobalVariables.column = New DataColumn With {
                .DataType = System.Type.GetType("System.String"),
                .ColumnName = "STPP",
                .ReadOnly = False,
                .Unique = False
            }
            GlobalVariables.Data.Columns.Add(GlobalVariables.column)
            GlobalVariables.column = New DataColumn With {
                .DataType = System.Type.GetType("System.String"),
                .ColumnName = "BWZKP",
                .ReadOnly = False,
                .Unique = False
            }
            GlobalVariables.Data.Columns.Add(GlobalVariables.column)




            GlobalVariables.Dataset = New DataSet()
            GlobalVariables.Dataset.Tables.Add(GlobalVariables.Data)

        End If





    End Sub

    Private Sub DeleteB_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub OA_DoubleClick(sender As Object, e As EventArgs) Handles OA.DoubleClick

        If Not OA.SelectedItem = "" Then
            GlobalVariables.SelectedProjectInt = OA.SelectedIndex
            GlobalVariables.SelectedProject = OA.SelectedItem.ToString()
            Projekte_Ansicht.Show()
            Me.Enabled = False
        End If

    End Sub

    Private Sub DeleteB_Click_1(sender As Object, e As EventArgs) Handles DeleteB.Click
        If Not OA.SelectedItem = "" Then


            If System.IO.Directory.Exists(GlobalVariables.UsersDataPath + "\" + GlobalVariables.Data.Rows(OA.SelectedIndex).Item("IA")) = True Then
                System.IO.Directory.Delete(GlobalVariables.UsersDataPath + "\" + GlobalVariables.Data.Rows(OA.SelectedIndex).Item("IA"), True)
            End If
            GlobalVariables.row = GlobalVariables.Data.Rows(OA.SelectedIndex)
            GlobalVariables.Data.Rows.Remove(GlobalVariables.row)
            GlobalVariables.Data.WriteXml(GlobalVariables.DataPath + "\Data.xml", XmlWriteMode.WriteSchema)
            OA.Items.Remove(OA.SelectedItem)



        End If
    End Sub
End Class
