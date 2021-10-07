using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class UserLoginViewModel
    {
        public int LoginId { get; set; }
        public int? UserId { get; set; }
        public int? UserDgfiId { get; set; }
        public string UserPassword { get; set; }

        public virtual UserInformation User { get; set; }

    }
}
