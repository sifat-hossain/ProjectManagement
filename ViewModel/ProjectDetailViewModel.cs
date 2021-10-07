using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class ProjectDetailViewModel
    {
        public int ProjectDetailId { get; set; }
        public int? ProjectId { get; set; }
        public int? UserId { get; set; }
        public int? VendorId { get; set; }
        public int? PgdwithProductId { get; set; }

        public virtual PgdwithProduct PgdwithProduct { get; set; }
        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual VendorInformation Vendor { get; set; }
    }
}
