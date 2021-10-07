using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class training
    {
        public int TrainingId { get; set; }
        public int? ProjectId { get; set; }
        public int? TrainingMemberId { get; set; }
        public string TrainingLocation { get; set; }
        public DateTime? TrainingStartDate { get; set; }
        public DateTime? TrainingEndDate { get; set; }
        public int? TrainingDuration { get; set; }
        public decimal? TrainingTaDa { get; set; }
        public string TrainingAttachment { get; set; }

        public virtual Project Project { get; set; }
        public virtual TrainingMember TrainingMember { get; set; }
    }
}
