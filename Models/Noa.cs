using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Noa
    {
        public Noa()
        {
            NoaAcceptances = new HashSet<NoaAcceptance>();
            PgVerifications = new HashSet<PgVerification>();
        }

        public int NoaId { get; set; }
        public int ProjectId { get; set; }
        public string NoaCode { get; set; }
        public DateTime? Pgdate { get; set; }
        public decimal? FinalContatractPrice { get; set; }
        public string TenderNo { get; set; }
        public string NoaAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual ICollection<NoaAcceptance> NoaAcceptances { get; set; }
        public virtual ICollection<PgVerification> PgVerifications { get; set; }
    }
}
