using System;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;

namespace M4bEnhancer;

/// <summary>
/// The main plugin.
/// </summary>
public class Plugin : BasePlugin<Configuration>
{
    private static readonly Guid _id = Guid.Parse("E55C1B14-5A52-4113-91EC-7DE4BEDD57FA");

    /// <summary>
    /// Initializes a new instance of the <see cref="Plugin"/> class.
    /// </summary>
    /// <param name="applicationPaths">Instance of the <see cref="IApplicationPaths"/> interface.</param>
    /// <param name="xmlSerializer">Instance of the <see cref="IXmlSerializer"/> interface.</param>
    public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
        : base(applicationPaths, xmlSerializer)
    {
        Instance = this;
    }

    /// <inheritdoc />
    public override string Name => "M4B Audiobook Enhancer";

    /// <inheritdoc />
    public override string Description => "Enhances local metadata and chapter extraction for .m4b audiobooks.";

    /// <inheritdoc />
    public override Guid Id => _id;

    /// <summary>
    /// Gets the current plugin instance.
    /// </summary>
    public static Plugin? Instance { get; private set; }
}
