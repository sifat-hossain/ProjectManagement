using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class UserLogin
    {
        public int LoginId { get; set; }
        public int? UserId { get; set; }
        public int? UserDgfiId { get; set; }
        public string UserPassword { get; set; }

        public virtual UserInformation User { get; set; }
    }
}
