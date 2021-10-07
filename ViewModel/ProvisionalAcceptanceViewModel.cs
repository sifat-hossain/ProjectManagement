using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class ProvisionalAcceptanceViewModel
    {

        public int ProvisionalAcceptanceId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProductId { get; set; }
        public string AcceptanceStatus { get; set; }
        public DateTime? ProvisionalAcceptance1 { get; set; }
        public int? PacMemberId { get; set; }

        public virtual PacMember PacMember { get; set; }
        public virtual Product Product { get; set; }
        public virtual Project Project { get; set; }
    }
}
