using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class UserRole
    {
        public UserRole()
        {
            UserInformations = new HashSet<UserInformation>();
        }

        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }

        public virtual ICollection<UserInformation> UserInformations { get; set; }
    }
}
