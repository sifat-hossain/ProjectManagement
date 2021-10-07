using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class WarrantyViewModel
    {
        public int WarrantyId { get; set; }
        public int? ProjectId { get; set; }
        public int? ProductId { get; set; }
        public DateTime? WarrantyStart { get; set; }
        public DateTime? WarrantyEnd { get; set; }

        public virtual Product Product { get; set; }
        public virtual Project Project { get; set; }


    }
}
