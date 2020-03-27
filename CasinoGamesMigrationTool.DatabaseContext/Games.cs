using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class Games
    {
        public Games()
        {
            BonusAttributeValues = new HashSet<BonusAttributeValues>();
            DisplayAttributeValues = new HashSet<DisplayAttributeValues>();
            GameAttributeValues = new HashSet<GameAttributeValues>();
            GamePoolEntries = new HashSet<GamePoolEntries>();
            LaunchAttributeValues = new HashSet<LaunchAttributeValues>();
            LayoutGames = new HashSet<LayoutGames>();
            PoolGameAttributeValues = new HashSet<PoolGameAttributeValues>();
        }

        public int Id { get; set; }
        public int ProviderId { get; set; }
        public int SystemId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Providers Provider { get; set; }
        public virtual ICollection<BonusAttributeValues> BonusAttributeValues { get; set; }
        public virtual ICollection<DisplayAttributeValues> DisplayAttributeValues { get; set; }
        public virtual ICollection<GameAttributeValues> GameAttributeValues { get; set; }
        public virtual ICollection<GamePoolEntries> GamePoolEntries { get; set; }
        public virtual ICollection<LaunchAttributeValues> LaunchAttributeValues { get; set; }
        public virtual ICollection<LayoutGames> LayoutGames { get; set; }
        public virtual ICollection<PoolGameAttributeValues> PoolGameAttributeValues { get; set; }
    }
}
