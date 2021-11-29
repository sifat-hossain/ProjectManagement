using Microsoft.AspNetCore.Http;
using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PsiViewModel
    {
        public int PsiId { get; set; }
        public int? ProjectId { get; set; }
        public string PsiLocation { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PsiStartDate { get; set; }

        [DataType(DataType.Date)]
        public DateTime? PsiEndDate { get; set; }
        public int? PsiDuration { get; set; }
        public string PsiAttachment { get; set; }
        public string ProjectName { get; set; }

        [Required(ErrorMessage = "Please Upload Attachment")]
        public IFormFile PsiAttachmentFile { get; set; }
    }
}
