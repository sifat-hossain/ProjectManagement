using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class TenderOpeningViewModel
    {
        public int TenderOpeningId { get; set; }
        public int? ProjectId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TenderOpeningDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? TenderClosingDate { get; set; }
        public decimal? TenderHonorium { get; set; }
        public string ProjectName { get; set; }
        public string TenderOpeningAttachment { get; set; }
        public DateTime? CreateDate { get; set; }

    }
}
