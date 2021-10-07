using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class CostEstimationCommitteeViewModel
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
