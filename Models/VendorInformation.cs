using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class VendorInformation
    {
        public VendorInformation()
        {
            InitialNotesheets = new HashSet<InitialNotesheet>();
            InvitationForTenders = new HashSet<InvitationForTender>();
            ProjectDetails = new HashSet<ProjectDetail>();
            VendorContactPersonInformations = new HashSet<VendorContactPersonInformation>();
        }

        public int VendorId { get; set; }
        public string VendorName { get; set; }
        public string VendorTradeLicenceNo { get; set; }
        public string VendorEmail { get; set; }
        public string VendorPhone { get; set; }
        public string VendorClearence { get; set; }

        public virtual ICollection<InitialNotesheet> InitialNotesheets { get; set; }
        public virtual ICollection<InvitationForTender> InvitationForTenders { get; set; }
        public virtual ICollection<ProjectDetail> ProjectDetails { get; set; }
        public virtual ICollection<VendorContactPersonInformation> VendorContactPersonInformations { get; set; }
    }
}
