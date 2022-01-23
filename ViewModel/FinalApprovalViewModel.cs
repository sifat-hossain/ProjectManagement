using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class FinalApprovalViewModel
    {
        public int FinalApprovalId { get; set; }
        public int? ProjectId { get; set; }

        [DataType(DataType.Date)]
        public DateTime? ApprovedDate { get; set; }
        public DateTime? CreateDate { get; set; }
        public int? UserId { get; set; }
        public string FinalApprovalAttachment { get; set; }
        public string ProjectName { get; set; }
        public string UserName { get; set; }
    }
}
