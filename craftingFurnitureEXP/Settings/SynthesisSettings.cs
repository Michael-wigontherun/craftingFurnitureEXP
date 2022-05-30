using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craftingFurnitureEXP.Settings
{
    public class SynthesisSettings
    {
        [MaintainOrder]

        
        public LogSettings logging = new();

        [SettingName("Smithing Furniture Keywords")]
        [Tooltip("Any Keywords on furniture that are meant to determine the item should use Smithing.")]
        public List<string> SmithingKeywords { get; set; } = new List<string>()
        {
            "CraftingTanningRack",
            "CraftingSmelter"
        };

        [SettingName("Alchemy Furniture Keywords")]
        [Tooltip("Any Keywords on furniture that are meant to determine the item should use Alchemy.")]
        public List<string> AlchemyKeywords { get; set; } = new List<string>()
        {
            "CraftingCookpot",
            "isGrainMill",
            "BYOHCraftingOven"
        };

        [SettingName("Enchanting Furniture Keywords")]
        [Tooltip("Any Keywords on furniture that are meant to determine the item should use Enchanting.")]
        public List<string> EnchantingKeywords { get; set; } = new List<string>();
    }
}
