using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PsiViewModel
    {
        public int PsiId { get; set; }
        public int? ProjectId { get; set; }
        public int? PsiMemberId { get; set; }
        public string PsiLocation { get; set; }
        public DateTime? PsiStartDate { get; set; }
        public DateTime? PsiEndDate { get; set; }
        public int? PsiDuration { get; set; }
        public string PsiAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual PsiMember PsiMember { get; set; }
    }
}
