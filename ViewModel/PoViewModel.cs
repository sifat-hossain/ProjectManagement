using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PoViewModel
    {
        public int Poid { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? Podate { get; set; }
        public string Poattachment { get; set; }

        public virtual Project Project { get; set; }
    }
}
