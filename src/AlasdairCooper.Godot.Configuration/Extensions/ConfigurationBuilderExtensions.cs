using JetBrains.Annotations;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Configuration.Json;

namespace AlasdairCooper.Godot.Configuration.Extensions;

[PublicAPI]
public static class ConfigurationBuilderExtensions
{
    public static IConfigurationBuilder AddGodotJsonFile(this IConfigurationBuilder builder, string resourcePath)
    {
        var bytes = global::Godot.FileAccess.GetFileAsBytes(resourcePath);
        return builder.Add<JsonStreamConfigurationSource>(s => s.Stream = new MemoryStream(bytes));
    }
}