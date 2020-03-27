using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class LayoutAttributes
    {
        public LayoutAttributes()
        {
            LayoutAttributeValues = new HashSet<LayoutAttributeValues>();
        }

        public int Id { get; set; }
        public int LayoutTemplateId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public byte Type { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual LayoutTemplates LayoutTemplate { get; set; }
        public virtual ICollection<LayoutAttributeValues> LayoutAttributeValues { get; set; }
    }
}
