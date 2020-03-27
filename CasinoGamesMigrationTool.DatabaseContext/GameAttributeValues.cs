using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class GameAttributeValues
    {
        public int GameId { get; set; }
        public int GameAttributeId { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Games Game { get; set; }
        public virtual GameAttributes GameAttribute { get; set; }
    }
}
