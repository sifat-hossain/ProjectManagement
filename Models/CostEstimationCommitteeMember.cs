using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class CostEstimationCommitteeMember
    {
        public CostEstimationCommitteeMember()
        {
            CostEstimationCommittees = new HashSet<CostEstimationCommittee>();
        }

        public int CostEstimationCommitteeMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CostEstimationCommitteeMemberCreateDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<CostEstimationCommittee> CostEstimationCommittees { get; set; }
    }
}
