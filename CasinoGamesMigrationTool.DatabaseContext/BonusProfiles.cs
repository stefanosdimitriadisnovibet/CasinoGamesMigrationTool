using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class BonusProfiles
    {
        public BonusProfiles()
        {
            BonusAttributes = new HashSet<BonusAttributes>();
        }

        public int Id { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<BonusAttributes> BonusAttributes { get; set; }
    }
}
