using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class DisplayProfiles
    {
        public DisplayProfiles()
        {
            DisplayAttributes = new HashSet<DisplayAttributes>();
        }

        public int Id { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<DisplayAttributes> DisplayAttributes { get; set; }
    }
}
