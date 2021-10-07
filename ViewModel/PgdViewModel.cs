using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PgdViewModel
    {
        public int PgdId { get; set; }
        public string PgdName { get; set; }
        public DateTime? PgdDate { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
