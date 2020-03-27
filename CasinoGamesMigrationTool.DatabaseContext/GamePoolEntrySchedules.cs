using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class GamePoolEntrySchedules
    {
        public int Id { get; set; }
        public int GamePoolId { get; set; }
        public int GameId { get; set; }
        public bool Publish { get; set; }
        public DateTime StartTime { get; set; }
        public byte Status { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual GamePoolEntries Game { get; set; }
    }
}
