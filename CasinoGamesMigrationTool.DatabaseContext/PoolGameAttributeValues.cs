using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class PoolGameAttributeValues
    {
        public int GameId { get; set; }
        public int PoolGameAttributeId { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Games Game { get; set; }
        public virtual PoolGameAttributes PoolGameAttribute { get; set; }
    }
}
