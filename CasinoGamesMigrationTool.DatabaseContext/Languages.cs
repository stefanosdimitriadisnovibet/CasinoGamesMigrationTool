using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class Languages
    {
        public Languages()
        {
            LanguageTranslations = new HashSet<LanguageTranslations>();
        }

        public int Id { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }

        public virtual ICollection<LanguageTranslations> LanguageTranslations { get; set; }
    }
}
