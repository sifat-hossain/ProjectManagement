using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class UserInformationViewModel
    {
      
        public string UserName { get; set; }
        public int DesignationId { get; set; }
        public string DesignationName { get; set; }
        public string PhoneNumber { get; set; }
        public string UserImage { get; set; }
        public string UserEmail { get; set; }
        public int UserDgfiId { get; set; }
        public bool? UserType { get; set; }
        public int? ForceRankId { get; set; }
        public string ForceRankName { get; set; }
        public int UserRoleId { get; set; }
        public string UserRoleName { get; set; }
    }
}
