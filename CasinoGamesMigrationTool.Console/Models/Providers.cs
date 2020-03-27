using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class Providers
    {
        public Providers()
        {
            Games = new HashSet<Games>();
            LaunchProfiles = new HashSet<LaunchProfiles>();
        }

        public int Id { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<Games> Games { get; set; }
        public virtual ICollection<LaunchProfiles> LaunchProfiles { get; set; }
    }
}
