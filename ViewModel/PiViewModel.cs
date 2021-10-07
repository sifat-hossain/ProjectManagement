using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PiViewModel
    {
        public int PiId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? Pidate { get; set; }
        public string PiAttachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
