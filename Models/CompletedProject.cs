using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class CompletedProject
    {
        public int CompletedProjectId { get; set; }
        public string ProjectName { get; set; }
        public DateTime? ContractDate { get; set; }
        public DateTime? WarrantyExpiredDate { get; set; }
        public DateTime? PgexpiredDate { get; set; }
        public string Description { get; set; }
    }
}
