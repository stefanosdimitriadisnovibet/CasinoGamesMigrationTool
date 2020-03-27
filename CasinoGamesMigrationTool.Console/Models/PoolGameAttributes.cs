using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class PoolGameAttributes
    {
        public PoolGameAttributes()
        {
            PoolGameAttributeValues = new HashSet<PoolGameAttributeValues>();
        }

        public int Id { get; set; }
        public int GamePoolId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual GamePools GamePool { get; set; }
        public virtual ICollection<PoolGameAttributeValues> PoolGameAttributeValues { get; set; }
    }
}
