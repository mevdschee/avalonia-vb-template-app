# avalonia-vb-template-app

By default dotnet CLI would create a C# template, if you want to create F# template you will need to add -lang F# to the end of the command. 
There is no way to add a VB.net template and therefor this project shows a C# (App) template that is converted to VB.net.

## Creating a new Application

To create a new barebones application called MyApp in its own subdirectory, you would run:

    dotnet new -i Avalonia.Templates
    dotnet new avalonia.app -o MyApp

I converted the generated code to VB.net.

Enjoy!

Source: https://github.com/AvaloniaUI/avalonia-dotnet-templates
