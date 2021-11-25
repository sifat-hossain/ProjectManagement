using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class InitialNotesheet
    {
        public int InitialNotesheetId { get; set; }
        public DateTime? InitialNoteSheetOpeningDate { get; set; }
        public string InitialNotesheetSubject { get; set; }
        public string InitialNotesheetAttachment { get; set; }
        public int? ProjectId { get; set; }
        public int? VendorId { get; set; }

        public virtual Project Project { get; set; }
        public virtual VendorInformation Vendor { get; set; }
    }
}
