![Nuget](https://img.shields.io/nuget/v/AlasdairCooper.Godot.Configuration?color=eebb00&style=for-the-badge) ![Nuget](https://img.shields.io/nuget/dt/AlasdairCooper.Godot.Configuration?color=0033ee&style=for-the-badge)

# AlasdairCooper.Godot.Configuration

This is a basic configuration provider for Godot. It uses the `JsonStreamConfigurationSource` to read files from Godot's file system.

Install [the NuGet package](https://www.nuget.org/packages/AlasdairCooper.Godot.Configuration).

## Setup

```csharp
# Program.cs

...
using AlasdairCooper.Godot.Configuration.Extensions;
...
builder.Configuration.AddGodotJsonFile("res://content/appsettings.json");
```
