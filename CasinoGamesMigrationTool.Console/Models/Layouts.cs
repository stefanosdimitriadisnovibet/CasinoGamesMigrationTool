using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.Console.Models
{
    public partial class Layouts
    {
        public Layouts()
        {
            LayoutAttributeValues = new HashSet<LayoutAttributeValues>();
            LayoutGames = new HashSet<LayoutGames>();
        }

        public int Id { get; set; }
        public int LayoutTemplateId { get; set; }
        public string Sysname { get; set; }
        public string Name { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual LayoutTemplates LayoutTemplate { get; set; }
        public virtual ICollection<LayoutAttributeValues> LayoutAttributeValues { get; set; }
        public virtual ICollection<LayoutGames> LayoutGames { get; set; }
    }
}
