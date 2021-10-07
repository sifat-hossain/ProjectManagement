using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class PgVerification
    {
        public int PgVerificationId { get; set; }
        public int? NoaId { get; set; }
        public int? PgVerificationStatus { get; set; }
        public decimal? PgPrice { get; set; }
        public DateTime? PgOpeningDate { get; set; }
        public DateTime? PgExpireDate { get; set; }
        public string PgVerificationAttachment { get; set; }

        public virtual Noa Noa { get; set; }
    }
}
