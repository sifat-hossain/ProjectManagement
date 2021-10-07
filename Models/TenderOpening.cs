using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class TenderOpening
    {
        public int TenderOpeningId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? TenderOpeningDate { get; set; }
        public DateTime? TenderClosingDate { get; set; }
        public decimal? TenderHonorium { get; set; }

        public virtual Project Project { get; set; }
    }
}
