using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class NoaAcceptance
    {
        public int NoaAcceptanceId { get; set; }
        public int? NoaId { get; set; }
        public string VendorReply { get; set; }
        public DateTime? NoaAcceptanceDate { get; set; }
        public string NoaAcceptanceAttachment { get; set; }

        public virtual Noa Noa { get; set; }
    }
}
