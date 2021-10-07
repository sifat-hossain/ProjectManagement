using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class TechSpecCommitteeViewModel
    {
        public int TechSpecCommitteeId { get; set; }
        public int? ProjectId { get; set; }
        public int? TechSpecCommitteeMemberId { get; set; }
        public string TechSpecCommitteeAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual TechSpecCommitteeMember TechSpecCommitteeMember { get; set; }
    }
}
