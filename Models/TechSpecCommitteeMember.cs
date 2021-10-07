using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class TechSpecCommitteeMember
    {
        public TechSpecCommitteeMember()
        {
            TechSpecCommittees = new HashSet<TechSpecCommittee>();
        }

        public int TechSpecCommitteeMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<TechSpecCommittee> TechSpecCommittees { get; set; }
    }
}
