using Ktuvit.Plugin.Configuration;
using Ktuvit.Plugin.Helpers;
using MediaBrowser.Common;
using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Net;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Controller.Plugins;
using MediaBrowser.Model.Drawing;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.Serialization;
using System;
using System.IO;

namespace Ktuvit.Plugin
{
    public class Plugin : BasePluginSimpleUI<PluginConfiguration>, IHasThumbImage
    {
        public Plugin(IApplicationHost applicationHost, IJsonSerializer jsonSerializer, ILogger logger , IHttpClient httpClient) : base(applicationHost)
        {
            Instance = this;
            KtuvitExplorer.Initialize(jsonSerializer, logger, httpClient);
            ImdbExplorer.Initialize(jsonSerializer, logger, httpClient);
        }


        public override sealed string Name => PluginName;

        public static string PluginName = "Ktuvit";
        public override Guid Id => new Guid("a1b2c3d4-e5f6-7890-abcd-ef1234567890");
        public override string Description => "Downloads Hebrew subtitles from Ktuvit.me";
        public static Plugin Instance { get; private set; }
        public PluginConfiguration Options => this.GetOptions();

        public Stream GetThumbImage()
        {
            var type = GetType();
            return type.Assembly.GetManifestResourceStream(type.Namespace + ".thumb.png");
        }

        public ImageFormat ThumbImageFormat
        {
            get
            {
                return ImageFormat.Png;
            }
        }
    }
}