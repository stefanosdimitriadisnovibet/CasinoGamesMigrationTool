using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class GamePools
    {
        public GamePools()
        {
            GamePoolEntries = new HashSet<GamePoolEntries>();
            PoolGameAttributes = new HashSet<PoolGameAttributes>();
        }

        public int Id { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<GamePoolEntries> GamePoolEntries { get; set; }
        public virtual ICollection<PoolGameAttributes> PoolGameAttributes { get; set; }
    }
}
