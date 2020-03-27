using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class LayoutGames
    {
        public LayoutGames()
        {
            LayoutGameAttributeValues = new HashSet<LayoutGameAttributeValues>();
        }

        public int Id { get; set; }
        public int LayoutId { get; set; }
        public int GameId { get; set; }
        public int Ordering { get; set; }
        public DateTime Created { get; set; }

        public virtual Games Game { get; set; }
        public virtual Layouts Layout { get; set; }
        public virtual ICollection<LayoutGameAttributeValues> LayoutGameAttributeValues { get; set; }
    }
}
