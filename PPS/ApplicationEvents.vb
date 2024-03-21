Imports Microsoft.VisualBasic.ApplicationServices

Namespace My
    ' The following events are available for MyApplication:
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.

    ' **NEW** ApplyApplicationDefaults: Raised when the application queries default values to be set for the application.

    ' Example:
    ' Private Sub MyApplication_ApplyApplicationDefaults(sender As Object, e As ApplyApplicationDefaultsEventArgs) Handles Me.ApplyApplicationDefaults
    '
    '   ' Setting the application-wide default Font:
    '   e.Font = New Font(FontFamily.GenericSansSerif, 12, FontStyle.Regular)
    '
    '   ' Setting the HighDpiMode for the Application:
    '   e.HighDpiMode = HighDpiMode.PerMonitorV2
    '
    '   ' If a splash dialog is used, this sets the minimum display time:
    '   e.MinimumSplashScreenDisplayTime = 4000
    ' End Sub

    Partial Friend Class MyApplication
        Public Sub MyApplication_Startup(sender As Object, e As StartupEventArgs) Handles Me.Startup
            Dim GroundDataDomain() As String = Split(My.User.Name, "\")
            Dim GroundDataPath As String = "C:\Users\" + GroundDataDomain(1) + "\Documents\PPS"

            If Not System.IO.Directory.Exists(GroundDataPath) Then

                'Erstell Basis Ordner und setz den Grund Daten Pfad
                System.IO.Directory.CreateDirectory(GroundDataPath)
                GlobalVariables.DataPath = GroundDataPath
                Dim XmlCreater As New System.IO.FileStream(GroundDataPath + "\Data.xml", System.IO.FileMode.Create)
                XmlCreater.Close()
                'Zeig das Erste Start Form an 
                PPSC.Enabled = False
                FirstStartForm.Show()

            Else
                GlobalVariables.DataPath = GroundDataPath
                GlobalVariables.UsersDataPath = My.Computer.FileSystem.ReadAllText(GroundDataPath + "\PPSInfo.txt")
                Debug.WriteLine(GlobalVariables.UsersDataPath)
            End If


        End Sub
    End Class
End Namespace
