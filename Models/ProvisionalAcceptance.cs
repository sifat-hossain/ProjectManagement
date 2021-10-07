using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class ProvisionalAcceptance
    {
        public int ProvisionalAcceptanceId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProductId { get; set; }
        public string AcceptanceStatus { get; set; }
        public DateTime? ProvisionalAcceptance1 { get; set; }
        public int? PacMemberId { get; set; }

        public virtual PacMember PacMember { get; set; }
        public virtual Product Product { get; set; }
        public virtual Project Project { get; set; }
    }
}
