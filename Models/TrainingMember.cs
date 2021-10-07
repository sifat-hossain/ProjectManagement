using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class TrainingMember
    {
        public TrainingMember()
        {
            training = new HashSet<training>();
        }

        public int TrainingMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<training> training { get; set; }
    }
}
