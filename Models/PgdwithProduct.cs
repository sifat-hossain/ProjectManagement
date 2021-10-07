using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class PgdwithProduct
    {
        public PgdwithProduct()
        {
            ProjectDetails = new HashSet<ProjectDetail>();
        }

        public int PgdwithProductId { get; set; }
        public int? PgdId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductAmount { get; set; }

        public virtual Pgd Pgd { get; set; }
        public virtual Product Product { get; set; }
        public virtual ICollection<ProjectDetail> ProjectDetails { get; set; }
    }
}
