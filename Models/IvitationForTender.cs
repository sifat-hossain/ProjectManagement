using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class IvitationForTender
    {
        public int IvitationForTenderId { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }
        public DateTime? IvitationForTenderDate { get; set; }
        public string IvitationForTenderAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual VendorInformation Vendor { get; set; }
    }
}
