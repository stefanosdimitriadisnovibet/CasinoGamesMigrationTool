using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class LayoutTemplates
    {
        public LayoutTemplates()
        {
            LayoutAttributes = new HashSet<LayoutAttributes>();
            LayoutGameAttributes = new HashSet<LayoutGameAttributes>();
            Layouts = new HashSet<Layouts>();
        }

        public int Id { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual ICollection<LayoutAttributes> LayoutAttributes { get; set; }
        public virtual ICollection<LayoutGameAttributes> LayoutGameAttributes { get; set; }
        public virtual ICollection<Layouts> Layouts { get; set; }
    }
}
