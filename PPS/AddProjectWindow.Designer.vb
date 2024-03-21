<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddProjectWindow
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
        KC = New TextBox()
        Label1 = New Label()
        CloseB = New Button()
        AddButton = New Button()
        IAC = New TextBox()
        Label3 = New Label()
        Label4 = New Label()
        KAC = New TextBox()
        Label5 = New Label()
        Label2 = New Label()
        ZeichnungenPfad = New TextBox()
        ChosseZButton = New Button()
        ResetButton = New Button()
        ZFD = New OpenFileDialog()
        DP = New DateTimePicker()
        Label6 = New Label()
        Label7 = New Label()
        stpP = New TextBox()
        BWZKP = New TextBox()
        stpB = New Button()
        BWZKB = New Button()
        ZSTP = New Button()
        WZKZ = New Button()
        stpDialog = New OpenFileDialog()
        BWZKDialog = New OpenFileDialog()
        SuspendLayout()
        ' 
        ' KC
        ' 
        KC.Location = New Point(162, 12)
        KC.Name = "KC"
        KC.Size = New Size(100, 23)
        KC.TabIndex = 0
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(112, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 1
        Label1.Text = "Kunde:"
        ' 
        ' CloseB
        ' 
        CloseB.Location = New Point(703, 15)
        CloseB.Name = "CloseB"
        CloseB.Size = New Size(75, 23)
        CloseB.TabIndex = 6
        CloseB.Text = "abbrechen"
        CloseB.UseVisualStyleBackColor = True
        ' 
        ' AddButton
        ' 
        AddButton.Location = New Point(12, 415)
        AddButton.Name = "AddButton"
        AddButton.Size = New Size(80, 23)
        AddButton.TabIndex = 5
        AddButton.Text = "Hinzufügen"
        AddButton.UseVisualStyleBackColor = True
        ' 
        ' IAC
        ' 
        IAC.Location = New Point(162, 40)
        IAC.Name = "IAC"
        IAC.Size = New Size(100, 23)
        IAC.TabIndex = 1
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 44)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 15)
        Label3.TabIndex = 6
        Label3.Text = "Interne Auftragsnummer:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 87)
        Label4.Name = "Label4"
        Label4.Size = New Size(138, 15)
        Label4.TabIndex = 7
        Label4.Text = "Kunde Auftragsnummer:"
        ' 
        ' KAC
        ' 
        KAC.Location = New Point(162, 79)
        KAC.Name = "KAC"
        KAC.Size = New Size(100, 23)
        KAC.TabIndex = 2
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(88, 121)
        Label5.Name = "Label5"
        Label5.Size = New Size(68, 15)
        Label5.TabIndex = 9
        Label5.Text = "Lifertermin:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(12, 190)
        Label2.Name = "Label2"
        Label2.Size = New Size(80, 15)
        Label2.TabIndex = 11
        Label2.Text = "Zeichnungen:"
        ' 
        ' ZeichnungenPfad
        ' 
        ZeichnungenPfad.Enabled = False
        ZeichnungenPfad.Location = New Point(98, 187)
        ZeichnungenPfad.Name = "ZeichnungenPfad"
        ZeichnungenPfad.Size = New Size(510, 23)
        ZeichnungenPfad.TabIndex = 12
        ' 
        ' ChosseZButton
        ' 
        ChosseZButton.Location = New Point(614, 186)
        ChosseZButton.Name = "ChosseZButton"
        ChosseZButton.Size = New Size(75, 23)
        ChosseZButton.TabIndex = 4
        ChosseZButton.Text = "Wählen"
        ChosseZButton.UseVisualStyleBackColor = True
        ' 
        ' ResetButton
        ' 
        ResetButton.Location = New Point(695, 186)
        ResetButton.Name = "ResetButton"
        ResetButton.Size = New Size(93, 23)
        ResetButton.TabIndex = 7
        ResetButton.Text = "Zurücksetzen"
        ResetButton.UseVisualStyleBackColor = True
        ' 
        ' ZFD
        ' 
        ZFD.Multiselect = True
        ' 
        ' DP
        ' 
        DP.Location = New Point(162, 115)
        DP.Name = "DP"
        DP.Size = New Size(200, 23)
        DP.TabIndex = 3
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(12, 240)
        Label6.Name = "Label6"
        Label6.Size = New Size(72, 15)
        Label6.TabIndex = 13
        Label6.Text = "stp. Dateien:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(12, 268)
        Label7.Name = "Label7"
        Label7.Size = New Size(68, 30)
        Label7.TabIndex = 14
        Label7.Text = "Bestellung, " & vbCrLf & "WZK usw:"
        ' 
        ' stpP
        ' 
        stpP.Enabled = False
        stpP.Location = New Point(98, 232)
        stpP.Name = "stpP"
        stpP.Size = New Size(510, 23)
        stpP.TabIndex = 15
        ' 
        ' BWZKP
        ' 
        BWZKP.Enabled = False
        BWZKP.Location = New Point(98, 275)
        BWZKP.Name = "BWZKP"
        BWZKP.Size = New Size(510, 23)
        BWZKP.TabIndex = 16
        ' 
        ' stpB
        ' 
        stpB.Location = New Point(614, 232)
        stpB.Name = "stpB"
        stpB.Size = New Size(75, 23)
        stpB.TabIndex = 17
        stpB.Text = "Wählen"
        stpB.UseVisualStyleBackColor = True
        ' 
        ' BWZKB
        ' 
        BWZKB.Location = New Point(614, 274)
        BWZKB.Name = "BWZKB"
        BWZKB.Size = New Size(75, 23)
        BWZKB.TabIndex = 18
        BWZKB.Text = "Wählen"
        BWZKB.UseVisualStyleBackColor = True
        ' 
        ' ZSTP
        ' 
        ZSTP.Location = New Point(695, 231)
        ZSTP.Name = "ZSTP"
        ZSTP.Size = New Size(93, 23)
        ZSTP.TabIndex = 19
        ZSTP.Text = "Zurücksetzen"
        ZSTP.UseVisualStyleBackColor = True
        ' 
        ' WZKZ
        ' 
        WZKZ.Location = New Point(695, 274)
        WZKZ.Name = "WZKZ"
        WZKZ.Size = New Size(93, 23)
        WZKZ.TabIndex = 20
        WZKZ.Text = "Zurücksetzen"
        WZKZ.UseVisualStyleBackColor = True
        ' 
        ' stpDialog
        ' 
        stpDialog.Multiselect = True
        ' 
        ' BWZKDialog
        ' 
        BWZKDialog.Multiselect = True
        ' 
        ' AddProjectWindow
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(WZKZ)
        Controls.Add(ZSTP)
        Controls.Add(BWZKB)
        Controls.Add(stpB)
        Controls.Add(BWZKP)
        Controls.Add(stpP)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(DP)
        Controls.Add(ResetButton)
        Controls.Add(ChosseZButton)
        Controls.Add(ZeichnungenPfad)
        Controls.Add(Label2)
        Controls.Add(Label5)
        Controls.Add(KAC)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(IAC)
        Controls.Add(AddButton)
        Controls.Add(CloseB)
        Controls.Add(Label1)
        Controls.Add(KC)
        Name = "AddProjectWindow"
        Text = "Auftrag Hinzufügen"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents KC As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents CloseB As Button
    Friend WithEvents AddButton As Button
    Friend WithEvents IAC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents KAC As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ZeichnungenPfad As TextBox
    Friend WithEvents ChosseZButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents ZFD As OpenFileDialog
    Friend WithEvents LTC As TextBox
    Friend WithEvents DP As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents stpP As TextBox
    Friend WithEvents BWZKP As TextBox
    Friend WithEvents stpB As Button
    Friend WithEvents BWZKB As Button
    Friend WithEvents ZSTP As Button
    Friend WithEvents WZKZ As Button
    Friend WithEvents stpDialog As OpenFileDialog
    Friend WithEvents BWZKDialog As OpenFileDialog

End Class
