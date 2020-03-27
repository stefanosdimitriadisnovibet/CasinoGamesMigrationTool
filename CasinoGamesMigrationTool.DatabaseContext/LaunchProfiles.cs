using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class LaunchProfiles
    {
        public LaunchProfiles()
        {
            GamePoolEntries = new HashSet<GamePoolEntries>();
            LaunchGameAttributes = new HashSet<LaunchGameAttributes>();
            LaunchProfileAttributeValues = new HashSet<LaunchProfileAttributeValues>();
        }

        public int Id { get; set; }
        public int ProviderId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Providers Provider { get; set; }
        public virtual ICollection<GamePoolEntries> GamePoolEntries { get; set; }
        public virtual ICollection<LaunchGameAttributes> LaunchGameAttributes { get; set; }
        public virtual ICollection<LaunchProfileAttributeValues> LaunchProfileAttributeValues { get; set; }
    }
}
