Imports Avalonia
Imports System

Class Program

    Public Shared Sub Main(ByVal args As String())
        BuildAvaloniaApp().StartWithClassicDesktopLifetime(args)
    End Sub

    Public Shared Function BuildAvaloniaApp() As AppBuilder
        Return AppBuilder.Configure(Of App)().UsePlatformDetect().LogToTrace()
    End Function
End Class
