using Mutagen.Bethesda.WPF.Reflection.Attributes;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using craftingFurnitureEXP.Settings;

namespace craftingFurnitureEXP
{
    public class EditorIDLists
    {
        [JsonInclude]
        public List<string> SmithingKeywords { get; set; }

        [JsonInclude]
        public List<string> AlchemyKeywords { get; set; }

        [JsonInclude]
        public List<string> EnchantingKeywords { get; set; }

        public EditorIDLists()
        {
            SmithingKeywords = new List<string>();
            AlchemyKeywords = new List<string>();
            EnchantingKeywords = new List<string>();
        }

        //public Settings(List<string> smithingKeywords, List<string> alchemyKeywords, List<string> enchantingKeywords, bool import = false)
        //{
        //    if (!import)
        //    {
        //        SmithingKeywords = smithingKeywords;
        //        AlchemyKeywords = alchemyKeywords;
        //        EnchantingKeywords = enchantingKeywords;
        //    }
        //    else
        //    {
        //        SmithingKeywords.AddRange(smithingKeywords);
        //        AlchemyKeywords.AddRange(alchemyKeywords);
        //        EnchantingKeywords.AddRange(enchantingKeywords);
        //    }

        //}

        public bool IsEmpty()
        {
            return SmithingKeywords.Count == 0 && AlchemyKeywords.Count == 0 && EnchantingKeywords.Count == 0;
        }

        public void ImportSettings(EditorIDLists settings)
        {
            SmithingKeywords.AddRange(settings.SmithingKeywords);
            AlchemyKeywords.AddRange(settings.AlchemyKeywords);
            EnchantingKeywords.AddRange(settings.EnchantingKeywords);
        }

        public void ImportSettings(SynthesisSettings settings)
        {
            SmithingKeywords.AddRange(settings.SmithingKeywords);
            AlchemyKeywords.AddRange(settings.AlchemyKeywords);
            EnchantingKeywords.AddRange(settings.EnchantingKeywords);
        }

        public void AddSmithingKeyword(string smithingKeywords)
        {
            SmithingKeywords.Add(smithingKeywords);
        }

        public void AddAlchemyKeyword(string alchemyKeywords)
        {
            AlchemyKeywords.Add(alchemyKeywords);
        }
        public void AddEnchantingKeyword(string enchantingKeywords)
        {
            EnchantingKeywords.Add(enchantingKeywords);
        }
    }
}
