using Mutagen.Bethesda.Plugins;
using Mutagen.Bethesda.Skyrim;
using Mutagen.Bethesda.Synthesis.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace ImprovedEnhancedCameraFirstPersonMeshFix.Settings
{
    public class PatcherSettings
    {
        [SynthesisOrder]
        [SynthesisSettingName("Generate Male Fixes")]
        [SynthesisTooltip("Generates the valid first person model path for males. Disabled by default.")]
        [SynthesisDescription("Generate Female Fixes")]
        public bool MaleFirstPerson { get; set; } = false;

        [SynthesisOrder]
        [SynthesisSettingName("Generate Female Fixes")]
        [SynthesisTooltip("Generates the valid first person model path for females. Enabled by default.")]
        [SynthesisDescription("Generate Female Fixes")]
        public bool FemaleFirstPerson { get; set; } = true;

        [SynthesisOrder]
        [SynthesisSettingName("Regex Mods (Source)")]
        [SynthesisTooltip("Only patch items originated from those mods that start with the char range. Only lowercase alphanumeric are read. Default is every mod")]
        public string RegexSource { get; set; } = "[a-z0-9]";

        [SynthesisOrder]
        [SynthesisSettingName("Included Mods")]
        [SynthesisTooltip("Only patch items overridden by those mods. Leave it blank to ignore.")]
        public HashSet<ModKey> IncludedMods_Override { get; set; } = new();

        [SynthesisOrder]
        [SynthesisSettingName("Excluded Mods")]
        [SynthesisTooltip("All items overridden by those mods will be excluded.")]
        public HashSet<ModKey> ExcludedMods_Override { get; set; } = new();
    }
}