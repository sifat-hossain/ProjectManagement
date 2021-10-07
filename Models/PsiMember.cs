﻿using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class PsiMember
    {
        public PsiMember()
        {
            Psis = new HashSet<Psi>();
        }

        public int PsiMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? PsiMemberCreateDate { get; set; }

        public virtual Project Project { get; set; }
        public virtual UserInformation User { get; set; }
        public virtual ICollection<Psi> Psis { get; set; }
    }
}
