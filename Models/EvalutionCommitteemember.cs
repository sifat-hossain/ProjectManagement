using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class EvalutionCommitteemember
    {
        public EvalutionCommitteemember()
        {
            Evalutions = new HashSet<Evalution>();
        }

        public int EvalutionCommitteememberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<Evalution> Evalutions { get; set; }
    }
}
