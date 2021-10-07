using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class TechSpecCommittee
    {
        public int TechSpecCommitteeId { get; set; }
        public int? ProjectId { get; set; }
        public int? TechSpecCommitteeMemberId { get; set; }
        public string TechSpecCommitteeAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual TechSpecCommitteeMember TechSpecCommitteeMember { get; set; }
    }
}
