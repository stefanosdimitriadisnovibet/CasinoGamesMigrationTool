using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class DisplayAttributes
    {
        public DisplayAttributes()
        {
            DisplayAttributeValues = new HashSet<DisplayAttributeValues>();
        }

        public int Id { get; set; }
        public int DisplayProfileId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public string Metadata { get; set; }

        public virtual DisplayProfiles DisplayProfile { get; set; }
        public virtual ICollection<DisplayAttributeValues> DisplayAttributeValues { get; set; }
    }
}
