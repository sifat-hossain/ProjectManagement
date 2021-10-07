using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Evalution
    {
        public int EvalutionId { get; set; }
        public int? ProjectId { get; set; }
        public int? EvalutionCommitteememberId { get; set; }
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
