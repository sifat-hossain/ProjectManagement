using ProjectManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectManagement.ViewModel
{
    public class PoViewModel
    {
        public int Poid { get; set; }
        public int? ProjectId { get; set; }
        [DataType(DataType.Date)]
        public DateTime? Podate { get; set; }
        public string Poattachment { get; set; }

        public string ProjectName { get; set; }
    }
}
