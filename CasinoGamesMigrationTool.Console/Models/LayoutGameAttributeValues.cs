using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class LayoutGameAttributeValues
    {
        public int LayoutGameId { get; set; }
        public int LayoutGameAttributeId { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual LayoutGames LayoutGame { get; set; }
        public virtual LayoutGameAttributes LayoutGameAttribute { get; set; }
    }
}
