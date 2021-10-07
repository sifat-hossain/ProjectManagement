using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class ProjectUserViewModel
    {
        public int ProjectUserId { get; set; }
        public int? ProjectId { get; set; }
        public int? BureauId { get; set; }

        public virtual Bureau Bureau { get; set; }
        public virtual Project Project { get; set; }
    }
}
