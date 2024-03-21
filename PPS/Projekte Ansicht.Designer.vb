<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Projekte_Ansicht
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
        BackB = New Button()
        Label1 = New Label()
        KDF = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Zeichnungen = New ListBox()
        StpDateien = New ListBox()
        Label8 = New Label()
        Werkzeugnise = New ListBox()
        IAF = New Label()
        KAF = New Label()
        LTF = New Label()
        SuspendLayout()
        ' 
        ' BackB
        ' 
        BackB.Location = New Point(713, 12)
        BackB.Name = "BackB"
        BackB.Size = New Size(75, 23)
        BackB.TabIndex = 0
        BackB.Text = "Zurück"
        BackB.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(12, 20)
        Label1.Name = "Label1"
        Label1.Size = New Size(44, 15)
        Label1.TabIndex = 1
        Label1.Text = "Kunde:"
        ' 
        ' KDF
        ' 
        KDF.AutoSize = True
        KDF.Location = New Point(62, 20)
        KDF.Name = "KDF"
        KDF.Size = New Size(35, 15)
        KDF.TabIndex = 2
        KDF.Text = "####"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(15, 52)
        Label3.Name = "Label3"
        Label3.Size = New Size(141, 15)
        Label3.TabIndex = 3
        Label3.Text = "Interne Auftragsnummer:"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(15, 79)
        Label4.Name = "Label4"
        Label4.Size = New Size(131, 15)
        Label4.TabIndex = 4
        Label4.Text = "Kunde Auftragsnmmer:"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(15, 113)
        Label5.Name = "Label5"
        Label5.Size = New Size(74, 15)
        Label5.TabIndex = 5
        Label5.Text = "Liefertermin:"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(15, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(80, 15)
        Label6.TabIndex = 6
        Label6.Text = "Zeichnungen:"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(452, 223)
        Label7.Name = "Label7"
        Label7.Size = New Size(59, 15)
        Label7.TabIndex = 7
        Label7.Text = "stp. Datei:"
        ' 
        ' Zeichnungen
        ' 
        Zeichnungen.FormattingEnabled = True
        Zeichnungen.ItemHeight = 15
        Zeichnungen.Location = New Point(15, 239)
        Zeichnungen.Name = "Zeichnungen"
        Zeichnungen.Size = New Size(336, 199)
        Zeichnungen.TabIndex = 8
        ' 
        ' StpDateien
        ' 
        StpDateien.FormattingEnabled = True
        StpDateien.ItemHeight = 15
        StpDateien.Location = New Point(452, 241)
        StpDateien.Name = "StpDateien"
        StpDateien.Size = New Size(336, 199)
        StpDateien.TabIndex = 9
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Location = New Point(251, 20)
        Label8.Name = "Label8"
        Label8.Size = New Size(88, 15)
        Label8.TabIndex = 10
        Label8.Text = "Werkszeugnise:"
        ' 
        ' Werkzeugnise
        ' 
        Werkzeugnise.FormattingEnabled = True
        Werkzeugnise.ItemHeight = 15
        Werkzeugnise.Location = New Point(345, 20)
        Werkzeugnise.Name = "Werkzeugnise"
        Werkzeugnise.Size = New Size(331, 169)
        Werkzeugnise.TabIndex = 11
        ' 
        ' IAF
        ' 
        IAF.AutoSize = True
        IAF.Location = New Point(162, 52)
        IAF.Name = "IAF"
        IAF.Size = New Size(35, 15)
        IAF.TabIndex = 12
        IAF.Text = "####"
        ' 
        ' KAF
        ' 
        KAF.AutoSize = True
        KAF.Location = New Point(152, 79)
        KAF.Name = "KAF"
        KAF.Size = New Size(35, 15)
        KAF.TabIndex = 13
        KAF.Text = "####"
        ' 
        ' LTF
        ' 
        LTF.AutoSize = True
        LTF.Location = New Point(95, 113)
        LTF.Name = "LTF"
        LTF.Size = New Size(35, 15)
        LTF.TabIndex = 14
        LTF.Text = "####"
        ' 
        ' Projekte_Ansicht
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        ControlBox = False
        Controls.Add(LTF)
        Controls.Add(KAF)
        Controls.Add(IAF)
        Controls.Add(Werkzeugnise)
        Controls.Add(Label8)
        Controls.Add(StpDateien)
        Controls.Add(Zeichnungen)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(KDF)
        Controls.Add(Label1)
        Controls.Add(BackB)
        Name = "Projekte_Ansicht"
        Text = "Projekte"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents BackB As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents KDF As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Zeichnungen As ListBox
    Friend WithEvents StpDateien As ListBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Werkzeugnise As ListBox
    Friend WithEvents IAF As Label
    Friend WithEvents KAF As Label
    Friend WithEvents LTF As Label
End Class
