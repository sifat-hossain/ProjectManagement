using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class NoaAcceptanceViewModel
    {
        public int NoaAcceptanceId { get; set; }
        public int? NoaId { get; set; }
        public string VendorReply { get; set; }
        public DateTime? NoaAcceptanceDate { get; set; }
        public string NoaAcceptanceAttachment { get; set; }

        public virtual Noa Noa { get; set; }
    }
}
