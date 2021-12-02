using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class CompletedProject
    {
        public int CompletedProjectId { get; set; }
        public string ProjectName { get; set; }
        [DataType(DataType.Date)]
        public DateTime? ContractDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? WarrantyExpiredDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PgexpiredDate { get; set; }
        public string Description { get; set; }
    }
}
