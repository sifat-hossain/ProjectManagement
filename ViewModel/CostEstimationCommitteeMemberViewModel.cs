using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class CostEstimationCommitteeMemberViewModel
    {
        public int CostEstimationCommitteeMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? CostEstimationCommitteeMemberCreateDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
    }
}
