using System;
using System.Collections.Generic;

#nullable disable

namespace ProjectManagement.Models
{
    public partial class Pi
    {
        public int PiId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime Pidate { get; set; }
        public string PiAttachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
