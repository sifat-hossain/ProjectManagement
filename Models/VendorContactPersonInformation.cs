using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class VendorContactPersonInformation
    {
        public int VendorContactPersonInformationId { get; set; }
        public string VendorContactPersonName { get; set; }
        public int VendorId { get; set; }
        public int VendorContactPersonDesignationId { get; set; }
        public string VendorContactPersonEmail { get; set; }
        public string VendorContactPersonPhone { get; set; }
        public int VendorContactPersonNid { get; set; }
        public string VendorContactPersonImage { get; set; }

        public virtual VendorInformation Vendor { get; set; }
        public virtual VendorContactPersonDesignation VendorContactPersonDesignation { get; set; }
    }
}
