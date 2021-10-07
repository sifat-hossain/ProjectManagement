using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class VendorContactPersonDesignation
    {
        public VendorContactPersonDesignation()
        {
            VendorContactPersonInformations = new HashSet<VendorContactPersonInformation>();
        }

        public int VendorContactPersonDesignationId { get; set; }
        public string VendorContactPersonDesignationName { get; set; }

        public virtual ICollection<VendorContactPersonInformation> VendorContactPersonInformations { get; set; }
    }
}
