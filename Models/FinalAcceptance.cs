using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class FinalAcceptance
    {
        public int FinalAcceptanceId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProductId { get; set; }
        public string FinalAcceptanceStatus { get; set; }
        public DateTime? FinalAcceptanceDate { get; set; }
        public int? FacMemberId { get; set; }

        public virtual FacMember FacMember { get; set; }
        public virtual Product Product { get; set; }
        public virtual Project Project { get; set; }
    }
}
