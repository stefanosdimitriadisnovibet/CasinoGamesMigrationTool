using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class MultilingualTexts
    {
        public MultilingualTexts()
        {
            LanguageTranslations = new HashSet<LanguageTranslations>();
        }

        public int Id { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<LanguageTranslations> LanguageTranslations { get; set; }
    }
}
