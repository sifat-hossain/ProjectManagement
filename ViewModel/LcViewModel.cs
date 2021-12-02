using Microsoft.AspNetCore.Http;
using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class LcViewModel
    {
        public int Lcid { get; set; }

        [Required(ErrorMessage = "Please Select a Project")]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Please Pick a Date")]
        [DataType(DataType.Date)]
        public DateTime? LcopeningDate { get; set; }

        [Required(ErrorMessage = "Please Input Bank")]
        public string NominatedBank { get; set; }

        [Required(ErrorMessage = "Please Select an Option")]
        [Display(Name = "Payment Process")]
        public string PaymentProcess { get; set; }
        public string LcAttachment { get; set; }

        [Required(ErrorMessage = "Please Upload Attachment")]
        public IFormFile LCAttachmentFile { get; set; }
        public virtual Project Project { get; set; }
    }
}
