using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Pgd
    {
        public Pgd()
        {
            PgdwithProducts = new HashSet<PgdwithProduct>();
        }

        public int PgdId { get; set; }
        public string PgdName { get; set; }
        public DateTime? PgdDate { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<PgdwithProduct> PgdwithProducts { get; set; }
    }
}
