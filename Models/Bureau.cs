using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Bureau
    {
        public Bureau()
        {
            ProjectUsers = new HashSet<ProjectUser>();
            Projects = new HashSet<Project>();
        }

        public int BureauId { get; set; }
        public string BureauName { get; set; }
        public string BureauFullName { get; set; }

        public virtual ICollection<ProjectUser> ProjectUsers { get; set; }
        public virtual ICollection<Project> Projects { get; set; }
    }
}
