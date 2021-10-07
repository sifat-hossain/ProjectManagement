using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class FinalContract
    {
        public int FinalContractId { get; set; }
        public int? ProjectId { get; set; }
        public decimal? FinalContractPrice { get; set; }
        public DateTime? ContractOpeningDate { get; set; }
        public string FinalContractAttachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
