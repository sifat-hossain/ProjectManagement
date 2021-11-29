using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class FinalAcceptanceViewModel
    {
        public int FinalAcceptanceId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProductId { get; set; }
        public string FinalAcceptanceStatus { get; set; }
        public DateTime? FinalAcceptanceDate { get; set; }
        public int? FacMemberId { get; set; }
        public virtual FacMember FacMember { get; set; }
        public virtual Product Product { get; set; }
        public virtual Project Project { get; set; }
    }
}
