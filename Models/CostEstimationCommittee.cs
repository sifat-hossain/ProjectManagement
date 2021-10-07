using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class CostEstimationCommittee
    {
        public int CostEstimationCommitteeId { get; set; }
        public int? ProjectId { get; set; }
        public int? CostEstimationCommitteeMemberId { get; set; }
        public DateTime? CostEstimationCommitteeOpeningDate { get; set; }
        public decimal? EstimatedCost { get; set; }
        public string CostEstimationCommitteeAttachment { get; set; }

        public virtual CostEstimationCommitteeMember CostEstimationCommitteeMember { get; set; }
        public virtual Project Project { get; set; }
    }
}
