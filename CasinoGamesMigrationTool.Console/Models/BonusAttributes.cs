using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class BonusAttributes
    {
        public BonusAttributes()
        {
            BonusAttributeValues = new HashSet<BonusAttributeValues>();
        }

        public int Id { get; set; }
        public int BonusProfileId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual BonusProfiles BonusProfile { get; set; }
        public virtual ICollection<BonusAttributeValues> BonusAttributeValues { get; set; }
    }
}
