using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Warranty
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
