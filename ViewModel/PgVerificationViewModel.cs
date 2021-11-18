using Microsoft.AspNetCore.Http;
using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PgVerificationViewModel
    {
        public int PgVerificationId { get; set; }
        public int? NoaId { get; set; }
        public int? PgVerificationStatus { get; set; }
        public decimal? PgPrice { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PgOpeningDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? PgExpireDate { get; set; }
        public string PgVerificationAttachment { get; set; }
        public string NoaCode { get; set; }
        public string ProjectName { get; set; }
        public IFormFile PGVerificationAttachmentFile { get; set; }
    }
}
