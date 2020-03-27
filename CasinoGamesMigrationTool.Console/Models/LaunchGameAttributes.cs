using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class LaunchGameAttributes
    {
        public LaunchGameAttributes()
        {
            LaunchAttributeValues = new HashSet<LaunchAttributeValues>();
        }

        public int Id { get; set; }
        public int LaunchProfileId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual LaunchProfiles LaunchProfile { get; set; }
        public virtual ICollection<LaunchAttributeValues> LaunchAttributeValues { get; set; }
    }
}
