using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Lc
    {
        public int Lcid { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? LcopeningDate { get; set; }
        public string NominatedBank { get; set; }
        public string PaymentProcess { get; set; }
        public string Lcattachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
