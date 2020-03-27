using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class BonusAttributeValues
    {
        public int GameId { get; set; }
        public int BonusAttributeId { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual BonusAttributes BonusAttribute { get; set; }
        public virtual Games Game { get; set; }
    }
}
