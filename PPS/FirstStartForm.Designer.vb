<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FirstStartForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        DataPath = New TextBox()
        Label1 = New Label()
        CB = New Button()
        ChooseDataPath = New FolderBrowserDialog()
        FB = New Button()
        SuspendLayout()
        ' 
        ' DataPath
        ' 
        DataPath.Enabled = False
        DataPath.Location = New Point(129, 66)
        DataPath.Name = "DataPath"
        DataPath.Size = New Size(370, 23)
        DataPath.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 74)
        Label1.Name = "Label1"
        Label1.Size = New Size(111, 15)
        Label1.TabIndex = 1
        Label1.Text = "Speicherort wählen:"
        ' 
        ' CB
        ' 
        CB.Location = New Point(505, 66)
        CB.Name = "CB"
        CB.Size = New Size(75, 23)
        CB.TabIndex = 2
        CB.Text = "Wählen"
        CB.UseVisualStyleBackColor = True
        ' 
        ' FB
        ' 
        FB.Location = New Point(652, 398)
        FB.Name = "FB"
        FB.Size = New Size(136, 40)
        FB.TabIndex = 3
        FB.Text = "Fertig"
        FB.UseVisualStyleBackColor = True
        ' 
        ' FirstStartForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(FB)
        Controls.Add(CB)
        Controls.Add(Label1)
        Controls.Add(DataPath)
        FormBorderStyle = FormBorderStyle.FixedSingle
        Name = "FirstStartForm"
        Text = "Erster Start"
        TopMost = True
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents DataPath As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CB As Button
    Friend WithEvents ChooseDataPath As FolderBrowserDialog
    Friend WithEvents FB As Button
End Class
