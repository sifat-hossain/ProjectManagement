using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class FacMember
    {
        public FacMember()
        {
            FinalAcceptances = new HashSet<FinalAcceptance>();
        }

        public int FacMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<FinalAcceptance> FinalAcceptances { get; set; }
    }
}
