using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class ProjectUser
    {
        public int ProjectUserId { get; set; }
        public int? ProjectId { get; set; }
        public int? BureauId { get; set; }

        public virtual Bureau Bureau { get; set; }
        public virtual Project Project { get; set; }
    }
}
