using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class InvitationForTenderViewModel
    {
        public int InvitationForTenderId { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? InvitationForTenderDate { get; set; }
        public string InvitationForTenderAttachment { get; set; }
        public string ProjectName { get; set; }
        public string VendorName { get; set; }
    }
}
