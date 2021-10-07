using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PgdwithProductViewModel
    {
        public int PgdwithProductId { get; set; }
        public int? PgdId { get; set; }
        public int? ProductId { get; set; }
        public int? ProductAmount { get; set; }

        public virtual Pgd Pgd { get; set; }
        public virtual Product Product { get; set; }
    }
}
