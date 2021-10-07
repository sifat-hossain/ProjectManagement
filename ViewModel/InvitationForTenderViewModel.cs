using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class InvitationForTenderViewModel
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
