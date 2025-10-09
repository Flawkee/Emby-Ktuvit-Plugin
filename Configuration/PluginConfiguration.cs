using Emby.Web.GenericEdit;
using Emby.Web.GenericEdit.Validation;
using Ktuvit.Plugin.Helpers;
using MediaBrowser.Common.Net;
using MediaBrowser.Model.Attributes;
using MediaBrowser.Model.Logging;
using MediaBrowser.Model.MediaInfo;
using MediaBrowser.Model.Serialization;
using System.ComponentModel;
using System.Threading.Tasks;

namespace Ktuvit.Plugin.Configuration
{
    public class PluginConfiguration : EditableOptionsBase
    {

        public override string EditorTitle => "Ktuvit Plugin Configuration";

        public override string EditorDescription => "Automatically downloads Hebrew subtitles from Ktuvit.me.\n\n"
                                                    + "Login credentials (username and password) are only required for movie subtitles.\n"
                                                    + "If credentials are not provided, the plugin will still download series subtitles.\n\n";

        [DisplayName("Ktuvit Username")]
        [Description("Email address registered in Ktuvit.me")]
        public string Username { get; set; }
        [DisplayName("Ktuvit Password")]
        [IsPassword]
        public string Password { get; set; }

        protected override void Validate(ValidationContext context)
        {
            var explorer = KtuvitExplorer.Instance;
            if (explorer == null)
            {
                context.AddValidationError("KtuvitExplorer is not initialized.");
                return;
            }

            // allow empty username and password (for series subtitles only)
            if (string.IsNullOrEmpty(Username) && string.IsNullOrEmpty(Password))
            {
                return;
            }
            var authenticationStatus = explorer.KtuvitAuthentication(Username, Password);
            if (!authenticationStatus)
            {
                context.AddValidationError("Failed to authenticate Ktuvit.me. Please validate your credentials.");
            }
        }
    }
}