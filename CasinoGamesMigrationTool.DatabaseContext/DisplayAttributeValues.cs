using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class DisplayAttributeValues
    {
        public int GameId { get; set; }
        public int DisplayAttributeId { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual DisplayAttributes DisplayAttribute { get; set; }
        public virtual Games Game { get; set; }
    }
}
