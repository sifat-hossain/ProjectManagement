using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Po
    {
        public int Poid { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? Podate { get; set; }
        public string Poattachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
