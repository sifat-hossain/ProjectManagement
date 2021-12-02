using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PsiMemberViewModel
    {
        public int PsiMemberId { get; set; }
        public int? UserId { get; set; }
        public int? ProjectId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PsiMemberCreateDate { get; set; }

        public string ProjectName { get; set; }
        public string UserName { get; set; }
    }
}
