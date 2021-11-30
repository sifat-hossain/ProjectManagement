using Microsoft.AspNetCore.Http;
using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class NoaViewModel
    {
        public int NoaId { get; set; }

        [Required(ErrorMessage = "Please Select a Project")]
        public int ProjectId { get; set; }

        public string ProjectName { get; set; }

        [Required (ErrorMessage = "Please Input NOA Code")]
        public string NoaCode { get; set; }

        [DataType(DataType.Date)]
        [Required(ErrorMessage = "Please Pick PG Date")]
        public DateTime? Pgdate { get; set; }

        [Required(ErrorMessage = "Please Input Contract Price")]
        public decimal? FinalContatractPrice { get; set; }

        [Required(ErrorMessage = "Please Input Tender No.")]
        public string TenderNo { get; set; }

        public string NoaAttachment { get; set; }

        [Required(ErrorMessage = "Please Upload Attachment")]
        public IFormFile NoaAttachmentFile { get; set; }

        public virtual Project Project { get; set; }
    }
}
