using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class LayoutGameAttributes
    {
        public LayoutGameAttributes()
        {
            LayoutGameAttributeValues = new HashSet<LayoutGameAttributeValues>();
        }

        public int Id { get; set; }
        public int LayoutTemplateId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual LayoutTemplates LayoutTemplate { get; set; }
        public virtual ICollection<LayoutGameAttributeValues> LayoutGameAttributeValues { get; set; }
    }
}
