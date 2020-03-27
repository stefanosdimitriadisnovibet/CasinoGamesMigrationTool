using System;
using System.Collections.Generic;

namespace CasinoGamesMigrationTool.DatabaseContext
{
    public partial class LayoutAttributeValues
    {
        public int LayoutId { get; set; }
        public int LayoutAttributeId { get; set; }
        public string Value { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }

        public virtual Layouts Layout { get; set; }
        public virtual LayoutAttributes LayoutAttribute { get; set; }
    }
}
