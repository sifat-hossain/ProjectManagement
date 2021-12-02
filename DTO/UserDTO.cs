using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.DTO
{
    public class UserDTO
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string DesignationName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserEmail { get; set; }
        public string UserRoleName { get; set; }
    }
}
