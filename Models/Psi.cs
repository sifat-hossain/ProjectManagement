using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Psi
    {
        public int PsiId { get; set; }
        public int? ProjectId { get; set; }
        public string PsiLocation { get; set; }
        public DateTime? PsiStartDate { get; set; }
        public DateTime? PsiEndDate { get; set; }
        public int? PsiDuration { get; set; }
        public string PsiAttachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
