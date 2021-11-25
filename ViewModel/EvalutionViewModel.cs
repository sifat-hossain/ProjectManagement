using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class EvalutionViewModel
    {
        public int EvalutionId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? EvalutionMeetingDate { get; set; }
        public string EvalutionMeetingMinutes { get; set; }
        public string EvalutionReport { get; set; }
        public string BuySellPropose { get; set; }
        public decimal? FinalContractPrice { get; set; }
        public string EvalutionAttachment { get; set; }

        public virtual EvalutionCommitteemember EvalutionCommitteemember { get; set; }
        public virtual Project Project { get; set; }
    }
}
