using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class InvitationForTender
    {
        public int InvitationForTenderId { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }
        public DateTime? InvitationForTenderDate { get; set; }
        public string InvitationForTenderAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual VendorInformation Vendor { get; set; }
    }
}
