using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class LanguageTranslations
    {
        public int MultilingualTextId { get; set; }
        public int LanguageId { get; set; }
        public string Body { get; set; }

        public virtual Languages Language { get; set; }
        public virtual MultilingualTexts MultilingualText { get; set; }
    }
}
