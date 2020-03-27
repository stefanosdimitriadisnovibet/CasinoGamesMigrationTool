using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class GamePoolEntries
    {
        public GamePoolEntries()
        {
            GamePoolEntrySchedules = new HashSet<GamePoolEntrySchedules>();
        }

        public int GamePoolId { get; set; }
        public int GameId { get; set; }
        public int LaunchProfileId { get; set; }
        public string Sysname { get; set; }
        public bool Published { get; set; }
        public int Ordering { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Games Game { get; set; }
        public virtual GamePools GamePool { get; set; }
        public virtual LaunchProfiles LaunchProfile { get; set; }
        public virtual ICollection<GamePoolEntrySchedules> GamePoolEntrySchedules { get; set; }
    }
}
