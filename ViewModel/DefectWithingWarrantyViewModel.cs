using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class DefectWithingWarrantyViewModel
    {
        public int DefectWithingWarrantyId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? InformDate { get; set; }
        public DateTime? SupportStart { get; set; }
        public DateTime? SupportEnd { get; set; }
        public string SupportStatus { get; set; }

        public virtual Product Product { get; set; }
        public virtual Project Project { get; set; }
    }
}
