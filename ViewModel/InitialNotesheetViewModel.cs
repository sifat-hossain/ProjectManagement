using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class InitialNotesheetViewModel
    {
        public int InitialNotesheetId { get; set; }
        public DateTime? InitialNoteSheetOpeningDate { get; set; }
        public string InitialNotesheetSubject { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }

        public virtual Project Project { get; set; }
        public virtual VendorInformation Vendor { get; set; }
    }
}
