using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class InitialNotesheetViewModel
    {      
        public int InitialNotesheetId { get; set; }

        [Required(ErrorMessage ="Please input opening date")]
        [DataType(DataType.Date)]
        public DateTime? InitialNoteSheetOpeningDate { get; set; }
      
        public string InitialNotesheetSubject { get; set; }
        public string InitialNotesheetAttachment { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }

        public string ProjectName { get; set; }
        public string VendorName { get; set; }
    }
}
