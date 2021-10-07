using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Designation
    {
        public Designation()
        {
            UserInformations = new HashSet<UserInformation>();
        }

        public int DesignationId { get; set; }
        public string DesignationName { get; set; }

        public virtual ICollection<UserInformation> UserInformations { get; set; }
    }
}
