<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class PPSC
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        OA = New ListBox()
        AddB = New Button()
        DeleteB = New Button()
        Archive = New Button()
        SuspendLayout()
        ' 
        ' OA
        ' 
        OA.FormattingEnabled = True
        OA.ItemHeight = 15
        OA.Location = New Point(0, -1)
        OA.MultiColumn = True
        OA.Name = "OA"
        OA.Size = New Size(347, 394)
        OA.TabIndex = 0
        ' 
        ' AddB
        ' 
        AddB.Location = New Point(0, 399)
        AddB.Name = "AddB"
        AddB.Size = New Size(75, 23)
        AddB.TabIndex = 1
        AddB.Text = "+"
        AddB.UseVisualStyleBackColor = True
        ' 
        ' DeleteB
        ' 
        DeleteB.Location = New Point(272, 399)
        DeleteB.Name = "DeleteB"
        DeleteB.Size = New Size(75, 23)
        DeleteB.TabIndex = 2
        DeleteB.Text = "-"
        DeleteB.UseVisualStyleBackColor = True
        ' 
        ' Archive
        ' 
        Archive.Location = New Point(137, 399)
        Archive.Name = "Archive"
        Archive.Size = New Size(75, 23)
        Archive.TabIndex = 3
        Archive.Text = "Archive"
        Archive.UseVisualStyleBackColor = True
        ' 
        ' PPSC
        ' 
        AllowDrop = True
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        AutoScroll = True
        AutoSizeMode = AutoSizeMode.GrowAndShrink
        ClientSize = New Size(800, 450)
        Controls.Add(Archive)
        Controls.Add(DeleteB)
        Controls.Add(AddB)
        Controls.Add(OA)
        Name = "PPSC"
        Text = "PPS Cockpit"
        ResumeLayout(False)
    End Sub

    Friend WithEvents OA As ListBox
    Friend WithEvents AddB As Button
    Friend WithEvents DeleteB As Button
    Friend WithEvents Archive As Button

End Class
