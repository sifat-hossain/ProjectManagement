using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class FinalApproval
    {
        public int FinalApprovalId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? ApprovedDate { get; set; }
        public int? UserId { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
    }
}
