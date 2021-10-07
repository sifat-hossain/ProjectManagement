using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.DTO
{
    public class ProjectDTO
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public decimal? ProjectInitialBudget { get; set; }
        public decimal? ProjectFinalBudget { get; set; }
        public DateTime ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectAttachment { get; set; }
        public int? BureauId { get; set; }
        public string BureauName { get; set; }
    }
}
