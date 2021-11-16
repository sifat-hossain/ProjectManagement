using System;
using Microsoft.CodeAnalysis;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Http;

namespace ProjectManagement.ViewModel
{
    public class PiViewModel
    {
        public int PiId { get; set; }

        [Required(ErrorMessage = "Please Select a Project")]
        public int ProjectId { get; set; }
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Please Pick PI Date")]
        public DateTime? Pidate { get; set; }
        public string PiAttachment { get; set; }

        [Required(ErrorMessage = "Please Upload Attachment")]
        public IFormFile PIAttachmentFile { get; set; }
        
    }
}
