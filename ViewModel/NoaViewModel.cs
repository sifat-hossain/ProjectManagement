using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class NoaViewModel
    {
        public int NoaId { get; set; }
        public int? ProjectId { get; set; }
        public string ProjectName { get; set; }

        public string NoaCode { get; set; }
        public DateTime? Pgdate { get; set; }
        public decimal? FinalContatractPrice { get; set; }
        public string TenderNo { get; set; }
        public string NoaAttachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
