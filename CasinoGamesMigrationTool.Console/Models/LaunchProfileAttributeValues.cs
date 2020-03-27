using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class LaunchProfileAttributeValues
    {
        public int Id { get; set; }
        public int LaunchProfileId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual LaunchProfiles LaunchProfile { get; set; }
    }
}
