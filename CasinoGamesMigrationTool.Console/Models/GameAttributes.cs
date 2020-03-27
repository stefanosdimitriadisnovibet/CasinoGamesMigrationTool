using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class GameAttributes
    {
        public GameAttributes()
        {
            GameAttributeValues = new HashSet<GameAttributeValues>();
        }

        public int Id { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<GameAttributeValues> GameAttributeValues { get; set; }
    }
}
