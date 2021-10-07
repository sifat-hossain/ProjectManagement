using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class FinalContractViewModel
    {
        public int FinalContractId { get; set; }
        public int? ProjectId { get; set; }
        public decimal? FinalContractPrice { get; set; }
        public DateTime? ContractOpeningDate { get; set; }
        public string FinalContractAttachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
