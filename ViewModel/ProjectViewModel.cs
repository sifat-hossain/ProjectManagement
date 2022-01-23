using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class ProjectViewModel
    {
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        public string PgdNo { get; set; }
        public string LotNo { get; set; }

        public decimal? ProjectInitialBudget { get; set; }
        public decimal? ProjectFinalBudget { get; set; }

        public string initialBudget { get; set; }
        public string finalBudget { get; set; }
        public string rdppBudget { get; set; }

        public decimal? RDPPBudget { get; set; }


        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Please Pick a Start Date")]
        public DateTime ProjectStartDate { get; set; }

        [DataType(DataType.Date)]
        //[Required(ErrorMessage = "Please Pick an End Date")]
        public DateTime? ProjectEndDate { get; set; }
        public string ProjectDescription { get; set; }
        public string ProjectAttachment { get; set; }
        public int? BureauId { get; set; }
        public string BureauName { get; set; }
      
    }
}
