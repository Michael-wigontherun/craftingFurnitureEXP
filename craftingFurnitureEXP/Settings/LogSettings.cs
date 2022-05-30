using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftingFurnitureEXP.Settings
{
    public class LogSettings
    {
        [MaintainOrder]

        [SettingName("Verbose Logging")]
        [Tooltip("Log everything or only errors and stages.")]
        public bool VerboseLogging = false;

        [SettingName("Disable Detected Keyword Logging")]
        [Tooltip("Selecting this overrides Verbose Logging output of detected keywords in your load order")]
        public bool DetectedKeywordLogging = true;
    }
}
