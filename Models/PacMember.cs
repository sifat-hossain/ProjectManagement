using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class PacMember
    {
        public PacMember()
        {
            ProvisionalAcceptances = new HashSet<ProvisionalAcceptance>();
        }

        public int PacMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<ProvisionalAcceptance> ProvisionalAcceptances { get; set; }
    }
}
